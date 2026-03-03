using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct FileHandle
{
	private delegate FileStatus GetFileStatus_InternalDelegate([In] System.IntPtr handle);

	private static readonly System.IntPtr NativeFieldInfoPtr_fileCommandPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_JobHandle_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFileHandleValid_Private_Static_Boolean_byref_FileHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Internal_Private_Static_JobHandle_byref_FileHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Internal_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_0;

	[FieldOffset(0)]
	public readonly System.IntPtr fileCommandPtr;

	[FieldOffset(8)]
	public readonly int version;

	private static readonly GetFileStatus_InternalDelegate GetFileStatus_InternalDelegateField;

	public unsafe JobHandle JobHandle
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1164919, RefRangeEnd = 1164920, XrefRangeStart = 1164915, XrefRangeEnd = 1164919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public FileStatus Status
	{
		get
		{
			if (!IsFileHandleValid(ref this))
			{
				throw new Il2CppSystem.InvalidOperationException("FileHandle.Status cannot be called on a closed FileHandle");
			}
			return GetFileStatus_Internal(ref this);
		}
	}

	static FileHandle()
	{
		Il2CppClassPointerStore<FileHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "FileHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileHandle>.NativeClassPtr);
		NativeFieldInfoPtr_fileCommandPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, "fileCommandPtr");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, "version");
		NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_Close_Public_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_IsFileHandleValid_Private_Static_Boolean_byref_FileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_GetJobHandle_Internal_Private_Static_JobHandle_byref_FileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_GetJobHandle_Internal_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, 100663478);
		GetFileStatus_InternalDelegateField = IL2CPP.ResolveICall<GetFileStatus_InternalDelegate>("Unity.IO.LowLevel.Unsafe.FileHandle::GetFileStatus_Internal");
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1164922, RefRangeEnd = 1164927, XrefRangeStart = 1164920, XrefRangeEnd = 1164922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1164931, RefRangeEnd = 1164934, XrefRangeStart = 1164927, XrefRangeEnd = 1164931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle Close(JobHandle dependency = default(JobHandle))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dependency);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_JobHandle_JobHandle_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1164922, RefRangeEnd = 1164927, XrefRangeStart = 1164922, XrefRangeEnd = 1164927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsFileHandleValid([In] ref FileHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFileHandleValid_Private_Static_Boolean_byref_FileHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164934, XrefRangeEnd = 1164936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle GetJobHandle_Internal([In] ref FileHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJobHandle_Internal_Private_Static_JobHandle_byref_FileHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164936, XrefRangeEnd = 1164938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetJobHandle_Internal_Injected([In] ref FileHandle handle, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJobHandle_Internal_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FileHandle>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}

	public unsafe static FileStatus GetFileStatus_Internal([In] ref FileHandle handle)
	{
		return GetFileStatus_InternalDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}
}
