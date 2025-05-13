/*
 * Created by SharpDevelop.
 * User: usuario
 * Date: 09/05/2025
 * Time: 12:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Grados_F_a_C
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListBox LstCalc;
		private System.Windows.Forms.Label LblR;
		private System.Windows.Forms.MaskedTextBox MskGrados;
		private System.Windows.Forms.Label LblFrioCalido;
		private System.Windows.Forms.Label LblGrados4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LblGrados3;
		private System.Windows.Forms.Button BtnInt;
		private System.Windows.Forms.Button BtnNuevo;
		private System.Windows.Forms.Button BtnConv;
		private System.Windows.Forms.Label LblGrados2;
		private System.Windows.Forms.Label LblGrados;
		private System.Windows.Forms.Panel panel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LstCalc = new System.Windows.Forms.ListBox();
            this.LblR = new System.Windows.Forms.Label();
            this.MskGrados = new System.Windows.Forms.MaskedTextBox();
            this.LblFrioCalido = new System.Windows.Forms.Label();
            this.LblGrados4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblGrados3 = new System.Windows.Forms.Label();
            this.BtnInt = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnConv = new System.Windows.Forms.Button();
            this.LblGrados2 = new System.Windows.Forms.Label();
            this.LblGrados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // LstCalc
            // 
            this.LstCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LstCalc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstCalc.ForeColor = System.Drawing.Color.White;
            this.LstCalc.FormattingEnabled = true;
            this.LstCalc.ItemHeight = 24;
            this.LstCalc.Location = new System.Drawing.Point(178, 221);
            this.LstCalc.Name = "LstCalc";
            this.LstCalc.Size = new System.Drawing.Size(299, 24);
            this.LstCalc.TabIndex = 28;
            // 
            // LblR
            // 
            this.LblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR.ForeColor = System.Drawing.Color.White;
            this.LblR.Location = new System.Drawing.Point(167, 148);
            this.LblR.Name = "LblR";
            this.LblR.Size = new System.Drawing.Size(209, 23);
            this.LblR.TabIndex = 27;
            this.LblR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MskGrados
            // 
            this.MskGrados.Location = new System.Drawing.Point(178, 41);
            this.MskGrados.Mask = "####";
            this.MskGrados.Name = "MskGrados";
            this.MskGrados.PromptChar = ' ';
            this.MskGrados.Size = new System.Drawing.Size(198, 20);
            this.MskGrados.TabIndex = 17;
            // 
            // LblFrioCalido
            // 
            this.LblFrioCalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFrioCalido.ForeColor = System.Drawing.Color.Black;
            this.LblFrioCalido.Location = new System.Drawing.Point(3, 253);
            this.LblFrioCalido.Name = "LblFrioCalido";
            this.LblFrioCalido.Size = new System.Drawing.Size(181, 67);
            this.LblFrioCalido.TabIndex = 26;
            this.LblFrioCalido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGrados4
            // 
            this.LblGrados4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrados4.ForeColor = System.Drawing.Color.White;
            this.LblGrados4.Location = new System.Drawing.Point(409, 127);
            this.LblGrados4.Name = "LblGrados4";
            this.LblGrados4.Size = new System.Drawing.Size(68, 61);
            this.LblGrados4.TabIndex = 25;
            this.LblGrados4.Text = "°C";
            this.LblGrados4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Calculo →";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGrados3
            // 
            this.LblGrados3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrados3.ForeColor = System.Drawing.Color.White;
            this.LblGrados3.Location = new System.Drawing.Point(20, 148);
            this.LblGrados3.Name = "LblGrados3";
            this.LblGrados3.Size = new System.Drawing.Size(154, 23);
            this.LblGrados3.TabIndex = 23;
            this.LblGrados3.Text = "Celsius →";
            this.LblGrados3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnInt
            // 
            this.BtnInt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnInt.ForeColor = System.Drawing.Color.Black;
            this.BtnInt.Location = new System.Drawing.Point(301, 83);
            this.BtnInt.Name = "BtnInt";
            this.BtnInt.Size = new System.Drawing.Size(75, 23);
            this.BtnInt.TabIndex = 22;
            this.BtnInt.Text = "&Intercambiar";
            this.BtnInt.UseVisualStyleBackColor = true;
            this.BtnInt.Click += new System.EventHandler(this.BtnIntClick);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnNuevo.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevo.Location = new System.Drawing.Point(178, 83);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 21;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
            // 
            // BtnConv
            // 
            this.BtnConv.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnConv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConv.ForeColor = System.Drawing.Color.Black;
            this.BtnConv.Location = new System.Drawing.Point(65, 83);
            this.BtnConv.Name = "BtnConv";
            this.BtnConv.Size = new System.Drawing.Size(75, 23);
            this.BtnConv.TabIndex = 20;
            this.BtnConv.Text = "&Convertir";
            this.BtnConv.UseVisualStyleBackColor = true;
            this.BtnConv.Click += new System.EventHandler(this.BtnConvClick);
            // 
            // LblGrados2
            // 
            this.LblGrados2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrados2.ForeColor = System.Drawing.Color.White;
            this.LblGrados2.Location = new System.Drawing.Point(409, 19);
            this.LblGrados2.Name = "LblGrados2";
            this.LblGrados2.Size = new System.Drawing.Size(68, 61);
            this.LblGrados2.TabIndex = 19;
            this.LblGrados2.Text = "°F";
            this.LblGrados2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGrados
            // 
            this.LblGrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGrados.ForeColor = System.Drawing.Color.White;
            this.LblGrados.Location = new System.Drawing.Point(20, 40);
            this.LblGrados.Name = "LblGrados";
            this.LblGrados.Size = new System.Drawing.Size(154, 23);
            this.LblGrados.TabIndex = 18;
            this.LblGrados.Text = "Fahrenheit →";
            this.LblGrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LblFrioCalido);
            this.panel1.Location = new System.Drawing.Point(483, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 333);
            this.panel1.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(668, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LstCalc);
            this.Controls.Add(this.LblR);
            this.Controls.Add(this.MskGrados);
            this.Controls.Add(this.LblGrados4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblGrados3);
            this.Controls.Add(this.BtnInt);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnConv);
            this.Controls.Add(this.LblGrados2);
            this.Controls.Add(this.LblGrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversion de Escalas de Temperatura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
