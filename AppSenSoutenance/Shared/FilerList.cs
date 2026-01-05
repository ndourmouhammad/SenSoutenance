using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Shared
{
    public class FilerList
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        /// <summary>
        /// Remplir la liste des annees academiques
        /// </summary>
        /// <return></return>
        /// 

        public List<ListItem> FillAnneeAcademique()
        {
            List<ListItem> laliste = new List<ListItem>();
            var listes = db.anneeAcademiques.ToList();
            laliste.Add(new ListItem
             {
                Value = null,
                Text = "Selectionner"
            });

            foreach (var t in listes)
            {
                var item = new ListItem
                {
                    Value = t.IdAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique.ToString()
                };
                laliste.Add(item);
            }
            return laliste;

        }
    }
}
