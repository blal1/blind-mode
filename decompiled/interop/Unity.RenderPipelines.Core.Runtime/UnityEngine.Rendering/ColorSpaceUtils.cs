using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

public static class ColorSpaceUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Rec709ToRec2020Mat;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rec709ToP3D65Mat;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rec2020ToRec709Mat;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rec2020ToP3D65Mat;

	private static readonly System.IntPtr NativeFieldInfoPtr_P3D65ToRec2020Mat;

	public unsafe static float3x3 Rec709ToRec2020Mat
	{
		get
		{
			Unsafe.SkipInit(out float3x3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Rec709ToRec2020Mat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Rec709ToRec2020Mat, (void*)(&value));
		}
	}

	public unsafe static float3x3 Rec709ToP3D65Mat
	{
		get
		{
			Unsafe.SkipInit(out float3x3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Rec709ToP3D65Mat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Rec709ToP3D65Mat, (void*)(&value));
		}
	}

	public unsafe static float3x3 Rec2020ToRec709Mat
	{
		get
		{
			Unsafe.SkipInit(out float3x3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Rec2020ToRec709Mat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Rec2020ToRec709Mat, (void*)(&value));
		}
	}

	public unsafe static float3x3 Rec2020ToP3D65Mat
	{
		get
		{
			Unsafe.SkipInit(out float3x3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Rec2020ToP3D65Mat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Rec2020ToP3D65Mat, (void*)(&value));
		}
	}

	public unsafe static float3x3 P3D65ToRec2020Mat
	{
		get
		{
			Unsafe.SkipInit(out float3x3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_P3D65ToRec2020Mat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_P3D65ToRec2020Mat, (void*)(&value));
		}
	}

	static ColorSpaceUtils()
	{
		Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ColorSpaceUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr);
		NativeFieldInfoPtr_Rec709ToRec2020Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "Rec709ToRec2020Mat");
		NativeFieldInfoPtr_Rec709ToP3D65Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "Rec709ToP3D65Mat");
		NativeFieldInfoPtr_Rec2020ToRec709Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "Rec2020ToRec709Mat");
		NativeFieldInfoPtr_Rec2020ToP3D65Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "Rec2020ToP3D65Mat");
		NativeFieldInfoPtr_P3D65ToRec2020Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSpaceUtils>.NativeClassPtr, "P3D65ToRec2020Mat");
	}

	public ColorSpaceUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
