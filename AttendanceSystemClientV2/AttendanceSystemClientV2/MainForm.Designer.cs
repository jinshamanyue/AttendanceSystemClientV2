namespace AttendanceSystemClientV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1_default = new System.Windows.Forms.Panel();
            this.panel2_down = new System.Windows.Forms.Panel();
            this.mainPageView = new Telerik.WinControls.UI.RadPageView();
            this.downloadDataPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.panel3_fill = new System.Windows.Forms.Panel();
            this.panel3_up = new System.Windows.Forms.Panel();
            this.panel4_down = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5_left = new System.Windows.Forms.Panel();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.panel4_up = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startRollCallPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.dataManagementPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.panel2_up = new System.Windows.Forms.Panel();
            this.metroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c = new Telerik.WinControls.RootRadElement();
            this.panel2_parent = new System.Windows.Forms.Panel();
            this.panel3_parent = new System.Windows.Forms.Panel();
            this.panel1_default.SuspendLayout();
            this.panel2_down.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).BeginInit();
            this.mainPageView.SuspendLayout();
            this.downloadDataPage.SuspendLayout();
            this.panel3_fill.SuspendLayout();
            this.panel3_up.SuspendLayout();
            this.panel4_down.SuspendLayout();
            this.panel5_left.SuspendLayout();
            this.panel4_up.SuspendLayout();
            this.startRollCallPage.SuspendLayout();
            this.dataManagementPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_default
            // 
            this.panel1_default.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1_default.Controls.Add(this.panel2_down);
            this.panel1_default.Controls.Add(this.panel2_up);
            this.panel1_default.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_default.Location = new System.Drawing.Point(0, 0);
            this.panel1_default.Name = "panel1_default";
            this.panel1_default.Size = new System.Drawing.Size(1273, 698);
            this.panel1_default.TabIndex = 0;
            this.panel1_default.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_default_Paint);
            // 
            // panel2_down
            // 
            this.panel2_down.Controls.Add(this.mainPageView);
            this.panel2_down.Controls.Add(this.radStatusStrip1);
            this.panel2_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_down.Location = new System.Drawing.Point(0, 125);
            this.panel2_down.Name = "panel2_down";
            this.panel2_down.Size = new System.Drawing.Size(1271, 571);
            this.panel2_down.TabIndex = 1;
            // 
            // mainPageView
            // 
            this.mainPageView.Controls.Add(this.downloadDataPage);
            this.mainPageView.Controls.Add(this.startRollCallPage);
            this.mainPageView.Controls.Add(this.dataManagementPage);
            this.mainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageView.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold);
            this.mainPageView.Location = new System.Drawing.Point(0, 0);
            this.mainPageView.Name = "mainPageView";
            this.mainPageView.SelectedPage = this.dataManagementPage;
            this.mainPageView.Size = new System.Drawing.Size(1271, 547);
            this.mainPageView.TabIndex = 0;
            this.mainPageView.Text = "radPageView1";
            this.mainPageView.ThemeName = "TelerikMetro";
            this.mainPageView.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            // 
            // downloadDataPage
            // 
            this.downloadDataPage.Controls.Add(this.panel3_fill);
            this.downloadDataPage.ItemSize = new System.Drawing.SizeF(175F, 63F);
            this.downloadDataPage.Location = new System.Drawing.Point(205, 4);
            this.downloadDataPage.Name = "downloadDataPage";
            this.downloadDataPage.Size = new System.Drawing.Size(1062, 539);
            this.downloadDataPage.Text = "课程下载";
            // 
            // panel3_fill
            // 
            this.panel3_fill.Controls.Add(this.panel3_up);
            this.panel3_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_fill.Location = new System.Drawing.Point(0, 0);
            this.panel3_fill.Name = "panel3_fill";
            this.panel3_fill.Size = new System.Drawing.Size(1062, 539);
            this.panel3_fill.TabIndex = 1;
            // 
            // panel3_up
            // 
            this.panel3_up.Controls.Add(this.panel4_down);
            this.panel3_up.Controls.Add(this.panel4_up);
            this.panel3_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3_up.Location = new System.Drawing.Point(0, 0);
            this.panel3_up.Name = "panel3_up";
            this.panel3_up.Size = new System.Drawing.Size(1062, 460);
            this.panel3_up.TabIndex = 1;
            // 
            // panel4_down
            // 
            this.panel4_down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4_down.Controls.Add(this.panel1);
            this.panel4_down.Controls.Add(this.panel5_left);
            this.panel4_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4_down.Location = new System.Drawing.Point(0, 77);
            this.panel4_down.Name = "panel4_down";
            this.panel4_down.Size = new System.Drawing.Size(1062, 383);
            this.panel4_down.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 381);
            this.panel1.TabIndex = 2;
            // 
            // panel5_left
            // 
            this.panel5_left.Controls.Add(this.coursesListBox);
            this.panel5_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5_left.Location = new System.Drawing.Point(0, 0);
            this.panel5_left.Name = "panel5_left";
            this.panel5_left.Size = new System.Drawing.Size(600, 381);
            this.panel5_left.TabIndex = 1;
            // 
            // coursesListBox
            // 
            this.coursesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursesListBox.Font = new System.Drawing.Font("微软雅黑", 21.75F);
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 38;
            this.coursesListBox.Items.AddRange(new object[] {
            "2014级软件1，2班计算机组成原理"});
            this.coursesListBox.Location = new System.Drawing.Point(0, 0);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(600, 381);
            this.coursesListBox.TabIndex = 0;
            // 
            // panel4_up
            // 
            this.panel4_up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4_up.Controls.Add(this.label1);
            this.panel4_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4_up.Location = new System.Drawing.Point(0, 0);
            this.panel4_up.Name = "panel4_up";
            this.panel4_up.Size = new System.Drawing.Size(1062, 77);
            this.panel4_up.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "已经下载的课程";
            // 
            // startRollCallPage
            // 
            this.startRollCallPage.Controls.Add(this.panel2_parent);
            this.startRollCallPage.ItemSize = new System.Drawing.SizeF(175F, 63F);
            this.startRollCallPage.Location = new System.Drawing.Point(205, 4);
            this.startRollCallPage.Name = "startRollCallPage";
            this.startRollCallPage.Size = new System.Drawing.Size(1062, 539);
            this.startRollCallPage.Text = "课堂考勤";
            // 
            // dataManagementPage
            // 
            this.dataManagementPage.Controls.Add(this.panel3_parent);
            this.dataManagementPage.ItemSize = new System.Drawing.SizeF(175F, 63F);
            this.dataManagementPage.Location = new System.Drawing.Point(205, 4);
            this.dataManagementPage.Name = "dataManagementPage";
            this.dataManagementPage.Size = new System.Drawing.Size(1062, 539);
            this.dataManagementPage.Text = "数据管理";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 547);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1271, 24);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // panel2_up
            // 
            this.panel2_up.BackgroundImage = global::AttendanceSystemClientV2.Properties.Resources.title;
            this.panel2_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_up.Location = new System.Drawing.Point(0, 0);
            this.panel2_up.Name = "panel2_up";
            this.panel2_up.Size = new System.Drawing.Size(1271, 125);
            this.panel2_up.TabIndex = 0;
            // 
            // object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c
            // 
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c.Name = "object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c";
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c.StretchHorizontally = true;
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c.StretchVertically = true;
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // panel2_parent
            // 
            this.panel2_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_parent.Location = new System.Drawing.Point(0, 0);
            this.panel2_parent.Name = "panel2_parent";
            this.panel2_parent.Size = new System.Drawing.Size(1062, 539);
            this.panel2_parent.TabIndex = 0;
            // 
            // panel3_parent
            // 
            this.panel3_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_parent.Location = new System.Drawing.Point(0, 0);
            this.panel3_parent.Name = "panel3_parent";
            this.panel3_parent.Size = new System.Drawing.Size(1062, 539);
            this.panel3_parent.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 698);
            this.Controls.Add(this.panel1_default);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Relativity Client Application";
            this.ThemeName = "TelerikMetro";
            this.panel1_default.ResumeLayout(false);
            this.panel2_down.ResumeLayout(false);
            this.panel2_down.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).EndInit();
            this.mainPageView.ResumeLayout(false);
            this.downloadDataPage.ResumeLayout(false);
            this.panel3_fill.ResumeLayout(false);
            this.panel3_up.ResumeLayout(false);
            this.panel4_down.ResumeLayout(false);
            this.panel5_left.ResumeLayout(false);
            this.panel4_up.ResumeLayout(false);
            this.panel4_up.PerformLayout();
            this.startRollCallPage.ResumeLayout(false);
            this.dataManagementPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_default;
        private System.Windows.Forms.Panel panel2_down;
        private System.Windows.Forms.Panel panel2_up;
        private Telerik.WinControls.Themes.TelerikMetroTheme metroTheme1;
        private Telerik.WinControls.UI.RadPageView mainPageView;
        private Telerik.WinControls.UI.RadPageViewPage downloadDataPage;
        private Telerik.WinControls.UI.RadPageViewPage startRollCallPage;
        private Telerik.WinControls.UI.RadPageViewPage dataManagementPage;
        private Telerik.WinControls.RootRadElement object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c;
        private System.Windows.Forms.Panel panel3_fill;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.Panel panel3_up;
        private System.Windows.Forms.Panel panel4_down;
        private System.Windows.Forms.Panel panel4_up;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2_parent;
        private System.Windows.Forms.Panel panel3_parent;

    }
}

