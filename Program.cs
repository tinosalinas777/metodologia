namespace practica;
class Program
{
    static void Main(string[] args)
    {
        //ejercicio 5 tp1
        void llenar(Icoleccionable colec){
			
			Random random = new Random();
			
			for(int i=0; i< 20; i++) {
				colec.Agregar(new Numero(random.Next(40)));
			}
		}

        //Ejercicio 6 TP 1
	    void informar(Icoleccionable colec){
			
			
			Console.WriteLine("Numero maximo: "+colec.Maximo().ToString());
			Console.WriteLine("Numero minimo: "+colec.Minimo().ToString());
			Console.WriteLine("Cantidad: "+colec.Cuantos().ToString());
			Console.WriteLine("Ingrese el numero que quiere buscar: ");
			
			Comparable c = new Numero(Int32.Parse(Console.ReadLine()));
			if(colec.Contiene(c)){
				Console.WriteLine("El elemento leido está en la coleccion");
			}else{
				Console.WriteLine("El elemento leido no está en la coleccion");
			}
			
		}
		void informarPersona(Icoleccionable colec){
			
			
			Console.WriteLine("Persona maximo: "+colec.Maximo());
			Console.WriteLine("Persona minimo: "+colec.Minimo());
			Console.WriteLine("Cantidad: "+colec.Cuantos());
			Console.WriteLine("Ingrese el DNI que quiere buscar: ");
			int num=int.Parse(Console.ReadLine());
			Comparable c = new Persona("p",num);
			//Console.WriteLine();
			if(colec.Contiene(c)){
				Console.WriteLine("El elemento leido está en la coleccion");
			}else{
				Console.WriteLine("El elemento leido no está en la coleccion");
			}
			
		}
		void informarAlumno(Icoleccionable colec){
			
			
			Console.WriteLine("Persona maximo: "+colec.Maximo());
			Console.WriteLine("Persona minimo: "+colec.Minimo());
			Console.WriteLine("Cantidad: "+colec.Cuantos());
			Console.WriteLine("Ingrese el DNI que quiere buscar: ");
			int num=int.Parse(Console.ReadLine());
			Random vv= new Random();
			Comparable c = new Alumno("p",num,vv.Next(4),vv.Next(10));
			
			if(colec.Contiene(c)){
				Console.WriteLine("El elemento leido está en la coleccion");
			}else{
				Console.WriteLine("El elemento leido no está en la coleccion");
			}
			
		}
        //Ejecicio 7 tp1
        Pila pila = new Pila();
		Cola cola = new Cola();
		ColeccionMultiple colecM=new ColeccionMultiple(pila,cola);
			
			
			
	    llenar(pila);
	    llenar(cola);
	        
	    Console.WriteLine("***Informe de la pila***");
	        
	    informar(pila);
	        
	    Console.WriteLine("***Informe de la cola***");
	        
	    informar(cola);

		Console.WriteLine("***informe coleccion multiple***");

		informar(colecM);
		//ejercicio 13 tp1

		Pila pil= new Pila();
		Cola col=new Cola();
		ColeccionMultiple c = new ColeccionMultiple(pil,col);
		llenarPersonas(pil);
		llenarPersonas(col);
		
		informarPersona(pil);
		//ejercicio 17 tp1
		Pila pil1= new Pila();
		Cola cola1= new Cola();
		ColeccionMultiple colM1=new ColeccionMultiple(pil1,cola1);

		llenarAlumnos(pil1);
		llenarAlumnos(cola1);
		informarAlumno(colM1);




	    void llenarPersonas(Icoleccionable col){//ejercicio 12 tp1
		
		    Random random = new Random();
			
		    for(int i=0; i< 20; i++) {
				Persona a = new Persona("persona "+random.Next(40).ToString(),random.Next(40));
				Console.WriteLine(a.getNombre());
				col.Agregar(a);
		    }
		}
		void llenarAlumnos(Icoleccionable col){//ejercicio 16 tp1
		
		    Random random = new Random();
			
		    for(int i=0; i< 20; i++) {
				Alumno a = new Alumno("p",random.Next(6),random.Next(4),random.Next(10));
				Console.WriteLine(a.getNombre()+a.getDNI()+a.getPromedio());
				col.Agregar(a);
		    }
		}
	        
	        
        



        


        Console.WriteLine("toque una tecla para terminar");
        Console.ReadKey();
    }
        
 
   
    
}


