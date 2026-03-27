using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace интерфейс
{
    public partial class Form1 : Form
    {
        private string fileText;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
                double NUM1 = Convert.ToDouble(textBox6.Text);
                double NUM2 = Convert.ToDouble(textBox7.Text);
                double average = (NUM1 + NUM2) / 2;
                textBox8.Text = "Среднее арифметическое: " + average;
        }

        private void button2_Click(object sender, EventArgs e)
       {
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }
        
        private void button8_Click(object sender, EventArgs e)

        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*{
                var matches = Regex.Matches(fileText, @"\b\d{2}\.\d{2}\.\d{4}\b");
                List<DateTime> dates = new List<DateTime>();

                foreach (Match m in matches)
                {
                    if (DateTime.TryParseExact(
                        m.Value,
                        "dd.MM.yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime dt))
                    {
                        dates.Add(dt);
                    }
                }

                if (dates.Count == 0) return;

                textBox13.Text = dates.Min().ToShortDateString();
                textBox12.Text = dates.Max().ToShortDateString();

                monthCalendar1.BoldedDates = dates.ToArray();
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                if (selectedItem == "Слова")
                {
                    groupBox3.Visible = true;
                    groupBox4.Visible = false;
                    groupBox5.Visible = false;
                }
                 else if (selectedItem == "Числа")
                {
                    groupBox3.Visible = false;
                    groupBox4.Visible = true;
                    groupBox5.Visible = false;
                }
                else if (selectedItem == "Даты")
                {
                    groupBox3.Visible = false;
                    groupBox4.Visible = false;
                    groupBox5.Visible = true;
                }
            }
        }
    }
}
