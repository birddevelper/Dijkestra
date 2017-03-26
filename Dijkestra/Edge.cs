using System;
using System.Collections.Generic;
using System.Text;

namespace MaxCut
{
    public class Edge
    {
        public string from;
        public string to;
        public float wieght;

        public Edge(string frm, string t, float wght)
        {
            from = frm;
            to = t;
            wieght = wght;



        }
        public Edge()
        {

        }
    }
}
