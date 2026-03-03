using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace Unity.IO.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ReadHandle
{
	private delegate long GetReadCount_InjectedDelegate([In] System.IntPtr handle);

	private delegate long GetBytesRead_InjectedDelegate([In] System.IntPtr handle);

	private delegate long GetBytesReadForCommand_InjectedDelegate([In] System.IntPtr handle, uint readCommandIndex);

	private delegate System.IntPtr GetBytesReadArray_InjectedDelegate([In] System.IntPtr handle);

	private static readonly System.IntPtr NativeFieldInfoPtr_ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelInternal_Private_Static_Void_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_ReadStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReadStatus_Private_Static_ReadStatus_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseReadHandle_Private_Static_Void_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReadHandleValid_Private_Static_Boolean_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Private_Static_JobHandle_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelInternal_Injected_Private_Static_Void_byref_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReadStatus_Injected_Private_Static_ReadStatus_byref_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseReadHandle_Injected_Private_Static_Void_byref_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReadHandleValid_Injected_Private_Static_Boolean_byref_ReadHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJobHandle_Injected_Private_Static_Void_byref_ReadHandle_byref_JobHandle_0;

	[FieldOffset(0)]
	public System.IntPtr ptr;

	[FieldOffset(8)]
	public int version;

	private static readonly GetReadCount_InjectedDelegate GetReadCount_InjectedDelegateField;

	private static readonly GetBytesRead_InjectedDelegate GetBytesRead_InjectedDelegateField;

	private static readonly GetBytesReadForCommand_InjectedDelegate GetBytesReadForCommand_InjectedDelegateField;

	private static readonly GetBytesReadArray_InjectedDelegate GetBytesReadArray_InjectedDelegateField;

	public unsafe JobHandle JobHandle
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1164991, RefRangeEnd = 1165007, XrefRangeStart = 1164987, XrefRangeEnd = 1164991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ReadStatus Status
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1165011, RefRangeEnd = 1165020, XrefRangeStart = 1165007, XrefRangeEnd = 1165011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Status_Public_get_ReadStatus_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ReadStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public long ReadCount
	{
		get
		{
			if (!IsReadHandleValid(this))
			{
				throw new Il2CppSystem.InvalidOperationException("Cannot use a ReadHandle that has been disposed");
			}
			return GetReadCount(this);
		}
	}

	static ReadHandle()
	{
		Il2CppClassPointerStore<ReadHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "ReadHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr);
		NativeFieldInfoPtr_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, "ptr");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, "version");
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_CancelInternal_Private_Static_Void_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_get_JobHandle_Public_get_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_get_Status_Public_get_ReadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_GetReadStatus_Private_Static_ReadStatus_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_ReleaseReadHandle_Private_Static_Void_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_IsReadHandleValid_Private_Static_Boolean_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_GetJobHandle_Private_Static_JobHandle_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_CancelInternal_Injected_Private_Static_Void_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_GetReadStatus_Injected_Private_Static_ReadStatus_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_ReleaseReadHandle_Injected_Private_Static_Void_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_IsReadHandleValid_Injected_Private_Static_Boolean_byref_ReadHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_GetJobHandle_Injected_Private_Static_Void_byref_ReadHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, 100663493);
		GetReadCount_InjectedDelegateField = IL2CPP.ResolveICall<GetReadCount_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.ReadHandle::GetReadCount_Injected");
		GetBytesRead_InjectedDelegateField = IL2CPP.ResolveICall<GetBytesRead_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesRead_Injected");
		GetBytesReadForCommand_InjectedDelegateField = IL2CPP.ResolveICall<GetBytesReadForCommand_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesReadForCommand_Injected");
		GetBytesReadArray_InjectedDelegateField = IL2CPP.ResolveICall<GetBytesReadArray_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.ReadHandle::GetBytesReadArray_Injected");
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 1164940, RefRangeEnd = 1164969, XrefRangeStart = 1164938, XrefRangeEnd = 1164940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164969, XrefRangeEnd = 1164974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1164978, RefRangeEnd = 1164985, XrefRangeStart = 1164974, XrefRangeEnd = 1164978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cancel()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cancel_Public_Void_0, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164985, XrefRangeEnd = 1164987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CancelInternal(ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelInternal_Private_Static_Void_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165020, XrefRangeEnd = 1165022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReadStatus GetReadStatus(ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReadStatus_Private_Static_ReadStatus_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ReadStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165022, XrefRangeEnd = 1165024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseReadHandle(ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseReadHandle_Private_Static_Void_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165024, XrefRangeEnd = 1165026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsReadHandleValid(ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsReadHandleValid_Private_Static_Boolean_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165026, XrefRangeEnd = 1165028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobHandle GetJobHandle(ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJobHandle_Private_Static_JobHandle_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165028, XrefRangeEnd = 1165030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CancelInternal_Injected([In] ref ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelInternal_Injected_Private_Static_Void_byref_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165030, XrefRangeEnd = 1165032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReadStatus GetReadStatus_Injected([In] ref ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReadStatus_Injected_Private_Static_ReadStatus_byref_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ReadStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165032, XrefRangeEnd = 1165034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseReadHandle_Injected([In] ref ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseReadHandle_Injected_Private_Static_Void_byref_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165034, XrefRangeEnd = 1165036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsReadHandleValid_Injected([In] ref ReadHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsReadHandleValid_Injected_Private_Static_Boolean_byref_ReadHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165036, XrefRangeEnd = 1165038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetJobHandle_Injected([In] ref ReadHandle handle, out JobHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJobHandle_Injected_Private_Static_Void_byref_ReadHandle_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadHandle>.NativeClassPtr, (System.IntPtr)(nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}

	public long GetBytesRead()
	{
		if (!IsReadHandleValid(this))
		{
			throw new Il2CppSystem.InvalidOperationException("ReadHandle.GetBytesRead cannot be called after the ReadHandle has been disposed");
		}
		return GetBytesRead(this);
	}

	public long GetBytesRead(uint readCommandIndex)
	{
		if (!IsReadHandleValid(this))
		{
			throw new Il2CppSystem.InvalidOperationException("ReadHandle.GetBytesRead cannot be called after the ReadHandle has been disposed");
		}
		return GetBytesReadForCommand(this, readCommandIndex);
	}

	public unsafe ulong* GetBytesReadArray()
	{
		if (!IsReadHandleValid(this))
		{
			throw new Il2CppSystem.InvalidOperationException("ReadHandle.GetBytesReadArray cannot be called after the ReadHandle has been disposed");
		}
		return GetBytesReadArray(this);
	}

	public static long GetReadCount(ReadHandle handle)
	{
		return GetReadCount_Injected(ref handle);
	}

	public static long GetBytesRead(ReadHandle handle)
	{
		return GetBytesRead_Injected(ref handle);
	}

	public static long GetBytesReadForCommand(ReadHandle handle, uint readCommandIndex)
	{
		return GetBytesReadForCommand_Injected(ref handle, readCommandIndex);
	}

	public unsafe static ulong* GetBytesReadArray(ReadHandle handle)
	{
		return GetBytesReadArray_Injected(ref handle);
	}

	public unsafe static long GetReadCount_Injected([In] ref ReadHandle handle)
	{
		return GetReadCount_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}

	public unsafe static long GetBytesRead_Injected([In] ref ReadHandle handle)
	{
		return GetBytesRead_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}

	public unsafe static long GetBytesReadForCommand_Injected([In] ref ReadHandle handle, uint readCommandIndex)
	{
		return GetBytesReadForCommand_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle), readCommandIndex);
	}

	public unsafe static ulong* GetBytesReadArray_Injected([In] ref ReadHandle handle)
	{
		return (ulong*)GetBytesReadArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref handle));
	}
}
