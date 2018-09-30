using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace odatacoresample.Model
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string ISBN { get; set; }
        
        public string Author { get; set; }
    }
}
