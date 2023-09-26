using DAL;
using ENTIDADES.Data_Contract;
using ENTIDADES.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN
{
    public interface IComputerService
    {
        public Response GetComputer(string id)
        {
            ComputerManager computerManager = new ComputerManager();
            Response resp = computerManager.GetComputer(id);
            if (resp.errorCode == 0)
            {
                Response response = new Response();
                response.errorCode = 200;
                response.message = "No se encontraron computadoras con ese ID";
                return response;
            }
            else
            {
                return resp;
            }
        }
        public Response addComputer(ComputerReq req)
        {
            ComputerManager computerManager = new ComputerManager();
            Response resp = computerManager.addComputer(req);
            if (resp.errorCode == 0)
            {
                Response response = new Response();
                response.errorCode = 200;
                response.message = "No se encontraron computadoras con ese ID";
                return response;
            }
            else
            {
                return resp;
            }
        }
    }
}
