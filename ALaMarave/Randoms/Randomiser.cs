using System;
using ALaMarave.Combatants;
using ALaMarave.Tours;

namespace ALaMarave.Randoms
{
    public class Randomiser : ILancerDe, IObtentionPourcentage
    {

        Random rdm = new Random();

        public CombatantType GetStarter()
        {
            int result = rdm.Next(1, 101);
            if(result < 65)
            {
                return CombatantType.HERO;
            }
            else
            {
                return CombatantType.MOB;
            }
        }

        public TourType GetTypeOfTour()
        {
            int result = rdm.Next(1, 101);
            if(result <= 25)
            {
                return TourType.REGENERATION;
            }else if (result > 25 && result <= 50)
            {
                return TourType.ENTRAINEMENT;
            }
            else
            {
                return TourType.MAROUFLE;
            }
        }

        public int LanceDe()
        {
            return rdm.Next(1, 13);
        }

    }
}