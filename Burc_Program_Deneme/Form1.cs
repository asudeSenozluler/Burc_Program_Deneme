﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burc_Program_Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Show();
            pictureBox2.Show();
            textBox1.Show();
            string burc;
            int gun, ay;
            gun = int.Parse(comboBox2.Text);
            ay = int.Parse(comboBox1.Text);
            burc = label4.Text;

            if (gun >= 22 && gun <= 30 && ay == 1)
            {
                label4.Text = "Kova";
                textBox1.Text = "Yeni burç tarihleri 2021 yılına göre Kova 25 günlük döngüsünü 16 Şubat- 12 Mart aralığında alır fakat geçerli kabul edilen 12 burca göre 22 Ocak ve 19 Şubat aralığını kabul ediyoruz. Hava grubuna dahil olan Kovaların en bilinen özelliği sağduyulu olması. İnsancıl yapıları ve her koşulda iradeli kalabilmeleri sayesinde ilerlemek için yeni fırsatlar yaratabilen kişiler genellikle bu burç tarihleri arasında doğmuş olarak karşımıza çıkar. Yardımsever yapıları nedeniyle karşılarına çıkan zor durumda bulunan kişilere anında koşmaya çalışırlar. Paraya değer vermek asla onlara göre değildir ki bu nedenle bazen cömertliğin ucunu kaçırabilirler. En kötü özellik olarak ihmalciliği gösterebiliriz. Yapıları daha rahat ve değişken olduğu için sorumluluk duyguları diğer burçlara oranla daha azdır demek yanlış olmaz. Kavga ve gürültüden mümkün olduğunca kaçan Kovalar, barışın önemli olduğunu bilen ve uygulamaya çalışan kişilerdir. Bağımsızlık duygusuna kendilerini fazlasıyla kaptırdıkları için ister iş hayatı ister özel hayat olsun, kapana kısılmış gibi hissetmekten hiç hoşlanmazlar. Bir Kova ile yakın ilişkiler kurmak istiyorsanız ilk bilmeniz gereken şey ona her saniye hesap sormamak olduğudur.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\kova.jpg";
            }

            else if (gun >= 1 && gun <= 19 && ay == 2)
            {  label4.Text = "Kova";
            textBox1.Text = "Yeni burç tarihleri 2021 yılına göre Kova 25 günlük döngüsünü 16 Şubat- 12 Mart aralığında alır fakat geçerli kabul edilen 12 burca göre 22 Ocak ve 19 Şubat aralığını kabul ediyoruz. Hava grubuna dahil olan Kovaların en bilinen özelliği sağduyulu olması. İnsancıl yapıları ve her koşulda iradeli kalabilmeleri sayesinde ilerlemek için yeni fırsatlar yaratabilen kişiler genellikle bu burç tarihleri arasında doğmuş olarak karşımıza çıkar. Yardımsever yapıları nedeniyle karşılarına çıkan zor durumda bulunan kişilere anında koşmaya çalışırlar. Paraya değer vermek asla onlara göre değildir ki bu nedenle bazen cömertliğin ucunu kaçırabilirler. En kötü özellik olarak ihmalciliği gösterebiliriz. Yapıları daha rahat ve değişken olduğu için sorumluluk duyguları diğer burçlara oranla daha azdır demek yanlış olmaz. Kavga ve gürültüden mümkün olduğunca kaçan Kovalar, barışın önemli olduğunu bilen ve uygulamaya çalışan kişilerdir. Bağımsızlık duygusuna kendilerini fazlasıyla kaptırdıkları için ister iş hayatı ister özel hayat olsun, kapana kısılmış gibi hissetmekten hiç hoşlanmazlar. Bir Kova ile yakın ilişkiler kurmak istiyorsanız ilk bilmeniz gereken şey ona her saniye hesap sormamak olduğudur.";
            pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\kova.jpg";
            }



           
            if (gun >= 20 && gun <= 29 && ay == 2)
            { label4.Text = "Balık";
                textBox1.Text="Aşırı duygusal olmaları ile tanınan Balıkların en güzel özelliği çok iyi empati yapabiliyor olmalarıdır. Karşılarındaki kişileri hemen anlayabilen, aşırı derecede anlayışlı davranan hatta çoğu zaman iyi niyeti suiistimal edilen bu burca sahip kişilerin bir diğer iyi özelliği de hislerinin çok güçlü olmasıdır. Sezgileri ve insancıl yaklaşımlarıyla her ortamda kendini belli edebilen Balıkların sanata olan ilgileri de oldukça fazla. Hayatları boyunca huzurdan başka hiçbir şeye değer vermezler ve huzurlu hissettikleri kişi/olay karşısında her şeyden vazgeçebilirler. Sevdiklerine karşı ilgi ve alakası yüksek olan bu kişiler hayatlarında naif ve sevgiden anlayan kişilerin bulunmasını arzular. Su grubunda yer alan Balık burcu canlı ve daima neşeli haliyle de ilgi görür fakat bu durum anlıktır. Beş dakika önce ağlayan bir Balık bir süre sonra kahkahalar atabilir. Duygularına göre durumlar karşısında şekillenen bu kişiler için her ne kadar hayalci denilse de aslında gerçek hayata bakışları da bir o kadar gerçekçidir. Sadece hayal kurmadan yaşamaları imkânsız olan bu burca sahip kişiler çoğu zaman gözyaşlarına hâkim olamazlar ve tozpembe hayallerinden vazgeçmek istemezler. En kötü özelliği kendini küçümsemek olan Balıklar her koşulda verici olmayı tercih ettikleri için bazen hayal kırıklığı yaşayabilirler. Son olarak da yeni burç tarihleri 2018 sıralamasına göre 13 Mart- 18 Nisan aralığında doğanlar Balık kabul ediliyor.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\balik.jpg";
            }
            else if (gun >= 1 && gun <= 20 && ay == 3)
            {    label4.Text = "Balık";
             textBox1.Text="Aşırı duygusal olmaları ile tanınan Balıkların en güzel özelliği çok iyi empati yapabiliyor olmalarıdır. Karşılarındaki kişileri hemen anlayabilen, aşırı derecede anlayışlı davranan hatta çoğu zaman iyi niyeti suiistimal edilen bu burca sahip kişilerin bir diğer iyi özelliği de hislerinin çok güçlü olmasıdır. Sezgileri ve insancıl yaklaşımlarıyla her ortamda kendini belli edebilen Balıkların sanata olan ilgileri de oldukça fazla. Hayatları boyunca huzurdan başka hiçbir şeye değer vermezler ve huzurlu hissettikleri kişi/olay karşısında her şeyden vazgeçebilirler. Sevdiklerine karşı ilgi ve alakası yüksek olan bu kişiler hayatlarında naif ve sevgiden anlayan kişilerin bulunmasını arzular. Su grubunda yer alan Balık burcu canlı ve daima neşeli haliyle de ilgi görür fakat bu durum anlıktır. Beş dakika önce ağlayan bir Balık bir süre sonra kahkahalar atabilir. Duygularına göre durumlar karşısında şekillenen bu kişiler için her ne kadar hayalci denilse de aslında gerçek hayata bakışları da bir o kadar gerçekçidir. Sadece hayal kurmadan yaşamaları imkânsız olan bu burca sahip kişiler çoğu zaman gözyaşlarına hâkim olamazlar ve tozpembe hayallerinden vazgeçmek istemezler. En kötü özelliği kendini küçümsemek olan Balıklar her koşulda verici olmayı tercih ettikleri için bazen hayal kırıklığı yaşayabilirler. Son olarak da yeni burç tarihleri 2018 sıralamasına göre 13 Mart- 18 Nisan aralığında doğanlar Balık kabul ediliyor.";
             pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\balik.jpg";
            }
           
            if (gun >= 21 && gun <= 31 && ay == 3)
            {
                label4.Text = "Koç";
                textBox1.Text = "Burç tarihleri ve özellikleri bakımından inceleyeceğimiz ilk burç ateş grubunda yer alan Koç burcu oluyor. Hayatında hareket, canlılık ve kıpır kıpırlığın eksik olmadığı Koç’lar için macera olmayan bir hayat kesinlikle çekilmez. Bu burcun genel özelliklerine bakacak olursak; cesaretli ve atılgan yapıları nedeniyle yeni girişimlere korkusuzca daldıklarını söyleyebiliriz. Herhangi bir konuda öncü olmak, karşılarındaki kişilere yol göstermekten hoşlanmaları da şüphesiz liderlik özelliğini taşıyor olmaktan geliyor. Her koşulda başarı ve zafer kazanmayı kendilerine amaç edinen Koç burcu kişilerinin en sevilmeyen özelliği maalesef sabırsız olmalarına dayanıyor. İçi içine sığmayan, durumların içine hemen dalabilme özelliklerini sabırsız yapıları tetikliyor. Bazen bu sabırsız yapılarından dolayı hatalara düşseler de burç tarihleri bakımından yönetici gezegenleri Mars olduğu için savaşçı yapıları kaybetmelerine izin vermez. Tüm özellikleri düşünülerek özel hayatları hakkında yorum yapmak gerekirse; heyecanlı, tutkulu ve cinselliğin çok ön planda ilerlediği bir hayat onlar için olmazsa olmazlar arasında gösterilebilir.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\koc.jpg";

            }


            else if (gun >= 1 && gun <= 20 && ay == 4)
            {
                label4.Text = "Koç";
                textBox1.Text = "Burç tarihleri ve özellikleri bakımından inceleyeceğimiz ilk burç ateş grubunda yer alan Koç burcu oluyor. Hayatında hareket, canlılık ve kıpır kıpırlığın eksik olmadığı Koç’lar için macera olmayan bir hayat kesinlikle çekilmez. Bu burcun genel özelliklerine bakacak olursak; cesaretli ve atılgan yapıları nedeniyle yeni girişimlere korkusuzca daldıklarını söyleyebiliriz. Herhangi bir konuda öncü olmak, karşılarındaki kişilere yol göstermekten hoşlanmaları da şüphesiz liderlik özelliğini taşıyor olmaktan geliyor. Her koşulda başarı ve zafer kazanmayı kendilerine amaç edinen Koç burcu kişilerinin en sevilmeyen özelliği maalesef sabırsız olmalarına dayanıyor. İçi içine sığmayan, durumların içine hemen dalabilme özelliklerini sabırsız yapıları tetikliyor. Bazen bu sabırsız yapılarından dolayı hatalara düşseler de burç tarihleri bakımından yönetici gezegenleri Mars olduğu için savaşçı yapıları kaybetmelerine izin vermez. Tüm özellikleri düşünülerek özel hayatları hakkında yorum yapmak gerekirse; heyecanlı, tutkulu ve cinselliğin çok ön planda ilerlediği bir hayat onlar için olmazsa olmazlar arasında gösterilebilir.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\koc.jpg";
            }
            if (gun >= 21 && gun <= 30 && ay == 4)
            {
                label4.Text = "Boğa";
                textBox1.Text = "Toprak grubunda yer alan Boğa burcu her zaman ne istediğini bilen burçlar arasında yer alıyor. Hayata dair istediklerini çok net belirleyebilen, amaçlarını sıralamada sıkıntı yaşamayan ve sürekliliğe önem veren Boğa burcu için çoğu astrolog “Zenginlik burcu; boğadır.” İfadesini kullanıyor. Bildiğiniz gibi burçların tarihleri kişilerin özelliklerini yöneterek ilerliyor. Bu sebeple Boğa burcunu incelediğimiz zaman karşımıza ilk çıkan şey; yönetici yıldız olarak Venüs’e sahip olması oluyor. Venüs ise güzellik, sevgi ve sanatı temsil eder. Yani Boğa burcu olan kişilerin ilgi alanları ve istekleri bu doğrultuda gelişir. Arkadaşlık ve dostluk onlar için fazlasıyla önemli iken koruyucu özellikleri sebebiyle bazen karşı tarafı fazlasıyla baskı altına alabilirler. Sıcakkanlı olmaları sebebiyle çok kolay arkadaşlık kurabilen Boğaların dostlukları genellikle çok uzun yıllar sürer. Sevdikleri için her türlü şeyi göze alabilme özelliklerinin yanında kırılgan ve alıngan bir yapıları da bulunur. Hassas bir ruha sahip oldukları için çoğu zaman gereksiz alınganlık yapabilirler. Ancak gelecek için herhangi bir Boğa kadını ya da erkeği ile hayatınızı birleştirmek istiyorsanız burç tarihleri ve özellikleri arasında evlilik için Boğalar ile çok doğru bir karar verdiğinizi bilmelisiniz.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\boga.jpg";
            }
            else if (gun >= 1 && gun <= 21 && ay == 5)
            {
                label4.Text = "Boğa";
             textBox1.Text = "Toprak grubunda yer alan Boğa burcu her zaman ne istediğini bilen burçlar arasında yer alıyor. Hayata dair istediklerini çok net belirleyebilen, amaçlarını sıralamada sıkıntı yaşamayan ve sürekliliğe önem veren Boğa burcu için çoğu astrolog “Zenginlik burcu; boğadır.” İfadesini kullanıyor. Bildiğiniz gibi burçların tarihleri kişilerin özelliklerini yöneterek ilerliyor. Bu sebeple Boğa burcunu incelediğimiz zaman karşımıza ilk çıkan şey; yönetici yıldız olarak Venüs’e sahip olması oluyor. Venüs ise güzellik, sevgi ve sanatı temsil eder. Yani Boğa burcu olan kişilerin ilgi alanları ve istekleri bu doğrultuda gelişir. Arkadaşlık ve dostluk onlar için fazlasıyla önemli iken koruyucu özellikleri sebebiyle bazen karşı tarafı fazlasıyla baskı altına alabilirler. Sıcakkanlı olmaları sebebiyle çok kolay arkadaşlık kurabilen Boğaların dostlukları genellikle çok uzun yıllar sürer. Sevdikleri için her türlü şeyi göze alabilme özelliklerinin yanında kırılgan ve alıngan bir yapıları da bulunur. Hassas bir ruha sahip oldukları için çoğu zaman gereksiz alınganlık yapabilirler. Ancak gelecek için herhangi bir Boğa kadını ya da erkeği ile hayatınızı birleştirmek istiyorsanız burç tarihleri ve özellikleri arasında evlilik için Boğalar ile çok doğru bir karar verdiğinizi bilmelisiniz.";
             pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\boga.jpg";
            }

            if (gun >= 22 && gun <= 31 && ay == 5)
            {
                label4.Text = "İkizler";
                textBox1.Text = "Burç tarihleri 22 Mayıs ile 22 Haziran aralığını gösterdiğinde karşımıza çıkan burç hava grubundan olan İkizler oluyor. Pozitif yapısı ve keskin zekâsı ile kendinden söz ettiren bu burca sahip olan kişilerin en belirgin özelliği yönetici gezegeni Merkür’ün ona sunduğu canlılık ve zekâsı oluyor. İkizler, ün yapmaktan büyük keyif alan burçlar arasında yer alır. Gazetecilik veya çok ünlü bir yazar olmak hem yeni bir şeyler üretmek hem de kendi isimlerini herkese duyurmak hayatta amaçladıkları şeyler arasında yer alır. Zekasını yeteneklerine göre kullanabilen pek çok İkizler burcunun yenmesi gereken tek şey sürekli konuşması olarak kabul edilebilir. İçerisinde bulunan enerji ve neşeyi etrafına konuşarak yayabilen İkizler’in bazen çok konuşuyor olması çevresine rahatsızlık verebilir. İletişimi çok iyi olan bu kişilerin geleceğe dair yatırımları iletişimi yüksek işlere yapmasında fayda var. İkili özel ilişkilerinde de oldukça hareketli olan ikizlerin hayat temposuna yetişmek pasif kişiler için oldukça zor bir seçim olabilir.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\ikizler.jpg";
            }
            else if (gun >= 1 && gun <= 22 && ay == 6)
            {  
                label4.Text = "İkizler";
            textBox1.Text = "Burç tarihleri 22 Mayıs ile 22 Haziran aralığını gösterdiğinde karşımıza çıkan burç hava grubundan olan İkizler oluyor. Pozitif yapısı ve keskin zekâsı ile kendinden söz ettiren bu burca sahip olan kişilerin en belirgin özelliği yönetici gezegeni Merkür’ün ona sunduğu canlılık ve zekâsı oluyor. İkizler, ün yapmaktan büyük keyif alan burçlar arasında yer alır. Gazetecilik veya çok ünlü bir yazar olmak hem yeni bir şeyler üretmek hem de kendi isimlerini herkese duyurmak hayatta amaçladıkları şeyler arasında yer alır. Zekasını yeteneklerine göre kullanabilen pek çok İkizler burcunun yenmesi gereken tek şey sürekli konuşması olarak kabul edilebilir. İçerisinde bulunan enerji ve neşeyi etrafına konuşarak yayabilen İkizler’in bazen çok konuşuyor olması çevresine rahatsızlık verebilir. İletişimi çok iyi olan bu kişilerin geleceğe dair yatırımları iletişimi yüksek işlere yapmasında fayda var. İkili özel ilişkilerinde de oldukça hareketli olan ikizlerin hayat temposuna yetişmek pasif kişiler için oldukça zor bir seçim olabilir.";
            pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\ikizler.jpg";
            }


            if (gun >= 23 && gun <= 30 && ay == 6)
            {
                label4.Text = "Yengeç";
                textBox1.Text = "Burçlar ve tarihleri açısından 23 Haziran ile 22 Temmuz tarihleri arasında dünyaya gelen Yengeç burcuna sahip kişiler merhametli, iyi niyetli ve yumuşak başlı özellikleriyle dikkat çekiyor. Oldukça sabırlı ve koruyucu özelliği bulunan Yengeç burcundan bir tanıdığa sahip olmak gerçekten dünyanın en güzel hediyelerinden biri sayılabilir. Duyguları çok hızlı değişen bir burç olmasına rağmen hayatlarında yer edinen kişilere karşı hep iyi yaklaşımlar sergilerler. Tek olumsuz özellik olarak aşırı dikkatsiz olmalarını söyleyebiliriz. Fiziksel açıdan genellikle orta boylu ve beyaz tenli olan Yengeçler ilerleyen günlerde beslenmelerine dikkat etmek zorunda kalabilirler. Genellikle Oğlak burcu ile çok iyi anlaşamazlar. Güven ve saygı onlar için çok önemlidir ve aile hayatında bu iki kavramın yer almasına özen gösterirler.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\yengec.jpg";
            }

            else if (gun >= 1 && gun <= 22 && ay == 7)
            {
                label4.Text = "Yengeç";
             textBox1.Text = "Burçlar ve tarihleri açısından 23 Haziran ile 22 Temmuz tarihleri arasında dünyaya gelen Yengeç burcuna sahip kişiler merhametli, iyi niyetli ve yumuşak başlı özellikleriyle dikkat çekiyor. Oldukça sabırlı ve koruyucu özelliği bulunan Yengeç burcundan bir tanıdığa sahip olmak gerçekten dünyanın en güzel hediyelerinden biri sayılabilir. Duyguları çok hızlı değişen bir burç olmasına rağmen hayatlarında yer edinen kişilere karşı hep iyi yaklaşımlar sergilerler. Tek olumsuz özellik olarak aşırı dikkatsiz olmalarını söyleyebiliriz. Fiziksel açıdan genellikle orta boylu ve beyaz tenli olan Yengeçler ilerleyen günlerde beslenmelerine dikkat etmek zorunda kalabilirler. Genellikle Oğlak burcu ile çok iyi anlaşamazlar. Güven ve saygı onlar için çok önemlidir ve aile hayatında bu iki kavramın yer almasına özen gösterirler.";
             pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\yengec.jpg";
            }

            if (gun >= 01 && gun <= 22 && ay == 9)
            {
                label4.Text = "Başak";
                textBox1.Text = "Toprak grubunun zekâsı ve titizliği ile dikkat çeken Başak burcu disiplinli yapısıyla da her ortamda kendini belli edebilir. Aşırıya kaçarsa fazlasıyla takıntılı olabilecek Başaklar genellikle titizlikleriyle gurur duyar. Etrafındaki her şeyle ilgili olan bu burcun beğenilmek ve takdir görmek hayatlarında en değer verdiği şeylerden biri olarak karşımıza çıkar. Başarıya ve yükselmeye önem verirler ve asla aynı noktada saymak onlara göre değildir. Her ne kadar bazen çekingenlikleri ağır basıyor olsa da çoğu yolu başarma inancıyla azimle aşarlar. Zekâsı ve olayları bakış açısıyla hep ilerleme hedefleyen bu kişileri kısıtlamaya çalışmak yapılabilecek en büyük hata olur. İçine kapanık bir duruş sergilemiş olsalar da en yakınlarına karşı oldukça cana yakın bir bakış açısı sergilerler. Temizlik, aşırı çalışkanlık ve hep düzenli olmaktan yana olan Başaklar asla dağınık insanlarla yan yana olmak istemez. Genellikle tutumlu davranışlar sergileyen bazı Başaklar için pinti olduğu söylenir fakat bu durum kesinlikle doğru değildir. Sadece kime ne derece önem verecek ne derece harcamalarını değiştirecek bunun kararını kendileri verirler. Mükemmellik onlar için çok önemli olduğu için hayatlarının her alanında ince noktalara takılarak ilerler ve hayatlarında öncelik sırası her zaman iş hayatı olur.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\basak.jpg";
            }
            else if (gun >= 23 && gun <= 31 && ay == 8)
            {
                label4.Text = "Başak";
             textBox1.Text = "Toprak grubunun zekâsı ve titizliği ile dikkat çeken Başak burcu disiplinli yapısıyla da her ortamda kendini belli edebilir. Aşırıya kaçarsa fazlasıyla takıntılı olabilecek Başaklar genellikle titizlikleriyle gurur duyar. Etrafındaki her şeyle ilgili olan bu burcun beğenilmek ve takdir görmek hayatlarında en değer verdiği şeylerden biri olarak karşımıza çıkar. Başarıya ve yükselmeye önem verirler ve asla aynı noktada saymak onlara göre değildir. Her ne kadar bazen çekingenlikleri ağır basıyor olsa da çoğu yolu başarma inancıyla azimle aşarlar. Zekâsı ve olayları bakış açısıyla hep ilerleme hedefleyen bu kişileri kısıtlamaya çalışmak yapılabilecek en büyük hata olur. İçine kapanık bir duruş sergilemiş olsalar da en yakınlarına karşı oldukça cana yakın bir bakış açısı sergilerler. Temizlik, aşırı çalışkanlık ve hep düzenli olmaktan yana olan Başaklar asla dağınık insanlarla yan yana olmak istemez. Genellikle tutumlu davranışlar sergileyen bazı Başaklar için pinti olduğu söylenir fakat bu durum kesinlikle doğru değildir. Sadece kime ne derece önem verecek ne derece harcamalarını değiştirecek bunun kararını kendileri verirler. Mükemmellik onlar için çok önemli olduğu için hayatlarının her alanında ince noktalara takılarak ilerler ve hayatlarında öncelik sırası her zaman iş hayatı olur.";
             pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\basak.jpg";
            }
           
            if (gun >= 23 && gun <= 31 && ay == 9)
               
            {
                label4.Text = "Terazi";
                textBox1.Text="Güzellik ve lüksten hoşlandığı bilinen Terazilerin aslında en önemli özelliği dengeli olmaları. Hayatlarında ve ilişkilerinde dengeye fazlasıyla önem veren bir teraziyi kıskaca almaya çalışmak yapılabilecek en hatalı davranışlar arasında gösterilebilir. Çok seviyeli bir arkadaşlık kurabilen Teraziler her ortamda kendini belli edebilen ve aranan kişiler arasında yer alır. Özellikle erkekleri için fazlaca çapkın olduğunu söyleyebiliriz fakat bir kez severlerse tam anlamıyla sevdiklerini de belirtelim. Dış görünüşlerine önem veren ve karşı taraftan da aynı inceliği arayan bu burcun kişileri gösterişli şeylerden çok fazla hoşlanır. Hava grubunda yer alan Terazilerin hayatından sevgi eksik olmamalı ve çoğu zamanını sevgiye dayalı işlerde harcaması gerekir. Sanat ile araları iyi olan bu kişilerin saygılı ve zarif duruşları etraflarındaki kişileri etkilemede kullandıkları bir silah. Fiziksel anlamda hem Terazi kadınları hem de erkekleri oldukça çekici bir görünüme sahiptir. Temizlik ve bakımlı olmaya özen gösteren ve aynı şeyi karşı taraftan da bekleyen Teraziler genellikle uzun boylu ve beyaz tenli olurlar.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\terazi.jpg";
            }
            else if (gun >= 1 && gun <= 22 && ay == 10)
            {  label4.Text = "Terazi";
              textBox1.Text="Güzellik ve lüksten hoşlandığı bilinen Terazilerin aslında en önemli özelliği dengeli olmaları. Hayatlarında ve ilişkilerinde dengeye fazlasıyla önem veren bir teraziyi kıskaca almaya çalışmak yapılabilecek en hatalı davranışlar arasında gösterilebilir. Çok seviyeli bir arkadaşlık kurabilen Teraziler her ortamda kendini belli edebilen ve aranan kişiler arasında yer alır. Özellikle erkekleri için fazlaca çapkın olduğunu söyleyebiliriz fakat bir kez severlerse tam anlamıyla sevdiklerini de belirtelim. Dış görünüşlerine önem veren ve karşı taraftan da aynı inceliği arayan bu burcun kişileri gösterişli şeylerden çok fazla hoşlanır. Hava grubunda yer alan Terazilerin hayatından sevgi eksik olmamalı ve çoğu zamanını sevgiye dayalı işlerde harcaması gerekir. Sanat ile araları iyi olan bu kişilerin saygılı ve zarif duruşları etraflarındaki kişileri etkilemede kullandıkları bir silah. Fiziksel anlamda hem Terazi kadınları hem de erkekleri oldukça çekici bir görünüme sahiptir. Temizlik ve bakımlı olmaya özen gösteren ve aynı şeyi karşı taraftan da bekleyen Teraziler genellikle uzun boylu ve beyaz tenli olurlar.";
              pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\terazi.jpg";
            }
            
            if (gun >= 23 && gun <= 31 && ay == 10)
                  
            {
                label4.Text = "Akrep";
                textBox1.Text="Akrep burcu tarihi 23 Ekim- 21 Kasım aralığı olarak kabul ediliyor fakat yeni burç tarihleri açısından sadece 6 günlük dilim Akreplere ayrılıyor. Bu tarihlere göre 24 Kasım- 29 Kasım aralığı yeni Akrep burcu tarihi kabul ediliyor. Su grubunun en acımasız ve korkulan burcu sayılan Akrepler kararlılığı, inatçılığı ve intikam alma duygusunu yüksek oranda taşıyor olmasıyla da göz korkutan burçlar arasında gösterilebilir. Mars ve Plüton yönetici yıldızına sahip bu burcun sezgileri fazlasıyla güçlü olup, olayları inceleme şekli de fazlasıyla detaycı denilebilir. Tutkulu, şehvet seven ve savaşa savaş taktiğini kullanan Akrepler için yenilgiyi kabullenmek oldukça zor bir durum. Çekici, cazibeli ve yeni şartlara kolay uyum sağlama özelliği ile ortamlarda dikkati üstüne çekebilen Akrepler birini umursamıyor ise ihmal etme, erteleme ve umursamama düzeyleri yükselebilir. Korkusuz ve acımasız olmaları ise en olumsuz özellikleri arasında gösterilebilir. Tuttuğunu kopartabilen Akrepler eğer içlerinde yanan ateşi dizginlemeyi öğrenemezlerse kendilerine zarar vermeye başlarlar. Koç burcundan olanlar ile araları çok iyi değildir.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\akrep.jpg";
            }
            else if (gun >= 1 && gun <= 21 && ay == 11)
            {   label4.Text = "Akrep";
           textBox1.Text="Akrep burcu tarihi 23 Ekim- 21 Kasım aralığı olarak kabul ediliyor fakat yeni burç tarihleri açısından sadece 6 günlük dilim Akreplere ayrılıyor. Bu tarihlere göre 24 Kasım- 29 Kasım aralığı yeni Akrep burcu tarihi kabul ediliyor. Su grubunun en acımasız ve korkulan burcu sayılan Akrepler kararlılığı, inatçılığı ve intikam alma duygusunu yüksek oranda taşıyor olmasıyla da göz korkutan burçlar arasında gösterilebilir. Mars ve Plüton yönetici yıldızına sahip bu burcun sezgileri fazlasıyla güçlü olup, olayları inceleme şekli de fazlasıyla detaycı denilebilir. Tutkulu, şehvet seven ve savaşa savaş taktiğini kullanan Akrepler için yenilgiyi kabullenmek oldukça zor bir durum. Çekici, cazibeli ve yeni şartlara kolay uyum sağlama özelliği ile ortamlarda dikkati üstüne çekebilen Akrepler birini umursamıyor ise ihmal etme, erteleme ve umursamama düzeyleri yükselebilir. Korkusuz ve acımasız olmaları ise en olumsuz özellikleri arasında gösterilebilir. Tuttuğunu kopartabilen Akrepler eğer içlerinde yanan ateşi dizginlemeyi öğrenemezlerse kendilerine zarar vermeye başlarlar. Koç burcundan olanlar ile araları çok iyi değildir.";
           pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\akrep.jpg";
            }
            if (gun >= 22 && gun <= 30 && ay == 11)
               
            {
                label4.Text= "Yay";
                textBox1.Text="Çoğu durumda “Kendini beğenmiş” olarak mimlenen Yaylar çoğu zaman karşı taraftaki kişileri küçümser. Bu sebeple bir Yay erkek veya kadının gerçekten tanımıyorsanız kesinlikle elektrik alamayabilirsiniz. Tanıdıkça aslında kendini beğenmişlik durumunun kendilerine hissettikleri güvenden olduğunu anlayabilirsiniz. Bazı kişilerde narsistik düzeyine ulaşan kendini beğenme durumu, bazı kişilerde daha dengeli ve iyimser boyutta kabul edilebilir. Araştırmacı kişilikleri nedeniyle yeni şeyler öğrenmek, yeni yerler gezmek ve keşifler yapmak tam olarak da ateş grubunun güçlü burçlarından Yay’a göredir. Yaptıkları işlerde, arkadaş ortamlarında ve hayatın genel olarak her alanında ünlü olmayı seven bu burç kişileri aynı zamanda oldukça girişken bir yapıya sahiptirler. Kendilerine olan aşırı güveniyle asla her olaya anında atılan yayların ellerinden bir uçan bir kaçan kurtulabilir. Öncü olmak ve olayları yönetmeye bayılan Yay burcu kişileri kendisi gibi olan insanlarla kolay kolay anlaşamaz ve genellikle İkizler burcundan kişilerle arkadaşlık kurmaları çok zor olur. Bu nedenle çevrelerinde genellikle yönetilebilecek kişiler bulunur. Giyim konusunda da standart tarzlardan hoşlanmayan ve kendilerine has kıyafetleri taşımaktan hoşlandıklarını söyleyebiliriz.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\yay.jpg";
            }
            else if (gun >= 01 && gun <= 21 && ay == 12)
            { label4.Text = "Yay";
             textBox1.Text="Çoğu durumda “Kendini beğenmiş” olarak mimlenen Yaylar çoğu zaman karşı taraftaki kişileri küçümser. Bu sebeple bir Yay erkek veya kadının gerçekten tanımıyorsanız kesinlikle elektrik alamayabilirsiniz. Tanıdıkça aslında kendini beğenmişlik durumunun kendilerine hissettikleri güvenden olduğunu anlayabilirsiniz. Bazı kişilerde narsistik düzeyine ulaşan kendini beğenme durumu, bazı kişilerde daha dengeli ve iyimser boyutta kabul edilebilir. Araştırmacı kişilikleri nedeniyle yeni şeyler öğrenmek, yeni yerler gezmek ve keşifler yapmak tam olarak da ateş grubunun güçlü burçlarından Yay’a göredir. Yaptıkları işlerde, arkadaş ortamlarında ve hayatın genel olarak her alanında ünlü olmayı seven bu burç kişileri aynı zamanda oldukça girişken bir yapıya sahiptirler. Kendilerine olan aşırı güveniyle asla her olaya anında atılan yayların ellerinden bir uçan bir kaçan kurtulabilir. Öncü olmak ve olayları yönetmeye bayılan Yay burcu kişileri kendisi gibi olan insanlarla kolay kolay anlaşamaz ve genellikle İkizler burcundan kişilerle arkadaşlık kurmaları çok zor olur. Bu nedenle çevrelerinde genellikle yönetilebilecek kişiler bulunur. Giyim konusunda da standart tarzlardan hoşlanmayan ve kendilerine has kıyafetleri taşımaktan hoşlandıklarını söyleyebiliriz.";
             pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\yay.jpg";
            }
          
            if (gun >= 01 && gun <= 21 && ay == 01)
            {   label4.Text = "Oğlak";
                textBox1.Text="22 Aralık ve 21 Ocak aralığı Oğlak burcu tarihi olarak kabul edilir ve bu tarihler arasında toprak grubunun kararlı yapısıyla dikkat çeken burcu olarak karşımıza çıkar. Direniş doğal olarak yapısında bulunan oğlak burcu tarihi yeni burç tarihlerine göre 20 Ocak- 15 Şubat aralığını kapsıyor ve tam olarak 27 gün döngüsünde sayılıyor. Yükseklere ulaşmak ve zirvede kalmayı hedefleyen Oğlak burcu kişilerinin çok fazla meraklı olması çoğu zaman sevilmez. Ancak kararlı yapısı ve önlem almadan duramıyor olması çoğu zaman risklerden kolayca kurtulmasını sağlayabilir. Satürn yönetici yıldızı etkisinde ilerleyen bu burca sahip kişilerin çok güçlü değer yargıları vardır. Sabırlı yapıları ve sorumluluk duygusu yüksek kişiler olması nedeniyle de olaylar ve kişiler karşısında soğukkanlı bir şekilde kalabilirler. İş hayatlarına fazla düşkün olan Oğlaklar eğer dengeyi iyi kuramazsa özel hayatlarını ihmal edebilirler. Rahatlığa fazlasıyla önem verdikleri için hayatlarının her alanında keyifli olmaya özen gösterirler. Genellikle koyu saç rengine sahip olan Oğlak burcu kişilerinin özellikle de çene hatları oldukça keskin olur. İlerleyen yaşlarda da bu durumun giderek oturmaya başlaması özellikle erkek Oğlaklara karizmatik bir hava katabilir.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\oglak.jpg";
            }
            else if (gun >= 22 && gun <= 31 && ay == 12)
            {  label4.Text = "Oğlak";
             textBox1.Text="22 Aralık ve 21 Ocak aralığı Oğlak burcu tarihi olarak kabul edilir ve bu tarihler arasında toprak grubunun kararlı yapısıyla dikkat çeken burcu olarak karşımıza çıkar. Direniş doğal olarak yapısında bulunan oğlak burcu tarihi yeni burç tarihlerine göre 20 Ocak- 15 Şubat aralığını kapsıyor ve tam olarak 27 gün döngüsünde sayılıyor. Yükseklere ulaşmak ve zirvede kalmayı hedefleyen Oğlak burcu kişilerinin çok fazla meraklı olması çoğu zaman sevilmez. Ancak kararlı yapısı ve önlem almadan duramıyor olması çoğu zaman risklerden kolayca kurtulmasını sağlayabilir. Satürn yönetici yıldızı etkisinde ilerleyen bu burca sahip kişilerin çok güçlü değer yargıları vardır. Sabırlı yapıları ve sorumluluk duygusu yüksek kişiler olması nedeniyle de olaylar ve kişiler karşısında soğukkanlı bir şekilde kalabilirler. İş hayatlarına fazla düşkün olan Oğlaklar eğer dengeyi iyi kuramazsa özel hayatlarını ihmal edebilirler. Rahatlığa fazlasıyla önem verdikleri için hayatlarının her alanında keyifli olmaya özen gösterirler. Genellikle koyu saç rengine sahip olan Oğlak burcu kişilerinin özellikle de çene hatları oldukça keskin olur. İlerleyen yaşlarda da bu durumun giderek oturmaya başlaması özellikle erkek Oğlaklara karizmatik bir hava katabilir.";
             pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\oglak.jpg";
            }

            if (gun >= 01 && gun <= 23 && ay == 8)
            {
                label4.Text = "Aslan";
                textBox1.Text = "Her ne kadar da yeni burç tarihleri sıralamasında 11 Ağustos- 16 Eylül aralığı Aslan burcu kabul ediliyor olsa da normal sıralaması 23 Temmuz- 22 Ağustos olarak kabul edilir. Bu sebeple biz yeni tarihler değil, normal kabul gören tarihlere göre Aslan burcunu yorumlayacak olursak; yönetici yıldızı güneş olarak ateş grubunun güçlü burçlarından biridir diyebiliriz. Plan kurmak, herhangi bir olayı organize etmek tam da Aslan burcuna sahip kişilere özel bir yetenek. Yaratıcılıklarını aşırı detaycı olmalarıyla birleştiren bu kişilerin gözünden kaçabilecek en ufak bir detay bile bulunmuyor. Oldukça cömert olan bu kişiler hayat emeli olarak hep yüksekleri hedefler. Her ne iş yapıyorlarsa yapsınlar en iyisi olmak, yüksekleri arzulamak tam da onlara göre bir durum. Bu durum çoğu zaman kendilerini aşırı beğenme olarak geri dönerek etrafındakileri rahatsız etse de pozitiflikleri ile her koşulda kendilerini kabul ettirmeyi başarırlar.";
                pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\aslan.jpg";
            }
            else if (gun >= 22 && gun <= 31 && ay == 7)
            {
                label4.Text = "Aslan";
             textBox1.Text = "Her ne kadar da yeni burç tarihleri sıralamasında 11 Ağustos- 16 Eylül aralığı Aslan burcu kabul ediliyor olsa da normal sıralaması 23 Temmuz- 22 Ağustos olarak kabul edilir. Bu sebeple biz yeni tarihler değil, normal kabul gören tarihlere göre Aslan burcunu yorumlayacak olursak; yönetici yıldızı güneş olarak ateş grubunun güçlü burçlarından biridir diyebiliriz. Plan kurmak, herhangi bir olayı organize etmek tam da Aslan burcuna sahip kişilere özel bir yetenek. Yaratıcılıklarını aşırı detaycı olmalarıyla birleştiren bu kişilerin gözünden kaçabilecek en ufak bir detay bile bulunmuyor. Oldukça cömert olan bu kişiler hayat emeli olarak hep yüksekleri hedefler. Her ne iş yapıyorlarsa yapsınlar en iyisi olmak, yüksekleri arzulamak tam da onlara göre bir durum. Bu durum çoğu zaman kendilerini aşırı beğenme olarak geri dönerek etrafındakileri rahatsız etse de pozitiflikleri ile her koşulda kendilerini kabul ettirmeyi başarırlar.";
             pictureBox2.ImageLocation = "C:\\Users\\asus\\Desktop\\udemy kurs\\Burc_Program_Deneme\\burc\\aslan.jpg";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            pictureBox2.Hide();
            label4.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Hide();
            pictureBox2.Hide();
            textBox1.Hide();
        }
    }
}
