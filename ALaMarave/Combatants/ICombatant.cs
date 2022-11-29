namespace ALaMarave.Combatants
{
    public interface ICombatant
    {
        int Pv { get; set; }
        int Armure { get; set; }
        int Force { get; set; }
        int MaxPv { get; set; }

        public void Attaque();
    }
}