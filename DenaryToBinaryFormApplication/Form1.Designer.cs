namespace DenaryToBinaryFormApplication
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
            this.btnDenaryToBinary = new System.Windows.Forms.Button();
            this.textDenary = new System.Windows.Forms.TextBox();
            this.textBinary = new System.Windows.Forms.TextBox();
            this.lblPlaceValues = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDenaryToBinary
            // 
            this.btnDenaryToBinary.Location = new System.Drawing.Point(54, 430);
            this.btnDenaryToBinary.Name = "btnDenaryToBinary";
            this.btnDenaryToBinary.Size = new System.Drawing.Size(192, 94);
            this.btnDenaryToBinary.TabIndex = 0;
            this.btnDenaryToBinary.Text = "Calculate";
            this.btnDenaryToBinary.UseVisualStyleBackColor = true;
            this.btnDenaryToBinary.Click += new System.EventHandler(this.btnDenaryToBinary_Click);
            // 
            // textDenary
            // 
            this.textDenary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDenary.Location = new System.Drawing.Point(54, 173);
            this.textDenary.Name = "textDenary";
            this.textDenary.Size = new System.Drawing.Size(640, 49);
            this.textDenary.TabIndex = 1;
            // 
            // textBinary
            // 
            this.textBinary.Enabled = false;
            this.textBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBinary.Location = new System.Drawing.Point(54, 349);
            this.textBinary.Name = "textBinary";
            this.textBinary.Size = new System.Drawing.Size(640, 49);
            this.textBinary.TabIndex = 2;
            // 
            // lblPlaceValues
            // 
            this.lblPlaceValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceValues.Location = new System.Drawing.Point(46, 275);
            this.lblPlaceValues.Name = "lblPlaceValues";
            this.lblPlaceValues.Size = new System.Drawing.Size(512, 57);
            this.lblPlaceValues.TabIndex = 3;
            this.lblPlaceValues.Text = "128 64 32 16    8    4    2    1";
            this.lblPlaceValues.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter a denary value to convert: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlaceValues);
            this.Controls.Add(this.textBinary);
            this.Controls.Add(this.textDenary);
            this.Controls.Add(this.btnDenaryToBinary);
            this.Name = "Form1";
            this.Text = "Denary to Binary Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDenaryToBinary;
        private System.Windows.Forms.TextBox textDenary;
        private System.Windows.Forms.TextBox textBinary;
        private System.Windows.Forms.Label lblPlaceValues;
        private System.Windows.Forms.Label label1;
    }
}

