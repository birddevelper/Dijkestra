namespace MaxCut
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
            this.btn_max_cut = new System.Windows.Forms.Button();
            this.lst_Path = new System.Windows.Forms.ListBox();
            this.lst_B = new System.Windows.Forms.ListBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_shortest_path = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_set_weight_a = new System.Windows.Forms.Label();
            this.lbl_sum_weight_b = new System.Windows.Forms.Label();
            this.chk_replace = new System.Windows.Forms.CheckBox();
            this.chk_boost = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmb_src = new System.Windows.Forms.ComboBox();
            this.cmb_dest = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_random = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_max_cut
            // 
            this.btn_max_cut.Location = new System.Drawing.Point(12, 12);
            this.btn_max_cut.Name = "btn_max_cut";
            this.btn_max_cut.Size = new System.Drawing.Size(117, 23);
            this.btn_max_cut.TabIndex = 0;
            this.btn_max_cut.Text = "Find Shortest Path";
            this.btn_max_cut.UseVisualStyleBackColor = true;
            this.btn_max_cut.Click += new System.EventHandler(this.btn_max_cut_Click);
            // 
            // lst_Path
            // 
            this.lst_Path.FormattingEnabled = true;
            this.lst_Path.Location = new System.Drawing.Point(8, 204);
            this.lst_Path.Name = "lst_Path";
            this.lst_Path.Size = new System.Drawing.Size(120, 147);
            this.lst_Path.TabIndex = 1;
            // 
            // lst_B
            // 
            this.lst_B.FormattingEnabled = true;
            this.lst_B.Location = new System.Drawing.Point(9, 399);
            this.lst_B.Name = "lst_B";
            this.lst_B.Size = new System.Drawing.Size(120, 30);
            this.lst_B.TabIndex = 2;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(135, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination :";
            // 
            // lbl_shortest_path
            // 
            this.lbl_shortest_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_shortest_path.AutoSize = true;
            this.lbl_shortest_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shortest_path.ForeColor = System.Drawing.Color.Red;
            this.lbl_shortest_path.Location = new System.Drawing.Point(382, 17);
            this.lbl_shortest_path.Name = "lbl_shortest_path";
            this.lbl_shortest_path.Size = new System.Drawing.Size(0, 13);
            this.lbl_shortest_path.TabIndex = 6;
            this.lbl_shortest_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(135, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 483);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Programmed by : Mostafa Shaeri";
            // 
            // lbl_set_weight_a
            // 
            this.lbl_set_weight_a.AutoSize = true;
            this.lbl_set_weight_a.ForeColor = System.Drawing.Color.Blue;
            this.lbl_set_weight_a.Location = new System.Drawing.Point(210, 56);
            this.lbl_set_weight_a.Name = "lbl_set_weight_a";
            this.lbl_set_weight_a.Size = new System.Drawing.Size(0, 13);
            this.lbl_set_weight_a.TabIndex = 9;
            // 
            // lbl_sum_weight_b
            // 
            this.lbl_sum_weight_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sum_weight_b.AutoSize = true;
            this.lbl_sum_weight_b.ForeColor = System.Drawing.Color.Blue;
            this.lbl_sum_weight_b.Location = new System.Drawing.Point(971, 56);
            this.lbl_sum_weight_b.Name = "lbl_sum_weight_b";
            this.lbl_sum_weight_b.Size = new System.Drawing.Size(0, 13);
            this.lbl_sum_weight_b.TabIndex = 10;
            // 
            // chk_replace
            // 
            this.chk_replace.AutoSize = true;
            this.chk_replace.Checked = true;
            this.chk_replace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_replace.Location = new System.Drawing.Point(15, 37);
            this.chk_replace.Name = "chk_replace";
            this.chk_replace.Size = new System.Drawing.Size(100, 17);
            this.chk_replace.TabIndex = 11;
            this.chk_replace.Text = "Replace Nodes";
            this.chk_replace.UseVisualStyleBackColor = true;
            // 
            // chk_boost
            // 
            this.chk_boost.AutoSize = true;
            this.chk_boost.Location = new System.Drawing.Point(121, 37);
            this.chk_boost.Name = "chk_boost";
            this.chk_boost.Size = new System.Drawing.Size(86, 17);
            this.chk_boost.TabIndex = 12;
            this.chk_boost.Text = "Boost Result";
            this.chk_boost.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 497);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // cmb_src
            // 
            this.cmb_src.FormattingEnabled = true;
            this.cmb_src.Location = new System.Drawing.Point(8, 72);
            this.cmb_src.Name = "cmb_src";
            this.cmb_src.Size = new System.Drawing.Size(121, 21);
            this.cmb_src.TabIndex = 14;
            // 
            // cmb_dest
            // 
            this.cmb_dest.FormattingEnabled = true;
            this.cmb_dest.Location = new System.Drawing.Point(8, 138);
            this.cmb_dest.Name = "cmb_dest";
            this.cmb_dest.Size = new System.Drawing.Size(121, 21);
            this.cmb_dest.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Path :";
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(216, 12);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(122, 23);
            this.btn_random.TabIndex = 17;
            this.btn_random.Text = "Random Network";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_max_cut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 580);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_dest);
            this.Controls.Add(this.cmb_src);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chk_boost);
            this.Controls.Add(this.chk_replace);
            this.Controls.Add(this.lbl_sum_weight_b);
            this.Controls.Add(this.lbl_set_weight_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_shortest_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lst_B);
            this.Controls.Add(this.lst_Path);
            this.Controls.Add(this.btn_max_cut);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maximum Cut Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_max_cut;
        private System.Windows.Forms.ListBox lst_Path;
        private System.Windows.Forms.ListBox lst_B;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_shortest_path;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_set_weight_a;
        private System.Windows.Forms.Label lbl_sum_weight_b;
        private System.Windows.Forms.CheckBox chk_replace;
        private System.Windows.Forms.CheckBox chk_boost;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmb_src;
        private System.Windows.Forms.ComboBox cmb_dest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_random;
    }
}

