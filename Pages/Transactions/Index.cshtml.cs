using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketWEB.Pages.Transactions
{
	public class IndexModel : PageModel
	{
		private readonly SupermarketContext _context;

		public IndexModel(SupermarketContext context)
		{
			_context = context;
		}

		public IList<Transaction> Transactions { get; set; }

		public async Task<IActionResult> OnGetAsync()
		{
			Transactions = await _context.Transactions.ToListAsync();
			return Page();
		}
	}
}
