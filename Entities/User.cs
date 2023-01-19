﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; }    
        public string Role { get; set; }
        
        public Human Human { get; set; }    
    }
}
