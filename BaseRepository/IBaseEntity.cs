using System;
using System.Collections.Generic;
using System.Text;

namespace BaseRepository
{
    public interface IBaseEntity
    {

        DateTime CreatedAt { get; set; }
        Guid CreatedById { get; set; }
        bool Deleted { get; set; }
        DateTime? DeletedAt { get; set; }
        Guid? DeletedById { get; set; }
        Guid Id { get; set; }
        DateTime? UpdatedAt { get; set; }
        Guid? UpdatedById { get; set; }
    }
}
