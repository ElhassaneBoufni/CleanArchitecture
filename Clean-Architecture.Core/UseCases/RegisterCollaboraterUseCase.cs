using System;
using System.Collections.Generic;
using System.Text;
using Clean_Architecture.Core.Interfaces.UseCases;
using Clean_Architecture.Core.Interfaces.Repositories;
using Clean_Architecture.Core.Entities;

namespace Clean_Architecture.Core.UseCases
{
    public class RegisterCollaboraterUseCase : IRegisterCollaboraterUseCase
    {
        ICollaboraterRepository _collaboraterRepository;

        public RegisterCollaboraterUseCase(ICollaboraterRepository collaboraterRepository)
        {
            _collaboraterRepository = collaboraterRepository;
        }

        public bool CreateCollab(Collaborater collaborater, string password)
        {
            return _collaboraterRepository.CreateCollaborater(collaborater, password);
        }

        public List<Collaborater> GetCollaboraters()
        {
            return _collaboraterRepository.SelectAllCollaboraters();
        }
    }
}
