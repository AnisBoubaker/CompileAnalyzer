using System.Collections.Generic;
using Constants.Enums;
using Entity.DTO;

namespace Services.Interfaces
{
    public interface IClientService
    {
        IEnumerable<ClientDTO> GetAllClients(string userEmail, UserRole userRole);
    }
}