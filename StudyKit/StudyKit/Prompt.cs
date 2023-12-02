using Newtonsoft.Json;
using System.Windows.Forms;

namespace StudyKit
{
	public class Prompt
	{
		[JsonProperty("promptText")]
		public string promptText { get; set; } = "Default";
		[JsonProperty("correctAnswer")]
		public string correctAnswer { get; set; } = "Answer";
		[JsonProperty("checkState")]
		public CheckState checkState { get; set; } = CheckState.Checked;

		[JsonIgnore]
		public string displayListName => promptText + "  //  " + correctAnswer;
	}
}
