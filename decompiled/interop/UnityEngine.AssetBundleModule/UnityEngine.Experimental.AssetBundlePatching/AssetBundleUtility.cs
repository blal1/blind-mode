using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Experimental.AssetBundlePatching;

public static class AssetBundleUtility
{
	private delegate void PatchAssetBundlesDelegate(IntPtr bundles, IntPtr filenames);

	private static readonly PatchAssetBundlesDelegate PatchAssetBundlesDelegateField = IL2CPP.ResolveICall<PatchAssetBundlesDelegate>("UnityEngine.Experimental.AssetBundlePatching.AssetBundleUtility::PatchAssetBundles");

	public static void PatchAssetBundles(Il2CppReferenceArray<AssetBundle> bundles, Il2CppStringArray filenames)
	{
		PatchAssetBundlesDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bundles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filenames));
	}
}
