
namespace Excel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_IMPORT = new System.Windows.Forms.Button();
            this.button_EXPORT = new System.Windows.Forms.Button();
            this.button_Calculare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_IMPORT
            // 
            this.button_IMPORT.Location = new System.Drawing.Point(631, 13);
            this.button_IMPORT.Name = "button_IMPORT";
            this.button_IMPORT.Size = new System.Drawing.Size(157, 55);
            this.button_IMPORT.TabIndex = 1;
            this.button_IMPORT.Text = "IMPORT";
            this.button_IMPORT.UseVisualStyleBackColor = true;
            this.button_IMPORT.Click += new System.EventHandler(this.button_IMPORT_Click);
            // 
            // button_EXPORT
            // 
            this.button_EXPORT.Location = new System.Drawing.Point(631, 136);
            this.button_EXPORT.Name = "button_EXPORT";
            this.button_EXPORT.Size = new System.Drawing.Size(157, 56);
            this.button_EXPORT.TabIndex = 2;
            this.button_EXPORT.Text = "EXPORT";
            this.button_EXPORT.UseVisualStyleBackColor = true;
            this.button_EXPORT.Click += new System.EventHandler(this.button_EXPORT_Click);
            // 
            // button_Calculare
            // 
            this.button_Calculare.Location = new System.Drawing.Point(631, 74);
            this.button_Calculare.Name = "button_Calculare";
            this.button_Calculare.Size = new System.Drawing.Size(157, 56);
            this.button_Calculare.TabIndex = 3;
            this.button_Calculare.Text = "CALCULARE";
            this.button_Calculare.UseVisualStyleBackColor = true;
            this.button_Calculare.Click += new System.EventHandler(this.button_Calculare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Calculare);
            this.Controls.Add(this.button_EXPORT);
            this.Controls.Add(this.button_IMPORT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Prelucrare Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_IMPORT;
        private System.Windows.Forms.Button button_EXPORT;
        private System.Windows.Forms.Button button_Calculare;
    }
}

