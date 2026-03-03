using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.VFX;

public class SpawnOverDistance : VFXSpawnerCallbacks
{
	public class InputProperties : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		private static readonly System.IntPtr NativeFieldInfoPtr_RatePerUnit;

		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityThreshold;

		private static readonly System.IntPtr NativeFieldInfoPtr_ClampToOne;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 Position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position)) = value;
			}
		}

		public unsafe float RatePerUnit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RatePerUnit);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RatePerUnit)) = value;
			}
		}

		public unsafe float VelocityThreshold
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityThreshold);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VelocityThreshold)) = value;
			}
		}

		public unsafe bool ClampToOne
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClampToOne);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClampToOne)) = value;
			}
		}

		static InputProperties()
		{
			Il2CppClassPointerStore<InputProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, "InputProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputProperties>.NativeClassPtr);
			NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, "Position");
			NativeFieldInfoPtr_RatePerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, "RatePerUnit");
			NativeFieldInfoPtr_VelocityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, "VelocityThreshold");
			NativeFieldInfoPtr_ClampToOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, "ClampToOne");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, 100663325);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142845, XrefRangeEnd = 1142848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputProperties>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public InputProperties(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OldPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionPropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_ratePerUnitPropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_velocityThresholdPropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_clampToOnePropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionAttributeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_oldPositionAttributeId;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPlay_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnStop_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector3 m_OldPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OldPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OldPosition)) = value;
		}
	}

	public unsafe static int positionPropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_positionPropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_positionPropertyId, (void*)(&value));
		}
	}

	public unsafe static int ratePerUnitPropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ratePerUnitPropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ratePerUnitPropertyId, (void*)(&value));
		}
	}

	public unsafe static int velocityThresholdPropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_velocityThresholdPropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_velocityThresholdPropertyId, (void*)(&value));
		}
	}

	public unsafe static int clampToOnePropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clampToOnePropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clampToOnePropertyId, (void*)(&value));
		}
	}

	public unsafe static int positionAttributeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_positionAttributeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_positionAttributeId, (void*)(&value));
		}
	}

	public unsafe static int oldPositionAttributeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_oldPositionAttributeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_oldPositionAttributeId, (void*)(&value));
		}
	}

	static SpawnOverDistance()
	{
		Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX", "SpawnOverDistance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr);
		NativeFieldInfoPtr_m_OldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, "m_OldPosition");
		NativeFieldInfoPtr_positionPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, "positionPropertyId");
		NativeFieldInfoPtr_ratePerUnitPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, "ratePerUnitPropertyId");
		NativeFieldInfoPtr_velocityThresholdPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, "velocityThresholdPropertyId");
		NativeFieldInfoPtr_clampToOnePropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, "clampToOnePropertyId");
		NativeFieldInfoPtr_positionAttributeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, "positionAttributeId");
		NativeFieldInfoPtr_oldPositionAttributeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, "oldPositionAttributeId");
		NativeMethodInfoPtr_OnPlay_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_OnStop_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr, 100663323);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142848, XrefRangeEnd = 1142853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxValues);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxComponent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPlay_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142853, XrefRangeEnd = 1142884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxValues);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxComponent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxValues);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxComponent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStop_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63181, RefRangeEnd = 63182, XrefRangeStart = 63181, XrefRangeEnd = 63182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpawnOverDistance()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnOverDistance>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpawnOverDistance(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
