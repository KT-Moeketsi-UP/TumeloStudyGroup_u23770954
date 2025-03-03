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
                new StudyGroupMember { StudentNumber = 12345678, Name = "John", Surname = "Doe", Email = "john.doe@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 23456789, Name = "Jane", Surname = "Smith", Email = "jane.smith@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 34567890, Name = "Mike", Surname = "Brown", Email = "mike.brown@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 45678901, Name = "Emily", Surname = "Johnson", Email = "emily.johnson@tuks.co.za" },
                new StudyGroupMember { StudentNumber = 56789012, Name = "Alice", Surname = "Taylor", Email = "alice.taylor@tuks.co.za" }
            };
            return View(members);
        }
    }
}