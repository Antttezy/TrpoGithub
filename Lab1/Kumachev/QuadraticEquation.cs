using Lab1.Core;
using System;
using System.Collections.Generic;

namespace Lab1.Kumachev
{
    public class QuadraticEquation : LinearEquation, EquationInterface
    {
        protected float D(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }

        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                Solve(b, c);
                return X;
            }

            X.Clear();
            float d = D(a, b, c);

            if (d < 0)
            {
                throw new Exception("D < 0");
            }

            if (d == 0)
            {
                X.Add(-b / (2 * a));
            }
            else
            {
                d = (float)Math.Sqrt(d);

                X.Add((-b + d) / (2 * a));
                X.Add((- b - d) / (2 * a));
            }

            return X;
        }
    }
}
