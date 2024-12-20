using FFImageLoading.Maui;

namespace corridainfinita;
public class Animacao
{
    protected List<String> Animacao1 = new List<String>();
    protected List<String> Animacao2 = new List<String>();
    protected List<String> Animacao3 = new List<String>();
    int frameAtual =1;
    protected  CachedImageView ImageView;

    protected bool Loop=true;
    protected int animacaoAtiva=1;
    bool parado=true;
    public Animacao(CachedImageView a)
    {
        ImageView = a;
    }
    public void Stop()
    {
        parado=true;
    }
    public void Play()
    {
        parado=false;
    }
    public void SetAnimacaoAtiva(int a)
    {
        animacaoAtiva=a;
    }
    public void Desenhar()
    {
        if(parado)
           return;
        String NomeArquivo="";
        int tamanhoAnimacao=0;
        if(animacaoAtiva==1)
        {
            NomeArquivo=Animacao1[frameAtual];
            tamanhoAnimacao=Animacao1.Count;
        }
        else if (animacaoAtiva==2)
        {
            NomeArquivo=Animacao2[frameAtual];
            tamanhoAnimacao=Animacao2.Count;
        }
        else if (animacaoAtiva==3)
        {
            NomeArquivo=Animacao3[frameAtual];
            tamanhoAnimacao=Animacao3.Count;
        }
        ImageView.Source=ImageSource.FromFile(NomeArquivo);
        frameAtual++;
        if(frameAtual >=tamanhoAnimacao)
        {
            if (Loop)
              frameAtual=0;
            else 
            {
                parado=true;
                QuandoParar();
            }
        }
    }
    public virtual void QuandoParar()
    {
        
    }
}