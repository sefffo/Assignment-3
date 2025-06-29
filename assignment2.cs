namespace Assignemt2
{

    class myclass
    {
        public int num;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //    int s;
            //    s=int.Parse(Console.ReadLine());
            //    Console.WriteLine(s);
            //}
            #endregion

            #region 2

            //int a = 10;
            //int b = 5;


            //b = a;
            //b = 20;


            //b will change and a still with no change




            #endregion

            #region 3

               myclass obj1 = new myclass();
               myclass obj2 = new myclass();

               obj1.num = 10;
               obj2.num = 20;

               obj2 = obj1;

               obj2.num = 30;
                //obj

               Console.WriteLine(obj1.num);
               Console.WriteLine(obj2.num);
                                           
               

                


            #endregion




        }
    }
}
