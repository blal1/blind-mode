using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public static class ParameterizedStrings : Object
{
	public sealed class FormatParam : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__int32;

		private static readonly System.IntPtr NativeFieldInfoPtr__string;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Int32_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_String_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Object_Public_get_Object_0;

		public unsafe int _int32
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__int32);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__int32)) = value;
			}
		}

		public unsafe string _string
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__string);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__string)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int Int32
		{
			[CallerCount(175)]
			[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Int32_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe string String
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764960, XrefRangeEnd = 764961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_String_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe Object Object
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764961, XrefRangeEnd = 764963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Object_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
		}

		static FormatParam()
		{
			Il2CppClassPointerStore<FormatParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "FormatParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatParam>.NativeClassPtr);
			NativeFieldInfoPtr__int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatParam>.NativeClassPtr, "_int32");
			NativeFieldInfoPtr__string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatParam>.NativeClassPtr, "_string");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatParam>.NativeClassPtr, 100667309);
			NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatParam>.NativeClassPtr, 100667310);
			NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatParam>.NativeClassPtr, 100667311);
			NativeMethodInfoPtr_get_Int32_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatParam>.NativeClassPtr, 100667312);
			NativeMethodInfoPtr_get_String_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatParam>.NativeClassPtr, 100667313);
			NativeMethodInfoPtr_get_Object_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatParam>.NativeClassPtr, 100667314);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764958, XrefRangeEnd = 764959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatParam(int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatParam>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 506934, RefRangeEnd = 506965, XrefRangeStart = 506934, XrefRangeEnd = 506965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatParam(int intValue, string stringValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatParam>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&intValue);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(stringValue);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764959, XrefRangeEnd = 764960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator FormatParam(int value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new FormatParam(pointer);
		}

		public FormatParam(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FormatParam()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatParam>.NativeClassPtr))
		{
		}
	}

	public sealed class LowLevelStack : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__arr;

		private static readonly System.IntPtr NativeFieldInfoPtr__count;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Pop_Public_FormatParam_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Push_Public_Void_FormatParam_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		public unsafe Il2CppReferenceArray<FormatParam> _arr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__arr);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FormatParam>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__arr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int _count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__count);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__count)) = value;
			}
		}

		static LowLevelStack()
		{
			Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "LowLevelStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr);
			NativeFieldInfoPtr__arr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr, "_arr");
			NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr, "_count");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr, 100667315);
			NativeMethodInfoPtr_Pop_Public_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr, 100667316);
			NativeMethodInfoPtr_Push_Public_Void_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr, 100667317);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr, 100667318);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764963, XrefRangeEnd = 764967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelStack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelStack>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 764967, RefRangeEnd = 764979, XrefRangeStart = 764967, XrefRangeEnd = 764967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatParam Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pop_Public_FormatParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new FormatParam(pointer);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 764987, RefRangeEnd = 764993, XrefRangeStart = 764979, XrefRangeEnd = 764987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(FormatParam item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)item));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Push_Public_Void_FormatParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764993, XrefRangeEnd = 764994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LowLevelStack(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedStack;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0;

	public unsafe static LowLevelStack _cachedStack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__cachedStack, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LowLevelStack>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__cachedStack, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ParameterizedStrings()
	{
		Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParameterizedStrings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr);
		NativeFieldInfoPtr__cachedStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "_cachedStack");
		NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667300);
		NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667301);
		NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667302);
		NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667303);
		NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667304);
		NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667305);
		NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667306);
		NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667307);
		NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667308);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764994, XrefRangeEnd = 765012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Evaluate(string format, [Optional] Il2CppReferenceArray<FormatParam> args)
	{
		if (args == null)
		{
			args = (Il2CppReferenceArray<FormatParam>)(object)new Il2CppStructArray<FormatParam>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 765137, RefRangeEnd = 765141, XrefRangeStart = 765012, XrefRangeEnd = 765137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EvaluateInternal(string format, ref int pos, Il2CppReferenceArray<FormatParam> args, LowLevelStack stack, ref Il2CppReferenceArray<FormatParam> dynamicVars, ref Il2CppReferenceArray<FormatParam> staticVars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicVars);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)staticVars);
		*(System.IntPtr**)num2 = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		dynamicVars = ((intPtr5 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<FormatParam>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		staticVars = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<FormatParam>(intPtr6));
		return IL2CPP.Il2CppStringToManaged(intPtr4);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 564182, RefRangeEnd = 564187, XrefRangeStart = 564182, XrefRangeEnd = 564187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AsBool(int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 721956, RefRangeEnd = 721972, XrefRangeStart = 721956, XrefRangeEnd = 721972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AsInt(bool b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765141, XrefRangeEnd = 765146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StringFromAsciiBytes(Il2CppStructArray<byte> buffer, int offset, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 765152, RefRangeEnd = 765154, XrefRangeStart = 765146, XrefRangeEnd = 765152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int snprintf(byte* str, System.IntPtr size, string format, string arg1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)str;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 765158, RefRangeEnd = 765160, XrefRangeStart = 765154, XrefRangeEnd = 765158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int snprintf(byte* str, System.IntPtr size, string format, int arg1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)str;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &arg1;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 765179, RefRangeEnd = 765180, XrefRangeStart = 765160, XrefRangeEnd = 765179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatPrintF(string format, Object arg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 765187, RefRangeEnd = 765189, XrefRangeStart = 765180, XrefRangeEnd = 765187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<FormatParam> GetDynamicOrStaticVariables(char c, ref Il2CppReferenceArray<FormatParam> dynamicVars, ref Il2CppReferenceArray<FormatParam> staticVars, out int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&c);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicVars);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)staticVars);
		*(System.IntPtr**)num2 = &intPtr2;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		dynamicVars = ((intPtr5 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<FormatParam>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		staticVars = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<FormatParam>(intPtr6));
		return (intPtr4 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FormatParam>>(intPtr4) : null;
	}

	public static string Evaluate(string format, params FormatParam[] args)
	{
		return Evaluate(format, new Il2CppReferenceArray<FormatParam>(args));
	}

	public ParameterizedStrings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
