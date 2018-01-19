namespace tokyo.aoisupersix.bve5MapViewer
{
    partial class SelectScenariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectScenariosForm));
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.TopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ReferenceButton = new System.Windows.Forms.Button();
            this.FilePathComboBox = new System.Windows.Forms.ComboBox();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ScenarioListView = new System.Windows.Forms.ListView();
            this.DisplaySettingToolStrip = new System.Windows.Forms.ToolStrip();
            this.DisplayToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.DisplayToolStripItem_Icon = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayToolStripItem_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayToolStripItem_Tile = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.SortToolStripItem_Title = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripItem_Route = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripItem_Vehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripItem_Author = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripItem_Time = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripItem_File = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.TopTableLayout.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
            this.DisplaySettingToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.AutoScroll = true;
            this.SplitContainer.Panel1.Controls.Add(this.TopTableLayout);
            this.SplitContainer.Panel1MinSize = 30;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.MainTableLayout);
            this.SplitContainer.Size = new System.Drawing.Size(584, 561);
            this.SplitContainer.SplitterDistance = 30;
            this.SplitContainer.TabIndex = 0;
            // 
            // TopTableLayout
            // 
            this.TopTableLayout.ColumnCount = 2;
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTableLayout.Controls.Add(this.ReferenceButton, 1, 0);
            this.TopTableLayout.Controls.Add(this.FilePathComboBox, 0, 0);
            this.TopTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTableLayout.Location = new System.Drawing.Point(0, 0);
            this.TopTableLayout.Name = "TopTableLayout";
            this.TopTableLayout.RowCount = 1;
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayout.Size = new System.Drawing.Size(584, 30);
            this.TopTableLayout.TabIndex = 0;
            // 
            // ReferenceButton
            // 
            this.ReferenceButton.AutoSize = true;
            this.ReferenceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReferenceButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReferenceButton.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReferenceButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ReferenceButton.Location = new System.Drawing.Point(552, 3);
            this.ReferenceButton.Name = "ReferenceButton";
            this.ReferenceButton.Size = new System.Drawing.Size(29, 24);
            this.ReferenceButton.TabIndex = 0;
            this.ReferenceButton.Text = "...";
            this.ReferenceButton.UseVisualStyleBackColor = true;
            // 
            // FilePathComboBox
            // 
            this.FilePathComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilePathComboBox.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FilePathComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FilePathComboBox.FormattingEnabled = true;
            this.FilePathComboBox.Location = new System.Drawing.Point(3, 2);
            this.FilePathComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.FilePathComboBox.Name = "FilePathComboBox";
            this.FilePathComboBox.Size = new System.Drawing.Size(543, 26);
            this.FilePathComboBox.TabIndex = 1;
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.ScenarioListView, 0, 1);
            this.MainTableLayout.Controls.Add(this.DisplaySettingToolStrip, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 3;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.MainTableLayout.Size = new System.Drawing.Size(584, 527);
            this.MainTableLayout.TabIndex = 0;
            // 
            // ScenarioListView
            // 
            this.ScenarioListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScenarioListView.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScenarioListView.Location = new System.Drawing.Point(3, 28);
            this.ScenarioListView.Name = "ScenarioListView";
            this.ScenarioListView.Size = new System.Drawing.Size(578, 384);
            this.ScenarioListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ScenarioListView.TabIndex = 0;
            this.ScenarioListView.UseCompatibleStateImageBehavior = false;
            // 
            // DisplaySettingToolStrip
            // 
            this.DisplaySettingToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.DisplaySettingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayToolStripButton,
            this.SortToolStripButton});
            this.DisplaySettingToolStrip.Location = new System.Drawing.Point(0, 0);
            this.DisplaySettingToolStrip.Name = "DisplaySettingToolStrip";
            this.DisplaySettingToolStrip.Size = new System.Drawing.Size(584, 25);
            this.DisplaySettingToolStrip.TabIndex = 1;
            this.DisplaySettingToolStrip.Text = "toolStrip1";
            // 
            // DisplayToolStripButton
            // 
            this.DisplayToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DisplayToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayToolStripItem_Icon,
            this.DisplayToolStripItem_Details,
            this.DisplayToolStripItem_Tile});
            this.DisplayToolStripButton.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisplayToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DisplayToolStripButton.Image")));
            this.DisplayToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DisplayToolStripButton.Name = "DisplayToolStripButton";
            this.DisplayToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.DisplayToolStripButton.Text = "表示";
            // 
            // DisplayToolStripItem_Icon
            // 
            this.DisplayToolStripItem_Icon.Name = "DisplayToolStripItem_Icon";
            this.DisplayToolStripItem_Icon.Size = new System.Drawing.Size(152, 22);
            this.DisplayToolStripItem_Icon.Text = "アイコン";
            // 
            // DisplayToolStripItem_Details
            // 
            this.DisplayToolStripItem_Details.Name = "DisplayToolStripItem_Details";
            this.DisplayToolStripItem_Details.Size = new System.Drawing.Size(152, 22);
            this.DisplayToolStripItem_Details.Text = "詳細";
            // 
            // DisplayToolStripItem_Tile
            // 
            this.DisplayToolStripItem_Tile.Name = "DisplayToolStripItem_Tile";
            this.DisplayToolStripItem_Tile.Size = new System.Drawing.Size(152, 22);
            this.DisplayToolStripItem_Tile.Text = "並べて表示";
            // 
            // SortToolStripButton
            // 
            this.SortToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortToolStripItem_Title,
            this.SortToolStripItem_Route,
            this.SortToolStripItem_Vehicle,
            this.SortToolStripItem_Author,
            this.SortToolStripItem_Time,
            this.SortToolStripItem_File});
            this.SortToolStripButton.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SortToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SortToolStripButton.Image")));
            this.SortToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortToolStripButton.Name = "SortToolStripButton";
            this.SortToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.SortToolStripButton.Text = "並び替え";
            // 
            // SortToolStripItem_Title
            // 
            this.SortToolStripItem_Title.Name = "SortToolStripItem_Title";
            this.SortToolStripItem_Title.Size = new System.Drawing.Size(152, 22);
            this.SortToolStripItem_Title.Text = "タイトル";
            // 
            // SortToolStripItem_Route
            // 
            this.SortToolStripItem_Route.Name = "SortToolStripItem_Route";
            this.SortToolStripItem_Route.Size = new System.Drawing.Size(152, 22);
            this.SortToolStripItem_Route.Text = "路線";
            // 
            // SortToolStripItem_Vehicle
            // 
            this.SortToolStripItem_Vehicle.Name = "SortToolStripItem_Vehicle";
            this.SortToolStripItem_Vehicle.Size = new System.Drawing.Size(152, 22);
            this.SortToolStripItem_Vehicle.Text = "車両";
            // 
            // SortToolStripItem_Author
            // 
            this.SortToolStripItem_Author.Name = "SortToolStripItem_Author";
            this.SortToolStripItem_Author.Size = new System.Drawing.Size(152, 22);
            this.SortToolStripItem_Author.Text = "作者";
            // 
            // SortToolStripItem_Time
            // 
            this.SortToolStripItem_Time.Name = "SortToolStripItem_Time";
            this.SortToolStripItem_Time.Size = new System.Drawing.Size(152, 22);
            this.SortToolStripItem_Time.Text = "運転日時";
            // 
            // SortToolStripItem_File
            // 
            this.SortToolStripItem_File.Name = "SortToolStripItem_File";
            this.SortToolStripItem_File.Size = new System.Drawing.Size(152, 22);
            this.SortToolStripItem_File.Text = "ファイル";
            // 
            // SelectScenariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.SplitContainer);
            this.Name = "SelectScenariosForm";
            this.Text = "SelectScenariosForm";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.TopTableLayout.ResumeLayout(false);
            this.TopTableLayout.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.DisplaySettingToolStrip.ResumeLayout(false);
            this.DisplaySettingToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.TableLayoutPanel TopTableLayout;
        private System.Windows.Forms.Button ReferenceButton;
        private System.Windows.Forms.ComboBox FilePathComboBox;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.ListView ScenarioListView;
        private System.Windows.Forms.ToolStrip DisplaySettingToolStrip;
        private System.Windows.Forms.ToolStripSplitButton DisplayToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripItem_Icon;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripItem_Details;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripItem_Tile;
        private System.Windows.Forms.ToolStripSplitButton SortToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripItem_Title;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripItem_Route;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripItem_Vehicle;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripItem_Author;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripItem_Time;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripItem_File;
    }
}