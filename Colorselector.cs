using System.Drawing;
using System.Windows.Forms;
public class Colorselector
{
	public static Color choose(ComboBox color)
	{
		Color c;
		if(color.SelectedItem.ToString() == "Red")
			c = Color.Red;
		else if(color.SelectedItem.ToString() == "Green")
			c = Color.Green;
		else c = Color.Blue;
		return c;
	}
}