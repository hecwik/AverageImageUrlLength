// See https://aka.ms/new-console-template for more information
using AverageImageUrlLength.CharacterCounter;

Counter counter = new Counter();

string urlString = "https://www.incimages.com/uploaded_files/image/1920x1080/getty_655998316_2000149920009280219_363765.jpg";
string urlString1 = "https://www.expatnest.com/wp-content/uploads/2021/11/top-10-expat-books-2021_expat-nest_expat-bookshop-1200x805.jpg";
string urlString2 = "https://thumbs.dreamstime.com/z/gamla-b%C3%B6cker-med-flygande-bokst%C3%A4ver-och-magiskt-ljus-p%C3%A5-bakgrunden-till-bokhyllan-i-biblioteket-som-en-symbol-f%C3%B6r-218640948.jpg";
string urlString3 = "https://thumbs.dreamstime.com/z/dr-suess-children-books-32419132.jpg";
string urlString4 = "https://thumbs.dreamstime.com/z/universitetar-f%C3%B6r-skola-f%C3%B6r-bokgrupph%C3%B6gskoleutbildning-16441446.jpg";
string urlString5 = "http://evasimkesyan.com/files/2010/10/books.JPG";
string urlString6 = "https://i.guim.co.uk/img/media/d305370075686a053b46f5c0e6384e32b3c00f97/0_50_5231_3138/master/5231.jpg?width=620&quality=45&auto=format&fit=max&dpr=2&s=3978a4df27932b7882dd741a1a84a3b3";
string urlString7 = "https://learnenglishteens.britishcouncil.org/sites/teens/files/styles/article/public/rs7364_thinkstockphotos-515067268-low.jpg?itok=6PTAbSRX";
string urlString8 = "https://media.gatesnotes.com/-/media/Images/Books/Klara-and-the-Sun/klara_and_the_sun_20210827_article-hero_1200x564.ashx";
string urlString9 = "https://img-cdn.inc.com/image/upload/w_1920,h_1080,c_fill/images/panoramic/GettyImages-577674005_492115_zfpgiw.jpg";
string urlString10 = "https://www.cleveland.com/resizer/FxeE7iH2BcukyUzZ_Su-ZTh7wa4=/800x0/smart/cloudfront-us-east-1.images.arcpublishing.com/advancelocal/IO77FVYTZFBPPHBRBUCFOZ32PI.JPG";




List<string> uL = new List<string>();


uL.Add(urlString);
uL.Add(urlString1);
uL.Add(urlString2);
uL.Add(urlString3);
uL.Add(urlString4);
uL.Add(urlString5);
uL.Add(urlString6);
uL.Add(urlString7);
uL.Add(urlString8);
uL.Add(urlString9);
uL.Add(urlString10);


Console.WriteLine(counter.CountCharacters(urlString + urlString1 + urlString2 + urlString3 + urlString4));
Console.WriteLine("Number of strings: " + uL.Count());

Console.WriteLine($"Average characters in URL links: {counter.NumberOfCharacters((urlString + urlString1 + urlString2 + urlString3 + urlString4)) / uL.Count()}  ");
