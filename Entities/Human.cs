using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Entities
{
    public class Human
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        
        public Address Address { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
        
    }
}
