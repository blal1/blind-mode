using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct ArgIterator
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sig;

	private static readonly System.IntPtr NativeFieldInfoPtr_args;

	private static readonly System.IntPtr NativeFieldInfoPtr_next_arg;

	private static readonly System.IntPtr NativeFieldInfoPtr_num_args;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public System.IntPtr sig;

	[FieldOffset(8)]
	public System.IntPtr args;

	[FieldOffset(16)]
	public int next_arg;

	[FieldOffset(20)]
	public int num_args;

	static ArgIterator()
	{
		Il2CppClassPointerStore<ArgIterator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgIterator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr);
		NativeFieldInfoPtr_sig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "sig");
		NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "args");
		NativeFieldInfoPtr_next_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "next_arg");
		NativeFieldInfoPtr_num_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "num_args");
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, 100667051);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, 100667052);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759782, XrefRangeEnd = 759788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(175)]
	[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
