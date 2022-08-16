namespace PCSpecs
{
    partial class CustomClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomClass));
            this.customListView = new MaterialSkin.Controls.MaterialListView();
            this.customclassListView = new MaterialSkin.Controls.MaterialListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customclassButton = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // customListView
            // 
            this.customListView.AutoSizeTable = false;
            this.customListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customListView.Depth = 0;
            this.customListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customListView.FullRowSelect = true;
            this.customListView.HideSelection = false;
            this.customListView.Location = new System.Drawing.Point(3, 64);
            this.customListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.customListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.customListView.MouseState = MaterialSkin.MouseState.OUT;
            this.customListView.Name = "customListView";
            this.customListView.OwnerDraw = true;
            this.customListView.Size = new System.Drawing.Size(794, 383);
            this.customListView.TabIndex = 0;
            this.customListView.UseCompatibleStateImageBehavior = false;
            this.customListView.View = System.Windows.Forms.View.Details;
            // 
            // customclassListView
            // 
            this.customclassListView.AutoSizeTable = false;
            this.customclassListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customclassListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customclassListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.valueHeader});
            this.customclassListView.Depth = 0;
            this.customclassListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customclassListView.FullRowSelect = true;
            this.customclassListView.HideSelection = false;
            this.customclassListView.Location = new System.Drawing.Point(3, 64);
            this.customclassListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.customclassListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.customclassListView.MouseState = MaterialSkin.MouseState.OUT;
            this.customclassListView.Name = "customclassListView";
            this.customclassListView.OwnerDraw = true;
            this.customclassListView.Size = new System.Drawing.Size(794, 383);
            this.customclassListView.TabIndex = 2;
            this.customclassListView.UseCompatibleStateImageBehavior = false;
            this.customclassListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 350;
            // 
            // valueHeader
            // 
            this.valueHeader.Text = "Value";
            this.valueHeader.Width = 500;
            // 
            // customclassButton
            // 
            this.customclassButton.AutoSize = true;
            this.customclassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.customclassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customclassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customclassButton.ForeColor = System.Drawing.Color.White;
            this.customclassButton.Location = new System.Drawing.Point(662, 32);
            this.customclassButton.Name = "customclassButton";
            this.customclassButton.Size = new System.Drawing.Size(130, 20);
            this.customclassButton.TabIndex = 3;
            this.customclassButton.Text = "Click to edit class";
            this.customclassButton.Click += new System.EventHandler(this.customclassButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(750, 88);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(20, 26);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.Visible = false;
            // 
            // CustomClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customclassButton);
            this.Controls.Add(this.customclassListView);
            this.Controls.Add(this.customListView);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomClass";
            this.Text = "Custom Class";
            this.Load += new System.EventHandler(this.CustomClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView customListView;
        private MaterialSkin.Controls.MaterialListView customclassListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader valueHeader;
        private System.Windows.Forms.Label customclassButton;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}