﻿using GestionDeAsesoriaAcademica.Domain.Entities;
using System.Collections.Generic;

namespace GestionDeAsesoriaAcademica.Application.Interfaces
{
    public interface IMockService
    {
        List<Position> GetPositions(int rowCount);

        List<Employee> GetEmployees(int rowCount);

        List<Position> SeedPositions(int rowCount);
    }
}