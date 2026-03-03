using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class UINumericFieldsUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_AllowedCharactersForFloat;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_AllowedCharactersForInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DoubleFieldFormatString;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FloatFieldFormatString;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_IntFieldFormatString;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0;

	public unsafe static string k_AllowedCharactersForFloat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_AllowedCharactersForFloat, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_AllowedCharactersForFloat, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_AllowedCharactersForInt
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_AllowedCharactersForInt, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_AllowedCharactersForInt, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_DoubleFieldFormatString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DoubleFieldFormatString, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DoubleFieldFormatString, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_FloatFieldFormatString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FloatFieldFormatString, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FloatFieldFormatString, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_IntFieldFormatString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_IntFieldFormatString, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_IntFieldFormatString, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static UINumericFieldsUtils()
	{
		Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UINumericFieldsUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr);
		NativeFieldInfoPtr_k_AllowedCharactersForFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_AllowedCharactersForFloat");
		NativeFieldInfoPtr_k_AllowedCharactersForInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_AllowedCharactersForInt");
		NativeFieldInfoPtr_k_DoubleFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_DoubleFieldFormatString");
		NativeFieldInfoPtr_k_FloatFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_FloatFieldFormatString");
		NativeFieldInfoPtr_k_IntFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_IntFieldFormatString");
		NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666789);
		NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666790);
		NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666791);
		NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666792);
		NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666793);
		NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666794);
		NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666795);
		NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666796);
		NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666797);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1216862, RefRangeEnd = 1216866, XrefRangeStart = 1216836, XrefRangeEnd = 1216862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToDouble(string str, out double value, out ExpressionEvaluator.Expression expr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expr = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1216877, RefRangeEnd = 1216878, XrefRangeStart = 1216866, XrefRangeEnd = 1216877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value, out ExpressionEvaluator.Expression expression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expression = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1216893, RefRangeEnd = 1216895, XrefRangeStart = 1216878, XrefRangeEnd = 1216893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value, out ExpressionEvaluator.Expression expression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expression = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1216901, RefRangeEnd = 1216902, XrefRangeStart = 1216895, XrefRangeEnd = 1216901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToLong(string str, out long value, out ExpressionEvaluator.Expression expr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expr = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1216918, RefRangeEnd = 1216921, XrefRangeStart = 1216902, XrefRangeEnd = 1216918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToLong(string str, string initialValueAsString, out long value, out ExpressionEvaluator.Expression expression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expression = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1216927, RefRangeEnd = 1216928, XrefRangeStart = 1216921, XrefRangeEnd = 1216927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToULong(string str, out ulong value, out ExpressionEvaluator.Expression expr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expr = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1216944, RefRangeEnd = 1216945, XrefRangeStart = 1216928, XrefRangeEnd = 1216944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value, out ExpressionEvaluator.Expression expression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expression = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1216950, RefRangeEnd = 1216952, XrefRangeStart = 1216945, XrefRangeEnd = 1216950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToInt(string str, string initialValueAsString, out int value, out ExpressionEvaluator.Expression expression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expression = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1216957, RefRangeEnd = 1216958, XrefRangeStart = 1216952, XrefRangeEnd = 1216957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value, out ExpressionEvaluator.Expression expression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		expression = ((num3 == 0) ? null : new ExpressionEvaluator.Expression(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public UINumericFieldsUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool TryConvertStringToDouble(string str, out double value)
	{
		ExpressionEvaluator.Expression expr;
		return TryConvertStringToDouble(str, out value, out expr);
	}

	public static bool TryConvertStringToLong(string str, out long value)
	{
		ExpressionEvaluator.Expression delayed;
		return ExpressionEvaluator.Evaluate<long>(str, out value, out delayed);
	}
}
