using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AssetBundleManifest : Object
{
	private delegate System.IntPtr GetAllAssetBundles_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetAllAssetBundlesWithVariant_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetAssetBundleHash_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr assetBundleName, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetDirectDependencies_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr assetBundleName);

	private delegate System.IntPtr GetAllDependencies_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr assetBundleName);

	private static readonly GetAllAssetBundles_InjectedDelegate GetAllAssetBundles_InjectedDelegateField = IL2CPP.ResolveICall<GetAllAssetBundles_InjectedDelegate>("UnityEngine.AssetBundleManifest::GetAllAssetBundles_Injected");

	private static readonly GetAllAssetBundlesWithVariant_InjectedDelegate GetAllAssetBundlesWithVariant_InjectedDelegateField = IL2CPP.ResolveICall<GetAllAssetBundlesWithVariant_InjectedDelegate>("UnityEngine.AssetBundleManifest::GetAllAssetBundlesWithVariant_Injected");

	private static readonly GetAssetBundleHash_InjectedDelegate GetAssetBundleHash_InjectedDelegateField = IL2CPP.ResolveICall<GetAssetBundleHash_InjectedDelegate>("UnityEngine.AssetBundleManifest::GetAssetBundleHash_Injected");

	private static readonly GetDirectDependencies_InjectedDelegate GetDirectDependencies_InjectedDelegateField = IL2CPP.ResolveICall<GetDirectDependencies_InjectedDelegate>("UnityEngine.AssetBundleManifest::GetDirectDependencies_Injected");

	private static readonly GetAllDependencies_InjectedDelegate GetAllDependencies_InjectedDelegateField = IL2CPP.ResolveICall<GetAllDependencies_InjectedDelegate>("UnityEngine.AssetBundleManifest::GetAllDependencies_Injected");

	public Il2CppStringArray GetAllAssetBundles()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAllAssetBundles_Injected(intPtr);
	}

	public Il2CppStringArray GetAllAssetBundlesWithVariant()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAllAssetBundlesWithVariant_Injected(intPtr);
	}

	public unsafe Hash128 GetAssetBundleHash(string assetBundleName)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out Hash128 ret);
		Hash128 result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetAssetBundleHash_Injected(intPtr, ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetAssetBundleHash_Injected(intPtr, ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			result = ret;
		}
		return result;
	}

	public unsafe Il2CppStringArray GetDirectDependencies(string assetBundleName)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetDirectDependencies_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return GetDirectDependencies_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe Il2CppStringArray GetAllDependencies(string assetBundleName)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetAllDependencies_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return GetAllDependencies_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static Il2CppStringArray GetAllAssetBundles_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetAllAssetBundles_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppStringArray GetAllAssetBundlesWithVariant_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetAllAssetBundlesWithVariant_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static void GetAssetBundleHash_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper assetBundleName, out Hash128 ret)
	{
		GetAssetBundleHash_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref assetBundleName), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static Il2CppStringArray GetDirectDependencies_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper assetBundleName)
	{
		System.IntPtr intPtr = GetDirectDependencies_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref assetBundleName));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static Il2CppStringArray GetAllDependencies_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper assetBundleName)
	{
		System.IntPtr intPtr = GetAllDependencies_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref assetBundleName));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}
}
