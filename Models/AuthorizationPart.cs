﻿using Orchard.ContentManagement;
using System;

namespace CodeSanook.Authorization.Models
{
    public class AuthorizationPart: ContentPart<AuthorizationPartRecord>
    {
        public Guid RefreshTokenId
        {
            get
            {
                return this.Record.RefreshTokenId;
            }
            set
            {
               this.Record.RefreshTokenId = value;
            }
        }
    }
}