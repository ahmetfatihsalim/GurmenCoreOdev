using System.ComponentModel.DataAnnotations;

namespace Gurmen.Model
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Range(0, 1, ErrorMessage = "Man 0, Woman 1")]
        public Gender Gender { get; set; }
        public int Age { get; set; }
    }
}
