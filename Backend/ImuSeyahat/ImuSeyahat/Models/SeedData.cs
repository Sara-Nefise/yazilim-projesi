using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImuSeyahat.Models
{
    public static class SeedData
    {
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>().HasData(
                new Place
                {
                    PlaceId = 1,
                    PlaceName = "Galata Kulesi",
                    CityName = "Istanbul",
                    PlaceAdress = "Bereketzade 34421 Beyoğlu Istanbul",
                    PhoneNumber = "5555555555",
                    PlaceEmail = "galatakulesi@gmail.com",
                    OpeningTime = "08:00",
                    ClosingTime = "23:59",
                    EntranceFee = 100,
                    PlaceDescription = "Eski Galata Kulesi, 528 yılında Bizans İmparatoru Anastasius tarafından fener kulesi olarak inşa edilmiştir. Ancak bu kule 1202-1204 yılları arasındaki Dördüncü Haçlı Seferleri sırasında İstanbul’u ele geçiren ve yağmalayan Latinler tarafından büyük oranda zarar görmüş ve yıkılmıştır. Bugün Galata Kulesi’nin bulunduğu yere yakın bir bölgeye inşa edilmiş olan kule bazı kaynaklarda bugünkü kule olarak gösterilse de bu yanlıştır.",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Galata_Tower_after_the_2020_restoration.jpg/270px-Galata_Tower_after_the_2020_restoration.jpg"
                },
                new Place
                {
                    PlaceId = 2,
                    PlaceName = "Sultanahmet Camii",
                    CityName = "Istanbul",
                    PlaceAdress = "Atmeydaný Cd. No:7 34122 Fatih/Istanbul",
                    PhoneNumber = "6666666666",
                    PlaceEmail = "sultanahmetcami@gmail.com",
                    OpeningTime = "09:00",
                    ClosingTime = "23:59",
                    EntranceFee = 0,
                    PlaceDescription = "Sultanahmet Camii, Osmanlı Sultanı I. Ahmet tarafından 1609 – 1616 tarihleri arasında yaptırılmıştır. Klâsik Türk sanatının en tipik örneği olan eser, orijinal olarak 6 minare ile inşa edilen ilk camidir. Mimar Sinan'ın eserlerinden biri olmadığı halde bu yapı Sinan'dan izler taşımaktadır. Sinan’ın öğrencisi Mimar Sedefkâr Mehmet Ağa, söylenene göre, camiyi inşa ederken, üstadının daha önce denediği bir planı daha büyük bir ölçüde uygulamıştır.",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/Exterior_of_Sultan_Ahmed_I_Mosque_in_Istanbul%2C_Turkey_002.jpg/1280px-Exterior_of_Sultan_Ahmed_I_Mosque_in_Istanbul%2C_Turkey_002.jpg"
                },
                new Place
                {
                    PlaceId = 3,
                    PlaceName = "Ulu Camiil",
                    CityName = "Bursa",
                    PlaceAdress = "Nalbantoğlu Ulucami Osmangazi/Bursa",
                    PhoneNumber = "11111111",
                    PlaceEmail = "ulucammi@gmail.com",
                    OpeningTime = "09:00",
                    ClosingTime = "11:59",
                    EntranceFee = 0,
                    PlaceDescription = "Bursa Ulu Cami, Orhan Gazi Parkı'nın bulunduğu geniş bir alana, Yıldırım Bayezid zamanında, 1396-1400 yılları arasında yapılmıştır. Osmanlı camileri arasında çok kubbeli anıtsal yapıların ilkidir. Ulu Cami’nin on iki büyük dört köşeli paye üzerine oturan 20 kubbesi bulunmaktadır. Yıldırım Bayezid’in 1396 Niğbolu zaferinden sonra Ulu Cami inşaatına başlanmıştır. Caminin inşaatı bittikten sonra ilk namazı  aralarında Yıldırım Bayezid, Molla Fenari, Emir Sultan’ın  da olduğu cemaate Somuncu Baba kıldırmıştır. Ulu Cami’nin ilk imamı, Mevlid’in yazarı Süleyman Çelebidir.",
                    ImageURL = "https://somuncubabaturbesi.com/wp-content/uploads/2018/03/bursa-ulu-camii-fotograf-somuncu-baba.jpg"
                },
                new Place
                {
                    PlaceId = 4,
                    PlaceName = "Ankara Kalesi",
                    CityName = "Ankara",
                    PlaceAdress = "Kale, 06240 Altındağ/Ankara",
                    PhoneNumber = "222222222",
                    PlaceEmail = "ankarakalesi@gmail.com",
                    OpeningTime = "09:00",
                    ClosingTime = "19:00",
                    EntranceFee = 0,
                    PlaceDescription = "Ankara Kalesi[1], Ankara'nın Altındağ ilçesinde bulunan tarihi bir kale. Ne zaman yapıldığı kesin olarak bilinmemekle birlikte MÖ 2. yüzyıl başında Galatların Ankara'ya yerleşmeleri sırasında kalenin var olduğu bilinmektedir. Romalılar, Bizanslılar, Selçuklular ve Osmanlılar dönemlerinde birçok kez onarımdan geçmiştir. Ankara Kalesi dışarıdan görümüne göre daha büyüktür. Her yıl çeşitli festivallere[2] de ev sahipliği yapmaktadır.",
                    ImageURL = "https://somuncubabaturbesi.com/wp-content/uploads/2018/03/bursa-ulu-camii-fotograf-somuncu-baba.jpg"
                },
                new Place
                {
                    PlaceId = 5,
                    PlaceName = "KızKalesi",
                    CityName = "Mersin",
                    PlaceAdress = "Mersin Erdemli ilçesine",
                    PhoneNumber = "44444444",
                    PlaceEmail = "kizkalisi@gmail.com",
                    OpeningTime = "03:00",
                    ClosingTime = "19:59",
                    EntranceFee = 220,
                    PlaceDescription = "Kız Kulesi hakkında çeşitli rivayetler anlatılan, efsanelere konu olan, İstanbul Boğazı'nın Marmara Denizi'ne yakın kısmında, Salacak açıklarında yer alan küçük adacık üzerinde inşa edilmiş yapı.Tarih içinde gözetleme kulesi, deniz feneri olarak kullanılmış, Boğaz girişini belirten bir mihenk noktasıdır. ",
                    ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/kiz-kalesi-34371.webp"
                },
                new Place
                {
                    PlaceId = 6,
                    PlaceName = "Aspendos Tiyatrosu",
                    CityName = "Antalya",
                    PlaceAdress = "Aspendos Antik Kenti antalya",
                    PhoneNumber = "555555555",
                    PlaceEmail = "aspends@gmail.com",
                    OpeningTime = "03:00",
                    ClosingTime = "19:59",
                    EntranceFee = 220,
                    PlaceDescription = "Aspendos tiyatrosu, döneminin belirgin tiyatro binası yapım özelliklerini içermektedir. 2. yüzyıl sonlarında yapılmıştır. inanılmaz derece mükemmel akustiği ile çağdaşlarının arasında haklı bir üne sahiptir. Kayıtlardan tiyatronun mimarı Aspendos’lu Theodorus’un oğlu Zenon olduğu anlaşılmaktadır.",
                    ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/aspendos-tiyatrosu-34372.webp"
                },
                new Place
                {
                    PlaceId = 7,
                    PlaceName = "Sinop Tarihi Cezaevi",
                    CityName = "Sinop",
                    PlaceAdress = "Kaleyazýsý Cumhuriyet Cd. Osmaniye Köyü/Sinop",
                    PhoneNumber = "66666666",
                    PlaceEmail = "sinopcezaev@gmail.com",
                    OpeningTime = "07:00",
                    ClosingTime = "11:00",
                    EntranceFee = 110,
                    PlaceDescription = "Üç yanı deniz olan ve tarihî Sinop Kalesi duvarlarının içerisinde yer alan cezaevine ev sahipliği yapan kale yaklaşık 4000 yıl önce Gaskalılar tarafından yapılmıştır. Yunanlar, Pontus, Roma, Bizans, Selçuklu ve Osmanlılar kendi dönemlerinde kaleyi korumuş ve güçlendirmişlerdir. Kalenin cezaevi olarak kullanımına ait en eski belgeler ise 1568 yılına dayanmaktadır.",
                    ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/sinop-tarihi-cezaevi-34380.webp"
                },
                new Place
                {
                    PlaceId = 8,
                    PlaceName = "Safranbolu Evleri",
                    CityName = "Karabük",
                    PlaceAdress = "Atatürk, 78600 Safranbolu/Karabük",
                    PhoneNumber = "77777777",
                    PlaceEmail = "safranbolu@gmail.com",
                    OpeningTime = "07:00",
                    ClosingTime = "11:00",
                    EntranceFee = 0,
                    PlaceDescription = "Safranbolu evleri, Karabük iline bağlı Safranbolu ilçesinde, 18. ve 19. yüzyıl Osmanlı kent yaşamının ve tarihi dokunun günümüze kadar kaldığı korunduğu bir ilçemizdir. UNESCO tarafından 17.12.1998’de Dünya Kültür Mirası listesine alınmıştır. Safranbolu evlerinin Osmanlı döneminde yumurta akından yapıldığı ve çok uzun süre depreme dayandığı söylenilmektedir .Safranbolu evleri Türk kültürünü aile yaşantısını aktara mükemmel yapıtlardan.Evler konak tarzında hali vakti yerinde ailelerin kaldığı evlerdir. Safranbolu evleri birbirinin önünü kapatmaz. Sokaklar taşlarla örülüdür.Alt yapı hala daha çalışmaktadır.",
                    ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/safranbolu-evleri-34381.webp"
                },
                new Place
                {
                    PlaceId = 9,
                    PlaceName = "Zilkale",
                    CityName = "Rize",
                    PlaceAdress = "Zilkale/Çamlýhemþin/Rize",
                    PhoneNumber = "88888888",
                    PlaceEmail = "zilkale@gmail.com",
                    OpeningTime = "07:00",
                    ClosingTime = "11:00",
                    EntranceFee = 0,
                    PlaceDescription = "Zil Kale, bölgenin en önemli eserlerinden birisidir. I. derece Arkeolojik sit alanı içerisinde bulunan kale, Çamlıhemşin’e 12 km uzaklıkta bulunan Fırtına Deresi’nin yamaçları üzerine kuruludur. Kesin yapım tarihi bilinmeyen kale, 8 burç ve 1 gözetleme kulesinden oluşmaktadır.",
                    ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/zilkale-34379.webp"
                },
                new Place
                {
                    PlaceId = 10,
                    PlaceName = "Çifte Minareli Medrese",
                    CityName = "Erzurum",
                    PlaceAdress = "Merkez,Cumhuriyet Yakutiye/Erzurum",
                    PhoneNumber = "71234568",
                    PlaceEmail = "cifteminarelimedrese@gmail.com",
                    OpeningTime = "01:00",
                    ClosingTime = "16:00",
                    EntranceFee = 0,
                    PlaceDescription = "Çifte Minareli Medrese (Hatuniye Medresesi) Anadolu Selçuklu dönemi medreselerindendir. Avlulu, 2 katlı, 4 eyvanlı medrese tipinin anıtsal bir örneğidir. Bütünüyle 38x48 m2’lik bir alanı kaplar. Kuzey cephesine hâkim taçkapısı başlı başına bir sanat şaheseridir. Taç kapıdan avluya geçilir.",
                    ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/cifte-minareli-medrese-549.webp"
                },
                new Place
                {
                    PlaceId = 11,
                    PlaceName = "Yalıboyu Evleri",
                    CityName = "Amasya",
                    PlaceAdress = "Bahçeleriçi Amasya Merkez/Amasya",
                    PhoneNumber = "99999999",
                    PlaceEmail = "yaliboyuevleri@gmail.com",
                    OpeningTime = "01:00",
                    ClosingTime = "16:00",
                    EntranceFee = 0,
                    PlaceDescription = "Yeşilırmak kenarında tarihi sur duvarları üzerine, ahşap çatkı arası, kerpiç dolgulu olarak inşaa edilmişlerdir. Kırma ya da beşik çatı üzeri, oluklu kiremitle örtülü bir biçimde düzenlenmiş olan ve geleneksel Osmanlı evinin bütün özelliklerini bünyesinde taşıyan bu evler, Amasya’nın tarihsel kimliğiyle uyumlu bir görünüm arz etmektedir. Evler bitişik nizamda, bodrum üzeri tek kat ya da iki katlı olarak düzenlenmişlerdir. Bazı uygulamalarda birinci kat üzerinde bazı uygulamalarda ise ikinci kat üzerinde köşk olarak bilinen şahniş yer almaktadır. Evler genellikle avlulu ve bahçelidir. Avluda su kuyusu ve ocak ilk göze çarpan nesnelerdir.",
                    ImageURL = "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/yaliboyu-evleri-34383.webp"
                }
                ) ;
        }
    }

}
