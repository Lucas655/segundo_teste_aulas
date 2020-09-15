using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosFixacaoOO3 {
    class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularNotaFinal() {
            return (Nota1 + Nota2 + Nota3);
        }

        public double DiferencaMediaMaximaETirada() {
            return 60.0 - CalcularNotaFinal();
        }


        public override string ToString() {
            return "Nota Final: " + CalcularNotaFinal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
