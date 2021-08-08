
namespace UI
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.PictureBox();
            this.lblDetailsFilter = new System.Windows.Forms.Label();
            this.detailsInputFilter = new System.Windows.Forms.TextBox();
            this.priceInputFilter = new System.Windows.Forms.NumericUpDown();
            this.lblPriceFilter = new System.Windows.Forms.Label();
            this.lblNameFilter = new System.Windows.Forms.Label();
            this.lblCodeFilter = new System.Windows.Forms.Label();
            this.codeInputFilter = new System.Windows.Forms.TextBox();
            this.nameInputFilter = new System.Windows.Forms.TextBox();
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Panel();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInputFilter)).BeginInit();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.dataGridMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            this.titleBar.Controls.Add(this.panel2);
            this.titleBar.Controls.Add(this.btnMaximize);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.btnRestore);
            this.titleBar.Controls.Add(this.btnMinimize);
            this.titleBar.Location = new System.Drawing.Point(3, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(982, 51);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(902, 11);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(22, 22);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(942, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(902, 11);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(22, 22);
            this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestore.TabIndex = 2;
            this.btnRestore.TabStop = false;
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(862, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.saveBtn);
            this.mainPanel.Controls.Add(this.addBtn);
            this.mainPanel.Controls.Add(this.lblDetailsFilter);
            this.mainPanel.Controls.Add(this.detailsInputFilter);
            this.mainPanel.Controls.Add(this.priceInputFilter);
            this.mainPanel.Controls.Add(this.lblPriceFilter);
            this.mainPanel.Controls.Add(this.lblNameFilter);
            this.mainPanel.Controls.Add(this.lblCodeFilter);
            this.mainPanel.Controls.Add(this.codeInputFilter);
            this.mainPanel.Controls.Add(this.nameInputFilter);
            this.mainPanel.Controls.Add(this.dataGridPanel);
            this.mainPanel.Controls.Add(this.logoPictureBox);
            this.mainPanel.Controls.Add(this.separator);
            this.mainPanel.Location = new System.Drawing.Point(3, 44);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(982, 499);
            this.mainPanel.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(450, 41);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(36, 37);
            this.saveBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.saveBtn.TabIndex = 13;
            this.saveBtn.TabStop = false;
            this.saveBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveBtn_MouseClick);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(385, 41);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(39, 37);
            this.addBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addBtn.TabIndex = 12;
            this.addBtn.TabStop = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // lblDetailsFilter
            // 
            this.lblDetailsFilter.AutoSize = true;
            this.lblDetailsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsFilter.ForeColor = System.Drawing.Color.White;
            this.lblDetailsFilter.Location = new System.Drawing.Point(582, 139);
            this.lblDetailsFilter.Name = "lblDetailsFilter";
            this.lblDetailsFilter.Size = new System.Drawing.Size(58, 16);
            this.lblDetailsFilter.TabIndex = 11;
            this.lblDetailsFilter.Text = "Detalles";
            // 
            // detailsInputFilter
            // 
            this.detailsInputFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.detailsInputFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsInputFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsInputFilter.ForeColor = System.Drawing.Color.White;
            this.detailsInputFilter.Location = new System.Drawing.Point(501, 158);
            this.detailsInputFilter.Name = "detailsInputFilter";
            this.detailsInputFilter.Size = new System.Drawing.Size(231, 15);
            this.detailsInputFilter.TabIndex = 10;
            this.detailsInputFilter.TextChanged += new System.EventHandler(this.detailsInputFilter_TextChanged);
            // 
            // priceInputFilter
            // 
            this.priceInputFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.priceInputFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceInputFilter.DecimalPlaces = 2;
            this.priceInputFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInputFilter.ForeColor = System.Drawing.Color.White;
            this.priceInputFilter.Location = new System.Drawing.Point(748, 156);
            this.priceInputFilter.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.priceInputFilter.Name = "priceInputFilter";
            this.priceInputFilter.Size = new System.Drawing.Size(86, 18);
            this.priceInputFilter.TabIndex = 9;
            this.priceInputFilter.ValueChanged += new System.EventHandler(this.priceInputFilter_ValueChanged);
            // 
            // lblPriceFilter
            // 
            this.lblPriceFilter.AutoSize = true;
            this.lblPriceFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceFilter.ForeColor = System.Drawing.Color.White;
            this.lblPriceFilter.Location = new System.Drawing.Point(765, 135);
            this.lblPriceFilter.Name = "lblPriceFilter";
            this.lblPriceFilter.Size = new System.Drawing.Size(47, 16);
            this.lblPriceFilter.TabIndex = 8;
            this.lblPriceFilter.Text = "Precio";
            // 
            // lblNameFilter
            // 
            this.lblNameFilter.AutoSize = true;
            this.lblNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFilter.ForeColor = System.Drawing.Color.White;
            this.lblNameFilter.Location = new System.Drawing.Point(358, 139);
            this.lblNameFilter.Name = "lblNameFilter";
            this.lblNameFilter.Size = new System.Drawing.Size(57, 16);
            this.lblNameFilter.TabIndex = 7;
            this.lblNameFilter.Text = "Nombre";
            // 
            // lblCodeFilter
            // 
            this.lblCodeFilter.AutoSize = true;
            this.lblCodeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeFilter.ForeColor = System.Drawing.Color.White;
            this.lblCodeFilter.Location = new System.Drawing.Point(178, 139);
            this.lblCodeFilter.Name = "lblCodeFilter";
            this.lblCodeFilter.Size = new System.Drawing.Size(52, 16);
            this.lblCodeFilter.TabIndex = 6;
            this.lblCodeFilter.Text = "Codigo";
            // 
            // codeInputFilter
            // 
            this.codeInputFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.codeInputFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeInputFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeInputFilter.ForeColor = System.Drawing.Color.White;
            this.codeInputFilter.Location = new System.Drawing.Point(146, 158);
            this.codeInputFilter.Name = "codeInputFilter";
            this.codeInputFilter.Size = new System.Drawing.Size(126, 15);
            this.codeInputFilter.TabIndex = 4;
            this.codeInputFilter.TextChanged += new System.EventHandler(this.codeInputFilter_TextChanged);
            // 
            // nameInputFilter
            // 
            this.nameInputFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.nameInputFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInputFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputFilter.ForeColor = System.Drawing.Color.White;
            this.nameInputFilter.Location = new System.Drawing.Point(288, 158);
            this.nameInputFilter.Name = "nameInputFilter";
            this.nameInputFilter.Size = new System.Drawing.Size(198, 15);
            this.nameInputFilter.TabIndex = 3;
            this.nameInputFilter.TextChanged += new System.EventHandler(this.nameInputFilter_TextChanged);
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.dataGridPanel.Controls.Add(this.productsGridView);
            this.dataGridPanel.Location = new System.Drawing.Point(74, 188);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Padding = new System.Windows.Forms.Padding(1);
            this.dataGridPanel.Size = new System.Drawing.Size(841, 301);
            this.dataGridPanel.TabIndex = 0;
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToOrderColumns = true;
            this.productsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.ProductName,
            this.Details,
            this.Price});
            this.productsGridView.ContextMenuStrip = this.dataGridMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.productsGridView.Location = new System.Drawing.Point(4, 4);
            this.productsGridView.MultiSelect = false;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowTemplate.ReadOnly = true;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(833, 293);
            this.productsGridView.TabIndex = 2;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Codigo";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Nombre";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 240;
            // 
            // Details
            // 
            this.Details.DataPropertyName = "Details";
            this.Details.HeaderText = "Detalles";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 280;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Price.DefaultCellStyle = dataGridViewCellStyle2;
            this.Price.HeaderText = "Precio ($)";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 122;
            // 
            // dataGridMenu
            // 
            this.dataGridMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.dataGridMenu.Name = "dataGridMenu";
            this.dataGridMenu.Size = new System.Drawing.Size(130, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(105, 6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(202, 110);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.AutoSize = true;
            this.separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.separator.Location = new System.Drawing.Point(93, 119);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(800, 2);
            this.separator.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Models.Entities.Product);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 1);
            this.panel2.TabIndex = 15;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(988, 545);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titleBar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sembrarte";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInputFilter)).EndInit();
            this.dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.dataGridMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Panel dataGridPanel;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.TextBox codeInputFilter;
        private System.Windows.Forms.TextBox nameInputFilter;
        private System.Windows.Forms.NumericUpDown priceInputFilter;
        private System.Windows.Forms.Label lblPriceFilter;
        private System.Windows.Forms.Label lblNameFilter;
        private System.Windows.Forms.Label lblCodeFilter;
        private System.Windows.Forms.Label lblDetailsFilter;
        private System.Windows.Forms.TextBox detailsInputFilter;
        private System.Windows.Forms.ContextMenuStrip dataGridMenu;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.PictureBox addBtn;
        private System.Windows.Forms.PictureBox saveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

