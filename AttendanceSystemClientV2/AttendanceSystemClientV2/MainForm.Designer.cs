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
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.metroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c = new Telerik.WinControls.RootRadElement();
            this.downloadDataPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.panel3_fill = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3_up = new System.Windows.Forms.Panel();
            this.panel4_down = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5_left = new System.Windows.Forms.Panel();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.panel4_up = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startRollCallPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.panel2_parent = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataManagementPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.panel3_parent = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2_up = new System.Windows.Forms.Panel();
            this.panel1_default.SuspendLayout();
            this.panel2_down.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPageView)).BeginInit();
            this.mainPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.downloadDataPage.SuspendLayout();
            this.panel3_fill.SuspendLayout();
            this.panel3_up.SuspendLayout();
            this.panel4_down.SuspendLayout();
            this.panel5_left.SuspendLayout();
            this.panel4_up.SuspendLayout();
            this.startRollCallPage.SuspendLayout();
            this.panel2_parent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.dataManagementPage.SuspendLayout();
            this.panel3_parent.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.mainPageView.DefaultPage = this.downloadDataPage;
            this.mainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPageView.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainPageView.Location = new System.Drawing.Point(0, 0);
            this.mainPageView.Name = "mainPageView";
            this.mainPageView.SelectedPage = this.downloadDataPage;
            this.mainPageView.Size = new System.Drawing.Size(1271, 547);
            this.mainPageView.TabIndex = 0;
            this.mainPageView.Text = "radPageView1";
            this.mainPageView.ThemeName = "TelerikMetro";
            this.mainPageView.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.mainPageView.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.mainPageView.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.None;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.mainPageView.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Left;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.mainPageView.GetChildAt(0))).ItemSpacing = 10;
            ((Telerik.WinControls.UI.RadPageViewBackstageElement)(this.mainPageView.GetChildAt(0))).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.mainPageView.GetChildAt(0).GetChildAt(0))).MinSize = new System.Drawing.Size(0, 0);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 547);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1271, 24);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c
            // 
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c.Name = "object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c";
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c.StretchHorizontally = true;
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c.StretchVertically = true;
            this.object_9d9a2a38_7052_4f9c_b5cb_084d4e0b9c3c.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // downloadDataPage
            // 
            this.downloadDataPage.Controls.Add(this.panel3_fill);
            this.downloadDataPage.Image = global::AttendanceSystemClientV2.Properties.Resources.list;
            this.downloadDataPage.ItemSize = new System.Drawing.SizeF(103F, 98F);
            this.downloadDataPage.Location = new System.Drawing.Point(133, 4);
            this.downloadDataPage.Name = "downloadDataPage";
            this.downloadDataPage.Size = new System.Drawing.Size(1134, 539);
            this.downloadDataPage.Text = " ";
            // 
            // panel3_fill
            // 
            this.panel3_fill.Controls.Add(this.button1);
            this.panel3_fill.Controls.Add(this.panel3_up);
            this.panel3_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_fill.Location = new System.Drawing.Point(0, 0);
            this.panel3_fill.Name = "panel3_fill";
            this.panel3_fill.Size = new System.Drawing.Size(1134, 539);
            this.panel3_fill.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "获取数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3_up
            // 
            this.panel3_up.Controls.Add(this.panel4_down);
            this.panel3_up.Controls.Add(this.panel4_up);
            this.panel3_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3_up.Location = new System.Drawing.Point(0, 0);
            this.panel3_up.Name = "panel3_up";
            this.panel3_up.Size = new System.Drawing.Size(1134, 460);
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
            this.panel4_down.Size = new System.Drawing.Size(1134, 383);
            this.panel4_down.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 381);
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
            this.panel4_up.Size = new System.Drawing.Size(1134, 77);
            this.panel4_up.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "已经下载的课程";
            // 
            // startRollCallPage
            // 
            this.startRollCallPage.Controls.Add(this.panel2_parent);
            this.startRollCallPage.Image = global::AttendanceSystemClientV2.Properties.Resources.rollcall;
            this.startRollCallPage.ItemSize = new System.Drawing.SizeF(103F, 94F);
            this.startRollCallPage.Location = new System.Drawing.Point(135, 4);
            this.startRollCallPage.Name = "startRollCallPage";
            this.startRollCallPage.Size = new System.Drawing.Size(1132, 539);
            this.startRollCallPage.Text = "    ";
            // 
            // panel2_parent
            // 
            this.panel2_parent.Controls.Add(this.panel3);
            this.panel2_parent.Controls.Add(this.panel2);
            this.panel2_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_parent.Location = new System.Drawing.Point(0, 0);
            this.panel2_parent.Name = "panel2_parent";
            this.panel2_parent.Size = new System.Drawing.Size(1132, 539);
            this.panel2_parent.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(564, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 539);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(568, 439);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 439);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 100);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 539);
            this.panel2.TabIndex = 0;
            // 
            // dataManagementPage
            // 
            this.dataManagementPage.Controls.Add(this.panel3_parent);
            this.dataManagementPage.Image = global::AttendanceSystemClientV2.Properties.Resources.upload;
            this.dataManagementPage.ItemSize = new System.Drawing.SizeF(103F, 86F);
            this.dataManagementPage.Location = new System.Drawing.Point(135, 4);
            this.dataManagementPage.Name = "dataManagementPage";
            this.dataManagementPage.Size = new System.Drawing.Size(1132, 539);
            this.dataManagementPage.Text = " ";
            // 
            // panel3_parent
            // 
            this.panel3_parent.Controls.Add(this.panel7);
            this.panel3_parent.Controls.Add(this.panel6);
            this.panel3_parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_parent.Location = new System.Drawing.Point(0, 0);
            this.panel3_parent.Name = "panel3_parent";
            this.panel3_parent.Size = new System.Drawing.Size(1132, 539);
            this.panel3_parent.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(532, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(600, 539);
            this.panel7.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(600, 460);
            this.panel9.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 460);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(600, 79);
            this.panel8.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(532, 539);
            this.panel6.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.downloadDataPage.ResumeLayout(false);
            this.panel3_fill.ResumeLayout(false);
            this.panel3_up.ResumeLayout(false);
            this.panel4_down.ResumeLayout(false);
            this.panel5_left.ResumeLayout(false);
            this.panel4_up.ResumeLayout(false);
            this.panel4_up.PerformLayout();
            this.startRollCallPage.ResumeLayout(false);
            this.panel2_parent.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.dataManagementPage.ResumeLayout(false);
            this.panel3_parent.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;

    }
}

