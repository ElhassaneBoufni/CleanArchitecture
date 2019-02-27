using System;
using System.Collections.Generic;
using System.Text;
using Clean_Architecture.Core.Interfaces.UseCases;
using Clean_Architecture.Core.Interfaces.Repositories;

namespace Clean_Architecture.Core.UseCases
{
    public class RegisterCollaboraterUseCase : IRegisterCollaboraterUseCase
    {
        ICollaboraterRepository _collaboraterRepository;

        public RegisterCollaboraterUseCase(ICollaboraterRepository collaboraterRepository)
        {
            _collaboraterRepository = collaboraterRepository;
        }
    }
}
