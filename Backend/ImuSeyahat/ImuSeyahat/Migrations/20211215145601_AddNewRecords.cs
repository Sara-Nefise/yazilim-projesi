using Microsoft.EntityFrameworkCore.Migrations;

namespace ImuSeyahat.Migrations
{
    public partial class AddNewRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "places",
                columns: table => new
                {
                    PlaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(maxLength: 50, nullable: false),
                    CityName = table.Column<string>(nullable: false),
                    PlaceAdress = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    PlaceEmail = table.Column<string>(nullable: false),
                    OpeningTime = table.Column<string>(nullable: false),
                    ClosingTime = table.Column<string>(nullable: false),
                    EntranceFee = table.Column<double>(nullable: false),
                    PlaceDescription = table.Column<string>(maxLength: 1000, nullable: false),
                    ImageURL = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_places", x => x.PlaceId);
                });

            migrationBuilder.InsertData(
                table: "places",
                columns: new[] { "PlaceId", "CityName", "ClosingTime", "EntranceFee", "ImageURL", "OpeningTime", "PhoneNumber", "PlaceAdress", "PlaceDescription", "PlaceEmail", "PlaceName" },
                values: new object[,]
                {
                    { 1, "Istanbul", "23:59", 100.0, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Galata_Tower_after_the_2020_restoration.jpg/270px-Galata_Tower_after_the_2020_restoration.jpg", "08:00", "5555555555", "Bereketzade 34421 Beyoğlu Istanbul", "Eski Galata Kulesi, 528 yılında Bizans İmparatoru Anastasius tarafından fener kulesi olarak inşa edilmiştir. Ancak bu kule 1202-1204 yılları arasındaki Dördüncü Haçlı Seferleri sırasında İstanbul’u ele geçiren ve yağmalayan Latinler tarafından büyük oranda zarar görmüş ve yıkılmıştır. Bugün Galata Kulesi’nin bulunduğu yere yakın bir bölgeye inşa edilmiş olan kule bazı kaynaklarda bugünkü kule olarak gösterilse de bu yanlıştır.", "galatakulesi@gmail.com", "Galata Kulesi" },
                    { 2, "Istanbul", "23:59", 0.0, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/Exterior_of_Sultan_Ahmed_I_Mosque_in_Istanbul%2C_Turkey_002.jpg/1280px-Exterior_of_Sultan_Ahmed_I_Mosque_in_Istanbul%2C_Turkey_002.jpg", "09:00", "6666666666", "Atmeydaný Cd. No:7 34122 Fatih/Istanbul", "Sultanahmet Camii, Osmanlı Sultanı I. Ahmet tarafından 1609 – 1616 tarihleri arasında yaptırılmıştır. Klâsik Türk sanatının en tipik örneği olan eser, orijinal olarak 6 minare ile inşa edilen ilk camidir. Mimar Sinan'ın eserlerinden biri olmadığı halde bu yapı Sinan'dan izler taşımaktadır. Sinan’ın öğrencisi Mimar Sedefkâr Mehmet Ağa, söylenene göre, camiyi inşa ederken, üstadının daha önce denediği bir planı daha büyük bir ölçüde uygulamıştır.", "sultanahmetcami@gmail.com", "Sultanahmet Camii" },
                    { 3, "Bursa", "11:59", 0.0, "https://somuncubabaturbesi.com/wp-content/uploads/2018/03/bursa-ulu-camii-fotograf-somuncu-baba.jpg", "09:00", "11111111", "Nalbantoğlu Ulucami Osmangazi/Bursa", "Bursa Ulu Cami, Orhan Gazi Parkı'nın bulunduğu geniş bir alana, Yıldırım Bayezid zamanında, 1396-1400 yılları arasında yapılmıştır. Osmanlı camileri arasında çok kubbeli anıtsal yapıların ilkidir. Ulu Cami’nin on iki büyük dört köşeli paye üzerine oturan 20 kubbesi bulunmaktadır. Yıldırım Bayezid’in 1396 Niğbolu zaferinden sonra Ulu Cami inşaatına başlanmıştır. Caminin inşaatı bittikten sonra ilk namazı  aralarında Yıldırım Bayezid, Molla Fenari, Emir Sultan’ın  da olduğu cemaate Somuncu Baba kıldırmıştır. Ulu Cami’nin ilk imamı, Mevlid’in yazarı Süleyman Çelebidir.", "ulucammi@gmail.com", "Ulu Camiil" },
                    { 4, "Ankara", "19:00", 0.0, "https://somuncubabaturbesi.com/wp-content/uploads/2018/03/bursa-ulu-camii-fotograf-somuncu-baba.jpg", "09:00", "222222222", "Kale, 06240 Altındağ/Ankara", "Ankara Kalesi[1], Ankara'nın Altındağ ilçesinde bulunan tarihi bir kale. Ne zaman yapıldığı kesin olarak bilinmemekle birlikte MÖ 2. yüzyıl başında Galatların Ankara'ya yerleşmeleri sırasında kalenin var olduğu bilinmektedir. Romalılar, Bizanslılar, Selçuklular ve Osmanlılar dönemlerinde birçok kez onarımdan geçmiştir. Ankara Kalesi dışarıdan görümüne göre daha büyüktür. Her yıl çeşitli festivallere[2] de ev sahipliği yapmaktadır.", "ankarakalesi@gmail.com", "Ankara Kalesi" },
                    { 5, "Mersin", "19:59", 220.0, "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/kiz-kalesi-34371.webp", "03:00", "44444444", "Mersin Erdemli ilçesine", "Kız Kulesi hakkında çeşitli rivayetler anlatılan, efsanelere konu olan, İstanbul Boğazı'nın Marmara Denizi'ne yakın kısmında, Salacak açıklarında yer alan küçük adacık üzerinde inşa edilmiş yapı.Tarih içinde gözetleme kulesi, deniz feneri olarak kullanılmış, Boğaz girişini belirten bir mihenk noktasıdır. ", "kizkalisi@gmail.com", "KızKalesi" },
                    { 6, "Antalya", "19:59", 220.0, "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/aspendos-tiyatrosu-34372.webp", "03:00", "555555555", "Aspendos Antik Kenti antalya", "Aspendos tiyatrosu, döneminin belirgin tiyatro binası yapım özelliklerini içermektedir. 2. yüzyıl sonlarında yapılmıştır. inanılmaz derece mükemmel akustiği ile çağdaşlarının arasında haklı bir üne sahiptir. Kayıtlardan tiyatronun mimarı Aspendos’lu Theodorus’un oğlu Zenon olduğu anlaşılmaktadır.", "aspends@gmail.com", "Aspendos Tiyatrosu" },
                    { 7, "Sinop", "11:00", 110.0, "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/sinop-tarihi-cezaevi-34380.webp", "07:00", "66666666", "Kaleyazýsý Cumhuriyet Cd. Osmaniye Köyü/Sinop", "Üç yanı deniz olan ve tarihî Sinop Kalesi duvarlarının içerisinde yer alan cezaevine ev sahipliği yapan kale yaklaşık 4000 yıl önce Gaskalılar tarafından yapılmıştır. Yunanlar, Pontus, Roma, Bizans, Selçuklu ve Osmanlılar kendi dönemlerinde kaleyi korumuş ve güçlendirmişlerdir. Kalenin cezaevi olarak kullanımına ait en eski belgeler ise 1568 yılına dayanmaktadır.", "sinopcezaev@gmail.com", "Sinop Tarihi Cezaevi" },
                    { 8, "Karabük", "11:00", 0.0, "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/safranbolu-evleri-34381.webp", "07:00", "77777777", "Atatürk, 78600 Safranbolu/Karabük", "Safranbolu evleri, Karabük iline bağlı Safranbolu ilçesinde, 18. ve 19. yüzyıl Osmanlı kent yaşamının ve tarihi dokunun günümüze kadar kaldığı korunduğu bir ilçemizdir. UNESCO tarafından 17.12.1998’de Dünya Kültür Mirası listesine alınmıştır. Safranbolu evlerinin Osmanlı döneminde yumurta akından yapıldığı ve çok uzun süre depreme dayandığı söylenilmektedir .Safranbolu evleri Türk kültürünü aile yaşantısını aktara mükemmel yapıtlardan.Evler konak tarzında hali vakti yerinde ailelerin kaldığı evlerdir. Safranbolu evleri birbirinin önünü kapatmaz. Sokaklar taşlarla örülüdür.Alt yapı hala daha çalışmaktadır.", "safranbolu@gmail.com", "Safranbolu Evleri" },
                    { 9, "Rize", "11:00", 0.0, "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/zilkale-34379.webp", "07:00", "88888888", "Zilkale/Çamlýhemþin/Rize", "Zil Kale, bölgenin en önemli eserlerinden birisidir. I. derece Arkeolojik sit alanı içerisinde bulunan kale, Çamlıhemşin’e 12 km uzaklıkta bulunan Fırtına Deresi’nin yamaçları üzerine kuruludur. Kesin yapım tarihi bilinmeyen kale, 8 burç ve 1 gözetleme kulesinden oluşmaktadır.", "zilkale@gmail.com", "Zilkale" },
                    { 10, "Erzurum", "16:00", 0.0, "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/cifte-minareli-medrese-549.webp", "01:00", "71234568", "Merkez,Cumhuriyet Yakutiye/Erzurum", "Çifte Minareli Medrese (Hatuniye Medresesi) Anadolu Selçuklu dönemi medreselerindendir. Avlulu, 2 katlı, 4 eyvanlı medrese tipinin anıtsal bir örneğidir. Bütünüyle 38x48 m2’lik bir alanı kaplar. Kuzey cephesine hâkim taçkapısı başlı başına bir sanat şaheseridir. Taç kapıdan avluya geçilir.", "cifteminarelimedrese@gmail.com", "Çifte Minareli Medrese" },
                    { 11, "Amasya", "16:00", 0.0, "https://cdn2.enuygun.com/media/lib/825x620/uploads/image/yaliboyu-evleri-34383.webp", "01:00", "99999999", "Bahçeleriçi Amasya Merkez/Amasya", "Yeşilırmak kenarında tarihi sur duvarları üzerine, ahşap çatkı arası, kerpiç dolgulu olarak inşaa edilmişlerdir. Kırma ya da beşik çatı üzeri, oluklu kiremitle örtülü bir biçimde düzenlenmiş olan ve geleneksel Osmanlı evinin bütün özelliklerini bünyesinde taşıyan bu evler, Amasya’nın tarihsel kimliğiyle uyumlu bir görünüm arz etmektedir. Evler bitişik nizamda, bodrum üzeri tek kat ya da iki katlı olarak düzenlenmişlerdir. Bazı uygulamalarda birinci kat üzerinde bazı uygulamalarda ise ikinci kat üzerinde köşk olarak bilinen şahniş yer almaktadır. Evler genellikle avlulu ve bahçelidir. Avluda su kuyusu ve ocak ilk göze çarpan nesnelerdir.", "yaliboyuevleri@gmail.com", "Yalıboyu Evleri" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "places");
        }
    }
}
