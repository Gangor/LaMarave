using ALaMarave.Combatants;

namespace ALaMarave.Factories
{
    public class CombatantFactory : ICombatantFactory
    {
        public ICombatant CreerCombatant(CombatantType type, IHero? heros)
        {
            if(type == CombatantType.HERO)
            {
                //TODO : Faire la repartition des forces par le joueur
                return new Hero(pv: 30, armure: 15, force: 15, maxPv: 30);
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