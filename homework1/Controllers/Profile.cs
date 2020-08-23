using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace homework1.Controllers
{
    public class Profile : Controller
    {
        public IActionResult Index()
        {
            var work = ("MultiCamp 19", "KMUTT 4life ", "Appman Agentmate", "Web Advisor");
            ViewData["work1"] = work.Item1;
            ViewData["work2"] = work.Item2;
            ViewData["work3"] = work.Item3;
            ViewData["work4"] = work.Item4;
            var fullname = ("Nichkamon Promputta", "61080500262");
            ViewData["Name"] = fullname.Item1;
            ViewData["Idnum"] = fullname.Item2;
            return View();
        }

        public IActionResult Aboutme()
        {
            var fullname = ("Nichkamon Promputta\r\n", "61080500262");
            ViewData["Name"] = fullname.Item1;
            ViewData["Idnum"] = fullname.Item2;
            ViewData["Namenum"] = fullname.Item1 + fullname.Item2;
            var work = ("MultiCamp 19", "KMUTT 4life ", "Appman Agentmate", "Web Advisor");
            ViewData["work1"] = work.Item1;
            ViewData["work2"] = work.Item2;
            ViewData["work3"] = work.Item3;
            ViewData["work4"] = work.Item4;
            var info = ("5 December 1999", "Bankok\r\n", "Thailand", "King Mongkut University of technology thonburi\r\n", "(KMUTT)\r\n");
            ViewData["Birth"] = info.Item1;
            ViewData["Home"] = info.Item2 + info.Item3;
            ViewData["Edu"] = info.Item4 + info.Item5;
            var head = ("Birthday :", "Address :", "Education :", "Work Experience :");
            ViewData["h1"] = head.Item1;
            ViewData["h2"] = head.Item2;
            ViewData["h3"] = head.Item3;
            ViewData["h4"] = head.Item4;
            return View();
        }

        public IActionResult Skill()
        {
            var tool = ("HTML\r\n", "CSS\r\n", "Javascript\r\n", "React.js\r\n", "Vue.js\r\n", "Node.js\r\n", "Docker\r\n", "Python", "C#\r\n", "C++\r\n", "Design\r\n", "Another");
            ViewData["dev1"] = tool.Item1 + tool.Item2 + tool.Item3;
            ViewData["dev2"] = tool.Item4;
            ViewData["dev3"] = tool.Item5;
            ViewData["dev4"] = tool.Item6;
            ViewData["dev5"] = tool.Item7;
            ViewData["dev6"] = tool.Item8 + tool.Item9 + tool.Item10;
            ViewData["dev7"] = tool.Item11 + tool.Item12;
            return View();
        }

        public IActionResult Contact()
        {
            var tacttitle = ("Email Address", "Facebook", "Telephone");
            ViewData["ti1"] = tacttitle.Item1;
            ViewData["ti2"] = tacttitle.Item2;
            ViewData["ti3"] = tacttitle.Item3;
            var tactname = ("fainichkamon@gmail.com", "Nichkamon Promputta", "faiichann 0643956141");
            ViewData["name1"] = tactname.Item1;
            ViewData["name2"] = tactname.Item2;
            ViewData["name3"] = tactname.Item3;
            return View();
        }
    }
}
