using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public sealed class AI01320xDecoder : AI013x0xDecoder
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_addWeightCode_Protected_Virtual_Void_StringBuilder_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_checkWeight_Protected_Virtual_Int32_Int32_0;

	static AI01320xDecoder()
	{
		Il2CppClassPointerStore<AI01320xDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "AI01320xDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AI01320xDecoder>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01320xDecoder>.NativeClassPtr, 100664343);
		NativeMethodInfoPtr_addWeightCode_Protected_Virtual_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01320xDecoder>.NativeClassPtr, 100664344);
		NativeMethodInfoPtr_checkWeight_Protected_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01320xDecoder>.NativeClassPtr, 100664345);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424946, XrefRangeEnd = 1424953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AI01320xDecoder(BitArray information)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AI01320xDecoder>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424953, XrefRangeEnd = 1424960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void addWeightCode(StringBuilder buf, int weight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &weight;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addWeightCode_Protected_Virtual_Void_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override int checkWeight(int weight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkWeight_Protected_Virtual_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AI01320xDecoder(IntPtr pointer)
		: base(pointer)
	{
	}
}
