using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Pizz�ria.Models
{
    public class PizzaEhod
    {
        [Key]
        public int IdEhod { get; set; }

        public string? NomEhod { get; set; }

        public string? DescriptionEhod { get; set; }
    }
}