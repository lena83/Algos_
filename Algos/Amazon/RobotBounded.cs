using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class RobotBounded
    {
        public static bool IsRobotBounded(string instructions)
        {
            int x = 0, y = 0;
            string direction = "North";

            foreach (char c in instructions)
            {
                if (c == 'G')
                {
                    if (direction == "North")
                    {
                        y++;
                    }
                    else if (direction == "South")
                    {
                        y--;
                    }
                    else if (direction == "West")
                    {
                        x--;
                    }
                    else if (direction == "East")
                    {
                        x++;
                    }
                }
                else if (c == 'L')
                {
                    if (direction == "North")
                    {
                        direction = "West";
                    }
                    else if (direction == "West")
                    {
                        direction = "South";
                    }
                    else if (direction == "South")
                    {
                        direction = "East";
                    }
                    else if (direction == "East")
                    {
                        direction = "North";
                    }
                }
                else if (c == 'R')
                {
                    if (direction == "North")
                    {
                        direction = "East";
                    }
                    else if (direction == "East")
                    {
                        direction = "South";
                    }
                    else if (direction == "South")
                    {
                        direction = "West";
                    }
                    else if (direction == "West")
                    {
                        direction = "North";
                    }
                }
            }
            if ((x == 0 && y == 0) || direction != "North")
            {
                return true;
            }
            return false;
        }



    }
}
