
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(-6, 34);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 25);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(374, 20);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 285);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(146, 72);
            this.b0.TabIndex = 3;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.NumEvent);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 207);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(70, 72);
            this.b1.TabIndex = 4;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.NumEvent);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(88, 207);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(70, 72);
            this.b2.TabIndex = 5;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.NumEvent);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(164, 207);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(70, 72);
            this.b3.TabIndex = 6;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.NumEvent);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 129);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(70, 72);
            this.b4.TabIndex = 7;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.NumEvent);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(88, 129);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(70, 72);
            this.b5.TabIndex = 8;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.NumEvent);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(164, 129);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(70, 72);
            this.b6.TabIndex = 9;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.NumEvent);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 51);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(70, 72);
            this.b7.TabIndex = 10;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.NumEvent);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(88, 51);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(70, 72);
            this.b8.TabIndex = 11;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.NumEvent);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(164, 51);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(70, 72);
            this.b9.TabIndex = 12;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.NumEvent);
            // 
            // bSub
            // 
            this.bSub.Location = new System.Drawing.Point(240, 207);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(70, 72);
            this.bSub.TabIndex = 13;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.operandEvent);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(240, 285);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(70, 72);
            this.bAdd.TabIndex = 14;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.operandEvent);
            // 
            // bMul
            // 
            this.bMul.Location = new System.Drawing.Point(240, 129);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(70, 72);
            this.bMul.TabIndex = 15;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.operandEvent);
            // 
            // bDiv
            // 
            this.bDiv.Location = new System.Drawing.Point(240, 51);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(70, 72);
            this.bDiv.TabIndex = 16;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.operandEvent);
            // 
            // bEq
            // 
            this.bEq.Location = new System.Drawing.Point(316, 207);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(70, 150);
            this.bEq.TabIndex = 17;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = true;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(316, 129);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(70, 72);
            this.bC.TabIndex = 18;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bCE
            // 
            this.bCE.Location = new System.Drawing.Point(316, 51);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(70, 72);
            this.bCE.TabIndex = 19;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 72);
            this.button1.TabIndex = 20;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bEq);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbResult);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.NumEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button button1;
    }
}

