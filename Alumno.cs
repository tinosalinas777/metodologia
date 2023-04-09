namespace practica;

class Alumno : Persona       //ejercicio 15 tp1
{
    protected int legajo;
    protected int promedio;

    public Alumno(string n,int d,int l,int p):base(n,d)
    {
        this.legajo=l;
        this.promedio=p;

    }
    public int getLegajo(){
        return this.legajo;
    }
    public int getPromedio(){
        return this.promedio;
    }
    public override bool sosIgual(Comparable a){
        if(this.getLegajo()==((Alumno)a).getLegajo())
        {
            return true;

        }
        return false;
    }
    public override bool sosMayor(Comparable a)
    {
        if(this.getLegajo()<((Alumno)a).getLegajo())
        {
            return false;

        }
        return true;
    }
    public override bool sosMenor(Comparable a)
    {
        if(this.getLegajo()>((Alumno)a).getLegajo())
        {
            return false;

        }
        return true;
    }

}