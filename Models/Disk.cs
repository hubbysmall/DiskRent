using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;


namespace Models
{
    public class Disk 
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string genre { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string country { get; set; }

        [DefaultValue(false)]
        public bool takenByClient { get; set; }
    }
}
