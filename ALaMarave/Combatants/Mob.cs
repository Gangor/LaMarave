using System;
using ALaMarave.Randoms;

namespace ALaMarave.Combatants
{
    public class Mob : ICombatant
    {
        public int Pv { get; set; }
        public int Armure { get; set; }
        public int Force { get; set; }



        ILancerDe lanceur = new Randomiser();

        public Mob(int pv, int armure, int force)
        {
            Pv = pv;
            Armure = armure;
            Force = force;
        }

        public void Attaque(ICombatant adversaire)
        {
            Console.WriteLine("MOB : Tu vas morfler !");
            int lanceDe = lanceur.LanceDe();
            int degats = lanceDe + this.Force - adversaire.Armure;
            if(degats >= adversaire.Pv)
            {
                adversaire.Pv = 0;
                Console.WriteLine("JEU : Il vient de te fracasser de {0} Pv", degats);
            }
            else
            {
                adversaire.Pv -= degats;
                Console.WriteLine("MOB : Plus que {0} Pv et je te bouffe !\n", adversaire.Pv);
            }
            
        }

        public bool isAlive()
        {
            return this.Pv > 0;
        }
    }
}