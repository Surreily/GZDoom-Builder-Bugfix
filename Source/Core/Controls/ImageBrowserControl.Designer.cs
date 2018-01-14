namespace CodeImp.DoomBuilder.Controls
{
	partial class ImageBrowserControl
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
			if(disposing && (components != null))
			{
				CleanUp();
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.labelMixMode = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.list = new CodeImp.DoomBuilder.Controls.ImageSelectorPanel();
            this.filterColorIntensity = new System.Windows.Forms.TrackBar();
            this.filterColor = new System.Windows.Forms.Button();
            this.filterColorCheckBox = new System.Windows.Forms.CheckBox();
            this.classicview = new System.Windows.Forms.CheckBox();
            this.objectclear = new System.Windows.Forms.Button();
            this.sizecombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usedtexturesfirst = new System.Windows.Forms.CheckBox();
            this.longtexturenames = new System.Windows.Forms.CheckBox();
            this.filterheightlabel = new System.Windows.Forms.Label();
            this.filterHeight = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.filterwidthlabel = new System.Windows.Forms.Label();
            this.filterWidth = new CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox();
            this.texturetypecombo = new System.Windows.Forms.ComboBox();
            this.objectname = new System.Windows.Forms.TextBox();
            this.refreshtimer = new System.Windows.Forms.Timer(this.components);
            this.filterColorDialog = new System.Windows.Forms.ColorDialog();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterColorIntensity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMixMode
            // 
            this.labelMixMode.AutoSize = true;
            this.labelMixMode.Location = new System.Drawing.Point(4, 12);
            this.labelMixMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMixMode.Name = "labelMixMode";
            this.labelMixMode.Size = new System.Drawing.Size(53, 20);
            this.labelMixMode.TabIndex = 0;
            this.labelMixMode.Text = "Show:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(246, 14);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Filter:";
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitter.IsSplitterFixed = true;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Margin = new System.Windows.Forms.Padding(4);
            this.splitter.Name = "splitter";
            this.splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.list);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.filterColorIntensity);
            this.splitter.Panel2.Controls.Add(this.filterColor);
            this.splitter.Panel2.Controls.Add(this.filterColorCheckBox);
            this.splitter.Panel2.Controls.Add(this.classicview);
            this.splitter.Panel2.Controls.Add(this.objectclear);
            this.splitter.Panel2.Controls.Add(this.sizecombo);
            this.splitter.Panel2.Controls.Add(this.label1);
            this.splitter.Panel2.Controls.Add(this.usedtexturesfirst);
            this.splitter.Panel2.Controls.Add(this.longtexturenames);
            this.splitter.Panel2.Controls.Add(this.filterheightlabel);
            this.splitter.Panel2.Controls.Add(this.filterHeight);
            this.splitter.Panel2.Controls.Add(this.filterwidthlabel);
            this.splitter.Panel2.Controls.Add(this.filterWidth);
            this.splitter.Panel2.Controls.Add(this.texturetypecombo);
            this.splitter.Panel2.Controls.Add(this.labelMixMode);
            this.splitter.Panel2.Controls.Add(this.objectname);
            this.splitter.Panel2.Controls.Add(this.label);
            this.splitter.Size = new System.Drawing.Size(1260, 519);
            this.splitter.SplitterDistance = 333;
            this.splitter.SplitterWidth = 6;
            this.splitter.TabIndex = 0;
            this.splitter.TabStop = false;
            // 
            // list
            // 
            this.list.AutoScroll = true;
            this.list.BackColor = System.Drawing.Color.White;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list.ClassicView = false;
            this.list.ContentType = "Textures";
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.HideSelection = false;
            this.list.ImageSize = 128;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Margin = new System.Windows.Forms.Padding(4);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(1260, 333);
            this.list.TabIndex = 1;
            this.list.Title = "Default group";
            this.list.UsedTexturesFirst = false;
            this.list.ItemDoubleClicked += new CodeImp.DoomBuilder.Controls.ImageSelectorPanel.ItemSelectedEventHandler(this.list_ItemDoubleClicked);
            this.list.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.list_KeyPress);
            // 
            // filterColorIntensity
            // 
            this.filterColorIntensity.Location = new System.Drawing.Point(943, 48);
            this.filterColorIntensity.Maximum = 200;
            this.filterColorIntensity.Minimum = 50;
            this.filterColorIntensity.Name = "filterColorIntensity";
            this.filterColorIntensity.Size = new System.Drawing.Size(191, 69);
            this.filterColorIntensity.TabIndex = 7;
            this.filterColorIntensity.TickFrequency = 10;
            this.filterColorIntensity.Value = 100;
            this.filterColorIntensity.Scroll += new System.EventHandler(this.filterColorIntensity_Scroll);
            // 
            // filterColor
            // 
            this.filterColor.Location = new System.Drawing.Point(882, 50);
            this.filterColor.Name = "filterColor";
            this.filterColor.Size = new System.Drawing.Size(55, 27);
            this.filterColor.TabIndex = 6;
            this.filterColor.UseVisualStyleBackColor = true;
            this.filterColor.Click += new System.EventHandler(this.filterColor_Click);
            // 
            // filterColorCheckBox
            // 
            this.filterColorCheckBox.AutoSize = true;
            this.filterColorCheckBox.Location = new System.Drawing.Point(765, 52);
            this.filterColorCheckBox.Name = "filterColorCheckBox";
            this.filterColorCheckBox.Size = new System.Drawing.Size(111, 24);
            this.filterColorCheckBox.TabIndex = 5;
            this.filterColorCheckBox.Text = "Filter Color";
            this.filterColorCheckBox.UseVisualStyleBackColor = true;
            this.filterColorCheckBox.CheckedChanged += new System.EventHandler(this.filterColorCheckBox_CheckedChanged);
            // 
            // classicview
            // 
            this.classicview.AutoSize = true;
            this.classicview.Location = new System.Drawing.Point(765, 12);
            this.classicview.Margin = new System.Windows.Forms.Padding(4);
            this.classicview.Name = "classicview";
            this.classicview.Size = new System.Drawing.Size(119, 24);
            this.classicview.TabIndex = 4;
            this.classicview.TabStop = false;
            this.classicview.Text = "Classic view";
            this.classicview.UseVisualStyleBackColor = true;
            this.classicview.CheckedChanged += new System.EventHandler(this.classicview_CheckedChanged);
            // 
            // objectclear
            // 
            this.objectclear.Image = global::CodeImp.DoomBuilder.Properties.Resources.Close;
            this.objectclear.Location = new System.Drawing.Point(495, 6);
            this.objectclear.Margin = new System.Windows.Forms.Padding(4);
            this.objectclear.Name = "objectclear";
            this.objectclear.Size = new System.Drawing.Size(39, 34);
            this.objectclear.TabIndex = 3;
            this.objectclear.TabStop = false;
            this.objectclear.UseVisualStyleBackColor = true;
            this.objectclear.Click += new System.EventHandler(this.objectclear_Click);
            // 
            // sizecombo
            // 
            this.sizecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizecombo.FormattingEnabled = true;
            this.sizecombo.Items.AddRange(new object[] {
            "1:1",
            "64",
            "80",
            "96",
            "128",
            "192",
            "256"});
            this.sizecombo.Location = new System.Drawing.Point(64, 48);
            this.sizecombo.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.sizecombo.Name = "sizecombo";
            this.sizecombo.Size = new System.Drawing.Size(158, 28);
            this.sizecombo.TabIndex = 2;
            this.sizecombo.TabStop = false;
            this.sizecombo.SelectedIndexChanged += new System.EventHandler(this.sizecombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size:";
            // 
            // usedtexturesfirst
            // 
            this.usedtexturesfirst.AutoSize = true;
            this.usedtexturesfirst.Location = new System.Drawing.Point(548, 12);
            this.usedtexturesfirst.Margin = new System.Windows.Forms.Padding(4);
            this.usedtexturesfirst.Name = "usedtexturesfirst";
            this.usedtexturesfirst.Size = new System.Drawing.Size(206, 24);
            this.usedtexturesfirst.TabIndex = 0;
            this.usedtexturesfirst.TabStop = false;
            this.usedtexturesfirst.Text = "Used textures at the top";
            this.usedtexturesfirst.UseVisualStyleBackColor = true;
            this.usedtexturesfirst.CheckedChanged += new System.EventHandler(this.usedtexturesfirst_CheckedChanged);
            // 
            // longtexturenames
            // 
            this.longtexturenames.AutoSize = true;
            this.longtexturenames.Location = new System.Drawing.Point(548, 51);
            this.longtexturenames.Margin = new System.Windows.Forms.Padding(4);
            this.longtexturenames.Name = "longtexturenames";
            this.longtexturenames.Size = new System.Drawing.Size(176, 24);
            this.longtexturenames.TabIndex = 0;
            this.longtexturenames.TabStop = false;
            this.longtexturenames.Text = "Long texture names";
            this.longtexturenames.UseVisualStyleBackColor = true;
            this.longtexturenames.CheckedChanged += new System.EventHandler(this.longtexturenames_CheckedChanged);
            // 
            // filterheightlabel
            // 
            this.filterheightlabel.AutoSize = true;
            this.filterheightlabel.Location = new System.Drawing.Point(387, 52);
            this.filterheightlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterheightlabel.Name = "filterheightlabel";
            this.filterheightlabel.Size = new System.Drawing.Size(60, 20);
            this.filterheightlabel.TabIndex = 0;
            this.filterheightlabel.Text = "Height:";
            // 
            // filterHeight
            // 
            this.filterHeight.AllowDecimal = false;
            this.filterHeight.AllowExpressions = false;
            this.filterHeight.AllowNegative = false;
            this.filterHeight.AllowRelative = false;
            this.filterHeight.ButtonStep = 1;
            this.filterHeight.ButtonStepBig = 10F;
            this.filterHeight.ButtonStepFloat = 1F;
            this.filterHeight.ButtonStepSmall = 0.1F;
            this.filterHeight.ButtonStepsUseModifierKeys = false;
            this.filterHeight.ButtonStepsWrapAround = false;
            this.filterHeight.Location = new System.Drawing.Point(452, 45);
            this.filterHeight.Margin = new System.Windows.Forms.Padding(6);
            this.filterHeight.Name = "filterHeight";
            this.filterHeight.Size = new System.Drawing.Size(81, 30);
            this.filterHeight.StepValues = null;
            this.filterHeight.TabIndex = 0;
            this.filterHeight.TabStop = false;
            this.filterHeight.WhenTextChanged += new System.EventHandler(this.filterSize_WhenTextChanged);
            // 
            // filterwidthlabel
            // 
            this.filterwidthlabel.AutoSize = true;
            this.filterwidthlabel.Location = new System.Drawing.Point(238, 52);
            this.filterwidthlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterwidthlabel.Name = "filterwidthlabel";
            this.filterwidthlabel.Size = new System.Drawing.Size(54, 20);
            this.filterwidthlabel.TabIndex = 0;
            this.filterwidthlabel.Text = "Width:";
            // 
            // filterWidth
            // 
            this.filterWidth.AllowDecimal = false;
            this.filterWidth.AllowExpressions = false;
            this.filterWidth.AllowNegative = false;
            this.filterWidth.AllowRelative = false;
            this.filterWidth.ButtonStep = 1;
            this.filterWidth.ButtonStepBig = 10F;
            this.filterWidth.ButtonStepFloat = 1F;
            this.filterWidth.ButtonStepSmall = 0.1F;
            this.filterWidth.ButtonStepsUseModifierKeys = false;
            this.filterWidth.ButtonStepsWrapAround = false;
            this.filterWidth.Location = new System.Drawing.Point(298, 45);
            this.filterWidth.Margin = new System.Windows.Forms.Padding(6);
            this.filterWidth.Name = "filterWidth";
            this.filterWidth.Size = new System.Drawing.Size(81, 30);
            this.filterWidth.StepValues = null;
            this.filterWidth.TabIndex = 0;
            this.filterWidth.TabStop = false;
            this.filterWidth.WhenTextChanged += new System.EventHandler(this.filterSize_WhenTextChanged);
            // 
            // texturetypecombo
            // 
            this.texturetypecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texturetypecombo.FormattingEnabled = true;
            this.texturetypecombo.Items.AddRange(new object[] {
            "All",
            "Textures",
            "Flats",
            "By selection type"});
            this.texturetypecombo.Location = new System.Drawing.Point(64, 8);
            this.texturetypecombo.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.texturetypecombo.Name = "texturetypecombo";
            this.texturetypecombo.Size = new System.Drawing.Size(158, 28);
            this.texturetypecombo.TabIndex = 0;
            this.texturetypecombo.TabStop = false;
            this.texturetypecombo.SelectedIndexChanged += new System.EventHandler(this.texturetypecombo_SelectedIndexChanged);
            // 
            // objectname
            // 
            this.objectname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.objectname.HideSelection = false;
            this.objectname.Location = new System.Drawing.Point(298, 9);
            this.objectname.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.objectname.Name = "objectname";
            this.objectname.Size = new System.Drawing.Size(190, 26);
            this.objectname.TabIndex = 0;
            this.objectname.TabStop = false;
            this.objectname.TextChanged += new System.EventHandler(this.objectname_TextChanged);
            this.objectname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.objectname_KeyDown);
            // 
            // refreshtimer
            // 
            this.refreshtimer.Interval = 500;
            this.refreshtimer.Tick += new System.EventHandler(this.refreshtimer_Tick);
            // 
            // ImageBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageBrowserControl";
            this.Size = new System.Drawing.Size(1260, 519);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.Panel2.PerformLayout();
            this.splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterColorIntensity)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitter;
		private CodeImp.DoomBuilder.Controls.ImageSelectorPanel list;
		private System.Windows.Forms.Timer refreshtimer;
		private System.Windows.Forms.TextBox objectname;
		private System.Windows.Forms.ComboBox texturetypecombo;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label labelMixMode;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox filterWidth;
		private System.Windows.Forms.Label filterheightlabel;
		private CodeImp.DoomBuilder.Controls.ButtonsNumericTextbox filterHeight;
		private System.Windows.Forms.Label filterwidthlabel;
		private System.Windows.Forms.CheckBox longtexturenames;
		private System.Windows.Forms.CheckBox usedtexturesfirst;
		private System.Windows.Forms.ComboBox sizecombo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button objectclear;
        private System.Windows.Forms.CheckBox classicview;
        private System.Windows.Forms.Button filterColor;
        private System.Windows.Forms.CheckBox filterColorCheckBox;
        private System.Windows.Forms.ColorDialog filterColorDialog;
        private System.Windows.Forms.TrackBar filterColorIntensity;
    }
}
