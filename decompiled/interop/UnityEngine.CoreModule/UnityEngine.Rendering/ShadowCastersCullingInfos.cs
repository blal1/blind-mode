using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class ShadowCastersCullingInfos : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_splitBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_perLightInfos;

	public unsafe NativeArray<ShadowSplitData> splitBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitBuffer);
			return new NativeArray<ShadowSplitData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ShadowSplitData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ShadowSplitData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<LightShadowCasterCullingInfo> perLightInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perLightInfos);
			return new NativeArray<LightShadowCasterCullingInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<LightShadowCasterCullingInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perLightInfos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<LightShadowCasterCullingInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static ShadowCastersCullingInfos()
	{
		Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShadowCastersCullingInfos");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr);
		NativeFieldInfoPtr_splitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr, "splitBuffer");
		NativeFieldInfoPtr_perLightInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr, "perLightInfos");
	}

	public ShadowCastersCullingInfos(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ShadowCastersCullingInfos()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr))
	{
	}
}
