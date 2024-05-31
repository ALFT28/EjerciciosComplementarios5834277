namespace EjerciciosComplementarios5834277;


public partial class Inversos : ContentPage
{
  
	public Inversos()
	{
		InitializeComponent();
	}
  

    private void Button_Clicked(object sender, EventArgs e)
    {

        //Se comprubea si los entry1, entry2, entry3 y entry4 no esten vacios. 
        if (!String.IsNullOrEmpty(entry1.Text) && 
            !String.IsNullOrEmpty(entry2.Text) && 
            !String.IsNullOrEmpty(entry3.Text) && 
            !String.IsNullOrEmpty(entry4.Text))
        {
            //Se declaran 4 varibles tipo double para almacenar los numeros ingresados.
            double Numero1, Numero2, Numero3, Numero4;

            //Double.TryParse intenta convertir una cadena (entry1.Text, entry2.Text, entry3.Text y entry4.Text) a número de tipo double.
            //Si la conversión es exitosa, almacena el valor convertido en Numweo1, Numweo2, Numweo3 y Numweo4.
            if (double.TryParse(entry1.Text, out Numero1) && 
               double.TryParse(entry2.Text, out Numero2) && 
               double.TryParse(entry3.Text, out Numero3) && 
               double.TryParse(entry4.Text, out Numero4))
            {

                //Se crea un arreglo de double llamado numerosInversos que contiene los números ingresados en orden inverso
                double[] numerosInversos = { Numero4, Numero3, Numero2, Numero1 };

                //Se utiliza el método string.Join para concatenar los elementos del arreglo numerosInversos en una sola cadena,
                //separando cada elemento por una coma y un espacio.
                //Luego, asigna esta cadena resultante al texto de entryResul
                //lo que mostrará los números en orden inverso en el cuadro de texto entryResul.
                entryResul.Text = string.Join(", ", numerosInversos);
            }
            else
            {
                //Si alguna de las conversiones falla, muestra una alerta de error.
                DisplayAlert("Error", "Por favor, introduce solo números válidos.", "OK");
            }
          

        }
        else
        {
            //Si alguna de las entradas está vacía, muestra una alerta de error.
            DisplayAlert("Error", "Introduce los numeros", "ok");
        }


    }

    private void ButtonLimpiar(object sender, EventArgs e)
    {
        entry1.Text = "";
        entry2.Text = "";
        entry3.Text = "";
        entry4.Text = "";
        entryResul.Text = "";
    }


}