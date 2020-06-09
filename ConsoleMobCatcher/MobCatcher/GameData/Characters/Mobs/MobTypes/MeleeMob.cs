using MobCatcher.GameData.Characters.Mobs.Abilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameData.Characters.Mobs.MobTypes
{
    class MeleeMob : Mob
    {
        public List<MeleeAbilities> Abilities { get; set; }
        public MeleeMob(string name, int level) : base(name)
        {


        }
    }
}
