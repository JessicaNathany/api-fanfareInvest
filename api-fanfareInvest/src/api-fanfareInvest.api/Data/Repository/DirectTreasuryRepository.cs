﻿using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Response;

namespace api_fanfareInvest.api.Data.Repository
{
    public class DirectTreasuryRepository : IDirectTreasuryRepository
    {
        public Task<IList<DirectTreasuryResponse>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
