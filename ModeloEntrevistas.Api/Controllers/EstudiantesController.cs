using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModeloEntrevistas.Core.Entities;
using ModeloEntrevistas.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloEntrevistas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public EstudiantesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEstudiante(int id) => Ok(await _unitOfWork.EstudiantesRepository.GetById(id));
        
        [HttpGet(Name = nameof(GetEstudiantes))]
        public IActionResult GetEstudiantes() =>  Ok(_unitOfWork.EstudiantesRepository.GetAll());

        [HttpPost]
        public async Task<IActionResult> InsertEstudiantes(Estudiantes estudiante)
        {

            await _unitOfWork.EstudiantesRepository.Add(estudiante);
            await _unitOfWork.SaveChangesAsync();
            return Ok("Estudiante Insertado Correctamente");
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, Estudiantes estudiante)
        {
            _unitOfWork.EstudiantesRepository.Update(estudiante);
            await _unitOfWork.SaveChangesAsync();
            return Ok("Estudiante Editado Correctamente");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _unitOfWork.EstudiantesRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return Ok("Estudiante Eliminado Correctamente");
        }

    }
}
