using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // No Thread Safe Singleton
            Console.WriteLine(" --- No Thread Safe Singleton ---");
            var noThreadSafeSingletonInstance = NoThreadSafeSingleton.DatabaseConnection.Instance;
            Console.WriteLine(noThreadSafeSingletonInstance.ConnectionString);

            // Thread Safety Singleton
            Console.WriteLine(" --- Thread Safety Singleton ---");
            var threadSafetySingletonInstance = ThreadSafetySingleton.DatabaseConnection.Instance;
            Console.WriteLine(threadSafetySingletonInstance.ConnectionString);


            // Thread Safety Singleton using Double Check Locking
            Console.WriteLine(" --- Thread Safety Singleton using Double Check Locking ---");
            var threadSafetySingletonLockingInstance = ThreadSafetySingletonWithLock.DatabaseConnection.Instance;
            Console.WriteLine(threadSafetySingletonLockingInstance.ConnectionString);


            // Thread Safe Singleton without using locks and no lazy instantiation
            Console.WriteLine(" --- Thread Safe Singleton without using locks and no lazy instantiation ---");
            var threadSafetySingletonWithoutLockInstance = ThreadSafetySingletonWithoutLock.DatabaseConnection.Instance;
            Console.WriteLine(threadSafetySingletonWithoutLockInstance.ConnectionString);


            // Fully lazy instantiation
            Console.WriteLine(" --- Fully lazy instantiation ---");
            var fullyLazyInstantiationInstance = FullyLazyInstantiation.DatabaseConnection.Instance;
            Console.WriteLine(fullyLazyInstantiationInstance.ConnectionString);


            //  Using .NET 4's Lazy
            Console.WriteLine(" --- Using .NET 4's Lazy ---");
            var net4sLazy = NET4sLazy.DatabaseConnection.Instance;
            Console.WriteLine(net4sLazy.ConnectionString);
        }
    }
}


