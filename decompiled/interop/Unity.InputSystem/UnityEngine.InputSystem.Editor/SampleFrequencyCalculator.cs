using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.Editor;

[StructLayout(LayoutKind.Explicit)]
public struct SampleFrequencyCalculator
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastUpdateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SampleCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__targetFrequency_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__frequency_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_targetFrequency_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_targetFrequency_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frequency_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_frequency_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSample_Public_Void_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Boolean_Double_0;

	[FieldOffset(0)]
	public double m_LastUpdateTime;

	[FieldOffset(8)]
	public int m_SampleCount;

	[FieldOffset(12)]
	public float _targetFrequency_k__BackingField;

	[FieldOffset(16)]
	public float _frequency_k__BackingField;

	public unsafe float targetFrequency
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_targetFrequency_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1007802, RefRangeEnd = 1007805, XrefRangeStart = 1007802, XrefRangeEnd = 1007802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_targetFrequency_Private_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float frequency
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frequency_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355316, RefRangeEnd = 355317, XrefRangeStart = 355316, XrefRangeEnd = 355317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_frequency_Private_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static SampleFrequencyCalculator()
	{
		Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Editor", "SampleFrequencyCalculator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr);
		NativeFieldInfoPtr_m_LastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, "m_LastUpdateTime");
		NativeFieldInfoPtr_m_SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, "m_SampleCount");
		NativeFieldInfoPtr__targetFrequency_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, "<targetFrequency>k__BackingField");
		NativeFieldInfoPtr__frequency_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, "<frequency>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, 100667279);
		NativeMethodInfoPtr_get_targetFrequency_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, 100667280);
		NativeMethodInfoPtr_set_targetFrequency_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, 100667281);
		NativeMethodInfoPtr_get_frequency_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, 100667282);
		NativeMethodInfoPtr_set_frequency_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, 100667283);
		NativeMethodInfoPtr_ProcessSample_Public_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, 100667284);
		NativeMethodInfoPtr_Update_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, 100667285);
		NativeMethodInfoPtr_Update_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, 100667286);
	}

	[CallerCount(0)]
	public unsafe SampleFrequencyCalculator(float targetFrequency, double realtimeSinceStartup)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetFrequency);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &realtimeSinceStartup;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ProcessSample(InputEventPtr eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessSample_Public_Void_InputEventPtr_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007805, XrefRangeEnd = 1007806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool Update(double realtimeSinceStartup)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&realtimeSinceStartup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Boolean_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SampleFrequencyCalculator>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
