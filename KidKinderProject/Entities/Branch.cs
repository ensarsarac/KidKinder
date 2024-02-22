using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinderProject.Entities
{
    public class Branch
    {
        public int BranchID { get; set; }
        public string BranchName { get; set; }
        public List<Teacher> Teachers{ get; set; }
    }
}