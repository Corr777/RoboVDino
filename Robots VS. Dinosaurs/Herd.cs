using System.Collections.Generic;

namespace Robots_VS.Dinosaurs
{
    class Herd
    {
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();

        public Herd()
        {
            Dinosaur milwaukeeSaursRex = new Dinosaur("MilwaukeeSaurs Rex", 50, 100, 100);
            dinosaurs.Add(milwaukeeSaursRex);

            Dinosaur UtahRaptor = new Dinosaur("UtahRaptor", 10, 100, 100);
            dinosaurs.Add(UtahRaptor);

            Dinosaur Atlantascopcosaurus = new Dinosaur("Atlantascopcosaurus", 60, 100, 100);
            dinosaurs.Add(Atlantascopcosaurus);

        }

        




    }
}
