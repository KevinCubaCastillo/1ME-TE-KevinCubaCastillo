using DAL.Models;
using ENTIDADES.Data_Contract;
using ENTIDADES;
namespace DAL
{
    public class ComputerManager
    {
        computadorasBDContext _context; 
        public Response GetComputer(int id) {
            try
            {
                Computer computer = _context.Computers.Find(id);
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
            catch (Exception e){
                Response resp = new Response();
                resp.message= "No se pudo relizar la busqueda de la computadora";
                resp.description = e.ToString();
                resp.errorCode = 200;
                return new Response();
            }
        }
    }
}