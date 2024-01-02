// -- tworzyć obiekt zasymuluj baza książek 
// -- tworzyć obiek zasymuluj baza transakcji
using ksiegarnia_klasyczna.Controller;
using ksiegarnia_klasyczna.Model;


//List<Gatunek> listaKsiazekWCalejKsiegarni = bazaGatunkow.ListaGatunkow; // taka zmienna, która w całym programie będzie powoałana tylko jeden raz


// wywołanie menu głównego
// View -> menu główne(listaKsiazekWCalejKsiegarni, listaTransakcji)



// poniżej lista rzeczy które wg mnie najsensowniej byłoby zrobić w pierwszej kolejności żeby uzyskać jakikolwiek działający program

// 1 modele - póki co pola, nawet bez logiki - zacząłem i mam zamiar to wstępnie skończyć dzisiaj lub w piątek

// 2 symulacja baz danych -> ZasymulujBaze
// List<Ksiazka> listaKsiazek = new List<Ksiazka> () {};
// listaKsiazek.Add(new Ksiazka('nazwa', 'gatunek', iloscStron, 'okladka'));
// albo
// List<Ksiazka> listaKsiazek = new List<Ksiazka> () {
//  new Ksiazka('nazwa', 'gatunek', iloscStron, 'okladka')),
//  new Ksiazka('nazwa', 'gatunek', iloscStron, 'okladka'))
// };
// 

// 3 określić logike programu, co jest minimalną logiką którą ma robić program

// 4 napisanie pod to min. menu

// 5 dodawanie logiki

//potem dopiero będziemy się martwić dodawaniem kolejnych funkcji i spełnianiem wymogów z moodle




//
//--MENU--
//  
//  -Znajdź książkę
//      -Pole wyszukiwania po tytule, autorze, nr isbn wyświetlające wszystkie dane ksiązki
//          -Zaktualizuj dane dot książki
//  -Wyświetl listę książek
//      -Po gatunku
//      -Po autorze
//      -Po cenie
//      -Po tytule
//      -Po liczbie stron
//  -Dodaj istniejące książki
//  -Dodaj nową książkę
//      -Formularz dodawania ksiązki do bazy danych
//  -Zaktualizuj dane dot książki [2]
//  -Sprzedaż
//  -Zwrot
//  -Raporty
//      -Raport sprzedaży
//  -Lista transakcji (sprzedaży i zwrotów)
//
//
//
//
//