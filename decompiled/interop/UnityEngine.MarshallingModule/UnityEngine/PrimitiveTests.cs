using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class PrimitiveTests
{
	private delegate void ParameterBoolDelegate(bool param1, bool param2, int param3);

	private delegate void ParameterIntDelegate(int param);

	private delegate void ParameterOutIntDelegate([Out] System.IntPtr param);

	private delegate void ParameterRefIntDelegate(System.IntPtr param);

	private delegate int ReturnIntDelegate();

	private delegate void ParameterIntDynamicArray_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterIntNullableDynamicArray_InjectedDelegate(System.IntPtr param);

	private delegate void ReturnIntDynamicArray_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ReturnNullIntDynamicArray_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ReturnBoolDynamicArray_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ReturnCharDynamicArray_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly ParameterBoolDelegate ParameterBoolDelegateField = IL2CPP.ResolveICall<ParameterBoolDelegate>("UnityEngine.PrimitiveTests::ParameterBool");

	private static readonly ParameterIntDelegate ParameterIntDelegateField = IL2CPP.ResolveICall<ParameterIntDelegate>("UnityEngine.PrimitiveTests::ParameterInt");

	private static readonly ParameterOutIntDelegate ParameterOutIntDelegateField = IL2CPP.ResolveICall<ParameterOutIntDelegate>("UnityEngine.PrimitiveTests::ParameterOutInt");

	private static readonly ParameterRefIntDelegate ParameterRefIntDelegateField = IL2CPP.ResolveICall<ParameterRefIntDelegate>("UnityEngine.PrimitiveTests::ParameterRefInt");

	private static readonly ReturnIntDelegate ReturnIntDelegateField = IL2CPP.ResolveICall<ReturnIntDelegate>("UnityEngine.PrimitiveTests::ReturnInt");

	private static readonly ParameterIntDynamicArray_InjectedDelegate ParameterIntDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntDynamicArray_InjectedDelegate>("UnityEngine.PrimitiveTests::ParameterIntDynamicArray_Injected");

	private static readonly ParameterIntNullableDynamicArray_InjectedDelegate ParameterIntNullableDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntNullableDynamicArray_InjectedDelegate>("UnityEngine.PrimitiveTests::ParameterIntNullableDynamicArray_Injected");

	private static readonly ReturnIntDynamicArray_InjectedDelegate ReturnIntDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ReturnIntDynamicArray_InjectedDelegate>("UnityEngine.PrimitiveTests::ReturnIntDynamicArray_Injected");

	private static readonly ReturnNullIntDynamicArray_InjectedDelegate ReturnNullIntDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ReturnNullIntDynamicArray_InjectedDelegate>("UnityEngine.PrimitiveTests::ReturnNullIntDynamicArray_Injected");

	private static readonly ReturnBoolDynamicArray_InjectedDelegate ReturnBoolDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ReturnBoolDynamicArray_InjectedDelegate>("UnityEngine.PrimitiveTests::ReturnBoolDynamicArray_Injected");

	private static readonly ReturnCharDynamicArray_InjectedDelegate ReturnCharDynamicArray_InjectedDelegateField = IL2CPP.ResolveICall<ReturnCharDynamicArray_InjectedDelegate>("UnityEngine.PrimitiveTests::ReturnCharDynamicArray_Injected");

	public static void ParameterBool(bool param1, bool param2, int param3)
	{
		ParameterBoolDelegateField(param1, param2, param3);
	}

	public static void ParameterInt(int param)
	{
		ParameterIntDelegateField(param);
	}

	public unsafe static void ParameterOutInt(out int param)
	{
		ParameterOutIntDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterRefInt(ref int param)
	{
		ParameterRefIntDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public static int ReturnInt()
	{
		return ReturnIntDelegateField();
	}

	public unsafe static void ParameterIntDynamicArray(Il2CppStructArray<int> param)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<int> span);
		((Span<int>)(&span))._002Ector((Il2CppArrayBase<int>)(object)param);
		fixed (int* begin = &((Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<int>)(&span)).Length);
			ParameterIntDynamicArray_Injected(ref param2);
		}
	}

	public unsafe static void ParameterIntNullableDynamicArray(Il2CppStructArray<int> param)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<int> span);
		((Span<int>)(&span))._002Ector((Il2CppArrayBase<int>)(object)param);
		fixed (int* begin = &((Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<int>)(&span)).Length);
			ParameterIntNullableDynamicArray_Injected(ref param2);
		}
	}

	public unsafe static Il2CppStructArray<int> ReturnIntDynamicArray()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			ReturnIntDynamicArray_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal<int>(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<int> ReturnNullIntDynamicArray()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			ReturnNullIntDynamicArray_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal<int>(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<bool> ReturnBoolDynamicArray()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<bool> result;
		try
		{
			ReturnBoolDynamicArray_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<bool> array);
			ret.Unmarshal<bool>(ref *(Il2CppArrayBase<bool>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<char> ReturnCharDynamicArray()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<char> result;
		try
		{
			ReturnCharDynamicArray_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<char> array);
			ret.Unmarshal<char>(ref *(Il2CppArrayBase<char>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static void ParameterIntDynamicArray_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterIntNullableDynamicArray_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntNullableDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ReturnIntDynamicArray_Injected(out BlittableArrayWrapper ret)
	{
		ReturnIntDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnNullIntDynamicArray_Injected(out BlittableArrayWrapper ret)
	{
		ReturnNullIntDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnBoolDynamicArray_Injected(out BlittableArrayWrapper ret)
	{
		ReturnBoolDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnCharDynamicArray_Injected(out BlittableArrayWrapper ret)
	{
		ReturnCharDynamicArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
