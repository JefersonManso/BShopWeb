// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using BShop.IdentityServer.MainModule.Account;

namespace BShop.IdentityServer.MainModule.Device;

public class DeviceAuthorizationInputModel : ConsentInputModel
{
    public string UserCode { get; set; }
}