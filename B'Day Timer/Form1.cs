using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Day_Timer
{
    public partial class Form1 : Form
    {
        List<Dictionary<string, Color>> templates = new List<Dictionary<string, Color>>();
        int c_template = 0;
        public Form1()
        {
            InitializeComponent();
            Dictionary<string, Color> template = new Dictionary<string, Color>();
            template.Add("bottomleft", Color.FromArgb(255, 192, 128));
            template.Add("bottomright", Color.FromArgb(251, 97, 122));
            template.Add("topleft", Color.FromArgb(251, 97, 122));
            template.Add("topright", Color.FromArgb(251, 97, 122));

            templates.Add(template);

            template = new Dictionary<string, Color>();
            template.Add("bottomleft", Color.FromArgb(192, 0, 192));
            template.Add("bottomright", Color.Black);
            template.Add("topleft", Color.FromArgb(251, 97, 122));
            template.Add("topright", Color.FromArgb(251, 97, 122));

            templates.Add(template);

            template = new Dictionary<string, Color>();
            template.Add("bottomleft", Color.Black);
            template.Add("bottomright", Color.Black);
            template.Add("topleft", Color.FromArgb(251, 97, 122));
            template.Add("topright", Color.Turquoise);

            templates.Add(template);

        }

        public void load_theme(Dictionary<string, Color> theme)
        {
            
            bunifuGradientPanel1.GradientBottomLeft = theme["bottomleft"];
            bunifuGradientPanel1.GradientBottomRight = theme["bottomright"];
            bunifuGradientPanel1.GradientTopLeft = theme["topleft"];
            bunifuGradientPanel1.GradientTopRight = theme["topright"];
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bubtnNotify_Click(object sender, EventArgs e)
        {
            if(c_template< templates.Count - 1)
            {
                c_template++;
            }
            else
            {
                c_template = 0;
            }
            load_theme(templates[c_template]);
        }

        private void bubtnDownload_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Dictionary<string, Color> template = new Dictionary<string, Color>();
            template.Add("bottomleft", Color.FromArgb(r.Next(0, 255), r.Next(0,192), r.Next(0, 128)));
            template.Add("bottomright", Color.FromArgb(r.Next(0, 251), r.Next(0, 97), r.Next(0, 122)));
            template.Add("topleft", Color.FromArgb(r.Next(0, 251), r.Next(0, 97), r.Next(0, 122)));
            template.Add("topright", Color.FromArgb(r.Next(0, 251), r.Next(0, 97), r.Next(0, 122)));

            load_theme(template);

            templates.Add(template);
        }

        DateTime endtime = new DateTime(2019, 01, 25, 0, 0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endtime.Subtract(DateTime.Now);

            lblNoDays.Text = ts.Days.ToString();
            lblNoHours.Text = ts.Hours.ToString();
            lblNoMinutes.Text = ts.Minutes.ToString();
            lblNoSeconds.Text = ts.Seconds.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}