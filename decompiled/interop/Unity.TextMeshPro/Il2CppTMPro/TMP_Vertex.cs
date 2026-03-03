using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro;

[StructLayout(LayoutKind.Explicit)]
public struct TMP_Vertex
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_uv;

	private static readonly System.IntPtr NativeFieldInfoPtr_uv2;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Zero;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0;

	[FieldOffset(0)]
	public Vector3 position;

	[FieldOffset(12)]
	public Vector4 uv;

	[FieldOffset(28)]
	public Vector2 uv2;

	[FieldOffset(36)]
	public Color32 color;

	public unsafe static TMP_Vertex k_Zero
	{
		get
		{
			Unsafe.SkipInit(out TMP_Vertex result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Zero, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Zero, (void*)(&value));
		}
	}

	public unsafe static TMP_Vertex zero
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120035, XrefRangeEnd = 1120039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TMP_Vertex*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TMP_Vertex()
	{
		Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Vertex");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "position");
		NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "uv");
		NativeFieldInfoPtr_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "uv2");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "color");
		NativeFieldInfoPtr_k_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, "k_Zero");
		NativeMethodInfoPtr_get_zero_Public_Static_get_TMP_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, 100663640);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_Vertex>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
