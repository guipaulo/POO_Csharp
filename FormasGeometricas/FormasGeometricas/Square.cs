﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    internal class Square:Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Você desenhou um {Nome}");
        }
    }
}
