namespace Lesson8_1_Class;
internal class Ogrenci
{
    /*
     Erişim Belirleyicileri(Midifiers)
    public
    private
 */

    public void BilgileriGetir(string isim,string adres)
    {
        Console.WriteLine("Adı:"+isim);
        Console.WriteLine("Adres:"+adres);
    }


    public int YasHesapla(DateTime dogumTarih)
    {
        int hesapla = DateTime.Now.Year - dogumTarih.Year;
        return hesapla;
    }


}
