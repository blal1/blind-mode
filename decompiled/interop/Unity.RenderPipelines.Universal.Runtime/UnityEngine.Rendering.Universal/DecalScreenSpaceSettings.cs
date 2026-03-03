using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[System.Serializable]
public class DecalScreenSpaceSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_normalBlend;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DecalNormalBlend normalBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalBlend);
			return *(DecalNormalBlend*)num;
		}
		set
		{
			*(DecalNormalBlend*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalBlend)) = value;
		}
	}

	static DecalScreenSpaceSettings()
	{
		Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalScreenSpaceSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr);
		NativeFieldInfoPtr_normalBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr, "normalBlend");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr, 100665183);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalScreenSpaceSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalScreenSpaceSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DecalScreenSpaceSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
