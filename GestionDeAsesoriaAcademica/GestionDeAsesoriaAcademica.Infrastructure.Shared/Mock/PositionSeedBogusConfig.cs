﻿using AutoBogus;
using Bogus;
using GestionDeAsesoriaAcademica.Domain.Entities;
using System;

namespace GestionDeAsesoriaAcademica.Infrastructure.Shared.Mock
{
    public class PositionSeedBogusConfig : AutoFaker<Position>
    {
        public PositionSeedBogusConfig()
        {
            Randomizer.Seed = new Random(8675309);
            RuleFor(m => m.Id, f => Guid.NewGuid());
            RuleFor(o => o.PositionTitle, f => f.Name.JobTitle());
            RuleFor(o => o.PositionNumber, f => f.Commerce.Ean13());
            RuleFor(o => o.PositionDescription, f => f.Name.JobDescriptor());
            RuleFor(o => o.Created, f => f.Date.Past(1));
            RuleFor(o => o.CreatedBy, f => f.Name.FullName());
            RuleFor(o => o.LastModified, f => f.Date.Recent(1));
            RuleFor(o => o.LastModifiedBy, f => f.Name.FullName());
            RuleFor(o => o.PositionSalary, f => f.Finance.Amount());
        }
    }
}