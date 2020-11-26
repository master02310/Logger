using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Starter
    {
        public void Run()
        {
            var rand = new Random();
            var action = new Actions();
            var log = Logger.GetInstance();

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int funcRandNum = rand.Next(1, 4);
                    switch (funcRandNum)
                    {
                        case 1:
                            action.Info();
                            break;
                        case 2:
                            action.Warning();
                            break;
                        case 3:
                            action.Error();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(log.NewMessage("Error", ex));
                }
            }
        }

    }
}
