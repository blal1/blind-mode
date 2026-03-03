using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security.Util;

public sealed class Tokenizer : Object
{
	[OriginalName("mscorlib.dll", "", "TokenSource")]
	public enum TokenSource
	{
		UnicodeByteArray,
		UTF8ByteArray,
		ASCIIByteArray,
		CharArray,
		String,
		NestedStrings,
		Other
	}

	[System.Serializable]
	public sealed class StringMaker : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_aStrings;

		private static readonly System.IntPtr NativeFieldInfoPtr_cStringsMax;

		private static readonly System.IntPtr NativeFieldInfoPtr_cStringsUsed;

		private static readonly System.IntPtr NativeFieldInfoPtr__outStringBuilder;

		private static readonly System.IntPtr NativeFieldInfoPtr__outChars;

		private static readonly System.IntPtr NativeFieldInfoPtr__outIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MakeString_Public_String_0;

		public unsafe Il2CppStringArray aStrings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aStrings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aStrings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe uint cStringsMax
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cStringsMax);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cStringsMax)) = value;
			}
		}

		public unsafe uint cStringsUsed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cStringsUsed);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cStringsUsed)) = value;
			}
		}

		public unsafe StringBuilder _outStringBuilder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outStringBuilder);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outStringBuilder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<char> _outChars
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outChars);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outChars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int _outIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outIndex)) = value;
			}
		}

		static StringMaker()
		{
			Il2CppClassPointerStore<StringMaker>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "StringMaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringMaker>.NativeClassPtr);
			NativeFieldInfoPtr_aStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, "aStrings");
			NativeFieldInfoPtr_cStringsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, "cStringsMax");
			NativeFieldInfoPtr_cStringsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, "cStringsUsed");
			NativeFieldInfoPtr__outStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, "_outStringBuilder");
			NativeFieldInfoPtr__outChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, "_outChars");
			NativeFieldInfoPtr__outIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, "_outIndex");
			NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, 100669122);
			NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, 100669123);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, 100669124);
			NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, 100669125);
			NativeMethodInfoPtr_MakeString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringMaker>.NativeClassPtr, 100669126);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 783923, RefRangeEnd = 783924, XrefRangeStart = 783922, XrefRangeEnd = 783923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint HashString(string str)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static uint HashCharArray(Il2CppStructArray<char> a, int l)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &l;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 783933, RefRangeEnd = 783934, XrefRangeStart = 783924, XrefRangeEnd = 783933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringMaker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringMaker>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783934, XrefRangeEnd = 783935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareStringAndChars(string str, Il2CppStructArray<char> a, int l)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &l;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 783945, RefRangeEnd = 783948, XrefRangeStart = 783935, XrefRangeEnd = 783945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MakeString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public StringMaker(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ITokenReader : Il2CppObjectBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0;

		static ITokenReader()
		{
			Il2CppClassPointerStore<ITokenReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "ITokenReader");
			NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITokenReader>.NativeClassPtr, 100669127);
		}

		[CallerCount(0)]
		public unsafe virtual int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public ITokenReader(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class StreamTokenReader : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__in;

		private static readonly System.IntPtr NativeFieldInfoPtr__numCharRead;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0;

		public unsafe StreamReader _in
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__in);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamReader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__in)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int _numCharRead
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numCharRead);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numCharRead)) = value;
			}
		}

		public unsafe int NumCharEncountered
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static StreamTokenReader()
		{
			Il2CppClassPointerStore<StreamTokenReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "StreamTokenReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamTokenReader>.NativeClassPtr);
			NativeFieldInfoPtr__in = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamTokenReader>.NativeClassPtr, "_in");
			NativeFieldInfoPtr__numCharRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamTokenReader>.NativeClassPtr, "_numCharRead");
			NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamTokenReader>.NativeClassPtr, 100669128);
			NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamTokenReader>.NativeClassPtr, 100669129);
			NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamTokenReader>.NativeClassPtr, 100669130);
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 485632, RefRangeEnd = 485641, XrefRangeStart = 485632, XrefRangeEnd = 485641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamTokenReader(StreamReader input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamTokenReader>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public StreamTokenReader(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_LineNo;

	private static readonly System.IntPtr NativeFieldInfoPtr__inProcessingTag;

	private static readonly System.IntPtr NativeFieldInfoPtr__inBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr__inChars;

	private static readonly System.IntPtr NativeFieldInfoPtr__inString;

	private static readonly System.IntPtr NativeFieldInfoPtr__inIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__inSize;

	private static readonly System.IntPtr NativeFieldInfoPtr__inSavedCharacter;

	private static readonly System.IntPtr NativeFieldInfoPtr__inTokenSource;

	private static readonly System.IntPtr NativeFieldInfoPtr__inTokenReader;

	private static readonly System.IntPtr NativeFieldInfoPtr__maker;

	private static readonly System.IntPtr NativeFieldInfoPtr__searchStrings;

	private static readonly System.IntPtr NativeFieldInfoPtr__replaceStrings;

	private static readonly System.IntPtr NativeFieldInfoPtr__inNestedIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__inNestedSize;

	private static readonly System.IntPtr NativeFieldInfoPtr__inNestedString;

	private static readonly System.IntPtr NativeMethodInfoPtr_BasicInitialization_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Recycle_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringToken_Private_String_0;

	public unsafe int LineNo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LineNo);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LineNo)) = value;
		}
	}

	public unsafe int _inProcessingTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inProcessingTag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inProcessingTag)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> _inBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inBytes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inBytes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<char> _inChars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inChars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inChars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _inString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int _inIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inIndex)) = value;
		}
	}

	public unsafe int _inSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inSize)) = value;
		}
	}

	public unsafe int _inSavedCharacter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inSavedCharacter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inSavedCharacter)) = value;
		}
	}

	public unsafe TokenSource _inTokenSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inTokenSource);
			return *(TokenSource*)num;
		}
		set
		{
			*(TokenSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inTokenSource)) = value;
		}
	}

	public unsafe ITokenReader _inTokenReader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inTokenReader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITokenReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inTokenReader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StringMaker _maker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringMaker>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray _searchStrings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__searchStrings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__searchStrings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray _replaceStrings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__replaceStrings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__replaceStrings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _inNestedIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inNestedIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inNestedIndex)) = value;
		}
	}

	public unsafe int _inNestedSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inNestedSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inNestedSize)) = value;
		}
	}

	public unsafe string _inNestedString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inNestedString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inNestedString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static Tokenizer()
	{
		Il2CppClassPointerStore<Tokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "Tokenizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr);
		NativeFieldInfoPtr_LineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "LineNo");
		NativeFieldInfoPtr__inProcessingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inProcessingTag");
		NativeFieldInfoPtr__inBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inBytes");
		NativeFieldInfoPtr__inChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inChars");
		NativeFieldInfoPtr__inString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inString");
		NativeFieldInfoPtr__inIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inIndex");
		NativeFieldInfoPtr__inSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inSize");
		NativeFieldInfoPtr__inSavedCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inSavedCharacter");
		NativeFieldInfoPtr__inTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inTokenSource");
		NativeFieldInfoPtr__inTokenReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inTokenReader");
		NativeFieldInfoPtr__maker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_maker");
		NativeFieldInfoPtr__searchStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_searchStrings");
		NativeFieldInfoPtr__replaceStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_replaceStrings");
		NativeFieldInfoPtr__inNestedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedIndex");
		NativeFieldInfoPtr__inNestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedSize");
		NativeFieldInfoPtr__inNestedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedString");
		NativeMethodInfoPtr_BasicInitialization_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669116);
		NativeMethodInfoPtr_Recycle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669117);
		NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669118);
		NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669119);
		NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669120);
		NativeMethodInfoPtr_GetStringToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100669121);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783948, XrefRangeEnd = 783953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BasicInitialization()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BasicInitialization_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783953, XrefRangeEnd = 783957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Recycle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Recycle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783957, XrefRangeEnd = 783964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Tokenizer(string input)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 783970, RefRangeEnd = 783971, XrefRangeStart = 783964, XrefRangeEnd = 783970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeFormat(Encoding encoding)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 783996, RefRangeEnd = 783999, XrefRangeStart = 783971, XrefRangeEnd = 783996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxNum;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endAfterKet;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783999, XrefRangeEnd = 784001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetStringToken()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public Tokenizer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
