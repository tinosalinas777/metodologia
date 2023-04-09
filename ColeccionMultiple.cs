namespace practica;

class ColeccionMultiple : Icoleccionable
{
    public Pila pila;
	public Cola cola;
		
	public ColeccionMultiple(Pila p, Cola c) {
		this.pila = p;
		this.cola = c;
	}

    public void Agregar(Comparable obj)
    {
        
    }

    public bool Contiene(Comparable obj)
    {
        if(pila.Contiene(obj) || cola.Contiene(obj))
		{
			return true;
		}else{
			return false;
		}
    }

    public int Cuantos()
    {
        return this.pila.Cuantos()+this.cola.Cuantos();
    }

    public Comparable Maximo()
    {
        Comparable maxPila = pila.Maximo();
			Comparable maxCola = cola.Maximo();
			
			if(maxCola.sosMayor(maxPila)){
				return maxCola;
			}else{
				return maxPila;
			}
    }

    public Comparable Minimo()
    {
        Comparable minPila = pila.Minimo();
			Comparable minCola = cola.Minimo();
			
			if(minCola.sosMenor(minPila)){
				return minCola;
			}else{
				return minPila;
			}
    }
}