using CinemaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class ShoppingCartDto
    {
        public int Id { get; set; }
        public List<TicketInShoppingCart> Tickets { get; set; }
        public double TotalPrice { get; set; }
    }
}