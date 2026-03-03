using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Accessibility;

public sealed class AccessibilityNotificationContext : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__notification_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__announcement_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__wasAnnouncementSuccessful_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentNodeId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__nextNodeId_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_notification_Public_get_AccessibilityNotification_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_notification_Public_set_Void_AccessibilityNotification_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isScreenReaderEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_announcement_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wasAnnouncementSuccessful_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentNodeId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nextNodeId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_nextNodeId_Public_set_Void_Int32_0;

	public unsafe AccessibilityNotification _notification_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__notification_k__BackingField);
			return *(AccessibilityNotification*)num;
		}
		set
		{
			*(AccessibilityNotification*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__notification_k__BackingField)) = value;
		}
	}

	public unsafe bool _isScreenReaderEnabled_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField)) = value;
		}
	}

	public unsafe string _announcement_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__announcement_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__announcement_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool _wasAnnouncementSuccessful_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wasAnnouncementSuccessful_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wasAnnouncementSuccessful_k__BackingField)) = value;
		}
	}

	public unsafe int _currentNodeId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentNodeId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentNodeId_k__BackingField)) = value;
		}
	}

	public unsafe int _nextNodeId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nextNodeId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nextNodeId_k__BackingField)) = value;
		}
	}

	public unsafe AccessibilityNotification notification
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_notification_Public_get_AccessibilityNotification_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AccessibilityNotification*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_notification_Public_set_Void_AccessibilityNotification_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isScreenReaderEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isScreenReaderEnabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string announcement
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_announcement_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			_announcement_k__BackingField = value;
		}
	}

	public unsafe bool wasAnnouncementSuccessful
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wasAnnouncementSuccessful_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int currentNodeId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentNodeId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int nextNodeId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nextNodeId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nextNodeId_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static AccessibilityNotificationContext()
	{
		Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AccessibilityNotificationContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr);
		NativeFieldInfoPtr__notification_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, "<notification>k__BackingField");
		NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, "<isScreenReaderEnabled>k__BackingField");
		NativeFieldInfoPtr__announcement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, "<announcement>k__BackingField");
		NativeFieldInfoPtr__wasAnnouncementSuccessful_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, "<wasAnnouncementSuccessful>k__BackingField");
		NativeFieldInfoPtr__currentNodeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, "<currentNodeId>k__BackingField");
		NativeFieldInfoPtr__nextNodeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, "<nextNodeId>k__BackingField");
		NativeMethodInfoPtr_get_notification_Public_get_AccessibilityNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_set_notification_Public_set_Void_AccessibilityNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_get_isScreenReaderEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_get_announcement_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_get_wasAnnouncementSuccessful_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_get_currentNodeId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_get_nextNodeId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_set_nextNodeId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, 100663372);
	}

	public AccessibilityNotificationContext(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AccessibilityNotificationContext()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr))
	{
	}
}
