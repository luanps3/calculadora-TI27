namespace calculadora_TI27.Core
{
    public class CalculadoraService
    {
        public static double Somar(double a, double b)
        {
            return a + b;
        }

        public static double Subtrair(double a, double b)
        {
            return a - b; 
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possivel dividir por zero.");
            }

            return a / b;
        }



    }
}
