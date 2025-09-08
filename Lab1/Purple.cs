using System.Reflection.Metadata;

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if (a == b && b == c && c == 0)  {
                answer = true;
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                answer = true;
            }
            if (a < 0 && b < 0 && c < 0)
            {
                answer = true;
            }
                // end

                return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0 || a != 0 && b % a == 0)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a*a == b || b*b == a || a*a*a == b || b*b*b == a)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = f * f - 4 * d * g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                return 1;
            }
            if (x > -1 && x <= 1)
            {
                return -x;
            }
            if (x > 1)
            {
                return -1;
            }
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            double circle_radius = Math.Sqrt(circleS / Math.PI);
            double square_side = Math.Sqrt(squareS);
            double square_diagonal = square_side * Math.Sqrt(2);
            if (square_diagonal / 2 <= circle_radius)
                answer = true;
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s == true)
            {
                if (t == true)
                {
                    answer = 6;
                }
                else
                {
                    if (f == true)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }
            else
            {
                if (t == true)
                {
                    answer = 3;
                }
                else
                {
                    if (f == true)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }
                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                return false; ;
            }
            int auroras = 0;
            if (pupils / 7 == 0)
            {
                auroras = pupils / 7;
            }
            else
            {
                auroras = pupils / 7 + 1;
            }
            if (bank > (pupils * 5 + auroras * salary))
                answer = true;
                // end

                return answer;
        }
    }
}