using Microsoft.VisualBasic.PowerPacks;

namespace TrafficLights
{
    partial class TrafficLightsGUI
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Ada = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Adg = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Adf = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Adb = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Adc = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Ade = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Add = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Acd = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Ace = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Acc = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Acb = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Acf = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Acg = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Aca = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.DDA = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.DVA = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.DXA = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lblLamp_info = new System.Windows.Forms.Label();
            this.lblTime_Remaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(284, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 29);
            this.textBox1.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Ada,
            this.Adg,
            this.Adf,
            this.Adb,
            this.Adc,
            this.Ade,
            this.Add,
            this.Acd,
            this.Ace,
            this.Acc,
            this.Acb,
            this.Acf,
            this.Acg,
            this.Aca,
            this.DDA,
            this.DVA,
            this.DXA});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 450);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // Ada
            // 
            this.Ada.CornerRadius = 2;
            this.Ada.FillColor = System.Drawing.SystemColors.Control;
            this.Ada.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Ada.Location = new System.Drawing.Point(75, 90);
            this.Ada.Name = "Ada";
            this.Ada.Size = new System.Drawing.Size(30, 5);
            this.Ada.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Adg
            // 
            this.Adg.CornerRadius = 2;
            this.Adg.FillColor = System.Drawing.SystemColors.Control;
            this.Adg.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Adg.Location = new System.Drawing.Point(75, 125);
            this.Adg.Name = "Adg";
            this.Adg.Size = new System.Drawing.Size(30, 5);
            this.Adg.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Adf
            // 
            this.Adf.CornerRadius = 2;
            this.Adf.FillColor = System.Drawing.SystemColors.Control;
            this.Adf.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Adf.Location = new System.Drawing.Point(70, 95);
            this.Adf.Name = "Adf";
            this.Adf.Size = new System.Drawing.Size(5, 30);
            this.Adf.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Adb
            // 
            this.Adb.CornerRadius = 2;
            this.Adb.FillColor = System.Drawing.SystemColors.Control;
            this.Adb.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Adb.Location = new System.Drawing.Point(105, 95);
            this.Adb.Name = "Adb";
            this.Adb.Size = new System.Drawing.Size(5, 30);
            this.Adb.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Adc
            // 
            this.Adc.CornerRadius = 2;
            this.Adc.FillColor = System.Drawing.SystemColors.Control;
            this.Adc.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Adc.Location = new System.Drawing.Point(105, 130);
            this.Adc.Name = "Adc";
            this.Adc.Size = new System.Drawing.Size(5, 30);
            this.Adc.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Ade
            // 
            this.Ade.CornerRadius = 2;
            this.Ade.FillColor = System.Drawing.SystemColors.Control;
            this.Ade.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Ade.Location = new System.Drawing.Point(70, 130);
            this.Ade.Name = "Ade";
            this.Ade.Size = new System.Drawing.Size(5, 30);
            this.Ade.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Add
            // 
            this.Add.CornerRadius = 2;
            this.Add.FillColor = System.Drawing.SystemColors.Control;
            this.Add.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Add.Location = new System.Drawing.Point(75, 160);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(30, 5);
            this.Add.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Acd
            // 
            this.Acd.CornerRadius = 2;
            this.Acd.FillColor = System.Drawing.SystemColors.Control;
            this.Acd.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Acd.Location = new System.Drawing.Point(30, 160);
            this.Acd.Name = "Acd";
            this.Acd.Size = new System.Drawing.Size(30, 5);
            this.Acd.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Ace
            // 
            this.Ace.CornerRadius = 2;
            this.Ace.FillColor = System.Drawing.SystemColors.Control;
            this.Ace.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Ace.Location = new System.Drawing.Point(25, 130);
            this.Ace.Name = "Ace";
            this.Ace.Size = new System.Drawing.Size(5, 30);
            this.Ace.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Acc
            // 
            this.Acc.CornerRadius = 2;
            this.Acc.FillColor = System.Drawing.SystemColors.Control;
            this.Acc.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Acc.Location = new System.Drawing.Point(60, 130);
            this.Acc.Name = "Acc";
            this.Acc.Size = new System.Drawing.Size(5, 30);
            this.Acc.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Acb
            // 
            this.Acb.CornerRadius = 2;
            this.Acb.FillColor = System.Drawing.SystemColors.Control;
            this.Acb.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Acb.Location = new System.Drawing.Point(60, 95);
            this.Acb.Name = "Acb";
            this.Acb.Size = new System.Drawing.Size(5, 30);
            this.Acb.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Acf
            // 
            this.Acf.CornerRadius = 2;
            this.Acf.FillColor = System.Drawing.SystemColors.Control;
            this.Acf.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Acf.Location = new System.Drawing.Point(25, 95);
            this.Acf.Name = "Acf";
            this.Acf.Size = new System.Drawing.Size(5, 30);
            this.Acf.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Acg
            // 
            this.Acg.CornerRadius = 2;
            this.Acg.FillColor = System.Drawing.SystemColors.Control;
            this.Acg.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Acg.Location = new System.Drawing.Point(30, 125);
            this.Acg.Name = "Acg";
            this.Acg.Size = new System.Drawing.Size(30, 5);
            this.Acg.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // Aca
            // 
            this.Aca.CornerRadius = 2;
            this.Aca.FillColor = System.Drawing.SystemColors.Control;
            this.Aca.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Aca.Location = new System.Drawing.Point(30, 90);
            this.Aca.Name = "Aca";
            this.Aca.Size = new System.Drawing.Size(30, 5);
            this.Aca.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // DDA
            // 
            this.DDA.FillColor = System.Drawing.Color.White;
            this.DDA.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DDA.Location = new System.Drawing.Point(47, 304);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(40, 40);
            this.DDA.Click += new System.EventHandler(this.DXA_Click);
            // 
            // DVA
            // 
            this.DVA.FillColor = System.Drawing.Color.White;
            this.DVA.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DVA.Location = new System.Drawing.Point(47, 242);
            this.DVA.Name = "DVA";
            this.DVA.Size = new System.Drawing.Size(40, 40);
            this.DVA.Click += new System.EventHandler(this.DXA_Click);
            // 
            // DXA
            // 
            this.DXA.FillColor = System.Drawing.Color.White;
            this.DXA.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.DXA.Location = new System.Drawing.Point(47, 180);
            this.DXA.Name = "DXA";
            this.DXA.Size = new System.Drawing.Size(40, 40);
            this.DXA.Click += new System.EventHandler(this.DXA_Click);
            // 
            // lblLamp_info
            // 
            this.lblLamp_info.AutoSize = true;
            this.lblLamp_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLamp_info.Location = new System.Drawing.Point(279, 149);
            this.lblLamp_info.Name = "lblLamp_info";
            this.lblLamp_info.Size = new System.Drawing.Size(0, 26);
            this.lblLamp_info.TabIndex = 2;
            this.lblLamp_info.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTime_Remaining
            // 
            this.lblTime_Remaining.AutoSize = true;
            this.lblTime_Remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTime_Remaining.Location = new System.Drawing.Point(539, 149);
            this.lblTime_Remaining.Name = "lblTime_Remaining";
            this.lblTime_Remaining.Size = new System.Drawing.Size(0, 26);
            this.lblTime_Remaining.TabIndex = 3;
            // 
            // TrafficLightsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime_Remaining);
            this.Controls.Add(this.lblLamp_info);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "TrafficLightsGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private ShapeContainer shapeContainer1;
        private OvalShape DXA;
        private OvalShape DDA;
        private OvalShape DVA;
        private System.Windows.Forms.Label lblLamp_info;
        private System.Windows.Forms.Label lblTime_Remaining;
        private RectangleShape Aca;
        private RectangleShape Ada;
        private RectangleShape Adg;
        private RectangleShape Adf;
        private RectangleShape Adb;
        private RectangleShape Ade;
        private RectangleShape Add;
        private RectangleShape Acd;
        private RectangleShape Ace;
        private RectangleShape Acc;
        private RectangleShape Acb;
        private RectangleShape Acf;
        private RectangleShape Acg;
        private RectangleShape Adc;
    }
}

