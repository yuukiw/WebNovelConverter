namespace WebNovelConverter
{
    partial class FaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ret = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ret
            // 
            this.ret.Location = new System.Drawing.Point(12, 186);
            this.ret.Name = "ret";
            this.ret.Size = new System.Drawing.Size(144, 23);
            this.ret.TabIndex = 1;
            this.ret.Text = "Retrive";
            this.ret.UseVisualStyleBackColor = true;
            this.ret.Click += new System.EventHandler(this.ret_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ret);
            this.Controls.Add(this.listBox1);
            this.Name = "FaveForm";
            this.Text = "FaveForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ret;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}