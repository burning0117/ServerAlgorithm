using System;
using System.Numerics;

namespace ClassLibrary1
{
    public class RayCastManager
    {
        /**
      *  vector31：圆心
      *  vector32:圆周上的点
      *  rotateAngle:旋转角度
      */
        public static Circle RotatePosition(Circle unityCircle, Circle rotateCircle, float rotateAngle)
        {
            //判断小圆摆放位置是否符合要求
            rotateAngle = rotateAngle % 360; //0-360度范围内
            Quaternion qua = Quaternion.CreateFromAxisAngle(Vector3.UnitY, rotateAngle);
            Vector3 center = Vector3.Transform(rotateCircle.center, qua);
            center = center * unityCircle.radius + unityCircle.center;
            return new Circle(center, rotateCircle.radius * unityCircle.radius);
        }

        //绕y轴旋转
        public static Vector3 RandomCirclePoint(Circle circle)
        {
            float theta = Mathf.Random() * 2 * Mathf.PI;
            float radius = Mathf.Random() * circle.radius;
            float x = radius * Mathf.Sin(theta);
            float z = radius * Mathf.Cos(theta);
            return new Vector3(x, circle.y, z) + circle.center;
        }

        public class Circle
        {
            public float x;
            public float y;
            public float z;
            public float radius;

            public Circle(float x, float y, float z, float radius)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.radius = radius;
            }

            public Circle(Vector3 centerPos, float radius) : this(centerPos.X, centerPos.Y, centerPos.Z, radius)
            {
            }

            /// <summary>
            /// 表面积
            /// </summary>
            public float surfaceArea
            {
                get { return Mathf.PI * radius * radius; }
            }

            /// <summary>
            /// 周长
            /// </summary>
            public float perimeter
            {
                get { return Mathf.PI * 2 * radius; }
            }

            public Vector3 center
            {
                get { return new Vector3(x, y, z); }
                set
                {
                    x = value.X;
                    y = value.Y;
                    z = value.Z;
                }
            }
        }
    }
}