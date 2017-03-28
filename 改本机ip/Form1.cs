using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Threading;

namespace 改本机ip
{
    public partial class Form1 : Form
    {
        public Files_tream save = new Files_tream("save.txt", Application.StartupPath + @"\save.txt");
        public List<string> inf = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
            LoadSave();
        }

        private void BT_alert_Click(object sender, EventArgs e)
        {
            changeip();
        }

        /// <summary>  
        /// 执行DOS命令，返回DOS命令的输出  
        /// </summary>  
        /// <param name="dosCommand">dos命令</param>  
        /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），  
        /// 如果设定为0，则无限等待</param>  
        /// <returns>返回DOS命令的输出</returns>  
        public static string Execute(string command, int seconds)
        {
            string output = ""; //输出字符串  
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象  
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";//设定需要执行的命令  
                startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出  
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动  
                startInfo.RedirectStandardInput = false;//不重定向输入  
                startInfo.RedirectStandardOutput = true; //重定向输出  
                startInfo.CreateNoWindow = true;//不创建窗口  
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程  
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束  
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒  
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出  
                    }
                }
                catch
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }
        //得到当前的ip信息
        public void refresh()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection nics = mc.GetInstances();
            foreach (ManagementObject nic in nics)
            {
                if (Convert.ToBoolean(nic["ipEnabled"]) == true)
                {
                    try
                    {
                        TB_ip.Text = (nic["IPAddress"] as String[])[0];
                        TB_mask.Text = (nic["IPSubnet"] as String[])[0];
                        TB_gateway.Text = (nic["DefaultIPGateway"] as String[])[0];
                        TB_DNS.Text = (nic["DNSServerSearchOrder"] as String[])[0];
                    }
                    catch (Exception ex)
                    { ; }
                }
            }
        }
        public void changeip()
        {
            TS_status.Text = "修改ip中";
            var ret=Execute("netsh interface ip set address 以太网 static " + TB_ip.Text + "   " + TB_mask.Text + "   " + TB_gateway.Text, 1).Replace("\r\n", "");
            TS_status.Text = ret == "" ? "修改成功!" : ret;
        }
        public void changedns()
        {
            TS_status.Text = "修改dns中";
            var ret= Execute("netsh    interface ip set dns    以太网    static " + TB_DNS.Text + "  primary", 1).Replace("\r\n", "");
            TS_status.Text = ret==""?"修改成功!":ret;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            changedns();
        }
        public void LoadSave()
        {
            var  list= save.Read_line();//组合名,ip,掩码,网关,dns
            inf = list;
            foreach (string a in list)
                CB_array.Items.Add(a.Split(',')[0]);
        }

        private void CB_array_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = CB_array.SelectedItem;
            foreach (string a in inf)
            {
                var arr= a.Split(',');
                if (arr.Length != 5)
                    throw new Exception("错误的配置信息");
                if (arr[0].Equals(name))
                {
                    TB_ip.Text = arr[1];
                    TB_mask.Text = arr[2];
                    TB_gateway.Text = arr[3];
                    TB_DNS.Text = arr[4];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            arr[1] = TB_ip.Text;
            arr[2] = TB_mask.Text;
            arr[3] = TB_gateway.Text;
            arr[4] = TB_DNS.Text;
            (new Save(save, arr,inf)).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ret = Execute("netsh interface ip set address name=以太网 source=dhcp", 1).Replace("\r\n","");
            TS_status.Text = ret == "" ? "修改成功!" : ret;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ret = Execute("netsh interface ip set dns name=以太网 source=dhcp", 1).Replace("\r\n","");
            TS_status.Text = ret == "" ? "修改成功!" : ret;
        }
    }
}
