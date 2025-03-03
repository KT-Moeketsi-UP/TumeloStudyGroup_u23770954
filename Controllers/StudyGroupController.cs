using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TumeloStudyGroup.Models;

namespace TumeloStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<StudyGroupMember> members = new List<StudyGroupMember>
            {
                new StudyGroupMember { StudentNumber = 23770954, Name = "Tumelo", Surname = "Moeketsi", Email = "u23770954@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 24924718, Name = "Gundo", Surname = "Ndou", Email = "u24924718@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 23646952, Name = "Ahmeed", Surname = "-", Email = "u23646925@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 23684722, Name = "Vishal", Surname = "Bhagwan", Email = "23684722@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 24954162, Name = "Nomcebo", Surname = "Mathe", Email = "u24954162@tuks.co.za" }
            };
            return View(members);
        }
    }
}