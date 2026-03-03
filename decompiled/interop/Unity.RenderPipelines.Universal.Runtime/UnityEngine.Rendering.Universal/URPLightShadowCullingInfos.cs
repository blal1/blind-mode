using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public sealed class URPLightShadowCullingInfos : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_slices;

	private static readonly System.IntPtr NativeFieldInfoPtr_slicesValidMask;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSliceValid_Public_Boolean_Int32_0;

	public unsafe NativeArray<ShadowSliceData> slices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slices);
			return new NativeArray<ShadowSliceData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ShadowSliceData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ShadowSliceData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe uint slicesValidMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slicesValidMask);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slicesValidMask)) = value;
		}
	}

	static URPLightShadowCullingInfos()
	{
		Il2CppClassPointerStore<URPLightShadowCullingInfos>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "URPLightShadowCullingInfos");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<URPLightShadowCullingInfos>.NativeClassPtr);
		NativeFieldInfoPtr_slices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URPLightShadowCullingInfos>.NativeClassPtr, "slices");
		NativeFieldInfoPtr_slicesValidMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URPLightShadowCullingInfos>.NativeClassPtr, "slicesValidMask");
		NativeMethodInfoPtr_IsSliceValid_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPLightShadowCullingInfos>.NativeClassPtr, 100665515);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1099569, RefRangeEnd = 1099572, XrefRangeStart = 1099569, XrefRangeEnd = 1099569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSliceValid(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSliceValid_Public_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public URPLightShadowCullingInfos(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public URPLightShadowCullingInfos()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<URPLightShadowCullingInfos>.NativeClassPtr))
	{
	}
}
