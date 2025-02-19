Podsumowanie:
1. Zrealizowano wszystkie wymagane funkcjonalności
  a. Pole tekstowe do wprowadzenia ścieżki do pliku tekstowego.
  b. Przycisk do wczytania pliku tekstowego.
  c. Tabela lub lista do wyświetlania wyników analizy (liczba słów, zdań i znaków).
2. Zrealizowane dodatkowe wymagania
   a. Obsługa błędów.
   b. Czytelny i intuicyjny interfejs użytkownika. (W mojej opinii)
3. Wprowadzone dodatkowe usprawnienia
   a. Wprowadzenie podstawowych logów, w celu prezentacji znajomości tych mechanizmów
   b. Wprowadzenie Dependency Injection
   c. Wprowadzenie dedykowanych Exception w celu rozróżnienia obsługiwanych (oczekiwanych) błędów oraz tych nieobsługiwanych.
   d. Struktura kodu pozwala na proste wprowadzanie kolejnych możliwości przetwarzania pliku 
   e. UI pozwala na wybór metod przetwarzania - prezentacja dynamicznej obsługi wybranych strategii (Interfejs: ITextDataProcessingStrategy)
   f. Wprowadzenie testów jednoskowych (m.in. użycie Moq)
   g. Struktura kodu pozwala na proste wprowadzenie innych możliwości dostarczania danych tesktowych (np. API, baza danych) (Interfejs: ITextDataProvider)
   h. Struktura kodu pozwala na łatwe tworzenie Unit Testów (bez zbędnych zależności)
5. Możliwości poprawy/rozwoju
   a. Może wprowadzenie możliwości czytania opcji przetwarzania np. z pliku konfiguracyjnego
   b. Wprowadzenie progress bar
