
namespace Among_Us_Radar
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRadar = new System.Windows.Forms.Panel();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.NumericPlayers = new System.Windows.Forms.NumericUpDown();
            this.labelPlayer1Offset = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericPlayer10Offset = new System.Windows.Forms.NumericUpDown();
            this.numericPlayer9Offset = new System.Windows.Forms.NumericUpDown();
            this.numericPlayer8Offset = new System.Windows.Forms.NumericUpDown();
            this.numericPlayer7Offset = new System.Windows.Forms.NumericUpDown();
            this.numericPlayer6Offset = new System.Windows.Forms.NumericUpDown();
            this.numericPlayer5Offset = new System.Windows.Forms.NumericUpDown();
            this.numericPlayer4Offset = new System.Windows.Forms.NumericUpDown();
            this.numericPlayer3Offset = new System.Windows.Forms.NumericUpDown();
            this.numericPlayer2Offset = new System.Windows.Forms.NumericUpDown();
            this.labelPlayer10Offset = new System.Windows.Forms.Label();
            this.labelPlayer9Offset = new System.Windows.Forms.Label();
            this.labelPlayer8Offset = new System.Windows.Forms.Label();
            this.labelPlayer7Offset = new System.Windows.Forms.Label();
            this.labelPlayer6Offset = new System.Windows.Forms.Label();
            this.labelPlayer5Offset = new System.Windows.Forms.Label();
            this.labelPlayer4Offset = new System.Windows.Forms.Label();
            this.labelPlayer3Offset = new System.Windows.Forms.Label();
            this.labelPlayer2Offset = new System.Windows.Forms.Label();
            this.numericPlayer1Offset = new System.Windows.Forms.NumericUpDown();
            this.numericSizeX = new System.Windows.Forms.NumericUpDown();
            this.numericSizeY = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMap = new System.Windows.Forms.ComboBox();
            this.ButtonSaveAll = new System.Windows.Forms.Button();
            this.CheckPlayers = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPlayers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer10Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer9Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer8Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer7Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer6Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer5Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer4Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer3Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer2Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer1Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRadar
            // 
            this.panelRadar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRadar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRadar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelRadar.Location = new System.Drawing.Point(12, 72);
            this.panelRadar.Name = "panelRadar";
            this.panelRadar.Size = new System.Drawing.Size(1024, 620);
            this.panelRadar.TabIndex = 0;
            this.panelRadar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelRadar_MouseUp);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(12, 8);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(214, 8);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 2;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // NumericPlayers
            // 
            this.NumericPlayers.Location = new System.Drawing.Point(171, 8);
            this.NumericPlayers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericPlayers.Name = "NumericPlayers";
            this.NumericPlayers.Size = new System.Drawing.Size(37, 20);
            this.NumericPlayers.TabIndex = 3;
            this.NumericPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPlayer1Offset
            // 
            this.labelPlayer1Offset.AutoSize = true;
            this.labelPlayer1Offset.Location = new System.Drawing.Point(6, 16);
            this.labelPlayer1Offset.Name = "labelPlayer1Offset";
            this.labelPlayer1Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer1Offset.TabIndex = 6;
            this.labelPlayer1Offset.Text = "Player1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericPlayer10Offset);
            this.groupBox1.Controls.Add(this.numericPlayer9Offset);
            this.groupBox1.Controls.Add(this.numericPlayer8Offset);
            this.groupBox1.Controls.Add(this.numericPlayer7Offset);
            this.groupBox1.Controls.Add(this.numericPlayer6Offset);
            this.groupBox1.Controls.Add(this.numericPlayer5Offset);
            this.groupBox1.Controls.Add(this.numericPlayer4Offset);
            this.groupBox1.Controls.Add(this.numericPlayer3Offset);
            this.groupBox1.Controls.Add(this.numericPlayer2Offset);
            this.groupBox1.Controls.Add(this.labelPlayer10Offset);
            this.groupBox1.Controls.Add(this.labelPlayer9Offset);
            this.groupBox1.Controls.Add(this.labelPlayer8Offset);
            this.groupBox1.Controls.Add(this.labelPlayer7Offset);
            this.groupBox1.Controls.Add(this.labelPlayer6Offset);
            this.groupBox1.Controls.Add(this.labelPlayer5Offset);
            this.groupBox1.Controls.Add(this.labelPlayer4Offset);
            this.groupBox1.Controls.Add(this.labelPlayer3Offset);
            this.groupBox1.Controls.Add(this.labelPlayer2Offset);
            this.groupBox1.Controls.Add(this.numericPlayer1Offset);
            this.groupBox1.Controls.Add(this.labelPlayer1Offset);
            this.groupBox1.Location = new System.Drawing.Point(304, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numericPlayer10Offset
            // 
            this.numericPlayer10Offset.Hexadecimal = true;
            this.numericPlayer10Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer10Offset.Location = new System.Drawing.Point(441, 33);
            this.numericPlayer10Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer10Offset.Name = "numericPlayer10Offset";
            this.numericPlayer10Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer10Offset.TabIndex = 25;
            // 
            // numericPlayer9Offset
            // 
            this.numericPlayer9Offset.Hexadecimal = true;
            this.numericPlayer9Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer9Offset.Location = new System.Drawing.Point(393, 33);
            this.numericPlayer9Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer9Offset.Name = "numericPlayer9Offset";
            this.numericPlayer9Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer9Offset.TabIndex = 24;
            // 
            // numericPlayer8Offset
            // 
            this.numericPlayer8Offset.Hexadecimal = true;
            this.numericPlayer8Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer8Offset.Location = new System.Drawing.Point(345, 32);
            this.numericPlayer8Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer8Offset.Name = "numericPlayer8Offset";
            this.numericPlayer8Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer8Offset.TabIndex = 23;
            // 
            // numericPlayer7Offset
            // 
            this.numericPlayer7Offset.Hexadecimal = true;
            this.numericPlayer7Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer7Offset.Location = new System.Drawing.Point(297, 32);
            this.numericPlayer7Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer7Offset.Name = "numericPlayer7Offset";
            this.numericPlayer7Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer7Offset.TabIndex = 22;
            // 
            // numericPlayer6Offset
            // 
            this.numericPlayer6Offset.Hexadecimal = true;
            this.numericPlayer6Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer6Offset.Location = new System.Drawing.Point(249, 32);
            this.numericPlayer6Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer6Offset.Name = "numericPlayer6Offset";
            this.numericPlayer6Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer6Offset.TabIndex = 21;
            // 
            // numericPlayer5Offset
            // 
            this.numericPlayer5Offset.Hexadecimal = true;
            this.numericPlayer5Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer5Offset.Location = new System.Drawing.Point(201, 32);
            this.numericPlayer5Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer5Offset.Name = "numericPlayer5Offset";
            this.numericPlayer5Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer5Offset.TabIndex = 20;
            // 
            // numericPlayer4Offset
            // 
            this.numericPlayer4Offset.Hexadecimal = true;
            this.numericPlayer4Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer4Offset.Location = new System.Drawing.Point(153, 32);
            this.numericPlayer4Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer4Offset.Name = "numericPlayer4Offset";
            this.numericPlayer4Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer4Offset.TabIndex = 19;
            // 
            // numericPlayer3Offset
            // 
            this.numericPlayer3Offset.Hexadecimal = true;
            this.numericPlayer3Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer3Offset.Location = new System.Drawing.Point(105, 33);
            this.numericPlayer3Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer3Offset.Name = "numericPlayer3Offset";
            this.numericPlayer3Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer3Offset.TabIndex = 18;
            // 
            // numericPlayer2Offset
            // 
            this.numericPlayer2Offset.Hexadecimal = true;
            this.numericPlayer2Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer2Offset.Location = new System.Drawing.Point(57, 32);
            this.numericPlayer2Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer2Offset.Name = "numericPlayer2Offset";
            this.numericPlayer2Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer2Offset.TabIndex = 17;
            // 
            // labelPlayer10Offset
            // 
            this.labelPlayer10Offset.AutoSize = true;
            this.labelPlayer10Offset.Location = new System.Drawing.Point(438, 16);
            this.labelPlayer10Offset.Name = "labelPlayer10Offset";
            this.labelPlayer10Offset.Size = new System.Drawing.Size(48, 13);
            this.labelPlayer10Offset.TabIndex = 16;
            this.labelPlayer10Offset.Text = "Player10";
            // 
            // labelPlayer9Offset
            // 
            this.labelPlayer9Offset.AutoSize = true;
            this.labelPlayer9Offset.Location = new System.Drawing.Point(390, 16);
            this.labelPlayer9Offset.Name = "labelPlayer9Offset";
            this.labelPlayer9Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer9Offset.TabIndex = 15;
            this.labelPlayer9Offset.Text = "Player9";
            // 
            // labelPlayer8Offset
            // 
            this.labelPlayer8Offset.AutoSize = true;
            this.labelPlayer8Offset.Location = new System.Drawing.Point(342, 16);
            this.labelPlayer8Offset.Name = "labelPlayer8Offset";
            this.labelPlayer8Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer8Offset.TabIndex = 14;
            this.labelPlayer8Offset.Text = "Player8";
            // 
            // labelPlayer7Offset
            // 
            this.labelPlayer7Offset.AutoSize = true;
            this.labelPlayer7Offset.Location = new System.Drawing.Point(294, 16);
            this.labelPlayer7Offset.Name = "labelPlayer7Offset";
            this.labelPlayer7Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer7Offset.TabIndex = 13;
            this.labelPlayer7Offset.Text = "Player7";
            // 
            // labelPlayer6Offset
            // 
            this.labelPlayer6Offset.AutoSize = true;
            this.labelPlayer6Offset.Location = new System.Drawing.Point(246, 16);
            this.labelPlayer6Offset.Name = "labelPlayer6Offset";
            this.labelPlayer6Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer6Offset.TabIndex = 12;
            this.labelPlayer6Offset.Text = "Player6";
            // 
            // labelPlayer5Offset
            // 
            this.labelPlayer5Offset.AutoSize = true;
            this.labelPlayer5Offset.Location = new System.Drawing.Point(198, 16);
            this.labelPlayer5Offset.Name = "labelPlayer5Offset";
            this.labelPlayer5Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer5Offset.TabIndex = 11;
            this.labelPlayer5Offset.Text = "Player5";
            // 
            // labelPlayer4Offset
            // 
            this.labelPlayer4Offset.AutoSize = true;
            this.labelPlayer4Offset.Location = new System.Drawing.Point(150, 16);
            this.labelPlayer4Offset.Name = "labelPlayer4Offset";
            this.labelPlayer4Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer4Offset.TabIndex = 10;
            this.labelPlayer4Offset.Text = "Player4";
            // 
            // labelPlayer3Offset
            // 
            this.labelPlayer3Offset.AutoSize = true;
            this.labelPlayer3Offset.Location = new System.Drawing.Point(102, 16);
            this.labelPlayer3Offset.Name = "labelPlayer3Offset";
            this.labelPlayer3Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer3Offset.TabIndex = 9;
            this.labelPlayer3Offset.Text = "Player3";
            // 
            // labelPlayer2Offset
            // 
            this.labelPlayer2Offset.AutoSize = true;
            this.labelPlayer2Offset.Location = new System.Drawing.Point(54, 16);
            this.labelPlayer2Offset.Name = "labelPlayer2Offset";
            this.labelPlayer2Offset.Size = new System.Drawing.Size(42, 13);
            this.labelPlayer2Offset.TabIndex = 8;
            this.labelPlayer2Offset.Text = "Player2";
            // 
            // numericPlayer1Offset
            // 
            this.numericPlayer1Offset.Hexadecimal = true;
            this.numericPlayer1Offset.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPlayer1Offset.Location = new System.Drawing.Point(9, 33);
            this.numericPlayer1Offset.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPlayer1Offset.Name = "numericPlayer1Offset";
            this.numericPlayer1Offset.Size = new System.Drawing.Size(39, 20);
            this.numericPlayer1Offset.TabIndex = 7;
            // 
            // numericSizeX
            // 
            this.numericSizeX.Location = new System.Drawing.Point(885, 11);
            this.numericSizeX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericSizeX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericSizeX.Name = "numericSizeX";
            this.numericSizeX.Size = new System.Drawing.Size(43, 20);
            this.numericSizeX.TabIndex = 9;
            // 
            // numericSizeY
            // 
            this.numericSizeY.Location = new System.Drawing.Point(885, 38);
            this.numericSizeY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericSizeY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericSizeY.Name = "numericSizeY";
            this.numericSizeY.Size = new System.Drawing.Size(43, 20);
            this.numericSizeY.TabIndex = 10;
            // 
            // comboBoxMap
            // 
            this.comboBoxMap.FormattingEnabled = true;
            this.comboBoxMap.Location = new System.Drawing.Point(12, 42);
            this.comboBoxMap.Name = "comboBoxMap";
            this.comboBoxMap.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMap.TabIndex = 11;
            // 
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Location = new System.Drawing.Point(796, 12);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.Size = new System.Drawing.Size(75, 52);
            this.ButtonSaveAll.TabIndex = 13;
            this.ButtonSaveAll.Text = "Save All";
            this.ButtonSaveAll.UseVisualStyleBackColor = true;
            this.ButtonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // CheckPlayers
            // 
            this.CheckPlayers.AutoSize = true;
            this.CheckPlayers.ForeColor = System.Drawing.Color.DarkRed;
            this.CheckPlayers.Location = new System.Drawing.Point(140, 42);
            this.CheckPlayers.Name = "CheckPlayers";
            this.CheckPlayers.Size = new System.Drawing.Size(139, 17);
            this.CheckPlayers.TabIndex = 14;
            this.CheckPlayers.Text = "Players In Game [future]";
            this.CheckPlayers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number Player \r\nIn Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckPlayers);
            this.Controls.Add(this.ButtonSaveAll);
            this.Controls.Add(this.comboBoxMap);
            this.Controls.Add(this.numericSizeY);
            this.Controls.Add(this.numericSizeX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NumericPlayers);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.panelRadar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericPlayers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer10Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer9Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer8Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer7Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer6Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer5Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer4Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer3Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer2Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayer1Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRadar;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.NumericUpDown NumericPlayers;
        private System.Windows.Forms.Label labelPlayer1Offset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericPlayer10Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer9Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer8Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer7Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer6Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer5Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer4Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer3Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer2Offset;
        private System.Windows.Forms.Label labelPlayer10Offset;
        private System.Windows.Forms.Label labelPlayer9Offset;
        private System.Windows.Forms.Label labelPlayer8Offset;
        private System.Windows.Forms.Label labelPlayer7Offset;
        private System.Windows.Forms.Label labelPlayer6Offset;
        private System.Windows.Forms.Label labelPlayer5Offset;
        private System.Windows.Forms.Label labelPlayer4Offset;
        private System.Windows.Forms.Label labelPlayer3Offset;
        private System.Windows.Forms.Label labelPlayer2Offset;
        private System.Windows.Forms.NumericUpDown numericPlayer1Offset;
        private System.Windows.Forms.NumericUpDown numericSizeX;
        private System.Windows.Forms.NumericUpDown numericSizeY;
        private System.Windows.Forms.ComboBox comboBoxMap;
        private System.Windows.Forms.Button ButtonSaveAll;
        private System.Windows.Forms.CheckBox CheckPlayers;
        private System.Windows.Forms.Label label1;
    }
}

