using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Diagnostics;

namespace noty
{
	public class funkce
	{
		#region fregvence
		//C0 16
		//2
		//d0 18
		//2
		//e0 20
		//1
		//f0 21
		//3
		//g0 24
		//3
		//a0 27
		//3
		//h0 30
		//2

		//c1 32
		//d1 34
		//e1 36
		//f1 37
		//g1 40
		//a1 43
		//h1 46

		//c2 48
		//d2 50
		//e2 52
		//f2 53
		//g2 56
		//a2 59
		//h2 62
		#endregion
		public bool[] errorlevel = new bool[4] {true,true,true,true};
		public string file = "";
		public Window alone;
		public repicecepice anone;
		public Disk dd = new Disk();
		public List<string> visledek = new List<string>();
		private MainWindow main;
		public bool? boolean = null;
		public int CDEFGAHC;
		public bool bylalone = false;
		public bool kill = false;
		public bool otaoz = true;

		public funkce(int count, MainWindow win)
		{
			anone = new repicecepice(this);
			alone = new repicecepice(this);
			main = win;
			interval = count;
			Thread eerr = new Thread(errorl);
			eerr.Start();
		}
		public void puton(bool pn,string nota,int stupen)//ok
		{
			switch (nota)
			{
				case "C":
					if (stupen == 1)
					{
						CDEFGAHC = 32;
					}
					else
					{
						CDEFGAHC = 48;
					}
					break;
				case "D":
					if (stupen == 1)
					{
						CDEFGAHC = 34;
					}
					else
					{
						CDEFGAHC = 50;
					}
					break;
				case "E":
					if (stupen == 1)
					{
						CDEFGAHC = 36;
					}
					else
					{
						CDEFGAHC = 52;
					}
					break;
				case "F":
					if (stupen == 1)
					{
						CDEFGAHC = 37;
					}
					else
					{
						CDEFGAHC = 52;
					}
					break;
				case "G":
					if (1 == stupen)
					{
						CDEFGAHC = 40;
					}
					else
					{
						CDEFGAHC = 56;
					}
					break;
				case "A":
					if (stupen == 1)
					{
						CDEFGAHC = 43;
					}
					else
					{
						CDEFGAHC = 59;
					}
					break;
				case "H":
					if (stupen == 1)
					{
						CDEFGAHC = 46;
					}
					else
					{
						CDEFGAHC = 62;
					}
					break;
				default:
					break;
			}
			if (pn)
			{
				CDEFGAHC =+ 2;
			}
			else
			{
				CDEFGAHC =- 2;
			}
			main.Button_reset();
		}
		public void zahraj()//ok
		{
			if (visledek.Count == 0)
			{
				MessageBox.Show("\"nemohu zahrat nic.\"","ha ha" ,MessageBoxButton.OK,MessageBoxImage.Information);
				errorlevel[3] = false;
				//window.lnoty.Content = "chiba nenuhu zahrat nic.";
			}
			else
			{
				errorlevel[0] = true;
				try
				{
					string[] sssplit;
					char[] chchar;
					chchar = visledek[0].ToCharArray();
					if (chchar.Length != 2)
					{
						for (int i = 0; i < visledek.Count; i++)
						{
							sssplit = visledek[i].Split('|');
							if (visledek[i][1] == 'm')
							{

							}
							else
							{
								switch (sssplit[2].ToString())
								{
									case "C ":
										if (int.Parse(sssplit[1]) == 1)
										{
											CDEFGAHC = 32;
										}
										else
										{
											CDEFGAHC = 48;
										}
										break;
									case "D ":
										if (int.Parse(sssplit[1]) == 1)
										{
											CDEFGAHC = 34;
										}
										else
										{
											CDEFGAHC = 50;
										}
										break;
									case "E ":
										if (int.Parse(sssplit[1]) == 1)
										{
											CDEFGAHC = 36;
										}
										else
										{
											CDEFGAHC = 52;
										}
										break;
									case "F ":
										if (int.Parse(sssplit[1]) == 1)
										{
											CDEFGAHC = 37;
										}
										else
										{
											CDEFGAHC = 52;
										}
										break;
									case "G ":
										if (int.Parse(sssplit[1]) == 1)
										{
											CDEFGAHC = 40;
										}
										else
										{
											CDEFGAHC = 56;
										}
										break;
									case "A ":
										if (int.Parse(sssplit[1]) == 1)
										{
											CDEFGAHC = 43;
										}
										else
										{
											CDEFGAHC = 59;
										}
										break;
									case "H ":
										if (int.Parse(sssplit[1]) == 1)
										{
											CDEFGAHC = 46;
										}
										else
										{
											CDEFGAHC = 62;
										}
										break;
									default:
										errorlevel[2] = false;
										break;
								}
							}
							switch (sssplit[0])
							{
								case "1n":
									Console.Beep(CDEFGAHC * 10, 1000);
									break;
								case "1m ":
									Thread.Sleep(1000);
									break;
								case "2n":
									Console.Beep(CDEFGAHC * 10, 500);
									break;
								case "2m ":
									Thread.Sleep(500);
									break;
								case "4n":
									Console.Beep(CDEFGAHC * 10, 250);
									break;
								case "4m ":
									Thread.Sleep(250);
									break;
								default:
									errorlevel[2] = false;
									break;
							}
						}
					}
				}
				catch (Exception)
				{
					errorlevel[0] = false;
				}
			}
		}
		public string[] args
		{
			get
			{
				if (dd.exist(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt"))
				{
					return dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt").Split(' ');
				}
				else
				{
					dd.WriteFile("", @"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt");
				}
				return dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt").Split(' ');
			}
			set
			{
				if (dd.exist(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt"))
				{
					if (value[0] == "\\r")
					{
						dd.WriteFile(dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt").Split(' ')
							[dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt").Length - value.Length],
							@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt");
						for (int i = 1; i < value.Length; i++)
						{
							dd.WriteFile(value[i], @"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt");
						}
					}
					if (value[0] == "\\rall")
					{
						int i;
						dd.WriteFile("", @"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt");
						for (i = 1; i < value.Length; i++)
						{
							dd.WriteFile(dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt") +
								value[i], @"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt");
						}

					}
					if (value[0] == "\\+")
					{
						dd.WriteFile(dd.ReadFile(@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt") +
							value[1], @"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt");
					}
					if (value[0] == "\\-all")
					{

					}
					//dd.WriteFile(+ value,
					//@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt");
				}
				else
				{
					for (int i = 0; i < value.Length; i++)
					{
						dd.WriteFile(value[i],
							@"C:\Users\Lenka Dembinna\Documents\Visual Studio 2019\ulozenonoty\args.txt");
					}
				}
			}
		}
		public void save()
		{
			if (file.ToCharArray().Length == 0)
			{
				main.save = new Window();
				main.save.Show();
			}
			else
			{
				if (bylalone)
				{
					alone = new repicecepice(this);
					alone.Show();
				}
				else
				{
					alone.Show();
					bylalone = true;
				}
			}
		}
		public void remove(int kolikaty)
		{
			if (visledek.Count + 1 <= kolikaty)
			{
				return;
			}
			if (visledek.Count != 0)
			{
				visledek.Remove(visledek[kolikaty - 1]);
			}
		}
		public void remove(bool lost = true)
		{
			if (lost)
			{
				remove(visledek.Count);
			}
			else
			{
				visledek.Clear();
			}
		}
		public void GetSetVoid(bool OKNo) 
		{
			if (OKNo)
			{
				main.saves.Button_sellect();
			}
			else
			{
				dd.WriteFile("", file + @"\noty.znot");
				for (int i = 0; i < visledek.Count; i++)
				{
					dd.WriteFile(dd.ReadFile(file + @"\noty.znot") + visledek[i], file + @"\noty.znot");
				}
			}
			
		}
		public void button(string jaky ,string nota = "C",int stupen = 1)//ok
		{
			switch (nota)
			{
				case "C":
					if (stupen == 1)
					{
						CDEFGAHC = 32;
					}
					else
					{
						CDEFGAHC = 48;
					}
					break;
				case "D":
					if (stupen == 1)
					{
						CDEFGAHC = 34;
					}
					else
					{
						CDEFGAHC = 50;
					}
					break;
				case "E":
					if (stupen == 1)
					{
						CDEFGAHC = 36;
					}
					else
					{
						CDEFGAHC = 52;
					}
					break;
				case "F":
					if (stupen == 1)
					{
						CDEFGAHC = 37;
					}
					else
					{
						CDEFGAHC = 52;
					}
					break;
				case "G":
					if (stupen == 1)
					{
						CDEFGAHC = 40;
					}
					else
					{
						CDEFGAHC = 56;
					}
					break;
				case "A":
					if (stupen == 1)
					{
						CDEFGAHC = 43;
					}
					else
					{
						CDEFGAHC = 59;
					}
					break;
				case "H":
					if (stupen == 1)
					{
						CDEFGAHC = 46;
					}
					else
					{
						CDEFGAHC = 62;
					}
					break;
				default:
					break;
			}
			switch (jaky)
			{
				case "1n":
					visledek.Add("1n|" + stupen + "|" + nota + " ");
					Console.Beep(CDEFGAHC * 10, 1000);
					break;
				case "1m":
					visledek.Add("1m ");
					break;
				case "2n":
					visledek.Add("2n|" + stupen + "|" + nota + " ");
					Console.Beep(CDEFGAHC * 10, 500);
					break;
				case "2m":
					visledek.Add("2m ");
					break;
				case "4n":
					visledek.Add("4n|" + stupen + "|" + nota + " ");
					Console.Beep(CDEFGAHC * 10, 250);
					break;
				case "4m":
					visledek.Add("4m ");
					break;
				case "8n":
					visledek.Add("8n|" + stupen + "|" + nota + " ");
					Console.Beep(CDEFGAHC * 10, 125);
					break;
				case "8m":
					visledek.Add("8m ");
					break;
				default:
					break;
			}
		}
		public void errorl()//ok
		{
			//kod tredu je [9776]
			while (true)
			{
				if (!errorlevel[0])
				{
					var esne = MessageBox.Show("chyba v kodu upravte hu\nzahraj", "error v kodu", MessageBoxButton.OKCancel, MessageBoxImage.Error, MessageBoxResult.OK);
					if (esne != MessageBoxResult.OK)
					{
						Environment.Exit(0);
					}
					else
					{
						errorlevel[0] = true;
					}
				}
				if (!errorlevel[2])
				{
					var esne = MessageBox.Show("chyba v kodu upravte hu\nzahraj\tswitch\to ton", "error v kodu", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
					if (esne != MessageBoxResult.OK)
					{
						Environment.Exit(0);
					}
					else
					{
						errorlevel[2] = true;
					}
				}
				if (!errorlevel[1])
				{
					var esne = MessageBox.Show("chyba v kodu upravte hu\nzahraj", "error v kodu", MessageBoxButton.OK, MessageBoxImage.Error);
				}
				if (kill)
				{
					break;
				}
				Thread.Sleep(interval);
			}
			Environment.Exit(0);
		}
		public int interval;//ok
	}
}