namespace EjerciciosComplementarios5834277;

public partial class PromedioEstudiante : ContentPage
{
    
    public PromedioEstudiante()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Se comprubea si los entry1, entry2, entry3, entry4 y entry5 no esten vacios. 
        if (!String.IsNullOrEmpty(entry1.Text) && 
            !String.IsNullOrEmpty(entry2.Text) && 
            !String.IsNullOrEmpty(entry3.Text) && 
            !String.IsNullOrEmpty(entry4.Text) && 
            !String.IsNullOrEmpty(entry5.Text))
        {
            //Se declaran 6 varibles tipo double para almacenar los numeros ingresados.
            double Promedio, Nota1, Nota2, Nota3, Nota4, Nota5;


            //Double.TryParse intenta convertir una cadena (entry1.Text, entry2.Text, entry3.Text, entry4.Text y entry5.Text)número de tipo double.
            //Si la conversión es exitosa, almacena el valor convertido en Nota1, Nota2, Nota3, Nota4, Nota5.
            if (double.TryParse(entry1.Text, out Nota1) &&
                double.TryParse(entry2.Text, out Nota2) && 
                double.TryParse(entry3.Text, out Nota3) && 
                double.TryParse(entry4.Text, out Nota4) && 
                double.TryParse(entry5.Text, out Nota5))
            {

                //Calcula el promedio sumando las cinco notas y dividiendo el resultado entre 5
                Promedio = (Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5;


                //Convierte el resultado del promedio a una cadena y lo muestra en el cuadro de texto entryResul.
                entryResul.Text = Promedio.ToString();
            }
            else
            {
                //Si alguna de las conversiones falla, muestra una alerta de error.
                DisplayAlert("Error", "Por favor, introduce solo números válidos.","OK");
            }

        }
        else
        {
            //Si alguna de las entradas está vacía, muestra una alerta de error.
            DisplayAlert("Error", "Introduce los numeros", "OK");
        }


    }

    private void ButtonLimpiar(object sender, EventArgs e)
    {
        entry1.Text = "";
        entry2.Text = "";
        entry3.Text = "";
        entry4.Text = "";
        entry5.Text = "";
        entryResul.Text = "";
    }
}