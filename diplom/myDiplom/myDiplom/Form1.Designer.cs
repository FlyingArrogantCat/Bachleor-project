namespace myDiplom
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainIdeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDistributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inforamnionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainIdeaToolStripMenuItem,
            this.inforamnionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainIdeaToolStripMenuItem
            // 
            this.mainIdeaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDistributionToolStripMenuItem,
            this.showDataToolStripMenuItem,
            this.addNewCountryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainIdeaToolStripMenuItem.Name = "mainIdeaToolStripMenuItem";
            this.mainIdeaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.mainIdeaToolStripMenuItem.Text = "main idea";
            // 
            // addNewCountryToolStripMenuItem
            // 
            this.addNewCountryToolStripMenuItem.Name = "addNewCountryToolStripMenuItem";
            this.addNewCountryToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addNewCountryToolStripMenuItem.Text = "add new country";
            this.addNewCountryToolStripMenuItem.Click += new System.EventHandler(this.addNewCountryToolStripMenuItem_Click);
            // 
            // createNewDistributionToolStripMenuItem
            // 
            this.createNewDistributionToolStripMenuItem.Name = "createNewDistributionToolStripMenuItem";
            this.createNewDistributionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.createNewDistributionToolStripMenuItem.Text = "create new distribution";
            this.createNewDistributionToolStripMenuItem.Click += new System.EventHandler(this.createNewDistributionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // inforamnionToolStripMenuItem
            // 
            this.inforamnionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAuthorToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.inforamnionToolStripMenuItem.Name = "inforamnionToolStripMenuItem";
            this.inforamnionToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.inforamnionToolStripMenuItem.Text = "information";
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutAuthorToolStripMenuItem.Text = "about author";
            this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutProgramToolStripMenuItem.Text = "about program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.showDataToolStripMenuItem.Text = "show data";
            this.showDataToolStripMenuItem.Click += new System.EventHandler(this.showDataToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 474);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MainModel ver .0.0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainIdeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDistributionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inforamnionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
    }
}

