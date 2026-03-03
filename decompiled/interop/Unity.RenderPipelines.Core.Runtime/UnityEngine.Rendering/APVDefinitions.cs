using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class APVDefinitions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_probeIndexChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeValidityThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeMaxRegionCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerMaskColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugEmptyColor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int probeIndexChunkSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_probeIndexChunkSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_probeIndexChunkSize, (void*)(&value));
		}
	}

	public unsafe static float probeValidityThreshold
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_probeValidityThreshold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_probeValidityThreshold, (void*)(&value));
		}
	}

	public unsafe static int probeMaxRegionCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_probeMaxRegionCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_probeMaxRegionCount, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<Color32> layerMaskColors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_layerMaskColors, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_layerMaskColors, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Color debugEmptyColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_debugEmptyColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_debugEmptyColor, (void*)(&value));
		}
	}

	static APVDefinitions()
	{
		Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "APVDefinitions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr);
		NativeFieldInfoPtr_probeIndexChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr, "probeIndexChunkSize");
		NativeFieldInfoPtr_probeValidityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr, "probeValidityThreshold");
		NativeFieldInfoPtr_probeMaxRegionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr, "probeMaxRegionCount");
		NativeFieldInfoPtr_layerMaskColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr, "layerMaskColors");
		NativeFieldInfoPtr_debugEmptyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr, "debugEmptyColor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr, 100665893);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe APVDefinitions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<APVDefinitions>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public APVDefinitions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
