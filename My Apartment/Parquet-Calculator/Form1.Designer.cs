namespace Parquet_Calculator
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
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.Worm = new System.Windows.Forms.NumericUpDown();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelWorm = new System.Windows.Forms.Label();
            this.labelLameli = new System.Windows.Forms.Label();
            this.labelKvadratura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm)).BeginInit();
            this.SuspendLayout();
            // 
            // Length
            // 
            this.Length.DecimalPlaces = 2;
            this.Length.Location = new System.Drawing.Point(92, 66);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(120, 22);
            this.Length.TabIndex = 0;
            this.Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Length.ValueChanged += new System.EventHandler(this.Length_ValueChanged);
            // 
            // Width
            // 
            this.Width.DecimalPlaces = 2;
            this.Width.Location = new System.Drawing.Point(251, 66);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(120, 22);
            this.Width.TabIndex = 1;
            this.Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Width.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Worm
            // 
            this.Worm.Location = new System.Drawing.Point(414, 66);
            this.Worm.Name = "Worm";
            this.Worm.Size = new System.Drawing.Size(120, 22);
            this.Worm.TabIndex = 2;
            this.Worm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Worm.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(98, 33);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(114, 20);
            this.labelLength.TabIndex = 3;
            this.labelLength.Text = "Дължина [m]";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.Location = new System.Drawing.Point(260, 33);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(102, 20);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Ширина [m]";
            // 
            // labelWorm
            // 
            this.labelWorm.AutoSize = true;
            this.labelWorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorm.Location = new System.Drawing.Point(433, 33);
            this.labelWorm.Name = "labelWorm";
            this.labelWorm.Size = new System.Drawing.Size(85, 20);
            this.labelWorm.TabIndex = 5;
            this.labelWorm.Text = "Фира [%]";
            // 
            // labelLameli
            // 
            this.labelLameli.BackColor = System.Drawing.Color.PaleGreen;
            this.labelLameli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLameli.Location = new System.Drawing.Point(377, 152);
            this.labelLameli.Name = "labelLameli";
            this.labelLameli.Size = new System.Drawing.Size(177, 65);
            this.labelLameli.TabIndex = 6;
            this.labelLameli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKvadratura
            // 
            this.labelKvadratura.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelKvadratura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKvadratura.Location = new System.Drawing.Point(73, 152);
            this.labelKvadratura.Name = "labelKvadratura";
            this.labelKvadratura.Size = new System.Drawing.Size(180, 65);
            this.labelKvadratura.TabIndex = 7;
            this.labelKvadratura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Квадратура на помещението";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(362, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Квадратура за паркет ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKvadratura);
            this.Controls.Add(this.labelLameli);
            this.Controls.Add(this.labelWorm);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.Worm);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Length);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Паркетен калкулатор";
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Worm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Length;
        private System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.NumericUpDown Worm;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelWorm;
        private System.Windows.Forms.Label labelLameli;
        private System.Windows.Forms.Label labelKvadratura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

