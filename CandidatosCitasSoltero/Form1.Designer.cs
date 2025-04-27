using System.Drawing;
using System.Windows.Forms;

namespace CandidatosCitasSoltero
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkImpredecible = new System.Windows.Forms.CheckBox();
            this.chkInteresante = new System.Windows.Forms.CheckBox();
            this.chkAtrevido = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.chkDivertido = new System.Windows.Forms.CheckBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cedulaDBDataSet = new CandidatosCitasSoltero.CedulaDBDataSet();
            this.cedulaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cedulaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedulaDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer apellido";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Segundo apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado Civil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(86, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(131, 114);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(86, 20);
            this.txtApellido1.TabIndex = 9;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(131, 138);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(86, 20);
            this.txtApellido2.TabIndex = 10;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(131, 163);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(172, 20);
            this.dtpFechaNacimiento.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(131, 215);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(86, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(131, 190);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(86, 20);
            this.txtEstadoCivil.TabIndex = 13;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(131, 242);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(86, 20);
            this.txtSexo.TabIndex = 14;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(131, 268);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(86, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(308, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 20);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkImpredecible
            // 
            this.chkImpredecible.AutoSize = true;
            this.chkImpredecible.Location = new System.Drawing.Point(536, 204);
            this.chkImpredecible.Name = "chkImpredecible";
            this.chkImpredecible.Size = new System.Drawing.Size(86, 17);
            this.chkImpredecible.TabIndex = 22;
            this.chkImpredecible.Text = "Impredecible";
            this.chkImpredecible.UseVisualStyleBackColor = true;
            // 
            // chkInteresante
            // 
            this.chkInteresante.AutoSize = true;
            this.chkInteresante.Location = new System.Drawing.Point(536, 225);
            this.chkInteresante.Name = "chkInteresante";
            this.chkInteresante.Size = new System.Drawing.Size(79, 17);
            this.chkInteresante.TabIndex = 23;
            this.chkInteresante.Text = "Interesante";
            this.chkInteresante.UseVisualStyleBackColor = true;
            // 
            // chkAtrevido
            // 
            this.chkAtrevido.AutoSize = true;
            this.chkAtrevido.Location = new System.Drawing.Point(536, 247);
            this.chkAtrevido.Name = "chkAtrevido";
            this.chkAtrevido.Size = new System.Drawing.Size(65, 17);
            this.chkAtrevido.TabIndex = 24;
            this.chkAtrevido.Text = "Atrevido";
            this.chkAtrevido.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Coloque su cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(131, 8);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(162, 20);
            this.txtCedula.TabIndex = 26;
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(532, 269);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(64, 20);
            this.btnPublicar.TabIndex = 27;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // chkDivertido
            // 
            this.chkDivertido.AutoSize = true;
            this.chkDivertido.Location = new System.Drawing.Point(536, 182);
            this.chkDivertido.Name = "chkDivertido";
            this.chkDivertido.Size = new System.Drawing.Size(68, 17);
            this.chkDivertido.TabIndex = 28;
            this.chkDivertido.Text = "Divertido";
            this.chkDivertido.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cedulaDBDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CandidatosCitasSoltero.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(122, 349);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 29;
            // 
            // cedulaDBDataSet
            // 
            this.cedulaDBDataSet.DataSetName = "CedulaDBDataSet";
            this.cedulaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cedulaDBDataSetBindingSource
            // 
            this.cedulaDBDataSetBindingSource.DataSource = this.cedulaDBDataSet;
            this.cedulaDBDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 534);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.chkDivertido);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkAtrevido);
            this.Controls.Add(this.chkInteresante);
            this.Controls.Add(this.chkImpredecible);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cedulaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedulaDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label23;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNombre;
        private TextBox txtApellido1;
        private TextBox txtApellido2;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtDireccion;
        private TextBox txtEstadoCivil;
        private TextBox txtSexo;
        private TextBox txtTelefono;
        private Button btnBuscar;
        private Label label9;
        private Label label10;
        private Label label11;
        private CheckBox checkBox1;
        private CheckBox chkImpredecible;
        private CheckBox chkInteresante;
        private CheckBox chkAtrevido;
        private Label label3;
        private TextBox txtCedula;
        private Button btnPublicar;
        private CheckBox chkDivertido;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BindingSource cedulaDBDataSetBindingSource;
        private CedulaDBDataSet cedulaDBDataSet;
    }
}

