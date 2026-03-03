using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.OneD;

public class Code93Writer : OneDimensionalCodeWriter
{
	private static readonly IntPtr NativeFieldInfoPtr_supportedWriteFormats;

	private static readonly IntPtr NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_appendPattern_Private_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_computeChecksumIndex_Private_Static_Int32_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_convertToExtended_Internal_Static_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static IList<BarcodeFormat> supportedWriteFormats
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_supportedWriteFormats, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IList<BarcodeFormat>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_supportedWriteFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override IList<BarcodeFormat> SupportedWriteFormats
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421306, XrefRangeEnd = 1421310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IList<BarcodeFormat>>(intPtr2) : null;
		}
	}

	static Code93Writer()
	{
		Il2CppClassPointerStore<Code93Writer>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "Code93Writer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr);
		NativeFieldInfoPtr_supportedWriteFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr, "supportedWriteFormats");
		NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr_appendPattern_Private_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr, 100664090);
		NativeMethodInfoPtr_computeChecksumIndex_Private_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr, 100664091);
		NativeMethodInfoPtr_convertToExtended_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr, 100664092);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr, 100664093);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421310, XrefRangeEnd = 1421353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<bool> encode(string contents)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static int appendPattern(Il2CppStructArray<bool> target, int pos, int a)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &pos;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &a;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendPattern_Private_Static_Int32_Il2CppStructArray_1_Boolean_Int32_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421353, XrefRangeEnd = 1421357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int computeChecksumIndex(string contents, int maxWeight)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &maxWeight;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_computeChecksumIndex_Private_Static_Int32_String_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1421397, RefRangeEnd = 1421398, XrefRangeStart = 1421357, XrefRangeEnd = 1421397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string convertToExtended(string contents)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertToExtended_Internal_Static_String_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1421402, RefRangeEnd = 1421403, XrefRangeStart = 1421398, XrefRangeEnd = 1421402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Code93Writer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Code93Writer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Code93Writer(IntPtr pointer)
		: base(pointer)
	{
	}
}
