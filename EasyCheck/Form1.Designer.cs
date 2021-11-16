namespace EasyCheck
{
    partial class EasyCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyCheck));
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.add1 = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.TextBox();
            this.price1 = new System.Windows.Forms.TextBox();
            this.del1 = new System.Windows.Forms.Button();
            this.down1 = new System.Windows.Forms.Button();
            this.up1 = new System.Windows.Forms.Button();
            this.up2 = new System.Windows.Forms.Button();
            this.down2 = new System.Windows.Forms.Button();
            this.del2 = new System.Windows.Forms.Button();
            this.price2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.up3 = new System.Windows.Forms.Button();
            this.down3 = new System.Windows.Forms.Button();
            this.del3 = new System.Windows.Forms.Button();
            this.price3 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.add3 = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.chUp = new System.Windows.Forms.Button();
            this.chDown = new System.Windows.Forms.Button();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.change1 = new System.Windows.Forms.Button();
            this.change2 = new System.Windows.Forms.Button();
            this.change3 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AllowDrop = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 15;
            this.lb1.Location = new System.Drawing.Point(13, 56);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(242, 334);
            this.lb1.TabIndex = 0;
            this.lb1.Tag = "1";
            this.lb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseClick);
            this.lb1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDoubleClick);
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 16;
            this.lb.Location = new System.Drawing.Point(11, 449);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(549, 164);
            this.lb.TabIndex = 3;
            this.lb.DoubleClick += new System.EventHandler(this.lb_DoubleClick);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnView.Location = new System.Drawing.Point(567, 580);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(184, 33);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Просмотр и печать";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(566, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить все позиции";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(13, 29);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(117, 21);
            this.add1.TabIndex = 6;
            this.add1.Tag = "1";
            this.add1.Text = "Добавить";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add_Click);
            // 
            // name1
            // 
            this.name1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name1.Location = new System.Drawing.Point(13, 7);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(192, 20);
            this.name1.TabIndex = 7;
            this.name1.Tag = "1";
            // 
            // price1
            // 
            this.price1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price1.Location = new System.Drawing.Point(211, 7);
            this.price1.MaxLength = 8;
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(44, 20);
            this.price1.TabIndex = 8;
            this.price1.Tag = "1";
            this.price1.Text = "0";
            this.price1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // del1
            // 
            this.del1.Location = new System.Drawing.Point(12, 396);
            this.del1.Name = "del1";
            this.del1.Size = new System.Drawing.Size(126, 21);
            this.del1.TabIndex = 15;
            this.del1.Tag = "1";
            this.del1.Text = "Удалить выбранный";
            this.del1.UseVisualStyleBackColor = true;
            this.del1.Click += new System.EventHandler(this.del_Click);
            // 
            // down1
            // 
            this.down1.Location = new System.Drawing.Point(144, 396);
            this.down1.Name = "down1";
            this.down1.Size = new System.Drawing.Size(52, 21);
            this.down1.TabIndex = 17;
            this.down1.Tag = "1";
            this.down1.Text = "\\/";
            this.down1.UseVisualStyleBackColor = true;
            this.down1.Click += new System.EventHandler(this.down_Click);
            // 
            // up1
            // 
            this.up1.Location = new System.Drawing.Point(203, 396);
            this.up1.Name = "up1";
            this.up1.Size = new System.Drawing.Size(52, 21);
            this.up1.TabIndex = 18;
            this.up1.Tag = "1";
            this.up1.Text = "/\\";
            this.up1.UseVisualStyleBackColor = true;
            this.up1.Click += new System.EventHandler(this.up_Click);
            // 
            // up2
            // 
            this.up2.Location = new System.Drawing.Point(451, 396);
            this.up2.Name = "up2";
            this.up2.Size = new System.Drawing.Size(52, 21);
            this.up2.TabIndex = 34;
            this.up2.Tag = "2";
            this.up2.Text = "/\\";
            this.up2.UseVisualStyleBackColor = true;
            this.up2.Click += new System.EventHandler(this.up_Click);
            // 
            // down2
            // 
            this.down2.Location = new System.Drawing.Point(392, 396);
            this.down2.Name = "down2";
            this.down2.Size = new System.Drawing.Size(52, 21);
            this.down2.TabIndex = 33;
            this.down2.Tag = "2";
            this.down2.Text = "\\/";
            this.down2.UseVisualStyleBackColor = true;
            this.down2.Click += new System.EventHandler(this.down_Click);
            // 
            // del2
            // 
            this.del2.Location = new System.Drawing.Point(260, 396);
            this.del2.Name = "del2";
            this.del2.Size = new System.Drawing.Size(126, 21);
            this.del2.TabIndex = 32;
            this.del2.Tag = "2";
            this.del2.Text = "Удалить выбранный";
            this.del2.UseVisualStyleBackColor = true;
            this.del2.Click += new System.EventHandler(this.del_Click);
            // 
            // price2
            // 
            this.price2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price2.Location = new System.Drawing.Point(459, 7);
            this.price2.MaxLength = 8;
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(44, 20);
            this.price2.TabIndex = 31;
            this.price2.Tag = "2";
            this.price2.Text = "0";
            this.price2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // name2
            // 
            this.name2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name2.Location = new System.Drawing.Point(261, 7);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(192, 20);
            this.name2.TabIndex = 30;
            this.name2.Tag = "2";
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(261, 29);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(117, 21);
            this.add2.TabIndex = 29;
            this.add2.Tag = "2";
            this.add2.Text = "Добавить";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add_Click);
            // 
            // lb2
            // 
            this.lb2.AllowDrop = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 15;
            this.lb2.Location = new System.Drawing.Point(261, 56);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(242, 334);
            this.lb2.TabIndex = 28;
            this.lb2.Tag = "2";
            this.lb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseClick);
            this.lb2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDoubleClick);
            // 
            // up3
            // 
            this.up3.Location = new System.Drawing.Point(699, 396);
            this.up3.Name = "up3";
            this.up3.Size = new System.Drawing.Size(52, 21);
            this.up3.TabIndex = 41;
            this.up3.Tag = "3";
            this.up3.Text = "/\\";
            this.up3.UseVisualStyleBackColor = true;
            this.up3.Click += new System.EventHandler(this.up_Click);
            // 
            // down3
            // 
            this.down3.Location = new System.Drawing.Point(640, 396);
            this.down3.Name = "down3";
            this.down3.Size = new System.Drawing.Size(52, 21);
            this.down3.TabIndex = 40;
            this.down3.Tag = "3";
            this.down3.Text = "\\/";
            this.down3.UseVisualStyleBackColor = true;
            this.down3.Click += new System.EventHandler(this.down_Click);
            // 
            // del3
            // 
            this.del3.Location = new System.Drawing.Point(508, 396);
            this.del3.Name = "del3";
            this.del3.Size = new System.Drawing.Size(126, 21);
            this.del3.TabIndex = 39;
            this.del3.Tag = "3";
            this.del3.Text = "Удалить выбранный";
            this.del3.UseVisualStyleBackColor = true;
            this.del3.Click += new System.EventHandler(this.del_Click);
            // 
            // price3
            // 
            this.price3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price3.Location = new System.Drawing.Point(707, 7);
            this.price3.MaxLength = 8;
            this.price3.Name = "price3";
            this.price3.Size = new System.Drawing.Size(44, 20);
            this.price3.TabIndex = 38;
            this.price3.Tag = "3";
            this.price3.Text = "0";
            this.price3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // name3
            // 
            this.name3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name3.Location = new System.Drawing.Point(509, 7);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(192, 20);
            this.name3.TabIndex = 37;
            this.name3.Tag = "3";
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(509, 29);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(117, 21);
            this.add3.TabIndex = 36;
            this.add3.Tag = "3";
            this.add3.Text = "Добавить";
            this.add3.UseVisualStyleBackColor = true;
            this.add3.Click += new System.EventHandler(this.add_Click);
            // 
            // lb3
            // 
            this.lb3.AllowDrop = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.FormattingEnabled = true;
            this.lb3.ItemHeight = 15;
            this.lb3.Location = new System.Drawing.Point(509, 56);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(242, 334);
            this.lb3.TabIndex = 35;
            this.lb3.Tag = "3";
            this.lb3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseClick);
            this.lb3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(566, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Итого:";
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.Location = new System.Drawing.Point(626, 555);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(125, 22);
            this.lbTotal.TabIndex = 43;
            this.lbTotal.Text = "0 р.";
            // 
            // chUp
            // 
            this.chUp.Location = new System.Drawing.Point(566, 462);
            this.chUp.Name = "chUp";
            this.chUp.Size = new System.Drawing.Size(37, 33);
            this.chUp.TabIndex = 44;
            this.chUp.Text = "/\\";
            this.chUp.UseVisualStyleBackColor = true;
            this.chUp.Click += new System.EventHandler(this.chUp_Click);
            // 
            // chDown
            // 
            this.chDown.Location = new System.Drawing.Point(566, 519);
            this.chDown.Name = "chDown";
            this.chDown.Size = new System.Drawing.Size(37, 33);
            this.chDown.TabIndex = 45;
            this.chDown.Text = "\\/";
            this.chDown.UseVisualStyleBackColor = true;
            this.chDown.Click += new System.EventHandler(this.chDown_Click);
            // 
            // tbCustomer
            // 
            this.tbCustomer.Location = new System.Drawing.Point(12, 423);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(432, 20);
            this.tbCustomer.TabIndex = 46;
            this.tbCustomer.TextChanged += new System.EventHandler(this.tbCustomer_TextChanged);
            // 
            // change1
            // 
            this.change1.Location = new System.Drawing.Point(136, 29);
            this.change1.Name = "change1";
            this.change1.Size = new System.Drawing.Size(120, 21);
            this.change1.TabIndex = 47;
            this.change1.Tag = "1";
            this.change1.Text = "Изменить";
            this.change1.UseVisualStyleBackColor = true;
            this.change1.Click += new System.EventHandler(this.change_Click);
            // 
            // change2
            // 
            this.change2.Location = new System.Drawing.Point(383, 29);
            this.change2.Name = "change2";
            this.change2.Size = new System.Drawing.Size(120, 21);
            this.change2.TabIndex = 48;
            this.change2.Tag = "2";
            this.change2.Text = "Изменить";
            this.change2.UseVisualStyleBackColor = true;
            this.change2.Click += new System.EventHandler(this.change_Click);
            // 
            // change3
            // 
            this.change3.Location = new System.Drawing.Point(631, 29);
            this.change3.Name = "change3";
            this.change3.Size = new System.Drawing.Size(120, 21);
            this.change3.TabIndex = 49;
            this.change3.Tag = "3";
            this.change3.Text = "Изменить";
            this.change3.UseVisualStyleBackColor = true;
            this.change3.Click += new System.EventHandler(this.change_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(451, 424);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(109, 19);
            this.btnInsert.TabIndex = 50;
            this.btnInsert.Text = "Вставить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // EasyCheck
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(763, 624);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.change3);
            this.Controls.Add(this.change2);
            this.Controls.Add(this.change1);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.chDown);
            this.Controls.Add(this.chUp);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.up3);
            this.Controls.Add(this.down3);
            this.Controls.Add(this.del3);
            this.Controls.Add(this.price3);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.add3);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.up2);
            this.Controls.Add(this.down2);
            this.Controls.Add(this.del2);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.up1);
            this.Controls.Add(this.down1);
            this.Controls.Add(this.del1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EasyCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyCheck";
            this.Load += new System.EventHandler(this.EasyCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.Button del1;
        private System.Windows.Forms.Button down1;
        private System.Windows.Forms.Button up1;
        private System.Windows.Forms.Button up2;
        private System.Windows.Forms.Button down2;
        private System.Windows.Forms.Button del2;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button up3;
        private System.Windows.Forms.Button down3;
        private System.Windows.Forms.Button del3;
        private System.Windows.Forms.TextBox price3;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.Button add3;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button chUp;
        private System.Windows.Forms.Button chDown;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Button change1;
        private System.Windows.Forms.Button change2;
        private System.Windows.Forms.Button change3;
        private System.Windows.Forms.Button btnInsert;
    }
}

