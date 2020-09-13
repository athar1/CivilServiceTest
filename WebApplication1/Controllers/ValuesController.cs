using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://bpdts-test-app.herokuapp.com/users");
                var data = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<List<User>>(data);
                var filterUsers = new filterUsers();
                var filteredUsers = filterUsers.filterUsersWithin50Miles(users);
                return filteredUsers;
            }
        }

        
    }
}
