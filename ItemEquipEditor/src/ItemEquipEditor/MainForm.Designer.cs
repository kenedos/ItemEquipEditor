namespace ItemEquipEditor
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtClassID = new TextBox();
            btnSearch = new Button();
            txtUseLv = new TextBox();
            txtItemGrade = new TextBox();
            txtEquipGroup = new TextBox();
            txtSellPrice = new TextBox();
            txtMaxSocket = new TextBox();
            lstRelevantProps = new ListBox();
            cmbRelevantProps = new ComboBox();
            txtRelevantValue = new TextBox();
            btnAddRelevant = new Button();
            btnUpdate = new Button();
            lblClassID = new Label();
            lblUseLv = new Label();
            lblItemGrade = new Label();
            lblEquipGroup = new Label();
            lblSellPrice = new Label();
            lblMaxSocket = new Label();
            lblRelevantProps = new Label();
            lblAddRelevant = new Label();
            lblRelevantValue = new Label();
            SuspendLayout();
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(160, 18);
            txtClassID.Margin = new Padding(4, 5, 4, 5);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(132, 27);
            txtClassID.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(301, 18);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtUseLv
            // 
            txtUseLv.Location = new Point(160, 58);
            txtUseLv.Margin = new Padding(4, 5, 4, 5);
            txtUseLv.Name = "txtUseLv";
            txtUseLv.Size = new Size(132, 27);
            txtUseLv.TabIndex = 2;
            // 
            // txtItemGrade
            // 
            txtItemGrade.Location = new Point(160, 98);
            txtItemGrade.Margin = new Padding(4, 5, 4, 5);
            txtItemGrade.Name = "txtItemGrade";
            txtItemGrade.Size = new Size(132, 27);
            txtItemGrade.TabIndex = 3;
            // 
            // txtEquipGroup
            // 
            txtEquipGroup.Location = new Point(160, 138);
            txtEquipGroup.Margin = new Padding(4, 5, 4, 5);
            txtEquipGroup.Name = "txtEquipGroup";
            txtEquipGroup.ReadOnly = true;
            txtEquipGroup.Size = new Size(132, 27);
            txtEquipGroup.TabIndex = 4;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(160, 178);
            txtSellPrice.Margin = new Padding(4, 5, 4, 5);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(132, 27);
            txtSellPrice.TabIndex = 5;
            // 
            // txtMaxSocket
            // 
            txtMaxSocket.Location = new Point(160, 218);
            txtMaxSocket.Margin = new Padding(4, 5, 4, 5);
            txtMaxSocket.Name = "txtMaxSocket";
            txtMaxSocket.Size = new Size(132, 27);
            txtMaxSocket.TabIndex = 6;
            // 
            // lstRelevantProps
            // 
            lstRelevantProps.FormattingEnabled = true;
            lstRelevantProps.Location = new Point(301, 83);
            lstRelevantProps.Margin = new Padding(4, 5, 4, 5);
            lstRelevantProps.Name = "lstRelevantProps";
            lstRelevantProps.Size = new Size(274, 144);
            lstRelevantProps.TabIndex = 7;
            // 
            // cmbRelevantProps
            // 
            cmbRelevantProps.FormattingEnabled = true;
            cmbRelevantProps.Location = new Point(176, 258);
            cmbRelevantProps.Margin = new Padding(4, 5, 4, 5);
            cmbRelevantProps.Name = "cmbRelevantProps";
            cmbRelevantProps.Size = new Size(194, 28);
            cmbRelevantProps.TabIndex = 8;
            // 
            // txtRelevantValue
            // 
            txtRelevantValue.Location = new Point(378, 258);
            txtRelevantValue.Margin = new Padding(4, 5, 4, 5);
            txtRelevantValue.Name = "txtRelevantValue";
            txtRelevantValue.Size = new Size(85, 27);
            txtRelevantValue.TabIndex = 9;
            // 
            // btnAddRelevant
            // 
            btnAddRelevant.Location = new Point(471, 254);
            btnAddRelevant.Margin = new Padding(4, 5, 4, 5);
            btnAddRelevant.Name = "btnAddRelevant";
            btnAddRelevant.Size = new Size(100, 35);
            btnAddRelevant.TabIndex = 10;
            btnAddRelevant.Text = "Add/Update";
            btnAddRelevant.UseVisualStyleBackColor = true;
            btnAddRelevant.Click += btnAddRelevant_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(16, 300);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(555, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update Item";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblClassID
            // 
            lblClassID.AutoSize = true;
            lblClassID.Location = new Point(16, 23);
            lblClassID.Margin = new Padding(4, 0, 4, 0);
            lblClassID.Name = "lblClassID";
            lblClassID.Size = new Size(61, 20);
            lblClassID.TabIndex = 12;
            lblClassID.Text = "Class ID";
            // 
            // lblUseLv
            // 
            lblUseLv.AutoSize = true;
            lblUseLv.Location = new Point(16, 63);
            lblUseLv.Margin = new Padding(4, 0, 4, 0);
            lblUseLv.Name = "lblUseLv";
            lblUseLv.Size = new Size(71, 20);
            lblUseLv.TabIndex = 13;
            lblUseLv.Text = "Use Level";
            // 
            // lblItemGrade
            // 
            lblItemGrade.AutoSize = true;
            lblItemGrade.Location = new Point(16, 103);
            lblItemGrade.Margin = new Padding(4, 0, 4, 0);
            lblItemGrade.Name = "lblItemGrade";
            lblItemGrade.Size = new Size(83, 20);
            lblItemGrade.TabIndex = 14;
            lblItemGrade.Text = "Item Grade";
            // 
            // lblEquipGroup
            // 
            lblEquipGroup.AutoSize = true;
            lblEquipGroup.Location = new Point(16, 143);
            lblEquipGroup.Margin = new Padding(4, 0, 4, 0);
            lblEquipGroup.Name = "lblEquipGroup";
            lblEquipGroup.Size = new Size(92, 20);
            lblEquipGroup.TabIndex = 15;
            lblEquipGroup.Text = "Equip Group";
            // 
            // lblSellPrice
            // 
            lblSellPrice.AutoSize = true;
            lblSellPrice.Location = new Point(16, 183);
            lblSellPrice.Margin = new Padding(4, 0, 4, 0);
            lblSellPrice.Name = "lblSellPrice";
            lblSellPrice.Size = new Size(69, 20);
            lblSellPrice.TabIndex = 16;
            lblSellPrice.Text = "Sell Price";
            // 
            // lblMaxSocket
            // 
            lblMaxSocket.AutoSize = true;
            lblMaxSocket.Location = new Point(16, 223);
            lblMaxSocket.Margin = new Padding(4, 0, 4, 0);
            lblMaxSocket.Name = "lblMaxSocket";
            lblMaxSocket.Size = new Size(128, 20);
            lblMaxSocket.TabIndex = 17;
            lblMaxSocket.Text = "Max Socket Count";
            // 
            // lblRelevantProps
            // 
            lblRelevantProps.AutoSize = true;
            lblRelevantProps.Location = new Point(301, 58);
            lblRelevantProps.Margin = new Padding(4, 0, 4, 0);
            lblRelevantProps.Name = "lblRelevantProps";
            lblRelevantProps.Size = new Size(137, 20);
            lblRelevantProps.TabIndex = 18;
            lblRelevantProps.Text = "Relevant Properties";
            // 
            // lblAddRelevant
            // 
            lblAddRelevant.AutoSize = true;
            lblAddRelevant.Location = new Point(16, 264);
            lblAddRelevant.Margin = new Padding(4, 0, 4, 0);
            lblAddRelevant.Name = "lblAddRelevant";
            lblAddRelevant.Size = new Size(152, 20);
            lblAddRelevant.TabIndex = 19;
            lblAddRelevant.Text = "Add/Update Property";
            // 
            // lblRelevantValue
            // 
            lblRelevantValue.AutoSize = true;
            lblRelevantValue.Location = new Point(378, 232);
            lblRelevantValue.Margin = new Padding(4, 0, 4, 0);
            lblRelevantValue.Name = "lblRelevantValue";
            lblRelevantValue.Size = new Size(45, 20);
            lblRelevantValue.TabIndex = 20;
            lblRelevantValue.Text = "Value";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 355);
            Controls.Add(lblRelevantValue);
            Controls.Add(lblAddRelevant);
            Controls.Add(lblRelevantProps);
            Controls.Add(lblMaxSocket);
            Controls.Add(lblSellPrice);
            Controls.Add(lblEquipGroup);
            Controls.Add(lblItemGrade);
            Controls.Add(lblUseLv);
            Controls.Add(lblClassID);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddRelevant);
            Controls.Add(txtRelevantValue);
            Controls.Add(cmbRelevantProps);
            Controls.Add(lstRelevantProps);
            Controls.Add(txtMaxSocket);
            Controls.Add(txtSellPrice);
            Controls.Add(txtEquipGroup);
            Controls.Add(txtItemGrade);
            Controls.Add(txtUseLv);
            Controls.Add(btnSearch);
            Controls.Add(txtClassID);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Item Equip Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUseLv;
        private System.Windows.Forms.TextBox txtItemGrade;
        private System.Windows.Forms.TextBox txtEquipGroup;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtMaxSocket;
        private System.Windows.Forms.ListBox lstRelevantProps;
        private System.Windows.Forms.ComboBox cmbRelevantProps;
        private System.Windows.Forms.TextBox txtRelevantValue;
        private System.Windows.Forms.Button btnAddRelevant;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblUseLv;
        private System.Windows.Forms.Label lblItemGrade;
        private System.Windows.Forms.Label lblEquipGroup;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label lblMaxSocket;
        private System.Windows.Forms.Label lblRelevantProps;
        private System.Windows.Forms.Label lblAddRelevant;
        private System.Windows.Forms.Label lblRelevantValue;
    }
}