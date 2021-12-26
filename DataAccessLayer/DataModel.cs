using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con;SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }

        public Kullanici KullaniciGiris(string email, string sifre)
        {
            try
            {
                Kullanici k = null;
                cmd.CommandText = "SELECT * FROM Kullanicilar WHERE Email=@e AND Sifre =@s";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", sifre);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    k = new Kullanici();
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                    k.Soyad = reader.GetString(2);
                    k.Mail = reader.GetString(3);
                    k.Sifre = reader.GetString(4);
                    k.Durum = reader.GetBoolean(5);
                }
                return k;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Sehir> SehirleriGetir()
        {
            List<Sehir> sehirler = new List<Sehir>();
            try
            {
                cmd.CommandText = "SELECT * FROM Sehirler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sehir s = new Sehir();
                    s.ID = reader.GetInt32(0);
                    s.Isim = reader.GetString(1);
                    sehirler.Add(s);
                }
                return sehirler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Ilce> IlceleriGetir(int sehirID)
        {
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                cmd.CommandText = "SELECT * FROM Ilceler WHERE SehirID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", sehirID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ilce i = new Ilce();
                    i.ID = reader.GetInt32(0);
                    i.SehirID = reader.GetInt32(1);
                    i.Isim = reader.GetString(2);
                    ilceler.Add(i);
                }
                return ilceler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Universite> UniversiteleriGetir()
        {
            List<Universite> universiteler = new List<Universite>();
            try
            {
                cmd.CommandText = "SELECT * FROM yok_universiteler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Universite u = new Universite();
                    u.ID = reader.GetInt32(0);
                    u.Isim = reader.GetString(1);
                    universiteler.Add(u);
                }
                return universiteler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Fakulte> FakulteleriGetir(int UniversiteID)
        {
            List<Fakulte> fakulteler = new List<Fakulte>();
            try
            {
                cmd.CommandText = "SELECT * FROM yok_fakulteler WHERE UniversiteID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", UniversiteID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Fakulte f = new Fakulte();
                    f.ID = reader.GetString(0);
                    f.UniversiteID = reader.GetInt32(1);
                    f.Isim = reader.GetString(2);
                    fakulteler.Add(f);
                }
                return fakulteler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Bolum> BolumleriGetir(int FakulteID)
        {
            List<Bolum> Bolumler = new List<Bolum>();
            try
            {
                cmd.CommandText = "SELECT * FROM yok_Bolumler WHERE FakulteID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", FakulteID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Bolum b = new Bolum();
                    b.ID = reader.GetInt32(0);
                    b.FakulteID = reader.GetString(1);
                    b.UniversiteID = reader.GetInt32(2);
                    b.Isim = reader.GetString(3);
                    Bolumler.Add(b);
                }
                return Bolumler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public int OgrenciKaydet(Ogrenci ogr)
        {
           
            try
            {
                cmd.CommandText = "INSERT INTO Ogrenciler(SehirID,IlceID,TCNo,Isim,Soyisim,TelNo,Adres,Resim) VALUES(@sehirID,@ilceID,@tCNo,@isim,@soyisim,@telNo,@adres,@resim) SELECT @@IDENTITY";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sehirID", ogr.SehirID);
                cmd.Parameters.AddWithValue("@ilceID", ogr.IlceID);
                cmd.Parameters.AddWithValue("@tCNo", ogr.TCNo);
                cmd.Parameters.AddWithValue("@isim", ogr.Isim);
                cmd.Parameters.AddWithValue("@soyisim", ogr.Soyisim);
                cmd.Parameters.AddWithValue("@telNo", ogr.TelNo);
                cmd.Parameters.AddWithValue("@adres", ogr.Adres);
                cmd.Parameters.AddWithValue("@resim", ogr.Resim);
                con.Open();

                int gelenid = Convert.ToInt32(cmd.ExecuteScalar());
                return gelenid;
            }
            catch
            {
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        public bool OgrenciOkulEkle(OgrenciOkul oo)
        {
            try
            {
                cmd.CommandText = "INSERT INTO OgrenciOkullar(OgrenciID,UniversiteID,FakulteID,BolumID,BaslangicYil,BitisYil,Durum)VALUES(@ogrenciID,@universiteID,@fakulteID,@bolumID,@baslangicYil,@bitisYil,@durum)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ogrenciID", oo.OgrenciID);
                cmd.Parameters.AddWithValue("@universiteID", oo.UniversiteID);
                cmd.Parameters.AddWithValue("@fakulteID", oo.FakulteID);
                cmd.Parameters.AddWithValue("@bolumID", oo.BolumID);
                cmd.Parameters.AddWithValue("@baslangicYil", oo.BaslangicYil);
                cmd.Parameters.AddWithValue("@bitisYil", oo.BitisYil);
                cmd.Parameters.AddWithValue("@durum", oo.Durum);
                con.Open();

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Ogrenci> OgrencileriGetir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            try
            {
                cmd.CommandText = "SELECT O.*, S.Isim, I.Isim, K.Isim + ' ' + K.Soyad AS Kullanici FROM Ogrenciler AS O JOIN Sehirler AS S ON S.ID = O.SehirID JOIN Ilceler AS I ON I.ID = O.IlceID JOIN Kullanicilar AS K ON K.ID = O.KullaniciID";
                cmd.Parameters.Clear();
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ogrenci ogr = new Ogrenci();
                    ogr.ID = reader.GetInt32(0);
                    ogr.SehirID = reader.GetInt32(1);
                    ogr.IlceID = reader.GetInt32(2);
                    ogr.KullaniciID = reader.GetInt32(3);
                    ogr.TCNo = reader.GetString(4);
                    ogr.Isim = reader.GetString(5);
                    ogr.Soyisim = reader.GetString(6);
                    ogr.TelNo = reader.GetString(7);
                    ogr.Adres = reader.GetString(8);
                    ogr.Resim = !reader.IsDBNull(9) ? reader.GetString(9) : "none.png";
                    ogr.SehirIsim = reader.GetString(10);
                    ogr.IlceIsim = reader.GetString(11);
                    ogr.KullaniciIsim = reader.GetString(12);
                    ogrenciler.Add(ogr);
                }
                return ogrenciler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
