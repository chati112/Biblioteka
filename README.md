Aplikacja służy do obsługi biblioteki. Zawiera obsługę plików binarnych, z których są odczytywane i do których zapisywane są dane. Korzystając z tej aplikacji pracownik może zarządzać zbiorami małej biblioteki: 
- aktualizować stan książek, 
-tworzyć bazę czytelników, 
- zarządzać wypożyczeniami,
- wyświetlać statystyki i generować raport do pliku .txt

Aplikacja posiada główny widok „Menu” z którego pracownik może przejść do: 
•	bazy lektur,
•	bazy czytelników,
•	bazy wypożyczeń,
•	raportu.
![image](https://github.com/chati112/Biblioteka/assets/133596038/41a05b0e-2518-4521-aa6a-95e36818e997)


Widok bazy lektur
W powyższym widoku pracownik po podaniu wszystkich danych lektury może dodać ją do bazy lektur. W zależności od wybranej opcji w RadioButton (Ksiażka/Czasopismo) dla książki zostaje dodany NrISBN, a dla czasopisma NrISSN. Użytkownik może też usuwać i edytować lektury znajdujące się w bibliotece.  Po dodaniu lektury z kategorii wiekowej „Dorośli” zostaje ona wyróżniona odpowiednim kolorem. Widok ten posiada także opcje filtrowania zbiorów biblioteki. 
![image](https://github.com/chati112/Biblioteka/assets/133596038/0c69875f-8611-4122-901f-c521d03f1f33)


Widok bazy czytelników
Widok ten odpowiada za czytelników biblioteki. Posiada trzy funkcjonalności czyli dodawanie, edycja i usuwanie czytelników w bibliotece.
![image](https://github.com/chati112/Biblioteka/assets/133596038/9f6dabf9-103f-4c71-bf10-b306cae69f5c)


Widok wypożyczeń
W tym widoku pracownik może dodawać, edytować i usuwać wypożyczenia. Dane w „ComboBox Lektura” i „ComboBox Czytelnik” są pobierane na podstawie listy książek, czasopism i czytelników. 
![image](https://github.com/chati112/Biblioteka/assets/133596038/81c0d651-ec5e-40c0-b7c0-6b3a6fe94b7b)


Okno raportu
Zawiera aktualne statystyki biblioteki (ilość książek, czasopism i czytelników). Po naciśnięciu przycisku „Generuj raport do pliku .txt” generuje się raport, który jest zapisywany w pliku .txt w folderze „Pliki”.
![image](https://github.com/chati112/Biblioteka/assets/133596038/036eea41-e641-4bb1-a9ce-d0669390dd3a)





Model dziedziny

![image](https://github.com/chati112/Biblioteka/assets/133596038/e296603b-b548-429e-965e-96f52fba7452)

1.	Klasa "Książka"  dziedziczy po klasie Lektura i reprezentuje książkę w bibliotece. Zawiera dodatkowe informacje dotyczące numeru ISBN. Klasa zawiera metody umożliwiające dodawanie, edytowanie i usuwanie książek. 
Atrybuty:
•	NumerISBN (właściwość typu string): Numer ISBN książki.
•	ksiazki (publiczna statyczna lista typu List<Ksiazka>): Lista zawierająca wszystkie książki.
Metody: 
•	DodajKsiazke (metoda wewnętrzna statyczna): Dodaje nową książkę do listy ksiazki.
•	UsunKsiazke (metoda wewnętrzna statyczna): Usuwa podaną książkę z listy ksiazki.
•	EdytujKsiazke (metoda wewnętrzna statyczna): Edytuje istniejącą książkę na podstawie podanego indeksu. Aktualizuje wartości pól Tytuł, Autor, RokWydania, Wydawnictwo, IlośćDostępnychSztuk oraz NumerISBN.

2.	Klasa "Czytelnik" reprezentuje czytelnika w bibliotece. Przechowuje informacje dotyczące imienia, nazwiska, roku urodzenia, numeru karty bibliotecznej oraz wieku czytelnika. Klasa zawiera również metody umożliwiające dodawanie, edytowanie i usuwanie czytelników.
Atrybuty:
•	imie (publiczne pole typu string): Imię czytelnika.
•	nazwisko (publiczne pole typu string): Nazwisko czytelnika.
•	rokUrodzenia (publiczne pole typu int): Rok urodzenia czytelnika.
•	NrKartyBibliotecznej (publiczne pole typu long): Numer karty bibliotecznej czytelnika.
•	czytelnicy (publiczna statyczna lista typu List<Czytelnik>): Lista zawierająca wszystkich czytelników.
•	nr (publiczne pole statyczne typu long): Licznik służący do generowania unikalnych numerów kart bibliotecznych.
Metody:
•	ToString (przesłonięta metoda ToString): Zwraca reprezentację tekstową czytelnika w formacie "NumerKarty : Imie Nazwisko".

3.	Klasa "Lektura" Klasa abstrakcyjna, jest klasą bazową dla różnych rodzajów lektur w bibliotece. Zawiera podstawowe informacje dotyczące tytułu, autora, roku wydania, wydawnictwa, ilości dostępnych sztuk, identyfikatora lektury oraz kategorii wiekowej. Klasa jest abstrakcyjna, co oznacza, że nie może być bezpośrednio instancjonowana. Wszystkie jej instancje są tworzone poprzez dziedziczące klasy.
Atrybuty:
•	tytuł (publiczne pole typu string): Tytuł lektury.
•	autor (publiczne pole typu string): Autor lektury.
•	rokWydania (publiczne pole typu int): Rok wydania lektury.
•	wydawnictwo (publiczne pole typu string): Wydawnictwo lektury.
•	ilośćDostępnychSztuk (publiczne pole typu int): Ilość dostępnych sztuk lektury.
•	idLektury (publiczne pole typu int): Identyfikator lektury.
•	kategoriaWiekowa (publiczne pole typu KategoriaWiekowa): enum KategoriaWiekowa (.
•	id (publiczne pole statyczne typu int): Licznik służący do generowania unikalnych identyfikatorów lektur.
Metody: 
•	ToString (przesłonięta metoda ToString): Zwraca reprezentację tekstową lektury w formacie "Tytuł Autor RokWydania".

4.	Klasa "Wypożyczenie" reprezentuje wypożyczenie lektury przez czytelnika. Przechowuje informacje dotyczące identyfikatora wypożyczenia, daty wypożyczenia i zwrotu, czytelnika, lektury oraz ilości wypożyczonych egzemplarzy. Klasa zawiera również metody umożliwiające dodawanie, edytowanie i usuwanie wypożyczeń.
Atrybuty:
•	id_Wypożyczenia (publiczne pole typu int): Unikalny identyfikator wypożyczenia.
•	dataWypozyczenia (publiczne pole typu DateTime): Data wypożyczenia lektury.
•	dataZwrotu (publiczne pole typu DateTime): Data planowanego zwrotu lektury.
•	czytelnik (publiczne pole typu Czytelnik): Obiekt reprezentujący czytelnika, który wypożyczył lekturę.
•	lektura (publiczne pole typu Lektura): Obiekt reprezentujący wypożyczoną lekturę.
•	ilosc (publiczne pole typu int): Ilość wypożyczonych egzemplarzy.
•	wypozyczenia (publiczna statyczna lista typu List<Wypozyczenie>): Lista zawierająca wszystkie wypożyczenia.
•	id (publiczne pole statyczne typu int): Licznik służący do generowania unikalnych identyfikatorów wypożyczeń.
Metody:
•	CzasWypozyczenia (publiczna właściwość typu TimeSpan): Właściwość tylko do odczytu, zwracająca czas trwania wypożyczenia. Jeśli data zwrotu została ustawiona, oblicza różnicę między datą zwrotu a datą wypożyczenia. W przeciwnym razie, oblicza różnicę między aktualną datą a datą wypożyczenia.
•	DodajWypozyczenie (publiczna statyczna metoda): Dodaje nowe wypożyczenie do listy wypozyczenia.
•	EdytujWypozyczenie (publiczna statyczna metoda): Edytuje istniejące wypożyczenie na podstawie podanego indeksu. Aktualizuje wartości pól dataWypozyczenia, dataZwrotu, czytelnik, lektura i ilosc.
•	UsuńWypozyczenie (publiczna statyczna metoda): Usuwa podane wypożyczenie z listy wypozyczenia.

5.	Klasa "Czasopismo" dziedziczy po klasie Lektura i reprezentuje czasopismo w bibliotece. Posiada dodatkowe pole NumerISSN, które przechowuje numer identyfikacyjny czasopisma. Klasa zawiera również metody umożliwiające dodawanie, edytowanie i usuwanie czasopism.
Atrybuty:
•	NumerISSN (publiczne pole typu string): Numer identyfikacyjny czasopisma.
•	czasopisma (publiczna statyczna lista typu List<Czasopismo>): Lista zawierająca wszystkie czasopisma.
Metody:
•	DodajCzasopismo (publiczna statyczna metoda): Dodaje nowe czasopismo do listy czasopisma.
•	UsunCzasopismo (publiczna statyczna metoda): Usuwa podane czasopismo z listy czasopisma.
•	EdytujCzasopismo (publiczna statyczna metoda): Edytuje istniejące czasopismo na podstawie podanego indeksu. Aktualizuje wartości pól Tytuł, Autor, RokWydania, Wydawnictwo, IlośćDostępnychSztuk, NumerISSN oraz Id.


