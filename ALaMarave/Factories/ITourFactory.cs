using ALaMarave.Tours;

namespace ALaMarave.Factories
{
    public interface ITourFactory
    {
        ITour CreeTour(TourType type);
    }
}