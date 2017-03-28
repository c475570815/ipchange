namespace 改本机ip
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_alert = new System.Windows.Forms.Button();
            this.ipv4地址 = new System.Windows.Forms.Label();
            this.TB_ip = new System.Windows.Forms.TextBox();
            this.TB_mask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_gateway = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_DNS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TS_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_array = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_alert
            // 
            this.BT_alert.Location = new System.Drawing.Point(47, 177);
            this.BT_alert.Name = "BT_alert";
            this.BT_alert.Size = new System.Drawing.Size(75, 23);
            this.BT_alert.TabIndex = 0;
            this.BT_alert.Text = "修改ip";
            this.BT_alert.UseVisualStyleBackColor = true;
            this.BT_alert.Click += new System.EventHandler(this.BT_alert_Click);
            // 
            // ipv4地址
            // 
            this.ipv4地址.AutoSize = true;
            this.ipv4地址.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ipv4地址.Location = new System.Drawing.Point(50, 49);
            this.ipv4地址.Name = "ipv4地址";
            this.ipv4地址.Size = new System.Drawing.Size(72, 16);
            this.ipv4地址.TabIndex = 1;
            this.ipv4地址.Text = "ipv4地址";
            // 
            // TB_ip
            // 
            this.TB_ip.Location = new System.Drawing.Point(129, 49);
            this.TB_ip.Name = "TB_ip";
            this.TB_ip.Size = new System.Drawing.Size(100, 21);
            this.TB_ip.TabIndex = 2;
            // 
            // TB_mask
            // 
            this.TB_mask.Location = new System.Drawing.Point(129, 76);
            this.TB_mask.Name = "TB_mask";
            this.TB_mask.Size = new System.Drawing.Size(100, 21);
            this.TB_mask.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(50, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "子网掩码";
            // 
            // TB_gateway
            // 
            this.TB_gateway.Location = new System.Drawing.Point(129, 103);
            this.TB_gateway.Name = "TB_gateway";
            this.TB_gateway.Size = new System.Drawing.Size(100, 21);
            this.TB_gateway.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "网关";
            // 
            // TB_DNS
            // 
            this.TB_DNS.Location = new System.Drawing.Point(129, 130);
            this.TB_DNS.Name = "TB_DNS";
            this.TB_DNS.Size = new System.Drawing.Size(100, 21);
            this.TB_DNS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(50, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "DNS";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(357, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TS_status
            // 
            this.TS_status.Name = "TS_status";
            this.TS_status.Size = new System.Drawing.Size(35, 17);
            this.TS_status.Text = "状态:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "修改dns";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_array
            // 
            this.CB_array.FormattingEnabled = true;
            this.CB_array.Location = new System.Drawing.Point(129, 12);
            this.CB_array.Name = "CB_array";
            this.CB_array.Size = new System.Drawing.Size(121, 20);
            this.CB_array.TabIndex = 11;
            this.CB_array.SelectedIndexChanged += new System.EventHandler(this.CB_array_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "组合选择";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "ip自动分配";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "DNS自动分配";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 301);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CB_array);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TB_DNS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_gateway);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_mask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipv4地址);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BT_alert);
            this.Name = "Form1";
            this.Text = "以太网ip修改";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_alert;
        private System.Windows.Forms.Label ipv4地址;
        private System.Windows.Forms.TextBox TB_ip;
        private System.Windows.Forms.TextBox TB_mask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_gateway;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_DNS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TS_status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_array;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

