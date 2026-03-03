using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Caching
{
	private delegate bool get_compressionEnabledDelegate();

	private delegate void set_compressionEnabledDelegate(bool value);

	private delegate bool get_readyDelegate();

	private delegate bool ClearCacheDelegate();

	private delegate bool ClearCache_IntDelegate(int expiration);

	private delegate long get_spaceOccupiedDelegate();

	private delegate long get_spaceFreeDelegate();

	private delegate long get_maximumAvailableDiskSpaceDelegate();

	private delegate void set_maximumAvailableDiskSpaceDelegate(long value);

	private delegate int get_expirationDelayDelegate();

	private delegate void set_expirationDelayDelegate(int value);

	private delegate int get_cacheCountDelegate();

	private delegate bool ClearCachedVersionInternal_InjectedDelegate(System.IntPtr assetBundleName, [In] System.IntPtr hash);

	private delegate bool ClearCachedVersions_InjectedDelegate(System.IntPtr assetBundleName, [In] System.IntPtr hash, bool keepInputVersion);

	private delegate void GetCachedVersions_InjectedDelegate(System.IntPtr assetBundleName, [Out] System.IntPtr ret);

	private delegate bool IsVersionCached_InjectedDelegate(System.IntPtr url, System.IntPtr assetBundleName, [In] System.IntPtr hash);

	private delegate bool MarkAsUsed_InjectedDelegate(System.IntPtr url, System.IntPtr assetBundleName, [In] System.IntPtr hash);

	private static readonly get_compressionEnabledDelegate get_compressionEnabledDelegateField = IL2CPP.ResolveICall<get_compressionEnabledDelegate>("UnityEngine.Caching::get_compressionEnabled");

	private static readonly set_compressionEnabledDelegate set_compressionEnabledDelegateField = IL2CPP.ResolveICall<set_compressionEnabledDelegate>("UnityEngine.Caching::set_compressionEnabled");

	private static readonly get_readyDelegate get_readyDelegateField = IL2CPP.ResolveICall<get_readyDelegate>("UnityEngine.Caching::get_ready");

	private static readonly ClearCacheDelegate ClearCacheDelegateField = IL2CPP.ResolveICall<ClearCacheDelegate>("UnityEngine.Caching::ClearCache");

	private static readonly ClearCache_IntDelegate ClearCache_IntDelegateField = IL2CPP.ResolveICall<ClearCache_IntDelegate>("UnityEngine.Caching::ClearCache_Int");

	private static readonly get_spaceOccupiedDelegate get_spaceOccupiedDelegateField = IL2CPP.ResolveICall<get_spaceOccupiedDelegate>("UnityEngine.Caching::get_spaceOccupied");

	private static readonly get_spaceFreeDelegate get_spaceFreeDelegateField = IL2CPP.ResolveICall<get_spaceFreeDelegate>("UnityEngine.Caching::get_spaceFree");

	private static readonly get_maximumAvailableDiskSpaceDelegate get_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<get_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::get_maximumAvailableDiskSpace");

	private static readonly set_maximumAvailableDiskSpaceDelegate set_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<set_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::set_maximumAvailableDiskSpace");

	private static readonly get_expirationDelayDelegate get_expirationDelayDelegateField = IL2CPP.ResolveICall<get_expirationDelayDelegate>("UnityEngine.Caching::get_expirationDelay");

	private static readonly set_expirationDelayDelegate set_expirationDelayDelegateField = IL2CPP.ResolveICall<set_expirationDelayDelegate>("UnityEngine.Caching::set_expirationDelay");

	private static readonly get_cacheCountDelegate get_cacheCountDelegateField = IL2CPP.ResolveICall<get_cacheCountDelegate>("UnityEngine.Caching::get_cacheCount");

	private static readonly ClearCachedVersionInternal_InjectedDelegate ClearCachedVersionInternal_InjectedDelegateField = IL2CPP.ResolveICall<ClearCachedVersionInternal_InjectedDelegate>("UnityEngine.Caching::ClearCachedVersionInternal_Injected");

	private static readonly ClearCachedVersions_InjectedDelegate ClearCachedVersions_InjectedDelegateField = IL2CPP.ResolveICall<ClearCachedVersions_InjectedDelegate>("UnityEngine.Caching::ClearCachedVersions_Injected");

	private static readonly GetCachedVersions_InjectedDelegate GetCachedVersions_InjectedDelegateField = IL2CPP.ResolveICall<GetCachedVersions_InjectedDelegate>("UnityEngine.Caching::GetCachedVersions_Injected");

	private static readonly IsVersionCached_InjectedDelegate IsVersionCached_InjectedDelegateField = IL2CPP.ResolveICall<IsVersionCached_InjectedDelegate>("UnityEngine.Caching::IsVersionCached_Injected");

	private static readonly MarkAsUsed_InjectedDelegate MarkAsUsed_InjectedDelegateField = IL2CPP.ResolveICall<MarkAsUsed_InjectedDelegate>("UnityEngine.Caching::MarkAsUsed_Injected");

	public static bool compressionEnabled
	{
		get
		{
			return get_compressionEnabledDelegateField();
		}
		set
		{
			set_compressionEnabledDelegateField(value);
		}
	}

	public static bool ready => get_readyDelegateField();

	public static int spaceUsed => (int)spaceOccupied;

	public static long spaceOccupied => get_spaceOccupiedDelegateField();

	public static int spaceAvailable => (int)spaceFree;

	public static long spaceFree => get_spaceFreeDelegateField();

	public static long maximumAvailableDiskSpace
	{
		get
		{
			return get_maximumAvailableDiskSpaceDelegateField();
		}
		set
		{
			set_maximumAvailableDiskSpaceDelegateField(value);
		}
	}

	public static int expirationDelay
	{
		get
		{
			return get_expirationDelayDelegateField();
		}
		set
		{
			set_expirationDelayDelegateField(value);
		}
	}

	public static int cacheCount => get_cacheCountDelegateField();

	public static bool ClearCache()
	{
		return ClearCacheDelegateField();
	}

	public static bool ClearCache(int expiration)
	{
		return ClearCache_Int(expiration);
	}

	public static bool ClearCache_Int(int expiration)
	{
		return ClearCache_IntDelegateField(expiration);
	}

	public static bool ClearCachedVersion(string assetBundleName, Hash128 hash)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(assetBundleName))
		{
			throw new Il2CppSystem.ArgumentException("Input AssetBundle name cannot be null or empty.");
		}
		return ClearCachedVersionInternal(assetBundleName, hash);
	}

	public unsafe static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return ClearCachedVersionInternal_Injected(ref managedSpanWrapper, ref hash);
				}
			}
			return ClearCachedVersionInternal_Injected(ref managedSpanWrapper, ref hash);
		}
		finally
		{
		}
	}

	public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(assetBundleName))
		{
			throw new Il2CppSystem.ArgumentException("Input AssetBundle name cannot be null or empty.");
		}
		return ClearCachedVersions(assetBundleName, hash, keepInputVersion: true);
	}

	public static bool ClearAllCachedVersions(string assetBundleName)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(assetBundleName))
		{
			throw new Il2CppSystem.ArgumentException("Input AssetBundle name cannot be null or empty.");
		}
		return ClearCachedVersions(assetBundleName, default(Hash128), keepInputVersion: false);
	}

	public unsafe static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return ClearCachedVersions_Injected(ref managedSpanWrapper, ref hash, keepInputVersion);
				}
			}
			return ClearCachedVersions_Injected(ref managedSpanWrapper, ref hash, keepInputVersion);
		}
		finally
		{
		}
	}

	public unsafe static Il2CppStructArray<Hash128> GetCachedVersions(string assetBundleName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Hash128> result;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetCachedVersions_Injected(ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetCachedVersions_Injected(ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Hash128> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Hash128>*)(&array));
			result = array;
		}
		return result;
	}

	public static void GetCachedVersions(string assetBundleName, List<Hash128> outCachedVersions)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(assetBundleName))
		{
			throw new Il2CppSystem.ArgumentException("Input AssetBundle name cannot be null or empty.");
		}
		if (outCachedVersions == null)
		{
			throw new Il2CppSystem.ArgumentNullException("Input outCachedVersions cannot be null.");
		}
		outCachedVersions.AddRange((IEnumerable<Hash128>)(object)GetCachedVersions(assetBundleName));
	}

	public static bool IsVersionCached(string url, int version)
	{
		return IsVersionCached(url, new Hash128(0u, 0u, 0u, (uint)version));
	}

	public static bool IsVersionCached(string url, Hash128 hash)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(url))
		{
			throw new Il2CppSystem.ArgumentException("Input AssetBundle url cannot be null or empty.");
		}
		return IsVersionCached(url, "", hash);
	}

	public unsafe static bool IsVersionCached(string url, string assetBundleName, Hash128 hash)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper url2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(url, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(url);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					url2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return IsVersionCached_Injected(ref url2, ref managedSpanWrapper2, ref hash);
						}
					}
					return IsVersionCached_Injected(ref url2, ref managedSpanWrapper2, ref hash);
				}
			}
			url2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return IsVersionCached_Injected(ref url2, ref managedSpanWrapper2, ref hash);
				}
			}
			return IsVersionCached_Injected(ref url2, ref managedSpanWrapper2, ref hash);
		}
		finally
		{
		}
	}

	public static bool MarkAsUsed(string url, int version)
	{
		return MarkAsUsed(url, new Hash128(0u, 0u, 0u, (uint)version));
	}

	public static bool MarkAsUsed(string url, Hash128 hash)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(url))
		{
			throw new Il2CppSystem.ArgumentException("Input AssetBundle url cannot be null or empty.");
		}
		return MarkAsUsed(url, "", hash);
	}

	public unsafe static bool MarkAsUsed(string url, string assetBundleName, Hash128 hash)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper url2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(url, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(url);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					url2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return MarkAsUsed_Injected(ref url2, ref managedSpanWrapper2, ref hash);
						}
					}
					return MarkAsUsed_Injected(ref url2, ref managedSpanWrapper2, ref hash);
				}
			}
			url2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(assetBundleName);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return MarkAsUsed_Injected(ref url2, ref managedSpanWrapper2, ref hash);
				}
			}
			return MarkAsUsed_Injected(ref url2, ref managedSpanWrapper2, ref hash);
		}
		finally
		{
		}
	}

	public static int GetVersionFromCache(string url)
	{
		return -1;
	}

	public static void GetAllCachePaths(List<string> cachePaths)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool CleanCache()
	{
		return ClearCache();
	}

	public unsafe static bool ClearCachedVersionInternal_Injected(ref ManagedSpanWrapper assetBundleName, [In] ref Hash128 hash)
	{
		return ClearCachedVersionInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref assetBundleName), (nint)Unsafe.AsPointer(ref hash));
	}

	public unsafe static bool ClearCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, [In] ref Hash128 hash, bool keepInputVersion)
	{
		return ClearCachedVersions_InjectedDelegateField((nint)Unsafe.AsPointer(ref assetBundleName), (nint)Unsafe.AsPointer(ref hash), keepInputVersion);
	}

	public unsafe static void GetCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, out BlittableArrayWrapper ret)
	{
		GetCachedVersions_InjectedDelegateField((nint)Unsafe.AsPointer(ref assetBundleName), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool IsVersionCached_Injected(ref ManagedSpanWrapper url, ref ManagedSpanWrapper assetBundleName, [In] ref Hash128 hash)
	{
		return IsVersionCached_InjectedDelegateField((nint)Unsafe.AsPointer(ref url), (nint)Unsafe.AsPointer(ref assetBundleName), (nint)Unsafe.AsPointer(ref hash));
	}

	public unsafe static bool MarkAsUsed_Injected(ref ManagedSpanWrapper url, ref ManagedSpanWrapper assetBundleName, [In] ref Hash128 hash)
	{
		return MarkAsUsed_InjectedDelegateField((nint)Unsafe.AsPointer(ref url), (nint)Unsafe.AsPointer(ref assetBundleName), (nint)Unsafe.AsPointer(ref hash));
	}
}
