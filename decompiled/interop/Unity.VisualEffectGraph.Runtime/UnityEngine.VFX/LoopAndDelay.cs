using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.VFX;

public class LoopAndDelay : VFXSpawnerCallbacks
{
	public class InputProperties : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_LoopCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_LoopDuration;

		private static readonly System.IntPtr NativeFieldInfoPtr_Delay;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int LoopCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopCount)) = value;
			}
		}

		public unsafe float LoopDuration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopDuration);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoopDuration)) = value;
			}
		}

		public unsafe float Delay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Delay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Delay)) = value;
			}
		}

		static InputProperties()
		{
			Il2CppClassPointerStore<InputProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, "InputProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputProperties>.NativeClassPtr);
			NativeFieldInfoPtr_LoopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, "LoopCount");
			NativeFieldInfoPtr_LoopDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, "LoopDuration");
			NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, "Delay");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputProperties>.NativeClassPtr, 100663314);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142814, XrefRangeEnd = 1142815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoopMaxCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoopCurrentIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WaitingForTotalTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopCountPropertyID;

	private static readonly System.IntPtr NativeFieldInfoPtr_loopDurationPropertyID;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayPropertyID;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPlay_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnStop_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int m_LoopMaxCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoopMaxCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoopMaxCount)) = value;
		}
	}

	public unsafe int m_LoopCurrentIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoopCurrentIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoopCurrentIndex)) = value;
		}
	}

	public unsafe float m_WaitingForTotalTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WaitingForTotalTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WaitingForTotalTime)) = value;
		}
	}

	public unsafe static int loopCountPropertyID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_loopCountPropertyID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_loopCountPropertyID, (void*)(&value));
		}
	}

	public unsafe static int loopDurationPropertyID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_loopDurationPropertyID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_loopDurationPropertyID, (void*)(&value));
		}
	}

	public unsafe static int delayPropertyID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_delayPropertyID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_delayPropertyID, (void*)(&value));
		}
	}

	static LoopAndDelay()
	{
		Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX", "LoopAndDelay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr);
		NativeFieldInfoPtr_m_LoopMaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, "m_LoopMaxCount");
		NativeFieldInfoPtr_m_LoopCurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, "m_LoopCurrentIndex");
		NativeFieldInfoPtr_m_WaitingForTotalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, "m_WaitingForTotalTime");
		NativeFieldInfoPtr_loopCountPropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, "loopCountPropertyID");
		NativeFieldInfoPtr_loopDurationPropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, "loopDurationPropertyID");
		NativeFieldInfoPtr_delayPropertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, "delayPropertyID");
		NativeMethodInfoPtr_OnPlay_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_OnStop_Public_Virtual_Final_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr, 100663312);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142815, XrefRangeEnd = 1142823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142823, XrefRangeEnd = 1142832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
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
	public unsafe LoopAndDelay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopAndDelay>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LoopAndDelay(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
