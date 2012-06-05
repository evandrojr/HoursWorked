using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HorasTrabalhadas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        DateTime T1, T2, T3, T4;


        private void txt1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            calc();
        }


        private void calc() {
            try
            {
                T1 = Convert.ToDateTime(txt1.Text);
                T2 = Convert.ToDateTime(txt2.Text);
                T3 = Convert.ToDateTime(txt3.Text);
                T4 = Convert.ToDateTime(txt4.Text);

                TimeSpan manha = T2.Subtract(T1);
                TimeSpan tarde = T4.Subtract(T3);
                lblHorasTrab.Text=tarde.Add(manha).ToString();
            }
            catch { }
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            calc();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "mailto:evandrojr@gmail.com?subject=Programa Horas Trabalhadas";
            proc.Start();

        }



    }
}
