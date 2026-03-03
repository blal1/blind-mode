using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Numerics;

public class ConstantHelper : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetByteWithAllBitsSet_Public_Static_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSByteWithAllBitsSet_Public_Static_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUInt16WithAllBitsSet_Public_Static_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt16WithAllBitsSet_Public_Static_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUInt32WithAllBitsSet_Public_Static_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt32WithAllBitsSet_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUInt64WithAllBitsSet_Public_Static_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt64WithAllBitsSet_Public_Static_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSingleWithAllBitsSet_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDoubleWithAllBitsSet_Public_Static_Double_0;

	static ConstantHelper()
	{
		Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Numerics", "ConstantHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetByteWithAllBitsSet_Public_Static_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672561);
		NativeMethodInfoPtr_GetSByteWithAllBitsSet_Public_Static_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672562);
		NativeMethodInfoPtr_GetUInt16WithAllBitsSet_Public_Static_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672563);
		NativeMethodInfoPtr_GetInt16WithAllBitsSet_Public_Static_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672564);
		NativeMethodInfoPtr_GetUInt32WithAllBitsSet_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672565);
		NativeMethodInfoPtr_GetInt32WithAllBitsSet_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672566);
		NativeMethodInfoPtr_GetUInt64WithAllBitsSet_Public_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672567);
		NativeMethodInfoPtr_GetInt64WithAllBitsSet_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672568);
		NativeMethodInfoPtr_GetSingleWithAllBitsSet_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672569);
		NativeMethodInfoPtr_GetDoubleWithAllBitsSet_Public_Static_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100672570);
	}

	[CallerCount(0)]
	public unsafe static byte GetByteWithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetByteWithAllBitsSet_Public_Static_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static sbyte GetSByteWithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSByteWithAllBitsSet_Public_Static_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 812776, RefRangeEnd = 812783, XrefRangeStart = 812776, XrefRangeEnd = 812776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort GetUInt16WithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUInt16WithAllBitsSet_Public_Static_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static short GetInt16WithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt16WithAllBitsSet_Public_Static_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint GetUInt32WithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUInt32WithAllBitsSet_Public_Static_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int GetInt32WithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt32WithAllBitsSet_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static ulong GetUInt64WithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUInt64WithAllBitsSet_Public_Static_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static long GetInt64WithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt64WithAllBitsSet_Public_Static_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float GetSingleWithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSingleWithAllBitsSet_Public_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static double GetDoubleWithAllBitsSet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDoubleWithAllBitsSet_Public_Static_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ConstantHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
