﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedColourControls.UX
{
    public class ScreenColourPickerWindow : KryptonForm
    {
        #region Designer Code
        private KryptonSplitContainer kryptonSplitContainer1;
        private Cyotek.Windows.Forms.ScreenColorPicker scpColour;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbSelectedColour;
        private KryptonPanel kryptonPanel1;
        private Controls.Labels.KryptonBlueValueLabel kryptonBlueValueLabel1;
        private KryptonToolkitSuiteExtendedCore.KryptonKnobControl kknbBlue;
        private KryptonToolkitSuiteExtendedCore.KryptonKnobControl kknbGreen;
        private Controls.Labels.KryptonGreenValueLabel kryptonGreenValueLabel1;
        private KryptonToolkitSuiteExtendedCore.KryptonKnobControl kknbRed;
        private Controls.Labels.KryptonRedValueLabel kryptonRedValueLabel1;
        private KryptonBlueValueNumericBox knumBlue;
        private KryptonGreenValueNumericBox knumGreen;
        private KryptonRedValueNumericBox knumRed;
        private KryptonPanel kryptonPanel2;
        private KryptonLabel klblHexValue;
        private KryptonButton kbtnOk;
        private Panel panel1;
        private KryptonButton kbtnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenColourPickerWindow));
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.klblHexValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.scpColour = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.cpbSelectedColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.knumBlue = new ExtendedColourControls.KryptonBlueValueNumericBox();
            this.knumGreen = new ExtendedColourControls.KryptonGreenValueNumericBox();
            this.knumRed = new ExtendedColourControls.KryptonRedValueNumericBox();
            this.kryptonBlueValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonBlueValueLabel();
            this.kknbBlue = new KryptonToolkitSuiteExtendedCore.KryptonKnobControl();
            this.kknbGreen = new KryptonToolkitSuiteExtendedCore.KryptonKnobControl();
            this.kryptonGreenValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonGreenValueLabel();
            this.kknbRed = new KryptonToolkitSuiteExtendedCore.KryptonKnobControl();
            this.kryptonRedValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonRedValueLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbSelectedColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.klblHexValue);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.scpColour);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.cpbSelectedColour);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonPanel1);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(477, 507);
            this.kryptonSplitContainer1.SplitterDistance = 172;
            this.kryptonSplitContainer1.TabIndex = 4;
            // 
            // klblHexValue
            // 
            this.klblHexValue.Location = new System.Drawing.Point(18, 282);
            this.klblHexValue.Name = "klblHexValue";
            this.klblHexValue.Size = new System.Drawing.Size(6, 2);
            this.klblHexValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHexValue.TabIndex = 1;
            this.klblHexValue.Values.Text = "";
            // 
            // scpColour
            // 
            this.scpColour.Color = System.Drawing.Color.Empty;
            this.scpColour.Image = global::ExtendedColourControls.Properties.Resources.dropper;
            this.scpColour.Location = new System.Drawing.Point(18, 154);
            this.scpColour.Name = "scpColour";
            this.scpColour.ShowGrid = false;
            this.scpColour.ShowTextWithSnapshot = true;
            this.scpColour.Size = new System.Drawing.Size(115, 112);
            this.scpColour.ColorChanged += new System.EventHandler(this.scpColour_ColorChanged);
            // 
            // cpbSelectedColour
            // 
            this.cpbSelectedColour.BackColor = System.Drawing.SystemColors.Control;
            this.cpbSelectedColour.Location = new System.Drawing.Point(18, 14);
            this.cpbSelectedColour.Name = "cpbSelectedColour";
            this.cpbSelectedColour.Size = new System.Drawing.Size(115, 115);
            this.cpbSelectedColour.TabIndex = 0;
            this.cpbSelectedColour.TabStop = false;
            this.cpbSelectedColour.ToolTipValues = null;
            this.cpbSelectedColour.BackColorChanged += new System.EventHandler(this.cpbSelectedColour_BackColorChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.knumBlue);
            this.kryptonPanel1.Controls.Add(this.knumGreen);
            this.kryptonPanel1.Controls.Add(this.knumRed);
            this.kryptonPanel1.Controls.Add(this.kryptonBlueValueLabel1);
            this.kryptonPanel1.Controls.Add(this.kknbBlue);
            this.kryptonPanel1.Controls.Add(this.kknbGreen);
            this.kryptonPanel1.Controls.Add(this.kryptonGreenValueLabel1);
            this.kryptonPanel1.Controls.Add(this.kknbRed);
            this.kryptonPanel1.Controls.Add(this.kryptonRedValueLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(300, 507);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // knumBlue
            // 
            this.knumBlue.Location = new System.Drawing.Point(224, 366);
            this.knumBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBlue.Name = "knumBlue";
            this.knumBlue.Size = new System.Drawing.Size(64, 26);
            this.knumBlue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBlue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBlue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumBlue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBlue.TabIndex = 31;
            this.knumBlue.ValueChanged += new System.EventHandler(this.knumBlue_ValueChanged);
            // 
            // knumGreen
            // 
            this.knumGreen.Location = new System.Drawing.Point(224, 211);
            this.knumGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreen.Name = "knumGreen";
            this.knumGreen.Size = new System.Drawing.Size(64, 26);
            this.knumGreen.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.knumGreen.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumGreen.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumGreen.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumGreen.TabIndex = 30;
            this.knumGreen.ValueChanged += new System.EventHandler(this.knumGreen_ValueChanged);
            // 
            // knumRed
            // 
            this.knumRed.Location = new System.Drawing.Point(224, 62);
            this.knumRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumRed.Name = "knumRed";
            this.knumRed.Size = new System.Drawing.Size(64, 26);
            this.knumRed.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumRed.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumRed.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumRed.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumRed.TabIndex = 29;
            this.knumRed.ValueChanged += new System.EventHandler(this.knumRed_ValueChanged);
            // 
            // kryptonBlueValueLabel1
            // 
            this.kryptonBlueValueLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonBlueValueLabel1.Location = new System.Drawing.Point(42, 366);
            this.kryptonBlueValueLabel1.Name = "kryptonBlueValueLabel1";
            this.kryptonBlueValueLabel1.RedValue = 255;
            this.kryptonBlueValueLabel1.Size = new System.Drawing.Size(46, 26);
            this.kryptonBlueValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.TabIndex = 27;
            this.kryptonBlueValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.Values.Text = "Blue";
            // 
            // kknbBlue
            // 
            this.kknbBlue.BackColor = System.Drawing.Color.Transparent;
            this.kknbBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kknbBlue.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kknbBlue.LargeChange = 20;
            this.kknbBlue.Location = new System.Drawing.Point(103, 324);
            this.kknbBlue.Maximum = 255;
            this.kknbBlue.Minimum = 0;
            this.kknbBlue.Name = "kknbBlue";
            this.kknbBlue.ShowLargeScale = true;
            this.kknbBlue.ShowSmallScale = false;
            this.kknbBlue.Size = new System.Drawing.Size(110, 110);
            this.kknbBlue.SizeLargeScaleMarker = 6;
            this.kknbBlue.SizeSmallScaleMarker = 3;
            this.kknbBlue.SmallChange = 5;
            this.kknbBlue.TabIndex = 22;
            this.kknbBlue.Value = 0;
            this.kknbBlue.ValueChanged += new KryptonToolkitSuiteExtendedCore.ValueChangedEventHandler(this.kknbBlue_ValueChanged);
            // 
            // kknbGreen
            // 
            this.kknbGreen.BackColor = System.Drawing.Color.Transparent;
            this.kknbGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kknbGreen.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kknbGreen.LargeChange = 20;
            this.kknbGreen.Location = new System.Drawing.Point(103, 171);
            this.kknbGreen.Maximum = 255;
            this.kknbGreen.Minimum = 0;
            this.kknbGreen.Name = "kknbGreen";
            this.kknbGreen.ShowLargeScale = true;
            this.kknbGreen.ShowSmallScale = false;
            this.kknbGreen.Size = new System.Drawing.Size(110, 110);
            this.kknbGreen.SizeLargeScaleMarker = 6;
            this.kknbGreen.SizeSmallScaleMarker = 3;
            this.kknbGreen.SmallChange = 5;
            this.kknbGreen.TabIndex = 21;
            this.kknbGreen.Value = 0;
            this.kknbGreen.ValueChanged += new KryptonToolkitSuiteExtendedCore.ValueChangedEventHandler(this.kknbGreen_ValueChanged);
            // 
            // kryptonGreenValueLabel1
            // 
            this.kryptonGreenValueLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGreenValueLabel1.Location = new System.Drawing.Point(30, 211);
            this.kryptonGreenValueLabel1.Name = "kryptonGreenValueLabel1";
            this.kryptonGreenValueLabel1.RedValue = 255;
            this.kryptonGreenValueLabel1.Size = new System.Drawing.Size(58, 26);
            this.kryptonGreenValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.TabIndex = 25;
            this.kryptonGreenValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.Values.Text = "Green";
            // 
            // kknbRed
            // 
            this.kknbRed.BackColor = System.Drawing.Color.Transparent;
            this.kknbRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kknbRed.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kknbRed.LargeChange = 20;
            this.kknbRed.Location = new System.Drawing.Point(103, 18);
            this.kknbRed.Maximum = 255;
            this.kknbRed.Minimum = 0;
            this.kknbRed.Name = "kknbRed";
            this.kknbRed.ShowLargeScale = true;
            this.kknbRed.ShowSmallScale = false;
            this.kknbRed.Size = new System.Drawing.Size(110, 110);
            this.kknbRed.SizeLargeScaleMarker = 6;
            this.kknbRed.SizeSmallScaleMarker = 3;
            this.kknbRed.SmallChange = 5;
            this.kknbRed.TabIndex = 20;
            this.kknbRed.Value = 0;
            this.kknbRed.ValueChanged += new KryptonToolkitSuiteExtendedCore.ValueChangedEventHandler(this.kknbRed_ValueChanged);
            // 
            // kryptonRedValueLabel1
            // 
            this.kryptonRedValueLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonRedValueLabel1.Location = new System.Drawing.Point(46, 62);
            this.kryptonRedValueLabel1.Name = "kryptonRedValueLabel1";
            this.kryptonRedValueLabel1.RedValue = 255;
            this.kryptonRedValueLabel1.Size = new System.Drawing.Size(42, 26);
            this.kryptonRedValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.TabIndex = 23;
            this.kryptonRedValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.Values.Text = "Red";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnOk);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 456);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(477, 51);
            this.kryptonPanel2.TabIndex = 5;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Location = new System.Drawing.Point(279, 14);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 25);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 1;
            this.kbtnOk.Values.Text = "O&k";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(375, 14);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 3);
            this.panel1.TabIndex = 6;
            // 
            // ScreenColourPickerWindow
            // 
            this.ClientSize = new System.Drawing.Size(477, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenColourPickerWindow";
            this.Text = "Screen Colour Picker";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpbSelectedColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private Color _knobForeColour, _knobBackColour, _knobBorderColour, _knobColour, _knobTrackingColour, _colour;

        private IPalette _palette;
        #endregion

        #region Properties
        public Color KnobForeColour { get => _knobForeColour; set { _knobForeColour = value; Invalidate(); } }

        public Color KnobBackColour { get => _knobBackColour; set { _knobBackColour = value; Invalidate(); } }

        public Color KnobBorderColour { get => _knobBorderColour; set { _knobBorderColour = value; Invalidate(); } }

        public Color KnobColour { get => _knobColour; set { _knobColour = value; Invalidate(); } }

        public Color KnobTrackingColour { get => _knobTrackingColour; set { _knobTrackingColour = value; Invalidate(); } }

        public Color Colour { get => _colour; set { _colour = value; OnSelectedColourChanged(value); Invalidate(); } }
        #endregion

        public delegate void SelectedColourChangedEventHandler(object sender, EventArgs e);

        public event SelectedColourChangedEventHandler SelectedColourChanged;

        #region Enumerations
        private enum ColourChannelLabel
        {
            BLUELABEL,
            GREENLABEL,
            REDLABEL
        }
        #endregion

        #region Constructor
        public ScreenColourPickerWindow()
        {
            InitializeComponent();

            InitialiseWindow();
        }
        #endregion

        #region Methods
        private void AlterLabel(ColourChannelLabel colourChannel, int value)
        {
            switch (colourChannel)
            {
                case ColourChannelLabel.BLUELABEL:
                    knumBlue.Value = value;
                    break;
                case ColourChannelLabel.GREENLABEL:
                    knumGreen.Value = value;
                    break;
                case ColourChannelLabel.REDLABEL:
                    knumRed.Value = value;
                    break;
            }
        }

        private void InitialiseWindow()
        {
            knumRed.Value = kknbRed.Value;

            knumGreen.Value = kknbGreen.Value;

            knumBlue.Value = kknbBlue.Value;

           klblHexValue.Text = string.Empty;

            cpbSelectedColour.BackColor = Color.Transparent;
        }

        private string GetHexColourValue(Color colour) => ColorTranslator.ToHtml(colour);

        private void UpdateColourValues(Color colour, bool useKnobs = true)
        {
            if (useKnobs)
            {
                kknbBlue.Value = colour.B;

                kknbGreen.Value = colour.G;

                kknbRed.Value = colour.R;
            }
            else
            {
                UpdateLabelValues(colour.R, colour.G, colour.B);
            }
        }

        private void UpdateLabelValues(byte r, byte g, byte b)
        {
            knumBlue.Value = b;

            knumGreen.Value = g;

            knumRed.Value = r;
        }

        private void ConstructSpecifiedColour(byte red, byte green, byte blue) => cpbSelectedColour.BackColor = Color.FromArgb(red, green, blue);

        private void ConstructSpecifiedColour(int red, int green, int blue) => cpbSelectedColour.BackColor = Color.FromArgb(red, green, blue);
        #endregion

        private void scpColour_ColorChanged(object sender, EventArgs e)
        {
            cpbSelectedColour.BackColor = scpColour.Color;
        }

        private void kknbRed_ValueChanged(object Sender)
        {
            AlterLabel(ColourChannelLabel.REDLABEL, kknbRed.Value);

            ConstructSpecifiedColour(kknbRed.Value, kknbGreen.Value, kknbBlue.Value);
        }

        private void kknbGreen_ValueChanged(object Sender)
        {
            AlterLabel(ColourChannelLabel.GREENLABEL, kknbGreen.Value);

            ConstructSpecifiedColour(kknbRed.Value, kknbGreen.Value, kknbBlue.Value);
        }

        private void kknbBlue_ValueChanged(object Sender)
        {
            AlterLabel(ColourChannelLabel.BLUELABEL, kknbBlue.Value);

            ConstructSpecifiedColour(kknbRed.Value, kknbGreen.Value, kknbBlue.Value);
        }

        private void knumRed_ValueChanged(object sender, EventArgs e)
        {
            ConstructSpecifiedColour((byte)knumRed.Value, (byte)knumGreen.Value, (byte)knumBlue.Value);
        }

        private void knumGreen_ValueChanged(object sender, EventArgs e)
        {
            ConstructSpecifiedColour((byte)knumRed.Value, (byte)knumGreen.Value, (byte)knumBlue.Value);
        }

        private void knumBlue_ValueChanged(object sender, EventArgs e)
        {
            ConstructSpecifiedColour((byte)knumRed.Value, (byte)knumGreen.Value, (byte)knumBlue.Value);
        }

        private void cpbSelectedColour_BackColorChanged(object sender, EventArgs e)
        {
            klblHexValue.Text = GetHexColourValue(cpbSelectedColour.BackColor);

            UpdateColourValues(cpbSelectedColour.BackColor);

            Colour = cpbSelectedColour.BackColor;
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        #region Protected
        protected virtual void OnSelectedColourChanged(object sender)
        {
            if (SelectedColourChanged != null) SelectedColourChanged(sender, EventArgs.Empty);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }
        #endregion
    }
}