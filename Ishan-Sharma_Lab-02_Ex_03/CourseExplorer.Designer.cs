namespace Ishan_Sharma_Lab_02_Ex_03
{
    partial class CourseExplorer
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("SETechnician");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("SET");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("SET-IG");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("HIT");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("CSNT");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("EET");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("BMET");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("ICET", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("College", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.courseTreeView = new System.Windows.Forms.TreeView();
            this.courseListView = new System.Windows.Forms.ListView();
            this.semesterColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // courseTreeView
            // 
            this.courseTreeView.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTreeView.Location = new System.Drawing.Point(12, 12);
            this.courseTreeView.Name = "courseTreeView";
            treeNode19.Name = "seTechnicianChildNode";
            treeNode19.Text = "SETechnician";
            treeNode20.Name = "setChildNode";
            treeNode20.Text = "SET";
            treeNode21.Name = "setIgChildNode";
            treeNode21.Text = "SET-IG";
            treeNode22.Name = "hitChildNode";
            treeNode22.Text = "HIT";
            treeNode23.Name = "CSNTChildNode";
            treeNode23.Text = "CSNT";
            treeNode24.Name = "EETChildNode";
            treeNode24.Text = "EET";
            treeNode25.Name = "BMETChildNode";
            treeNode25.Text = "BMET";
            treeNode26.Name = "icetChildNode";
            treeNode26.Text = "ICET";
            treeNode27.Name = "collegeMaainNode";
            treeNode27.Text = "College";
            this.courseTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27});
            this.courseTreeView.Size = new System.Drawing.Size(200, 220);
            this.courseTreeView.TabIndex = 1;
            this.courseTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.courseTreeView_AfterSelect);
            // 
            // courseListView
            // 
            this.courseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.semesterColumnHeader,
            this.course1,
            this.course2,
            this.course3,
            this.course4,
            this.course5,
            this.course6});
            this.courseListView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListView.GridLines = true;
            this.courseListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.courseListView.Location = new System.Drawing.Point(218, 12);
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(522, 220);
            this.courseListView.TabIndex = 2;
            this.courseListView.UseCompatibleStateImageBehavior = false;
            this.courseListView.View = System.Windows.Forms.View.Details;
            this.courseListView.SelectedIndexChanged += new System.EventHandler(this.courseListView_SelectedIndexChanged);
            // 
            // semesterColumnHeader
            // 
            this.semesterColumnHeader.Text = "Semester";
            this.semesterColumnHeader.Width = 81;
            // 
            // course1
            // 
            this.course1.Text = "Course 1";
            this.course1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.course1.Width = 68;
            // 
            // course2
            // 
            this.course2.Text = "Course 2";
            this.course2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.course2.Width = 68;
            // 
            // course3
            // 
            this.course3.Text = "Course 3";
            this.course3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.course3.Width = 68;
            // 
            // course4
            // 
            this.course4.Text = "Course 4";
            this.course4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.course4.Width = 71;
            // 
            // course5
            // 
            this.course5.Text = "Course 5";
            this.course5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.course5.Width = 73;
            // 
            // course6
            // 
            this.course6.Text = "Course 6";
            this.course6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.course6.Width = 73;
            // 
            // CourseExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 378);
            this.Controls.Add(this.courseListView);
            this.Controls.Add(this.courseTreeView);
            this.Name = "CourseExplorer";
            this.RightToLeftLayout = true;
            this.Text = "Course Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView courseTreeView;
        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader semesterColumnHeader;
        private System.Windows.Forms.ColumnHeader course1;
        private System.Windows.Forms.ColumnHeader course2;
        private System.Windows.Forms.ColumnHeader course3;
        private System.Windows.Forms.ColumnHeader course4;
        private System.Windows.Forms.ColumnHeader course5;
        private System.Windows.Forms.ColumnHeader course6;
    }
}

