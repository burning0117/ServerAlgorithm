using System;
using System.Collections.Generic;
using System.Numerics;

namespace ClassLibrary1
{
    public class Mathf
    {
        private static Random random = new Random();
        public const float PI = 3.141593f;
        public const float PIx2 = 3.141593f * 2;
        public const float Infinity = float.PositiveInfinity;
        public const float NegativeInfinity = float.NegativeInfinity;
        public const float Deg2Rad = 0.01745329f;
        public const float Rad2Deg = 57.29578f;
        public static readonly float Epsilon;

        static Mathf()
        {
            //Epsilon = !MathfInternal.IsFlushToZeroEnabled ? MathfInternal.FloatMinDenormal : MathfInternal.FloatMinNormal;
        }

        public static float Sin(float f)
        {
            return (float) Math.Sin((double) f);
        }

        public static float Cos(float f)
        {
            return (float) Math.Cos((double) f);
        }

        public static float Tan(float f)
        {
            return (float) Math.Tan((double) f);
        }

        public static float Asin(float f)
        {
            return (float) Math.Asin((double) f);
        }

        public static float Acos(float f)
        {
            return (float) Math.Acos((double) f);
        }

        public static float Atan(float f)
        {
            return (float) Math.Atan((double) f);
        }

        public static float Atan2(float y, float x)
        {
            return (float) Math.Atan2((double) y, (double) x);
        }

        public static float Sqrt(float f)
        {
            return (float) Math.Sqrt((double) f);
        }

        public static float Abs(float f)
        {
            return Math.Abs(f);
        }

        public static int Abs(int value)
        {
            return Math.Abs(value);
        }

        public static float Min(float a, float b)
        {
            return ((a >= b) ? b : a);
        }

        public static float Min(params float[] values)
        {
            int length = values.Length;
            if (length == 0)
            {
                return 0f;
            }

            float num2 = values[0];
            for (int i = 1; i < length; i++)
            {
                if (values[i] < num2)
                {
                    num2 = values[i];
                }
            }

            return num2;
        }

        public static int Min(int a, int b)
        {
            return ((a >= b) ? b : a);
        }

        public static int Min(params int[] values)
        {
            int length = values.Length;
            if (length == 0)
            {
                return 0;
            }

            int num2 = values[0];
            for (int i = 1; i < length; i++)
            {
                if (values[i] < num2)
                {
                    num2 = values[i];
                }
            }

            return num2;
        }

        public static float Max(float a, float b)
        {
            return ((a <= b) ? b : a);
        }

        public static float Max(params float[] values)
        {
            int length = values.Length;
            if (length == 0)
            {
                return 0f;
            }

            float num2 = values[0];
            for (int i = 1; i < length; i++)
            {
                if (values[i] > num2)
                {
                    num2 = values[i];
                }
            }

            return num2;
        }

        public static int Max(int a, int b)
        {
            return ((a <= b) ? b : a);
        }

        public static int Max(params int[] values)
        {
            int length = values.Length;
            if (length == 0)
            {
                return 0;
            }

            int num2 = values[0];
            for (int i = 1; i < length; i++)
            {
                if (values[i] > num2)
                {
                    num2 = values[i];
                }
            }

            return num2;
        }


        public static float Pow(float f, float p)
        {
            return (float) Math.Pow((double) f, (double) p);
        }

        public static float Exp(float power)
        {
            return (float) Math.Exp((double) power);
        }

        public static float Log(float f, float p)
        {
            return (float) Math.Log((double) f, (double) p);
        }

        public static float Log(float f)
        {
            return (float) Math.Log((double) f);
        }

        public static float Log10(float f)
        {
            return (float) Math.Log10((double) f);
        }

        public static float Ceil(float f)
        {
            return (float) Math.Ceiling((double) f);
        }

        public static float Floor(float f)
        {
            return (float) Math.Floor((double) f);
        }

        public static float Round(float f)
        {
            return (float) Math.Round((double) f);
        }

        public static int CeilToInt(float f)
        {
            return (int) Math.Ceiling((double) f);
        }

        public static int FloorToInt(float f)
        {
            return (int) Math.Floor((double) f);
        }

        public static int RoundToInt(float f)
        {
            return (int) Math.Round((double) f);
        }

        public static float Random()
        {
            return (float) random.NextDouble();
        }

        public static int Random(int min, int max)
        {
            return random.Next(min, max);
        }


        public static float Sign(float f)
        {
            return ((f < 0f) ? -1f : 1f);
        }

        public static float Clamp(float value, float min, float max)
        {
            if (value < min)
            {
                value = min;
                return value;
            }

            if (value > max)
            {
                value = max;
            }

            return value;
        }

        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                value = min;
                return value;
            }

            if (value > max)
            {
                value = max;
            }

            return value;
        }

        public static float Clamp01(float value)
        {
            if (value < 0f)
            {
                return 0f;
            }

            if (value > 1f)
            {
                return 1f;
            }

            return value;
        }

        public static float Lerp(float a, float b, float t)
        {
            return (a + ((b - a) * Clamp01(t)));
        }

        public static float LerpUnclamped(float a, float b, float t)
        {
            return (a + ((b - a) * t));
        }




        public static float MoveTowards(float current, float target, float maxDelta)
        {
            if (Abs((float) (target - current)) <= maxDelta)
            {
                return target;
            }

            return (current + (Sign(target - current) * maxDelta));
        }


    }
}