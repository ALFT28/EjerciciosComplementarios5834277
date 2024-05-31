namespace EjerciciosComplementarios5834277;


public partial class Triangulo : ContentPage
{
	
	public Triangulo()
	{
		InitializeComponent();
	}



	private void Button_Clicked(object sender, EventArgs e)
	{
        //Se comprubea si los entry1, entry2 no esten vacios. 
        if (!String.IsNullOrEmpty(entry1.Text)  && 
			!String.IsNullOrEmpty(entry2.Text))
		{

            //Se declaran 2 varibles tipo double para almacenar los numeros ingresados.
            double Altura, Base;

            //double.TryParse intenta convertir una cadena (entry1.Text y entry2.Text) a número de tipo double.
            //Si la conversión es exitosa, almacena el valor convertido en Altura y Base.
            if (double.TryParse(entry1.Text, out Altura) 
			   && double.TryParse(entry2.Text, out Base))
			{


				//Para calcular la superfici se multiplica la altura por la base
				double Superficie = Altura * Base;

				//Y para el perimetro se multiplica por dos y se suma la altura y base 
				double Perimetro = 2 * (Altura + Base);


                //Convierte el resultado de la superficie a una cadena y lo muestra en el cuadro de texto entryResul.
                entryResul.Text = Superficie.ToString();

                //Convierte el resultado del perimetro a una cadena y lo muestra en el cuadro de texto entryResul1.
                entryResul1.Text = Perimetro.ToString();
            }
			else
			{
                //Si alguna de las conversiones falla, muestra una alerta de error.
                DisplayAlert("Error", "Por favor introduce solo números válidos.", "Ok");
			}	
            
        }
		else
		{
            //Si alguna de las entradas está vacía, muestra una alerta de error.
            DisplayAlert("Error", "Introduce los numeros", "Ok");
        }

	}

    private void ButtonLimpiar(object sender, EventArgs e)
	{
		entry1.Text = "";
		entry2.Text = "";
		entryResul.Text = "";
	}


}