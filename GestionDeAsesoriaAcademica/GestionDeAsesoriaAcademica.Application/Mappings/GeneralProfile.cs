using AutoMapper;
using GestionDeAsesoriaAcademica.Application.Features.Employees.Queries.GetEmployees;
using GestionDeAsesoriaAcademica.Application.Features.Positions.Commands.CreatePosition;
using GestionDeAsesoriaAcademica.Application.Features.Positions.Queries.GetPositions;
using GestionDeAsesoriaAcademica.Domain.Entities;

namespace GestionDeAsesoriaAcademica.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}