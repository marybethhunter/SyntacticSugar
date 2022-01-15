using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    public class Bug
    {
        /*
            You can declare a typed public property, make it read-only,
            and initialize it with a default value all on the same
            line of code in C#. Readonly properties can be set in the
            class' constructors, but not by external code.
        */
        public string Name { get; } = "";
        public string Species { get; } = "";
        public List<string> Predators { get; } = new List<string>();
        public List<string> Prey { get; } = new List<string>();

        // Convert this readonly property to an expression member
        //DONE
        public string FormalName
        {
            get => $"{this.Name} the {this.Species}";
        }

        // Class constructor
        public Bug(string name, string species, List<string> predators, List<string> prey)
        {
            this.Name = name;
            this.Species = species;
            this.Predators = predators;
            this.Prey = prey;
        }

        // Convert this method to an expression member
        //DONE
        public void PreyList()
        {
            var commaDelimitedPrey = string.Join(",", this.Prey);
            Console.WriteLine(commaDelimitedPrey);
        }

        // Convert this method to an expression member
        //DONE
        public void PredatorList()
        {
            var commaDelimitedPredators = string.Join(",", this.Predators);
            Console.WriteLine(commaDelimitedPredators);
        }

        // Convert this to expression method
        //DONE
        public void Eat(string food)
        {
            if (this.Prey.Contains(food))
            {
                Console.WriteLine( $"{this.Name} ate the {food}.");
            }
            else
            {
                Console.WriteLine($"{this.Name} is still hungry.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bug myBug = new Bug("spider", "arachnid", new List<string>(), new List<string>());


            myBug.Eat("smaller spider");

            Console.WriteLine(myBug.FormalName);

            myBug.PredatorList();
            myBug.PreyList();

        }
    }
}
