using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class BlittableStructTests
{
	private delegate void ParameterNestedBlittableStruct_InjectedDelegate([In] System.IntPtr s);

	private delegate void ReturnNestedBlittableStruct_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ParameterStructIntDynamicArray_InjectedDelegate(System.IntPtr param);

	private delegate void ReturnStructIntDynamicArray_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ParameterStructNestedBlittableDynamicArray_InjectedDelegate(System.IntPtr param);

	private delegate void ReturnStructNestedBlittableDynamicArray_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ParameterStructFixedBuffer_InjectedDelegate([In] System.IntPtr param);

	private delegate void ReturnStructFixedBuffer_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly ParameterNestedBlittableStruct_InjectedDelegate ParameterNestedBlittableStruct_InjectedDelegateField = IL2CPP.ResolveICall<ParameterNestedBlittableStruct_InjectedDelegate>("UnityEngine.BlittableStructTests::ParameterNestedBlittableStruct_Injected");

	private static readonly ReturnNestedBlittableStruct_InjectedDelegate ReturnNestedBlittableStruct_InjectedDelegateField = IL2CPP.ResolveICall<ReturnNestedBlittableStruct_InjectedDelegate>("UnityEngine.BlittableStructTests::ReturnNestedBlittableStruct_Injected");

	private static readonly ParameterStructIntDynamicArray_InjectedDelegate ParameterStructIntDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ParameterStructIntDynamicArray_InjectedDelegate>("UnityEngine.BlittableStructTests::ParameterStructIntDynamicArray_Injected");

	private static readonly ReturnStructIntDynamicArray_InjectedDelegate ReturnStructIntDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ReturnStructIntDynamicArray_InjectedDelegate>("UnityEngine.BlittableStructTests::ReturnStructIntDynamicArray_Injected");

	private static readonly ParameterStructNestedBlittableDynamicArray_InjectedDelegate ParameterStructNestedBlittableDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ParameterStructNestedBlittableDynamicArray_InjectedDelegate>("UnityEngine.BlittableStructTests::ParameterStructNestedBlittableDynamicArray_Injected");

	private static readonly ReturnStructNestedBlittableDynamicArray_InjectedDelegate ReturnStructNestedBlittableDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ReturnStructNestedBlittableDynamicArray_InjectedDelegate>("UnityEngine.BlittableStructTests::ReturnStructNestedBlittableDynamicArray_Injected");

	private static readonly ParameterStructFixedBuffer_InjectedDelegate ParameterStructFixedBuffer_InjectedDelegateField = IL2CPP.ResolveICall<ParameterStructFixedBuffer_InjectedDelegate>("UnityEngine.BlittableStructTests::ParameterStructFixedBuffer_Injected");

	private static readonly ReturnStructFixedBuffer_InjectedDelegate ReturnStructFixedBuffer_InjectedDelegateField = IL2CPP.ResolveICall<ReturnStructFixedBuffer_InjectedDelegate>("UnityEngine.BlittableStructTests::ReturnStructFixedBuffer_Injected");

	public static void ParameterNestedBlittableStruct(StructNestedBlittable s)
	{
		ParameterNestedBlittableStruct_Injected(ref s);
	}

	public static StructNestedBlittable ReturnNestedBlittableStruct()
	{
		ReturnNestedBlittableStruct_Injected(out var ret);
		return ret;
	}

	public unsafe static void ParameterStructNestedBlittableDynamicArray(Il2CppStructArray<StructNestedBlittable> param)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<StructNestedBlittable> span);
		((Span<StructNestedBlittable>)(&span))._002Ector((Il2CppArrayBase<StructNestedBlittable>)(object)param);
		fixed (StructNestedBlittable* begin = &((Span<StructNestedBlittable>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<StructNestedBlittable>)(&span)).Length);
			ParameterStructNestedBlittableDynamicArray_Injected(ref param2);
		}
	}

	public unsafe static Il2CppStructArray<StructNestedBlittable> ReturnStructNestedBlittableDynamicArray()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<StructNestedBlittable> result;
		try
		{
			ReturnStructNestedBlittableDynamicArray_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<StructNestedBlittable> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<StructNestedBlittable>*)(&array));
			result = array;
		}
		return result;
	}

	public static void ParameterStructFixedBuffer(StructFixedBuffer param)
	{
		ParameterStructFixedBuffer_Injected(ref param);
	}

	public static StructFixedBuffer ReturnStructFixedBuffer()
	{
		ReturnStructFixedBuffer_Injected(out var ret);
		return ret;
	}

	public unsafe static void ParameterNestedBlittableStruct_Injected([In] ref StructNestedBlittable s)
	{
		ParameterNestedBlittableStruct_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref s));
	}

	public unsafe static void ReturnNestedBlittableStruct_Injected(out StructNestedBlittable ret)
	{
		ReturnNestedBlittableStruct_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ParameterStructIntDynamicArray_Injected(ref ManagedSpanWrapper param)
	{
		ParameterStructIntDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ReturnStructIntDynamicArray_Injected(out BlittableArrayWrapper ret)
	{
		ReturnStructIntDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ParameterStructNestedBlittableDynamicArray_Injected(ref ManagedSpanWrapper param)
	{
		ParameterStructNestedBlittableDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ReturnStructNestedBlittableDynamicArray_Injected(out BlittableArrayWrapper ret)
	{
		ReturnStructNestedBlittableDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ParameterStructFixedBuffer_Injected([In] ref StructFixedBuffer param)
	{
		ParameterStructFixedBuffer_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ReturnStructFixedBuffer_Injected(out StructFixedBuffer ret)
	{
		ReturnStructFixedBuffer_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
