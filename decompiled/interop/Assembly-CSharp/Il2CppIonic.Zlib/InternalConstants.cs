using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public static class InternalConstants : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BITS;

	private static readonly System.IntPtr NativeFieldInfoPtr_BL_CODES;

	private static readonly System.IntPtr NativeFieldInfoPtr_D_CODES;

	private static readonly System.IntPtr NativeFieldInfoPtr_LITERALS;

	private static readonly System.IntPtr NativeFieldInfoPtr_LENGTH_CODES;

	private static readonly System.IntPtr NativeFieldInfoPtr_L_CODES;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_BL_BITS;

	private static readonly System.IntPtr NativeFieldInfoPtr_REP_3_6;

	private static readonly System.IntPtr NativeFieldInfoPtr_REPZ_3_10;

	private static readonly System.IntPtr NativeFieldInfoPtr_REPZ_11_138;

	public unsafe static int MAX_BITS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_BITS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_BITS, (void*)(&value));
		}
	}

	public unsafe static int BL_CODES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BL_CODES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BL_CODES, (void*)(&value));
		}
	}

	public unsafe static int D_CODES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_D_CODES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_D_CODES, (void*)(&value));
		}
	}

	public unsafe static int LITERALS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LITERALS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LITERALS, (void*)(&value));
		}
	}

	public unsafe static int LENGTH_CODES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LENGTH_CODES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LENGTH_CODES, (void*)(&value));
		}
	}

	public unsafe static int L_CODES
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_L_CODES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_L_CODES, (void*)(&value));
		}
	}

	public unsafe static int MAX_BL_BITS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_BL_BITS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_BL_BITS, (void*)(&value));
		}
	}

	public unsafe static int REP_3_6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REP_3_6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REP_3_6, (void*)(&value));
		}
	}

	public unsafe static int REPZ_3_10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REPZ_3_10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REPZ_3_10, (void*)(&value));
		}
	}

	public unsafe static int REPZ_11_138
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REPZ_11_138, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REPZ_11_138, (void*)(&value));
		}
	}

	static InternalConstants()
	{
		Il2CppClassPointerStore<InternalConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "InternalConstants");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "MAX_BITS");
		NativeFieldInfoPtr_BL_CODES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "BL_CODES");
		NativeFieldInfoPtr_D_CODES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "D_CODES");
		NativeFieldInfoPtr_LITERALS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "LITERALS");
		NativeFieldInfoPtr_LENGTH_CODES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "LENGTH_CODES");
		NativeFieldInfoPtr_L_CODES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "L_CODES");
		NativeFieldInfoPtr_MAX_BL_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "MAX_BL_BITS");
		NativeFieldInfoPtr_REP_3_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "REP_3_6");
		NativeFieldInfoPtr_REPZ_3_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "REPZ_3_10");
		NativeFieldInfoPtr_REPZ_11_138 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalConstants>.NativeClassPtr, "REPZ_11_138");
	}

	public InternalConstants(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
