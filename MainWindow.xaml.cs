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

namespace Kurvendiskussion
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Nst_Click(object sender, RoutedEventArgs e)
        {
            double anstieg = Convert.ToDouble(TB_Anstieg.Text);
            double yAchsenAbschnitt = Convert.ToDouble(TB_yAchse.Text);
            lineareFunktion f = new lineareFunktion(anstieg, yAchsenAbschnitt);
            string Ausgabe;
            Ausgabe = "Die Nullstelle ist x_n=" + f.berechneNullstelle() +"\n";
            Ausgabe += "Der Schnittpunkt mit der xAchse liegt bei: (" + f.berechneNullstelle() + " / 0)";
            TB_Ausgabe_Nst.Text = Ausgabe;
        }

        private void Btn_Funktionswert_Click(object sender, RoutedEventArgs e)
        {
            double anstieg = Convert.ToDouble(TB_Anstieg.Text);
            double yAchsenAbschnitt = Convert.ToDouble(TB_yAchse.Text);
            lineareFunktion f = new lineareFunktion(anstieg, yAchsenAbschnitt);
            string Ausgabe="";
            Ausgabe = f.berechneFunktionswert(Convert.ToDouble(TB_xWert.Text)).ToString();
            TB_Funktionswert.Text = Ausgabe;
        }
    }
}
