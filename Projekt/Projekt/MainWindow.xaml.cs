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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
           


        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    /* to do wsadzenia w wpf moje poprzednie menu wyswietla nie wiem jak je polaczyc
     * <Window x:Class="Projekt.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Projekt"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Menu Margin="10,0,726,377">
        <MenuItem Header="Dodaj..." Height="32" Width="52" Click="MenuItem_Click">
            <MenuItem Header="Lotnisko"/>
            <MenuItem Header="Trasa"/>
            <MenuItem Header="Lot"/>
            <MenuItem Header="Klient"/>
            <MenuItem Header="Samolot">
                <MenuItem Header="Typ"/>
                <MenuItem Header="Model"/>
            </MenuItem>
            <Separator/>
            <MenuItem Header="Rezerwacja"/>
        </MenuItem>
    </Menu>
</Window>
*/
}
