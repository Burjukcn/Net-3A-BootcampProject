using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Instructors
{
    public class CreateInstructorResponse
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}