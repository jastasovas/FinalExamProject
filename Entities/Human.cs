using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Entities
{
    public class Human
    {
        public int Id { get; set; }
        //[ForeignKey("Address")]
        //public int AddressId { get; set; } // paskutinis bandymas
        public int UserId   { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] ProfilePicture { get; set; }





        public List<User> Users { get; set; } 
    }
}
