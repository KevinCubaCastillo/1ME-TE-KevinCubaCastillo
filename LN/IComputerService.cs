﻿using ENTIDADES.Data_Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public interface IComputerService
    {
        public Response GetComputer(int id)
        {
            return new Response();
        }
    }
}
