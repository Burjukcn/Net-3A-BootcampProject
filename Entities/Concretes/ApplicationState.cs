using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ApplicationState :BaseEntity<int>

    { 
        public  string Name { get; set; }
        public int Id { get; set; }


        public ICollection<Application> Applications { get; set; }//Bu özellik, Application sınıfı ile ilişkilendirilmiş bir koleksiyonu temsil eder. ICollection türünden nesneleri içerebilir. Application türünde olan bu koleksiyon, bu sınıf ile Application sınıfı arasında bir ilişkiyi ifade eder. Bu ilişki, ApplicationState sınıfı ile Application sınıfı arasında bir-to-many ilişkisini gösterir. Yani, bir ApplicationState nesnesi, birden fazla Application nesnesini içerebilir.

        public ApplicationState()
        {
            Applications = new HashSet<Application>();//Bu metod, sınıfın bir örneği oluşturulduğunda otomatik olarak çağrılır. Bu özelik içinde, Applications koleksiyonu bir HashSet<Application> türünde yeni bir nesne ile başlatılır. HashSet, benzersiz elemanları tutan ve elemanların ekleme/silme gibi işlemlerini hızlı bir şekilde gerçekleştiren bir koleksiyon türüdür. Bu sayede, Applications özelliği başlangıçta boş bir koleksiyon olarak tanımlanmış olur. Bu, sınıfın kullanıma hazır hale gelmesini sağlar ve koleksiyonun null olmasını engeller.
        }


        public ApplicationState(string name, int ıd)
        {
            Name = name;
            Id = ıd;
        }
    }
}
