using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class CompactVisibilityMasksJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rendererVisibilityMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_compactedVisibilityMasks;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

	public unsafe NativeArray<byte> rendererVisibilityMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererVisibilityMasks);
			return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererVisibilityMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParallelBitArray compactedVisibilityMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactedVisibilityMasks);
			return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactedVisibilityMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static CompactVisibilityMasksJob()
	{
		Il2CppClassPointerStore<CompactVisibilityMasksJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "CompactVisibilityMasksJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompactVisibilityMasksJob>.NativeClassPtr);
		NativeFieldInfoPtr_rendererVisibilityMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompactVisibilityMasksJob>.NativeClassPtr, "rendererVisibilityMasks");
		NativeFieldInfoPtr_compactedVisibilityMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompactVisibilityMasksJob>.NativeClassPtr, "compactedVisibilityMasks");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompactVisibilityMasksJob>.NativeClassPtr, 100663557);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069479, RefRangeEnd = 1069480, XrefRangeStart = 1069478, XrefRangeEnd = 1069479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int startIndex, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&startIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CompactVisibilityMasksJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CompactVisibilityMasksJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompactVisibilityMasksJob>.NativeClassPtr))
	{
	}
}
