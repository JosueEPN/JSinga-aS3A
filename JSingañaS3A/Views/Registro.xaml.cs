namespace JSingañaS3A.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;
		string contrasena = txtContrasena.Text;

		//permite enviar variables a diferentes ventanas

		Navigation.PushAsync(new Views.Login(usuario, contrasena));


    }
}