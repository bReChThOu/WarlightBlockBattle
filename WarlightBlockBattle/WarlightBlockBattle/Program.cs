using System;
using WarlightBlockBattle.Core;

namespace WarlightBlockBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var debug = args != null && args.Length == 1 && args[0].Equals("debug", StringComparison.OrdinalIgnoreCase);

                using (var bot = new Bot())
                {
                    bot.Run(debug);
                }
            }
            catch (Exception ex)
            {
                var exitMsg = ex.Message + (ex.InnerException != null ? ex.InnerException.Message : "");
                Console.Error.Write("Bot crashed. Exception was: {0}", exitMsg);
            }
        }
    }
}
