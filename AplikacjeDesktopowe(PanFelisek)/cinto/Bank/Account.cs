using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        private List<Client> owners_ = new List<Client>();

        protected double saldo_;
        protected uint number_;
        protected uint pin_;
        protected string haslo_;

        protected bool zalogowany_ = false;

        public bool is_zalogowany()
        {
            return zalogowany_;
        }
        public Account(uint pin, string haslo, uint number, Client owner)
        {
            pin_ = pin;
            haslo_ = haslo;
            number_ = number;
            owners_.Add(owner);
        }
        public void Zaloguj(string haslo)
        {
            if(haslo == haslo_)
            {
                Console.WriteLine("Udało Ci się zalogować.");
                zalogowany_ = true;
                return;
            }

            Console.WriteLine($"Nie udało Ci się zalogować. (Prawidłowe: {haslo_})");
            zalogowany_ = false;

        }
        public void wyloguj()
        {
            Console.WriteLine("Zostałeś wylogowany.");
            zalogowany_ = false;
        }

        public void Informacja()
        {
            Console.WriteLine($"\nKonto nr: {number_}\n saldo: {saldo_} \n Właściciele:");
            foreach(Client it in owners_)
            {
                Console.Write(it.Name_ + " " + it.Nazwisko_ + "   \n");
            }
        }
        public void Wplata(double kwota)
        {
            Console.WriteLine($"Wpłata na konto {number_} w wysojosci {kwota}.");
            saldo_ += kwota;
        }
        public bool Wyplata(double kwota)
        {
            if(saldo_ > kwota)
            {
                saldo_ -= kwota;
                return true;
            }
            Console.WriteLine($"Wpłata niemożliwa (brak środków na koncie). Stan konta: {saldo_}");
            return false;
            
        }
    }
}
