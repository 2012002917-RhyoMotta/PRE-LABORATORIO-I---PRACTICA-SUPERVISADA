namespace Proyecto_PreLab
{
    partial class CRUDForm
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
            dgvAlumnos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            grado = new DataGridViewTextBoxColumn();
            seccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            matricula = new DataGridViewTextBoxColumn();
            ciclo = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            fecha_nacimiento = new DataGridViewTextBoxColumn();
            promedio = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            txtNombre = new TextBox();
            txtGrado = new TextBox();
            txtSeccion = new TextBox();
            txtTelefono = new TextBox();
            txtMatricula = new TextBox();
            txtCiclo = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            txtPromedio = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnReg = new Button();
            btnMod = new Button();
            btnDel = new Button();
            btnNew = new Button();
            lblCodigo = new Label();
            label3 = new Label();
            btnCreditos = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { id, nombre, grado, seccion, telefono, matricula, ciclo, email, direccion, fecha_nacimiento, promedio, estado });
            dgvAlumnos.Location = new Point(12, 14);
            dgvAlumnos.Margin = new Padding(4);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 5;
            dgvAlumnos.Size = new Size(982, 550);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellClick += dgvAlumnos_CellClick;
            // 
            // id
            // 
            id.FillWeight = 50.9460068F;
            id.HeaderText = "ID";
            id.Name = "id";
            id.Width = 50;
            // 
            // nombre
            // 
            nombre.FillWeight = 50.9460068F;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.Width = 98;
            // 
            // grado
            // 
            grado.FillWeight = 50.9460068F;
            grado.HeaderText = "Grado";
            grado.Name = "grado";
            grado.Width = 81;
            // 
            // seccion
            // 
            seccion.FillWeight = 50.9460068F;
            seccion.HeaderText = "Sección";
            seccion.Name = "seccion";
            seccion.Width = 94;
            // 
            // telefono
            // 
            telefono.FillWeight = 50.9460068F;
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.Width = 102;
            // 
            // matricula
            // 
            matricula.FillWeight = 50.9460068F;
            matricula.HeaderText = "Matricula";
            matricula.Name = "matricula";
            matricula.Width = 108;
            // 
            // ciclo
            // 
            ciclo.FillWeight = 50.9460068F;
            ciclo.HeaderText = "Ciclo";
            ciclo.Name = "ciclo";
            ciclo.Width = 73;
            // 
            // email
            // 
            email.FillWeight = 50.9460068F;
            email.HeaderText = "Email";
            email.Name = "email";
            email.Width = 78;
            // 
            // direccion
            // 
            direccion.FillWeight = 50.9460068F;
            direccion.HeaderText = "Dirección";
            direccion.Name = "direccion";
            direccion.Width = 108;
            // 
            // fecha_nacimiento
            // 
            fecha_nacimiento.FillWeight = 639.593933F;
            fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            fecha_nacimiento.Name = "fecha_nacimiento";
            fecha_nacimiento.Width = 125;
            // 
            // promedio
            // 
            promedio.FillWeight = 50.9460068F;
            promedio.HeaderText = "Promedio";
            promedio.Name = "promedio";
            promedio.Width = 110;
            // 
            // estado
            // 
            estado.FillWeight = 50.9460068F;
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.Width = 86;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1143, 118);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 29);
            txtNombre.TabIndex = 1;
            // 
            // txtGrado
            // 
            txtGrado.Location = new Point(1143, 155);
            txtGrado.Margin = new Padding(4);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(189, 29);
            txtGrado.TabIndex = 2;
            // 
            // txtSeccion
            // 
            txtSeccion.Location = new Point(1143, 192);
            txtSeccion.Margin = new Padding(4);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(189, 29);
            txtSeccion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(1143, 230);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(189, 29);
            txtTelefono.TabIndex = 4;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(1143, 267);
            txtMatricula.Margin = new Padding(4);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(189, 29);
            txtMatricula.TabIndex = 5;
            // 
            // txtCiclo
            // 
            txtCiclo.Location = new Point(1143, 302);
            txtCiclo.Margin = new Padding(4);
            txtCiclo.Name = "txtCiclo";
            txtCiclo.Size = new Size(189, 29);
            txtCiclo.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1143, 339);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 29);
            txtEmail.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(1143, 377);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(189, 29);
            txtDireccion.TabIndex = 8;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(1143, 483);
            txtPromedio.Margin = new Padding(4);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(189, 29);
            txtPromedio.TabIndex = 10;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.ImeMode = ImeMode.NoControl;
            dtpFechaNacimiento.Location = new Point(1143, 428);
            dtpFechaNacimiento.Margin = new Padding(4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(189, 29);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // cmbEstado
            // 
            cmbEstado.AccessibleDescription = "";
            cmbEstado.AccessibleName = "";
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "-- Seleccione Estado --", "Activo", "Inactivo", "Graduado", "Suspendido" });
            cmbEstado.Location = new Point(1143, 520);
            cmbEstado.Margin = new Padding(4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(189, 29);
            cmbEstado.TabIndex = 13;
            cmbEstado.Text = "-- Seleccione Estado --";
            // 
            // btnReg
            // 
            btnReg.BackColor = SystemColors.ActiveCaption;
            btnReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnReg.Location = new Point(1002, 571);
            btnReg.Margin = new Padding(4);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(332, 77);
            btnReg.TabIndex = 14;
            btnReg.Text = "REGISTRAR";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnMod.Location = new Point(12, 571);
            btnMod.Margin = new Padding(4);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(322, 77);
            btnMod.TabIndex = 15;
            btnMod.Text = "MODIFICAR";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnDel.Location = new Point(342, 571);
            btnDel.Margin = new Padding(4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(322, 77);
            btnDel.TabIndex = 16;
            btnDel.Text = "BORRAR";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnNew.Location = new Point(672, 571);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(322, 77);
            btnNew.TabIndex = 17;
            btnNew.Text = "NUEVO";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.BackColor = SystemColors.Window;
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(1143, 79);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(188, 30);
            lblCodigo.TabIndex = 18;
            lblCodigo.Text = "1";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1210, 13);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 20;
            label3.Text = "Creditos >>";
            // 
            // btnCreditos
            // 
            btnCreditos.BackColor = Color.Black;
            btnCreditos.Image = Properties.Resources.Creditos;
            btnCreditos.Location = new Point(1310, 13);
            btnCreditos.Margin = new Padding(4);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(24, 23);
            btnCreditos.TabIndex = 19;
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1001, 84);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 21;
            label1.Text = "ID:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1001, 119);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 21;
            label2.Text = "NOMBRE:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1001, 156);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 21;
            label4.Text = "GRADO:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1001, 193);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 21;
            label5.Text = "SECCIÓN:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1001, 231);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 21;
            label6.Text = "TELÉFONO:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1002, 268);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 21;
            label7.Text = "MATRICULA:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1001, 303);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 25);
            label8.TabIndex = 21;
            label8.Text = "CICLO:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1002, 340);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(136, 25);
            label9.TabIndex = 21;
            label9.Text = "EMAIL:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1002, 378);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 21;
            label10.Text = "DIRECCIÓN:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(1001, 420);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(136, 50);
            label11.TabIndex = 21;
            label11.Text = "FECHA DE\r\nNACIMIENTO:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1001, 484);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(136, 25);
            label12.TabIndex = 21;
            label12.Text = "PROMEDIO:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(1001, 521);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(136, 25);
            label13.TabIndex = 21;
            label13.Text = "ESTADO:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(1000, 40);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(343, 30);
            label14.TabIndex = 22;
            label14.Text = "INGRESE LOS SIGUIENTES DATOS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CRUDForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 661);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnCreditos);
            Controls.Add(lblCodigo);
            Controls.Add(btnNew);
            Controls.Add(btnDel);
            Controls.Add(btnMod);
            Controls.Add(btnReg);
            Controls.Add(cmbEstado);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtPromedio);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtCiclo);
            Controls.Add(txtMatricula);
            Controls.Add(txtTelefono);
            Controls.Add(txtSeccion);
            Controls.Add(txtGrado);
            Controls.Add(txtNombre);
            Controls.Add(dgvAlumnos);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CRUDForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDForm";
            Load += CRUDForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnos;
        private TextBox txtNombre;
        private TextBox txtGrado;
        private TextBox txtSeccion;
        private TextBox txtTelefono;
        private TextBox txtMatricula;
        private TextBox txtCiclo;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private TextBox txtPromedio;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbEstado;
        private Button btnReg;
        private Button btnMod;
        private Button btnDel;
        private Button btnNew;
        private Label lblCodigo;
        private Label label3;
        private Button btnCreditos;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn grado;
        private DataGridViewTextBoxColumn seccion;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn ciclo;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn fecha_nacimiento;
        private DataGridViewTextBoxColumn promedio;
        private DataGridViewTextBoxColumn estado;
    }
}