using System;
using ALaMarave.Randoms;

namespace ALaMarave.Combatants
{
    public class Hero : IHero
    {
        public int Pv { get; set; }
        public int Armure { get; set; }
        public int Force { get; set ; }
        public int MaxPv { get; set; }
        public int level { get; set; }

        public int Level = 1;

        ILancerDe lanceur = new Randomiser();

        public Hero(int pv, int armure, int force, int maxPv)
        {
            Pv = pv;
            Armure = armure;
            Force = force;
            MaxPv = maxPv;
        }

        public void Attaque(ICombatant adversaire)
        {
            Console.WriteLine("TOI : Kamé Hamé Ha !!!!!");
            int lanceDe = lanceur.LanceDe();
            int degats = lanceDe + this.Force - adversaire.Armure;
            if (degats >= adversaire.Pv)
            {
                adversaire.Pv = 0;
            }
            else
            {
                adversaire.Pv -= degats;
                Console.WriteLine("TOI : HA HA HA ! Il te reste à peine {0} Pvs\n", adversaire.Pv);

            }
            
        }

        public bool isAlive()
        {
            return this.Pv > 0;
        }
    }
}