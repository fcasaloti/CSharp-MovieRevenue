namespace CSIS1175_003F2019FernandoCasalotiSilvaAS4
{
    partial class MainForm
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
            this.sortNameBtn = new System.Windows.Forms.Button();
            this.sortRevenueBtn = new System.Windows.Forms.Button();
            this.resultsLb = new System.Windows.Forms.ListBox();
            this.searchGb = new System.Windows.Forms.GroupBox();
            this.revenueRbtn = new System.Windows.Forms.RadioButton();
            this.nameRbtn = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortNameBtn
            // 
            this.sortNameBtn.Location = new System.Drawing.Point(39, 44);
            this.sortNameBtn.Name = "sortNameBtn";
            this.sortNameBtn.Size = new System.Drawing.Size(114, 73);
            this.sortNameBtn.TabIndex = 0;
            this.sortNameBtn.Text = "Sort by Name";
            this.sortNameBtn.UseVisualStyleBackColor = true;
            this.sortNameBtn.Click += new System.EventHandler(this.sortNameBtn_Click);
            // 
            // sortRevenueBtn
            // 
            this.sortRevenueBtn.Location = new System.Drawing.Point(39, 136);
            this.sortRevenueBtn.Name = "sortRevenueBtn";
            this.sortRevenueBtn.Size = new System.Drawing.Size(114, 72);
            this.sortRevenueBtn.TabIndex = 1;
            this.sortRevenueBtn.Text = "Sort by Revenue";
            this.sortRevenueBtn.UseVisualStyleBackColor = true;
            this.sortRevenueBtn.Click += new System.EventHandler(this.sortRevenueBtn_Click);
            // 
            // resultsLb
            // 
            this.resultsLb.FormattingEnabled = true;
            this.resultsLb.ItemHeight = 20;
            this.resultsLb.Location = new System.Drawing.Point(172, 44);
            this.resultsLb.Name = "resultsLb";
            this.resultsLb.Size = new System.Drawing.Size(541, 164);
            this.resultsLb.TabIndex = 2;
            // 
            // searchGb
            // 
            this.searchGb.Controls.Add(this.revenueRbtn);
            this.searchGb.Controls.Add(this.nameRbtn);
            this.searchGb.Controls.Add(this.searchBtn);
            this.searchGb.Controls.Add(this.searchTb);
            this.searchGb.Location = new System.Drawing.Point(172, 231);
            this.searchGb.Name = "searchGb";
            this.searchGb.Size = new System.Drawing.Size(541, 143);
            this.searchGb.TabIndex = 3;
            this.searchGb.TabStop = false;
            this.searchGb.Text = "Search";
            // 
            // revenueRbtn
            // 
            this.revenueRbtn.AutoSize = true;
            this.revenueRbtn.Location = new System.Drawing.Point(171, 97);
            this.revenueRbtn.Name = "revenueRbtn";
            this.revenueRbtn.Size = new System.Drawing.Size(120, 24);
            this.revenueRbtn.TabIndex = 3;
            this.revenueRbtn.TabStop = true;
            this.revenueRbtn.Text = "By Revenue";
            this.revenueRbtn.UseVisualStyleBackColor = true;
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Location = new System.Drawing.Point(23, 97);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(124, 24);
            this.nameRbtn.TabIndex = 2;
            this.nameRbtn.TabStop = true;
            this.nameRbtn.Text = "Within Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(327, 34);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(129, 40);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(23, 34);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(268, 26);
            this.searchTb.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.searchGb);
            this.Controls.Add(this.resultsLb);
            this.Controls.Add(this.sortRevenueBtn);
            this.Controls.Add(this.sortNameBtn);
            this.Name = "MainForm";
            this.Text = "Fernando Movie Revenue";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.searchGb.ResumeLayout(false);
            this.searchGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sortNameBtn;
        private System.Windows.Forms.Button sortRevenueBtn;
        private System.Windows.Forms.ListBox resultsLb;
        private System.Windows.Forms.GroupBox searchGb;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.RadioButton revenueRbtn;
        private System.Windows.Forms.RadioButton nameRbtn;
        private System.Windows.Forms.Button searchBtn;
    }
}

