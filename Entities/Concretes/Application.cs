using Core.Entities;

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

        public Application(int applicantId, int bootcampId, int applicationStateId, Bootcamp? bootcamp, Applicant? applicant, ApplicationState? applicationState)
        {
            ApplicantId = applicantId;
            BootcampId = bootcampId;
            ApplicationStateId = applicationStateId;
            Bootcamp = bootcamp;
            Applicant = applicant;
            ApplicationState = applicationState;
        }
    }
}