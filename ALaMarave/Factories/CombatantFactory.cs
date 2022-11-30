using System;
using ALaMarave.Combatants;

namespace ALaMarave.Factories
{
    public class CombatantFactory : ICombatantFactory
    {
        public ICombatant CreerCombatant(CombatantType type, IHero? heros)
        {
            if(type == CombatantType.HERO)
            {
                
                Console.WriteLine("Vous avez 12 points à répartir selon votre convenance");
                
                int pv;
                int force;
                int armure;
                do
                {
                    Console.WriteLine("Nombre de Pv :");
                    pv = Convert.ToInt32(Console.ReadLine());
                } while (pv > 12);
                do
                {
                    Console.WriteLine("Nombre de force :");
                    force = Convert.ToInt32(Console.ReadLine());
                } while (pv + force > 12);
                do
                {
                    Console.WriteLine("Nombre d'armure :");
                    armure = Convert.ToInt32(Console.ReadLine());
                } while (pv + armure + force > 12);
                
                return new Hero(pv: 30 + pv, armure: 15 + armure, force: 15 + force, maxPv: 30 + pv);
            }else if(type == CombatantType.MOB && !heros.Equals(null))
            {
                return new Mob(pv: 25 + 2*heros.level, armure: 12 + 2 * heros.level, force: 12 + 2 * heros.level);
            }
            else
            {
                throw new System.InvalidOperationException();
            }
        }

    }
}