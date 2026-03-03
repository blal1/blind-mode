using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.Profiling.Memory;

public static class MemoryProfiler : Il2CppSystem.Object
{
	private delegate void StartOperation_InjectedDelegate(uint captureFlag, bool requestScreenshot, System.IntPtr path, bool isRemote);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SnapshotFinished;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SaveScreenshotToDisk;

	private static readonly System.IntPtr NativeFieldInfoPtr_CreatingMetadata;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_CreatingMetadata_Public_Static_add_Void_Action_1_MemorySnapshotMetadata_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_CreatingMetadata_Public_Static_rem_Void_Action_1_MemorySnapshotMetadata_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0;

	private static readonly StartOperation_InjectedDelegate StartOperation_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action<string, bool> m_SnapshotFinished
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_SnapshotFinished, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_SnapshotFinished, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_SaveScreenshotToDisk, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string, bool, DebugScreenCapture>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_SaveScreenshotToDisk, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<MemorySnapshotMetadata> CreatingMetadata
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CreatingMetadata, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<MemorySnapshotMetadata>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CreatingMetadata, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MemoryProfiler()
	{
		Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.Memory", "MemoryProfiler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr);
		NativeFieldInfoPtr_m_SnapshotFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SnapshotFinished");
		NativeFieldInfoPtr_m_SaveScreenshotToDisk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "m_SaveScreenshotToDisk");
		NativeFieldInfoPtr_CreatingMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, "CreatingMetadata");
		NativeMethodInfoPtr_add_CreatingMetadata_Public_Static_add_Void_Action_1_MemorySnapshotMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_remove_CreatingMetadata_Public_Static_rem_Void_Action_1_MemorySnapshotMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryProfiler>.NativeClassPtr, 100663472);
		StartOperation_InjectedDelegateField = IL2CPP.ResolveICall<StartOperation_InjectedDelegate>("Unity.Profiling.Memory.MemoryProfiler::StartOperation_Injected");
	}

	[SpecialName]
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1164859, RefRangeEnd = 1164865, XrefRangeStart = 1164850, XrefRangeEnd = 1164859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_CreatingMetadata(Il2CppSystem.Action<MemorySnapshotMetadata> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_CreatingMetadata_Public_Static_add_Void_Action_1_MemorySnapshotMetadata_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1164874, RefRangeEnd = 1164880, XrefRangeStart = 1164865, XrefRangeEnd = 1164874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_CreatingMetadata(Il2CppSystem.Action<MemorySnapshotMetadata> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_CreatingMetadata_Public_Static_rem_Void_Action_1_MemorySnapshotMetadata_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164880, XrefRangeEnd = 1164903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> PrepareMetadata()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareMetadata_Private_Static_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static int WriteIntToByteArray(Il2CppStructArray<byte> array, int offset, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteIntToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164903, XrefRangeEnd = 1164904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int WriteStringToByteArray(Il2CppStructArray<byte> array, int offset, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteStringToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164904, XrefRangeEnd = 1164908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FinalizeSnapshot(string path, bool result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalizeSnapshot_Private_Static_Void_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164908, XrefRangeEnd = 1164915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveScreenshotToDisk(string path, bool result, System.IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPtr;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsCount;
		*(TextureFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveScreenshotToDisk_Private_Static_Void_String_Boolean_IntPtr_Int32_TextureFormat_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MemoryProfiler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_m_SnapshotFinished(Il2CppSystem.Action<string, bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_m_SnapshotFinished(Il2CppSystem.Action<string, bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_m_SaveScreenshotToDisk(Il2CppSystem.Action<string, bool, DebugScreenCapture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_m_SaveScreenshotToDisk(Il2CppSystem.Action<string, bool, DebugScreenCapture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void StartOperation(uint captureFlag, bool requestScreenshot, string path, bool isRemote)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(path);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					StartOperation_Injected(captureFlag, requestScreenshot, ref managedSpanWrapper, isRemote);
					return;
				}
			}
			StartOperation_Injected(captureFlag, requestScreenshot, ref managedSpanWrapper, isRemote);
		}
		finally
		{
		}
	}

	public static void TakeSnapshot(string path, Il2CppSystem.Action<string, bool> finishCallback, [Optional] CaptureFlags captureFlags)
	{
		TakeSnapshot(path, finishCallback, null, captureFlags);
	}

	public static void TakeSnapshot(string path, Il2CppSystem.Action<string, bool> finishCallback, Il2CppSystem.Action<string, bool, DebugScreenCapture> screenshotCallback, [Optional] CaptureFlags captureFlags)
	{
		if ((object)m_SnapshotFinished != null)
		{
			Debug.LogWarning("Canceling snapshot, there is another snapshot in progress.");
			finishCallback.Invoke(path, arg2: false);
		}
		else
		{
			add_m_SnapshotFinished(finishCallback);
			add_m_SaveScreenshotToDisk(screenshotCallback);
			StartOperation((uint)captureFlags, (object)m_SaveScreenshotToDisk != null, path, isRemote: false);
		}
	}

	public static void TakeTempSnapshot(Il2CppSystem.Action<string, bool> finishCallback, [Optional] CaptureFlags captureFlags)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void StartOperation_Injected(uint captureFlag, bool requestScreenshot, ref ManagedSpanWrapper path, bool isRemote)
	{
		StartOperation_InjectedDelegateField(captureFlag, requestScreenshot, (nint)Unsafe.AsPointer(ref path), isRemote);
	}
}
