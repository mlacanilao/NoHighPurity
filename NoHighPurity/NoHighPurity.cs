﻿using BepInEx;
using HarmonyLib;

namespace NoHighPurity
{
    internal static class ModInfo
    {
        internal const string Guid = "omegaplatinum.elin.nohighpurity";
        internal const string Name = "No High Purity";
        internal const string Version = "1.0.3.1";
    }

    [BepInPlugin(GUID: ModInfo.Guid, Name: ModInfo.Name, Version: ModInfo.Version)]
    internal class NoHighPurity : BaseUnityPlugin
    {
        internal static NoHighPurity Instance { get; private set; }

        private void Start()
        {
            Instance = this;

            Harmony.CreateAndPatchAll(type: typeof(Patcher), harmonyInstanceId: ModInfo.Guid);
        }

        internal static void Log(object payload)
        {
            Instance.Logger.LogInfo(data: payload);
        }
    }
}