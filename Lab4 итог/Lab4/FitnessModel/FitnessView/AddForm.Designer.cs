namespace FitnessView
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxSwimmingStyles = new System.Windows.Forms.ComboBox();
            this.RadioButtonRun = new System.Windows.Forms.RadioButton();
            this.RadioButtonSwimming = new System.Windows.Forms.RadioButton();
            this.RadioButtonBenchPress = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.RandomButton = new System.Windows.Forms.Button();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIntensive = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPodxody = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGirya = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntensive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPodxody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGirya)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стиль плавания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время выполнения,с";
            // 
            // ComboBoxSwimmingStyles
            // 
            this.ComboBoxSwimmingStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSwimmingStyles.FormattingEnabled = true;
            this.ComboBoxSwimmingStyles.Location = new System.Drawing.Point(12, 196);
            this.ComboBoxSwimmingStyles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxSwimmingStyles.Name = "ComboBoxSwimmingStyles";
            this.ComboBoxSwimmingStyles.Size = new System.Drawing.Size(157, 24);
            this.ComboBoxSwimmingStyles.TabIndex = 6;
            this.ComboBoxSwimmingStyles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSwimmingStyles_SelectedIndexChanged);
            // 
            // RadioButtonRun
            // 
            this.RadioButtonRun.AutoSize = true;
            this.RadioButtonRun.Location = new System.Drawing.Point(5, 21);
            this.RadioButtonRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonRun.Name = "RadioButtonRun";
            this.RadioButtonRun.Size = new System.Drawing.Size(51, 21);
            this.RadioButtonRun.TabIndex = 9;
            this.RadioButtonRun.Text = "Бег";
            this.RadioButtonRun.UseVisualStyleBackColor = true;
            this.RadioButtonRun.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RadioButtonSwimming
            // 
            this.RadioButtonSwimming.AutoSize = true;
            this.RadioButtonSwimming.Location = new System.Drawing.Point(5, 48);
            this.RadioButtonSwimming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonSwimming.Name = "RadioButtonSwimming";
            this.RadioButtonSwimming.Size = new System.Drawing.Size(94, 21);
            this.RadioButtonSwimming.TabIndex = 10;
            this.RadioButtonSwimming.Text = "Плавание";
            this.RadioButtonSwimming.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBenchPress
            // 
            this.RadioButtonBenchPress.AutoSize = true;
            this.RadioButtonBenchPress.Location = new System.Drawing.Point(5, 75);
            this.RadioButtonBenchPress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonBenchPress.Name = "RadioButtonBenchPress";
            this.RadioButtonBenchPress.Size = new System.Drawing.Size(110, 21);
            this.RadioButtonBenchPress.TabIndex = 11;
            this.RadioButtonBenchPress.Text = "Жим штанги";
            this.RadioButtonBenchPress.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonRun);
            this.groupBox1.Controls.Add(this.RadioButtonBenchPress);
            this.groupBox1.Controls.Add(this.RadioButtonSwimming);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(157, 114);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид упражения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Интенсивность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дистанция";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Количество подходов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Вес гири";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(239, 245);
            this.TextBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(175, 22);
            this.TextBoxResult.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Затраченные калории";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(483, 270);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 21;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(589, 270);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес человека,кг";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownTime);
            this.groupBox2.Controls.Add(this.numericUpDownWeight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(227, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(451, 90);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обязательно к заполнению";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTime.Location = new System.Drawing.Point(256, 53);
            this.numericUpDownTime.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(181, 22);
            this.numericUpDownTime.TabIndex = 26;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.DecimalPlaces = 1;
            this.numericUpDownWeight.Location = new System.Drawing.Point(13, 53);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            594,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            23,
            0,
            0,
            65536});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(175, 22);
            this.numericUpDownWeight.TabIndex = 25;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            23,
            0,
            0,
            65536});
            this.numericUpDownWeight.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(483, 224);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(181, 39);
            this.RandomButton.TabIndex = 24;
            this.RandomButton.Text = "Случайная активность";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.Location = new System.Drawing.Point(483, 140);
            this.numericUpDownDistance.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownDistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(181, 22);
            this.numericUpDownDistance.TabIndex = 25;
            // 
            // numericUpDownIntensive
            // 
            this.numericUpDownIntensive.Location = new System.Drawing.Point(240, 140);
            this.numericUpDownIntensive.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownIntensive.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIntensive.Name = "numericUpDownIntensive";
            this.numericUpDownIntensive.Size = new System.Drawing.Size(175, 22);
            this.numericUpDownIntensive.TabIndex = 26;
            // 
            // numericUpDownPodxody
            // 
            this.numericUpDownPodxody.Location = new System.Drawing.Point(240, 197);
            this.numericUpDownPodxody.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPodxody.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPodxody.Name = "numericUpDownPodxody";
            this.numericUpDownPodxody.Size = new System.Drawing.Size(175, 22);
            this.numericUpDownPodxody.TabIndex = 27;
            // 
            // numericUpDownGirya
            // 
            this.numericUpDownGirya.Location = new System.Drawing.Point(481, 197);
            this.numericUpDownGirya.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownGirya.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownGirya.Name = "numericUpDownGirya";
            this.numericUpDownGirya.Size = new System.Drawing.Size(183, 22);
            this.numericUpDownGirya.TabIndex = 28;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 305);
            this.Controls.Add(this.numericUpDownGirya);
            this.Controls.Add(this.numericUpDownPodxody);
            this.Controls.Add(this.numericUpDownIntensive);
            this.Controls.Add(this.numericUpDownDistance);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboBoxSwimmingStyles);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавить запись";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntensive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPodxody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGirya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxSwimmingStyles;
        private System.Windows.Forms.RadioButton RadioButtonRun;
        private System.Windows.Forms.RadioButton RadioButtonSwimming;
        private System.Windows.Forms.RadioButton RadioButtonBenchPress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.NumericUpDown numericUpDownIntensive;
        private System.Windows.Forms.NumericUpDown numericUpDownPodxody;
        private System.Windows.Forms.NumericUpDown numericUpDownGirya;
    }
}