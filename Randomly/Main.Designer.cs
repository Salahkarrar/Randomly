namespace Randomly
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Eye_Btn = new System.Windows.Forms.Button();
            this.UserName_Txt = new System.Windows.Forms.TextBox();
            this.T_PassMangerBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.randomSet = new Randomly.RandomSet();
            this.Websites_Txt = new System.Windows.Forms.TextBox();
            this.Date_Txt = new System.Windows.Forms.TextBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.New_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Copy_Btn = new System.Windows.Forms.Button();
            this.Random_Btn = new System.Windows.Forms.Button();
            this.Pass_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.Pass_Grid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_PassMangerTabAd = new Randomly.RandomSetTableAdapters.T_PassMangerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_PassMangerBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomSet)).BeginInit();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.Eye_Btn);
            this.panel1.Controls.Add(this.UserName_Txt);
            this.panel1.Controls.Add(this.Websites_Txt);
            this.panel1.Controls.Add(this.Date_Txt);
            this.panel1.Controls.Add(this.Delete_Btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Cancel_Btn);
            this.panel1.Controls.Add(this.Edit_Btn);
            this.panel1.Controls.Add(this.New_Btn);
            this.panel1.Controls.Add(this.Save_Btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Copy_Btn);
            this.panel1.Controls.Add(this.Random_Btn);
            this.panel1.Controls.Add(this.Pass_Txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 243);
            this.panel1.TabIndex = 0;
            // 
            // Eye_Btn
            // 
            this.Eye_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eye_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Eye_Btn.FlatAppearance.BorderSize = 0;
            this.Eye_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Eye_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eye_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eye_Btn.ForeColor = System.Drawing.Color.Transparent;
            this.Eye_Btn.Image = global::Randomly.Properties.Resources.show;
            this.Eye_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eye_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Eye_Btn.Location = new System.Drawing.Point(369, 101);
            this.Eye_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Eye_Btn.Name = "Eye_Btn";
            this.Eye_Btn.Size = new System.Drawing.Size(33, 27);
            this.Eye_Btn.TabIndex = 12;
            this.Eye_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eye_Btn.UseVisualStyleBackColor = false;
            this.Eye_Btn.Click += new System.EventHandler(this.Eye_Btn_Click);
            // 
            // UserName_Txt
            // 
            this.UserName_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_PassMangerBindSour, "UserName", true));
            this.UserName_Txt.Location = new System.Drawing.Point(129, 62);
            this.UserName_Txt.Name = "UserName_Txt";
            this.UserName_Txt.ReadOnly = true;
            this.UserName_Txt.Size = new System.Drawing.Size(272, 25);
            this.UserName_Txt.TabIndex = 2;
            // 
            // T_PassMangerBindSour
            // 
            this.T_PassMangerBindSour.DataMember = "T_PassManger";
            this.T_PassMangerBindSour.DataSource = this.randomSet;
            // 
            // randomSet
            // 
            this.randomSet.DataSetName = "RandomSet";
            this.randomSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Websites_Txt
            // 
            this.Websites_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Websites_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_PassMangerBindSour, "Websites", true));
            this.Websites_Txt.Location = new System.Drawing.Point(129, 25);
            this.Websites_Txt.Name = "Websites_Txt";
            this.Websites_Txt.ReadOnly = true;
            this.Websites_Txt.Size = new System.Drawing.Size(272, 25);
            this.Websites_Txt.TabIndex = 1;
            // 
            // Date_Txt
            // 
            this.Date_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_PassMangerBindSour, "DateChange", true));
            this.Date_Txt.Location = new System.Drawing.Point(129, 138);
            this.Date_Txt.Name = "Date_Txt";
            this.Date_Txt.ReadOnly = true;
            this.Date_Txt.Size = new System.Drawing.Size(272, 25);
            this.Date_Txt.TabIndex = 4;
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_Btn.Image = global::Randomly.Properties.Resources.Dark_Delete_18;
            this.Delete_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete_Btn.Location = new System.Drawing.Point(508, 189);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(99, 33);
            this.Delete_Btn.TabIndex = 10;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Btn.ForeColor = System.Drawing.Color.Black;
            this.Cancel_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel_Btn.Location = new System.Drawing.Point(358, 189);
            this.Cancel_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(99, 33);
            this.Cancel_Btn.TabIndex = 9;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Btn.ForeColor = System.Drawing.Color.Black;
            this.Edit_Btn.Image = global::Randomly.Properties.Resources.Dark_Edit_18;
            this.Edit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Edit_Btn.Location = new System.Drawing.Point(250, 189);
            this.Edit_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(99, 33);
            this.Edit_Btn.TabIndex = 8;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // New_Btn
            // 
            this.New_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.New_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Btn.ForeColor = System.Drawing.Color.Black;
            this.New_Btn.Image = global::Randomly.Properties.Resources.Dark_Add_18;
            this.New_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.New_Btn.Location = new System.Drawing.Point(34, 189);
            this.New_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(99, 33);
            this.New_Btn.TabIndex = 0;
            this.New_Btn.Text = "New";
            this.New_Btn.UseVisualStyleBackColor = true;
            this.New_Btn.Click += new System.EventHandler(this.New_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_Btn.Enabled = false;
            this.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Btn.ForeColor = System.Drawing.Color.Black;
            this.Save_Btn.Image = global::Randomly.Properties.Resources.Dark_Save_18;
            this.Save_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_Btn.Location = new System.Drawing.Point(142, 189);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(99, 33);
            this.Save_Btn.TabIndex = 7;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // Copy_Btn
            // 
            this.Copy_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Copy_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Copy_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Copy_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Copy_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Copy_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy_Btn.ForeColor = System.Drawing.Color.Black;
            this.Copy_Btn.Image = global::Randomly.Properties.Resources.copy;
            this.Copy_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Copy_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Copy_Btn.Location = new System.Drawing.Point(555, 102);
            this.Copy_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Copy_Btn.Name = "Copy_Btn";
            this.Copy_Btn.Size = new System.Drawing.Size(98, 31);
            this.Copy_Btn.TabIndex = 6;
            this.Copy_Btn.Text = "Copy";
            this.Copy_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Copy_Btn.UseVisualStyleBackColor = true;
            this.Copy_Btn.Click += new System.EventHandler(this.Copy_Btn_Click);
            // 
            // Random_Btn
            // 
            this.Random_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Random_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Random_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Random_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Random_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Random_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Random_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Random_Btn.ForeColor = System.Drawing.Color.Black;
            this.Random_Btn.Image = global::Randomly.Properties.Resources.Dark_Restore_18;
            this.Random_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Random_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Random_Btn.Location = new System.Drawing.Point(424, 102);
            this.Random_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Random_Btn.Name = "Random_Btn";
            this.Random_Btn.Size = new System.Drawing.Size(110, 31);
            this.Random_Btn.TabIndex = 5;
            this.Random_Btn.Text = "Random";
            this.Random_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Random_Btn.UseVisualStyleBackColor = true;
            this.Random_Btn.Click += new System.EventHandler(this.Random_Btn_Click);
            // 
            // Pass_Txt
            // 
            this.Pass_Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pass_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Pass_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_PassMangerBindSour, "Pass", true));
            this.Pass_Txt.Location = new System.Drawing.Point(129, 102);
            this.Pass_Txt.Name = "Pass_Txt";
            this.Pass_Txt.ReadOnly = true;
            this.Pass_Txt.Size = new System.Drawing.Size(272, 25);
            this.Pass_Txt.TabIndex = 3;
            this.Pass_Txt.UseSystemPasswordChar = true;
            this.Pass_Txt.Enter += new System.EventHandler(this.Pass_Txt_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Websites";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            // 
            // Grid_Group
            // 
            this.Grid_Group.BackColor = System.Drawing.Color.Transparent;
            this.Grid_Group.Controls.Add(this.Pass_Grid);
            this.Grid_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Grid_Group.Location = new System.Drawing.Point(0, 243);
            this.Grid_Group.Margin = new System.Windows.Forms.Padding(4);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Padding = new System.Windows.Forms.Padding(4);
            this.Grid_Group.Size = new System.Drawing.Size(693, 240);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Password Manager List";
            // 
            // Pass_Grid
            // 
            this.Pass_Grid.AllowUserToAddRows = false;
            this.Pass_Grid.AllowUserToDeleteRows = false;
            this.Pass_Grid.AllowUserToResizeColumns = false;
            this.Pass_Grid.AllowUserToResizeRows = false;
            this.Pass_Grid.AutoGenerateColumns = false;
            this.Pass_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Pass_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Pass_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Pass_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Pass_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pass_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.websitesDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.dateChangeDataGridViewTextBoxColumn});
            this.Pass_Grid.DataSource = this.T_PassMangerBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Pass_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Pass_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pass_Grid.EnableHeadersVisualStyles = false;
            this.Pass_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Pass_Grid.Location = new System.Drawing.Point(4, 23);
            this.Pass_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Pass_Grid.MultiSelect = false;
            this.Pass_Grid.Name = "Pass_Grid";
            this.Pass_Grid.ReadOnly = true;
            this.Pass_Grid.RowHeadersVisible = false;
            this.Pass_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Pass_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Pass_Grid.RowTemplate.DividerHeight = 4;
            this.Pass_Grid.RowTemplate.Height = 25;
            this.Pass_Grid.RowTemplate.ReadOnly = true;
            this.Pass_Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Pass_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Pass_Grid.ShowCellErrors = false;
            this.Pass_Grid.ShowCellToolTips = false;
            this.Pass_Grid.ShowEditingIcon = false;
            this.Pass_Grid.ShowRowErrors = false;
            this.Pass_Grid.Size = new System.Drawing.Size(685, 213);
            this.Pass_Grid.TabIndex = 0;
            this.Pass_Grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Pass_Grid_CellFormatting);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // websitesDataGridViewTextBoxColumn
            // 
            this.websitesDataGridViewTextBoxColumn.DataPropertyName = "Websites";
            this.websitesDataGridViewTextBoxColumn.HeaderText = "Websites";
            this.websitesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.websitesDataGridViewTextBoxColumn.Name = "websitesDataGridViewTextBoxColumn";
            this.websitesDataGridViewTextBoxColumn.ReadOnly = true;
            this.websitesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Pass";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateChangeDataGridViewTextBoxColumn
            // 
            this.dateChangeDataGridViewTextBoxColumn.DataPropertyName = "DateChange";
            this.dateChangeDataGridViewTextBoxColumn.HeaderText = "DateChange";
            this.dateChangeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateChangeDataGridViewTextBoxColumn.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dateChangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // T_PassMangerTabAd
            // 
            this.T_PassMangerTabAd.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 483);
            this.Controls.Add(this.Grid_Group);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randomly";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_PassMangerBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomSet)).EndInit();
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Eye_Btn;
        private System.Windows.Forms.TextBox Date_Txt;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Copy_Btn;
        private System.Windows.Forms.Button Random_Btn;
        private System.Windows.Forms.TextBox Pass_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView Pass_Grid;
        private RandomSet randomSet;
        private System.Windows.Forms.BindingSource T_PassMangerBindSour;
        private RandomSetTableAdapters.T_PassMangerTableAdapter T_PassMangerTabAd;
        private System.Windows.Forms.TextBox UserName_Txt;
        private System.Windows.Forms.TextBox Websites_Txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChangeDataGridViewTextBoxColumn;
    }
}

