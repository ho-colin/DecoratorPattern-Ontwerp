using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class Suiker : IDrank {

        private readonly IDrank Drank;

        public Suiker(IDrank drank) {
            this.Drank = drank;
        }

        public string getOmschrijving() {
            return Drank.getOmschrijving() + ", met suiker";
        }

        public double getPrijs() {
            return Drank.getPrijs() + 0.2;
        }
    }
}
