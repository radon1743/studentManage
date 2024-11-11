namespace studentManage
{
    partial class manageScore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_desciption = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_studentlist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_maintable = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_maintable)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(144, 43);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(284, 21);
            this.comboBox_course.TabIndex = 40;
            // 
            // textBox_score
            // 
            this.textBox_score.Location = new System.Drawing.Point(144, 70);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(91, 20);
            this.textBox_score.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Score :";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 8);
            this.panel3.TabIndex = 37;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.YellowGreen;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.SystemColors.Window;
            this.button_update.Location = new System.Drawing.Point(612, 159);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(97, 32);
            this.button_update.TabIndex = 34;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_desciption
            // 
            this.textBox_desciption.Location = new System.Drawing.Point(144, 102);
            this.textBox_desciption.Multiline = true;
            this.textBox_desciption.Name = "textBox_desciption";
            this.textBox_desciption.Size = new System.Drawing.Size(359, 62);
            this.textBox_desciption.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button_studentlist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 33);
            this.panel1.TabIndex = 42;
            // 
            // button_studentlist
            // 
            this.button_studentlist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_studentlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_studentlist.Font = new System.Drawing.Font("Arial", 14F);
            this.button_studentlist.Location = new System.Drawing.Point(40, 2);
            this.button_studentlist.Name = "button_studentlist";
            this.button_studentlist.Size = new System.Drawing.Size(128, 30);
            this.button_studentlist.TabIndex = 2;
            this.button_studentlist.Text = "Student List";
            this.button_studentlist.UseVisualStyleBackColor = false;
            this.button_studentlist.Click += new System.EventHandler(this.button_studentlist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(26, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Select Course :";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(144, 15);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(155, 20);
            this.textBox_id.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.comboBox_course);
            this.panel2.Controls.Add(this.textBox_score);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.Controls.Add(this.textBox_desciption);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 203);
            this.panel2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Student Id : ";
            // 
            // dataGridView_maintable
            // 
            this.dataGridView_maintable.AllowUserToAddRows = false;
            this.dataGridView_maintable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_maintable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_maintable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_maintable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_maintable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_maintable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_maintable.Location = new System.Drawing.Point(9, 38);
            this.dataGridView_maintable.Name = "dataGridView_maintable";
            this.dataGridView_maintable.RowHeadersWidth = 30;
            this.dataGridView_maintable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_maintable.Size = new System.Drawing.Size(701, 193);
            this.dataGridView_maintable.TabIndex = 28;
            this.dataGridView_maintable.Click += new System.EventHandler(this.dataGridView_maintable_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.Window;
            this.button_delete.Location = new System.Drawing.Point(511, 159);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(97, 32);
            this.button_delete.TabIndex = 41;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Cursor = System.Windows.Forms.Cursors.No;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(511, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 42;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // manageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 437);
            this.Controls.Add(this.dataGridView_maintable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "manageScore";
            this.Text = "manageScore";
            this.Load += new System.EventHandler(this.manageScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_maintable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_desciption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_maintable;
        private System.Windows.Forms.Button button_studentlist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_delete;
    }
}