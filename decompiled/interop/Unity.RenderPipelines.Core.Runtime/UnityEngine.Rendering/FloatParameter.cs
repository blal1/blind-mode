using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

[Serializable]
public class FloatParameter : VolumeParameter<float>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Single_Single_Single_0;

	static FloatParameter()
	{
		Il2CppClassPointerStore<FloatParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FloatParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr, 100666949);
		NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr, 100666950);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1054610, RefRangeEnd = 1054612, XrefRangeStart = 1054607, XrefRangeEnd = 1054610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FloatParameter(float value, bool overrideState = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatParameter>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &overrideState;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override void Interp(float from, float to, float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&from);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &t;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Interp_Public_Virtual_Final_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FloatParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
