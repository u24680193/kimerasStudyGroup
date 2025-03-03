using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kimerasStudyGroup.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult ListMember()
        {
            List<Models.StudyGroupMember> member = new List<Models.StudyGroupMember>();

            member.Add(new Models.StudyGroupMember { StudentNumber = "u24680193", Name = "Kimera", Surname = "Perumal", EmailAddress = "u24680193@tuks.co.za" });
            member.Add(new Models.StudyGroupMember { StudentNumber = "u24713407", Name = "Tiyana", Surname = "Vanmali", EmailAddress = "u24713407@tuks.co.za" });
            member.Add(new Models.StudyGroupMember { StudentNumber = "u23646773", Name = "Arishna", Surname = "Rathod", EmailAddress = "u23646773@tuks.co.za" });
            member.Add(new Models.StudyGroupMember { StudentNumber = "u23679485", Name = "Luyanda", Surname = "Mthethwa", EmailAddress = "23679485@tuks.co.za" });
            member.Add(new Models.StudyGroupMember { StudentNumber = "u23539242", Name = "Mariam", Surname = "Abdul", EmailAddress = "u23539242@tuks.co.za" });

            return View(member);
        }
    }
}