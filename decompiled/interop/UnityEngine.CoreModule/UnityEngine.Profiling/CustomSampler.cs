using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling;

public sealed class CustomSampler : Sampler
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CustomSampler_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CustomSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100666972);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(CustomSampler customSampler)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customSampler);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CustomSampler_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InvalidCustomSampler;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0;

	public unsafe static CustomSampler s_InvalidCustomSampler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InvalidCustomSampler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InvalidCustomSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CustomSampler()
	{
		Il2CppClassPointerStore<CustomSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "CustomSampler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr);
		NativeFieldInfoPtr_s_InvalidCustomSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, "s_InvalidCustomSampler");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, 100666968);
		NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, 100666970);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222014, XrefRangeEnd = 1222022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomSampler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1222030, RefRangeEnd = 1222034, XrefRangeStart = 1222022, XrefRangeEnd = 1222030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CustomSampler Create(string name, bool collectGpuData = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &collectGpuData;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr2) : null;
	}

	public CustomSampler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Begin()
	{
		ProfilerUnsafeUtility.BeginSample(base.m_Ptr);
	}

	public void Begin(Object targetObject)
	{
		ProfilerUnsafeUtility.Internal_BeginWithObject(base.m_Ptr, targetObject);
	}

	public void End()
	{
		ProfilerUnsafeUtility.EndSample(base.m_Ptr);
	}
}
