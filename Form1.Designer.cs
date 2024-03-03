namespace Monto_Articulos_6_2_24
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
            lbl_Monto_Total=new Label();
            lbl_ITBIS=new Label();
            lbl_Monto_Neto=new Label();
            txt_Monto_Neto=new TextBox();
            txt_ITBIS=new TextBox();
            txt_Monto_Total=new TextBox();
            txt_Descuento=new TextBox();
            lbl_Descuento=new Label();
            Calcular=new Button();
            btn_Limpiar=new Button();
            btn_Salir=new Button();
            label1=new Label();
            SuspendLayout();
            // 
            // lbl_Monto_Total
            // 
            lbl_Monto_Total.AutoSize=true;
            lbl_Monto_Total.Font=new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Monto_Total.Location=new Point(222, 76);
            lbl_Monto_Total.Name="lbl_Monto_Total";
            lbl_Monto_Total.Size=new Size(83, 17);
            lbl_Monto_Total.TabIndex=0;
            lbl_Monto_Total.Text="Monto_Total";
            // 
            // lbl_ITBIS
            // 
            lbl_ITBIS.AutoSize=true;
            lbl_ITBIS.Font=new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ITBIS.Location=new Point(247, 228);
            lbl_ITBIS.Name="lbl_ITBIS";
            lbl_ITBIS.Size=new Size(45, 17);
            lbl_ITBIS.TabIndex=1;
            lbl_ITBIS.Text="ITBIS";
            // 
            // lbl_Monto_Neto
            // 
            lbl_Monto_Neto.AutoSize=true;
            lbl_Monto_Neto.Font=new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Monto_Neto.Location=new Point(222, 305);
            lbl_Monto_Neto.Name="lbl_Monto_Neto";
            lbl_Monto_Neto.Size=new Size(83, 17);
            lbl_Monto_Neto.TabIndex=2;
            lbl_Monto_Neto.Text="Monto_Neto";
            // 
            // txt_Monto_Neto
            // 
            txt_Monto_Neto.Location=new Point(312, 297);
            txt_Monto_Neto.Name="txt_Monto_Neto";
            txt_Monto_Neto.Size=new Size(100, 23);
            txt_Monto_Neto.TabIndex=3;
            // 
            // txt_ITBIS
            // 
            txt_ITBIS.Location=new Point(312, 220);
            txt_ITBIS.Name="txt_ITBIS";
            txt_ITBIS.Size=new Size(100, 23);
            txt_ITBIS.TabIndex=4;
            // 
            // txt_Monto_Total
            // 
            txt_Monto_Total.Location=new Point(312, 73);
            txt_Monto_Total.Name="txt_Monto_Total";
            txt_Monto_Total.Size=new Size(100, 23);
            txt_Monto_Total.TabIndex=5;
            // 
            // txt_Descuento
            // 
            txt_Descuento.Location=new Point(312, 147);
            txt_Descuento.Name="txt_Descuento";
            txt_Descuento.Size=new Size(100, 23);
            txt_Descuento.TabIndex=7;
            // 
            // lbl_Descuento
            // 
            lbl_Descuento.AutoSize=true;
            lbl_Descuento.Font=new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Descuento.Location=new Point(222, 150);
            lbl_Descuento.Name="lbl_Descuento";
            lbl_Descuento.Size=new Size(71, 17);
            lbl_Descuento.TabIndex=6;
            lbl_Descuento.Text="Descuento";
            // 
            // Calcular
            // 
            Calcular.BackColor=SystemColors.InactiveCaption;
            Calcular.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Calcular.Location=new Point(564, 111);
            Calcular.Name="Calcular";
            Calcular.Size=new Size(91, 31);
            Calcular.TabIndex=8;
            Calcular.Text="Calcular";
            Calcular.UseVisualStyleBackColor=false;
            Calcular.Click+=Calcular_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor=SystemColors.InactiveCaption;
            btn_Limpiar.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location=new Point(564, 170);
            btn_Limpiar.Name="btn_Limpiar";
            btn_Limpiar.Size=new Size(91, 31);
            btn_Limpiar.TabIndex=9;
            btn_Limpiar.Text="Limpiar";
            btn_Limpiar.UseVisualStyleBackColor=false;
            btn_Limpiar.Click+=btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor=SystemColors.InactiveCaption;
            btn_Salir.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(564, 222);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(91, 31);
            btn_Salir.TabIndex=10;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=false;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(338, 19);
            label1.Name="label1";
            label1.Size=new Size(206, 22);
            label1.TabIndex=11;
            label1.Text="MONTO_ARTICULOS";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(Calcular);
            Controls.Add(txt_Descuento);
            Controls.Add(lbl_Descuento);
            Controls.Add(txt_Monto_Total);
            Controls.Add(txt_ITBIS);
            Controls.Add(txt_Monto_Neto);
            Controls.Add(lbl_Monto_Neto);
            Controls.Add(lbl_ITBIS);
            Controls.Add(lbl_Monto_Total);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Monto_Total;
        private Label lbl_ITBIS;
        private Label lbl_Monto_Neto;
        private TextBox txt_Monto_Neto;
        private TextBox txt_ITBIS;
        private TextBox txt_Monto_Total;
        private TextBox txt_Descuento;
        private Label lbl_Descuento;
        private Button Calcular;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Label label1;
    }
}