﻿using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;

namespace PartyJanna
{
    public static class SpellManager
    {
        static SpellManager()
        {
            Q = new Spell.Skillshot(SpellSlot.Q, 1000, SkillShotType.Linear);
            W = new Spell.Targeted(SpellSlot.W, 600);
            E = new Spell.Targeted(SpellSlot.E, 800);
            R = new Spell.Active(SpellSlot.R, 725);
        }

        public static Spell.Skillshot Q { get; private set; }
        public static Spell.Targeted W { get; private set; }
        public static Spell.Targeted E { get; private set; }
        public static Spell.Active R { get; private set; }

        public static void Initialize()
        {
        }
    }
}