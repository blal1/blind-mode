using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ExceptionTypeTests
{
	private delegate void NullReferenceException_InjectedDelegate(System.IntPtr nativeFormat, System.IntPtr values);

	private delegate void ArgumentNullException_InjectedDelegate(System.IntPtr argumentName);

	private delegate void ArgumentException_InjectedDelegate(System.IntPtr nativeFormat, System.IntPtr values);

	private delegate void InvalidOperationException_InjectedDelegate(System.IntPtr nativeFormat, System.IntPtr values);

	private delegate void IndexOutOfRangeException_InjectedDelegate(System.IntPtr nativeFormat, int index);

	private static readonly NullReferenceException_InjectedDelegate NullReferenceException_InjectedDelegateField = IL2CPP.ResolveICall<NullReferenceException_InjectedDelegate>("UnityEngine.ExceptionTypeTests::NullReferenceException_Injected");

	private static readonly ArgumentNullException_InjectedDelegate ArgumentNullException_InjectedDelegateField = IL2CPP.ResolveICall<ArgumentNullException_InjectedDelegate>("UnityEngine.ExceptionTypeTests::ArgumentNullException_Injected");

	private static readonly ArgumentException_InjectedDelegate ArgumentException_InjectedDelegateField = IL2CPP.ResolveICall<ArgumentException_InjectedDelegate>("UnityEngine.ExceptionTypeTests::ArgumentException_Injected");

	private static readonly InvalidOperationException_InjectedDelegate InvalidOperationException_InjectedDelegateField = IL2CPP.ResolveICall<InvalidOperationException_InjectedDelegate>("UnityEngine.ExceptionTypeTests::InvalidOperationException_Injected");

	private static readonly IndexOutOfRangeException_InjectedDelegate IndexOutOfRangeException_InjectedDelegateField = IL2CPP.ResolveICall<IndexOutOfRangeException_InjectedDelegate>("UnityEngine.ExceptionTypeTests::IndexOutOfRangeException_Injected");

	public unsafe static void NullReferenceException(string nativeFormat, string values)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper nativeFormat2;
			ReadOnlySpan<char> readOnlySpan2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(nativeFormat, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = nativeFormat.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					nativeFormat2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(values, ref managedSpanWrapper2))
					{
						readOnlySpan2 = values.AsSpan();
						fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							NullReferenceException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
							return;
						}
					}
					NullReferenceException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
					return;
				}
			}
			nativeFormat2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(values, ref managedSpanWrapper2))
			{
				readOnlySpan2 = values.AsSpan();
				fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					NullReferenceException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
					return;
				}
			}
			NullReferenceException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static void ArgumentNullException(string argumentName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(argumentName, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = argumentName.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					ArgumentNullException_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ArgumentNullException_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void ArgumentException(string nativeFormat, string values)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper nativeFormat2;
			ReadOnlySpan<char> readOnlySpan2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(nativeFormat, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = nativeFormat.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					nativeFormat2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(values, ref managedSpanWrapper2))
					{
						readOnlySpan2 = values.AsSpan();
						fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							ArgumentException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
							return;
						}
					}
					ArgumentException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
					return;
				}
			}
			nativeFormat2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(values, ref managedSpanWrapper2))
			{
				readOnlySpan2 = values.AsSpan();
				fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					ArgumentException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
					return;
				}
			}
			ArgumentException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static void InvalidOperationException(string nativeFormat, string values)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper nativeFormat2;
			ReadOnlySpan<char> readOnlySpan2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(nativeFormat, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = nativeFormat.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					nativeFormat2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(values, ref managedSpanWrapper2))
					{
						readOnlySpan2 = values.AsSpan();
						fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							InvalidOperationException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
							return;
						}
					}
					InvalidOperationException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
					return;
				}
			}
			nativeFormat2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(values, ref managedSpanWrapper2))
			{
				readOnlySpan2 = values.AsSpan();
				fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					InvalidOperationException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
					return;
				}
			}
			InvalidOperationException_Injected(ref nativeFormat2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static void IndexOutOfRangeException(string nativeFormat, int index)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(nativeFormat, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = nativeFormat.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					IndexOutOfRangeException_Injected(ref managedSpanWrapper, index);
					return;
				}
			}
			IndexOutOfRangeException_Injected(ref managedSpanWrapper, index);
		}
		finally
		{
		}
	}

	public unsafe static void NullReferenceException_Injected(ref ManagedSpanWrapper nativeFormat, ref ManagedSpanWrapper values)
	{
		NullReferenceException_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nativeFormat), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref values));
	}

	public unsafe static void ArgumentNullException_Injected(ref ManagedSpanWrapper argumentName)
	{
		ArgumentNullException_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref argumentName));
	}

	public unsafe static void ArgumentException_Injected(ref ManagedSpanWrapper nativeFormat, ref ManagedSpanWrapper values)
	{
		ArgumentException_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nativeFormat), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref values));
	}

	public unsafe static void InvalidOperationException_Injected(ref ManagedSpanWrapper nativeFormat, ref ManagedSpanWrapper values)
	{
		InvalidOperationException_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nativeFormat), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref values));
	}

	public unsafe static void IndexOutOfRangeException_Injected(ref ManagedSpanWrapper nativeFormat, int index)
	{
		IndexOutOfRangeException_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref nativeFormat), index);
	}
}
