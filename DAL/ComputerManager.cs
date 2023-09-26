using DAL.Models;
using ENTIDADES.Data_Contract;
using ENTIDADES;
namespace DAL
{
    public class ComputerManager
    {
        computadorasBDContext _context = new computadorasBDContext(); 
        public Response GetComputer(int id) {
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
                return new Response();
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
    }
}