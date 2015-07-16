using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowBank
{
    public partial class Form1 : Form
    {
        MainSystem Domain = new MainSystem();
        Shelves counter1 = new Shelves();
        Shelves counter2 = new Shelves();
        WaitNumber pull = new WaitNumber();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pullbutton_Click(object sender, EventArgs e)
        {
            if (pull.wait_number > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            Domain.currentnumber++;
            pull.wait_number+=1;
            waitnumberbox.Text = Convert.ToString(pull.wait_number-1);
            currentNumber.Text = Convert.ToString(Domain.currentnumber);
            Domain.save.Add(Domain.currentnumber);
            counterwait.Text = Convert.ToString(pull.wait_number);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void waitnumberbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pull.wait_number -= 1 ;
            if (pull.wait_number > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                waitnumberbox.Text = Convert.ToString(pull.wait_number - 1);
            }
            else 
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            counterwait.Text = Convert.ToString(pull.wait_number );
            foreach (int item in Domain.save)
        	{
                MessageBox.Show("counter1 : " +item+"(Number) customer.." );       
                break;
	        }
            counter1box.Text = Convert.ToString(Domain.save[0]);
            Domain.save.RemoveAt(0);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pull.wait_number -= 1;
            if (pull.wait_number > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                waitnumberbox.Text = Convert.ToString(pull.wait_number - 1);
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            counterwait.Text = Convert.ToString(pull.wait_number);
            foreach (int item in Domain.save)
            {
                MessageBox.Show("counter2 : " + item + "(Number) customer..");
                break;
            }
            counter2box.Text = Convert.ToString(Domain.save[0]);
            Domain.save.RemoveAt(0);
        }
    }
}
