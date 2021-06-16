using CharlsShoes.BLL;
using CharlsShoes.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiCharlsShoes.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {


        #region Singleton

        VentaOperations data = VentaOperations.Instance();

        #endregion


        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {


            if (data.GetAll().Count() > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Consulta exitosa",
                    data = data.GetAll(),


                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al consultar ventas",
                    data = "null"


                });
            }


        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (data.GetById(id) != null)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Consulta exitosa",
                    data = data.GetById(id),


                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al consultar venta",
                    data = "null"


                });
            }
        }

        // POST api/<ClientesController>
       
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Venta newData)
        {

            if (data.Add(newData) !=null)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Venta creada"



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al crear Venta",



                });
            }
        }

    }
}
