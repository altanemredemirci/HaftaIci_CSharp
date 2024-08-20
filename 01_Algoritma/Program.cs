namespace _01_Algoritma
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            /*
               
             YAZILIM :Var olan bir problemi çözmek veya çözümü geliştirmek için yapılır.
             1-Backend => UI alanında gelen istekleri derleyen" yapıdır.
             2-Frontend => User Interface(UI/UX) => Html,Css,JavaScript

                 Mobile App => 
                 Game
                 Desktop App
                 Web App


            Yazılım uzmanlığı => .Net Developer 

            Framework: Yazılımcılar tarafından geliştirilen ve yazılım geliştiricilerin kullanımına açılan hazır kod kütüphanesidir.

            .Net Framework: C# tabanlı farklı platformlarda kodlanmış projelerin ortak bir tabanda geliştirilmesini ve çalıştırılmasını sağlar.
                
                *Games
                *Web
                *Console
                *Desktop
                *Machine Learning



            ## ******** ALGORİTMA ********* ##
            Algoritma, Var olan bir problemi veya geliştirme ihtiyacını çözmek için yapılacak çözüm adımlarının mantıklı sıralamasıdır.

            1-Başlangıç ve Bitiş belli olmalı
            2-Sonluluk (karşılaşılacak bütün olasılıklar bir sonuca varmalı)
            3-Kesinlik (çözüm adımları net anlaşılır ve açık olmalıdır.)
            4-Etkinlik (Modüler ve Genellenebilir kodlama)
            5-Verimilik (Performans,Zaman,Maliyet)



            ÇAY DEMLEME ALGORİTMASI
            1-Başla
            2-Mutfağa Git
            3-Çaydanlığa Su Koy
            4-Ocağı Yak
            5-Su Kaynadı Mı? T->7  F->6
            6-Bekle ->5
            7-Demliğe Çay Koy
            8-Çaydanlığa Su Koy
            9-Çay Demlendi Mi? T->11 F->10
            10-Bekle ->9
            11-Servis Et
            12-Bitti


            ** Su Yok
            ** Çay Yok


            1-Başla
            2-Mutfağa Git
            3-Su ve Çay Var Mı? T->9 F->4
            4-Bakkala Git
            5-Bakkal Açık Mı? T->7 F->6
            6-Başka Bakkala Git ->5
            7-Eksikleri Al
            8-Eve Dön ->2 
            9-Çaydanlığa Su Koy
            10-Ocağı Yak
            11-Su Kaynadı Mı? T->13  F->12
            12-Bekle ->11
            13-Demliğe Çay Koy
            14-Çaydanlığa Su Koy
            15-Çay Demlendi Mi? T->17 F->16
            16-Bekle ->15
            17-Servis Et
            18-Bitti



            ### EVDEN ÜÇÜNCÜ BİNYIL AKADEMİYE GİTME PROGRAMI ###
            1-Başla
            2-Daireden Çık
            3-Asansör Mü Merdiven Mi? A->4 M->11
            4-Asansör Katta Mı? T->6 F->5
            5-Asansörü Çağır ->4
            6-Asansöre Bin
            7-İstenilen Kat tuşuna Bas
            8-İstenilen Katta Mıyız? T->10 F->9
            9-Bekle ->8
            10-Asansörden İn ->13
            11-1 Kat İn
            12-İstenilen Katta Mıyız? F->11 T->13
            13-Binadan Çık


            14-Akbil Dolu Mu? T->17 F->15
            15-Dolum İstasyonuna Git
            16-Akbile Bakiye Yükle
            17-Durağa Git
            18-Hangi Toplu Taşımaya Binilecek? 14B
            19-Toplu Taşıma Geldi Mi? F->20 T->21
            20-Bekle ->19
            21-Toplu Taşımaya Bin
            22-Akbil Bas
            23-Boş Yer Var Mı? T->25 F->24
            24-Ayakta Git ->26
            25-Otur
            26-İstenile Durağına Geldik Mi? T->28 F->27
            27-Bekle ->26
            28-Toplu Taşımadan İn
            29-Akademiye Yürü
            30-Bitti
            
             
             
             ## EVDEN ÇÖP ATMA PROGRAMI
            1-Başla
            2-Daireden Çık
            3-Asansör Mü Merdiven Mi? A->4 M->11
            4-Asansör Katta Mı? T->6 F->5
            5-Asansörü Çağır ->4
            6-Asansöre Bin
            7-0 tuşuna Bas
            8-0. Katta Mıyız? T->10 F->9
            9-Bekle ->8
            10-Asansörden İn ->13
            11-1 Kat İn
            12-0.katta Mıyız? F->11 T->13
            13-Binadan Çık
            14-Kontaynere Git
            15-Çöp At
            16-Bitti



            ## MİSAFİR YOLCU ETME PROGRAMI
            1-Başla
            2-Daireden Çık
            3-Asansör Mü Merdiven Mi? A->4 M->11
            4-Asansör Katta Mı? T->6 F->5
            5-Asansörü Çağır ->4
            6-Asansöre Bin
            7-0 tuşuna Bas
            8-0. Katta Mıyız? T->10 F->9
            9-Bekle ->8
            10-Asansörden İn ->13
            11-1 Kat İn
            12-0.katta Mıyız? F->11 T->13
            13-Binadan Çık
            14-Güle Güle De
            15-Bitti

            ## MİSAFİR KARŞILAMA PROGRAMI
            1-Başla
            2-Daireden Çık
            3-Asansör Mü Merdiven Mi? A->4 M->11
            4-Asansör Katta Mı? T->6 F->5
            5-Asansörü Çağır ->4
            6-Asansöre Bin
            7-0 tuşuna Bas
            8-0. Katta Mıyız? T->10 F->9
            9-Bekle ->8
            10-Asansörden İn ->13
            11-1 Kat İn
            12-0.katta Mıyız? F->11 T->13
            13-Binadan Çık
            14-Hoşgeldin de 
            15-Bitti
             
             */

           

        }
    }
}
