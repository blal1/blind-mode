using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class InAppBilling : MonoBehaviour
{
	public sealed class Func : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static Func()
		{
			Il2CppClassPointerStore<Func>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "Func");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func>.NativeClassPtr, 100663510);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func>.NativeClassPtr, 100663511);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func>.NativeClassPtr, 100663512);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func>.NativeClassPtr, 100663513);
		}

		[CallerCount(4109)]
		[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27725, XrefRangeEnd = 27728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31837, XrefRangeEnd = 31838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31838, XrefRangeEnd = 31839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Func(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator Func(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<Func>((System.Delegate)P_0);
		}

		public static Func operator +(Func P_0, Func P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<Func>();
		}

		public static Func operator -(Func P_0, Func P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<Func>();
			}
			return (Func)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_SUCCESS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_REQUIRE_AGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_INVALID_RECEIPT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_BAD_REQUEST;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_ALREADY_FINISHED;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_SERVER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_USER_CANNOT_BUY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_MAINTENANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_NOT_ENOUGH_POINT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_BAD_USER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_PURCHASE_CANCELED;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_NO_SUBSCRIPTIONS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_VOIDED_PURCHASE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ERR_PURCHASE_PENDING;

	private static readonly System.IntPtr NativeFieldInfoPtr_base64EncodedPublicKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_debuggable;

	private static readonly System.IntPtr NativeFieldInfoPtr_queue;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Private_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunOnMainThread_Public_Static_Void_Func_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string version
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_version, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_version, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static int SUCCESS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUCCESS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUCCESS, (void*)(&value));
		}
	}

	public unsafe static int ERR_REQUIRE_AGE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_REQUIRE_AGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_REQUIRE_AGE, (void*)(&value));
		}
	}

	public unsafe static int ERR_INVALID_RECEIPT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_INVALID_RECEIPT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_INVALID_RECEIPT, (void*)(&value));
		}
	}

	public unsafe static int ERR_BAD_REQUEST
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_BAD_REQUEST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_BAD_REQUEST, (void*)(&value));
		}
	}

	public unsafe static int ERR_ALREADY_FINISHED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_ALREADY_FINISHED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_ALREADY_FINISHED, (void*)(&value));
		}
	}

	public unsafe static int ERR_SERVER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_SERVER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_SERVER, (void*)(&value));
		}
	}

	public unsafe static int ERR_USER_CANNOT_BUY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_USER_CANNOT_BUY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_USER_CANNOT_BUY, (void*)(&value));
		}
	}

	public unsafe static int ERR_MAINTENANCE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_MAINTENANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_MAINTENANCE, (void*)(&value));
		}
	}

	public unsafe static int ERR_NOT_ENOUGH_POINT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_NOT_ENOUGH_POINT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_NOT_ENOUGH_POINT, (void*)(&value));
		}
	}

	public unsafe static int ERR_BAD_USER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_BAD_USER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_BAD_USER, (void*)(&value));
		}
	}

	public unsafe static int ERR_PURCHASE_CANCELED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_PURCHASE_CANCELED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_PURCHASE_CANCELED, (void*)(&value));
		}
	}

	public unsafe static int ERR_NO_SUBSCRIPTIONS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_NO_SUBSCRIPTIONS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_NO_SUBSCRIPTIONS, (void*)(&value));
		}
	}

	public unsafe static int ERR_VOIDED_PURCHASE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_VOIDED_PURCHASE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_VOIDED_PURCHASE, (void*)(&value));
		}
	}

	public unsafe static int ERR_PURCHASE_PENDING
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ERR_PURCHASE_PENDING, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ERR_PURCHASE_PENDING, (void*)(&value));
		}
	}

	public unsafe string base64EncodedPublicKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base64EncodedPublicKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base64EncodedPublicKey)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool debuggable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debuggable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debuggable)) = value;
		}
	}

	public unsafe static Queue<Func> queue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_queue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<Func>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_queue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InAppBilling()
	{
		Il2CppClassPointerStore<InAppBilling>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InAppBilling");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr);
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "version");
		NativeFieldInfoPtr_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "SUCCESS");
		NativeFieldInfoPtr_ERR_REQUIRE_AGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_REQUIRE_AGE");
		NativeFieldInfoPtr_ERR_INVALID_RECEIPT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_INVALID_RECEIPT");
		NativeFieldInfoPtr_ERR_BAD_REQUEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_BAD_REQUEST");
		NativeFieldInfoPtr_ERR_ALREADY_FINISHED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_ALREADY_FINISHED");
		NativeFieldInfoPtr_ERR_SERVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_SERVER");
		NativeFieldInfoPtr_ERR_USER_CANNOT_BUY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_USER_CANNOT_BUY");
		NativeFieldInfoPtr_ERR_MAINTENANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_MAINTENANCE");
		NativeFieldInfoPtr_ERR_NOT_ENOUGH_POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_NOT_ENOUGH_POINT");
		NativeFieldInfoPtr_ERR_BAD_USER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_BAD_USER");
		NativeFieldInfoPtr_ERR_PURCHASE_CANCELED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_PURCHASE_CANCELED");
		NativeFieldInfoPtr_ERR_NO_SUBSCRIPTIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_NO_SUBSCRIPTIONS");
		NativeFieldInfoPtr_ERR_VOIDED_PURCHASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_VOIDED_PURCHASE");
		NativeFieldInfoPtr_ERR_PURCHASE_PENDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "ERR_PURCHASE_PENDING");
		NativeFieldInfoPtr_base64EncodedPublicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "base64EncodedPublicKey");
		NativeFieldInfoPtr_debuggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "debuggable");
		NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, "queue");
		NativeMethodInfoPtr_decode_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_RunOnMainThread_Public_Static_Void_Func_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr, 100663508);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31839, XrefRangeEnd = 31845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string decode(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31845, XrefRangeEnd = 31849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31849, XrefRangeEnd = 31857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RunOnMainThread(Func f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunOnMainThread_Public_Static_Void_Func_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31857, XrefRangeEnd = 31867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31867, XrefRangeEnd = 31872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InAppBilling()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAppBilling>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InAppBilling(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
