using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Application : BaseEntity<int>
    {
        public int ApplicantId { get; set; }
        public int BootcampId { get; set; }
        public int ApplicationStateId { get; set; }

        public virtual Bootcamp? Bootcamp { get; set; }//  farklı sınıflarla olan ilişkileri temsil eder ve her biri ilgili sınıfın nesnelerini referanslamak için kullanılabilir.u ilişkilerin null olabileceği belirtilmiştir, yani bu özellikler null değer alabilir. Bu durum, ilişkinin mevcut olmayabileceğini veya atanmamış olabileceğini gösterir.
        public virtual Applicant? Applicant { get; set; }

        public virtual ApplicationState? ApplicationState { get; set; }

        public Application()
        {

        }

        public Application(int id, int applicantId, int bootcampId, int applicationStateId)
        {
            Id = id;
            ApplicantId = applicantId;
            BootcampId = bootcampId;
            ApplicationStateId = applicationStateId;
        }

    }
}