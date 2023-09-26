using ENTIDADES.Data_Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public class ComputerService : IComputerService
    {
        public string generateCode(string marca)
        {
            Random rand = new Random();
            string code = rand.Next(1000).ToString();
            return code;
        }


    }
}
