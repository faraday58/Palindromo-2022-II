namespace Palindromo_2022_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cadena = txtbPalindromo.Text;
            string cadena_sin_espacios = "";
            string cadenaInvertida="";

            cadena_sin_espacios = cadena.Replace(' ','\0');

            for(int i=0;i <cadena_sin_espacios.Length;i++)
            {

                cadenaInvertida = cadenaInvertida + cadena_sin_espacios[cadena_sin_espacios.Length - i-1];
                
            }

            txtbPalindromo.Text = cadenaInvertida;


        }
    }
}