using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem;

[System.Serializable]
public class Uri : Object
{
	[OriginalName("System.dll", "", "Flags")]
	[System.Flags]
	public enum Flags : ulong
	{
		Zero = 0uL,
		SchemeNotCanonical = 1uL,
		UserNotCanonical = 2uL,
		HostNotCanonical = 4uL,
		PortNotCanonical = 8uL,
		PathNotCanonical = 0x10uL,
		QueryNotCanonical = 0x20uL,
		FragmentNotCanonical = 0x40uL,
		CannotDisplayCanonical = 0x7FuL,
		E_UserNotCanonical = 0x80uL,
		E_HostNotCanonical = 0x100uL,
		E_PortNotCanonical = 0x200uL,
		E_PathNotCanonical = 0x400uL,
		E_QueryNotCanonical = 0x800uL,
		E_FragmentNotCanonical = 0x1000uL,
		E_CannotDisplayCanonical = 0x1F80uL,
		ShouldBeCompressed = 0x2000uL,
		FirstSlashAbsent = 0x4000uL,
		BackslashInPath = 0x8000uL,
		IndexMask = 0xFFFFuL,
		HostTypeMask = 0x70000uL,
		HostNotParsed = 0uL,
		IPv6HostType = 0x10000uL,
		IPv4HostType = 0x20000uL,
		DnsHostType = 0x30000uL,
		UncHostType = 0x40000uL,
		BasicHostType = 0x50000uL,
		UnusedHostType = 0x60000uL,
		UnknownHostType = 0x70000uL,
		UserEscaped = 0x80000uL,
		AuthorityFound = 0x100000uL,
		HasUserInfo = 0x200000uL,
		LoopbackHost = 0x400000uL,
		NotDefaultPort = 0x800000uL,
		UserDrivenParsing = 0x1000000uL,
		CanonicalDnsHost = 0x2000000uL,
		ErrorOrParsingRecursion = 0x4000000uL,
		DosPath = 0x8000000uL,
		UncPath = 0x10000000uL,
		ImplicitFile = 0x20000000uL,
		MinimalUriInfoSet = 0x40000000uL,
		AllUriInfoSet = 0x80000000uL,
		IdnHost = 0x100000000uL,
		HasUnicode = 0x200000000uL,
		HostUnicodeNormalized = 0x400000000uL,
		RestUnicodeNormalized = 0x800000000uL,
		UnicodeHost = 0x1000000000uL,
		IntranetUri = 0x2000000000uL,
		UseOrigUncdStrOffset = 0x4000000000uL,
		UserIriCanonical = 0x8000000000uL,
		PathIriCanonical = 0x10000000000uL,
		QueryIriCanonical = 0x20000000000uL,
		FragmentIriCanonical = 0x40000000000uL,
		IriCanonical = 0x78000000000uL,
		CompressedSlashes = 0x100000000000uL
	}

	public class UriInfo : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Host;

		private static readonly System.IntPtr NativeFieldInfoPtr_ScopeId;

		private static readonly System.IntPtr NativeFieldInfoPtr_String;

		private static readonly System.IntPtr NativeFieldInfoPtr_Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_DnsSafeHost;

		private static readonly System.IntPtr NativeFieldInfoPtr_MoreInfo;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string Host
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Host);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Host)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string ScopeId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScopeId);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScopeId)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string String
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_String);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_String)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Offset Offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Offset);
				return *(Offset*)num;
			}
			set
			{
				*(Offset*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Offset)) = value;
			}
		}

		public unsafe string DnsSafeHost
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DnsSafeHost);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DnsSafeHost)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe MoreInfo MoreInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoreInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MoreInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoreInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static UriInfo()
		{
			Il2CppClassPointerStore<UriInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriInfo>.NativeClassPtr);
			NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriInfo>.NativeClassPtr, "Host");
			NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriInfo>.NativeClassPtr, "ScopeId");
			NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriInfo>.NativeClassPtr, "String");
			NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriInfo>.NativeClassPtr, "Offset");
			NativeFieldInfoPtr_DnsSafeHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriInfo>.NativeClassPtr, "DnsSafeHost");
			NativeFieldInfoPtr_MoreInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriInfo>.NativeClassPtr, "MoreInfo");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriInfo>.NativeClassPtr, 100664287);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public UriInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Offset
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Scheme;

		private static readonly System.IntPtr NativeFieldInfoPtr_User;

		private static readonly System.IntPtr NativeFieldInfoPtr_Host;

		private static readonly System.IntPtr NativeFieldInfoPtr_PortValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_Path;

		private static readonly System.IntPtr NativeFieldInfoPtr_Query;

		private static readonly System.IntPtr NativeFieldInfoPtr_Fragment;

		private static readonly System.IntPtr NativeFieldInfoPtr_End;

		[FieldOffset(0)]
		public ushort Scheme;

		[FieldOffset(2)]
		public ushort User;

		[FieldOffset(4)]
		public ushort Host;

		[FieldOffset(6)]
		public ushort PortValue;

		[FieldOffset(8)]
		public ushort Path;

		[FieldOffset(10)]
		public ushort Query;

		[FieldOffset(12)]
		public ushort Fragment;

		[FieldOffset(14)]
		public ushort End;

		static Offset()
		{
			Il2CppClassPointerStore<Offset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "Offset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offset>.NativeClassPtr);
			NativeFieldInfoPtr_Scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "Scheme");
			NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "User");
			NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "Host");
			NativeFieldInfoPtr_PortValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "PortValue");
			NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "Path");
			NativeFieldInfoPtr_Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "Query");
			NativeFieldInfoPtr_Fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "Fragment");
			NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offset>.NativeClassPtr, "End");
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Offset>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class MoreInfo : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Path;

		private static readonly System.IntPtr NativeFieldInfoPtr_Query;

		private static readonly System.IntPtr NativeFieldInfoPtr_Fragment;

		private static readonly System.IntPtr NativeFieldInfoPtr_AbsoluteUri;

		private static readonly System.IntPtr NativeFieldInfoPtr_Hash;

		private static readonly System.IntPtr NativeFieldInfoPtr_RemoteUrl;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string Path
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Path);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Path)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string Query
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Query);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Query)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string Fragment
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Fragment);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Fragment)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string AbsoluteUri
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AbsoluteUri);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AbsoluteUri)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int Hash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hash);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hash)) = value;
			}
		}

		public unsafe string RemoteUrl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteUrl);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RemoteUrl)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static MoreInfo()
		{
			Il2CppClassPointerStore<MoreInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "MoreInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr);
			NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr, "Path");
			NativeFieldInfoPtr_Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr, "Query");
			NativeFieldInfoPtr_Fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr, "Fragment");
			NativeFieldInfoPtr_AbsoluteUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr, "AbsoluteUri");
			NativeFieldInfoPtr_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr, "Hash");
			NativeFieldInfoPtr_RemoteUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr, "RemoteUrl");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr, 100664288);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoreInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoreInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MoreInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("System.dll", "", "Check")]
	[System.Flags]
	public enum Check
	{
		None = 0,
		EscapedCanonical = 1,
		DisplayCanonical = 2,
		DotSlashAttn = 4,
		DotSlashEscaped = 0x80,
		BackslashInPath = 0x10,
		ReservedFound = 0x20,
		NotIriCanonical = 0x40,
		FoundNonAscii = 8
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeFile;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeFtp;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeGopher;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeHttp;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeHttps;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeWs;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeWss;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeMailto;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeNews;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeNntp;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeNetTcp;

	private static readonly System.IntPtr NativeFieldInfoPtr_UriSchemeNetPipe;

	private static readonly System.IntPtr NativeFieldInfoPtr_SchemeDelimiter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_String;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_originalUnicodeString;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Syntax;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DnsSafeHost;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Info;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_iriParsing;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ConfigInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ConfigInitializing;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_IdnScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_IriParsing;

	private static readonly System.IntPtr NativeFieldInfoPtr_useDotNetRelativeOrAbsolute;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsWindowsFileSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_initLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_HexLowerChars;

	private static readonly System.IntPtr NativeFieldInfoPtr__WSchars;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HostType_Private_get_Flags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalPath_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Authority_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Segments_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPath_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Query_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Fragment_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Scheme_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalString_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserInfo_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForColonInFirstPathSegment_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHostString_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseRemaining_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_String_byref_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_Uri_byref_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWellFormedOriginalString_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWellFormedUriString_Public_Static_Boolean_String_UriKind_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBaseOf_Public_Boolean_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBaseOfHelper_Internal_Boolean_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0;

	public unsafe static string UriSchemeFile
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeFile, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeFile, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeFtp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeFtp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeFtp, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeGopher
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeGopher, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeGopher, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeHttp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeHttp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeHttp, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeHttps
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeHttps, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeHttps, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeWs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeWs, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeWs, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeWss
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeWss, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeWss, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeMailto
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeMailto, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeMailto, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeNews
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeNews, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeNews, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeNntp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeNntp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeNntp, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeNetTcp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeNetTcp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeNetTcp, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string UriSchemeNetPipe
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UriSchemeNetPipe, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UriSchemeNetPipe, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string SchemeDelimiter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SchemeDelimiter, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SchemeDelimiter, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_String
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_String);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_String)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_originalUnicodeString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalUnicodeString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_originalUnicodeString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe UriParser m_Syntax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Syntax);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Syntax)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_DnsSafeHost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DnsSafeHost);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DnsSafeHost)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Flags m_Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
			return *(Flags*)num;
		}
		set
		{
			*(Flags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
		}
	}

	public unsafe UriInfo m_Info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Info);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Info)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_iriParsing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_iriParsing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_iriParsing)) = value;
		}
	}

	public unsafe static bool s_ConfigInitialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ConfigInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ConfigInitialized, (void*)(&value));
		}
	}

	public unsafe static bool s_ConfigInitializing
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ConfigInitializing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ConfigInitializing, (void*)(&value));
		}
	}

	public unsafe static UriIdnScope s_IdnScope
	{
		get
		{
			Unsafe.SkipInit(out UriIdnScope result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_IdnScope, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_IdnScope, (void*)(&value));
		}
	}

	public unsafe static bool s_IriParsing
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_IriParsing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_IriParsing, (void*)(&value));
		}
	}

	public unsafe static bool useDotNetRelativeOrAbsolute
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_useDotNetRelativeOrAbsolute, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_useDotNetRelativeOrAbsolute, (void*)(&value));
		}
	}

	public unsafe static bool IsWindowsFileSystem
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsWindowsFileSystem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsWindowsFileSystem, (void*)(&value));
		}
	}

	public unsafe static Object s_initLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_initLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_initLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> HexLowerChars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HexLowerChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HexLowerChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> _WSchars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__WSchars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__WSchars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool IsImplicitFile
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsUncOrDosPath
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsDosPath
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsUncPath
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Flags HostType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HostType_Private_get_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Flags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe UriParser Syntax
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
	}

	public unsafe bool IsNotAbsoluteUri
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool AllowIdn
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 869470, RefRangeEnd = 869478, XrefRangeStart = 869465, XrefRangeEnd = 869470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool UserDrivenParsing
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869487, RefRangeEnd = 869489, XrefRangeStart = 869487, XrefRangeEnd = 869487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ushort SecuredPathIndex
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 869489, RefRangeEnd = 869492, XrefRangeStart = 869489, XrefRangeEnd = 869489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string AbsolutePath
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 869627, RefRangeEnd = 869634, XrefRangeStart = 869624, XrefRangeEnd = 869627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string PrivateAbsolutePath
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869642, RefRangeEnd = 869644, XrefRangeStart = 869634, XrefRangeEnd = 869642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string AbsoluteUri
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 869652, RefRangeEnd = 869656, XrefRangeStart = 869644, XrefRangeEnd = 869652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string LocalPath
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 869664, RefRangeEnd = 869668, XrefRangeStart = 869656, XrefRangeEnd = 869664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LocalPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string Authority
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 869676, RefRangeEnd = 869679, XrefRangeStart = 869668, XrefRangeEnd = 869676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Authority_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe UriHostNameType HostNameType
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 869684, RefRangeEnd = 869687, XrefRangeStart = 869679, XrefRangeEnd = 869684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UriHostNameType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsDefaultPort
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 869690, RefRangeEnd = 869693, XrefRangeStart = 869687, XrefRangeEnd = 869690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsFile
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869697, RefRangeEnd = 869698, XrefRangeStart = 869693, XrefRangeEnd = 869697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsLoopback
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869700, RefRangeEnd = 869702, XrefRangeStart = 869698, XrefRangeEnd = 869700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string PathAndQuery
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 869705, RefRangeEnd = 869711, XrefRangeStart = 869702, XrefRangeEnd = 869705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe Il2CppStringArray Segments
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869729, RefRangeEnd = 869731, XrefRangeStart = 869711, XrefRangeEnd = 869729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Segments_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public unsafe bool IsUnc
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string Host
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 869739, RefRangeEnd = 869761, XrefRangeStart = 869731, XrefRangeEnd = 869739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static Object InitializeLock
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869763, XrefRangeEnd = 869778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
	}

	public unsafe int Port
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 869853, RefRangeEnd = 869862, XrefRangeStart = 869848, XrefRangeEnd = 869853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string Query
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869870, RefRangeEnd = 869872, XrefRangeStart = 869862, XrefRangeEnd = 869870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Query_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string Fragment
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 869880, RefRangeEnd = 869883, XrefRangeStart = 869872, XrefRangeEnd = 869880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Fragment_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string Scheme
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 869883, RefRangeEnd = 869907, XrefRangeStart = 869883, XrefRangeEnd = 869883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Scheme_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe bool OriginalStringSwitched
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869907, XrefRangeEnd = 869908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string OriginalString
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 869909, RefRangeEnd = 869928, XrefRangeStart = 869908, XrefRangeEnd = 869909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OriginalString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string DnsSafeHost
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869928, XrefRangeEnd = 869932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe bool IsAbsoluteUri
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 869932, RefRangeEnd = 869937, XrefRangeStart = 869932, XrefRangeEnd = 869932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool UserEscaped
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string UserInfo
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 869945, RefRangeEnd = 869950, XrefRangeStart = 869937, XrefRangeEnd = 869945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserInfo_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe bool HasAuthority
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 870833, RefRangeEnd = 870835, XrefRangeStart = 870833, XrefRangeEnd = 870833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Uri()
	{
		Il2CppClassPointerStore<Uri>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "Uri");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri>.NativeClassPtr);
		NativeFieldInfoPtr_UriSchemeFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeFile");
		NativeFieldInfoPtr_UriSchemeFtp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeFtp");
		NativeFieldInfoPtr_UriSchemeGopher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeGopher");
		NativeFieldInfoPtr_UriSchemeHttp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeHttp");
		NativeFieldInfoPtr_UriSchemeHttps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeHttps");
		NativeFieldInfoPtr_UriSchemeWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeWs");
		NativeFieldInfoPtr_UriSchemeWss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeWss");
		NativeFieldInfoPtr_UriSchemeMailto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeMailto");
		NativeFieldInfoPtr_UriSchemeNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNews");
		NativeFieldInfoPtr_UriSchemeNntp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNntp");
		NativeFieldInfoPtr_UriSchemeNetTcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNetTcp");
		NativeFieldInfoPtr_UriSchemeNetPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNetPipe");
		NativeFieldInfoPtr_SchemeDelimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "SchemeDelimiter");
		NativeFieldInfoPtr_m_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_String");
		NativeFieldInfoPtr_m_originalUnicodeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_originalUnicodeString");
		NativeFieldInfoPtr_m_Syntax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Syntax");
		NativeFieldInfoPtr_m_DnsSafeHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_DnsSafeHost");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Info");
		NativeFieldInfoPtr_m_iriParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_iriParsing");
		NativeFieldInfoPtr_s_ConfigInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_ConfigInitialized");
		NativeFieldInfoPtr_s_ConfigInitializing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_ConfigInitializing");
		NativeFieldInfoPtr_s_IdnScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_IdnScope");
		NativeFieldInfoPtr_s_IriParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_IriParsing");
		NativeFieldInfoPtr_useDotNetRelativeOrAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "useDotNetRelativeOrAbsolute");
		NativeFieldInfoPtr_IsWindowsFileSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "IsWindowsFileSystem");
		NativeFieldInfoPtr_s_initLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_initLock");
		NativeFieldInfoPtr_HexLowerChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "HexLowerChars");
		NativeFieldInfoPtr__WSchars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "_WSchars");
		NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664162);
		NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664163);
		NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664164);
		NativeMethodInfoPtr_get_HostType_Private_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664165);
		NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664167);
		NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664168);
		NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664169);
		NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664170);
		NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664171);
		NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664172);
		NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664173);
		NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664174);
		NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664175);
		NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664176);
		NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664177);
		NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664178);
		NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664179);
		NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664180);
		NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664181);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664182);
		NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664183);
		NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664184);
		NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664185);
		NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664186);
		NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664190);
		NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664192);
		NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664194);
		NativeMethodInfoPtr_get_LocalPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr_get_Authority_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664196);
		NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664197);
		NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664198);
		NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664199);
		NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664200);
		NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664201);
		NativeMethodInfoPtr_get_Segments_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664202);
		NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664203);
		NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664204);
		NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664205);
		NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr_GetLocalPath_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664208);
		NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664209);
		NativeMethodInfoPtr_get_Query_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664210);
		NativeMethodInfoPtr_get_Fragment_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664211);
		NativeMethodInfoPtr_get_Scheme_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664212);
		NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664213);
		NativeMethodInfoPtr_get_OriginalString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664214);
		NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664215);
		NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664216);
		NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664217);
		NativeMethodInfoPtr_get_UserInfo_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664218);
		NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664219);
		NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664221);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664223);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664225);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_CheckForColonInFirstPathSegment_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664227);
		NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664233);
		NativeMethodInfoPtr_CreateHostString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664234);
		NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664235);
		NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664236);
		NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664237);
		NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664238);
		NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664239);
		NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664240);
		NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664241);
		NativeMethodInfoPtr_ParseRemaining_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664242);
		NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664243);
		NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664250);
		NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664251);
		NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664252);
		NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664253);
		NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664254);
		NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664262);
		NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664263);
		NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664264);
		NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664265);
		NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664266);
		NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664267);
		NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664268);
		NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_String_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664269);
		NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_Uri_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664270);
		NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664271);
		NativeMethodInfoPtr_IsWellFormedOriginalString_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664272);
		NativeMethodInfoPtr_IsWellFormedUriString_Public_Static_Boolean_String_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664273);
		NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664274);
		NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664275);
		NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664279);
		NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_IsBaseOf_Public_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_IsBaseOfHelper_Internal_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100664285);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869464, RefRangeEnd = 869465, XrefRangeStart = 869459, XrefRangeEnd = 869464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IriParsingStatic(UriParser syntax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 869483, RefRangeEnd = 869487, XrefRangeStart = 869478, XrefRangeEnd = 869483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AllowIdnStatic(UriParser syntax, Flags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(Flags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsIntranet(string schemeHost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeHost);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetUserDrivenParsing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool NotAny(Flags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool InFact(Flags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool StaticNotAny(Flags allFlags, Flags checkFlags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&allFlags);
		*(Flags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool StaticInFact(Flags allFlags, Flags checkFlags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&allFlags);
		*(Flags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869492, XrefRangeEnd = 869493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UriInfo EnsureUriInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869493, XrefRangeEnd = 869494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureParseRemaining()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869494, XrefRangeEnd = 869496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureHostString(bool allowDnsOptimization)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&allowDnsOptimization);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 869503, RefRangeEnd = 869510, XrefRangeStart = 869496, XrefRangeEnd = 869503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Uri(string uriString)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 869512, RefRangeEnd = 869517, XrefRangeStart = 869510, XrefRangeEnd = 869512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Uri(string uriString, UriKind uriKind)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
		*(UriKind**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriKind;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 869519, RefRangeEnd = 869522, XrefRangeStart = 869517, XrefRangeEnd = 869519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Uri(Uri baseUri, string relativeUri)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869549, RefRangeEnd = 869550, XrefRangeStart = 869522, XrefRangeEnd = 869549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateUri(Uri baseUri, string relativeUri, bool dontEscape)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dontEscape;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869564, RefRangeEnd = 869565, XrefRangeStart = 869550, XrefRangeEnd = 869564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Uri(Uri baseUri, Uri relativeUri)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeUri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869565, XrefRangeEnd = 869578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(relativeStr);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dontEscape;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(result);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		result = IL2CPP.Il2CppStringToManaged(intPtr);
		return *(ParsingError*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 869590, RefRangeEnd = 869592, XrefRangeStart = 869578, XrefRangeEnd = 869590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UriFormatException GetException(ParsingError err)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&err);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriFormatException>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869592, XrefRangeEnd = 869612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializationInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)streamingContext));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869612, XrefRangeEnd = 869624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializationInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)streamingContext));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializationInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)streamingContext));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869761, XrefRangeEnd = 869763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StaticIsFile(UriParser syntax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869818, RefRangeEnd = 869819, XrefRangeStart = 869778, XrefRangeEnd = 869818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeUriConfig()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869847, RefRangeEnd = 869848, XrefRangeStart = 869819, XrefRangeEnd = 869847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocalPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalPath_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869950, RefRangeEnd = 869951, XrefRangeStart = 869950, XrefRangeEnd = 869950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGenDelim(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 869951, RefRangeEnd = 869954, XrefRangeStart = 869951, XrefRangeEnd = 869951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsHexDigit(char character)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&character);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869954, RefRangeEnd = 869955, XrefRangeStart = 869954, XrefRangeEnd = 869954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FromHex(char digit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&digit);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869955, XrefRangeEnd = 869966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869966, XrefRangeEnd = 869972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 869972, RefRangeEnd = 870004, XrefRangeStart = 869972, XrefRangeEnd = 869972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Uri uri1, Uri uri2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 870004, RefRangeEnd = 870027, XrefRangeStart = 870004, XrefRangeEnd = 870004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(Uri uri1, Uri uri2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870027, XrefRangeEnd = 870045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object comparand)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparand);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870045, XrefRangeEnd = 870052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckForColonInFirstPathSegment(string uriString)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForColonInFirstPathSegment_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870057, RefRangeEnd = 870058, XrefRangeStart = 870052, XrefRangeEnd = 870057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InternalEscapeString(string rawString)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 870063, RefRangeEnd = 870069, XrefRangeStart = 870058, XrefRangeEnd = 870063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ParsingError ParseScheme(string uriString, ref Flags flags, ref UriParser syntax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref flags);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		syntax = ((intPtr4 == (System.IntPtr)0) ? null : new UriParser(intPtr4));
		return *(ParsingError*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870074, RefRangeEnd = 870075, XrefRangeStart = 870069, XrefRangeEnd = 870074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UriFormatException ParseMinimal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriFormatException>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870100, RefRangeEnd = 870101, XrefRangeStart = 870075, XrefRangeEnd = 870100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParsingError PrivateParseMinimal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ParsingError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870101, XrefRangeEnd = 870107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrivateParseMinimalIri(string newHost, ushort idx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newHost);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 870142, RefRangeEnd = 870164, XrefRangeStart = 870107, XrefRangeEnd = 870142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateUriInfo(Flags cF)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cF);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 870194, RefRangeEnd = 870203, XrefRangeStart = 870164, XrefRangeEnd = 870194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateHostString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHostString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870211, RefRangeEnd = 870213, XrefRangeStart = 870203, XrefRangeEnd = 870211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Flags flags, ref string scopeId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref flags);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870229, RefRangeEnd = 870230, XrefRangeStart = 870213, XrefRangeEnd = 870229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetHostViaCustomSyntax()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870230, XrefRangeEnd = 870231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetParts(UriComponents uriParts, UriFormat formatAs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uriParts);
		*(UriFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatAs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870231, XrefRangeEnd = 870235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetEscapedParts(UriComponents uriParts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uriParts);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870239, RefRangeEnd = 870240, XrefRangeStart = 870235, XrefRangeEnd = 870239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uriParts);
		*(UriFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatAs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870298, RefRangeEnd = 870300, XrefRangeStart = 870240, XrefRangeEnd = 870298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&parts);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nonCanonical;
		*(UriFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatAs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870302, RefRangeEnd = 870304, XrefRangeStart = 870300, XrefRangeEnd = 870302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetUriPartsFromUserString(UriComponents uriParts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uriParts);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 870386, RefRangeEnd = 870390, XrefRangeStart = 870304, XrefRangeEnd = 870386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseRemaining()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseRemaining_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870435, RefRangeEnd = 870437, XrefRangeStart = 870390, XrefRangeEnd = 870435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Flags flags, ref UriParser syntax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)uriString;
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref err);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref flags);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		syntax = ((intPtr4 == (System.IntPtr)0) ? null : new UriParser(intPtr4));
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870494, RefRangeEnd = 870495, XrefRangeStart = 870437, XrefRangeEnd = 870494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)lptr;
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nChars;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		syntax = ((intPtr4 == (System.IntPtr)0) ? null : new UriParser(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870502, RefRangeEnd = 870504, XrefRangeStart = 870495, XrefRangeEnd = 870502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)ptr;
		*(ushort**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		byte* num = (byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0, (System.IntPtr)0, (void**)ptr2, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		syntax = ((intPtr4 == (System.IntPtr)0) ? null : new UriParser(intPtr4));
		return *(ParsingError*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870629, RefRangeEnd = 870630, XrefRangeStart = 870504, XrefRangeEnd = 870629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Flags flags, UriParser syntax, ref string newHost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)pString;
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref err);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref flags);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		byte* num = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		newHost = IL2CPP.Il2CppStringToManaged(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870680, RefRangeEnd = 870681, XrefRangeStart = 870630, XrefRangeEnd = 870680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)pString;
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startInput;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &iriParsing;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasUnicode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(userInfoString);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref flags);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref justNormalized);
		byte* num = (byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref err);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		newHost = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870681, XrefRangeEnd = 870704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Flags flags, ref string newHost, ref ParsingError err)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)pString;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startInput;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &iriParsing;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasUnicode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref flags);
		byte* num = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref err);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		newHost = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870706, RefRangeEnd = 870708, XrefRangeStart = 870704, XrefRangeEnd = 870706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idx);
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &delim;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870708, XrefRangeEnd = 870709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)str;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idx);
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &delim;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 870731, RefRangeEnd = 870737, XrefRangeStart = 870709, XrefRangeEnd = 870731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)str;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref idx);
		*(ushort**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &delim;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Check*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870771, RefRangeEnd = 870772, XrefRangeStart = 870737, XrefRangeEnd = 870771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<char> GetCanonicalPath(Il2CppStructArray<char> dest, ref int pos, UriFormat formatAs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(UriFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &formatAs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870779, RefRangeEnd = 870780, XrefRangeStart = 870772, XrefRangeEnd = 870779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)pch;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref end);
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch1;
		*(char**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch2;
		*(char**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ch3;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870802, RefRangeEnd = 870803, XrefRangeStart = 870780, XrefRangeEnd = 870802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<char> Compress(Il2CppStructArray<char> dest, ushort start, ref int destLength, UriParser syntax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destLength);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870811, RefRangeEnd = 870812, XrefRangeStart = 870803, XrefRangeEnd = 870811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalculateCaseInsensitiveHashCode(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870812, XrefRangeEnd = 870833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)basePart);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(relativePart);
		*(UriFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsLWS(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsAsciiLetter(char character)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&character);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870838, RefRangeEnd = 870840, XrefRangeStart = 870835, XrefRangeEnd = 870838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAsciiLetterOrDigit(char character)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&character);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870840, RefRangeEnd = 870842, XrefRangeStart = 870840, XrefRangeEnd = 870840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBidiControlCharacter(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870850, RefRangeEnd = 870852, XrefRangeStart = 870842, XrefRangeEnd = 870850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)strToClean;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870859, RefRangeEnd = 870861, XrefRangeStart = 870852, XrefRangeEnd = 870859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateThis(string uri, bool dontEscape, UriKind uriKind)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dontEscape;
		*(UriKind**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriKind;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 870868, RefRangeEnd = 870875, XrefRangeStart = 870861, XrefRangeEnd = 870868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&err);
		*(UriKind**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriKind;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		e = ((num3 == 0) ? null : new UriFormatException(num3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870875, XrefRangeEnd = 870876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckForConfigLoad(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870876, XrefRangeEnd = 870883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckForUnicode(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870883, XrefRangeEnd = 870897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckForEscapedUnreserved(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 870904, RefRangeEnd = 870907, XrefRangeStart = 870897, XrefRangeEnd = 870904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
		*(UriKind**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriKind;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		result = ((num3 == 0) ? null : new Uri(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 870939, RefRangeEnd = 870940, XrefRangeStart = 870907, XrefRangeEnd = 870939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryCreate(Uri baseUri, string relativeUri, out Uri result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_String_byref_Uri_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		result = ((num3 == 0) ? null : new Uri(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870940, XrefRangeEnd = 870956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeUri);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_Uri_Uri_byref_Uri_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		result = ((num3 == 0) ? null : new Uri(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 870958, RefRangeEnd = 870978, XrefRangeStart = 870956, XrefRangeEnd = 870958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetComponents(UriComponents components, UriFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&components);
		*(UriFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870978, XrefRangeEnd = 870982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsWellFormedOriginalString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWellFormedOriginalString_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 870994, RefRangeEnd = 870996, XrefRangeStart = 870982, XrefRangeEnd = 870994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWellFormedUriString(string uriString, UriKind uriKind)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
		*(UriKind**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriKind;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWellFormedUriString_Public_Static_Boolean_String_UriKind_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 871007, RefRangeEnd = 871009, XrefRangeStart = 870996, XrefRangeEnd = 871007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InternalIsWellFormedOriginalString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 871019, RefRangeEnd = 871026, XrefRangeStart = 871009, XrefRangeEnd = 871019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UnescapeDataString(string stringToUnescape)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToUnescape);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 871031, RefRangeEnd = 871035, XrefRangeStart = 871026, XrefRangeEnd = 871031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EscapeDataString(string stringToEscape)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToEscape);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871035, XrefRangeEnd = 871037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string EscapeUnescapeIri(string input, int start, int end, UriComponents component)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(UriComponents**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &component;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871037, XrefRangeEnd = 871040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Uri(Flags flags, UriParser uriParser, string uri)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&flags);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uriParser);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 871059, RefRangeEnd = 871065, XrefRangeStart = 871040, XrefRangeEnd = 871059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dontEscape;
		*(UriKind**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriKind;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		e = ((intPtr4 == (System.IntPtr)0) ? null : new UriFormatException(intPtr4));
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 871078, RefRangeEnd = 871084, XrefRangeStart = 871065, XrefRangeEnd = 871078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeUri);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newUriString);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref userEscaped);
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		newUriString = IL2CPP.Il2CppStringToManaged(intPtr);
		nint num4 = num3;
		e = ((num4 == 0) ? null : new UriFormatException(num4));
		return (intPtr3 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871084, XrefRangeEnd = 871093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRelativeSerializationString(UriFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 871099, RefRangeEnd = 871101, XrefRangeStart = 871093, XrefRangeEnd = 871099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uriComponents);
		*(UriFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871104, RefRangeEnd = 871105, XrefRangeStart = 871101, XrefRangeEnd = 871104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBaseOf(Uri uri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBaseOf_Public_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 871122, RefRangeEnd = 871124, XrefRangeStart = 871105, XrefRangeEnd = 871122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBaseOfHelper(Uri uriLink)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uriLink);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBaseOfHelper_Internal_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 871134, RefRangeEnd = 871136, XrefRangeStart = 871124, XrefRangeEnd = 871134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateThisFromUri(Uri otherUri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherUri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Uri(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
