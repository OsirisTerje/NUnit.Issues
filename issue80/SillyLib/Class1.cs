using System.Collections.Generic;
using System.Threading.Tasks;

namespace SillyLib
{
	public class Class1
    {
		List<string> _badList;

		public async void DoIt()
		{
			await Task.Delay(4);
			_badList.Add("this will die");
		}
    }


}
