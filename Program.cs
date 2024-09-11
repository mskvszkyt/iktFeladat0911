using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool szabalyos(string input)
            {
                bool vege;
                while (input.Length != 0)
                {
                    vege = false;
                    for (int i = 0; i < input.Length - 1; i++)
                    {
                        if (input[i] == '(' && input[i + 1] == ')')
                        {
                            input = input.Substring(0, i) + input.Substring(i + 2);
                            vege = true;
                        }
                    }
                    if (!vege) return false;

                }
                return true;
            }

            List<string> sorok = File.ReadAllLines("input.txt").ToList();
            Console.WriteLine(sorok.Count(n => szabalyos(n)));
            Console.WriteLine(sorok.Count(n => n.isValid()));

            List<Szemely> szemelyek = File.ReadLines("people.csv").Select(n => new Szemely(n)).ToList();


            Console.WriteLine($"Legfiatalabb: {szemelyek.MinBy(n => n.Age).FName} {szemelyek.MinBy(n => n.Age).LName}, {szemelyek.MinBy(n => n.Age).Age} éves");
            Console.WriteLine($"Legfiatalabb: {szemelyek.MaxBy(n => n.Age).FName} {szemelyek.MaxBy(n => n.Age).LName}, {szemelyek.MaxBy(n => n.Age).Age} éves");
            Console.WriteLine($"Átlag: {szemelyek.Average(n => n.Age)}");

            List<Dog> kutyak = File.ReadLines("dogs.csv").Select(n => new Dog(n)).ToList();

            foreach (Dog dog in kutyak)
            {
                foreach (Szemely szemely in szemelyek)
                {
                    if (szemely.Id == dog.OwnerId)
                    {
                        szemely.kutyak.Add(dog);
                    }
                }
            }

            Console.WriteLine($"{szemelyek.MaxBy(n => n.kutyak.Count).FName} {szemelyek.MaxBy(n => n.kutyak.Count).LName} has {szemelyek.MaxBy(n => n.kutyak.Count).kutyak.Count} dog(s)");



        }
    }
}