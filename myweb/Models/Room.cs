using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myweb.Models
{
    public class Room
    {
        [Key]
        [StringLength(8)]
        public string RoomID { get; set; } = Guid.NewGuid().ToString().Substring(0,8);

        [Required]
        [StringLength(20)]
        public string RoomName { get; set; }

        public ICollection<User> users { get; set; }
    }
}
