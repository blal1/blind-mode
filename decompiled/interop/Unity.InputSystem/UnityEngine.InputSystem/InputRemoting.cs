using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public sealed class InputRemoting : Il2CppSystem.Object
{
	[OriginalName("Unity.InputSystem.dll", "", "MessageType")]
	public enum MessageType
	{
		Connect,
		Disconnect,
		NewLayout,
		NewDevice,
		NewEvents,
		RemoveDevice,
		RemoveLayout,
		ChangeUsages,
		StartSending,
		StopSending
	}

	public sealed class Message : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_participantId;

		private static readonly System.IntPtr NativeFieldInfoPtr_type;

		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		public unsafe int participantId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantId)) = value;
			}
		}

		public unsafe MessageType type
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
				return *(MessageType*)num;
			}
			set
			{
				*(MessageType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = value;
			}
		}

		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Message()
		{
			Il2CppClassPointerStore<Message>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Message>.NativeClassPtr);
			NativeFieldInfoPtr_participantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "participantId");
			NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "type");
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "data");
		}

		public Message(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Message()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
		}
	}

	[OriginalName("Unity.InputSystem.dll", "", "Flags")]
	[System.Flags]
	public enum Flags
	{
		Sending = 1,
		StartSendingOnConnect = 2
	}

	[System.Serializable]
	public sealed class RemoteSender : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_senderId;

		private static readonly System.IntPtr NativeFieldInfoPtr_layouts;

		private static readonly System.IntPtr NativeFieldInfoPtr_devices;

		public unsafe int senderId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_senderId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_senderId)) = value;
			}
		}

		public unsafe Il2CppReferenceArray<InternedString> layouts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layouts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InternedString>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layouts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<RemoteInputDevice> devices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_devices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RemoteInputDevice>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_devices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static RemoteSender()
		{
			Il2CppClassPointerStore<RemoteSender>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "RemoteSender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteSender>.NativeClassPtr);
			NativeFieldInfoPtr_senderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSender>.NativeClassPtr, "senderId");
			NativeFieldInfoPtr_layouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSender>.NativeClassPtr, "layouts");
			NativeFieldInfoPtr_devices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSender>.NativeClassPtr, "devices");
		}

		public RemoteSender(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public RemoteSender()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteSender>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	public sealed class RemoteInputDevice : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_remoteId;

		private static readonly System.IntPtr NativeFieldInfoPtr_localId;

		private static readonly System.IntPtr NativeFieldInfoPtr_description;

		public unsafe int remoteId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remoteId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remoteId)) = value;
			}
		}

		public unsafe int localId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localId)) = value;
			}
		}

		public unsafe InputDeviceDescription description
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description);
				return new InputDeviceDescription(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceDescription>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceDescription>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static RemoteInputDevice()
		{
			Il2CppClassPointerStore<RemoteInputDevice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "RemoteInputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteInputDevice>.NativeClassPtr);
			NativeFieldInfoPtr_remoteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteInputDevice>.NativeClassPtr, "remoteId");
			NativeFieldInfoPtr_localId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteInputDevice>.NativeClassPtr, "localId");
			NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteInputDevice>.NativeClassPtr, "description");
		}

		public RemoteInputDevice(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public RemoteInputDevice()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteInputDevice>.NativeClassPtr))
		{
		}
	}

	public class Subscriber : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_owner;

		private static readonly System.IntPtr NativeFieldInfoPtr_observer;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InputRemoting owner
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owner);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputRemoting>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.IObserver<Message> observer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_observer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IObserver<Message>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_observer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Subscriber()
		{
			Il2CppClassPointerStore<Subscriber>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "Subscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Subscriber>.NativeClassPtr);
			NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, "owner");
			NativeFieldInfoPtr_observer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, "observer");
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100665751);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100665752);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992335, XrefRangeEnd = 992339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Subscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Subscriber>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Subscriber(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class ConnectMsg : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0;

		static ConnectMsg()
		{
			Il2CppClassPointerStore<ConnectMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "ConnectMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectMsg>.NativeClassPtr);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectMsg>.NativeClassPtr, 100665753);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992339, XrefRangeEnd = 992340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ConnectMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class StartSendingMsg : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0;

		static StartSendingMsg()
		{
			Il2CppClassPointerStore<StartSendingMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "StartSendingMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartSendingMsg>.NativeClassPtr);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSendingMsg>.NativeClassPtr, 100665754);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992340, XrefRangeEnd = 992342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public StartSendingMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class StopSendingMsg : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0;

		static StopSendingMsg()
		{
			Il2CppClassPointerStore<StopSendingMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "StopSendingMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopSendingMsg>.NativeClassPtr);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopSendingMsg>.NativeClassPtr, 100665755);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992342, XrefRangeEnd = 992344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public StopSendingMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class DisconnectMsg : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0;

		static DisconnectMsg()
		{
			Il2CppClassPointerStore<DisconnectMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "DisconnectMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisconnectMsg>.NativeClassPtr);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisconnectMsg>.NativeClassPtr, 100665756);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992344, XrefRangeEnd = 992363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver, Message msg)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)msg));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DisconnectMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class NewLayoutMsg : Il2CppSystem.Object
	{
		[System.Serializable]
		public sealed class Data : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			private static readonly System.IntPtr NativeFieldInfoPtr_layoutJson;

			private static readonly System.IntPtr NativeFieldInfoPtr_isOverride;

			public unsafe string name
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string layoutJson
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutJson);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutJson)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe bool isOverride
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOverride);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOverride)) = value;
				}
			}

			static Data()
			{
				Il2CppClassPointerStore<Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewLayoutMsg>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Data>.NativeClassPtr);
				NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "name");
				NativeFieldInfoPtr_layoutJson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "layoutJson");
				NativeFieldInfoPtr_isOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "isOverride");
			}

			public Data(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public Data()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Data>.NativeClassPtr))
			{
			}
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Nullable_1_Message_InputRemoting_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0;

		static NewLayoutMsg()
		{
			Il2CppClassPointerStore<NewLayoutMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "NewLayoutMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewLayoutMsg>.NativeClassPtr);
			NativeMethodInfoPtr_Create_Public_Static_Nullable_1_Message_InputRemoting_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewLayoutMsg>.NativeClassPtr, 100665757);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewLayoutMsg>.NativeClassPtr, 100665758);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 992378, RefRangeEnd = 992381, XrefRangeStart = 992363, XrefRangeEnd = 992378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppSystem.Nullable<Message> Create(InputRemoting sender, string layoutName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(layoutName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Nullable_1_Message_InputRemoting_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<Message>(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992381, XrefRangeEnd = 992390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver, Message msg)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)msg));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public NewLayoutMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class NewDeviceMsg : Il2CppSystem.Object
	{
		[System.Serializable]
		public sealed class Data : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			private static readonly System.IntPtr NativeFieldInfoPtr_layout;

			private static readonly System.IntPtr NativeFieldInfoPtr_deviceId;

			private static readonly System.IntPtr NativeFieldInfoPtr_usages;

			private static readonly System.IntPtr NativeFieldInfoPtr_description;

			public unsafe string name
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe string layout
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layout);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layout)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe int deviceId
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceId);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceId)) = value;
				}
			}

			public unsafe Il2CppStringArray usages
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usages);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe InputDeviceDescription description
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description);
					return new InputDeviceDescription(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceDescription>.NativeClassPtr, (System.IntPtr)num));
				}
				set
				{
					// IL cpblk instruction
					Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputDeviceDescription>.NativeClassPtr, ref *(uint*)null));
				}
			}

			static Data()
			{
				Il2CppClassPointerStore<Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewDeviceMsg>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Data>.NativeClassPtr);
				NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "name");
				NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "layout");
				NativeFieldInfoPtr_deviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "deviceId");
				NativeFieldInfoPtr_usages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "usages");
				NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "description");
			}

			public Data(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public Data()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Data>.NativeClassPtr))
			{
			}
		}

		[System.Serializable]
		[ObfuscatedName("UnityEngine.InputSystem.InputRemoting+NewDeviceMsg+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__Create_b__1_0_Internal_String_InternedString_0;

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

			public unsafe static Il2CppSystem.Func<InternedString, string> __9__1_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InternedString, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__1_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewDeviceMsg>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__1_0");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665762);
				NativeMethodInfoPtr__Create_b__1_0_Internal_String_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665763);
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
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992390, XrefRangeEnd = 992391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Create_b__1_0(InternedString x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Create_b__1_0_Internal_String_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0;

		static NewDeviceMsg()
		{
			Il2CppClassPointerStore<NewDeviceMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "NewDeviceMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewDeviceMsg>.NativeClassPtr);
			NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDeviceMsg>.NativeClassPtr, 100665759);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDeviceMsg>.NativeClassPtr, 100665760);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 992426, RefRangeEnd = 992429, XrefRangeStart = 992391, XrefRangeEnd = 992426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message Create(InputDevice device)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Message(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992429, XrefRangeEnd = 992471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver, Message msg)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)msg));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public NewDeviceMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class NewEventsMsg : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateResetEvent_Public_Static_Message_InputDevice_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateStateEvent_Public_Static_Message_InputDevice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Message_ptr_InputEvent_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0;

		static NewEventsMsg()
		{
			Il2CppClassPointerStore<NewEventsMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "NewEventsMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewEventsMsg>.NativeClassPtr);
			NativeMethodInfoPtr_CreateResetEvent_Public_Static_Message_InputDevice_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewEventsMsg>.NativeClassPtr, 100665764);
			NativeMethodInfoPtr_CreateStateEvent_Public_Static_Message_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewEventsMsg>.NativeClassPtr, 100665765);
			NativeMethodInfoPtr_Create_Public_Static_Message_ptr_InputEvent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewEventsMsg>.NativeClassPtr, 100665766);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewEventsMsg>.NativeClassPtr, 100665767);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992471, XrefRangeEnd = 992473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message CreateResetEvent(InputDevice device, bool isHardReset)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHardReset;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateResetEvent_Public_Static_Message_InputDevice_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Message(pointer);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 992481, RefRangeEnd = 992483, XrefRangeStart = 992473, XrefRangeEnd = 992481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message CreateStateEvent(InputDevice device)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStateEvent_Public_Static_Message_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Message(pointer);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 992492, RefRangeEnd = 992496, XrefRangeStart = 992483, XrefRangeEnd = 992492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message Create(InputEvent* events, int eventCount)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)events;
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventCount;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Message_ptr_InputEvent_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Message(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992496, XrefRangeEnd = 992501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver, Message msg)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)msg));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public NewEventsMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class ChangeUsageMsg : Il2CppSystem.Object
	{
		[System.Serializable]
		public sealed class Data : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_deviceId;

			private static readonly System.IntPtr NativeFieldInfoPtr_usages;

			public unsafe int deviceId
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceId);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviceId)) = value;
				}
			}

			public unsafe Il2CppStringArray usages
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usages);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static Data()
			{
				Il2CppClassPointerStore<Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeUsageMsg>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Data>.NativeClassPtr);
				NativeFieldInfoPtr_deviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "deviceId");
				NativeFieldInfoPtr_usages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Data>.NativeClassPtr, "usages");
			}

			public Data(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public Data()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Data>.NativeClassPtr))
			{
			}
		}

		[System.Serializable]
		[ObfuscatedName("UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__Create_b__1_0_Internal_String_InternedString_0;

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

			public unsafe static Il2CppSystem.Func<InternedString, string> __9__1_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InternedString, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__1_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeUsageMsg>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__1_0");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665771);
				NativeMethodInfoPtr__Create_b__1_0_Internal_String_InternedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665772);
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
			public unsafe string _Create_b__1_0(InternedString x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Create_b__1_0_Internal_String_InternedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0;

		static ChangeUsageMsg()
		{
			Il2CppClassPointerStore<ChangeUsageMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "ChangeUsageMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeUsageMsg>.NativeClassPtr);
			NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeUsageMsg>.NativeClassPtr, 100665768);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeUsageMsg>.NativeClassPtr, 100665769);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 992531, RefRangeEnd = 992532, XrefRangeStart = 992501, XrefRangeEnd = 992531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message Create(InputDevice device)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Message(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992532, XrefRangeEnd = 992570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver, Message msg)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)msg));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ChangeUsageMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class RemoveDeviceMsg : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0;

		static RemoveDeviceMsg()
		{
			Il2CppClassPointerStore<RemoveDeviceMsg>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "RemoveDeviceMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveDeviceMsg>.NativeClassPtr);
			NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveDeviceMsg>.NativeClassPtr, 100665773);
			NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveDeviceMsg>.NativeClassPtr, 100665774);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992570, XrefRangeEnd = 992572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message Create(InputDevice device)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Message_InputDevice_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Message(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992572, XrefRangeEnd = 992577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(InputRemoting receiver, Message msg)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)receiver);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)msg));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Static_Void_InputRemoting_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public RemoveDeviceMsg(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_SerializeData_Private_Static_Il2CppStructArray_1_Byte_TData_0<TData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeData_Private_Static_Il2CppStructArray_1_Byte_TData_0, Il2CppClassPointerStore<InputRemoting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_DeserializeData_Private_Static_TData_Il2CppStructArray_1_Byte_0<TData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DeserializeData_Private_Static_TData_Il2CppStructArray_1_Byte_0, Il2CppClassPointerStore<InputRemoting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TData>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Subscribers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Senders;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sending_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sending_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InputManager_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartSending_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopSending_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnNext_Private_Virtual_Final_New_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnError_Private_Virtual_Final_New_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnCompleted_Private_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_IDisposable_IObserver_1_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendInitialMessages_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAllGeneratedLayouts_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendLayout_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAllDevices_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendDevice_Private_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Private_Void_InputEventPtr_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendDeviceChange_Private_Void_InputDevice_InputDeviceChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendLayoutChange_Private_Void_String_InputControlLayoutChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Send_Private_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindOrCreateSenderRecord_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildLayoutNamespace_Private_Static_InternedString_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindLocalDeviceId_Private_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDeviceByRemoteId_Private_InputDevice_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_manager_Internal_get_InputManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRemoteDevices_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeData_Private_Static_Il2CppStructArray_1_Byte_TData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeData_Private_Static_TData_Il2CppStructArray_1_Byte_0;

	public unsafe Flags m_Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
			return *(Flags*)num;
		}
		set
		{
			*(Flags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
		}
	}

	public unsafe InputManager m_LocalManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Subscriber> m_Subscribers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Subscribers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Subscriber>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Subscribers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RemoteSender> m_Senders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Senders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RemoteSender>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Senders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool sending
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sending_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sending_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputManager manager
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_manager_Internal_get_InputManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputManager>(intPtr2) : null;
		}
	}

	static InputRemoting()
	{
		Il2CppClassPointerStore<InputRemoting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputRemoting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr);
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_LocalManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "m_LocalManager");
		NativeFieldInfoPtr_m_Subscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "m_Subscribers");
		NativeFieldInfoPtr_m_Senders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, "m_Senders");
		NativeMethodInfoPtr_get_sending_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665725);
		NativeMethodInfoPtr_set_sending_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665726);
		NativeMethodInfoPtr__ctor_Internal_Void_InputManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665727);
		NativeMethodInfoPtr_StartSending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665728);
		NativeMethodInfoPtr_StopSending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665729);
		NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnNext_Private_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665730);
		NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnError_Private_Virtual_Final_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665731);
		NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnCompleted_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665732);
		NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_IDisposable_IObserver_1_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665733);
		NativeMethodInfoPtr_SendInitialMessages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665734);
		NativeMethodInfoPtr_SendAllGeneratedLayouts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665735);
		NativeMethodInfoPtr_SendLayout_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665736);
		NativeMethodInfoPtr_SendAllDevices_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665737);
		NativeMethodInfoPtr_SendDevice_Private_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665738);
		NativeMethodInfoPtr_SendEvent_Private_Void_InputEventPtr_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665739);
		NativeMethodInfoPtr_SendDeviceChange_Private_Void_InputDevice_InputDeviceChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665740);
		NativeMethodInfoPtr_SendLayoutChange_Private_Void_String_InputControlLayoutChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665741);
		NativeMethodInfoPtr_Send_Private_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665742);
		NativeMethodInfoPtr_FindOrCreateSenderRecord_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665743);
		NativeMethodInfoPtr_BuildLayoutNamespace_Private_Static_InternedString_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665744);
		NativeMethodInfoPtr_FindLocalDeviceId_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665745);
		NativeMethodInfoPtr_TryGetDeviceByRemoteId_Private_InputDevice_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665746);
		NativeMethodInfoPtr_get_manager_Internal_get_InputManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665747);
		NativeMethodInfoPtr_RemoveRemoteDevices_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665748);
		NativeMethodInfoPtr_SerializeData_Private_Static_Il2CppStructArray_1_Byte_TData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665749);
		NativeMethodInfoPtr_DeserializeData_Private_Static_TData_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr, 100665750);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992577, XrefRangeEnd = 992579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputRemoting(InputManager manager, bool startSendingOnConnect = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputRemoting>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)manager);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startSendingOnConnect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_InputManager_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 992608, RefRangeEnd = 992610, XrefRangeStart = 992579, XrefRangeEnd = 992608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartSending()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartSending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 992637, RefRangeEnd = 992639, XrefRangeStart = 992610, XrefRangeEnd = 992637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopSending()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnNext(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)msg));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnNext_Private_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnError(Il2CppSystem.Exception error)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnError_Private_Virtual_Final_New_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnCompleted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IObserver_UnityEngine_InputSystem_InputRemoting_Message__OnCompleted_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992639, XrefRangeEnd = 992648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.IDisposable Subscribe(Il2CppSystem.IObserver<Message> observer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)observer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subscribe_Public_Virtual_Final_New_IDisposable_IObserver_1_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992648, XrefRangeEnd = 992650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendInitialMessages()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendInitialMessages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 992672, RefRangeEnd = 992674, XrefRangeStart = 992650, XrefRangeEnd = 992672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendAllGeneratedLayouts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAllGeneratedLayouts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992674, XrefRangeEnd = 992680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendLayout(string layoutName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(layoutName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendLayout_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 992704, RefRangeEnd = 992706, XrefRangeStart = 992680, XrefRangeEnd = 992704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendAllDevices()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAllDevices_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992706, XrefRangeEnd = 992711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendDevice(InputDevice device)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendDevice_Private_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992711, XrefRangeEnd = 992714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendEvent(InputEventPtr eventPtr, InputDevice device)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eventPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvent_Private_Void_InputEventPtr_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992714, XrefRangeEnd = 992726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendDeviceChange(InputDevice device, InputDeviceChange change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputDeviceChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendDeviceChange_Private_Void_InputDevice_InputDeviceChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992726, XrefRangeEnd = 992734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendLayoutChange(string layout, InputControlLayoutChange change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(layout);
		*(InputControlLayoutChange**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendLayoutChange_Private_Void_String_InputControlLayoutChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 992739, RefRangeEnd = 992748, XrefRangeStart = 992734, XrefRangeEnd = 992739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Send(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)msg));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Send_Private_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 992751, RefRangeEnd = 992758, XrefRangeStart = 992748, XrefRangeEnd = 992751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindOrCreateSenderRecord(int senderId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&senderId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindOrCreateSenderRecord_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992758, XrefRangeEnd = 992764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InternedString BuildLayoutNamespace(int senderId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&senderId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildLayoutNamespace_Private_Static_InternedString_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InternedString(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 992764, RefRangeEnd = 992767, XrefRangeStart = 992764, XrefRangeEnd = 992764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindLocalDeviceId(int remoteDeviceId, int senderIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&remoteDeviceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &senderIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindLocalDeviceId_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992767, XrefRangeEnd = 992770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&remoteDeviceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &senderIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetDeviceByRemoteId_Private_InputDevice_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992770, XrefRangeEnd = 992782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveRemoteDevices(int participantId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&participantId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRemoteDevices_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992782, XrefRangeEnd = 992788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> SerializeData<TData>(TData data)
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TData reference;
		if (!typeof(TData).IsValueType)
		{
			object obj = data;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref data;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeData_Private_Static_Il2CppStructArray_1_Byte_TData_0<TData>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992788, XrefRangeEnd = 992792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TData DeserializeData<TData>(Il2CppStructArray<byte> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DeserializeData_Private_Static_TData_Il2CppStructArray_1_Byte_0<TData>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TData>(intPtr2, false, true);
	}

	public InputRemoting(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
