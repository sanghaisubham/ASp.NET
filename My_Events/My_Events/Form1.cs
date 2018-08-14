using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Events
{
    //partial class is a class that can exist in more than one files

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            publisher publisher = new publisher();
            Subscriber subscriber = new Subscriber();
            //publisher.AlarmEvent("hello"); Error ,event can be raised only from the class where it is declared
            publisher.AlarmEvent += subscriber.EventHandler;
            publisher.RaiseAlarm();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + " " + e.Y;
        }
    }
}
