﻿using System;

namespace GestionDeAsesoriaAcademica.Domain.Common
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}