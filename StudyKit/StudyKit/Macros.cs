using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

public class Macros
{
	[JsonIgnore]
	public static int macrosAmount = 5;

	public string[] values = new string[macrosAmount];

	[JsonIgnore]
	public List<TextBox> list = new List<TextBox>();


	public void LoadValues(string[] values)
	{
		this.values = values;

		for (int i = 0; i < macrosAmount; i++)
			list[i].Text = values[i];
	}
}