using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameData.Items
{
    static class ListClass //Klassen er lavet til brug af "List<T>.Splice<T> i ItemNameGenerator.
    {
        public static List<T> Splice<T>(this List<T> source, int index, int count)
        {
            var items = source.GetRange(index, count);
            source.RemoveRange(index, count);
            return items;
        }

    }
}
