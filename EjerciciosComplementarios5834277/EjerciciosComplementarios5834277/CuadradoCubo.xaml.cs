namespace EjerciciosComplementarios5834277;


public partial class CuadradoCubo : ContentPage
{
	public CuadradoCubo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Se comprubea si  entry1.Text no este vacio. 
        if (!String.IsNullOrEmpty(Entry1.Text))
		{
            //Se declara 3 variables tipo double
			//para almacenar el número ingresado (Numero1), su cuadrado (Cuadrado) y su cubo (Cubo).
            double Numero1, Cubo, Cuadrado;

            //double.TryParse intenta convertir el valor de texto de Entry1 a un número double.
			//Si la conversión es exitosa, el valor convertido se almacena en Numero1 y la condición es true.
            if (double.TryParse(Entry1.Text, out Numero1))
			{

                //Calcula el cuadrado de Numero1 multiplicándolo por sí mismo y almacena el resultado en Cuadrado.
                Cuadrado = Numero1 * Numero1;

                //Calcula el cubo de Numero1 multiplicándolo por sí mismo dos veces más y almacena el resultado en Cubo.
                Cubo = Numero1 * Numero1 * Numero1;


                //Convierte los valores de Cuadrado y Cubo a cadenas
                //y los muestra en los cuadros de texto EntryCuadrado y EntryCubo respectivamente.
                EntryCuadrado.Text = Convert.ToString(Cuadrado);
				EntryCubo.Text = Convert.ToString(Cubo);
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
		Entry1.Text = "";
		EntryCuadrado.Text = "";
		EntryCubo.Text = "";

	}


}