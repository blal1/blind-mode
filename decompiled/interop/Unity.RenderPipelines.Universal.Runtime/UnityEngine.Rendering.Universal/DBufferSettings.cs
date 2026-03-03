using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[System.Serializable]
public class DBufferSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_surfaceData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DecalSurfaceData surfaceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceData);
			return *(DecalSurfaceData*)num;
		}
		set
		{
			*(DecalSurfaceData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceData)) = value;
		}
	}

	static DBufferSettings()
	{
		Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DBufferSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr);
		NativeFieldInfoPtr_surfaceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr, "surfaceData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr, 100665182);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 148250, RefRangeEnd = 148267, XrefRangeStart = 148250, XrefRangeEnd = 148267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DBufferSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBufferSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DBufferSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
