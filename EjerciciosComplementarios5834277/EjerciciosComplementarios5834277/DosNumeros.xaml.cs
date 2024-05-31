namespace EjerciciosComplementarios5834277;


public partial class DosNumeros : ContentPage
{ 
  
	public DosNumeros()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Se comprubea si los entry1 y entry2 no estan vacio. 
        if (!String.IsNullOrEmpty(entry1.Text) && 
            !String.IsNullOrEmpty(entry2.Text))
        {
            //Se declara 3 variables tipo double para almacenar los numeros ingresados.
            double Calcular, Numero1, Numero2;

            //Double.TryParse intenta convertir una cadena (entry1.Text y entry2.Text) a un número de tipo double.
            //Si la conversión es exitosa, almacena el valor convertido en Numero1 y Numero2. 
            if (double.TryParse(entry1.Text, out Numero1) &&
                double.TryParse(entry2.Text, out Numero2))
            {
                //Si ambas conversiones son exitosas, realiza el cálculo
                //Se utiliza el método Math.Pow para elevar la suma al cuadrado y luego divide el resultado por 2.
                Calcular = Math.Pow(Numero1 + Numero2, 2) / 2;


                //Convierte el resultado del cálculo a una cadena y lo muestra en el cuadro de texto entryResul.
                entryResul.Text = Calcular.ToString();
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
        entryResul.Text = "";

    }
}