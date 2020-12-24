using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioMod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            String[] PacificDreams =
            {
                "Isometric Air", "Real Window", "Practical Heart", "Antagonistic", "Simplepleasures", "Chodze", "Midnight Eye", "Blurred", "The Other Room", "La Stessa Causa", 
                "Retrogenesis", "Miami Suicide", "Slippery Stabs", "Ashes And Diamonds", "Ice Maddox", "Lithium", "Slag"
            };
            InitializeComponent();
        }
        void ChangeStation(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem RadioStation = ((sender as ListBox).SelectedItem as ListBoxItem);
            object SongListN = grid.FindName("Songs");
            if (SongListN is ListBox)
            {
                ListBox SongList = SongListN as ListBox;
                if (RadioStation.Content.ToString() == "88.9 PACIFIC DREAMS")
                {
                    for(int i = 0;i < PacificDreams.length)
                }
            }
        }
        void SelectSong(object sender, SelectionChangedEventArgs args)
        {

        }

        private void Replace(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("replace");
            
        }
    }
}
