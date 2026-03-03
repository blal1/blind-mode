using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

public sealed class VolumeRequiresRendererFeatures : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TargetFeatureTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;

	public unsafe HashSet<Il2CppSystem.Type> TargetFeatureTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetFeatureTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Il2CppSystem.Type>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TargetFeatureTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static VolumeRequiresRendererFeatures()
	{
		Il2CppClassPointerStore<VolumeRequiresRendererFeatures>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "VolumeRequiresRendererFeatures");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeRequiresRendererFeatures>.NativeClassPtr);
		NativeFieldInfoPtr_TargetFeatureTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeRequiresRendererFeatures>.NativeClassPtr, "TargetFeatureTypes");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeRequiresRendererFeatures>.NativeClassPtr, 100666128);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108213, XrefRangeEnd = 1108229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VolumeRequiresRendererFeatures([Optional] Il2CppReferenceArray<Il2CppSystem.Type> featureTypes)
	{
		if (featureTypes == null)
		{
			featureTypes = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeRequiresRendererFeatures>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)featureTypes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VolumeRequiresRendererFeatures(params Il2CppSystem.Type[] featureTypes)
		: this(new Il2CppReferenceArray<Il2CppSystem.Type>(featureTypes))
	{
	}

	public VolumeRequiresRendererFeatures(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
