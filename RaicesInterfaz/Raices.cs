using System;

namespace RaicesInterfaz
{
    class Raices
    {
        private int a;
        private int b;
        private int c;
        private string x1;
        private string x2;
        private string tipo;

        // constructores
        public Raices()
        {
            a = 0; b = 0; c = 0;
            x1 = ""; x2 = ""; tipo = "";
        }

        public Raices(int a, int b, int c)
        {
            this.a = a; this.b = b; this.c = c;
            x1 = ""; x2 = ""; tipo = "";
        }

        // propiedades
        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }
        public string X1 { get { return x1; } }
        public string X2 { get { return x2; } }
        public string Tipo { get { return tipo; } }

        // discriminante
        public float Disc()
        {
            return (b * b) - (4 * a * c);
        }

        public void RaicesIguales()
        {
            float raiz = -b / (2.0f * a);
            x1 = raiz.ToString("F2");
            x2 = raiz.ToString("F2");
            tipo = "Raíces reales iguales";
        }

        public void RaicesRealesDiferentes()
        {
            float disc = Disc();
            float sqrtDisc = (float)Math.Sqrt(disc);
            float x1Calc = (-b + sqrtDisc) / (2.0f * a);
            float x2Calc = (-b - sqrtDisc) / (2.0f * a);
            x1 = x1Calc.ToString("F2");
            x2 = x2Calc.ToString("F2");
            tipo = "Raíces reales diferentes";
        }

        public void RaicesImaginarias()
        {
            float real = -b / (2.0f * a);
            float imag = (float)Math.Sqrt(Math.Abs(Disc())) / (2.0f * Math.Abs(a));
            x1 = $"{real:F2} + {imag:F2}i";
            x2 = $"{real:F2} - {imag:F2}i";
            tipo = "Raíces imaginarias";
        }

        // método principal
        public void CalcularRaices()
        {
            if (a == 0)
            {
                tipo = "Error: A no puede ser 0";
                x1 = "";
                x2 = "";
                return;
            }

            float disc = Disc();
            if (disc == 0)
                RaicesIguales();
            else if (disc > 0)
                RaicesRealesDiferentes();
            else
                RaicesImaginarias();
        }
    }
}