using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine;

public class CurveTimeline : Timeline
{
	private static readonly IntPtr NativeFieldInfoPtr_curves;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Il2CppStringArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetStepped_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Shrink_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetBezier_Public_Void_Int32_Int32_Int32_Single_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBezierValue_Public_Single_Single_Int32_Int32_Int32_0;

	public unsafe Il2CppStructArray<float> curves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curves);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curves)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CurveTimeline()
	{
		Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "CurveTimeline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr);
		NativeFieldInfoPtr_curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr, "curves");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_SetStepped_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_Shrink_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_SetBezier_Public_Void_Int32_Int32_Int32_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_GetBezierValue_Public_Single_Single_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr, 100663345);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 840717, RefRangeEnd = 840727, XrefRangeStart = 840707, XrefRangeEnd = 840717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveTimeline(int frameCount, int bezierCount, [Optional] Il2CppStringArray propertyIds)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		if (propertyIds == null)
		{
			propertyIds = new Il2CppStringArray(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveTimeline>.NativeClassPtr));
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&frameCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &bezierCount;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyIds);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 840727, RefRangeEnd = 840738, XrefRangeStart = 840727, XrefRangeEnd = 840727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStepped(int frame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&frame);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStepped_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 840743, RefRangeEnd = 840753, XrefRangeStart = 840738, XrefRangeEnd = 840743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Shrink(int bezierCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&bezierCount);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shrink_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 840753, RefRangeEnd = 840759, XrefRangeStart = 840753, XrefRangeEnd = 840753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBezier(int bezier, int frame, int value, float time1, float value1, float cx1, float cy1, float cx2, float cy2, float time2, float value2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[11];
		*ptr = (nint)(&bezier);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &frame;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &time1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &value1;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &cx1;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &cy1;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &cx2;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)))) = &cy2;
		*(float**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(IntPtr)))) = &time2;
		*(float**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(IntPtr)))) = &value2;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBezier_Public_Void_Int32_Int32_Int32_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 840759, RefRangeEnd = 840788, XrefRangeStart = 840759, XrefRangeEnd = 840759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBezierValue(float time, int frameIndex, int valueOffset, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&time);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &frameIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &valueOffset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &i;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBezierValue_Public_Single_Single_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CurveTimeline(int frameCount, int bezierCount, params string[] propertyIds)
		: this(frameCount, bezierCount, new Il2CppStringArray(propertyIds))
	{
	}//IL_0004: Unknown result type (might be due to invalid IL or missing references)
	//IL_000e: Expected O, but got Unknown


	public CurveTimeline(IntPtr pointer)
		: base(pointer)
	{
	}
}
