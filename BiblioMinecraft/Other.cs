﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMinecraft
{
    public static class Other
    {
        public static float Dist(float x1, float x2, float y1, float y2, float z1, float z2)
        {
            return (float)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(z1 - z2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
}