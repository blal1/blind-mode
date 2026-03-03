using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Accessibility;

public static class AssistiveSupport : Il2CppSystem.Object
{
	public class NotificationDispatcher : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Send_Private_Static_Void_byref_AccessibilityNotificationContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SendScreenChanged_Public_Virtual_Final_New_Void_AccessibilityNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static NotificationDispatcher()
		{
			Il2CppClassPointerStore<NotificationDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, "NotificationDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationDispatcher>.NativeClassPtr);
			NativeMethodInfoPtr_Send_Private_Static_Void_byref_AccessibilityNotificationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDispatcher>.NativeClassPtr, 100663388);
			NativeMethodInfoPtr_SendScreenChanged_Public_Virtual_Final_New_Void_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDispatcher>.NativeClassPtr, 100663389);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDispatcher>.NativeClassPtr, 100663390);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147817, XrefRangeEnd = 1147822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Send([In] ref AccessibilityNotificationContext context)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_Private_Static_Void_byref_AccessibilityNotificationContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147822, XrefRangeEnd = 1147827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendScreenChanged(AccessibilityNode nodeToFocus = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeToFocus);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendScreenChanged_Public_Virtual_Final_New_Void_AccessibilityNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationDispatcher>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public NotificationDispatcher(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetService_Internal_Static_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetService_Internal_Static_T_0, Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeFocusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenReaderStatusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__notificationDispatcher_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ServiceManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isScreenReaderEnabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isScreenReaderEnabled_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_notificationDispatcher_Public_Static_get_IAccessibilityNotificationDispatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetService_Internal_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScreenReaderStatusChanged_Private_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NodeFocusChanged_Private_Static_Void_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeHierarchy_Public_Static_get_AccessibilityHierarchy_0;

	public unsafe static Il2CppSystem.Action<AccessibilityNode> nodeFocusChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nodeFocusChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<AccessibilityNode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nodeFocusChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<bool> screenReaderStatusChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_screenReaderStatusChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_screenReaderStatusChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool _isScreenReaderEnabled_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static IAccessibilityNotificationDispatcher _notificationDispatcher_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__notificationDispatcher_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAccessibilityNotificationDispatcher>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__notificationDispatcher_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ServiceManager s_ServiceManager
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ServiceManager, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ServiceManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ServiceManager, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool isScreenReaderEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147827, XrefRangeEnd = 1147831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isScreenReaderEnabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147831, XrefRangeEnd = 1147835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isScreenReaderEnabled_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static IAccessibilityNotificationDispatcher notificationDispatcher
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147835, XrefRangeEnd = 1147839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_notificationDispatcher_Public_Static_get_IAccessibilityNotificationDispatcher_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAccessibilityNotificationDispatcher>(intPtr2) : null;
		}
	}

	public unsafe static AccessibilityHierarchy activeHierarchy
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1147959, RefRangeEnd = 1147965, XrefRangeStart = 1147953, XrefRangeEnd = 1147959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeHierarchy_Public_Static_get_AccessibilityHierarchy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityHierarchy>(intPtr2) : null;
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static AssistiveSupport()
	{
		Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AssistiveSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr);
		NativeFieldInfoPtr_nodeFocusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, "nodeFocusChanged");
		NativeFieldInfoPtr_screenReaderStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, "screenReaderStatusChanged");
		NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, "<isScreenReaderEnabled>k__BackingField");
		NativeFieldInfoPtr__notificationDispatcher_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, "<notificationDispatcher>k__BackingField");
		NativeFieldInfoPtr_s_ServiceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, "s_ServiceManager");
		NativeMethodInfoPtr_get_isScreenReaderEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_set_isScreenReaderEnabled_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_get_notificationDispatcher_Public_Static_get_IAccessibilityNotificationDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_GetService_Internal_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_ScreenReaderStatusChanged_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_NodeFocusChanged_Private_Static_Void_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_get_activeHierarchy_Public_Static_get_AccessibilityHierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssistiveSupport>.NativeClassPtr, 100663386);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1147910, RefRangeEnd = 1147911, XrefRangeStart = 1147839, XrefRangeEnd = 1147910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1147919, RefRangeEnd = 1147930, XrefRangeStart = 1147911, XrefRangeEnd = 1147919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetService<T>()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetService_Internal_Static_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147930, XrefRangeEnd = 1147949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScreenReaderStatusChanged(bool screenReaderEnabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&screenReaderEnabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScreenReaderStatusChanged_Private_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147949, XrefRangeEnd = 1147953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NodeFocusChanged(AccessibilityNode currentNode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentNode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NodeFocusChanged_Private_Static_Void_AccessibilityNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AssistiveSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_nodeFocusChanged(Il2CppSystem.Action<AccessibilityNode> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_nodeFocusChanged(Il2CppSystem.Action<AccessibilityNode> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_screenReaderStatusChanged(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_screenReaderStatusChanged(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool IsServiceRunning<T>()
	{
		IService service = (IService)(object)GetService<T>();
		return service != null;
	}

	public static void SetApplicationAccessibilityLanguage(SystemLanguage language)
	{
		AccessibilityManager.SetApplicationAccessibilityLanguage(language);
	}

	[SpecialName]
	public static void add_s_ActiveHierarchyChanged(Il2CppSystem.Action<AccessibilityHierarchy> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_s_ActiveHierarchyChanged(Il2CppSystem.Action<AccessibilityHierarchy> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_activeHierarchyChanged(Il2CppSystem.Action<AccessibilityHierarchy> value)
	{
		add_s_ActiveHierarchyChanged(value);
	}

	[SpecialName]
	public static void remove_activeHierarchyChanged(Il2CppSystem.Action<AccessibilityHierarchy> value)
	{
		remove_s_ActiveHierarchyChanged(value);
	}

	public static void OnHierarchyNodeFramesRefreshed(AccessibilityHierarchy hierarchy)
	{
		if (activeHierarchy == hierarchy)
		{
			notificationDispatcher.SendLayoutChanged((AccessibilityNode)null);
		}
	}

	public static void CheckPlatformSupported()
	{
		if (!Application.isEditor && !AccessibilityManager.isSupportedPlatform)
		{
			throw new Il2CppSystem.PlatformNotSupportedException(Il2CppSystem.String.Format("This API is not supported for platform {0}", (Il2CppSystem.Object)(object)Application.platform));
		}
	}
}
