using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Rendering;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct LightProbesQuery
{
	[StructLayout(LayoutKind.Explicit)]
	public struct LightProbesQueryDispose
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_LightProbeContextWrapper;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		[FieldOffset(0)]
		public System.IntPtr m_LightProbeContextWrapper;

		static LightProbesQueryDispose()
		{
			Il2CppClassPointerStore<LightProbesQueryDispose>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, "LightProbesQueryDispose");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbesQueryDispose>.NativeClassPtr);
			NativeFieldInfoPtr_m_LightProbeContextWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbesQueryDispose>.NativeClassPtr, "m_LightProbeContextWrapper");
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQueryDispose>.NativeClassPtr, 100664313);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172190, XrefRangeEnd = 1172194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightProbesQueryDispose>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct LightProbesQueryDisposeJob
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Data;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		[FieldOffset(0)]
		public LightProbesQueryDispose Data;

		static LightProbesQueryDisposeJob()
		{
			Il2CppClassPointerStore<LightProbesQueryDisposeJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, "LightProbesQueryDisposeJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbesQueryDisposeJob>.NativeClassPtr);
			NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbesQueryDisposeJob>.NativeClassPtr, "Data");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQueryDisposeJob>.NativeClassPtr, 100664314);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightProbesQueryDisposeJob>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private delegate void CalculateInterpolatedLightAndOcclusionProbe_InjectedDelegate(System.IntPtr lightProbeContextWrapper, [In] System.IntPtr position, System.IntPtr tetrahedronIndex, [Out] System.IntPtr lightProbe, [Out] System.IntPtr occlusionProbe);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightProbeContextWrapper;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocatorLabel;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateInterpolatedLightAndOcclusionProbes_Public_Void_NativeArray_1_Vector3_NativeArray_1_Int32_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateInterpolatedLightAndOcclusionProbes_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0;

	[FieldOffset(0)]
	public System.IntPtr m_LightProbeContextWrapper;

	[FieldOffset(8)]
	public Allocator m_AllocatorLabel;

	private static readonly CalculateInterpolatedLightAndOcclusionProbe_InjectedDelegate CalculateInterpolatedLightAndOcclusionProbe_InjectedDelegateField;

	public bool IsCreated => m_LightProbeContextWrapper != Il2CppSystem.IntPtr.Zero;

	static LightProbesQuery()
	{
		Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbesQuery");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr);
		NativeFieldInfoPtr_m_LightProbeContextWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, "m_LightProbeContextWrapper");
		NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, "m_AllocatorLabel");
		NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, 100664307);
		NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, 100664308);
		NativeMethodInfoPtr_Create_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, 100664309);
		NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, 100664310);
		NativeMethodInfoPtr_CalculateInterpolatedLightAndOcclusionProbes_Public_Void_NativeArray_1_Vector3_NativeArray_1_Int32_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, 100664311);
		NativeMethodInfoPtr_CalculateInterpolatedLightAndOcclusionProbes_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, 100664312);
		CalculateInterpolatedLightAndOcclusionProbe_InjectedDelegateField = IL2CPP.ResolveICall<CalculateInterpolatedLightAndOcclusionProbe_InjectedDelegate>("UnityEngine.LightProbesQuery::CalculateInterpolatedLightAndOcclusionProbe_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172198, RefRangeEnd = 1172199, XrefRangeStart = 1172194, XrefRangeEnd = 1172198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LightProbesQuery(Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&allocator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172199, XrefRangeEnd = 1172203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172206, RefRangeEnd = 1172207, XrefRangeStart = 1172203, XrefRangeEnd = 1172206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle Dispose(JobHandle inputDeps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputDeps);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_JobHandle_JobHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172207, XrefRangeEnd = 1172209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172209, XrefRangeEnd = 1172211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(System.IntPtr lightProbeContextWrapper)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lightProbeContextWrapper);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172250, RefRangeEnd = 1172251, XrefRangeStart = 1172211, XrefRangeEnd = 1172250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateInterpolatedLightAndOcclusionProbes(NativeArray<Vector3> positions, NativeArray<int> tetrahedronIndices, NativeArray<SphericalHarmonicsL2> lightProbes, NativeArray<Vector4> occlusionProbes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)positions));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)tetrahedronIndices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lightProbes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occlusionProbes));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateInterpolatedLightAndOcclusionProbes_Public_Void_NativeArray_1_Vector3_NativeArray_1_Int32_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172251, XrefRangeEnd = 1172253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateInterpolatedLightAndOcclusionProbes(System.IntPtr lightProbeContextWrapper, System.IntPtr positions, System.IntPtr tetrahedronIndices, System.IntPtr lightProbes, System.IntPtr occlusionProbes, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&lightProbeContextWrapper);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positions;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &tetrahedronIndices;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightProbes;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &occlusionProbes;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateInterpolatedLightAndOcclusionProbes_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightProbesQuery>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void CalculateInterpolatedLightAndOcclusionProbe(Vector3 position, ref int tetrahedronIndex, out SphericalHarmonicsL2 lightProbe, out Vector4 occlusionProbe)
	{
		CalculateInterpolatedLightAndOcclusionProbe(m_LightProbeContextWrapper, position, ref tetrahedronIndex, out lightProbe, out occlusionProbe);
	}

	public static void CalculateInterpolatedLightAndOcclusionProbe(System.IntPtr lightProbeContextWrapper, Vector3 position, ref int tetrahedronIndex, out SphericalHarmonicsL2 lightProbe, out Vector4 occlusionProbe)
	{
		CalculateInterpolatedLightAndOcclusionProbe_Injected(lightProbeContextWrapper, ref position, ref tetrahedronIndex, out lightProbe, out occlusionProbe);
	}

	public unsafe static void CalculateInterpolatedLightAndOcclusionProbe_Injected(System.IntPtr lightProbeContextWrapper, [In] ref Vector3 position, ref int tetrahedronIndex, out SphericalHarmonicsL2 lightProbe, out Vector4 occlusionProbe)
	{
		CalculateInterpolatedLightAndOcclusionProbe_InjectedDelegateField(lightProbeContextWrapper, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref tetrahedronIndex), (nint)Unsafe.AsPointer(ref lightProbe), (nint)Unsafe.AsPointer(ref occlusionProbe));
	}
}
