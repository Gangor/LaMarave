using ALaMarave.Randoms;
using ALaMarave.Tours;

namespace ALaMarave.Factories
{
    public class TourFactory : ITourFactory
    {

        public ITour CreeTour(TourType type)
        {
            switch (type)
            {
                case TourType.REGENERATION:
                    return new Merlin();
                case TourType.ENTRAINEMENT:
                    return new MaitreArme();
                case TourType.MAROUFLE:
                    return new Combat();
                default:
                    throw new System.InvalidOperationException();
            }
                
        }
    }
}

