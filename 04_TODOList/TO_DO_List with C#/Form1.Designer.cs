namespace TO_DO_List_with_C_
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
            this.lvNewTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvCompletedTasks = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.etertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvNewTasks
            // 
            this.lvNewTasks.BackColor = System.Drawing.Color.White;
            this.lvNewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvNewTasks.CheckBoxes = true;
            this.lvNewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9});
            this.lvNewTasks.ContextMenuStrip = this.contextMenuStrip2;
            this.lvNewTasks.FullRowSelect = true;
            this.lvNewTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvNewTasks.HideSelection = false;
            this.lvNewTasks.Location = new System.Drawing.Point(291, 61);
            this.lvNewTasks.MultiSelect = false;
            this.lvNewTasks.Name = "lvNewTasks";
            this.lvNewTasks.Size = new System.Drawing.Size(936, 260);
            this.lvNewTasks.TabIndex = 0;
            this.lvNewTasks.UseCompatibleStateImageBehavior = false;
            this.lvNewTasks.View = System.Windows.Forms.View.Details;
            this.lvNewTasks.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvNewTasks_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "task";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "date";
            this.columnHeader2.Width = 189;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Time";
            this.columnHeader8.Width = 152;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Priority";
            this.columnHeader9.Width = 150;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.updateToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(206, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 24);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 24);
            this.toolStripMenuItem2.Text = "Mark as completed";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // lvCompletedTasks
            // 
            this.lvCompletedTasks.BackColor = System.Drawing.Color.White;
            this.lvCompletedTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.lvCompletedTasks.ContextMenuStrip = this.contextMenuStrip1;
            this.lvCompletedTasks.FullRowSelect = true;
            this.lvCompletedTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCompletedTasks.HideSelection = false;
            this.lvCompletedTasks.Location = new System.Drawing.Point(291, 373);
            this.lvCompletedTasks.MultiSelect = false;
            this.lvCompletedTasks.Name = "lvCompletedTasks";
            this.lvCompletedTasks.Size = new System.Drawing.Size(936, 260);
            this.lvCompletedTasks.TabIndex = 1;
            this.lvCompletedTasks.UseCompatibleStateImageBehavior = false;
            this.lvCompletedTasks.View = System.Windows.Forms.View.Details;
            this.lvCompletedTasks.Visible = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Task";
            this.columnHeader3.Width = 235;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "date";
            this.columnHeader4.Width = 166;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Priority";
            this.columnHeader7.Width = 166;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etertToolStripMenuItem,
            this.ertToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 52);
            // 
            // etertToolStripMenuItem
            // 
            this.etertToolStripMenuItem.Name = "etertToolStripMenuItem";
            this.etertToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.etertToolStripMenuItem.Text = "Mark as not compeletd";
            this.etertToolStripMenuItem.Click += new System.EventHandler(this.unCompleteToolStripMenuItem_Click);
            // 
            // ertToolStripMenuItem
            // 
            this.ertToolStripMenuItem.Name = "ertToolStripMenuItem";
            this.ertToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.ertToolStripMenuItem.Text = "Delete";
            this.ertToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(291, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "> Completed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Location = new System.Drawing.Point(291, 654);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(936, 58);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "+     Add a Task";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Rubik", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "TASKS";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateTaskToolStrip);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::TO_DO_List_with_C_.Properties.Resources.johannes_andersson_UCd78vfC8vU_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 796);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvCompletedTasks);
            this.Controls.Add(this.lvNewTasks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNewTasks;
        private System.Windows.Forms.ListView lvCompletedTasks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem etertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ertToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

