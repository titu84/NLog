using NLog;
using System;
using Logger_ToFile;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplicationTestNLog
{
    class Program
    {    
        static void Main(string[] args)
        {
            LoggToFile l = new LoggToFile(System.Reflection.Assembly.GetExecutingAssembly().FullName);
            try
            {
                l.Info(System.Reflection.MethodBase.GetCurrentMethod().ToString(), Console.ReadLine());                
                Console.ReadKey();
                throw new Exception("straszne", new NullReferenceException());
            }
            catch (Exception ex)
            {
                l.Error(System.Reflection.MethodBase.GetCurrentMethod().ToString(), ex.Message + Environment.NewLine + ex.InnerException);
            }
        }
    }  
}
