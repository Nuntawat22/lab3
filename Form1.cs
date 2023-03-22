using System.Diagnostics;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        List<Student> Namjo = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        // Add
        private void button1_Click(object sender, EventArgs e)
        {
            String name = m1.Text;
            String id = m2.Text;
            String Brithday = m3.Text;
            String Height = m4.Text;
            String Grade = m5.Text;
            String Major = m6.Text;

            int iYear = Int32.Parse(Brithday);
            double Mj = Double.Parse(Grade);

            Student newNamjo = new Student(name, id, iYear, Height, Mj , Major);
            this.Namjo.Add(newNamjo);

            BindingSource source = new BindingSource();
            source.DataSource = this.Namjo;
            this.Mo.DataSource = source;

            //clear textbox
            this.m1.Text = "";
            this.m2.Text = "";
            this.m3.Text = "";
            this.m4.Text = "";
            this.m5.Text = "";
            this.m6.Text = "";
            
            M.Text = (from DataGridViewRow row in Mo.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Max().ToString();
            double max = 0;
            for (int i = 0; i <= Mo.Rows.Count - 1; i++)
            {
                if (max < double.Parse(Mo.Rows[i].Cells[4].Value.ToString()))
                {

                    max = double.Parse(Mo.Rows[i].Cells[4].Value.ToString());

                }
            }

            M.Text = max.ToString();

            double[] Mmax = new double[Mo.Rows.Count];
            Mmax = (from DataGridViewRow row in Mo.Rows
                    where row.Cells[1].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            M.Text = Mmax.Max().ToString();
            //min
            
            k2.Text = (from DataGridViewRow row in Mo.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Min().ToString();
           
            

            double min = 0;
            for (int i = 0; i <= Mo.Rows.Count - 1; i++)
            {
                if (min < double.Parse(Mo.Rows[i].Cells[4].Value.ToString()))
                {

                    min = double.Parse(Mo.Rows[i].Cells[4].Value.ToString());

                }
            }

            k2.Text = min.ToString();

            double[] Mmin = new double[Mo.Rows.Count];
            Mmin = (from DataGridViewRow row in Mo.Rows
                    where row.Cells[1].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            k2.Text = Mmin.Min().ToString();

            int mj = Mo.Rows.Count;
            mmm.Text = mj.ToString();
        }
    }
}