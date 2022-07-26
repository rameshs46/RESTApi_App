using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTApi_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendController : ControllerBase
    {
        public List<Friend> GetFriends()
        {
            List<Friend> friends = new List<Friend>(3);
            friends.Add(new Friend("Bhuvanesh", "Jayaprakash", "Vriddhachalam"));
            friends.Add(new Friend("Anand", "KS", "Vriddhachalam"));
            friends.Add(new Friend("Natesan", "K", "Chennai"));

            return friends;
        }
    }
}
