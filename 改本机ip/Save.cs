using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 改本机ip
{
    public partial class Save : Form
    {
        public Save(Files_tream save, string [] arr,List<string> inf )
        {
            InitializeComponent();
            this.save = save;
            this.arr = arr;
            this.inf = inf;
        }
        public Files_tream save;
        public string[] arr;
        List<string>inf;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TB_name.Text != "")
            {
                arr[0] = TB_name.Text;
                inf.Add(arr[0] + "," + arr[1] + "," + arr[2] + "," + arr[3] + "," + arr[4]);
                save.Write_line(inf);
                this.Close();
            }            
        }
    }
}
