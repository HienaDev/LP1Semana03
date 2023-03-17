using System;

// Created enum with flags so it can be treated as bits
// Activates each achievement bit by bit
namespace playerAchievements
{
    [Flags]
    enum achievements
    {
        DefeatOptionalBoss = 1 << 0, // 1
        FindHiddenLevel = 1 << 1, // 2
        FinishGame = 1 << 2 // 4
    }
}