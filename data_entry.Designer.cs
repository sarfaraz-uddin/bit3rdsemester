namespace Bit3rdSemester
{
    partial class data_entry
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
            this.student_list = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_calc = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.PictureBox();
            this.photos = new System.Windows.Forms.Button();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.student_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // student_list
            // 
            this.student_list.AllowUserToAddRows = false;
            this.student_list.AllowUserToDeleteRows = false;
            this.student_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.STDID,
            this.naam,
            this.Address,
            this.Filepath,
            this.action});
            this.student_list.Location = new System.Drawing.Point(317, 30);
            this.student_list.Name = "student_list";
            this.student_list.ReadOnly = true;
            this.student_list.RowTemplate.Height = 24;
            this.student_list.Size = new System.Drawing.Size(804, 486);
            this.student_list.TabIndex = 6;
            this.student_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student_list_CellClick);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(37, 58);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(249, 30);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(37, 134);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(249, 30);
            this.textBox_address.TabIndex = 1;
            // 
            // name_box
            // 
            this.name_box.AutoSize = true;
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(32, 30);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(65, 25);
            this.name_box.TabIndex = 5;
            this.name_box.Text = "name";
            // 
            // address_box
            // 
            this.address_box.AutoSize = true;
            this.address_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_box.Location = new System.Drawing.Point(32, 106);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(89, 25);
            this.address_box.TabIndex = 4;
            this.address_box.Text = "address";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(208, 334);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(87, 50);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(173, 390);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(122, 50);
            this.button_remove.TabIndex = 3;
            this.button_remove.Text = "remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.Button_remove_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(10, 390);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(122, 50);
            this.button_update.TabIndex = 7;
            this.button_update.Text = "update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.update_click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(10, 446);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 50);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.clear_click);
            // 
            // button_calc
            // 
            this.button_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calc.Location = new System.Drawing.Point(148, 446);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(147, 50);
            this.button_calc.TabIndex = 9;
            this.button_calc.Text = "calculator";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.open_calc);
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(37, 187);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(249, 99);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 10;
            this.photo.TabStop = false;
            // 
            // photos
            // 
            this.photos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photos.Location = new System.Drawing.Point(37, 292);
            this.photos.Name = "photos";
            this.photos.Size = new System.Drawing.Size(165, 58);
            this.photos.TabIndex = 11;
            this.photos.Text = "select photo";
            this.photos.UseVisualStyleBackColor = true;
            this.photos.Click += new System.EventHandler(this.sel_photo);
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 70;
            // 
            // STDID
            // 
            this.STDID.HeaderText = "ID";
            this.STDID.Name = "STDID";
            this.STDID.ReadOnly = true;
            this.STDID.Visible = false;
            // 
            // naam
            // 
            this.naam.HeaderText = "Name";
            this.naam.Name = "naam";
            this.naam.ReadOnly = true;
            this.naam.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // Filepath
            // 
            this.Filepath.HeaderText = "Filepath";
            this.Filepath.Name = "Filepath";
            this.Filepath.ReadOnly = true;
            this.Filepath.Width = 200;
            // 
            // action
            // 
            this.action.HeaderText = "action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Width = 150;
            // 
            // data_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 547);
            this.Controls.Add(this.photos);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.student_list);
            this.Name = "data_entry";
            this.Text = "data_entry";
            this.Load += new System.EventHandler(this.Data_entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView student_list;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label name_box;
        private System.Windows.Forms.Label address_box;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button photos;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
    }
}