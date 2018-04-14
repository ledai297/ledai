using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListenAndWrite.Models.BusinessModel
{
    public class ScoreModel
    {
        public int GetScore(string source,string test)
        {
            return (int)(test.Length) / (source.Length);
        }
    }
}