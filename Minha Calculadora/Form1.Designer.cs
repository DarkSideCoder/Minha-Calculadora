namespace Minha_Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vl = new System.Windows.Forms.TextBox();
            this.vl2 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.soma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre com o valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entre com o valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado ";
            // 
            // vl
            // 
            this.vl.Location = new System.Drawing.Point(139, 43);
            this.vl.Name = "vl";
            this.vl.Size = new System.Drawing.Size(109, 20);
            this.vl.TabIndex = 4;
            // 
            // vl2
            // 
            this.vl2.Location = new System.Drawing.Point(139, 78);
            this.vl2.Name = "vl2";
            this.vl2.Size = new System.Drawing.Size(109, 20);
            this.vl2.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(177, 113);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(16, 13);
            this.label.TabIndex = 7;
            this.label.Text = "...";
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(15, 160);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(95, 33);
            this.soma.TabIndex = 8;
            this.soma.Text = "Somar";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.label);
            this.Controls.Add(this.vl2);
            this.Controls.Add(this.vl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vl;
        private System.Windows.Forms.TextBox vl2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button soma;
    }
}

