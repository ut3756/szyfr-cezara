namespace szyfr_cezara
{
    public partial class MainPage : ContentPage
    {
        private static int klucz = 0;
        private static string alfabet = "abcdefghijklmnopqrstuvwxyz";
        public MainPage()
        {
            InitializeComponent();
        }

        private async void barykuj(object sender, EventArgs e)
        {
            string s = entCezary.Text.ToLower();
            int klucz = int.Parse(entKlucz.Text);

            if (klucz <= 0 || klucz >= 26)
                await DisplayAlert("zle", "👎", "damn");

            otu.Text = szyfruj(s, klucz);
        }

        private async void odbarykuj(object sender, EventArgs e)
        {
            string s = entCezary.Text.ToLower();
            int klucz = int.Parse(entKlucz.Text);

            if (klucz <= 0 || klucz >= 26)
                await DisplayAlert("zle", "👎", "damn");

            otu.Text = szyfruj(s, klucz);

        }

        private string szyfruj(string tekst, int klucz)
        {
            string wynik = "";
            foreach (char c in tekst)
            {
                int poz = alfabet.IndexOf(c);
                if (poz == -1)
                {
                    wynik += c;
                    continue;
                }
                poz = (poz + klucz) % alfabet.Length;
                if (poz > alfabet.Length)
                    poz = alfabet.Length - poz;
                wynik += alfabet[poz];
            }
            return wynik;
        }
    }

}
