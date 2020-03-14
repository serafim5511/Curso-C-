using System;
using System.Collections.Generic;
using System.Text;
using Abstrato.Entities.List;
using Abstrato.Entities;


namespace Abstrato.Entities
{
    abstract class  Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
