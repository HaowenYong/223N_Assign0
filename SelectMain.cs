using System;
using System.Drawing;
using System.Windows.Forms;

public class SelectMain : Form{
	static void Main(string[] args){
		System.Console.WriteLine("assignment 0");
		Selector s = new Selector();
		Application.Run(s);
		System.Console.WriteLine("end of assignment 0");
	}
}