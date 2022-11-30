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
            Console.WriteLine("JEU : Tu viens de tomber sur le grand Maitre d'armes ! ");
            Console.WriteLine(MaitreArmeInsolent.creerInsulte());
            hero.level++;
            Console.WriteLine("Félicitation, tu viens de level up !");
            give10pctPv(hero);
            repartirPoints(hero);

        }

        private void repartirPoints(IHero hero)
        {
            Console.WriteLine("Vous avez 3 points à répartir selon votre convenance");

            int pv;
            int force;
            int armure;
            do
            {
                Console.WriteLine("Nombre de Pv :");
                pv = Convert.ToInt32(Console.ReadLine());
            } while (pv > 3);
            do
            {
                Console.WriteLine("Nombre de force :");
                force = Convert.ToInt32(Console.ReadLine());
            } while (pv + force > 3);
            do
            {
                Console.WriteLine("Nombre d'armure :");
                armure = Convert.ToInt32(Console.ReadLine());
            } while (pv + armure + force > 3);

            hero.Pv += pv;
            hero.Force += force;
            hero.Armure += armure;
        }

        private void give10pctPv(IHero hero)
        {
            Console.WriteLine("JEU : +10% Pv\n");
            hero.Pv += Convert.ToInt32(0.1 * hero.Pv);
        }
    }
}