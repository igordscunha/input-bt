ArvoreBinaria arvore = new ArvoreBinaria();

arvore.Inserir(50);
arvore.Inserir(30);
arvore.Inserir(60);
arvore.Inserir(40);
arvore.Inserir(180);
arvore.Inserir(90);
arvore.Inserir(80);
arvore.Inserir(150);
arvore.Inserir(110);

if (arvore.raiz != null)
{
    Console.WriteLine("Árvore em ordem:");
    arvore.OrdemCrescente(arvore.raiz);
    Console.WriteLine();

}
else
{
    Console.WriteLine("A árvore está vazia.");
}


public class No
{
    public int data;
    public No? esquerda, direita;

    public No(int valor)
    {
        data = valor;
        esquerda = direita = null;
    }
}

public class ArvoreBinaria
{
    public No? raiz;

    public ArvoreBinaria()
    {
        raiz = null;
    }

    public No InserirRecursivo(No raiz, int valor)
    {
        if (raiz == null)
        {
            raiz = new No(valor);
            return raiz;
        }

        if (valor < raiz.data)
            raiz.esquerda = InserirRecursivo(raiz.esquerda, valor);

        else if (valor > raiz.data)
        {
            raiz.direita = InserirRecursivo(raiz.direita, valor);
        }

        return raiz;
    }

    public void Inserir(int valor)
    {
        raiz = InserirRecursivo(raiz, valor);
    }

    public void OrdemCrescente(No raiz)
    {
        if (raiz != null)
        {

            OrdemCrescente(raiz.esquerda);

            Console.WriteLine(raiz.data + " ");

            OrdemCrescente(raiz.direita);

        }
    }
}