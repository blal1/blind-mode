using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ExceptionTests
{
	private delegate int NonUnmarshallingReturnDelegate();

	private delegate int get_PropertyThatCanThrowDelegate();

	private delegate void set_PropertyThatCanThrowDelegate(int value);

	private delegate int get_PropertyGetThatCanThrowDelegate();

	private delegate void set_PropertyGetThatCanThrowDelegate(int value);

	private delegate int get_PropertySetThatCanThrowDelegate();

	private delegate void set_PropertySetThatCanThrowDelegate(int value);

	private delegate void VoidReturnStringParameter_InjectedDelegate(System.IntPtr param);

	private delegate void UnmarshallingReturn_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly NonUnmarshallingReturnDelegate NonUnmarshallingReturnDelegateField = IL2CPP.ResolveICall<NonUnmarshallingReturnDelegate>("UnityEngine.ExceptionTests::NonUnmarshallingReturn");

	private static readonly get_PropertyThatCanThrowDelegate get_PropertyThatCanThrowDelegateField = IL2CPP.ResolveICall<get_PropertyThatCanThrowDelegate>("UnityEngine.ExceptionTests::get_PropertyThatCanThrow");

	private static readonly set_PropertyThatCanThrowDelegate set_PropertyThatCanThrowDelegateField = IL2CPP.ResolveICall<set_PropertyThatCanThrowDelegate>("UnityEngine.ExceptionTests::set_PropertyThatCanThrow");

	private static readonly get_PropertyGetThatCanThrowDelegate get_PropertyGetThatCanThrowDelegateField = IL2CPP.ResolveICall<get_PropertyGetThatCanThrowDelegate>("UnityEngine.ExceptionTests::get_PropertyGetThatCanThrow");

	private static readonly set_PropertyGetThatCanThrowDelegate set_PropertyGetThatCanThrowDelegateField = IL2CPP.ResolveICall<set_PropertyGetThatCanThrowDelegate>("UnityEngine.ExceptionTests::set_PropertyGetThatCanThrow");

	private static readonly get_PropertySetThatCanThrowDelegate get_PropertySetThatCanThrowDelegateField = IL2CPP.ResolveICall<get_PropertySetThatCanThrowDelegate>("UnityEngine.ExceptionTests::get_PropertySetThatCanThrow");

	private static readonly set_PropertySetThatCanThrowDelegate set_PropertySetThatCanThrowDelegateField = IL2CPP.ResolveICall<set_PropertySetThatCanThrowDelegate>("UnityEngine.ExceptionTests::set_PropertySetThatCanThrow");

	private static readonly VoidReturnStringParameter_InjectedDelegate VoidReturnStringParameter_InjectedDelegateField = IL2CPP.ResolveICall<VoidReturnStringParameter_InjectedDelegate>("UnityEngine.ExceptionTests::VoidReturnStringParameter_Injected");

	private static readonly UnmarshallingReturn_InjectedDelegate UnmarshallingReturn_InjectedDelegateField = IL2CPP.ResolveICall<UnmarshallingReturn_InjectedDelegate>("UnityEngine.ExceptionTests::UnmarshallingReturn_Injected");

	public static int PropertyThatCanThrow
	{
		get
		{
			return get_PropertyThatCanThrowDelegateField();
		}
		set
		{
			set_PropertyThatCanThrowDelegateField(value);
		}
	}

	public static int PropertyGetThatCanThrow
	{
		get
		{
			return get_PropertyGetThatCanThrowDelegateField();
		}
		set
		{
			set_PropertyGetThatCanThrowDelegateField(value);
		}
	}

	public static int PropertySetThatCanThrow
	{
		get
		{
			return get_PropertySetThatCanThrowDelegateField();
		}
		set
		{
			set_PropertySetThatCanThrowDelegateField(value);
		}
	}

	public unsafe static void VoidReturnStringParameter(string param)
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
					VoidReturnStringParameter_Injected(ref managedSpanWrapper);
					return;
				}
			}
			VoidReturnStringParameter_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static int NonUnmarshallingReturn()
	{
		return NonUnmarshallingReturnDelegateField();
	}

	public static string UnmarshallingReturn()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			UnmarshallingReturn_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void VoidReturnStringParameter_Injected(ref ManagedSpanWrapper param)
	{
		VoidReturnStringParameter_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void UnmarshallingReturn_Injected(out ManagedSpanWrapper ret)
	{
		UnmarshallingReturn_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
