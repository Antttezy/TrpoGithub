using System;
using System.Collections.Generic;

namespace Lab1.Kumachev
{
    public class LinearEquation
    {
        public List<float> X { get; } = new List<float>();

        public List<float> Solve(float a, float b)
        {
            X.Clear();

            if (a == 0)
            {
                throw new Exception("A = 0");
            }

            X.Add(-b / a);
            return X;
        }
    }
}
