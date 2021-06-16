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
    public class CategoriasController : ControllerBase
    {

        #region Singleton

        CategoriaOperations data = CategoriaOperations.Instance();

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
                    message = "Error al consultar categoría",
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
                    message = "Error al consultar categoría",
                    data = "null"


                });
            }
        }

        // POST api/<ClientesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Categoria newData)
        {

            if (data.Add(newData) > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Categoría creado"



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al crear categoría",



                });
            }
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Categoria newData)
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
                        message = "Categoría modificada"



                    });

                }
                else
                {
                    return StatusCode(StatusCodes.Status401Unauthorized, new
                    {
                        status = false,
                        message = "Error al modificar categoría",



                    });
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al modificar categoría",



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
                    message = "Categoría eliminado",



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al eliminar Categoría",



                });
            }
        }
    }
}
