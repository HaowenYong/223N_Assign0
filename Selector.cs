using System;
using System.Drawing;
using System.Windows.Forms;

public class Selector : Form{
	private Button draw = new Button();
	private RadioButton square = new RadioButton();
	private RadioButton circle = new RadioButton();
	private ComboBox color = new ComboBox();

	private Color c = Color.Yellow;

	public Selector() {
		Text = "Select";
		draw.Text = "Draw";
		color.Text = "Choose a color";
		square.Text = "Square";
		circle.Text = "Circle";

		Size = new Size(500, 250);

		int w = 20;
		draw.Location = new Point(20,30);
		square.Location = new Point(w += 10 + draw.Width, 30);
		circle.Location = new Point(w += 10 + square.Width, 30);
		color.Location = new Point(w += 10 + circle.Width, 30);

		color.Items.Add("Red");
		color.Items.Add("Green");
		color.Items.Add("Blue");

		Controls.Add(draw);
		Controls.Add(square);
		Controls.Add(circle);
		Controls.Add(color);

		draw.Click += new EventHandler(Draw_Click);	
	}
	
	protected override void OnPaint(PaintEventArgs e) {
		Graphics g = e.Graphics;
		Brush brush = new SolidBrush(c);
		if(square.Checked)
			g.FillRectangle(brush, 100, 100, 100, 100);
		else
			g.FillEllipse(brush, 100, 100, 100, 100);
		base.OnPaint(e);
	}

	protected void Draw_Click(Object sender, EventArgs e){
		c = Colorselector.choose(color);
		Invalidate();
	}
}