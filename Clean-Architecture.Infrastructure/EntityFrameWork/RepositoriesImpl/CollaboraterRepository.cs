using System;
using System.Collections.Generic;
using System.Text;
using Clean_Architecture.Core.Entities;
using Clean_Architecture.Core.Interfaces.Repositories;

namespace Clean_Architecture.Infrastructure.EntityFrameWork.RepositoriesImpl
{
    class CollaboraterRepository : ICollaboraterRepository
    {
        private readonly ApplicationDbContext _context;
        List<Collaborater> list;

        public CollaboraterRepository(ApplicationDbContext context)
        {
            _context = context;
            list = new List<Collaborater>();
        }

        public bool CreateCollaborater(Collaborater collaborater, string password)
        {
            collaborater.Id = Guid.NewGuid().ToString();
            _context.Add(collaborater);
            if (_context.SaveChanges() > 0)
                return true;
            else
                return false;
        }

        public List<Collaborater> SelectAllCollaboraters()
        {
            list.Add(new Collaborater("Hamid", "Chakib", "hamidchak@mail.com", "hamouda"));
            list.Add(new Collaborater("Karim", "Ernesto", "KPrime@mail.com", "ErneKam"));
            return list;
        }
    }
}
