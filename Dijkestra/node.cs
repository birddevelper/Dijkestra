using System;
using System.Collections.Generic;
using System.Text;

namespace MaxCut
{
    public class node
    {
        public string name;
        public string set;
        public string pred;
        public double distance;
        public int center_x;
        public int center_y;
        public node (string nam,int x,int y)
        {
            name = nam;
            set = "b";
            center_x = x;
            center_y = y;
            distance = Double.MaxValue;

        }

    }
}
