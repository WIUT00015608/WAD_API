using ContactManagerAPI.DAL.Repositories.ContactRepository;
using ContactManagerAPI.DTO.Contact;
using ContactManagerAPI.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagerAPI.Controllers
{
    //Student ID is 00015608
    [Route("[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactRepository _contactRepo;
        public ContactController(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contacts = await _contactRepo.GetAllAsync();

            if (contacts == null)
            {
                return NotFound();
            }

            var contactDto = contacts.Select(s => s.ToContactDto());
            return Ok(contactDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var contact = await _contactRepo.GetByIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact.ToContactDto());
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment([FromBody] CreateContactDto contactDto)
        {
            var model = contactDto.ToCreateContact();
            await _contactRepo.CreateAsync(model);
            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model.ToContactDto());
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateComment([FromRoute] int id, [FromBody] UpdateContactDto updateContactDto)
        {
            var model = await _contactRepo.UpdateAsync(id, updateContactDto);
            //var stockModel = _context.Stocks.FirstOrDefault(x => x.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model.ToContactDto());
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var model = await _contactRepo.DeleteAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
