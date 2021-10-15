
namespace WindowsFormsApp1
{
    partial class ProgramaContactos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBuscador = new System.Windows.Forms.TextBox();
            this.gridContactos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(603, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(696, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "AÑADIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBuscador
            // 
            this.textBuscador.Location = new System.Drawing.Point(113, 44);
            this.textBuscador.Name = "textBuscador";
            this.textBuscador.Size = new System.Drawing.Size(472, 20);
            this.textBuscador.TabIndex = 3;
            this.textBuscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridContactos
            // 
            this.gridContactos.AutoGenerateColumns = false;
            this.gridContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.primerNombreDataGridViewTextBoxColumn,
            this.segundoNombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.gridContactos.DataSource = this.contactoBindingSource;
            this.gridContactos.Location = new System.Drawing.Point(12, 95);
            this.gridContactos.Name = "gridContactos";
            this.gridContactos.Size = new System.Drawing.Size(823, 341);
            this.gridContactos.TabIndex = 4;
            this.gridContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // primerNombreDataGridViewTextBoxColumn
            // 
            this.primerNombreDataGridViewTextBoxColumn.DataPropertyName = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn.HeaderText = "PrimerNombre";
            this.primerNombreDataGridViewTextBoxColumn.Name = "primerNombreDataGridViewTextBoxColumn";
            // 
            // segundoNombreDataGridViewTextBoxColumn
            // 
            this.segundoNombreDataGridViewTextBoxColumn.DataPropertyName = "SegundoNombre";
            this.segundoNombreDataGridViewTextBoxColumn.HeaderText = "SegundoNombre";
            this.segundoNombreDataGridViewTextBoxColumn.Name = "segundoNombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // contactoBindingSource
            // 
            this.contactoBindingSource.DataSource = typeof(WindowsFormsApp1.Contacto);
            // 
            // ProgramaContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 469);
            this.Controls.Add(this.gridContactos);
            this.Controls.Add(this.textBuscador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ProgramaContactos";
            this.Text = "CONTACTOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBuscador;
        private System.Windows.Forms.DataGridView gridContactos;
        private System.Windows.Forms.BindingSource contactoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}

