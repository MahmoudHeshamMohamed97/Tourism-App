namespace Tourism_App
{
    partial class EmployeeForm
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
            this.tab_Reservations = new System.Windows.Forms.TabControl();
            this.tab_Journeys = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_budget = new System.Windows.Forms.Label();
            this.txt_budget = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_Date = new System.Windows.Forms.ComboBox();
            this.cmb_location = new System.Windows.Forms.ComboBox();
            this.cmb_numOfDays = new System.Windows.Forms.ComboBox();
            this.cmb_travelWay = new System.Windows.Forms.ComboBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.data_Journeys = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_Reservations.SuspendLayout();
            this.tab_Journeys.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Journeys)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Reservations
            // 
            this.tab_Reservations.Controls.Add(this.tab_Journeys);
            this.tab_Reservations.Controls.Add(this.tabPage2);
            this.tab_Reservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Reservations.Location = new System.Drawing.Point(0, 0);
            this.tab_Reservations.Name = "tab_Reservations";
            this.tab_Reservations.SelectedIndex = 0;
            this.tab_Reservations.Size = new System.Drawing.Size(800, 450);
            this.tab_Reservations.TabIndex = 0;
            // 
            // tab_Journeys
            // 
            this.tab_Journeys.Controls.Add(this.groupBox1);
            this.tab_Journeys.Controls.Add(this.btn_book);
            this.tab_Journeys.Controls.Add(this.data_Journeys);
            this.tab_Journeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Journeys.Location = new System.Drawing.Point(4, 34);
            this.tab_Journeys.Name = "tab_Journeys";
            this.tab_Journeys.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Journeys.Size = new System.Drawing.Size(792, 412);
            this.tab_Journeys.TabIndex = 0;
            this.tab_Journeys.Text = "Journeys";
            this.tab_Journeys.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_budget);
            this.groupBox1.Controls.Add(this.txt_budget);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmb_Date);
            this.groupBox1.Controls.Add(this.cmb_location);
            this.groupBox1.Controls.Add(this.cmb_numOfDays);
            this.groupBox1.Controls.Add(this.cmb_travelWay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filteration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Budget";
            // 
            // lbl_budget
            // 
            this.lbl_budget.AutoSize = true;
            this.lbl_budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_budget.ForeColor = System.Drawing.Color.Red;
            this.lbl_budget.Location = new System.Drawing.Point(70, 109);
            this.lbl_budget.Name = "lbl_budget";
            this.lbl_budget.Size = new System.Drawing.Size(317, 29);
            this.lbl_budget.TabIndex = 14;
            this.lbl_budget.Text = "Budget Should be number";
            this.lbl_budget.Visible = false;
            // 
            // txt_budget
            // 
            this.txt_budget.Location = new System.Drawing.Point(178, 61);
            this.txt_budget.Name = "txt_budget";
            this.txt_budget.Size = new System.Drawing.Size(138, 27);
            this.txt_budget.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(544, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_Date
            // 
            this.cmb_Date.FormattingEnabled = true;
            this.cmb_Date.Location = new System.Drawing.Point(645, 61);
            this.cmb_Date.Name = "cmb_Date";
            this.cmb_Date.Size = new System.Drawing.Size(137, 28);
            this.cmb_Date.TabIndex = 11;
            // 
            // cmb_location
            // 
            this.cmb_location.FormattingEnabled = true;
            this.cmb_location.Location = new System.Drawing.Point(488, 61);
            this.cmb_location.Name = "cmb_location";
            this.cmb_location.Size = new System.Drawing.Size(137, 28);
            this.cmb_location.TabIndex = 10;
            // 
            // cmb_numOfDays
            // 
            this.cmb_numOfDays.FormattingEnabled = true;
            this.cmb_numOfDays.Location = new System.Drawing.Point(334, 61);
            this.cmb_numOfDays.Name = "cmb_numOfDays";
            this.cmb_numOfDays.Size = new System.Drawing.Size(137, 28);
            this.cmb_numOfDays.TabIndex = 9;
            // 
            // cmb_travelWay
            // 
            this.cmb_travelWay.FormattingEnabled = true;
            this.cmb_travelWay.Location = new System.Drawing.Point(6, 61);
            this.cmb_travelWay.Name = "cmb_travelWay";
            this.cmb_travelWay.Size = new System.Drawing.Size(137, 28);
            this.cmb_travelWay.TabIndex = 7;
            // 
            // btn_book
            // 
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.Location = new System.Drawing.Point(323, 153);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(101, 48);
            this.btn_book.TabIndex = 1;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Visible = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // data_Journeys
            // 
            this.data_Journeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Journeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Journeys.Location = new System.Drawing.Point(3, 207);
            this.data_Journeys.Name = "data_Journeys";
            this.data_Journeys.RowHeadersWidth = 51;
            this.data_Journeys.RowTemplate.Height = 24;
            this.data_Journeys.Size = new System.Drawing.Size(786, 202);
            this.data_Journeys.TabIndex = 0;
            this.data_Journeys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Journeys_CellContentClick);
            this.data_Journeys.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_Journeys_RowHeaderMouseClick);
            this.data_Journeys.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_Journeys_RowHeaderMouseDoubleClick);
            this.data_Journeys.MouseEnter += new System.EventHandler(this.data_Journeys_MouseEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservations";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Transportation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "#Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_Reservations);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tab_Reservations.ResumeLayout(false);
            this.tab_Journeys.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Journeys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Reservations;
        private System.Windows.Forms.TabPage tab_Journeys;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView data_Journeys;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Date;
        private System.Windows.Forms.ComboBox cmb_location;
        private System.Windows.Forms.ComboBox cmb_numOfDays;
        private System.Windows.Forms.ComboBox cmb_travelWay;
        private System.Windows.Forms.TextBox txt_budget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_budget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}