﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Entities
{
    public class Address
    {
        public int Id { get; set; }
        
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public int HumanId { get; set; }
        public Human Human { get; set; }
    }
}
