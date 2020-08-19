using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Aula1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Aula1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControleAula1 : ControllerBase
    {
        [HttpGet]
        public Pessoa MetodoGet ()
        {
            
            Pessoa pessoa = new Pessoa();
            pessoa.ID = 1;
            pessoa.Nome = "Bruno";
            pessoa.Idade = 20;
            return pessoa;

        }
        [HttpPost]
        public string MetodoPost([FromBody] Pessoa pessoa)
        {
            pessoa.ID = 1;
            return $"{pessoa.ID} ? MetodoPost - OK";
        }

        [HttpPut]
        public Pessoa MetodoPut(int id)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.ID = 2;
            pessoa.Nome = "Carol";
            pessoa.Idade = 25;

            return pessoa;

        }
        [HttpDelete]
        public string MetodoDelete(int id)
        {
            return "Metodo Delete - OK";
        }

    }
}
