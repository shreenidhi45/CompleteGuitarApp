using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteGuitarApp.Model
{
    internal class GuitarSpec
    {
       
        public Builder builder { get; }
        public string model { get; }
        public Type type { get; }
        public Wood backWood { get; }
        public Wood topWood { get; }
       public int numStrings { get; }
        
        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numStrings)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
            this.numStrings = numStrings;
        }

        public bool matches(GuitarSpec spec)
        {
            // Ignore serial # since that's unique
            // Ignore price since that's unique

            // Check if matches fail
            if (builder != spec.builder) { return false; }
            if (!stringsMatch(model, spec.model)) { return false; }
            if (type != spec.type) { return false; }
            if (backWood != spec.backWood) { return false; }
            if (topWood != spec.topWood) { return false; }

            return true;
        }
       
        private bool stringsMatch(string stringA,
                                  string stringB)
        {
            if (!string.IsNullOrEmpty(stringA) &&
                !string.IsNullOrEmpty(stringB) &&
                string.Compare(stringA, stringB) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
