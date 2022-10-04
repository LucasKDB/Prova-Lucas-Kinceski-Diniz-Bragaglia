using System;
using System.ComponentModel.DataAnnotations;
using API_Folha.Validations;

namespace API.Models
{
    //Data Annotations
    public class Folha
    {
        

        public int folhaid { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public double valorhora
        {
            set { valorhora = value; }
            get { return valorhora; }
        }

        public int quantidadehoras
        {
            set { quantidadehoras = value; }
            get { return quantidadehoras; }
        }

        public double salariobruto
        {
            set { salariobruto = valorhora * quantidadehoras; }
            get { return salariobruto; }
        }

        public double renda
        {
            set
            {
                if (salariobruto >= 1903.98 && salariobruto <= 2826.65)
                {
                    renda = salariobruto - (7.5 * (salariobruto / 100));
                }
                else
                {
                    if (salariobruto > 2800.00 && salariobruto <= 3751.00)
                    {

                        renda = salariobruto - (15.00 * (salariobruto / 100));
                        
                    }
                    if (salariobruto > 3751.01)
                    {
                        renda = salariobruto - (22.50 * (salariobruto / 100));
                       

                    }
                }
            }
            get { return renda; }
        }

        public double inss
        {
            set
            {
                if (salariobruto <= 1693.72)
                {
                    inss = salariobruto - (8 * (salariobruto / 100));
                }
                else
                {
                    if (salariobruto > 1693.72 && salariobruto <= 2822.90)
                    {

                        renda = salariobruto - (9 * (salariobruto / 100));
                       
                    }
                    if (salariobruto > 2822.90 && salariobruto <= 5645.80)
                    {

                        renda = salariobruto - (11.00 * (salariobruto / 100));
                    }
                    if (salariobruto > 5645.80)
                    {
                        renda = salariobruto - 621.03;

                    }
                }
            }
            get { return inss; }
        }


        public double fgts
        {
            set { fgts = (8 * (salariobruto / 100)); }
            get { return fgts; }
        }

        public double salarioliquido
        {
            set { salarioliquido = salariobruto - renda - inss; }
            get { return salarioliquido; }
        }

        public Funcionario funcionarioId { get; set; }
    }
}

    



