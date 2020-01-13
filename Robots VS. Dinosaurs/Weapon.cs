namespace Robots_VS.Dinosaurs
{
    class Weapon
    {
        public string Type;
        public string ParticleGun;
        public string RadioactivePaintballSplatter;
        public string AcidThrowingSuperSoaker;
        // constructor (SPAWNER)
        public Weapon(string type, string ParticleGun, string RadioactivePaintballSplatter, string AcidThrowingSuperSoaker)
        {
            this.Type = type;
            this.ParticleGun = ParticleGun;
            this.RadioactivePaintballSplatter = RadioactivePaintballSplatter;
            this.AcidThrowingSuperSoaker = AcidThrowingSuperSoaker;
        }

        // member methods (CAN DO)
        public void AssignWeapon()
        {
            string WeaponType = (ParticleGun + RadioactivePaintballSplatter + AcidThrowingSuperSoaker);
            
        }











    }
}
