
namespace Lucky_s_Wheel_Picker
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.layPanWheelPlusDiv = new System.Windows.Forms.TableLayoutPanel();
            this.bgHolder = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spinButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.layPanWheelPlusDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgHolder)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Indigo;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chart1.BackImage = "G:\\X_Users\\Timm\\Downloads\\Test4.png";
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chart1.BackSecondaryColor = System.Drawing.Color.MediumSlateBlue;
            this.chart1.BorderlineWidth = 0;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea3.Area3DStyle.Inclination = 0;
            chartArea3.Area3DStyle.Rotation = 180;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.CustomProperties = "DoughnutRadius=80, PieDrawingStyle=Concave, PieStartAngle=270";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            series3.Legend = "Legend1";
            series3.Name = "s1";
            series3.SmartLabelStyle.Enabled = false;
            series3.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Bottom) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Center)));
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(623, 603);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // layPanWheelPlusDiv
            // 
            this.layPanWheelPlusDiv.AutoSize = true;
            this.layPanWheelPlusDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layPanWheelPlusDiv.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.layPanWheelPlusDiv.ColumnCount = 2;
            this.layPanWheelPlusDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.23077F));
            this.layPanWheelPlusDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.769231F));
            this.layPanWheelPlusDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 426F));
            this.layPanWheelPlusDiv.Controls.Add(this.bgHolder, 1, 0);
            this.layPanWheelPlusDiv.Controls.Add(this.chart1, 0, 0);
            this.layPanWheelPlusDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layPanWheelPlusDiv.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.layPanWheelPlusDiv.Location = new System.Drawing.Point(0, 0);
            this.layPanWheelPlusDiv.Name = "layPanWheelPlusDiv";
            this.layPanWheelPlusDiv.Padding = new System.Windows.Forms.Padding(0, 0, 420, 0);
            this.layPanWheelPlusDiv.RowCount = 1;
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 603F));
            this.layPanWheelPlusDiv.Size = new System.Drawing.Size(1082, 603);
            this.layPanWheelPlusDiv.TabIndex = 2;
            // 
            // bgHolder
            // 
            this.bgHolder.BackColor = System.Drawing.Color.MidnightBlue;
            this.bgHolder.BackSecondaryColor = System.Drawing.Color.Purple;
            this.bgHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgHolder.Location = new System.Drawing.Point(623, 0);
            this.bgHolder.Margin = new System.Windows.Forms.Padding(0);
            this.bgHolder.Name = "bgHolder";
            this.bgHolder.Size = new System.Drawing.Size(39, 603);
            this.bgHolder.TabIndex = 2;
            this.bgHolder.Text = "chart2";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(18, 270);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.resultLabel.MinimumSize = new System.Drawing.Size(200, 42);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(390, 63);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result Goes Here";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.spinButton);
            this.panel1.Controls.Add(this.selectButton);
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(656, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 603);
            this.panel1.TabIndex = 4;
            // 
            // spinButton
            // 
            this.spinButton.BackColor = System.Drawing.Color.PowderBlue;
            this.spinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(63, 450);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(300, 120);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "SPIN";
            this.spinButton.UseVisualStyleBackColor = false;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(113, 365);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(200, 60);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "Select Wheel List";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.layPanWheelPlusDiv);
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Form1";
            this.Text = "Lucky\'s Wheel Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.layPanWheelPlusDiv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bgHolder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel layPanWheelPlusDiv;
        private System.Windows.Forms.DataVisualization.Charting.Chart bgHolder;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button spinButton;
    }
}

