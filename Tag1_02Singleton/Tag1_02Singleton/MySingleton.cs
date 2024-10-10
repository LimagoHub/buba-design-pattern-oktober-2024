using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_02Singleton
{
    public class MySingleton
    {
        private static MySingleton instance = null;

        public static MySingleton GetInstance()
        {
            if(instance == null)
            {
                instance = new MySingleton();
            }
            return instance;
        }
       
        private MySingleton()
        {
            
        }

        public virtual void doSomething(string message)
        {
            Console.WriteLine(message);
        }
    }
}
