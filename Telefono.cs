//using 
using System;

//namespaces
namespace Mobiles{
	
	//clase
	public class Telefono(){
	
		//atributos
		public string modelo;
		public string color;
		public double alto;
		public double ancho;
		public string pantalla;
		
		//propiedades
		#region Propiedades
		public string Modelo
		{
			get{
				return modelo;
			}
			set{
				modelo = value;
			}
		}
		
		
		
		public double Alto{
			get{
				return alto;
			}
			set{
				alto = value;
			}
		}
		
		public double Ancho{
			get{
				return ancho;
			}
			set{
				ancho = value;
			}
		}
		
		public string Tamano{
			
			get 
			{
				return ancho + " x " + alto;
			}
		
		}
		#endregion
		
		
		public bool Llamar(){
			//.....
			if(haySeñal){
				return true;
			}
			else{
			   return false;
			}			
		}
		
		
	}	
}
