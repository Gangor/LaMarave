namespace ALaMarave
{
    using System;
    using ALaMarave.Combatants;
    using Randoms;

    public class PhaseCombat
    {
        private IObtentionPourcentage proba = new Randomiser();

        public void JouerPhaseCombat(ICombatant heros, ICombatant mob, CombatantType starter)
        {
            if (starter.Equals(CombatantType.HERO))
            {
                heros.Attaque(mob);
                if (mob.isAlive())
                {
                    mob.Attaque(heros);
                }
            }
            else
            {
                mob.Attaque(heros);
                if (heros.isAlive())
                {
                    heros.Attaque(mob);
                }
            }

        }
    }
}