using System.ComponentModel.DataAnnotations.Schema;

namespace FirstFluentAPI.Entities
{
    public class Cars
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string MadeYear { get; set; }
        public int PersonId { get; set; }
        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }
    }
}
