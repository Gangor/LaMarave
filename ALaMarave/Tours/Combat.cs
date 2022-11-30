using System;
using ALaMarave.Combatants;
using ALaMarave.Factories;
using ALaMarave.Randoms;

namespace ALaMarave.Tours
{
    public class Combat : ITour
    {

        ICombatantFactory combatantFactory = new CombatantFactory();
        PhaseCombat combat = new PhaseCombat();
        IObtentionPourcentage proba = new Randomiser();

        public void JouerTour(IHero hero)
        {
            Console.WriteLine("TOI : Ho Ho ! J'ai cru voir un mob, mais oui, mais oui, j'ai bien vu un mob !\n");
            ICombatant mob = combatantFactory.CreerCombatant(CombatantType.MOB, hero);
            CombatantType starter = proba.GetStarter();
            while(mob.isAlive() && hero.isAlive())
            {
                Console.WriteLine("JEU : Il te reste {0} Pv\n", hero.Pv);
                combat.JouerPhaseCombat(heros: hero, mob: mob, starter);
            }
            if (hero.isAlive())
            {
                Console.WriteLine("TOI : Allez ca c'est fait ! On continue\n");
            }
            else
            {
                Console.WriteLine("JEU : Désolé mon gars mais c'est la loose");
                Console.WriteLine("JEU : RIP");
            }
        }
    }
}