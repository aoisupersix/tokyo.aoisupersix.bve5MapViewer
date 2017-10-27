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
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.TopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ReferenceButton = new System.Windows.Forms.Button();
            this.FilePathComboBox = new System.Windows.Forms.ComboBox();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ScenarioListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.TopTableLayout.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
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
            this.FilePathComboBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FilePathComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FilePathComboBox.FormattingEnabled = true;
            this.FilePathComboBox.Location = new System.Drawing.Point(3, 5);
            this.FilePathComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.FilePathComboBox.Name = "FilePathComboBox";
            this.FilePathComboBox.Size = new System.Drawing.Size(543, 20);
            this.FilePathComboBox.TabIndex = 1;
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.ScenarioListView, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.MainTableLayout.Size = new System.Drawing.Size(584, 527);
            this.MainTableLayout.TabIndex = 0;
            // 
            // ScenarioListView
            // 
            this.ScenarioListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScenarioListView.Location = new System.Drawing.Point(3, 3);
            this.ScenarioListView.Name = "ScenarioListView";
            this.ScenarioListView.Size = new System.Drawing.Size(578, 403);
            this.ScenarioListView.TabIndex = 0;
            this.ScenarioListView.UseCompatibleStateImageBehavior = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.TableLayoutPanel TopTableLayout;
        private System.Windows.Forms.Button ReferenceButton;
        private System.Windows.Forms.ComboBox FilePathComboBox;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.ListView ScenarioListView;
    }
}