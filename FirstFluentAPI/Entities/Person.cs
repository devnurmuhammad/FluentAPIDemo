namespace FirstFluentAPI.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<Cars> Cars { get; set; }
        public ICollection<Bicycles> Bicycles { get; set; }
    }
}
