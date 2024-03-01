using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Applicants
{
    public class CreateApplicantResponse
    {
        public int Id { get; set; }
        public string About { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}