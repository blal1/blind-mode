using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization;

public class HebrewNumber : Object
{
	[OriginalName("mscorlib.dll", "", "HebrewToken")]
	public enum HebrewToken : short
	{
		Invalid = -1,
		Digit400,
		Digit200_300,
		Digit100,
		Digit10,
		Digit1,
		Digit6_7,
		Digit7,
		Digit9,
		SingleQuote,
		DoubleQuote
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct HebrewValue
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_token;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int16_0;

		[FieldOffset(0)]
		public HebrewToken token;

		[FieldOffset(2)]
		public short value;

		static HebrewValue()
		{
			Il2CppClassPointerStore<HebrewValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "HebrewValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewValue>.NativeClassPtr);
			NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewValue>.NativeClassPtr, "token");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewValue>.NativeClassPtr, "value");
			NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewValue>.NativeClassPtr, 100672800);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 817658, RefRangeEnd = 817659, XrefRangeStart = 817658, XrefRangeEnd = 817658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HebrewValue(HebrewToken token, short value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&token);
			*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_HebrewToken_Int16_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HebrewValue>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[OriginalName("mscorlib.dll", "", "HS")]
	public enum HS : sbyte
	{
		_err = -1,
		Start = 0,
		S400 = 1,
		S400_400 = 2,
		S400_X00 = 3,
		S400_X0 = 4,
		X00_DQ = 5,
		S400_X00_X0 = 6,
		X0_DQ = 7,
		X = 8,
		X0 = 9,
		X00 = 10,
		S400_DQ = 11,
		S400_400_DQ = 12,
		S400_400_100 = 13,
		S9 = 14,
		X00_S9 = 15,
		S9_DQ = 16,
		END = 100
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_hebrewValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_maxHebrewNumberCh;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_numberPasingState;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0;

	public unsafe static Il2CppStructArray<HebrewValue> s_hebrewValues
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_hebrewValues, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<HebrewValue>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_hebrewValues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static char s_maxHebrewNumberCh
	{
		get
		{
			Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_maxHebrewNumberCh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_maxHebrewNumberCh, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<HS> s_numberPasingState
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_numberPasingState, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<HS>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_numberPasingState, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static HebrewNumber()
	{
		Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HebrewNumber");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr);
		NativeFieldInfoPtr_s_hebrewValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "s_hebrewValues");
		NativeFieldInfoPtr_s_maxHebrewNumberCh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "s_maxHebrewNumberCh");
		NativeFieldInfoPtr_s_numberPasingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, "s_numberPasingState");
		NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100672796);
		NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100672797);
		NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumber>.NativeClassPtr, 100672798);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 817705, RefRangeEnd = 817709, XrefRangeStart = 817659, XrefRangeEnd = 817705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToString(int Number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Internal_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 817718, RefRangeEnd = 817720, XrefRangeStart = 817709, XrefRangeEnd = 817718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ch);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseByChar_Internal_Static_HebrewNumberParsingState_Char_byref_HebrewNumberParsingContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HebrewNumberParsingState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 817720, XrefRangeEnd = 817726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsDigit(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDigit_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public HebrewNumber(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
