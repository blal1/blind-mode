using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSpine;

public class CurveTimeline2 : CurveTimeline
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FrameEntries_Public_Virtual_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetFrame_Public_Void_Int32_Single_Single_Single_0;

	public unsafe override int FrameEntries
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 86858, RefRangeEnd = 86864, XrefRangeStart = 86858, XrefRangeEnd = 86864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_FrameEntries_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static CurveTimeline2()
	{
		Il2CppClassPointerStore<CurveTimeline2>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "CurveTimeline2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveTimeline2>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveTimeline2>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_get_FrameEntries_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveTimeline2>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_SetFrame_Public_Void_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveTimeline2>.NativeClassPtr, 100663356);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 840839, RefRangeEnd = 840842, XrefRangeStart = 840831, XrefRangeEnd = 840839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveTimeline2(int frameCount, int bezierCount, string propertyId1, string propertyId2)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveTimeline2>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&frameCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &bezierCount;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(propertyId1);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(propertyId2);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 840842, RefRangeEnd = 840844, XrefRangeStart = 840842, XrefRangeEnd = 840842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFrame(int frame, float time, float value1, float value2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&frame);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &time;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &value1;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &value2;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFrame_Public_Void_Int32_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CurveTimeline2(IntPtr pointer)
		: base(pointer)
	{
	}
}
