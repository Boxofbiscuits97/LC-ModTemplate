using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    [BepInPlugin(MODGUID, MODNAME, MODVERSION)]
    public class $safeprojectname$Base : BaseUnityPlugin
    {
        public const string MODGUID = "LCMOD.$safeprojectname$";
        public const string MODNAME = "$safeprojectname$";
        public const string MODVERSION = "1.0.0";

        private readonly Harmony harmony = new Harmony(MODGUID);
        private static $safeprojectname$Base Instance;

        internal ManualLogSource logger = BepInEx.Logging.Logger.CreateLogSource(MODNAME);

        void Awake()
        {
            if (Instance == null) Instance = this;
            logger = Logger;

            Logger.LogInfo($"Mod {MODGUID} is loaded!");

            harmony.PatchAll(typeof($safeprojectname$Base)); //Add more patches below


        }
    }
}
