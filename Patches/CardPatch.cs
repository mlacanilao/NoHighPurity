namespace NoHighPurity
{
    internal static class CardPatch
    {
        internal static void CreatePostfix(Thing __instance)
        {
            if (__instance?.elements?.dict == null)
                return;

            bool foundPurity = false;

            foreach (Element element in __instance.elements.dict.Values)
            {
                if (element.id == 759)
                {
                    foundPurity = true;
                    break;
                }
            }

            if (foundPurity == true)
            {
                __instance.elements.SetTo(id: 759, v: 0);
            }
        }
        
        internal static void SetTierPostfix(Thing __instance)
        {
            if (__instance?.elements?.dict == null)
                return;

            bool foundPurity = false;

            foreach (Element element in __instance.elements.dict.Values)
            {
                if (element.id == 759)
                {
                    foundPurity = true;
                    break;
                }
            }

            if (foundPurity == true)
            {
                __instance.elements.SetTo(id: 759, v: 0);
            }
        }
    }
}