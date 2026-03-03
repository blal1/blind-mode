using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMono;

[StructLayout(LayoutKind.Explicit)]
public struct RuntimeGenericParamInfoHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0;

	[FieldOffset(0)]
	public System.IntPtr value;

	public unsafe Il2CppReferenceArray<Il2CppSystem.Type> Constraints
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696515, RefRangeEnd = 696516, XrefRangeStart = 696514, XrefRangeEnd = 696515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr2) : null;
		}
	}

	public unsafe GenericParameterAttributes Attributes
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696516, RefRangeEnd = 696518, XrefRangeStart = 696516, XrefRangeEnd = 696516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GenericParameterAttributes*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RuntimeGenericParamInfoHandle()
	{
		Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeGenericParamInfoHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr);
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, "value");
		NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_get_Attributes_Internal_get_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, 100663383);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 696527, RefRangeEnd = 696528, XrefRangeStart = 696518, XrefRangeEnd = 696527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Il2CppSystem.Type> GetConstraints()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConstraints_Private_Il2CppReferenceArray_1_Type_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe int GetConstraintsCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConstraintsCount_Private_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeGenericParamInfoHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
