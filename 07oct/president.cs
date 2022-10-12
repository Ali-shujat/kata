using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Resting.API.Data;
using System.Collections.Generic;

namespace Resting.API.Controllers
{

  public class President
  {
    [Key]
    [Required]
    public string Id { get; set; }
    public string Name { get; set; }
    public string From { get; set; }
    public string To { get; set; }
  }

  public class AddPresidentRequest
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public string From { get; set; }
    public string To { get; set; }
  }

  public class UpdatePresidentRequest
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public string From { get; set; }
    public string To { get; set; }
  }

  [ApiController]
  [Route("/api/presidents")]
  public class PresidentsController : ControllerBase
  {
    private IPresidentRepository _repo;
    public PresidentsController(IPresidentRepository repo)
    {
      _repo = repo;
    }
    
    [HttpGet]
    public ActionResult<List<President>> GetAllPresidents()
    {
        return Ok(_repo.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<President> GetOnePresident(string id)
    {
        var president = _repo.GetOne(id);
        if (president == null) return NotFound();
        return Ok(president);
    }

    [HttpPost]
    public ActionResult<President> AddNewPresident(string name, string from, string to, AddPresidentRequest addRequest)
    {
      var president = _repo.Create(addRequest.Name, addRequest.From, addRequest.To);  
      return  Created($"http://localhost/api/presidents/{president.Id}", president);
    }

    [HttpPut("{id}")]
    public ActionResult<President> UpdatePresident(string id, UpdatePresidentRequest updateRequest)
    {
      if (_repo.GetOne(id) == null)
      {
        return NotFound();
      }
        var president = _repo.Update(id, updateRequest.Name, updateRequest.From, updateRequest.To);
        return Ok(president);
    }

    [HttpDelete("{id}")]
    public ActionResult<President> DeletePresident(string id)
    {
      _repo.Delete(id);
      return null; 
    }
  }
}