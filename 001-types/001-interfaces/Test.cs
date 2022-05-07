using System;

namespace _001_interfaces
{
    interface TestIE
    {
       void TestingMethod();
    }

    class Test : TestIE
    {
        private static Test instance = null;
        private static readonly object padlock = new object();

        public static Test Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new Test();
                }
                return instance;
            }
        }
    }
        public void TestingMethod()
        {
            Console.WriteLine("testing..");
        }
    }
}