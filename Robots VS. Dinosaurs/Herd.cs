using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_VS.Dinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();

        public Herd()
        {
            Dinosaur milwaukeeSaursRex = new Dinosaur("MilwaukeeSaurs Rex", 30);
            dinosaurs.Add(milwaukeeSaursRex);

            Dinosaur UtahRaptor = new Dinosaur("UtahRaptor", 10);
            dinosaurs.Add(UtahRaptor);

            Dinosaur Atlantascopcosaurus = new Dinosaur("Atlantascopcosaurus", 30);
            dinosaurs.Add(Atlantascopcosaurus);

            Dinosaur ceratops = new Dinosaur("ceratops", 10);
            dinosaurs.Add(ceratops);

            Dinosaur stegosaur = new Dinosaur("stegosaur", 30);
            dinosaurs.Add(stegosaur);

            Dinosaur Elopteryx = new Dinosaur("Elopteryx", 10);
            dinosaurs.Add(Elopteryx);

        }

        //accessibility _ return type _ method name _ (parameters)
        public void DinosaurType()
        {

           

            //foreach (string dinosaur in dinosaurs)
            //{
            //    Console.WriteLine(dinosaur);
            //}
        }

    }
}
