﻿using System;
using System.ComponentModel.Composition;
using GitHub.TeamFoundation;

namespace GitHub.Services
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class VSGitServicesFactory
    {
        [ImportingConstructor]
        public VSGitServicesFactory(TeamFoundationResolver teamFoundationResolver, IGitHubServiceProvider serviceProvider)
        {
            VSGitServices = new VSGitServices(serviceProvider);
        }

        [Export(typeof(IVSGitServices))]
        public IVSGitServices VSGitServices { get; }
    }
}
