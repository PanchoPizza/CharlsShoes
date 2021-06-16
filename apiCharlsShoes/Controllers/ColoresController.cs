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
    public class ColoresController : ControllerBase
    {
        #region Singleton

        ColorOperations data = ColorOperations.Instance();

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
                    message = "Error al consultar color",
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
                    message = "Error al consultar color",
                    data = "null"


                });
            }
        }

        // POST api/<ClientesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Color newData)
        {

            if (data.Add(newData) > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Color creado"



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al crear color",



                });
            }
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Color newData)
        {


            var item = data.GetById(id);

            if (item != null)
            {


                item.descripcion = newData.descripcion;





                if (data.Update(item) > 0)
                {
                    return StatusCode(StatusCodes.Status201Created, new
                    {
                        status = true,
                        message = "Color modificado"



                    });

                }
                else
                {
                    return StatusCode(StatusCodes.Status401Unauthorized, new
                    {
                        status = false,
                        message = "Error al modificar color",



                    });
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al modificar color",



                });
            }
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (data.Delete(id) > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Color eliminado",



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al eliminar Color",



                });
            }
        }
    }
}
