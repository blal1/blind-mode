using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class Vector4Parameter : VolumeParameter<Vector4>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0;

	static Vector4Parameter()
	{
		Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "Vector4Parameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr, 100666988);
		NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr, 100666989);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1054741, RefRangeEnd = 1054747, XrefRangeStart = 1054738, XrefRangeEnd = 1054741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4Parameter(Vector4 value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4Parameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector4_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override void Interp(Vector4 from, Vector4 to, float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&from);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &t;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Interp_Public_Virtual_Void_Vector4_Vector4_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Vector4Parameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
