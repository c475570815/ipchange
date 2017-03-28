using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 改本机ip
{
   public class Files_tream
    {
        private string filename;//操作文件名
        private string filepath;//操作文件路径;
        public Files_tream(string name, string path)//构造函数中给出文件名和路径
        {
            filename = name;
            filepath = path;
        }
        /// <summary>
        /// 读取文件的方法
        /// </summary>
        /// <returns></returns>
        public string Read_document()
        {
            try
            {
                FileStream read = new FileStream(filepath, FileMode.Open);//文件路径 文件操作方式 
                byte[] databyte = new byte[read.Length];
                for (int i = 0; i < read.Length; i++)
                {
                    databyte[i] = (byte)read.ReadByte();
                }
                UTF8Encoding endcoding = new UTF8Encoding();
                string b = endcoding.GetString(databyte);
                read.Close();
                return b;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                return "";
            }
        }
        /// <summary>
        /// 写入文件方法
        /// </summary>
        /// <param name="body">要写入的文本</param>
        /// <returns></returns>
        public bool Write_documnet(string body)
        {
            try
            {
                FileStream write = new FileStream(filepath, FileMode.Open);
                UTF8Encoding endcoding = new UTF8Encoding();
                byte[] databyte = endcoding.GetBytes(body);
                try
                {
                    write.Write(databyte, 0, body.Length);
                    write.Close();
                    return true;
                }
                catch
                {
                    write.Close();
                    return false;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                return false;
            }
        }
        /// <summary>
        /// 向文件写入数据
        /// </summary>
        /// <param name="line">一行数据</param>
        /// <returns></returns>
        public bool Write_line(List<string> line)
        {
            try
            {
                FileStream record = new FileStream(filepath, FileMode.Create);
                StreamWriter write = new StreamWriter(record,Encoding.UTF8);
                foreach(string a in line)
                    write.WriteLine(a);
                write.Close();
                record.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        /// <summary>
        /// 读取一行
        /// </summary>
        /// <returns></returns>
        public List<string> Read_line()
        {
            try
            {
                FileStream record = new FileStream(filepath, FileMode.OpenOrCreate);
                StreamReader read = new StreamReader(record);
                string r;
                List<string> rt = new List<string>();
                for (int i = 0; (r = read.ReadLine()) != null; i++)
                {
                    rt.Add(r);
                }
                read.Close();
                record.Close();

                return rt;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                return null;
            }
        }
    }
}
