using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amif_practice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amif_practice.Controllers
{

    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public String Index()
        {
            return "Hello World";
        }

        public String Welcome(String name, int id=1)
        {
            List<User> user_list = database.getAllUsers();
            return $"名前：{user_list[0].name}さん, ID：{user_list[0].id}";
        }
    }
}

