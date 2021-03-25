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

namespace Formulář_s_validací_polí
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_ClickDone(object sender, EventArgs e)
        {
            Zamestnanec z = new Zamestnanec("Jan", "Novák", 2000, "Vysoká škola", "Správce sítě", 45000);
            Zamestnanec zf = new Zamestnanec(tboxJmeno.Text, tboxPrijmeni.Text, Convert.ToInt32(tboxRok.Text),
                                            rboxVzdelani.Text, tboxPozice.Text, Convert.ToInt32(tboxPlat.Text));      
        }
    }

    class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int RokNarozeni { get; set; }
        public Osoba(string j, string p, int n)
        {
            Jmeno = j;
            Prijmeni = p;
            RokNarozeni = n;
        }
    }
    class Zamestnanec : Osoba
    {
        public string Vzdelani { get; set; }
        public string Pozice { get; set; }
        public int HrubyPlat { get; set; }

        public Zamestnanec(string j, string p, int n, string vzd, string poz, int plat) : base(j, p, n)
        {
            Vzdelani = vzd;
            Pozice = poz;
            HrubyPlat = plat;
        }
    }
}
