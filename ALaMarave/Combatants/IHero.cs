using System;
using System.Collections.Generic;
using System.Text;

namespace ALaMarave.Combatants
{
    public interface IHero: ICombatant
    {
        int level { get; set; }
        int MaxPv { get; set; }
    }
}
