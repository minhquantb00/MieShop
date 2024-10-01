﻿using MieShop.Commons.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Domain.Entities.Media
{
    public partial class MediaFolder : BaseEntity<Guid>
    {
        private IEnumerable<MediaFile> _files;
        private IEnumerable<MediaFolder> _children;
        public Guid? ParentId { get; set; }
        public virtual MediaFolder Parent { get; set; }
        public string Name { get; set; } = "";
        public string Slug { get; set; } = "";
        public bool CanDetectTracks { get; set; } = true;
        public virtual IEnumerable<MediaFolder> Children
        {
            get; set;
        }

        public string? Metadata { get; set; } = "";
        public int FilesCount { get; set; } = 0;

        public string Owner { get; set; } = "";
        public bool Deleted { get; set; } = false;

        public bool IsPublic { get; set; } = false;

        public string? IsProtected { get; set; } = "";

        public string? IsPrivate { get; set; } = "";

        public virtual IEnumerable<MediaFile> Files
        {
            get; set;
        }
    }
}
