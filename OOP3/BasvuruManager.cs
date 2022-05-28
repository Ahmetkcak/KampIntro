using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //işlemler
            krediManager.Hesapla(); 
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediller)
        {
            foreach (var kredi in krediller)
            {
                kredi.Hesapla();
            }
        }
    }
}
