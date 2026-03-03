using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

public sealed class DownloadHandlerAssetBundle : DownloadHandler
{
	public new static class BindingsMarshaller
	{
	}

	private delegate System.IntPtr Create_InjectedDelegate(System.IntPtr obj, System.IntPtr url, uint crc);

	private delegate System.IntPtr CreateCached_InjectedDelegate(System.IntPtr obj, System.IntPtr url, System.IntPtr name, [In] System.IntPtr hash, uint crc);

	private delegate System.IntPtr get_assetBundle_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_autoLoadAssetBundle_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_autoLoadAssetBundle_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_isDownloadComplete_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly Create_InjectedDelegate Create_InjectedDelegateField = IL2CPP.ResolveICall<Create_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::Create_Injected");

	private static readonly CreateCached_InjectedDelegate CreateCached_InjectedDelegateField = IL2CPP.ResolveICall<CreateCached_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::CreateCached_Injected");

	private static readonly get_assetBundle_InjectedDelegate get_assetBundle_InjectedDelegateField = IL2CPP.ResolveICall<get_assetBundle_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::get_assetBundle_Injected");

	private static readonly get_autoLoadAssetBundle_InjectedDelegate get_autoLoadAssetBundle_InjectedDelegateField = IL2CPP.ResolveICall<get_autoLoadAssetBundle_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::get_autoLoadAssetBundle_Injected");

	private static readonly set_autoLoadAssetBundle_InjectedDelegate set_autoLoadAssetBundle_InjectedDelegateField = IL2CPP.ResolveICall<set_autoLoadAssetBundle_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::set_autoLoadAssetBundle_Injected");

	private static readonly get_isDownloadComplete_InjectedDelegate get_isDownloadComplete_InjectedDelegateField = IL2CPP.ResolveICall<get_isDownloadComplete_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::get_isDownloadComplete_Injected");

	public AssetBundle assetBundle
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<AssetBundle>(get_assetBundle_Injected(intPtr));
		}
	}

	public bool autoLoadAssetBundle
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoLoadAssetBundle_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoLoadAssetBundle_Injected(intPtr, value);
		}
	}

	public bool isDownloadComplete
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isDownloadComplete_Injected(intPtr);
		}
	}

	public unsafe static System.IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(url, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = url.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return Create_Injected(obj, ref managedSpanWrapper, crc);
				}
			}
			return Create_Injected(obj, ref managedSpanWrapper, crc);
		}
		finally
		{
		}
	}

	public unsafe static System.IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_0053: Expected O, but got Ref
		//The blocks IL_002a, IL_0037, IL_0045, IL_0053, IL_0058 are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper url2;
			ReadOnlySpan<char> readOnlySpan2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(url, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = url.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					url2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper2))
					{
						readOnlySpan2 = name.AsSpan();
						fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return CreateCached_Injected(obj, ref url2, ref managedSpanWrapper2, ref hash, crc);
						}
					}
					return CreateCached_Injected(obj, ref url2, ref managedSpanWrapper2, ref hash, crc);
				}
			}
			url2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper2))
			{
				readOnlySpan2 = name.AsSpan();
				fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return CreateCached_Injected(obj, ref url2, ref managedSpanWrapper2, ref hash, crc);
				}
			}
			return CreateCached_Injected(obj, ref url2, ref managedSpanWrapper2, ref hash, crc);
		}
		finally
		{
		}
	}

	public void InternalCreateAssetBundle(string url, uint crc)
	{
		base.m_Ptr = Create(this, url, crc);
	}

	public void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc)
	{
		base.m_Ptr = CreateCached(this, url, name, hash, crc);
	}

	public override Il2CppStructArray<byte> GetData()
	{
		throw new NotSupportedException("Raw data access is not supported for asset bundles");
	}

	public override string GetText()
	{
		throw new NotSupportedException("String access is not supported for asset bundles");
	}

	public static AssetBundle GetContent(UnityWebRequest www)
	{
		return DownloadHandler.GetCheckedDownloader<DownloadHandlerAssetBundle>(www).assetBundle;
	}

	public unsafe static System.IntPtr Create_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, uint crc)
	{
		return Create_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref url), crc);
	}

	public unsafe static System.IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, ref ManagedSpanWrapper url, ref ManagedSpanWrapper name, [In] ref Hash128 hash, uint crc)
	{
		return CreateCached_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref url), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref name), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hash), crc);
	}

	public static System.IntPtr get_assetBundle_Injected(System.IntPtr _unity_self)
	{
		return get_assetBundle_InjectedDelegateField(_unity_self);
	}

	public static bool get_autoLoadAssetBundle_Injected(System.IntPtr _unity_self)
	{
		return get_autoLoadAssetBundle_InjectedDelegateField(_unity_self);
	}

	public static void set_autoLoadAssetBundle_Injected(System.IntPtr _unity_self, bool value)
	{
		set_autoLoadAssetBundle_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isDownloadComplete_Injected(System.IntPtr _unity_self)
	{
		return get_isDownloadComplete_InjectedDelegateField(_unity_self);
	}
}
