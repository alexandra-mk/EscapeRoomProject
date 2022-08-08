﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Core.Repositories
{
    public interface IReservationRepository : IGenericRepository<Reservation>
    {
        List<Reservation> GetReservations();
    }
}
