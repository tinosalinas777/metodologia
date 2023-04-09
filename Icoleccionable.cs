namespace practica;

interface Icoleccionable
{
    public int Cuantos();
    public Comparable Minimo();

    public Comparable Maximo();
    public void Agregar(Comparable obj);
    public bool Contiene(Comparable obj);

}