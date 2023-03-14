namespace HamburgerSiparis;

public class HamburgerOzellikleri
{
    public HamburgerOzellikleri()
    {
        HamburgerSize.Add("Küçük");
        HamburgerSize.Add("Orta");
        HamburgerSize.Add("Büyük");
        Icecekler.Add("Kola");
        Icecekler.Add("Fanta");
        Icecekler.Add("Gazoz");
        Cesitler.Add("Tavuk");
        Cesitler.Add("Et");
        Cesitler.Add("Biftek");
        Cesitler.Add("Pastırma");
        Cesitler.Add("Balık");
        Cesitler.Add("Kaburga");
    }
    public List<string> HamburgerSize { get; set; } = new();
    public List<string> Icecekler { get; set; } = new();
    public List<string> Cesitler { get; set; } = new();
}
