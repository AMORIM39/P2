using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    using System;

    public class ConsoleLogger : ILogger
    {
        public void Log(string mensagem)
        {
            Console.WriteLine("[LOG] " + mensagem);
        }
        // Interface de log: atende ao ISP (pequena e coesa)
    }
}
