namespace Lista_zakupow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100) 
            { 
                 if(textBox1.Text.Length > 0 ) 
                 {
                    if (listBox1.Items.Contains(textBox1.Text)) 
                    {
                      DialogResult result = MessageBox.Show("Ten element ju¿ istnieje! Czy dalej chcesz go dodaæ?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if(result == DialogResult.No) 
                        {
                            textBox1.Text = "";
                            return;
                        }
                    }
                   
                    listBox1.Items.Add(textBox1.Text);
                    AktualizujProgres();
                    textBox1.Text = "";
                    
                 }
                 else 
                 {
                    MessageBox.Show("Wartoœæ jest pusta!", "B³¹d!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
            else
            {
                MessageBox.Show("Lista jest ju¿ pe³na!", "B³¹d!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktualizujProgres()
        {
            int i = listBox1.Items.Count;
            progressBar1.Value = i * 10;
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i != -1) 
            { 
                listBox1.Items.RemoveAt(i);
                AktualizujProgres();
            
            }
            else 
            {
                MessageBox.Show("¯aden element nie zosta³ zaznaczony!", "B³¹d!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCzysc_Click(object sender, EventArgs e)
        {
          DialogResult result = MessageBox.Show("Czy na pewno chcesz usun¹æ ca³¹ listê zakupów?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

           if(result == DialogResult.Yes) 
            {
                listBox1.Items.Clear();
                AktualizujProgres();
            }

        }
    }
}