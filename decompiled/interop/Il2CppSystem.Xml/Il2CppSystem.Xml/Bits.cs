using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml;

public static class Bits : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MASK_0101010101010101;

	private static readonly System.IntPtr NativeFieldInfoPtr_MASK_0011001100110011;

	private static readonly System.IntPtr NativeFieldInfoPtr_MASK_0000111100001111;

	private static readonly System.IntPtr NativeFieldInfoPtr_MASK_0000000011111111;

	private static readonly System.IntPtr NativeFieldInfoPtr_MASK_1111111111111111;

	private static readonly System.IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0;

	public unsafe static uint MASK_0101010101010101
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MASK_0101010101010101, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MASK_0101010101010101, (void*)(&value));
		}
	}

	public unsafe static uint MASK_0011001100110011
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MASK_0011001100110011, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MASK_0011001100110011, (void*)(&value));
		}
	}

	public unsafe static uint MASK_0000111100001111
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MASK_0000111100001111, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MASK_0000111100001111, (void*)(&value));
		}
	}

	public unsafe static uint MASK_0000000011111111
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MASK_0000000011111111, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MASK_0000000011111111, (void*)(&value));
		}
	}

	public unsafe static uint MASK_1111111111111111
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MASK_1111111111111111, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MASK_1111111111111111, (void*)(&value));
		}
	}

	static Bits()
	{
		Il2CppClassPointerStore<Bits>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Bits");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bits>.NativeClassPtr);
		NativeFieldInfoPtr_MASK_0101010101010101 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0101010101010101");
		NativeFieldInfoPtr_MASK_0011001100110011 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0011001100110011");
		NativeFieldInfoPtr_MASK_0000111100001111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0000111100001111");
		NativeFieldInfoPtr_MASK_0000000011111111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_0000000011111111");
		NativeFieldInfoPtr_MASK_1111111111111111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bits>.NativeClassPtr, "MASK_1111111111111111");
		NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bits>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bits>.NativeClassPtr, 100663313);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901563, XrefRangeEnd = 901567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Count(uint num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Count_Public_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 901575, RefRangeEnd = 901577, XrefRangeStart = 901567, XrefRangeEnd = 901575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LeastPosition(uint num)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeastPosition_Public_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Bits(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
