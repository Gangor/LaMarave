using System;
using ALaMarave.Combatants;
using ALaMarave.Factories;

namespace ALaMarave.Tours
{
    public class MaitreArme : ITour
    {

        IInsulteFactory MaitreArmeInsolent = new InsulteFactory();
   
        public void JouerTour(IHero hero)
        {
            Console.WriteLine("JEU : Tu viens de tomber sur le grand Maitre d'armes ! Félicitation tu viens de level up !");
            //TODO : MaitreArmeInsolent.creerInsulte();
            hero.level++;
            give10pctPv(hero);
            //TODO : repartirPoints(hero);

        }

        private void repartirPoints(IHero hero)
        {
            throw new NotImplementedException();
        }

        private void give10pctPv(IHero hero)
        {
            Console.WriteLine("JEU : +10% Pv\n");
            hero.Pv += Convert.ToInt32(0.1 * hero.Pv);
        }
    }
}