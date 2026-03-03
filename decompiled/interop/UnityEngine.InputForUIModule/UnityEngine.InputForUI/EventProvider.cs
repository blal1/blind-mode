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
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

public static class EventProvider : Il2CppSystem.Object
{
	public sealed class Registration : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		private static readonly System.IntPtr NativeFieldInfoPtr_priority;

		private static readonly System.IntPtr NativeFieldInfoPtr_playerId;

		private static readonly System.IntPtr NativeFieldInfoPtr__types;

		public unsafe EventConsumer handler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handler);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventConsumer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int priority
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = value;
			}
		}

		public unsafe Il2CppSystem.Nullable<int> playerId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerId);
				return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe HashSet<Event.Type> _types
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__types);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Event.Type>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__types)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Registration()
		{
			Il2CppClassPointerStore<Registration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "Registration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Registration>.NativeClassPtr);
			NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registration>.NativeClassPtr, "handler");
			NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registration>.NativeClassPtr, "priority");
			NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registration>.NativeClassPtr, "playerId");
			NativeFieldInfoPtr__types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Registration>.NativeClassPtr, "_types");
		}

		public Registration(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Registration()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Registration>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.InputForUI.EventProvider+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Subscribe_b__5_0_Internal_Int32_Registration_Registration_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Comparison<Registration> __9__5_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Registration>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__5_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__5_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663418);
			NativeMethodInfoPtr__Subscribe_b__5_0_Internal_Int32_Registration_Registration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663419);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _Subscribe_b__5_0(Registration a, Registration b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Subscribe_b__5_0_Internal_Int32_Registration_Registration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.InputForUI.EventProvider+<>c__DisplayClass6_0")]
	public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Unsubscribe_b__0_Internal_Boolean_Registration_0;

		public unsafe EventConsumer handler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handler);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventConsumer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass6_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "<>c__DisplayClass6_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr);
			NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, "handler");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100663420);
			NativeMethodInfoPtr__Unsubscribe_b__0_Internal_Boolean_Registration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100663421);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass6_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251395, XrefRangeEnd = 1251403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Unsubscribe_b__0(Registration x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Unsubscribe_b__0_Internal_Boolean_Registration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass6_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public sealed class _003C_003Ec
	{
	}

	public sealed class _003C_003Ec__DisplayClass6_0
	{
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_impl;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_sanitizer;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_implMockBackup;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_focusChangedRegistered;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr__registrations;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Public_Static_Void_EventConsumer_Int32_Nullable_1_Int32_Il2CppStructArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_EventConsumer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispatch_Internal_Static_Void_byref_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bootstrap_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFocusChanged_Private_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputSystemProvider_Internal_Static_Void_IEventProviderImpl_0;

	public unsafe static IEventProviderImpl s_impl
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_impl, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventProviderImpl>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_impl, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EventSanitizer s_sanitizer
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventSanitizer>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_sanitizer, (void*)intPtr);
			return new EventSanitizer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventSanitizer>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_sanitizer, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static IEventProviderImpl s_implMockBackup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_implMockBackup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventProviderImpl>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_implMockBackup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool s_focusChangedRegistered
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_focusChangedRegistered, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_focusChangedRegistered, (void*)(&value));
		}
	}

	public unsafe static bool m_IsEnabled
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_IsEnabled, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_IsEnabled, (void*)(&value));
		}
	}

	public unsafe static bool m_IsInitialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_IsInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_IsInitialized, (void*)(&value));
		}
	}

	public unsafe static List<Registration> _registrations
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__registrations, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Registration>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__registrations, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static uint playerCount => s_impl?.playerCount ?? 0;

	public static string _providerClassName => ((Il2CppSystem.Object)(object)s_impl)?.GetType().Name;

	public static RationalTime doubleClickTime
	{
		get
		{
			int num = UnityEngine.Event.GetDoubleClickTime();
			return new RationalTime((long)num, new RationalTime.TicksPerSecond(1000u));
		}
	}

	static EventProvider()
	{
		Il2CppClassPointerStore<EventProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "EventProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventProvider>.NativeClassPtr);
		NativeFieldInfoPtr_s_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "s_impl");
		NativeFieldInfoPtr_s_sanitizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "s_sanitizer");
		NativeFieldInfoPtr_s_implMockBackup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "s_implMockBackup");
		NativeFieldInfoPtr_s_focusChangedRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "s_focusChangedRegistered");
		NativeFieldInfoPtr_m_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_IsEnabled");
		NativeFieldInfoPtr_m_IsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "m_IsInitialized");
		NativeFieldInfoPtr__registrations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, "_registrations");
		NativeMethodInfoPtr_Subscribe_Public_Static_Void_EventConsumer_Int32_Nullable_1_Int32_Il2CppStructArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_EventConsumer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_Dispatch_Internal_Static_Void_byref_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_Bootstrap_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_Shutdown_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_OnFocusChanged_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_SetInputSystemProvider_Internal_Static_Void_IEventProviderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventProvider>.NativeClassPtr, 100663415);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251446, RefRangeEnd = 1251447, XrefRangeStart = 1251403, XrefRangeEnd = 1251446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Subscribe(EventConsumer handler, int priority = 0, Il2CppSystem.Nullable<int> playerId = null, [Optional] Il2CppStructArray<Event.Type> type)
	{
		if (type == null)
		{
			type = new Il2CppStructArray<Event.Type>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &priority;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)playerId));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subscribe_Public_Static_Void_EventConsumer_Int32_Nullable_1_Int32_Il2CppStructArray_1_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1251488, RefRangeEnd = 1251490, XrefRangeStart = 1251447, XrefRangeEnd = 1251488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unsubscribe(EventConsumer handler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_EventConsumer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1251499, RefRangeEnd = 1251502, XrefRangeStart = 1251490, XrefRangeEnd = 1251499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetEnabled(bool enable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnabled_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1251534, RefRangeEnd = 1251550, XrefRangeStart = 1251502, XrefRangeEnd = 1251534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Dispatch([In] ref Event ev)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ev);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispatch_Internal_Static_Void_byref_Event_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251550, XrefRangeEnd = 1251556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Bootstrap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bootstrap_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1251586, RefRangeEnd = 1251590, XrefRangeStart = 1251556, XrefRangeEnd = 1251586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1251615, RefRangeEnd = 1251617, XrefRangeStart = 1251590, XrefRangeEnd = 1251615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shutdown()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shutdown_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251617, XrefRangeEnd = 1251624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnFocusChanged(bool focus)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&focus);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFocusChanged_Private_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251624, XrefRangeEnd = 1251646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyUpdate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251646, XrefRangeEnd = 1251657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetInputSystemProvider(IEventProviderImpl impl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)impl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputSystemProvider_Internal_Static_Void_IEventProviderImpl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public static void Subscribe(EventConsumer handler, [Optional] int priority, [Optional] Il2CppSystem.Nullable<int> playerId, params Event.Type[] type)
	{
		Subscribe(handler, priority, playerId, new Il2CppStructArray<Event.Type>(type));
	}

	public EventProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void RequestCurrentState(Il2CppStructArray<Event.Type> types)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void RequestCurrentState(params Event.Type[] types)
	{
		RequestCurrentState(new Il2CppStructArray<Event.Type>(types));
	}

	public static void SetMockProvider(IEventProviderImpl impl)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void ClearMockProvider()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
