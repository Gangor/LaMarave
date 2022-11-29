namespace ALaMarave;
{
    using Factories;

    public class Partie
    {
        public ICombatant hero;
        public Queue<ITour> tours = new Queue<ITour>(20);

        public Partie()
        {
            throw new System.NotImplementedException();
        }



        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}