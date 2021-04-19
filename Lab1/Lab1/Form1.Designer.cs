
namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_PaisA = new System.Windows.Forms.ComboBox();
            this.btn_Convertir = new System.Windows.Forms.Button();
            this.cb_PaisB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Importe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_CantidadA = new System.Windows.Forms.Label();
            this.lb_CantidadB = new System.Windows.Forms.Label();
            this.lb_TotalConver = new System.Windows.Forms.Label();
            this.lb_Total2Apl = new System.Windows.Forms.Label();
            this.tb_NombrePais = new System.Windows.Forms.TextBox();
            this.cb_Divisa = new System.Windows.Forms.ComboBox();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_PaisA
            // 
            this.cb_PaisA.FormattingEnabled = true;
            this.cb_PaisA.Location = new System.Drawing.Point(187, 43);
            this.cb_PaisA.Name = "cb_PaisA";
            this.cb_PaisA.Size = new System.Drawing.Size(121, 23);
            this.cb_PaisA.TabIndex = 0;
            // 
            // btn_Convertir
            // 
            this.btn_Convertir.Location = new System.Drawing.Point(28, 86);
            this.btn_Convertir.Name = "btn_Convertir";
            this.btn_Convertir.Size = new System.Drawing.Size(75, 23);
            this.btn_Convertir.TabIndex = 1;
            this.btn_Convertir.Text = "Convertir";
            this.btn_Convertir.UseVisualStyleBackColor = true;
            this.btn_Convertir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_PaisB
            // 
            this.cb_PaisB.FormattingEnabled = true;
            this.cb_PaisB.Location = new System.Drawing.Point(355, 44);
            this.cb_PaisB.Name = "cb_PaisB";
            this.cb_PaisB.Size = new System.Drawing.Size(121, 23);
            this.cb_PaisB.TabIndex = 2;
            this.cb_PaisB.SelectedIndexChanged += new System.EventHandler(this.cb_PaisB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(314, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "⮀";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "De A:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "a B:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_Importe
            // 
            this.tb_Importe.Location = new System.Drawing.Point(28, 43);
            this.tb_Importe.Name = "tb_Importe";
            this.tb_Importe.Size = new System.Drawing.Size(131, 23);
            this.tb_Importe.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Importe:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad de divisa A:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad de divisa B:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total de conversion:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total con 2% aplicado:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lb_CantidadA
            // 
            this.lb_CantidadA.AutoSize = true;
            this.lb_CantidadA.Location = new System.Drawing.Point(154, 114);
            this.lb_CantidadA.Name = "lb_CantidadA";
            this.lb_CantidadA.Size = new System.Drawing.Size(44, 15);
            this.lb_CantidadA.TabIndex = 13;
            this.lb_CantidadA.Text = "label10";
            this.lb_CantidadA.Click += new System.EventHandler(this.label10_Click);
            // 
            // lb_CantidadB
            // 
            this.lb_CantidadB.AutoSize = true;
            this.lb_CantidadB.Location = new System.Drawing.Point(154, 158);
            this.lb_CantidadB.Name = "lb_CantidadB";
            this.lb_CantidadB.Size = new System.Drawing.Size(44, 15);
            this.lb_CantidadB.TabIndex = 14;
            this.lb_CantidadB.Text = "label11";
            // 
            // lb_TotalConver
            // 
            this.lb_TotalConver.AutoSize = true;
            this.lb_TotalConver.Location = new System.Drawing.Point(154, 207);
            this.lb_TotalConver.Name = "lb_TotalConver";
            this.lb_TotalConver.Size = new System.Drawing.Size(44, 15);
            this.lb_TotalConver.TabIndex = 15;
            this.lb_TotalConver.Text = "label12";
            // 
            // lb_Total2Apl
            // 
            this.lb_Total2Apl.AutoSize = true;
            this.lb_Total2Apl.Location = new System.Drawing.Point(154, 261);
            this.lb_Total2Apl.Name = "lb_Total2Apl";
            this.lb_Total2Apl.Size = new System.Drawing.Size(44, 15);
            this.lb_Total2Apl.TabIndex = 16;
            this.lb_Total2Apl.Text = "label13";
            this.lb_Total2Apl.Click += new System.EventHandler(this.label13_Click);
            // 
            // tb_NombrePais
            // 
            this.tb_NombrePais.Location = new System.Drawing.Point(545, 227);
            this.tb_NombrePais.Name = "tb_NombrePais";
            this.tb_NombrePais.Size = new System.Drawing.Size(100, 23);
            this.tb_NombrePais.TabIndex = 17;
            // 
            // cb_Divisa
            // 
            this.cb_Divisa.FormattingEnabled = true;
            this.cb_Divisa.Location = new System.Drawing.Point(545, 261);
            this.cb_Divisa.Name = "cb_Divisa";
            this.cb_Divisa.Size = new System.Drawing.Size(100, 23);
            this.cb_Divisa.TabIndex = 18;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(439, 330);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.btn_Crear.TabIndex = 19;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(520, 330);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 20;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(601, 330);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 21;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(683, 329);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrar.TabIndex = 22;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(556, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "CRUD Paises";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(481, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Nombre:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(481, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 15);
            this.label16.TabIndex = 25;
            this.label16.Text = "Divisa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.cb_Divisa);
            this.Controls.Add(this.tb_NombrePais);
            this.Controls.Add(this.lb_Total2Apl);
            this.Controls.Add(this.lb_TotalConver);
            this.Controls.Add(this.lb_CantidadB);
            this.Controls.Add(this.lb_CantidadA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Importe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_PaisB);
            this.Controls.Add(this.btn_Convertir);
            this.Controls.Add(this.cb_PaisA);
            this.Name = "Form1";
            this.Text = "Convertidor de divisas.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_PaisA;
        private System.Windows.Forms.ComboBox cb_PaisB;
        private System.Windows.Forms.Button btn_Convertir;
        private System.Windows.Forms.TextBox tb_Importe;
        private System.Windows.Forms.Label lb_CantidadA;
        private System.Windows.Forms.Label lb_CantidadB;
        private System.Windows.Forms.Label lb_TotalConver;
        private System.Windows.Forms.Label lb_Total2Apl;
        private System.Windows.Forms.TextBox tb_NombrePais;
        private System.Windows.Forms.ComboBox cb_Divisa;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Borrar;
    }
}

