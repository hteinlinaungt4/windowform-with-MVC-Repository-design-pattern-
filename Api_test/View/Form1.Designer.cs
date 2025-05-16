namespace Api_test
{
    partial class Form1
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
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox3 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox1.Location = new System.Drawing.Point(12, 12);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.Padding = new System.Windows.Forms.Padding(10);
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.Size = new System.Drawing.Size(491, 386);
            this.materialListBox1.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(427, 421);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Get api";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(548, 26);
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(250, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 2;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // materialMaskedTextBox2
            // 
            this.materialMaskedTextBox2.AllowPromptAsInput = true;
            this.materialMaskedTextBox2.AnimateReadOnly = false;
            this.materialMaskedTextBox2.AsciiOnly = false;
            this.materialMaskedTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox2.BeepOnError = false;
            this.materialMaskedTextBox2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox2.Depth = 0;
            this.materialMaskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox2.HidePromptOnLeave = false;
            this.materialMaskedTextBox2.HideSelection = true;
            this.materialMaskedTextBox2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox2.LeadingIcon = null;
            this.materialMaskedTextBox2.Location = new System.Drawing.Point(548, 116);
            this.materialMaskedTextBox2.Mask = "";
            this.materialMaskedTextBox2.MaxLength = 32767;
            this.materialMaskedTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox2.Name = "materialMaskedTextBox2";
            this.materialMaskedTextBox2.PasswordChar = '\0';
            this.materialMaskedTextBox2.PrefixSuffixText = null;
            this.materialMaskedTextBox2.PromptChar = '_';
            this.materialMaskedTextBox2.ReadOnly = false;
            this.materialMaskedTextBox2.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox2.ResetOnPrompt = true;
            this.materialMaskedTextBox2.ResetOnSpace = true;
            this.materialMaskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox2.SelectedText = "";
            this.materialMaskedTextBox2.SelectionLength = 0;
            this.materialMaskedTextBox2.SelectionStart = 0;
            this.materialMaskedTextBox2.ShortcutsEnabled = true;
            this.materialMaskedTextBox2.Size = new System.Drawing.Size(250, 48);
            this.materialMaskedTextBox2.SkipLiterals = true;
            this.materialMaskedTextBox2.TabIndex = 3;
            this.materialMaskedTextBox2.TabStop = false;
            this.materialMaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox2.TrailingIcon = null;
            this.materialMaskedTextBox2.UseSystemPasswordChar = false;
            this.materialMaskedTextBox2.ValidatingType = null;
            // 
            // materialMaskedTextBox3
            // 
            this.materialMaskedTextBox3.AllowPromptAsInput = true;
            this.materialMaskedTextBox3.AnimateReadOnly = false;
            this.materialMaskedTextBox3.AsciiOnly = false;
            this.materialMaskedTextBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox3.BeepOnError = false;
            this.materialMaskedTextBox3.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox3.Depth = 0;
            this.materialMaskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox3.HidePromptOnLeave = false;
            this.materialMaskedTextBox3.HideSelection = true;
            this.materialMaskedTextBox3.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox3.LeadingIcon = null;
            this.materialMaskedTextBox3.Location = new System.Drawing.Point(548, 196);
            this.materialMaskedTextBox3.Mask = "";
            this.materialMaskedTextBox3.MaxLength = 32767;
            this.materialMaskedTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox3.Name = "materialMaskedTextBox3";
            this.materialMaskedTextBox3.PasswordChar = '\0';
            this.materialMaskedTextBox3.PrefixSuffixText = null;
            this.materialMaskedTextBox3.PromptChar = '_';
            this.materialMaskedTextBox3.ReadOnly = false;
            this.materialMaskedTextBox3.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox3.ResetOnPrompt = true;
            this.materialMaskedTextBox3.ResetOnSpace = true;
            this.materialMaskedTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox3.SelectedText = "";
            this.materialMaskedTextBox3.SelectionLength = 0;
            this.materialMaskedTextBox3.SelectionStart = 0;
            this.materialMaskedTextBox3.ShortcutsEnabled = true;
            this.materialMaskedTextBox3.Size = new System.Drawing.Size(250, 48);
            this.materialMaskedTextBox3.SkipLiterals = true;
            this.materialMaskedTextBox3.TabIndex = 4;
            this.materialMaskedTextBox3.TabStop = false;
            this.materialMaskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox3.TrailingIcon = null;
            this.materialMaskedTextBox3.UseSystemPasswordChar = false;
            this.materialMaskedTextBox3.ValidatingType = null;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(586, 316);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(150, 36);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.Text = "Create";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 503);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialMaskedTextBox3);
            this.Controls.Add(this.materialMaskedTextBox2);
            this.Controls.Add(this.materialMaskedTextBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox2;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}

