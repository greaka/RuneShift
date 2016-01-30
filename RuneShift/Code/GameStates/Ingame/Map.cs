﻿using System;
using SFML;
using SFML.Graphics;
using SFML.Window;
using System.Collections.Generic;

namespace RuneShift
{
    class Map
    {
        List<StoneCircle> StoneCircles = new List<StoneCircle>();

        public Map()
        {
            StoneCircles.Add(new StoneCircle(10F, 5));
            StoneCircles.Add(new StoneCircle(20F, 7));
            StoneCircles.Add(new StoneCircle(30F, 10));
            StoneCircles.Add(new StoneCircle(40F, 15));
        }

        public void Update()
        {
            foreach(StoneCircle stoneCircle in StoneCircles)
            {
                stoneCircle.Update();
            }
        }

        public void Draw(RenderWindow win)
        {
            foreach (StoneCircle stoneCircle in StoneCircles)
            {
                stoneCircle.Draw(win);
            }
        }
    }
}