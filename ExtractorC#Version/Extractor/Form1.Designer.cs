
namespace HelloWorldCsharp
{
    partial class btn_Hello
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.comb1 = new System.Windows.Forms.ComboBox();
            this.comb2 = new System.Windows.Forms.ComboBox();
            this.comb3 = new System.Windows.Forms.ComboBox();
            this.comb4 = new System.Windows.Forms.ComboBox();
            this.comb5 = new System.Windows.Forms.ComboBox();
            this.comb6 = new System.Windows.Forms.ComboBox();
            this.comb7 = new System.Windows.Forms.ComboBox();
            this.comb8 = new System.Windows.Forms.ComboBox();
            this.comb9 = new System.Windows.Forms.ComboBox();
            this.comb10 = new System.Windows.Forms.ComboBox();
            this.lineDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_path = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Load_Graph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(54, 81);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(280, 39);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Choose File (.csv)";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comb1
            // 
            this.comb1.FormattingEnabled = true;
            this.comb1.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb1.Location = new System.Drawing.Point(120, 161);
            this.comb1.Name = "comb1";
            this.comb1.Size = new System.Drawing.Size(214, 21);
            this.comb1.TabIndex = 1;
            this.comb1.Tag = "s";
            this.comb1.Text = "Choose Node";
            this.comb1.SelectedIndexChanged += new System.EventHandler(this.comb1_SelectedIndexChanged);
            // 
            // comb2
            // 
            this.comb2.FormattingEnabled = true;
            this.comb2.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb2.Location = new System.Drawing.Point(120, 212);
            this.comb2.Name = "comb2";
            this.comb2.Size = new System.Drawing.Size(214, 21);
            this.comb2.TabIndex = 2;
            this.comb2.Text = "Choose Node";
            this.comb2.SelectedIndexChanged += new System.EventHandler(this.comb2_SelectedIndexChanged);
            // 
            // comb3
            // 
            this.comb3.FormattingEnabled = true;
            this.comb3.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb3.Location = new System.Drawing.Point(120, 258);
            this.comb3.Name = "comb3";
            this.comb3.Size = new System.Drawing.Size(214, 21);
            this.comb3.TabIndex = 3;
            this.comb3.Text = "Choose Node";
            this.comb3.SelectedIndexChanged += new System.EventHandler(this.comb3_SelectedIndexChanged);
            // 
            // comb4
            // 
            this.comb4.FormattingEnabled = true;
            this.comb4.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb4.Location = new System.Drawing.Point(120, 306);
            this.comb4.Name = "comb4";
            this.comb4.Size = new System.Drawing.Size(214, 21);
            this.comb4.TabIndex = 4;
            this.comb4.Text = "Choose Node";
            this.comb4.SelectedIndexChanged += new System.EventHandler(this.comb4_SelectedIndexChanged);
            // 
            // comb5
            // 
            this.comb5.FormattingEnabled = true;
            this.comb5.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb5.Location = new System.Drawing.Point(120, 353);
            this.comb5.Name = "comb5";
            this.comb5.Size = new System.Drawing.Size(214, 21);
            this.comb5.TabIndex = 5;
            this.comb5.Text = "Choose Node";
            this.comb5.SelectedIndexChanged += new System.EventHandler(this.combo5_SelectedIndexChanged);
            // 
            // comb6
            // 
            this.comb6.FormattingEnabled = true;
            this.comb6.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb6.Location = new System.Drawing.Point(120, 408);
            this.comb6.Name = "comb6";
            this.comb6.Size = new System.Drawing.Size(214, 21);
            this.comb6.TabIndex = 6;
            this.comb6.Text = "Choose Node";
            this.comb6.SelectedIndexChanged += new System.EventHandler(this.comb6_SelectedIndexChanged);
            // 
            // comb7
            // 
            this.comb7.FormattingEnabled = true;
            this.comb7.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb7.Location = new System.Drawing.Point(120, 465);
            this.comb7.Name = "comb7";
            this.comb7.Size = new System.Drawing.Size(214, 21);
            this.comb7.TabIndex = 7;
            this.comb7.Text = "Choose Node";
            this.comb7.SelectedIndexChanged += new System.EventHandler(this.comb7_SelectedIndexChanged);
            // 
            // comb8
            // 
            this.comb8.FormattingEnabled = true;
            this.comb8.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb8.Location = new System.Drawing.Point(120, 521);
            this.comb8.Name = "comb8";
            this.comb8.Size = new System.Drawing.Size(214, 21);
            this.comb8.TabIndex = 8;
            this.comb8.Text = "Choose Node";
            this.comb8.SelectedIndexChanged += new System.EventHandler(this.comb8_SelectedIndexChanged);
            // 
            // comb9
            // 
            this.comb9.FormattingEnabled = true;
            this.comb9.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb9.Location = new System.Drawing.Point(120, 579);
            this.comb9.Name = "comb9";
            this.comb9.Size = new System.Drawing.Size(214, 21);
            this.comb9.TabIndex = 9;
            this.comb9.Text = "Choose Node";
            this.comb9.SelectedIndexChanged += new System.EventHandler(this.comb9_SelectedIndexChanged);
            // 
            // comb10
            // 
            this.comb10.FormattingEnabled = true;
            this.comb10.Items.AddRange(new object[] {
            "L1 Admit",
            "L2 Admit",
            "S1L1",
            "S1L2",
            "S3L1",
            "S3L2",
            "Enter Open",
            "Enter Close",
            "Exit Open",
            "Exit Close",
            "Chamber Conveyor",
            "ATM Switch",
            "Iso Valve",
            "S7L1",
            "S7L2",
            "S9L1",
            "S9L2",
            "L1 D/S",
            "L2 D/S",
            "Green Light",
            "Choose Node"});
            this.comb10.Location = new System.Drawing.Point(120, 640);
            this.comb10.MaxDropDownItems = 21;
            this.comb10.Name = "comb10";
            this.comb10.Size = new System.Drawing.Size(214, 21);
            this.comb10.TabIndex = 10;
            this.comb10.Text = "Choose Node";
            this.comb10.SelectedIndexChanged += new System.EventHandler(this.comb10_SelectedIndexChanged);
            // 
            // lineDisplay
            // 
            legend1.Name = "Legend1";
            this.lineDisplay.Legends.Add(legend1);
            this.lineDisplay.Location = new System.Drawing.Point(376, 161);
            this.lineDisplay.Name = "lineDisplay";
            this.lineDisplay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.lineDisplay.Series.Add(series1);
            this.lineDisplay.Size = new System.Drawing.Size(1168, 500);
            this.lineDisplay.TabIndex = 11;
            this.lineDisplay.Text = "chart1";
            // 
            // lbl_path
            // 
            this.lbl_path.Location = new System.Drawing.Point(365, 81);
            this.lbl_path.Multiline = true;
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(601, 39);
            this.lbl_path.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 705);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Start Time (HH:MM:SS)";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(611, 705);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "End Time (HH:MM:SS)";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Load_Graph
            // 
            this.btn_Load_Graph.Location = new System.Drawing.Point(846, 702);
            this.btn_Load_Graph.Name = "btn_Load_Graph";
            this.btn_Load_Graph.Size = new System.Drawing.Size(120, 23);
            this.btn_Load_Graph.TabIndex = 15;
            this.btn_Load_Graph.Text = "Load Graph";
            this.btn_Load_Graph.UseVisualStyleBackColor = true;
            this.btn_Load_Graph.Click += new System.EventHandler(this.btn_Load_Graph_Click);
            // 
            // btn_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 827);
            this.Controls.Add(this.btn_Load_Graph);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.lineDisplay);
            this.Controls.Add(this.comb10);
            this.Controls.Add(this.comb9);
            this.Controls.Add(this.comb8);
            this.Controls.Add(this.comb7);
            this.Controls.Add(this.comb6);
            this.Controls.Add(this.comb5);
            this.Controls.Add(this.comb4);
            this.Controls.Add(this.comb3);
            this.Controls.Add(this.comb2);
            this.Controls.Add(this.comb1);
            this.Controls.Add(this.btn_openFile);
            this.Name = "btn_Hello";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lineDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.ComboBox comb1;
        private System.Windows.Forms.ComboBox comb2;
        private System.Windows.Forms.ComboBox comb3;
        private System.Windows.Forms.ComboBox comb4;
        private System.Windows.Forms.ComboBox comb5;
        private System.Windows.Forms.ComboBox comb6;
        private System.Windows.Forms.ComboBox comb7;
        private System.Windows.Forms.ComboBox comb8;
        private System.Windows.Forms.ComboBox comb9;
        private System.Windows.Forms.ComboBox comb10;
        private System.Windows.Forms.TextBox lbl_path;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Load_Graph;
        public System.Windows.Forms.DataVisualization.Charting.Chart lineDisplay;
    }
}

