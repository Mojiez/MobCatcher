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
            WeaponNameGenerator weaponnameGenerator = new WeaponNameGenerator();
            Random random = new Random();
            ItemProperty item = new ItemProperty();

            if (random.Next(2) == 1)
            {
                item.type = random.Next(1, 6);
                item.Name = itemNameGenerator.GenerateItemName(item.type);
            }
            else
            {
                item.type = random.Next(6, 11);
                item.Name = weaponnameGenerator.GenerateRandomWeaponName(item.type);
            }
            
            
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