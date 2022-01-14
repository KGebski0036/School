using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        private List<Client> clients_ = new List<Client>();
        private List<Account> accounts_ = new List<Account>();

        public uint AddClient(Client client)
        {
            Console.WriteLine($"Dodano klienta {client.Name_} {client.Nazwisko_}.");
            clients_.Add(client);
            return (uint)clients_.Count - 1;
        }
        public uint CreateAccount(uint ownerId, uint pin, string haslo, uint number)
        {
            Console.WriteLine($"Dodano konto {number}.");
            accounts_.Add(new Account(pin, haslo, number, clients_[(int)ownerId]));
            return (uint)accounts_.Count - 1;
        }

        public void Wplata(uint nrKonta, double kwota)
        {
            Console.WriteLine($"Zarejestrowano wpłatę na konto {nrKonta} w wysokości {kwota}");
            accounts_[(int)nrKonta].Wplata(kwota);
        }
        public bool Wyplata(uint nrKonta, double kwota)
        {
            if (accounts_[(int)nrKonta].is_zalogowany())
            {
                Console.WriteLine($"Zarejestrowano wypłatę z konta {nrKonta} w wysokości {kwota}");
                return accounts_[(int)nrKonta].Wyplata(kwota);
            }
            Console.WriteLine("Nie można wypłacić bez zalogowania");
            return false;
            
        }
        public bool Przelew(uint nrKontaOd, uint nrKontaDo, double kwota)
        {
            if (accounts_[(int)nrKontaOd].is_zalogowany() && accounts_[(int)nrKontaDo].is_zalogowany())
            {
                if (accounts_[(int)nrKontaOd].Wyplata(kwota))
                {
                    accounts_[(int)nrKontaDo].Wplata(kwota);
                    return true;
                }
            }
            return false;
        }
        public void Zaloguj(uint nrKonta)
        {
            Console.WriteLine($"Wpisz haslo do konta nr {nrKonta}");
            string haslo = Console.ReadLine();
            accounts_[(int)nrKonta].Zaloguj(haslo);
        }

        public void PokazKlijentow()
        {
            Console.Write("--------------------------");
            foreach(Account it in accounts_)
            {
                it.Informacja();
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }


    }
}
