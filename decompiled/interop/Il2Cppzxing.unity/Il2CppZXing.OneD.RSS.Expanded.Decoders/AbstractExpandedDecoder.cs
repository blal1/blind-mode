using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public class AbstractExpandedDecoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_information;

	private static readonly System.IntPtr NativeFieldInfoPtr_generalDecoder;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInformation_Protected_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getGeneralDecoder_Internal_GeneralAppIdDecoder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseInformation_Public_Abstract_Virtual_New_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createDecoder_Public_Static_AbstractExpandedDecoder_BitArray_0;

	public unsafe BitArray information
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_information);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_information)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GeneralAppIdDecoder generalDecoder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generalDecoder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GeneralAppIdDecoder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generalDecoder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AbstractExpandedDecoder()
	{
		Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "AbstractExpandedDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr);
		NativeFieldInfoPtr_information = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr, "information");
		NativeFieldInfoPtr_generalDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr, "generalDecoder");
		NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr, 100664335);
		NativeMethodInfoPtr_getInformation_Protected_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr, 100664336);
		NativeMethodInfoPtr_getGeneralDecoder_Internal_GeneralAppIdDecoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr, 100664337);
		NativeMethodInfoPtr_parseInformation_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr, 100664338);
		NativeMethodInfoPtr_createDecoder_Public_Static_AbstractExpandedDecoder_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr, 100664339);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1424873, RefRangeEnd = 1424884, XrefRangeStart = 1424855, XrefRangeEnd = 1424873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AbstractExpandedDecoder(BitArray information)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractExpandedDecoder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitArray getInformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInformation_Protected_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GeneralAppIdDecoder getGeneralDecoder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getGeneralDecoder_Internal_GeneralAppIdDecoder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GeneralAppIdDecoder>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual string parseInformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_parseInformation_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1424934, RefRangeEnd = 1424935, XrefRangeStart = 1424884, XrefRangeEnd = 1424934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AbstractExpandedDecoder createDecoder(BitArray information)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createDecoder_Public_Static_AbstractExpandedDecoder_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AbstractExpandedDecoder>(intPtr2) : null;
	}

	public AbstractExpandedDecoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
