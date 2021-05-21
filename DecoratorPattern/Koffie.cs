using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern {
    public class Koffie : IDrank {

        public string getOmschrijving() {
            return "Koffie";
        }

        public double getPrijs() {
            return 1.5;
        }
    }
}
