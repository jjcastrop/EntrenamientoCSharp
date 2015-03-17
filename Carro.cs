using System;
using CarpetaCarros;

namespace  Vehiculos{

	public class Carro{

		//Atributos
		public string marca;
		public string modelo;
		
		//Constructor
		public Carro(){
		}
		
		public Carro(int velocidad){
		}
		
		//Propiedad
		public string Marca{
			get
			{
				return marca;
			}
			set
			{
				marca = value;
			}
		}
		
		//Metodo
		public string Acelerar()
		{
			/// acelerando 
			return "acelero";
		}
		
		
		public string Acelerar(int velocidad){
			/// acelerando 
			return "acelero";
		}
		
		public string DesAcelerar()
		{
			/// acelerando 
			return "acelero";
		}
		
	}
}
