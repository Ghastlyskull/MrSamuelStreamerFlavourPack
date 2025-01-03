﻿using RimWorld;
using Verse;

namespace MSSFP;

[DefOf]
public static class MSSFPDefOf
{
    public static readonly ThingDef MSSFP_Frogge;
    public static readonly TraitDef MSS_SweetBabyBoy;
    public static readonly HediffDef MSS_FP_FroggeHaunt;
    public static readonly HediffDef MSS_FP_PawnDisplayer;
    public static readonly PreceptDef MSS_FP_IdeoRole_FroggeWarrior;
    static MSSFPDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(MSSFPDefOf));
}
