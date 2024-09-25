using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Form1
{
    public partial class Form1 : Form
    {
        private List<Zadanie> listaZadan = new List<Zadanie>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbWaznosc.Items.Add("Niski priorytet");
            cmbWaznosc.Items.Add("Średni priorytet");
            cmbWaznosc.Items.Add("Wysoki priorytet");

            cmbWaznosc.SelectedIndex = 0;

            OdczytajDane();
        }

        public class Zadanie
        {
            public string Nazwa { get; set; }
            public string Priorytet { get; set; }

            public Zadanie() { }

            public Zadanie(string nazwa, string priorytet)
            {
                Nazwa = nazwa;
                Priorytet = priorytet;
            }

            public override string ToString()
            {
                return $"{Nazwa} (Priorytet: {Priorytet})";
            }
        }

        private void ZapiszDane()
        {
            // Serializacja listy zadań do JSON
            string daneJSON = JsonConvert.SerializeObject(listaZadan, Formatting.Indented);
            string sciezkaPliku = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "zadania.json");

            try
            {
                File.WriteAllText(sciezkaPliku, daneJSON);
                MessageBox.Show("Dane zapisane w " + sciezkaPliku);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisywania danych: " + ex.Message);
            }
        }

        private void OdczytajDane()
        {
            string sciezkaPliku = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "zadania.json");

            if (File.Exists(sciezkaPliku))
            {
                try
                {
                    string daneJSON = File.ReadAllText(sciezkaPliku);
                    listaZadan = JsonConvert.DeserializeObject<List<Zadanie>>(daneJSON) ?? new List<Zadanie>();

                    // Dodaj zadania do ListBoxa
                    listBoxZadania.Items.Clear(); // Wyczyść ListBox przed dodaniem nowych danych
                    foreach (var zadanie in listaZadan)
                    {
                        listBoxZadania.Items.Add(zadanie);
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show("Błąd podczas deserializacji danych: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Plik nie istnieje: " + sciezkaPliku);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbWaznosc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDodajZadanie_Click(object sender, EventArgs e)
        {
            string nazwaZadania = txtNazwaZadania.Text;

            if (cmbWaznosc.SelectedItem != null)
            {
                string priorytet = cmbWaznosc.SelectedItem.ToString();

                if (!string.IsNullOrEmpty(nazwaZadania))
                {
                    Zadanie noweZadanie = new Zadanie(nazwaZadania, priorytet);
                    listaZadan.Add(noweZadanie); // Dodaj zadanie do listy

                    listBoxZadania.Items.Add(noweZadanie); // Dodaj zadanie do ListBoxa
                    txtNazwaZadania.Clear(); // Wyczyść pole tekstowe

                    ZapiszDane(); // Zapisz dane po dodaniu zadania
                }
                else
                {
                    MessageBox.Show("Proszę wprowadzić nazwę zadania.");
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać priorytet zadania.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ZapiszDane(); // Zapisz dane przy zamykaniu aplikacji
        }

        private void btnUsunZadanie_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy jakiekolwiek zadanie jest wybrane
            if (listBoxZadania.SelectedItem != null)
            {
                // Pobranie wybranego zadania
                var wybraneZadanie = listBoxZadania.SelectedItem as Zadanie;

                // Usunięcie zadania z listy zadań
                listaZadan.Remove(wybraneZadanie);

                // Usunięcie zadania z ListBoxa
                listBoxZadania.Items.Remove(wybraneZadanie);

                // Aktualizacja pliku JSON
                ZapiszDane();

                MessageBox.Show("Zadanie zostało usunięte.");
            }
            else
            {
                MessageBox.Show("Proszę wybrać zadanie do usunięcia.");
            }
        }
    }


}
