using apiCharlsShoes.Data;
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
{   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<ClientesController>


        #region Singleton

        ClienteOperations cliente = ClienteOperations.Instance();

        #endregion


        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if (cliente.GetAll().Count() > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message ="Consulta exitosa",
                    data = cliente.GetAll(),
                    

                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al consultar clientes",
                    data= "null"

                   
                });
            }


        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (cliente.GetById(id) !=null)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Consulta exitosa",
                    data = cliente.GetById(id),


                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al consultar cliente",
                    data = "null"


                });
            }
        }

        // POST api/<ClientesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cliente newCliente )
        {

            if (cliente.Add(newCliente) >0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Cliente creado"
                  


                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al crear cliente",
                


                });
            }
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] Cliente newCliente)
        {


            var cli = cliente.GetById(id);

            if (cli != null)
            {


                cli.apellidoM = newCliente.apellidoM;
                cli.apellidoP = newCliente.apellidoP;
                cli.direccion = newCliente.direccion;
                cli.descuento = newCliente.descuento;
                cli.nombre = newCliente.nombre;
                cli.telefono = newCliente.telefono;
                   

                

                if (cliente.Update(cli) > 0)
                {
                    return StatusCode(StatusCodes.Status201Created, new
                    {
                        status = true,
                        message = "Cliente modificado"



                    });

                }
                else
                {
                    return StatusCode(StatusCodes.Status401Unauthorized, new
                    {
                        status = false,
                        message = "Error al modificar cliente",



                    });
                }
            }
            else {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al modificar cliente",



                });
            }
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (cliente.Delete(id) >0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Cliente eliminado",
                 


                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al eliminar cliente",
                 


                });
            }
        }
    }
}
