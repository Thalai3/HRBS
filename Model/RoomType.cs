using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRBS.Model
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }

        [Column(TypeName="varchar(25)")]
        public string TypeName { get; set; }

        //Navigation property
        public ICollection<Room> Rooms { get; set; }
    }
}
