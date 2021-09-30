using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using videohub.topVideo;

namespace videohub.Pages_videos
{
    public class DeleteModel : PageModel
    {
        private readonly videohubVideosContext _context;

        public DeleteModel(videohubVideosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public video video { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            video = await _context.video.FirstOrDefaultAsync(m => m.ID == id);

            if (video == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            video = await _context.video.FindAsync(id);

            if (video != null)
            {
                _context.video.Remove(video);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
