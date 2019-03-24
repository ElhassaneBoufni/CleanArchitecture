using System;
using System.Collections.Generic;
using System.Text;
using Clean_Architecture.Core.Entities;

namespace Clean_Architecture.Core.Interfaces.Repositories
{
    public interface ICollaboraterRepository
    {
        bool CreateCollaborater(Collaborater collaborater, string password);
        List<Collaborater> SelectAllCollaboraters();
    }
}
