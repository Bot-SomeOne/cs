using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Day250824.Help
{
    internal class help
    {
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
        public static double Angle(double x1, double y1, double x2, double y2)
        {
            // Tính góc giữa hai điểm A và B với trục hoành
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;

            // Tính góc (radian)
            double angleInRadians = Math.Atan2(deltaY, deltaX);

            // Chuyển đổi sang độ nếu cần
            double angleInDegrees = angleInRadians * (180 / Math.PI);

            return angleInDegrees;
        }
    }
}
