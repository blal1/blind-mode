using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering;

public static class InstanceTypeInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_ParentTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ChildTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitParentTypes_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitChildTypes_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlattenChildInstanceTypes_Private_Static_Void_InstanceType_NativeList_1_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateTypeRelationsAreCorrectlySorted_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChildTypes_Public_Static_List_1_InstanceType_InstanceType_0;

	public unsafe static Il2CppStructArray<InstanceType> s_ParentTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ParentTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<InstanceType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ParentTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<List<InstanceType>> s_ChildTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ChildTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<InstanceType>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ChildTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InstanceTypeInfo()
	{
		Il2CppClassPointerStore<InstanceTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceTypeInfo");
		NativeFieldInfoPtr_s_ParentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTypeInfo>.NativeClassPtr, "s_ParentTypes");
		NativeFieldInfoPtr_s_ChildTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTypeInfo>.NativeClassPtr, "s_ChildTypes");
		NativeMethodInfoPtr_InitParentTypes_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceTypeInfo>.NativeClassPtr, 100663879);
		NativeMethodInfoPtr_InitChildTypes_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceTypeInfo>.NativeClassPtr, 100663880);
		NativeMethodInfoPtr_FlattenChildInstanceTypes_Private_Static_Void_InstanceType_NativeList_1_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceTypeInfo>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_ValidateTypeRelationsAreCorrectlySorted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceTypeInfo>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_GetChildTypes_Public_Static_List_1_InstanceType_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceTypeInfo>.NativeClassPtr, 100663883);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073512, XrefRangeEnd = 1073523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitParentTypes()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitParentTypes_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073523, XrefRangeEnd = 1073552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitChildTypes()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitChildTypes_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073576, RefRangeEnd = 1073578, XrefRangeStart = 1073552, XrefRangeEnd = 1073576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlattenChildInstanceTypes(InstanceType instanceType, NativeList<InstanceType> instanceTypes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&instanceType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceTypes));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlattenChildInstanceTypes_Private_Static_Void_InstanceType_NativeList_1_InstanceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073578, XrefRangeEnd = 1073593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateTypeRelationsAreCorrectlySorted()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateTypeRelationsAreCorrectlySorted_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073593, XrefRangeEnd = 1073597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<InstanceType> GetChildTypes(InstanceType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChildTypes_Public_Static_List_1_InstanceType_InstanceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InstanceType>>(intPtr2) : null;
	}

	public InstanceTypeInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
