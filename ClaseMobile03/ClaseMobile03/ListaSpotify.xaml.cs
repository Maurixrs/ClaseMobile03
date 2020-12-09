using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClaseMobile03
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaSpotify : MasterDetailPage
    {
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var musica = e.SelectedItem as Musica;
            musica.AlbumMusica = "album harcodeado";
            musica.PuestoMusica = "puesto harcodeado";
           
            Detail = new NavigationPage(new DetalleMusica(musica));
            IsPresented = false;
        }
        public ListaSpotify()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Musica> {
            new Musica{ NombreMusica = "Canción 01",ArtistaMusica="Artista 01",AlbumMusica="Album 01",PuestoMusica="01"},
            new Musica{ NombreMusica = "Canción 02",ArtistaMusica="Artista 01",AlbumMusica="Album 02",PuestoMusica="02"},
            new Musica{ NombreMusica = "Canción 03",ArtistaMusica="Artista 03",AlbumMusica="Album 03",PuestoMusica="03"}
            };

        }
    }
}