﻿using System.Collections.Generic;
using System.Linq;
using Octopus.Server.Extensibility.Authentication.DirectoryServices.Configuration;
using Octopus.Server.Extensibility.Extensions.Infrastructure.Web.Content;

namespace Octopus.Server.Extensibility.Authentication.DirectoryServices.Web
{
    public class DirectoryServicesJavascriptContributor : IContributesJavascript
    {
        readonly IDirectoryServicesConfigurationStore configurationStore;

        public DirectoryServicesJavascriptContributor(IDirectoryServicesConfigurationStore configurationStore)
        {
            this.configurationStore = configurationStore;
        }

        public IEnumerable<string> GetJavascriptUris()
        {
            return !configurationStore.GetIsEnabled()
                ? Enumerable.Empty<string>()
                : new[] { "~/areas/users/ad_auth_provider.js" };
        }
    }
}