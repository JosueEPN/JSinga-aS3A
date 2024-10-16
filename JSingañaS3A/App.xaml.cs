namespace JSingañaS3A
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Habilita la navegacion entre vistas 
            MainPage = new NavigationPage( new Views.Login() );
        }
    }
}
