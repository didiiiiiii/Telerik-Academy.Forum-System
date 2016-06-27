namespace ForumSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ForumSystem.Data.Common.Models;
    using System.Collections.Generic;
    public class Post : AuditInfo, IDeletableEntity
    {
        public int Id { get; set; }

        public Post()
        {
            this.Tags = new HashSet<Tag>();
        }

        [MaxLength(100)]
        public string Title { get; set; }

        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }
 
        public string Content { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

    }
}
