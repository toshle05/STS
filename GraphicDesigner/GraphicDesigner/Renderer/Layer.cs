﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicDesigner
{
    public class Layer
    {
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public int Level { get; set; }
        public ColorMatrix colorMatrix { get; set; }

        public Layer(int startX, int startY, int endX, int endY, int level)
        {
            this.StartX = startX;
            this.StartY = startY;
            this.EndX = endX;
            this.EndY = endY;
            this.Level = level;
            this.colorMatrix = new ColorMatrix(startX, startY, endX, endY);
        }

        public int Width
        {
            get
            {
                return this.EndX - this.StartX + 1;
            }
        }

        public int Heigth
        {
            get
            {
                return this.EndY - this.StartY + 1;
            }
        }

        public Layer Clone()
        {
            Layer clone = new Layer(this.StartX, this.StartY, this.EndX, this.EndY, this.Level);
            return clone;
        }
    }
}
