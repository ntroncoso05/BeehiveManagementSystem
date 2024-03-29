﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19F;
        public const float LOW_LEVEL_WARNING = 10F;
        private static float honey = 25F;
        private static float nectar = 100F;

        public static string StatusReport 
        { 
            get 
            { 
                string status = $"{honey:0.0} units of honey.\n{nectar:0.0} units of nectar.";
                string warnings = "";

                if (honey < LOW_LEVEL_WARNING) warnings += "\nLOW HONEY - ADD A HONEY MANUFACTURER.";
                if (nectar < LOW_LEVEL_WARNING) warnings += "\nLOW NECTAR - ADD A NECTAR COLLECTOR.";

                return status + warnings;
            }
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0F)
            {
                nectar += amount;
            }
        }

        public static void ConvertNectarToHoney(float amount)
        {
            float nectarToConvert = amount;
            if (nectarToConvert > nectar) nectarToConvert = nectar;
            nectar -= nectarToConvert;
            honey += nectarToConvert * NECTAR_CONVERSION_RATIO;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            return false;
        }
    }
}
