using System;

namespace GestionDeAsesoriaAcademica.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}