using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace MobCatcher.GameData.Items
{
    public class ItemGenerator
    {
        
        public ItemProperty GenerateRandomItem()
        {
            ItemNameGenerator itemNameGenerator = new ItemNameGenerator();
            Random random = new Random();
            ItemProperty item = new ItemProperty();
            item.type = random.Next(1,5);
            item.Name = itemNameGenerator.GenerateItemName(item.type);
            item.Stats = GenerateItemStats();
            
            return item;
        }

        private List<PrimaryItemStat> GenerateItemStats()
        {
            List<PrimaryItemStat> temp = new List<PrimaryItemStat>();
            Random random = new Random();
            temp.Add(new PrimaryItemStat { Attack = random.Next(50, 150), Defence = random.Next(50, 150), Health = random.Next(150, 500)});
            return temp;
        }
    }
}