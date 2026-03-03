using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct FrameData
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "Flags")]
	[System.Flags]
	public enum Flags
	{
		Evaluate = 1,
		SeekOccured = 2,
		Loop = 4,
		Hold = 8,
		EffectivePlayStateDelayed = 0x10,
		EffectivePlayStatePlaying = 0x20
	}

	[OriginalName("UnityEngine.CoreModule.dll", "", "EvaluationType")]
	public enum EvaluationType
	{
		Evaluate,
		Playback
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveParentDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveParentSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Output;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_weight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0;

	[FieldOffset(0)]
	public ulong m_FrameID;

	[FieldOffset(8)]
	public double m_DeltaTime;

	[FieldOffset(16)]
	public float m_Weight;

	[FieldOffset(20)]
	public float m_EffectiveWeight;

	[FieldOffset(24)]
	public double m_EffectiveParentDelay;

	[FieldOffset(32)]
	public float m_EffectiveParentSpeed;

	[FieldOffset(36)]
	public float m_EffectiveSpeed;

	[FieldOffset(40)]
	public Flags m_Flags;

	[FieldOffset(48)]
	public PlayableOutput m_Output;

	public unsafe float deltaTime
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229510, RefRangeEnd = 1229512, XrefRangeStart = 1229510, XrefRangeEnd = 1229510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float weight
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1153382, RefRangeEnd = 1153405, XrefRangeStart = 1153382, XrefRangeEnd = 1153405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weight_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float effectiveSpeed
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1157013, RefRangeEnd = 1157023, XrefRangeStart = 1157013, XrefRangeEnd = 1157023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe EvaluationType evaluationType
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229512, RefRangeEnd = 1229515, XrefRangeStart = 1229512, XrefRangeEnd = 1229512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EvaluationType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool seekOccurred
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229515, RefRangeEnd = 1229517, XrefRangeStart = 1229515, XrefRangeEnd = 1229515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool timeLooped
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1229517, RefRangeEnd = 1229524, XrefRangeStart = 1229517, XrefRangeEnd = 1229517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool timeHeld
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229524, RefRangeEnd = 1229525, XrefRangeStart = 1229524, XrefRangeEnd = 1229524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe PlayableOutput output
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1229525, RefRangeEnd = 1229529, XrefRangeStart = 1229525, XrefRangeEnd = 1229525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe PlayState effectivePlayState
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1229529, RefRangeEnd = 1229533, XrefRangeStart = 1229529, XrefRangeEnd = 1229529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public ulong frameId => m_FrameID;

	public float effectiveWeight => m_EffectiveWeight;

	public double effectiveParentDelay => m_EffectiveParentDelay;

	public float effectiveParentSpeed => m_EffectiveParentSpeed;

	static FrameData()
	{
		Il2CppClassPointerStore<FrameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "FrameData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameData>.NativeClassPtr);
		NativeFieldInfoPtr_m_FrameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_FrameID");
		NativeFieldInfoPtr_m_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_DeltaTime");
		NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Weight");
		NativeFieldInfoPtr_m_EffectiveWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveWeight");
		NativeFieldInfoPtr_m_EffectiveParentDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentDelay");
		NativeFieldInfoPtr_m_EffectiveParentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveParentSpeed");
		NativeFieldInfoPtr_m_EffectiveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_EffectiveSpeed");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, "m_Output");
		NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667367);
		NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667368);
		NativeMethodInfoPtr_get_weight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667369);
		NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667370);
		NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667371);
		NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667372);
		NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667373);
		NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667374);
		NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667375);
		NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100667376);
	}

	[CallerCount(0)]
	public unsafe bool HasFlags(Flags flag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
