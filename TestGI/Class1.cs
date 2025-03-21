using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGI
{
    class Class1
    {
        public string textQuestion;
        public int rightAnswer;
        public Class1(string text,int answer)
        {
            textQuestion = text;
            rightAnswer = answer;
        }
        public string Print()
        {
            return textQuestion;
        }
    }
}
