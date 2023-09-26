using ENTIDADES.Data_Contract;
using LN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1ME_TE_KevinCubaCastillo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        private IComputerService _computerService;
        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }

        [HttpGet("getById")]
        public Response Get(string id)
        {
            return _computerService.GetComputer(id);
        }

        [HttpPost ("addComputer")]
        public IActionResult addComputer()
        {
            Response oResponse = new Response();
            try
            {

            }catch (Exception ex)
            {
                oResponse.description = ex.Message;
            }
            return Ok(oResponse);
        }
    }
}
