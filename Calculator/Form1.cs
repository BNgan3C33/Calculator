using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;    
            String opt = btn.Text;

            int no1 = Int32.Parse(txtNo1.Text);
            int no2 = Int32.Parse(txtNo2.Text);
            int kq = 0;

            switch (opt)
            {
                case "+":
                    kq = no1 + no2;
                    break;
                case "-":
                    kq = no1 - no2;
                    break;
                case "*":
                    kq = no1 * no2;
                    break;
                case "/":
                    if (no2 == 0)
                        MessageBox.Show("Phép chia không thực hiện được");
                    else
                        kq = no1 / no2;
                    break;
            }
            txtResult.Text = kq.ToString();
            txtResult.Show();
        }
    }
}
