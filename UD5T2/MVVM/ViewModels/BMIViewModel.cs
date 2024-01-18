using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD5T2.MVVM.Models;

namespace UD5T2.MVVM.ViewModels
{
    internal class BMIViewModel
    {
        // Propiedad que representa el modelo BMI
        public BMI BMI { get; set; }

        // Constructor de la clase BMIViewModel
        public BMIViewModel()
        {
            // Se instancia un objeto BMI al crear una instancia de BMIViewModel
            BMI = new BMI();

            // Se establecen valores iniciales para Peso y Altura del objeto BMI
            BMI.Peso = 50;
            BMI.Altura = 25;
        }
    }
}

