using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class HoneyManufacturer : Bee
    {
        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15F;
        public override float CostPerShift { get { return 1.7F; } }

        public HoneyManufacturer() : base("Honey Manufacturer") { }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    }
}
