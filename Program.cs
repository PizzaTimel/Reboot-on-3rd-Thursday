using System.Diagnostics;
namespace dotnet6
{
    class Program
    {
        static void Main()
        {
            if (Thursday.Checkdate() == true)
            {
                Process.Start("shutdown","/f /r /t 0");                
            }
        }
        
    }
}
