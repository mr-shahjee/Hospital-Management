using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCrud.Models
{
    public class Gad7
    {
        [Key]
           public int Gad7Id { get; set; }
        public DateTime Gad7Date { get; set; }
        public string TreatmentStage { get; set; }
        public int Score { get; set; }

    }
}