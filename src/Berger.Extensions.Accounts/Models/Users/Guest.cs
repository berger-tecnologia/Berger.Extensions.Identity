﻿using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Accounts
{
    public class Guest : BaseEntity
    {
        public Guid? CountryId { get; set; }
    }
}