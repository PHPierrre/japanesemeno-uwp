using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Japanese
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Menu_Click(Object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HiraganaListBoxItem.IsSelected) { mainFrame.Navigate(typeof(PageHiragana)); mainTitle.Text = "Liste des Hiragana"; }
            else if (KatanaListBoxItem.IsSelected) { mainFrame.Navigate(typeof(PageKatana)); mainTitle.Text = "Liste des Katana"; }
            else if (KanjiListBoxItem.IsSelected) { mainFrame.Navigate(typeof(PageKanji)); mainTitle.Text = "Liste des Kanji"; }
            /*
             * var itemId = ((SampleDataItem)e.ClickedItem).UniqueId;
             * this.Frame.Navigate(typeof(ItemPage), itemId);
             */
        }
    }

}
