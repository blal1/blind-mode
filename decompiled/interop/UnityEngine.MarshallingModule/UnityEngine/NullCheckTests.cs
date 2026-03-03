using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class NullCheckTests
{
	private delegate void WritableObjectParameterNullAllowedDelegate(System.IntPtr param);

	private delegate void StringParameterNullAllowed_InjectedDelegate(System.IntPtr param);

	private delegate void StringParameterNullNotAllowed_InjectedDelegate(System.IntPtr param);

	private delegate void ArrayParameterNullAllowed_InjectedDelegate(System.IntPtr param);

	private delegate void ArrayParameterNullNotAllowed_InjectedDelegate(System.IntPtr param);

	private delegate void ObjectParameterNullAllowed_InjectedDelegate(System.IntPtr param);

	private delegate void ObjectParameterNullNotAllowed_InjectedDelegate(System.IntPtr param);

	private delegate void WritableObjectParameterNullNotAllowed_InjectedDelegate(System.IntPtr param);

	private delegate void IntPtrObjectParameterNullAllowed_InjectedDelegate(System.IntPtr param);

	private delegate void IntPtrObjectParameterNullNotAllowed_InjectedDelegate(System.IntPtr param);

	private static readonly WritableObjectParameterNullAllowedDelegate WritableObjectParameterNullAllowedDelegateField = IL2CPP.ResolveICall<WritableObjectParameterNullAllowedDelegate>("UnityEngine.NullCheckTests::WritableObjectParameterNullAllowed");

	private static readonly StringParameterNullAllowed_InjectedDelegate StringParameterNullAllowed_InjectedDelegateField = IL2CPP.ResolveICall<StringParameterNullAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::StringParameterNullAllowed_Injected");

	private static readonly StringParameterNullNotAllowed_InjectedDelegate StringParameterNullNotAllowed_InjectedDelegateField = IL2CPP.ResolveICall<StringParameterNullNotAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::StringParameterNullNotAllowed_Injected");

	private static readonly ArrayParameterNullAllowed_InjectedDelegate ArrayParameterNullAllowed_InjectedDelegateField = IL2CPP.ResolveICall<ArrayParameterNullAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::ArrayParameterNullAllowed_Injected");

	private static readonly ArrayParameterNullNotAllowed_InjectedDelegate ArrayParameterNullNotAllowed_InjectedDelegateField = IL2CPP.ResolveICall<ArrayParameterNullNotAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::ArrayParameterNullNotAllowed_Injected");

	private static readonly ObjectParameterNullAllowed_InjectedDelegate ObjectParameterNullAllowed_InjectedDelegateField = IL2CPP.ResolveICall<ObjectParameterNullAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::ObjectParameterNullAllowed_Injected");

	private static readonly ObjectParameterNullNotAllowed_InjectedDelegate ObjectParameterNullNotAllowed_InjectedDelegateField = IL2CPP.ResolveICall<ObjectParameterNullNotAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::ObjectParameterNullNotAllowed_Injected");

	private static readonly WritableObjectParameterNullNotAllowed_InjectedDelegate WritableObjectParameterNullNotAllowed_InjectedDelegateField = IL2CPP.ResolveICall<WritableObjectParameterNullNotAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::WritableObjectParameterNullNotAllowed_Injected");

	private static readonly IntPtrObjectParameterNullAllowed_InjectedDelegate IntPtrObjectParameterNullAllowed_InjectedDelegateField = IL2CPP.ResolveICall<IntPtrObjectParameterNullAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::IntPtrObjectParameterNullAllowed_Injected");

	private static readonly IntPtrObjectParameterNullNotAllowed_InjectedDelegate IntPtrObjectParameterNullNotAllowed_InjectedDelegateField = IL2CPP.ResolveICall<IntPtrObjectParameterNullNotAllowed_InjectedDelegate>("UnityEngine.NullCheckTests::IntPtrObjectParameterNullNotAllowed_Injected");

	public unsafe static void StringParameterNullAllowed(string param)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(param, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = param.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					StringParameterNullAllowed_Injected(ref managedSpanWrapper);
					return;
				}
			}
			StringParameterNullAllowed_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void StringParameterNullNotAllowed(string param)
	{
		//IL_0027: Expected O, but got Ref
		//IL_0033: Expected O, but got Ref
		//The blocks IL_0038 are reachable both inside and outside the pinned region starting at IL_0027. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (param == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(param, "param");
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(param, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = param.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					StringParameterNullNotAllowed_Injected(ref managedSpanWrapper);
					return;
				}
			}
			StringParameterNullNotAllowed_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void ArrayParameterNullAllowed(Il2CppStructArray<int> param)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<int> span);
		((Span<int>)(&span))._002Ector((Il2CppArrayBase<int>)(object)param);
		fixed (int* begin = &((Span<int>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper param2 = new ManagedSpanWrapper(begin, ((Span<int>)(&span)).Length);
			ArrayParameterNullAllowed_Injected(ref param2);
		}
	}

	public unsafe static void ArrayParameterNullNotAllowed(Il2CppStructArray<int> param)
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
			ArrayParameterNullNotAllowed_Injected(ref param2);
		}
	}

	public static void ObjectParameterNullAllowed(MarshallingTestObject param)
	{
		ObjectParameterNullAllowed_Injected(Object.MarshalledUnityObject.Marshal(param));
	}

	public static void ObjectParameterNullNotAllowed(MarshallingTestObject param)
	{
		if ((object)param == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(param, "param");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(param);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(param, "param");
		}
		ObjectParameterNullNotAllowed_Injected(intPtr);
	}

	public static void WritableObjectParameterNullAllowed(MarshallingTestObject param)
	{
		WritableObjectParameterNullAllowedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static void WritableObjectParameterNullNotAllowed(MarshallingTestObject param)
	{
		if ((object)param == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(param, "param");
		}
		WritableObjectParameterNullNotAllowed_Injected(param);
	}

	public static void IntPtrObjectParameterNullAllowed(MyIntPtrObject param)
	{
		IntPtrObjectParameterNullAllowed_Injected((param == null) ? ((System.IntPtr)0) : MyIntPtrObject.BindingsMarshaller.ConvertToNative(param));
	}

	public static void IntPtrObjectParameterNullNotAllowed(MyIntPtrObject param)
	{
		if (param == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)param, "param");
		}
		System.IntPtr intPtr = MyIntPtrObject.BindingsMarshaller.ConvertToNative(param);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)param, "param");
		}
		IntPtrObjectParameterNullNotAllowed_Injected(intPtr);
	}

	public unsafe static void StringParameterNullAllowed_Injected(ref ManagedSpanWrapper param)
	{
		StringParameterNullAllowed_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void StringParameterNullNotAllowed_Injected(ref ManagedSpanWrapper param)
	{
		StringParameterNullNotAllowed_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ArrayParameterNullAllowed_Injected(ref ManagedSpanWrapper param)
	{
		ArrayParameterNullAllowed_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ArrayParameterNullNotAllowed_Injected(ref ManagedSpanWrapper param)
	{
		ArrayParameterNullNotAllowed_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public static void ObjectParameterNullAllowed_Injected(System.IntPtr param)
	{
		ObjectParameterNullAllowed_InjectedDelegateField(param);
	}

	public static void ObjectParameterNullNotAllowed_Injected(System.IntPtr param)
	{
		ObjectParameterNullNotAllowed_InjectedDelegateField(param);
	}

	public static void WritableObjectParameterNullNotAllowed_Injected(MarshallingTestObject param)
	{
		WritableObjectParameterNullNotAllowed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static void IntPtrObjectParameterNullAllowed_Injected(System.IntPtr param)
	{
		IntPtrObjectParameterNullAllowed_InjectedDelegateField(param);
	}

	public static void IntPtrObjectParameterNullNotAllowed_Injected(System.IntPtr param)
	{
		IntPtrObjectParameterNullNotAllowed_InjectedDelegateField(param);
	}
}
