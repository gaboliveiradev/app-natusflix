using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNatusFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Uncharted : ContentPage
    {
        public Uncharted()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logoNatusFlix.Source = ImageSource.FromResource("AppNatusFlix.Imagens.natusflix.png");

            var htmlSoucer = new HtmlWebViewSource();
            htmlSoucer.Html = @"<iframe 
                width='560' height='315' 
                src='https://www.youtube.com/embed/jsgd_jVH834' 
                title='YouTube video player' frameborder='0' 
                allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen>
            </iframe>";

            visualizador.Source = htmlSoucer;
        }
    }
}