using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Hash128
{
	private sealed class MethodInfoStoreGeneric_Compute_Public_Static_Hash128_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Compute_Public_Static_Hash128_byref_T_0, Il2CppClassPointerStore<Hash128>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Append_Public_Void_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Append_Public_Void_byref_T_0, Il2CppClassPointerStore<Hash128>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate void ComputeFromArrayDelegate(System.IntPtr data, int start, int count, int elemSize, System.IntPtr hash);

	private delegate void ComputeFromString_InjectedDelegate(System.IntPtr data, System.IntPtr hash);

	private static readonly System.IntPtr NativeFieldInfoPtr_u64_0;

	private static readonly System.IntPtr NativeFieldInfoPtr_u64_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_kConst;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFromPtr_Private_Static_Void_IntPtr_Int32_Int32_Int32_byref_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compute_Public_Static_Hash128_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compute_Public_Static_Hash128_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShortHash4_Private_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Hash128_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_Void_byref_Hash128_byref_ManagedSpanWrapper_0;

	[FieldOffset(0)]
	public ulong u64_0;

	[FieldOffset(8)]
	public ulong u64_1;

	private static readonly ComputeFromArrayDelegate ComputeFromArrayDelegateField;

	private static readonly ComputeFromString_InjectedDelegate ComputeFromString_InjectedDelegateField;

	public unsafe static ulong kConst
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kConst, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kConst, (void*)(&value));
		}
	}

	public bool isValid => u64_0 != 0L || u64_1 != 0;

	static Hash128()
	{
		Il2CppClassPointerStore<Hash128>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Hash128");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128>.NativeClassPtr);
		NativeFieldInfoPtr_u64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "u64_0");
		NativeFieldInfoPtr_u64_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "u64_1");
		NativeFieldInfoPtr_kConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "kConst");
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665506);
		NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665507);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665508);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665509);
		NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665510);
		NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665511);
		NativeMethodInfoPtr_ComputeFromPtr_Private_Static_Void_IntPtr_Int32_Int32_Int32_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665512);
		NativeMethodInfoPtr_Compute_Public_Static_Hash128_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665513);
		NativeMethodInfoPtr_Compute_Public_Static_Hash128_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665514);
		NativeMethodInfoPtr_Append_Public_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665515);
		NativeMethodInfoPtr_Append_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665516);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665517);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665518);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665519);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665520);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665521);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665522);
		NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665523);
		NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665524);
		NativeMethodInfoPtr_ShortHash4_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665525);
		NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665526);
		NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665527);
		NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665528);
		NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_Void_byref_Hash128_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665529);
		ComputeFromArrayDelegateField = IL2CPP.ResolveICall<ComputeFromArrayDelegate>("UnityEngine.Hash128::ComputeFromArray");
		ComputeFromString_InjectedDelegateField = IL2CPP.ResolveICall<ComputeFromString_InjectedDelegate>("UnityEngine.Hash128::ComputeFromString_Injected");
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1182179, RefRangeEnd = 1182183, XrefRangeStart = 1182179, XrefRangeEnd = 1182179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&u32_0);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u32_1;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &u32_2;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &u32_3;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 745538, RefRangeEnd = 745547, XrefRangeStart = 745538, XrefRangeEnd = 745547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hash128(ulong u64_0, ulong u64_1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u64_0);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u64_1;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int CompareTo(Hash128 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1182184, RefRangeEnd = 1182187, XrefRangeStart = 1182183, XrefRangeEnd = 1182184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1182201, RefRangeEnd = 1182202, XrefRangeStart = 1182187, XrefRangeEnd = 1182201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hash128 Parse(string hashString)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hashString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Hash128*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1182207, RefRangeEnd = 1182208, XrefRangeStart = 1182202, XrefRangeEnd = 1182207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Hash128ToStringImpl(Hash128 hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1182210, RefRangeEnd = 1182212, XrefRangeStart = 1182208, XrefRangeEnd = 1182210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ComputeFromPtr(System.IntPtr data, int start, int count, int elemSize, ref Hash128 hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &elemSize;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFromPtr_Private_Static_Void_IntPtr_Int32_Int32_Int32_byref_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1182215, RefRangeEnd = 1182230, XrefRangeStart = 1182212, XrefRangeEnd = 1182215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hash128 Compute<T>(ref T val) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref val));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Compute_Public_Static_Hash128_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref val) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		return *(Hash128*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1182231, RefRangeEnd = 1182235, XrefRangeStart = 1182230, XrefRangeEnd = 1182231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hash128 Compute(int val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compute_Public_Static_Hash128_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Hash128*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1182238, RefRangeEnd = 1182242, XrefRangeStart = 1182235, XrefRangeEnd = 1182238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Append<T>(ref T val) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref val));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Append_Public_Void_byref_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref val) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182242, XrefRangeEnd = 1182243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Append(int val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182243, XrefRangeEnd = 1182246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(Hash128 obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182246, XrefRangeEnd = 1182248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182248, XrefRangeEnd = 1182251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1182251, RefRangeEnd = 1182253, XrefRangeStart = 1182251, XrefRangeEnd = 1182251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Hash128 hash1, Hash128 hash2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hash1);
		*(Hash128**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hash2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1182253, RefRangeEnd = 1182262, XrefRangeStart = 1182253, XrefRangeEnd = 1182253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(Hash128 hash1, Hash128 hash2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hash1);
		*(Hash128**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hash2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Hash128_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1182262, RefRangeEnd = 1182265, XrefRangeStart = 1182262, XrefRangeEnd = 1182262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator <(Hash128 x, Hash128 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(Hash128**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator >(Hash128 x, Hash128 y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(Hash128**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1182265, RefRangeEnd = 1182267, XrefRangeStart = 1182265, XrefRangeEnd = 1182265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShortHash4(uint data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShortHash4_Private_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref h0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h1);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h2);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref h3);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void Rot64(ref ulong x, int k)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &k;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182267, XrefRangeEnd = 1182269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Parse_Injected(ref ManagedSpanWrapper hashString, out Hash128 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref hashString);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Hash128_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182269, XrefRangeEnd = 1182271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Hash128ToStringImpl_Injected([In] ref Hash128 hash, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref hash);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_Void_byref_Hash128_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hash128>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public unsafe static void ComputeFromString(string data, ref Hash128 hash)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(data, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(data);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					ComputeFromString_Injected(ref managedSpanWrapper, ref hash);
					return;
				}
			}
			ComputeFromString_Injected(ref managedSpanWrapper, ref hash);
		}
		finally
		{
		}
	}

	public unsafe static void ComputeFromArray(Il2CppSystem.Array data, int start, int count, int elemSize, ref Hash128 hash)
	{
		ComputeFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data), start, count, elemSize, (nint)Unsafe.AsPointer(ref hash));
	}

	public static Hash128 Compute(string data)
	{
		Hash128 hash = default(Hash128);
		ComputeFromString(data, ref hash);
		return hash;
	}

	public unsafe static Hash128 Compute<T>(NativeArray<T> data) where T : struct
	{
		//IL_001c: Expected O, but got Ref
		Hash128 hash = default(Hash128);
		ComputeFromPtr((System.IntPtr)data.GetUnsafeReadOnlyPtr(), 0, ((NativeArray<T>)(&data)).Length, UnsafeUtility.SizeOf<T>(), ref hash);
		return hash;
	}

	public unsafe static Hash128 Compute<T>(NativeArray<T> data, int start, int count) where T : struct
	{
		//IL_0013: Expected O, but got Ref
		if (start < 0 || count < 0 || start + count > ((NativeArray<T>)(&data)).Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object)(object)start, (Il2CppSystem.Object)(object)count));
		}
		Hash128 hash = default(Hash128);
		ComputeFromPtr((System.IntPtr)data.GetUnsafeReadOnlyPtr(), start, count, UnsafeUtility.SizeOf<T>(), ref hash);
		return hash;
	}

	public static Hash128 Compute<T>(Il2CppArrayBase<T> data) where T : struct
	{
		if (!UnsafeUtility.IsArrayBlittable((Il2CppSystem.Array)(object)data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Array passed to Compute must be blittable.\n", UnsafeUtility.GetReasonForArrayNonBlittable((Il2CppSystem.Array)(object)data)));
		}
		Hash128 hash = default(Hash128);
		ComputeFromArray((Il2CppSystem.Array)(object)data, 0, ((Il2CppArrayBase)data).Length, UnsafeUtility.SizeOf<T>(), ref hash);
		return hash;
	}

	public static Hash128 Compute<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
	{
		if (!UnsafeUtility.IsArrayBlittable((Il2CppSystem.Array)(object)data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Array passed to Compute must be blittable.\n", UnsafeUtility.GetReasonForArrayNonBlittable((Il2CppSystem.Array)(object)data)));
		}
		if (start < 0 || count < 0 || start + count > ((Il2CppArrayBase)data).Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object)(object)start, (Il2CppSystem.Object)(object)count));
		}
		Hash128 hash = default(Hash128);
		ComputeFromArray((Il2CppSystem.Array)(object)data, start, count, UnsafeUtility.SizeOf<T>(), ref hash);
		return hash;
	}

	public static Hash128 Compute<T>(List<T> data) where T : struct
	{
		if (!UnsafeUtility.IsGenericListBlittable<T>())
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Compute", UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
		}
		Hash128 hash = default(Hash128);
		ComputeFromArray((Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), 0, data.Count, UnsafeUtility.SizeOf<T>(), ref hash);
		return hash;
	}

	public static Hash128 Compute<T>(List<T> data, int start, int count) where T : struct
	{
		if (!UnsafeUtility.IsGenericListBlittable<T>())
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Compute", UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
		}
		if (start < 0 || count < 0 || start + count > data.Count)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object)(object)start, (Il2CppSystem.Object)(object)count));
		}
		Hash128 hash = default(Hash128);
		ComputeFromArray((Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), start, count, UnsafeUtility.SizeOf<T>(), ref hash);
		return hash;
	}

	public static Hash128 Compute(float val)
	{
		Hash128 result = default(Hash128);
		result.Append(val);
		return result;
	}

	public unsafe static Hash128 Compute(void* data, ulong size)
	{
		Hash128 hash = default(Hash128);
		ComputeFromPtr(new System.IntPtr(data), 0, (int)size, 1, ref hash);
		return hash;
	}

	public void Append(string data)
	{
		ComputeFromString(data, ref this);
	}

	public unsafe void Append<T>(NativeArray<T> data) where T : struct
	{
		//IL_0014: Expected O, but got Ref
		ComputeFromPtr((System.IntPtr)data.GetUnsafeReadOnlyPtr(), 0, ((NativeArray<T>)(&data)).Length, UnsafeUtility.SizeOf<T>(), ref this);
	}

	public unsafe void Append<T>(NativeArray<T> data, int start, int count) where T : struct
	{
		//IL_0013: Expected O, but got Ref
		if (start < 0 || count < 0 || start + count > ((NativeArray<T>)(&data)).Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object)(object)start, (Il2CppSystem.Object)(object)count));
		}
		ComputeFromPtr((System.IntPtr)data.GetUnsafeReadOnlyPtr(), start, count, UnsafeUtility.SizeOf<T>(), ref this);
	}

	public void Append<T>(Il2CppArrayBase<T> data) where T : struct
	{
		if (!UnsafeUtility.IsArrayBlittable((Il2CppSystem.Array)(object)data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Array passed to Append must be blittable.\n", UnsafeUtility.GetReasonForArrayNonBlittable((Il2CppSystem.Array)(object)data)));
		}
		ComputeFromArray((Il2CppSystem.Array)(object)data, 0, ((Il2CppArrayBase)data).Length, UnsafeUtility.SizeOf<T>(), ref this);
	}

	public void Append<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
	{
		if (!UnsafeUtility.IsArrayBlittable((Il2CppSystem.Array)(object)data))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Array passed to Append must be blittable.\n", UnsafeUtility.GetReasonForArrayNonBlittable((Il2CppSystem.Array)(object)data)));
		}
		if (start < 0 || count < 0 || start + count > ((Il2CppArrayBase)data).Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object)(object)start, (Il2CppSystem.Object)(object)count));
		}
		ComputeFromArray((Il2CppSystem.Array)(object)data, start, count, UnsafeUtility.SizeOf<T>(), ref this);
	}

	public void Append<T>(List<T> data) where T : struct
	{
		if (!UnsafeUtility.IsGenericListBlittable<T>())
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Append", UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
		}
		ComputeFromArray((Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), 0, data.Count, UnsafeUtility.SizeOf<T>(), ref this);
	}

	public void Append<T>(List<T> data, int start, int count) where T : struct
	{
		if (!UnsafeUtility.IsGenericListBlittable<T>())
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Append", UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
		}
		if (start < 0 || count < 0 || start + count > data.Count)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Bad start/count arguments (start:{0} count:{1})", (Il2CppSystem.Object)(object)start, (Il2CppSystem.Object)(object)count));
		}
		ComputeFromArray((Il2CppSystem.Array)(object)NoAllocHelpers.ExtractArrayFromList(data), start, count, UnsafeUtility.SizeOf<T>(), ref this);
	}

	public unsafe void Append(float val)
	{
		ShortHash4(*(uint*)(&val));
	}

	public unsafe void Append(void* data, ulong size)
	{
		ComputeFromPtr(new System.IntPtr(data), 0, (int)size, 1, ref this);
	}

	public unsafe static void ComputeFromString_Injected(ref ManagedSpanWrapper data, ref Hash128 hash)
	{
		ComputeFromString_InjectedDelegateField((nint)Unsafe.AsPointer(ref data), (nint)Unsafe.AsPointer(ref hash));
	}
}
