using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public new int CurrentHitPoints = 10;

        public new int MaximumHitPoints = 10;

        public int Gold { get; set; } = 20;

        public int ExperiencePoints { get; set; } = 0;

        public int Level { get; set; } = 1;

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }
    }
}
