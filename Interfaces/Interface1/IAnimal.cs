using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public interface IAnimal
    {
        //properties
        string Name{get;set;}
        string Habitat{get;set;}
        string  EatingHabitat{get;set;}

        //methods
        void DisplayInfo();

    }
}