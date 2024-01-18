using UD5T2.MVVM.ViewModels;

namespace UD5T2.MVVM.Views
{
    public partial class BMIView : ContentPage
    {
        // Constructor de la clase BMIView
        public BMIView()
        {
            // Inicializa la vista
            InitializeComponent();

            // Establece el contexto de enlace para la vista con una instancia de BMIViewModel
            BindingContext = new BMIViewModel();
        }
    }
}
