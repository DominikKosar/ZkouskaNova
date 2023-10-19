using System.Diagnostics;

namespace TestGitu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.Write("Ahoj chlapeee");
            Debug.Write("Dalsi text, zkouska vìtví");
            int cislo = 0;
            cislo += 8;
            int cislo2 = 0;
            cislo2 += cislo;
        }
    }
}