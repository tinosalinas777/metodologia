namespace practica;

class Pila : Icoleccionable
{
    private List<Comparable> elementos;
    public Pila() 
    {
        this.elementos = new List<Comparable>();
    }
    public void push(Comparable c)
    {
        this.elementos.Add(c);
    }
    public Comparable pop() 
    {
        Comparable c = this.elementos[this.elementos.Count -1];
		this.elementos.RemoveAt(this.elementos.Count -1);
        return c;
    }

    public int Cuantos()
    {
        return this.elementos.Count;
    }

    public Comparable Minimo()
    {
        Comparable n = (Comparable)this.elementos[0];
       
		for(int i=1; i < this.Cuantos(); i++) {
			if (this.elementos[i].sosMenor(n)) {
				n= this.elementos[i];
			}
		}
			
		return n;
		
    }

    public Comparable Maximo()
    {
        Comparable c = this.elementos[0];
			
			for(int i=1; i < this.Cuantos(); i++) {
				if (this.elementos[i].sosMayor(c)) {
					c = this.elementos[i];
				}
			}
			
			return c;
    }

    public void Agregar(Comparable c)
    {
        push(c);
    }

    public bool Contiene(Comparable c)
    {
        for(int i=0; i < this.Cuantos(); i++) {
			if (this.elementos[i].sosIgual(c)) {
				return true;
			}
		}
			
		return false;
    }
}
