using System;

namespace OOPNotes {
    class Volvo {
        public bool safetyFeature = true;
        private string model;

        public Volvo(string model) { // constructor
            this.model = model;
        }

        public string ReturnModel() { // getter method b/c of private variable.
            return model;
        }
    }
}