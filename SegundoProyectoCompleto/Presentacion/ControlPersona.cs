using SegundoProyectoCompleto.Datos;
using SegundoProyectoCompleto.Logica;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SegundoProyectoCompleto.Presentacion
{
    public partial class ControlPersona : UserControl
    {
        public ControlPersona()
        {
            InitializeComponent();
        }
        int IdCargo = 0; //variable para capturar el id del cargo
        //variables para el paginado
        int desde = 1;
        int hasta = 10;
        int contador;
        int Idpersonal;
        private int item_por_pagina = 10;
        string Estado;
        int totalPaginas;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonal();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LocalizarDgvCargos();
            panelCargos.Visible = false;
            panelPaginado.Visible = false;
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            Limpiar();

        }
        private void Limpiar()
        {
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtCargo.Clear();
            txtSueldoHora.Clear();

            BuscarCargos(); //*****


        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombres.Text))
            {
                if (!string.IsNullOrEmpty(txtIdentificacion.Text))
                {
                    if (!string.IsNullOrEmpty(cbxPais.Text))
                    {
                        if (IdCargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldoHora.Text))
                            {
                                InsertarPersonal();


                            }
                            else
                            {
                                MessageBox.Show("El sueldo no puede estar Vacio", "Sueldo vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Debes selecionar un cargo", "Cargo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Debes Selecionar un Pais", "Pais Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Debes Agregar la Identificacion", "Identificacion Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
            else
            {
                MessageBox.Show("Debes Agregar un Nombre", "Nombre Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void InsertarPersonal()
        {
            LogicaPersonal Lparametros = new LogicaPersonal();
            DatosPersonal Dfuncion = new DatosPersonal();

            Lparametros.Nombre = txtNombres.Text;
            Lparametros.Identificacion = txtIdentificacion.Text;
            Lparametros.Pais = cbxPais.Text;
            Lparametros.Id_cargo = IdCargo;
            Lparametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);

            if (Dfuncion.InsertarPersonal(Lparametros) == true)
            {
                MostrarPersonal();
                panelRegistro.Visible = false;

            }


            //cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);

        }

        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            DatosPersonal funcion = new DatosPersonal();
            funcion.MostrarPersona(ref dt, desde, hasta);
            dataListadoPersonal.DataSource = dt;
            DisenarDtvPersonal();

        }
        private void DisenarDtvPersonal()
        {
            Bases.DisenoDGV(ref dataListadoPersonal);
            Bases.DisenoDgvEliminar(ref dataListadoPersonal);
            panelPaginado.Visible = true;
            //ocultar columnas innecesarias
            dataListadoPersonal.Columns[2].Visible = false;
            dataListadoPersonal.Columns[7].Visible = false;
        }
        private void InsertarCargos()
        {
            if (!string.IsNullOrEmpty(txtCargoC.Text)) // validar que los campos no esten vacios
            {
                if (!string.IsNullOrEmpty(txtSueldoxHoraC.Text))
                {
                    LogicaCargos Lparametros = new LogicaCargos();
                    DatosCargos Dfuncion = new DatosCargos();

                    Lparametros.Cargo = txtCargoC.Text;
                    Lparametros.SueldoCargo = Convert.ToDouble(txtSueldoxHoraC.Text);

                    if (Dfuncion.InsertarCargo(Lparametros) == true)
                    {
                        txtCargo.Clear();
                        BuscarCargos();
                        panelCargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Agregue el sueldo", "Falta el sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Agregue el cargo", "Falta el cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void BuscarCargos()
        {
            DataTable dt = new DataTable();
            DatosCargos funcion = new DatosCargos();
            funcion.buscar_Cargos(ref dt, txtCargo.Text);
            dataListadoCargos.DataSource = dt;

            //aplicar los ajustes de la clase Bases
            Bases.DisenoDGV(ref dataListadoCargos);

            //ocultar las columnas del dgv para solo mostrar el nombre
            dataListadoCargos.Columns[1].Visible = false;
            dataListadoCargos.Columns[3].Visible = false;
            dataListadoCargos.Visible = true;// mostrar el datagv cuando escibamos

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            BuscarCargos();
        }

        private void btbAgregarCargos_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
            btnGuardarCargos.Visible = true;
            btnGuardarCargosC.Visible = false;
            txtCargoC.Clear();
            txtSueldoxHoraC.Clear();


        }

        private void LocalizarDgvCargos()
        { //cambiar tamano y localizacion
            dataListadoCargos.Location = new Point(txtSueldoHora.Location.X, txtSueldoHora.Location.Y); // ubicar el dataG en la posicion que esta el txtSueldoHora
            dataListadoCargos.Size = new Size(141, 469);
            dataListadoCargos.Visible = true;
            lblSueldo.Visible = false; // oculatar el label de sueldo ya que el dgv lo tapara
            panelBtnguardar.Visible = false;
        }

        private void btnGuardarCargos_Click(object sender, EventArgs e)
        {
            InsertarCargos();
        }

        private void txtSueldoxHoraC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoxHoraC, e); // funcion que solo permite teclas numericas
        }

        private void txtSueldoxHoraC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSueldoHora_KeyPress(object sender, KeyPressEventArgs e) // la letra e representa el evento key pres
        {
            Bases.Decimales(txtSueldoHora, e); //funcion que solo permite teclas numericas
        }

        private void dataListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //editar cargo
            if (e.ColumnIndex == dataListadoCargos.Columns["EditarC"].Index)
            {
                ObtenerCagosEditar();
            }
            //selecionar cargo
            if (e.ColumnIndex == dataListadoCargos.Columns["Cargo"].Index)
            {
                ObtenerDatosCargos();
            }
        }
        private void ObtenerDatosCargos()
        {
            IdCargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value);
            txtCargo.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoHora.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            dataListadoCargos.Visible = false;
            panel8.Visible = false;
            panelBtnguardar.Visible = true;
            lblSueldo.Visible = true;

        }
        private void ObtenerCagosEditar()
        {
            //La variable IdCargo la declaramos en arriba en esta clase

            IdCargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value); // la celda no. 1 corresponde al IdCargo

            txtCargoC.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoxHoraC.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            btnGuardarCargos.Visible = false;
            btnGuardarCargosC.Visible = true;
            txtCargoC.Focus(); //para que la barra de escritura aparezca en este campo
            txtCargoC.SelectAll(); //seleccionar el texto de ext campo
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
            panelPaginado.Visible = true;
        }

        private void btnVolverCago_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = false;
        }

        private void btnGuardarCargosC_Click(object sender, EventArgs e)
        {
            EditarCargos();
        }

        private void EditarCargos()
        {
            if (!string.IsNullOrEmpty(txtCargoC.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldoxHoraC.Text))
                {
                    LogicaCargos parametros = new LogicaCargos();
                    DatosCargos funcion = new DatosCargos();

                    parametros.Id_cargo = IdCargo;
                    parametros.Cargo = txtCargoC.Text;
                    parametros.SueldoCargo = Convert.ToDouble(txtSueldoxHoraC.Text);

                    if (funcion.editar_Cargo(parametros) == true)
                    {
                        MessageBox.Show("Cargo Actualizado Correctamente", "Cargo Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCargo.Clear();
                        BuscarCargos();
                        panelCargos.Visible = false;
                    }

                }
                else
                {
                    MessageBox.Show("Agregue el sueldo", "Falta el Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else
            {
                MessageBox.Show("Agregue el Cargo", "Falta el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlPersona_Load(object sender, EventArgs e)
        {
            ReiniciarPAginado();
            MostrarPersonal();

        }
        private void ReiniciarPAginado()
        {
            desde = 1;
            hasta = 10;
            Contar();
            if (contador > hasta)
            {
                btnPagSiguiente.Visible = true;
                btnPagAnterior.Visible = false;
                btnUltimaPag.Visible = true;
                btnPrimeraPag.Visible = true;
            }
            else
            {
                btnPagSiguiente.Visible = false;
                btnPagAnterior.Visible = false;
                btnUltimaPag.Visible = false;
                btnPrimeraPag.Visible = false;
            }

            Paginar();
        }

        private void dataListadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //eliminar
            if (e.ColumnIndex == dataListadoPersonal.Columns["Eliminar"].Index)
            {

                DialogResult result = MessageBox.Show("Se Desactivara la cuenta del usuario para que no pueda acceder, Desea Continuar? ", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    ELiminarPersonal();
                }

            }
            //editar
            if (e.ColumnIndex == dataListadoPersonal.Columns["Editar"].Index)
            {
                ObtenerDatos();

            }

        }
        private void ObtenerDatos()
        {
            Idpersonal = Convert.ToInt32(dataListadoPersonal.SelectedCells[2].Value);
            Estado = dataListadoPersonal.SelectedCells[8].Value.ToString();
            if (Estado == "ELIMINADO")
            {
                Restaurar_Personal();
            }
            else
            {
                LocalizarDgvCargos();
                txtNombres.Text = dataListadoPersonal.SelectedCells[3].Value.ToString();
                txtIdentificacion.Text = dataListadoPersonal.SelectedCells[4].Value.ToString();
                cbxPais.Text = dataListadoPersonal.SelectedCells[10].Value.ToString();
                txtCargo.Text = dataListadoPersonal.SelectedCells[6].Value.ToString();
                IdCargo = Convert.ToInt32(dataListadoPersonal.SelectedCells[7].Value);
                txtSueldoHora.Text = dataListadoPersonal.SelectedCells[5].Value.ToString();

                panelPaginado.Visible = false;
                panelRegistro.Visible = true;
                panelRegistro.Dock = DockStyle.Fill;
                dataListadoCargos.Visible = false;
                lblSueldo.Visible = true;
                panelBtnguardar.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnGuardarCambiosPersonal.Visible = true;
                panelCargos.Visible = false;

            }
        }
        private void Restaurar_Personal()
        {
            DialogResult result = MessageBox.Show("Este personal se Elimino, Desea Volver habilitarlo? ", "Restauracion de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                HabilitarPersonal();


            }
        }

        private void HabilitarPersonal()
        {
            LogicaPersonal parametros = new LogicaPersonal();
            DatosPersonal funcion = new DatosPersonal();
            parametros.Id_Personal = Idpersonal;
            if (funcion.RestaurarPersonal(parametros))
            {
                MostrarPersonal();
            }
        }

        private void ELiminarPersonal()
        {
            Idpersonal = Convert.ToInt32(dataListadoPersonal.SelectedCells[2].Value);
            LogicaPersonal parametros = new LogicaPersonal();
            DatosPersonal funcion = new DatosPersonal();
            parametros.Id_Personal = Idpersonal;

            if (funcion.eliminarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisenarDtvPersonal();
            timer1.Stop(); // igual que  timer1.Enable = false;
        }

        private void EditarPersonal()
        {
            LogicaPersonal parametros = new LogicaPersonal();
            DatosPersonal funcion = new DatosPersonal();

            parametros.Id_Personal = Idpersonal;
            parametros.Nombre = txtNombres.Text;
            parametros.Identificacion = txtIdentificacion.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_cargo = IdCargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);

            if (funcion.editarPersonal(parametros) == true)
            {
                ReiniciarPAginado();
                MostrarPersonal();
                panelRegistro.Visible = false;

            }


        }

        private void btnGuardarCambiosPersonal_Click(object sender, EventArgs e)
        {
            EditarPersonal();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            desde += 10;
            hasta += 10;
            MostrarPersonal();
            Contar();

            if (contador > hasta)
            {
                btnPagSiguiente.Visible = true;
                btnPagAnterior.Visible = true;
            }
            else
            {
                btnPagSiguiente.Visible = false;
                btnPagAnterior.Visible = true;
            }
            Paginar();
        }

        private void Paginar()
        {
            try
            {
                lblPagina.Text = (hasta / item_por_pagina).ToString();

                //math.Ceiling devuelve el numero entero mayor al decimal mas cercano.
                lblTotalPag.Text = Math.Ceiling(Convert.ToSingle(contador) / item_por_pagina).ToString();
                totalPaginas = Convert.ToInt32(lblTotalPag.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Contar()
        {
            DatosPersonal funcion = new DatosPersonal();
            funcion.ContarPersonal(ref contador);
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta -= 10;

            MostrarPersonal();
            Contar();
            if (contador > hasta)
            {
                btnPagSiguiente.Visible = true;
                btnPagAnterior.Visible = true;

            }
            else

            {
                btnPagSiguiente.Visible = false; ;
                btnPagAnterior.Visible = true;

            }
            if (desde == 1)
            {
                ReiniciarPAginado();
            }
            Paginar();

        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {
            hasta = totalPaginas * item_por_pagina; //20 //30
            desde = hasta - 9; // 11 //21
            MostrarPersonal();
            Contar();

                if (contador > hasta)
            {
                btnPagSiguiente.Visible = true;
                btnPagAnterior.Visible = true;

            }
            else

            {
                btnPagSiguiente.Visible = false; ;
                btnPagAnterior.Visible = true;

            }
            Paginar();
        }

        private void btnPrimeraPag_Click(object sender, EventArgs e)
        {
            ReiniciarPAginado();
            MostrarPersonal();
        }

        private void BuscarPersonal()
        {
            DataTable dt = new DataTable();
            DatosPersonal funcion = new DatosPersonal();
            funcion.BuscarPersonal(ref dt, desde, hasta, txtBuscador.Text);
            dataListadoPersonal.DataSource = dt;

            DisenarDtvPersonal();
             
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReiniciarPAginado();
            MostrarPersonal();
        }
    }
}
