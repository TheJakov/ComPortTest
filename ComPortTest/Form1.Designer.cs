
namespace ComPortTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxMiniVidas = new System.Windows.Forms.GroupBox();
            this.lbComPortMiniVidas = new System.Windows.Forms.Label();
            this.txtComPortMiniVidas = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxBacTecFX = new System.Windows.Forms.GroupBox();
            this.lbComPortBacTecFX = new System.Windows.Forms.Label();
            this.txtComPortBacTecFX = new System.Windows.Forms.TextBox();
            this.groupBoxBioneerExicycler = new System.Windows.Forms.GroupBox();
            this.lbComPortBioneerExicycler = new System.Windows.Forms.Label();
            this.txtComPortBioneerExicycler = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxMiniVidas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxBacTecFX.SuspendLayout();
            this.groupBoxBioneerExicycler.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MiniVidasButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F);
            this.button2.Location = new System.Drawing.Point(36, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Send data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BacTecFXButton_Click);
            // 
            // groupBoxMiniVidas
            // 
            this.groupBoxMiniVidas.BackColor = System.Drawing.Color.White;
            this.groupBoxMiniVidas.Controls.Add(this.lbComPortMiniVidas);
            this.groupBoxMiniVidas.Controls.Add(this.txtComPortMiniVidas);
            this.groupBoxMiniVidas.Controls.Add(this.button1);
            this.groupBoxMiniVidas.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBoxMiniVidas.Location = new System.Drawing.Point(17, 101);
            this.groupBoxMiniVidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMiniVidas.Name = "groupBoxMiniVidas";
            this.groupBoxMiniVidas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMiniVidas.Size = new System.Drawing.Size(473, 117);
            this.groupBoxMiniVidas.TabIndex = 2;
            this.groupBoxMiniVidas.TabStop = false;
            this.groupBoxMiniVidas.Text = "MiniVidas";
            // 
            // lbComPortMiniVidas
            // 
            this.lbComPortMiniVidas.AutoSize = true;
            this.lbComPortMiniVidas.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbComPortMiniVidas.Location = new System.Drawing.Point(234, 87);
            this.lbComPortMiniVidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComPortMiniVidas.Name = "lbComPortMiniVidas";
            this.lbComPortMiniVidas.Size = new System.Drawing.Size(81, 20);
            this.lbComPortMiniVidas.TabIndex = 2;
            this.lbComPortMiniVidas.Text = "COM port";
            // 
            // txtComPortMiniVidas
            // 
            this.txtComPortMiniVidas.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtComPortMiniVidas.Location = new System.Drawing.Point(333, 82);
            this.txtComPortMiniVidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComPortMiniVidas.Name = "txtComPortMiniVidas";
            this.txtComPortMiniVidas.Size = new System.Drawing.Size(132, 27);
            this.txtComPortMiniVidas.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lbTitle.Location = new System.Drawing.Point(156, 29);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(194, 28);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "ComPort Tester";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 81);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxBacTecFX
            // 
            this.groupBoxBacTecFX.Controls.Add(this.lbComPortBacTecFX);
            this.groupBoxBacTecFX.Controls.Add(this.txtComPortBacTecFX);
            this.groupBoxBacTecFX.Controls.Add(this.button2);
            this.groupBoxBacTecFX.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBoxBacTecFX.Location = new System.Drawing.Point(17, 226);
            this.groupBoxBacTecFX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBacTecFX.Name = "groupBoxBacTecFX";
            this.groupBoxBacTecFX.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBacTecFX.Size = new System.Drawing.Size(473, 117);
            this.groupBoxBacTecFX.TabIndex = 3;
            this.groupBoxBacTecFX.TabStop = false;
            this.groupBoxBacTecFX.Text = "BacTecFX";
            // 
            // lbComPortBacTecFX
            // 
            this.lbComPortBacTecFX.AutoSize = true;
            this.lbComPortBacTecFX.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbComPortBacTecFX.Location = new System.Drawing.Point(234, 85);
            this.lbComPortBacTecFX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComPortBacTecFX.Name = "lbComPortBacTecFX";
            this.lbComPortBacTecFX.Size = new System.Drawing.Size(81, 20);
            this.lbComPortBacTecFX.TabIndex = 4;
            this.lbComPortBacTecFX.Text = "COM port";
            // 
            // txtComPortBacTecFX
            // 
            this.txtComPortBacTecFX.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtComPortBacTecFX.Location = new System.Drawing.Point(333, 82);
            this.txtComPortBacTecFX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComPortBacTecFX.Name = "txtComPortBacTecFX";
            this.txtComPortBacTecFX.Size = new System.Drawing.Size(132, 27);
            this.txtComPortBacTecFX.TabIndex = 3;
            // 
            // groupBoxBioneerExicycler
            // 
            this.groupBoxBioneerExicycler.Controls.Add(this.lbComPortBioneerExicycler);
            this.groupBoxBioneerExicycler.Controls.Add(this.txtComPortBioneerExicycler);
            this.groupBoxBioneerExicycler.Controls.Add(this.button3);
            this.groupBoxBioneerExicycler.Font = new System.Drawing.Font("Consolas", 12F);
            this.groupBoxBioneerExicycler.Location = new System.Drawing.Point(17, 360);
            this.groupBoxBioneerExicycler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBioneerExicycler.Name = "groupBoxBioneerExicycler";
            this.groupBoxBioneerExicycler.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBioneerExicycler.Size = new System.Drawing.Size(473, 117);
            this.groupBoxBioneerExicycler.TabIndex = 4;
            this.groupBoxBioneerExicycler.TabStop = false;
            this.groupBoxBioneerExicycler.Text = "Bioneer Exicycler";
            // 
            // lbComPortBioneerExicycler
            // 
            this.lbComPortBioneerExicycler.AutoSize = true;
            this.lbComPortBioneerExicycler.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbComPortBioneerExicycler.Location = new System.Drawing.Point(234, 84);
            this.lbComPortBioneerExicycler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComPortBioneerExicycler.Name = "lbComPortBioneerExicycler";
            this.lbComPortBioneerExicycler.Size = new System.Drawing.Size(81, 20);
            this.lbComPortBioneerExicycler.TabIndex = 4;
            this.lbComPortBioneerExicycler.Text = "COM port";
            // 
            // txtComPortBioneerExicycler
            // 
            this.txtComPortBioneerExicycler.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtComPortBioneerExicycler.Location = new System.Drawing.Point(333, 81);
            this.txtComPortBioneerExicycler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComPortBioneerExicycler.Name = "txtComPortBioneerExicycler";
            this.txtComPortBioneerExicycler.Size = new System.Drawing.Size(132, 27);
            this.txtComPortBioneerExicycler.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "Send data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BioneerExicyclerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 516);
            this.Controls.Add(this.groupBoxBioneerExicycler);
            this.Controls.Add(this.groupBoxBacTecFX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxMiniVidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(521, 563);
            this.MinimumSize = new System.Drawing.Size(521, 563);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComPort TEST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxMiniVidas.ResumeLayout(false);
            this.groupBoxMiniVidas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxBacTecFX.ResumeLayout(false);
            this.groupBoxBacTecFX.PerformLayout();
            this.groupBoxBioneerExicycler.ResumeLayout(false);
            this.groupBoxBioneerExicycler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBoxMiniVidas;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxBacTecFX;
        private System.Windows.Forms.GroupBox groupBoxBioneerExicycler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbComPortMiniVidas;
        private System.Windows.Forms.TextBox txtComPortMiniVidas;
        private System.Windows.Forms.Label lbComPortBacTecFX;
        private System.Windows.Forms.TextBox txtComPortBacTecFX;
        private System.Windows.Forms.Label lbComPortBioneerExicycler;
        private System.Windows.Forms.TextBox txtComPortBioneerExicycler;
    }
}

