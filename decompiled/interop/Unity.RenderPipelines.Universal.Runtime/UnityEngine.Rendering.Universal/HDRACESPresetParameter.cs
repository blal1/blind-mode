using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal;

[Serializable]
public sealed class HDRACESPresetParameter : VolumeParameter<HDRACESPreset>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HDRACESPreset_Boolean_0;

	static HDRACESPresetParameter()
	{
		Il2CppClassPointerStore<HDRACESPresetParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "HDRACESPresetParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRACESPresetParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_HDRACESPreset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRACESPresetParameter>.NativeClassPtr, 100664851);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089330, XrefRangeEnd = 1089333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HDRACESPresetParameter(HDRACESPreset value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRACESPresetParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HDRACESPreset_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HDRACESPresetParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
