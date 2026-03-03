using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Unity;

public static class UnityTls : Il2CppSystem.Object
{
	[OriginalName("System.dll", "", "unitytls_error_code")]
	public enum unitytls_error_code : uint
	{
		UNITYTLS_SUCCESS = 0u,
		UNITYTLS_INVALID_ARGUMENT = 1u,
		UNITYTLS_INVALID_FORMAT = 2u,
		UNITYTLS_INVALID_PASSWORD = 3u,
		UNITYTLS_INVALID_STATE = 4u,
		UNITYTLS_BUFFER_OVERFLOW = 5u,
		UNITYTLS_OUT_OF_MEMORY = 6u,
		UNITYTLS_INTERNAL_ERROR = 7u,
		UNITYTLS_NOT_SUPPORTED = 8u,
		UNITYTLS_ENTROPY_SOURCE_FAILED = 9u,
		UNITYTLS_STREAM_CLOSED = 10u,
		UNITYTLS_DER_PARSE_ERROR = 11u,
		UNITYTLS_KEY_PARSE_ERROR = 12u,
		UNITYTLS_SSL_ERROR = 13u,
		UNITYTLS_USER_CUSTOM_ERROR_START = 1048576u,
		UNITYTLS_USER_WOULD_BLOCK = 1048577u,
		UNITYTLS_USER_WOULD_BLOCK_READ = 1048578u,
		UNITYTLS_USER_WOULD_BLOCK_WRITE = 1048579u,
		UNITYTLS_USER_READ_FAILED = 1048580u,
		UNITYTLS_USER_WRITE_FAILED = 1048581u,
		UNITYTLS_USER_UNKNOWN_ERROR = 1048582u,
		UNITYTLS_SSL_NEEDS_VERIFY = 1048583u,
		UNITYTLS_HANDSHAKE_STEP = 1048584u,
		UNITYTLS_USER_CUSTOM_ERROR_END = 2097152u
	}

	[OriginalName("System.dll", "", "unitytls_log_level")]
	public enum unitytls_log_level : uint
	{
		UNITYTLS_LOGLEVEL_MIN = 0u,
		UNITYTLS_LOGLEVEL_FATAL = 0u,
		UNITYTLS_LOGLEVEL_ERROR = 1u,
		UNITYTLS_LOGLEVEL_WARN = 2u,
		UNITYTLS_LOGLEVEL_INFO = 3u,
		UNITYTLS_LOGLEVEL_DEBUG = 4u,
		UNITYTLS_LOGLEVEL_TRACE = 5u,
		UNITYTLS_LOGLEVEL_MAX = 5u
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_errorstate
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_magic;

		private static readonly System.IntPtr NativeFieldInfoPtr_code;

		private static readonly System.IntPtr NativeFieldInfoPtr_reserved;

		[FieldOffset(0)]
		public uint magic;

		[FieldOffset(4)]
		public unitytls_error_code code;

		[FieldOffset(8)]
		public ulong reserved;

		static unitytls_errorstate()
		{
			Il2CppClassPointerStore<unitytls_errorstate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_errorstate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_errorstate>.NativeClassPtr);
			NativeFieldInfoPtr_magic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_errorstate>.NativeClassPtr, "magic");
			NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_errorstate>.NativeClassPtr, "code");
			NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_errorstate>.NativeClassPtr, "reserved");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_errorstate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_key
	{
		static unitytls_key()
		{
			Il2CppClassPointerStore<unitytls_key>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_key");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_key>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_key>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_key_ref
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handle;

		[FieldOffset(0)]
		public ulong handle;

		static unitytls_key_ref()
		{
			Il2CppClassPointerStore<unitytls_key_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_key_ref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_key_ref>.NativeClassPtr);
			NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_key_ref>.NativeClassPtr, "handle");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_key_ref>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_x509_ref
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handle;

		[FieldOffset(0)]
		public ulong handle;

		static unitytls_x509_ref()
		{
			Il2CppClassPointerStore<unitytls_x509_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509_ref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_x509_ref>.NativeClassPtr);
			NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_x509_ref>.NativeClassPtr, "handle");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_x509_ref>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_x509list
	{
		static unitytls_x509list()
		{
			Il2CppClassPointerStore<unitytls_x509list>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509list");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_x509list>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_x509list>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_x509list_ref
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handle;

		[FieldOffset(0)]
		public ulong handle;

		static unitytls_x509list_ref()
		{
			Il2CppClassPointerStore<unitytls_x509list_ref>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509list_ref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_x509list_ref>.NativeClassPtr);
			NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_x509list_ref>.NativeClassPtr, "handle");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_x509list_ref>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[OriginalName("System.dll", "", "unitytls_x509verify_result")]
	[System.Flags]
	public enum unitytls_x509verify_result : uint
	{
		UNITYTLS_X509VERIFY_SUCCESS = 0u,
		UNITYTLS_X509VERIFY_NOT_DONE = 0x80000000u,
		UNITYTLS_X509VERIFY_FATAL_ERROR = uint.MaxValue,
		UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1u,
		UNITYTLS_X509VERIFY_FLAG_REVOKED = 2u,
		UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4u,
		UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8u,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_NOT_TRUSTED = 0x10u,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_EXPIRED = 0x20u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_MISSING = 0x40u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_SKIP_VERIFY = 0x80u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_OTHER = 0x100u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_FUTURE = 0x200u,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_FUTURE = 0x400u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_KEY_USAGE = 0x800u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_EXT_KEY_USAGE = 0x1000u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_NS_CERT_TYPE = 0x2000u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_MD = 0x4000u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_PK = 0x8000u,
		UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_KEY = 0x10000u,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_MD = 0x20000u,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_PK = 0x40000u,
		UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_KEY = 0x80000u,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 0x10000u,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 0x20000u,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 0x40000u,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 0x80000u,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 0x100000u,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 0x200000u,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 0x400000u,
		UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 0x800000u,
		UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 0x8000000u
	}

	public sealed class unitytls_x509verify_callback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0;

		static unitytls_x509verify_callback()
		{
			Il2CppClassPointerStore<unitytls_x509verify_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509verify_callback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509verify_callback>.NativeClassPtr, 100663338);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509verify_callback>.NativeClassPtr, 100663339);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 862516, RefRangeEnd = 862518, XrefRangeStart = 862512, XrefRangeEnd = 862516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe unitytls_x509verify_callback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509verify_callback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual unitytls_x509verify_result Invoke(void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)userData;
			*(unitytls_x509_ref**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cert;
			*(unitytls_x509verify_result**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
			*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509_ref_unitytls_x509verify_result_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(unitytls_x509verify_result*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unitytls_x509verify_callback(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_tlsctx
	{
		static unitytls_tlsctx()
		{
			Il2CppClassPointerStore<unitytls_tlsctx>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_tlsctx>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_tlsctx>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_x509name
	{
		static unitytls_x509name()
		{
			Il2CppClassPointerStore<unitytls_x509name>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_x509name");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_x509name>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_x509name>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[OriginalName("System.dll", "", "unitytls_ciphersuite")]
	public enum unitytls_ciphersuite : uint
	{
		UNITYTLS_CIPHERSUITE_INVALID = 16777215u
	}

	[OriginalName("System.dll", "", "unitytls_protocol")]
	public enum unitytls_protocol : uint
	{
		UNITYTLS_PROTOCOL_TLS_1_0,
		UNITYTLS_PROTOCOL_TLS_1_1,
		UNITYTLS_PROTOCOL_TLS_1_2,
		UNITYTLS_PROTOCOL_INVALID
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct unitytls_tlsctx_protocolrange
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_min;

		private static readonly System.IntPtr NativeFieldInfoPtr_max;

		[FieldOffset(0)]
		public unitytls_protocol min;

		[FieldOffset(4)]
		public unitytls_protocol max;

		static unitytls_tlsctx_protocolrange()
		{
			Il2CppClassPointerStore<unitytls_tlsctx_protocolrange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_protocolrange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_tlsctx_protocolrange>.NativeClassPtr);
			NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_tlsctx_protocolrange>.NativeClassPtr, "min");
			NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_tlsctx_protocolrange>.NativeClassPtr, "max");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<unitytls_tlsctx_protocolrange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class unitytls_tlsctx_write_callback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		static unitytls_tlsctx_write_callback()
		{
			Il2CppClassPointerStore<unitytls_tlsctx_write_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_write_callback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_write_callback>.NativeClassPtr, 100663340);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_write_callback>.NativeClassPtr, 100663341);
		}

		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 128953, RefRangeEnd = 128971, XrefRangeStart = 128953, XrefRangeEnd = 128971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe unitytls_tlsctx_write_callback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_write_callback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual System.IntPtr Invoke(void* userData, byte* data, System.IntPtr bufferLen, unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)userData;
			*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = data;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
			*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unitytls_tlsctx_write_callback(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class unitytls_tlsctx_read_callback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

		static unitytls_tlsctx_read_callback()
		{
			Il2CppClassPointerStore<unitytls_tlsctx_read_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_read_callback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_read_callback>.NativeClassPtr, 100663342);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_read_callback>.NativeClassPtr, 100663343);
		}

		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 128953, RefRangeEnd = 128971, XrefRangeStart = 128953, XrefRangeEnd = 128971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe unitytls_tlsctx_read_callback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_read_callback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual System.IntPtr Invoke(void* userData, byte* buffer, System.IntPtr bufferLen, unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)userData;
			*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
			*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unitytls_tlsctx_read_callback(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class unitytls_tlsctx_trace_callback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0;

		static unitytls_tlsctx_trace_callback()
		{
			Il2CppClassPointerStore<unitytls_tlsctx_trace_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_trace_callback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663344);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_trace_callback>.NativeClassPtr, 100663345);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862518, XrefRangeEnd = 862522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe unitytls_tlsctx_trace_callback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_trace_callback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(void* userData, unitytls_tlsctx* ctx, byte* traceMessage, System.IntPtr traceMessageLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)userData;
			*(unitytls_tlsctx**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ctx;
			*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = traceMessage;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &traceMessageLen;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unitytls_tlsctx_trace_callback(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class unitytls_tlsctx_certificate_callback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0;

		static unitytls_tlsctx_certificate_callback()
		{
			Il2CppClassPointerStore<unitytls_tlsctx_certificate_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_certificate_callback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663346);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_certificate_callback>.NativeClassPtr, 100663347);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862522, XrefRangeEnd = 862526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe unitytls_tlsctx_certificate_callback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_certificate_callback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(void* userData, unitytls_tlsctx* ctx, byte* cn, System.IntPtr cnLen, unitytls_x509name* caList, System.IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[9];
			*ptr = (nint)userData;
			*(unitytls_tlsctx**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ctx;
			*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = cn;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cnLen;
			*(unitytls_x509name**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = caList;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &caListLen;
			*(unitytls_x509list_ref**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = chain;
			*(unitytls_key_ref**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = key;
			*(unitytls_errorstate**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Void_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_x509name_IntPtr_ptr_unitytls_x509list_ref_ptr_unitytls_key_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unitytls_tlsctx_certificate_callback(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class unitytls_tlsctx_x509verify_callback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0;

		static unitytls_tlsctx_x509verify_callback()
		{
			Il2CppClassPointerStore<unitytls_tlsctx_x509verify_callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_x509verify_callback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663348);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_x509verify_callback>.NativeClassPtr, 100663349);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862526, XrefRangeEnd = 862530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe unitytls_tlsctx_x509verify_callback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_x509verify_callback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual unitytls_x509verify_result Invoke(void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)userData;
			*(unitytls_x509list_ref**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chain;
			*(unitytls_errorstate**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_Void_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(unitytls_x509verify_result*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unitytls_tlsctx_x509verify_callback(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class unitytls_tlsctx_callbacks : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_read;

		private static readonly System.IntPtr NativeFieldInfoPtr_write;

		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		public unsafe unitytls_tlsctx_read_callback read
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_read);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_read_callback>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_read)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_write_callback write
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_write);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_write_callback>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_write)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe void* data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				return *(void**)num;
			}
			set
			{
				*(void**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)) = value;
			}
		}

		static unitytls_tlsctx_callbacks()
		{
			Il2CppClassPointerStore<unitytls_tlsctx_callbacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_tlsctx_callbacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_tlsctx_callbacks>.NativeClassPtr);
			NativeFieldInfoPtr_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_tlsctx_callbacks>.NativeClassPtr, "read");
			NativeFieldInfoPtr_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_tlsctx_callbacks>.NativeClassPtr, "write");
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_tlsctx_callbacks>.NativeClassPtr, "data");
		}

		public unitytls_tlsctx_callbacks(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public unitytls_tlsctx_callbacks()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_callbacks>.NativeClassPtr))
		{
		}
	}

	public class unitytls_interface_struct : Il2CppSystem.Object
	{
		public sealed class unitytls_errorstate_create_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0;

			static unitytls_errorstate_create_t()
			{
				Il2CppClassPointerStore<unitytls_errorstate_create_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_create_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_errorstate_create_t>.NativeClassPtr, 100663351);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_errorstate_create_t>.NativeClassPtr, 100663352);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 862533, RefRangeEnd = 862536, XrefRangeStart = 862530, XrefRangeEnd = 862533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_errorstate_create_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_errorstate_create_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_errorstate Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_errorstate*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_errorstate_create_t(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public static implicit operator unitytls_errorstate_create_t(System.Func<unitytls_errorstate> P_0)
			{
				return DelegateSupport.ConvertDelegate<unitytls_errorstate_create_t>((System.Delegate)P_0);
			}

			public static unitytls_errorstate_create_t operator +(unitytls_errorstate_create_t P_0, unitytls_errorstate_create_t P_1)
			{
				return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<unitytls_errorstate_create_t>();
			}

			public static unitytls_errorstate_create_t operator -(unitytls_errorstate_create_t P_0, unitytls_errorstate_create_t P_1)
			{
				object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
				if (obj != null)
				{
					obj = ((Il2CppObjectBase)obj).Cast<unitytls_errorstate_create_t>();
				}
				return (unitytls_errorstate_create_t)obj;
			}
		}

		public sealed class unitytls_errorstate_raise_error_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0;

			static unitytls_errorstate_raise_error_t()
			{
				Il2CppClassPointerStore<unitytls_errorstate_raise_error_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_raise_error_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663353);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_errorstate_raise_error_t>.NativeClassPtr, 100663354);
			}

			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 576610, RefRangeEnd = 576618, XrefRangeStart = 576610, XrefRangeEnd = 576618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_errorstate_raise_error_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_errorstate_raise_error_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)errorState;
				*(unitytls_error_code**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &errorCode;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_errorstate_unitytls_error_code_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_errorstate_raise_error_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_key_get_ref_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0;

			static unitytls_key_get_ref_t()
			{
				Il2CppClassPointerStore<unitytls_key_get_ref_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_key_get_ref_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_key_get_ref_t>.NativeClassPtr, 100663355);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_key_get_ref_t>.NativeClassPtr, 100663356);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862536, XrefRangeEnd = 862540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_key_get_ref_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_key_get_ref_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)key;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_key_ref_ptr_unitytls_key_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_key_ref*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_key_get_ref_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_key_parse_der_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_key_parse_der_t()
			{
				Il2CppClassPointerStore<unitytls_key_parse_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_der_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_key_parse_der_t>.NativeClassPtr, 100663357);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_key_parse_der_t>.NativeClassPtr, 100663358);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862540, XrefRangeEnd = 862544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_key_parse_der_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_key_parse_der_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_key* Invoke(byte* buffer, System.IntPtr bufferLen, byte* password, System.IntPtr passwordLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[5];
				*ptr = (nint)buffer;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
				*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = password;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &passwordLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (unitytls_key*)result;
			}

			public unitytls_key_parse_der_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_key_parse_pem_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_key_parse_pem_t()
			{
				Il2CppClassPointerStore<unitytls_key_parse_pem_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_pem_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_key_parse_pem_t>.NativeClassPtr, 100663359);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_key_parse_pem_t>.NativeClassPtr, 100663360);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_key_parse_pem_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_key_parse_pem_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_key* Invoke(byte* buffer, System.IntPtr bufferLen, byte* password, System.IntPtr passwordLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[5];
				*ptr = (nint)buffer;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
				*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = password;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &passwordLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_key_ptr_Byte_IntPtr_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (unitytls_key*)result;
			}

			public unitytls_key_parse_pem_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_key_free_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0;

			static unitytls_key_free_t()
			{
				Il2CppClassPointerStore<unitytls_key_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_key_free_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_key_free_t>.NativeClassPtr, 100663361);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_key_free_t>.NativeClassPtr, 100663362);
			}

			[CallerCount(245)]
			[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_key_free_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_key_free_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_key* key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)key;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_key_free_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509_export_der_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_x509_export_der_t()
			{
				Il2CppClassPointerStore<unitytls_x509_export_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509_export_der_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509_export_der_t>.NativeClassPtr, 100663363);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509_export_der_t>.NativeClassPtr, 100663364);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862544, XrefRangeEnd = 862547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509_export_der_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509_export_der_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual System.IntPtr Invoke(unitytls_x509_ref cert, byte* buffer, System.IntPtr bufferLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = (nint)(&cert);
				*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_unitytls_x509_ref_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_x509_export_der_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509list_get_ref_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0;

			static unitytls_x509list_get_ref_t()
			{
				Il2CppClassPointerStore<unitytls_x509list_get_ref_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_ref_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_get_ref_t>.NativeClassPtr, 100663365);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_get_ref_t>.NativeClassPtr, 100663366);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509list_get_ref_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509list_get_ref_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)list;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509list_ref_ptr_unitytls_x509list_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_x509list_ref*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_x509list_get_ref_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509list_get_x509_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_x509list_get_x509_t()
			{
				Il2CppClassPointerStore<unitytls_x509list_get_x509_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_x509_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_get_x509_t>.NativeClassPtr, 100663367);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_get_x509_t>.NativeClassPtr, 100663368);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862547, XrefRangeEnd = 862550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509list_get_x509_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509list_get_x509_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_x509_ref Invoke(unitytls_x509list_ref list, System.IntPtr index, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[3];
				*ptr = (nint)(&list);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509_ref_unitytls_x509list_ref_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_x509_ref*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_x509list_get_x509_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509list_create_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0;

			static unitytls_x509list_create_t()
			{
				Il2CppClassPointerStore<unitytls_x509list_create_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_create_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_create_t>.NativeClassPtr, 100663369);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_create_t>.NativeClassPtr, 100663370);
			}

			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 862554, RefRangeEnd = 862560, XrefRangeStart = 862550, XrefRangeEnd = 862554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509list_create_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509list_create_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_x509list* Invoke(unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_x509list_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (unitytls_x509list*)result;
			}

			public unitytls_x509list_create_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509list_append_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0;

			static unitytls_x509list_append_t()
			{
				Il2CppClassPointerStore<unitytls_x509list_append_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_append_t>.NativeClassPtr, 100663371);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_append_t>.NativeClassPtr, 100663372);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862560, XrefRangeEnd = 862564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509list_append_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509list_append_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[3];
				*ptr = (nint)list;
				*(unitytls_x509_ref**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cert;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_unitytls_x509_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_x509list_append_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509list_append_der_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_x509list_append_der_t()
			{
				Il2CppClassPointerStore<unitytls_x509list_append_der_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_der_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_append_der_t>.NativeClassPtr, 100663373);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_append_der_t>.NativeClassPtr, 100663374);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509list_append_der_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509list_append_der_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_x509list* list, byte* buffer, System.IntPtr bufferLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = (nint)list;
				*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_x509list_append_der_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509list_free_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0;

			static unitytls_x509list_free_t()
			{
				Il2CppClassPointerStore<unitytls_x509list_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_free_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_free_t>.NativeClassPtr, 100663375);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509list_free_t>.NativeClassPtr, 100663376);
			}

			[CallerCount(245)]
			[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509list_free_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509list_free_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_x509list* list)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)list;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_x509list_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_x509list_free_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509verify_default_ca_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;

			static unitytls_x509verify_default_ca_t()
			{
				Il2CppClassPointerStore<unitytls_x509verify_default_ca_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_default_ca_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663377);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509verify_default_ca_t>.NativeClassPtr, 100663378);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862564, XrefRangeEnd = 862567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509verify_default_ca_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509verify_default_ca_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, byte* cn, System.IntPtr cnLen, unitytls_x509verify_callback cb, void* userData, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[6];
				*ptr = (nint)(&chain);
				*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = cn;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cnLen;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cb);
				*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = userData;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_x509verify_result*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_x509verify_default_ca_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509verify_explicit_ca_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;

			static unitytls_x509verify_explicit_ca_t()
			{
				Il2CppClassPointerStore<unitytls_x509verify_explicit_ca_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_explicit_ca_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663379);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509verify_explicit_ca_t>.NativeClassPtr, 100663380);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862567, XrefRangeEnd = 862570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509verify_explicit_ca_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509verify_explicit_ca_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, byte* cn, System.IntPtr cnLen, unitytls_x509verify_callback cb, void* userData, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[7];
				*ptr = (nint)(&chain);
				*(unitytls_x509list_ref**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trustCA;
				*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = cn;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cnLen;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cb);
				*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = userData;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_unitytls_x509list_ref_unitytls_x509list_ref_ptr_Byte_IntPtr_unitytls_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_x509verify_result*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_x509verify_explicit_ca_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_create_server_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_create_server_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_create_server_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_server_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663381);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_create_server_t>.NativeClassPtr, 100663382);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862570, XrefRangeEnd = 862573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_create_server_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_create_server_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[5];
				*ptr = (nint)(&supportedProtocols);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)callbacks));
				*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &certChain;
				*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &leafCertificateKey;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_UInt64_UInt64_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (unitytls_tlsctx*)result;
			}

			public unitytls_tlsctx_create_server_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_create_client_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_create_client_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_create_client_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_client_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663383);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_create_client_t>.NativeClassPtr, 100663384);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_create_client_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_create_client_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, byte* cn, System.IntPtr cnLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[5];
				*ptr = (nint)(&supportedProtocols);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)callbacks));
				*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = cn;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cnLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_unitytls_tlsctx_unitytls_tlsctx_protocolrange_unitytls_tlsctx_callbacks_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (unitytls_tlsctx*)result;
			}

			public unitytls_tlsctx_create_client_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_server_require_client_authentication_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_server_require_client_authentication_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_server_require_client_authentication_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663385);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr, 100663386);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_server_require_client_authentication_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_server_require_client_authentication_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[3];
				*ptr = (nint)ctx;
				*(unitytls_x509list_ref**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clientAuthCAList;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_x509list_ref_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_tlsctx_server_require_client_authentication_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_set_certificate_callback_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_set_certificate_callback_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_certificate_callback_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663387);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr, 100663388);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_set_certificate_callback_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_set_certificate_callback_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, void* userData, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = (nint)ctx;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cb);
				*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = userData;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_certificate_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_tlsctx_set_certificate_callback_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_set_trace_callback_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_set_trace_callback_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_callback_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663389);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr, 100663390);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_set_trace_callback_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_set_trace_callback_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, void* userData, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = (nint)ctx;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cb);
				*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = userData;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_trace_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_tlsctx_set_trace_callback_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_set_x509verify_callback_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_set_x509verify_callback_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_x509verify_callback_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663391);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr, 100663392);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_set_x509verify_callback_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_set_x509verify_callback_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, void* userData, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = (nint)ctx;
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cb);
				*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = userData;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_tlsctx_x509verify_callback_ptr_Void_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_tlsctx_set_x509verify_callback_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_set_supported_ciphersuites_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_set_supported_ciphersuites_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_supported_ciphersuites_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663393);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr, 100663394);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_set_supported_ciphersuites_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_set_supported_ciphersuites_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, System.IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = (nint)ctx;
				*(unitytls_ciphersuite**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = supportedCiphersuites;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &supportedCiphersuitesLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_ciphersuite_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_tlsctx_set_supported_ciphersuites_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_get_ciphersuite_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_get_ciphersuite_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_ciphersuite_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663395);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr, 100663396);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862573, XrefRangeEnd = 862577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_get_ciphersuite_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_get_ciphersuite_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)ctx;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_ciphersuite_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_ciphersuite*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_tlsctx_get_ciphersuite_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_get_protocol_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_get_protocol_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_get_protocol_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_protocol_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663397);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_get_protocol_t>.NativeClassPtr, 100663398);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_get_protocol_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_get_protocol_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)ctx;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_protocol_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_protocol*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_tlsctx_get_protocol_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_process_handshake_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_process_handshake_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_process_handshake_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_process_handshake_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663399);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_process_handshake_t>.NativeClassPtr, 100663400);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_process_handshake_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_process_handshake_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)ctx;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_unitytls_x509verify_result_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(unitytls_x509verify_result*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_tlsctx_process_handshake_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_read_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_read_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_read_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_read_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_read_t>.NativeClassPtr, 100663401);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_read_t>.NativeClassPtr, 100663402);
			}

			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 128953, RefRangeEnd = 128971, XrefRangeStart = 128953, XrefRangeEnd = 128971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_read_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_read_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual System.IntPtr Invoke(unitytls_tlsctx* ctx, byte* buffer, System.IntPtr bufferLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = (nint)ctx;
				*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_tlsctx_read_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_write_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_write_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_write_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_write_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_write_t>.NativeClassPtr, 100663403);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_write_t>.NativeClassPtr, 100663404);
			}

			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 128953, RefRangeEnd = 128971, XrefRangeStart = 128953, XrefRangeEnd = 128971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_write_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_write_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual System.IntPtr Invoke(unitytls_tlsctx* ctx, byte* data, System.IntPtr bufferLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = (nint)ctx;
				*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = data;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_ptr_unitytls_tlsctx_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unitytls_tlsctx_write_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_notify_close_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0;

			static unitytls_tlsctx_notify_close_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_notify_close_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_notify_close_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663405);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_notify_close_t>.NativeClassPtr, 100663406);
			}

			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 862581, RefRangeEnd = 862587, XrefRangeStart = 862577, XrefRangeEnd = 862581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_notify_close_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_notify_close_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)ctx;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_tlsctx_notify_close_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_tlsctx_free_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0;

			static unitytls_tlsctx_free_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_free_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_free_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_free_t>.NativeClassPtr, 100663407);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_free_t>.NativeClassPtr, 100663408);
			}

			[CallerCount(245)]
			[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_free_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_free_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_tlsctx* ctx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)ctx;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_tlsctx_free_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_random_generate_bytes_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0;

			static unitytls_random_generate_bytes_t()
			{
				Il2CppClassPointerStore<unitytls_random_generate_bytes_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_random_generate_bytes_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_random_generate_bytes_t>.NativeClassPtr, 100663409);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_random_generate_bytes_t>.NativeClassPtr, 100663410);
			}

			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 852815, RefRangeEnd = 852819, XrefRangeStart = 852815, XrefRangeEnd = 852819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_random_generate_bytes_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_random_generate_bytes_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(byte* buffer, System.IntPtr bufferLen, unitytls_errorstate* errorState)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[3];
				*ptr = (nint)buffer;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLen;
				*(unitytls_errorstate**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = errorState;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_Byte_IntPtr_ptr_unitytls_errorstate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_random_generate_bytes_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class unitytls_x509verify_result_to_string_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_Char_unitytls_x509verify_result_0;

			static unitytls_x509verify_result_to_string_t()
			{
				Il2CppClassPointerStore<unitytls_x509verify_result_to_string_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_result_to_string_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509verify_result_to_string_t>.NativeClassPtr, 100663411);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_Char_unitytls_x509verify_result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_x509verify_result_to_string_t>.NativeClassPtr, 100663412);
			}

			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 804608, RefRangeEnd = 804619, XrefRangeStart = 804608, XrefRangeEnd = 804619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_x509verify_result_to_string_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_x509verify_result_to_string_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual char* Invoke(unitytls_x509verify_result v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&v);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_ptr_Char_unitytls_x509verify_result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (char*)result;
			}

			public unitytls_x509verify_result_to_string_t(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public unsafe static implicit operator unitytls_x509verify_result_to_string_t(System.Func<unitytls_x509verify_result, char*> P_0)
			{
				return DelegateSupport.ConvertDelegate<unitytls_x509verify_result_to_string_t>((System.Delegate)P_0);
			}

			public static unitytls_x509verify_result_to_string_t operator +(unitytls_x509verify_result_to_string_t P_0, unitytls_x509verify_result_to_string_t P_1)
			{
				return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<unitytls_x509verify_result_to_string_t>();
			}

			public static unitytls_x509verify_result_to_string_t operator -(unitytls_x509verify_result_to_string_t P_0, unitytls_x509verify_result_to_string_t P_1)
			{
				object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
				if (obj != null)
				{
					obj = ((Il2CppObjectBase)obj).Cast<unitytls_x509verify_result_to_string_t>();
				}
				return (unitytls_x509verify_result_to_string_t)obj;
			}
		}

		public sealed class unitytls_tlsctx_set_trace_level_t : Il2CppSystem.MulticastDelegate
		{
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_log_level_0;

			static unitytls_tlsctx_set_trace_level_t()
			{
				Il2CppClassPointerStore<unitytls_tlsctx_set_trace_level_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_level_t");
				NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_trace_level_t>.NativeClassPtr, 100663413);
				NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_log_level_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_tlsctx_set_trace_level_t>.NativeClassPtr, 100663414);
			}

			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 576610, RefRangeEnd = 576618, XrefRangeStart = 576610, XrefRangeEnd = 576618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe unitytls_tlsctx_set_trace_level_t(Il2CppSystem.Object @object, System.IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_tlsctx_set_trace_level_t>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
				*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual void Invoke(unitytls_tlsctx* ctx, unitytls_log_level level)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)ctx;
				*(unitytls_log_level**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_unitytls_tlsctx_unitytls_log_level_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unitytls_tlsctx_set_trace_level_t(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE;

		private static readonly System.IntPtr NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_errorstate_create;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_errorstate_raise_error;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_key_get_ref;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_key_parse_der;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_key_parse_pem;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_key_free;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509_export_der;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509list_get_ref;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509list_get_x509;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509list_create;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509list_append;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509list_append_der;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509list_append_pem;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509list_free;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509verify_default_ca;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509verify_explicit_ca;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_create_server;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_create_client;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_get_protocol;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_process_handshake;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_read;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_write;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_notify_close;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_free;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_random_generate_bytes;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_x509verify_result_to_string;

		private static readonly System.IntPtr NativeFieldInfoPtr_unitytls_tlsctx_set_trace_level;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ulong UNITYTLS_INVALID_HANDLE
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE);
				return *(ulong*)num;
			}
			set
			{
				*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE)) = value;
			}
		}

		public unsafe unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT);
				return *(unitytls_tlsctx_protocolrange*)num;
			}
			set
			{
				*(unitytls_tlsctx_protocolrange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT)) = value;
			}
		}

		public unsafe unitytls_errorstate_create_t unitytls_errorstate_create
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_errorstate_create);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_errorstate_create_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_errorstate_create)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_errorstate_raise_error);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_errorstate_raise_error_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_errorstate_raise_error)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_key_get_ref_t unitytls_key_get_ref
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_key_get_ref);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_key_get_ref_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_key_get_ref)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_key_parse_der_t unitytls_key_parse_der
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_key_parse_der);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_key_parse_der_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_key_parse_der)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_key_parse_pem_t unitytls_key_parse_pem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_key_parse_pem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_key_parse_pem_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_key_parse_pem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_key_free_t unitytls_key_free
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_key_free);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_key_free_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_key_free)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509_export_der_t unitytls_x509_export_der
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509_export_der);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509_export_der_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509_export_der)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509list_get_ref_t unitytls_x509list_get_ref
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_get_ref);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509list_get_ref_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_get_ref)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509list_get_x509_t unitytls_x509list_get_x509
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_get_x509);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509list_get_x509_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_get_x509)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509list_create_t unitytls_x509list_create
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_create);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509list_create_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_create)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509list_append_t unitytls_x509list_append
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_append);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509list_append_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_append)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509list_append_der_t unitytls_x509list_append_der
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_append_der);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509list_append_der_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_append_der)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509list_append_der_t unitytls_x509list_append_pem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_append_pem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509list_append_der_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_append_pem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509list_free_t unitytls_x509list_free
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_free);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509list_free_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509list_free)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509verify_default_ca);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509verify_default_ca_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509verify_default_ca)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509verify_explicit_ca);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509verify_explicit_ca_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509verify_explicit_ca)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_create_server);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_create_server_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_create_server)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_create_client);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_create_client_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_create_client)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_server_require_client_authentication_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_set_certificate_callback_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_set_trace_callback_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_set_x509verify_callback_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_set_supported_ciphersuites_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_get_ciphersuite_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_get_protocol);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_get_protocol_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_get_protocol)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_process_handshake);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_process_handshake_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_process_handshake)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_read_t unitytls_tlsctx_read
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_read);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_read_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_read)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_write_t unitytls_tlsctx_write
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_write);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_write_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_write)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_notify_close);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_notify_close_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_notify_close)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_free_t unitytls_tlsctx_free
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_free);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_free_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_free)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_random_generate_bytes_t unitytls_random_generate_bytes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_random_generate_bytes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_random_generate_bytes_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_random_generate_bytes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_x509verify_result_to_string_t unitytls_x509verify_result_to_string
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509verify_result_to_string);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_x509verify_result_to_string_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_x509verify_result_to_string)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe unitytls_tlsctx_set_trace_level_t unitytls_tlsctx_set_trace_level
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_trace_level);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_tlsctx_set_trace_level_t>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unitytls_tlsctx_set_trace_level)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static unitytls_interface_struct()
		{
			Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "unitytls_interface_struct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr);
			NativeFieldInfoPtr_UNITYTLS_INVALID_HANDLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "UNITYTLS_INVALID_HANDLE");
			NativeFieldInfoPtr_UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT");
			NativeFieldInfoPtr_unitytls_errorstate_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_create");
			NativeFieldInfoPtr_unitytls_errorstate_raise_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_errorstate_raise_error");
			NativeFieldInfoPtr_unitytls_key_get_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_key_get_ref");
			NativeFieldInfoPtr_unitytls_key_parse_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_der");
			NativeFieldInfoPtr_unitytls_key_parse_pem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_key_parse_pem");
			NativeFieldInfoPtr_unitytls_key_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_key_free");
			NativeFieldInfoPtr_unitytls_x509_export_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509_export_der");
			NativeFieldInfoPtr_unitytls_x509list_get_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_ref");
			NativeFieldInfoPtr_unitytls_x509list_get_x509 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_get_x509");
			NativeFieldInfoPtr_unitytls_x509list_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_create");
			NativeFieldInfoPtr_unitytls_x509list_append = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append");
			NativeFieldInfoPtr_unitytls_x509list_append_der = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_der");
			NativeFieldInfoPtr_unitytls_x509list_append_pem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_append_pem");
			NativeFieldInfoPtr_unitytls_x509list_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509list_free");
			NativeFieldInfoPtr_unitytls_x509verify_default_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_default_ca");
			NativeFieldInfoPtr_unitytls_x509verify_explicit_ca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_explicit_ca");
			NativeFieldInfoPtr_unitytls_tlsctx_create_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_server");
			NativeFieldInfoPtr_unitytls_tlsctx_create_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_create_client");
			NativeFieldInfoPtr_unitytls_tlsctx_server_require_client_authentication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_server_require_client_authentication");
			NativeFieldInfoPtr_unitytls_tlsctx_set_certificate_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_certificate_callback");
			NativeFieldInfoPtr_unitytls_tlsctx_set_trace_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_callback");
			NativeFieldInfoPtr_unitytls_tlsctx_set_x509verify_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_x509verify_callback");
			NativeFieldInfoPtr_unitytls_tlsctx_set_supported_ciphersuites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_supported_ciphersuites");
			NativeFieldInfoPtr_unitytls_tlsctx_get_ciphersuite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_ciphersuite");
			NativeFieldInfoPtr_unitytls_tlsctx_get_protocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_get_protocol");
			NativeFieldInfoPtr_unitytls_tlsctx_process_handshake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_process_handshake");
			NativeFieldInfoPtr_unitytls_tlsctx_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_read");
			NativeFieldInfoPtr_unitytls_tlsctx_write = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_write");
			NativeFieldInfoPtr_unitytls_tlsctx_notify_close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_notify_close");
			NativeFieldInfoPtr_unitytls_tlsctx_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_free");
			NativeFieldInfoPtr_unitytls_random_generate_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_random_generate_bytes");
			NativeFieldInfoPtr_unitytls_x509verify_result_to_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_x509verify_result_to_string");
			NativeFieldInfoPtr_unitytls_tlsctx_set_trace_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, "unitytls_tlsctx_set_trace_level");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr, 100663350);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe unitytls_interface_struct()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<unitytls_interface_struct>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unitytls_interface_struct(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_marshalledInterface;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0;

	public unsafe static unitytls_interface_struct marshalledInterface
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_marshalledInterface, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_interface_struct>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_marshalledInterface, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool IsSupported
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862588, XrefRangeEnd = 862589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static unitytls_interface_struct NativeInterface
	{
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 862602, RefRangeEnd = 862673, XrefRangeStart = 862589, XrefRangeEnd = 862602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<unitytls_interface_struct>(intPtr2) : null;
		}
	}

	static UnityTls()
	{
		Il2CppClassPointerStore<UnityTls>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTls>.NativeClassPtr);
		NativeFieldInfoPtr_marshalledInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, "marshalledInterface");
		NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_get_IsSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_get_NativeInterface_Public_Static_get_unitytls_interface_struct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTls>.NativeClassPtr, 100663337);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862587, XrefRangeEnd = 862588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetUnityTlsInterface()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnityTlsInterface_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public UnityTls(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
