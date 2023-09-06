namespace weather
{
    partial class Saa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saa));
            this.btnHaku = new System.Windows.Forms.Button();
            this.txtboxHaku = new System.Windows.Forms.TextBox();
            this.lblhaku = new System.Windows.Forms.Label();
            this.lbllampotila = new System.Windows.Forms.Label();
            this.lbLampo = new System.Windows.Forms.Label();
            this.picboxicon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTuuli = new System.Windows.Forms.Label();
            this.lbluv = new System.Windows.Forms.Label();
            this.lbIlmanpaine = new System.Windows.Forms.Label();
            this.lbilmakos = new System.Windows.Forms.Label();
            this.lbIlmankosteus = new System.Windows.Forms.Label();
            this.btnHuominenSaa = new System.Windows.Forms.Button();
            this.btn5pvEnnuste = new System.Windows.Forms.Button();
            this.lbpv1 = new System.Windows.Forms.Label();
            this.lbpv2 = new System.Windows.Forms.Label();
            this.lbpv4 = new System.Windows.Forms.Label();
            this.lbpv3 = new System.Windows.Forms.Label();
            this.lbpv5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxicon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHaku
            // 
            this.btnHaku.Location = new System.Drawing.Point(229, 59);
            this.btnHaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHaku.Name = "btnHaku";
            this.btnHaku.Size = new System.Drawing.Size(113, 34);
            this.btnHaku.TabIndex = 0;
            this.btnHaku.Text = "Hae";
            this.btnHaku.UseVisualStyleBackColor = true;
            this.btnHaku.Click += new System.EventHandler(this.btnHaku_Click);
            // 
            // txtboxHaku
            // 
            this.txtboxHaku.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtboxHaku.Location = new System.Drawing.Point(107, 65);
            this.txtboxHaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxHaku.Name = "txtboxHaku";
            this.txtboxHaku.Size = new System.Drawing.Size(116, 22);
            this.txtboxHaku.TabIndex = 1;
            // 
            // lblhaku
            // 
            this.lblhaku.AutoSize = true;
            this.lblhaku.BackColor = System.Drawing.Color.Transparent;
            this.lblhaku.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhaku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhaku.Location = new System.Drawing.Point(47, 66);
            this.lblhaku.Name = "lblhaku";
            this.lblhaku.Size = new System.Drawing.Size(54, 19);
            this.lblhaku.TabIndex = 2;
            this.lblhaku.Text = "Paikka:";
            // 
            // lbllampotila
            // 
            this.lbllampotila.AutoSize = true;
            this.lbllampotila.BackColor = System.Drawing.Color.Transparent;
            this.lbllampotila.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllampotila.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllampotila.Location = new System.Drawing.Point(37, 114);
            this.lbllampotila.Name = "lbllampotila";
            this.lbllampotila.Size = new System.Drawing.Size(79, 19);
            this.lbllampotila.TabIndex = 3;
            this.lbllampotila.Text = "Lämpötila:";
            // 
            // lbLampo
            // 
            this.lbLampo.AutoSize = true;
            this.lbLampo.BackColor = System.Drawing.Color.Transparent;
            this.lbLampo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLampo.Location = new System.Drawing.Point(133, 118);
            this.lbLampo.Name = "lbLampo";
            this.lbLampo.Size = new System.Drawing.Size(20, 16);
            this.lbLampo.TabIndex = 4;
            this.lbLampo.Text = "°C";
            // 
            // picboxicon
            // 
            this.picboxicon.BackColor = System.Drawing.Color.Transparent;
            this.picboxicon.Location = new System.Drawing.Point(240, 100);
            this.picboxicon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxicon.Name = "picboxicon";
            this.picboxicon.Size = new System.Drawing.Size(101, 48);
            this.picboxicon.TabIndex = 5;
            this.picboxicon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tuulen nopeus:";
            // 
            // lbTuuli
            // 
            this.lbTuuli.AutoSize = true;
            this.lbTuuli.BackColor = System.Drawing.Color.Transparent;
            this.lbTuuli.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuuli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTuuli.Location = new System.Drawing.Point(132, 151);
            this.lbTuuli.Name = "lbTuuli";
            this.lbTuuli.Size = new System.Drawing.Size(34, 19);
            this.lbTuuli.TabIndex = 7;
            this.lbTuuli.Text = "m/s";
            // 
            // lbluv
            // 
            this.lbluv.AutoSize = true;
            this.lbluv.BackColor = System.Drawing.Color.Transparent;
            this.lbluv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbluv.Location = new System.Drawing.Point(35, 190);
            this.lbluv.Name = "lbluv";
            this.lbluv.Size = new System.Drawing.Size(82, 18);
            this.lbluv.TabIndex = 8;
            this.lbluv.Text = "Ilmanpaine:";
            // 
            // lbIlmanpaine
            // 
            this.lbIlmanpaine.AutoSize = true;
            this.lbIlmanpaine.BackColor = System.Drawing.Color.Transparent;
            this.lbIlmanpaine.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIlmanpaine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbIlmanpaine.Location = new System.Drawing.Point(132, 190);
            this.lbIlmanpaine.Name = "lbIlmanpaine";
            this.lbIlmanpaine.Size = new System.Drawing.Size(44, 19);
            this.lbIlmanpaine.TabIndex = 9;
            this.lbIlmanpaine.Text = "mBar";
            // 
            // lbilmakos
            // 
            this.lbilmakos.AutoSize = true;
            this.lbilmakos.BackColor = System.Drawing.Color.Transparent;
            this.lbilmakos.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbilmakos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbilmakos.Location = new System.Drawing.Point(19, 226);
            this.lbilmakos.Name = "lbilmakos";
            this.lbilmakos.Size = new System.Drawing.Size(98, 19);
            this.lbilmakos.TabIndex = 10;
            this.lbilmakos.Text = "Ilmankosteus:";
            // 
            // lbIlmankosteus
            // 
            this.lbIlmankosteus.AutoSize = true;
            this.lbIlmankosteus.BackColor = System.Drawing.Color.Transparent;
            this.lbIlmankosteus.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIlmankosteus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbIlmankosteus.Location = new System.Drawing.Point(132, 226);
            this.lbIlmankosteus.Name = "lbIlmankosteus";
            this.lbIlmankosteus.Size = new System.Drawing.Size(21, 19);
            this.lbIlmankosteus.TabIndex = 11;
            this.lbIlmankosteus.Text = "%";
            // 
            // btnHuominenSaa
            // 
            this.btnHuominenSaa.Location = new System.Drawing.Point(368, 59);
            this.btnHuominenSaa.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuominenSaa.Name = "btnHuominenSaa";
            this.btnHuominenSaa.Size = new System.Drawing.Size(121, 36);
            this.btnHuominenSaa.TabIndex = 12;
            this.btnHuominenSaa.Text = "huomisen sää";
            this.btnHuominenSaa.UseVisualStyleBackColor = true;
            this.btnHuominenSaa.Click += new System.EventHandler(this.btnHuominenSaa_Click);
            // 
            // btn5pvEnnuste
            // 
            this.btn5pvEnnuste.Location = new System.Drawing.Point(517, 59);
            this.btn5pvEnnuste.Margin = new System.Windows.Forms.Padding(4);
            this.btn5pvEnnuste.Name = "btn5pvEnnuste";
            this.btn5pvEnnuste.Size = new System.Drawing.Size(121, 36);
            this.btn5pvEnnuste.TabIndex = 13;
            this.btn5pvEnnuste.Text = "5pv ennuste";
            this.btn5pvEnnuste.UseVisualStyleBackColor = true;
            this.btn5pvEnnuste.Click += new System.EventHandler(this.btn5pvEnnuste_Click);
            // 
            // lbpv1
            // 
            this.lbpv1.AutoSize = true;
            this.lbpv1.BackColor = System.Drawing.Color.Transparent;
            this.lbpv1.ForeColor = System.Drawing.Color.White;
            this.lbpv1.Location = new System.Drawing.Point(531, 118);
            this.lbpv1.Name = "lbpv1";
            this.lbpv1.Size = new System.Drawing.Size(0, 16);
            this.lbpv1.TabIndex = 14;
            // 
            // lbpv2
            // 
            this.lbpv2.AutoSize = true;
            this.lbpv2.BackColor = System.Drawing.Color.Transparent;
            this.lbpv2.ForeColor = System.Drawing.Color.White;
            this.lbpv2.Location = new System.Drawing.Point(531, 152);
            this.lbpv2.Name = "lbpv2";
            this.lbpv2.Size = new System.Drawing.Size(0, 16);
            this.lbpv2.TabIndex = 15;
            // 
            // lbpv4
            // 
            this.lbpv4.AutoSize = true;
            this.lbpv4.BackColor = System.Drawing.Color.Transparent;
            this.lbpv4.ForeColor = System.Drawing.Color.White;
            this.lbpv4.Location = new System.Drawing.Point(531, 226);
            this.lbpv4.Name = "lbpv4";
            this.lbpv4.Size = new System.Drawing.Size(0, 16);
            this.lbpv4.TabIndex = 16;
            // 
            // lbpv3
            // 
            this.lbpv3.AutoSize = true;
            this.lbpv3.BackColor = System.Drawing.Color.Transparent;
            this.lbpv3.ForeColor = System.Drawing.Color.White;
            this.lbpv3.Location = new System.Drawing.Point(531, 190);
            this.lbpv3.Name = "lbpv3";
            this.lbpv3.Size = new System.Drawing.Size(0, 16);
            this.lbpv3.TabIndex = 17;
            // 
            // lbpv5
            // 
            this.lbpv5.AutoSize = true;
            this.lbpv5.BackColor = System.Drawing.Color.Transparent;
            this.lbpv5.ForeColor = System.Drawing.Color.White;
            this.lbpv5.Location = new System.Drawing.Point(531, 263);
            this.lbpv5.Name = "lbpv5";
            this.lbpv5.Size = new System.Drawing.Size(0, 16);
            this.lbpv5.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 475);
            this.Controls.Add(this.lbpv5);
            this.Controls.Add(this.lbpv3);
            this.Controls.Add(this.lbpv4);
            this.Controls.Add(this.lbpv2);
            this.Controls.Add(this.lbpv1);
            this.Controls.Add(this.btn5pvEnnuste);
            this.Controls.Add(this.btnHuominenSaa);
            this.Controls.Add(this.lbIlmankosteus);
            this.Controls.Add(this.lbilmakos);
            this.Controls.Add(this.lbIlmanpaine);
            this.Controls.Add(this.lbluv);
            this.Controls.Add(this.lbTuuli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxicon);
            this.Controls.Add(this.lbLampo);
            this.Controls.Add(this.lbllampotila);
            this.Controls.Add(this.lblhaku);
            this.Controls.Add(this.txtboxHaku);
            this.Controls.Add(this.btnHaku);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sää";
            ((System.ComponentModel.ISupportInitialize)(this.picboxicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHaku;
        private System.Windows.Forms.TextBox txtboxHaku;
        private System.Windows.Forms.Label lblhaku;
        private System.Windows.Forms.Label lbllampotila;
        private System.Windows.Forms.Label lbLampo;
        private System.Windows.Forms.PictureBox picboxicon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTuuli;
        private System.Windows.Forms.Label lbluv;
        private System.Windows.Forms.Label lbIlmanpaine;
        private System.Windows.Forms.Label lbilmakos;
        private System.Windows.Forms.Label lbIlmankosteus;
        private System.Windows.Forms.Button btnHuominenSaa;
        private System.Windows.Forms.Button btn5pvEnnuste;
        private System.Windows.Forms.Label lbpv1;
        private System.Windows.Forms.Label lbpv2;
        private System.Windows.Forms.Label lbpv4;
        private System.Windows.Forms.Label lbpv3;
        private System.Windows.Forms.Label lbpv5;
    }
}

