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
using feudalismManagement;

namespace feudalismGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CharacterManager _characterManager = new CharacterManager();
        public MainWindow()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            ListBox.ItemsSource = _characterManager.ListAllCharacters();
        }

        //private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (ListBox.SelectedItem != null)
        //    {
        //        _characterManager.SetSelectedCharacter(ListBox.SelectedItem);
        //        PopulateCharacterFields();
        //    }
        //}

        //private void PopulateCharacterFields()
        //{
        //    if (_characterManager.SelectedCharacter != null)
        //    {
        //        Text.Text = _characterManager.SelectedCharacter.CharacterName;
               
        //    }
        //}


    }
}
