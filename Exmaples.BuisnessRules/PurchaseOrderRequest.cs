using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmaples.BuisnessRules
{
	public class CustomerInfo
	{
		public string Location { get; set; }
		public string IpAddress { get; set; }
		public string Email { get; set; }
	}

	public class PurchaseOrderRequest
	{
		public IEnumerable<string> Products { get; set; }
		public CustomerInfo CustomerInfo { get; set; }

	}
}