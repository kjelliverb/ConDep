using System;
using ConDep.Dsl.FluentWebDeploy.Builders;

namespace ConDep.Dsl.FluentWebDeploy
{
	public static class CopyDirExtension
	{
		public static void CopyDir(this ProviderCollectionBuilder providerCollectionBuilder, string sourceDir, Action<CopyDirOptions> options)
		{
			var copyDirProvider = new CopyDirProvider(sourceDir);
			options(new CopyDirOptions(copyDirProvider));
			providerCollectionBuilder.AddProvider(copyDirProvider);
		}
	}
}