using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmedAppointmentsController : ControllerBase
    {
        IConfirmedAppointmentService _confirmedAppointmentService;
        public ConfirmedAppointmentsController(IConfirmedAppointmentService confirmedAppointmentService)
        {
            _confirmedAppointmentService = confirmedAppointmentService;
        }

        [HttpGet("getallbysalonıd")]
        public IActionResult GetAllBySalonId(int id)
        {
            var result = _confirmedAppointmentService.GetAllBySalonId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbyuserıd")]
        public IActionResult GetAllByUserId(int id)
        {
            var result = _confirmedAppointmentService.GetAllByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbyıd")]
        public IActionResult GetAllById(int id)
        {
            var result = _confirmedAppointmentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addconfirmedAppointment")]
        public IActionResult Add(ConfirmedAppointment confirmedAppointment)
        {
            var result = _confirmedAppointmentService.Add(confirmedAppointment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateconfirmedAppointment")]
        public IActionResult Update(ConfirmedAppointment confirmedAppointment)
        {
            var resultowner = checkOwner(confirmedAppointment.CustomerId);
            if (resultowner == false)
            {
                return Unauthorized();
            }
            var result = _confirmedAppointmentService.Update(confirmedAppointment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteconfirmedAppointment")]
        public IActionResult Delete(ConfirmedAppointment confirmedAppointment)
        {
            var resultowner = checkOwner(confirmedAppointment.CustomerId);
            if (resultowner == false)
            {
                return Unauthorized();
            }
            var result = _confirmedAppointmentService.Delete(confirmedAppointment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        public bool checkOwner(int userId)
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (id == null)
            {
                return false;
            }
            var currentUserId = int.Parse(id);
            return currentUserId != userId ? false : true;
        }
    }
}
