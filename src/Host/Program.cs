﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new NumberOfRectanglesThatCanFormTheLargestSquare().CountGoodRectangles(new int[][] { new int[] { 5, 8 }, new int[] { 3, 9 }, new int[] { 5, 12 }, new int[] { 16, 5 } });
        }
    }
}
