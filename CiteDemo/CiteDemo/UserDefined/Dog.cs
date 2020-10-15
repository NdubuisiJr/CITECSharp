using System.Collections.Generic;

namespace CiteDemo.UserDefined {
    class Dog : Animal {
        public Dog(string breed) {
            Breed = breed;
            Color = "Brown";
        }

        public Dog(int age) {
            Age = age;
        }

        public Dog(int age, string breed) {
            Age = age;
            Breed = breed;
        }
        // 1 -10
        int hungerLevel;//Field
        int wickednessLevel;//Field

        public void Feed(int amount) { // Methods
            if (hungerLevel - amount < 1 || wickednessLevel-amount < 1) {
                return;
            }
            hungerLevel -= amount;
            wickednessLevel -= (amount - 1);
        }

        public void Starve(int amount) {// Methods
            hungerLevel += amount;
            wickednessLevel += (amount + 3);
        }

        public List<int> ShowTeeth() {
            List<int> state = new List<int>();
            state.Add(wickednessLevel);
            state.Add(hungerLevel);
            return state;
        }

        // Age property -- Full property
        int age;
        public int Age {
            get {
                return age;
            }
            set {
                age = value;
            }
        }

        // Auto - property
        public string Color { get; set; } // Read-Write property

        public string Breed { get; } // ReadOnly property
        
    }
}
