using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClaimBased
{
	public class SimpleDirectory
	{
		public static List<SimpleDirectoryEntry> Entries = new List<SimpleDirectoryEntry>()
		{
			new SimpleDirectoryEntry(){Name="Andrew Dixon", Email="andrew@contoso.com", Title="Developer"},
			new SimpleDirectoryEntry(){Name="Iben Thorello", Email="iben@contoso.com", Title="Developer"},
			new SimpleDirectoryEntry(){Name="Terry Adams", Email="terry@contoso.com", Title="Developer"},
			new SimpleDirectoryEntry(){Name="Kim Abercrombie", Email="kim@contoso.com", Title="Developer"},
			new SimpleDirectoryEntry(){Name="David Hamilton", Email="david@contoso.com", Title="Painter"},
			new SimpleDirectoryEntry(){Name="Michael Patton", Email="michael@contoso.com", Title="Fire Dancer"},
			new SimpleDirectoryEntry(){Name="Mark Hanson", Email="mark@contoso.com", Title="Chief Yodeller"},
		};
	}
}

