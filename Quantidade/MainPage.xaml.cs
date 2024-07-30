namespace Quantidade
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void BTNola_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "Meu bebe!", "Ok");
        }
    }

}
