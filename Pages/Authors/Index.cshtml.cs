﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Onetiu_Diana2_Lab2.Data;
using Onetiu_Diana2_Lab2.Models;

namespace Onetiu_Diana2_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Onetiu_Diana2_Lab2.Data.Onetiu_Diana2_Lab2Context _context;

        public IndexModel(Onetiu_Diana2_Lab2.Data.Onetiu_Diana2_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}