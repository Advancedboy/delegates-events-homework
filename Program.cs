using System;

namespace Homework
{
    internal class Program
    {
    //    public delegate void MyDelegate(int value);
    //    public Action Action;
    //    public Func<float, int> Func;
        static void Main(string[] args)
        {
            #region Delegate
            //Action action = ActionMethod1;
            //action += ActionMethod2;
            //action.Invoke();
            //MyDelegate myDelegate = Method1;
            //MyDelegate myDelegate2 = Method2;
            //myDelegate.Invoke(10);
            //myDelegate2.Invoke(10);

            //Func<float, int> func = Method3;
            //int a = func.Invoke(10.12f);
            //Console.WriteLine(a);
            #endregion
            Car car = new Car
            {
                Name = "Porsche Cayman"
            };

            car.OverSpeed += Car_OverSpeed;
            car.DriveAtSameSpeed += Car_DriveAtSameSpeed;
            car.SpeedTest(10.12f);
            Console.ReadLine();
        }

        private static void Car_DriveAtSameSpeed(object sender, EventArgs e)
        {
            if(sender is Car)
            {
                Console.WriteLine("Speed is ok!");
            }
        }

        private static void Car_OverSpeed()
        {
            Console.WriteLine("SLOW DOWN!!!");
        }
        //static void ActionMethod1()
        //{
        //    Console.WriteLine("ActionMethod1");
        //}
        //static void ActionMethod2()
        //{
        //    Console.WriteLine("ActionMethod2");
        //}
        //static void Method1(int i)
        //{
        //    Console.WriteLine($"Method 1, int i: {i}.");
        //}
        //static void Method2(int i)
        //{
        //    Console.WriteLine($"Method 2, int i: {i}.");
        //}

        //static int Method3(float a)
        //{
        //    Console.WriteLine($"Method 3: {a}");
        //    return (int)a;
        //}
    }
}
