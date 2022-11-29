namespace ALaMarave.Factories
{
    public interface ICombatantFactory
    {
        ICombatant CreerCombatant(CombatantType type);
    }
}   