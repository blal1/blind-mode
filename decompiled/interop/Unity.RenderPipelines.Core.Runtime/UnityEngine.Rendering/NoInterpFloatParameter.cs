using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class NoInterpFloatParameter : VolumeParameter<float>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0;

	static NoInterpFloatParameter()
	{
		Il2CppClassPointerStore<NoInterpFloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpFloatParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpFloatParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpFloatParameter>.NativeClassPtr, 100666951);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1054612, XrefRangeEnd = 1054615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoInterpFloatParameter(float value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpFloatParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NoInterpFloatParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
