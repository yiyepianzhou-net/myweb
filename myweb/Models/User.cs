using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myweb.Models
{
    public class User
    {
        [Key]
        public string UserID { get; set; } = Guid.NewGuid().ToString().Substring(0,8);

        [StringLength(20)]
        [Required]
        public string UserName { get; set; }

        [ForeignKey("RoomID")]
        [StringLength(8)]
        public string RoomId { get; set; }
    }
}
