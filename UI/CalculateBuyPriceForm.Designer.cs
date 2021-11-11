
namespace SembrarteApp
{
    partial class CalculateBuyPriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateBuyPriceForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.codeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ivaCheckBox = new System.Windows.Forms.CheckBox();
            this.porcentageInput = new System.Windows.Forms.NumericUpDown();
            this.lblPorcentage = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.logoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.separator = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porcentageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox1)).BeginInit();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            this.mainPanel.Controls.Add(this.codeComboBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.ivaCheckBox);
            this.mainPanel.Controls.Add(this.porcentageInput);
            this.mainPanel.Controls.Add(this.lblPorcentage);
            this.mainPanel.Controls.Add(this.lblCode);
            this.mainPanel.Controls.Add(this.btnCancel);
            this.mainPanel.Controls.Add(this.btnAccept);
            this.mainPanel.Controls.Add(this.logoPictureBox1);
            this.mainPanel.Controls.Add(this.separator);
            this.mainPanel.Location = new System.Drawing.Point(4, 49);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(543, 236);
            this.mainPanel.TabIndex = 6;
            // 
            // codeComboBox
            // 
            this.codeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.codeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Location = new System.Drawing.Point(30, 160);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(186, 26);
            this.codeComboBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(428, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "IVA (+21%)";
            // 
            // ivaCheckBox
            // 
            this.ivaCheckBox.AutoSize = true;
            this.ivaCheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ivaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ivaCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ivaCheckBox.Location = new System.Drawing.Point(457, 166);
            this.ivaCheckBox.Name = "ivaCheckBox";
            this.ivaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ivaCheckBox.TabIndex = 16;
            this.ivaCheckBox.UseVisualStyleBackColor = true;
            // 
            // porcentageInput
            // 
            this.porcentageInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.porcentageInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.porcentageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentageInput.ForeColor = System.Drawing.SystemColors.Window;
            this.porcentageInput.Location = new System.Drawing.Point(281, 162);
            this.porcentageInput.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.porcentageInput.Name = "porcentageInput";
            this.porcentageInput.Size = new System.Drawing.Size(92, 20);
            this.porcentageInput.TabIndex = 15;
            this.porcentageInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPorcentage
            // 
            this.lblPorcentage.AutoSize = true;
            this.lblPorcentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPorcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentage.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPorcentage.Location = new System.Drawing.Point(277, 135);
            this.lblPorcentage.Name = "lblPorcentage";
            this.lblPorcentage.Size = new System.Drawing.Size(106, 18);
            this.lblPorcentage.TabIndex = 14;
            this.lblPorcentage.Text = "Porcentaje (%)";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(87, 135);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(56, 18);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Codigo";
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
            this.logoPictureBox1.Location = new System.Drawing.Point(46, 8);
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
            this.separator.Location = new System.Drawing.Point(30, 87);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(474, 2);
            this.separator.TabIndex = 8;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(84)))), ((int)(((byte)(40)))));
            this.titleBar.Controls.Add(this.panel2);
            this.titleBar.Controls.Add(this.panel1);
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.btnMinimize);
            this.titleBar.Location = new System.Drawing.Point(4, 1);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(543, 53);
            this.titleBar.TabIndex = 5;
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
            this.panel2.Size = new System.Drawing.Size(543, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 1);
            this.panel1.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Aplicar Margen";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(512, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(480, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // CalculateBuyPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(199)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(551, 289);
            this.ControlBox = false;
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculateBuyPriceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calcular Costo";
            this.Load += new System.EventHandler(this.CalculateBuyPriceForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.porcentageInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox1)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox logoPictureBox1;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox codeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ivaCheckBox;
        private System.Windows.Forms.NumericUpDown porcentageInput;
        private System.Windows.Forms.Label lblPorcentage;
    }
}