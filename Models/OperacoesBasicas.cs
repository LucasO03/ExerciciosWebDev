using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models
{
    public class OperacoesBasicas
    {
        [Display(Name = "Digite o primeiro valor")]
        [Required(ErrorMessage = "Informe o Valor")]
        [RegularExpression(@"^\d+,?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double Valor1 { get; set; }

        [Display(Name = "Digite o segundo valor")]
        [Required(ErrorMessage = "Informe o Valor")]
        [RegularExpression(@"^\d+,?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
        public double Valor2 { get; set; }

        [Display(Name = "Valor Soma")]
        public double ResultadoSoma { get => Soma(); }

        [Display(Name = "Valor Subtração")]
        public double ResultadoSubtracao { get => Subtracao(); }

        [Display(Name = "Valor Divisão")]
        public double ResultadoDivisao { get => Divisao(); }

        [Display(Name = "Valor Multiplicação")]
        public double ResultadoMultiplicacao { get => Multiplicacao(); }


        private double Soma(){
            return (Valor1 + Valor2);
        }

        private double Subtracao(){
            return (Valor1 - Valor2);
        }    
         private double Divisao(){
            return (Valor1 / Valor2);
        }

        private double Multiplicacao(){
            return (Valor1 * Valor2);
        }         

    }
}