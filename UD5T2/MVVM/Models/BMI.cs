using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace UD5T2.MVVM.Models
{
    // Se utiliza un atributo para agregar automáticamente la interfaz INotifyPropertyChanged
    [AddINotifyPropertyChangedInterface]
    //Clase BMI que hereda de la interfaz INotifyPropertyChanged
    internal class BMI: INotifyPropertyChanged
    {
        private float altura, peso;
        // Evento que se activa cuando una propiedad cambia
        public event PropertyChangedEventHandler PropertyChanged;
        // Propiedad para la altura con su get y set correspondiente
        public float Altura {
            get
            {
                return altura;
            }
            set
            {
                //Set en el que se actualiza el valor de la altura y se notifica del cambio de valor a Resultado y ResultadoBMI para que cambien tambien
                altura = value;
                OnPropertyChanged(nameof(Altura));
                OnPropertyChanged(nameof(Resultado));
                OnPropertyChanged(nameof(ResultadoBMI));
            }
        }
        public float Peso {
            get
            {
                return peso;
            }
            set
            {
                //Set en el que se actualiza el valor del peso y se notifica del cambio de valor a Resultado y ResultadoBMI para que cambien tambien
                peso = value;
                OnPropertyChanged(nameof(Peso));
                OnPropertyChanged(nameof(Resultado));
                OnPropertyChanged(nameof(ResultadoBMI));
            }
        }
        // Propiedad que calcula el índice de masa corporal (BMI) usando la fórmula estándar
        public float Resultado {
            get
            {
                return Peso / (Altura * Altura) * 10000;
            }
        }

        // Propiedad que devuelve un mensaje basado en el resultado del BMI
        public string ResultadoBMI
        {
            get
            {
                // Se asigna un mensaje según el rango de BMI
                if (Resultado <= 16)
                {
                    return "BMI: Delgado Severo";
                } else if (Resultado <= 17)
                {
                    return "BMI: Delgado Moderado";
                }
                else if (Resultado <= 18.5)
                {
                    return "BMI: Delgado Medio";
                }
                else if (Resultado <= 25)
                {
                    return "BMI: Normal";
                }
                else if (Resultado <= 30)
                {
                    return "BMI: Sobrepeso";
                }
                else if (Resultado <= 35)
                {
                    return "BMI: Obesidad Clase |";
                }
                else if (Resultado <= 40)
                {
                    return "BMI: Obesidad Clase ||";
                }
                else
                {
                    return "BMI: Obesidad Clase |||";
                }
            }
        }

        // Método protegido para invocar el evento PropertyChanged y notificar los cambios, para cuando una propiedad cambia.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
