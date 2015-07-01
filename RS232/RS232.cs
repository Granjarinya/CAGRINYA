using System;
using System.IO.Ports;
namespace RS232
{
	internal class RS232
	{
		public SerialPort Puerto;
		public void config(SerialPort serialport, string puerto_com, int baudios, int num_bit, StopBits bitstop, Parity paridad)
		{
			this.Puerto = serialport;
			this.cerrar();
			this.Puerto.PortName = puerto_com;
			this.Puerto.BaudRate = baudios;
			this.Puerto.DataBits = num_bit;
			this.Puerto.StopBits = bitstop;
			this.Puerto.Parity = paridad;
			this.Puerto.Open();
		}
		public void cerrar()
		{
			this.Puerto.Close();
		}
		public void enviar(byte[] datos, int longitud_datos)
		{
			this.Puerto.Write(datos, 0, longitud_datos);
		}
		public string recibir()
		{
			int bytesToRead = this.Puerto.BytesToRead;
			byte[] array = new byte[bytesToRead];
			this.Puerto.Read(array, 0, bytesToRead);
			return Convert.ToString(array);
		}
	}
}
