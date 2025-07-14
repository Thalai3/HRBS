using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRBS.Model
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }

        [Column(TypeName ="Nvarchar(25)")]
        public string RoomNumber { get; set; }

        [Column(TypeName ="Nvarchar(10)")]
        public string Status { get; set; }
    }
}
