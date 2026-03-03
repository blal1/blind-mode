using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection;

[System.Serializable]
public class PlayerEditorConnectionEvents : Il2CppSystem.Object
{
	[System.Serializable]
	public class MessageEvent : UnityEvent<MessageEventArgs>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static MessageEvent()
		{
			Il2CppClassPointerStore<MessageEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEvent>.NativeClassPtr, 100667357);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229375, XrefRangeEnd = 1229378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MessageEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ConnectionChangeEvent : UnityEvent<int>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static ConnectionChangeEvent()
		{
			Il2CppClassPointerStore<ConnectionChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "ConnectionChangeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionChangeEvent>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionChangeEvent>.NativeClassPtr, 100667358);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229378, XrefRangeEnd = 1229381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionChangeEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionChangeEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ConnectionChangeEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class MessageTypeSubscribers : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_messageTypeId;

		private static readonly System.IntPtr NativeFieldInfoPtr_subscriberCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_messageCallback;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string m_messageTypeId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_messageTypeId);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_messageTypeId)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int subscriberCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subscriberCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subscriberCount)) = value;
			}
		}

		public unsafe MessageEvent messageCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MessageEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Guid MessageTypeId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229381, XrefRangeEnd = 1229382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(Il2CppSystem.Guid*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229382, XrefRangeEnd = 1229384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static MessageTypeSubscribers()
		{
			Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageTypeSubscribers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr);
			NativeFieldInfoPtr_m_messageTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr, "m_messageTypeId");
			NativeFieldInfoPtr_subscriberCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr, "subscriberCount");
			NativeFieldInfoPtr_messageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr, "messageCallback");
			NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr, 100667359);
			NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr, 100667360);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr, 100667361);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229384, XrefRangeEnd = 1229392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageTypeSubscribers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageTypeSubscribers>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MessageTypeSubscribers(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MessageTypeSubscribers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SubscriberLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_connectionEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_disconnectionEvent;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_messageTypeSubscribers_Public_get_IReadOnlyList_1_MessageTypeSubscribers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildLookup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<MessageTypeSubscribers> m_MessageTypeSubscribers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MessageTypeSubscribers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MessageTypeSubscribers>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MessageTypeSubscribers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Guid, MessageTypeSubscribers> m_SubscriberLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubscriberLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Guid, MessageTypeSubscribers>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubscriberLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ConnectionChangeEvent connectionEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConnectionChangeEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ConnectionChangeEvent disconnectionEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disconnectionEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConnectionChangeEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disconnectionEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IReadOnlyList<MessageTypeSubscribers> messageTypeSubscribers
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_messageTypeSubscribers_Public_get_IReadOnlyList_1_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<MessageTypeSubscribers>>(intPtr2) : null;
		}
	}

	static PlayerEditorConnectionEvents()
	{
		Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "PlayerEditorConnectionEvents");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr);
		NativeFieldInfoPtr_m_MessageTypeSubscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "m_MessageTypeSubscribers");
		NativeFieldInfoPtr_m_SubscriberLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "m_SubscriberLookup");
		NativeFieldInfoPtr_connectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "connectionEvent");
		NativeFieldInfoPtr_disconnectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "disconnectionEvent");
		NativeMethodInfoPtr_get_messageTypeSubscribers_Public_get_IReadOnlyList_1_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667351);
		NativeMethodInfoPtr_BuildLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667352);
		NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667353);
		NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667354);
		NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667355);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100667356);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1229421, RefRangeEnd = 1229426, XrefRangeStart = 1229392, XrefRangeEnd = 1229421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildLookup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229426, XrefRangeEnd = 1229440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeMessageIdSubscribers(Il2CppSystem.Guid messageId, Il2CppStructArray<byte> data, int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&messageId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1229472, RefRangeEnd = 1229473, XrefRangeStart = 1229440, XrefRangeEnd = 1229472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityEvent<MessageEventArgs> AddAndCreate(Il2CppSystem.Guid messageId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&messageId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<MessageEventArgs>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229473, XrefRangeEnd = 1229486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterManagedCallback(Il2CppSystem.Guid messageId, UnityAction<MessageEventArgs> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&messageId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229486, XrefRangeEnd = 1229507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerEditorConnectionEvents()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PlayerEditorConnectionEvents(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Clear()
	{
		if (m_SubscriberLookup != null)
		{
			m_SubscriberLookup.Clear();
		}
		m_MessageTypeSubscribers.Clear();
	}
}
