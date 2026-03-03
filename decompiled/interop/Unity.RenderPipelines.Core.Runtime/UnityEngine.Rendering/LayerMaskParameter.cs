using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class LayerMaskParameter : VolumeParameter<LayerMask>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Boolean_0;

	static LayerMaskParameter()
	{
		Il2CppClassPointerStore<LayerMaskParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LayerMaskParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerMaskParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMaskParameter>.NativeClassPtr, 100666926);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1054574, XrefRangeEnd = 1054577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LayerMaskParameter(LayerMask value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayerMaskParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LayerMask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LayerMaskParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
