using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostArk.Game.Messages.Types
{
    [Flags]
    public enum
        DamageModifierFlags // 0b**FBKD*C with F: front attack, B: Back attack, K: bleed crit (dots ?), D: bleed not crit (dots ?), C: crit
    {
        None = 0,
        SkillCrit = 1,
        UnkModifier1 = 2,
        DotNoCrit = 4,
        DotCrit = 8,
        BackAttack = 16,
        FrontAttack = 32,
        UnkModifier2 = 64,
        UnkModifier3 = 128
    }
}
