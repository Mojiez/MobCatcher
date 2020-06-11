using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameData.Items
{
    public class ItemProperty
    {
        public string Name { get; set; }
        public int ItemID { get; set; }
        public List<PrimaryItemStat> Stats { get; set; }


        public ItemProperty()
        {
           
        }
    }
}