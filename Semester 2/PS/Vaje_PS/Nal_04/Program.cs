using System;
using System.Collections.Generic;

namespace Nal_04
{
	public class IskalnoDrevo
	{
		/// <summary>
		/// Vgnezden razred Vozlisce
		/// definira zametek razreda Vozlisce, namenjenega interni
		/// rabi (tj. samo znotraj razreda IskalnoDrevo).
		/// 
		/// Razred Vozlisce predstavlja tip, ki pomaga notranje 
		/// urediti drevesno podatkovno strukturo.
		/// 
		/// Skelet vsebuje ob konstruktorju, ki prejme podatek in
		/// kopirnem konstruktorju, se metode:
		/// - osnovne funkcionalnosti
		///   - vstavi()
		/// - razsirjene funkcionalnosti
		///   - size()
		/// - dodatne funkcionalnosti
		///   - najvecji()
		///   - najmanjsi()
		///   - narascajocaVrsta()
		///   - padajocaVrsta()
		///   - prefixQueue()
		///   - infixQueue()
		///   - postfixQueue()
		/// </summary>
		class Vozlisce
		{
			private float podatek;
			private Vozlisce levo;
			private Vozlisce desno;

			/// <summary>
			/// Konstuktor, ki prejme podatek, ki ga nato hrani
			/// ustvarjeno Vozlisce.
			/// </summary>
			/// <remarks>
			/// Leva in desna veja kazeta v prazno (null).
			/// </remarks>
			/// <param name="podatek">
			/// Podatek (decimalno stevilo - tipa <see cref="System.Float"/>), 
			/// ki ga hrani vozlisce.
			/// </param>
			public Vozlisce(float podatek)
			{
				this.podatek = podatek;
				levo = null;
				desno = null;
			}

			//kopirni konstruktor
			public Vozlisce(Vozlisce original)
			{
				this.podatek = original.podatek;
				levo = null;
				desno = null;

				if (original.levo != null)
					levo = new Vozlisce(original.levo);
				if (original.desno != null)
					desno = new Vozlisce(original.desno);
			}

			/// <summary>
			/// Metoda vstavi podan podatek v Vozlisce na naslednjem nivoju,
			/// ali na katerem od visjih nivojev v drevesu vozlisc.
			/// </summary>
			/// <remarks>
			/// Ce je ustrezna veja, kamor po pravilih dvojiskega (stopnja_drevesa==2)
			/// iskalnega drevesa spada podan podatek, ze "polna", metoda "rekurzivno" klice
			/// vstavljanje podatka nad najvisjim vozliscem te veje drevesa.
			/// </remarks>
			/// <param name="podatek">
			/// Podatek (decimalno stevilo - tipa <see cref="System.Float"/>), ki se hrani 
			/// v novo Vozlisce na naslednjem nivoju ali na katerem od visjih nivojev v 
			/// drevesu vozlisc.
			/// </param>
			public void vstavi(float podatek)
			{
				if (podatek < this.podatek)
				{
					if (levo == null)
						levo = new Vozlisce(podatek);
					else
						levo.vstavi(podatek);
				}
				else
				{   //when (podatek >= this.podatek)
					if (desno == null)
						desno = new Vozlisce(podatek);
					else
						desno.vstavi(podatek);
				}
			}

			public int size()
			{
				int stevec = 1;
				if (desno != null)
					stevec += desno.size();
				if (levo != null)
					stevec += levo.size();
				return stevec;

			}

			public float najvecji()
			{
				Vozlisce naslednji = this;
				while (naslednji.desno != null)
				{
					naslednji = naslednji.desno;
				}
				return naslednji.podatek;
			}

			public float najmanjsi()
			{
				Vozlisce naslednji = this;
				while (naslednji.levo != null)
				{
					naslednji = naslednji.levo;
				}
				return naslednji.podatek;

			}

			public void narascajocaVrsta(Queue<float> vrsta)
			{
				infixQueue(vrsta);
			}

			public void padajocaVrsta(Queue<float> vrsta)
			{
				if (desno != null)
					desno.padajocaVrsta(vrsta);
				vrsta.Enqueue(podatek);
				if (levo != null)
					levo.padajocaVrsta(vrsta);
			}

			public void prefixQueue(Queue<float> vrsta)
			{

				vrsta.Enqueue(podatek);
				if (levo != null)
					levo.prefixQueue(vrsta);

				if (desno != null)
					desno.prefixQueue(vrsta);
			}

			/// <summary>
			/// Metoda, ki vrne (vse) hranjene elemente urejene po
			/// vrstnem redu, kot ga ustvari infiksni pregled 
			/// dvojiskega (stopnja_drevesa==2) drevesa.
			/// </summary>
			/// <param name="vrsta">
			/// Po izvedbi metode: Vrsta (tipa <see cref="Queue<System.Float>"/>) 
			/// hranjenih stevil v vrstnem redu, kot ga dobimo po infiksnem prehodu 
			/// dvojiskega (stopnja_drevesa==2) drevesa.
			/// </param>
			public void infixQueue(Queue<float> vrsta)
			{
				if (levo != null)
					levo.infixQueue(vrsta);
				vrsta.Enqueue(podatek);
				if (desno != null)
					desno.infixQueue(vrsta);
			}

			public void postfixQueue(Queue<float> vrsta)
			{
				if (levo != null)
					levo.postfixQueue(vrsta);
				if (desno != null)
					desno.postfixQueue(vrsta);
				vrsta.Enqueue(podatek);
			}
		}   //end class Vozlisce

		//lastnosti
		Vozlisce koren;

		//privzeti konstruktor
		public IskalnoDrevo()
		{
			this.koren = null;
		}

		//kopirni konstruktor
		public IskalnoDrevo(IskalnoDrevo original)
		{
			koren = new Vozlisce(original.koren);
		}

		/// <summary>
		/// Metoda vstavi podan podatek v koren oz.
		/// na katerega od visjih nivojev drevesa.
		/// </summary>
		/// <remarks>
		/// Ce drevo ni prazno, klice (rekurzivno) vstavljanje nad 
		/// korenskim vozliscem.
		/// </remarks>
		/// <param name="podatek">
		/// Podatek (decimalno stevilo - tipa <see cref="System.Float"/>) 
		/// ki se hrani v korensko Vozlisce ali katerega od vozlisc na 
		/// visjem nivoju v drevesu.
		/// </param>
		public void vstavi(float podatek)
		{
			if (empty())
				koren = new Vozlisce(podatek);
			else
				koren.vstavi(podatek);
		}

		/// <summary>
		/// Metoda javi ali je drevo prazno (vrne "true") ali ne
		/// (vrne "false").
		/// </summary>
		/// <remarks>
		/// Preveri samo ali je kazalec na korensko Vozlisce null ali
		/// ne.
		/// </remarks>
		/// <returns>
		/// (tip <see cref="System.Boolean"/>) Vrne "true", ce drevo 
		/// "nima korenskega vozlisca" oz. "false", ce ga ima.
		/// </returns>
		public bool empty()
		{
			return (koren == null);
		}

		/// <summary>
		/// Presteje in vrne stevilo hranjenih elementov v iskalnem
		/// drevesu.
		/// </summary>
		/// <remarks>
		/// Kadar drevo ima korensko Vozlisce, se dejanski
		/// izracun(/stetje) stevila hranjenih elementov zgodi v
		/// metodi IskalnoDrevo.Vozlisce.size() zacensi nad
		/// korenskim vozliscem drevesa.
		/// </remarks>
		/// <returns>
		/// Stevilo hranjenih elementov(/vozlisc) v tem drevesu 
		/// (tipa <see cref="System.Int32"/>) oz. 0, ce drevo 
		/// nima korenskega vozlisca.
		/// </returns>
		public int size()
		{
			if (koren == null/*empty()*/)
				return 0;
			else
				return koren.size();
		}

		//metode za dodatno funkcionalnost
		public float najvecjiElement()
		{
			if (koren != null)
				return koren.najvecji();
			return float.NaN;   //HACK: dummy return
		}

		public float najmanjsiElement()
		{
			if (koren != null)
				return koren.najmanjsi();
			return float.NaN;   //HACK: dummy return
		}


		/// <summary>
		/// Metoda s pomocjo pregleda iskalnega drevesa vrne vrsto (vseh) hranjenih
		/// elementov po narascajocem vrstnem redu.
		/// </summary>
		/// <returns>
		/// Vrsta decimalnih stevil (tipa <see cref="Queue<System.Float>"/>) , 
		/// urejenih narascajoce.
		/// </returns>
		public Queue<float> narascajocaVrsta()
		{
			Queue<float> narascajoca = new Queue<float>();
			if (koren != null)
				koren.narascajocaVrsta(narascajoca);
			return narascajoca;
		}

		public Queue<float> padajocaVrsta()
		{
			Queue<float> padajoca = new Queue<float>();
			if (koren != null)
				koren.padajocaVrsta(padajoca);
			return padajoca;
		}


		public Queue<float> prefixQueue()
		{
			Queue<float> prefix = new Queue<float>();
			if (koren != null)
				koren.prefixQueue(prefix);
			return prefix;
		}

		public Queue<float> infixQueue()
		{
			return narascajocaVrsta();
		}
		public Queue<float> postfixQueue()
		{
			Queue<float> post = new Queue<float>();
			if (koren != null)
				koren.postfixQueue(post);
			return post;
		}
	}   //end class IskalnoDrevo

	public class Test
	{
		static float min_element(float[] zaporedje)
		{
			if (zaporedje.Length == 0)
				return float.NaN;
			else if (zaporedje.Length == 1)
				return zaporedje[0];
			float najmanjsi = zaporedje[0];

			foreach (float vrednost in zaporedje)
				if (vrednost < najmanjsi)
					najmanjsi = vrednost;
			return najmanjsi;
		}

		static bool test_najmanjsi_element()
		{
			string opis_scenarija = "Vrni najmanjsi element v iskalnem drevesu.";
			string ime_metode = "float IskalnoDrevo.najmanjsiElement()";
			try
			{
				//stevila
				float[] zaporedje = { 1.1f, -9.9f, 16.16f, -25.25f, -1.1f, 4.4f, 36.36f, -16.16f, -4.4f, .0f, 9.9f, 25.25f, 49.49f };
				//priprava IskalnoDrevo
				IskalnoDrevo id = new IskalnoDrevo();
				for (int i = 0; i < zaporedje.Length; i++)
					id.vstavi(zaporedje[i]);

				//kontrola
				float pricakovana_vrednost = min_element(zaporedje);

				//testing
				if (id.najmanjsiElement() != pricakovana_vrednost)
				{
					Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' ni vrnila pravilnega najmanjsega elementa. ", opis_scenarija, ime_metode);
					return false;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("V testnem scenariju \'{0}\': Metoda \'{1}\' je prozila izjemo. Opis izjeme: \'{2}\'", opis_scenarija, ime_metode, e.Message);
				return false;
			}

			//vse vredu
			return true;
		}

        //glavna metoda
       /* private static void Main(string[] args)
		{
			bool uspesni = true;
			Console.WriteLine("--- zacetek testiranja ---");
			//izvajanje testov
			if (!test_najmanjsi_element())
				uspesni = false;
			// TODO: Tukaj dodajte svoje teste, ki bodo ustrezno preverili, da vasa
			//       implementacija deluje pravilno.



			//povzetek
			if (uspesni)
				Console.Write("Povzetek: Program JE");
			else
				Console.Write("Povzetek: Program ni");
			Console.WriteLine(" uspesno prestal testiranje.");
			Console.WriteLine("--- konec testiranja ---");
			Console.WriteLine();
		}*/
	}
}
