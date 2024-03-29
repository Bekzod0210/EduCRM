﻿namespace EduCRM.Models
{
    public class Mentor
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public List<Group>? Groups { get; set; } 
    }
}
