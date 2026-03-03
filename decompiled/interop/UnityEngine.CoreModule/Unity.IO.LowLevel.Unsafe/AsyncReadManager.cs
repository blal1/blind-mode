using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe;

public static class AsyncReadManager : Il2CppSystem.Object
{
	private delegate void ReadInternal_InjectedDelegate(System.IntPtr filename, System.IntPtr cmds, uint cmdCount, System.IntPtr assetName, ulong typeID, AssetLoadingSubsystem subsystem, [Out] System.IntPtr ret);

	private delegate void ReadWithHandlesInternal_NativePtr_InjectedDelegate([In] System.IntPtr fileHandle, System.IntPtr readCmdArray, [In] System.IntPtr dependency, [Out] System.IntPtr ret);

	private delegate void CloseCachedFileAsync_InjectedDelegate(System.IntPtr fileName, [In] System.IntPtr dependency, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFileInfoInternal_Private_Static_ReadHandle_String_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFileInfo_Public_Static_ReadHandle_String_ptr_FileInfoResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Private_Static_ReadHandle_byref_FileHandle_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Static_ReadHandle_byref_FileHandle_ReadCommandArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenFileAsync_Internal_Private_Static_FileHandle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenFileAsync_Public_Static_FileHandle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseFileAsync_Internal_Static_JobHandle_byref_FileHandle_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFileInfoInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_ptr_Void_byref_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Injected_Private_Static_Void_byref_FileHandle_ptr_Void_byref_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenFileAsync_Internal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_FileHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseFileAsync_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_byref_JobHandle_0;

	private static readonly ReadInternal_InjectedDelegate ReadInternal_InjectedDelegateField;

	private static readonly ReadWithHandlesInternal_NativePtr_InjectedDelegate ReadWithHandlesInternal_NativePtr_InjectedDelegateField;

	private static readonly CloseCachedFileAsync_InjectedDelegate CloseCachedFileAsync_InjectedDelegateField;

	static AsyncReadManager()
	{
		Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr);
		NativeMethodInfoPtr_GetFileInfoInternal_Private_Static_ReadHandle_String_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_GetFileInfo_Public_Static_ReadHandle_String_ptr_FileInfoResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Private_Static_ReadHandle_byref_FileHandle_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_Read_Public_Static_ReadHandle_byref_FileHandle_ReadCommandArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_OpenFileAsync_Internal_Private_Static_FileHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_OpenFileAsync_Public_Static_FileHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_CloseFileAsync_Internal_Static_JobHandle_byref_FileHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_GetFileInfoInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_ptr_Void_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Injected_Private_Static_Void_byref_FileHandle_ptr_Void_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_OpenFileAsync_Internal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_FileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_CloseFileAsync_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncReadManager>.NativeClassPtr, 100663504);
		ReadInternal_InjectedDelegateField = IL2CPP.ResolveICall<ReadInternal_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManager::ReadInternal_Injected");
		ReadWithHandlesInternal_NativePtr_InjectedDelegateField = IL2CPP.ResolveICall<ReadWithHandlesInternal_NativePtr_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManager::ReadWithHandlesInternal_NativePtr_Injected");
		CloseCachedFileAsync_InjectedDelegateField = IL2CPP.ResolveICall<CloseCachedFileAsync_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManager::CloseCachedFileAsync_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1165052, RefRangeEnd = 1165053, XrefRangeStart = 1165038, XrefRangeEnd = 1165052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReadHandle GetFileInfoInternal(string filename, void* cmd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = cmd;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileInfoInternal_Private_Static_ReadHandle_String_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ReadHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1165054, RefRangeEnd = 1165056, XrefRangeStart = 1165053, XrefRangeEnd = 1165054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReadHandle GetFileInfo(string filename, FileInfoResult* result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(FileInfoResult**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = result;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileInfo_Public_Static_ReadHandle_String_ptr_FileInfoResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ReadHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165056, XrefRangeEnd = 1165058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReadHandle ReadWithHandlesInternal_NativeCopy([In] ref FileHandle fileHandle, void* readCmdArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fileHandle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = readCmdArray;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Private_Static_ReadHandle_byref_FileHandle_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ReadHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1165062, RefRangeEnd = 1165063, XrefRangeStart = 1165058, XrefRangeEnd = 1165062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReadHandle Read([In] ref FileHandle fileHandle, ReadCommandArray readCmdArray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fileHandle);
		*(ReadCommandArray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &readCmdArray;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read_Public_Static_ReadHandle_byref_FileHandle_ReadCommandArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ReadHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1165077, RefRangeEnd = 1165078, XrefRangeStart = 1165063, XrefRangeEnd = 1165077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FileHandle OpenFileAsync_Internal(string fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenFileAsync_Internal_Private_Static_FileHandle_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FileHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1165079, RefRangeEnd = 1165080, XrefRangeStart = 1165078, XrefRangeEnd = 1165079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FileHandle OpenFileAsync(string fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenFileAsync_Public_Static_FileHandle_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FileHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165080, XrefRangeEnd = 1165082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle CloseFileAsync([In] ref FileHandle fileHandle, JobHandle dependency)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fileHandle);
		*(JobHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dependency;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseFileAsync_Internal_Static_JobHandle_byref_FileHandle_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165082, XrefRangeEnd = 1165084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetFileInfoInternal_Injected(ref ManagedSpanWrapper filename, void* cmd, out ReadHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref filename);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = cmd;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileInfoInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_ptr_Void_byref_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165084, XrefRangeEnd = 1165086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadWithHandlesInternal_NativeCopy_Injected([In] ref FileHandle fileHandle, void* readCmdArray, out ReadHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fileHandle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = readCmdArray;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadWithHandlesInternal_NativeCopy_Injected_Private_Static_Void_byref_FileHandle_ptr_Void_byref_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165086, XrefRangeEnd = 1165088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenFileAsync_Internal_Injected(ref ManagedSpanWrapper fileName, out FileHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fileName);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenFileAsync_Internal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_FileHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165088, XrefRangeEnd = 1165090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CloseFileAsync_Injected([In] ref FileHandle fileHandle, [In] ref JobHandle dependency, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fileHandle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref dependency);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseFileAsync_Injected_Private_Static_Void_byref_FileHandle_byref_JobHandle_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AsyncReadManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static ReadHandle ReadInternal(string filename, void* cmds, uint cmdCount, string assetName, ulong typeID, AssetLoadingSubsystem subsystem)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0046: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//The blocks IL_0029, IL_0038, IL_0046, IL_0054, IL_0059 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ReadHandle ret);
		ReadHandle result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper filename2;
			void* cmds2;
			uint cmdCount2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(filename, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(filename);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					filename2 = ref managedSpanWrapper;
					cmds2 = cmds;
					cmdCount2 = cmdCount;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(assetName, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(assetName);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							ReadInternal_Injected(ref filename2, cmds2, cmdCount2, ref managedSpanWrapper2, typeID, subsystem, out ret);
						}
					}
					else
					{
						ReadInternal_Injected(ref filename2, cmds2, cmdCount2, ref managedSpanWrapper2, typeID, subsystem, out ret);
					}
				}
			}
			else
			{
				filename2 = ref managedSpanWrapper;
				cmds2 = cmds;
				cmdCount2 = cmdCount;
				if (!StringMarshaller.TryMarshalEmptyOrNullString(assetName, ref managedSpanWrapper2))
				{
					readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(assetName);
					fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
					{
						managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
						ReadInternal_Injected(ref filename2, cmds2, cmdCount2, ref managedSpanWrapper2, typeID, subsystem, out ret);
					}
				}
				else
				{
					ReadInternal_Injected(ref filename2, cmds2, cmdCount2, ref managedSpanWrapper2, typeID, subsystem, out ret);
				}
			}
		}
		finally
		{
			result = ret;
		}
		return result;
	}

	public unsafe static ReadHandle Read(string filename, ReadCommand* readCmds, uint readCmdCount, [Optional] string assetName, [Optional] ulong typeID, [Optional] AssetLoadingSubsystem subsystem)
	{
		return ReadInternal(filename, readCmds, readCmdCount, assetName, typeID, subsystem);
	}

	public unsafe static ReadHandle ReadWithHandlesInternal_NativePtr([In] ref FileHandle fileHandle, void* readCmdArray, JobHandle dependency)
	{
		ReadWithHandlesInternal_NativePtr_Injected(ref fileHandle, readCmdArray, ref dependency, out var ret);
		return ret;
	}

	public unsafe static ReadHandle ReadDeferred([In] ref FileHandle fileHandle, ReadCommandArray* readCmdArray, JobHandle dependency)
	{
		if (!fileHandle.IsValid())
		{
			throw new Il2CppSystem.InvalidOperationException("FileHandle is invalid and may not be read from.");
		}
		return ReadWithHandlesInternal_NativePtr(ref fileHandle, readCmdArray, dependency);
	}

	public unsafe static JobHandle CloseCachedFileAsync(string fileName, [Optional] JobHandle dependency)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out JobHandle ret);
		JobHandle result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(fileName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(fileName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					CloseCachedFileAsync_Injected(ref managedSpanWrapper, ref dependency, out ret);
				}
			}
			else
			{
				CloseCachedFileAsync_Injected(ref managedSpanWrapper, ref dependency, out ret);
			}
		}
		finally
		{
			result = ret;
		}
		return result;
	}

	public unsafe static void ReadInternal_Injected(ref ManagedSpanWrapper filename, void* cmds, uint cmdCount, ref ManagedSpanWrapper assetName, ulong typeID, AssetLoadingSubsystem subsystem, out ReadHandle ret)
	{
		ReadInternal_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref filename), (nint)cmds, cmdCount, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref assetName), typeID, subsystem, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReadWithHandlesInternal_NativePtr_Injected([In] ref FileHandle fileHandle, void* readCmdArray, [In] ref JobHandle dependency, out ReadHandle ret)
	{
		ReadWithHandlesInternal_NativePtr_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fileHandle), (nint)readCmdArray, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref dependency), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CloseCachedFileAsync_Injected(ref ManagedSpanWrapper fileName, [In] ref JobHandle dependency, out JobHandle ret)
	{
		CloseCachedFileAsync_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fileName), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref dependency), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
