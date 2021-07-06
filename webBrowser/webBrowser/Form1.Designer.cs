
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
            this.buttonClickMouse = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.groupBoxVolume.SuspendLayout();
            this.tableLayoutPanelVolume.SuspendLayout();
            this.groupBoxRate.SuspendLayout();
            this.tableLayoutPanelRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPausePlay
            // 
            this.buttonPausePlay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPausePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPausePlay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonPausePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPausePlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPausePlay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPausePlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPausePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPausePlay.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPausePlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPausePlay.Location = new System.Drawing.Point(6, 6);
            this.buttonPausePlay.Name = "buttonPausePlay";
            this.buttonPausePlay.Size = new System.Drawing.Size(176, 61);
            this.buttonPausePlay.TabIndex = 1;
            this.buttonPausePlay.Text = "PLAY | PAUSE";
            this.buttonPausePlay.UseVisualStyleBackColor = false;
            this.buttonPausePlay.Click += new System.EventHandler(this.buttonPausePlay_Click);
            this.buttonPausePlay.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonPausePlay.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // browser
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.browser, 7);
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(3, 73);
            this.browser.Margin = new System.Windows.Forms.Padding(0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScrollBarsEnabled = false;
            this.browser.Size = new System.Drawing.Size(1437, 593);
            this.browser.TabIndex = 0;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browser_DocumentCompleted);
            this.browser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.browser_PreviewKeyDown);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.mainTableLayoutPanel.ColumnCount = 7;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.87641F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.8764F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.8764F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.51926F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0955F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.8764F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.87963F));
            this.mainTableLayoutPanel.Controls.Add(this.buttonNext, 2, 0);
            this.mainTableLayoutPanel.Controls.Add(this.browser, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.buttonPausePlay, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.buttonBack, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.groupBoxVolume, 3, 0);
            this.mainTableLayoutPanel.Controls.Add(this.groupBoxRate, 4, 0);
            this.mainTableLayoutPanel.Controls.Add(this.buttonKeyboard, 5, 0);
            this.mainTableLayoutPanel.Controls.Add(this.buttonClickMouse, 6, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20656F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.79344F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1443, 669);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNext.Location = new System.Drawing.Point(376, 6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(176, 61);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "NEXT";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonNext.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.Location = new System.Drawing.Point(191, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(176, 61);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonBack.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // groupBoxVolume
            // 
            this.groupBoxVolume.BackColor = System.Drawing.Color.White;
            this.groupBoxVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxVolume.Controls.Add(this.tableLayoutPanelVolume);
            this.groupBoxVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxVolume.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxVolume.ForeColor = System.Drawing.Color.Black;
            this.groupBoxVolume.Location = new System.Drawing.Point(561, 6);
            this.groupBoxVolume.Name = "groupBoxVolume";
            this.groupBoxVolume.Size = new System.Drawing.Size(299, 61);
            this.groupBoxVolume.TabIndex = 3;
            this.groupBoxVolume.TabStop = false;
            this.groupBoxVolume.Text = "VOLUME";
            // 
            // tableLayoutPanelVolume
            // 
            this.tableLayoutPanelVolume.ColumnCount = 3;
            this.tableLayoutPanelVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelVolume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelVolume.Controls.Add(this.buttonPlusVolume, 1, 0);
            this.tableLayoutPanelVolume.Controls.Add(this.buttonMinusVolume, 0, 0);
            this.tableLayoutPanelVolume.Controls.Add(this.buttonMuteVolume, 2, 0);
            this.tableLayoutPanelVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVolume.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelVolume.Name = "tableLayoutPanelVolume";
            this.tableLayoutPanelVolume.RowCount = 1;
            this.tableLayoutPanelVolume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVolume.Size = new System.Drawing.Size(293, 42);
            this.tableLayoutPanelVolume.TabIndex = 0;
            // 
            // buttonPlusVolume
            // 
            this.buttonPlusVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlusVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlusVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlusVolume.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlusVolume.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlusVolume.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlusVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusVolume.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPlusVolume.Location = new System.Drawing.Point(100, 3);
            this.buttonPlusVolume.Name = "buttonPlusVolume";
            this.buttonPlusVolume.Size = new System.Drawing.Size(91, 36);
            this.buttonPlusVolume.TabIndex = 0;
            this.buttonPlusVolume.Text = "PLUS";
            this.buttonPlusVolume.UseVisualStyleBackColor = false;
            this.buttonPlusVolume.Click += new System.EventHandler(this.buttonPlusVolume_Click);
            this.buttonPlusVolume.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonPlusVolume.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // buttonMinusVolume
            // 
            this.buttonMinusVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinusVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinusVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinusVolume.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinusVolume.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinusVolume.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinusVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinusVolume.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinusVolume.Location = new System.Drawing.Point(3, 3);
            this.buttonMinusVolume.Name = "buttonMinusVolume";
            this.buttonMinusVolume.Size = new System.Drawing.Size(91, 36);
            this.buttonMinusVolume.TabIndex = 1;
            this.buttonMinusVolume.Text = "MINUS";
            this.buttonMinusVolume.UseVisualStyleBackColor = false;
            this.buttonMinusVolume.Click += new System.EventHandler(this.buttonMinusVolume_Click);
            this.buttonMinusVolume.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonMinusVolume.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // buttonMuteVolume
            // 
            this.buttonMuteVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMuteVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMuteVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMuteVolume.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMuteVolume.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMuteVolume.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMuteVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMuteVolume.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMuteVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMuteVolume.Location = new System.Drawing.Point(197, 3);
            this.buttonMuteVolume.Name = "buttonMuteVolume";
            this.buttonMuteVolume.Size = new System.Drawing.Size(93, 36);
            this.buttonMuteVolume.TabIndex = 2;
            this.buttonMuteVolume.Text = "MUTE";
            this.buttonMuteVolume.UseVisualStyleBackColor = false;
            this.buttonMuteVolume.Click += new System.EventHandler(this.buttonMuteVolume_Click);
            this.buttonMuteVolume.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonMuteVolume.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // groupBoxRate
            // 
            this.groupBoxRate.BackColor = System.Drawing.Color.White;
            this.groupBoxRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxRate.Controls.Add(this.tableLayoutPanelRate);
            this.groupBoxRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxRate.Font = new System.Drawing.Font("Bahnschrift Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxRate.Location = new System.Drawing.Point(869, 6);
            this.groupBoxRate.Name = "groupBoxRate";
            this.groupBoxRate.Size = new System.Drawing.Size(222, 61);
            this.groupBoxRate.TabIndex = 4;
            this.groupBoxRate.TabStop = false;
            this.groupBoxRate.Text = "RATE";
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
            this.tableLayoutPanelRate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelRate.Size = new System.Drawing.Size(216, 42);
            this.tableLayoutPanelRate.TabIndex = 0;
            // 
            // buttonPlusRate
            // 
            this.buttonPlusRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlusRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlusRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlusRate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlusRate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlusRate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlusRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusRate.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPlusRate.Location = new System.Drawing.Point(111, 3);
            this.buttonPlusRate.Name = "buttonPlusRate";
            this.buttonPlusRate.Size = new System.Drawing.Size(102, 36);
            this.buttonPlusRate.TabIndex = 0;
            this.buttonPlusRate.Text = "PLUS";
            this.buttonPlusRate.UseVisualStyleBackColor = false;
            this.buttonPlusRate.Click += new System.EventHandler(this.buttonPlusRate_Click);
            this.buttonPlusRate.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonPlusRate.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // buttonMinusRate
            // 
            this.buttonMinusRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinusRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinusRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinusRate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinusRate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinusRate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinusRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinusRate.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinusRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinusRate.Location = new System.Drawing.Point(3, 3);
            this.buttonMinusRate.Name = "buttonMinusRate";
            this.buttonMinusRate.Size = new System.Drawing.Size(102, 36);
            this.buttonMinusRate.TabIndex = 1;
            this.buttonMinusRate.Text = "MINUS";
            this.buttonMinusRate.UseVisualStyleBackColor = false;
            this.buttonMinusRate.Click += new System.EventHandler(this.buttonMinusRate_Click);
            this.buttonMinusRate.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonMinusRate.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // buttonKeyboard
            // 
            this.buttonKeyboard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKeyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKeyboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonKeyboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonKeyboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeyboard.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKeyboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonKeyboard.Location = new System.Drawing.Point(1100, 6);
            this.buttonKeyboard.Name = "buttonKeyboard";
            this.buttonKeyboard.Size = new System.Drawing.Size(176, 61);
            this.buttonKeyboard.TabIndex = 5;
            this.buttonKeyboard.Text = "KEYBOARD";
            this.buttonKeyboard.UseVisualStyleBackColor = false;
            this.buttonKeyboard.Click += new System.EventHandler(this.buttonKeyboard_Click);
            this.buttonKeyboard.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonKeyboard.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // buttonClickMouse
            // 
            this.buttonClickMouse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClickMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClickMouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClickMouse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClickMouse.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClickMouse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClickMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClickMouse.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClickMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClickMouse.Location = new System.Drawing.Point(1285, 6);
            this.buttonClickMouse.Name = "buttonClickMouse";
            this.buttonClickMouse.Size = new System.Drawing.Size(152, 61);
            this.buttonClickMouse.TabIndex = 6;
            this.buttonClickMouse.Text = "CLICK";
            this.buttonClickMouse.UseVisualStyleBackColor = false;
            this.buttonClickMouse.Click += new System.EventHandler(this.buttonClickMouse_Click);
            this.buttonClickMouse.MouseEnter += new System.EventHandler(this.buttons_MouseEnter);
            this.buttonClickMouse.MouseLeave += new System.EventHandler(this.buttons_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::webBrowser.Properties.Resources._0;
            this.ClientSize = new System.Drawing.Size(1443, 669);
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
        private System.Windows.Forms.Button buttonClickMouse;
    }
}

