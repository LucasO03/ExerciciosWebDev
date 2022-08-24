using System.ComponentModel.DataAnnotations;

namespace Exercicio.Models
{
    public class PesoIdeal
    {
     
        [Display(Name = "Peso (Kg)")]
        [Required(ErrorMessage = "Informe um peso")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double Peso { get; set; }

        [Display(Name = "Altura (m)")]
        [Required(ErrorMessage = "Informe um altura")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double Altura { get; set; }

        [Display(Name = "IMC")]
        public double PesoCalculado { get => Calcular(); }

        private double Calcular()
        {
            return Peso / (Altura * Altura);
        }

    }
}