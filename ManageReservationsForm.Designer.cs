namespace CsharpHotelDatabase
{
    partial class ManageReservationsForm
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
            this.manageClients = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noButton = new System.Windows.Forms.RadioButton();
            this.yesButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.removeReservationButton = new System.Windows.Forms.Button();
            this.editReservationButton = new System.Windows.Forms.Button();
            this.addReservationButton = new System.Windows.Forms.Button();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateInBox = new System.Windows.Forms.DateTimePicker();
            this.dateOutBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReservId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageClients
            // 
            this.manageClients.AutoSize = true;
            this.manageClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClients.Location = new System.Drawing.Point(226, 12);
            this.manageClients.Name = "manageClients";
            this.manageClients.Size = new System.Drawing.Size(354, 39);
            this.manageClients.TabIndex = 0;
            this.manageClients.Text = "Manage Reservations";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.manageClients);
            this.panel1.Location = new System.Drawing.Point(-3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 63);
            this.panel1.TabIndex = 34;
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(96, 30);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(47, 24);
            this.noButton.TabIndex = 35;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.Checked = true;
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(20, 30);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(55, 24);
            this.yesButton.TabIndex = 33;
            this.yesButton.TabStop = true;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(410, 336);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFieldsButton.Location = new System.Drawing.Point(133, 402);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(106, 30);
            this.clearFieldsButton.TabIndex = 44;
            this.clearFieldsButton.Text = "Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // removeReservationButton
            // 
            this.removeReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeReservationButton.Location = new System.Drawing.Point(269, 366);
            this.removeReservationButton.Name = "removeReservationButton";
            this.removeReservationButton.Size = new System.Drawing.Size(85, 30);
            this.removeReservationButton.TabIndex = 43;
            this.removeReservationButton.Text = "Remove";
            this.removeReservationButton.UseVisualStyleBackColor = true;
            this.removeReservationButton.Click += new System.EventHandler(this.removeReservationButton_Click);
            // 
            // editReservationButton
            // 
            this.editReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editReservationButton.Location = new System.Drawing.Point(178, 366);
            this.editReservationButton.Name = "editReservationButton";
            this.editReservationButton.Size = new System.Drawing.Size(85, 30);
            this.editReservationButton.TabIndex = 42;
            this.editReservationButton.Text = "Edit";
            this.editReservationButton.UseVisualStyleBackColor = true;
            this.editReservationButton.Click += new System.EventHandler(this.editReservationButton_Click);
            // 
            // addReservationButton
            // 
            this.addReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReservationButton.Location = new System.Drawing.Point(18, 366);
            this.addReservationButton.Name = "addReservationButton";
            this.addReservationButton.Size = new System.Drawing.Size(147, 30);
            this.addReservationButton.TabIndex = 41;
            this.addReservationButton.Text = "Add Reservation";
            this.addReservationButton.UseVisualStyleBackColor = true;
            this.addReservationButton.Click += new System.EventHandler(this.addReservationButton_Click);
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientId.Location = new System.Drawing.Point(164, 143);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(99, 29);
            this.textBoxClientId.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Client ID:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(164, 188);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(182, 32);
            this.comboBoxRoomType.TabIndex = 46;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.AutoSize = true;
            this.roomTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeLabel.Location = new System.Drawing.Point(37, 190);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(128, 25);
            this.roomTypeLabel.TabIndex = 38;
            this.roomTypeLabel.Text = "Room Type:";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(164, 238);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(182, 32);
            this.comboBoxRoomNumber.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Room Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date In:";
            // 
            // dateInBox
            // 
            this.dateInBox.CustomFormat = "";
            this.dateInBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInBox.Location = new System.Drawing.Point(164, 286);
            this.dateInBox.Name = "dateInBox";
            this.dateInBox.Size = new System.Drawing.Size(200, 20);
            this.dateInBox.TabIndex = 52;
            // 
            // dateOutBox
            // 
            this.dateOutBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOutBox.Location = new System.Drawing.Point(164, 320);
            this.dateOutBox.Name = "dateOutBox";
            this.dateOutBox.Size = new System.Drawing.Size(200, 20);
            this.dateOutBox.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Date Out:";
            // 
            // textBoxReservId
            // 
            this.textBoxReservId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReservId.Location = new System.Drawing.Point(164, 96);
            this.textBoxReservId.Name = "textBoxReservId";
            this.textBoxReservId.ReadOnly = true;
            this.textBoxReservId.Size = new System.Drawing.Size(99, 29);
            this.textBoxReservId.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "Reserv ID:";
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxReservId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOutBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateInBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRoomNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.roomTypeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.removeReservationButton);
            this.Controls.Add(this.editReservationButton);
            this.Controls.Add(this.addReservationButton);
            this.Name = "ManageReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReservationsForm";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label manageClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton noButton;
        private System.Windows.Forms.RadioButton yesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.Button removeReservationButton;
        private System.Windows.Forms.Button editReservationButton;
        private System.Windows.Forms.Button addReservationButton;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label roomTypeLabel;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateInBox;
        private System.Windows.Forms.DateTimePicker dateOutBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReservId;
        private System.Windows.Forms.Label label5;
    }
}