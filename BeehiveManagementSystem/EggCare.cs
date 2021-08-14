using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class EggCare : Bee
    {
        public const float CARE_PROGRESS_PER_SHIFT = .15F;
        public override float CostPerShift { get { return 1.35F; } }

        private Queen queen;
        public EggCare(Queen queen) : base("Egg Care")
        {
            this.queen = queen;
        }

        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
