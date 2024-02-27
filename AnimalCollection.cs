using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ch11Ex01;

namespace Ch11Ex02
{
    public  class AnimalCollections : CollectionBase
    {
      
        
            public void Add(Animal newAnimal) => List.Add(newAnimal);

            public void Remove ( Animal newAnimal) => List.Remove(newAnimal);

            public Animal this[int animalIndex]
            {
                get { return (Animal)this[animalIndex]; }
                set { List[animalIndex] = value; }
            }

        

    }
}
