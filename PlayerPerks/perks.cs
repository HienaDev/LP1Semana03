using System;


namespace PerksToUse
{
    [Flags]
    enum perks
    {
        WaterBreathing = 1 << 0, // 1
        Stealth = 1 << 1, // 2
        AutoHeal = 1 << 2, // 4
        DoubleJump = 1 << 3 // 8
    }
}
