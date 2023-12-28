using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksiegarnia_klasyczna.Model
{
    internal class Transakcja
    {
        // pola Transakcja
        // konstruktor transakcji
        // podstawowa logika transakcji


        public string Guid { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }
        public int ID_Klienta { get; } // program podaje jakieś ID autora traksajcji (nie wiem jakie, coś sztucznego, nie budujemy systemu bakowego) po tym ID możemy (ALE NIE BĘDZIEMY TEGO ROBIĆ) rozpoznać dane klienta.
        public string NumerKonta { get; } // Numer rachunku bankowego Klienta
        public bool CzyBylZwrot { get; } // jeżeli na podstawie tej transakcji wystąpił zwrot, to zmieniamy na true. Przy najstępnej próbie gdyby klient chciał znowu wypłacić, to mówimy - już był zwrot. Założenie: na jedną transakcję można zrobić jeden zwrot, raz 

        public List<Dictionary<int, string>> PodsumowanieZamowienia = new();



        public Transakcja(decimal amount, DateTime date, string note, int id_autora)
        {
            this.Guid = "1234"; // <- jak wygenerować GUID w C#
            this.Amount = amount;
            this.Date = date; // teraz <- pobierz aktualny timestamp podczas wpisywania tej wartości
            this.Note = note;
            this.ID_Klienta = id_autora;
            this.CzyBylZwrot = false;
        }
    }
}
