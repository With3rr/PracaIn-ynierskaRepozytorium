﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRO.Domain.Query
{
    public interface IQueryHandler<TQuery,TResult> where TQuery:IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }
}
