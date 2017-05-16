﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Elastic.Installer.Domain;
using WixSharp;
using Elastic.Installer.Domain.Kibana.Model;
using Elastic.Installer.Domain.Model;
using Elastic.Installer.Domain.Shared.Configuration.EnvironmentBased;
using Elastic.Installer.Domain.Session;

namespace Elastic.Installer.Msi.Kibana
{
	public class Kibana : Product
	{
		public override IEnumerable<string> AllArguments => KibanaArgumentParser.AllArguments;

		public override IEnumerable<ModelArgument> MsiParams =>
			KibanaInstallationModel.Create(new NoopWixStateProvider(), new NoopSession()).ToMsiParams();

		public override Dictionary<string, Guid> ProductCode => ProductGuids.KibanaProductCodes;

		public override Guid UpgradeCode => ProductGuids.KibanaUpgradeCode;
	}
}