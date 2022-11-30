namespace ALaMarave
{
using System;
using System.Collections.Generic;
using ALaMarave.Combatants;
    using ALaMarave.Randoms;
    using ALaMarave.Tours;
using Factories;

    public class Partie
    {
        private ICombatantFactory combatantFactory = new CombatantFactory();
        private ITourFactory tourFactory = new TourFactory();
        private IObtentionPourcentage proba = new Randomiser();
        private Queue<ITour> tours = new Queue<ITour>(20);

        public void Start()
        {
            Console.WriteLine("Salut à toi grand joueur ! Nous allons créer ton personnage ensemble!\n");
            ICombatant hero = combatantFactory.CreerCombatant(CombatantType.HERO, null);
            while (tours.Count < 20 && hero.isAlive())
            {
                ITour tour = tourFactory.CreeTour(proba.GetTypeOfTour());
                tours.Enqueue(tour);
                tour.JouerTour((IHero)hero);
            }
            
            
        }
        
    }
}