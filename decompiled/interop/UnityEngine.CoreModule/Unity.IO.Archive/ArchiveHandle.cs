using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine;

namespace Unity.IO.Archive;

[StructLayout(LayoutKind.Explicit)]
public struct ArchiveHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Handle;

	[FieldOffset(0)]
	public ulong Handle;

	public ArchiveStatus Status
	{
		get
		{
			ThrowIfInvalid();
			return ArchiveFileInterface.Archive_GetStatus(this);
		}
	}

	public JobHandle JobHandle
	{
		get
		{
			ThrowIfInvalid();
			return ArchiveFileInterface.Archive_GetJobHandle(this);
		}
	}

	public CompressionType Compression
	{
		get
		{
			ThrowIfInvalid();
			return ArchiveFileInterface.Archive_GetCompression(this);
		}
	}

	public bool IsStreamed
	{
		get
		{
			ThrowIfInvalid();
			return ArchiveFileInterface.Archive_IsStreamed(this);
		}
	}

	static ArchiveHandle()
	{
		Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", "ArchiveHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr);
		NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr, "Handle");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArchiveHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public JobHandle Unmount()
	{
		ThrowIfInvalid();
		return ArchiveFileInterface.Archive_UnmountAsync(this);
	}

	public void ThrowIfInvalid()
	{
		if (!ArchiveFileInterface.Archive_IsValid(this))
		{
			throw new Il2CppSystem.InvalidOperationException("The archive has already been unmounted.");
		}
	}

	public string GetMountPath()
	{
		ThrowIfInvalid();
		return ArchiveFileInterface.Archive_GetMountPath(this);
	}

	public Il2CppReferenceArray<ArchiveFileInfo> GetFileInfo()
	{
		ThrowIfInvalid();
		return ArchiveFileInterface.Archive_GetFileInfo(this);
	}
}
