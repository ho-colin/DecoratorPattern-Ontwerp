using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class Melk : IDrank {
        private readonly IDrank Drank;

        public Melk(IDrank drank) {
            this.Drank = drank;
        }

        public string getOmschrijving() {
            return Drank.getOmschrijving() + ", met melk";
        }

        public double getPrijs() {
            return Drank.getPrijs() + 0.1;
        }

    }
}
