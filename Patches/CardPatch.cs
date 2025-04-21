namespace NoHighPurity
{
    internal static class CardPatch
    {
        internal static void CreatePostfix(Thing __instance)
        {
            RemoveHighPurityIfExists(instance: __instance);
        }

        internal static void SetTierPostfix(Thing __instance)
        {
            RemoveHighPurityIfExists(instance: __instance);
        }
        
        private static void RemoveHighPurityIfExists(Thing instance)
        {
            if (instance?.elements?.dict?.ContainsKey(key: 759) == true)
            {
                instance.elements.SetTo(id: 759, v: 0);
            }
        }
    }
}