using System;

namespace md01_CadernoExercicios_03
{
    class Program
    {
        static void Main(string[] args)

            /*3. Faça um algoritmo que:
            a) Obtenha o valor para a variável HT (horas trabalhadas no mês);
            b) Obtenha o valor para a variável VH (valor hora trabalhada):
            c) Obtenha o valor para a variável PD (percentual de desconto);
            d) Calcule o salário bruto => SB = HT * VH;
            e) Calcule o total de desconto => TD = (PD/100)*SB;
            f) Calcule o salário líquido => SL = SB – TD;
            g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário
            Liquido
            */
        {
            double ht, vh, pd, sb, td, sl;

            Console.WriteLine("\nDigite o total de horas trabalhadas no mês:");
            ht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o valor da hora trabalhada:");
            vh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o percentual de desconto:");
            pd = Convert.ToDouble(Console.ReadLine());
            sb = ht * vh;
            td = (pd / 100) * sb;
            sl = sb - td;

            Console.WriteLine("\nHoras trabalhadas no mês: {0}", ht.ToString("0.0"));
            Console.WriteLine("\nSalário Bruto: R$ {0}", sb.ToString("0.00"));
            Console.WriteLine("\nDescontos: R$ {0}", td.ToString("0.00"));
            Console.WriteLine("\nSalário líquido: R$ {0}", sl.ToString("0.00"));
  
        }
    }
}
