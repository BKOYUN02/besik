using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYUN_1
{
    class AYAR
    {
        public static void yazı()
        {
            string a = "9";
            do
            {
                Console.WriteLine("yazı rengi ne olsun");
                Console.WriteLine("MAVİ------> #1#");
                Console.WriteLine("KIRMIZI---> #2#");
                Console.WriteLine("SARI------> #3#");
                Console.WriteLine("YEŞİL-----> #4#");
                Console.WriteLine("MOR-------> #5#");
                a = Console.ReadLine();
                if (a == "1" || a == "2" || a == "3" || a == "4" || a == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }

            } while (true);

            switch (a)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    break;
                default: break;
            }
            Console.Clear();
        }
        public static void Aplan()
        {
            string a = "9";
            do
            {
                Console.WriteLine("Arkaplan rengi ne olsun");
                Console.WriteLine("SİYAH-----> #1#");
                Console.WriteLine("BEYAZ-----> #2#");
                a = Console.ReadLine();
                if (a == "1" || a == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }

            } while (true);

            switch (a)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    break;
                case "2":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                default: break;
            }
            Console.Clear();

        }
        public static void ayar()
        {
            do
            {

                string seçim_1;
                Console.WriteLine("*****RENG DEĞİŞTİRME*****");
                Console.WriteLine("YAZI RENGİ--------> #1#");
                Console.WriteLine("ARKAPLAN RENGİ----> #2#");
                Console.WriteLine("GERİ--------------> #0#");
                seçim_1 = Console.ReadLine();
                if (!(seçim_1 == "1" || seçim_1 == "2" || seçim_1 == "0"))
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }
                if (seçim_1 == "0")
                {
                    break;
                }
                if (seçim_1 == "1")
                {
                    yazı();
                    break;
                }
                if (seçim_1 == "2")
                {
                    Aplan();
                    break;
                }
            } while (true);
            Console.Clear();
        }


    }
    class Oyun
    {
        //public string oyuncu;
        public static void karakter()
        {
            string a = "9";
            string oyuncu = "oyuncu";
            do
            {
                Console.WriteLine("OYUNCU SEÇİMİ");
                Console.WriteLine("BERKANT------> #1#");
                Console.WriteLine("EDA----------> #2#");
                Console.WriteLine("İREM---------> #3#");
                Console.WriteLine("KADİR--------> #4#");
                Console.WriteLine("ŞEYMA--------> #5#");
                a = Console.ReadLine();
                if (a == "1" || a == "2" || a == "3" || a == "4" || a == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }

            } while (true);

            switch (a)
            {
                case "1":
                    oyuncu = "Berkant";
                    break;
                case "2":
                    oyuncu = "Eda";
                    break;
                case "3":
                    oyuncu = "İrem";
                    break;
                case "4":
                    oyuncu = "Kadir";
                    break;
                case "5":
                    oyuncu = "Şeyma";
                    break;
                default: break;
            }
            Console.Clear();
            o_basla(oyuncu);
        }
        public static void o_basla(string a)
        {
            Console.WriteLine("[][][][]---OYUN BAŞLIYOR---[][][][]");
            Console.WriteLine(a + " Ve beşik grubu Arkadaşları sıradan bir günde Çınaraltı Cafede oturuyorlardı.");
            Console.WriteLine("Kadir , İrem ve Şeyma sıcak çikolata ; Eda ayran ; Berkant ise oralet içiyordu.");
            Console.WriteLine("Dışarıda bağırma sesleri duymaya başladılar ve camdan dışarı baktılar ve bir felaket ile karşı karşıya oldukları anladılar");
            Console.WriteLine("Dışarıda insanlar birbirine saldırıyor, insanlar birbirini ısırıyor, insanlar kaçmaya çalışıyordu bu bir zombie salgınıydı");
            Console.WriteLine("Hemen " + a + " arkadaşlarını etrafına topladı ve ne yapacaklarına dair bir plan yapmaları gerektiğini söyledi.");
            Console.WriteLine("O sırada " + a + " nın telefonu çaldı ve arayan +oyuncu+ nın babasıydı.");
            Console.WriteLine(a + " babasıyla konuştukdan sonra arkadaşlarına donüp ve dedi ki 'Balıkesir in 50KM Batısında askerlerin");
            Console.WriteLine("güvene aldığı bir yer varmış oraya gidelim mi' ");
            Console.WriteLine("oylama yapmaya karar vermişler; iki kişi gidmeye karar vermiş diğer iki kişi ise ");
            Console.WriteLine("Çınaraltında kalıp yardım beklemek için oy kullanmış");
            Console.WriteLine("seçimin sonucu " + a + " nın kararına bağlıydı");
            Console.WriteLine();
            Console.WriteLine("Çınaraltında kalıp yardım beklemek------------> #1#");
            Console.WriteLine("güvenli bölgöye gitmek için harakete geçmek---> #2#");
            do
            {
                string seçim_1 = Console.ReadLine();
                if (!(seçim_1 == "2" || seçim_1 == "1"))
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }
                if (seçim_1 == "1")
                {
                    Console.Clear();
                    uzatma_1(a);
                    break;
                }
                if (seçim_1 == "2")
                {
                    Console.Clear();
                    devam_1(a);
                    break;
                }
            } while (true);
        }
        public static void uzatma_1(string a)
        {
            Console.WriteLine("5 saattir bekliyorsunuz ve hiç gelip giden yok");
            Console.WriteLine("ve bir andan telefonlara bir mesaj geldi mesajda " + a + " nın babasının");
            Console.WriteLine("söylediği güvenli yere çağrı yapıldığı ve yardımın aylarca hiçbir yere gidmeyeceği yazıyordu");
            Console.WriteLine("yeniden oylama yapıldı ve tekrar dan oylar 2ye2 kaldı");
            Console.WriteLine("seçimin sonucu " + a + " nın kararına bağlıydı");
            Console.WriteLine();
            Console.WriteLine("Çınaraltında kalıp yardım beklemek------------> #1#");
            Console.WriteLine("güvenli bölgöye gitmek için harakete geçmek---> #2#");
            do
            {
                string seçim_1 = Console.ReadLine();
                if (!(seçim_1 == "2" || seçim_1 == "1"))
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }
                if (seçim_1 == "1")
                {
                    Console.Clear();
                    olum_1(a);
                    break;
                }
                if (seçim_1 == "2")
                {
                    Console.Clear();
                    devam_1(a);
                    break;
                }
            } while (true);
        }
        public static void devam_1(string a)
        {
            Console.WriteLine(a + " ve arkadaşları çınaraltından dışarı cıkmışlardı önlerinde iki seçenek vardı ");
            Console.WriteLine("ya güvenli bölgöye ulaşmak için bir araba bulacaklardı ya da kendilerini savunmak için bir silah");
            Console.WriteLine();
            Console.WriteLine("araba için otoparka gitmek------------> #1#");
            Console.WriteLine("silah bulmak için silahcıya gitmek----> #2#");
            do
            {
                string seçim_1 = Console.ReadLine();

                if (!(seçim_1 == "2" || seçim_1 == "1"))
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }
                if (seçim_1 == "1")
                {
                    Console.Clear();
                    devam_2(a);
                    break;
                }
                if (seçim_1 == "2")
                {
                    Console.Clear();
                    bağlama_1(a);
                    break;
                }
            } while (true);
        }
        public static void devam_2(string a)
        {
            Console.WriteLine("eski model bir araba buldunuz " + a + " hemen şoför koltuğuna oturdu ");
            Console.WriteLine("ve arabaya düz kontak yapıp yola koyuldunuz");
            Console.WriteLine("Balıkesir in çıkışında küçük bir kız gördünüz. Araba ile yavaşca yanına yaklaşıp kızın");
            Console.WriteLine("yanında durdunuz. kız sizden yaralı olan annesi için yardım istiyordu. ");
            Console.WriteLine("Grub arasında bir tartışma geçtikten sonra kıza yardım edip edilmeyeceğine " + a + " karar verecekti");
            Console.WriteLine();
            Console.WriteLine("kıza yardım et---------------> #1#");
            Console.WriteLine("kızı boşver bas gaza git-----> #2#");
            do
            {
                string seçim_1 = Console.ReadLine();
                if (!(seçim_1 == "2" || seçim_1 == "1"))
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }
                if (seçim_1 == "1")
                {
                    Console.Clear();
                    olum_2(a);
                    break;
                }
                if (seçim_1 == "2")
                {
                    Console.Clear();
                    devam_3(a);
                    break;
                }
            } while (true);
        }
        public static void devam_3(string a)
        {
            Console.WriteLine("kız arkada kalmıştı yola devam ediyordunuz");
            Console.WriteLine(a + " sert bir fren yaparak durdu. Arkadaşları ne olduğunu sorduğunda ise şu cevabı verdi");
            Console.WriteLine("Yolun ilerisinde üzerimize doğru gelen bir zombi sürüsü var");
            Console.WriteLine("grub hemen düşünmeye başladı ");
            Console.WriteLine("ve iki seçeneklerinin olduğunun farkına vardılar");
            Console.WriteLine("ya arabayı kapatıp arabanın içinde sesizce zombilerin etraflarından geçmelerini bekliyeceklerdi");
            Console.WriteLine("ya da yolun hemen yanındaki klübeye gideceklerdi");
            Console.WriteLine("Oylama yaptılar ve yine 2ye 2 kaldılar");
            Console.WriteLine("karar yine " + a + " ya kalmıştı");
            Console.WriteLine();
            Console.WriteLine("arabada beklemek--------> #1#");
            Console.WriteLine("klubeye gitmek----------> #2#");
            do
            {
                string seçim_1 = Console.ReadLine();

                if (!(seçim_1 == "2" || seçim_1 == "1"))
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }
                if (seçim_1 == "1")
                {
                    Console.Clear();
                    devam_4(a);
                    break;
                }
                if (seçim_1 == "2")
                {
                    Console.Clear();
                    devam_4_1(a);
                    break;
                }
            } while (true);
        }
        public static void devam_4(string a)
        {
            Console.WriteLine("Arabayı kapatılar ve arabanın içinde yatıp sessizce beklemeye başladılar");
            Console.WriteLine("Zombiler yavaş bir şekilde arabanın yanından geçip gittiler");
            Console.WriteLine(a + " arabayı çalıştırıp yola devam etti");
            Console.WriteLine("karşılarına bir anda askerler çıktı ");
            Console.WriteLine("evet sonunda güvenli bölgeye ulaşmışlardı");
            Console.WriteLine("arabanın içinden sevinçle indiler ve güvenli bölgeye geçtiler ");
            Console.WriteLine(a + " bu işte bir terslik olduğunu anlamıştı...");
            Console.WriteLine("**************DEVAM EDECEK***********");
            Console.WriteLine();
            final();
        }
        public static void devam_4_1(string a)
        {
            Console.WriteLine(a + " ve arkadaşları klubeye doğru yürümeye başladılar.");
            Console.WriteLine("Klübeye vardıklarında içeride yaşlı bir adam ve karısı vardı");
            Console.WriteLine(a + " yavaşca kapıyı caldı");
            Console.WriteLine("içeriden yaşlı adam elinde tüfeği ile çıktı ve burayı terk etmeleri gerektiğini söyledi");
            Console.WriteLine("Beşik grubu durumu anlattı ama yaşlı adam gençlerin kendisiyle dalda geçtiğini düşünüp");
            Console.WriteLine("gençlerin gitmesi için havaya doğru ateş etti.");
            Console.WriteLine("zombiler sesi duydu ve klübeye doğru koşmaya başladılar");
            Console.WriteLine("bunu gören " + a + " ve arkadaşları ormana doğru koşmaya başladılar");
            Console.WriteLine(a + " hariç diğerleri zombilere yem olmuşlardı");
            Console.WriteLine("Artık " + a + " yanlız kalmıştı arkadaşarının yakalanması sayesinde hayattaydı");
            Console.WriteLine("**************DEVAM EDECEK***********");
            Console.WriteLine();
            final();

        }
        public static void olum_2(string a)
        {
            Console.WriteLine("kıza yardım etmek için arabadan indiniz. " + a + " kızı kucağına aldı.");
            Console.WriteLine("Küçük kız " + a + " nın kulağına şu kelimeleri fısıldadı");
            Console.WriteLine("!!ÇOK APTALSINIZ!!");
            Console.WriteLine("bir anda beşik grubunun etrafı silahlı adamlara çevrildi");
            Console.WriteLine(a + " bunun bir tuzak olduğunu anlamıştı ama artık cok geçti");
            Console.WriteLine("adamlar BEŞİK grubunun kafalarına sıkıp daha sonra yemek için yanlarına aldılar ");
            Console.WriteLine();
            final();
        }
        public static void bağlama_1(string a)
        {
            Console.WriteLine("Silahcıya girdiniz. O da ne içeride hiç silah kalmamış");
            Console.WriteLine("Şimdi tek çare araba bulup güvenli bölgeye gitmek");
            Console.WriteLine();
            devam_2(a);
        }
        public static void olum_1(string a)
        {
            Console.WriteLine("yardım beklemeye devam ediyorlardı bir anda içeriye zombiler girmeye başladı");
            Console.WriteLine(a + " sandalyeler ile zombilere saldırmasına rağmen beşik grubundaki herkes öldü");
            Console.WriteLine();
            final();
        }
        public static void final()
        {
            Console.WriteLine();
            Console.WriteLine("0000000000      00000      000        00");
            Console.WriteLine("0000000000     00   00     0000       00");
            Console.WriteLine("00            00     00    00 00      00");
            Console.WriteLine("00            00     00    00  00     00");
            Console.WriteLine("0000000000    00     00    00   00    00");
            Console.WriteLine("0000000000    00     00    00    00   00");
            Console.WriteLine("        00    00     00    00     00  00");
            Console.WriteLine("        00    00     00    00      00 00");
            Console.WriteLine("0000000000     00   00     00       0000");
            Console.WriteLine("0000000000      00000      00        000");
            Console.WriteLine();
            Console.WriteLine("[][][]----YAPIMCI----[][][]");
            Console.WriteLine("              |             ");
            Console.WriteLine("              |             ");
            Console.WriteLine("              ↓             ");
            Console.WriteLine("[][][]----BERKANT----[][][]");
            Console.WriteLine();
            Console.WriteLine("ana menüye dönmek için lütfen ENTER a basın");
            Console.ReadLine();
            Console.Clear();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //AYAR C1 = new AYAR();
            do
            {
                string seçim;
                Console.WriteLine("0000000000     0000000000     0000000000    00    00   00");
                Console.WriteLine("0000000000     0000000000     0000000000    00    00  00");
                Console.WriteLine("00       00    00             00                  00 00");
                Console.WriteLine("00       00    00             00                  0000");
                Console.WriteLine("0000000000     0000000000     0000000000    00    000");
                Console.WriteLine("0000000000     0000000000     0000000000    00    000");
                Console.WriteLine("00       00    00                     00    00    0000");
                Console.WriteLine("00       00    00                     00    00    00 00");
                Console.WriteLine("0000000000     0000000000     0000000000    00    00  00");
                Console.WriteLine("0000000000     0000000000     0000000000    00    00   00");
                Console.WriteLine("                                  00                ");
                Console.WriteLine("                                  00                ");
                Console.WriteLine();
                Console.WriteLine("GİRİŞ");
                Console.WriteLine("OYUNA BAŞLA----> #1#");
                Console.WriteLine("AYARLAR--------> #2#");
                Console.WriteLine("CIKIŞ----------> #0#");
                seçim = Console.ReadLine();
                if (!(seçim == "1" || seçim == "2" || seçim == "0"))
                {
                    Console.WriteLine("HATALI BİR TUŞA BASTINIZ LÜTFEN TEKRAR DENEYİN");
                    continue;
                }
                if (seçim == "1")
                {
                    Console.Clear();
                    Oyun.karakter();
                }
                if (seçim == "2")
                {
                    Console.Clear();
                    AYAR.ayar();
                }
                if (seçim == "0")
                {
                    break;
                }

            } while (true);
        }
    }
}
