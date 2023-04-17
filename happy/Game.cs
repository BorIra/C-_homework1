using System;
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
            for(int i = 0; i < 3; i ++)
              questions.Add(new Question(new List<string> {
                "Что растёт в огороде?",
                "Лук",
                "Пистолет",
                "Пулемёт", 
                "Ракета" 
              }, 1));

        }
        
        public void Run()
        {
            foreach(var q in questions)
                {
                    q.Output();
                    int ans = int.Parse(Console.ReadLine());
                    if(ans == q.TrueAns) 
                    {
                        ind++;
                        coins += (int) Math.Pow(2, ind);
                        Console.WriteLine("Вы правы! У вас {0} очков!", coins);
                    }
                    else
                    {
                        if(life) 
                        {
                            life = false;
                            Console.WriteLine("Вы не правы! У вас {0} очков!", coins);
                        }
                        else 
                        {
                            Console.WriteLine("Игра окончена! У вас {0} очков!", coins);
                            break;
                        }
                    }
                }

        }

    }
}