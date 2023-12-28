using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksiegarnia_klasyczna.Model
{
    internal class Ksiazka
    {
        // pola Książki - isbn (id), cena, liczba stron, rok wydania, autor, tytuł
        // konstruktor książki
        // podstawowa logika książki np. Poprawna forma tytułu, poprawnie nadanie ceny, zmiana ceny

        public string ISBN { get; set; }
        public decimal Cena { get; set; }
        public int LiczbaStron { get; set; }
        public string Autor { get; set; }
        public string Tytul { get; set; }
        public string Gatunek { get; set; }

        public Ksiazka(string isbn, decimal cena, int liczbaStron, string autor, string tytul, string gatunek)
        {
            ISBN = poprawISBN(isbn);
            Cena = poprawCene(cena);
            LiczbaStron = poprawLiczbeStron(liczbaStron);
            Autor = usunBialeZnaki(autor);
            Tytul = usunBialeZnaki(tytul);
            Gatunek = usunBialeZnaki(gatunek);
        }

        private string poprawISBN(string tekst)
        {
            if (tekst.Length == 13)
            {
                return tekst;
            }
            else
            {
                throw new ArgumentException("ISBN musi mieć 13 znaków");
            }
        }

        private string usunBialeZnaki(string tekst)
        {
            return tekst.Trim(); //' asdasd ' -> 'asdasd'
        }

        private decimal poprawCene(decimal cena)
        {
            if (cena > 0)
            {
                return cena;
            }
            else
            {
                throw new ArgumentException("Nieprawidłowa cena");
            }
        }

        private int poprawLiczbeStron(int liczbastron)
        {
            if (liczbastron > 0)
            {
                return liczbastron;
            }
            else
            {
                throw new ArgumentException("Liczba stron musi wynosić przynajmniej 1");
            }
        }
    }
}
