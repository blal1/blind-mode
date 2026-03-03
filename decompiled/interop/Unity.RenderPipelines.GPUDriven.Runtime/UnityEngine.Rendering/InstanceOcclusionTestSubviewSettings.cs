using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct InstanceOcclusionTestSubviewSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_testCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderSubviewIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderSubviewMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplitIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplitMask;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromSpan_Public_Static_InstanceOcclusionTestSubviewSettings_ReadOnlySpan_1_SubviewOcclusionTest_0;

	[FieldOffset(0)]
	public int testCount;

	[FieldOffset(4)]
	public int occluderSubviewIndices;

	[FieldOffset(8)]
	public int occluderSubviewMask;

	[FieldOffset(12)]
	public int cullingSplitIndices;

	[FieldOffset(16)]
	public int cullingSplitMask;

	static InstanceOcclusionTestSubviewSettings()
	{
		Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceOcclusionTestSubviewSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr);
		NativeFieldInfoPtr_testCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr, "testCount");
		NativeFieldInfoPtr_occluderSubviewIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr, "occluderSubviewIndices");
		NativeFieldInfoPtr_occluderSubviewMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr, "occluderSubviewMask");
		NativeFieldInfoPtr_cullingSplitIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr, "cullingSplitIndices");
		NativeFieldInfoPtr_cullingSplitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr, "cullingSplitMask");
		NativeMethodInfoPtr_FromSpan_Public_Static_InstanceOcclusionTestSubviewSettings_ReadOnlySpan_1_SubviewOcclusionTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr, 100663911);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073812, RefRangeEnd = 1073813, XrefRangeStart = 1073811, XrefRangeEnd = 1073812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InstanceOcclusionTestSubviewSettings FromSpan(Il2CppSystem.ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)subviewOcclusionTests));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromSpan_Public_Static_InstanceOcclusionTestSubviewSettings_ReadOnlySpan_1_SubviewOcclusionTest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InstanceOcclusionTestSubviewSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceOcclusionTestSubviewSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
