﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public static class SolvingFlicker
    {
        public static void SetDoubleBuffered(this Panel panel)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, panel, new object[] { true });
        }
    }
}
