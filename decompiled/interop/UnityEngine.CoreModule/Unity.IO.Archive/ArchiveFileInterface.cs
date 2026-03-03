using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.IO.Archive;

public static class ArchiveFileInterface : Il2CppSystem.Object
{
	private delegate ArchiveStatus Archive_GetStatus_InjectedDelegate([In] System.IntPtr handle);

	private delegate void Archive_GetJobHandle_InjectedDelegate([In] System.IntPtr handle, [Out] System.IntPtr ret);

	private delegate bool Archive_IsValid_InjectedDelegate([In] System.IntPtr handle);

	private delegate void Archive_UnmountAsync_InjectedDelegate([In] System.IntPtr handle, [Out] System.IntPtr ret);

	private delegate void Archive_GetMountPath_InjectedDelegate([In] System.IntPtr handle, [Out] System.IntPtr ret);

	private delegate CompressionType Archive_GetCompression_InjectedDelegate([In] System.IntPtr handle);

	private delegate bool Archive_IsStreamed_InjectedDelegate([In] System.IntPtr handle);

	private delegate System.IntPtr Archive_GetFileInfo_InjectedDelegate([In] System.IntPtr handle);

	private static readonly Archive_GetStatus_InjectedDelegate Archive_GetStatus_InjectedDelegateField;

	private static readonly Archive_GetJobHandle_InjectedDelegate Archive_GetJobHandle_InjectedDelegateField;

	private static readonly Archive_IsValid_InjectedDelegate Archive_IsValid_InjectedDelegateField;

	private static readonly Archive_UnmountAsync_InjectedDelegate Archive_UnmountAsync_InjectedDelegateField;

	private static readonly Archive_GetMountPath_InjectedDelegate Archive_GetMountPath_InjectedDelegateField;

	private static readonly Archive_GetCompression_InjectedDelegate Archive_GetCompression_InjectedDelegateField;

	private static readonly Archive_IsStreamed_InjectedDelegate Archive_IsStreamed_InjectedDelegateField;

	private static readonly Archive_GetFileInfo_InjectedDelegate Archive_GetFileInfo_InjectedDelegateField;

	static ArchiveFileInterface()
	{
		Il2CppClassPointerStore<ArchiveFileInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveFileInterface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveFileInterface>.NativeClassPtr);
		Archive_GetStatus_InjectedDelegateField = IL2CPP.ResolveICall<Archive_GetStatus_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetStatus_Injected");
		Archive_GetJobHandle_InjectedDelegateField = IL2CPP.ResolveICall<Archive_GetJobHandle_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetJobHandle_Injected");
		Archive_IsValid_InjectedDelegateField = IL2CPP.ResolveICall<Archive_IsValid_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_IsValid_Injected");
		Archive_UnmountAsync_InjectedDelegateField = IL2CPP.ResolveICall<Archive_UnmountAsync_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_UnmountAsync_Injected");
		Archive_GetMountPath_InjectedDelegateField = IL2CPP.ResolveICall<Archive_GetMountPath_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetMountPath_Injected");
		Archive_GetCompression_InjectedDelegateField = IL2CPP.ResolveICall<Archive_GetCompression_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetCompression_Injected");
		Archive_IsStreamed_InjectedDelegateField = IL2CPP.ResolveICall<Archive_IsStreamed_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_IsStreamed_Injected");
		Archive_GetFileInfo_InjectedDelegateField = IL2CPP.ResolveICall<Archive_GetFileInfo_InjectedDelegate>("Unity.IO.Archive.ArchiveFileInterface::Archive_GetFileInfo_Injected");
	}

	public ArchiveFileInterface(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static ArchiveStatus Archive_GetStatus(ArchiveHandle handle)
	{
		return Archive_GetStatus_Injected(ref handle);
	}

	public static JobHandle Archive_GetJobHandle(ArchiveHandle handle)
	{
		Archive_GetJobHandle_Injected(ref handle, out var ret);
		return ret;
	}

	public static bool Archive_IsValid(ArchiveHandle handle)
	{
		return Archive_IsValid_Injected(ref handle);
	}

	public static JobHandle Archive_UnmountAsync(ArchiveHandle handle)
	{
		Archive_UnmountAsync_Injected(ref handle, out var ret);
		return ret;
	}

	public static string Archive_GetMountPath(ArchiveHandle handle)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			Archive_GetMountPath_Injected(ref handle, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static CompressionType Archive_GetCompression(ArchiveHandle handle)
	{
		return Archive_GetCompression_Injected(ref handle);
	}

	public static bool Archive_IsStreamed(ArchiveHandle handle)
	{
		return Archive_IsStreamed_Injected(ref handle);
	}

	public static Il2CppReferenceArray<ArchiveFileInfo> Archive_GetFileInfo(ArchiveHandle handle)
	{
		return Archive_GetFileInfo_Injected(ref handle);
	}

	public unsafe static ArchiveStatus Archive_GetStatus_Injected([In] ref ArchiveHandle handle)
	{
		return Archive_GetStatus_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe static void Archive_GetJobHandle_Injected([In] ref ArchiveHandle handle, out JobHandle ret)
	{
		Archive_GetJobHandle_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool Archive_IsValid_Injected([In] ref ArchiveHandle handle)
	{
		return Archive_IsValid_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe static void Archive_UnmountAsync_Injected([In] ref ArchiveHandle handle, out JobHandle ret)
	{
		Archive_UnmountAsync_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Archive_GetMountPath_Injected([In] ref ArchiveHandle handle, out ManagedSpanWrapper ret)
	{
		Archive_GetMountPath_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static CompressionType Archive_GetCompression_Injected([In] ref ArchiveHandle handle)
	{
		return Archive_GetCompression_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe static bool Archive_IsStreamed_Injected([In] ref ArchiveHandle handle)
	{
		return Archive_IsStreamed_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe static Il2CppReferenceArray<ArchiveFileInfo> Archive_GetFileInfo_Injected([In] ref ArchiveHandle handle)
	{
		System.IntPtr intPtr = Archive_GetFileInfo_InjectedDelegateField((nint)Unsafe.AsPointer(ref handle));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ArchiveFileInfo>>(intPtr) : null;
	}
}
