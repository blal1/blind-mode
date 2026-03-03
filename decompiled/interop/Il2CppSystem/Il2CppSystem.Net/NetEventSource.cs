using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppSystem.Net;

public sealed class NetEventSource : EventSource
{
	public class Keywords : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Default;

		private static readonly System.IntPtr NativeFieldInfoPtr_Debug;

		private static readonly System.IntPtr NativeFieldInfoPtr_EnterExit;

		public unsafe static EventKeywords Default
		{
			get
			{
				Unsafe.SkipInit(out EventKeywords result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Default, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Default, (void*)(&value));
			}
		}

		public unsafe static EventKeywords Debug
		{
			get
			{
				Unsafe.SkipInit(out EventKeywords result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Debug, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Debug, (void*)(&value));
			}
		}

		public unsafe static EventKeywords EnterExit
		{
			get
			{
				Unsafe.SkipInit(out EventKeywords result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnterExit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnterExit, (void*)(&value));
			}
		}

		static Keywords()
		{
			Il2CppClassPointerStore<Keywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, "Keywords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keywords>.NativeClassPtr);
			NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keywords>.NativeClassPtr, "Default");
			NativeFieldInfoPtr_Debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keywords>.NativeClassPtr, "Debug");
			NativeFieldInfoPtr_EnterExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keywords>.NativeClassPtr, "EnterExit");
		}

		public Keywords(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Log;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_FormattableString_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_Object_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Private_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Object_FormattableString_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Object_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Info_Public_Static_Void_Object_FormattableString_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Info_Public_Static_Void_Object_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Info_Private_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ErrorMessage_Private_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fail_Public_Static_Void_Object_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CriticalFailure_Private_Void_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Associate_Public_Static_Void_Object_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Associate_Private_Void_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IdOf_Public_Static_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Public_Static_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Format_Private_Static_String_FormattableString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteEvent_Private_Void_Int32_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static NetEventSource Log
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Log, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetEventSource>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Log, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public new unsafe static bool IsEnabled
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 884851, RefRangeEnd = 884887, XrefRangeStart = 884845, XrefRangeEnd = 884851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static NetEventSource()
	{
		Il2CppClassPointerStore<NetEventSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NetEventSource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr);
		NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, "Log");
		NativeMethodInfoPtr_Enter_Public_Static_Void_Object_FormattableString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665822);
		NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665823);
		NativeMethodInfoPtr_Enter_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr_Exit_Public_Static_Void_Object_FormattableString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665825);
		NativeMethodInfoPtr_Exit_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665826);
		NativeMethodInfoPtr_Exit_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665827);
		NativeMethodInfoPtr_Info_Public_Static_Void_Object_FormattableString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665828);
		NativeMethodInfoPtr_Info_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665829);
		NativeMethodInfoPtr_Info_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665830);
		NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665831);
		NativeMethodInfoPtr_ErrorMessage_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665832);
		NativeMethodInfoPtr_Fail_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665833);
		NativeMethodInfoPtr_CriticalFailure_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665834);
		NativeMethodInfoPtr_Associate_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665835);
		NativeMethodInfoPtr_Associate_Private_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665836);
		NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665837);
		NativeMethodInfoPtr_IdOf_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665838);
		NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665839);
		NativeMethodInfoPtr_Format_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665840);
		NativeMethodInfoPtr_Format_Private_Static_String_FormattableString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665841);
		NativeMethodInfoPtr_WriteEvent_Private_Void_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665842);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr, 100665843);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 884617, RefRangeEnd = 884622, XrefRangeStart = 884596, XrefRangeEnd = 884617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Enter(Object thisOrContextObject, FormattableString formattableString = null, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formattableString);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enter_Public_Static_Void_Object_FormattableString_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 884641, RefRangeEnd = 884644, XrefRangeStart = 884622, XrefRangeEnd = 884641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Enter(Object thisOrContextObject, Object arg0, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 884665, RefRangeEnd = 884666, XrefRangeStart = 884644, XrefRangeEnd = 884665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Enter(Object thisOrContextObject, Object arg0, Object arg1, Object arg2, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enter_Public_Static_Void_Object_Object_Object_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884666, XrefRangeEnd = 884669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Enter(string thisOrContextObject, string memberName, string parameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(parameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enter_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 884690, RefRangeEnd = 884691, XrefRangeStart = 884669, XrefRangeEnd = 884690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Exit(Object thisOrContextObject, FormattableString formattableString = null, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formattableString);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exit_Public_Static_Void_Object_FormattableString_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884691, XrefRangeEnd = 884707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Exit(Object thisOrContextObject, Object arg0, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exit_Public_Static_Void_Object_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884707, XrefRangeEnd = 884710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Exit(string thisOrContextObject, string memberName, string result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exit_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 884731, RefRangeEnd = 884751, XrefRangeStart = 884710, XrefRangeEnd = 884731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Info(Object thisOrContextObject, FormattableString formattableString = null, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formattableString);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Info_Public_Static_Void_Object_FormattableString_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 884767, RefRangeEnd = 884777, XrefRangeStart = 884751, XrefRangeEnd = 884767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Info(Object thisOrContextObject, Object message, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Info_Public_Static_Void_Object_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884777, XrefRangeEnd = 884780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Info(string thisOrContextObject, string memberName, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Info_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884780, XrefRangeEnd = 884796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Error(Object thisOrContextObject, Object message, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884796, XrefRangeEnd = 884799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ErrorMessage(string thisOrContextObject, string memberName, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ErrorMessage_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 884815, RefRangeEnd = 884821, XrefRangeStart = 884799, XrefRangeEnd = 884815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Fail(Object thisOrContextObject, Object message, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fail_Public_Static_Void_Object_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884821, XrefRangeEnd = 884824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CriticalFailure(string thisOrContextObject, string memberName, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CriticalFailure_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 884841, RefRangeEnd = 884842, XrefRangeStart = 884824, XrefRangeEnd = 884841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Associate(Object first, Object second, string memberName = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)first);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)second);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Associate_Public_Static_Void_Object_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884842, XrefRangeEnd = 884845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Associate(string thisOrContextObject, string memberName, string first, string second)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(thisOrContextObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(memberName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(first);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(second);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Associate_Private_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 884896, RefRangeEnd = 884908, XrefRangeStart = 884887, XrefRangeEnd = 884896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IdOf(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IdOf_Public_Static_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int GetHashCode(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 884924, RefRangeEnd = 884933, XrefRangeStart = 884908, XrefRangeEnd = 884924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Format(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Public_Static_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 884944, RefRangeEnd = 884947, XrefRangeStart = 884933, XrefRangeEnd = 884944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(FormattableString s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Format_Private_Static_String_FormattableString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 884960, RefRangeEnd = 884962, XrefRangeStart = 884947, XrefRangeEnd = 884960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&eventId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg3);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg4);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteEvent_Private_Void_Int32_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetEventSource()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetEventSource>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NetEventSource(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
