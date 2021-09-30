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
    public class IndexModel : PageModel
    {
        private readonly videohubVideosContext _context;

        public IndexModel(videohubVideosContext context)
        {
            _context = context;
        }

        public IList<video> video { get;set; }

        public async Task OnGetAsync()
        {
            video = await _context.video.ToListAsync();
        }
    }
}
