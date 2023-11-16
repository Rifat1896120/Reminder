namespace reminder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.save_btn = new System.Windows.Forms.Button();
            this.event_text = new System.Windows.Forms.TextBox();
            this.k = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time_text = new System.Windows.Forms.TextBox();
            this.play_btn = new System.Windows.Forms.Button();
            this.delet_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kjlf = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.BackgroundImage = global::reminder.Properties.Resources.save_close_48px;
            this.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Victor Mono", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(3, 175);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(128, 34);
            this.save_btn.TabIndex = 5;
            this.save_btn.Tag = "svs";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // event_text
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.event_text, 2);
            this.event_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.event_text.Font = new System.Drawing.Font("Victor Mono", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_text.Location = new System.Drawing.Point(3, 90);
            this.event_text.Name = "event_text";
            this.event_text.Size = new System.Drawing.Size(236, 24);
            this.event_text.TabIndex = 2;
            this.event_text.Text = "Something";
            this.event_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.event_text.TextChanged += new System.EventHandler(this.event_text_TextChanged);
            this.event_text.Enter += new System.EventHandler(this.event_focus);
            this.event_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_event);
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.k, 2);
            this.k.Dock = System.Windows.Forms.DockStyle.Fill;
            this.k.Font = new System.Drawing.Font("Victor Mono", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.k.Location = new System.Drawing.Point(3, 0);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(236, 15);
            this.k.TabIndex = 0;
            this.k.Text = "Status:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tableLayoutPanel1.Controls.Add(this.k, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.event_text, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.time_text, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.save_btn, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.play_btn, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.delet_btn, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.close_btn, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.pause_btn, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.status, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.kjlf, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(97)))), ((int)(((byte)(186)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Victor Mono", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Victor Mono", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time";
            // 
            // time_text
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.time_text, 2);
            this.time_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_text.Font = new System.Drawing.Font("Victor Mono", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_text.Location = new System.Drawing.Point(3, 138);
            this.time_text.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.time_text.Name = "time_text";
            this.time_text.Size = new System.Drawing.Size(236, 24);
            this.time_text.TabIndex = 3;
            this.time_text.Tag = "kdsj";
            this.time_text.Text = "10:20pm (Hint)";
            this.time_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time_text.TextChanged += new System.EventHandler(this.time_text_TextChanged);
            this.time_text.Enter += new System.EventHandler(this.text_focus);
            // 
            // play_btn
            // 
            this.play_btn.BackgroundImage = global::reminder.Properties.Resources.play_48px;
            this.play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_btn.FlatAppearance.BorderSize = 0;
            this.play_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_btn.Font = new System.Drawing.Font("Victor Mono", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Location = new System.Drawing.Point(3, 215);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(128, 46);
            this.play_btn.TabIndex = 0;
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // delet_btn
            // 
            this.delet_btn.BackgroundImage = global::reminder.Properties.Resources.delete_node_48px;
            this.delet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delet_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delet_btn.FlatAppearance.BorderSize = 0;
            this.delet_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delet_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delet_btn.Font = new System.Drawing.Font("Victor Mono", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet_btn.Location = new System.Drawing.Point(3, 330);
            this.delet_btn.Name = "delet_btn";
            this.delet_btn.Size = new System.Drawing.Size(128, 38);
            this.delet_btn.TabIndex = 0;
            this.delet_btn.UseVisualStyleBackColor = true;
            this.delet_btn.Click += new System.EventHandler(this.delet_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackgroundImage = global::reminder.Properties.Resources.close_window_48px;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Victor Mono", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(3, 374);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(128, 35);
            this.close_btn.TabIndex = 6;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.AllowDrop = true;
            this.pause_btn.AutoEllipsis = true;
            this.pause_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pause_btn.BackColor = System.Drawing.Color.Transparent;
            this.pause_btn.BackgroundImage = global::reminder.Properties.Resources.pause_48px;
            this.pause_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pause_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pause_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pause_btn.FlatAppearance.BorderSize = 0;
            this.pause_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pause_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause_btn.Font = new System.Drawing.Font("Victor Mono", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_btn.Location = new System.Drawing.Point(0, 412);
            this.pause_btn.Margin = new System.Windows.Forms.Padding(0);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Padding = new System.Windows.Forms.Padding(5);
            this.pause_btn.Size = new System.Drawing.Size(134, 63);
            this.pause_btn.TabIndex = 7;
            this.pause_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pause_btn.UseVisualStyleBackColor = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(245, 3);
            this.listView1.Name = "listView1";
            this.tableLayoutPanel1.SetRowSpan(this.listView1, 14);
            this.listView1.Size = new System.Drawing.Size(286, 469);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 138;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.status, 2);
            this.status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status.Font = new System.Drawing.Font("Victor Mono", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(83)))), ((int)(((byte)(95)))));
            this.status.Location = new System.Drawing.Point(3, 15);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(236, 29);
            this.status.TabIndex = 10;
            this.status.Text = "Stop";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Victor Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(97)))), ((int)(((byte)(186)))));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(134, 172);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 7);
            this.panel1.Size = new System.Drawing.Size(108, 298);
            this.panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Victor Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(239)))));
            this.label9.Location = new System.Drawing.Point(34, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "APP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Victor Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(37, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "ER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Victor Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(239)))));
            this.label8.Location = new System.Drawing.Point(37, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "RE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Victor Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(40, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "ND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Victor Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(38, 83);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(34, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "MI";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 303);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_key);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Victor Mono", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select one for delete";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Reminder app taskber icon";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Reminder app ";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouse_click_notifyicon);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // kjlf
            // 
            this.kjlf.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.kjlf, 2);
            this.kjlf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kjlf.Font = new System.Drawing.Font("Victor Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kjlf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(122)))), ((int)(((byte)(198)))));
            this.kjlf.Location = new System.Drawing.Point(3, 44);
            this.kjlf.Name = "kjlf";
            this.kjlf.Size = new System.Drawing.Size(236, 20);
            this.kjlf.TabIndex = 14;
            this.kjlf.Text = "Time Counter...";
            this.kjlf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 510);
            this.MinimumSize = new System.Drawing.Size(550, 505);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox event_text;
        private System.Windows.Forms.Label k;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button delet_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.TextBox time_text;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label kjlf;
    }
}

