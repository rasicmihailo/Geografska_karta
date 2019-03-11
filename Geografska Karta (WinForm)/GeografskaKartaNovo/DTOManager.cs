using GeografskaKartaNovo.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeografskaKartaNovo
{
    public class DTOManager
    {

        #region metode za tackasti objekat

        public static void AddTackastiObjekatBasic(TackastiObjekatBasic tob)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                TackastiObjekat t = new TackastiObjekat();
                
                t.Naziv = tob.Naziv;
                t.X_tac = tob.X_tac;
                t.Y_tac = tob.Y_tac;
                t.Datum_Osnivanja = tob.Datum_Osnivanja;
                t.Datum_status = tob.Datum_status;
                t.F_naseljeno = tob.F_naseljeno;
                t.Broj_Stanovnika = tob.Broj_Stanovnika;
                t.Tip_naselja = tob.Tip_naselja;
                t.Tip_turizma = tob.Tip_turizma;
                t.Opstina = tob.Opstina;
                t.F_turisticko = tob.F_turisticko;
                
                session.Save(t);
                
                session.Close();

                //dodavanje znamenitosti tek nakon pribavljanja id-ja tackastog objekta

                TackastiObjekatBasic tob1 = DTOManager.GetTackastiObjekatBasic(tob.Naziv);

                t.Id = tob1.Id;

                foreach (Znamenitost z in tob.Lista_Znamenitosti)
                {
                    DTOManager.AddZnamenitost(new ZnamenitostBasic(z.Naziv_Znamenitost, t));
                }


            }
            catch (Exception ec)
            {
                
            }
        }

        public static void AddZnamenitost(ZnamenitostBasic tob)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Znamenitost t = new Znamenitost();

                t.Naziv_Znamenitost = tob.Naziv_Znamenitost;
                t.Id_Naseljenog_Mesta = tob.Id_Naseljenog_Mesta;
                
                session.Save(t);

                session.Close();


            }
            catch (Exception ec)
            {

            }
        }

        public static TackastiObjekatBasic GetTackastiObjekatBasic(int Id)
        {
            
            TackastiObjekatBasic tob = null;
            


            try
            {
                ISession s = DataLayer.GetSession();

                TackastiObjekat to = s.Load<TackastiObjekat>(Id);


                //hibernate je mudar pa zato naredne linije koda jesu ophodne (nisu neophodne, prim. prev.)

                //IQuery q = s.CreateQuery("from SadrziTac as k where k.Id_Tackastog_Objekta = ?");
                //q.SetInt32(0, to.Id);
                //to.Lista_SadrziTac = q.List<SadrziTac>();

                //IQuery q2 = s.CreateQuery("from Znamenitost as z where z.Id_Naseljenog_Mesta = ?");
                //q2.SetInt32(0, to.Id);
                //to.Lista_Znamenitosti = q2.List<Znamenitost>();

                foreach (SadrziTac geog in to.Lista_SadrziTac)
                {
                    to.Lista_Linijskih_objekata.Add(geog.Id_Linijskog_Objekta);
                }


                tob = new TackastiObjekatBasic(to.Id, to.Naziv, to.X_tac, to.Y_tac, to.Datum_Osnivanja, to.F_naseljeno,
                    to.F_turisticko, to.Broj_Stanovnika, to.Tip_naselja, to.Opstina, to.Datum_status,
                    to.Tip_turizma, to.Lista_Znamenitosti, to.Lista_SadrziTac, to.Lista_Linijskih_objekata);


                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return tob;
        }

        public static TackastiObjekatBasic GetTackastiObjekatBasic(string Naziv)
        {

            TackastiObjekatBasic tob = null;



            try
            {
                ISession s = DataLayer.GetSession();

                IQuery qq = s.CreateQuery("select t.Id from TackastiObjekat as t where t.Naziv = ?");
                qq.SetString(0, Naziv);

                int Id = (int) qq.UniqueResult();


                TackastiObjekat to = s.Load<TackastiObjekat>(Id);

                //IQuery q = s.CreateQuery("from SadrziTac as k where k.Id_Tackastog_Objekta = ?");
                //q.SetInt32(0, to.Id);

                //to.Lista_SadrziTac = q.List<SadrziTac>();

                //IQuery q2 = s.CreateQuery("from Znamenitost as z where z.Id_Naseljenog_Mesta = ?");
                //q2.SetInt32(0, to.Id);
                //to.Lista_Znamenitosti = q2.List<Znamenitost>();

                foreach (SadrziTac geog in to.Lista_SadrziTac)
                {
                    to.Lista_Linijskih_objekata.Add(geog.Id_Linijskog_Objekta);
                }


                tob = new TackastiObjekatBasic(to.Id, to.Naziv, to.X_tac, to.Y_tac, to.Datum_Osnivanja, to.F_naseljeno,
                    to.F_turisticko, to.Broj_Stanovnika, to.Tip_naselja, to.Opstina, to.Datum_status,
                    to.Tip_turizma, to.Lista_Znamenitosti, to.Lista_SadrziTac, to.Lista_Linijskih_objekata);


                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return tob;
        }
        
        public static TackastiObjekat GetTackastiObjekat(int Id)
        {

            TackastiObjekat to = null;

            try
            {
                ISession s = DataLayer.GetSession();

                to = s.Load<TackastiObjekat>(Id);

                IQuery q = s.CreateQuery("from SadrziTac as k where k.Id_Tackastog_Objekta = ?");
                q.SetInt32(0, to.Id);

                to.Lista_SadrziTac = q.List<SadrziTac>();

                foreach (SadrziTac geog in to.Lista_SadrziTac)
                {
                    to.Lista_Linijskih_objekata.Add(geog.Id_Linijskog_Objekta);
                }


                


                 s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return to;
        }

        public static List<TackastiObjekatBasic> GetSveTackasteObjekteBasic()
        {
            List<TackastiObjekatBasic> tobList = new List<TackastiObjekatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TackastiObjekat> objekti = from o in s.Query<TackastiObjekat>() select o;

                foreach (TackastiObjekat to in objekti)
                {
                    tobList.Add(new TackastiObjekatBasic(to.Id, to.Naziv, to.X_tac, to.Y_tac, to.Datum_Osnivanja, to.F_naseljeno,
                        to.F_turisticko, to.Broj_Stanovnika, to.Tip_naselja, to.Opstina, to.Datum_status,
                        to.Tip_turizma, to.Lista_Znamenitosti, to.Lista_SadrziTac, to.Lista_Linijskih_objekata));
                }
                

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return tobList;
        }

        public static void UpdateTackastiObjekatBasic(TackastiObjekatBasic tob)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                TackastiObjekat o = s.Load<TackastiObjekat>(tob.Id);

                o.Broj_Stanovnika = tob.Broj_Stanovnika;
                o.Datum_Osnivanja = tob.Datum_Osnivanja;
                o.Datum_status = tob.Datum_status;
                o.F_naseljeno = tob.F_naseljeno;
                o.F_turisticko = tob.F_turisticko;
                o.Naziv = tob.Naziv;
                o.Opstina = tob.Opstina;
                o.Tip_naselja = tob.Tip_naselja;
                o.Tip_turizma = tob.Tip_turizma;
                o.X_tac = tob.X_tac;
                o.Y_tac = tob.Y_tac;
                

                s.Update(o);
                s.Flush();

                s.Close();

                int prov = 0;
                foreach (Znamenitost z in tob.Lista_Znamenitosti)
                {
                    foreach (Znamenitost z1 in o.Lista_Znamenitosti)
                    {
                        if (z.Naziv_Znamenitost.Equals(z1.Naziv_Znamenitost))
                            prov = 1;
                    }
                    if (prov == 0)
                        DTOManager.AddZnamenitost(new ZnamenitostBasic(z.Naziv_Znamenitost, o));
                    else
                        prov = 0;
                }

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void DeleteTackastiObjekatBasic(int id)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                TackastiObjekat o = s.Load<TackastiObjekat>(id);
                s.Delete(o);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            
        }

        public static LinijskiObjekat GetLinijskiObjekat(int Id)
        {

            LinijskiObjekat to = null;

            try
            {
                ISession s = DataLayer.GetSession();

                to = s.Load<LinijskiObjekat>(Id);


                

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return to;
        }

        #endregion
      
        #region metode za povrsinski objekat

        public static List<PovrsinskiObjekatBasic> GetSvePovrsinskeObjekteBasic()
        {
            List<PovrsinskiObjekatBasic> pobList = new List<PovrsinskiObjekatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PovrsinskiObjekat> objekti = from o in s.Query<PovrsinskiObjekat>() select o;

                foreach (PovrsinskiObjekat po in objekti)
                {
                    pobList.Add(new PovrsinskiObjekatBasic(po.Id, po.Naziv, po.Lista_SadrziLin, po.Lista_Linijskih_objekata));
                }


                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pobList;
        }

        public static PovrsinskiObjekatBasic GetPovrsinskiObjekatBasic(int id)
        {


            PovrsinskiObjekatBasic pob = null;



            try
            {
                ISession s = DataLayer.GetSession();
                
                PovrsinskiObjekat po = s.Load<PovrsinskiObjekat>(id);


                //hibernate je mudar pa zato naredne linije koda jesu ophodne (nisu neophodne, prim. prev.)

                //IQuery q = s.CreateQuery("from SadrziLin as k where k.Id_Povrsinskog_Objekta = ?");
                //q.SetInt32(0, po.Id);
                //po.Lista_SadrziLin = q.List<SadrziLin>();


                foreach (SadrziLin geog in po.Lista_SadrziLin)
                {
                    po.Lista_Linijskih_objekata.Add(geog.Id_Linijskog_Objekta);
                }


                pob = new PovrsinskiObjekatBasic(po.Id, po.Naziv, po.Lista_SadrziLin, po.Lista_Linijskih_objekata);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return pob;
        }

        public static PovrsinskiObjekatBasic GetPovrsinskiObjekatBasic(string naziv)
        {


            PovrsinskiObjekatBasic pob = null;



            try
            {
                ISession s = DataLayer.GetSession();

                IQuery qq = s.CreateQuery("select p.Id from PovrsinskiObjekat as p where p.Naziv = ?");
                qq.SetString(0, naziv);

                int id = (int)qq.UniqueResult();


                PovrsinskiObjekat po = s.Load<PovrsinskiObjekat>(id);


                //hibernate je mudar pa zato naredne linije koda jesu ophodne (nisu neophodne, prim. prev.)

                //IQuery q = s.CreateQuery("from SadrziLin as k where k.Id_Povrsinskog_Objekta = ?");
                //q.SetInt32(0, po.Id);
                //po.Lista_SadrziLin = q.List<SadrziLin>();


                foreach (SadrziLin geog in po.Lista_SadrziLin)
                {
                    po.Lista_Linijskih_objekata.Add(geog.Id_Linijskog_Objekta);
                }


                pob = new PovrsinskiObjekatBasic(po.Id, po.Naziv, po.Lista_SadrziLin, po.Lista_Linijskih_objekata);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return pob;
        }

        public static void DeletePovrsinskiObjekatBasic(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PovrsinskiObjekat po = s.Load<PovrsinskiObjekat>(id);
                s.Delete(po);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static List<LinijskiObjekatBasic> GetSveLinijskeObjekteBasic()
        {
            List<LinijskiObjekatBasic> lobList = new List<LinijskiObjekatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<LinijskiObjekat> objekti = from o in s.Query<LinijskiObjekat>() select o;

                foreach (LinijskiObjekat lo in objekti)
                {
                    lobList.Add(new LinijskiObjekatBasic(lo.Id, lo.Naziv, lo.Duzina, lo.Tip_Objekta, lo.Tip_Objekta));
                }


                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lobList;
        }

        public static void AddPovrsinskiObjekatBasic(PovrsinskiObjekatBasic pob)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                PovrsinskiObjekat p = new PovrsinskiObjekat();

                p.Naziv = pob.Naziv;


                session.Save(p);

                session.Close();

                //dodavanje linijskog tek nakon pribavljanja id-ja tackastog objekta

                PovrsinskiObjekatBasic pob1 = DTOManager.GetPovrsinskiObjekatBasic(pob.Naziv);

                p.Id = pob1.Id;

                foreach (LinijskiObjekat l in pob.Lista_Linijskih_objekata)
                {
                    DTOManager.AddSadrziLin(new SadrziLinBasic(p, l));
                }


            }
            catch (Exception ec)
            {

            }
        }

        public static void AddSadrziLin(SadrziLinBasic slb)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                SadrziLin s = new SadrziLin();

                s.Id_Povrsinskog_Objekta = slb.Id_Povrsinskog_Objekta;
                s.Id_Linijskog_Objekta = slb.Id_Linijskog_Objekta;

                session.Save(s);

                session.Close();


            }
            catch (Exception ec)
            {

            }
        }

        public static void UpdatePovrsinskiObjekatBasic(PovrsinskiObjekatBasic pob)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PovrsinskiObjekat p = s.Load<PovrsinskiObjekat>(pob.Id);

                p.Naziv = pob.Naziv;
                

                s.Update(p);
                s.Flush();

                s.Close();


                int prov = 0;
                foreach (SadrziLin l in pob.Lista_SadrziLin)
                {
                    foreach (SadrziLin l1 in p.Lista_SadrziLin)
                    {
                        if (l.Id_Linijskog_Objekta.Id == l1.Id_Linijskog_Objekta.Id)
                            prov = 1;
                    }
                    if (prov == 0)
                        DTOManager.AddSadrziLin(new SadrziLinBasic(p, l.Id_Linijskog_Objekta));
                    else
                        prov = 0;
                }

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion

        #region metode za vodnu povrsinu

        public static List<VodnaPovrsinaBasic> GetSveVodnePovrsine()
        {
            List<VodnaPovrsinaBasic> vpbList = new List<VodnaPovrsinaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VodnaPovrsina> objekti = from o in s.Query<VodnaPovrsina>() select o;

                foreach (VodnaPovrsina vp in objekti)
                {
                    vpbList.Add(new VodnaPovrsinaBasic(vp.Id, vp.Naziv, vp.Tip_Vode));
                }


                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return vpbList;
        }

        public static VodnaPovrsinaBasic GetVodnaPovrsinaBasic(int id)
        {
            VodnaPovrsinaBasic vpb = null;

            
            try
            {
                ISession s = DataLayer.GetSession();

                VodnaPovrsina vp = s.Load<VodnaPovrsina>(id);

                vpb = new VodnaPovrsinaBasic(vp.Id, vp.Naziv, vp.Tip_Vode);


                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }


            return vpb;

        }

        public static void DeleteVodnaPovrsinaBasic(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VodnaPovrsina o = s.Load<VodnaPovrsina>(id);

                s.Delete(o);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void UpdateVodnaPovrsinaBasic(VodnaPovrsinaBasic vpb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VodnaPovrsina vp = s.Load<VodnaPovrsina>(vpb.Id);

                vp.Naziv = vpb.Naziv;
                vp.Tip_Vode = vpb.Tip_Vode;

                s.Update(vp);

                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {

            }
        }

        public static void AddVodnaPovrsinaBasic(VodnaPovrsinaBasic vpb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VodnaPovrsina vp = new VodnaPovrsina();

                vp.Naziv = vpb.Naziv;
                vp.Tip_Vode = vpb.Tip_Vode;

                s.Save(vp);

                s.Close();

            }
            catch(Exception ec)
            {

            }
        }

        #endregion

        #region Uzvisenje
        public static List<UzvisenjeBasic> vratiSvaUzvisenja()
        {
            List<UzvisenjeBasic> lista = new List<UzvisenjeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Uzvisenje> u = from o in s.Query<Uzvisenje>()
                                           select o;

                foreach (Uzvisenje e in u)
                {
                    lista.Add(new UzvisenjeBasic(e.Id, e.Naziv, e.Nadmorska_visina));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return lista;
        }
        public static void dodajNovoUzvisenje(UzvisenjeBasic u)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                Uzvisenje uz = new Uzvisenje();

                uz.Naziv = u.naziv;
                uz.Nadmorska_visina = u.Nadmorska_visina;

                s.Save(uz);

                s.Flush();
                s.Close();


                ISession s1 = DataLayer.GetSession();
                IQuery q = s1.CreateQuery("select u.Id from Uzvisenje as u where u.Naziv = ?");
                q.SetString(0, u.naziv);

                int id = (int)q.UniqueResult();

                Uzvisenje izBaze = s1.Load<Uzvisenje>(id);


                foreach (ListaVrhova l in u.Lista_Vrhova)
                {
                    ListaVrhova l1 = new ListaVrhova();
                    l1.Ime = l.Ime;
                    l1.Nadmorska_visina = l.Nadmorska_visina;
                    l1.Id_Uzvisenja = izBaze;
                    izBaze.Lista_Vrhova.Add(l1);
                    s1.Save(l1);
                    s1.Flush();
                }

                foreach (GeografskiObjekat g in u.Lista_Geografskih_objekata)
                {
                    SadrziGeog gs = new SadrziGeog();
                    GeografskiObjekat gn = new GeografskiObjekat();
                    gn.Id = g.Id;
                    gn.Naziv = g.Naziv;
                    gn.Lista_Uzvisenja.Add(izBaze);
                    gn.Lista_Sadrzi_Geog.Add(gs);

                    izBaze.Lista_Geografskih_objekata.Add(gn);
                    izBaze.Lista_Sadrzi_Geog.Add(gs);

                    gs.Id_Geografskog_Objekta = gn;
                    gs.Id_Uzvisenog_Objekta = izBaze;

                    gs.Lista_Geografski_Objekat.Add(gn);
                    gs.Lista_Uzvisenje_Objekat.Add(izBaze);

                    s1.Save(gs);
                    s1.Flush();
                }

                s1.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static UzvisenjeBasic vratiUzvisenje(int id)
        {
            UzvisenjeBasic basic = new UzvisenjeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Uzvisenje u = s.Load<Uzvisenje>(id);

                basic = new UzvisenjeBasic(u.Id, u.Naziv, u.Nadmorska_visina);

                basic.Lista_SadrziGeog = u.Lista_SadrziGeog;
                basic.Lista_Vrhova = u.Lista_Vrhova;

                //pribavlja sve geografske objekte koji postoje u bazi
                IEnumerable<GeografskiObjekat> lista = from g in s.Query<GeografskiObjekat>()
                                                       select g;
                foreach (GeografskiObjekat g in lista)
                {
                    basic.listaSvihGeografskih.Add(g);
                }
                //pribavlja sve vrhove iz baze
                IEnumerable<ListaVrhova> vrhovi = from v in s.Query<ListaVrhova>()
                                                  select v;
                foreach (ListaVrhova v in vrhovi)
                {
                    basic.listaSvihVrhova.Add(v);
                }

                //samo one koje on sadrzi geografske
                foreach (SadrziGeog g in u.Lista_SadrziGeog)
                {
                    basic.Lista_Geografskih_objekata.Add(g.Id_Geografskog_Objekta);
                }


                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return basic;
        }
        public static void obrisiUzvisenje(UzvisenjeBasic u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Uzvisenje u1 = s.Load<Uzvisenje>(u.id);

                s.Delete(u1);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void azurirajUzvisenje(UzvisenjeBasic u)
        {
            SadrziGeog gs = new SadrziGeog();
            try
            {
                ISession s = DataLayer.GetSession();
                Uzvisenje uzvisenjeBaza = s.Load<Uzvisenje>(u.id);

                uzvisenjeBaza.Nadmorska_visina = u.Nadmorska_visina;
                uzvisenjeBaza.Naziv = u.naziv;

                foreach (SadrziGeog sg in uzvisenjeBaza.Lista_SadrziGeog)
                {
                    uzvisenjeBaza.Lista_Geografskih_objekata.Add(sg.Id_Geografskog_Objekta);
                }

                s.Update(uzvisenjeBaza);
                s.Flush();

                bool istiVrhovi = false;

                foreach (ListaVrhova l in u.Lista_Vrhova)
                {
                    if (l.Id_Uzvisenja == null)
                    {
                        l.Id_Uzvisenja = uzvisenjeBaza;
                        s.Update(l);
                        s.Flush();
                    }

                    //provera da li ima istih vrhova
                    foreach (ListaVrhova v in uzvisenjeBaza.Lista_Vrhova)
                    {
                        if (l.Id_Uzvisenja == null)
                            istiVrhovi = false;
                        else if (l.Id_Uzvisenja.Id == v.Id_Uzvisenja.Id)
                        {
                            istiVrhovi = true;
                        }
                    }
                    if (!istiVrhovi)
                    {
                        ListaVrhova l1 = new ListaVrhova();
                        l1.Ime = l.Ime;
                        l1.Nadmorska_visina = l.Nadmorska_visina;
                        l1.Id_Uzvisenja = uzvisenjeBaza;
                        uzvisenjeBaza.Lista_Vrhova.Add(l1);
                        s.Save(l1);
                    }
                    istiVrhovi = false;
                }

                bool istiGeog = false;
                foreach (GeografskiObjekat g in u.Lista_Geografskih_objekata)
                {
                    //provera da li ima istih objekata
                    foreach (GeografskiObjekat v in uzvisenjeBaza.Lista_Geografskih_objekata)
                    {
                        if (g.Id == v.Id || uzvisenjeBaza.Lista_Geografskih_objekata.Count == 0)
                        {
                            istiGeog = true;
                        }
                    }
                    if (!istiGeog)
                    {
                        GeografskiObjekat gn = new GeografskiObjekat();
                        gn.Id = g.Id;
                        gn.Naziv = g.Naziv;
                        gn.Lista_Uzvisenja.Add(uzvisenjeBaza);
                        gn.Lista_Sadrzi_Geog.Add(gs);

                        uzvisenjeBaza.Lista_Geografskih_objekata.Add(gn);
                        uzvisenjeBaza.Lista_Sadrzi_Geog.Add(gs);

                        gs.Id_Geografskog_Objekta = gn;
                        gs.Id_Uzvisenog_Objekta = uzvisenjeBaza;

                        gs.Lista_Geografski_Objekat.Add(gn);
                        gs.Lista_Uzvisenje_Objekat.Add(uzvisenjeBaza);

                        s.Save(gs);
                    }
                    istiGeog = false;
                }
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static ListaVrhovaBasic vratiVrh(int id)
        {
            ListaVrhovaBasic vb = new ListaVrhovaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ListaVrhova l = s.Load<ListaVrhova>(id);

                vb = new ListaVrhovaBasic(l.Id, l.Ime, l.Nadmorska_visina);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return vb;
        }
        public static List<ListaVrhovaBasic> vratiSveVrhove()
        {
            List<ListaVrhovaBasic> lista = new List<ListaVrhovaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ListaVrhova> u = from o in s.Query<ListaVrhova>()
                                             select o;

                foreach (ListaVrhova e in u)
                {
                    lista.Add(new ListaVrhovaBasic(e.Id, e.Ime, e.Nadmorska_visina));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return lista;
        }
        public static void upisiVrh(String ime, double visina, UzvisenjeBasic u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ListaVrhova l = new ListaVrhova();
                l.Ime = ime;
                l.Nadmorska_visina = visina;
                //l.Id_Uzvisenja = uz;

                s.Save(l);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static ListaVrhovaBasic vratiVrh(String ime)
        {
            ListaVrhovaBasic vb = new ListaVrhovaBasic();
            try
            {
                ISession s1 = DataLayer.GetSession();
                IQuery q = s1.CreateQuery("select u.Id from ListaVrhova as u where u.Ime = ?");
                q.SetString(0, ime);

                int id = (int)q.UniqueResult();

                ListaVrhova izBaze = s1.Load<ListaVrhova>(id);

                vb = new ListaVrhovaBasic(izBaze.Id, izBaze.Ime, izBaze.Nadmorska_visina);

                s1.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return vb;

        }

        #endregion

        #region LinijskiObjekti

        public static List<LinijskiObjekatBasic> vratiSveLinijskeObjekte()
        {
            List<LinijskiObjekatBasic> lista = new List<LinijskiObjekatBasic>();

            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<LinijskiObjekat> objekti = from l in session.Query<LinijskiObjekat>()
                                                       select l;

                foreach (LinijskiObjekat li in objekti)
                {
                    lista.Add(new LinijskiObjekatBasic(li.Duzina, li.Tip_Objekta, li.Opis_Objekta, li.Naziv, li.Id));
                }

                session.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return lista;
        }
        public static LinijskiObjekatBasic vratiLinijskiObjekat(int id)
        {
            LinijskiObjekatBasic lb = new LinijskiObjekatBasic();

            try
            {
                ISession session = DataLayer.GetSession();

                LinijskiObjekat li = session.Load<LinijskiObjekat>(id);
                lb = new LinijskiObjekatBasic(li.Duzina, li.Tip_Objekta, li.Opis_Objekta, li.Naziv, li.Id);

                IQuery q1 = session.CreateQuery("from SadrziTac as s where s.Id_Linijskog_Objekta = " + id);
                li.Lista_SadrziTac = q1.List<SadrziTac>(); //vraca sve SadrziTac objekte u kojima se nalazi trazeni linijski objekat sa tackastim

                IQuery q = session.CreateQuery("from Koordinate as k where k.Id_Linijskog_Objekta = " + id);
                li.ListaKoordinata = q.List<Koordinate>();

                IEnumerable<TackastiObjekat> lista = from o in session.Query<TackastiObjekat>()
                                                     select o;
                IQuery q4 = session.CreateQuery("from SadrziLin as s where s.Id_Linijskog_Objekta = " + id);
                li.Lista_SadrziLin = q4.List<SadrziLin>();

                foreach (SadrziLin s in li.Lista_SadrziLin)
                {
                    li.Lista_Povrsinskih_objekata.Add(s.Id_Povrsinskog_Objekta);
                }

                foreach (PovrsinskiObjekat p in li.Lista_Povrsinskih_objekata)
                {
                    lb.Lista_Povrsinskih_objekata.Add(p);
                }

                foreach (TackastiObjekat t in lista)
                {
                    lb.Lista_Svih_Tackastih_objekata.Add(t);
                }

                foreach (Koordinate k in li.ListaKoordinata)
                {
                    lb.ListaKoordinata.Add(k);
                }

                foreach (SadrziTac s in li.Lista_SadrziTac)
                {
                    li.Lista_Tackastih_objekata.Add(s.Id_Tackastog_Objekta);
                }

                foreach (TackastiObjekat t in li.Lista_Tackastih_objekata)
                {
                    lb.Lista_Tackastih_objekata.Add(t);
                }

                // session.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return lb;

        }
        public static LinijskiObjekatBasic vratilinijskiObjekat(String str)
        {
            LinijskiObjekatBasic lb = new LinijskiObjekatBasic();

            try
            {
                ISession session = DataLayer.GetSession();
             
                IQuery q2 = session.CreateQuery("select u.Id from LinijskiObjekat as u where u.Naziv = ?");
                q2.SetString(0, str);

                int id = (int)q2.UniqueResult();

                LinijskiObjekat li = session.Load<LinijskiObjekat>(id);
                lb = new LinijskiObjekatBasic(li.Duzina, li.Tip_Objekta, li.Opis_Objekta, li.Naziv, li.Id);

                IQuery q1 = session.CreateQuery("from SadrziTac as s where s.Id_Linijskog_Objekta = " + id);
                li.Lista_SadrziTac = q1.List<SadrziTac>(); //vraca sve SadrziTac objekte u kojima se nalazi trazeni linijski objekat sa tackastim

                IQuery q = session.CreateQuery("from Koordinate as k where k.Id_Linijskog_Objekta = " + id);
                li.ListaKoordinata = q.List<Koordinate>();

                IEnumerable<TackastiObjekat> lista = from o in session.Query<TackastiObjekat>()
                                                     select o;
                IQuery q4 = session.CreateQuery("from SadrziLin as s where s.Id_Linijskog_Objekta = " + id);
                li.Lista_SadrziLin = q4.List<SadrziLin>();

                foreach (SadrziLin s in li.Lista_SadrziLin)
                {
                    li.Lista_Povrsinskih_objekata.Add(s.Id_Povrsinskog_Objekta);
                }

                foreach (PovrsinskiObjekat p in li.Lista_Povrsinskih_objekata)
                {
                    lb.Lista_Povrsinskih_objekata.Add(p);
                }

                foreach (TackastiObjekat t in lista)
                {
                    lb.Lista_Svih_Tackastih_objekata.Add(t);
                }

                foreach (Koordinate k in li.ListaKoordinata)
                {
                    lb.ListaKoordinata.Add(k);
                }

                foreach (SadrziTac s in li.Lista_SadrziTac)
                {
                    li.Lista_Tackastih_objekata.Add(s.Id_Tackastog_Objekta);
                }

                foreach (TackastiObjekat t in li.Lista_Tackastih_objekata)
                {
                    lb.Lista_Tackastih_objekata.Add(t);
                }

                // session.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return lb;

        }
        public static LinijskiObjekatBasic azurirajLinijskiObjekat(LinijskiObjekatBasic l)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Entiteti.LinijskiObjekat prvi = session.Load<LinijskiObjekat>(l.Id);

                prvi.Duzina = l.Duzina;
                prvi.Naziv = l.Naziv;
                prvi.Opis_Objekta = l.Opis_Objekta;
                prvi.Tip_Objekta = l.Tip_Objekta;

                foreach (SadrziTac st in prvi.Lista_SadrziTac)
                {
                    prvi.Lista_Tackastih_objekata.Add(st.Id_Tackastog_Objekta);
                }

                session.Update(prvi);

                session.Flush();

                bool isteKoor = false;
                foreach (Koordinate k in l.ListaKoordinata)
                {
                    if (k.Id_Linijskog_Objekta == null)
                    {
                        k.Id_Linijskog_Objekta = prvi;
                        session.Update(k);
                        session.Flush();
                    }
                    foreach (Koordinate k1 in prvi.ListaKoordinata)
                    {
                        if (k1.Id_Linijskog_Objekta.Id == k.Id_Linijskog_Objekta.Id)
                        {
                            isteKoor = true;
                        }
                        if (!isteKoor)
                        {
                            Koordinate kn = new Koordinate();
                            kn.X_lin = k.X_lin;
                            kn.Y_lin = k.Y_lin;
                            kn.Id_Linijskog_Objekta = prvi;
                            prvi.ListaKoordinata.Add(kn);

                            session.Save(kn);
                            session.Flush();
                        }
                        isteKoor = false;
                    }
                }

                bool istiTac = false;

                foreach (TackastiObjekat t in l.Lista_Tackastih_objekata)
                {
                    foreach (TackastiObjekat t1 in prvi.Lista_Tackastih_objekata)
                    {
                        if (t.Id == t1.Id || prvi.Lista_Tackastih_objekata.Count == 0)
                        {
                            istiTac = true;
                        }
                    }
                    if (!istiTac)
                    {
                        SadrziTac st = new SadrziTac();
                        TackastiObjekat tn = new TackastiObjekat();
                        tn.Id = t.Id;
                        tn.Naziv = t.Naziv;
                        tn.Opstina = t.Opstina;
                        tn.Tip_naselja = t.Tip_naselja;
                        tn.Tip_turizma = t.Tip_turizma;
                        tn.X_tac = t.X_tac;
                        tn.Y_tac = t.Y_tac;
                        tn.F_naseljeno = t.F_naseljeno;
                        tn.F_turisticko = t.F_turisticko;
                        tn.Datum_status = t.Datum_status;
                        tn.Datum_Osnivanja = t.Datum_Osnivanja;
                        tn.Broj_Stanovnika = t.Broj_Stanovnika;
                        tn.Lista_Znamenitosti = t.Lista_Znamenitosti;

                        prvi.Lista_Tackastih_objekata.Add(tn);

                        prvi.Lista_Tackastih_objekata.Add(tn);
                        tn.Lista_Linijskih_objekata.Add(prvi);

                        prvi.Lista_SadrziTac.Add(st);
                        tn.Lista_SadrziTac.Add(st);
                        //reference
                        st.Id_Linijskog_Objekta = prvi;
                        st.Id_Tackastog_Objekta = tn;
                        //dodavanje u listu
                        st.Lista_Linijski_Objekat.Add(prvi);
                        st.Lista_Tackasti_Objekat.Add(tn);

                        session.Save(st);
                        session.Flush();
                    }
                    istiTac = false;
                }


                session.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return l;
        }
        public static void dodajLinijskiObjekat(LinijskiObjekatBasic l)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Entiteti.LinijskiObjekat prvi = new Entiteti.LinijskiObjekat();

                prvi.Naziv = l.Naziv;
                prvi.Duzina = l.Duzina;
                prvi.Opis_Objekta = l.Opis_Objekta;
                prvi.Tip_Objekta = l.Tip_Objekta;


                session.Save(prvi);

                session.Flush();
                session.Close();

                ISession s1 = DataLayer.GetSession();
                IQuery q = s1.CreateQuery("select u.Id from LinijskiObjekat as u where u.Naziv = ?");
                q.SetString(0, l.Naziv);

                int id = (int)q.UniqueResult();

                LinijskiObjekat lin = s1.Load<LinijskiObjekat>(id);


                foreach (Koordinate k in l.ListaKoordinata)
                {
                    Koordinate kn = new Koordinate();
                    kn.X_lin = k.X_lin;
                    kn.Y_lin = k.Y_lin;
                    kn.Id_Linijskog_Objekta = lin;
                    lin.ListaKoordinata.Add(kn);

                    s1.Save(kn);
                    s1.Flush();
                }


                foreach (TackastiObjekat t in l.Lista_Tackastih_objekata)
                {
                    SadrziTac st = new SadrziTac();
                    TackastiObjekat tn = new TackastiObjekat();
                    tn.Id = t.Id;
                    tn.Naziv = t.Naziv;
                    tn.Opstina = t.Opstina;
                    tn.Tip_naselja = t.Tip_naselja;
                    tn.Tip_turizma = t.Tip_turizma;
                    tn.X_tac = t.X_tac;
                    tn.Y_tac = t.Y_tac;
                    tn.F_naseljeno = t.F_naseljeno;
                    tn.F_turisticko = t.F_turisticko;
                    tn.Datum_status = t.Datum_status;
                    tn.Datum_Osnivanja = t.Datum_Osnivanja;
                    tn.Broj_Stanovnika = t.Broj_Stanovnika;
                    tn.Lista_Znamenitosti = t.Lista_Znamenitosti;

                    lin.Lista_Tackastih_objekata.Add(tn);

                    lin.Lista_Tackastih_objekata.Add(tn);
                    tn.Lista_Linijskih_objekata.Add(lin);

                    lin.Lista_SadrziTac.Add(st);
                    tn.Lista_SadrziTac.Add(st);
                    //reference
                    st.Id_Linijskog_Objekta = lin;
                    st.Id_Tackastog_Objekta = tn;
                    //dodavanje u listu
                    st.Lista_Linijski_Objekat.Add(lin);
                    st.Lista_Tackasti_Objekat.Add(tn);

                    s1.Save(st);
                    s1.Flush();
                }
                s1.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static TackastiObjekatBasic vratiSamoTackastiObjekat(int id)
        {
            TackastiObjekatBasic tb = new TackastiObjekatBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                TackastiObjekat t = s.Load<TackastiObjekat>(id);

                tb = new TackastiObjekatBasic(t.Id, t.Naziv, t.Opstina);

                tb.Datum_Osnivanja = t.Datum_Osnivanja;
                tb.Datum_status = t.Datum_status;
                tb.F_naseljeno = t.F_naseljeno;
                tb.F_turisticko = t.F_turisticko;
                tb.Broj_Stanovnika = t.Broj_Stanovnika;
                tb.Tip_naselja = t.Tip_naselja;
                tb.Tip_turizma = t.Tip_turizma;
                tb.X_tac = t.X_tac;
                tb.Y_tac = t.Y_tac;

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return tb;
        }
        public static List<PovrsinskiObjekatBasic> vratiPovrsinske()
        {
            List<PovrsinskiObjekatBasic> lista = new List<PovrsinskiObjekatBasic>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<PovrsinskiObjekat> pov = from p in session.Query<PovrsinskiObjekat>()
                                                     select p;

                foreach (PovrsinskiObjekat p in pov)
                {
                    lista.Add(new PovrsinskiObjekatBasic(p.Id, p.Naziv));
                }

                session.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Pojavila se greska: " + ec);
            }

            return lista;
        }
        public static List<TackastiObjekatBasic> vratiTackaste()
        {
            List<TackastiObjekatBasic> lista = new List<TackastiObjekatBasic>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<TackastiObjekat> tac = from t in session.Query<TackastiObjekat>()
                                                   select t;

                foreach (TackastiObjekat t in tac)
                {
                    lista.Add(new TackastiObjekatBasic(t.Id, t.Naziv, t.Opstina));
                }


                session.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Pojavila se greska: " + ec);
            }

            return lista;

        }
        public static void obrisiLinijski(LinijskiObjekatBasic l)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                LinijskiObjekat l1 = s.Load<LinijskiObjekat>(l.Id);

                s.Delete(l1);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }
        public static void dodajKoordinatu(KoordinateBasic k)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Koordinate k1 = new Koordinate();
                k1.X_lin = k.X_lin;
                k1.Y_lin = k.Y_lin;

                session.Save(k1);
                session.Flush();
                session.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static KoordinateBasic vratiKoordinate(double x, double y)
        {
            KoordinateBasic k = new KoordinateBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select k.id from Koordinate as k where k.X_lin=? and k.Y_lin=?");
                q.SetDouble(0, x);
                q.SetDouble(1, y);

                int id = (int)q.UniqueResult();

                Koordinate kb = s.Load<Koordinate>(id);

                k = new KoordinateBasic(kb.Id, kb.X_lin, kb.Y_lin);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return k;
        }

        #endregion

        #region GeografskiObjekti

        public static GeografskiObjekatBasic vratiGeografskiObjekat(String naziv)
        {
            GeografskiObjekatBasic geo = new GeografskiObjekatBasic();
            try
            {
                ISession s1 = DataLayer.GetSession();
                IQuery q = s1.CreateQuery("select u.Id from GeografskiObjekat as u where u.Naziv = ?");
                q.SetString(0, naziv);
                int id = (int)q.UniqueResult();

                GeografskiObjekat g = s1.Load<GeografskiObjekat>(id);

                geo.Naziv = g.Naziv;
                geo.Id = g.Id;

                s1.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return geo;
        }
        public static List<GeografskiObjekatBasic> VratiGeografskeObjekte()
        {

            List<GeografskiObjekatBasic> lista_basic_geog_obj = new List<GeografskiObjekatBasic>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<GeografskiObjekat> geog_obj = from o in session.Query<GeografskiObjekat>()
                                                          select o;

                foreach (GeografskiObjekat g in geog_obj)
                {
                    lista_basic_geog_obj.Add(new GeografskiObjekatBasic(g.Id, g.Naziv, g.Lista_Uzvisenja, g.Lista_Sadrzi_Geog));
                }

                session.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine("Pojavila se greska: " + ec);
            }

            return lista_basic_geog_obj;
        }
        public static GeografskiObjekatBasic vratiGeografskiObjekat(int id)
        {
            GeografskiObjekatBasic geog = new GeografskiObjekatBasic();
            try
            {
                ISession session = DataLayer.GetSession();

                GeografskiObjekat g = session.Load<GeografskiObjekat>(id);

                IQuery q2 = session.CreateQuery("from SadrziGeog as s where s.Id_Geografskog_Objekta =" + id);

                g.Lista_Sadrzi_Geog = q2.List<SadrziGeog>();

                foreach (SadrziGeog sad in g.Lista_Sadrzi_Geog)
                {
                    g.Lista_Uzvisenja.Add(sad.Id_Uzvisenog_Objekta);
                }

                geog = new GeografskiObjekatBasic(g.Id, g.Naziv);
                geog.Lista_Basic_Sadrzi_Geog = g.Lista_Sadrzi_Geog;
                geog.Lista_Basic_Uzvisenja = g.Lista_Uzvisenja;


                // session.Save(g);
                // session.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine("Pojavila se greska: " + ec);
            }

            return geog;
        }
        public static GeografskiObjekatBasic azurirajGeogObj(GeografskiObjekatBasic obj)
        {
            try
            {
                ISession session = DataLayer.GetSession();
                GeografskiObjekat g = session.Load<GeografskiObjekat>(obj.Id);

                g.Naziv = obj.Naziv;

                session.Update(g);

                session.Flush();
                session.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Pojavila se greska: " + ex);
            }
            return obj;
        }
        public static void dodajGeog(GeografskiObjekatBasic g)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Entiteti.GeografskiObjekat prvi = new Entiteti.GeografskiObjekat();

                prvi.Naziv = g.Naziv;

                session.Save(prvi);

                session.Flush();
                session.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        public static void obrisiGeografskiObjekat(GeografskiObjekatBasic g)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Entiteti.GeografskiObjekat prvi = session.Load<GeografskiObjekat>(g.Id);


                session.Delete(prvi);


                session.Flush();
                session.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

    }
}