using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Utilities;

[StructLayout(LayoutKind.Explicit)]
public struct PredictiveParser
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpectSingleChar_Public_Void_ReadOnlySpan_1_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpectInt_Public_Int32_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpectString_Public_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AcceptSingleChar_Public_Boolean_ReadOnlySpan_1_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AcceptString_Public_Boolean_ReadOnlySpan_1_Char_byref_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AcceptInt_Public_Void_ReadOnlySpan_1_Char_0;

	[FieldOffset(0)]
	public int m_Position;

	static PredictiveParser()
	{
		Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "PredictiveParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr);
		NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr, "m_Position");
		NativeMethodInfoPtr_ExpectSingleChar_Public_Void_ReadOnlySpan_1_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr, 100668926);
		NativeMethodInfoPtr_ExpectInt_Public_Int32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr, 100668927);
		NativeMethodInfoPtr_ExpectString_Public_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr, 100668928);
		NativeMethodInfoPtr_AcceptSingleChar_Public_Boolean_ReadOnlySpan_1_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr, 100668929);
		NativeMethodInfoPtr_AcceptString_Public_Boolean_ReadOnlySpan_1_Char_byref_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr, 100668930);
		NativeMethodInfoPtr_AcceptInt_Public_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr, 100668931);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 1020578, RefRangeEnd = 1020605, XrefRangeStart = 1020578, XrefRangeEnd = 1020578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExpectSingleChar(Il2CppSystem.ReadOnlySpan<char> str, char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpectSingleChar_Public_Void_ReadOnlySpan_1_Char_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1020606, RefRangeEnd = 1020627, XrefRangeStart = 1020605, XrefRangeEnd = 1020606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ExpectInt(Il2CppSystem.ReadOnlySpan<char> str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpectInt_Public_Int32_ReadOnlySpan_1_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1020633, RefRangeEnd = 1020648, XrefRangeStart = 1020627, XrefRangeEnd = 1020633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<char> ExpectString(Il2CppSystem.ReadOnlySpan<char> str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpectString_Public_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<char>(pointer);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 1020648, RefRangeEnd = 1020673, XrefRangeStart = 1020648, XrefRangeEnd = 1020648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AcceptSingleChar(Il2CppSystem.ReadOnlySpan<char> str, char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AcceptSingleChar_Public_Boolean_ReadOnlySpan_1_Char_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1020679, RefRangeEnd = 1020687, XrefRangeStart = 1020673, XrefRangeEnd = 1020679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AcceptString(Il2CppSystem.ReadOnlySpan<char> input, out Il2CppSystem.ReadOnlySpan<char> output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)input));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AcceptString_Public_Boolean_ReadOnlySpan_1_Char_byref_ReadOnlySpan_1_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		output = ((num3 == 0) ? null : new Il2CppSystem.ReadOnlySpan<char>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1020688, RefRangeEnd = 1020689, XrefRangeStart = 1020687, XrefRangeEnd = 1020688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AcceptInt(Il2CppSystem.ReadOnlySpan<char> str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AcceptInt_Public_Void_ReadOnlySpan_1_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PredictiveParser>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
