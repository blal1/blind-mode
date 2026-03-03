using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations;

public static class DiscreteEvaluationAttributeUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertFloatToDiscreteInt_Public_Static_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertDiscreteIntToFloat_Public_Static_Single_Int32_0;

	static DiscreteEvaluationAttributeUtilities()
	{
		Il2CppClassPointerStore<DiscreteEvaluationAttributeUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "DiscreteEvaluationAttributeUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscreteEvaluationAttributeUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_ConvertFloatToDiscreteInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteEvaluationAttributeUtilities>.NativeClassPtr, 100664239);
		NativeMethodInfoPtr_ConvertDiscreteIntToFloat_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteEvaluationAttributeUtilities>.NativeClassPtr, 100664240);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1157719, RefRangeEnd = 1157720, XrefRangeStart = 1157719, XrefRangeEnd = 1157719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ConvertFloatToDiscreteInt(float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertFloatToDiscreteInt_Public_Static_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1157720, RefRangeEnd = 1157721, XrefRangeStart = 1157720, XrefRangeEnd = 1157720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertDiscreteIntToFloat(int f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertDiscreteIntToFloat_Public_Static_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DiscreteEvaluationAttributeUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
