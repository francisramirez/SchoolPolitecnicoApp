using SchoolPoliApp.WinForms.Service;

namespace SchoolPoliApp.WinForms
{
    public partial class Form1 : Form
    {
        private readonly IMyService myService;

        public Form1(IMyService myService)
        {
            InitializeComponent();
            this.myService = myService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.myService.GetNombre(tbxNombre.Text);
            MessageBox.Show(nombre);
        }
    }
}
