using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        /// Nom de famille
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Nom Manquant")]
        public string Nom { get; set; }

        /// Prénom            
        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Prénom Manquant")]
        public string Prenom { get; set; }

        /// Sexe
        [Display(Name = "Sexe")]
        [Required(ErrorMessage = "Sexe Non-Renseigné")]
        public string Sexe { get; set; }

        /// Adresse
        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Adresse Manquante")]
        public string Adresse { get; set; }

        /// Code Postal
        [Display(Name = "Code Postal")]
        [Required(ErrorMessage = "Code Postal Manquant")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Code Postal nécessite 5 chiffres")]
        public string Cpostal { get; set; }

        /// Ville
        [Display(Name = "Ville")]
        [Required(ErrorMessage = "Ville Manquant")]
        public string Ville { get; set; }

        /// E-mail
        [Display(Name = "Adresse Mail")]
        [Required(ErrorMessage = "Adresse Mail Manquant")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage = "Adresse E-Mail invalide")]
        public string Email { get; set; }

        
        /// Date de début de formation        
        [Display(Name = "Date début formation")]
        [Required(ErrorMessage = "Date de début de formation Manquant")]
        [Range(typeof(DateTime), "1/1/1970", "1/1/2021", ErrorMessage = "Date antérieur au 01/01/2021")]
        public string DateDF { get; set; }

        /// Type de formation suivie
        [Display(Name = "Formation Suivie")]
        [Required(ErrorMessage = "Type de Formation Suivie Manquant")]
        public string Formation { get; set; }

        /// Avis Formation Cobol
        [Display(Name = "Formation Cobol")]
        public string Fcobol { get; set; }

        /// Avis Formation C#
        [Display(Name = "Formation C#")]
        public string Csharp { get; set; }
    }
}