using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels;

public sealed class ChannelServices : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_registeredChannels;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayedClientChannels;

	private static readonly System.IntPtr NativeFieldInfoPtr__crossContextSink;

	private static readonly System.IntPtr NativeFieldInfoPtr_CrossContextUrl;

	private static readonly System.IntPtr NativeFieldInfoPtr_oldStartModeTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0;

	public unsafe static ArrayList registeredChannels
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_registeredChannels, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_registeredChannels, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ArrayList delayedClientChannels
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_delayedClientChannels, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_delayedClientChannels, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CrossContextChannel _crossContextSink
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__crossContextSink, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CrossContextChannel>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__crossContextSink, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string CrossContextUrl
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CrossContextUrl, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CrossContextUrl, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static IList oldStartModeTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_oldStartModeTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_oldStartModeTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CrossContextChannel CrossContextChannel
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793944, XrefRangeEnd = 793948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CrossContextChannel>(intPtr2) : null;
		}
	}

	static ChannelServices()
	{
		Il2CppClassPointerStore<ChannelServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "ChannelServices");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr);
		NativeFieldInfoPtr_registeredChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "registeredChannels");
		NativeFieldInfoPtr_delayedClientChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "delayedClientChannels");
		NativeFieldInfoPtr__crossContextSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "_crossContextSink");
		NativeFieldInfoPtr_CrossContextUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "CrossContextUrl");
		NativeFieldInfoPtr_oldStartModeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, "oldStartModeTypes");
		NativeMethodInfoPtr_get_CrossContextChannel_Internal_Static_get_CrossContextChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670142);
		NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670143);
		NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670144);
		NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670145);
		NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670146);
		NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670147);
		NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670148);
		NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670149);
		NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670150);
		NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670151);
		NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670152);
		NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelServices>.NativeClassPtr, 100670153);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794008, RefRangeEnd = 794011, XrefRangeStart = 793948, XrefRangeEnd = 794008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMessageSink CreateClientChannelSinkChain(string url, Object remoteChannelData, out string objectUri)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remoteChannelData);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_String_Object_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		objectUri = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 794020, RefRangeEnd = 794022, XrefRangeStart = 794011, XrefRangeEnd = 794020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, Il2CppReferenceArray<Object> channelDataArray, out string objectUri)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)channelDataArray);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateClientChannelSinkChain_Internal_Static_IMessageSink_IChannelSender_String_Il2CppReferenceArray_1_Object_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		objectUri = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794026, RefRangeEnd = 794027, XrefRangeStart = 794022, XrefRangeEnd = 794026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterChannel(IChannel chnl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chnl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794084, RefRangeEnd = 794087, XrefRangeStart = 794027, XrefRangeEnd = 794084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterChannel(IChannel chnl, bool ensureSecurity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chnl);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ensureSecurity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterChannel_Public_Static_Void_IChannel_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794235, RefRangeEnd = 794236, XrefRangeStart = 794087, XrefRangeEnd = 794235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterChannelConfig(ChannelData channel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)channel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterChannelConfig_Internal_Static_Void_ChannelData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 794252, RefRangeEnd = 794254, XrefRangeStart = 794236, XrefRangeEnd = 794252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateProvider(ProviderData prov)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prov);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateProvider_Private_Static_Object_ProviderData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794308, RefRangeEnd = 794309, XrefRangeStart = 794254, XrefRangeEnd = 794308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMessage SyncDispatchMessage(IMessage msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncDispatchMessage_Public_Static_IMessage_IMessage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794327, RefRangeEnd = 794328, XrefRangeStart = 794309, XrefRangeEnd = 794327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReturnMessage CheckIncomingMessage(IMessage msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIncomingMessage_Private_Static_ReturnMessage_IMessage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReturnMessage>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794354, RefRangeEnd = 794355, XrefRangeStart = 794328, XrefRangeEnd = 794354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callMsg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)retMsg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckReturnMessage_Internal_Static_IMessage_IMessage_IMessage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLocalCall(IMessage callMsg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callMsg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLocalCall_Private_Static_Boolean_IMessage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794396, RefRangeEnd = 794399, XrefRangeStart = 794355, XrefRangeEnd = 794396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> GetCurrentChannelInfo()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentChannelInfo_Internal_Static_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	public ChannelServices(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
