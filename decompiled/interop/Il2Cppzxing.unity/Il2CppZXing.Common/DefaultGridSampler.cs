using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppZXing.Common;

public sealed class DefaultGridSampler : GridSampler
{
	private static readonly IntPtr NativeMethodInfoPtr_sampleGrid_Public_Virtual_BitMatrix_BitMatrix_Int32_Int32_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_sampleGrid_Public_Virtual_BitMatrix_BitMatrix_Int32_Int32_PerspectiveTransform_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DefaultGridSampler()
	{
		Il2CppClassPointerStore<DefaultGridSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Common", "DefaultGridSampler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultGridSampler>.NativeClassPtr);
		NativeMethodInfoPtr_sampleGrid_Public_Virtual_BitMatrix_BitMatrix_Int32_Int32_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGridSampler>.NativeClassPtr, 100664743);
		NativeMethodInfoPtr_sampleGrid_Public_Virtual_BitMatrix_BitMatrix_Int32_Int32_PerspectiveTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGridSampler>.NativeClassPtr, 100664744);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultGridSampler>.NativeClassPtr, 100664745);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429095, XrefRangeEnd = 1429100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override BitMatrix sampleGrid(BitMatrix image, int dimensionX, int dimensionY, float p1ToX, float p1ToY, float p2ToX, float p2ToY, float p3ToX, float p3ToY, float p4ToX, float p4ToY, float p1FromX, float p1FromY, float p2FromX, float p2FromY, float p3FromX, float p3FromY, float p4FromX, float p4FromY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[19];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &dimensionX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &dimensionY;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &p1ToX;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &p1ToY;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &p2ToX;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &p2ToY;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &p3ToX;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)))) = &p3ToY;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(IntPtr)))) = &p4ToX;
		*(float**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(IntPtr)))) = &p4ToY;
		*(float**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(IntPtr)))) = &p1FromX;
		*(float**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(IntPtr)))) = &p1FromY;
		*(float**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(IntPtr)))) = &p2FromX;
		*(float**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(IntPtr)))) = &p2FromY;
		*(float**)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(IntPtr)))) = &p3FromX;
		*(float**)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(IntPtr)))) = &p3FromY;
		*(float**)((byte*)ptr + checked((nuint)17u * unchecked((nuint)sizeof(IntPtr)))) = &p4FromX;
		*(float**)((byte*)ptr + checked((nuint)18u * unchecked((nuint)sizeof(IntPtr)))) = &p4FromY;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sampleGrid_Public_Virtual_BitMatrix_BitMatrix_Int32_Int32_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429100, XrefRangeEnd = 1429117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override BitMatrix sampleGrid(BitMatrix image, int dimensionX, int dimensionY, PerspectiveTransform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &dimensionX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &dimensionY;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sampleGrid_Public_Virtual_BitMatrix_BitMatrix_Int32_Int32_PerspectiveTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429117, XrefRangeEnd = 1429121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DefaultGridSampler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultGridSampler>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DefaultGridSampler(IntPtr pointer)
		: base(pointer)
	{
	}
}
