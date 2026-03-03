using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Android;

public static class AndroidAssetPacks
{
	public class AssetPackManagerDownloadStatusCallback : AndroidJavaProxy
	{
		[System.Serializable]
		public sealed class _003C_003Ec
		{
		}
	}

	public class AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy
	{
	}

	public class AssetPackManagerStatusQueryCallback : AndroidJavaProxy
	{
	}

	private delegate bool CoreUnityAssetPacksDownloadedDelegate();

	private delegate System.IntPtr GetCoreUnityAssetPackNamesDelegate();

	private delegate void GetTextureCompressionsPackName_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetDataPackName_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetStreamingAssetsPackName_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly CoreUnityAssetPacksDownloadedDelegate CoreUnityAssetPacksDownloadedDelegateField = IL2CPP.ResolveICall<CoreUnityAssetPacksDownloadedDelegate>("UnityEngine.Android.AndroidAssetPacks::CoreUnityAssetPacksDownloaded");

	private static readonly GetCoreUnityAssetPackNamesDelegate GetCoreUnityAssetPackNamesDelegateField = IL2CPP.ResolveICall<GetCoreUnityAssetPackNamesDelegate>("UnityEngine.Android.AndroidAssetPacks::GetCoreUnityAssetPackNames");

	private static readonly GetTextureCompressionsPackName_InjectedDelegate GetTextureCompressionsPackName_InjectedDelegateField = IL2CPP.ResolveICall<GetTextureCompressionsPackName_InjectedDelegate>("UnityEngine.Android.AndroidAssetPacks::GetTextureCompressionsPackName_Injected");

	private static readonly GetDataPackName_InjectedDelegate GetDataPackName_InjectedDelegateField = IL2CPP.ResolveICall<GetDataPackName_InjectedDelegate>("UnityEngine.Android.AndroidAssetPacks::GetDataPackName_Injected");

	private static readonly GetStreamingAssetsPackName_InjectedDelegate GetStreamingAssetsPackName_InjectedDelegateField = IL2CPP.ResolveICall<GetStreamingAssetsPackName_InjectedDelegate>("UnityEngine.Android.AndroidAssetPacks::GetStreamingAssetsPackName_Injected");

	public static bool coreUnityAssetPacksDownloaded => CoreUnityAssetPacksDownloaded();

	public static string textureCompressionsPackName => GetTextureCompressionsPackName();

	public static string dataPackName => GetDataPackName();

	public static string streamingAssetsPackName => GetStreamingAssetsPackName();

	public static bool CoreUnityAssetPacksDownloaded()
	{
		return CoreUnityAssetPacksDownloadedDelegateField();
	}

	public static string GetTextureCompressionsPackName()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetTextureCompressionsPackName_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetDataPackName()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetDataPackName_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetStreamingAssetsPackName()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetStreamingAssetsPackName_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static Il2CppStringArray GetCoreUnityAssetPackNames()
	{
		System.IntPtr intPtr = GetCoreUnityAssetPackNamesDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static void GetAssetPackStateAsync(Il2CppStringArray assetPackNames, Il2CppSystem.Action<ulong, Il2CppReferenceArray<AndroidAssetPackState>> callback)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static GetAssetPackStateAsyncOperation GetAssetPackStateAsync(Il2CppStringArray assetPackNames)
	{
		if (assetPackNames == null || ((Il2CppArrayBase)assetPackNames).Length == 0)
		{
			return null;
		}
		GetAssetPackStateAsyncOperation getAssetPackStateAsyncOperation = new GetAssetPackStateAsyncOperation();
		GetAssetPackStateAsync(assetPackNames, new Il2CppSystem.Action<ulong, Il2CppReferenceArray<AndroidAssetPackState>>(getAssetPackStateAsyncOperation, (nint)__ldftn(GetAssetPackStateAsyncOperation.OnResult)));
		return getAssetPackStateAsyncOperation;
	}

	public static void DownloadAssetPackAsync(Il2CppStringArray assetPackNames, Il2CppSystem.Action<AndroidAssetPackInfo> callback)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static DownloadAssetPackAsyncOperation DownloadAssetPackAsync(Il2CppStringArray assetPackNames)
	{
		if (assetPackNames == null || ((Il2CppArrayBase)assetPackNames).Length == 0)
		{
			return null;
		}
		DownloadAssetPackAsyncOperation downloadAssetPackAsyncOperation = new DownloadAssetPackAsyncOperation(assetPackNames);
		DownloadAssetPackAsync(assetPackNames, new Il2CppSystem.Action<AndroidAssetPackInfo>(downloadAssetPackAsyncOperation, (nint)__ldftn(DownloadAssetPackAsyncOperation.OnUpdate)));
		return downloadAssetPackAsyncOperation;
	}

	public static void RequestToUseMobileDataAsync(Il2CppSystem.Action<AndroidAssetPackUseMobileDataRequestResult> callback)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static RequestToUseMobileDataAsyncOperation RequestToUseMobileDataAsync()
	{
		RequestToUseMobileDataAsyncOperation requestToUseMobileDataAsyncOperation = new RequestToUseMobileDataAsyncOperation();
		RequestToUseMobileDataAsync(new Il2CppSystem.Action<AndroidAssetPackUseMobileDataRequestResult>(requestToUseMobileDataAsyncOperation, (nint)__ldftn(RequestToUseMobileDataAsyncOperation.OnResult)));
		return requestToUseMobileDataAsyncOperation;
	}

	public static string GetAssetPackPath(string assetPackName)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void CancelAssetPackDownload(Il2CppStringArray assetPackNames)
	{
		GetAssetPackManager().Call<string>("cancelAssetPackDownloads", (Il2CppArrayBase<string>)(object)assetPackNames);
	}

	public static void RemoveAssetPack(string assetPackName)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static AndroidJavaObject GetAssetPackManager()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void GetTextureCompressionsPackName_Injected(out ManagedSpanWrapper ret)
	{
		GetTextureCompressionsPackName_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetDataPackName_Injected(out ManagedSpanWrapper ret)
	{
		GetDataPackName_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetStreamingAssetsPackName_Injected(out ManagedSpanWrapper ret)
	{
		GetStreamingAssetsPackName_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
