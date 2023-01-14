using System.Diagnostics;

namespace lab3
{
    public partial class Form1 : Form
    {
        List<Student> Namjo = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = m1.Text;
            String id = m2.Text;
            String Brithday = m3.Text;
            String Height = m4.Text;
            String Grade = m5.Text;
            String Major = m6.Text;

            int iYear = Int32.Parse(Brithday);
            //int Mo = Int32.Parse(Height);
            int Mj = Int32.Parse(Grade);

            //create obj from Student
            Student newNamjo = new Student(name, id, iYear, Height, Mj , Major);
            this.Namjo.Add(newNamjo);

            BindingSource source = new BindingSource();
            source.DataSource = this.Namjo;
            this.dataGridView1.DataSource = source;
            //clear textbox
            this.m1.Text = "";
            this.m2.Text = "";
            this.m3.Text = "";
            this.m4.Text = "";
            this.m5.Text = "";
            this.m6.Text = "";
        }
    }
}