using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppYgomSystem.Timeline;
using Il2CppYgomSystem.UI;

namespace Il2Cpp;

public class DuelClientEndView : ViewController
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PREFAB_PATH;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ArgsKeyLPController;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ArgsKeyPushAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ArgsKeyPopAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ArgsKeyLoopEndAtStackRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PushAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PopAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_TIMELINE_PATH;

	private static readonly System.IntPtr NativeFieldInfoPtr_TIMELINELABEL_TRANSIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TIMELINELABEL_TRANSOUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TIMELINELABEL_WAIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TimelineObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LabelClipEndFlag_TransOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoopEndAtStackRemove;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotificationStackRemove_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransitionStart_Public_Virtual_Void_TransitionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransitionUpdate_Public_Virtual_Boolean_TransitionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__NotificationStackEntry_b__14_0_Private_Void_String_LabeledPlayableController_0;

	public unsafe static string PREFAB_PATH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PREFAB_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PREFAB_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_ArgsKeyLPController
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ArgsKeyLPController, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ArgsKeyLPController, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_ArgsKeyPushAction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ArgsKeyPushAction, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ArgsKeyPushAction, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_ArgsKeyPopAction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ArgsKeyPopAction, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ArgsKeyPopAction, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_ArgsKeyLoopEndAtStackRemove
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ArgsKeyLoopEndAtStackRemove, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ArgsKeyLoopEndAtStackRemove, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppSystem.Action<ViewControllerManager, ViewController> m_PushAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PushAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ViewControllerManager, ViewController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PushAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<ViewControllerManager, ViewController> m_PopAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PopAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ViewControllerManager, ViewController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PopAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string TIMELINE_PATH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TIMELINE_PATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TIMELINE_PATH, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string TIMELINELABEL_TRANSIN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TIMELINELABEL_TRANSIN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TIMELINELABEL_TRANSIN, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string TIMELINELABEL_TRANSOUT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TIMELINELABEL_TRANSOUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TIMELINELABEL_TRANSOUT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string TIMELINELABEL_WAIT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TIMELINELABEL_WAIT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TIMELINELABEL_WAIT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe TimelineObject m_TimelineObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TimelineObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimelineObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TimelineObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_LabelClipEndFlag_TransOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LabelClipEndFlag_TransOut);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LabelClipEndFlag_TransOut)) = value;
		}
	}

	public unsafe bool m_LoopEndAtStackRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoopEndAtStackRemove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoopEndAtStackRemove)) = value;
		}
	}

	static DuelClientEndView()
	{
		Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DuelClientEndView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr);
		NativeFieldInfoPtr_PREFAB_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "PREFAB_PATH");
		NativeFieldInfoPtr_k_ArgsKeyLPController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "k_ArgsKeyLPController");
		NativeFieldInfoPtr_k_ArgsKeyPushAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "k_ArgsKeyPushAction");
		NativeFieldInfoPtr_k_ArgsKeyPopAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "k_ArgsKeyPopAction");
		NativeFieldInfoPtr_k_ArgsKeyLoopEndAtStackRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "k_ArgsKeyLoopEndAtStackRemove");
		NativeFieldInfoPtr_m_PushAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "m_PushAction");
		NativeFieldInfoPtr_m_PopAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "m_PopAction");
		NativeFieldInfoPtr_TIMELINE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "TIMELINE_PATH");
		NativeFieldInfoPtr_TIMELINELABEL_TRANSIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "TIMELINELABEL_TRANSIN");
		NativeFieldInfoPtr_TIMELINELABEL_TRANSOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "TIMELINELABEL_TRANSOUT");
		NativeFieldInfoPtr_TIMELINELABEL_WAIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "TIMELINELABEL_WAIT");
		NativeFieldInfoPtr_m_TimelineObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "m_TimelineObject");
		NativeFieldInfoPtr_m_LabelClipEndFlag_TransOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "m_LabelClipEndFlag_TransOut");
		NativeFieldInfoPtr_m_LoopEndAtStackRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, "m_LoopEndAtStackRemove");
		NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_NotificationStackRemove_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_TransitionStart_Public_Virtual_Void_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_TransitionUpdate_Public_Virtual_Boolean_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr__NotificationStackEntry_b__14_0_Private_Void_String_LabeledPlayableController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr, 100663595);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33055, XrefRangeEnd = 33105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NotificationStackEntry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33105, XrefRangeEnd = 33111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NotificationStackRemove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NotificationStackRemove_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33111, XrefRangeEnd = 33116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void TransitionStart(TransitionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TransitionStart_Public_Virtual_Void_TransitionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33116, XrefRangeEnd = 33117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool TransitionUpdate(TransitionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TransitionUpdate_Public_Virtual_Boolean_TransitionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33117, XrefRangeEnd = 33121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DuelClientEndView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuelClientEndView>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33121, XrefRangeEnd = 33124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _NotificationStackEntry_b__14_0(string label, LabeledPlayableController controller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__NotificationStackEntry_b__14_0_Private_Void_String_LabeledPlayableController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DuelClientEndView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
