using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public static class ZlibConstants : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_WindowBitsMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_WindowBitsDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_OK;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_STREAM_END;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_NEED_DICT;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_STREAM_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_DATA_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_Z_BUF_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorkingBufferSizeDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorkingBufferSizeMin;

	public unsafe static int WindowBitsMax
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WindowBitsMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WindowBitsMax, (void*)(&value));
		}
	}

	public unsafe static int WindowBitsDefault
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WindowBitsDefault, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WindowBitsDefault, (void*)(&value));
		}
	}

	public unsafe static int Z_OK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_OK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_OK, (void*)(&value));
		}
	}

	public unsafe static int Z_STREAM_END
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_STREAM_END, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_STREAM_END, (void*)(&value));
		}
	}

	public unsafe static int Z_NEED_DICT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_NEED_DICT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_NEED_DICT, (void*)(&value));
		}
	}

	public unsafe static int Z_STREAM_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_STREAM_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_STREAM_ERROR, (void*)(&value));
		}
	}

	public unsafe static int Z_DATA_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_DATA_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_DATA_ERROR, (void*)(&value));
		}
	}

	public unsafe static int Z_BUF_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Z_BUF_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Z_BUF_ERROR, (void*)(&value));
		}
	}

	public unsafe static int WorkingBufferSizeDefault
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorkingBufferSizeDefault, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorkingBufferSizeDefault, (void*)(&value));
		}
	}

	public unsafe static int WorkingBufferSizeMin
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WorkingBufferSizeMin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WorkingBufferSizeMin, (void*)(&value));
		}
	}

	static ZlibConstants()
	{
		Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "ZlibConstants");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr);
		NativeFieldInfoPtr_WindowBitsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "WindowBitsMax");
		NativeFieldInfoPtr_WindowBitsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "WindowBitsDefault");
		NativeFieldInfoPtr_Z_OK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "Z_OK");
		NativeFieldInfoPtr_Z_STREAM_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "Z_STREAM_END");
		NativeFieldInfoPtr_Z_NEED_DICT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "Z_NEED_DICT");
		NativeFieldInfoPtr_Z_STREAM_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "Z_STREAM_ERROR");
		NativeFieldInfoPtr_Z_DATA_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "Z_DATA_ERROR");
		NativeFieldInfoPtr_Z_BUF_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "Z_BUF_ERROR");
		NativeFieldInfoPtr_WorkingBufferSizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "WorkingBufferSizeDefault");
		NativeFieldInfoPtr_WorkingBufferSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZlibConstants>.NativeClassPtr, "WorkingBufferSizeMin");
	}

	public ZlibConstants(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
