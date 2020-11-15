﻿using ShowDataWebApp.Models;
using ShowDataWebApp.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShowDataWebApp.Repository
{
    public class ShowModelRepository : Repository<ShowModel>, IShowModelRepository
    {
        private readonly IHttpClientFactory _httpFactory;

        public ShowModelRepository(IHttpClientFactory httpFactory) : base(httpFactory)
        {
            _httpFactory = httpFactory;
        }
    }
}