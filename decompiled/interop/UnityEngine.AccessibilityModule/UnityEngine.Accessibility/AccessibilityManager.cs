using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Accessibility;

public static class AccessibilityManager : Il2CppSystem.Object
{
	public sealed class NotificationContext : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__notification_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__announcement_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__wasAnnouncementSuccessful_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__currentNode_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__nextNode_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__fontScale_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__isBoldTextEnabled_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__isClosedCaptioningEnabled_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__nativeContext_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_notification_Public_get_AccessibilityNotification_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_notification_Public_set_Void_AccessibilityNotification_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isScreenReaderEnabled_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isScreenReaderEnabled_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_announcement_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_wasAnnouncementSuccessful_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentNode_Public_get_AccessibilityNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_currentNode_Public_set_Void_AccessibilityNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_nextNode_Public_set_Void_AccessibilityNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_fontScale_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_fontScale_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isBoldTextEnabled_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isBoldTextEnabled_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_isClosedCaptioningEnabled_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_isClosedCaptioningEnabled_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_nativeContext_Public_set_Void_AccessibilityNotificationContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_AccessibilityNotificationContext_0;

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

		public unsafe AccessibilityNode _currentNode_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentNode_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentNode_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe AccessibilityNode _nextNode_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nextNode_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nextNode_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe float _fontScale_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fontScale_k__BackingField);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fontScale_k__BackingField)) = value;
			}
		}

		public unsafe bool _isBoldTextEnabled_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isBoldTextEnabled_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isBoldTextEnabled_k__BackingField)) = value;
			}
		}

		public unsafe bool _isClosedCaptioningEnabled_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isClosedCaptioningEnabled_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isClosedCaptioningEnabled_k__BackingField)) = value;
			}
		}

		public unsafe AccessibilityNotificationContext _nativeContext_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nativeContext_k__BackingField);
				return new AccessibilityNotificationContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nativeContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AccessibilityNotificationContext>.NativeClassPtr, ref *(uint*)null));
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
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 584882, RefRangeEnd = 584883, XrefRangeStart = 584882, XrefRangeEnd = 584883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isScreenReaderEnabled_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe string announcement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_announcement_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool wasAnnouncementSuccessful
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86557, RefRangeEnd = 86558, XrefRangeStart = 86557, XrefRangeEnd = 86558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wasAnnouncementSuccessful_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe AccessibilityNode currentNode
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentNode_Public_get_AccessibilityNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityNode>(intPtr2) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentNode_Public_set_Void_AccessibilityNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe AccessibilityNode nextNode
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nextNode_Public_set_Void_AccessibilityNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float fontScale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 42518, RefRangeEnd = 42519, XrefRangeStart = 42518, XrefRangeEnd = 42519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontScale_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fontScale_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isBoldTextEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isBoldTextEnabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isBoldTextEnabled_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool isClosedCaptioningEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isClosedCaptioningEnabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isClosedCaptioningEnabled_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe AccessibilityNotificationContext nativeContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147460, XrefRangeEnd = 1147461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nativeContext_Public_set_Void_AccessibilityNotificationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static NotificationContext()
		{
			Il2CppClassPointerStore<NotificationContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, "NotificationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr);
			NativeFieldInfoPtr__notification_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<notification>k__BackingField");
			NativeFieldInfoPtr__isScreenReaderEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<isScreenReaderEnabled>k__BackingField");
			NativeFieldInfoPtr__announcement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<announcement>k__BackingField");
			NativeFieldInfoPtr__wasAnnouncementSuccessful_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<wasAnnouncementSuccessful>k__BackingField");
			NativeFieldInfoPtr__currentNode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<currentNode>k__BackingField");
			NativeFieldInfoPtr__nextNode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<nextNode>k__BackingField");
			NativeFieldInfoPtr__fontScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<fontScale>k__BackingField");
			NativeFieldInfoPtr__isBoldTextEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<isBoldTextEnabled>k__BackingField");
			NativeFieldInfoPtr__isClosedCaptioningEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<isClosedCaptioningEnabled>k__BackingField");
			NativeFieldInfoPtr__nativeContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, "<nativeContext>k__BackingField");
			NativeMethodInfoPtr_get_notification_Public_get_AccessibilityNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663319);
			NativeMethodInfoPtr_set_notification_Public_set_Void_AccessibilityNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663320);
			NativeMethodInfoPtr_get_isScreenReaderEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663321);
			NativeMethodInfoPtr_set_isScreenReaderEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663322);
			NativeMethodInfoPtr_set_announcement_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663323);
			NativeMethodInfoPtr_set_wasAnnouncementSuccessful_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663324);
			NativeMethodInfoPtr_get_currentNode_Public_get_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663325);
			NativeMethodInfoPtr_set_currentNode_Public_set_Void_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663326);
			NativeMethodInfoPtr_set_nextNode_Public_set_Void_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663327);
			NativeMethodInfoPtr_get_fontScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663328);
			NativeMethodInfoPtr_set_fontScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663329);
			NativeMethodInfoPtr_get_isBoldTextEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663330);
			NativeMethodInfoPtr_set_isBoldTextEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663331);
			NativeMethodInfoPtr_get_isClosedCaptioningEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663332);
			NativeMethodInfoPtr_set_isClosedCaptioningEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663333);
			NativeMethodInfoPtr_set_nativeContext_Public_set_Void_AccessibilityNotificationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663334);
			NativeMethodInfoPtr__ctor_Public_Void_byref_AccessibilityNotificationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr, 100663335);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1147484, RefRangeEnd = 1147485, XrefRangeStart = 1147461, XrefRangeEnd = 1147484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationContext(ref AccessibilityNotificationContext nativeNotification)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativeNotification);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_AccessibilityNotificationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public NotificationContext(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public NotificationContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationContext>.NativeClassPtr))
		{
		}
	}

	public sealed class ExclusiveLock : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Disposed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InternalDispose_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		public unsafe bool m_Disposed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Disposed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Disposed)) = value;
			}
		}

		static ExclusiveLock()
		{
			Il2CppClassPointerStore<ExclusiveLock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, "ExclusiveLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveLock>.NativeClassPtr);
			NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveLock>.NativeClassPtr, "m_Disposed");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveLock>.NativeClassPtr, 100663336);
			NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveLock>.NativeClassPtr, 100663337);
			NativeMethodInfoPtr_InternalDispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveLock>.NativeClassPtr, 100663338);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveLock>.NativeClassPtr, 100663339);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147485, XrefRangeEnd = 1147491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExclusiveLock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveLock>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147491, XrefRangeEnd = 1147499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147499, XrefRangeEnd = 1147504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147504, XrefRangeEnd = 1147513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ExclusiveLock(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate SystemLanguage GetApplicationAccessibilityLanguageDelegate();

	private delegate void SetApplicationAccessibilityLanguageDelegate(SystemLanguage languageCode);

	private static readonly System.IntPtr NativeFieldInfoPtr_asyncNotificationContexts;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenReaderStatusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeFocusChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_screenReaderStatusChanged_Public_Static_add_Void_Action_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_screenReaderStatusChanged_Public_Static_rem_Void_Action_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_nodeFocusChanged_Public_Static_add_Void_Action_1_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_nodeFocusChanged_Public_Static_rem_Void_Action_1_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsScreenReaderEnabled_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAccessibilityNotification_Internal_Static_Void_byref_AccessibilityNotificationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Update_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetRootNodeIds_Internal_Static_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetNode_Internal_Static_Boolean_Int32_byref_AccessibilityNodeData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetNodeIdAt_Internal_Static_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_OnAccessibilityNotificationReceived_Internal_Static_Void_byref_AccessibilityNotificationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueNotification_Internal_Static_Void_NotificationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExclusiveLock_Internal_Static_IDisposable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lock_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unlock_Private_Static_Void_0;

	private static readonly GetApplicationAccessibilityLanguageDelegate GetApplicationAccessibilityLanguageDelegateField;

	private static readonly SetApplicationAccessibilityLanguageDelegate SetApplicationAccessibilityLanguageDelegateField;

	public unsafe static Queue<NotificationContext> asyncNotificationContexts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_asyncNotificationContexts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<NotificationContext>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_asyncNotificationContexts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public static bool isSupportedPlatform
	{
		get
		{
			RuntimePlatform platform = Application.platform;
			return platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer;
		}
	}

	static AccessibilityManager()
	{
		Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AccessibilityManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr);
		NativeFieldInfoPtr_asyncNotificationContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, "asyncNotificationContexts");
		NativeFieldInfoPtr_screenReaderStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, "screenReaderStatusChanged");
		NativeFieldInfoPtr_nodeFocusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, "nodeFocusChanged");
		NativeMethodInfoPtr_add_screenReaderStatusChanged_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_remove_screenReaderStatusChanged_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_add_nodeFocusChanged_Public_Static_add_Void_Action_1_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_remove_nodeFocusChanged_Public_Static_rem_Void_Action_1_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_IsScreenReaderEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_SendAccessibilityNotification_Internal_Static_Void_byref_AccessibilityNotificationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_Internal_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_Internal_Update_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_Internal_GetRootNodeIds_Internal_Static_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_Internal_GetNode_Internal_Static_Boolean_Int32_byref_AccessibilityNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_Internal_GetNodeIdAt_Internal_Static_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_Internal_OnAccessibilityNotificationReceived_Internal_Static_Void_byref_AccessibilityNotificationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_QueueNotification_Internal_Static_Void_NotificationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_GetExclusiveLock_Internal_Static_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_Lock_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_Unlock_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityManager>.NativeClassPtr, 100663317);
		GetApplicationAccessibilityLanguageDelegateField = IL2CPP.ResolveICall<GetApplicationAccessibilityLanguageDelegate>("UnityEngine.Accessibility.AccessibilityManager::GetApplicationAccessibilityLanguage");
		SetApplicationAccessibilityLanguageDelegateField = IL2CPP.ResolveICall<SetApplicationAccessibilityLanguageDelegate>("UnityEngine.Accessibility.AccessibilityManager::SetApplicationAccessibilityLanguage");
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1147526, RefRangeEnd = 1147529, XrefRangeStart = 1147513, XrefRangeEnd = 1147526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_screenReaderStatusChanged(Il2CppSystem.Action<bool> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_screenReaderStatusChanged_Public_Static_add_Void_Action_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147529, XrefRangeEnd = 1147542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_screenReaderStatusChanged(Il2CppSystem.Action<bool> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_screenReaderStatusChanged_Public_Static_rem_Void_Action_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147542, XrefRangeEnd = 1147555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_nodeFocusChanged(Il2CppSystem.Action<AccessibilityNode> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_nodeFocusChanged_Public_Static_add_Void_Action_1_AccessibilityNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147555, XrefRangeEnd = 1147568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_nodeFocusChanged(Il2CppSystem.Action<AccessibilityNode> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_nodeFocusChanged_Public_Static_rem_Void_Action_1_AccessibilityNode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147568, XrefRangeEnd = 1147570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsScreenReaderEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsScreenReaderEnabled_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147570, XrefRangeEnd = 1147572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendAccessibilityNotification([In] ref AccessibilityNotificationContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAccessibilityNotification_Internal_Static_Void_byref_AccessibilityNotificationContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147572, XrefRangeEnd = 1147576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147576, XrefRangeEnd = 1147633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Update_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147633, XrefRangeEnd = 1147666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> Internal_GetRootNodeIds()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetRootNodeIds_Internal_Static_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147666, XrefRangeEnd = 1147675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_GetNode(int id, ref AccessibilityNodeData nodeData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nodeData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetNode_Internal_Static_Boolean_Int32_byref_AccessibilityNodeData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147675, XrefRangeEnd = 1147684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_GetNodeIdAt(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetNodeIdAt_Internal_Static_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147684, XrefRangeEnd = 1147689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_OnAccessibilityNotificationReceived(ref AccessibilityNotificationContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_OnAccessibilityNotificationReceived_Internal_Static_Void_byref_AccessibilityNotificationContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1147703, RefRangeEnd = 1147709, XrefRangeStart = 1147689, XrefRangeEnd = 1147703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueNotification(NotificationContext notification)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)notification));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueNotification_Internal_Static_Void_NotificationContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147709, XrefRangeEnd = 1147718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.IDisposable GetExclusiveLock()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExclusiveLock_Internal_Static_IDisposable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147718, XrefRangeEnd = 1147720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Lock()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lock_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147720, XrefRangeEnd = 1147732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unlock()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unlock_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AccessibilityManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static SystemLanguage GetApplicationAccessibilityLanguage()
	{
		return GetApplicationAccessibilityLanguageDelegateField();
	}

	public static void SetApplicationAccessibilityLanguage(SystemLanguage languageCode)
	{
		SetApplicationAccessibilityLanguageDelegateField(languageCode);
	}
}
