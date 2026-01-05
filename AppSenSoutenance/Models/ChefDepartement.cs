using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Models
{
    public class ChefDepartement: Utilisateur
    {
        
        public int? IdDepartement { get; set; } 
        [ForeignKey("IdDepartement")]

        public virtual Departement Departement { get; set; }
    }
}
