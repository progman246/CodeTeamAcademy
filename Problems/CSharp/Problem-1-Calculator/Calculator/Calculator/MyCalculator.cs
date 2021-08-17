using System;

namespace Calculator
{
    public class MyCalculator
    {
        public int Add(int a1, int a2)
        {
            return a1 + a2;
        }

        public double Add(double d1, double d2)
        {
            return d1 + d2;
        }

        public long Add(long l1, long l2)
        {
            return l1 + l2;
        }

        public int Multiply(int m1, int m2)
        {
            return m1 * m2;
        }

        public double Multiply(Double d1, double d2)
        {
            return d1 * d2;
        }

        public long Multiply(long l1, long l2)
        {
            return l1 * l2;
        }

        public (int,int) Divide(int l1, int l2)
        {
            return (l1 / l2, l1 % l2);
        }

        public (long, long) Divide(long l1, long l2)
        {
            return (l1 / l2, l1 % l2);
        }

        public int Subtract(int l1, int l2)
        {
            return (l1 - l2);
        }

        public double Subtract(double l1, double l2)
        {
            return (l1 - l2);
        }

        public long Subtract(long l1, long l2)
        {
            return l1 - l2;
        }

        public int Add(int a1, int a2, int a3, int a4, int a5, int a6)
        {
            return (a1 + a2 + a3 + a4 + a5 + a6);
        }

        public double Add(double a1, double a2, double a3, double a4, double a5)
        {
            return (a1 + a2 + a3 + a4 + a5);
        }

        public long Add(long a1, long a2, long a3, long a4, long a5, long a6)
        {
            return (a1 + a2 + a3 + a4 + a5 + a6);
        }

        public int Multiply(int a1, int a2, int a3, int a4)
        {
            
                return (a1*a2*a3*a4);
        }

        public double Multiply(double a1, double a2, double a3, double a4)
        {

            return (a1 * a2 * a3 * a4);
        }

        public long Multiply(long a1, long a2, long a3, long a4)
        {

            return (a1 * a2 * a3 * a4);
        }







    }
}
