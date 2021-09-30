using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using videohub.topVideo;

    public class videohubVideosContext : DbContext
    {
        public videohubVideosContext (DbContextOptions<videohubVideosContext> options)
            : base(options)
        {
        }

        public DbSet<videohub.topVideo.video> video { get; set; }
    }
