using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro;

public static class TMP_Math : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FLOAT_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_FLOAT_MIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_INT_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_INT_MIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_FLOAT_UNSET;

	private static readonly System.IntPtr NativeFieldInfoPtr_INT_UNSET;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_16BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_16BIT;

	private static readonly System.IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0;

	public unsafe static float FLOAT_MAX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FLOAT_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FLOAT_MAX, (void*)(&value));
		}
	}

	public unsafe static float FLOAT_MIN
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FLOAT_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FLOAT_MIN, (void*)(&value));
		}
	}

	public unsafe static int INT_MAX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INT_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INT_MAX, (void*)(&value));
		}
	}

	public unsafe static int INT_MIN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INT_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INT_MIN, (void*)(&value));
		}
	}

	public unsafe static float FLOAT_UNSET
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FLOAT_UNSET, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FLOAT_UNSET, (void*)(&value));
		}
	}

	public unsafe static int INT_UNSET
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INT_UNSET, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INT_UNSET, (void*)(&value));
		}
	}

	public unsafe static Vector2 MAX_16BIT
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_16BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_16BIT, (void*)(&value));
		}
	}

	public unsafe static Vector2 MIN_16BIT
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_16BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_16BIT, (void*)(&value));
		}
	}

	static TMP_Math()
	{
		Il2CppClassPointerStore<TMP_Math>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Math");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr);
		NativeFieldInfoPtr_FLOAT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_MAX");
		NativeFieldInfoPtr_FLOAT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_MIN");
		NativeFieldInfoPtr_INT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_MAX");
		NativeFieldInfoPtr_INT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_MIN");
		NativeFieldInfoPtr_FLOAT_UNSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_UNSET");
		NativeFieldInfoPtr_INT_UNSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_UNSET");
		NativeFieldInfoPtr_MAX_16BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "MAX_16BIT");
		NativeFieldInfoPtr_MIN_16BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "MIN_16BIT");
		NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, 100663610);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1119845, RefRangeEnd = 1119848, XrefRangeStart = 1119845, XrefRangeEnd = 1119845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Approximately(float a, float b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int Mod(int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TMP_Math(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
