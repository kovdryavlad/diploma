﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentationBasedOnGraph.ResultSegments
{
    class AssesmentsSegment
    {
        //points with(R, G, B) coords or (L,a,b) e.t.c
        public List<double[]> points;
        public double[] center;

        public AssesmentsSegment(List<double[]> points)
        {
            this.points = points;

            SimpleMatrix.Matrix a = new SimpleMatrix.Matrix(points.ToArray());
            center = a.Transpose().data.Select(dim => dim.Average()).ToArray();
        }

        public int Length => points.Count;
    }
}
