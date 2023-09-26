using DAL.Models;
using ENTIDADES.Data_Contract;
using ENTIDADES;
using ENTIDADES.Request;

namespace DAL
{
    public class ComputerManager
    {
        computadorasBDContext _context = new computadorasBDContext(); 
        public Response GetComputer(string id) {
            Computer computer;
            try
            {
                computer = _context.Computers.Find(id);
            }
            catch (Exception e){
                Response response = new Response();
                response.message= "No se pudo relizar la busqueda de la computadora";
                response.description = e.ToString();
                response.errorCode = 200;
                return response;
            }
            ENTIDADES.Computadora resp = new Computadora();
            resp.Id = computer.Id;
            resp.Model = computer.Model;
            resp.Brand = computer.Brand;
            resp.Price = computer.Price;
            resp.Size = computer.Size;
            resp.message = "Computadora encontrada con éxito";
            resp.errorCode = 200;
            return resp;
        }
        public Response addComputer(ComputerReq req)
        {
            Response response = new Response();
            try
            {
                Computer comp = new Computer();
                comp.Id = codeGenerator(req);
                comp.Model = req.Model;
                comp.Brand = req.Brand;
                comp.Price = req.Price;
                comp.Size = req.Size;
                _context.Computers.Add(comp);
                _context.SaveChanges();

                ENTIDADES.Computadora resp = new Computadora();
                resp.Id = comp.Id;
                resp.Model = comp.Model;
                resp.Brand = comp.Brand;
                resp.Price = comp.Price;
                resp.Size = comp.Size;
                resp.message = "Computadora insertada con éxito";
                resp.errorCode = 200;
                return resp;
            }
            catch(Exception e)
            {
                response.message = e.Message;
                response.description = e.ToString();
                response.errorCode = 200;
                return response;
            }
        }
        public string codeGenerator(ComputerReq req)
        {
            Random rand = new Random();
            string code = rand.Next(1000).ToString();
            return code;
        }
    }
}