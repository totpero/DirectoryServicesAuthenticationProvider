﻿using System.Collections.Generic;
using System.Linq;
using Octopus.Server.Extensibility.Authentication.DirectoryServices.Configuration;
using Octopus.Server.Extensibility.Extensions.Infrastructure.Web.Content;

namespace Octopus.Server.Extensibility.Authentication.DirectoryServices.Web
{
    public class DirectoryServicesCSSContributor : IContributesCSS
    {
        readonly IDirectoryServicesConfigurationStore configurationStore;

        public DirectoryServicesCSSContributor(IDirectoryServicesConfigurationStore configurationStore)
        {
            this.configurationStore = configurationStore;
        }

        public IEnumerable<string> GetCSSUris()
        {
            if (!configurationStore.GetIsEnabled())
                return Enumerable.Empty<string>();
            return new [] { "~/styles/DirectoryServices.css" };
        }
    }
}