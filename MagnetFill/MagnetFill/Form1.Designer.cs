namespace MagnetFill
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbMagnet = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.tbWeb = new System.Windows.Forms.TextBox();
            this.btnWeb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(43, 82);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(184, 21);
            this.tbInput.TabIndex = 0;
            // 
            // lbMagnet
            // 
            this.lbMagnet.AutoSize = true;
            this.lbMagnet.Location = new System.Drawing.Point(43, 120);
            this.lbMagnet.Name = "lbMagnet";
            this.lbMagnet.Size = new System.Drawing.Size(125, 12);
            this.lbMagnet.TabIndex = 1;
            this.lbMagnet.Text = "magnet:?xt=urn:btih:";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(73, 161);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Thunder";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // tbWeb
            // 
            this.tbWeb.Location = new System.Drawing.Point(316, 82);
            this.tbWeb.Name = "tbWeb";
            this.tbWeb.Size = new System.Drawing.Size(188, 21);
            this.tbWeb.TabIndex = 3;
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(376, 161);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(75, 23);
            this.btnWeb.TabIndex = 4;
            this.btnWeb.Text = "Chrome";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Torrent HASH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Website";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.tbWeb);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lbMagnet);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lbMagnet;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox tbWeb;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

