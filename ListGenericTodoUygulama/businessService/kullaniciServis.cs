using ListGenericTodoUygulama.database;
using ListGenericTodoUygulama.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenericTodoUygulama.businessService
{
    public class kullaniciServis
    {
        public kullanici kullaniciKontrol(string kullaniciAdi, string sifre)
        {
            return sanalDatabase.kullaniciTablo.Where(x => x.kullaniciAdi == kullaniciAdi && x.sifre == sifre).FirstOrDefault();
        }
    }
}
