using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Analytics;

public class AnalyticsEventBase : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_eventName;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendEventOptions;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SendEventOptions_String_0;

	public unsafe string eventName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int eventVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventVersion)) = value;
		}
	}

	public unsafe string eventPrefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventPrefix);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventPrefix)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe SendEventOptions sendEventOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendEventOptions);
			return *(SendEventOptions*)num;
		}
		set
		{
			*(SendEventOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendEventOptions)) = value;
		}
	}

	static AnalyticsEventBase()
	{
		Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Analytics", "AnalyticsEventBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr);
		NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, "eventName");
		NativeFieldInfoPtr_eventVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, "eventVersion");
		NativeFieldInfoPtr_eventPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, "eventPrefix");
		NativeFieldInfoPtr_sendEventOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, "sendEventOptions");
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SendEventOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr, 100667625);
	}

	[CallerCount(67)]
	[CachedScanResults(RefRangeStart = 1231581, RefRangeEnd = 1231648, XrefRangeStart = 1231578, XrefRangeEnd = 1231581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnalyticsEventBase(string eventName, int eventVersion, SendEventOptions sendEventOptions = SendEventOptions.kAppendNone, string eventPrefix = "")
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsEventBase>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventVersion;
		*(SendEventOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sendEventOptions;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(eventPrefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_SendEventOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnalyticsEventBase(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public string EventName()
	{
		return eventName;
	}

	public int EventVersion()
	{
		return eventVersion;
	}

	public string EventPrefix()
	{
		return eventPrefix;
	}
}
