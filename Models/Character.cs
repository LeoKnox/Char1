using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcChar.Models
{
    public class Character
    {
        [Key]
        public int CharId { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int AC { get; set; }
        public int HP { get; set; }
    }
}
