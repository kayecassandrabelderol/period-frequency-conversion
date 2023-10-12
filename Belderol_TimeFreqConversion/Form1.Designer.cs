namespace Belderol_ConversionAct6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbtn_perfreq = new System.Windows.Forms.RadioButton();
            this.rdbtn_freqper = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_timeunit = new System.Windows.Forms.ComboBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_freq = new System.Windows.Forms.TextBox();
            this.cmb_frequnit = new System.Windows.Forms.ComboBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbtn_perfreq
            // 
            this.rdbtn_perfreq.AutoSize = true;
            this.rdbtn_perfreq.Location = new System.Drawing.Point(85, 60);
            this.rdbtn_perfreq.Name = "rdbtn_perfreq";
            this.rdbtn_perfreq.Size = new System.Drawing.Size(131, 19);
            this.rdbtn_perfreq.TabIndex = 0;
            this.rdbtn_perfreq.TabStop = true;
            this.rdbtn_perfreq.Text = "Period to Frequency";
            this.rdbtn_perfreq.UseVisualStyleBackColor = true;
            this.rdbtn_perfreq.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtn_freqper
            // 
            this.rdbtn_freqper.AutoSize = true;
            this.rdbtn_freqper.Location = new System.Drawing.Point(252, 60);
            this.rdbtn_freqper.Name = "rdbtn_freqper";
            this.rdbtn_freqper.Size = new System.Drawing.Size(131, 19);
            this.rdbtn_freqper.TabIndex = 1;
            this.rdbtn_freqper.TabStop = true;
            this.rdbtn_freqper.Text = "Frequency to Period";
            this.rdbtn_freqper.UseVisualStyleBackColor = true;
            this.rdbtn_freqper.CheckedChanged += new System.EventHandler(this.rdbtn_freqper_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Period T [?]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frequency F [?]";
            // 
            // cmb_timeunit
            // 
            this.cmb_timeunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_timeunit.FormattingEnabled = true;
            this.cmb_timeunit.Items.AddRange(new object[] {
            "Seconds",
            "Miliseconds",
            "Microseconds",
            "Nanoseconds",
            "Picoseconds"});
            this.cmb_timeunit.Location = new System.Drawing.Point(314, 123);
            this.cmb_timeunit.Name = "cmb_timeunit";
            this.cmb_timeunit.Size = new System.Drawing.Size(121, 23);
            this.cmb_timeunit.TabIndex = 4;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(142, 123);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(166, 23);
            this.txt_time.TabIndex = 5;
            // 
            // txt_freq
            // 
            this.txt_freq.Location = new System.Drawing.Point(142, 191);
            this.txt_freq.Name = "txt_freq";
            this.txt_freq.Size = new System.Drawing.Size(166, 23);
            this.txt_freq.TabIndex = 7;
            // 
            // cmb_frequnit
            // 
            this.cmb_frequnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_frequnit.FormattingEnabled = true;
            this.cmb_frequnit.Items.AddRange(new object[] {
            "hertz",
            "kilohertz",
            "megahertz",
            "gigahertz",
            "terahertz"});
            this.cmb_frequnit.Location = new System.Drawing.Point(314, 191);
            this.cmb_frequnit.Name = "cmb_frequnit";
            this.cmb_frequnit.Size = new System.Drawing.Size(121, 23);
            this.cmb_frequnit.TabIndex = 6;
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_convert.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_convert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_convert.Location = new System.Drawing.Point(179, 254);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(100, 35);
            this.btn_convert.TabIndex = 8;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 310);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_freq);
            this.Controls.Add(this.cmb_frequnit);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.cmb_timeunit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbtn_freqper);
            this.Controls.Add(this.rdbtn_perfreq);
            this.Name = "Form1";
            this.Text = "Period to Frequency Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdbtn_perfreq;
        private RadioButton rdbtn_freqper;
        private Label label1;
        private Label label2;
        private ComboBox cmb_timeunit;
        private TextBox txt_time;
        private TextBox txt_freq;
        private ComboBox cmb_frequnit;
        private Button btn_convert;
    }
}