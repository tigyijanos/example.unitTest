namespace MySoftware.Service
{
    using System;

    public class MathService : IMathService
    {
        /// <summary>
        /// Sum A and B
        /// </summary>
        /// <param name="a">additive</param>
        /// <param name="b">additive</param>
        /// <returns></returns>
        public double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Divide a by b
        /// </summary>
        /// <param name="a">dividend</param>
        /// <param name="b">divider</param>
        /// <returns>quotient</returns>
        public double Divide(double a, double b)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (b == 0)
            {
                throw new DivideByZeroException("You can't do that!");
            }

            return a / b;
        }
    }
}