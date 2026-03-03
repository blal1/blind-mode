using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem;

public class UriParser : Object
{
	[OriginalName("System.dll", "", "UriQuirksVersion")]
	public enum UriQuirksVersion
	{
		V2 = 2,
		V3
	}

	public class BuiltInUriParser : UriParser
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0;

		static BuiltInUriParser()
		{
			Il2CppClassPointerStore<BuiltInUriParser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "BuiltInUriParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltInUriParser>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltInUriParser>.NativeClassPtr, 100664331);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871401, RefRangeEnd = 871402, XrefRangeStart = 871394, XrefRangeEnd = 871401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltInUriParser>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultPort;
			*(UriSyntaxFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &syntaxFlags;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public BuiltInUriParser(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Table;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdatableFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdatableFlagsUsed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Port;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Scheme;

	private static readonly System.IntPtr NativeFieldInfoPtr_HttpUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_HttpsUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_WsUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_WssUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_FtpUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_FileUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_GopherUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_NntpUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_NewsUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_MailToUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_UuidUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_TelnetUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_LdapUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_NetTcpUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_NetPipeUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_VsMacrosUri;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_QuirksVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_HttpSyntaxFlags;

	private static readonly System.IntPtr NativeFieldInfoPtr_FileSyntaxFlags;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBaseOf_Protected_Virtual_New_Boolean_Uri_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWellFormedOriginalString_Protected_Virtual_New_Boolean_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalIsBaseOf_Internal_Boolean_Uri_Uri_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_Uri_0;

	public unsafe static Dictionary<string, UriParser> m_Table
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Table, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, UriParser>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Table, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<string, UriParser> m_TempTable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_TempTable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, UriParser>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_TempTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UriSyntaxFlags m_Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
			return *(UriSyntaxFlags*)num;
		}
		set
		{
			*(UriSyntaxFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
		}
	}

	public unsafe UriSyntaxFlags m_UpdatableFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdatableFlags);
			return *(UriSyntaxFlags*)num;
		}
		set
		{
			*(UriSyntaxFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdatableFlags)) = value;
		}
	}

	public unsafe bool m_UpdatableFlagsUsed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdatableFlagsUsed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdatableFlagsUsed)) = value;
		}
	}

	public unsafe int m_Port
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Port);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Port)) = value;
		}
	}

	public unsafe string m_Scheme
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Scheme);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Scheme)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static UriParser HttpUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HttpUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HttpUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser HttpsUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HttpsUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HttpsUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser WsUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WsUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WsUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser WssUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WssUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WssUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser FtpUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FtpUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FtpUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser FileUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FileUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FileUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser GopherUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GopherUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GopherUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser NntpUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NntpUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NntpUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser NewsUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NewsUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NewsUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser MailToUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MailToUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MailToUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser UuidUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UuidUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UuidUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser TelnetUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TelnetUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TelnetUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser LdapUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LdapUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LdapUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser NetTcpUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NetTcpUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NetTcpUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser NetPipeUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NetPipeUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NetPipeUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriParser VsMacrosUri
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VsMacrosUri, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VsMacrosUri, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UriQuirksVersion s_QuirksVersion
	{
		get
		{
			Unsafe.SkipInit(out UriQuirksVersion result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_QuirksVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_QuirksVersion, (void*)(&value));
		}
	}

	public unsafe static UriSyntaxFlags HttpSyntaxFlags
	{
		get
		{
			Unsafe.SkipInit(out UriSyntaxFlags result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HttpSyntaxFlags, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HttpSyntaxFlags, (void*)(&value));
		}
	}

	public unsafe static UriSyntaxFlags FileSyntaxFlags
	{
		get
		{
			Unsafe.SkipInit(out UriSyntaxFlags result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FileSyntaxFlags, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FileSyntaxFlags, (void*)(&value));
		}
	}

	public unsafe string SchemeName
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe int DefaultPort
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool ShouldUseLegacyV2Quirks
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 871464, RefRangeEnd = 871470, XrefRangeStart = 871460, XrefRangeEnd = 871464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe UriSyntaxFlags Flags
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UriSyntaxFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsSimple
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 871583, RefRangeEnd = 871598, XrefRangeStart = 871583, XrefRangeEnd = 871583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static UriParser()
	{
		Il2CppClassPointerStore<UriParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriParser");
		NativeFieldInfoPtr_m_Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Table");
		NativeFieldInfoPtr_m_TempTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_TempTable");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_UpdatableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_UpdatableFlags");
		NativeFieldInfoPtr_m_UpdatableFlagsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_UpdatableFlagsUsed");
		NativeFieldInfoPtr_m_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Port");
		NativeFieldInfoPtr_m_Scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Scheme");
		NativeFieldInfoPtr_HttpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpUri");
		NativeFieldInfoPtr_HttpsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpsUri");
		NativeFieldInfoPtr_WsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "WsUri");
		NativeFieldInfoPtr_WssUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "WssUri");
		NativeFieldInfoPtr_FtpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FtpUri");
		NativeFieldInfoPtr_FileUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FileUri");
		NativeFieldInfoPtr_GopherUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "GopherUri");
		NativeFieldInfoPtr_NntpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NntpUri");
		NativeFieldInfoPtr_NewsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NewsUri");
		NativeFieldInfoPtr_MailToUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "MailToUri");
		NativeFieldInfoPtr_UuidUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "UuidUri");
		NativeFieldInfoPtr_TelnetUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "TelnetUri");
		NativeFieldInfoPtr_LdapUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "LdapUri");
		NativeFieldInfoPtr_NetTcpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NetTcpUri");
		NativeFieldInfoPtr_NetPipeUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NetPipeUri");
		NativeFieldInfoPtr_VsMacrosUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "VsMacrosUri");
		NativeFieldInfoPtr_s_QuirksVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "s_QuirksVersion");
		NativeFieldInfoPtr_HttpSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpSyntaxFlags");
		NativeFieldInfoPtr_FileSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FileSyntaxFlags");
		NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664307);
		NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664308);
		NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664309);
		NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664310);
		NativeMethodInfoPtr_IsBaseOf_Protected_Virtual_New_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664311);
		NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664312);
		NativeMethodInfoPtr_IsWellFormedOriginalString_Protected_Virtual_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664313);
		NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664314);
		NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664316);
		NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664317);
		NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664318);
		NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664319);
		NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664320);
		NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664322);
		NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664323);
		NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664324);
		NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664325);
		NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664327);
		NativeMethodInfoPtr_InternalIsBaseOf_Internal_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664328);
		NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664329);
		NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100664330);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual UriParser OnNewUri()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871402, XrefRangeEnd = 871405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		parsingError = ((num3 == 0) ? null : new UriFormatException(num3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871405, XrefRangeEnd = 871414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeUri);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		parsingError = ((num3 == 0) ? null : new UriFormatException(num3));
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871414, XrefRangeEnd = 871416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsBaseOf(Uri baseUri, Uri relativeUri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)relativeUri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsBaseOf_Protected_Virtual_New_Boolean_Uri_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871416, XrefRangeEnd = 871458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		*(UriComponents**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &components;
		*(UriFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871458, XrefRangeEnd = 871460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsWellFormedOriginalString(Uri uri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsWellFormedOriginalString_Protected_Virtual_New_Boolean_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 871473, RefRangeEnd = 871476, XrefRangeStart = 871470, XrefRangeEnd = 871473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool NotAny(UriSyntaxFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 871479, RefRangeEnd = 871514, XrefRangeStart = 871476, XrefRangeEnd = 871479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InFact(UriSyntaxFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871517, RefRangeEnd = 871518, XrefRangeStart = 871514, XrefRangeEnd = 871517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAllSet(UriSyntaxFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871518, XrefRangeEnd = 871521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&flags);
		*(UriSyntaxFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &expected;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871521, XrefRangeEnd = 871524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UriParser(UriSyntaxFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriParser>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871570, RefRangeEnd = 871571, XrefRangeStart = 871524, XrefRangeEnd = 871570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871571, XrefRangeEnd = 871583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UriParser GetSyntax(string lwrCaseScheme)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871598, XrefRangeEnd = 871599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UriParser InternalOnNewUri()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe void InternalValidate(Uri thisUri, out UriFormatException parsingError)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisUri);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		parsingError = ((num3 == 0) ? null : new UriFormatException(num3));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 871599, RefRangeEnd = 871603, XrefRangeStart = 871599, XrefRangeEnd = 871599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisBaseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uriLink);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		parsingError = ((num3 == 0) ? null : new UriFormatException(num3));
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871603, RefRangeEnd = 871604, XrefRangeStart = 871603, XrefRangeEnd = 871603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisBaseUri);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uriLink);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalIsBaseOf_Internal_Boolean_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 871604, RefRangeEnd = 871607, XrefRangeStart = 871604, XrefRangeEnd = 871604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisUri);
		*(UriComponents**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriComponents;
		*(UriFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uriFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 871607, RefRangeEnd = 871610, XrefRangeStart = 871607, XrefRangeEnd = 871607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InternalIsWellFormedOriginalString(Uri thisUri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisUri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalIsWellFormedOriginalString_Internal_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public UriParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
