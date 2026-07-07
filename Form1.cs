using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Honda_kline
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            LoadComPorts();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadComPorts()
        {
            cmbCom.Items.Clear();

            foreach (string port in SerialPort.GetPortNames())
            {
                cmbCom.Items.Add(port);
            }

            if (cmbCom.Items.Count > 0)
            {
                cmbCom.SelectedIndex = 0;
            }
        }

    }