using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class NoInterpVector4Parameter : VolumeParameter<Vector4>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0;

	static NoInterpVector4Parameter()
	{
		Il2CppClassPointerStore<NoInterpVector4Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpVector4Parameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpVector4Parameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpVector4Parameter>.NativeClassPtr, 100666990);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1054747, XrefRangeEnd = 1054750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoInterpVector4Parameter(Vector4 value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpVector4Parameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NoInterpVector4Parameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
