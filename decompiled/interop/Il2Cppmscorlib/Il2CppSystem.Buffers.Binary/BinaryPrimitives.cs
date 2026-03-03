using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Buffers.Binary;

public static class BinaryPrimitives : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt16_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt32_UInt32_0;

	static BinaryPrimitives()
	{
		Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers.Binary", "BinaryPrimitives");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr);
		NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr, 100674382);
		NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr, 100674383);
		NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr, 100674384);
		NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr, 100674385);
	}

	[CallerCount(0)]
	public unsafe static short ReverseEndianness(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int16_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int ReverseEndianness(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static ushort ReverseEndianness(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt16_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint ReverseEndianness(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public BinaryPrimitives(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
