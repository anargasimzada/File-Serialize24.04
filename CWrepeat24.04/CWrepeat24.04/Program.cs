using System.Diagnostics;

namespace CWrepeat24._04
{
    internal class Program
    {
        static int Num;
        static object Ali = new object();
        static void Main(string[] args)
        {
           
            static void Main(string[] args)
            {
                /*Loop2();
                Loop1();*/
                /*Thread.Sleep(1000);
                Thread t1 = new Thread(Loop2);
                Thread t2 = new Thread(Loop1);
                t1.Start();
                t1.Join();
                t2.Start();        
                t2.Join();
                Console.WriteLine("salam");*/


                /* Parallel.Invoke(Loop1,Loop2);
                 Console.WriteLine("salam");*/
                /*
                 * 
                Thread t1 = new Thread(Increase);
                Thread t2 = new Thread(Decrease);
                t1.Start();
                t1.Join();
                t2.Start();
                t2.Join();
                Console.WriteLine(Num);*/

                #region Taks
                /*SeherYemeyi();*/
                SeherYemeyiAsync().Wait();
                #endregion

            }
            static async Task SeherYemeyiAsync()
            {
                Stopwatch sw = Stopwatch.StartNew();
                await Task.WhenAll(BoilSausageAsync(), PrepareTeaAsync(), SufreHazirlaAsync());
                /*await BoilSausageAsync();
                await PrepareTeaAsync();
                await SufreHazirlaAsync();*/
                Console.WriteLine(sw.ElapsedMilliseconds);
            }
            static async Task BoilSausageAsync()
            {
                await Task.Delay(5000);
                Console.WriteLine("sausage boiled");
            }
            static async Task PrepareTeaAsync()
            {
                Console.WriteLine("caydani dolduruq");
                await Task.Delay(3000);
                Console.WriteLine("su qaynadi,cay demlendi");
                Console.WriteLine("cay hazirdi");
            }
            static async Task SufreHazirlaAsync()
            {
                await Task.Delay(1500);
                Console.WriteLine("sufre hazirdi");

            }





            static void SeherYemeyi()
            {
                Stopwatch sw = Stopwatch.StartNew();
                PrepareTea();
                BoilSausage();
                SufreHazirla();
                Console.WriteLine(sw.ElapsedMilliseconds);
            }
            static void BoilSausage()
            {
                Thread.Sleep(5000);
                Console.WriteLine("sausage boiled");
            }
            static void PrepareTea()
            {
                Console.WriteLine("caydani dolduruq");
                Thread.Sleep(3000);
                Console.WriteLine("su qaynadi,cay demlendi");
                Console.WriteLine("cay hazirdi");
            }
            static void SufreHazirla()
            {
                Thread.Sleep(1500);
                Console.WriteLine("sufre hazirdi");
            }


            static void Increase()
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock (Ali)
                    {
                        Num++;
                    }
                }
            }
            static void Decrease()
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock (Ali)
                    {
                        Num--;
                    }

                }
            }
            static void Loop1()
            {
                for (int i = 0; i < 500; i++)
                {
                    Console.WriteLine(i);
                }
            }
            static void Loop2()
            {
                for (int i = -500; i < 0; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
