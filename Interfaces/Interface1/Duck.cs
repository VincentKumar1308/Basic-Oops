using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public class Duck:IAnimal
    {
        //properties
        public string Name{get;set;}
        public string Habitat{get;set;}
        public string EatingHabitat{get;set;}

        //constructors
        public Duck(string name,string habitat,string eatingHabitat){
            Name=name;
            Habitat=habitat;
            EatingHabitat=eatingHabitat;
        }

        //methods
        public void DisplayInfo(){
            System.Console.WriteLine($" Name : {Name} | Habitat : {Habitat} Eating Habit : {EatingHabitat}");
        }
    }
}