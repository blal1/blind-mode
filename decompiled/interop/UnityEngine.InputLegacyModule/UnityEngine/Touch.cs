using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Touch
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_FingerId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RawPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PositionDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TapCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Phase;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Pressure;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_maximumPossiblePressure;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RadiusVariance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AltitudeAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AzimuthAngle;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rawPosition_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rawPosition_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_deltaPosition_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pressure_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maximumPossiblePressure_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_TouchType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_radius_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0;

	[FieldOffset(0)]
	public int m_FingerId;

	[FieldOffset(4)]
	public Vector2 m_Position;

	[FieldOffset(12)]
	public Vector2 m_RawPosition;

	[FieldOffset(20)]
	public Vector2 m_PositionDelta;

	[FieldOffset(28)]
	public float m_TimeDelta;

	[FieldOffset(32)]
	public int m_TapCount;

	[FieldOffset(36)]
	public TouchPhase m_Phase;

	[FieldOffset(40)]
	public TouchType m_Type;

	[FieldOffset(44)]
	public float m_Pressure;

	[FieldOffset(48)]
	public float m_maximumPossiblePressure;

	[FieldOffset(52)]
	public float m_Radius;

	[FieldOffset(56)]
	public float m_RadiusVariance;

	[FieldOffset(60)]
	public float m_AltitudeAngle;

	[FieldOffset(64)]
	public float m_AzimuthAngle;

	public unsafe int fingerId
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_FingerId = value;
		}
	}

	public unsafe Vector2 position
	{
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1252492, RefRangeEnd = 1252523, XrefRangeStart = 1252492, XrefRangeEnd = 1252492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1113952, RefRangeEnd = 1113956, XrefRangeStart = 1113952, XrefRangeEnd = 1113956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 rawPosition
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252523, RefRangeEnd = 1252524, XrefRangeStart = 1252523, XrefRangeEnd = 1252523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rawPosition_Public_get_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252524, RefRangeEnd = 1252525, XrefRangeStart = 1252524, XrefRangeEnd = 1252524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rawPosition_Public_set_Void_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 deltaPosition
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1252525, RefRangeEnd = 1252529, XrefRangeStart = 1252525, XrefRangeEnd = 1252525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1252394, RefRangeEnd = 1252396, XrefRangeStart = 1252394, XrefRangeEnd = 1252396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deltaPosition_Public_set_Void_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float deltaTime
	{
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1156476, RefRangeEnd = 1156529, XrefRangeStart = 1156476, XrefRangeEnd = 1156529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_TimeDelta = value;
		}
	}

	public unsafe int tapCount
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1156529, RefRangeEnd = 1156553, XrefRangeStart = 1156529, XrefRangeEnd = 1156553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_TapCount = value;
		}
	}

	public unsafe TouchPhase phase
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1252529, RefRangeEnd = 1252544, XrefRangeStart = 1252529, XrefRangeEnd = 1252529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TouchPhase*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Phase = value;
		}
	}

	public unsafe float pressure
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1252544, RefRangeEnd = 1252562, XrefRangeStart = 1252544, XrefRangeEnd = 1252544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pressure_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Pressure = value;
		}
	}

	public unsafe float maximumPossiblePressure
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1153342, RefRangeEnd = 1153348, XrefRangeStart = 1153342, XrefRangeEnd = 1153348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maximumPossiblePressure_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_maximumPossiblePressure = value;
		}
	}

	public unsafe TouchType type
	{
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1222676, RefRangeEnd = 1222709, XrefRangeStart = 1222676, XrefRangeEnd = 1222709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_TouchType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TouchType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Type = value;
		}
	}

	public unsafe float altitudeAngle
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1114306, RefRangeEnd = 1114309, XrefRangeStart = 1114306, XrefRangeEnd = 1114309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_AltitudeAngle = value;
		}
	}

	public unsafe float azimuthAngle
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1252562, RefRangeEnd = 1252565, XrefRangeStart = 1252562, XrefRangeEnd = 1252562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_AzimuthAngle = value;
		}
	}

	public unsafe float radius
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1252565, RefRangeEnd = 1252580, XrefRangeStart = 1252565, XrefRangeEnd = 1252565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_radius_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Radius = value;
		}
	}

	public unsafe float radiusVariance
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1114260, RefRangeEnd = 1114305, XrefRangeStart = 1114260, XrefRangeEnd = 1114305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_RadiusVariance = value;
		}
	}

	static Touch()
	{
		Il2CppClassPointerStore<Touch>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "Touch");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Touch>.NativeClassPtr);
		NativeFieldInfoPtr_m_FingerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_FingerId");
		NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Position");
		NativeFieldInfoPtr_m_RawPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_RawPosition");
		NativeFieldInfoPtr_m_PositionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_PositionDelta");
		NativeFieldInfoPtr_m_TimeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_TimeDelta");
		NativeFieldInfoPtr_m_TapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_TapCount");
		NativeFieldInfoPtr_m_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Phase");
		NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Type");
		NativeFieldInfoPtr_m_Pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Pressure");
		NativeFieldInfoPtr_m_maximumPossiblePressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_maximumPossiblePressure");
		NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Radius");
		NativeFieldInfoPtr_m_RadiusVariance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_RadiusVariance");
		NativeFieldInfoPtr_m_AltitudeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_AltitudeAngle");
		NativeFieldInfoPtr_m_AzimuthAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_AzimuthAngle");
		NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_get_rawPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_set_rawPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_set_deltaPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_get_tapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_get_pressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_get_maximumPossiblePressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_get_type_Public_get_TouchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_get_radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663313);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Touch>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
