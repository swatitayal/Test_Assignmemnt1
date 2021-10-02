using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Test.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using System.Threading.Tasks;
using System.Diagnostics;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Photo> Photos;
        private Photo photo;
        private Album album;
        private User user;



        public MainPage()
        {
            this.InitializeComponent();
            Photos = new ObservableCollection<Photo>();
            PhotoManager.GetAllPhotos(Photos);
            user = new User();
            AddToAlbum.Visibility = Visibility.Collapsed;
        }

        private void CreateAlbum_Click(object sender, RoutedEventArgs e)
        {
            album = new Album(InputAlbumName.Text, InputDescription.Text);
            user.addAlbum(album);
            Debug.WriteLine("Album Added");
            // Add a success message! hide all controls, show text success message.

        }

        private void AddToAlbum_Click(object sender, RoutedEventArgs e)
        {
            album.addPhoto(photo);
            Debug.WriteLine("Photo Added");
        }

        private void PhotoGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            photo = (Photo)e.ClickedItem;
            AddToAlbum.Visibility = Visibility.Visible;

            /*var localRoot = ApplicationData.Current.LocalFolder.Path;
            DirectoryInfo d = new DirectoryInfo(localRoot + "\\FromUI");
            if (!d.Exists)
            {
                d.Create();
                Debug.WriteLine("Created file at " + localRoot);
            }
            else
                Debug.WriteLine("Not created" + localRoot);

            string exactPath = Path.GetFullPath(photo.PhotoPath);

            string sourcepath = @"C:\Users\Swati\Kal\Test_Assign1\Test\Test" + exactPath;

            Debug.WriteLine("The source path is:" + sourcepath);
                       
            File.Copy(sourcepath, Path.Combine(d.FullName, photo.Name), true); */

        }

        
    }
}
