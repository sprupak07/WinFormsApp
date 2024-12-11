using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class WeatherApp : Form
    {
        private TextBox textBoxCity;
        private Button buttonFetch;
        private Label labelTemp;
        private Label labelCondition;
        private Label labelHumidity;
        private Label labelWind;
        private PictureBox pictureBoxIcon;

        private void InitializeComponent()
        {
            textBoxCity = new TextBox();
            buttonFetch = new Button();
            labelTemp = new Label();
            labelCondition = new Label();
            labelHumidity = new Label();
            labelWind = new Label();
            pictureBoxIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(238, 82);
            textBoxCity.Margin = new Padding(4, 5, 4, 5);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(272, 31);
            textBoxCity.TabIndex = 0;
            // 
            // buttonFetch
            // 
            buttonFetch.Location = new Point(751, 73);
            buttonFetch.Margin = new Padding(4, 5, 4, 5);
            buttonFetch.Name = "buttonFetch";
            buttonFetch.Size = new Size(125, 40);
            buttonFetch.TabIndex = 1;
            buttonFetch.Text = "Fetch Weather";
            buttonFetch.Click += ButtonFetch_Click;
            // 
            // labelTemp
            // 
            labelTemp.Location = new Point(38, 125);
            labelTemp.Margin = new Padding(4, 0, 4, 0);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(375, 39);
            labelTemp.TabIndex = 2;
            // 
            // labelCondition
            // 
            labelCondition.Location = new Point(85, 303);
            labelCondition.Margin = new Padding(4, 0, 4, 0);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(375, 39);
            labelCondition.TabIndex = 3;
            // 
            // labelHumidity
            // 
            labelHumidity.Location = new Point(85, 350);
            labelHumidity.Margin = new Padding(4, 0, 4, 0);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(375, 39);
            labelHumidity.TabIndex = 4;
            // 
            // labelWind
            // 
            labelWind.Location = new Point(85, 397);
            labelWind.Margin = new Padding(4, 0, 4, 0);
            labelWind.Name = "labelWind";
            labelWind.Size = new Size(375, 39);
            labelWind.TabIndex = 5;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(704, 247);
            pictureBoxIcon.Margin = new Padding(4, 5, 4, 5);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(238, 250);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 6;
            pictureBoxIcon.TabStop = false;
            // 
            // WeatherApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 622);
            Controls.Add(textBoxCity);
            Controls.Add(buttonFetch);
            Controls.Add(labelTemp);
            Controls.Add(labelCondition);
            Controls.Add(labelHumidity);
            Controls.Add(labelWind);
            Controls.Add(pictureBoxIcon);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WeatherApp";
            Text = "Weather App";
            Load += WeatherApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
