using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNatusFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            logoNatusFlix.Source = ImageSource.FromResource("AppNatusFlix.Imagens.natusflix.png");

            btnUncharted.Source = ImageSource.FromResource("AppNatusFlix.Posters.uncharted.jpeg");
            btnMoonFall.Source = ImageSource.FromResource("AppNatusFlix.Posters.moonfall.jpg");
            btnViuvaNegra.Source = ImageSource.FromResource("AppNatusFlix.Posters.viuvanegra.jpg");
            btnEternal.Source = ImageSource.FromResource("AppNatusFlix.Posters.eternal.jpg");
            btnTheBatman.Source = ImageSource.FromResource("AppNatusFlix.Posters.thebatman.jpg");
            btnSpiderman.Source = ImageSource.FromResource("AppNatusFlix.Posters.spiderman.jpg");
            btnVenom.Source = ImageSource.FromResource("AppNatusFlix.Posters.venom.jpg");
            btnVingadores.Source = ImageSource.FromResource("AppNatusFlix.Posters.vingadores.jpg");
        }

        private void clickedUncharted(object sender, EventArgs e)
        {
            try {
                Navigation.PushAsync(new Filmes.Uncharted());
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }

        private void clickedMoonFall(object sender, EventArgs e)
        {
            try {
                Navigation.PushAsync(new Filmes.MoonFall());
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }

        private void clickedViuvaNegra(object sender, EventArgs e)
        {
            try {
                Navigation.PushAsync(new Filmes.ViuvaNegra());
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }

        private void clickedEternal(object sender, EventArgs e)
        {
            try {
                Navigation.PushAsync(new Filmes.Eternal());
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }

        private void clickedBatman(object sender, EventArgs e)
        {
            try {
                Navigation.PushAsync(new Filmes.Batman());
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }

        private void clickedSpiderman(object sender, EventArgs e)
        {
            try {
                Navigation.PushAsync(new Filmes.Spiderman());
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }

        private void clickedVingadores(object sender, EventArgs e)
        {
            try {
                Navigation.PushAsync(new Filmes.Vingadores());
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }

        private void clickedVenom(object sender, EventArgs e)
        {
            try {
                Navigation.PushAsync(new Filmes.Venom());
            } catch (Exception ex) {
                DisplayAlert("ERRO", ex.Message, "Fechar");
            }
        }
    }
}