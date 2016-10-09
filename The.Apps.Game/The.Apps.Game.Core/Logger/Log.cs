using System;
namespace The.Apps.Game.Core.Logger
{
    public static class Log
    {
        public static void Error(string message, Exception exception = null)
        {
            Console.WriteLine(message);
            if (exception != null)
                Console.WriteLine(exception.Message);
        }
    }
}
