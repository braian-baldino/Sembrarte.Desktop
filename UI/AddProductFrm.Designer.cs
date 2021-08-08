
namespace UI
{
    partial class AddProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductFrm));
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.codeInput = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.logoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Panel();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(299, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            this.titleBar.Controls.Add(this.panel2);
            this.titleBar.Controls.Add(this.panel1);
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.btnMinimize);
            this.titleBar.Location = new System.Drawing.Point(3, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(372, 51);
            this.titleBar.TabIndex = 2;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 1);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 1);
            this.panel1.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 16);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Agregar";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(335, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            this.mainPanel.Controls.Add(this.nameInput);
            this.mainPanel.Controls.Add(this.descriptionInput);
            this.mainPanel.Controls.Add(this.codeInput);
            this.mainPanel.Controls.Add(this.btnCancel);
            this.mainPanel.Controls.Add(this.btnAccept);
            this.mainPanel.Controls.Add(this.logoPictureBox1);
            this.mainPanel.Controls.Add(this.separator);
            this.mainPanel.Controls.Add(this.priceInput);
            this.mainPanel.Controls.Add(this.lblPrice);
            this.mainPanel.Controls.Add(this.lblName);
            this.mainPanel.Controls.Add(this.lblDescription);
            this.mainPanel.Controls.Add(this.lblCode);
            this.mainPanel.Location = new System.Drawing.Point(3, 44);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(372, 353);
            this.mainPanel.TabIndex = 0;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.ForeColor = System.Drawing.Color.White;
            this.nameInput.Location = new System.Drawing.Point(46, 181);
            this.nameInput.Multiline = true;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(221, 25);
            this.nameInput.TabIndex = 14;
            // 
            // descriptionInput
            // 
            this.descriptionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.descriptionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionInput.ForeColor = System.Drawing.Color.White;
            this.descriptionInput.Location = new System.Drawing.Point(45, 245);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(266, 22);
            this.descriptionInput.TabIndex = 13;
            // 
            // codeInput
            // 
            this.codeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.codeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeInput.ForeColor = System.Drawing.Color.White;
            this.codeInput.Location = new System.Drawing.Point(46, 121);
            this.codeInput.Name = "codeInput";
            this.codeInput.Size = new System.Drawing.Size(159, 22);
            this.codeInput.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(233, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(27, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(189, 31);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(27, 27);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "✔";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // logoPictureBox1
            // 
            this.logoPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox1.Image")));
            this.logoPictureBox1.Location = new System.Drawing.Point(46, 3);
            this.logoPictureBox1.Name = "logoPictureBox1";
            this.logoPictureBox1.Size = new System.Drawing.Size(97, 75);
            this.logoPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox1.TabIndex = 9;
            this.logoPictureBox1.TabStop = false;
            // 
            // separator
            // 
            this.separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separator.AutoSize = true;
            this.separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.separator.Location = new System.Drawing.Point(30, 82);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(313, 2);
            this.separator.TabIndex = 8;
            // 
            // priceInput
            // 
            this.priceInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.priceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceInput.DecimalPlaces = 2;
            this.priceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceInput.ForeColor = System.Drawing.Color.White;
            this.priceInput.Location = new System.Drawing.Point(47, 307);
            this.priceInput.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(83, 18);
            this.priceInput.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(44, 285);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 18);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Precio";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(44, 160);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 18);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(43, 224);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(61, 18);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Detalles";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(43, 99);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 18);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Codigo";
            // 
            // AddProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(378, 399);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.NumericUpDown priceInput;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox logoPictureBox1;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox codeInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}