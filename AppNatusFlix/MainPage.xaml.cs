using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppNatusFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logoNatusFlix.Source = ImageSource.FromResource("AppNatusFlix.Imagens.natusflix.png");
        }

        public void NavegarPages(Button btn)
        {
            try {
                if (btn.Text == "Aventura") {
                    Navigation.PushAsync(new Categorias.Aventura());
                } else if (btn.Text == "Comédia") {
                    Navigation.PushAsync(new Categorias.Comedia());
                } else if (btn.Text == "Drama") {
                    Navigation.PushAsync(new Categorias.Drama());
                } else if (btn.Text == "Fantasia") {
                    Navigation.PushAsync(new Categorias.Fantasia());
                } else if (btn.Text == "Romance") {
                    Navigation.PushAsync(new Categorias.Romance());
                } else if (btn.Text == "Terror") {
                    Navigation.PushAsync(new Categorias.Terror());
                }
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }

        private void btnClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            NavegarPages(btn);
        }
    }
}
