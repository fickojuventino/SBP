﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MotornaVozila.Entiteti;
using NHibernate;
using NHibernate.Linq;

namespace MotornaVozila
{
    public partial class frmKupac : Form
    {
        private DataTable _kupci = new DataTable();
        private bool noviKupac = false;

        public frmKupac()
        {
            InitializeComponent();
        }

        private void frmKupac_Load(object sender, EventArgs e)
        {
            dgvKupac.AllowUserToAddRows = false;
            dgvKupac.AllowUserToDeleteRows = false;
            dgvKupac.AllowUserToOrderColumns = false;
            dgvKupac.AllowUserToResizeRows = false;
            dgvKupac.AllowUserToResizeColumns = false;
            dgvKupac.ReadOnly = true;
            dgvKupac.MultiSelect = false;
            dgvKupac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKupac.DataBindingComplete += delegate
            {
                foreach (DataGridViewColumn c in dgvKupac.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dgvKupac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvKupac.RowHeadersVisible = false;
            };

            GetData();
        }

        private void GetData()
        {
            _kupci = new DataTable();

            _kupci.Columns.Add("IdKupac");
            _kupci.Columns.Add("Ime");
            _kupci.Columns.Add("Prezime");
            _kupci.Columns.Add("Telefon");
            _kupci.Columns.Add("TipLica");
            _kupci.Columns.Add("PIB");
            _kupci.Columns.Add("MATBR");

            ISession session = DataLayer.GetSession();

            var kupci = (from kpc in session.Query<Kupac>()
                           select kpc).ToList();

            foreach (var kpc in kupci)
            {
                var newRow = _kupci.NewRow();

                newRow[0] = kpc.id;
                newRow[1] = kpc.ime;
                newRow[2] = kpc.prezime;
                newRow[3] = kpc.telefon;
                newRow[4] = kpc.tipLica;
                newRow[5] = kpc.pib;
                newRow[6] = kpc.maticniBroj;

                _kupci.Rows.Add(newRow);
            }

            dgvKupac.DataSource = _kupci;

            dgvKupac.Columns["IdKupac"].Width = 60;
            dgvKupac.Columns["Ime"].Width = 60;
            dgvKupac.Columns["Prezime"].Width = 70;
            dgvKupac.Columns["Telefon"].Width = 80;
            dgvKupac.Columns["TipLica"].Width = 60;
            dgvKupac.Columns["PIB"].Width = 60;

            session.Close();
        }

        private void dgvKupac_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKupac.SelectedRows.Count <= 0 || dgvKupac.DataSource == null)
                return;
            else
            {                
                txt_ime.Text = dgvKupac.SelectedRows[0].Cells[1].Value.ToString();
                txt_prezime.Text = dgvKupac.SelectedRows[0].Cells[2].Value.ToString();
                txt_telefon.Text = dgvKupac.SelectedRows[0].Cells[3].Value.ToString();
                cb_tip_lica.Text = dgvKupac.SelectedRows[0].Cells[4].Value.ToString();
                txt_pib.Text = dgvKupac.SelectedRows[0].Cells[5].Value.ToString();
                txt_mat_br.Text = dgvKupac.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btn_novi_Click(object sender, EventArgs e)
        {
            noviKupac = true;

            txt_ime.Text = string.Empty;
            txt_prezime.Text = string.Empty;
            txt_telefon.Text = string.Empty;
            cb_tip_lica.Text = string.Empty;
            txt_pib.Text = string.Empty;
            txt_mat_br.Text = string.Empty;
            txt_id_kup_vozila.Text = string.Empty;
            txt_ime.Focus();
        }

        private void btn_obustavi_Click(object sender, EventArgs e)
        {
            noviKupac = false;
            dgvKupac_SelectionChanged(sender, e);
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                //kreira novog kupca
                if (noviKupac)
                {
                    if (string.IsNullOrEmpty(txt_ime.Text) || string.IsNullOrEmpty(txt_prezime.Text))
                    {
                        MessageBox.Show("Polja Ime i Prezime ne smeju biti prazna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();

                    Kupac kupac = new Kupac();

                    kupac.ime = txt_ime.Text;
                    kupac.prezime = txt_prezime.Text;

                    if (string.IsNullOrEmpty(txt_telefon.Text))
                        kupac.telefon = null;
                    else
                        kupac.telefon = Double.Parse(txt_telefon.Text);
                    
                        kupac.tipLica = cb_tip_lica.Text;                    
                    
                    if(kupac.tipLica == "pravno")
                    {
                        kupac.pib = Double.Parse(txt_pib.Text);
                        kupac.maticniBroj = null;
                    }
                    else if(kupac.tipLica == "fizicko")
                    {
                        kupac.maticniBroj = Double.Parse(txt_mat_br.Text);
                        kupac.pib = null;
                    }                                  

                    if(!string.IsNullOrEmpty(txt_id_kup_vozila.Text))
                    {
                        var vozilo = (from v in session.Query<Vozilo>()
                                     where v.id == int.Parse(txt_id_kup_vozila.Text)
                                     select v).SingleOrDefault();
                        kupac.vozila.Add(vozilo);
                    }
                    
                    session.Save(kupac);
                    session.Flush();
                    session.Close();

                    GetData();
                    noviKupac = false;
                }
                //azurira postojeceg kupca
                else
                {
                    if (string.IsNullOrEmpty(txt_ime.Text) || string.IsNullOrEmpty(txt_prezime.Text))
                    {
                        MessageBox.Show("Polja Ime i Prezime ne smeju biti parzna!", "Upozorenje",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ISession session = DataLayer.GetSession();
                    int.TryParse(dgvKupac.SelectedRows[0].Cells[0].Value.ToString(), out var id);
                    Kupac kupac = session.Load<Kupac>(id);
                      
                    kupac.ime = txt_ime.Text;
                    kupac.prezime = txt_prezime.Text;
                    kupac.telefon = Double.Parse(txt_telefon.Text);
                    kupac.tipLica = cb_tip_lica.Text;

                    if (kupac.tipLica == "pravno")
                    {
                        kupac.pib = Double.Parse(txt_pib.Text);
                        kupac.maticniBroj = null;
                    }
                    else
                    {
                        kupac.pib = null;
                        kupac.maticniBroj = Double.Parse(txt_mat_br.Text);
                    }

                    if (!string.IsNullOrEmpty(txt_id_kup_vozila.Text))
                    {
                        var vozilo = (from v in session.Query<Vozilo>()
                                      where v.id == int.Parse(txt_id_kup_vozila.Text)
                                      select v).SingleOrDefault();
                        kupac.vozila.Add(vozilo);
                    }

                    session.SaveOrUpdate(kupac);

                    session.Flush();
                    session.Close();
                    GetData();
                }
            }
            catch (Exception catchException)
            {
                MessageBox.Show(catchException.Message + catchException.InnerException, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKupac.Rows.Count <= 0 || dgvKupac.SelectedRows.Count <= 0)
                    return;

                var dr = MessageBox.Show("Da li ste sigurno da zelite da izbrisete kupca?", "Kupac",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ISession session = DataLayer.GetSession();

                int.TryParse(dgvKupac.SelectedRows[0].Cells[0].Value.ToString(), out var id);

                var kupac = (from kpc in session.Query<Kupac>()
                             where kpc.id == id
                             select kpc).SingleOrDefault();
                
                for (int i = kupac.vozila.Count; i > 0; i--)
                {
                    kupac.vozila[i - 1].kupac = null;
                    session.Update(kupac.vozila[i - 1]);
                    kupac.vozila.RemoveAt(i - 1);
                }

                session.Delete(kupac);
                session.Flush();
                session.Close();

                GetData();
            }
            catch (Exception catchException)
            {
                MessageBox.Show(catchException.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
