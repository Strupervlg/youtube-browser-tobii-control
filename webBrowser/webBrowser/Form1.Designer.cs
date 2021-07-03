
namespace webBrowser
{
    partial class MainWindow
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
            this.buttonPausePlay = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxVolume = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelVolume = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPlusVolume = new System.Windows.Forms.Button();
            this.buttonMinusVolume = new System.Windows.Forms.Button();
            this.buttonMuteVolume = new System.Windows.Forms.Button();
            this.groupBoxRate = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRate = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPlusRate = new System.Windows.Forms.Button();
            this.buttonMinusRate = new System.Windows.Forms.Button();
            this.buttonKeyboard = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.groupBoxVolume.SuspendLayout();
            this.tableLayoutPanelVolume.SuspendLayout();
            this.groupBoxRate.SuspendLayout();
            this.tableLayoutPanelRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPausePlay
            // 
            this.buttonPausePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPausePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPausePlay.Location = new System.Drawing.Point(3, 3);
            this.buttonPausePlay.Name = "buttonPausePlay";
            this.buttonPausePlay.Size = new System.Drawing.Size(180, 79);
            this.buttonPausePlay.TabIndex = 1;
            this.buttonPausePlay.Text = "Pause/Play";
            this.buttonPausePlay.UseVisualStyleBackColor = true;
            this.buttonPausePlay.Click += new System.EventHandler(this.buttonPausePlay_Click);
            this.buttonPausePlay.MouseEnter += new System.EventHandler(this.buttonPausePlay_MouseEnter);
            this.buttonPausePlay.MouseLeave += new System.EventHandler(this.buttonPausePlay_MouseLeave);
            // 
            // browser
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.browser, 6);
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 85);
            this.browser.Margin = new System.Windows.Forms.Padding(0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1450, 569);
            this.browser.TabIndex = 0;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 6;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.mainTableLayoutPanel.Controls.Add(this.buttonNext, 2, 0);
            this.mainTableLayoutPanel.Controls.Add(this.browser, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.buttonPausePlay, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.buttonBack, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.groupBoxVolume, 3, 0);
            this.mainTableLayoutPanel.Controls.Add(this.groupBoxRate, 4, 0);
            this.mainTableLayoutPanel.Controls.Add(this.buttonKeyboard, 5, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.56637F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 569F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1450, 654);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNext.Location = new System.Drawing.Point(389, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(191, 79);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.MouseEnter += new System.EventHandler(this.buttonNext_MouseEnter);
            this.buttonNext.MouseLeave += new System.EventHandler(this.buttonNext_MouseLeave);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.Location = new System.Drawing.Point(189, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(194, 79);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttonBack_MouseLeave);
            // 
            // groupBoxVolume
            // 
            this.groupBoxVolume.Controls.Add(this.tableLayoutPanelVolume);
            this.groupBoxVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVolume.Location = new System.Drawing.Point(586, 3);
            this.groupBoxVolume.Name = "groupBoxVolume";
            this.groupBoxVolume.Size = new System.Drawing.Size(358, 79);
            this.groupBoxVolume.TabIndex = 3;
            this.groupBoxVolume.TabStop = false;
            this.groupBoxVolume.Text = "Volume";
            // 
            // tableLayoutPanelVolume
            // 
            this.tableLayoutPanelVolume.ColumnCount = 3;
            this.tableLayoutPanelVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanelVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanelVolume.Controls.Add(this.buttonPlusVolume, 1, 0);
            this.tableLayoutPanelVolume.Controls.Add(this.buttonMinusVolume, 0, 0);
            this.tableLayoutPanelVolume.Controls.Add(this.buttonMuteVolume, 2, 0);
            this.tableLayoutPanelVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVolume.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelVolume.Name = "tableLayoutPanelVolume";
            this.tableLayoutPanelVolume.RowCount = 1;
            this.tableLayoutPanelVolume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVolume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelVolume.Size = new System.Drawing.Size(352, 60);
            this.tableLayoutPanelVolume.TabIndex = 0;
            // 
            // buttonPlusVolume
            // 
            this.buttonPlusVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlusVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlusVolume.Location = new System.Drawing.Point(118, 3);
            this.buttonPlusVolume.Name = "buttonPlusVolume";
            this.buttonPlusVolume.Size = new System.Drawing.Size(116, 54);
            this.buttonPlusVolume.TabIndex = 0;
            this.buttonPlusVolume.Text = "Plus";
            this.buttonPlusVolume.UseVisualStyleBackColor = true;
            this.buttonPlusVolume.Click += new System.EventHandler(this.buttonPlusVolume_Click);
            this.buttonPlusVolume.MouseEnter += new System.EventHandler(this.buttonPlusVolume_MouseEnter);
            this.buttonPlusVolume.MouseLeave += new System.EventHandler(this.buttonPlusVolume_MouseLeave);
            // 
            // buttonMinusVolume
            // 
            this.buttonMinusVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinusVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinusVolume.Location = new System.Drawing.Point(3, 3);
            this.buttonMinusVolume.Name = "buttonMinusVolume";
            this.buttonMinusVolume.Size = new System.Drawing.Size(109, 54);
            this.buttonMinusVolume.TabIndex = 1;
            this.buttonMinusVolume.Text = "Minus";
            this.buttonMinusVolume.UseVisualStyleBackColor = true;
            this.buttonMinusVolume.Click += new System.EventHandler(this.buttonMinusVolume_Click);
            this.buttonMinusVolume.MouseEnter += new System.EventHandler(this.buttonMinusVolume_MouseEnter);
            this.buttonMinusVolume.MouseLeave += new System.EventHandler(this.buttonMinusVolume_MouseLeave);
            // 
            // buttonMuteVolume
            // 
            this.buttonMuteVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMuteVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMuteVolume.Location = new System.Drawing.Point(240, 3);
            this.buttonMuteVolume.Name = "buttonMuteVolume";
            this.buttonMuteVolume.Size = new System.Drawing.Size(109, 54);
            this.buttonMuteVolume.TabIndex = 2;
            this.buttonMuteVolume.Text = "Mute";
            this.buttonMuteVolume.UseVisualStyleBackColor = true;
            this.buttonMuteVolume.Click += new System.EventHandler(this.buttonMuteVolume_Click);
            this.buttonMuteVolume.MouseEnter += new System.EventHandler(this.buttonMuteVolume_MouseEnter);
            this.buttonMuteVolume.MouseLeave += new System.EventHandler(this.buttonMuteVolume_MouseLeave);
            // 
            // groupBoxRate
            // 
            this.groupBoxRate.Controls.Add(this.tableLayoutPanelRate);
            this.groupBoxRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRate.Location = new System.Drawing.Point(950, 3);
            this.groupBoxRate.Name = "groupBoxRate";
            this.groupBoxRate.Size = new System.Drawing.Size(303, 79);
            this.groupBoxRate.TabIndex = 4;
            this.groupBoxRate.TabStop = false;
            this.groupBoxRate.Text = "Rate";
            // 
            // tableLayoutPanelRate
            // 
            this.tableLayoutPanelRate.ColumnCount = 2;
            this.tableLayoutPanelRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRate.Controls.Add(this.buttonPlusRate, 1, 0);
            this.tableLayoutPanelRate.Controls.Add(this.buttonMinusRate, 0, 0);
            this.tableLayoutPanelRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRate.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelRate.Name = "tableLayoutPanelRate";
            this.tableLayoutPanelRate.RowCount = 1;
            this.tableLayoutPanelRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelRate.Size = new System.Drawing.Size(297, 60);
            this.tableLayoutPanelRate.TabIndex = 0;
            // 
            // buttonPlusRate
            // 
            this.buttonPlusRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlusRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlusRate.Location = new System.Drawing.Point(151, 3);
            this.buttonPlusRate.Name = "buttonPlusRate";
            this.buttonPlusRate.Size = new System.Drawing.Size(143, 54);
            this.buttonPlusRate.TabIndex = 0;
            this.buttonPlusRate.Text = "Plus";
            this.buttonPlusRate.UseVisualStyleBackColor = true;
            this.buttonPlusRate.Click += new System.EventHandler(this.buttonPlusRate_Click);
            this.buttonPlusRate.MouseEnter += new System.EventHandler(this.buttonPlusRate_MouseEnter);
            this.buttonPlusRate.MouseLeave += new System.EventHandler(this.buttonPlusRate_MouseLeave);
            // 
            // buttonMinusRate
            // 
            this.buttonMinusRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinusRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinusRate.Location = new System.Drawing.Point(3, 3);
            this.buttonMinusRate.Name = "buttonMinusRate";
            this.buttonMinusRate.Size = new System.Drawing.Size(142, 54);
            this.buttonMinusRate.TabIndex = 1;
            this.buttonMinusRate.Text = "Minus";
            this.buttonMinusRate.UseVisualStyleBackColor = true;
            this.buttonMinusRate.Click += new System.EventHandler(this.buttonMinusRate_Click);
            this.buttonMinusRate.MouseEnter += new System.EventHandler(this.buttonMinusRate_MouseEnter);
            this.buttonMinusRate.MouseLeave += new System.EventHandler(this.buttonMinusRate_MouseLeave);
            // 
            // buttonKeyboard
            // 
            this.buttonKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonKeyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKeyboard.Location = new System.Drawing.Point(1259, 3);
            this.buttonKeyboard.Name = "buttonKeyboard";
            this.buttonKeyboard.Size = new System.Drawing.Size(188, 79);
            this.buttonKeyboard.TabIndex = 5;
            this.buttonKeyboard.Text = "Keyboard";
            this.buttonKeyboard.UseVisualStyleBackColor = true;
            this.buttonKeyboard.Click += new System.EventHandler(this.buttonKeyboard_Click);
            this.buttonKeyboard.MouseEnter += new System.EventHandler(this.buttonKeyboard_MouseEnter);
            this.buttonKeyboard.MouseLeave += new System.EventHandler(this.buttonKeyboard_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::webBrowser.Properties.Resources._0;
            this.ClientSize = new System.Drawing.Size(1450, 654);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MainWindow";
            this.Text = "Browser";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.groupBoxVolume.ResumeLayout(false);
            this.tableLayoutPanelVolume.ResumeLayout(false);
            this.groupBoxRate.ResumeLayout(false);
            this.tableLayoutPanelRate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPausePlay;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBoxVolume;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVolume;
        private System.Windows.Forms.Button buttonPlusVolume;
        private System.Windows.Forms.Button buttonMinusVolume;
        private System.Windows.Forms.Button buttonMuteVolume;
        private System.Windows.Forms.GroupBox groupBoxRate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRate;
        private System.Windows.Forms.Button buttonPlusRate;
        private System.Windows.Forms.Button buttonMinusRate;
        private System.Windows.Forms.Button buttonKeyboard;
    }
}

