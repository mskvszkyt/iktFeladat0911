using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Szemely
    {
        string fName;
        string lName;
        int age;
        string id;
        public List<Dog> kutyak = [];

        public Szemely(string fName, string lName, string id)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = Convert.ToInt32(id.Split('-')[1]);
            this.id = id;
        }

        public Szemely(string sor)
        {
            string[] tagok = sor.Split(";");
            this.fName = tagok[0];
            this.lName = tagok[1];
            this.age = Convert.ToInt32(tagok[2].Split('-')[1]);
            this.id = tagok[2];
        }

        public string FName { get => fName; }
        public string LName { get => lName; }
        public int Age { get => age; }
        public string Id { get => id; }
        internal List<Dog> Kutyak { get => kutyak; }
    }
}
