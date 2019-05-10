using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using MotornaVozila.Entiteti;
using MotornaVozila.Mapiranja;

namespace MotornaVozila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Ucitavaju se podaci o zaposlenom sa specificiranim id-em
                Zaposleni zaposleni = s.Load<Zaposleni>(33);
                Servis servis = s.Load<Servis>(3);

                MessageBox.Show(servis.odgovorniTehnicar.ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();


            //    Entiteti.Prodavnica p = new Entiteti.Prodavnica();

            //    //p = s.Load<Entiteti.Prodavnica>(81);
           
            //    p.Naziv = "Emmi Shop II";
            //    p.RadniDan = "08-20";
            //    p.Subota = "08-14";
            //    p.Nedelja = "Ne radi";


            //    //s.Save(p);
            //    s.SaveOrUpdate(p);

            //    s.Flush();
            //    s.Close();
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void cmdManytoOne_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    //Ucitavaju se podaci o prodavnici za zadatim brojem
            //    Odeljenje o = s.Load<Odeljenje>(5);

            //    MessageBox.Show(o.Tip);
            //    MessageBox.Show(o.PripadaProdavnici.Naziv);

            //    s.Close();
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    //Ucitavaju se podaci o prodavnici za zadatim brojem
            //    MotornaVozila.Entiteti.Prodavnica p = s.Load<MotornaVozila.Entiteti.Prodavnica>(61);

            //    foreach (Odeljenje o in p.Odeljenja)
            //    {
            //        MessageBox.Show(o.Tip + " " + o.Lokacija);
            //    }

            //    s.Close();
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
        }

        private void cmdCreateOdeljenje_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    Entiteti.Prodavnica p = new Entiteti.Prodavnica();

            //    //p = s.Load<Entiteti.Prodavnica>(81);

            //    p.Naziv = "Emmi Shop III";
            //    p.RadniDan = "08-20";
            //    p.Subota = "08-14";
            //    p.Nedelja = "Ne radi";

            //    Odeljenje o = new Odeljenje();

            //    o.Tip = "DO5";
            //    o.Lokacija = "Nis";
            //    o.BrojKasa = 1;
            //    o.InfoPult = "Da";

                
            //    p.Odeljenja.Add(o);

            //    //ako je kod prodavnice kolekcija postavljena na Inverse
            //    //obavezno ukoliko za Foreign Key BROJ postavimo da je NOT NULL
            //    //o.PripadaProdavnici = p;

            //    s.Save(p);
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}
            

        }

    }
}
