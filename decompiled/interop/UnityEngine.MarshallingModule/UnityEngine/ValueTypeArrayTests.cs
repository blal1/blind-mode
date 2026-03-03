using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ValueTypeArrayTests
{
	private delegate void ParameterIntArrayReadOnly_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterIntArrayWritable_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterIntArrayEmpty_InjectedDelegate(System.IntPtr param, System.IntPtr param2);

	private delegate void ParameterIntArrayNullExceptions_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterIntMultidimensionalArray_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterIntMultidimensionalArrayNullExceptions_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterCharArrayReadOnly_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterBlittableCornerCaseStructArrayReadOnly_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterIntArrayOutAttr_InjectedDelegate([Out] System.IntPtr param);

	private delegate void ParameterCharArrayOutAttr_InjectedDelegate([Out] System.IntPtr param);

	private delegate void ParameterBlittableCornerCaseStructArrayOutAttr_InjectedDelegate([Out] System.IntPtr param);

	private delegate void ParameterIntArrayReturn_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ParameterIntArrayReturnEmpty_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ParameterIntArrayReturnNull_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ParameterCharArrayReturn_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ParameterBlittableCornerCaseStructArrayReturn_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly ParameterIntArrayReadOnly_InjectedDelegate ParameterIntArrayReadOnly_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntArrayReadOnly_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntArrayReadOnly_Injected");

	private static readonly ParameterIntArrayWritable_InjectedDelegate ParameterIntArrayWritable_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntArrayWritable_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntArrayWritable_Injected");

	private static readonly ParameterIntArrayEmpty_InjectedDelegate ParameterIntArrayEmpty_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntArrayEmpty_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntArrayEmpty_Injected");

	private static readonly ParameterIntArrayNullExceptions_InjectedDelegate ParameterIntArrayNullExceptions_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntArrayNullExceptions_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntArrayNullExceptions_Injected");

	private static readonly ParameterIntMultidimensionalArray_InjectedDelegate ParameterIntMultidimensionalArray_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntMultidimensionalArray_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntMultidimensionalArray_Injected");

	private static readonly ParameterIntMultidimensionalArrayNullExceptions_InjectedDelegate ParameterIntMultidimensionalArrayNullExceptions_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntMultidimensionalArrayNullExceptions_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntMultidimensionalArrayNullExceptions_Injected");

	private static readonly ParameterCharArrayReadOnly_InjectedDelegate ParameterCharArrayReadOnly_InjectedDelegateField = IL2CPP.ResolveICall<ParameterCharArrayReadOnly_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterCharArrayReadOnly_Injected");

	private static readonly ParameterBlittableCornerCaseStructArrayReadOnly_InjectedDelegate ParameterBlittableCornerCaseStructArrayReadOnly_InjectedDelegateField = IL2CPP.ResolveICall<ParameterBlittableCornerCaseStructArrayReadOnly_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterBlittableCornerCaseStructArrayReadOnly_Injected");

	private static readonly ParameterIntArrayOutAttr_InjectedDelegate ParameterIntArrayOutAttr_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntArrayOutAttr_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntArrayOutAttr_Injected");

	private static readonly ParameterCharArrayOutAttr_InjectedDelegate ParameterCharArrayOutAttr_InjectedDelegateField = IL2CPP.ResolveICall<ParameterCharArrayOutAttr_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterCharArrayOutAttr_Injected");

	private static readonly ParameterBlittableCornerCaseStructArrayOutAttr_InjectedDelegate ParameterBlittableCornerCaseStructArrayOutAttr_InjectedDelegateField = IL2CPP.ResolveICall<ParameterBlittableCornerCaseStructArrayOutAttr_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterBlittableCornerCaseStructArrayOutAttr_Injected");

	private static readonly ParameterIntArrayReturn_InjectedDelegate ParameterIntArrayReturn_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntArrayReturn_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntArrayReturn_Injected");

	private static readonly ParameterIntArrayReturnEmpty_InjectedDelegate ParameterIntArrayReturnEmpty_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntArrayReturnEmpty_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntArrayReturnEmpty_Injected");

	private static readonly ParameterIntArrayReturnNull_InjectedDelegate ParameterIntArrayReturnNull_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntArrayReturnNull_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterIntArrayReturnNull_Injected");

	private static readonly ParameterCharArrayReturn_InjectedDelegate ParameterCharArrayReturn_InjectedDelegateField = IL2CPP.ResolveICall<ParameterCharArrayReturn_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterCharArrayReturn_Injected");

	private static readonly ParameterBlittableCornerCaseStructArrayReturn_InjectedDelegate ParameterBlittableCornerCaseStructArrayReturn_InjectedDelegateField = IL2CPP.ResolveICall<ParameterBlittableCornerCaseStructArrayReturn_InjectedDelegate>("UnityEngine.ValueTypeArrayTests::ParameterBlittableCornerCaseStructArrayReturn_Injected");

	public unsafe static void ParameterIntArrayReadOnly(Il2CppStructArray<int> param)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<int> span);
		((Span<int>)(&span))._002Ector((Il2CppArrayBase<int>)(object)param);
		fixed (int* begin = &((Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<int>)(&span)).Length);
			ParameterIntArrayReadOnly_Injected(ref param2);
		}
	}

	public unsafe static void ParameterIntArrayWritable(Il2CppStructArray<int> param)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<int> span);
		((Span<int>)(&span))._002Ector((Il2CppArrayBase<int>)(object)param);
		fixed (int* begin = &((Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<int>)(&span)).Length);
			ParameterIntArrayWritable_Injected(ref param2);
		}
	}

	public unsafe static void ParameterIntArrayEmpty(Il2CppStructArray<int> param, Il2CppStructArray<int> param2)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		//IL_002b: Expected O, but got Ref
		//IL_0032: Expected O, but got Ref
		//IL_0040: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<int> span);
		((Span<int>)(&span))._002Ector((Il2CppArrayBase<int>)(object)param);
		fixed (int* begin = &((Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param3 = new ManagedSpanWrapper(begin, ((Span<int>)(&span)).Length);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<int> span2);
			((Span<int>)(&span2))._002Ector((Il2CppArrayBase<int>)(object)param2);
			fixed (int* begin2 = &((Span<int>)(&span2)).GetPinnableReference())
			{
				ManagedSpanWrapper param4 = new ManagedSpanWrapper(begin2, ((Span<int>)(&span2)).Length);
				ParameterIntArrayEmpty_Injected(ref param3, ref param4);
			}
		}
	}

	public unsafe static void ParameterIntArrayNullExceptions(Il2CppStructArray<int> param)
	{
		//IL_0017: Expected O, but got Ref
		//IL_001e: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		if (param == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)param, "param");
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<int> span);
		((Span<int>)(&span))._002Ector((Il2CppArrayBase<int>)(object)param);
		fixed (int* begin = &((Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<int>)(&span)).Length);
			ParameterIntArrayNullExceptions_Injected(ref param2);
		}
	}

	public unsafe static void ParameterCharArrayReadOnly(Il2CppStructArray<char> param)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<char> span);
		((Span<char>)(&span))._002Ector((Il2CppArrayBase<char>)(object)param);
		fixed (char* begin = &((Span<char>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<char>)(&span)).Length);
			ParameterCharArrayReadOnly_Injected(ref param2);
		}
	}

	public static void ParameterIntArrayOutAttr([Out] Il2CppStructArray<int> param)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public static void ParameterCharArrayOutAttr([Out] Il2CppStructArray<char> param)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public unsafe static Il2CppStructArray<int> ParameterIntArrayReturn()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			ParameterIntArrayReturn_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal<int>(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<int> ParameterIntArrayReturnEmpty()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			ParameterIntArrayReturnEmpty_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal<int>(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<int> ParameterIntArrayReturnNull()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			ParameterIntArrayReturnNull_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal<int>(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<char> ParameterCharArrayReturn()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<char> result;
		try
		{
			ParameterCharArrayReturn_Injected(out ret);
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<char> array);
			ret.Unmarshal<char>(ref *(Il2CppArrayBase<char>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static void ParameterIntArrayReadOnly_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntArrayReadOnly_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterIntArrayWritable_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntArrayWritable_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterIntArrayEmpty_Injected(ref ManagedSpanWrapper param, ref ManagedSpanWrapper param2)
	{
		ParameterIntArrayEmpty_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param2));
	}

	public unsafe static void ParameterIntArrayNullExceptions_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntArrayNullExceptions_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterIntMultidimensionalArray_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntMultidimensionalArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterIntMultidimensionalArrayNullExceptions_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntMultidimensionalArrayNullExceptions_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterCharArrayReadOnly_Injected(ref ManagedSpanWrapper param)
	{
		ParameterCharArrayReadOnly_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterBlittableCornerCaseStructArrayReadOnly_Injected(ref ManagedSpanWrapper param)
	{
		ParameterBlittableCornerCaseStructArrayReadOnly_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterIntArrayOutAttr_Injected(out BlittableArrayWrapper param)
	{
		ParameterIntArrayOutAttr_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterCharArrayOutAttr_Injected(out BlittableArrayWrapper param)
	{
		ParameterCharArrayOutAttr_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterBlittableCornerCaseStructArrayOutAttr_Injected(out BlittableArrayWrapper param)
	{
		ParameterBlittableCornerCaseStructArrayOutAttr_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterIntArrayReturn_Injected(out BlittableArrayWrapper ret)
	{
		ParameterIntArrayReturn_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ParameterIntArrayReturnEmpty_Injected(out BlittableArrayWrapper ret)
	{
		ParameterIntArrayReturnEmpty_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ParameterIntArrayReturnNull_Injected(out BlittableArrayWrapper ret)
	{
		ParameterIntArrayReturnNull_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ParameterCharArrayReturn_Injected(out BlittableArrayWrapper ret)
	{
		ParameterCharArrayReturn_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ParameterBlittableCornerCaseStructArrayReturn_Injected(out BlittableArrayWrapper ret)
	{
		ParameterBlittableCornerCaseStructArrayReturn_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
