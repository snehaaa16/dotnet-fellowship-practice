using System;

namespace _04_Methods.Level3
{
    public class CollinearPoints
    {
        // Check using Slope Method
        public static bool CheckBySlope(
            double pointAX, double pointAY,
            double pointBX, double pointBY,
            double pointCX, double pointCY)
        {
            if (pointAX == pointBX || pointBX == pointCX || pointAX == pointCX)
                return false;

            double slopeAB = (pointBY - pointAY) / (pointBX - pointAX);
            double slopeBC = (pointCY - pointBY) / (pointCX - pointBX);
            double slopeAC = (pointCY - pointAY) / (pointCX - pointAX);

            return slopeAB == slopeBC && slopeBC == slopeAC;
        }

        // Check using Area Method
        public static bool CheckByArea(
            double pointAX, double pointAY,
            double pointBX, double pointBY,
            double pointCX, double pointCY)
        {
            double triangleArea =
                0.5 * Math.Abs(
                pointAX * (pointBY - pointCY) +
                pointBX * (pointCY - pointAY) +
                pointCX * (pointAY - pointBY));

            return triangleArea == 0;
        }
    }
}