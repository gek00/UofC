namespace Grades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblQuiz1 = new System.Windows.Forms.Label();
            this.lblQuiz2 = new System.Windows.Forms.Label();
            this.lblQuiz3 = new System.Windows.Forms.Label();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.lblFinalEx = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.txtQuiz3 = new System.Windows.Forms.TextBox();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.txtFinalEx = new System.Windows.Forms.TextBox();
            this.GradeAvg = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtLowest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuiz1
            // 
            this.lblQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz1.Location = new System.Drawing.Point(51, 97);
            this.lblQuiz1.Name = "lblQuiz1";
            this.lblQuiz1.Size = new System.Drawing.Size(97, 37);
            this.lblQuiz1.TabIndex = 0;
            this.lblQuiz1.Text = "Quiz I";
            // 
            // lblQuiz2
            // 
            this.lblQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz2.Location = new System.Drawing.Point(51, 149);
            this.lblQuiz2.Name = "lblQuiz2";
            this.lblQuiz2.Size = new System.Drawing.Size(97, 34);
            this.lblQuiz2.TabIndex = 1;
            this.lblQuiz2.Text = "Quiz II";
            // 
            // lblQuiz3
            // 
            this.lblQuiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz3.Location = new System.Drawing.Point(51, 197);
            this.lblQuiz3.Name = "lblQuiz3";
            this.lblQuiz3.Size = new System.Drawing.Size(97, 33);
            this.lblQuiz3.TabIndex = 2;
            this.lblQuiz3.Text = "Quiz III";
            // 
            // lblMidterm
            // 
            this.lblMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidterm.Location = new System.Drawing.Point(51, 247);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(105, 33);
            this.lblMidterm.TabIndex = 3;
            this.lblMidterm.Text = "Midterm";
            // 
            // lblFinalEx
            // 
            this.lblFinalEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalEx.Location = new System.Drawing.Point(51, 289);
            this.lblFinalEx.Name = "lblFinalEx";
            this.lblFinalEx.Size = new System.Drawing.Size(132, 34);
            this.lblFinalEx.TabIndex = 4;
            this.lblFinalEx.Text = "Final Exam";
            this.lblFinalEx.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(296, 395);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(193, 55);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz1.Location = new System.Drawing.Point(296, 97);
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(100, 22);
            this.txtQuiz1.TabIndex = 6;
            this.txtQuiz1.TextChanged += new System.EventHandler(this.txtQuiz1_TextChanged);
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz2.Location = new System.Drawing.Point(296, 149);
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(100, 22);
            this.txtQuiz2.TabIndex = 7;
            // 
            // txtQuiz3
            // 
            this.txtQuiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz3.Location = new System.Drawing.Point(296, 197);
            this.txtQuiz3.Name = "txtQuiz3";
            this.txtQuiz3.Size = new System.Drawing.Size(100, 22);
            this.txtQuiz3.TabIndex = 8;
            // 
            // txtMidterm
            // 
            this.txtMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidterm.Location = new System.Drawing.Point(296, 247);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(100, 22);
            this.txtMidterm.TabIndex = 9;
            // 
            // txtFinalEx
            // 
            this.txtFinalEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalEx.Location = new System.Drawing.Point(296, 289);
            this.txtFinalEx.Name = "txtFinalEx";
            this.txtFinalEx.Size = new System.Drawing.Size(100, 22);
            this.txtFinalEx.TabIndex = 10;
            // 
            // GradeAvg
            // 
            this.GradeAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeAvg.Location = new System.Drawing.Point(126, 33);
            this.GradeAvg.Name = "GradeAvg";
            this.GradeAvg.Size = new System.Drawing.Size(104, 36);
            this.GradeAvg.TabIndex = 11;
            this.GradeAvg.Text = "Grade:";
            // 
            // lblAverage
            // 
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(191, 343);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(108, 31);
            this.lblAverage.TabIndex = 12;
            this.lblAverage.Text = "Average";
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAverage.Enabled = false;
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAverage.Location = new System.Drawing.Point(305, 343);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 31);
            this.txtAverage.TabIndex = 13;
            // 
            // txtLowest
            // 
            this.txtLowest.Enabled = false;
            this.txtLowest.Location = new System.Drawing.Point(56, 395);
            this.txtLowest.Name = "txtLowest";
            this.txtLowest.Size = new System.Drawing.Size(100, 20);
            this.txtLowest.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lowest Score Dropped";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLetter
            // 
            this.txtLetter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLetter.Enabled = false;
            this.txtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter.Location = new System.Drawing.Point(245, 34);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(56, 35);
            this.txtLetter.TabIndex = 17;
            this.txtLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(210, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Cle&ar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(510, 513);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLowest);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.GradeAvg);
            this.Controls.Add(this.txtFinalEx);
            this.Controls.Add(this.txtMidterm);
            this.Controls.Add(this.txtQuiz3);
            this.Controls.Add(this.txtQuiz2);
            this.Controls.Add(this.txtQuiz1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFinalEx);
            this.Controls.Add(this.lblMidterm);
            this.Controls.Add(this.lblQuiz3);
            this.Controls.Add(this.lblQuiz2);
            this.Controls.Add(this.lblQuiz1);
            this.Name = "Form1";
            this.Text = "Grade Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuiz1;
        private System.Windows.Forms.Label lblQuiz2;
        private System.Windows.Forms.Label lblQuiz3;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.Label lblFinalEx;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtQuiz1;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.TextBox txtQuiz3;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.TextBox txtFinalEx;
        private System.Windows.Forms.Label GradeAvg;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtLowest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnClear;
    }
}

