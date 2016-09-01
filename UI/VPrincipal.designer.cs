using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    partial class VPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMin2 = new System.Windows.Forms.Label();
            this.labelMax2 = new System.Windows.Forms.Label();
            this.labelMax3 = new System.Windows.Forms.Label();
            this.labelMin3 = new System.Windows.Forms.Label();
            this.labelMax4 = new System.Windows.Forms.Label();
            this.labelMin4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFechaHoy = new System.Windows.Forms.Label();
            this.bwRssReader = new System.ComponentModel.BackgroundWorker();
            this.labelDescripcionEspHoy = new System.Windows.Forms.Label();
            this.labelDescripcionEspMañ = new System.Windows.Forms.Label();
            this.labelDescripcionEspPas = new System.Windows.Forms.Label();
            this.labelDescripcionEspTrasPas = new System.Windows.Forms.Label();
            this.labelValorMinMañ = new System.Windows.Forms.Label();
            this.labelValorMaxMañ = new System.Windows.Forms.Label();
            this.labelValorMinPas = new System.Windows.Forms.Label();
            this.labelValorMaxPas = new System.Windows.Forms.Label();
            this.labelValorMinTrasPas = new System.Windows.Forms.Label();
            this.labelValorMaxTrasPas = new System.Windows.Forms.Label();
            this.pictureBoxHoy = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrasPas = new System.Windows.Forms.PictureBox();
            this.pictureBoxPas = new System.Windows.Forms.PictureBox();
            this.pictureBoxMañ = new System.Windows.Forms.PictureBox();
            this.labelValorTemperaturaHoy = new System.Windows.Forms.Label();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.labelDescripcionIngMañ = new System.Windows.Forms.Label();
            this.labelDescripcionIngPas = new System.Windows.Forms.Label();
            this.labelDescripcionIngTrasPas = new System.Windows.Forms.Label();
            this.labelDescripcionIngHoyNoche = new System.Windows.Forms.Label();
            this.labelDescripcionEspHoyNoche = new System.Windows.Forms.Label();
            this.labelMaxHoyNoche = new System.Windows.Forms.Label();
            this.labelMinHoyNoche = new System.Windows.Forms.Label();
            this.pictureBoxHoyNoche = new System.Windows.Forms.PictureBox();
            this.labelAmanecer = new System.Windows.Forms.Label();
            this.labelValorAmanecer = new System.Windows.Forms.Label();
            this.labelAtardecer = new System.Windows.Forms.Label();
            this.labelValorAtardecer = new System.Windows.Forms.Label();
            this.labelHumedad = new System.Windows.Forms.Label();
            this.labelValorHmedad = new System.Windows.Forms.Label();
            this.labelPresion = new System.Windows.Forms.Label();
            this.labelValorPresion = new System.Windows.Forms.Label();
            this.labelValorMaxHoyNoche = new System.Windows.Forms.Label();
            this.labelValorMinHoyNoche = new System.Windows.Forms.Label();
            this.groupBoxClima = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTrasPasado = new System.Windows.Forms.Panel();
            this.panelPasado = new System.Windows.Forms.Panel();
            this.panelHoyNoche = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelMañana = new System.Windows.Forms.Panel();
            this.panelHoy = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.labelDescripcionIngHoy = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.climaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCampania = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxBanner = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bannerDeslizante = new UI.BannerDeslizante();
            this.campaniaDeslizante = new UI.CampaniaDeslizante();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrasPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMañ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoyNoche)).BeginInit();
            this.groupBoxClima.SuspendLayout();
            this.panelTrasPasado.SuspendLayout();
            this.panelPasado.SuspendLayout();
            this.panelHoyNoche.SuspendLayout();
            this.panelMañana.SuspendLayout();
            this.panelHoy.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxCampania.SuspendLayout();
            this.groupBoxBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mañana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pasado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "TrasPasado";
            // 
            // labelMin2
            // 
            this.labelMin2.AutoSize = true;
            this.labelMin2.ForeColor = System.Drawing.Color.Blue;
            this.labelMin2.Location = new System.Drawing.Point(5, 127);
            this.labelMin2.Name = "labelMin2";
            this.labelMin2.Size = new System.Drawing.Size(24, 13);
            this.labelMin2.TabIndex = 6;
            this.labelMin2.Text = "Min";
            // 
            // labelMax2
            // 
            this.labelMax2.AutoSize = true;
            this.labelMax2.ForeColor = System.Drawing.Color.Red;
            this.labelMax2.Location = new System.Drawing.Point(52, 127);
            this.labelMax2.Name = "labelMax2";
            this.labelMax2.Size = new System.Drawing.Size(27, 13);
            this.labelMax2.TabIndex = 7;
            this.labelMax2.Text = "Máx";
            // 
            // labelMax3
            // 
            this.labelMax3.AutoSize = true;
            this.labelMax3.ForeColor = System.Drawing.Color.Red;
            this.labelMax3.Location = new System.Drawing.Point(52, 128);
            this.labelMax3.Name = "labelMax3";
            this.labelMax3.Size = new System.Drawing.Size(27, 13);
            this.labelMax3.TabIndex = 9;
            this.labelMax3.Text = "Máx";
            // 
            // labelMin3
            // 
            this.labelMin3.AutoSize = true;
            this.labelMin3.ForeColor = System.Drawing.Color.Blue;
            this.labelMin3.Location = new System.Drawing.Point(5, 128);
            this.labelMin3.Name = "labelMin3";
            this.labelMin3.Size = new System.Drawing.Size(24, 13);
            this.labelMin3.TabIndex = 8;
            this.labelMin3.Text = "Min";
            // 
            // labelMax4
            // 
            this.labelMax4.AutoSize = true;
            this.labelMax4.ForeColor = System.Drawing.Color.Red;
            this.labelMax4.Location = new System.Drawing.Point(55, 129);
            this.labelMax4.Name = "labelMax4";
            this.labelMax4.Size = new System.Drawing.Size(27, 13);
            this.labelMax4.TabIndex = 11;
            this.labelMax4.Text = "Máx";
            // 
            // labelMin4
            // 
            this.labelMin4.AutoSize = true;
            this.labelMin4.ForeColor = System.Drawing.Color.Blue;
            this.labelMin4.Location = new System.Drawing.Point(8, 129);
            this.labelMin4.Name = "labelMin4";
            this.labelMin4.Size = new System.Drawing.Size(24, 13);
            this.labelMin4.TabIndex = 10;
            this.labelMin4.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hoy";
            // 
            // labelFechaHoy
            // 
            this.labelFechaHoy.AutoSize = true;
            this.labelFechaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaHoy.Location = new System.Drawing.Point(85, 29);
            this.labelFechaHoy.Name = "labelFechaHoy";
            this.labelFechaHoy.Size = new System.Drawing.Size(77, 20);
            this.labelFechaHoy.TabIndex = 21;
            this.labelFechaHoy.Text = "fechaHoy";
            // 
            // labelDescripcionEspHoy
            // 
            this.labelDescripcionEspHoy.AutoSize = true;
            this.labelDescripcionEspHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionEspHoy.Location = new System.Drawing.Point(15, 202);
            this.labelDescripcionEspHoy.Name = "labelDescripcionEspHoy";
            this.labelDescripcionEspHoy.Size = new System.Drawing.Size(131, 16);
            this.labelDescripcionEspHoy.TabIndex = 25;
            this.labelDescripcionEspHoy.Text = "descripcion Español";
            // 
            // labelDescripcionEspMañ
            // 
            this.labelDescripcionEspMañ.AutoSize = true;
            this.labelDescripcionEspMañ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionEspMañ.Location = new System.Drawing.Point(6, 96);
            this.labelDescripcionEspMañ.Name = "labelDescripcionEspMañ";
            this.labelDescripcionEspMañ.Size = new System.Drawing.Size(145, 15);
            this.labelDescripcionEspMañ.TabIndex = 26;
            this.labelDescripcionEspMañ.Text = "labelDescripcionEspMañ";
            // 
            // labelDescripcionEspPas
            // 
            this.labelDescripcionEspPas.AutoSize = true;
            this.labelDescripcionEspPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionEspPas.Location = new System.Drawing.Point(5, 99);
            this.labelDescripcionEspPas.Name = "labelDescripcionEspPas";
            this.labelDescripcionEspPas.Size = new System.Drawing.Size(141, 15);
            this.labelDescripcionEspPas.TabIndex = 27;
            this.labelDescripcionEspPas.Text = "labelDescripcionEspPas";
            // 
            // labelDescripcionEspTrasPas
            // 
            this.labelDescripcionEspTrasPas.AutoSize = true;
            this.labelDescripcionEspTrasPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionEspTrasPas.Location = new System.Drawing.Point(8, 100);
            this.labelDescripcionEspTrasPas.Name = "labelDescripcionEspTrasPas";
            this.labelDescripcionEspTrasPas.Size = new System.Drawing.Size(165, 15);
            this.labelDescripcionEspTrasPas.TabIndex = 28;
            this.labelDescripcionEspTrasPas.Text = "labelDescripcionEspTrasPas";
            // 
            // labelValorMinMañ
            // 
            this.labelValorMinMañ.AutoSize = true;
            this.labelValorMinMañ.Location = new System.Drawing.Point(4, 140);
            this.labelValorMinMañ.Name = "labelValorMinMañ";
            this.labelValorMinMañ.Size = new System.Drawing.Size(91, 13);
            this.labelValorMinMañ.TabIndex = 29;
            this.labelValorMinMañ.Text = "labelValorMinMañ";
            // 
            // labelValorMaxMañ
            // 
            this.labelValorMaxMañ.AutoSize = true;
            this.labelValorMaxMañ.Location = new System.Drawing.Point(51, 140);
            this.labelValorMaxMañ.Name = "labelValorMaxMañ";
            this.labelValorMaxMañ.Size = new System.Drawing.Size(94, 13);
            this.labelValorMaxMañ.TabIndex = 30;
            this.labelValorMaxMañ.Text = "labelValorMaxMañ";
            // 
            // labelValorMinPas
            // 
            this.labelValorMinPas.AutoSize = true;
            this.labelValorMinPas.Location = new System.Drawing.Point(4, 143);
            this.labelValorMinPas.Name = "labelValorMinPas";
            this.labelValorMinPas.Size = new System.Drawing.Size(88, 13);
            this.labelValorMinPas.TabIndex = 31;
            this.labelValorMinPas.Text = "labelValorMinPas";
            // 
            // labelValorMaxPas
            // 
            this.labelValorMaxPas.AutoSize = true;
            this.labelValorMaxPas.Location = new System.Drawing.Point(51, 143);
            this.labelValorMaxPas.Name = "labelValorMaxPas";
            this.labelValorMaxPas.Size = new System.Drawing.Size(91, 13);
            this.labelValorMaxPas.TabIndex = 32;
            this.labelValorMaxPas.Text = "labelValorMaxPas";
            // 
            // labelValorMinTrasPas
            // 
            this.labelValorMinTrasPas.AutoSize = true;
            this.labelValorMinTrasPas.Location = new System.Drawing.Point(7, 144);
            this.labelValorMinTrasPas.Name = "labelValorMinTrasPas";
            this.labelValorMinTrasPas.Size = new System.Drawing.Size(109, 13);
            this.labelValorMinTrasPas.TabIndex = 33;
            this.labelValorMinTrasPas.Text = "labelValorMinTrasPas";
            // 
            // labelValorMaxTrasPas
            // 
            this.labelValorMaxTrasPas.AutoSize = true;
            this.labelValorMaxTrasPas.Location = new System.Drawing.Point(54, 144);
            this.labelValorMaxTrasPas.Name = "labelValorMaxTrasPas";
            this.labelValorMaxTrasPas.Size = new System.Drawing.Size(112, 13);
            this.labelValorMaxTrasPas.TabIndex = 34;
            this.labelValorMaxTrasPas.Text = "labelValorMaxTrasPas";
            // 
            // pictureBoxHoy
            // 
            this.pictureBoxHoy.Location = new System.Drawing.Point(14, 55);
            this.pictureBoxHoy.Name = "pictureBoxHoy";
            this.pictureBoxHoy.Size = new System.Drawing.Size(191, 160);
            this.pictureBoxHoy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHoy.TabIndex = 15;
            this.pictureBoxHoy.TabStop = false;
            // 
            // pictureBoxTrasPas
            // 
            this.pictureBoxTrasPas.Location = new System.Drawing.Point(7, 4);
            this.pictureBoxTrasPas.Name = "pictureBoxTrasPas";
            this.pictureBoxTrasPas.Size = new System.Drawing.Size(91, 81);
            this.pictureBoxTrasPas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTrasPas.TabIndex = 4;
            this.pictureBoxTrasPas.TabStop = false;
            // 
            // pictureBoxPas
            // 
            this.pictureBoxPas.Location = new System.Drawing.Point(8, 3);
            this.pictureBoxPas.Name = "pictureBoxPas";
            this.pictureBoxPas.Size = new System.Drawing.Size(91, 81);
            this.pictureBoxPas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPas.TabIndex = 2;
            this.pictureBoxPas.TabStop = false;
            // 
            // pictureBoxMañ
            // 
            this.pictureBoxMañ.Location = new System.Drawing.Point(7, 0);
            this.pictureBoxMañ.Name = "pictureBoxMañ";
            this.pictureBoxMañ.Size = new System.Drawing.Size(91, 81);
            this.pictureBoxMañ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMañ.TabIndex = 0;
            this.pictureBoxMañ.TabStop = false;
            // 
            // labelValorTemperaturaHoy
            // 
            this.labelValorTemperaturaHoy.AutoSize = true;
            this.labelValorTemperaturaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTemperaturaHoy.Location = new System.Drawing.Point(187, 82);
            this.labelValorTemperaturaHoy.Name = "labelValorTemperaturaHoy";
            this.labelValorTemperaturaHoy.Size = new System.Drawing.Size(173, 16);
            this.labelValorTemperaturaHoy.TabIndex = 38;
            this.labelValorTemperaturaHoy.Text = "labelValorTemperaturaHoy";
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatura.ForeColor = System.Drawing.Color.Black;
            this.labelTemperatura.Location = new System.Drawing.Point(187, 66);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(86, 16);
            this.labelTemperatura.TabIndex = 36;
            this.labelTemperatura.Text = "Temperatura";
            // 
            // labelDescripcionIngMañ
            // 
            this.labelDescripcionIngMañ.AutoSize = true;
            this.labelDescripcionIngMañ.Location = new System.Drawing.Point(6, 111);
            this.labelDescripcionIngMañ.Name = "labelDescripcionIngMañ";
            this.labelDescripcionIngMañ.Size = new System.Drawing.Size(92, 13);
            this.labelDescripcionIngMañ.TabIndex = 40;
            this.labelDescripcionIngMañ.Text = "descripcion Ingles";
            // 
            // labelDescripcionIngPas
            // 
            this.labelDescripcionIngPas.AutoSize = true;
            this.labelDescripcionIngPas.Location = new System.Drawing.Point(4, 114);
            this.labelDescripcionIngPas.Name = "labelDescripcionIngPas";
            this.labelDescripcionIngPas.Size = new System.Drawing.Size(92, 13);
            this.labelDescripcionIngPas.TabIndex = 41;
            this.labelDescripcionIngPas.Text = "descripcion Ingles";
            // 
            // labelDescripcionIngTrasPas
            // 
            this.labelDescripcionIngTrasPas.AutoSize = true;
            this.labelDescripcionIngTrasPas.Location = new System.Drawing.Point(8, 116);
            this.labelDescripcionIngTrasPas.Name = "labelDescripcionIngTrasPas";
            this.labelDescripcionIngTrasPas.Size = new System.Drawing.Size(92, 13);
            this.labelDescripcionIngTrasPas.TabIndex = 42;
            this.labelDescripcionIngTrasPas.Text = "descripcion Ingles";
            // 
            // labelDescripcionIngHoyNoche
            // 
            this.labelDescripcionIngHoyNoche.AutoSize = true;
            this.labelDescripcionIngHoyNoche.Location = new System.Drawing.Point(16, 131);
            this.labelDescripcionIngHoyNoche.Name = "labelDescripcionIngHoyNoche";
            this.labelDescripcionIngHoyNoche.Size = new System.Drawing.Size(92, 13);
            this.labelDescripcionIngHoyNoche.TabIndex = 48;
            this.labelDescripcionIngHoyNoche.Text = "descripcion Ingles";
            // 
            // labelDescripcionEspHoyNoche
            // 
            this.labelDescripcionEspHoyNoche.AutoSize = true;
            this.labelDescripcionEspHoyNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionEspHoyNoche.Location = new System.Drawing.Point(16, 116);
            this.labelDescripcionEspHoyNoche.Name = "labelDescripcionEspHoyNoche";
            this.labelDescripcionEspHoyNoche.Size = new System.Drawing.Size(177, 15);
            this.labelDescripcionEspHoyNoche.TabIndex = 47;
            this.labelDescripcionEspHoyNoche.Text = "labelDescripcionEspHoyNoche";
            // 
            // labelMaxHoyNoche
            // 
            this.labelMaxHoyNoche.AutoSize = true;
            this.labelMaxHoyNoche.ForeColor = System.Drawing.Color.Red;
            this.labelMaxHoyNoche.Location = new System.Drawing.Point(66, 144);
            this.labelMaxHoyNoche.Name = "labelMaxHoyNoche";
            this.labelMaxHoyNoche.Size = new System.Drawing.Size(27, 13);
            this.labelMaxHoyNoche.TabIndex = 46;
            this.labelMaxHoyNoche.Text = "Máx";
            // 
            // labelMinHoyNoche
            // 
            this.labelMinHoyNoche.AutoSize = true;
            this.labelMinHoyNoche.ForeColor = System.Drawing.Color.Blue;
            this.labelMinHoyNoche.Location = new System.Drawing.Point(16, 144);
            this.labelMinHoyNoche.Name = "labelMinHoyNoche";
            this.labelMinHoyNoche.Size = new System.Drawing.Size(24, 13);
            this.labelMinHoyNoche.TabIndex = 45;
            this.labelMinHoyNoche.Text = "Min";
            // 
            // pictureBoxHoyNoche
            // 
            this.pictureBoxHoyNoche.Location = new System.Drawing.Point(17, 38);
            this.pictureBoxHoyNoche.Name = "pictureBoxHoyNoche";
            this.pictureBoxHoyNoche.Size = new System.Drawing.Size(91, 81);
            this.pictureBoxHoyNoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHoyNoche.TabIndex = 43;
            this.pictureBoxHoyNoche.TabStop = false;
            // 
            // labelAmanecer
            // 
            this.labelAmanecer.AutoSize = true;
            this.labelAmanecer.Location = new System.Drawing.Point(187, 111);
            this.labelAmanecer.Name = "labelAmanecer";
            this.labelAmanecer.Size = new System.Drawing.Size(55, 13);
            this.labelAmanecer.TabIndex = 49;
            this.labelAmanecer.Text = "Amanecer";
            // 
            // labelValorAmanecer
            // 
            this.labelValorAmanecer.AutoSize = true;
            this.labelValorAmanecer.Location = new System.Drawing.Point(239, 111);
            this.labelValorAmanecer.Name = "labelValorAmanecer";
            this.labelValorAmanecer.Size = new System.Drawing.Size(101, 13);
            this.labelValorAmanecer.TabIndex = 50;
            this.labelValorAmanecer.Text = "labelValorAmanecer";
            // 
            // labelAtardecer
            // 
            this.labelAtardecer.AutoSize = true;
            this.labelAtardecer.Location = new System.Drawing.Point(187, 137);
            this.labelAtardecer.Name = "labelAtardecer";
            this.labelAtardecer.Size = new System.Drawing.Size(53, 13);
            this.labelAtardecer.TabIndex = 51;
            this.labelAtardecer.Text = "Atardecer";
            // 
            // labelValorAtardecer
            // 
            this.labelValorAtardecer.AutoSize = true;
            this.labelValorAtardecer.Location = new System.Drawing.Point(239, 137);
            this.labelValorAtardecer.Name = "labelValorAtardecer";
            this.labelValorAtardecer.Size = new System.Drawing.Size(99, 13);
            this.labelValorAtardecer.TabIndex = 52;
            this.labelValorAtardecer.Text = "labelValorAtardecer";
            // 
            // labelHumedad
            // 
            this.labelHumedad.AutoSize = true;
            this.labelHumedad.Location = new System.Drawing.Point(187, 163);
            this.labelHumedad.Name = "labelHumedad";
            this.labelHumedad.Size = new System.Drawing.Size(53, 13);
            this.labelHumedad.TabIndex = 53;
            this.labelHumedad.Text = "Humedad";
            // 
            // labelValorHmedad
            // 
            this.labelValorHmedad.AutoSize = true;
            this.labelValorHmedad.Location = new System.Drawing.Point(239, 163);
            this.labelValorHmedad.Name = "labelValorHmedad";
            this.labelValorHmedad.Size = new System.Drawing.Size(75, 13);
            this.labelValorHmedad.TabIndex = 54;
            this.labelValorHmedad.Text = "labelHumedad";
            // 
            // labelPresion
            // 
            this.labelPresion.AutoSize = true;
            this.labelPresion.Location = new System.Drawing.Point(187, 189);
            this.labelPresion.Name = "labelPresion";
            this.labelPresion.Size = new System.Drawing.Size(42, 13);
            this.labelPresion.TabIndex = 55;
            this.labelPresion.Text = "Presión";
            // 
            // labelValorPresion
            // 
            this.labelValorPresion.AutoSize = true;
            this.labelValorPresion.Location = new System.Drawing.Point(239, 189);
            this.labelValorPresion.Name = "labelValorPresion";
            this.labelValorPresion.Size = new System.Drawing.Size(88, 13);
            this.labelValorPresion.TabIndex = 56;
            this.labelValorPresion.Text = "labelValorPresion";
            // 
            // labelValorMaxHoyNoche
            // 
            this.labelValorMaxHoyNoche.AutoSize = true;
            this.labelValorMaxHoyNoche.Location = new System.Drawing.Point(68, 160);
            this.labelValorMaxHoyNoche.Name = "labelValorMaxHoyNoche";
            this.labelValorMaxHoyNoche.Size = new System.Drawing.Size(124, 13);
            this.labelValorMaxHoyNoche.TabIndex = 58;
            this.labelValorMaxHoyNoche.Text = "labelValorMaxHoyNoche";
            // 
            // labelValorMinHoyNoche
            // 
            this.labelValorMinHoyNoche.AutoSize = true;
            this.labelValorMinHoyNoche.Location = new System.Drawing.Point(16, 160);
            this.labelValorMinHoyNoche.Name = "labelValorMinHoyNoche";
            this.labelValorMinHoyNoche.Size = new System.Drawing.Size(121, 13);
            this.labelValorMinHoyNoche.TabIndex = 57;
            this.labelValorMinHoyNoche.Text = "labelValorMinHoyNoche";
            // 
            // groupBoxClima
            // 
            this.groupBoxClima.Controls.Add(this.label6);
            this.groupBoxClima.Controls.Add(this.panelTrasPasado);
            this.groupBoxClima.Controls.Add(this.panelPasado);
            this.groupBoxClima.Controls.Add(this.panelHoyNoche);
            this.groupBoxClima.Controls.Add(this.panelMañana);
            this.groupBoxClima.Controls.Add(this.panelHoy);
            this.groupBoxClima.Location = new System.Drawing.Point(809, 27);
            this.groupBoxClima.Name = "groupBoxClima";
            this.groupBoxClima.Size = new System.Drawing.Size(408, 627);
            this.groupBoxClima.TabIndex = 60;
            this.groupBoxClima.TabStop = false;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(230, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 10);
            this.label6.TabIndex = 65;
            // 
            // panelTrasPasado
            // 
            this.panelTrasPasado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTrasPasado.Controls.Add(this.labelValorMaxTrasPas);
            this.panelTrasPasado.Controls.Add(this.labelValorMinTrasPas);
            this.panelTrasPasado.Controls.Add(this.labelDescripcionIngTrasPas);
            this.panelTrasPasado.Controls.Add(this.label4);
            this.panelTrasPasado.Controls.Add(this.labelDescripcionEspTrasPas);
            this.panelTrasPasado.Controls.Add(this.labelMax4);
            this.panelTrasPasado.Controls.Add(this.labelMin4);
            this.panelTrasPasado.Controls.Add(this.pictureBoxTrasPas);
            this.panelTrasPasado.Location = new System.Drawing.Point(233, 460);
            this.panelTrasPasado.Name = "panelTrasPasado";
            this.panelTrasPasado.Size = new System.Drawing.Size(167, 162);
            this.panelTrasPasado.TabIndex = 64;
            // 
            // panelPasado
            // 
            this.panelPasado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelPasado.Controls.Add(this.labelValorMaxPas);
            this.panelPasado.Controls.Add(this.labelValorMinPas);
            this.panelPasado.Controls.Add(this.labelDescripcionIngPas);
            this.panelPasado.Controls.Add(this.label3);
            this.panelPasado.Controls.Add(this.labelDescripcionEspPas);
            this.panelPasado.Controls.Add(this.labelMax3);
            this.panelPasado.Controls.Add(this.labelMin3);
            this.panelPasado.Controls.Add(this.pictureBoxPas);
            this.panelPasado.Location = new System.Drawing.Point(60, 460);
            this.panelPasado.Name = "panelPasado";
            this.panelPasado.Size = new System.Drawing.Size(173, 162);
            this.panelPasado.TabIndex = 63;
            // 
            // panelHoyNoche
            // 
            this.panelHoyNoche.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHoyNoche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHoyNoche.Controls.Add(this.pictureBoxHoyNoche);
            this.panelHoyNoche.Controls.Add(this.label10);
            this.panelHoyNoche.Controls.Add(this.labelValorMaxHoyNoche);
            this.panelHoyNoche.Controls.Add(this.labelValorMinHoyNoche);
            this.panelHoyNoche.Controls.Add(this.labelDescripcionIngHoyNoche);
            this.panelHoyNoche.Controls.Add(this.labelDescripcionEspHoyNoche);
            this.panelHoyNoche.Controls.Add(this.labelMaxHoyNoche);
            this.panelHoyNoche.Controls.Add(this.labelMinHoyNoche);
            this.panelHoyNoche.Location = new System.Drawing.Point(9, 253);
            this.panelHoyNoche.Name = "panelHoyNoche";
            this.panelHoyNoche.Size = new System.Drawing.Size(218, 194);
            this.panelHoyNoche.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Esta Noche";
            // 
            // panelMañana
            // 
            this.panelMañana.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelMañana.Controls.Add(this.labelValorMaxMañ);
            this.panelMañana.Controls.Add(this.labelValorMinMañ);
            this.panelMañana.Controls.Add(this.labelDescripcionIngMañ);
            this.panelMañana.Controls.Add(this.labelDescripcionEspMañ);
            this.panelMañana.Controls.Add(this.labelMax2);
            this.panelMañana.Controls.Add(this.labelMin2);
            this.panelMañana.Controls.Add(this.label2);
            this.panelMañana.Controls.Add(this.pictureBoxMañ);
            this.panelMañana.Location = new System.Drawing.Point(233, 292);
            this.panelMañana.Name = "panelMañana";
            this.panelMañana.Size = new System.Drawing.Size(167, 168);
            this.panelMañana.TabIndex = 61;
            // 
            // panelHoy
            // 
            this.panelHoy.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHoy.Controls.Add(this.label40);
            this.panelHoy.Controls.Add(this.labelDescripcionIngHoy);
            this.panelHoy.Controls.Add(this.label1);
            this.panelHoy.Controls.Add(this.labelValorPresion);
            this.panelHoy.Controls.Add(this.labelPresion);
            this.panelHoy.Controls.Add(this.labelValorHmedad);
            this.panelHoy.Controls.Add(this.labelHumedad);
            this.panelHoy.Controls.Add(this.labelValorAtardecer);
            this.panelHoy.Controls.Add(this.labelAtardecer);
            this.panelHoy.Controls.Add(this.labelValorAmanecer);
            this.panelHoy.Controls.Add(this.labelAmanecer);
            this.panelHoy.Controls.Add(this.labelValorTemperaturaHoy);
            this.panelHoy.Controls.Add(this.labelTemperatura);
            this.panelHoy.Controls.Add(this.labelDescripcionEspHoy);
            this.panelHoy.Controls.Add(this.labelFechaHoy);
            this.panelHoy.Controls.Add(this.pictureBoxHoy);
            this.panelHoy.Location = new System.Drawing.Point(9, 16);
            this.panelHoy.Name = "panelHoy";
            this.panelHoy.Size = new System.Drawing.Size(391, 235);
            this.panelHoy.TabIndex = 60;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(9, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(321, 25);
            this.label40.TabIndex = 98;
            this.label40.Text = "Concepción del Uruguay - Argentina";
            // 
            // labelDescripcionIngHoy
            // 
            this.labelDescripcionIngHoy.AutoSize = true;
            this.labelDescripcionIngHoy.Location = new System.Drawing.Point(18, 218);
            this.labelDescripcionIngHoy.Name = "labelDescripcionIngHoy";
            this.labelDescripcionIngHoy.Size = new System.Drawing.Size(92, 13);
            this.labelDescripcionIngHoy.TabIndex = 57;
            this.labelDescripcionIngHoy.Text = "descripcion Ingles";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPantallaCompletaToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // verPantallaCompletaToolStripMenuItem
            // 
            this.verPantallaCompletaToolStripMenuItem.Name = "verPantallaCompletaToolStripMenuItem";
            this.verPantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.verPantallaCompletaToolStripMenuItem.Text = "&Ver pantalla completa";
            this.verPantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.verPantallaCompletaToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaToolStripMenuItem,
            this.climaToolStripMenuItem,
            this.campaniaToolStripMenuItem,
            this.bannerToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.configuraciónToolStripMenuItem.Text = "&Configuración";
            // 
            // pantallaToolStripMenuItem
            // 
            this.pantallaToolStripMenuItem.Name = "pantallaToolStripMenuItem";
            this.pantallaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pantallaToolStripMenuItem.Text = "&Pantalla";
            // 
            // climaToolStripMenuItem
            // 
            this.climaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarCiudadToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.climaToolStripMenuItem.Name = "climaToolStripMenuItem";
            this.climaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.climaToolStripMenuItem.Text = "&Clima";
            // 
            // cambiarCiudadToolStripMenuItem
            // 
            this.cambiarCiudadToolStripMenuItem.Name = "cambiarCiudadToolStripMenuItem";
            this.cambiarCiudadToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cambiarCiudadToolStripMenuItem.Text = "&Cambiar Ciudad";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.actualizarToolStripMenuItem.Text = "&Actualizar";
            // 
            // campaniaToolStripMenuItem
            // 
            this.campaniaToolStripMenuItem.Name = "campaniaToolStripMenuItem";
            this.campaniaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.campaniaToolStripMenuItem.Text = "C&ampaña";
            this.campaniaToolStripMenuItem.Click += new System.EventHandler(this.campaniaToolStripMenuItem_Click);
            // 
            // bannerToolStripMenuItem
            // 
            this.bannerToolStripMenuItem.Name = "bannerToolStripMenuItem";
            this.bannerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bannerToolStripMenuItem.Text = "&Banner";
            this.bannerToolStripMenuItem.Click += new System.EventHandler(this.bannerToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.verAyudaToolStripMenuItem.Text = "&Ver ayuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre ...";
            // 
            // groupBoxCampania
            // 
            this.groupBoxCampania.Controls.Add(this.campaniaDeslizante);
            this.groupBoxCampania.Controls.Add(this.label5);
            this.groupBoxCampania.Location = new System.Drawing.Point(12, 27);
            this.groupBoxCampania.Name = "groupBoxCampania";
            this.groupBoxCampania.Size = new System.Drawing.Size(791, 535);
            this.groupBoxCampania.TabIndex = 62;
            this.groupBoxCampania.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(27, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "  ";
            // 
            // groupBoxBanner
            // 
            this.groupBoxBanner.Controls.Add(this.bannerDeslizante);
            this.groupBoxBanner.Location = new System.Drawing.Point(12, 568);
            this.groupBoxBanner.Name = "groupBoxBanner";
            this.groupBoxBanner.Size = new System.Drawing.Size(791, 86);
            this.groupBoxBanner.TabIndex = 0;
            this.groupBoxBanner.TabStop = false;
            // 
            // bannerDeslizante
            // 
            this.bannerDeslizante.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bannerDeslizante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannerDeslizante.CaracteresAMostrar = 100;
            this.bannerDeslizante.Enabled = false;
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerDeslizante.Location = new System.Drawing.Point(22, 33);
            this.bannerDeslizante.Name = "bannerDeslizante";
            this.bannerDeslizante.Size = new System.Drawing.Size(746, 28);
            this.bannerDeslizante.TabIndex = 0;
            this.bannerDeslizante.TextoCompleto = null;
            // 
            // campaniaDeslizante
            // 
            this.campaniaDeslizante.Campania = null;
            this.campaniaDeslizante.ImageLocation = "";
            this.campaniaDeslizante.Location = new System.Drawing.Point(32, 70);
            this.campaniaDeslizante.Name = "campaniaDeslizante";
            this.campaniaDeslizante.Size = new System.Drawing.Size(722, 451);
            this.campaniaDeslizante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campaniaDeslizante.TabIndex = 39;
            this.campaniaDeslizante.TabStop = false;
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1222, 669);
            this.Controls.Add(this.groupBoxBanner);
            this.Controls.Add(this.groupBoxCampania);
            this.Controls.Add(this.groupBoxClima);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VPrincipal";
            this.Text = "Pantalla Publicitaria EASYNEWS";
            this.Activated += new System.EventHandler(this.VPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VPrincipal_FormClosing);
            this.Resize += new System.EventHandler(this.VPrincipal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrasPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMañ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoyNoche)).EndInit();
            this.groupBoxClima.ResumeLayout(false);
            this.panelTrasPasado.ResumeLayout(false);
            this.panelTrasPasado.PerformLayout();
            this.panelPasado.ResumeLayout(false);
            this.panelPasado.PerformLayout();
            this.panelHoyNoche.ResumeLayout(false);
            this.panelHoyNoche.PerformLayout();
            this.panelMañana.ResumeLayout(false);
            this.panelMañana.PerformLayout();
            this.panelHoy.ResumeLayout(false);
            this.panelHoy.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCampania.ResumeLayout(false);
            this.groupBoxCampania.PerformLayout();
            this.groupBoxBanner.ResumeLayout(false);
            this.groupBoxBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMañ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxPas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxTrasPas;
        private System.Windows.Forms.Label labelMin2;
        private System.Windows.Forms.Label labelMax2;
        private System.Windows.Forms.Label labelMax3;
        private System.Windows.Forms.Label labelMin3;
        private System.Windows.Forms.Label labelMax4;
        private System.Windows.Forms.Label labelMin4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxHoy;
        private System.Windows.Forms.Label labelFechaHoy;
        private System.ComponentModel.BackgroundWorker bwRssReader;
        private System.Windows.Forms.Label labelDescripcionEspHoy;
        private System.Windows.Forms.Label labelDescripcionEspMañ;
        private System.Windows.Forms.Label labelDescripcionEspPas;
        private System.Windows.Forms.Label labelDescripcionEspTrasPas;
        private System.Windows.Forms.Label labelValorMinMañ;
        private System.Windows.Forms.Label labelValorMaxMañ;
        private System.Windows.Forms.Label labelValorMinPas;
        private System.Windows.Forms.Label labelValorMaxPas;
        private System.Windows.Forms.Label labelValorMinTrasPas;
        private System.Windows.Forms.Label labelValorMaxTrasPas;
        private System.Windows.Forms.Label labelValorTemperaturaHoy;
        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.Label labelDescripcionIngMañ;
        private System.Windows.Forms.Label labelDescripcionIngPas;
        private System.Windows.Forms.Label labelDescripcionIngTrasPas;
        private System.Windows.Forms.Label labelDescripcionIngHoyNoche;
        private System.Windows.Forms.Label labelDescripcionEspHoyNoche;
        private System.Windows.Forms.Label labelMaxHoyNoche;
        private System.Windows.Forms.Label labelMinHoyNoche;
        private System.Windows.Forms.PictureBox pictureBoxHoyNoche;
        private System.Windows.Forms.Label labelAmanecer;
        private System.Windows.Forms.Label labelValorAmanecer;
        private System.Windows.Forms.Label labelAtardecer;
        private System.Windows.Forms.Label labelValorAtardecer;
        private System.Windows.Forms.Label labelHumedad;
        private System.Windows.Forms.Label labelValorHmedad;
        private System.Windows.Forms.Label labelPresion;
        private System.Windows.Forms.Label labelValorPresion;
        private System.Windows.Forms.Label labelValorMaxHoyNoche;
        private System.Windows.Forms.Label labelValorMinHoyNoche;
        private GroupBox groupBoxClima;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem verPantallaCompletaToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem pantallaToolStripMenuItem;
        private ToolStripMenuItem climaToolStripMenuItem;
        private ToolStripMenuItem campaniaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem cambiarCiudadToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem bannerToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem verAyudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private GroupBox groupBoxCampania;
        private GroupBox groupBoxBanner;
        private Label label5;
        private Timer timer1;
        private BannerDeslizante bannerDeslizante;
        private CampaniaDeslizante campaniaDeslizante;
        private Panel panelTrasPasado;
        private Panel panelPasado;
        private Panel panelHoyNoche;
        private Label label10;
        private Panel panelMañana;
        private Panel panelHoy;
        private Label labelDescripcionIngHoy;
        private Label label6;
        private Label label40;
    }
}

