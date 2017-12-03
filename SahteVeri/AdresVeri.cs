﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    public static class AdresVeri
    {
        static Random rnd = new Random();

        public static string SokakGetir()
        {
            string[] sokakDizi ={"1 NOLU DAMLA SK","101 NOLU SK","102 NOLU SK","103 NOLU SK","104 NOLU SK","105 NOLU SK","106 NOLU SK","107 NOLU SK","108 NOLU SK","110 NOLU SK","111 NOLU SK","112 NOLU SK","113 NOLU SK","114 NOLU SK","115 NOLU SK","116 NOLU SK","118 NOLU SK","120 NOLU SK","122 NOLU SK","124 NOLU SK","126 NOLU SK","128 NOLU SK","130 NOLU SK","19 MAYIS SK","2 NOLU DAMLA SK","201 NOLU SK","202 NOLU SK","203 NOLU SK","204 NOLU SK","205 NOLU SK","206 NOLU SK","207 NOLU SK","208 NOLU SK","209 NOLU SK","210 NOLU SK","211 NOLU SK","301 NOLU SK","302 NOLU SK","303 NOLU SK","304 NOLU SK","305 NOLU SK","306 NOLU SK","307 NOLU SK","308 NOLU SK","309 NOLU SK","310 NOLU SK","311 NOLU SK","313 NOLU SK","315 NOLU SK","401 NOLU SK","402 NOLU SK","403 NOLU SK","404 NOLU SK","405 NOLU SK","406 NOLU SK","407 NOLU SK","408 NOLU SK","409 NOLU SK","410 NOLU SK","411 NOLU SK","412 NOLU SK","413 NOLU SK","801 NOLU SK","802 NOLU SK","803 NOLU SK","804 NOLU SK","805 NOLU SK","806 NOLU SK","807 NOLU SK","808 NOLU SK","809 NOLU SK","810 NOLU SK","811 NOLU SK","812 NOLU SK","813 NOLU SK","814 NOLU SK","816 NOLU SK","817 NOLU SK","818 NOLU SK","819 NOLU SK","820 NOLU SK","902 NOLU SK","903 NOLU SK","904 NOLU SK","905 NOLU SK","906 NOLU SK","907 NOLU SK","908 NOLU SK","ABDULLAH SK","ACAR SK","ACIBADEM SK","ACISU SK","ADA SK","ADATEPE SK","ADEM SK","ADIM SK","ADRES SK","AHMET CAN BALİ SK","AHMET SK","AHSEN SK","AKAR SK","AKARSU SK","AKASYA SK","AKDENİZ SK","AKER SK","AKIM SK","AKIN SK","AKMEŞE SK","AKSU SK","AKTUĞ SK","AKTÜRK SK","BABAYİĞİT SK","ADEM SK","BAHADIR SK","BAHAR SK","BAHARDALI SK","BAHÇE SK","BAHÇECİK CAMİİ SK","BAHÇELİ SK","BAHÇIVANCI SK","BAK SK","BAKANER SK","BAKKAL ÇIKMAZI SK","BALABAN SK","BALIK SK","BALIKLI SK","BALIKPAZARI SK","BALIKYAĞI FABRİKA SK","BALIKÇILAR SK","BALKAYA SK","BALLICA SK","BALOĞLU SK","BALÖZÜ SK","BANKA ÇIKMAZI SK","BARINAK SK","BARIŞ SK","BARUTÇUOĞLU SK","BASAMAK SK","BASIN SİTESİ SK","BAYIR SK","BAYRAK SK","BAYRAKTAR SK","BAYRAM SK","BAYRAMBEY SK","BAĞIMSIZ SK","BAĞLARBAŞI SK","BAŞAK SK","BAŞAR SK","BAŞKAYA SK","BAŞKENT SK","BEBEK SK","BEKAROĞLU SK","BEKÇİ ALİ SK","BELDE SK","BEREKET SK","BESTE SK","BEYAZGÜL SK","BEŞEVLER SK","BEŞİKÇİ SK","BILDIRCIN SK","BOLLUK SK","BORA SK","BORSA SK","BOSTAN SK","BOTANİK SK","BOYLAM SK","BOZTEPE KAHYAOĞLU SK","BUDAK SK","BUHAR SK","BULUT SK","BULUŞ SK","CAN SK","CANAN SK","CANDAN SK","CEFA SK","CELEP SK","CEMRE SK","CEMİYET SK","CENK SK","CENNET SK","CEYHAN SK","CEYLAN SK","COŞANDERE SK","COŞKU SK","COŞKUNLAR SK","CUDİBEY MEKTEP SK","CÜMLE SK","CİHANGİR SK","CİVELEK SK","ÇABUK SK","ÇAKIR SK","ÇAKMAKÇILAR SK","ÇALIK SK","ÇALIKUŞU SK","ÇALIŞKAN SK","ÇAMLIBEL SK","ÇAMLIK CİVARI SK","DAMLA SK","DAYIOĞLU SK","DEDEOĞLU SK","DEFNE SK","DEKOR SK","DEMET SK","DEMOKRASİ SK","DEMİR SK","DEMİRCİLER SK","DEMİRKAPI SK","DENİZ SK","DENİZCİLER SK","DENİZGÜLÜ SK","DENİZHAN SK","DENİZKIZI SK","DERE SK","DEREBOYU SK","DERELİ SK","DEREOTU SK","DEREÜSTÜ SK","DEREİÇİ SK","DERGAH SK","DERMAN SK","DERVİŞOĞLU SK","EDALI SK","EFE SK","EFLATUN SK","EFSANE SK","EKOL SK","EKİN SK","ELEMAN SK","ELMALI SK","ELMAS SK","ELVAN SK","ELİF SK","EMEKTAR SK","EMEKÇİLER SK","EMRE KARAAĞAÇLI SK","EMRE SK","EMRULLAH SK","EMSAL SK","EMİN ALEMDAR SK","EMİN SK","EMİR SK","EMİRGAN SK","ENDER SK","ENDÜSTRİ SK","ENSAR SK","ENİŞTE AHMET SK","ERDEM SK","ERDEMLİ SK","ERDOĞDU UZUN SK","EREN SK","ERENLER SK","ERİŞKİN SK","ERİŞİM SK","SEN SK","ESENLER SK","ESENYALI SK","ESENYURT SK","ESER SK","ESKİ DEMİRCİLER SK","ESKİ MEKTEP ARALIĞI SK","FAVORİ SK","FENERCİLER SK","FENERLİ SK","FERAH SK","FESTİVAL SK","FEZA SK","FIRAT SK","FUNDA SK","FİDAN SK","FİDANLIK SK","FİKİR SK","FİKİRTEPE SK","FİRUZE SK","GAMLI SK","GAMZE SK","GANİTA SK","GAZİPAŞA ÇAYIR SK","GEDİKLİ MAHMUT SK","GEDİKLİ REMZİ SK","GEDİKLİ SK","GELİNCİK SK","GELİŞİM SK","GENÇOĞLU SK","GEYİKLİ SK","GEÇİT SK","GOLOĞLU SK","GONCA SK","GURBET SK","GURUR SK","GÖKKUŞAĞI SK","GÖKTAŞ SK","GÖKÇE SK","GÖKÇEDENİZ SK","GÖNÜL SK","GÖRKEM SK","GÖZLEM SK","GÜL SK","GÜLBAHÇE SK","GÜLER SK","GÜLGAZİ SK","GÜLGÖNÜL SK","GÜLHAN SK","GÜLİSTAN SK","GÜMÜŞ SK","GÜMÜŞDERE SK","GÜNDÜZ SK","GÜNEY SK","GÜNEŞ SK","GÜNEŞTEPE SK","GÜNGÖREN SK","GÜRPINAR SK","GÜVEN SK","GÜVERCİN SK","GÜZEL SK","GÜZELBAHÇE SK","GÜZELCE SK","GÜZELTEPE SK","GÜZİDE SK","GİŞE SK","HACI AHMET SK","HACI ARİF HAMAM SK","HACI KAŞİF SK","HACI MUSTAFA SK","HACI VEHBİ EFENDİ SK","HACIOĞLU SK","HAFIZ AHMET SK","HALK SK","HALKEVİ SK","HALLAÇOĞLU SK","HALİDE EDİP ADIVAR SK","HAMAMİZADE SK","HANECİ SK","HANEDAN SK","HANIMELİ SK","HARMAN SK","HASAN BAŞ ÇIKMAZ SK","HASAN TAHSİN SK","HASAN ÇAVUŞ SK","HASANPAŞA SK","HASRET SK","HASTAHANE CİVARI SK","HATIRA SK","HATUNCUK CAMİİ SK","HATİP CAMİİ SK","HAVADAR SK","HAŞMET SK","HAŞİM SK","HAŞİMOĞLU SK","HEKİMLER SK","HEYBETLİ SK","HIZIR SK","HOŞ SK","HUZURLU SK","HÜRMET SK","HÜSAMOĞLU SK","HÜSAMOĞLU ÇIKMAZ SK","HÜSEYİN KAZAZOĞLU SK","HİDAYET SK","HİLAL SK","HİSAR SK","IHLAMUR SK","ISLAHANE SK","IŞIK SK","IŞIL SK","İBNİ SİNA SK","İBRAHİM ÇIKMAZI SK","İBİŞOĞLU SK","İBŞİROĞLU ÇIKMAZI SK","İDEAL SK","İFADE SK","İFTİHAR SK","İHLAS SK","İKRAM SK","İKİ ÇEŞME SK","İLHAM SK","İLKADIM SK","İLKE SK","İLLER SK","KABİR SK","KABİNE SK","KADIOĞLU SK","KADİFE SK","KAFKAS SK","KAHRAMAN ÇIKMAZ SK","KAHYAOĞLU SK","KAKTÜS SK","KALAFATOĞLU SK","KALAYCIOĞLU SK","KALCIOĞLU SK","KALCIYA CİVARI SK","KALE ALTI SK","KALEKAPI SK","KALEKAPISI YOKUŞU SK","KALEM SK","KALFA SK","KALHANE SK","KALITIM SK","KALORİ SK","KALİTE SK","KARAKAŞ SK","KARAKAŞ ÇIKMAZI SK","KARAKOLHANE SK","KARANFİL SK","KARAYEMİŞ SK","KARBEYAZ SK","KAŞ SK","KAŞANBUR SK","KEHRİBAR SK","KELEBEK SK","KEMER SK","KEMERALTI SK","KEMERLİDERE KAPTAN SK","KENANOĞLU SK","KENT SK","KERPİÇ SK","KERVAN SK","KEVSER SK","KEÇECİOĞLU SK","KUDRETTİN CAMİİ SK","KUKULTAŞ SK","KULOĞLU SK","KÜLLAÇ SK","KÜPELİ SK","KÜÇÜK SANAYİ SK","KÜÇÜK SK","LAKOTOĞLU SK","LALE SK","LATİFLİ SK","LEVENT SK","LEYLAK SK","LOJMAN SK","LÜTFULLAH SK","LİMAN SK","LİMONLU SK","LİMONLU ÇIKMAZI SK","LİSE SK","MADEN SK","MAKBER SK","MALKOÇ DEREİÇİ SK","MALKOÇOĞLU ÇIKMAZ SK","MANOLYA SK","MANZARALI SK","MARANGOZ SK","MARTI SK","MELTEM SK","MEMİŞ ÇIKMAZ SK","MENEKŞE SK","MENZİL SK","MERCAN SK","MEYDAN CAMİİ SK","MEYDAN HAMAM SK","MEYDANCIK SK","MORA SK","MORGÜL SK","MUAZZAM SK","MÜCAHİT SK","MÜEZZİN SK","MÜFTÜ CAMİİ SK","MİNİ SK","NADİDE SK","NAME SK","NANELİ SK","NARLI SK","NARLIBAHÇE SK","NARÇİÇEĞİ SK","NEMLİOĞLU CEMAL SK","NERGİS SK","NEŞE SK","NUHOĞLU SK","NURGÜL SK","NİLÜFER SK","NİMET SK","NİSA SK","NİSAN SK","NİYET SK","OCAK SK","ORTANCA SK","OSMAN NURİ AYDEMİR SK","OYA SK","OZAN SK","ÖMER HAYALİ SK","ÖMER TERZİ SK","ÖMÜR SK","ÖNDER SK","ÖRNEK SK","ÖZ SK","ÖZBAK SK","ÖZDEN SK","ÖZEL SK","ÖZGÜRLÜK SK","ÖZLENEN SK","ÖZLÜ SK","ÖZTÜRK SK","ÖZYURT SK","ÖĞRETMEN MEKTEP SK","ÖĞRETİM SK","PALMİYE SK","PAMUKDEDE SK","PAPATYA SK","PARK SK","PAZAR SK","PAZARYOLU SK","PAŞAHAMAM ARALIĞI SK","PAŞAHAMAM GEÇİDİ SK","PAŞAHAMAM SK","PAŞALIOĞLU SK","PEHLİVAN SK","PELİN SK","PELİNSU SK","PEMBE SK","PERTEVPAŞA SK","PETEK SK","PINAR SK","PINARBAŞI SK","POYRAZ SK","PİKNİK SK","PİLOT SK","PİROĞLU ÇIKMAZ SK","RAFİNE SK","RAHMET SK","RAMPA SK","REFORM SK","REHBER SK","REKABET SK","REİS SK","RIHTIM SK","RÜZGARLI SK","RÜZGARLIBAHÇE SK","SAAT SK","SAATÇI MEHMET SK","SABAH SK","SABIR SK","SAHRA SK","SAKA SK","SAKALLIOĞLU SK","SAKİN SK","SALI SK","SALKIM SK","SEDEF SK","SEDİR SK","SEFA SK","SELVA SK","SELVİ SK","SELÇUK AKYOL SK","SELİM SK","SEYFETTİN SK","SEYHAN SK","SEZER SK","SEÇKİN SK","SEÇİM SK","SILA SK","SOFOĞLU SK","SONBAHAR SK","SONGÜL SK","SOYLU SK","SOĞANLI SK","SOĞUK ÇEŞME SK","SÖKMEN SK","SÖNMEZ SK","SÖĞÜT SK","SİRKECİLER YALIHAN SK","SİTE SK","SİYAMOĞLU SK","ŞADIRVAN SK","ŞAFAK SK","ŞAHİN SK","ŞAHİNKAYA SK","ŞAİR SK","ŞEFKAT SK","ŞEHİR SK","ŞEHİT BOZDAĞ SK","ŞEHİT MEHMET ÇAKIR SK","ŞEHİT SK","ŞEHİTBABA SK","ŞEKER SK","ŞELALE SK","ŞENKAYA SK","ŞENLİK SK","ŞEREF SK","ŞH.ASTĞM.COŞKUN DAVULCU SK","ŞİFA SK","ŞİRİN HATUN SK","ŞİRİN SK","ŞİRİNTEPE SK","TABAKHANE SK","TABAKLAR SK","TABYA SK","TABİP SK","TAFLAN SK","TAHTALI CAMİİ SK","TAKSİM HARKI SK","TAKVİM SK","TALİH SK","TARAKÇILAR SK","TARIM SK","TOMURCUK SK","TOPAL HAKİM SK","TOPHANE CAMİİ SK","TOPHANE HAMAM SK","TOPRAK SK","TOPÇUOĞLU SK","TOROS SK","TOYGAROĞLU SK","TRT SK","TUFAN SK","TUNA SK","TUNCAY SK","TUNÇ SK","TURAN SK","TURNA SK","TUZLU ÇEŞME SK","TÜRBE SK","TÜRKOĞLU SK","TÜTÜN SK","TİCARET MEKTEP SK","TİCARET SK","TİYATRO SK","UFUK SK","ULAŞ SK","ULUS SK","USTA SK","USTAOĞLU SK","UYGAR SK","UYGUR SK","UZUN SK","UZUN İBRAHİMOĞLU SK","UZUNOĞLU SK","UĞUR SK","UĞURLU SK","UĞURLUSİ SK","ÜMİT SK","ÜNLÜ SK","ÜNVER SK","ÜRÜN SK","ÜSTAD SK","ÜSTÜN SK","ÜZÜMLÜ SK","VAKIFLAR SK","VALİDE SK","VARIŞ SK","VEDA SK","VEFA SK","VEFAKAR SK","VELİ SK","VERİMLİ SK","VOLKAN SK","VUSLAT SK","VİLLA SK","VİŞNE SK","YABANGÜLÜ SK","YADİGAR SK","YAHYA REİS SK","YAKAMOZ SK","YAKUP REİSOĞLU SK","YAKUT SK","YALDIZ SK","YALI ARALIĞI SK","YALÇIN SK","YALÇINKAYA SK","YAMAÇ SK","YAN SK","YANIK HASAN REİS SK","YANKI SK","YAPRAK SK","YAREN SK","YARIMBIYIK SK","YASEMİN SK","YAVUZ SK","YAYA SK","YAYLA SK","YAZAR SK","YAZICIOĞLU SK","YAZMA SK","YAZMALI SK","YAĞMUR SK","YELKEN SK",
           "YEMEN SK","YENER SK","YENİ SK","YENİCE SK","YENİCUMA CAMİİ ÇIKMAZI SK","YENİCUMA İZİR K3ÜK SK","YENİDÜNYA SK","YENİGÜN SK","YERLİCE SK","YETENEKLİ SK","YEŞİLIRMAK SK","YOL SK","YOLDAŞ SK","YURTTAŞ SK","YUSUFOĞLU SK","YUVA SK","YÜCE SK","YÜNCÜLER SK","YÜZBAŞI EMRULLAH SK","YÜZÜK SK","YİĞİT SK","ZAFER SK","ZAFERİ SK","ZAKKUM SK","ZAMBAK SK","ZARİF SK","ZAĞNOS DEREİÇİ SK","ZAİMOĞLU SK","ZEKİ SK","ZERAFET SK","ZIVALIOĞLU SK","ZÜHRE SK","ZÜMRÜT SK","ZİHİN SK","ZİNCİRLİÇEŞME SK","ZİRAAT SK","ZİRVE SK","ZİVER SK","ZİYAD NEMLİ SANAT SK","ZİYAFET SK","ZİYARET SK" };
            int s = rnd.Next(0, sokakDizi.Length);
            return sokakDizi[s];
        }
        public static string CaddeGetir()
        {
            string[] caddeDizi ={"VATAN CD","BAĞDAT CD","MANOLYA CD","BİLGİN CD","ALEMDAĞ CD","İSTİKLAL CD","DAR CD","FATİH CD",
                "OKUL CD","SAĞLIK CD","MEVLANA CD","GÜL CD","GÜVEN CD","MENEKŞE CD","SEVGİ CD","ÇİÇEK CD","SAYGILI CD","HARMAN CD",
                "YUNUS EMRE CD","BARIŞ CD","NALBANT CD","AVCILAR CD","CEVİZLİ CD","DEĞİRMEN CD","DERE CD ","KEKLİK CD",
                "BAYIR CD","BAYRAK CD","CUMHURİYET CD","KURTULUŞ CD","SARIKAYA CD","UMUT CD","PAPATYA CD","MISIR CD","SARIYER CD",
                "PAPATYA CD","SARAY CD","PİYADE CD","HALİS CD","DEMİR CD","FAYDA CD","HİCRET CD","MALTEPE CD","EFENDİ CD","HACI CD"
                , "LALE CD","BAYEZİT CD","YILDIZ CD","AYDIN CD","FENER CD","AFFAN CD"," KİTAPÇIOĞLU CD","AHMET SUAT ÖZYAZICI CD","AKAY CD","AKİF SARUHAN CD","ALTINŞEHİR CD","ALİ NACİ PEKER CD","ATA CD","AYASOFYA CD","BARBOROS CD","BARIŞ CD","BAYINDIR CD","BEDESTAN CD","BOZTEPE CD","BURLA HATUN CD","BUZLUDERE CD","CEMİL USTA CD","COŞKUNDERE CD","CUMA CD","CUMHURİYET CD","ÇAMLICA CD","ÇAMLIK CD","ÇAMOBA CD","ÇUKURÇAYIR YOLU CD","ÇÖMLEKÇİ CD","DERYA CD","DEVLET KARAYOLU CD","DEVLET SAHİL YOLU CD","DEĞİRMEN CD","DEĞİRMENDERE CD","DOKTOR İBRAHİM OKMAN CD","DR MEHMET İBRAHİM CD","ECDAT SK","ELGAFDERE CD","EMEK CD","ERZURUM YOLU CD","EVLİYA CD","EVİM CD","EYÜBOĞLU CD","EĞİTİM CD","EŞREF BİTLİS CD","FARABİ CD","FATİH CD","FAİK AHMET BARUTÇU CD","FAİK DRANAZ CD","GAZİ CD","GAZİ MUSTAFA KEMAL CD","GAZİPAŞA CD","GENÇLİK CD","GÜVELİOĞLU CD","GÜZELHİSAR CD","HACI ZİYA HABİBOĞLU CD","HAKİMİYET CD","HARİTA CD","HASAN SAKA CD","HASTAHANE CD","HAYAT CD","HORON CD","HUZUR CD","HÜRRİYET CD","HİZMET CD","İBRAHİM ALEMDAĞ CD","İNÖNÜ CD","İPEKYOLU CD","İRAN CD","KADER CD","KAHRAMANMARAŞ CD","KALKANOĞLU CD","KARLIK CD","KARTALTEPE CD","KARŞIYAKA CD","KAYMAKLI CD","KINALITAŞ CD","KONAK CD","KUNDURACILAR CD","KURAN KURSU CD","KUZGUNDERE CD","KÖSEOĞLU CD","KÖŞK CD","KÜLTÜR CD","KİSARNA CD","MAHMUT GOLOĞLU CD","MOLOZ CD","MUHTAR COŞKUN KARAAĞAÇLI CD","MUSTAFA ALEMDAĞ CD","MİLLİ EGEMENLİK CD","MİMAR SİNAN CD","NAZLICAN CD","NURETTİN DOĞAN CD","ÖZGÜR CD","ÖZLEM CD","ÖĞRETMEN ÖMER ÇEBİ CD","PROF.OSMAN TURAN CD","PULATHANE CD","PİRİ REİS CD","SANAYİ ÇARŞISI CD","SEFER ÖZGÜR CD","SEMERCİLER CD","SERDAR CD","SEYRAN CD","SEYRANTEPE CD","SEZAİ UZAY CD","SOĞUKSU CD","SUAT OYMAN CD","ŞENOL GÜNEŞ CD","ŞH.ASTĞM.ORHAN SANCAR CD","ŞH.AYHAN İNCEKARA CD","ŞH.OSMAN ERTOSUN CD","ŞH.REFİK CESUR CD","ŞH.İBRAHİM KARAOĞLANOĞLU CD","TAKSİM CD","TELSİZTEPE CD","VATAN CD","YALI CD","YAŞAM CD","YENİ CAMİ CD","YENİCUMA CD","YEŞİL CD","YİRMİ4 ŞUBAT CD","ZAFANOZ CD","ZAĞNOS CD","ZEYTİNLİK CD","ZÜBEYDA HANIM CD"
 };
            int s = rnd.Next(0, caddeDizi.Length);
            return caddeDizi[s];
        }
        public static string İlceGetir()
        {
            string[] ilce = { "Aladağ", "Ceyhan", "Çukurova", "Feke", "İmamoğlu", "Karaisalı", "Karataş", "Kozan", "Pozantı", "Saimbeyli", "Sarıçam", "Seyhan", "Tufanbeyli", "Yumurtalık", "Yüreğir", "Adıyaman", "Besni", "Çelikhan", "Gerger", "Gölbaşı", "Kahta", "Samsat", "Sincik", "Tut", "Afyonkarahisar", "Başmakçı", "Bayat", "Bolvadin", "Çay", "Çobanlar", "Dazkırı", "Dinar", "Emirdağ", "Evciler", "Hocalar", "İhsaniye", "İscehisar", "Kızılören", "Sandıklı", "Sinanpaşa", "Sultandağı", "Şuhut", "Ağrı", "Diyadin", "Doğubeyazıt", "Eleşkirt", "Hamur", "Patnos", "Taşlıçay", "Tutak", "Ağaçören", "Aksaray", "Eskil", "Gülağaç", "Güzelyurt", "Ortaköy", "Sarıyahşi", "Amasya", "Göynücek", "Gümüşhacıköy", "Hamamözü", "Merzifon", "Suluova", "Taşova", "Akyurt", "Altındağ", "Ayaş", "Bala", "Beypazarı", "Çamlıdere", "Çankaya", "Çubuk", "Elmadağ", "Etimesgut", "Evren", "Gölbaşı", "Güdül", "Haymana", "Kalecik", "Kazan", "Keçiören", "Kızılcahamam", "Mamak", "Nallıhan", "Polatlı", "Pursaklar", "Sincan", "Şereflikoçhisar", "Yenimahalle", "Akseki", "Aksu", "Alanya", "Döşemealtı", "Elmalı", "Finike", "Gazipaşa", "Gündoğmuş", "İbradi", "Kale", "Kaş", "Kemer", "Kepez", "Konyaaltı", "Korkuteli", "Kumluca", "Manavgat", "Muratpaşa", "Serik", "Ardahan", "Çıldır", "Damal", "Göle", "Hanak", "Posof", "Ardanuç", "Arhavi", "Artvin", "Borçka", "Hopa", "Murgul", "Şavşat", "Yusufeli", "Aydın", "Bozdoğan", "Buharkent", "Çine", "Didim", "Germencik", "İncirliova", "Karacasu", "Karpuzlu", "Koçarlı", "Köşk", "Kuşadası", "Kuyucak", "Nazilli", "Söke", "Sultanhisar", "Yenipazar", "Ayvalık", "Balıkesir", "Balya", "Bandırma", "Bigadiç", "Burhaniye", "Dursunbey", "Edremit", "Erdek", "Gömeç", "Gönen", "Havran", "İvrindi", "Kepsut", "Manyas", "Marmara", "Savaştepe", "Sındırgı", "Susurluk", "Amasra", "Bartın", "Kurucaşile", "Ulus", "Batman", "Beşiri", "Gercüş", "Hasankeyf", "Kozluk", "Sason", "Aydıntepe", "Bayburt", "Demirözü", "Bilecik", "Bozüyük", "Gölpazarı", "İnhisar", "Osmaneli", "Pazaryeri", "Söğüt", "Yenipazar", "Adaklı", "Bingöl", "Genç", "Karlıova", "Kiğı", "Solhan", "Yayladere", "Yedisu", "Adilcevaz", "Ahlat", "Bitlis", "Güroymak", "Hizan", "Mutki", "Tatvan", "Bolu", "Dörtdivan", "Gerede", "Göynük", "Kıbrıscık", "Mengen", "Mudurnu", "Seben", "Yeniçağa", "Ağlasun", "Altınyayla", "Bucak", "Burdur", "Çavdır", "Çeltikçi", "Gölhisar", "Karamanlı", "Kemer", "Tefenni", "Yeşilova", "Büyükorhan", "Gemlik", "Gürsu", "Harmancık", "İnegöl", "İznik", "Karacabey", "Keles", "Kestel", "Mudanya", "Mustafakemalpaşa", "Nilüfer", "Orhaneli", "Orhangazi", "Osmangazi", "Yenişehir", "Yıldırım", "Ayvacık", "Bayramiç", "Biga", "Bozcaada", "Çan", "Çanakkale", "Eceabat", "Ezine", "Gelibolu", "Gökçeada", "Lapseki", "Yenice", "Atkaracalar", "Bayramören", "Çankırı", "Çerkeş", "Eldivan", "Ilgaz", "Kızılırmak", "Korgun", "Kurşunlu", "Orta", "Şabanözü", "Yapraklı", "Alaca", "Bayat", "Boğazkale", "Çorum", "Dodurga", "İskilip", "Kargı", "Laçin", "Mecitözü", "Oğuzlar", "Ortaköy", "Osmancık", "Sungurlu", "Uğurludağ", "Acıpayam", "Akköy", "Babadağ", "Baklan", "Bekilli", "Beyağaç", "Bozkurt", "Buldan", "Çal", "Çameli", "Çardak", "Çivril", "Denizli", "Güney", "Honaz", "Kale", "Sarayköy", "Serinhisar", "Tavas", "Bağlar", "Bismil", "Çermik", "Çınar", "Çüngüş", "Dicle", "Eğil", "Ergani", "Hani", "Hazro", "Kayapınar", "Kocaköy", "Kulp", "Lice", "Silvan", "Sur", "Yenişehir", "Akçakoca", "Cumayeri", "Çilimli", "Düzce", "Gölyaka", "Gümüşova", "Kaynaşlı", "Yığılca",
"Edirne","Enez","Havsa","İpsala","Keşan","Lalapaşa","Meriç","Süloğlu","Uzunköprü","Ağın","Alacakaya","Arıcak","Baskil","Elazığ","Karakoçan","Keban","Kovancılar","Maden","Palu","Sivrice","Çayırlı","Erzincan","İliç","Kemah","Kemaliye","Otlukbeli","Refahiye","Tercan","Üzümlü","Aşkale","Aziziye","Çat","Hınıs","Horasan","İspir","Karaçoban","Karayazı","Köprüköy","Narman","Oltu","Olur","Palandöken","Pasinler","Pazaryolu","Şenkaya","Tekman","Tortum","Uzundere","Yakutiye","Alpu","Beylikova","Çifteler","Günyüzü","Han","İnönü","Mahmudiye","Mihalgazi","Mihalıççık","Odunpazarı","Sarıcakaya","Seyitgazi","Sivrihisar","Tepebaşı","Araban","İslahiye","Karkamış","Nizip","Nurdağı","Oğuzeli","Şahinbey","Şehitkamil","Yavuzeli","Alucra","Bulancak","Çamoluk","Çanakçı","Dereli","Doğankent","Espiye","Eynesil","Giresun","Görele","Güce","Keşap","Piraziz","Şebinkarahisar","Tirebolu","Yağlıdere","Gümüşhane","Kelkit","Köse","Kürtün","Şiran","Torul","Çukurca","Hakkâri","Şemdinli","Yüksekova","Altınözü","Antakya","Belen","Dörtyol","Erzin","Hassa","İskenderun","Kırıkhan","Kumlu","Reyhanlı","Samandağ","Yayladağı","Aralık","Iğdır","Karakoyunlu","Tuzluca","Aksu","Atabey","Eğirdir","Gelendost","Gönen","Isparta","Keçiborlu","Senirkent","Sütçüler","Şarkikaraağaç","Uluborlu","Yalvaç","Yenişarbademli","Adalar","Arnavutköy","Ataşehir","Avcılar","Bağcılar","Bahçelievler","Bakırköy","Başakşehir","Bayrampaşa","Beşiktaş","Beykoz","Beylikdüzü","Beyoğlu","Büyükçekmece","Çatalca","Çekmeköy","Esenler","Esenyurt","Eyüp","Fatih","Gaziosmanpaşa","Güngören","Kadıköy","Kağıthane","Kartal","Küçükçekmece","Maltepe","Pendik","Sancaktepe","Sarıyer","Silivri","Sultanbeyli","Sultangazi","Şile","Şişli","Tuzla","Ümraniye","Üsküdar","Zeytinburnu","Aliağa","Balçova","Bayındır","Bayraklı","Bergama","Beydağ","Bornova","Buca","Çeşme","Çiğli","Dikili","Foça","Gaziemir","Güzelbahçe","Karabağlar","Karaburun","Karşıyaka","Kemalpaşa","Kınık","Kiraz","Konak","Menderes","Menemen","Narlıdere","Ödemiş","Seferihisar","Selçuk","Tire","Torbalı","Urla","Afşin","Andırın","Çağlayancerit","Ekinözü","Elbistan","Göksun","Kahramanmaraş","Nurhak","Pazarcık","Türkoğlu","Eflani","Eskipazar","Karabük","Ovacık","Safranbolu","Yenice","Ayrancı","Başyayla","Ermenek","Karaman","Kazımkarabekir","Sarıveliler","Akyaka","Arpaçay","Digor","Kağızman","Kars","Sarıkamış","Selim","Susuz","Abana","Ağlı","Araç","Azdavay","Bozkurt","Cide","Çatalzeytin","Daday","Devrekani","Doğanyurt","Hanönü","İhsangazi","İnebolu","Kastamonu","Küre","Pınarbaşı","Seydiler","Şenpazar","Taşköprü","Tosya","Akkışla","Bünyan","Develi","Felahiye","Hacılar","İncesu","Kocasinan","Melikgazi","Özvatan","Pınarbaşı","Sarıoğlan","Sarız","Talas","Tomarza","Yahyalı","Yeşilhisar","Bahşılı","Balışeyh","Çelebi","Delice","Karakeçili","Keskin","Kırıkkale","Sulakyurt","Yahşihan","Babaeski","Demirköy","Kırklareli","Kofçaz","Lüleburgaz","Pehlivanköy","Pınarhisar","Vize","Akçakent","Akpınar","Boztepe","Çiçekdağı","Kaman","Kırşehir","Mucur","Elbeyli","Kilis","Musabeyli","Polateli","Başiskele","Çayırova","Darıca","Derince","Dilovası","Gebze","Gölcük","İzmit","Kandıra","Karamürsel","Kartepe","Körfez","Ahırlı","Akören","Akşehir","Altınekin","Beyşehir","Bozkır","Cihanbeyli","Çeltik","Çumra","Derbent","Derebucak","Doğanhisar","Emirgazi","Ereğli","Güneysınır","Hadım","Halkapınar","Hüyük","Ilgın","Kadınhanı","Karapınar","Karatay","Kulu","Meram","Sarayönü","Selçuklu","Seydişehir","Taşkent","Tuzlukçu","Yalıhüyük","Yeniceoba","Yunak","Altıntaş","Aslanapa","Çavdarhisar","Domaniç","Dumlupınar","Emet","Gediz","Hisarcık","Kütahya","Pazarlar","Şaphane","Simav","Tavşanlı","Akçadağ","Arapgir","Arguvan","Battalgazi","Darende","Doğanşehir","Doğanyol","Hekimhan","Kale","Kuluncak","Malatya","Pütürge","Yazıhan","Yeşilyurt","Gürün","Ahmetli","Akhisar","Alaşehir","Demirci","Gölmarmara","Gördes","Kırkağaç","Köprübaşı","Kula","Manisa","Salihli","Sarıgöl","Saruhanlı","Selendi","Soma","Turgutlu","Dargeçit","Derik","Kızıltepe","Mardin","Mazıdağı","Midyat","Nusaybin","Ömerli","Savur","Yeşilli","Akdeniz","Anamur","Aydıncık","Bozyazı","Çamlıyayla","Erdemli","Gülnar","Mezitli","Mut","Silifke","Tarsus","Toroslar","Yenişehir","Bodrum","Dalaman","Datça","Fethiye","Kavaklıdere","Köyceğiz","Marmaris","Milas","Muğla","Ortaca","Ula","Yatağan","Bulanık","Hasköy","Korkut","Malazgirt","Muş","Varto","Acıgöl","Avanos","Derinkuyu","Gülşehir","Hacıbektaş","Kozaklı","Nevşehir","Ürgüp","Altunhisar","Bor","Çamardı","Çiftlik","Niğde","Ulukışla","Akkuş","Aybastı","Çamaş","Çatalpınar","Çaybaşı","Fatsa","Gölköy","Gülyalı","Gürgentepe","İkizce","Kabadüz","Kabataş","Korgan","Kumru","Mesudiye","Ordu","Perşembe","Ulubey","Ünye","Bahçe","Düziçi","Hasanbeyli","Kadirli","Osmaniye","Sumbas","Toprakkale","Ardeşen","Çamlıhemşin","Çayeli","Derepazarı","Fındıklı","Güneysu","Hemşin","İkizdere","İyidere","Kalkandere","Pazar","Rize","Adapazarı","Akyazı","Arifiye","Erenler","Ferizli","Geyve","Hendek","Karapürçek","Karasu","Kaynarca","Kocaali","Pamukova","Sapanca","Serdivan","Söğütlü","Taraklı","Alaçam","Asarcık","Atakum","Ayvacık","Bafra","Canik","Çarşamba","Havza","İlkadım","Kavak","Ladik","Ondokuzmayıs","Salıpazarı","Tekkeköy","Terme","Vezirköprü","Yakakent","Aydınlar","Baykan","Eruh","Kurtalan","Pervari","Siirt","Şirvan","Ayancık","Boyabat","Dikmen","Durağan","Erfelek","Gerze","Saraydüzü","Sinop","Türkeli","Akıncılar","Altınyayla","Divriği","Doğanşar","Gemerek","Gölova","Hafik","İmranlı","Kangal","Koyulhisar","Sivas","Suşehri","Şarkışla","Ulaş","Yıldızeli","Zara","Gürün","Akçakale","Birecik","Bozova","Ceylanpınar","Halfeti","Harran","Hilvan","Şanlıurfa","Siverek","Suruç","Viranşehir","Beytüşşebap","Cizre","Güçlükonak","İdil","Silopi","Şırnak","Uludere","Çerkezköy","Çorlu","Hayrabolu","Malkara","Marmara Ereğlisi","Muratlı","Saray","Şarköy","Tekirdağ","Almus","Artova","Başçiftlik","Erbaa","Niksar","Pazar","Reşadiye","Sulusaray","Tokat","Turhal","Yeşilyurt","Zile","Akçaabat","Araklı","Arsin","Beşikdüzü","Çarşıbaşı","Çaykara","Dernekpazarı","Düzköy","Hayrat","Köprübaşı","Maçka","Of","Sürmene","Şalpazarı","Tonya","Trabzon","Vakfıkebir","Yomra","Çemişgezek","Hozat","Mazgirt","Nazimiye","Ovacık","Pertek","Pülümür","Tunceli","Banaz","Eşme","Karahallı","Sivaslı","Ulubey","Uşak","Bahçesaray","Başkale","Çaldıran","Çatak","Edremit","Erciş","Gevaş","Gürpınar","Muradiye","Özalp","Saray","Van","Altınova","Armutlu","Çınarcık","Çiftlikköy","Termal","Yalova","Akdağmadeni","Aydıncık","Boğazlıyan","Çandır","Çayıralan","Çekerek","Kadışehri","Saraykent","Sarıkaya","Sorgun","Şefaatli","Yenifakılı","Yerköy","Yozgat","Alaplı","Çaycuma","Devrek","Gökçebey","Kilimli","Kozlu","Karadeniz Ereğli","Zonguldak" };
            return ilce[rnd.Next(0, ilce.Length)];
        }
        public static string SehirGetir()
        {
            string[] sehirDizi = {"İstanbul","Ankara","İzmir", "Adana", "Adıyaman", "Afyonkarahisar",
                "Ağrı", "Aksaray", "Amasya" ,"Antalya", "Ardahan",
                "Artvin","Aydın", "Balıkesir","Bartın", "Batman","Bayburt","Bilecik" ,"Bingöl" ,"Bitlis",
                "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı" ,"Çorum"," Denizli", "Diyarbakır ","Düzce",
                "Edirne","Elazığ", "Erzincan","Erzurum","Eskişehir","Gaziantep","Giresun","Gümüşhane",
                "Hakkari","Hatay","Iğdır","Isparta" ,"Kahramanmaraş","Karabük","Karaman","Kars",
                "Kastamonu","Kayseri","Kırıkkale","Kırklareli","Kırşehir", "Kilis","Kocaeli",
                "Konya","Kütahya","Malatya","Manisa","Mardin","Mersin", "Muğla", "Muş" ,"Nevşehir" ,"Niğde",
                "Ordu", "Osmaniye","Rize", "Sakarya", "Samsun", "Siirt", "Sinop" ,"Sivas" ,"Şırnak" ,"Tekirdağ",
                "Tokat" ,"Trabzon" ,"Tunceli", "Şanlıurfa", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };
            int s = rnd.Next(0, sehirDizi.Length);
            return sehirDizi[s];
        }
        public static string NumaraGetir()
        {
            int s1 = rnd.Next(1, 20);
            int s2 = rnd.Next(1, 20);
            return (s1 + "/" + s2);
        }
    }
}