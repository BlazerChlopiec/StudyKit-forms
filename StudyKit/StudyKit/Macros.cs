using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class Macros
{
	[JsonIgnore]
	public static int macrosAmount = 5;

	public string[] values = new string[macrosAmount];

	[JsonIgnore]
	public List<TextBox> list = new List<TextBox>();

	[JsonIgnore]
	Control target;


	/// <summary>
	/// loading values from json
	/// </summary>
	public void LoadValues(string[] values)
	{
		this.values = values;

		for (int i = 0; i < macrosAmount; i++)
			list[i].Text = values[i];
	}

	public void InitializeMacros(TextBox prefabMacro, Control target)
	{
		this.target = target;

		list.Add(prefabMacro);

		for (int i = 0; i < Macros.macrosAmount - 1; i++)
		{
			var macro = prefabMacro.Clone();
			list.Add(macro);
			macro.Location = new Point(prefabMacro.Location.X + 39 * (i + 1), prefabMacro.Location.Y);
			macro.Show();
		}

		foreach (var macro in list)
		{
			macro.MouseDoubleClick += new MouseEventHandler(delegate { InvokeMacro(list.IndexOf(macro)); });

			macro.TextChanged += new EventHandler(delegate
			{
				if (macro.Text.Length > 0)
					macro.Text = macro.Text.Substring(0, 1); // this allows for one character only

				macro.SelectionStart = 1;

				var index = list.IndexOf(macro);
				values[index] = macro.Text;
			});
		}
	}

	public void InvokeMacro(int index)
	{
		var macro = list[index];

		if (macro.TextLength > 0)
		{
			target.Text += macro.Text;
			macro.SelectionLength = 0;
			macro.SelectionStart = 1;
		}
	}
}