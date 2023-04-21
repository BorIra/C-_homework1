using System;
using System.Linq;
namespace Happy
{
    public class Question
    {
        public string Quest;
        public List <string> Ans;
        public int TrueAns;
        public string comment;

        public Question(List<string> str, int answer, string comentToAnswer)
        {
            Quest = str[0];
            Ans = str.Skip(1).ToList(); 
            TrueAns = answer;       
            comment = comentToAnswer;
        }

        public void OutputQuestion()
        {
            Console.WriteLine(Quest);
            for(int i = 0; i < 4; i++)
                Console.WriteLine("{0}. {1}", i+1, Ans[i]);
        }

        public void OutputFifthyFifthy()
        {
            Random rand = new Random();
            int falseVariant;
            do 
            {
                falseVariant = rand.Next(0, 4);
                //Console.WriteLine($"falseVariant={falseVariant}, ans ={TrueAns}");
            }
            while ((falseVariant+1) == TrueAns);
            
            if (falseVariant < TrueAns)
            {
                Console.WriteLine($"{falseVariant+1}. { Ans[falseVariant]}");
                Console.WriteLine($"{TrueAns}. { Ans[TrueAns-1]}");
            }
            else
            {
                Console.WriteLine($"{TrueAns}. { Ans[TrueAns-1]}");
                Console.WriteLine($"{falseVariant+1}. { Ans[falseVariant]}");
            }

        }
     
    }
}