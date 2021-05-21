using System;

namespace DecoratorPattern {
    class Program {
        static void Main(string[] args) {

            IDrank Koffie = new Koffie();
            IDrank KoffieMetMelk = new Melk(new Koffie());
            IDrank KoffieMetSuiker = new Suiker(new Koffie());
            IDrank KoffieMetMelkMetSuiker = new Melk(new Suiker(new Koffie()));

            Console.WriteLine(Koffie.getOmschrijving());
            Console.WriteLine(Koffie.getPrijs());

            Console.WriteLine(KoffieMetMelk.getOmschrijving());
            Console.WriteLine(KoffieMetMelk.getPrijs());

            Console.WriteLine(KoffieMetSuiker.getOmschrijving());
            Console.WriteLine(KoffieMetSuiker.getPrijs());

            Console.WriteLine(KoffieMetMelkMetSuiker.getOmschrijving());
            Console.WriteLine(KoffieMetMelkMetSuiker.getPrijs());
        }
    }
}
