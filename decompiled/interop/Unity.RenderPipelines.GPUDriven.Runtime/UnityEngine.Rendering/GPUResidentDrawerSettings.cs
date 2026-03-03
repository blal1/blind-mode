using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class GPUResidentDrawerSettings : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportDitheringCrossFade;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableOcclusionCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInEditMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallMeshScreenPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_errorShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadingShader;

	public unsafe GPUResidentDrawerMode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(GPUResidentDrawerMode*)num;
		}
		set
		{
			*(GPUResidentDrawerMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = value;
		}
	}

	public unsafe bool supportDitheringCrossFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDitheringCrossFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDitheringCrossFade)) = value;
		}
	}

	public unsafe bool enableOcclusionCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableOcclusionCulling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableOcclusionCulling)) = value;
		}
	}

	public unsafe bool allowInEditMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInEditMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInEditMode)) = value;
		}
	}

	public unsafe float smallMeshScreenPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallMeshScreenPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallMeshScreenPercentage)) = value;
		}
	}

	public unsafe Shader errorShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Shader loadingShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadingShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static GPUResidentDrawerSettings()
	{
		Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUResidentDrawerSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr);
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_supportDitheringCrossFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, "supportDitheringCrossFade");
		NativeFieldInfoPtr_enableOcclusionCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, "enableOcclusionCulling");
		NativeFieldInfoPtr_allowInEditMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, "allowInEditMode");
		NativeFieldInfoPtr_smallMeshScreenPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, "smallMeshScreenPercentage");
		NativeFieldInfoPtr_errorShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, "errorShader");
		NativeFieldInfoPtr_loadingShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, "loadingShader");
	}

	public GPUResidentDrawerSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GPUResidentDrawerSettings()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr))
	{
	}
}
