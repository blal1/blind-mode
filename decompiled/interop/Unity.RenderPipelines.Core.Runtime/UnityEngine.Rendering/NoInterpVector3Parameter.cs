using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class NoInterpVector3Parameter : VolumeParameter<Vector3>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0;

	static NoInterpVector3Parameter()
	{
		Il2CppClassPointerStore<NoInterpVector3Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpVector3Parameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpVector3Parameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpVector3Parameter>.NativeClassPtr, 100666987);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1054735, XrefRangeEnd = 1054738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoInterpVector3Parameter(Vector3 value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpVector3Parameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NoInterpVector3Parameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
