using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Entities
{
    public class User
    {
        public int Id { get; set; }
        //[ForeignKey("Human")] // paskutinis atkomentuotas // po eimanto
        //public int HumanId { get; set; }   // po eimanto 
        public string Username { get; set; } 
        public string Password { get; set; }    
        public string Role { get; set; }

        //public List<Human> Humans { get; set; }
    }
}
