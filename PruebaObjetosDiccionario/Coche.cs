using System;
using System.Collections;
namespace PruebaObjetosDiccionario
{
	public class Coche
	{
		private int velocidad = 0;
		private string marca = "";
		private int matricula = 0;
		private string color = "";
		private bool estaParado = false;
		private int orientacion = 0;/// <summary>
									/// 0-arriba  1-abajo  2-izquierda  3-derecha
									/// </summary>

		public Coche(string marca, int matricula, int velocidad, string color, bool estaParado, int orientacion)
		{
			this.marca = marca;
			this.matricula = matricula;
			this.color = color;
            this.velocidad = velocidad;
            this.estaParado = false;
			this.orientacion = orientacion;
		}
		public Coche()
		{

		}

		public int getMatricula() { return matricula; }
		public string getColor() { return color; }
		public string getMarca() { return marca; }
		public int getVelocidad() { return velocidad; }
		public bool getEstaParado() { return estaParado; }
		public int getOrientacion() { return orientacion; }
		public void setColor(string color)
		{
			this.setColor(color);
		}
		public void setMatricula(int matricula)
		{
			this.setMatricula(matricula);
		}
		public void setMarca(string marca)
		{
			this.setMarca(marca);
		}
		public void setVelocidad(int velocidad)
		{
			this.setVelocidad(velocidad);
		}
		public void setEstaParado(bool estaParado)
		{
			this.setEstaParado(estaParado);
		}
		public void setOrientacion(int orientacion)
		{
			this.setOrientacion(orientacion);
		}
	}

}
