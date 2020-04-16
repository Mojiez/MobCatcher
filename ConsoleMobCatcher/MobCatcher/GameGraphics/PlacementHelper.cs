using System;
using System.Collections.Generic;
using System.Text;

namespace MobCatcher.GameGraphics
{
    class PlacementHelper
    {
        public void WriteAt(string input, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(input);
        }

    }
}
