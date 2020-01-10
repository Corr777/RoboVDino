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
            Dinosaur milwaukeeSaursRex = new Dinosaur("MilwaukeeSaurs Rex", 50);
            dinosaurs.Add(milwaukeeSaursRex);

            Dinosaur UtahRaptor = new Dinosaur("UtahRaptor", 10);
            dinosaurs.Add(UtahRaptor);

            Dinosaur Atlantascopcosaurus = new Dinosaur("Atlantascopcosaurus", 60);
            dinosaurs.Add(Atlantascopcosaurus);

            Dinosaur Orleansceratops = new Dinosaur("Orleansceratops", 40);
            dinosaurs.Add(Orleansceratops);

            Dinosaur Bamastegosaur = new Dinosaur("Bamastegosaur", 5);
            dinosaurs.Add(Bamastegosaur);

            Dinosaur JacksonElopteryx = new Dinosaur("JacksonElopteryx", 20);
            dinosaurs.Add(JacksonElopteryx);

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
