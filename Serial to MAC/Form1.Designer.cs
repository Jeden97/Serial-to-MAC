namespace Serial_to_MAC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calculate = new System.Windows.Forms.Button();
            this.copyMac = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.copySerial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialNum
            // 
            this.serialNum.Location = new System.Drawing.Point(109, 121);
            this.serialNum.Name = "serialNum";
            this.serialNum.Size = new System.Drawing.Size(183, 20);
            this.serialNum.TabIndex = 0;
            this.serialNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Number";
            // 
            // mainLogo
            // 
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(66, 26);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(291, 66);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 2;
            this.mainLogo.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(265, 176);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Serial Number";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MAC Address";
            this.columnHeader4.Width = 135;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(164, 147);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // copyMac
            // 
            this.copyMac.Location = new System.Drawing.Point(35, 147);
            this.copyMac.Name = "copyMac";
            this.copyMac.Size = new System.Drawing.Size(103, 23);
            this.copyMac.TabIndex = 5;
            this.copyMac.Text = "Copy All MAC Address";
            this.copyMac.UseVisualStyleBackColor = true;
            this.copyMac.Click += new System.EventHandler(this.copyMac_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // copySerial
            // 
            this.copySerial.Location = new System.Drawing.Point(267, 147);
            this.copySerial.Name = "copySerial";
            this.copySerial.Size = new System.Drawing.Size(103, 23);
            this.copySerial.TabIndex = 6;
            this.copySerial.Text = "Copy All Serial Numbers";
            this.copySerial.UseVisualStyleBackColor = true;
            this.copySerial.Click += new System.EventHandler(this.copySerial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 384);
            this.Controls.Add(this.copySerial);
            this.Controls.Add(this.copyMac);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mainLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialNum);
            this.Name = "Form1";
            this.Text = "Serial To Mac Address";
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serialNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainLogo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button copyMac;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button copySerial;
    }
}

