using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using videohub.topVideo;

namespace videohub.Pages_videos
{
    public class CreateModel : PageModel
    {
        private readonly videohubVideosContext _context;

        public CreateModel(videohubVideosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public video video { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.video.Add(video);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
