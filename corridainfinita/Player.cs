using FFImageLoading.Maui;

namespace CorridaInfinita;
public delegate void Callback();
public class Player : Animacao
{

    public Player (CachedImageView a) : base( a )
{
    for (int i =1; i <= 4; i++)
        Animacao1.Add($"player{i.ToString("D2")}.png");
    for (int i=1; i <= 6; ++i)
        Animacao2.Add($"playerdead{i.ToString("D2")}.png");
}
    public void Run()
    {
        Loop=true;
        SetAnimacaoAtiva(1);
        Play();
    }
    public void Die()
    {
        Loop=false;
        SetAnimacaoAtiva(2);
    }
    public void MoveY(int S)
    {
        ImageView.TranslationY += S;
    }
    public double GetY ()
    {
        return ImageView.TranslationY;
    }
    public void SetY (double a)
    {
        ImageView.TranslationY = a;
    }
}