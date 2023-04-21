using ASPNETCoreWebAPICRUDEFCodeFirstApproach.Data;
using ASPNETCoreWebAPICRUDEFCodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWebAPICRUDEFCodeFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly userscontext con;

        public UsersController(userscontext con)
        {
            this.con = con;
        }

        [HttpGet]
        [Route("get")]
        public IEnumerable<Users> Get()
        {
            return con.Users.ToList();
        }
        [HttpPost]
        [Route("add")]
        public string Post(Users u1)
        {
            con.Users.Add(u1);
            con.SaveChanges();
            return "success";
        }
        [HttpPut]
        [Route("update")]
        public string Put(Users u1)
        {
            con.Entry(u1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            con.SaveChanges();
            return "Update Successfully";
        }
        [HttpDelete]
        [Route("delete")]
        public string Delete(int id)
        {

            var result = con.Users.Where(test => test.ID == id).FirstOrDefault();
            if (result != null)
            {
                con.Users.Remove(result);
                con.SaveChanges();
                return "Deleted Successfully";
            }
            return "Deleted Unsuccessfully";
        }
        [HttpGet]
        [Route("details/{id}")]
        public Users Get(int id)
        {
            return con.Users.Where(test => test.ID == id).FirstOrDefault();

        }


    }
}
