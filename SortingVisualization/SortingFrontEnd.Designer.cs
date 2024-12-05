namespace SortingVisualization
{
    partial class SortingFrontEnd
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
            RandomvalueBtn = new Button();
            backPanel = new Panel();
            label1 = new Label();
            Time = new Label();
            AllSortAlgoDD = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // RandomvalueBtn
            // 
            RandomvalueBtn.AccessibleDescription = "RandomGenrateBtn";
            RandomvalueBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RandomvalueBtn.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RandomvalueBtn.Location = new Point(850, 12);
            RandomvalueBtn.Name = "RandomvalueBtn";
            RandomvalueBtn.Size = new Size(203, 31);
            RandomvalueBtn.TabIndex = 0;
            RandomvalueBtn.Text = "Generate Random Value";
            RandomvalueBtn.UseVisualStyleBackColor = true;
            RandomvalueBtn.Click += button1_Click;
            // 
            // backPanel
            // 
            backPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backPanel.BackColor = SystemColors.AppWorkspace;
            backPanel.Location = new Point(12, 86);
            backPanel.Name = "backPanel";
            backPanel.Size = new Size(1041, 422);
            backPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 57);
            label1.Name = "label1";
            label1.Size = new Size(116, 26);
            label1.TabIndex = 3;
            label1.Text = "Total Time:";
            // 
            // Time
            // 
            Time.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Time.AutoSize = true;
            Time.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.Location = new Point(569, 57);
            Time.Name = "Time";
            Time.Size = new Size(57, 26);
            Time.TabIndex = 4;
            Time.Text = "00:00";
            // 
            // AllSortAlgoDD
            // 
            AllSortAlgoDD.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllSortAlgoDD.FormattingEnabled = true;
            AllSortAlgoDD.Items.AddRange(new object[] { "Bubble Sort", "Insertion Sort", "Selection Sort" });
            AllSortAlgoDD.Location = new Point(217, 13);
            AllSortAlgoDD.Name = "AllSortAlgoDD";
            AllSortAlgoDD.Size = new Size(204, 30);
            AllSortAlgoDD.TabIndex = 7;
            AllSortAlgoDD.SelectedIndexChanged += AllSortAlgoDD_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(17, 18);
            label2.Name = "label2";
            label2.Size = new Size(198, 21);
            label2.TabIndex = 8;
            label2.Text = "Select a Sorting Algorithm:";
            // 
            // SortingFrontEnd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 520);
            Controls.Add(label2);
            Controls.Add(AllSortAlgoDD);
            Controls.Add(Time);
            Controls.Add(label1);
            Controls.Add(backPanel);
            Controls.Add(RandomvalueBtn);
            Name = "SortingFrontEnd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Soring Visualization";
            Load += SortingFrontEnd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RandomvalueBtn;
        private Panel backPanel;
        private Label label1;
        private Label Time;
        private ComboBox AllSortAlgoDD;
        private Label label2;
    }
}