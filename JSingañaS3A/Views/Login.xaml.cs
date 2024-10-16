namespace JSingañaS3A.Views;

public partial class Login : ContentPage
{
    string user, password;
	public Login()
	{
		InitializeComponent();
	}
    public Login(string usuario, string contrasena) 
    {
        InitializeComponent();
        user = usuario;
        password = contrasena;

    }
    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;
        if (usuario == user && contrasena == password)
        {
            //Navegar Entre ventanas
            Navigation.PushAsync(new Views.Opreaciones());
        }
        else 
        {
            DisplayAlert("Error","Contraseña o Usuario no coinciden"," Cerrar");
        }
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        //Navegar entre ventanas
        Navigation.PushAsync(new Views.Registro());

    }
}