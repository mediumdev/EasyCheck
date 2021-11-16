namespace EasyCheck
{
    partial class frmCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheck));
            this.btnPrint = new System.Windows.Forms.Button();
            this.sr_bottom = new System.Windows.Forms.PictureBox();
            this.sr_center = new System.Windows.Forms.PictureBox();
            this.sr_top = new System.Windows.Forms.PictureBox();
            this.SR = new System.Windows.Forms.PictureBox();
            this.lbDefaultPrinter = new System.Windows.Forms.Label();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.lbPrinter = new System.Windows.Forms.Label();
            this.lbCopy = new System.Windows.Forms.Label();
            this.tbCopy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sr_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sr_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sr_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.Location = new System.Drawing.Point(681, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 30);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // sr_bottom
            // 
            this.sr_bottom.Image = global::EasyCheck.Properties.Resources.sr_bottom;
            this.sr_bottom.Location = new System.Drawing.Point(818, 124);
            this.sr_bottom.Name = "sr_bottom";
            this.sr_bottom.Size = new System.Drawing.Size(50, 50);
            this.sr_bottom.TabIndex = 23;
            this.sr_bottom.TabStop = false;
            this.sr_bottom.Visible = false;
            // 
            // sr_center
            // 
            this.sr_center.Image = global::EasyCheck.Properties.Resources.sr_center;
            this.sr_center.Location = new System.Drawing.Point(818, 68);
            this.sr_center.Name = "sr_center";
            this.sr_center.Size = new System.Drawing.Size(50, 50);
            this.sr_center.TabIndex = 22;
            this.sr_center.TabStop = false;
            this.sr_center.Visible = false;
            // 
            // sr_top
            // 
            this.sr_top.Image = global::EasyCheck.Properties.Resources.sr_top;
            this.sr_top.Location = new System.Drawing.Point(818, 12);
            this.sr_top.Name = "sr_top";
            this.sr_top.Size = new System.Drawing.Size(50, 50);
            this.sr_top.TabIndex = 21;
            this.sr_top.TabStop = false;
            this.sr_top.Visible = false;
            // 
            // SR
            // 
            this.SR.ErrorImage = global::EasyCheck.Properties.Resources.sr_top;
            this.SR.Image = global::EasyCheck.Properties.Resources.sr;
            this.SR.Location = new System.Drawing.Point(11, 12);
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(800, 376);
            this.SR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SR.TabIndex = 20;
            this.SR.TabStop = false;
            // 
            // lbDefaultPrinter
            // 
            this.lbDefaultPrinter.Location = new System.Drawing.Point(12, 392);
            this.lbDefaultPrinter.Name = "lbDefaultPrinter";
            this.lbDefaultPrinter.Size = new System.Drawing.Size(192, 17);
            this.lbDefaultPrinter.TabIndex = 30;
            this.lbDefaultPrinter.Text = "Принтер по умолчанию:";
            // 
            // btnPrinter
            // 
            this.btnPrinter.Location = new System.Drawing.Point(212, 393);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(141, 31);
            this.btnPrinter.TabIndex = 29;
            this.btnPrinter.Text = "Обновить принтер";
            this.btnPrinter.UseVisualStyleBackColor = true;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // lbPrinter
            // 
            this.lbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrinter.Location = new System.Drawing.Point(14, 407);
            this.lbPrinter.Name = "lbPrinter";
            this.lbPrinter.Size = new System.Drawing.Size(192, 18);
            this.lbPrinter.TabIndex = 28;
            // 
            // lbCopy
            // 
            this.lbCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCopy.Location = new System.Drawing.Point(546, 398);
            this.lbCopy.Name = "lbCopy";
            this.lbCopy.Size = new System.Drawing.Size(98, 23);
            this.lbCopy.TabIndex = 31;
            this.lbCopy.Text = "Число копий:";
            // 
            // tbCopy
            // 
            this.tbCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCopy.Location = new System.Drawing.Point(641, 397);
            this.tbCopy.MaxLength = 2;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(26, 23);
            this.tbCopy.TabIndex = 32;
            this.tbCopy.Text = "1";
            this.tbCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCopy.TextChanged += new System.EventHandler(this.tbCopy_TextChanged);
            this.tbCopy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCopy_KeyPress);
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 435);
            this.Controls.Add(this.tbCopy);
            this.Controls.Add(this.lbCopy);
            this.Controls.Add(this.lbDefaultPrinter);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.lbPrinter);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.sr_bottom);
            this.Controls.Add(this.sr_center);
            this.Controls.Add(this.sr_top);
            this.Controls.Add(this.SR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCheck";
            this.Text = "Товарный чек";
            this.Load += new System.EventHandler(this.frmCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sr_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sr_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sr_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox sr_bottom;
        private System.Windows.Forms.PictureBox sr_center;
        private System.Windows.Forms.PictureBox sr_top;
        private System.Windows.Forms.PictureBox SR;
        private System.Windows.Forms.Label lbDefaultPrinter;
        private System.Windows.Forms.Button btnPrinter;
        private System.Windows.Forms.Label lbPrinter;
        private System.Windows.Forms.Label lbCopy;
        private System.Windows.Forms.TextBox tbCopy;
    }
}