namespace cashdro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnValida = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewDevice = new System.Windows.Forms.DataGridView();
            this.IPdevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceWithError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewdata = new System.Windows.Forms.DataGridView();
            this.CURRENCYID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOSITLEVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEVELRECYCLER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAXLEVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALERT = new System.Windows.Forms.DataGridViewImageColumn();
            this.picOk = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOk)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(70, 61);
            this.txtpass.Margin = new System.Windows.Forms.Padding(6);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(87, 20);
            this.txtpass.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(70, 32);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(87, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnValida
            // 
            this.btnValida.Location = new System.Drawing.Point(95, 93);
            this.btnValida.Margin = new System.Windows.Forms.Padding(6);
            this.btnValida.Name = "btnValida";
            this.btnValida.Size = new System.Drawing.Size(62, 29);
            this.btnValida.TabIndex = 3;
            this.btnValida.Text = "validar";
            this.btnValida.UseVisualStyleBackColor = true;
            this.btnValida.Click += new System.EventHandler(this.btnValida_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.IP,
            this.ALIAS,
            this.ESTADO});
            this.dataGridView.Location = new System.Drawing.Point(11, 237);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(408, 325);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Item";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP Equipo";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // ALIAS
            // 
            this.ALIAS.HeaderText = "Nombre";
            this.ALIAS.Name = "ALIAS";
            this.ALIAS.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ESTADO.FillWeight = 40F;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 60;
            // 
            // dataGridViewDevice
            // 
            this.dataGridViewDevice.AllowUserToAddRows = false;
            this.dataGridViewDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPdevice,
            this.deviceName,
            this.DeviceWithError,
            this.STATUS});
            this.dataGridViewDevice.Location = new System.Drawing.Point(432, 38);
            this.dataGridViewDevice.Name = "dataGridViewDevice";
            this.dataGridViewDevice.RowTemplate.Height = 33;
            this.dataGridViewDevice.Size = new System.Drawing.Size(315, 170);
            this.dataGridViewDevice.TabIndex = 5;
            this.dataGridViewDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevice_CellClick);
            // 
            // IPdevice
            // 
            this.IPdevice.HeaderText = "Item";
            this.IPdevice.Name = "IPdevice";
            this.IPdevice.ReadOnly = true;
            this.IPdevice.Width = 60;
            // 
            // deviceName
            // 
            this.deviceName.HeaderText = "Nombre";
            this.deviceName.Name = "deviceName";
            this.deviceName.ReadOnly = true;
            // 
            // DeviceWithError
            // 
            this.DeviceWithError.HeaderText = "Error ?";
            this.DeviceWithError.Name = "DeviceWithError";
            this.DeviceWithError.ReadOnly = true;
            this.DeviceWithError.Width = 50;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.STATUS.Name = "STATUS";
            this.STATUS.Width = 60;
            // 
            // dataGridViewdata
            // 
            this.dataGridViewdata.AllowUserToAddRows = false;
            this.dataGridViewdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CURRENCYID,
            this.VALUE,
            this.DEPOSITLEVEL,
            this.LEVELRECYCLER,
            this.MAXLEVEL,
            this.ALERT});
            this.dataGridViewdata.Location = new System.Drawing.Point(432, 238);
            this.dataGridViewdata.Name = "dataGridViewdata";
            this.dataGridViewdata.RowTemplate.Height = 33;
            this.dataGridViewdata.Size = new System.Drawing.Size(604, 320);
            this.dataGridViewdata.TabIndex = 6;
            this.dataGridViewdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdata_CellContentClick);
            // 
            // CURRENCYID
            // 
            this.CURRENCYID.HeaderText = "Moneda";
            this.CURRENCYID.Name = "CURRENCYID";
            // 
            // VALUE
            // 
            this.VALUE.HeaderText = "Denominacion";
            this.VALUE.Name = "VALUE";
            this.VALUE.ReadOnly = true;
            // 
            // DEPOSITLEVEL
            // 
            this.DEPOSITLEVEL.HeaderText = "Fianza";
            this.DEPOSITLEVEL.Name = "DEPOSITLEVEL";
            this.DEPOSITLEVEL.ReadOnly = true;
            // 
            // LEVELRECYCLER
            // 
            this.LEVELRECYCLER.HeaderText = "Total";
            this.LEVELRECYCLER.Name = "LEVELRECYCLER";
            this.LEVELRECYCLER.ReadOnly = true;
            // 
            // MAXLEVEL
            // 
            this.MAXLEVEL.HeaderText = "Recuento";
            this.MAXLEVEL.Name = "MAXLEVEL";
            this.MAXLEVEL.ReadOnly = true;
            // 
            // ALERT
            // 
            this.ALERT.HeaderText = "ALERT";
            this.ALERT.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ALERT.Name = "ALERT";
            this.ALERT.Width = 60;
            // 
            // picOk
            // 
            this.picOk.Image = ((System.Drawing.Image)(resources.GetObject("picOk.Image")));
            this.picOk.Location = new System.Drawing.Point(1020, 152);
            this.picOk.Name = "picOk";
            this.picOk.Size = new System.Drawing.Size(57, 48);
            this.picOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOk.TabIndex = 7;
            this.picOk.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.btnValida);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(806, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "label1";
            this.lblMensaje.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(919, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(869, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consulta Niveles  On Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Consulta estado tecnico ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Parque de maquinas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(863, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(875, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado tecnico";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(509, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 13);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(27, 238);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(449, 242);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 14);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1088, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picOk);
            this.Controls.Add(this.dataGridViewdata);
            this.Controls.Add(this.dataGridViewDevice);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Sistema integrado ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOk)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnValida;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridView dataGridViewDevice;
        private System.Windows.Forms.DataGridView dataGridViewdata;
        private System.Windows.Forms.PictureBox picOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALIAS;
        private System.Windows.Forms.DataGridViewImageColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPdevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceWithError;
        private System.Windows.Forms.DataGridViewImageColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENCYID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOSITLEVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEVELRECYCLER;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXLEVEL;
        private System.Windows.Forms.DataGridViewImageColumn ALERT;
        private System.Windows.Forms.Button button1;
    }
}

