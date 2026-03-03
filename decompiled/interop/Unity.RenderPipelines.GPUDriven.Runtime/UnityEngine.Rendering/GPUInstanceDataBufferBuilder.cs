using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class GPUInstanceDataBufferBuilder : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_AddComponent_Public_Void_Int32_Boolean_Boolean_InstanceType_InstanceComponentGroup_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddComponent_Public_Void_Int32_Boolean_Boolean_InstanceType_InstanceComponentGroup_0, Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Components;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMetadataValue_Private_MetadataValue_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Void_Int32_Boolean_Boolean_InstanceType_InstanceComponentGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComponent_Public_Void_Int32_Boolean_Int32_Boolean_InstanceType_InstanceComponentGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_GPUInstanceDataBuffer_byref_InstanceNumInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe NativeList<GPUInstanceComponentDesc> m_Components
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Components);
			return new NativeList<GPUInstanceComponentDesc>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<GPUInstanceComponentDesc>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Components), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<GPUInstanceComponentDesc>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static GPUInstanceDataBufferBuilder()
	{
		Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUInstanceDataBufferBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr);
		NativeFieldInfoPtr_m_Components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr, "m_Components");
		NativeMethodInfoPtr_CreateMetadataValue_Private_MetadataValue_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr, 100663688);
		NativeMethodInfoPtr_AddComponent_Public_Void_Int32_Boolean_Boolean_InstanceType_InstanceComponentGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr, 100663689);
		NativeMethodInfoPtr_AddComponent_Public_Void_Int32_Boolean_Int32_Boolean_InstanceType_InstanceComponentGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr, 100663690);
		NativeMethodInfoPtr_Build_Public_GPUInstanceDataBuffer_byref_InstanceNumInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr, 100663691);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr, 100663692);
	}

	[CallerCount(0)]
	public unsafe MetadataValue CreateMetadataValue(int nameID, int gpuAddress, bool isOverridden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&nameID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gpuAddress;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOverridden;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMetadataValue_Private_MetadataValue_Int32_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MetadataValue*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1071414, RefRangeEnd = 1071418, XrefRangeStart = 1071412, XrefRangeEnd = 1071414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddComponent<T>(int propertyID, bool isOverriden, bool isPerInstance, InstanceType instanceType, InstanceComponentGroup componentGroup = InstanceComponentGroup.Default) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&propertyID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOverriden;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPerInstance;
		*(InstanceType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceType;
		*(InstanceComponentGroup**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &componentGroup;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddComponent_Public_Void_Int32_Boolean_Boolean_InstanceType_InstanceComponentGroup_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071429, RefRangeEnd = 1071431, XrefRangeStart = 1071418, XrefRangeEnd = 1071429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddComponent(int propertyID, bool isOverriden, int byteSize, bool isPerInstance, InstanceType instanceType, InstanceComponentGroup componentGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&propertyID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOverriden;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteSize;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPerInstance;
		*(InstanceType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceType;
		*(InstanceComponentGroup**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &componentGroup;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddComponent_Public_Void_Int32_Boolean_Int32_Boolean_InstanceType_InstanceComponentGroup_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071548, RefRangeEnd = 1071550, XrefRangeStart = 1071431, XrefRangeEnd = 1071548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUInstanceDataBuffer Build([In] ref InstanceNumInfo instanceNumInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref instanceNumInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Build_Public_GPUInstanceDataBuffer_byref_InstanceNumInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUInstanceDataBuffer>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071554, RefRangeEnd = 1071556, XrefRangeStart = 1071550, XrefRangeEnd = 1071554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUInstanceDataBufferBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GPUInstanceDataBufferBuilder()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUInstanceDataBufferBuilder>.NativeClassPtr))
	{
	}
}
