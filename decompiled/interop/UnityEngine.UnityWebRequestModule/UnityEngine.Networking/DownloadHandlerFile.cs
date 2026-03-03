using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

public sealed class DownloadHandlerFile : DownloadHandler
{
	public new static class BindingsMarshaller
	{
	}

	private delegate System.IntPtr Create_InjectedDelegate(System.IntPtr obj, System.IntPtr path, bool append);

	private delegate bool get_removeFileOnAbort_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_removeFileOnAbort_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private static readonly Create_InjectedDelegate Create_InjectedDelegateField = IL2CPP.ResolveICall<Create_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerFile::Create_Injected");

	private static readonly get_removeFileOnAbort_InjectedDelegate get_removeFileOnAbort_InjectedDelegateField = IL2CPP.ResolveICall<get_removeFileOnAbort_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerFile::get_removeFileOnAbort_Injected");

	private static readonly set_removeFileOnAbort_InjectedDelegate set_removeFileOnAbort_InjectedDelegateField = IL2CPP.ResolveICall<set_removeFileOnAbort_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerFile::set_removeFileOnAbort_Injected");

	public bool removeFileOnAbort
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_removeFileOnAbort_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_removeFileOnAbort_Injected(intPtr, value);
		}
	}

	public unsafe static System.IntPtr Create(DownloadHandlerFile obj, string path, bool append)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(path);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return Create_Injected(obj, ref managedSpanWrapper, append);
				}
			}
			return Create_Injected(obj, ref managedSpanWrapper, append);
		}
		finally
		{
		}
	}

	public void InternalCreateVFS(string path, bool append)
	{
		string directoryName = Path.GetDirectoryName(path);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		base.m_Ptr = Create(this, path, append);
	}

	public override NativeArray<byte> GetNativeData()
	{
		throw new Il2CppSystem.NotSupportedException("Raw data access is not supported");
	}

	public override Il2CppStructArray<byte> GetData()
	{
		throw new Il2CppSystem.NotSupportedException("Raw data access is not supported");
	}

	public override string GetText()
	{
		throw new Il2CppSystem.NotSupportedException("String access is not supported");
	}

	public unsafe static System.IntPtr Create_Injected(DownloadHandlerFile obj, ref ManagedSpanWrapper path, bool append)
	{
		return Create_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj), (nint)Unsafe.AsPointer(ref path), append);
	}

	public static bool get_removeFileOnAbort_Injected(System.IntPtr _unity_self)
	{
		return get_removeFileOnAbort_InjectedDelegateField(_unity_self);
	}

	public static void set_removeFileOnAbort_Injected(System.IntPtr _unity_self, bool value)
	{
		set_removeFileOnAbort_InjectedDelegateField(_unity_self, value);
	}
}
