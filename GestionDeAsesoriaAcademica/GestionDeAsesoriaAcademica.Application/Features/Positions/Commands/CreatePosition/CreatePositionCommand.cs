using AutoMapper;
using GestionDeAsesoriaAcademica.Application.Interfaces.Repositories;
using GestionDeAsesoriaAcademica.Application.Wrappers;
using GestionDeAsesoriaAcademica.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionDeAsesoriaAcademica.Application.Features.Positions.Commands.CreatePosition
{
    public partial class CreatePositionCommand : IRequest<Response<Guid>>
    {
        public string PositionTitle { get; set; }
        public string PositionNumber { get; set; }
        public string PositionDescription { get; set; }
        public decimal PositionSalary { get; set; }
    }

    public class CreatePositionCommandHandler : IRequestHandler<CreatePositionCommand, Response<Guid>>
    {
        private readonly IPositionRepositoryAsync _repository;
        private readonly IMapper _mapper;

        public CreatePositionCommandHandler(IPositionRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<Guid>> Handle(CreatePositionCommand request, CancellationToken cancellationToken)
        {
            var position = _mapper.Map<Position>(request);
            await _repository.AddAsync(position);
            return new Response<Guid>(position.Id);
        }
    }
}