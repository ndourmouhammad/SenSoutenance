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
                Value = "0",
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

        /// <summary>
        /// Remplir la liste des sessions
        /// </summary>
        public List<ListItem> FillSession()
        {
            List<ListItem> laliste = new List<ListItem>();
            var listes = db.sessions.ToList();
            laliste.Add(new ListItem
            {
                Value = "0",
                Text = "Selectionner"
            });

            foreach (var t in listes)
            {
                var item = new ListItem
                {
                    Value = t.IdSession.ToString(),
                    Text = t.LibelleSession.ToString()
                };
                laliste.Add(item);
            }
            return laliste;
        }
        /// <summary>
        /// Remplir la liste des mémoires
        /// </summary>
        public List<ListItem> FillMemoire()
        {
            List<ListItem> laliste = new List<ListItem>();
            var listes = db.memoires.ToList();
            laliste.Add(new ListItem
            {
                Value = "0",
                Text = "Selectionner"
            });

            foreach (var t in listes)
            {
                var item = new ListItem
                {
                    Value = t.IdMemoire.ToString(),
                    Text = t.SujetMemoire
                };
                laliste.Add(item);
            }
            return laliste;
        }
        /// <summary>
        /// Remplir la liste des départements
        /// </summary>
        public List<ListItem> FillDepartement()
        {
            List<ListItem> laliste = new List<ListItem>();
            var listes = db.Departements.ToList();
            laliste.Add(new ListItem
            {
                Value = "0",
                Text = "Selectionner"
            });

            foreach (var t in listes)
            {
                var item = new ListItem
                {
                    Value = t.IdDepartement.ToString(),
                    Text = t.LibelleDepartement
                };
                laliste.Add(item);
            }
            return laliste;
        }
    }
}
