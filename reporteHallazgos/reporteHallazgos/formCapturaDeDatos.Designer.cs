using System.Windows.Forms;
namespace reporteHallazgos
{    
    partial class formCapturaDeDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCapturaDeDatos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.comboBoxEnterado = new System.Windows.Forms.ComboBox();
            this.textBoxPedido = new System.Windows.Forms.TextBox();
            this.comboBoxResponsables = new System.Windows.Forms.ComboBox();
            this.textBoxCantidadInicial = new System.Windows.Forms.TextBox();
            this.comboBoxUnidadesInicial = new System.Windows.Forms.ComboBox();
            this.comboBoxDisposicion = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.richTextBoxObservaciones = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCausa = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCausaDesconocida = new System.Windows.Forms.CheckBox();
            this.buttonGeneraReporte = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.richTextBoxInspeccionesRealizadas = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxDatosDePersonal = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBoxAyudanteEnTurno = new System.Windows.Forms.ComboBox();
            this.comboBoxOperadorEnTurno = new System.Windows.Forms.ComboBox();
            this.comboBoxInspectorDeCalidadEnTurno = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBoxSupervisorEnTurno = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.comboBoxIdentificadoPor = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBoxCantidades = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBoxUnidadesFinal = new System.Windows.Forms.ComboBox();
            this.textBoxCantidadFinal = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonCapturarLotes = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCantidadDeLotes = new System.Windows.Forms.TextBox();
            this.textBoxPrefijo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxPerfil = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarDatos = new System.Windows.Forms.Button();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxCorte = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxCalibre = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxDatosDePersonal.SuspendLayout();
            this.groupBoxCantidades.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor llena los campos para la generación del reporte: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(135, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(139, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Turno: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(152, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enterado: ";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(56, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cantidad de lotes: ";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(123, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pedido: ";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(26, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cantidad inicial";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(86, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Responsable: ";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(34, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Disposición: ";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(17, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Descripción: ";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(74, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Probable causa: ";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(11, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Probable causa: ";
            this.label13.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(203, 77);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(181, 26);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "mixto"});
            this.comboBoxTurno.Location = new System.Drawing.Point(203, 109);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(181, 28);
            this.comboBoxTurno.TabIndex = 2;
            // 
            // comboBoxEnterado
            // 
            this.comboBoxEnterado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnterado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxEnterado.FormattingEnabled = true;
            this.comboBoxEnterado.Location = new System.Drawing.Point(248, 210);
            this.comboBoxEnterado.Name = "comboBoxEnterado";
            this.comboBoxEnterado.Size = new System.Drawing.Size(181, 28);
            this.comboBoxEnterado.TabIndex = 3;
            // 
            // textBoxPedido
            // 
            this.textBoxPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPedido.Location = new System.Drawing.Point(203, 177);
            this.textBoxPedido.Name = "textBoxPedido";
            this.textBoxPedido.Size = new System.Drawing.Size(181, 26);
            this.textBoxPedido.TabIndex = 4;
            this.textBoxPedido.Text = "PMM ";
            // 
            // comboBoxResponsables
            // 
            this.comboBoxResponsables.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxResponsables.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxResponsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxResponsables.FormattingEnabled = true;
            this.comboBoxResponsables.Location = new System.Drawing.Point(203, 143);
            this.comboBoxResponsables.Name = "comboBoxResponsables";
            this.comboBoxResponsables.Size = new System.Drawing.Size(181, 28);
            this.comboBoxResponsables.TabIndex = 5;
            // 
            // textBoxCantidadInicial
            // 
            this.textBoxCantidadInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCantidadInicial.Location = new System.Drawing.Point(147, 29);
            this.textBoxCantidadInicial.Name = "textBoxCantidadInicial";
            this.textBoxCantidadInicial.Size = new System.Drawing.Size(181, 26);
            this.textBoxCantidadInicial.TabIndex = 4;
            // 
            // comboBoxUnidadesInicial
            // 
            this.comboBoxUnidadesInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidadesInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUnidadesInicial.FormattingEnabled = true;
            this.comboBoxUnidadesInicial.Items.AddRange(new object[] {
            "Kg.",
            "Lb.",
            "Cajas",
            "Mazos",
            "Carretes"});
            this.comboBoxUnidadesInicial.Location = new System.Drawing.Point(334, 27);
            this.comboBoxUnidadesInicial.Name = "comboBoxUnidadesInicial";
            this.comboBoxUnidadesInicial.Size = new System.Drawing.Size(122, 28);
            this.comboBoxUnidadesInicial.TabIndex = 5;
            // 
            // comboBoxDisposicion
            // 
            this.comboBoxDisposicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDisposicion.FormattingEnabled = true;
            this.comboBoxDisposicion.Items.AddRange(new object[] {
            "Rechazado",
            "Reinspección",
            "Retrabajo",
            "Reclasificado"});
            this.comboBoxDisposicion.Location = new System.Drawing.Point(147, 93);
            this.comboBoxDisposicion.Name = "comboBoxDisposicion";
            this.comboBoxDisposicion.Size = new System.Drawing.Size(181, 28);
            this.comboBoxDisposicion.TabIndex = 5;
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(15, 54);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(972, 67);
            this.richTextBoxDescripcion.TabIndex = 6;
            this.richTextBoxDescripcion.Text = "";
            // 
            // richTextBoxObservaciones
            // 
            this.richTextBoxObservaciones.Location = new System.Drawing.Point(15, 378);
            this.richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            this.richTextBoxObservaciones.Size = new System.Drawing.Size(972, 81);
            this.richTextBoxObservaciones.TabIndex = 6;
            this.richTextBoxObservaciones.Text = "";
            // 
            // richTextBoxCausa
            // 
            this.richTextBoxCausa.Location = new System.Drawing.Point(15, 285);
            this.richTextBoxCausa.Name = "richTextBoxCausa";
            this.richTextBoxCausa.Size = new System.Drawing.Size(972, 67);
            this.richTextBoxCausa.TabIndex = 6;
            this.richTextBoxCausa.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCausaDesconocida);
            this.groupBox1.Controls.Add(this.buttonGeneraReporte);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.richTextBoxCausa);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.richTextBoxObservaciones);
            this.groupBox1.Controls.Add(this.richTextBoxInspeccionesRealizadas);
            this.groupBox1.Controls.Add(this.richTextBoxDescripcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(12, 752);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 567);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.groupBox1_MouseCaptureChanged);
            // 
            // checkBoxCausaDesconocida
            // 
            this.checkBoxCausaDesconocida.AutoSize = true;
            this.checkBoxCausaDesconocida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBoxCausaDesconocida.Location = new System.Drawing.Point(144, 262);
            this.checkBoxCausaDesconocida.Name = "checkBoxCausaDesconocida";
            this.checkBoxCausaDesconocida.Size = new System.Drawing.Size(162, 22);
            this.checkBoxCausaDesconocida.TabIndex = 8;
            this.checkBoxCausaDesconocida.Text = "Causa Desconocida";
            this.checkBoxCausaDesconocida.UseVisualStyleBackColor = true;
            this.checkBoxCausaDesconocida.CheckedChanged += new System.EventHandler(this.checkBoxCausaDesconocida_CheckedChanged);
            // 
            // buttonGeneraReporte
            // 
            this.buttonGeneraReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonGeneraReporte.Location = new System.Drawing.Point(15, 481);
            this.buttonGeneraReporte.Name = "buttonGeneraReporte";
            this.buttonGeneraReporte.Size = new System.Drawing.Size(972, 52);
            this.buttonGeneraReporte.TabIndex = 7;
            this.buttonGeneraReporte.Text = "Generar reporte";
            this.buttonGeneraReporte.UseVisualStyleBackColor = true;
            this.buttonGeneraReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label38.Location = new System.Drawing.Point(11, 139);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(187, 20);
            this.label38.TabIndex = 0;
            this.label38.Text = "Inspecciones realizadas: ";
            this.label38.Click += new System.EventHandler(this.label3_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(-6, 262);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(20, 25);
            this.label28.TabIndex = 7;
            this.label28.Text = "*";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(0, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 25);
            this.label27.TabIndex = 7;
            this.label27.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(11, 355);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Observaciones: ";
            this.label16.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBoxInspeccionesRealizadas
            // 
            this.richTextBoxInspeccionesRealizadas.Location = new System.Drawing.Point(15, 162);
            this.richTextBoxInspeccionesRealizadas.Name = "richTextBoxInspeccionesRealizadas";
            this.richTextBoxInspeccionesRealizadas.Size = new System.Drawing.Size(972, 67);
            this.richTextBoxInspeccionesRealizadas.TabIndex = 6;
            this.richTextBoxInspeccionesRealizadas.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxDatosDePersonal);
            this.groupBox2.Controls.Add(this.groupBoxCantidades);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.buttonCapturarLotes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxResponsables);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxPedido);
            this.groupBox2.Controls.Add(this.textBoxCantidadDeLotes);
            this.groupBox2.Controls.Add(this.textBoxPrefijo);
            this.groupBox2.Controls.Add(this.comboBoxTurno);
            this.groupBox2.Controls.Add(this.dateTimePickerFecha);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1012, 531);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos generales";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            this.groupBox2.MouseCaptureChanged += new System.EventHandler(this.groupBox2_MouseCaptureChanged);
            // 
            // groupBoxDatosDePersonal
            // 
            this.groupBoxDatosDePersonal.Controls.Add(this.label29);
            this.groupBoxDatosDePersonal.Controls.Add(this.comboBoxEnterado);
            this.groupBoxDatosDePersonal.Controls.Add(this.comboBoxAyudanteEnTurno);
            this.groupBoxDatosDePersonal.Controls.Add(this.comboBoxOperadorEnTurno);
            this.groupBoxDatosDePersonal.Controls.Add(this.label4);
            this.groupBoxDatosDePersonal.Controls.Add(this.comboBoxInspectorDeCalidadEnTurno);
            this.groupBoxDatosDePersonal.Controls.Add(this.label31);
            this.groupBoxDatosDePersonal.Controls.Add(this.comboBoxSupervisorEnTurno);
            this.groupBoxDatosDePersonal.Controls.Add(this.label33);
            this.groupBoxDatosDePersonal.Controls.Add(this.comboBoxIdentificadoPor);
            this.groupBoxDatosDePersonal.Controls.Add(this.label36);
            this.groupBoxDatosDePersonal.Controls.Add(this.label35);
            this.groupBoxDatosDePersonal.Controls.Add(this.label30);
            this.groupBoxDatosDePersonal.Controls.Add(this.label23);
            this.groupBoxDatosDePersonal.Location = new System.Drawing.Point(475, 260);
            this.groupBoxDatosDePersonal.Name = "groupBoxDatosDePersonal";
            this.groupBoxDatosDePersonal.Size = new System.Drawing.Size(477, 252);
            this.groupBoxDatosDePersonal.TabIndex = 11;
            this.groupBoxDatosDePersonal.TabStop = false;
            this.groupBoxDatosDePersonal.Text = "Datos de personal";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label29.Location = new System.Drawing.Point(115, 43);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(127, 20);
            this.label29.TabIndex = 0;
            this.label29.Text = "Identificado por: ";
            this.label29.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxAyudanteEnTurno
            // 
            this.comboBoxAyudanteEnTurno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAyudanteEnTurno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAyudanteEnTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxAyudanteEnTurno.FormattingEnabled = true;
            this.comboBoxAyudanteEnTurno.Items.AddRange(new object[] {
            "Operador 1",
            "Operador 2",
            "Operador 3",
            "Operador 4",
            "Operador 5",
            "Operador 6",
            "Operador 7"});
            this.comboBoxAyudanteEnTurno.Location = new System.Drawing.Point(248, 176);
            this.comboBoxAyudanteEnTurno.Name = "comboBoxAyudanteEnTurno";
            this.comboBoxAyudanteEnTurno.Size = new System.Drawing.Size(181, 28);
            this.comboBoxAyudanteEnTurno.TabIndex = 9;
            // 
            // comboBoxOperadorEnTurno
            // 
            this.comboBoxOperadorEnTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperadorEnTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxOperadorEnTurno.FormattingEnabled = true;
            this.comboBoxOperadorEnTurno.Items.AddRange(new object[] {
            "Operador 1",
            "Operador 2",
            "Operador 3",
            "Operador 4",
            "Operador 5",
            "Operador 6",
            "Operador 7"});
            this.comboBoxOperadorEnTurno.Location = new System.Drawing.Point(248, 142);
            this.comboBoxOperadorEnTurno.Name = "comboBoxOperadorEnTurno";
            this.comboBoxOperadorEnTurno.Size = new System.Drawing.Size(181, 28);
            this.comboBoxOperadorEnTurno.TabIndex = 9;
            // 
            // comboBoxInspectorDeCalidadEnTurno
            // 
            this.comboBoxInspectorDeCalidadEnTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInspectorDeCalidadEnTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxInspectorDeCalidadEnTurno.FormattingEnabled = true;
            this.comboBoxInspectorDeCalidadEnTurno.Items.AddRange(new object[] {
            "Inspector 1",
            "Inspector 2",
            "Inspector 3",
            "Inspector 4",
            "Inspector 5"});
            this.comboBoxInspectorDeCalidadEnTurno.Location = new System.Drawing.Point(248, 108);
            this.comboBoxInspectorDeCalidadEnTurno.Name = "comboBoxInspectorDeCalidadEnTurno";
            this.comboBoxInspectorDeCalidadEnTurno.Size = new System.Drawing.Size(181, 28);
            this.comboBoxInspectorDeCalidadEnTurno.TabIndex = 9;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label31.Location = new System.Drawing.Point(87, 77);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(155, 20);
            this.label31.TabIndex = 0;
            this.label31.Text = "Supervisor en turno: ";
            this.label31.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxSupervisorEnTurno
            // 
            this.comboBoxSupervisorEnTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSupervisorEnTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxSupervisorEnTurno.FormattingEnabled = true;
            this.comboBoxSupervisorEnTurno.Items.AddRange(new object[] {
            "Supervisor 1",
            "Supervisor 2",
            "Supervisor 3",
            "Supervisor 4",
            "Supervisor 5"});
            this.comboBoxSupervisorEnTurno.Location = new System.Drawing.Point(248, 74);
            this.comboBoxSupervisorEnTurno.Name = "comboBoxSupervisorEnTurno";
            this.comboBoxSupervisorEnTurno.Size = new System.Drawing.Size(181, 28);
            this.comboBoxSupervisorEnTurno.TabIndex = 9;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label33.Location = new System.Drawing.Point(19, 111);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(223, 20);
            this.label33.TabIndex = 0;
            this.label33.Text = "Inspector de calidad en turno: ";
            this.label33.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxIdentificadoPor
            // 
            this.comboBoxIdentificadoPor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxIdentificadoPor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxIdentificadoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxIdentificadoPor.FormattingEnabled = true;
            this.comboBoxIdentificadoPor.Location = new System.Drawing.Point(248, 40);
            this.comboBoxIdentificadoPor.Name = "comboBoxIdentificadoPor";
            this.comboBoxIdentificadoPor.Size = new System.Drawing.Size(181, 28);
            this.comboBoxIdentificadoPor.TabIndex = 8;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label36.Location = new System.Drawing.Point(95, 179);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(140, 20);
            this.label36.TabIndex = 0;
            this.label36.Text = "Ayudante en turno";
            this.label36.Click += new System.EventHandler(this.label3_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label35.Location = new System.Drawing.Point(95, 145);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(147, 20);
            this.label35.TabIndex = 0;
            this.label35.Text = "Operador en turno: ";
            this.label35.Click += new System.EventHandler(this.label3_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(99, 43);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 25);
            this.label30.TabIndex = 7;
            this.label30.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(126, 210);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 25);
            this.label23.TabIndex = 7;
            this.label23.Text = "*";
            // 
            // groupBoxCantidades
            // 
            this.groupBoxCantidades.Controls.Add(this.label8);
            this.groupBoxCantidades.Controls.Add(this.label32);
            this.groupBoxCantidades.Controls.Add(this.comboBoxUnidadesInicial);
            this.groupBoxCantidades.Controls.Add(this.comboBoxUnidadesFinal);
            this.groupBoxCantidades.Controls.Add(this.textBoxCantidadInicial);
            this.groupBoxCantidades.Controls.Add(this.textBoxCantidadFinal);
            this.groupBoxCantidades.Controls.Add(this.comboBoxDisposicion);
            this.groupBoxCantidades.Controls.Add(this.label10);
            this.groupBoxCantidades.Location = new System.Drawing.Point(475, 77);
            this.groupBoxCantidades.Name = "groupBoxCantidades";
            this.groupBoxCantidades.Size = new System.Drawing.Size(477, 177);
            this.groupBoxCantidades.TabIndex = 10;
            this.groupBoxCantidades.TabStop = false;
            this.groupBoxCantidades.Text = "Cantidades";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label32.Location = new System.Drawing.Point(26, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(106, 20);
            this.label32.TabIndex = 0;
            this.label32.Text = "Cantidad final";
            this.label32.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxUnidadesFinal
            // 
            this.comboBoxUnidadesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidadesFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUnidadesFinal.FormattingEnabled = true;
            this.comboBoxUnidadesFinal.Items.AddRange(new object[] {
            "Kg.",
            "Lb.",
            "Cajas",
            "Mazos",
            "Carretes"});
            this.comboBoxUnidadesFinal.Location = new System.Drawing.Point(334, 59);
            this.comboBoxUnidadesFinal.Name = "comboBoxUnidadesFinal";
            this.comboBoxUnidadesFinal.Size = new System.Drawing.Size(122, 28);
            this.comboBoxUnidadesFinal.TabIndex = 5;
            // 
            // textBoxCantidadFinal
            // 
            this.textBoxCantidadFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCantidadFinal.Location = new System.Drawing.Point(147, 61);
            this.textBoxCantidadFinal.Name = "textBoxCantidadFinal";
            this.textBoxCantidadFinal.Size = new System.Drawing.Size(181, 26);
            this.textBoxCantidadFinal.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(69, 151);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 25);
            this.label24.TabIndex = 7;
            this.label24.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(119, 117);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 25);
            this.label22.TabIndex = 7;
            this.label22.Text = "*";
            // 
            // buttonCapturarLotes
            // 
            this.buttonCapturarLotes.Location = new System.Drawing.Point(132, 273);
            this.buttonCapturarLotes.Name = "buttonCapturarLotes";
            this.buttonCapturarLotes.Size = new System.Drawing.Size(252, 36);
            this.buttonCapturarLotes.TabIndex = 6;
            this.buttonCapturarLotes.Text = "Capturar lotes";
            this.buttonCapturarLotes.UseVisualStyleBackColor = true;
            this.buttonCapturarLotes.Click += new System.EventHandler(this.buttonCapturarLotes_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(140, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Prefijo:";
            this.label14.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxCantidadDeLotes
            // 
            this.textBoxCantidadDeLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCantidadDeLotes.Location = new System.Drawing.Point(203, 209);
            this.textBoxCantidadDeLotes.Name = "textBoxCantidadDeLotes";
            this.textBoxCantidadDeLotes.Size = new System.Drawing.Size(181, 26);
            this.textBoxCantidadDeLotes.TabIndex = 4;
            // 
            // textBoxPrefijo
            // 
            this.textBoxPrefijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPrefijo.Location = new System.Drawing.Point(203, 241);
            this.textBoxPrefijo.Name = "textBoxPrefijo";
            this.textBoxPrefijo.Size = new System.Drawing.Size(181, 26);
            this.textBoxPrefijo.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(334, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Material:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(20, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Cliente:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(341, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Calibre:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(349, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 20);
            this.label19.TabIndex = 7;
            this.label19.Text = "Color: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(687, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "Perfil: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(683, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 20);
            this.label21.TabIndex = 7;
            this.label21.Text = "Corte: ";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Enabled = false;
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxColor.Location = new System.Drawing.Point(409, 101);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(181, 26);
            this.textBoxColor.TabIndex = 8;
            // 
            // textBoxPerfil
            // 
            this.textBoxPerfil.Enabled = false;
            this.textBoxPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPerfil.Location = new System.Drawing.Point(747, 40);
            this.textBoxPerfil.Name = "textBoxPerfil";
            this.textBoxPerfil.Size = new System.Drawing.Size(181, 26);
            this.textBoxPerfil.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonBuscarDatos);
            this.groupBox3.Controls.Add(this.textBoxClave);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBoxCorte);
            this.groupBox3.Controls.Add(this.textBoxCliente);
            this.groupBox3.Controls.Add(this.textBoxPerfil);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBoxCalibre);
            this.groupBox3.Controls.Add(this.textBoxMaterial);
            this.groupBox3.Controls.Add(this.textBoxColor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox3.Location = new System.Drawing.Point(12, 549);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1012, 197);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de producto: ";
            this.groupBox3.MouseCaptureChanged += new System.EventHandler(this.groupBox3_MouseCaptureChanged);
            // 
            // buttonBuscarDatos
            // 
            this.buttonBuscarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.buttonBuscarDatos.Location = new System.Drawing.Point(21, 136);
            this.buttonBuscarDatos.Name = "buttonBuscarDatos";
            this.buttonBuscarDatos.Size = new System.Drawing.Size(985, 38);
            this.buttonBuscarDatos.TabIndex = 11;
            this.buttonBuscarDatos.Text = "Buscar datos";
            this.buttonBuscarDatos.UseVisualStyleBackColor = true;
            this.buttonBuscarDatos.Click += new System.EventHandler(this.buttonBuscarDatos_Click);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxClave.Location = new System.Drawing.Point(88, 40);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(181, 26);
            this.textBoxClave.TabIndex = 10;
            this.textBoxClave.Text = ".00073";
            this.textBoxClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxClave_KeyPress);
            // 
            // textBoxCorte
            // 
            this.textBoxCorte.Enabled = false;
            this.textBoxCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCorte.Location = new System.Drawing.Point(747, 72);
            this.textBoxCorte.Name = "textBoxCorte";
            this.textBoxCorte.Size = new System.Drawing.Size(181, 26);
            this.textBoxCorte.TabIndex = 8;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Enabled = false;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCliente.Location = new System.Drawing.Point(88, 69);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(181, 26);
            this.textBoxCliente.TabIndex = 8;
            // 
            // textBoxCalibre
            // 
            this.textBoxCalibre.Enabled = false;
            this.textBoxCalibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCalibre.Location = new System.Drawing.Point(409, 40);
            this.textBoxCalibre.Name = "textBoxCalibre";
            this.textBoxCalibre.Size = new System.Drawing.Size(181, 26);
            this.textBoxCalibre.TabIndex = 8;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Enabled = false;
            this.textBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMaterial.Location = new System.Drawing.Point(409, 69);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(181, 26);
            this.textBoxMaterial.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(30, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clave:";
            // 
            // formCapturaDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1170, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCapturaDeDatos";
            this.Text = "Pantalla principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCapturaDeDatos_FormClosing_1);
            this.Load += new System.EventHandler(this.pantallaPrincipal_Load);
            this.Click += new System.EventHandler(this.formCapturaDeDatos_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxDatosDePersonal.ResumeLayout(false);
            this.groupBoxDatosDePersonal.PerformLayout();
            this.groupBoxCantidades.ResumeLayout(false);
            this.groupBoxCantidades.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.ComboBox comboBoxEnterado;
        private System.Windows.Forms.TextBox textBoxPedido;
        private System.Windows.Forms.ComboBox comboBoxResponsables;
        private System.Windows.Forms.TextBox textBoxCantidadInicial;
        private System.Windows.Forms.ComboBox comboBoxUnidadesInicial;
        private System.Windows.Forms.ComboBox comboBoxDisposicion;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.RichTextBox richTextBoxObservaciones;
        private System.Windows.Forms.RichTextBox richTextBoxCausa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonGeneraReporte;
        private System.Windows.Forms.Button buttonCapturarLotes;
        private System.Windows.Forms.TextBox textBoxCantidadDeLotes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPerfil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxCorte;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxCalibre;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPrefijo;
        private System.Windows.Forms.Button buttonBuscarDatos;
        private System.Windows.Forms.CheckBox checkBoxCausaDesconocida;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBoxIdentificadoPor;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBoxOperadorEnTurno;
        private System.Windows.Forms.ComboBox comboBoxInspectorDeCalidadEnTurno;
        private System.Windows.Forms.ComboBox comboBoxSupervisorEnTurno;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxCantidadFinal;
        private System.Windows.Forms.ComboBox comboBoxUnidadesFinal;
        private System.Windows.Forms.Label label32;
        private Label label24;
        private GroupBox groupBoxDatosDePersonal;
        private ComboBox comboBoxAyudanteEnTurno;
        private Label label36;
        private GroupBox groupBoxCantidades;
        private Label label38;
        private RichTextBox richTextBoxInspeccionesRealizadas;
    }
}

