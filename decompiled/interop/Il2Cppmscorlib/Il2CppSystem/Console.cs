using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem;

public static class Console : Object
{
	public class WindowsConsole : Object
	{
		public sealed class WindowsCancelHandler : MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0;

			static WindowsCancelHandler()
			{
				Il2CppClassPointerStore<WindowsCancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr, "WindowsCancelHandler");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsCancelHandler>.NativeClassPtr, 100667074);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsCancelHandler>.NativeClassPtr, 100667075);
			}

			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 218067, RefRangeEnd = 218104, XrefRangeStart = 218067, XrefRangeEnd = 218104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WindowsCancelHandler(Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsCancelHandler>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual bool Invoke(int keyCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&keyCode);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public WindowsCancelHandler(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public static implicit operator WindowsCancelHandler(System.Func<int, bool> P_0)
			{
				return DelegateSupport.ConvertDelegate<WindowsCancelHandler>((System.Delegate)P_0);
			}

			public static WindowsCancelHandler operator +(WindowsCancelHandler P_0, WindowsCancelHandler P_1)
			{
				return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<WindowsCancelHandler>();
			}

			public static WindowsCancelHandler operator -(WindowsCancelHandler P_0, WindowsCancelHandler P_1)
			{
				object obj = Delegate.Remove(P_0, P_1);
				if (obj != null)
				{
					obj = ((Il2CppObjectBase)obj).Cast<WindowsCancelHandler>();
				}
				return (WindowsCancelHandler)obj;
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_ctrlHandlerAdded;

		private static readonly System.IntPtr NativeFieldInfoPtr_cancelHandler;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0;

		public unsafe static bool ctrlHandlerAdded
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ctrlHandlerAdded, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ctrlHandlerAdded, (void*)(&value));
			}
		}

		public unsafe static WindowsCancelHandler cancelHandler
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cancelHandler, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WindowsCancelHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cancelHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static WindowsConsole()
		{
			Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "WindowsConsole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr);
			NativeFieldInfoPtr_ctrlHandlerAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr, "ctrlHandlerAdded");
			NativeFieldInfoPtr_cancelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr, "cancelHandler");
			NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr, 100667068);
			NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr, 100667069);
			NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr, 100667070);
			NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr, 100667071);
			NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsole>.NativeClassPtr, 100667072);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759788, XrefRangeEnd = 759790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetConsoleCP()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759790, XrefRangeEnd = 759792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetConsoleOutputCP()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759792, XrefRangeEnd = 759796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoWindowsConsoleCancelEvent(int keyCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&keyCode);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759801, RefRangeEnd = 759802, XrefRangeStart = 759796, XrefRangeEnd = 759801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInputCodePage()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759807, RefRangeEnd = 759808, XrefRangeStart = 759802, XrefRangeEnd = 759807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetOutputCodePage()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public WindowsConsole(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_stdout;

	private static readonly System.IntPtr NativeFieldInfoPtr_stderr;

	private static readonly System.IntPtr NativeFieldInfoPtr_stdin;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsRunningOnAndroid;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputEncoding;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputEncoding;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancel_event;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetError_Public_Static_Void_TextWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoConsoleCancelEvent_Private_Static_Void_0;

	public unsafe static TextWriter stdout
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stdout, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stdout, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TextWriter stderr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stderr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stderr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TextReader stdin
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stdin, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stdin, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool IsRunningOnAndroid
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsRunningOnAndroid, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsRunningOnAndroid, (void*)(&value));
		}
	}

	public unsafe static Encoding inputEncoding
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputEncoding, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputEncoding, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Encoding outputEncoding
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_outputEncoding, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_outputEncoding, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ConsoleCancelEventHandler cancel_event
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cancel_event, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConsoleCancelEventHandler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cancel_event, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TextWriter Error
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759887, XrefRangeEnd = 759891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
		}
	}

	public unsafe static Encoding InputEncoding
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760025, XrefRangeEnd = 760029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
		}
	}

	public unsafe static Encoding OutputEncoding
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760029, XrefRangeEnd = 760033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
		}
	}

	static Console()
	{
		Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Console");
		NativeFieldInfoPtr_stdout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stdout");
		NativeFieldInfoPtr_stderr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stderr");
		NativeFieldInfoPtr_stdin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stdin");
		NativeFieldInfoPtr_IsRunningOnAndroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "IsRunningOnAndroid");
		NativeFieldInfoPtr_inputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "inputEncoding");
		NativeFieldInfoPtr_outputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "outputEncoding");
		NativeFieldInfoPtr_cancel_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "cancel_event");
		NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667054);
		NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667055);
		NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667056);
		NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667057);
		NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667058);
		NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667059);
		NativeMethodInfoPtr_SetError_Public_Static_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667060);
		NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667061);
		NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667062);
		NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667063);
		NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667064);
		NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667065);
		NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667066);
		NativeMethodInfoPtr_DoConsoleCancelEvent_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667067);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759886, RefRangeEnd = 759887, XrefRangeStart = 759808, XrefRangeEnd = 759886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputEncoding);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputEncoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 759903, RefRangeEnd = 759906, XrefRangeStart = 759891, XrefRangeEnd = 759903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Stream Open(System.IntPtr handle, FileAccess access, int bufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(FileAccess**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &access;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 759914, RefRangeEnd = 759916, XrefRangeStart = 759906, XrefRangeEnd = 759914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Stream OpenStandardError(int bufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bufferSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 759924, RefRangeEnd = 759927, XrefRangeStart = 759916, XrefRangeEnd = 759924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Stream OpenStandardInput(int bufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bufferSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 759935, RefRangeEnd = 759937, XrefRangeStart = 759927, XrefRangeEnd = 759935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Stream OpenStandardOutput(int bufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bufferSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759953, RefRangeEnd = 759954, XrefRangeStart = 759937, XrefRangeEnd = 759953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetError(TextWriter newError)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newError);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetError_Public_Static_Void_TextWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759970, RefRangeEnd = 759971, XrefRangeStart = 759954, XrefRangeEnd = 759970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetOut(TextWriter newOut)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newOut);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 760024, RefRangeEnd = 760025, XrefRangeStart = 759971, XrefRangeEnd = 760024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteLine(string format, Object arg0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 760046, RefRangeEnd = 760047, XrefRangeStart = 760033, XrefRangeEnd = 760046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ConsoleKeyInfo ReadKey()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ConsoleKeyInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760047, XrefRangeEnd = 760057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ConsoleKeyInfo ReadKey(bool intercept)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intercept);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ConsoleKeyInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 760073, RefRangeEnd = 760074, XrefRangeStart = 760057, XrefRangeEnd = 760073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoConsoleCancelEvent()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoConsoleCancelEvent_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Console(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
