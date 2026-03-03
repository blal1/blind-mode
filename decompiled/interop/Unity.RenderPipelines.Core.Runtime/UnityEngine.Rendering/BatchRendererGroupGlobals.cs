using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct BatchRendererGroupGlobals
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kGlobalsPropertyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_kGlobalsPropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProbesOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpecCube0_HDR;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpecCube1_HDR;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHCoefficients;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_BatchRendererGroupGlobals_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchRendererGroupGlobals_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0;

	[FieldOffset(0)]
	public Vector4 ProbesOcclusion;

	[FieldOffset(16)]
	public Vector4 SpecCube0_HDR;

	[FieldOffset(32)]
	public Vector4 SpecCube1_HDR;

	[FieldOffset(48)]
	public SHCoefficients SHCoefficients;

	public unsafe static string kGlobalsPropertyName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kGlobalsPropertyName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kGlobalsPropertyName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static int kGlobalsPropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kGlobalsPropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kGlobalsPropertyId, (void*)(&value));
		}
	}

	public unsafe static BatchRendererGroupGlobals Default
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049996, XrefRangeEnd = 1050005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Public_Static_get_BatchRendererGroupGlobals_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BatchRendererGroupGlobals*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BatchRendererGroupGlobals()
	{
		Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BatchRendererGroupGlobals");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr);
		NativeFieldInfoPtr_kGlobalsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "kGlobalsPropertyName");
		NativeFieldInfoPtr_kGlobalsPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "kGlobalsPropertyId");
		NativeFieldInfoPtr_ProbesOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "ProbesOcclusion");
		NativeFieldInfoPtr_SpecCube0_HDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "SpecCube0_HDR");
		NativeFieldInfoPtr_SpecCube1_HDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "SpecCube1_HDR");
		NativeFieldInfoPtr_SHCoefficients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, "SHCoefficients");
		NativeMethodInfoPtr_get_Default_Public_Static_get_BatchRendererGroupGlobals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100666359);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchRendererGroupGlobals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100666360);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100666361);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100666362);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100666363);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, 100666364);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1050006, RefRangeEnd = 1050009, XrefRangeStart = 1050005, XrefRangeEnd = 1050006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(BatchRendererGroupGlobals other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchRendererGroupGlobals_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050009, XrefRangeEnd = 1050015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050015, XrefRangeEnd = 1050021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050021, XrefRangeEnd = 1050025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(BatchRendererGroupGlobals**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050025, XrefRangeEnd = 1050029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(BatchRendererGroupGlobals left, BatchRendererGroupGlobals right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(BatchRendererGroupGlobals**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BatchRendererGroupGlobals_BatchRendererGroupGlobals_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchRendererGroupGlobals>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
