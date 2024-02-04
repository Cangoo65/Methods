using Methods;

int a = 4;
int b = 5;

Console.WriteLine(a+b);

int sonuc= Topla(a,b);

Console.WriteLine(sonuc);

Methodlar Ornek=new Methodlar();
int sonucArt=Ornek.ArtirveTopla(a,b);

Console.WriteLine(sonucArt);
static int Topla(int deger1,int deger2)
{
    return deger1 + deger2;
}
Console.Read();
