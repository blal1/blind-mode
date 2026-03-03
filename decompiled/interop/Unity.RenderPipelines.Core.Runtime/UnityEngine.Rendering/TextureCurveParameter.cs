using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class TextureCurveParameter : VolumeParameter<TextureCurve>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureCurve_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

	static TextureCurveParameter()
	{
		Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TextureCurveParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_TextureCurve_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr, 100666817);
		NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr, 100666818);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1053660, RefRangeEnd = 1053668, XrefRangeStart = 1053657, XrefRangeEnd = 1053660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureCurveParameter(TextureCurve value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextureCurve_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053668, XrefRangeEnd = 1053670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextureCurveParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
