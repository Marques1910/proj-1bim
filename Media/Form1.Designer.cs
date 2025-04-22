namespace Media
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.numMedia1 = new System.Windows.Forms.NumericUpDown();
            this.numMedia2 = new System.Windows.Forms.NumericUpDown();
            this.numMedia3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Média 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Média 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Média 3:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(43, 279);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(40, 314);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(103, 30);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMedia1
            // 
            this.numMedia1.Location = new System.Drawing.Point(43, 60);
            this.numMedia1.Name = "numMedia1";
            this.numMedia1.Size = new System.Drawing.Size(120, 20);
            this.numMedia1.TabIndex = 8;
            // 
            // numMedia2
            // 
            this.numMedia2.Location = new System.Drawing.Point(43, 147);
            this.numMedia2.Name = "numMedia2";
            this.numMedia2.Size = new System.Drawing.Size(120, 20);
            this.numMedia2.TabIndex = 9;
            // 
            // numMedia3
            // 
            this.numMedia3.Location = new System.Drawing.Point(43, 228);
            this.numMedia3.Name = "numMedia3";
            this.numMedia3.Size = new System.Drawing.Size(120, 20);
            this.numMedia3.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 551);
            this.Controls.Add(this.numMedia3);
            this.Controls.Add(this.numMedia2);
            this.Controls.Add(this.numMedia1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numMedia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numMedia1;
        private System.Windows.Forms.NumericUpDown numMedia2;
        private System.Windows.Forms.NumericUpDown numMedia3;
    }
}

