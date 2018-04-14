using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListenAndWrite.Models.BusinessModel
{
    public class FullModeModel
    {
        public  String GetTable(string source, string test)
        {
            String result = "";
            string[] s = source.Split(' ');
            string[] t = test.Split(' ');
            int lengthS = s.Length;
            int lengthT = t.Length;
            int[,] M = new int[lengthS + 1, lengthT + 1];
            for (int i = 1; i <= lengthS; i++)
            {
                for (int j = 1; j <= lengthT; j++)
                {
                    if (s[i - 1].Equals(t[j - 1]))
                    {
                        M[i, j] = M[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        M[i, j] = M[i, j - 1] > M[i - 1, j] ? M[i, j - 1] : M[i - 1, j];
                    }
                }
            }
           
            for (int i = 0; i < lengthS; i++)
            {
                if (M[i + 1, lengthT] == M[i, lengthT] + 1)
                {
                    result += (s[i].ToUpper()+" ");
                    
                }
                else
                {
                    result += (s[i].ToLower() + " ");
                    
                }
            }
            return result;
        }

        public int GetScore(string source,string test)
        {
            string[] sourceArray = source.Split(' ');
            string[] testArray = source.Split(' ');
            int lengthSuorce = sourceArray.Length;
            int lengthTest = testArray.Length;
            int[, ] M = new int[lengthTest, lengthSuorce];
            for(int i = 1; i <= lengthSuorce; i++)
            {
                for(int j = 1; j <= lengthTest; j++)
                {
                    if (testArray[j].Equals(sourceArray[i]))
                    {
                        M[i, j] = M[i - 1, j - 1];
                    }
                    else
                    {
                        M[i,j]= M[i, j] = M[i, j - 1] > M[i - 1, j] ? M[i, j - 1] : M[i - 1, j];
                    }
                }
            }
            string result = "";
            for ( int i = 0; i < lengthSuorce; i++)
            {
                if (M[i + 1, lengthTest] == M[i, lengthTest] + 1)
                {
                    result += sourceArray[i];

                }
            }
            string r = result.ToString();
            return (r.Length / source.Length)*100;
        }
    }
}