using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string Specialist { get; set; }

        public string Employee { get; set; }

        public int EmpolyeeNumber { get; set; }

    }
}