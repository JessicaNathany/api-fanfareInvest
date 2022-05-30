﻿using api_fanfareInvest.api.Response;

namespace api_fanfareInvest.api.Data.Interface
{
    public interface IDirectTreasuryRepository
    {
        Task<IList<DirectTreasuryResponse>> GetAsync();
    }
}
