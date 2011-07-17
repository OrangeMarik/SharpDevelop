﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using ICSharpCode.PackageManagement.Scripting;
using NuGet;

namespace ICSharpCode.PackageManagement
{
	public class UpdatedPackageViewModel : PackageViewModel
	{
		public UpdatedPackageViewModel(
			IPackageFromRepository package,
			PackageManagementSelectedProjects selectedProjects,
			IPackageManagementEvents packageManagementEvents,
			IPackageActionRunner actionRunner,
			ILogger logger)
			: base(package, selectedProjects, packageManagementEvents, actionRunner, logger)
		{
		}
		
		protected override ProcessPackageOperationsAction CreateInstallPackageAction(
			IPackageManagementProject project)
		{
			return project.CreateUpdatePackageAction();
		}
	}
}
