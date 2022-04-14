using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Proxies;
using RemoteClass;
namespace RemoteClient
{
    public partial class Form1 : Form
    {
        private IRemoteClass _obj = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = (DotNetRemoting.RemoteClass)Activator.GetObject(typeof(DotNetRemoting.RemoteClass),
                               "tcp://localhost:8085/RemoteClass");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(tb_x.Text);
                int b = int.Parse(tb_y.Text);
                switch (((Button)sender).Name)
                {
                    case "btn_add":
                        tb_ans.Text = (_obj.Add(a, b)).ToString();
                        break;
                    case "btn_substract":
                        tb_ans.Text = (_obj.Substract(a, b)).ToString();
                        break;
                    case "btn_mutly":
                        tb_ans.Text = (_obj.Multy(a, b)).ToString();
                        break;
                    case "btn_divide":
                        tb_ans.Text = (_obj.Divide(a, b)).ToString();
                        break;
                    default:
                        break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
