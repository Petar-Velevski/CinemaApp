using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaApp.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}