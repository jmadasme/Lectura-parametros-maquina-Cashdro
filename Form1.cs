
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://200.54.171.218:8090
//https://200.54.171.218:8090/Cashdro3Web/#/splash
namespace cashdro
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CefSettings settings = new CefSettings();
            settings.IgnoreCertificateErrors = true;
            Cef.Initialize(settings);

        }

        private int n = -1; //indice seleccionado
        private string pathImg = @"D:\imagenes\";
        private string IPActual = "";
        string _cnLocal = @"Data Source=.\SQLEXPRESS;Initial Catalog=GestionCashdro;User Id=jm;password=123";
        string _cliente = "";
        string _correoFrom="";
        string _correoPass="";
        string _correoAlerta = "";
        string _alias = "";
        string _IP;


        private void Form1_Load(object sender, EventArgs e)
        {
            // cargaGrid();
            LeerParametros();
            // ChequeaCashdroBakgroud();
            timer1.Enabled = true;

            timer1.Interval =   1000 * 60 * 30; //media hora
            timer1.Start();

        }



        void cargaGrid()
        {
            string cnLocal = _cnLocal;

            using (SqlConnection connection = new SqlConnection(cnLocal))
            {
                // int employeeID = findEmployeeID();
                try
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("getCasdro", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    // command.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
                    command.CommandTimeout = 5;
                    dataGridView.Rows.Clear();
                    Boolean tieneEror = false;
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                lblMensaje.Text = "Conectando con " + dr["ip"].ToString() + "......";
                                n = dataGridView.Rows.Add();
                                dataGridView.Rows[n].Cells[0].Value = dr["id"].ToString();
                                dataGridView.Rows[n].Cells[1].Value = dr["ip"].ToString();
                                dataGridView.Rows[n].Cells[2].Value = dr["alias"].ToString();
                                _alias = dr["alias"].ToString();

                                if (getError(dr["ip"].ToString()))
                                {

                                    Bitmap img;
                                    string nombreIcono = @pathImg + @"warning.png";
                                    img = new Bitmap(@nombreIcono);
                                    // picOk.Image 
                                    dataGridView.Rows[n].Cells[3].Value = img;
                                    tieneEror = true;
                                  dataGridView.Rows[n].Cells[3].ReadOnly = true;

                                }
                                else
                                {
                                    Bitmap img;
                                    string nombreIcono = @pathImg + @"check-icon.png";
                                    img = new Bitmap(@nombreIcono);
                                    // picOk.Image 
                                    dataGridView.Rows[n].Cells[3].Value = img;
                                    dataGridView.Rows[n].Cells[3].ReadOnly = false;
                                }


                            }
                        }

                    }
                    if (tieneEror)
                    {
                        Bitmap img;
                        string nombreIcono = @pathImg + @"warning.png";
                        img = new Bitmap(@nombreIcono);
                        picOk.Image = img;

                    }
                    else
                    {
                        Bitmap img;
                        string nombreIcono = @pathImg + @"check-icon.png";
                        img = new Bitmap(@nombreIcono);
                        picOk.Image = img;
                    }
                    lblMensaje.Text = " ";
                }
                catch (Exception)
                {
                    if (connection.State == System.Data.ConnectionState.Open) connection.Close();
                    //    return ds;
                }


            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    n = dataGridView.Rows.Add();
        //    dataGridView.Rows[n].Cells[0].Value = "1";
        //    dataGridView.Rows[n].Cells[1].Value = "1.1.1.1";
        //    dataGridView.Rows[n].Cells[2].Value = "esto es un alias";

        //    Bitmap img;
        //    img = new Bitmap(@"D:\ADASME\2019 Abril\monitorCashdro\check-icon.png");
        //    DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
        //    dataGridView.Columns.Add(imageCol);
        //    dataGridView.Rows[n].Cells[3].Value = img; //status



        //}

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                IPActual = dataGridView.Rows[n].Cells[1].Value.ToString();
             _alias = dataGridView.Rows[n].Cells[2].Value.ToString();
                if  (dataGridView.Rows[n].Cells[3].ReadOnly == true) return;



                if (e.ColumnIndex == 3) //click en la imagen
                {
                    //  MessageBox.Show("boton click");
                    dataGridViewDevice.Rows.Clear();
                    dataGridViewdata.Rows.Clear();
                    cargaGridDevice(dataGridView.Rows[n].Cells[1].Value.ToString());
                    cargaGridData(dataGridView.Rows[n].Cells[1].Value.ToString());
                }
                //aqui se puede leer la celda a la que le hacen click

            }
        }




        void cargaGridDevice(string IP)
        {
           
            //buscar en URL los devices
            //       dataGridViewDevice.Rows.Clear();
            int nGridevice = -1;
            Boolean MsgError = false;
           
            //string url = "https://" + IP + "/Cashdro3WS/index.php?operation=getDiagnosis";
            string url = "https://179.8.123.97/Cashdro3WS/index.php?operation=getDiagnosis";
            Uri address = new Uri(url);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            using (WebClient webClient = new WebClient())
            {

                var stream = webClient.OpenRead(address);
                using (System.IO.StreamReader sr = new System.IO.StreamReader(stream))
                {
                    var page = sr.ReadToEnd();
                    // Console.WriteLine("resultado lectura1(enqueue): {0}", page);
                    // MessageBox.Show("resultado lectura1(enqueue): {0}", page);
                    //PARSEO JSON
                    RootObjectDevice newTarget = JsonConvert.DeserializeObject<RootObjectDevice>(page);
                    int devicesCount = newTarget.data.Devices.Count();
                    //cada device es una row en dgrid
                    List<Device> dv = newTarget.data.Devices;

                    foreach (Device d in dv)
                    {
                        nGridevice = dataGridViewDevice.Rows.Add();
                        dataGridViewDevice.Rows[nGridevice].Cells[0].Value = d.deviceId.ToString();
                        dataGridViewDevice.Rows[nGridevice].Cells[1].Value = d.deviceName.ToString();
                        dataGridViewDevice.Rows[nGridevice].Cells[2].Value = d.deviceWithError.ToString();

                        if (!dataGridViewDevice.Rows[nGridevice].Cells[2].Value.ToString().Equals("False", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MsgError = true;
                            Bitmap img;
                            string nombreIcono = @pathImg + @"warning.png";
                            img = new Bitmap(@nombreIcono);
                            // picOk.Image 
                            dataGridViewDevice.Rows[nGridevice].Cells[3].Value = img;
                        }
                        else
                        {
                            Bitmap img;
                            string nombreIcono = @pathImg + @"check-icon.png";
                            img = new Bitmap(@nombreIcono);
                            dataGridViewDevice.Rows[nGridevice].Cells[3].Value = img;
                        }
                    }

                }
            }


        }

        void cargaTblDevice(string IP)
        {
            try
            {

                string url = "https://" + IP + "/Cashdro3WS/index.php?operation=getDiagnosis";
                Uri address = new Uri(url);
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                using (WebClient webClient = new WebClient())
                {
                    var stream = webClient.OpenRead(address);

                    using (System.IO.StreamReader sr = new System.IO.StreamReader(stream))
                    {

                        var page = sr.ReadToEnd();
                        // Console.WriteLine("resultado lectura1(enqueue): {0}", page);
                        // MessageBox.Show("resultado lectura1(enqueue): {0}", page);
                        //PARSEO JSON
                        RootObjectDevice newTarget = JsonConvert.DeserializeObject<RootObjectDevice>(page);
                        int devicesCount = newTarget.data.Devices.Count();
                        //cada device es una row en dgrid
                        List<Device> dv = newTarget.data.Devices;

                        foreach (Device d in dv)
                        {
                            InsertaDispositivo(_cliente, d.deviceName.ToString(), d.deviceWithError.ToString(), IP);
                            //if (int.Parse(d.deviceWithError.ToString()) != 0)
                            //{
                            ////    enviaCorreo(IP, d.deviceName.ToString());

                            //}
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                enviaCorreo(_IP, "error en dispositivo");

            }


        }

        private void InsertaDispositivo(string cliente, string devicename, string deviceWithError, string IP)
        {
            SqlConnection connection = new SqlConnection(_cnLocal);
            connection.Open();
            //   SqlCommand command1 = new SqlCommand("select top 1 imagen from [Productos] where CodigoProducto=" + IDProducto, connection);
            SqlCommand sqlCmd = new SqlCommand("[pInsertDevices] @cliente,@deviceName,@deviceWithError,@IP", connection);
            sqlCmd.Parameters.Add(new SqlParameter("@cliente", cliente.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@deviceName", devicename.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@deviceWithError", deviceWithError.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@IP", IP.ToString().Trim()));
            sqlCmd.ExecuteNonQuery();
            connection.Close();
        }
        private void InsertaData(string cliente, string currencyId, string Value, string depositLevel, string LevelRecycler,string IP,string MaxLevel)
        {
            SqlConnection connection = new SqlConnection(_cnLocal);
            connection.Open();
            //   SqlCommand command1 = new SqlCommand("select top 1 imagen from [Productos] where CodigoProducto=" + IDProducto, connection);
            SqlCommand sqlCmd = new SqlCommand("[pInsertdata] @cliente,@currencyId,@Value,@depositLevel,@LevelRecycler,@IP,@MaxLevel", connection);

            sqlCmd.Parameters.Add(new SqlParameter("@cliente", cliente.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@currencyId", currencyId.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@Value", Value.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@depositLevel", depositLevel.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@LevelRecycler", LevelRecycler.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@IP", IP.ToString().Trim()));
            sqlCmd.Parameters.Add(new SqlParameter("@MaxLevel", MaxLevel.ToString().Trim()));
            sqlCmd.ExecuteNonQuery();
            connection.Close();
        }


        void cargaGridData(string IP)
        {
            //  dataGridViewDevice.Rows.Clear();
            int nGridata = -1;
            //buscar en URL la data
            string url = "https://" + IP + "/Cashdro3WS/index.php?operation=getPiecesCurrency&%20currencyId=CLP&includeImages=0&includeLevels=1&name=manager&password=2";
            Uri address = new Uri(url);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            using (WebClient webClient = new WebClient())
            {
                var stream = webClient.OpenRead(address);
                using (System.IO.StreamReader sr = new System.IO.StreamReader(stream))
                {
                    var page = sr.ReadToEnd();
                    // Console.WriteLine("resultado lectura1(enqueue): {0}", page);
                    // MessageBox.Show("resultado lectura1(enqueue): {0}", page);
                    //PARSEO JSON
                    RootObjectDatum newTarget = JsonConvert.DeserializeObject<RootObjectDatum>(page);
                    int dataCount = newTarget.data.Count();
                    //cada device es una row en dgrid
                    List<Datum> dt = newTarget.data;
                    Bitmap img;
                    string nombreIcono;
                    foreach (Datum d in dt)
                    {


                        nGridata = dataGridViewdata.Rows.Add();
                        dataGridViewdata.Rows[nGridata].Cells[0].Value = d.CurrencyId.ToString();
                        //dataGridViewdata.Rows[nGridata].Cells[1].Value = d.Value.ToString();
                        string numero = d.Value.ToString();

                        dataGridViewdata.Rows[nGridata].Cells[1].Value = Convert.ToUInt32(numero) / 100;
                        dataGridViewdata.Rows[nGridata].Cells[2].Value = d.DepositLevel.ToString();
                        dataGridViewdata.Rows[nGridata].Cells[3].Value = d.LevelRecycler.ToString();
                        dataGridViewdata.Rows[nGridata].Cells[4].Value = d.MaxLevel.ToString();
                        int depositlevel = Convert.ToInt32(d.DepositLevel.ToString()); //minima cantidad tolerada
                        int levelrecycler = Convert.ToInt32(d.LevelRecycler.ToString());// cantidad actual
                        ////
                        if (levelrecycler < depositlevel) //gatillar alerta
                        {
                            //enviar correo
                         //   enviaCorreo(_IP,_alias);
                            //marcar grilla


                            nombreIcono = @pathImg + @"warning.png";
                            img = new Bitmap(@nombreIcono);
                            // picOk.Image 
                            dataGridViewdata.Rows[nGridata].Cells[5].Value = img;
                        }
                        else
                        {

                            nombreIcono = @pathImg + @"check-icon.png";
                            img = new Bitmap(@nombreIcono);
                            dataGridViewdata.Rows[nGridata].Cells[5].Value = img;
                        }

                    }

                }
            }

        }

        void cargaTblData(string IP)
        {
            try
            {
                //buscar en URL la data
                string url = "https://" + IP + "/Cashdro3WS/index.php?operation=getPiecesCurrency&%20currencyId=CLP&includeImages=0&includeLevels=1&name=manager&password=2";
                Uri address = new Uri(url);
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                using (WebClient webClient = new WebClient())
                {
                    var stream = webClient.OpenRead(address);
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(stream))
                    {
                        var page = sr.ReadToEnd();
                        //PARSEO JSON
                        RootObjectDatum newTarget = JsonConvert.DeserializeObject<RootObjectDatum>(page);
                        int dataCount = newTarget.data.Count();
                        //cada device es una row en dgrid
                        List<Datum> dt = newTarget.data;

                        foreach (Datum d in dt)
                        {
                            InsertaData(_cliente, d.CurrencyId.ToString(), d.Value.ToString(), d.DepositLevel.ToString(), d.LevelRecycler.ToString(), IP, d.MaxLevel.ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }



        void enviaCorreo(string IP,string devicename)
        {


            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(_correoFrom);
                message.To.Add(new MailAddress(_correoAlerta));
                message.Subject = "Alerta";
                message.Body = "Error en casdro " + _alias + "\n IP: " + IP + " \n Device: " + devicename;

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(_correoFrom, _correoPass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }



        }



        //void ChequeaCashdro()
        //{
        //    string IP = "";
        //    foreach (DataGridViewRow row in dataGridView.Rows)
        //    {
        //        //     MessageBox.Show(row.Cells["IP"].Value.ToString());
        //        //busca si hay error

        //        //  

        //        if (row.Cells[1].Value != null)
        //        {
        //            IP = row.Cells[1].Value.ToString();
        //            if (getError(IP))
        //            {
        //                Bitmap img;
        //                string nombreIcono = @pathImg + @"no-icon.png";
        //                img = new Bitmap(@nombreIcono);
        //                picOk.Image = img;
        //                return;
        //            }
        //            else
        //            {
        //                Bitmap img;
        //                string nombreIcono = @pathImg + @"check-icon.png";
        //                img = new Bitmap(@nombreIcono);
        //                picOk.Image = img;

        //            }
        //        }
        //    }
        //}

        void ChequeaCashdroBakgroud()
        {
            string cnLocal = _cnLocal;

            using (SqlConnection connection = new SqlConnection(cnLocal))
            {
             try
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("getCasdro", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    // command.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
                    command.CommandTimeout = 5;
                    dataGridView.Rows.Clear();
             
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                _correoAlerta = dr["correoAlerta"].ToString();
                                _alias =  dr["alias"].ToString();
                                _IP = dr["ip"].ToString();
                                
                                //inserta dispositivos
                                cargaTblDevice(_IP);
                                //inserta data de niveles
                                cargaTblData(_IP);

                            }
                        }

                    }
                
                }
                catch (Exception)
                {
                
                    if (connection.State == System.Data.ConnectionState.Open) connection.Close();
                    //    return ds;
                }


            }
        }

        bool getError(string IP)
        {
            string url = "https://" + IP + "/Cashdro3WS/index.php?operation=getDiagnosis";
            Uri address = new Uri(url);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            Boolean tieneError = false;
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    var stream = webClient.OpenRead(address);
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(stream))
                    {
                        var page = sr.ReadToEnd();
                        //PARSEO JSON
                        RootObjectDevice newTarget = JsonConvert.DeserializeObject<RootObjectDevice>(page);
                        int devicesCount = newTarget.data.Devices.Count();
                        //cada device es una row en dgrid
                        List<Device> dv = newTarget.data.Devices;
                        string mensaje = "";
                        foreach (Device d in dv)
                        {
                            mensaje = d.deviceWithError.ToString();
                            if (!mensaje.Equals("False", StringComparison.InvariantCultureIgnoreCase))
                            {
                                tieneError = true;
                            }
                        }

                    }
                }
                return (tieneError);
            }
            catch
            {
                return (true);
            }

        } //fin procedure
        private void dataGridViewDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int idxdataGridViewDevice = e.RowIndex;
            if (idxdataGridViewDevice != -1)
            {
                if (e.ColumnIndex == 3)
                {
                    string url = "https://" + IPActual + "/Cashdro3Web/#/diagnosis/false?username=manager&password=2";
                    var monitor = new webBrownser(url);
                    DialogResult dr = monitor.ShowDialog();
                    if (dr == DialogResult.Cancel)
                    {
                        monitor.Close();

                        monitor.Dispose();
                        // MessageBox.Show("CODIGO DE CLIENTE NO EXISTE");
                    }


                }
                //aqui se puede leer la celda a la que le hacen click
            }
        }
        private void btnValida_Click(object sender, EventArgs e)
        {
            Boolean esValido = false;
             esValido=  ValidaUsuario(txtUser.Text, txtpass.Text);
            if (esValido)
            {
                cargaGrid();
            }
            else
            {
            }  
        }

        
    private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }


        private bool ValidaUsuario(string usuario, string password)
       {
            Boolean isOK= false;
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = _cnLocal;
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from [user] where usuario=@usr and pass=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", usuario);
            scmd.Parameters.AddWithValue("@pwd", password);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {

                //MessageBox.Show("Acceso Concedido ");
                isOK = true;
            }

            else
            {

                //      pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Documents\Visual Studio 2015\Projects\mylogin\denied.jpg");
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");

                txtUser.Clear();
                txtpass.Clear();
                isOK = false;
            }
            scn.Close();
            return isOK;
        }

        public void LeerParametros()
        {

            using (SqlConnection connection = new SqlConnection(_cnLocal))
            {
                // int employeeID = findEmployeeID();
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GetParametros", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    // command.Parameters.Add(new SqlParameter("@EmployeeID", employeeID));
                    command.CommandTimeout = 5;

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                _correoFrom = dr["CorreoFrom"].ToString();
                                _correoPass = dr["CorreoPass"].ToString();
                                _cliente = dr["Cliente"].ToString();

                            }
                        }

                    }
                }
                catch (Exception)
                {
                    if (connection.State == System.Data.ConnectionState.Open) connection.Close();
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //segun el intervalo ir a ejecutar recofida de informacion y guardar en la BD

            ChequeaCashdroBakgroud();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cargaGridDevice2();
        }

        private void cargaGridDevice2()
        {

            //buscar en URL los devices
            //       dataGridViewDevice.Rows.Clear();
            int nGridevice = -1;
            Boolean MsgError = false;

            //string url = "https://" + IP + "/Cashdro3WS/index.php?operation=getDiagnosis";
            //string url = "https://179.8.123.97/Cashdro3WS/index.php?operation=getDiagnosis";
            string url = "https://200.54.171.218:8092/Cashdro3WS/index.php?operation=getDiagnosis";
            Uri address = new Uri(url);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            using (WebClient webClient = new WebClient())
            {

                var stream = webClient.OpenRead(address);
                using (System.IO.StreamReader sr = new System.IO.StreamReader(stream))
                {
                    var page = sr.ReadToEnd();
                    // Console.WriteLine("resultado lectura1(enqueue): {0}", page);
                    // MessageBox.Show("resultado lectura1(enqueue): {0}", page);
                    //PARSEO JSON
                    RootObjectDevice newTarget = JsonConvert.DeserializeObject<RootObjectDevice>(page);
                    int devicesCount = newTarget.data.Devices.Count();
                    //cada device es una row en dgrid
                    List<Device> dv = newTarget.data.Devices;

                    foreach (Device d in dv)
                    {
                        nGridevice = dataGridViewDevice.Rows.Add();
                        dataGridViewDevice.Rows[nGridevice].Cells[0].Value = d.deviceId.ToString();
                        dataGridViewDevice.Rows[nGridevice].Cells[1].Value = d.deviceName.ToString();
                        dataGridViewDevice.Rows[nGridevice].Cells[2].Value = d.deviceWithError.ToString();

                        if (!dataGridViewDevice.Rows[nGridevice].Cells[2].Value.ToString().Equals("False", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MsgError = true;
                            Bitmap img;
                            string nombreIcono = @pathImg + @"warning.png";
                            img = new Bitmap(@nombreIcono);
                            // picOk.Image 
                            dataGridViewDevice.Rows[nGridevice].Cells[3].Value = img;
                        }
                        else
                        {
                            //Bitmap img;
                            //string nombreIcono = @pathImg + @"check-icon.png";
                            //img = new Bitmap(@nombreIcono);
                            //dataGridViewDevice.Rows[nGridevice].Cells[3].Value = img;
                        }
                    }

                }
            }
        }
    }
    
}
