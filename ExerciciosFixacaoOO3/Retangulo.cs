using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosFixacaoOO3 {
    class Retangulo {

        public double Largura;
        public double Altura;


        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {

            double d = Math.Sqrt((Math.Pow(Largura, 2)) + (Math.Pow(Altura, 2)));
            return d;
        }

        public override string ToString() {
            return "Area = " + Area() + "\nPerímetro = " + Perimetro() + "\nDiagonal = " + Diagonal();
        }

    }
}
