using ElectrodomesticosApi.Model;
using ElectrodomesticosApi.Services;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectrodomesticosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectrodomesticosController : ControllerBase
    {
        private readonly object ElectrodomServices;

        public ElectrodomesticosController(object electrodomServices)
        {
            ElectrodomServices = electrodomServices;
        }

        // GET: api/<ElectrodomesticosController>
        [HttpGet]
        public ActionResult<IEnumerable<ElectrodomesticosModels>> GetAll()
        {
            var eletrodomesticos = ElectrodomServices.GetAll();
            return Ok(eletrodomesticos);
        }

        // GET api/<ElectrodomesticosController>/5
        [HttpGet("{id}")]
        public ActionResult<ElectrodomesticosModels> GetById(int id)
        {
            var electrodomestico = ElectrodomServices.GetById(id);
            if(electrodomestico == null)
                return NotFound();
            return Ok(electrodomestico);
        }

        // POST api/<ElectrodomesticosController>
        [HttpPost]
        public ActionResult<ElectrodomesticosModels> Save(ElectrodomesticosModels electrodomesticosModels)
        {
            var savedElectrodomestico = ElectrodomServices.Save(electrodomesticosModels);
            return CreatedAtAction(nameof(GetById), new {id = savedElectrodomestico.Id}, savedElectrodomestico);
        }

        // PUT api/<ElectrodomesticosController>/5
        [HttpPut("{id}")]
        public IActionResult Update(int id,ElectrodomesticosModels electrodomesticosModels)
        {
            var uptaded= _ElectrodomesticoService.Update(id,electrodomesticosModels);
            if (!uptaded)
                return NotFound();
            return NoContent();
        }

        // DELETE api/<ElectrodomesticosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _ElectrodomesticoService.Delete(id);
            if (!deleted)
                return NotFound();
            return NoContent();
        }
    }
}
