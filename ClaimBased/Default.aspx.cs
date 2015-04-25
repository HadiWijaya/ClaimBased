using System;
using System.Web;
using System.Web.UI;
using System.Security.Claims;
using System.Threading;

namespace ClaimBased
{
	public partial class Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;

			if (claimsPrincipal != null)
			{
				signedIn.Text = "You are signed in...";

				foreach (Claim claim in claimsPrincipal.Claims) 
				{
					claimType.Text = claim.Type;
					claimValue.Text = claim.Value;
					claimValueType.Text = claim.ValueType;
					claimSubjectName.Text = claim.Subject.Name;
					claimIssuer.Text = claim.Issuer;
				}
			}
			else
			{
				signedIn.Text = "You are not signed in.";
			}
		}
	}
}

