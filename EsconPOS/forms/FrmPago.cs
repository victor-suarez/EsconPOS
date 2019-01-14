using EsconPOS.classes;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmPago : Form
    {
        #region Variables y constantes

        private const string Numeros = "0123456789";
        private Color ColorFaltante = Color.IndianRed;
        private Color ColorSobrante = Color.LawnGreen;
        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Propiedades

        private double _MtoFaltante;
        private double _MtoPagado;
        private double _MtoSobrante;
        private Documentos _documento;

        public Documentos documento
        {
            get { return _documento; }
            set { _documento = value; }
        }


        public double MtoFaltante
        {
            get { return _MtoFaltante; }
            set { _MtoFaltante = value; }
        }

        public double MtoPagado
        {
            get { return _MtoPagado; }
            set { _MtoPagado = value; }
        }

        public double MtoSobrante
        {
            get { return _MtoSobrante; }
            set { _MtoSobrante = value; }
        }

        #endregion Propiedades

        #region Funciones

        private void ActualizaDatosEnPantalla()
        {
            LblCodDocumento.Text = documento.CodDocumento;
            LblMontoTotal.Text = documento.MontoNeto.ToString("N2");
            LblMontoFaltante.Text = this.MtoFaltante.ToString("N2");
            LblMontoSobrante.Text = this.MtoSobrante.ToString("N2");
        }

        private void ActualizaTotalesDoc(decimal Monto)
        {
            this.MtoPagado += (double)NumMontoPago.Value;
            // Calcular faltante o sobrante
            if (this.MtoPagado <= documento.MontoNeto)
            {
                this.MtoSobrante = 0;
                this.MtoFaltante = documento.MontoNeto - this.MtoPagado;
            }
            else
            {
                this.MtoFaltante = 0;
                this.MtoSobrante = this.MtoPagado - documento.MontoNeto;
            }
        }

        private void CargarBancos()
        {
            CmbBanco.DataSource = context.Bancos
                                  .Where(b => b.Activo == 1)
                                  .OrderBy("Nombre")
                                  .ToList();
            CmbBanco.DisplayMember = "Nombre";
            CmbBanco.ValueMember = "BancoID";
            if (CmbBanco.Items.Count == 1)
                CmbBanco.SelectedIndex = 0;
            else
                CmbBanco.SelectedIndex = -1;
        }

        private void CargarCombos()
        {
            CargarBancos();
            CargarFormasPago();
        }

        private void CargarFormasPago()
        {
            CmbFormaPago.DataSource = context.FormasPagos
                                        .Where(f => f.Activo == 1)
                                        .OrderBy("Orden")
                                        .ToList();
            CmbFormaPago.DisplayMember = "FormaPago";
            CmbFormaPago.ValueMember = "FormaPagoID";
            if (CmbFormaPago.Items.Count == 1)
                CmbFormaPago.SelectedIndex = 0;
            else
                CmbFormaPago.SelectedIndex = -1;
        }

        private void FormaPagoAgregar()
        {
            if (!FormaPagoExiste(((FormasPagos)CmbFormaPago.SelectedItem).FormaPagoID))
            {
                // Agregar fila al grid
                int NewRowIdx = dgvPagos.Rows.Add(
                                                    ((FormasPagos)CmbFormaPago.SelectedItem).Codigo,
                                                    NumMontoPago.Value.ToString("N2"),
                                                    CmbBanco.SelectedIndex == -1 ? "" : ((Bancos)CmbBanco.SelectedItem).Iniciales,
                                                    TxtNroDocPago.Text.Trim(),
                                                    TxtNroAutPago.Text.Trim()
                                                );

                dgvPagos.Rows[NewRowIdx].Tag = new Pagos
                {
                    FormaPagoID = ((FormasPagos)CmbFormaPago.SelectedItem).FormaPagoID,
                    MonedaID = documento.MonedaID,
                    MontoPago = (double)NumMontoPago.Value,
                    BancoID = CmbBanco.SelectedIndex == -1 ? -1 : ((Bancos)CmbBanco.SelectedItem).BancoID,
                    NroDocPago = TxtNroDocPago.Text.Trim() == "" ? null : TxtNroDocPago.Text.Trim(),
                    Autorizacion = TxtNroAutPago.Text.Trim() == "" ? null : TxtNroAutPago.Text.Trim(),
                    AgregadoEl = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    AgregadoPor = Global.glEmpleado
                };

                ActualizaTotalesDoc(NumMontoPago.Value);
                // Desplegar los totales
                LblMontoFaltante.Text = this.MtoFaltante.ToString("N2");
                LblMontoSobrante.Text = this.MtoSobrante.ToString("N2");
                // Decorar los totales
                LblMontoFaltante.BackColor = this.MtoFaltante != 0 ? ColorFaltante : SystemColors.Control;
                LblMontoSobrante.BackColor = this.MtoSobrante != 0 ? ColorSobrante : SystemColors.Control;
                if (this.MtoPagado >= documento.MontoNeto)
                    //Guardar pagos
                    FormaPagoGuardar();
            }
        }

        private void FormaPagoEliminar(int rowIdx)
        {
            ActualizaTotalesDoc((decimal)dgvPagos["colMontoPago", rowIdx].Value * -1);
            dgvPagos.Rows.RemoveAt(rowIdx);
        }

        private bool FormaPagoExiste(long ID)
        {
            foreach (DataGridViewRow row in dgvPagos.Rows)
            {
                if ((long)row.Tag == ID) return true;
            };
            return false;
        }

        private void FormaPagoGuardar()
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataGridViewRow row in dgvPagos.Rows)
            {
                try
                {
                    var pago = new Pagos
                    {
                        DocumentoID = documento.DocumentoID,
                        FormaPagoID = ((Pagos)row.Tag).FormaPagoID,
                        MonedaID = ((Pagos)row.Tag).MonedaID,
                        MontoPago = ((Pagos)row.Tag).MontoPago,
                        BancoID = ((Pagos)row.Tag).BancoID,
                        NroDocPago = ((Pagos)row.Tag).NroDocPago,
                        Autorizacion = ((Pagos)row.Tag).Autorizacion,
                        AgregadoEl = ((Pagos)row.Tag).AgregadoEl,
                        AgregadoPor = ((Pagos)row.Tag).AgregadoPor
                    };
                    documento.Pagos.Add(pago);
                }
                catch (System.Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando el documento de pago.");
                    Cursor.Current = Cursors.Default;
                    return;
                }
            }
            // Modificar documento con el total pagado
            context.Documentos.Attach(documento);
            documento.MontoPagado = this.MtoPagado;
            try
            {
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                Global.MensajeError(ex, "Error guardando el documento pagado.");
                return;
            }
            Cursor.Current = Cursors.Default;
        }

        private bool ValEntReq()
        {
            if (CmbFormaPago.SelectedIndex == -1)
            {
                CmbFormaPago.Focus();
                MessageBox.Show("Debe seleccionar la forma del pago de la lista.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (NumMontoPago.Value == 0)
            {
                NumMontoPago.Focus();
                MessageBox.Show("Debe transcribir el monto del pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (((FormasPagos)CmbFormaPago.SelectedItem).RequiereBanco == 1 && CmbBanco.SelectedIndex == -1)
            {
                CmbBanco.Focus();
                MessageBox.Show("Debe seleccionar el banco emisor del documento de pago de la lista.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (((FormasPagos)CmbFormaPago.SelectedItem).RequiereNumero == 1 && TxtNroDocPago.Text.Trim().Length == 0)
            {
                TxtNroDocPago.Focus();
                MessageBox.Show("Debe transcribir el número del documento de pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (((FormasPagos)CmbFormaPago.SelectedItem).RequiereAutorizacion == 1 && TxtNroAutPago.Text.Trim().Length == 0)
            {
                TxtNroAutPago.Focus();
                MessageBox.Show("Debe transcribir el código de autorización emitido por el emisor del documento de pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void VerifCamposReq()
        {
            if (CmbFormaPago.SelectedIndex == -1) return;
            var formapago = (FormasPagos)CmbFormaPago.SelectedItem;

            LblBanco.Visible = (formapago.RequiereBanco == 1);
            CmbBanco.Visible = (formapago.RequiereBanco == 1);
            LblNroDocPago.Visible = (formapago.RequiereNumero == 1);
            TxtNroDocPago.Visible = (formapago.RequiereNumero == 1);
            LblNroAutPago.Visible = (formapago.RequiereAutorizacion == 1);
            TxtNroAutPago.Visible = (formapago.RequiereAutorizacion == 1);

            if (formapago.RequiereBanco == 1 || formapago.RequiereNumero == 1 || formapago.RequiereAutorizacion == 1)
                GbxDatosAdicionales.Visible = true;
        }

        #endregion Funciones

        #region Métodos

        public FrmPago()
        {
            InitializeComponent();
        }

        // Siguiente campo cuando presiona [ENTER]. Limpia selección cuando presiona [ESC].
        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                ((ComboBox)sender).SelectedIndex = -1;
            }
        }

        private void CmbFormaPago_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            VerifCamposReq();
        }

        private void FrmPago_Load(object sender, System.EventArgs e)
        {
            CargarCombos();
            ActualizaDatosEnPantalla();
        }

        private void Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (((NumericUpDown)sender).Name == "NumMontoPago" && !GbxDatosAdicionales.Visible)
                    TsBtnAgregar_Click(null, null);
                else
                    SelectNextControl((NumericUpDown)sender, true, true, true, false);
            }
        }

        private void TsBtnAgregar_Click(object sender, System.EventArgs e)
        {
            FormaPagoAgregar();
        }

        private void TsBtnEliminar_Click(object sender, System.EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count == 0) return;
            FormaPagoEliminar(((DataGridView)sender).SelectedRows[0].Index);
        }

        private void TsBtnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #endregion Métodos
    }
}