using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Windows.Forms;
using TextFileProcessing;
using TextFileProcessing.Exceptions;

namespace AverageExchangeRate
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Set up global exception handling
			Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

			Log.Logger = new LoggerConfiguration()
				.WriteTo.File("logs.txt", rollingInterval: RollingInterval.Day)
				.CreateLogger();


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var services = ConfigureServices();

			using (var serviceProvider = services.BuildServiceProvider())
			{
				var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
				Log.Information("Program starts");
				Application.Run(mainWindow);
			}
		}

		private static IServiceCollection ConfigureServices()
		{
			var services = new ServiceCollection();

			services.AddTransient<MainWindow>();

			return services;
		}

		private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			HandleException(e.Exception);
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			var exception = e.ExceptionObject as Exception;

			HandleException(exception);
		}

		private static void HandleException(Exception e)
		{

			if (e is TextFileProcessingBaseException)
			{
				Log.Information(e, "Handled exception caught");
				MessageBox.Show(e.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Log.Error(e, "Unandled exception caught");

				if (e != null)
				{
					MessageBox.Show($"An unexpected error occurred: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("An unexpected error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
