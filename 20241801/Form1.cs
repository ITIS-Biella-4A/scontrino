namespace _20241801
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 15; i++)
            {
                quantita_cb.Items.Add(i);
            }
            //preselezione primo valore
            quantita_cb.SelectedIndex = 0;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            prodotto_txt.Focus();

        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void esci_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inserisci_btn_Click(object sender, EventArgs e)
        {
            if (prodotto_txt.Text=="" || prezzo_txt.Text=="")
            {
                MessageBox.Show("scrivi qualcosa bro", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
            }
        }
    }
}