using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class ConstantBufferSingleton<CBType> : ConstantBuffer<CBType> where CBType : new()
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Internal_Static_get_ConstantBufferSingleton_1_CBType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instance_Internal_Static_set_Void_ConstantBufferSingleton_1_CBType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ConstantBufferSingleton<CBType> s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstantBufferSingleton<CBType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ConstantBufferSingleton<CBType> instance
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1028140, RefRangeEnd = 1028141, XrefRangeStart = 1028106, XrefRangeEnd = 1028140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Internal_Static_get_ConstantBufferSingleton_1_CBType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstantBufferSingleton<CBType>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028141, XrefRangeEnd = 1028146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_instance_Internal_Static_set_Void_ConstantBufferSingleton_1_CBType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ConstantBufferSingleton()
	{
		Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ConstantBufferSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CBType>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, "s_Instance");
		NativeMethodInfoPtr_get_instance_Internal_Static_get_ConstantBufferSingleton_1_CBType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, 100664305);
		NativeMethodInfoPtr_set_instance_Internal_Static_set_Void_ConstantBufferSingleton_1_CBType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, 100664307);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr, 100664308);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028146, XrefRangeEnd = 1028185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028185, XrefRangeEnd = 1028297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConstantBufferSingleton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantBufferSingleton<CBType>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ConstantBufferSingleton(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
