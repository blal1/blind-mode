using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class StringTests
{
	private delegate void ParameterCoreStringVectorDelegate(System.IntPtr param);

	private delegate void ParameterCoreStringDynamicArrayDelegate(System.IntPtr param);

	private delegate System.IntPtr ReturnCoreStringVectorDelegate();

	private delegate System.IntPtr ReturnCoreStringDynamicArrayDelegate();

	private delegate System.IntPtr ReturnNullStringDynamicArrayDelegate();

	private delegate void SetTestOutString_InjectedDelegate(System.IntPtr testString);

	private delegate void ParameterICallString_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterICallNullString_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterCoreString_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterConstCharPtr_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterConstCharPtrNull_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterConstCharPtrEmptyString_InjectedDelegate(System.IntPtr param);

	private delegate void ReturnCoreString_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ReturnCoreStringRef_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ReturnConstCharPtr_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void FalseConditional_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void ParameterOutString_InjectedDelegate([Out] System.IntPtr param);

	private delegate void ParameterOutStringInNull_InjectedDelegate([Out] System.IntPtr param);

	private delegate void ParameterOutStringNotSet_InjectedDelegate([Out] System.IntPtr param);

	private delegate void ParameterRefString_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterRefStringInNull_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterRefStringNotSet_InjectedDelegate(System.IntPtr param);

	private static readonly ParameterCoreStringVectorDelegate ParameterCoreStringVectorDelegateField = IL2CPP.ResolveICall<ParameterCoreStringVectorDelegate>("UnityEngine.StringTests::ParameterCoreStringVector");

	private static readonly ParameterCoreStringDynamicArrayDelegate ParameterCoreStringDynamicArrayDelegateField = IL2CPP.ResolveICall<ParameterCoreStringDynamicArrayDelegate>("UnityEngine.StringTests::ParameterCoreStringDynamicArray");

	private static readonly ReturnCoreStringVectorDelegate ReturnCoreStringVectorDelegateField = IL2CPP.ResolveICall<ReturnCoreStringVectorDelegate>("UnityEngine.StringTests::ReturnCoreStringVector");

	private static readonly ReturnCoreStringDynamicArrayDelegate ReturnCoreStringDynamicArrayDelegateField = IL2CPP.ResolveICall<ReturnCoreStringDynamicArrayDelegate>("UnityEngine.StringTests::ReturnCoreStringDynamicArray");

	private static readonly ReturnNullStringDynamicArrayDelegate ReturnNullStringDynamicArrayDelegateField = IL2CPP.ResolveICall<ReturnNullStringDynamicArrayDelegate>("UnityEngine.StringTests::ReturnNullStringDynamicArray");

	private static readonly SetTestOutString_InjectedDelegate SetTestOutString_InjectedDelegateField = IL2CPP.ResolveICall<SetTestOutString_InjectedDelegate>("UnityEngine.StringTests::SetTestOutString_Injected");

	private static readonly ParameterICallString_InjectedDelegate ParameterICallString_InjectedDelegateField = IL2CPP.ResolveICall<ParameterICallString_InjectedDelegate>("UnityEngine.StringTests::ParameterICallString_Injected");

	private static readonly ParameterICallNullString_InjectedDelegate ParameterICallNullString_InjectedDelegateField = IL2CPP.ResolveICall<ParameterICallNullString_InjectedDelegate>("UnityEngine.StringTests::ParameterICallNullString_Injected");

	private static readonly ParameterCoreString_InjectedDelegate ParameterCoreString_InjectedDelegateField = IL2CPP.ResolveICall<ParameterCoreString_InjectedDelegate>("UnityEngine.StringTests::ParameterCoreString_Injected");

	private static readonly ParameterConstCharPtr_InjectedDelegate ParameterConstCharPtr_InjectedDelegateField = IL2CPP.ResolveICall<ParameterConstCharPtr_InjectedDelegate>("UnityEngine.StringTests::ParameterConstCharPtr_Injected");

	private static readonly ParameterConstCharPtrNull_InjectedDelegate ParameterConstCharPtrNull_InjectedDelegateField = IL2CPP.ResolveICall<ParameterConstCharPtrNull_InjectedDelegate>("UnityEngine.StringTests::ParameterConstCharPtrNull_Injected");

	private static readonly ParameterConstCharPtrEmptyString_InjectedDelegate ParameterConstCharPtrEmptyString_InjectedDelegateField = IL2CPP.ResolveICall<ParameterConstCharPtrEmptyString_InjectedDelegate>("UnityEngine.StringTests::ParameterConstCharPtrEmptyString_Injected");

	private static readonly ReturnCoreString_InjectedDelegate ReturnCoreString_InjectedDelegateField = IL2CPP.ResolveICall<ReturnCoreString_InjectedDelegate>("UnityEngine.StringTests::ReturnCoreString_Injected");

	private static readonly ReturnCoreStringRef_InjectedDelegate ReturnCoreStringRef_InjectedDelegateField = IL2CPP.ResolveICall<ReturnCoreStringRef_InjectedDelegate>("UnityEngine.StringTests::ReturnCoreStringRef_Injected");

	private static readonly ReturnConstCharPtr_InjectedDelegate ReturnConstCharPtr_InjectedDelegateField = IL2CPP.ResolveICall<ReturnConstCharPtr_InjectedDelegate>("UnityEngine.StringTests::ReturnConstCharPtr_Injected");

	private static readonly FalseConditional_InjectedDelegate FalseConditional_InjectedDelegateField = IL2CPP.ResolveICall<FalseConditional_InjectedDelegate>("UnityEngine.StringTests::FalseConditional_Injected");

	private static readonly ParameterOutString_InjectedDelegate ParameterOutString_InjectedDelegateField = IL2CPP.ResolveICall<ParameterOutString_InjectedDelegate>("UnityEngine.StringTests::ParameterOutString_Injected");

	private static readonly ParameterOutStringInNull_InjectedDelegate ParameterOutStringInNull_InjectedDelegateField = IL2CPP.ResolveICall<ParameterOutStringInNull_InjectedDelegate>("UnityEngine.StringTests::ParameterOutStringInNull_Injected");

	private static readonly ParameterOutStringNotSet_InjectedDelegate ParameterOutStringNotSet_InjectedDelegateField = IL2CPP.ResolveICall<ParameterOutStringNotSet_InjectedDelegate>("UnityEngine.StringTests::ParameterOutStringNotSet_Injected");

	private static readonly ParameterRefString_InjectedDelegate ParameterRefString_InjectedDelegateField = IL2CPP.ResolveICall<ParameterRefString_InjectedDelegate>("UnityEngine.StringTests::ParameterRefString_Injected");

	private static readonly ParameterRefStringInNull_InjectedDelegate ParameterRefStringInNull_InjectedDelegateField = IL2CPP.ResolveICall<ParameterRefStringInNull_InjectedDelegate>("UnityEngine.StringTests::ParameterRefStringInNull_Injected");

	private static readonly ParameterRefStringNotSet_InjectedDelegate ParameterRefStringNotSet_InjectedDelegateField = IL2CPP.ResolveICall<ParameterRefStringNotSet_InjectedDelegate>("UnityEngine.StringTests::ParameterRefStringNotSet_Injected");

	public unsafe static void SetTestOutString(string testString)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(testString, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = testString.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetTestOutString_Injected(ref managedSpanWrapper);
					return;
				}
			}
			SetTestOutString_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void ParameterICallString(string param)
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
					ParameterICallString_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterICallString_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void ParameterICallNullString(string param)
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
					ParameterICallNullString_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterICallNullString_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void ParameterCoreString(string param)
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
					ParameterCoreString_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterCoreString_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void ParameterConstCharPtr(string param)
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
					ParameterConstCharPtr_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterConstCharPtr_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void ParameterConstCharPtrNull(string param)
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
					ParameterConstCharPtrNull_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterConstCharPtrNull_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void ParameterConstCharPtrEmptyString(string param)
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
					ParameterConstCharPtrEmptyString_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterConstCharPtrEmptyString_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void ParameterCoreStringVector(Il2CppStringArray param)
	{
		ParameterCoreStringVectorDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static void ParameterCoreStringDynamicArray(Il2CppStringArray param)
	{
		ParameterCoreStringDynamicArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static string ReturnCoreString()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			ReturnCoreString_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string ReturnCoreStringRef()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			ReturnCoreStringRef_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string ReturnConstCharPtr()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			ReturnConstCharPtr_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static Il2CppStringArray ReturnCoreStringVector()
	{
		System.IntPtr intPtr = ReturnCoreStringVectorDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppStringArray ReturnCoreStringDynamicArray()
	{
		System.IntPtr intPtr = ReturnCoreStringDynamicArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppStringArray ReturnNullStringDynamicArray()
	{
		System.IntPtr intPtr = ReturnNullStringDynamicArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static string FalseConditional()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			FalseConditional_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static void ParameterOutString(out string param)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper param2);
		try
		{
			ParameterOutString_Injected(out param2);
		}
		finally
		{
			param = OutStringMarshaller.GetStringAndDispose(param2);
		}
	}

	public static void ParameterOutStringInNull(out string param)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper param2);
		try
		{
			ParameterOutStringInNull_Injected(out param2);
		}
		finally
		{
			param = OutStringMarshaller.GetStringAndDispose(param2);
		}
	}

	public static void ParameterOutStringNotSet(out string param)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper param2);
		try
		{
			ParameterOutStringNotSet_Injected(out param2);
		}
		finally
		{
			param = OutStringMarshaller.GetStringAndDispose(param2);
		}
	}

	public unsafe static void ParameterRefString(ref string param)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
		try
		{
			if (!StringMarshaller.TryMarshalEmptyOrNullString(param, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = param.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					ParameterRefString_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterRefString_Injected(ref managedSpanWrapper);
		}
		finally
		{
			param = OutStringMarshaller.GetStringAndDispose(managedSpanWrapper);
		}
	}

	public unsafe static void ParameterRefStringInNull(ref string param)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
		try
		{
			if (!StringMarshaller.TryMarshalEmptyOrNullString(param, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = param.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					ParameterRefStringInNull_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterRefStringInNull_Injected(ref managedSpanWrapper);
		}
		finally
		{
			param = OutStringMarshaller.GetStringAndDispose(managedSpanWrapper);
		}
	}

	public unsafe static void ParameterRefStringNotSet(ref string param)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
		try
		{
			if (!StringMarshaller.TryMarshalEmptyOrNullString(param, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = param.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					ParameterRefStringNotSet_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ParameterRefStringNotSet_Injected(ref managedSpanWrapper);
		}
		finally
		{
			param = OutStringMarshaller.GetStringAndDispose(managedSpanWrapper);
		}
	}

	public unsafe static void SetTestOutString_Injected(ref ManagedSpanWrapper testString)
	{
		SetTestOutString_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref testString));
	}

	public unsafe static void ParameterICallString_Injected(ref ManagedSpanWrapper param)
	{
		ParameterICallString_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterICallNullString_Injected(ref ManagedSpanWrapper param)
	{
		ParameterICallNullString_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterCoreString_Injected(ref ManagedSpanWrapper param)
	{
		ParameterCoreString_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterConstCharPtr_Injected(ref ManagedSpanWrapper param)
	{
		ParameterConstCharPtr_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterConstCharPtrNull_Injected(ref ManagedSpanWrapper param)
	{
		ParameterConstCharPtrNull_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterConstCharPtrEmptyString_Injected(ref ManagedSpanWrapper param)
	{
		ParameterConstCharPtrEmptyString_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ReturnCoreString_Injected(out ManagedSpanWrapper ret)
	{
		ReturnCoreString_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnCoreStringRef_Injected(out ManagedSpanWrapper ret)
	{
		ReturnCoreStringRef_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ReturnConstCharPtr_Injected(out ManagedSpanWrapper ret)
	{
		ReturnConstCharPtr_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void FalseConditional_Injected(out ManagedSpanWrapper ret)
	{
		FalseConditional_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ParameterOutString_Injected(out ManagedSpanWrapper param)
	{
		ParameterOutString_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterOutStringInNull_Injected(out ManagedSpanWrapper param)
	{
		ParameterOutStringInNull_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterOutStringNotSet_Injected(out ManagedSpanWrapper param)
	{
		ParameterOutStringNotSet_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterRefString_Injected(ref ManagedSpanWrapper param)
	{
		ParameterRefString_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterRefStringInNull_Injected(ref ManagedSpanWrapper param)
	{
		ParameterRefStringInNull_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}

	public unsafe static void ParameterRefStringNotSet_Injected(ref ManagedSpanWrapper param)
	{
		ParameterRefStringNotSet_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}
}
