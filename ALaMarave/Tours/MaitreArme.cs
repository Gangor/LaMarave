using System;
using ALaMarave.Combatants;
using ALaMarave.Factories;

namespace ALaMarave.Tours
{
    public class MaitreArme : ITour
    {

        IInsulteFactory MaitreArmeInsolent = new InsulteFactory();
   
        public void JouerTour(IHero adversaire)
        {
            Console.WriteLine("JEU : Tu viens de tomber sur le grand Maitre d'armes ! Félicitation tu viens de level up !\n");
            //TODO : MaitreArmeInsolent.creerInsulte();
            adversaire.level++;
            //TODO : repartirPoints();
        }

        private void repartirPoints()
        {
            throw new NotImplementedException();
        }
    }
}