using FrooxEngine;
using HarmonyLib;
using ResoniteModLoader;
using KrysalisManagedAPI;

namespace KrysalisMod;

public class KrysalisMod : ResoniteMod
{
    internal const string VERSION_CONSTANT = "1.0.0";
    public override string Name => "KrysalisMod";
    public override string Author => "DoubleStyx";
    public override string Version => VERSION_CONSTANT;
    public override string Link => "https://github.com/DoubleStyx/Krysalis/";

    public override void OnEngineInit()
    {
        Harmony harmony = new Harmony("net.DoubleStyx.KrysalisMod");
        Msg("Registered Harmony instance");
        harmony.PatchAll();
        Msg("Patched all methods");
    }

    [HarmonyPatch(typeof(Engine), "FinishInitialization")]
    class Engine_FinishInitialization_Patch
    {
        static void Postfix(Engine __instance)
        {
            Msg("This is a message ran from a patch.");
        }
    }
}
