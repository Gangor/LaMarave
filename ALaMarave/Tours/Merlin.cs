using System;
using ALaMarave.Combatants;

namespace ALaMarave.Tours
{
    public class Merlin : ITour
    {
        public void JouerTour(IHero hero)
        {
            Console.WriteLine("JEU : Tu viens de tomber sur Merlin ! Il te redonne 100% de Pv, chanceux !\n");
            hero.Pv = hero.MaxPv;
        }
    }
}