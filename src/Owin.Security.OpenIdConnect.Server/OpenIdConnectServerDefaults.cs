﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenIdConnect.Server
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.Owin.Security;

namespace Owin.Security.OpenIdConnect.Server {
    /// <summary>
    /// Default values used by authorization server and bearer authentication.
    /// </summary>
    public static class OpenIdConnectServerDefaults {
        /// <summary>
        /// Default value for <see cref="AuthenticationOptions.AuthenticationType"/>.
        /// </summary>
        public const string AuthenticationType = "ASOS";

        /// <summary>
        /// Default value for <see cref="OpenIdConnectServerOptions.ConfigurationEndpointPath"/>.
        /// </summary>
        public const string ConfigurationEndpointPath = "/.well-known/openid-configuration";

        /// <summary>
        /// Default value for <see cref="OpenIdConnectServerOptions.CryptographyEndpointPath"/>.
        /// </summary>
        public const string CryptographyEndpointPath = "/.well-known/jwks";
    }
}
