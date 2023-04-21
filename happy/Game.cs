using System;
using System.IO;
namespace Happy
{
    class Game
    {
        bool fiftyFifty = true;
        bool life = true;
        int coins = 0;
        int sum = 0;
        int ind = 0;
        List<Question> questions = new();

        public Game()
        {
            StreamReader sr = new StreamReader("FileQuestions", System.Text.Encoding.Default);
            while (sr.EndOfStream != true)
            {
                questions.Add(new Question(new List<string> {
                sr.ReadLine(),
                sr.ReadLine(),
                sr.ReadLine(),
                sr.ReadLine(), 
                sr.ReadLine() 
              }, Convert.ToInt32(sr.ReadLine()), sr.ReadLine()));
            }
        }
        
        public void Run()
        {
            foreach(var q in questions)
                {
                    q.OutputQuestion();
                    if (fiftyFifty) Console.WriteLine("5. Вы можете воспользоваться подсказкой 50/50!");
                    int ans = int.Parse(Console.ReadLine());
                    if (ans == 5) 
                    {
                        fiftyFifty = false;
                        q.OutputFifthyFifthy();
                        ans = int.Parse(Console.ReadLine());
                    }
                    if(ans == q.TrueAns) 
                    {
                        ind++;
                        coins += (int) Math.Pow(2, ind);
                        Console.WriteLine($"Вы правы! {q.comment}. У вас {coins} очков!");
                        //Console.WriteLine("Вы правы! У вас {0} очков!", coins);
                    }
                    else
                    {
                        if(life) 
                        {
                            life = false;
                            Console.WriteLine($"Вы не правы! {q.comment}. У вас {coins} очков!");
                        }
                        else 
                        {
                            Console.WriteLine($"Вы не правы! {q.comment}. Игра окончена! У вас {coins} очков!");
                            break;
                        }
                    }
                }

        }

    }
}