public class Node
{
    private object item;
    private Node prox;

    public Node(object item)
    {
        this.item = item;
        prox = null;
    }
}
public class ListaSimples
{
    public object Primeiro { get; private set; }
    public object Ultimo { get; private set; }

    private Node primeiro, ultimo;
    private int qtdade;

    public ListaSimples()
    {
        primeiro = null;
        ultimo = null;
        qtdade = 0;
    }

    public void InserirInicio(Node novo)
    {
        novo.prox = primeiro;
        primeiro = novo;
        if (ultimo == null)
            ultimo = novo;
        qtdade++;
    }

    public void InserirFim(Node novo)
    {
        if (primeiro == null)
            primeiro = novo;
        else
            ultimo.prox = novo;
        ultimo = novo;
        qtdade++;
    }

    public void InserirPosicao(Node novo, int pos)
    {
        Node aux = primeiro;
        int cont = 0;

        if (pos == 0)
        {
            novo.prox = primeiro;
            if (primeiro == ultimo)
                ultimo = novo;
            primeiro = novo;
        }
        else
        {
            while (aux != null && cont < pos - 1)
            {
                aux = aux.prox;
                cont++;
            }
            if (aux != null)
            {
                novo.prox = aux.prox;
                aux.prox = novo;
            }
            else
            {
                ultimo.prox = novo;
                ultimo = novo;
            }
        }
        qtdade++;
    }

    public int Contar()
    {
        int cont = 0;
        Node aux = primeiro;
        while (aux != null)
        {
            cont++;
            aux = aux.prox;
        }
        return cont;
    }
}
public Node buscaNo(object item)
{
    int i = 0;
    Node aux = primeiro;
    while (aux != null)
    {
        if (aux.getItem() == item)
        {
            return aux;
        }
        i++;
        aux = aux.getProx();
    }
    return null;
}
