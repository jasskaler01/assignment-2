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
    public class DetailsModel : PageModel
    {
        private readonly videohubVideosContext _context;

        public DetailsModel(videohubVideosContext context)
        {
            _context = context;
        }

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
    }
}
