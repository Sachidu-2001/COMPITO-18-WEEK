﻿using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cognome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Telefono { get; set; }

        public ICollection<Prenotazione> Prenotazioni { get; set; } = new List<Prenotazione>();

    }
}
