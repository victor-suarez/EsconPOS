﻿using EsconPOS.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmUnidadMedida : Form
    {
        private mainEntities context = new mainEntities();

        private void CargarUnidades()
        {
            var dataset = context.UnidadesMedidas
                .Select(u => new {
                    ID = u.UnidadMedidaID,
                    Codigo = u.Codigo,
                    Descripción = u.UnidadMedida,
                    Iniciales = u.Iniciales,
                    En_Uso = u.Activo == 0 ? "NO" : "SI"
                }).ToList();
            DgvUnidades.DataSource = dataset;
            DgvUnidades.Columns["ID"].Visible = false;
            DgvUnidades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtUnidadMedida.Text = "";
            TxtIniciales.Text = "";
            ChkActiva.Checked = false;
        }

        private void MoverRegistroToCrt(long ID)
        {
            var und = (from u in context.UnidadesMedidas
                       where u.UnidadMedidaID == ID
                       select u).First();

            TxtCodigo.Text = und.Codigo;
            TxtCodigo.Tag = und.UnidadMedidaID;
            TxtUnidadMedida.Text = und.UnidadMedida;
            TxtIniciales.Text = und.Iniciales ?? "";
            ChkActiva.Checked = (und.Activo == 1);
            if (und.EmpleadoUpd != null)
                TssLblModificado.Text = (und.EmpleadoUpd.Login.ToLower() + " " + und.ModificadoEl) ?? "";
            else
                TssLblModificado.Text = "";
        }

        private void Eliminar()
        {
            if (TxtCodigo.Tag == null) return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                long ID = long.Parse(TxtCodigo.Tag.ToString());
                var und = context.UnidadesMedidas.Single(u => u.UnidadMedidaID == ID);
                context.UnidadesMedidas.Attach(und);
                context.UnidadesMedidas.Remove(und);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                    Global.MensajeErrorBd(ex, "Error eliminando unidad de medida.");
                else
                    Global.MensajeError(ex, "Error eliminando unidad de medida.");
                return;
            }
            SetStatus("Unidad de medida eliminada.");
            ClearCrt();
            CargarUnidades();
            Cursor.Current = Cursors.Default;
        }

        private void Guardar()
        {
            if (!ValEntReq()) return;
            Cursor.Current = Cursors.WaitCursor;
            if (TxtCodigo.Tag == null)
            {
                try
                {
                    context.UnidadesMedidas.Add
                    (
                        new UnidadesMedidas
                        {
                            Codigo = TxtCodigo.Text,
                            UnidadMedida = TxtUnidadMedida.Text,
                            Iniciales = string.IsNullOrEmpty(TxtIniciales.Text) ? null : TxtIniciales.Text,
                            Activo = ChkActiva.Checked ? 1 : 0
                        }
                    );
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                        Global.MensajeErrorBd(ex, "Error guardando datos de la unidad de medida.");
                    else
                        Global.MensajeError(ex, "Error guardando datos de la unidad de medida.");
                    return;
                }
                SetStatus("Unidad de medida de productos agregada.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var und = context.UnidadesMedidas.Single(u => u.UnidadMedidaID == ID);
                    context.UnidadesMedidas.Attach(und);

                    und.Codigo = TxtCodigo.Text;
                    und.UnidadMedida = TxtUnidadMedida.Text;
                    und.Iniciales = string.IsNullOrEmpty(TxtIniciales.Text) ? null : TxtIniciales.Text;
                    und.Activo = ChkActiva.Checked ? 1 : 0;
                    und.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    und.ModificadoPor = Global.Usuario.UsuarioID;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                        Global.MensajeErrorBd(ex, "Error modificando datos de la unidad de medida.");
                    else
                        Global.MensajeError(ex, "Error modificando datos de la unidad de medida.");
                    return;
                }
                SetStatus("Unidad de medida de productos modificada.");
            }; //(.Tag != null)
            ClearCrt();
            CargarUnidades();
            Cursor.Current = Cursors.Default;
        }

        private void SetStatus(string Status = "", bool Error = false)
        {
            if (Error)
                TssLblStatus.ForeColor = Color.Red;
            else
                TssLblStatus.ForeColor = SystemColors.ControlText;
            TssLblStatus.Text = Status;
        }

        private bool ValEntReq()
        {
            if (TxtCodigo.Text.Trim().Length == 0)
            {
                TxtCodigo.Focus();
                MessageBox.Show("Debe transcribir un código para la unidad de medida.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtUnidadMedida.Text.Trim().Length == 0)
            {
                TxtUnidadMedida.Focus();
                MessageBox.Show("Debe transcribir el nombre de la unidad de medida.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Chk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((CheckBox)sender, true, true, true, false);
            }
        }

        private void DgvUnidades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvUnidades["ID", e.RowIndex].Value.ToString()));
            TabUnidades.SelectTab("PagEditar");
        }

        public FrmUnidadMedida()
        {
            InitializeComponent();
        }

        private void FrmUnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarUnidades();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                CargarUnidades();
            }
            else
            {
                if (((TextBox)sender).Name == "TxtFiltroUnidad")
                {
                    var filtered_dataset = context.UnidadesMedidas
                        .Where(u => u.UnidadMedida.Contains(((TextBox)sender).Text))
                        .Select(u => new
                        {
                            ID = u.UnidadMedidaID,
                            Codigo = u.Codigo,
                            Descripción = u.UnidadMedida,
                            Iniciales = u.Iniciales,
                            En_Uso = u.Activo == 0 ? "NO" : "SI"
                        }).ToList();
                    DgvUnidades.DataSource = filtered_dataset;
                    DgvUnidades.Columns["ID"].Visible = false;
                    DgvUnidades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                }
                else
                if (((TextBox)sender).Name == "TxtFiltroCodigo")
                {
                    var filtered_dataset = context.UnidadesMedidas
                        .Where(u => u.Codigo.Contains(((TextBox)sender).Text))
                        .Select(u => new
                        {
                            ID = u.UnidadMedidaID,
                            Codigo = u.Codigo,
                            Descripción = u.UnidadMedida,
                            Iniciales = u.Iniciales,
                            En_Uso = u.Activo == 0 ? "NO" : "SI"
                        }).ToList();
                    DgvUnidades.DataSource = filtered_dataset;
                    DgvUnidades.Columns["ID"].Visible = false;
                    DgvUnidades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                }
            }
        }

        private void TsBtnDeshacer_Click(object sender, EventArgs e)
        {
            ClearCrt();
        }

        private void TsBtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void TsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void TsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}