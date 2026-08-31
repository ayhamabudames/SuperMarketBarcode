namespace Barcode
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cuiFileDropper1 = new HartUI.Controls.cuiFileDropper();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.cuiFormAnimator1 = new HartUI.Components.cuiFormAnimator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnUseCamera = new HartUI.Controls.cuiSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnAllInfo = new HartUI.Controls.cuiSwitch();
            this.cuiResizeGrip1 = new HartUI.Controls.cuiResizeGrip();
            this.cuiSeparator1 = new HartUI.Controls.cuiSeparator();
            this.cuiTitleBarCustomizer1 = new HartUI.Components.cuiTitleBarCustomizer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.lblTitlePrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.cbCameras = new HartUI.Controls.cuiComboBox();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiFileDropper1
            // 
            this.cuiFileDropper1.AllowDrop = true;
            this.cuiFileDropper1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiFileDropper1.DashedOutline = true;
            this.cuiFileDropper1.DashedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiFileDropper1.DashLength = 8;
            this.cuiFileDropper1.Filter = "";
            this.cuiFileDropper1.ForeColor = System.Drawing.Color.Gray;
            this.cuiFileDropper1.HoverContent = "Release to drop";
            this.cuiFileDropper1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiFileDropper1.HoverUploadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(24)))), ((int)(((byte)(226)))));
            this.cuiFileDropper1.Image = ((System.Drawing.Image)(resources.GetObject("cuiFileDropper1.Image")));
            this.cuiFileDropper1.ImagePadding = 2;
            this.cuiFileDropper1.ImageSize = new System.Drawing.Size(24, 24);
            this.cuiFileDropper1.ImageTint = System.Drawing.Color.Gray;
            this.cuiFileDropper1.Location = new System.Drawing.Point(458, 243);
            this.cuiFileDropper1.Multiselect = false;
            this.cuiFileDropper1.Name = "cuiFileDropper1";
            this.cuiFileDropper1.NormalContent = "Drop file here";
            this.cuiFileDropper1.NormalForeColor = System.Drawing.Color.Gray;
            this.cuiFileDropper1.NormalUploadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(24)))), ((int)(((byte)(226)))));
            this.cuiFileDropper1.OutlineThickness = 1F;
            this.cuiFileDropper1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFileDropper1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiFileDropper1.Size = new System.Drawing.Size(100, 100);
            this.cuiFileDropper1.TabIndex = 1;
            this.cuiFileDropper1.Text = "cuiFileDropper1";
            this.cuiFileDropper1.UploadContent = "Click to upload";
            this.cuiFileDropper1.UploadWithClick = true;
            this.cuiFileDropper1.FileDropped += new System.EventHandler<HartUI.Controls.FileDroppedEventArgs>(this.cuiFileDropper1_FileDropped);
            // 
            // pbBarcode
            // 
            this.pbBarcode.Image = global::Barcode.Properties.Resources._8401_white_tree;
            this.pbBarcode.Location = new System.Drawing.Point(185, 12);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(373, 136);
            this.pbBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarcode.TabIndex = 2;
            this.pbBarcode.TabStop = false;
            // 
            // cuiFormAnimator1
            // 
            this.cuiFormAnimator1.AnimateOnStart = true;
            this.cuiFormAnimator1.Duration = 1000;
            this.cuiFormAnimator1.EasingType = HartUI.Helpers.DrawingHelper.EasingTypes.QuadOut;
            this.cuiFormAnimator1.StartOpacity = 0D;
            this.cuiFormAnimator1.TargetForm = this;
            this.cuiFormAnimator1.TargetOpacity = 1D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Use Camera ? ";
            // 
            // rbtnUseCamera
            // 
            this.rbtnUseCamera.Checked = false;
            this.rbtnUseCamera.CheckedBackground = System.Drawing.Color.LawnGreen;
            this.rbtnUseCamera.CheckedForeground = System.Drawing.Color.White;
            this.rbtnUseCamera.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.rbtnUseCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnUseCamera.Location = new System.Drawing.Point(124, 293);
            this.rbtnUseCamera.MinimumSize = new System.Drawing.Size(12, 8);
            this.rbtnUseCamera.Name = "rbtnUseCamera";
            this.rbtnUseCamera.OutlineThickness = 1F;
            this.rbtnUseCamera.Size = new System.Drawing.Size(48, 26);
            this.rbtnUseCamera.TabIndex = 5;
            this.rbtnUseCamera.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.rbtnUseCamera.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbtnUseCamera.UncheckedForeground = System.Drawing.Color.White;
            this.rbtnUseCamera.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.rbtnUseCamera.CheckedChanged += new System.EventHandler(this.rbtnUseCamera_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "All Info ? ";
            // 
            // rbtnAllInfo
            // 
            this.rbtnAllInfo.Checked = true;
            this.rbtnAllInfo.CheckedBackground = System.Drawing.Color.LawnGreen;
            this.rbtnAllInfo.CheckedForeground = System.Drawing.Color.White;
            this.rbtnAllInfo.CheckedOutlineColor = System.Drawing.Color.Empty;
            this.rbtnAllInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAllInfo.Location = new System.Drawing.Point(124, 321);
            this.rbtnAllInfo.MinimumSize = new System.Drawing.Size(12, 8);
            this.rbtnAllInfo.Name = "rbtnAllInfo";
            this.rbtnAllInfo.OutlineThickness = 1F;
            this.rbtnAllInfo.Size = new System.Drawing.Size(48, 26);
            this.rbtnAllInfo.TabIndex = 7;
            this.rbtnAllInfo.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.rbtnAllInfo.UncheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbtnAllInfo.UncheckedForeground = System.Drawing.Color.White;
            this.rbtnAllInfo.UncheckedOutlineColor = System.Drawing.Color.Empty;
            this.rbtnAllInfo.CheckedChanged += new System.EventHandler(this.rbtnAllInfo_CheckedChanged);
            // 
            // cuiResizeGrip1
            // 
            this.cuiResizeGrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip1.GripColor = System.Drawing.Color.Gray;
            this.cuiResizeGrip1.GripSize = 2;
            this.cuiResizeGrip1.GripTexture = true;
            this.cuiResizeGrip1.Location = new System.Drawing.Point(552, 341);
            this.cuiResizeGrip1.Name = "cuiResizeGrip1";
            this.cuiResizeGrip1.Size = new System.Drawing.Size(24, 24);
            this.cuiResizeGrip1.SkipBottomRightSquare = false;
            this.cuiResizeGrip1.TabIndex = 9;
            this.cuiResizeGrip1.TabStop = false;
            this.cuiResizeGrip1.TargetForm = null;
            this.cuiResizeGrip1.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(-5, 264);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(285, 23);
            this.cuiSeparator1.TabIndex = 10;
            this.cuiSeparator1.TabStop = false;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
            // 
            // cuiTitleBarCustomizer1
            // 
            this.cuiTitleBarCustomizer1.DarkMode = false;
            this.cuiTitleBarCustomizer1.TargetForm = this;
            this.cuiTitleBarCustomizer1.TitleBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cuiTitleBarCustomizer1.TitleBarTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Code : ";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleName.Location = new System.Drawing.Point(8, 201);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(63, 20);
            this.lblTitleName.TabIndex = 12;
            this.lblTitleName.Text = "Name : ";
            // 
            // lblTitlePrice
            // 
            this.lblTitlePrice.AutoSize = true;
            this.lblTitlePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePrice.Location = new System.Drawing.Point(8, 239);
            this.lblTitlePrice.Name = "lblTitlePrice";
            this.lblTitlePrice.Size = new System.Drawing.Size(56, 20);
            this.lblTitlePrice.TabIndex = 13;
            this.lblTitlePrice.Text = "Price : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(71, 239);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "[???]";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(71, 201);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "[???]";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(71, 164);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(49, 20);
            this.lblCode.TabIndex = 14;
            this.lblCode.Text = "[???]";
            this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // cbCameras
            // 
            this.cbCameras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCameras.DropDownBackgroundColor = System.Drawing.Color.White;
            this.cbCameras.DropDownForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.cbCameras.ExpandArrowColor = System.Drawing.Color.Gray;
            this.cbCameras.ForeColor = System.Drawing.Color.Gray;
            this.cbCameras.ItemHeight = 32;
            this.cbCameras.Items = new string[] {
        "",
        "",
        ""};
            this.cbCameras.Location = new System.Drawing.Point(185, 317);
            this.cbCameras.MaxDropDownHeight = 240;
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.NoSelectionText = "None";
            this.cbCameras.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cbCameras.OutlineThickness = 1F;
            this.cbCameras.Rounding = 8;
            this.cbCameras.SelectedIndex = -1;
            this.cbCameras.SelectedItem = "";
            this.cbCameras.Size = new System.Drawing.Size(129, 30);
            this.cbCameras.SortAlphabetically = true;
            this.cbCameras.TabIndex = 17;
            // 
            // pbProductImage
            // 
            this.pbProductImage.Image = global::Barcode.Properties.Resources.products;
            this.pbProductImage.Location = new System.Drawing.Point(16, 12);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(140, 140);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 18;
            this.pbProductImage.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 364);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.cbCameras);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblTitlePrice);
            this.Controls.Add(this.lblTitleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cuiSeparator1);
            this.Controls.Add(this.cuiResizeGrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnAllInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnUseCamera);
            this.Controls.Add(this.pbBarcode);
            this.Controls.Add(this.cuiFileDropper1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Barcode Reader";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HartUI.Controls.cuiFileDropper cuiFileDropper1;
        private System.Windows.Forms.PictureBox pbBarcode;
        private HartUI.Components.cuiFormAnimator cuiFormAnimator1;
        private System.Windows.Forms.Label label1;
        private HartUI.Controls.cuiSwitch rbtnUseCamera;
        private System.Windows.Forms.Label lblTitlePrice;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Label label3;
        private HartUI.Controls.cuiSeparator cuiSeparator1;
        private HartUI.Controls.cuiResizeGrip cuiResizeGrip1;
        private System.Windows.Forms.Label label2;
        private HartUI.Controls.cuiSwitch rbtnAllInfo;
        protected HartUI.Components.cuiTitleBarCustomizer cuiTitleBarCustomizer1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private HartUI.Controls.cuiComboBox cbCameras;
        private System.Windows.Forms.PictureBox pbProductImage;
    }
}

