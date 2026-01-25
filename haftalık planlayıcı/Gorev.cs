using System.Drawing;

namespace HaftalikAjanda
{
    public class Gorev
    {
        public string Metin { get; set; }
        public Color Renk { get; set; }

        public Gorev(string metin)
        {
            Metin = metin;
            Renk = Color.LightGray;
        }
    }
}
