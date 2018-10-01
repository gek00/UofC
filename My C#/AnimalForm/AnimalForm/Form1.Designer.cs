namespace AnimalForm
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
            this.lstAnimal = new System.Windows.Forms.ListBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtAcquire = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAnimal
            // 
            this.lstAnimal.FormattingEnabled = true;
            this.lstAnimal.Location = new System.Drawing.Point(12, 12);
            this.lstAnimal.Name = "lstAnimal";
            this.lstAnimal.Size = new System.Drawing.Size(380, 199);
            this.lstAnimal.TabIndex = 0;
            this.lstAnimal.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnClear);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.label1);
            this.grpAdd.Controls.Add(this.lblDays);
            this.grpAdd.Controls.Add(this.txtAcquire);
            this.grpAdd.Controls.Add(this.txtDays);
            this.grpAdd.Controls.Add(this.lblName);
            this.grpAdd.Controls.Add(this.txtName);
            this.grpAdd.Location = new System.Drawing.Point(413, 13);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(199, 198);
            this.grpAdd.TabIndex = 1;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Animal";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(28, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "A&dd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acquiring Cost";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(10, 70);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(68, 13);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Days Owned";
            // 
            // txtAcquire
            // 
            this.txtAcquire.Location = new System.Drawing.Point(84, 108);
            this.txtAcquire.Name = "txtAcquire";
            this.txtAcquire.Size = new System.Drawing.Size(100, 20);
            this.txtAcquire.TabIndex = 3;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(84, 67);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(317, 218);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Tot&al";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "$8.50 is applied per day owned*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lstAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAnimal;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtAcquire;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label label2;
    }
}

