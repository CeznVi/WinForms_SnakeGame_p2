namespace SnakeGame
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.фаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_StartStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxAppleCount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxAppleByNextLVL = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxLVL = new System.Windows.Forms.ToolStripTextBox();
            this.panelMainWindow = new System.Windows.Forms.Panel();
            this.timer_updSnake = new System.Windows.Forms.Timer(this.components);
            this.timer_updApple = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 649);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(990, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabel1.Text = "Инициализация";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(990, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // фаToolStripMenuItem
            // 
            this.фаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem});
            this.фаToolStripMenuItem.Name = "фаToolStripMenuItem";
            this.фаToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.фаToolStripMenuItem.Text = "Игра";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новаяИграToolStripMenuItem.Text = "Начать игру";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_StartStop,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBoxAppleCount,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripTextBoxAppleByNextLVL,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripTextBoxLVL});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(990, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripButton_StartStop
            // 
            this.toolStripButton_StartStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_StartStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_StartStop.Image")));
            this.toolStripButton_StartStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_StartStop.Name = "toolStripButton_StartStop";
            this.toolStripButton_StartStop.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButton_StartStop.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton_StartStop.Text = "Старт";
            this.toolStripButton_StartStop.Click += new System.EventHandler(this.toolStripButton_StartStop_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton1.Text = "Пауза";
            this.toolStripButton1.ToolTipText = "\r\n";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel1.Text = "Сьедено яблок:";
            // 
            // toolStripTextBoxAppleCount
            // 
            this.toolStripTextBoxAppleCount.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBoxAppleCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxAppleCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxAppleCount.Name = "toolStripTextBoxAppleCount";
            this.toolStripTextBoxAppleCount.ReadOnly = true;
            this.toolStripTextBoxAppleCount.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBoxAppleCount.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(172, 22);
            this.toolStripLabel2.Text = "Яблок до следующего уровня";
            // 
            // toolStripTextBoxAppleByNextLVL
            // 
            this.toolStripTextBoxAppleByNextLVL.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBoxAppleByNextLVL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxAppleByNextLVL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxAppleByNextLVL.Name = "toolStripTextBoxAppleByNextLVL";
            this.toolStripTextBoxAppleByNextLVL.ReadOnly = true;
            this.toolStripTextBoxAppleByNextLVL.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBoxAppleByNextLVL.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel3.Text = "Уровень:";
            // 
            // toolStripTextBoxLVL
            // 
            this.toolStripTextBoxLVL.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBoxLVL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBoxLVL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxLVL.Name = "toolStripTextBoxLVL";
            this.toolStripTextBoxLVL.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBoxLVL.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelMainWindow
            // 
            this.panelMainWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMainWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainWindow.Location = new System.Drawing.Point(0, 49);
            this.panelMainWindow.Name = "panelMainWindow";
            this.panelMainWindow.Size = new System.Drawing.Size(990, 600);
            this.panelMainWindow.TabIndex = 4;
            // 
            // timer_updSnake
            // 
            this.timer_updSnake.Interval = 500;
            this.timer_updSnake.Tick += new System.EventHandler(this.timer_updSnake_Tick);
            // 
            // timer_updApple
            // 
            this.timer_updApple.Interval = 15000;
            this.timer_updApple.Tick += new System.EventHandler(this.timer_updApple_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 671);
            this.Controls.Add(this.panelMainWindow);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змейка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem фаToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel panelMainWindow;
        private System.Windows.Forms.Timer timer_updSnake;
        private System.Windows.Forms.ToolStripButton toolStripButton_StartStop;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAppleCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAppleByNextLVL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxLVL;
        private System.Windows.Forms.Timer timer_updApple;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
    }
}

