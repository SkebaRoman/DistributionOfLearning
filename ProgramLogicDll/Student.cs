﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ProgramLogicDll
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Profession { get; set; }
        public string Email { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public DateTime ExpirationDate { get; set; }
        public virtual Group Groups { get; set; }
    }
}
