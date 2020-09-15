using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_Project.Models
{
    [Table("")]
    public class Questions
    {   
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        
        public string Posted { get; set; }
        //Datetime^
        public string Category { get; set; }
        public int Status { get; set; }



    }
}
