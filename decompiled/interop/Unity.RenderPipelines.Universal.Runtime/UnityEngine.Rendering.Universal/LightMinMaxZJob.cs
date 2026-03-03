using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

public sealed class LightMinMaxZJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_worldToViews;

	private static readonly System.IntPtr NativeFieldInfoPtr_lights;

	private static readonly System.IntPtr NativeFieldInfoPtr_minMaxZs;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe Fixed2<float4x4> worldToViews
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldToViews);
			return new Fixed2<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldToViews), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<VisibleLight> lights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lights);
			return new NativeArray<VisibleLight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float2> minMaxZs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMaxZs);
			return new NativeArray<float2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minMaxZs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static LightMinMaxZJob()
	{
		Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "LightMinMaxZJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr);
		NativeFieldInfoPtr_worldToViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr, "worldToViews");
		NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr, "lights");
		NativeFieldInfoPtr_minMaxZs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr, "minMaxZs");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr, 100665614);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1100658, RefRangeEnd = 1100659, XrefRangeStart = 1100630, XrefRangeEnd = 1100658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LightMinMaxZJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LightMinMaxZJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightMinMaxZJob>.NativeClassPtr))
	{
	}
}
