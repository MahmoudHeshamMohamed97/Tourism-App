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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.data_Journeys = new System.Windows.Forms.DataGridView();
            this.btn_book = new System.Windows.Forms.Button();
            this.tab_Reservations.SuspendLayout();
            this.tab_Journeys.SuspendLayout();
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
            // data_Journeys
            // 
            this.data_Journeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Journeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_Journeys.Location = new System.Drawing.Point(3, 165);
            this.data_Journeys.Name = "data_Journeys";
            this.data_Journeys.RowHeadersWidth = 51;
            this.data_Journeys.RowTemplate.Height = 24;
            this.data_Journeys.Size = new System.Drawing.Size(786, 244);
            this.data_Journeys.TabIndex = 0;
            this.data_Journeys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Journeys_CellContentClick);
            this.data_Journeys.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_Journeys_RowHeaderMouseClick);
            this.data_Journeys.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_Journeys_RowHeaderMouseDoubleClick);
            this.data_Journeys.MouseEnter += new System.EventHandler(this.data_Journeys_MouseEnter);
            // 
            // btn_book
            // 
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.Location = new System.Drawing.Point(322, 111);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(101, 48);
            this.btn_book.TabIndex = 1;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Visible = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_Reservations);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tab_Reservations.ResumeLayout(false);
            this.tab_Journeys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Journeys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Reservations;
        private System.Windows.Forms.TabPage tab_Journeys;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView data_Journeys;
        private System.Windows.Forms.Button btn_book;
    }
}