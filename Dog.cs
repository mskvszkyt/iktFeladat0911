using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dog
    {
        string nev;
        string fajta;
        string eletkor;
        string ownerId;

        public Dog(string nev, string fajta, string eletkor, string ownerId)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.eletkor = eletkor;
            this.ownerId = ownerId;
        }

        public Dog(string sor)
        {
            string[] tagok = sor.Split(';');
            this.nev = tagok[0];
            this.fajta = tagok[1];
            this.eletkor = tagok[2];
            this.ownerId = tagok[3];
        }

        public string Nev { get => nev; }
        public string Fajta { get => fajta; }
        public string Eletkor { get => eletkor; }
        public string OwnerId { get => ownerId; }
    }
}
