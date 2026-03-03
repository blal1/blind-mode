using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal;

public class UniversalPostProcessingData : ContextItem
{
	private static readonly IntPtr NativeFieldInfoPtr_isEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_gradingMode;

	private static readonly IntPtr NativeFieldInfoPtr_lutSize;

	private static readonly IntPtr NativeFieldInfoPtr_useFastSRGBLinearConversion;

	private static readonly IntPtr NativeFieldInfoPtr_supportScreenSpaceLensFlare;

	private static readonly IntPtr NativeFieldInfoPtr_supportDataDrivenLensFlare;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool isEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled)) = value;
		}
	}

	public unsafe ColorGradingMode gradingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradingMode);
			return *(ColorGradingMode*)num;
		}
		set
		{
			*(ColorGradingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradingMode)) = value;
		}
	}

	public unsafe int lutSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutSize)) = value;
		}
	}

	public unsafe bool useFastSRGBLinearConversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFastSRGBLinearConversion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFastSRGBLinearConversion)) = value;
		}
	}

	public unsafe bool supportScreenSpaceLensFlare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportScreenSpaceLensFlare);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportScreenSpaceLensFlare)) = value;
		}
	}

	public unsafe bool supportDataDrivenLensFlare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDataDrivenLensFlare);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDataDrivenLensFlare)) = value;
		}
	}

	static UniversalPostProcessingData()
	{
		Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalPostProcessingData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr);
		NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr, "isEnabled");
		NativeFieldInfoPtr_gradingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr, "gradingMode");
		NativeFieldInfoPtr_lutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr, "lutSize");
		NativeFieldInfoPtr_useFastSRGBLinearConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr, "useFastSRGBLinearConversion");
		NativeFieldInfoPtr_supportScreenSpaceLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr, "supportScreenSpaceLensFlare");
		NativeFieldInfoPtr_supportDataDrivenLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr, "supportDataDrivenLensFlare");
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr, 100664555);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr, 100664556);
	}

	[CallerCount(0)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalPostProcessingData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalPostProcessingData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalPostProcessingData(IntPtr pointer)
		: base(pointer)
	{
	}
}
