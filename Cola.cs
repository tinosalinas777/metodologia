namespace practica;

class Cola : Icoleccionable
{
    private List<Comparable> elementos;
		
	public Cola()
    {
        this.elementos = new List<Comparable>();
    }
    public void encolar (Comparable c){
        this.elementos.Insert(this.elementos.Count,c);
    }
    public Comparable desencolar (){
        Comparable c =  this.elementos[0];
		this.elementos.RemoveAt(0);
		return c;
	}

    public void Agregar(Comparable c)
    {
        encolar(c);
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

    public int Cuantos()
    {
        return this.elementos.Count;
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

    public Comparable Minimo()
    {
        Comparable c=this.elementos[0];
        for(int i=1; i < this.Cuantos();i++){
            if(this.elementos[i].sosMenor(c)){
                c=this.elementos[i];
            }

        }
        return c;
    }
}