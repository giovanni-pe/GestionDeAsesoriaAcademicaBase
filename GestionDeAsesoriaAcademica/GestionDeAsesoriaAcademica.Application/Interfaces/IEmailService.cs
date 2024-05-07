using GestionDeAsesoriaAcademica.Application.DTOs.Email;
using System.Threading.Tasks;

namespace GestionDeAsesoriaAcademica.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}