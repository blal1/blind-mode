using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public static class FieldParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_VARIABLE_LENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_TWO_DIGIT_DATA_LENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_THREE_DIGIT_DATA_LENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOUR_DIGIT_DATA_LENGTH;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseFieldsInGeneralPurpose_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_processFixedAI_Private_Static_String_Int32_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_processVariableAI_Private_Static_String_Int32_Int32_String_0;

	public unsafe static Il2CppSystem.Object VARIABLE_LENGTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VARIABLE_LENGTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VARIABLE_LENGTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>> TWO_DIGIT_DATA_LENGTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TWO_DIGIT_DATA_LENGTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TWO_DIGIT_DATA_LENGTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>> THREE_DIGIT_DATA_LENGTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THREE_DIGIT_DATA_LENGTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THREE_DIGIT_DATA_LENGTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>> THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>> FOUR_DIGIT_DATA_LENGTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FOUR_DIGIT_DATA_LENGTH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<string, Il2CppReferenceArray<Il2CppSystem.Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FOUR_DIGIT_DATA_LENGTH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static FieldParser()
	{
		Il2CppClassPointerStore<FieldParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "FieldParser");
		NativeFieldInfoPtr_VARIABLE_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldParser>.NativeClassPtr, "VARIABLE_LENGTH");
		NativeFieldInfoPtr_TWO_DIGIT_DATA_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldParser>.NativeClassPtr, "TWO_DIGIT_DATA_LENGTH");
		NativeFieldInfoPtr_THREE_DIGIT_DATA_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldParser>.NativeClassPtr, "THREE_DIGIT_DATA_LENGTH");
		NativeFieldInfoPtr_THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldParser>.NativeClassPtr, "THREE_DIGIT_PLUS_DIGIT_DATA_LENGTH");
		NativeFieldInfoPtr_FOUR_DIGIT_DATA_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldParser>.NativeClassPtr, "FOUR_DIGIT_DATA_LENGTH");
		NativeMethodInfoPtr_parseFieldsInGeneralPurpose_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldParser>.NativeClassPtr, 100664407);
		NativeMethodInfoPtr_processFixedAI_Private_Static_String_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldParser>.NativeClassPtr, 100664408);
		NativeMethodInfoPtr_processVariableAI_Private_Static_String_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldParser>.NativeClassPtr, 100664409);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1425324, RefRangeEnd = 1425329, XrefRangeStart = 1425245, XrefRangeEnd = 1425324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string parseFieldsInGeneralPurpose(string rawInformation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawInformation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseFieldsInGeneralPurpose_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1425341, RefRangeEnd = 1425344, XrefRangeStart = 1425329, XrefRangeEnd = 1425341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string processFixedAI(int aiSize, int fieldSize, string rawInformation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&aiSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fieldSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rawInformation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_processFixedAI_Private_Static_String_Int32_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1425360, RefRangeEnd = 1425363, XrefRangeStart = 1425344, XrefRangeEnd = 1425360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string processVariableAI(int aiSize, int variableFieldSize, string rawInformation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&aiSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &variableFieldSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rawInformation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_processVariableAI_Private_Static_String_Int32_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public FieldParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
