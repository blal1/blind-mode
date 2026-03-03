using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.VFX.Utility;

namespace UnityEngine.VFX;

[System.Serializable]
public class VisualEffectControlClip : PlayableAsset
{
	[OriginalName("Unity.VisualEffectGraph.Runtime.dll", "", "ReinitMode")]
	public enum ReinitMode
	{
		None,
		OnExitClip,
		OnEnterClip,
		OnEnterOrExitClip
	}

	[System.Serializable]
	public sealed class PrewarmClipSettings : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_enable;

		private static readonly System.IntPtr NativeFieldInfoPtr_stepCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_eventName;

		public unsafe bool enable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enable);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enable)) = value;
			}
		}

		public unsafe uint stepCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stepCount);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stepCount)) = value;
			}
		}

		public unsafe float deltaTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTime)) = value;
			}
		}

		public unsafe ExposedProperty eventName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventName);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExposedProperty>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static PrewarmClipSettings()
		{
			Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "PrewarmClipSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr);
			NativeFieldInfoPtr_enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr, "enable");
			NativeFieldInfoPtr_stepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr, "stepCount");
			NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr, "deltaTime");
			NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr, "eventName");
		}

		public PrewarmClipSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public PrewarmClipSettings()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public sealed class ClipEvent : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultEditorColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_editorColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_enter;

		private static readonly System.IntPtr NativeFieldInfoPtr_exit;

		public unsafe static Color defaultEditorColor
		{
			get
			{
				Unsafe.SkipInit(out Color result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultEditorColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultEditorColor, (void*)(&value));
			}
		}

		public unsafe Color editorColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorColor);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorColor)) = value;
			}
		}

		public unsafe VisualEffectPlayableSerializedEventNoColor enter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enter);
				return new VisualEffectPlayableSerializedEventNoColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe VisualEffectPlayableSerializedEventNoColor exit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exit);
				return new VisualEffectPlayableSerializedEventNoColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ClipEvent()
		{
			Il2CppClassPointerStore<ClipEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "ClipEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipEvent>.NativeClassPtr);
			NativeFieldInfoPtr_defaultEditorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipEvent>.NativeClassPtr, "defaultEditorColor");
			NativeFieldInfoPtr_editorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipEvent>.NativeClassPtr, "editorColor");
			NativeFieldInfoPtr_enter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipEvent>.NativeClassPtr, "enter");
			NativeFieldInfoPtr_exit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipEvent>.NativeClassPtr, "exit");
		}

		public ClipEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ClipEvent()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipEvent>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__clipStart_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__clipEnd_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrubbing;

	private static readonly System.IntPtr NativeFieldInfoPtr_startSeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_reinit;

	private static readonly System.IntPtr NativeFieldInfoPtr_prewarm;

	private static readonly System.IntPtr NativeFieldInfoPtr_clipEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_singleEvents;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipStart_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clipStart_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipEnd_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_clipEnd_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe double _clipStart_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipStart_k__BackingField);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipStart_k__BackingField)) = value;
		}
	}

	public unsafe double _clipEnd_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipEnd_k__BackingField);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clipEnd_k__BackingField)) = value;
		}
	}

	public unsafe bool scrubbing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrubbing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrubbing)) = value;
		}
	}

	public unsafe uint startSeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startSeed);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startSeed)) = value;
		}
	}

	public unsafe ReinitMode reinit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reinit);
			return *(ReinitMode*)num;
		}
		set
		{
			*(ReinitMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reinit)) = value;
		}
	}

	public unsafe PrewarmClipSettings prewarm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prewarm);
			return new PrewarmClipSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prewarm), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrewarmClipSettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe List<ClipEvent> clipEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClipEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clipEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<VisualEffectPlayableSerializedEvent> singleEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singleEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<VisualEffectPlayableSerializedEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singleEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe virtual ClipCaps clipCaps
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ClipCaps*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double clipStart
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipStart_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clipStart_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double clipEnd
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipEnd_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clipEnd_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static VisualEffectControlClip()
	{
		Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX", "VisualEffectControlClip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr);
		NativeFieldInfoPtr__clipStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "<clipStart>k__BackingField");
		NativeFieldInfoPtr__clipEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "<clipEnd>k__BackingField");
		NativeFieldInfoPtr_scrubbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "scrubbing");
		NativeFieldInfoPtr_startSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "startSeed");
		NativeFieldInfoPtr_reinit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "reinit");
		NativeFieldInfoPtr_prewarm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "prewarm");
		NativeFieldInfoPtr_clipEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "clipEvents");
		NativeFieldInfoPtr_singleEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, "singleEvents");
		NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_get_clipStart_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_set_clipStart_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_get_clipEnd_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_set_clipEnd_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr, 100663337);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142884, XrefRangeEnd = 1142972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)owner);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142972, XrefRangeEnd = 1143031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VisualEffectControlClip()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectControlClip>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VisualEffectControlClip(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
