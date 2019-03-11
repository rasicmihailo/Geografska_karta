using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeografskaKartaNovo.Entiteti;
using GeografskaKartaNovo.Mapiranja;
using GeografskaKartaNovo;
using NHibernate.Linq;
using NHibernate.Criterion;
using NHibernate;

namespace GeografskaKartaNovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        
        private void btnDodajGeog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Entiteti.GeografskiObjekat prvi = new Entiteti.GeografskiObjekat();

                prvi.Naziv = "Juzna Morava";

                session.Save(prvi);

                session.Flush();
                session.Close();

                MessageBox.Show("Dodat je novi geografski objekat.");

            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajTackasti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                TackastiObjekat t = new TackastiObjekat();

                t.Naziv = "Novi Pazar";
                t.X_tac = 110;
                t.Y_tac = 155;
                t.Datum_Osnivanja=new DateTime(2011,03,01);
                t.F_naseljeno = 1;
                t.Broj_Stanovnika = 250000;
                t.Tip_naselja = "100000-500000";
                t.Opstina = "Novi Pazar";
                t.F_turisticko = 0;

                session.Save(t);

                session.Flush();
                session.Close();

                MessageBox.Show("Dodat je novi tackasti objekat.");

            }catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajLinijski_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                LinijskiObjekat linijski = new LinijskiObjekat();

                linijski.Naziv = "Tara";
                linijski.Tip_Objekta = "reka";
                linijski.Duzina = "2000";
                linijski.Opis_Objekta = "plovna";

                session.Save(linijski);

                session.Flush();
                session.Close();

                MessageBox.Show("Dodat je novi linijski objekat.");

            }catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajPovrsinski_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                PovrsinskiObjekat povrsinski = new PovrsinskiObjekat();

                povrsinski.Naziv = "Sava";
                
                session.Save(povrsinski);

                session.Flush();
                session.Close();

                MessageBox.Show("Dodat je novi povrsinski objekat.");
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnDodajUzvisenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Uzvisenje uzvisenje = new Uzvisenje();

                uzvisenje.Naziv = "Mont Everest";
                uzvisenje.Nadmorska_visina = 8848;


                session.Save(uzvisenje);

                session.Flush();
                session.Close();

                MessageBox.Show("Dodato je novo uzvisenje.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVodnaPovrsina_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                VodnaPovrsina vodna = new VodnaPovrsina();

                vodna.Naziv = "Zvornicko";
                vodna.Tip_Vode = "jezero";

                session.Save(vodna);

                session.Flush();
                session.Close();

                MessageBox.Show("Dodata je nova vodna povrsinska.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        
        private void btnDodajZnamenitosti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                TackastiObjekat tac = session.Load<TackastiObjekat>(155);

                Znamenitost z1 = new Znamenitost();
                Znamenitost z2 = new Znamenitost();

                //prva znemenitost
                z1.Naziv_Znamenitost = "Rostilj";
                z1.Id_Naseljenog_Mesta = tac;
                tac.Lista_Znamenitosti.Add(z1);
                session.Save(z1);

                //druga znamenitost
                z2.Naziv_Znamenitost = "FK Zeleznicar";
                z2.Id_Naseljenog_Mesta = tac;
                tac.Lista_Znamenitosti.Add(z2);
                session.Save(z2);

                session.Flush();
                session.Close();

                MessageBox.Show("Dodate su nove znamenitosti.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajVrhove_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Uzvisenje uzvisenje = session.Load<Uzvisenje>(103);

                ListaVrhova l1 = new ListaVrhova();
                ListaVrhova l2 = new ListaVrhova();

                //prvi vrh
                l1.Id_Uzvisenja = uzvisenje;
                l1.Ime = "Khumbutse";
                l1.Nadmorska_visina = 6700;
                uzvisenje.Lista_Vrhova.Add(l1);
                session.Save(l1);

                //drugi vrh
                l2.Id_Uzvisenja = uzvisenje;
                l2.Ime = "Arkhale";
                l2.Nadmorska_visina = 7200;
                uzvisenje.Lista_Vrhova.Add(l2);
                session.Save(l2);
             
                session.Close();

                MessageBox.Show("Dodati su novi vrhovi.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajKoordinate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                LinijskiObjekat linijski = session.Load<LinijskiObjekat>(101);

                Koordinate k1 = new Koordinate();
                Koordinate k2 = new Koordinate();
                Koordinate k3 = new Koordinate();

                //prva koordinata
                k1.Id_Linijskog_Objekta = linijski;
                k1.X_lin =100;
                k1.Y_lin = 120;
                linijski.ListaKoordinata.Add(k1);
                session.Save(k1);

                //druga koordinata
                k2.Id_Linijskog_Objekta = linijski;
                k2.X_lin = 130;
                k2.Y_lin = 160;
                linijski.ListaKoordinata.Add(k2);
                session.Save(k2);

                //treca koordinata
                k3.Id_Linijskog_Objekta = linijski;
                k3.X_lin = 180;
                k3.Y_lin = 240;
                linijski.ListaKoordinata.Add(k3);
                session.Save(k3);


                session.Flush();
                session.Close();

                MessageBox.Show("Dodate su nove koordinate.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Lin_Tac_SADRZITAC_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                SadrziTac sadrziTac = new SadrziTac();

                LinijskiObjekat linijski = session.Load<LinijskiObjekat>(164);
                TackastiObjekat tackasti = session.Load<TackastiObjekat>(158);

                linijski.Lista_Tackastih_objekata.Add(tackasti);
                tackasti.Lista_Linijskih_objekata.Add(linijski);

                linijski.Lista_SadrziTac.Add(sadrziTac);
                tackasti.Lista_SadrziTac.Add(sadrziTac);
                //reference
                sadrziTac.Id_Linijskog_Objekta = linijski;
                sadrziTac.Id_Tackastog_Objekta = tackasti;
                //dodavanje u listu
                sadrziTac.Lista_Linijski_Objekat.Add(linijski);
                sadrziTac.Lista_Tackasti_Objekat.Add(tackasti);

                session.Save(sadrziTac);

       
                session.Close();

                MessageBox.Show("Dodata je nova veza Linijski-Sadrzi-Tackasti.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }

        private void Povrs_Lin_SADRZILIN_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                SadrziLin sadrziLin = new SadrziLin();

                LinijskiObjekat linijski = session.Load<LinijskiObjekat>(104);
                Uzvisenje uzvisenje = session.Load<Uzvisenje>(171);

                linijski.Lista_Povrsinskih_objekata.Add(uzvisenje);
                uzvisenje.Lista_Linijskih_objekata.Add(linijski);

                linijski.Lista_SadrziLin.Add(sadrziLin);
                uzvisenje.Lista_SadrziLin.Add(sadrziLin);

                //reference
                sadrziLin.Id_Linijskog_Objekta = linijski;
                sadrziLin.Id_Povrsinskog_Objekta = uzvisenje;
                //dodavanje u listu
                sadrziLin.Lista_Linijski_Objekat.Add(linijski);
                sadrziLin.Lista_Povrsinski_Objekat.Add(uzvisenje);


                session.Save(sadrziLin);

                session.Close();

                MessageBox.Show("Dodata je nova veza Povrsinski-Sadrzi-Linijski.");

            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Uzvisenje_Geog_SADRZIGEOG_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                SadrziGeog sadrziGeog = new SadrziGeog();

                GeografskiObjekat geografski = session.Load<GeografskiObjekat>(5);
                Uzvisenje uzvisenje = session.Load<Uzvisenje>(173);

                geografski.Lista_Uzvisenja.Add(uzvisenje);
                uzvisenje.Lista_Geografskih_objekata.Add(geografski);

                geografski.Lista_Sadrzi_Geog.Add(sadrziGeog);
                uzvisenje.Lista_Sadrzi_Geog.Add(sadrziGeog);

                //reference
                sadrziGeog.Id_Geografskog_Objekta = geografski;
                sadrziGeog.Id_Uzvisenog_Objekta = uzvisenje;
                //dodavanje u listu
                sadrziGeog.Lista_Geografski_Objekat.Add(geografski);
                sadrziGeog.Lista_Uzvisenje_Objekat.Add(uzvisenje);


                session.Save(sadrziGeog);

   
                session.Close();
                MessageBox.Show("Dodata je nova veza Uzvisenje-Sadrzi-Geografski.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnPrikazGeog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.GeografskiObjekat g = s.Load<Entiteti.GeografskiObjekat>(5);

                MessageBox.Show(g.Id + " " + g.Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnTac_Znamen_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.TackastiObjekat g = s.Load<Entiteti.TackastiObjekat>(151);

                IQuery q = s.CreateQuery("from Znamenitost as z where z.Id_Naseljenog_Mesta = 151");

                g.Lista_Znamenitosti = q.List<Znamenitost>();



                MessageBox.Show(g.Id + " " + g.Naziv + " " + g.X_tac + " " + g.Y_tac + " "
                    + g.Datum_Osnivanja + " " + g.Tip_naselja + " " + g.Broj_Stanovnika + " "
                    + g.Opstina + " " + g.Datum_status + " " + g.Tip_turizma + "\nZnamenitosti:\n" + string.Join("\n", g.Lista_Znamenitosti));

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnLinTacKoord_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.LinijskiObjekat g = s.Load<Entiteti.LinijskiObjekat>(5);


                IQuery q = s.CreateQuery("from Koordinate as k where k.Id_Linijskog_Objekta = 5");

                g.ListaKoordinata = q.List<Koordinate>();

                IQuery q2 = s.CreateQuery("from SadrziTac as s where s.Id_Linijskog_Objekta = 5");

                g.Lista_SadrziTac = q2.List<SadrziTac>();



                foreach (SadrziTac geog in g.Lista_SadrziTac)
                {
                    g.Lista_Tackastih_objekata.Add(geog.Id_Tackastog_Objekta);
                }

                MessageBox.Show(g.Id + " " + g.Naziv + " " + g.Duzina + " "
                    + "\nKoordinate:\n" + string.Join("\n", g.ListaKoordinata)
                    + "\nTackasti:\n" + string.Join("\n", g.Lista_Tackastih_objekata));

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUzvGeogVrh_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Uzvisenje g = s.Load<Entiteti.Uzvisenje>(22);


                IQuery q = s.CreateQuery("from ListaVrhova as lis where lis.Id_Uzvisenja = 22");

                g.Lista_Vrhova = q.List<ListaVrhova>();


                IQuery q2 = s.CreateQuery("from SadrziGeog as s where s.Id_Uzvisenog_Objekta = 22");

                g.Lista_Sadrzi_Geog = q2.List<SadrziGeog>();



                foreach (SadrziGeog geog in g.Lista_Sadrzi_Geog)
                {
                    g.Lista_Geografskih_objekata.Add(geog.Id_Geografskog_Objekta);
                }


                MessageBox.Show(g.Id + " " + g.Naziv + " " + g.Nadmorska_visina + " "
                    + "\nVrhovi:\n" + string.Join("\n", g.Lista_Vrhova)
                    + "\nGeografski objekti:\n" + string.Join("\n", g.Lista_Geografskih_objekata));

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUzvLin_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Uzvisenje g = s.Load<Entiteti.Uzvisenje>(171);


                IQuery q = s.CreateQuery("from SadrziLin as s where s.Id_Povrsinskog_Objekta = 171");

                g.Lista_SadrziLin = q.List<SadrziLin>();



                foreach (SadrziLin geog in g.Lista_SadrziLin)
                {
                    g.Lista_Linijskih_objekata.Add(geog.Id_Linijskog_Objekta);
                }

                MessageBox.Show(g.Id + " " + g.Naziv + " " + g.Nadmorska_visina + " "
                    + "\nLinijski:\n" + string.Join("\n", g.Lista_Linijskih_objekata));

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
