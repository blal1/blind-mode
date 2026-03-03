using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Timeline;

[Serializable]
public class SignalEmitter : Marker
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Retroactive;

	private static readonly IntPtr NativeFieldInfoPtr_m_EmitOnce;

	private static readonly IntPtr NativeFieldInfoPtr_m_Asset;

	private static readonly IntPtr NativeMethodInfoPtr_get_retroactive_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_retroactive_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_emitOnce_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_emitOnce_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_asset_Public_get_SignalAsset_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_asset_Public_set_Void_SignalAsset_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Playables_INotification_get_id_Private_Virtual_Final_New_get_PropertyName_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool m_Retroactive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Retroactive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Retroactive)) = value;
		}
	}

	public unsafe bool m_EmitOnce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmitOnce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmitOnce)) = value;
		}
	}

	public unsafe SignalAsset m_Asset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Asset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SignalAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Asset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool retroactive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_retroactive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_retroactive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool emitOnce
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_emitOnce_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_emitOnce_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe SignalAsset asset
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asset_Public_get_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SignalAsset>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_asset_Public_set_Void_SignalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual PropertyName UnityEngine_002EPlayables_002EINotification_002Eid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140352, XrefRangeEnd = 1140358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_Playables_INotification_get_id_Private_Virtual_Final_New_get_PropertyName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PropertyName*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual NotificationFlags UnityEngine_002ETimeline_002EINotificationOptionProvider_002Eflags
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(NotificationFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SignalEmitter()
	{
		Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "SignalEmitter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr);
		NativeFieldInfoPtr_m_Retroactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, "m_Retroactive");
		NativeFieldInfoPtr_m_EmitOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, "m_EmitOnce");
		NativeFieldInfoPtr_m_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, "m_Asset");
		NativeMethodInfoPtr_get_retroactive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr_set_retroactive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr_get_emitOnce_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663963);
		NativeMethodInfoPtr_set_emitOnce_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663964);
		NativeMethodInfoPtr_get_asset_Public_get_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_set_asset_Public_set_Void_SignalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663966);
		NativeMethodInfoPtr_UnityEngine_Playables_INotification_get_id_Private_Virtual_Final_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663968);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr, 100663969);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 26528, RefRangeEnd = 26564, XrefRangeStart = 26528, XrefRangeEnd = 26564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SignalEmitter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalEmitter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SignalEmitter(IntPtr pointer)
		: base(pointer)
	{
	}
}
