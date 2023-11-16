using System.ComponentModel.DataAnnotations.Schema;

namespace FirstFluentAPI.Entities
{
    public class Bicycles
    {
        public int Id { get; set; }
        public string BicycleName { get; set; }
        public int PersonId { get; set; }
        [ForeignKey(nameof(PersonId))]
        public Person Person { get; set; }
    }
}
