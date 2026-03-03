using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[System.Serializable]
public class DecalSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_technique;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDrawDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_decalLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_dBufferSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenSpaceSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DecalTechniqueOption technique
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_technique);
			return *(DecalTechniqueOption*)num;
		}
		set
		{
			*(DecalTechniqueOption*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_technique)) = value;
		}
	}

	public unsafe float maxDrawDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDrawDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDrawDistance)) = value;
		}
	}

	public unsafe bool decalLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalLayers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalLayers)) = value;
		}
	}

	public unsafe DBufferSettings dBufferSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dBufferSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DBufferSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dBufferSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DecalScreenSpaceSettings screenSpaceSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenSpaceSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecalScreenSpaceSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenSpaceSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DecalSettings()
	{
		Il2CppClassPointerStore<DecalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr);
		NativeFieldInfoPtr_technique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "technique");
		NativeFieldInfoPtr_maxDrawDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "maxDrawDistance");
		NativeFieldInfoPtr_decalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "decalLayers");
		NativeFieldInfoPtr_dBufferSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "dBufferSettings");
		NativeFieldInfoPtr_screenSpaceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "screenSpaceSettings");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, 100665184);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096477, XrefRangeEnd = 1096478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DecalSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
