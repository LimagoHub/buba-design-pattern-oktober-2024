using System.Reflection;
using Tiere;

namespace Tag3_4Reflection;

class Program
{
    static void Main(string[] args)
    {
        Type type = typeof(Schwein);
        type = new Schwein().GetType();
        Assembly currentAssem = Assembly.GetExecutingAssembly();
        type = currentAssem.GetType("Tiere.Schwein");
        
        Console.WriteLine(type.Name);
        
        MethodInfo[] methodInfos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach(MethodInfo info in methodInfos)
        {
            Console.WriteLine(info.Name);

        }
        
        MethodInfo mi = type.GetMethod("Fressen",BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        
        ConstructorInfo ci = type.GetConstructor(new Type[] { typeof(string) });
        
        object obj = ci.Invoke(new object[] { "Miss Piggy"});
        Console.WriteLine(obj);
        mi.Invoke(obj, new object[]{});
        Console.WriteLine(obj);
    }
}