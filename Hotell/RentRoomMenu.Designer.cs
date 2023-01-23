namespace Hotell
{
    partial class RentRoomMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentRoomMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdNud = new System.Windows.Forms.NumericUpDown();
            this.customerIdNud = new System.Windows.Forms.NumericUpDown();
            this.roomtypeComBox = new System.Windows.Forms.ComboBox();
            this.rentBtn = new System.Windows.Forms.Button();
            this.numericDayNud = new System.Windows.Forms.NumericUpDown();
            this.dayNud = new System.Windows.Forms.Label();
            this.RentLb = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userIdNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDayNud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Type";
            // 
            // userIdNud
            // 
            this.userIdNud.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.userIdNud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userIdNud.Location = new System.Drawing.Point(121, 39);
            this.userIdNud.Name = "userIdNud";
            this.userIdNud.Size = new System.Drawing.Size(120, 24);
            this.userIdNud.TabIndex = 3;
            this.userIdNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // customerIdNud
            // 
            this.customerIdNud.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.customerIdNud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerIdNud.Location = new System.Drawing.Point(121, 75);
            this.customerIdNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customerIdNud.Name = "customerIdNud";
            this.customerIdNud.Size = new System.Drawing.Size(120, 24);
            this.customerIdNud.TabIndex = 4;
            this.customerIdNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // roomtypeComBox
            // 
            this.roomtypeComBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.roomtypeComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.roomtypeComBox.FormattingEnabled = true;
            this.roomtypeComBox.Location = new System.Drawing.Point(120, 114);
            this.roomtypeComBox.Name = "roomtypeComBox";
            this.roomtypeComBox.Size = new System.Drawing.Size(121, 26);
            this.roomtypeComBox.TabIndex = 5;
            // 
            // rentBtn
            // 
            this.rentBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rentBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentBtn.Location = new System.Drawing.Point(121, 198);
            this.rentBtn.Name = "rentBtn";
            this.rentBtn.Size = new System.Drawing.Size(120, 57);
            this.rentBtn.TabIndex = 0;
            this.rentBtn.Text = "RENT";
            this.rentBtn.UseVisualStyleBackColor = false;
            this.rentBtn.Click += new System.EventHandler(this.rentBtn_Click);
            // 
            // numericDayNud
            // 
            this.numericDayNud.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericDayNud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericDayNud.Location = new System.Drawing.Point(121, 147);
            this.numericDayNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDayNud.Name = "numericDayNud";
            this.numericDayNud.Size = new System.Drawing.Size(120, 24);
            this.numericDayNud.TabIndex = 7;
            this.numericDayNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dayNud
            // 
            this.dayNud.AutoSize = true;
            this.dayNud.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dayNud.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNud.Location = new System.Drawing.Point(12, 149);
            this.dayNud.Name = "dayNud";
            this.dayNud.Size = new System.Drawing.Size(38, 18);
            this.dayNud.TabIndex = 6;
            this.dayNud.Text = "Day";
            // 
            // RentLb
            // 
            this.RentLb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RentLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RentLb.FormattingEnabled = true;
            this.RentLb.ItemHeight = 18;
            this.RentLb.Location = new System.Drawing.Point(279, 39);
            this.RentLb.Name = "RentLb";
            this.RentLb.Size = new System.Drawing.Size(226, 184);
            this.RentLb.TabIndex = 10;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.backBtn.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(647, 319);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 48);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // RentRoomMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 379);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.RentLb);
            this.Controls.Add(this.numericDayNud);
            this.Controls.Add(this.dayNud);
            this.Controls.Add(this.roomtypeComBox);
            this.Controls.Add(this.customerIdNud);
            this.Controls.Add(this.userIdNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentBtn);
            this.Name = "RentRoomMenu";
            this.Text = "RentRoomMenu";
            this.Load += new System.EventHandler(this.RentRoomMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userIdNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDayNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown userIdNud;
        private System.Windows.Forms.NumericUpDown customerIdNud;
        private System.Windows.Forms.ComboBox roomtypeComBox;
        private System.Windows.Forms.Button rentBtn;
        private System.Windows.Forms.NumericUpDown numericDayNud;
        private System.Windows.Forms.Label dayNud;
        private System.Windows.Forms.ListBox RentLb;
        private System.Windows.Forms.Button backBtn;
    }
}