﻿namespace calc_polation_2022
{
    partial class CALPO_Cuadratica
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
            this.gb_results = new System.Windows.Forms.GroupBox();
            this.lbox_results = new System.Windows.Forms.ListBox();
            this.gb_values = new System.Windows.Forms.GroupBox();
            this.txt_y2 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.lbl_y2 = new System.Windows.Forms.Label();
            this.lbl_x2 = new System.Windows.Forms.Label();
            this.txt_fx = new System.Windows.Forms.TextBox();
            this.lbl_fx = new System.Windows.Forms.Label();
            this.txt_y1 = new System.Windows.Forms.TextBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_y0 = new System.Windows.Forms.TextBox();
            this.txt_x0 = new System.Windows.Forms.TextBox();
            this.lbl_y1 = new System.Windows.Forms.Label();
            this.lbl_y0 = new System.Windows.Forms.Label();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.lbl_x0 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.lbl_x = new System.Windows.Forms.Label();
            this.gb_options = new System.Windows.Forms.GroupBox();
            this.cb_calculate_percent = new System.Windows.Forms.CheckBox();
            this.gb_results_type = new System.Windows.Forms.GroupBox();
            this.rb_last4dec = new System.Windows.Forms.RadioButton();
            this.rb_redondeo = new System.Windows.Forms.RadioButton();
            this.rb_noRedondeo = new System.Windows.Forms.RadioButton();
            this.btn_reset = new FontAwesome.Sharp.IconButton();
            this.btn_calculate = new FontAwesome.Sharp.IconButton();
            this.lbl_va = new System.Windows.Forms.Label();
            this.lbl_vv = new System.Windows.Forms.Label();
            this.gb_results.SuspendLayout();
            this.gb_values.SuspendLayout();
            this.gb_options.SuspendLayout();
            this.gb_results_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_results
            // 
            this.gb_results.Controls.Add(this.lbox_results);
            this.gb_results.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_results.Location = new System.Drawing.Point(169, 11);
            this.gb_results.Name = "gb_results";
            this.gb_results.Size = new System.Drawing.Size(573, 340);
            this.gb_results.TabIndex = 6;
            this.gb_results.TabStop = false;
            this.gb_results.Text = "Resultados";
            // 
            // lbox_results
            // 
            this.lbox_results.BackColor = System.Drawing.SystemColors.Control;
            this.lbox_results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbox_results.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbox_results.HorizontalScrollbar = true;
            this.lbox_results.ItemHeight = 22;
            this.lbox_results.Items.AddRange(new object[] {
            "FÓRMULA DE LA INTERPOLACIÓN CUADRÁTICA",
            "",
            "• f(x) = b₀ + b₁ (x - x₀) + b₂ (x - x₀) (x - x₁)",
            "",
            "donde...",
            "",
            "• b₀ = f(x₀)",
            "• b₁ = f(x₁) - f(x₀) ÷ x₁ - x₀",
            "• b₂ = ((f(x₂) - f(x₁)) ÷ (x₂ - x₁)) - ((f(x₁) - f(x₀)) ÷ (x₁ - x₀)) ÷ x₂ - x₀"});
            this.lbox_results.Location = new System.Drawing.Point(11, 22);
            this.lbox_results.Name = "lbox_results";
            this.lbox_results.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbox_results.Size = new System.Drawing.Size(551, 308);
            this.lbox_results.TabIndex = 4;
            this.lbox_results.TabStop = false;
            // 
            // gb_values
            // 
            this.gb_values.Controls.Add(this.lbl_va);
            this.gb_values.Controls.Add(this.lbl_vv);
            this.gb_values.Controls.Add(this.txt_y2);
            this.gb_values.Controls.Add(this.txt_x2);
            this.gb_values.Controls.Add(this.lbl_y2);
            this.gb_values.Controls.Add(this.lbl_x2);
            this.gb_values.Controls.Add(this.txt_fx);
            this.gb_values.Controls.Add(this.lbl_fx);
            this.gb_values.Controls.Add(this.txt_y1);
            this.gb_values.Controls.Add(this.txt_x1);
            this.gb_values.Controls.Add(this.txt_y0);
            this.gb_values.Controls.Add(this.txt_x0);
            this.gb_values.Controls.Add(this.lbl_y1);
            this.gb_values.Controls.Add(this.lbl_y0);
            this.gb_values.Controls.Add(this.lbl_x1);
            this.gb_values.Controls.Add(this.lbl_x0);
            this.gb_values.Controls.Add(this.txt_x);
            this.gb_values.Controls.Add(this.lbl_x);
            this.gb_values.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_values.Location = new System.Drawing.Point(12, 351);
            this.gb_values.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_values.Name = "gb_values";
            this.gb_values.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_values.Size = new System.Drawing.Size(729, 251);
            this.gb_values.TabIndex = 5;
            this.gb_values.TabStop = false;
            this.gb_values.Text = "Valores";
            // 
            // txt_y2
            // 
            this.txt_y2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_y2.Location = new System.Drawing.Point(430, 200);
            this.txt_y2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_y2.Name = "txt_y2";
            this.txt_y2.PlaceholderText = "número";
            this.txt_y2.ShortcutsEnabled = false;
            this.txt_y2.Size = new System.Drawing.Size(289, 36);
            this.txt_y2.TabIndex = 16;
            this.txt_y2.Text = "0";
            this.txt_y2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_y2_KeyPress);
            // 
            // txt_x2
            // 
            this.txt_x2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_x2.Location = new System.Drawing.Point(64, 200);
            this.txt_x2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.PlaceholderText = "número";
            this.txt_x2.ShortcutsEnabled = false;
            this.txt_x2.Size = new System.Drawing.Size(265, 36);
            this.txt_x2.TabIndex = 15;
            this.txt_x2.Text = "0";
            this.txt_x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x2_KeyPress);
            // 
            // lbl_y2
            // 
            this.lbl_y2.AutoSize = true;
            this.lbl_y2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_y2.Location = new System.Drawing.Point(338, 202);
            this.lbl_y2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_y2.Name = "lbl_y2";
            this.lbl_y2.Size = new System.Drawing.Size(85, 28);
            this.lbl_y2.TabIndex = 14;
            this.lbl_y2.Text = "F(X₂) =";
            // 
            // lbl_x2
            // 
            this.lbl_x2.AutoSize = true;
            this.lbl_x2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x2.Location = new System.Drawing.Point(9, 202);
            this.lbl_x2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x2.Name = "lbl_x2";
            this.lbl_x2.Size = new System.Drawing.Size(54, 28);
            this.lbl_x2.TabIndex = 13;
            this.lbl_x2.Text = "X₂ =";
            // 
            // txt_fx
            // 
            this.txt_fx.Enabled = false;
            this.txt_fx.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_fx.Location = new System.Drawing.Point(430, 28);
            this.txt_fx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_fx.Name = "txt_fx";
            this.txt_fx.PlaceholderText = "número";
            this.txt_fx.ShortcutsEnabled = false;
            this.txt_fx.Size = new System.Drawing.Size(289, 36);
            this.txt_fx.TabIndex = 12;
            this.txt_fx.Text = "0";
            this.txt_fx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fx_KeyPress);
            // 
            // lbl_fx
            // 
            this.lbl_fx.AutoSize = true;
            this.lbl_fx.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_fx.Location = new System.Drawing.Point(338, 30);
            this.lbl_fx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fx.Name = "lbl_fx";
            this.lbl_fx.Size = new System.Drawing.Size(75, 28);
            this.lbl_fx.TabIndex = 11;
            this.lbl_fx.Text = "F(X) =";
            // 
            // txt_y1
            // 
            this.txt_y1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_y1.Location = new System.Drawing.Point(430, 141);
            this.txt_y1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_y1.Name = "txt_y1";
            this.txt_y1.PlaceholderText = "número";
            this.txt_y1.ShortcutsEnabled = false;
            this.txt_y1.Size = new System.Drawing.Size(289, 36);
            this.txt_y1.TabIndex = 10;
            this.txt_y1.Text = "0";
            this.txt_y1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_y1_KeyPress);
            // 
            // txt_x1
            // 
            this.txt_x1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_x1.Location = new System.Drawing.Point(64, 141);
            this.txt_x1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.PlaceholderText = "número";
            this.txt_x1.ShortcutsEnabled = false;
            this.txt_x1.Size = new System.Drawing.Size(265, 36);
            this.txt_x1.TabIndex = 9;
            this.txt_x1.Text = "0";
            this.txt_x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x1_KeyPress);
            // 
            // txt_y0
            // 
            this.txt_y0.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_y0.Location = new System.Drawing.Point(430, 84);
            this.txt_y0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_y0.Name = "txt_y0";
            this.txt_y0.PlaceholderText = "número";
            this.txt_y0.ShortcutsEnabled = false;
            this.txt_y0.Size = new System.Drawing.Size(289, 36);
            this.txt_y0.TabIndex = 8;
            this.txt_y0.Text = "0";
            this.txt_y0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_y0_KeyPress);
            // 
            // txt_x0
            // 
            this.txt_x0.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_x0.Location = new System.Drawing.Point(64, 84);
            this.txt_x0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_x0.Name = "txt_x0";
            this.txt_x0.PlaceholderText = "número";
            this.txt_x0.ShortcutsEnabled = false;
            this.txt_x0.Size = new System.Drawing.Size(265, 36);
            this.txt_x0.TabIndex = 7;
            this.txt_x0.Text = "0";
            this.txt_x0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x0_KeyPress);
            // 
            // lbl_y1
            // 
            this.lbl_y1.AutoSize = true;
            this.lbl_y1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_y1.Location = new System.Drawing.Point(338, 143);
            this.lbl_y1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_y1.Name = "lbl_y1";
            this.lbl_y1.Size = new System.Drawing.Size(85, 28);
            this.lbl_y1.TabIndex = 5;
            this.lbl_y1.Text = "F(X₁) =";
            // 
            // lbl_y0
            // 
            this.lbl_y0.AutoSize = true;
            this.lbl_y0.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_y0.Location = new System.Drawing.Point(338, 86);
            this.lbl_y0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_y0.Name = "lbl_y0";
            this.lbl_y0.Size = new System.Drawing.Size(85, 28);
            this.lbl_y0.TabIndex = 4;
            this.lbl_y0.Text = "F(X₀) =";
            // 
            // lbl_x1
            // 
            this.lbl_x1.AutoSize = true;
            this.lbl_x1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x1.Location = new System.Drawing.Point(9, 143);
            this.lbl_x1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x1.Name = "lbl_x1";
            this.lbl_x1.Size = new System.Drawing.Size(54, 28);
            this.lbl_x1.TabIndex = 3;
            this.lbl_x1.Text = "X₁ =";
            // 
            // lbl_x0
            // 
            this.lbl_x0.AutoSize = true;
            this.lbl_x0.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x0.Location = new System.Drawing.Point(9, 86);
            this.lbl_x0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x0.Name = "lbl_x0";
            this.lbl_x0.Size = new System.Drawing.Size(54, 28);
            this.lbl_x0.TabIndex = 2;
            this.lbl_x0.Text = "X₀ =";
            // 
            // txt_x
            // 
            this.txt_x.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_x.Location = new System.Drawing.Point(64, 28);
            this.txt_x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_x.Name = "txt_x";
            this.txt_x.PlaceholderText = "número";
            this.txt_x.ShortcutsEnabled = false;
            this.txt_x.Size = new System.Drawing.Size(265, 36);
            this.txt_x.TabIndex = 6;
            this.txt_x.Text = "0";
            this.txt_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x_KeyPress);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x.Location = new System.Drawing.Point(13, 30);
            this.lbl_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(44, 28);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "X =";
            // 
            // gb_options
            // 
            this.gb_options.Controls.Add(this.cb_calculate_percent);
            this.gb_options.Controls.Add(this.gb_results_type);
            this.gb_options.Controls.Add(this.btn_reset);
            this.gb_options.Controls.Add(this.btn_calculate);
            this.gb_options.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_options.Location = new System.Drawing.Point(12, 11);
            this.gb_options.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_options.Name = "gb_options";
            this.gb_options.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_options.Size = new System.Drawing.Size(150, 340);
            this.gb_options.TabIndex = 4;
            this.gb_options.TabStop = false;
            this.gb_options.Text = "Opciones";
            // 
            // cb_calculate_percent
            // 
            this.cb_calculate_percent.AutoSize = true;
            this.cb_calculate_percent.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_calculate_percent.Location = new System.Drawing.Point(6, 177);
            this.cb_calculate_percent.Name = "cb_calculate_percent";
            this.cb_calculate_percent.Size = new System.Drawing.Size(126, 34);
            this.cb_calculate_percent.TabIndex = 7;
            this.cb_calculate_percent.Text = "Calcular error\r\nrelativo porcentual";
            this.cb_calculate_percent.UseVisualStyleBackColor = true;
            this.cb_calculate_percent.CheckedChanged += new System.EventHandler(this.cb_calculate_percent_CheckedChanged);
            // 
            // gb_results_type
            // 
            this.gb_results_type.Controls.Add(this.rb_last4dec);
            this.gb_results_type.Controls.Add(this.rb_redondeo);
            this.gb_results_type.Controls.Add(this.rb_noRedondeo);
            this.gb_results_type.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_results_type.Location = new System.Drawing.Point(6, 226);
            this.gb_results_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_results_type.Name = "gb_results_type";
            this.gb_results_type.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_results_type.Size = new System.Drawing.Size(139, 108);
            this.gb_results_type.TabIndex = 2;
            this.gb_results_type.TabStop = false;
            this.gb_results_type.Text = "Tipo de Resultado";
            // 
            // rb_last4dec
            // 
            this.rb_last4dec.AutoSize = true;
            this.rb_last4dec.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_last4dec.Location = new System.Drawing.Point(9, 65);
            this.rb_last4dec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_last4dec.Name = "rb_last4dec";
            this.rb_last4dec.Size = new System.Drawing.Size(78, 34);
            this.rb_last4dec.TabIndex = 5;
            this.rb_last4dec.Text = "Últimos 4\r\ndecimales";
            this.rb_last4dec.UseVisualStyleBackColor = true;
            // 
            // rb_redondeo
            // 
            this.rb_redondeo.AutoSize = true;
            this.rb_redondeo.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_redondeo.Location = new System.Drawing.Point(9, 40);
            this.rb_redondeo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_redondeo.Name = "rb_redondeo";
            this.rb_redondeo.Size = new System.Drawing.Size(82, 19);
            this.rb_redondeo.TabIndex = 3;
            this.rb_redondeo.Text = "Redondear";
            this.rb_redondeo.UseVisualStyleBackColor = true;
            // 
            // rb_noRedondeo
            // 
            this.rb_noRedondeo.AutoSize = true;
            this.rb_noRedondeo.Checked = true;
            this.rb_noRedondeo.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_noRedondeo.Location = new System.Drawing.Point(9, 15);
            this.rb_noRedondeo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_noRedondeo.Name = "rb_noRedondeo";
            this.rb_noRedondeo.Size = new System.Drawing.Size(100, 19);
            this.rb_noRedondeo.TabIndex = 2;
            this.rb_noRedondeo.TabStop = true;
            this.rb_noRedondeo.Text = "Sin redondear";
            this.rb_noRedondeo.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_reset.IconColor = System.Drawing.Color.Black;
            this.btn_reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reset.Location = new System.Drawing.Point(6, 113);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(139, 51);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reiniciar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calculate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_calculate.IconColor = System.Drawing.Color.Black;
            this.btn_calculate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_calculate.Location = new System.Drawing.Point(6, 22);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(139, 85);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calcular\r";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_va
            // 
            this.lbl_va.AutoSize = true;
            this.lbl_va.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_va.Location = new System.Drawing.Point(430, 10);
            this.lbl_va.Name = "lbl_va";
            this.lbl_va.Size = new System.Drawing.Size(132, 15);
            this.lbl_va.TabIndex = 18;
            this.lbl_va.Text = "VALOR APROXIMADO";
            this.lbl_va.Visible = false;
            // 
            // lbl_vv
            // 
            this.lbl_vv.AutoSize = true;
            this.lbl_vv.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vv.Location = new System.Drawing.Point(64, 10);
            this.lbl_vv.Name = "lbl_vv";
            this.lbl_vv.Size = new System.Drawing.Size(121, 15);
            this.lbl_vv.TabIndex = 17;
            this.lbl_vv.Text = "VALOR VERDADERO";
            this.lbl_vv.Visible = false;
            // 
            // CALPO_Cuadratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 614);
            this.Controls.Add(this.gb_results);
            this.Controls.Add(this.gb_values);
            this.Controls.Add(this.gb_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CALPO_Cuadratica";
            this.Text = "CALPO: Interpolación Cuadrática";
            this.Load += new System.EventHandler(this.CALPO_Cuadratica_Load);
            this.gb_results.ResumeLayout(false);
            this.gb_values.ResumeLayout(false);
            this.gb_values.PerformLayout();
            this.gb_options.ResumeLayout(false);
            this.gb_options.PerformLayout();
            this.gb_results_type.ResumeLayout(false);
            this.gb_results_type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_results;
        private ListBox lbox_results;
        private GroupBox gb_values;
        private TextBox txt_fx;
        private Label lbl_fx;
        private TextBox txt_y1;
        private TextBox txt_x1;
        private TextBox txt_y0;
        private TextBox txt_x0;
        private Label lbl_y1;
        private Label lbl_y0;
        private Label lbl_x1;
        private Label lbl_x0;
        private TextBox txt_x;
        private Label lbl_x;
        private GroupBox gb_options;
        private CheckBox cb_calculate_percent;
        private GroupBox gb_results_type;
        private RadioButton rb_last4dec;
        private RadioButton rb_redondeo;
        private RadioButton rb_noRedondeo;
        private FontAwesome.Sharp.IconButton btn_reset;
        private FontAwesome.Sharp.IconButton btn_calculate;
        private TextBox txt_y2;
        private TextBox txt_x2;
        private Label lbl_y2;
        private Label lbl_x2;
        private Label lbl_va;
        private Label lbl_vv;
    }
}