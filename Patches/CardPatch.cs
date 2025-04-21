namespace NoHighPurity
{
    internal static class CardPatch
    {
        internal static void CreatePostfix(Thing __instance)
        {
            if (__instance?.elements?.dict?.ContainsKey(key: 759) == true)
            {
                __instance.elements.SetTo(id: 759, v: 0);
            }
        }
        
        internal static void SetTierPostfix(Thing __instance)
        {
            if (__instance?.elements?.dict == null)
                return;

            if (__instance.elements.dict.TryGetValue(key: 759, value: out _))
            {
                __instance.elements.SetTo(id: 759, v: 0);
            }
        }
    }
}