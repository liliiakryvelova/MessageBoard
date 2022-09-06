using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;
using System.Linq;
using System;

namespace MessageBoard.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MessagesController : ControllerBase
  {
    private readonly MessageBoardContext _db;

    public MessagesController(MessageBoardContext db)
    {
      _db = db;
    }

    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Message>>> GetByDate(DateTime startDate, DateTime endDate)
    // {
    //     var timeRecords = from m in _db.Messages
    //                       where (m.Date >= startDate && m.Date <= endDate)
    //                       select m;
    //         return await timeRecords.ToListAsync();
    // }
    // GET api/messages
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Message>>> Get(string groupname, DateTime startDate, DateTime endDate)
    {
     var query = _db.Messages.AsQueryable();
     if(groupname != null){
        query = from m in _db.Messages
                join c in _db.Categories
                on m.CategoryId equals c.CategoryId
                where c.CategoryName == groupname
                select m;
              // return joinResult.ToList();
     }
     if( startDate != null && endDate != null)
     {
        query = query.Where(entry => (entry.Date >=startDate) && (entry.Date <= endDate));
     }
      return await query.ToListAsync();
    }

    // POST api/messages
    [HttpPost]
    public async Task<ActionResult<Message>> Post(Message message)
    {
      _db.Messages.Add(message);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = message.MessageId }, message);
    }

    // GET: api/Messages/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Message>> GetById(int id)
    {
        var message = await _db.Messages.FindAsync(id);

        if (message == null)
        {
            return NotFound();
        }

        return message;
    }

    // //GET: api/Messages/?groupname=home
    // [HttpGet("{groupname}")]
    // public async Task<ActionResult<IEnumerable<SearchMessagesByCategory>>> GetGroup(string groupname)
    // {
    //   if(groupname != null){
    //     var joinResult = from m in _db.Messages
		// 	          join c in _db.Categories on m.CategoryId equals c.CategoryId
		// 	          where c.CategoryName == groupname
		// 	          select new SearchMessagesByCategory(
    //               c.CategoryName,
    //               m.Description);
    //     return await joinResult.ToListAsync();
    //   }
    //   else{
    //     var unsortedList = from m in _db.Messages
		// 	          join c in _db.Categories on m.CategoryId equals c.CategoryId
		// 	          select new SearchMessagesByCategory(
    //               c.CategoryName,
    //               m.Description);
    //      return await unsortedList.ToListAsync();      
    //   }
    // }

     // PUT: api/Animals/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Message message)
    {
      if (id != message.MessageId)
      {
        return BadRequest();
      }

      _db.Entry(message).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!MessageExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }
    private bool MessageExists(int id)
    {
      return _db.Messages.Any(e => e.MessageId == id);
    }
  }
}         