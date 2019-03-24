using System;
using System.Collections.Generic;
using System.Text;
using Clean_Architecture.Core.Entities;

namespace Clean_Architecture.Core.Interfaces.UseCases
{
    public interface IRegisterCollaboraterUseCase
    {
        bool CreateCollab(Collaborater collaborater, string password);
        List<Collaborater> GetCollaboraters();
    }
}
