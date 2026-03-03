using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.CrashReportHandler;

public class CrashReportHandler
{
	private delegate bool get_enableCaptureExceptionsDelegate();

	private delegate void set_enableCaptureExceptionsDelegate(bool value);

	private delegate uint get_logBufferSizeDelegate();

	private delegate void set_logBufferSizeDelegate(uint value);

	private delegate void get_installationIdentifier_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_installationIdentifier_InjectedDelegate(System.IntPtr value);

	private delegate void GetUserMetadata_InjectedDelegate(System.IntPtr key, [Out] System.IntPtr ret);

	private delegate void SetUserMetadata_InjectedDelegate(System.IntPtr key, System.IntPtr value);

	private static readonly get_enableCaptureExceptionsDelegate get_enableCaptureExceptionsDelegateField = IL2CPP.ResolveICall<get_enableCaptureExceptionsDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::get_enableCaptureExceptions");

	private static readonly set_enableCaptureExceptionsDelegate set_enableCaptureExceptionsDelegateField = IL2CPP.ResolveICall<set_enableCaptureExceptionsDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::set_enableCaptureExceptions");

	private static readonly get_logBufferSizeDelegate get_logBufferSizeDelegateField = IL2CPP.ResolveICall<get_logBufferSizeDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::get_logBufferSize");

	private static readonly set_logBufferSizeDelegate set_logBufferSizeDelegateField = IL2CPP.ResolveICall<set_logBufferSizeDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::set_logBufferSize");

	private static readonly get_installationIdentifier_InjectedDelegate get_installationIdentifier_InjectedDelegateField = IL2CPP.ResolveICall<get_installationIdentifier_InjectedDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::get_installationIdentifier_Injected");

	private static readonly set_installationIdentifier_InjectedDelegate set_installationIdentifier_InjectedDelegateField = IL2CPP.ResolveICall<set_installationIdentifier_InjectedDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::set_installationIdentifier_Injected");

	private static readonly GetUserMetadata_InjectedDelegate GetUserMetadata_InjectedDelegateField = IL2CPP.ResolveICall<GetUserMetadata_InjectedDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::GetUserMetadata_Injected");

	private static readonly SetUserMetadata_InjectedDelegate SetUserMetadata_InjectedDelegateField = IL2CPP.ResolveICall<SetUserMetadata_InjectedDelegate>("UnityEngine.CrashReportHandler.CrashReportHandler::SetUserMetadata_Injected");

	public static bool enableCaptureExceptions
	{
		get
		{
			return get_enableCaptureExceptionsDelegateField();
		}
		set
		{
			set_enableCaptureExceptionsDelegateField(value);
		}
	}

	public static uint logBufferSize
	{
		get
		{
			return get_logBufferSizeDelegateField();
		}
		set
		{
			set_logBufferSizeDelegateField(value);
		}
	}

	public unsafe static string installationIdentifier
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_installationIdentifier_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_0024: Expected O, but got Ref
			//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					ReadOnlySpan<char> readOnlySpan = value.AsSpan();
					fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_installationIdentifier_Injected(ref managedSpanWrapper);
						return;
					}
				}
				set_installationIdentifier_Injected(ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public unsafe static string GetUserMetadata(string key)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = key.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetUserMetadata_Injected(ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetUserMetadata_Injected(ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void SetUserMetadata(string key, string value)
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
			ref ManagedSpanWrapper key2;
			ReadOnlySpan<char> readOnlySpan2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = key.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					key2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
					{
						readOnlySpan2 = value.AsSpan();
						fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							SetUserMetadata_Injected(ref key2, ref managedSpanWrapper2);
							return;
						}
					}
					SetUserMetadata_Injected(ref key2, ref managedSpanWrapper2);
					return;
				}
			}
			key2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
			{
				readOnlySpan2 = value.AsSpan();
				fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					SetUserMetadata_Injected(ref key2, ref managedSpanWrapper2);
					return;
				}
			}
			SetUserMetadata_Injected(ref key2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static void get_installationIdentifier_Injected(out ManagedSpanWrapper ret)
	{
		get_installationIdentifier_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_installationIdentifier_Injected(ref ManagedSpanWrapper value)
	{
		set_installationIdentifier_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public unsafe static void GetUserMetadata_Injected(ref ManagedSpanWrapper key, out ManagedSpanWrapper ret)
	{
		GetUserMetadata_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref key), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetUserMetadata_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper value)
	{
		SetUserMetadata_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref key), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}
}
