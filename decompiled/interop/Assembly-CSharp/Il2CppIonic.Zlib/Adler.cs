using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public sealed class Adler : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BASE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NMAX;

	private static readonly System.IntPtr NativeMethodInfoPtr_Adler32_Public_Static_UInt32_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static uint BASE
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BASE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BASE, (void*)(&value));
		}
	}

	public unsafe static int NMAX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NMAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NMAX, (void*)(&value));
		}
	}

	static Adler()
	{
		Il2CppClassPointerStore<Adler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "Adler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Adler>.NativeClassPtr);
		NativeFieldInfoPtr_BASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Adler>.NativeClassPtr, "BASE");
		NativeFieldInfoPtr_NMAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Adler>.NativeClassPtr, "NMAX");
		NativeMethodInfoPtr_Adler32_Public_Static_UInt32_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Adler>.NativeClassPtr, 100664316);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Adler>.NativeClassPtr, 100664317);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 41443, RefRangeEnd = 41450, XrefRangeStart = 41434, XrefRangeEnd = 41443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint Adler32(uint adler, Il2CppStructArray<byte> buf, int index, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&adler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Adler32_Public_Static_UInt32_UInt32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Adler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Adler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Adler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
