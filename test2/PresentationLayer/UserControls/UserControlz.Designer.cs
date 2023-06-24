namespace PresentationLayer.UserControls
{
    partial class UserControlz
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clear_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.create_btn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.age_lbl = new System.Windows.Forms.Label();
            this.age_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(658, 348);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(60, 33);
            this.clear_btn.TabIndex = 30;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(534, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 29;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(437, 348);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(66, 32);
            this.update_btn.TabIndex = 28;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(314, 71);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 62;
            this.userDataGridView.RowTemplate.Height = 33;
            this.userDataGridView.Size = new System.Drawing.Size(772, 230);
            this.userDataGridView.TabIndex = 27;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(314, 348);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(89, 33);
            this.create_btn.TabIndex = 25;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 23);
            this.textBox4.TabIndex = 24;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 227);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 23);
            this.textBox3.TabIndex = 23;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Location = new System.Drawing.Point(171, 171);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(28, 15);
            this.age_lbl.TabIndex = 22;
            this.age_lbl.Text = "Age";
            this.age_lbl.Click += new System.EventHandler(this.age_lbl_Click);
            // 
            // age_numericUpDown
            // 
            this.age_numericUpDown.Location = new System.Drawing.Point(205, 169);
            this.age_numericUpDown.Name = "age_numericUpDown";
            this.age_numericUpDown.Size = new System.Drawing.Size(68, 23);
            this.age_numericUpDown.TabIndex = 21;
            this.age_numericUpDown.ThousandsSeparator = true;
            this.age_numericUpDown.ValueChanged += new System.EventHandler(this.age_numericUpDown_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Location = new System.Drawing.Point(142, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 23);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 23);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name_txtBox
            // 
            this.name_txtBox.Location = new System.Drawing.Point(142, 105);
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.Size = new System.Drawing.Size(128, 23);
            this.name_txtBox.TabIndex = 18;
            this.name_txtBox.TextChanged += new System.EventHandler(this.name_txtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(85, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Email:";
            // 
            // UserControlz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.age_numericUpDown);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name_txtBox);
            this.Name = "UserControlz";
            this.Size = new System.Drawing.Size(1108, 415);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.NumericUpDown age_numericUpDown;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox name_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
