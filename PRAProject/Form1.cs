using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRAProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_posts_Click(object sender, EventArgs e)
        {
            panel_feed.BringToFront();
        }

        private void label_userName_Click(object sender, EventArgs e)
        {
            panel_user.BringToFront();
        }

        private void button_newpost_Click(object sender, EventArgs e)
        {
            panel_newPost.BringToFront();
        }

        private void button_editpost_Click(object sender, EventArgs e)
        {
            panel_editPost.BringToFront();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            panel_contactAdmin.BringToFront();
        }
    }
}
