using System;
using System.Linq;
namespace Happy
{
    public class Question
    {
        public string Quest;
        public List <string> Ans;
        public int TrueAns;

        public Question(List<string> str, int answer)
        {
            Quest = str[0];
            Ans = str.Skip(1).ToList(); 
            TrueAns = answer;       
        }

        public void Output()
        {
            Console.WriteLine(Quest);
            for(int i = 0; i < 4; i++)
                Console.WriteLine("{0}. {1}", i+1, Ans[i]);
        }
     
    }
}