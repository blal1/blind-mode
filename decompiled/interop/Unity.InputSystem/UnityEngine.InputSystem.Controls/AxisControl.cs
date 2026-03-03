using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls;

public class AxisControl : InputControl<float>
{
	[OriginalName("Unity.InputSystem.dll", "", "Clamp")]
	public enum Clamp
	{
		None,
		BeforeNormalize,
		AfterNormalize,
		ToConstantBeforeNormalize
	}

	private static readonly IntPtr NativeFieldInfoPtr_clamp;

	private static readonly IntPtr NativeFieldInfoPtr_clampMin;

	private static readonly IntPtr NativeFieldInfoPtr_clampMax;

	private static readonly IntPtr NativeFieldInfoPtr_clampConstant;

	private static readonly IntPtr NativeFieldInfoPtr_invert;

	private static readonly IntPtr NativeFieldInfoPtr_normalize;

	private static readonly IntPtr NativeFieldInfoPtr_normalizeMin;

	private static readonly IntPtr NativeFieldInfoPtr_normalizeMax;

	private static readonly IntPtr NativeFieldInfoPtr_normalizeZero;

	private static readonly IntPtr NativeFieldInfoPtr_scale;

	private static readonly IntPtr NativeFieldInfoPtr_scaleFactor;

	private static readonly IntPtr NativeMethodInfoPtr_Preprocess_Protected_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Unpreprocess_Private_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Single_ptr_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_Void_Single_ptr_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CompareValue_Public_Virtual_Boolean_ptr_Void_ptr_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_ptr_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_EvaluateMagnitude_Private_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_FourCC_0;

	public unsafe Clamp clamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clamp);
			return *(Clamp*)num;
		}
		set
		{
			*(Clamp*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clamp)) = value;
		}
	}

	public unsafe float clampMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampMin)) = value;
		}
	}

	public unsafe float clampMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampMax)) = value;
		}
	}

	public unsafe float clampConstant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampConstant);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampConstant)) = value;
		}
	}

	public unsafe bool invert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invert);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invert)) = value;
		}
	}

	public unsafe bool normalize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalize);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalize)) = value;
		}
	}

	public unsafe float normalizeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalizeMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalizeMin)) = value;
		}
	}

	public unsafe float normalizeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalizeMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalizeMax)) = value;
		}
	}

	public unsafe float normalizeZero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalizeZero);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalizeZero)) = value;
		}
	}

	public unsafe bool scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = value;
		}
	}

	public unsafe float scaleFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaleFactor)) = value;
		}
	}

	static AxisControl()
	{
		Il2CppClassPointerStore<AxisControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Controls", "AxisControl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AxisControl>.NativeClassPtr);
		NativeFieldInfoPtr_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "clamp");
		NativeFieldInfoPtr_clampMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "clampMin");
		NativeFieldInfoPtr_clampMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "clampMax");
		NativeFieldInfoPtr_clampConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "clampConstant");
		NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "invert");
		NativeFieldInfoPtr_normalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "normalize");
		NativeFieldInfoPtr_normalizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "normalizeMin");
		NativeFieldInfoPtr_normalizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "normalizeMax");
		NativeFieldInfoPtr_normalizeZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "normalizeZero");
		NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "scale");
		NativeFieldInfoPtr_scaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, "scaleFactor");
		NativeMethodInfoPtr_Preprocess_Protected_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668393);
		NativeMethodInfoPtr_Unpreprocess_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668394);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668395);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668396);
		NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Single_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668397);
		NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_Void_Single_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668398);
		NativeMethodInfoPtr_CompareValue_Public_Virtual_Boolean_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668399);
		NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668400);
		NativeMethodInfoPtr_EvaluateMagnitude_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668401);
		NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AxisControl>.NativeClassPtr, 100668402);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1014159, RefRangeEnd = 1014161, XrefRangeStart = 1014155, XrefRangeEnd = 1014159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Preprocess(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Preprocess_Protected_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014161, XrefRangeEnd = 1014162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Unpreprocess(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unpreprocess_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(173)]
	[CachedScanResults(RefRangeStart = 1014169, RefRangeEnd = 1014342, XrefRangeStart = 1014162, XrefRangeEnd = 1014169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AxisControl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AxisControl>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1014352, RefRangeEnd = 1014355, XrefRangeStart = 1014342, XrefRangeEnd = 1014352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014355, XrefRangeEnd = 1014356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadUnprocessedValueFromState_Public_Virtual_Single_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014356, XrefRangeEnd = 1014357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WriteValueIntoState(float value, void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = statePtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WriteValueIntoState_Public_Virtual_Void_Single_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014357, XrefRangeEnd = 1014363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)firstStatePtr;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = secondStatePtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CompareValue_Public_Virtual_Boolean_ptr_Void_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014363, XrefRangeEnd = 1014372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float EvaluateMagnitude(void* statePtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)statePtr;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EvaluateMagnitude_Public_Virtual_Single_ptr_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014372, XrefRangeEnd = 1014378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float EvaluateMagnitude(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EvaluateMagnitude_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014378, XrefRangeEnd = 1014389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override FourCC CalculateOptimizedControlDataType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CalculateOptimizedControlDataType_Protected_Virtual_FourCC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AxisControl(IntPtr pointer)
		: base(pointer)
	{
	}
}
