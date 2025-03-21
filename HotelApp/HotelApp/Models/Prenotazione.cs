using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Models
{
    public class Prenotazione
    {
        [Key]
        public int PrenotazioneId { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        [ForeignKey("Camera")]

        public int CameraId { get; set; }

        [Required]
        public DateOnly DataInizio { get; set; }

        [Required]
        public DateOnly DataFine { get; set; }

        [Required]
        public string Stato { get; set; }
    }
}
