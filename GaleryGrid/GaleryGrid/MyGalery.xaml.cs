namespace GaleryGrid;

public partial class MyGalery : ContentPage
{
	public MyGalery()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Img1());
    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Animal());

    }

    private void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new camaro());

    }

    private void ImageButton_Clicked_5(object sender, EventArgs e)
    {
        Navigation.PushAsync(new juan_feliz());

    }
}