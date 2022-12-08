using System;
using System.Collections.Generic;

namespace SumOfGCPandLCM
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int gcp = FindGCP(n, m);
            int lcm = FindLCM(n, m);
            int sum = gcp + lcm;
            Console.WriteLine(sum);

        }

        static int FindGCP(int n, int m)
        {
            List<int> divisorsOfN = new List<int>();
            List<int> divisorsOfM = new List<int>();
            bool isFound = false;
            int gcp = 0;

            if (n < m)
            {
                int temp = n;
                n = m;
                m = temp;
            }

            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    divisorsOfN.Add(i);
                }

                if(m % i == 0)
                {
                    divisorsOfM.Add(i);
                }
            }

            for(int i = divisorsOfN.Count - 1; i >= 0; i--)
            {
                for(int k = divisorsOfM.Count - 1; k >= 0; k--)
                {
                    if(divisorsOfN[i] == divisorsOfM[k])
                    {
                        gcp = divisorsOfN[i];
                        isFound = true;
                        break;
                    }
                }

                if(isFound)
                {
                    break;
                }    
            }

            return gcp;
        }

        static int FindLCM(int n, int m)
        {
            int lcm = 0;
            List<int> nMultiples = new List<int>();
            List<int> mMultiples = new List<int>();
            bool isInside = false;

            if (n < m)
            {
                int temp = n;
                n = m;
                m = temp;
            }
            //n>m

            int firstNum = m;
            int secondNum = n;
            bool isFirst = true;
            int i = 0;

            while(true)
            {
                if (isFirst == false)
                {
                    m += firstNum;
                    n += secondNum;
                    mMultiples.Add(m);
                    nMultiples.Add(n);
                }
                else
                {
                    mMultiples.Add(firstNum);
                    nMultiples.Add(secondNum);
                }

                for (int k = 0; k < nMultiples.Count; ++k)
                {
                    if (mMultiples[i] == nMultiples[k])
                    {
                        lcm = mMultiples[i];
                        isInside = true;
                        break;
                    }
                }

                if(isInside)
                {
                    break;
                }

                isFirst = false;
                ++i;
            }

            return lcm;

        }
    }
}
