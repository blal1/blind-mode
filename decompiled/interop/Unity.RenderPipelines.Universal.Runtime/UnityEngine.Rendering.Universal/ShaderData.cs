using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.Universal;

public class ShaderData : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0, Il2CppClassPointerStore<ShaderData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightDataBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightIndicesBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightShadowParamsStructuredBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightShadowSliceMatricesStructuredBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Internal_Static_get_ShaderData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightDataBuffer_Internal_ComputeBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightIndicesBuffer_Internal_ComputeBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdditionalLightShadowParamsStructuredBuffer_Internal_ComputeBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAdditionalLightShadowSliceMatricesStructuredBuffer_Internal_ComputeBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeBuffer_Private_Void_byref_ComputeBuffer_0;

	public unsafe static ShaderData m_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShaderData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeBuffer m_LightDataBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightDataBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightDataBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeBuffer m_LightIndicesBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightIndicesBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightIndicesBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowParamsStructuredBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowParamsStructuredBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowSliceMatricesStructuredBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowSliceMatricesStructuredBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ShaderData instance
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1099426, RefRangeEnd = 1099430, XrefRangeStart = 1099418, XrefRangeEnd = 1099426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Internal_Static_get_ShaderData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShaderData>(intPtr2) : null;
		}
	}

	static ShaderData()
	{
		Il2CppClassPointerStore<ShaderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShaderData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderData>.NativeClassPtr);
		NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_Instance");
		NativeFieldInfoPtr_m_LightDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_LightDataBuffer");
		NativeFieldInfoPtr_m_LightIndicesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_LightIndicesBuffer");
		NativeFieldInfoPtr_m_AdditionalLightShadowParamsStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_AdditionalLightShadowParamsStructuredBuffer");
		NativeFieldInfoPtr_m_AdditionalLightShadowSliceMatricesStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, "m_AdditionalLightShadowSliceMatricesStructuredBuffer");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665499);
		NativeMethodInfoPtr_get_instance_Internal_Static_get_ShaderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665500);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665501);
		NativeMethodInfoPtr_GetLightDataBuffer_Internal_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665502);
		NativeMethodInfoPtr_GetLightIndicesBuffer_Internal_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665503);
		NativeMethodInfoPtr_GetAdditionalLightShadowParamsStructuredBuffer_Internal_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665504);
		NativeMethodInfoPtr_GetAdditionalLightShadowSliceMatricesStructuredBuffer_Internal_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665505);
		NativeMethodInfoPtr_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665506);
		NativeMethodInfoPtr_DisposeBuffer_Private_Void_byref_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderData>.NativeClassPtr, 100665507);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShaderData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099438, RefRangeEnd = 1099439, XrefRangeStart = 1099430, XrefRangeEnd = 1099438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099439, XrefRangeEnd = 1099442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeBuffer GetLightDataBuffer(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightDataBuffer_Internal_ComputeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099445, RefRangeEnd = 1099446, XrefRangeStart = 1099442, XrefRangeEnd = 1099445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeBuffer GetLightIndicesBuffer(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightIndicesBuffer_Internal_ComputeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099449, RefRangeEnd = 1099450, XrefRangeStart = 1099446, XrefRangeEnd = 1099449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdditionalLightShadowParamsStructuredBuffer_Internal_ComputeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099453, RefRangeEnd = 1099454, XrefRangeStart = 1099450, XrefRangeEnd = 1099453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAdditionalLightShadowSliceMatricesStructuredBuffer_Internal_ComputeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1099466, RefRangeEnd = 1099470, XrefRangeStart = 1099454, XrefRangeEnd = 1099466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeBuffer GetOrUpdateBuffer<T>(ref ComputeBuffer buffer, int size) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetOrUpdateBuffer_Private_ComputeBuffer_byref_ComputeBuffer_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		buffer = ((intPtr4 == (System.IntPtr)0) ? null : new ComputeBuffer(intPtr4));
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr3) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1099470, XrefRangeEnd = 1099472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeBuffer(ref ComputeBuffer buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeBuffer_Private_Void_byref_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		buffer = ((intPtr4 == (System.IntPtr)0) ? null : new ComputeBuffer(intPtr4));
	}

	public ShaderData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
