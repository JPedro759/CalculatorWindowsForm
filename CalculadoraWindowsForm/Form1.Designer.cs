namespace CalculadoraWindowsForm
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnseta = new System.Windows.Forms.Button();
            this.btnfraçao = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btnMRN = new System.Windows.Forms.Button();
            this.btnMRP = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btninversao = new System.Windows.Forms.Button();
            this.btnporcentagem = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.btnsubtraçao = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnvirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblconta = new System.Windows.Forms.TextBox();
            this.txtMemoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(128, 140);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(52, 49);
            this.btnC.TabIndex = 56;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(70, 140);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(52, 49);
            this.btnCE.TabIndex = 55;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnseta
            // 
            this.btnseta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseta.Location = new System.Drawing.Point(12, 140);
            this.btnseta.Name = "btnseta";
            this.btnseta.Size = new System.Drawing.Size(52, 49);
            this.btnseta.TabIndex = 54;
            this.btnseta.Text = "←";
            this.btnseta.UseVisualStyleBackColor = true;
            this.btnseta.Click += new System.EventHandler(this.btnseta_Click);
            // 
            // btnfraçao
            // 
            this.btnfraçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfraçao.Location = new System.Drawing.Point(244, 250);
            this.btnfraçao.Name = "btnfraçao";
            this.btnfraçao.Size = new System.Drawing.Size(52, 49);
            this.btnfraçao.TabIndex = 53;
            this.btnfraçao.Text = "1/x";
            this.btnfraçao.UseVisualStyleBackColor = true;
            this.btnfraçao.Click += new System.EventHandler(this.btnfraçao_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmulti.Location = new System.Drawing.Point(186, 250);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(52, 49);
            this.btnmulti.TabIndex = 52;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnMRN
            // 
            this.btnMRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRN.Location = new System.Drawing.Point(244, 87);
            this.btnMRN.Name = "btnMRN";
            this.btnMRN.Size = new System.Drawing.Size(52, 49);
            this.btnMRN.TabIndex = 51;
            this.btnMRN.Text = "M-";
            this.btnMRN.Click += new System.EventHandler(this.btnMRN_Click);
            // 
            // btnMRP
            // 
            this.btnMRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRP.Location = new System.Drawing.Point(186, 87);
            this.btnMRP.Name = "btnMRP";
            this.btnMRP.Size = new System.Drawing.Size(52, 49);
            this.btnMRP.TabIndex = 50;
            this.btnMRP.Text = "M+";
            this.btnMRP.UseVisualStyleBackColor = true;
            this.btnMRP.Click += new System.EventHandler(this.btnMRP_Click);
            // 
            // btnMS
            // 
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.Location = new System.Drawing.Point(128, 87);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(52, 49);
            this.btnMS.TabIndex = 49;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(70, 87);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(52, 49);
            this.btnMR.TabIndex = 48;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(12, 87);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(52, 49);
            this.btnMC.TabIndex = 47;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraiz.Location = new System.Drawing.Point(244, 140);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(52, 49);
            this.btnraiz.TabIndex = 46;
            this.btnraiz.Text = "√";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // btninversao
            // 
            this.btninversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninversao.Location = new System.Drawing.Point(186, 140);
            this.btninversao.Name = "btninversao";
            this.btninversao.Size = new System.Drawing.Size(52, 49);
            this.btninversao.TabIndex = 45;
            this.btninversao.Text = "+/-";
            this.btninversao.UseVisualStyleBackColor = true;
            this.btninversao.Click += new System.EventHandler(this.btninversao_Click);
            // 
            // btnporcentagem
            // 
            this.btnporcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcentagem.Location = new System.Drawing.Point(244, 195);
            this.btnporcentagem.Name = "btnporcentagem";
            this.btnporcentagem.Size = new System.Drawing.Size(52, 49);
            this.btnporcentagem.TabIndex = 44;
            this.btnporcentagem.Text = "%";
            this.btnporcentagem.UseVisualStyleBackColor = true;
            this.btnporcentagem.Click += new System.EventHandler(this.btnporcentagem_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivisao.Location = new System.Drawing.Point(186, 195);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(52, 49);
            this.btndivisao.TabIndex = 43;
            this.btndivisao.Text = "/";
            this.btndivisao.UseVisualStyleBackColor = true;
            this.btndivisao.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnsubtraçao
            // 
            this.btnsubtraçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtraçao.Location = new System.Drawing.Point(186, 305);
            this.btnsubtraçao.Name = "btnsubtraçao";
            this.btnsubtraçao.Size = new System.Drawing.Size(52, 49);
            this.btnsubtraçao.TabIndex = 42;
            this.btnsubtraçao.Text = "-";
            this.btnsubtraçao.UseVisualStyleBackColor = true;
            this.btnsubtraçao.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnigual
            // 
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(245, 305);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(52, 104);
            this.btnigual.TabIndex = 41;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnsoma
            // 
            this.btnsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoma.Location = new System.Drawing.Point(186, 360);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(52, 49);
            this.btnsoma.TabIndex = 40;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnvirgula
            // 
            this.btnvirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvirgula.Location = new System.Drawing.Point(128, 360);
            this.btnvirgula.Name = "btnvirgula";
            this.btnvirgula.Size = new System.Drawing.Size(52, 49);
            this.btnvirgula.TabIndex = 39;
            this.btnvirgula.Text = ",";
            this.btnvirgula.UseVisualStyleBackColor = true;
            this.btnvirgula.Click += new System.EventHandler(this.btnvirgula_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 360);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(110, 49);
            this.btn0.TabIndex = 38;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(128, 305);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 49);
            this.btn9.TabIndex = 37;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(70, 305);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 49);
            this.btn8.TabIndex = 36;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 305);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 49);
            this.btn7.TabIndex = 35;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(128, 250);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 49);
            this.btn6.TabIndex = 34;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(70, 250);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 49);
            this.btn5.TabIndex = 33;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 250);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 49);
            this.btn4.TabIndex = 32;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(128, 195);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 49);
            this.btn3.TabIndex = 31;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(70, 195);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 49);
            this.btn2.TabIndex = 30;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.bnt_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 195);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 49);
            this.btn1.TabIndex = 29;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.bnt_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(43, 38);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(253, 32);
            this.txtresultado.TabIndex = 57;
            this.txtresultado.Text = "0";
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblconta
            // 
            this.lblconta.Enabled = false;
            this.lblconta.Location = new System.Drawing.Point(12, 12);
            this.lblconta.Name = "lblconta";
            this.lblconta.Size = new System.Drawing.Size(284, 20);
            this.lblconta.TabIndex = 58;
            this.lblconta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMemoria
            // 
            this.txtMemoria.Enabled = false;
            this.txtMemoria.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemoria.Location = new System.Drawing.Point(12, 38);
            this.txtMemoria.Name = "txtMemoria";
            this.txtMemoria.Size = new System.Drawing.Size(35, 32);
            this.txtMemoria.TabIndex = 59;
            this.txtMemoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 418);
            this.Controls.Add(this.txtMemoria);
            this.Controls.Add(this.lblconta);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnseta);
            this.Controls.Add(this.btnfraçao);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnMRN);
            this.Controls.Add(this.btnMRP);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btninversao);
            this.Controls.Add(this.btnporcentagem);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btnsubtraçao);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.btnvirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnseta;
        private System.Windows.Forms.Button btnfraçao;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btnMRN;
        private System.Windows.Forms.Button btnMRP;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btninversao;
        private System.Windows.Forms.Button btnporcentagem;
        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.Button btnsubtraçao;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnvirgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.TextBox lblconta;
        private System.Windows.Forms.TextBox txtMemoria;
    }
}

