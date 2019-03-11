using GeografskaKartaNovo.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using GeografskaKartaNovo.DTOs;

namespace GeografskaKartaNovo
{
    public class DataProvider
    {

        #region Znamenitost

        public IEnumerable<Znamenitost> GetZnamenitosti()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Znamenitost> znamenitosti = s.Query<Znamenitost>()
                                                .Select(p => p);

            //s.Close();

            return znamenitosti;
        }

        public Znamenitost GetZnamenitost(int id)
        {
            ISession s = DataLayer.GetSession();

            Znamenitost znam = s.Query<Znamenitost>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            s.Close();

            return znam;
        }

        public ZnamenitostView GetZnamenitostView(int id)
        {
            Znamenitost znam = GetZnamenitost(id);

            if (znam == null) return new ZnamenitostView();

            return new ZnamenitostView(znam);
        }

        public int AddZnamenitost(Znamenitost z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(z);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateZnamenitost(int id, Znamenitost z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Znamenitost znam = GetZnamenitost(id);

                znam.Naziv_Znamenitost = z.Naziv_Znamenitost;
                
                s.Update(znam);
                s.Flush();

                s.Close();

                return 1;
            }
            catch(Exception ec)
            {
                return -1;
            }
        }

        public int RemoveZnamenitost(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Znamenitost znam = s.Query<Znamenitost>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(znam);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion
        
        #region TackastiObjekat

        public IEnumerable<TackastiObjekat> GetTackaste()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<TackastiObjekat> tackastiObjekti = s.Query<TackastiObjekat>()
                                                        .Select(p => p);

            //s.Close();

            //IList<TackastiObjekatView> tackastiObjektiView = new List<TackastiObjekatView>();

            //foreach (TackastiObjekat tac in tackastiObjekti)
            //    tackastiObjektiView.Add(new TackastiObjekatView(tac));

            return tackastiObjekti;
        }

        public TackastiObjekat GetTackastiObjekat(int id)
        {
            ISession s = DataLayer.GetSession();

            TackastiObjekat tac = s.Query<TackastiObjekat>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            s.Close();

            return tac;

        }

        public TackastiObjekatView GetTackstiObjekatView(int id)
        {
            TackastiObjekat tac = GetTackastiObjekat(id);

            if (tac == null) return new TackastiObjekatView();

            return new TackastiObjekatView(tac);
        }

        public int AddTackasti(TackastiObjekat t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(t);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateTacksati(int id, TackastiObjekat t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TackastiObjekat tac = GetTackastiObjekat(id);

                tac.Naziv = t.Naziv;
                tac.X_tac = t.X_tac;
                tac.Y_tac = t.Y_tac;
                tac.Datum_Osnivanja = t.Datum_Osnivanja;
                tac.F_naseljeno = t.F_naseljeno;
                tac.F_turisticko = t.F_turisticko;
                tac.Broj_Stanovnika = t.Broj_Stanovnika;
                tac.Tip_naselja = t.Tip_naselja;
                tac.Opstina = t.Opstina;
                tac.Datum_status = t.Datum_status;
                tac.Tip_turizma = t.Tip_turizma;

                s.Update(tac);
                s.Flush();

                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveTackasti(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TackastiObjekat tac = s.Query<TackastiObjekat>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(tac);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion
        
        #region PovrsinskiObjekat

        public IEnumerable<PovrsinskiObjekat> GetPovrsinske()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<PovrsinskiObjekat> povrsinskiObjekti = s.Query<PovrsinskiObjekat>()
                                                        .Select(p => p);

            //s.Close();
            
            return povrsinskiObjekti;
        }

        public PovrsinskiObjekat GetPovrsinskiObjekat(int id)
        {
            ISession s = DataLayer.GetSession();

            PovrsinskiObjekat pov = s.Query<PovrsinskiObjekat>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            s.Close();

            return pov;

        }

        public PovrsinskiObjekatView GetPovrsinskiObjekatView(int id)
        {
            PovrsinskiObjekat pov = GetPovrsinskiObjekat(id);

            if (pov == null) return new PovrsinskiObjekatView();

            return new PovrsinskiObjekatView(pov);
        }

        public int AddPovrsinski(PovrsinskiObjekat p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(p);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdatePovrsinski(int id, PovrsinskiObjekat p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PovrsinskiObjekat pov = GetPovrsinskiObjekat(id);

                pov.Naziv = p.Naziv;
                
                s.Update(pov);
                s.Flush();

                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemovePovrsinski(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PovrsinskiObjekat pov = s.Query<PovrsinskiObjekat>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(pov);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion

        #region VodnaPovrsina

        public IEnumerable<VodnaPovrsina> GetVodne()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<VodnaPovrsina> vodnePovrsine = s.Query<VodnaPovrsina>()
                                                        .Select(p => p);

            //s.Close();

            return vodnePovrsine;
        }

        public VodnaPovrsina GetVodnaPovrsina(int id)
        {
            ISession s = DataLayer.GetSession();

            VodnaPovrsina vod = s.Query<VodnaPovrsina>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            s.Close();

            return vod;

        }

        public VodnaPovrsinaView GetVodnaPovrsinaView(int id)
        {
            VodnaPovrsina vod = GetVodnaPovrsina(id);

            if (vod == null) return new VodnaPovrsinaView();

            return new VodnaPovrsinaView(vod);
        }

        public int AddVodna(VodnaPovrsina v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(v);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateVodna(int id, VodnaPovrsina v)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VodnaPovrsina vod = GetVodnaPovrsina(id);

                vod.Naziv = v.Naziv;
                vod.Tip_Vode = v.Tip_Vode;

                s.Update(vod);
                s.Flush();

                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int RemoveVodna(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VodnaPovrsina vod = s.Query<VodnaPovrsina>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(vod);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion





        #region GeografskiObjekat

        public IEnumerable<GeografskiObjekat> vratiGeografske()
        {

            ISession s = DataLayer.GetSession();

            IEnumerable<GeografskiObjekat> g = s.Query<GeografskiObjekat>()
                                                .Select(p => p);

            //s.Close();

            return g;
        }
        public GeografskiObjekatView vratiGeografskiObjekat(int id)
        {
            ISession s = DataLayer.GetSession();

            GeografskiObjekat g = s.Query<GeografskiObjekat>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            GeografskiObjekatView gw = new GeografskiObjekatView();

            gw.Naziv = g.Naziv;
            gw.Id = g.Id;

            s.Close();

            return gw;
        }
        public int dodajGeografski(GeografskiObjekat g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(g);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int obrisiGeografski(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GeografskiObjekat g = s.Query<GeografskiObjekat>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(g);

                s.Flush();
                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int azurirajGeografski(int id, GeografskiObjekat g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GeografskiObjekat go = s.Load<GeografskiObjekat>(id);

                go.Naziv = g.Naziv;

                s.Update(go);
                s.Flush();

                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion

        #region LinijskiObjekat
        public IEnumerable<LinijskiObjekat> vratiLinijske()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<LinijskiObjekat> g = s.Query<LinijskiObjekat>()
                                                .Select(p => p);

            //s.Close();

            return g;

        }
        public LinijskiObjekatView vratiLinijskiObjekat(int id)
        {
            ISession s = DataLayer.GetSession();

            LinijskiObjekat l = s.Query<LinijskiObjekat>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            LinijskiObjekatView lin = new LinijskiObjekatView();

            lin.Id = l.Id;
            lin.Naziv = l.Naziv;
            lin.Opis_Objekta = l.Opis_Objekta;
            lin.Tip_Objekta = l.Tip_Objekta;
            lin.Duzina = l.Duzina;

            s.Close();

            return lin;
        }
        public int dodajLinijski(LinijskiObjekat l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(l);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int obrisiLinijski(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                LinijskiObjekat l = s.Query<LinijskiObjekat>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(l);

                s.Flush();
                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int azurirajLinijski(int id, LinijskiObjekat l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                LinijskiObjekat lo = s.Load<LinijskiObjekat>(id);

                lo.Naziv = l.Naziv;
                lo.Opis_Objekta = l.Opis_Objekta;
                lo.Tip_Objekta = l.Tip_Objekta;
                lo.Duzina = l.Duzina;


                s.Update(lo);
                s.Flush();

                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion

        #region Koordinate

        public IEnumerable<Koordinate> vratiSveKoordinate()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Koordinate> k = s.Query<Koordinate>()
                                                .Select(p => p);

            //s.Close();

            return k;
        }
        public KoordinateView vratiKoordinatu(int id)
        {
            ISession s = DataLayer.GetSession();

            Koordinate k = s.Query<Koordinate>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            KoordinateView kw = new KoordinateView();

            kw.Id = k.Id;
            kw.X_lin = k.X_lin;
            kw.Y_lin = k.Y_lin;

            s.Close();

            return kw;
        }
        public int dodajKoordinatu(Koordinate k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(k);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int obrisiKoordinate(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Koordinate k = s.Query<Koordinate>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(k);

                s.Flush();
                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int azurirajKoordinate(int id, Koordinate k)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Koordinate ko = s.Load<Koordinate>(id);

                ko.X_lin = k.X_lin;
                ko.Y_lin = k.Y_lin;
                ko.Id_Linijskog_Objekta = k.Id_Linijskog_Objekta;

                s.Update(ko);
                s.Flush();

                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion

        #region Uzvisenje

        public IEnumerable<Uzvisenje> vratiSvaUzvisenja()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Uzvisenje> u = s.Query<Uzvisenje>()
                                                .Select(p => p);

            //s.Close();

            return u;
        }
        public UzvisenjeView vratiUzvisenje(int id)
        {
            ISession s = DataLayer.GetSession();

            Uzvisenje u = s.Query<Uzvisenje>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            UzvisenjeView uzw = new UzvisenjeView();
            uzw.Nadmorska_visina = u.Nadmorska_visina;
            uzw.Id = u.Id;
            uzw.Naziv = u.Naziv;

            s.Close();

            return uzw;
        }
        public int dodajUzvisenjeu(Uzvisenje u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(u);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int obrisiUzvisenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Uzvisenje u = s.Query<Uzvisenje>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(u);

                s.Flush();
                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int azurirajUzvisenje(int id, Uzvisenje u)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Uzvisenje uz = s.Load<Uzvisenje>(id);

                uz.Nadmorska_visina = u.Nadmorska_visina;
                uz.Naziv = u.Naziv;

                s.Update(uz);
                s.Flush();

                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion

        #region Vrhovi

        public IEnumerable<ListaVrhova> vratiSveVrhove()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<ListaVrhova> l = s.Query<ListaVrhova>()
                                                .Select(p => p);

            //s.Close();

            return l;

        }
        public ListaVrhovaView vratiVrh(int id)
        {
            ISession s = DataLayer.GetSession();

            ListaVrhova l = s.Query<ListaVrhova>()
                .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

            ListaVrhovaView lw = new ListaVrhovaView();
            lw.Id = l.Id;
            lw.Ime = l.Ime;
            lw.Nadmorska_visina = l.Nadmorska_visina;

            s.Close();

            return lw;

        }
        public int dodajVrh(ListaVrhova l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(l);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int obrisiVrh(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ListaVrhova l = s.Query<ListaVrhova>()
                    .Where(v => v.Id == id).Select(p => p).FirstOrDefault();

                s.Delete(l);

                s.Flush();
                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;

            }
        }
        public int azurirajVrh(int id, ListaVrhova l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ListaVrhova lv = s.Load<ListaVrhova>(id);

                lv.Nadmorska_visina = l.Nadmorska_visina;
                lv.Ime = l.Ime;
                lv.Id_Uzvisenja = l.Id_Uzvisenja;

                s.Update(lv);
                s.Flush();

                s.Close();
                return 1;

            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        #endregion
    }
}
