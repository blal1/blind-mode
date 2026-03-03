using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct UIVertex
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_tangent;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_uv0;

	private static readonly System.IntPtr NativeFieldInfoPtr_uv1;

	private static readonly System.IntPtr NativeFieldInfoPtr_uv2;

	private static readonly System.IntPtr NativeFieldInfoPtr_uv3;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultTangent;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleVert;

	[FieldOffset(0)]
	public Vector3 position;

	[FieldOffset(12)]
	public Vector3 normal;

	[FieldOffset(24)]
	public Vector4 tangent;

	[FieldOffset(40)]
	public Color32 color;

	[FieldOffset(44)]
	public Vector4 uv0;

	[FieldOffset(60)]
	public Vector4 uv1;

	[FieldOffset(76)]
	public Vector4 uv2;

	[FieldOffset(92)]
	public Vector4 uv3;

	public unsafe static Color32 s_DefaultColor
	{
		get
		{
			Unsafe.SkipInit(out Color32 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultColor, (void*)(&value));
		}
	}

	public unsafe static Vector4 s_DefaultTangent
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultTangent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
		}
	}

	public unsafe static UIVertex simpleVert
	{
		get
		{
			Unsafe.SkipInit(out UIVertex result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_simpleVert, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_simpleVert, (void*)(&value));
		}
	}

	static UIVertex()
	{
		Il2CppClassPointerStore<UIVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UIVertex");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIVertex>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "position");
		NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "normal");
		NativeFieldInfoPtr_tangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "tangent");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "color");
		NativeFieldInfoPtr_uv0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv0");
		NativeFieldInfoPtr_uv1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv1");
		NativeFieldInfoPtr_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv2");
		NativeFieldInfoPtr_uv3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "uv3");
		NativeFieldInfoPtr_s_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "s_DefaultColor");
		NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "s_DefaultTangent");
		NativeFieldInfoPtr_simpleVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, "simpleVert");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIVertex>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
