using HumanResourceSystem.Data;
using HumanResourceSystem.Model;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Description;

namespace HumanResourceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaboratorController : ControllerBase
    {
        private readonly DataContext _context;

        public CollaboratorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Collaborator>>> GetAllCollaborators()
        {
            return Ok(await _context.Collaborators.ToListAsync());
        }

        [HttpGet("id")]
        public async Task<ActionResult<Collaborator>> GetCollaborator(Collaborator id)
        {
            if(id == null)
            {
                return BadRequest("Collaborator not found");
            }

            return Ok(await _context.Collaborators.FindAsync(id));
        }

        //[HttpGet]
        //public async Task test()
        //{
        //    string response
        //}

        //[HttpGet]
        //public IQueryable<CollaboratorDto> GetCollaborators()
        //{
        //    var collaborator = from c in _context.Collaborators
        //                       select new CollaboratorDto()
        //                       {
        //                           Id = c.Id,
        //                           FirstName = c.FirstName,
        //                           Insertion = c.Insertion,
        //                           LastName = c.LastName
        //                       };
        //    return collaborator;
        //}


    }
}
