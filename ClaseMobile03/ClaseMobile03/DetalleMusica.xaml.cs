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
    public partial class DetalleMusica : ContentPage
    {
        public DetalleMusica(Musica musica)
        {
            InitializeComponent();

            entryNombre.Text = musica.NombreMusica;
            entryArtista.Text = musica.ArtistaMusica;
            entryAlbum.Text = musica.AlbumMusica;
            entryPuesto.Text = musica.PuestoMusica;
            
        }
    }
}