using HarmonyLib;

namespace NoHighPurity
{
    internal class Patcher
    {
        [HarmonyPostfix]
        [HarmonyPatch(declaringType: typeof(Card), methodName: nameof(Card.Create))]
        public static void CardCreate(Thing __instance)
        {
            CardPatch.CreatePostfix(__instance: __instance);
        }
        
        [HarmonyPostfix]
        [HarmonyPatch(declaringType: typeof(Card), methodName: nameof(Card.SetTier))]
        public static void CardSetTier(Thing __instance)
        {
            CardPatch.SetTierPostfix(__instance: __instance);
        }
    }
}