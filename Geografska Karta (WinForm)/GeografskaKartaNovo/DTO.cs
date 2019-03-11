using GeografskaKartaNovo.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografskaKartaNovo
{
    
    public class TackastiObjekatBasic
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int X_tac { get; set; }
        public virtual int Y_tac { get; set; }
        public virtual DateTime Datum_Osnivanja { get; set; }
        public virtual int F_naseljeno { get; set; }
        public virtual int F_turisticko { get; set; }
        public virtual int Broj_Stanovnika { get; set; }
        public virtual String Tip_naselja { get; set; }
        public virtual String Opstina { get; set; }
        public virtual DateTime Datum_status { get; set; }
        public virtual String Tip_turizma { get; set; }

        public virtual IList<Znamenitost> Lista_Znamenitosti { get; set; }//
        public virtual IList<SadrziTac> Lista_SadrziTac { get; set; }
        public virtual IList<LinijskiObjekat> Lista_Linijskih_objekata { get; set; }

        public TackastiObjekatBasic()
        {
            Lista_Znamenitosti = new List<Znamenitost>();//
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
        }
        public TackastiObjekatBasic(int id, String naziv, String opstina)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Opstina = opstina;
            Lista_Znamenitosti = new List<Znamenitost>();
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
        }
        public TackastiObjekatBasic(int id, string naziv, string x, string y, DateTime date)//samo tackasti objekat, ne naseljeno mesto ili banja
        {
            Id = id;
            Naziv = naziv;
            X_tac = Int32.Parse(x);
            Y_tac = Int32.Parse(y);
            Datum_Osnivanja = date;
            F_naseljeno = 0;
            F_turisticko = 0;
            Lista_Znamenitosti = new List<Znamenitost>();//
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
        }

        public TackastiObjekatBasic(int id, string naziv, string x, string y, DateTime date, 
            string brStan, string tipNas, string opstina, IList<Znamenitost> lista_Znamenitosti1)//naseljeno mesto
        {
            Id = id;
            Naziv = naziv;
            X_tac = Int32.Parse(x);
            Y_tac = Int32.Parse(y);
            Datum_Osnivanja = date;
            F_naseljeno = 1;
            F_turisticko = 0;
            Broj_Stanovnika = Int32.Parse(brStan);
            Tip_naselja = tipNas;
            Opstina = opstina;

            Lista_Znamenitosti = new List<Znamenitost>();//
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();

            Lista_Znamenitosti = lista_Znamenitosti1;
        }

        public TackastiObjekatBasic(int id, string naziv, string x, string y, DateTime date,
            string brStan, string tipNas, string opstina, IList<Znamenitost> lista_Znamenitosti1,
            string tipTur, DateTime date2)//turisticko
        {
            Id = id;
            Naziv = naziv;
            X_tac = Int32.Parse(x);
            Y_tac = Int32.Parse(y);
            Datum_Osnivanja = date;
            F_naseljeno = 1;
            F_turisticko = 1;
            Broj_Stanovnika = Int32.Parse(brStan);
            Tip_naselja = tipNas;
            Opstina = opstina;
            Tip_turizma = tipTur;
            Datum_status = date2;

            Lista_Znamenitosti = new List<Znamenitost>();//
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();

            Lista_Znamenitosti = lista_Znamenitosti1;
        }
        
        public TackastiObjekatBasic(int id, string naziv, int x_tac, int y_tac, DateTime datum_Osnivanja, 
            int f_naseljeno, int f_turisticko, int broj_Stanovnika, string tip_naselja, string opstina, 
            DateTime datum_status, string tip_turizma, IList<Znamenitost> lista_Znamenitosti1, 
            IList<SadrziTac> lista_SadrziTac1, IList<LinijskiObjekat> lista_Linijskih_objekata1)
        {
            Id = id;
            Naziv = naziv;
            X_tac = x_tac;
            Y_tac = y_tac;
            Datum_Osnivanja = datum_Osnivanja;
            F_naseljeno = f_naseljeno;
            F_turisticko = f_turisticko;
            Broj_Stanovnika = broj_Stanovnika;
            Tip_naselja = tip_naselja;
            Opstina = opstina;
            Datum_status = datum_status;
            Tip_turizma = tip_turizma;

            Lista_Znamenitosti = new List<Znamenitost>();//
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();

            Lista_Znamenitosti = lista_Znamenitosti1;
            Lista_Linijskih_objekata = lista_Linijskih_objekata1;
            Lista_SadrziTac = lista_SadrziTac1;
           // foreach (Znamenitost a in lista_Znamenitosti1)
           //     Lista_Znamenitosti.Add(new ZnamenitostBasic(a.Id, a.Naziv_Znamenitost, new TackastiObjekat()));
           //         a.Id_Naseljenog_Mesta.Id, a.Id_Naseljenog_Mesta.Naziv, a.Id_Naseljenog_Mesta.X_tac, a.Id_Naseljenog_Mesta.Y_tac,
             //       a.Id_Naseljenog_Mesta.Datum_Osnivanja, a.Id_Naseljenog_Mesta.F_naseljeno,
               //     a.Id_Naseljenog_Mesta.F_turisticko, a.Id_Naseljenog_Mesta.Broj_Stanovnika, a.Id_Naseljenog_Mesta.Tip_naselja,
                 //   a.Id_Naseljenog_Mesta.Opstina, a.Id_Naseljenog_Mesta.Datum_status,
                   // a.Id_Naseljenog_Mesta.Tip_turizma)));
            //foreach (var b in lista_SadrziTac1)
            //    Lista_SadrziTac.Add(b);
            //foreach (var c in lista_Linijskih_objekata1)
            //    Lista_Linijskih_objekata.Add(c);
            
        }

        public override string ToString()
        {
            return Id.ToString() + " " + Naziv;
        }
    }

    public class ZnamenitostBasic
    {

        public virtual String Naziv_Znamenitost { get; set; }
        public virtual int Id { get; set; }
        public virtual TackastiObjekat Id_Naseljenog_Mesta { get; set; }//

        public ZnamenitostBasic(int id, string naziv_Znamenitost, TackastiObjekat id_Naseljenog_Mesta)//
        {
            Naziv_Znamenitost = naziv_Znamenitost;
            Id = id;
            Id_Naseljenog_Mesta = id_Naseljenog_Mesta;
        }

        public ZnamenitostBasic(String text, TackastiObjekat tackasti)
        {
            Naziv_Znamenitost = text;
            Id_Naseljenog_Mesta = tackasti;

        }

        public override string ToString()
        {
            return Id.ToString() + " " + Naziv_Znamenitost;
        }

    }

    public class PovrsinskiObjekatBasic
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual IList<SadrziLin> Lista_SadrziLin { get; set; }
        public virtual IList<LinijskiObjekat> Lista_Linijskih_objekata { get; set; }

        public PovrsinskiObjekatBasic()
        {
            Lista_SadrziLin = new List<SadrziLin>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
        }

        public PovrsinskiObjekatBasic(int id, string naziv, IList<SadrziLin> lista_SadrziLin, IList<LinijskiObjekat> lista_Linijskih_objekata)
        {
            Id = id;
            Naziv = naziv;

            Lista_SadrziLin = new List<SadrziLin>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();

            Lista_SadrziLin = lista_SadrziLin;
            Lista_Linijskih_objekata = lista_Linijskih_objekata;
        }
        public PovrsinskiObjekatBasic(int id, String na)
        {
            this.Id = id;
            this.Naziv = na;
            Lista_SadrziLin = new List<SadrziLin>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
        }
    }

    public class LinijskiObjekatBasic
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual String Duzina { get; set; }
        public virtual String Tip_Objekta { get; set; }
        public virtual String Opis_Objekta { get; set; }

        public virtual IList<Koordinate> ListaKoordinata { get; set; }
        public virtual IList<SadrziTac> Lista_SadrziTac { get; set; }
        public virtual IList<SadrziLin> Lista_SadrziLin { get; set; }
        public virtual IList<TackastiObjekat> Lista_Tackastih_objekata { get; set; }
        public virtual IList<PovrsinskiObjekat> Lista_Povrsinskih_objekata { get; set; }
        public virtual IList<TackastiObjekat> Lista_Svih_Tackastih_objekata { get; set; }

        public LinijskiObjekatBasic()
        {
            ListaKoordinata = new List<Koordinate>();
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_SadrziLin = new List<SadrziLin>();
            Lista_Tackastih_objekata = new List<TackastiObjekat>();
            Lista_Povrsinskih_objekata = new List<PovrsinskiObjekat>();
            Lista_Svih_Tackastih_objekata = new List<TackastiObjekat>();
        }

        public LinijskiObjekatBasic(int id, string naziv, string duzina, string tip_Objekta, string opis_Objekta)
        {
            Id = id;
            Naziv = naziv;
            Duzina = duzina;
            Tip_Objekta = tip_Objekta;
            Opis_Objekta = opis_Objekta;

            ListaKoordinata = new List<Koordinate>();
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_SadrziLin = new List<SadrziLin>();
            Lista_Tackastih_objekata = new List<TackastiObjekat>();
            Lista_Povrsinskih_objekata = new List<PovrsinskiObjekat>();
        }
        public LinijskiObjekatBasic(String duzina, String tip, String opis, String naziv, int id)
        {
            this.Duzina = duzina;
            this.Tip_Objekta = tip;
            this.Opis_Objekta = opis;
            this.Naziv = naziv;
            this.Id = id;
            ListaKoordinata = new List<Koordinate>();
            Lista_SadrziTac = new List<SadrziTac>();
            Lista_SadrziLin = new List<SadrziLin>();
            Lista_Tackastih_objekata = new List<TackastiObjekat>();
            Lista_Povrsinskih_objekata = new List<PovrsinskiObjekat>();
            Lista_Svih_Tackastih_objekata = new List<TackastiObjekat>();
        }

        public override string ToString()
        {
            return Id.ToString() + " " + Naziv;
        }

    }

    public class SadrziLinBasic
    {
        public virtual LinijskiObjekat Id_Linijskog_Objekta { get; set; }
        public virtual PovrsinskiObjekat Id_Povrsinskog_Objekta { get; set; }
        public virtual int Id { get; set; }

        public virtual IList<LinijskiObjekat> Lista_Linijski_Objekat { get; set; }
        public virtual IList<PovrsinskiObjekat> Lista_Povrsinski_Objekat { get; set; }

        public SadrziLinBasic()
        {
            Lista_Linijski_Objekat = new List<LinijskiObjekat>();
            Lista_Povrsinski_Objekat = new List<PovrsinskiObjekat>();
        }

        public SadrziLinBasic(PovrsinskiObjekat id_Povrsinskog_Objekta, LinijskiObjekat id_Linijskog_Objekta)
        {
            Id_Linijskog_Objekta = id_Linijskog_Objekta;
            Id_Povrsinskog_Objekta = id_Povrsinskog_Objekta;

            Lista_Linijski_Objekat = new List<LinijskiObjekat>();
            Lista_Povrsinski_Objekat = new List<PovrsinskiObjekat>();
        }
    }
    
    public class VodnaPovrsinaBasic
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual String Tip_Vode { get; set; }

        public VodnaPovrsinaBasic()
        {

        }

        public VodnaPovrsinaBasic(int id, string naziv, string tip_Vode)
        {
            Id = id;
            Naziv = naziv;
            Tip_Vode = tip_Vode;
        }
    }

    public class UzvisenjeBasic
    {
        public virtual int id { get; set; }
        public virtual String naziv { get; set; }
        public virtual double Nadmorska_visina { get; set; }
        public virtual IList<ListaVrhova> Lista_Vrhova { get; set; }
        public virtual IList<SadrziGeog> Lista_SadrziGeog { get; set; }
        public virtual IList<GeografskiObjekat> Lista_Geografskih_objekata { get; set; }
        public virtual IList<SadrziLin> Lista_SadrziLin { get; set; }
        public virtual IList<LinijskiObjekat> Lista_Linijskih_objekata { get; set; }

        public virtual IList<ListaVrhova> listaSvihVrhova { get; set; }
        public virtual IList<GeografskiObjekat> listaSvihGeografskih { get; set; }

        public UzvisenjeBasic()
        {
            Lista_Vrhova = new List<ListaVrhova>();
            Lista_SadrziGeog = new List<SadrziGeog>();
            Lista_Geografskih_objekata = new List<GeografskiObjekat>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
            Lista_SadrziLin = new List<SadrziLin>();
            listaSvihGeografskih = new List<GeografskiObjekat>();
            listaSvihVrhova = new List<ListaVrhova>();
        }
        public UzvisenjeBasic(int id, String naziv, double visina)
        {
            this.id = id;
            this.naziv = naziv;
            this.Nadmorska_visina = visina;

            Lista_Vrhova = new List<ListaVrhova>();
            Lista_SadrziGeog = new List<SadrziGeog>();
            Lista_Geografskih_objekata = new List<GeografskiObjekat>();
            Lista_Linijskih_objekata = new List<LinijskiObjekat>();
            Lista_SadrziLin = new List<SadrziLin>();
            listaSvihGeografskih = new List<GeografskiObjekat>();
            listaSvihVrhova = new List<ListaVrhova>();
        }
    }

    public class ListaVrhovaBasic
    {
        public virtual String Ime { get; set; }
        public virtual double Nadmorska_visina { get; set; }
        public virtual int Id { get; set; }
        public virtual Uzvisenje Id_Uzvisenja { get; set; }

        public ListaVrhovaBasic()
        {

        }
        public ListaVrhovaBasic(int id, String ime, double vi)
        {
            this.Id = id;
            this.Ime = ime;
            this.Nadmorska_visina = vi;
        }
    }

    public class GeografskiObjekatBasic
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }

        public virtual IList<SadrziGeog> Lista_Basic_Sadrzi_Geog { get; set; }
        public virtual IList<Uzvisenje> Lista_Basic_Uzvisenja { get; set; }

        public GeografskiObjekatBasic(int id, string na, IList<Uzvisenje> uzv, IList<SadrziGeog> sadrzi)
        {
            Lista_Basic_Uzvisenja = new List<Uzvisenje>();
            Lista_Basic_Sadrzi_Geog = new List<SadrziGeog>();
            this.Id = id;
            this.Naziv = na;
            this.Lista_Basic_Uzvisenja = uzv;
            this.Lista_Basic_Sadrzi_Geog = sadrzi;
        }
        public GeografskiObjekatBasic()
        {
            Lista_Basic_Uzvisenja = new List<Uzvisenje>();
            Lista_Basic_Sadrzi_Geog = new List<SadrziGeog>();
        }

        public GeografskiObjekatBasic(int id, string na)
        {
            Lista_Basic_Uzvisenja = new List<Uzvisenje>();
            Lista_Basic_Sadrzi_Geog = new List<SadrziGeog>();
            this.Naziv = na;
            this.Id = id;
        }
    }

    public class KoordinateBasic
    {
        public virtual double X_lin { get; set; }
        public virtual double Y_lin { get; set; }
        public virtual int Id { get; set; }

        public virtual LinijskiObjekat Id_Linijskog_Objekta { get; set; }

        public KoordinateBasic(int id, double x, double y)
        {
            this.Id = id;
            this.X_lin = x;
            this.Y_lin = y;
        }
        public KoordinateBasic() { }

        public KoordinateBasic(double x, double y, LinijskiObjekat l)
        {
            this.X_lin = x;
            this.Y_lin = y;
            this.Id_Linijskog_Objekta = l;
        }
    }

}
