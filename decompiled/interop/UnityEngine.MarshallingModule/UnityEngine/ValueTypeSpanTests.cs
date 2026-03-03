using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ValueTypeSpanTests
{
	private delegate void ParameterIntReadOnlySpan_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterIntSpan_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterBoolReadOnlySpan_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterCharReadOnlySpan_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterEnumReadOnlySpan_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterBlittableCornerCaseStructReadOnlySpan_InjectedDelegate(System.IntPtr param);

	private delegate void ReturnsArrayRefWritableAsSpan_InjectedDelegate(int val1, int val2, int val3, [Out] System.IntPtr ret);

	private delegate void ReturnsCoreVectorRefAsSpan_InjectedDelegate(int val1, int val2, int val3, [Out] System.IntPtr ret);

	private delegate void ReturnsScriptingSpanAsSpan_InjectedDelegate(int val1, int val2, int val3, [Out] System.IntPtr ret);

	private delegate void ReturnsArrayRefWritableAsReadOnlySpan_InjectedDelegate(int val1, int val2, int val3, [Out] System.IntPtr ret);

	private delegate void ReturnsCoreVectorRefAsReadOnlySpan_InjectedDelegate(int val1, int val2, int val3, [Out] System.IntPtr ret);

	private delegate void ReturnsArrayRefAsReadOnlySpan_InjectedDelegate(int val1, int val2, int val3, [Out] System.IntPtr ret);

	private delegate void ReturnsScriptingReadOnlySpanAsSpan_InjectedDelegate(int val1, int val2, int val3, [Out] System.IntPtr ret);

	private static readonly ParameterIntReadOnlySpan_InjectedDelegate ParameterIntReadOnlySpan_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntReadOnlySpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ParameterIntReadOnlySpan_Injected");

	private static readonly ParameterIntSpan_InjectedDelegate ParameterIntSpan_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntSpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ParameterIntSpan_Injected");

	private static readonly ParameterBoolReadOnlySpan_InjectedDelegate ParameterBoolReadOnlySpan_InjectedDelegateField = IL2CPP.ResolveICall<ParameterBoolReadOnlySpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ParameterBoolReadOnlySpan_Injected");

	private static readonly ParameterCharReadOnlySpan_InjectedDelegate ParameterCharReadOnlySpan_InjectedDelegateField = IL2CPP.ResolveICall<ParameterCharReadOnlySpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ParameterCharReadOnlySpan_Injected");

	private static readonly ParameterEnumReadOnlySpan_InjectedDelegate ParameterEnumReadOnlySpan_InjectedDelegateField = IL2CPP.ResolveICall<ParameterEnumReadOnlySpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ParameterEnumReadOnlySpan_Injected");

	private static readonly ParameterBlittableCornerCaseStructReadOnlySpan_InjectedDelegate ParameterBlittableCornerCaseStructReadOnlySpan_InjectedDelegateField = IL2CPP.ResolveICall<ParameterBlittableCornerCaseStructReadOnlySpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ParameterBlittableCornerCaseStructReadOnlySpan_Injected");

	private static readonly ReturnsArrayRefWritableAsSpan_InjectedDelegate ReturnsArrayRefWritableAsSpan_InjectedDelegateField = IL2CPP.ResolveICall<ReturnsArrayRefWritableAsSpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ReturnsArrayRefWritableAsSpan_Injected");

	private static readonly ReturnsCoreVectorRefAsSpan_InjectedDelegate ReturnsCoreVectorRefAsSpan_InjectedDelegateField = IL2CPP.ResolveICall<ReturnsCoreVectorRefAsSpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ReturnsCoreVectorRefAsSpan_Injected");

	private static readonly ReturnsScriptingSpanAsSpan_InjectedDelegate ReturnsScriptingSpanAsSpan_InjectedDelegateField = IL2CPP.ResolveICall<ReturnsScriptingSpanAsSpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ReturnsScriptingSpanAsSpan_Injected");

	private static readonly ReturnsArrayRefWritableAsReadOnlySpan_InjectedDelegate ReturnsArrayRefWritableAsReadOnlySpan_InjectedDelegateField = IL2CPP.ResolveICall<ReturnsArrayRefWritableAsReadOnlySpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ReturnsArrayRefWritableAsReadOnlySpan_Injected");

	private static readonly ReturnsCoreVectorRefAsReadOnlySpan_InjectedDelegate ReturnsCoreVectorRefAsReadOnlySpan_InjectedDelegateField = IL2CPP.ResolveICall<ReturnsCoreVectorRefAsReadOnlySpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ReturnsCoreVectorRefAsReadOnlySpan_Injected");

	private static readonly ReturnsArrayRefAsReadOnlySpan_InjectedDelegate ReturnsArrayRefAsReadOnlySpan_InjectedDelegateField = IL2CPP.ResolveICall<ReturnsArrayRefAsReadOnlySpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ReturnsArrayRefAsReadOnlySpan_Injected");

	private static readonly ReturnsScriptingReadOnlySpanAsSpan_InjectedDelegate ReturnsScriptingReadOnlySpanAsSpan_InjectedDelegateField = IL2CPP.ResolveICall<ReturnsScriptingReadOnlySpanAsSpan_InjectedDelegate>("UnityEngine.ValueTypeSpanTests::ReturnsScriptingReadOnlySpanAsSpan_Injected");

	public unsafe static void ParameterIntReadOnlySpan(ReadOnlySpan<int> param)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0015: Expected O, but got Ref
		ReadOnlySpan<int> readOnlySpan = param;
		fixed (int* begin = &((ReadOnlySpan<int>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((ReadOnlySpan<int>)(&readOnlySpan)).Length);
			ParameterIntReadOnlySpan_Injected(ref param2);
		}
	}

	public unsafe static void ParameterIntSpan(Span<int> param)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0015: Expected O, but got Ref
		Span<int> span = param;
		fixed (int* begin = &((Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<int>)(&span)).Length);
			ParameterIntSpan_Injected(ref param2);
		}
	}

	public unsafe static void ParameterBoolReadOnlySpan(ReadOnlySpan<bool> param)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0015: Expected O, but got Ref
		ReadOnlySpan<bool> readOnlySpan = param;
		fixed (bool* begin = &((ReadOnlySpan<bool>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((ReadOnlySpan<bool>)(&readOnlySpan)).Length);
			ParameterBoolReadOnlySpan_Injected(ref param2);
		}
	}

	public unsafe static void ParameterCharReadOnlySpan(ReadOnlySpan<char> param)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0015: Expected O, but got Ref
		ReadOnlySpan<char> readOnlySpan = param;
		fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
			ParameterCharReadOnlySpan_Injected(ref param2);
		}
	}

	public unsafe static void ParameterEnumReadOnlySpan(ReadOnlySpan<SomeEnum> param)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0015: Expected O, but got Ref
		ReadOnlySpan<SomeEnum> readOnlySpan = param;
		fixed (SomeEnum* begin = &((ReadOnlySpan<SomeEnum>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((ReadOnlySpan<SomeEnum>)(&readOnlySpan)).Length);
			ParameterEnumReadOnlySpan_Injected(ref param2);
		}
	}

	public static Span<int> ReturnsArrayRefWritableAsSpan(int val1, int val2, int val3)
	{
		ReturnsArrayRefWritableAsSpan_Injected(val1, val2, val3, out var ret);
		return ManagedSpanWrapper.ToSpan<int>(ret);
	}

	public static Span<int> ReturnsCoreVectorRefAsSpan(int val1, int val2, int val3)
	{
		ReturnsCoreVectorRefAsSpan_Injected(val1, val2, val3, out var ret);
		return ManagedSpanWrapper.ToSpan<int>(ret);
	}

	public static Span<int> ReturnsScriptingSpanAsSpan(int val1, int val2, int val3)
	{
		ReturnsScriptingSpanAsSpan_Injected(val1, val2, val3, out var ret);
		return ManagedSpanWrapper.ToSpan<int>(ret);
	}

	public static ReadOnlySpan<int> ReturnsArrayRefWritableAsReadOnlySpan(int val1, int val2, int val3)
	{
		ReturnsArrayRefWritableAsReadOnlySpan_Injected(val1, val2, val3, out var ret);
		return ManagedSpanWrapper.ToReadOnlySpan<int>(ret);
	}

	public static ReadOnlySpan<int> ReturnsCoreVectorRefAsReadOnlySpan(int val1, int val2, int val3)
	{
		ReturnsCoreVectorRefAsReadOnlySpan_Injected(val1, val2, val3, out var ret);
		return ManagedSpanWrapper.ToReadOnlySpan<int>(ret);
	}

	public static ReadOnlySpan<int> ReturnsArrayRefAsReadOnlySpan(int val1, int val2, int val3)
	{
		ReturnsArrayRefAsReadOnlySpan_Injected(val1, val2, val3, out var ret);
		return ManagedSpanWrapper.ToReadOnlySpan<int>(ret);
	}

	public static ReadOnlySpan<int> ReturnsScriptingReadOnlySpanAsSpan(int val1, int val2, int val3)
	{
		ReturnsScriptingReadOnlySpanAsSpan_Injected(val1, val2, val3, out var ret);
		return ManagedSpanWrapper.ToReadOnlySpan<int>(ret);
	}

	public unsafe static void ParameterIntReadOnlySpan_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntReadOnlySpan_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterIntSpan_Injected(ref ManagedSpanWrapper param)
	{
		ParameterIntSpan_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterBoolReadOnlySpan_Injected(ref ManagedSpanWrapper param)
	{
		ParameterBoolReadOnlySpan_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterCharReadOnlySpan_Injected(ref ManagedSpanWrapper param)
	{
		ParameterCharReadOnlySpan_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterEnumReadOnlySpan_Injected(ref ManagedSpanWrapper param)
	{
		ParameterEnumReadOnlySpan_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterBlittableCornerCaseStructReadOnlySpan_Injected(ref ManagedSpanWrapper param)
	{
		ParameterBlittableCornerCaseStructReadOnlySpan_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ReturnsArrayRefWritableAsSpan_Injected(int val1, int val2, int val3, out ManagedSpanWrapper ret)
	{
		ReturnsArrayRefWritableAsSpan_InjectedDelegateField(val1, val2, val3, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnsCoreVectorRefAsSpan_Injected(int val1, int val2, int val3, out ManagedSpanWrapper ret)
	{
		ReturnsCoreVectorRefAsSpan_InjectedDelegateField(val1, val2, val3, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnsScriptingSpanAsSpan_Injected(int val1, int val2, int val3, out ManagedSpanWrapper ret)
	{
		ReturnsScriptingSpanAsSpan_InjectedDelegateField(val1, val2, val3, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnsArrayRefWritableAsReadOnlySpan_Injected(int val1, int val2, int val3, out ManagedSpanWrapper ret)
	{
		ReturnsArrayRefWritableAsReadOnlySpan_InjectedDelegateField(val1, val2, val3, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnsCoreVectorRefAsReadOnlySpan_Injected(int val1, int val2, int val3, out ManagedSpanWrapper ret)
	{
		ReturnsCoreVectorRefAsReadOnlySpan_InjectedDelegateField(val1, val2, val3, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnsArrayRefAsReadOnlySpan_Injected(int val1, int val2, int val3, out ManagedSpanWrapper ret)
	{
		ReturnsArrayRefAsReadOnlySpan_InjectedDelegateField(val1, val2, val3, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnsScriptingReadOnlySpanAsSpan_Injected(int val1, int val2, int val3, out ManagedSpanWrapper ret)
	{
		ReturnsScriptingReadOnlySpanAsSpan_InjectedDelegateField(val1, val2, val3, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
