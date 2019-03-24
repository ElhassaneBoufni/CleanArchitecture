using System;
using System.Collections.Generic;
using System.Text;
using Clean_Architecture.Core.Entities;
using Clean_Architecture.Core.Interfaces.Repositories;

namespace Clean_Architecture.Infrastructure.InMemory.RepositoriesImpl
{
    public class CollaboraterRepository : ICollaboraterRepository
    {
        List<Collaborater> list;

        public CollaboraterRepository()
        {
            list = new List<Collaborater>();

            list.Add(new Collaborater("Hamid", "Chakib", "hamidchak@mail.com", "hamouda"));
            list.Add(new Collaborater("Karim", "Ernesto", "KPrime@mail.com", "ErneKam"));
        }

        public bool CreateCollaborater(Collaborater collaborater, string password)
        {
            throw new NotImplementedException();
        }

        public List<Collaborater> SelectAllCollaboraters()
        {
            return list;
        }
    }
}
