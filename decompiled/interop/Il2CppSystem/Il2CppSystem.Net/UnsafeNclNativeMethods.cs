using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security;

namespace Il2CppSystem.Net;

public static class UnsafeNclNativeMethods : Object
{
	public static class HttpApi : Object
	{
		public static class HTTP_REQUEST_HEADER_ID : Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_m_Strings;

			private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;

			public unsafe static Il2CppStringArray m_Strings
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Strings, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Strings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static HTTP_REQUEST_HEADER_ID()
			{
				Il2CppClassPointerStore<HTTP_REQUEST_HEADER_ID>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpApi>.NativeClassPtr, "HTTP_REQUEST_HEADER_ID");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTP_REQUEST_HEADER_ID>.NativeClassPtr);
				NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTP_REQUEST_HEADER_ID>.NativeClassPtr, "m_Strings");
				NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTP_REQUEST_HEADER_ID>.NativeClassPtr, 100666547);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 891257, RefRangeEnd = 891258, XrefRangeStart = 891253, XrefRangeEnd = 891257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string ToString(int position)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&position);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public HTTP_REQUEST_HEADER_ID(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Strings;

		public unsafe static Il2CppStringArray m_Strings
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Strings, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Strings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static HttpApi()
		{
			Il2CppClassPointerStore<HttpApi>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr, "HttpApi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpApi>.NativeClassPtr);
			NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpApi>.NativeClassPtr, "m_Strings");
		}

		public HttpApi(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class SecureStringHelper : Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0;

		static SecureStringHelper()
		{
			Il2CppClassPointerStore<SecureStringHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr, "SecureStringHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureStringHelper>.NativeClassPtr);
			NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHelper>.NativeClassPtr, 100666549);
			NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringHelper>.NativeClassPtr, 100666550);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 891269, RefRangeEnd = 891272, XrefRangeStart = 891258, XrefRangeEnd = 891269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateString(SecureString secureString)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secureString);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Internal_Static_String_SecureString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 891277, RefRangeEnd = 891282, XrefRangeStart = 891272, XrefRangeEnd = 891277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SecureString CreateSecureString(string plainString)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(plainString);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSecureString_Internal_Static_SecureString_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SecureString>(intPtr2) : null;
		}

		public SecureStringHelper(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	static UnsafeNclNativeMethods()
	{
		Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "UnsafeNclNativeMethods");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNclNativeMethods>.NativeClassPtr);
	}

	public UnsafeNclNativeMethods(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
