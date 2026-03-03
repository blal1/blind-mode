using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class ProbeVolumeDebugColorPreferences : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_GetDetailSubdivisionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_GetMediumSubdivisionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_GetLowSubdivisionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_GetVeryLowSubdivisionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_GetSparseSubdivisionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_GetSparsestSubdivisionColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DetailSubdivision;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MediumSubdivision;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_LowSubdivision;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_VeryLowSubdivision;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SparseSubdivision;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SparsestSubdivision;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppSystem.Func<Color> GetDetailSubdivisionColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GetDetailSubdivisionColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GetDetailSubdivisionColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<Color> GetMediumSubdivisionColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GetMediumSubdivisionColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GetMediumSubdivisionColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<Color> GetLowSubdivisionColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GetLowSubdivisionColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GetLowSubdivisionColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<Color> GetVeryLowSubdivisionColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GetVeryLowSubdivisionColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GetVeryLowSubdivisionColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<Color> GetSparseSubdivisionColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GetSparseSubdivisionColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GetSparseSubdivisionColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<Color> GetSparsestSubdivisionColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GetSparsestSubdivisionColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Color>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GetSparsestSubdivisionColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Color s_DetailSubdivision
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DetailSubdivision, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DetailSubdivision, (void*)(&value));
		}
	}

	public unsafe static Color s_MediumSubdivision
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MediumSubdivision, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MediumSubdivision, (void*)(&value));
		}
	}

	public unsafe static Color s_LowSubdivision
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_LowSubdivision, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_LowSubdivision, (void*)(&value));
		}
	}

	public unsafe static Color s_VeryLowSubdivision
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_VeryLowSubdivision, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_VeryLowSubdivision, (void*)(&value));
		}
	}

	public unsafe static Color s_SparseSubdivision
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SparseSubdivision, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SparseSubdivision, (void*)(&value));
		}
	}

	public unsafe static Color s_SparsestSubdivision
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SparsestSubdivision, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SparsestSubdivision, (void*)(&value));
		}
	}

	static ProbeVolumeDebugColorPreferences()
	{
		Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeDebugColorPreferences");
		NativeFieldInfoPtr_GetDetailSubdivisionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "GetDetailSubdivisionColor");
		NativeFieldInfoPtr_GetMediumSubdivisionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "GetMediumSubdivisionColor");
		NativeFieldInfoPtr_GetLowSubdivisionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "GetLowSubdivisionColor");
		NativeFieldInfoPtr_GetVeryLowSubdivisionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "GetVeryLowSubdivisionColor");
		NativeFieldInfoPtr_GetSparseSubdivisionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "GetSparseSubdivisionColor");
		NativeFieldInfoPtr_GetSparsestSubdivisionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "GetSparsestSubdivisionColor");
		NativeFieldInfoPtr_s_DetailSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "s_DetailSubdivision");
		NativeFieldInfoPtr_s_MediumSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "s_MediumSubdivision");
		NativeFieldInfoPtr_s_LowSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "s_LowSubdivision");
		NativeFieldInfoPtr_s_VeryLowSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "s_VeryLowSubdivision");
		NativeFieldInfoPtr_s_SparseSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "s_SparseSubdivision");
		NativeFieldInfoPtr_s_SparsestSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, "s_SparsestSubdivision");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr, 100665745);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeVolumeDebugColorPreferences()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeDebugColorPreferences>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeVolumeDebugColorPreferences(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
