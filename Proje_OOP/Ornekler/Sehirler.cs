namespace Proje_OOP.Ornekler
{
	/*burada sehirler sınıfına bayrak sınıfını miras aldırdık yani bayrak sınıfında ne varsa
	 artık sehırler sınıfında gorunur halde olacaktır */
	public class Sehirler:Bayrak
	{
		public int Id { get; set; }
		public string Ad { get; set; }
		public int Nufus { get; set; }
		public string Ulke { get; set; }
	}
}
