using GestionDeAsesoriaAcademica.Application.Interfaces;
using System;

namespace GestionDeAsesoriaAcademica.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}