using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net;

public static class Dns : Object
{
	public sealed class GetHostAddressesCallback : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0;

		static GetHostAddressesCallback()
		{
			Il2CppClassPointerStore<GetHostAddressesCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dns>.NativeClassPtr, "GetHostAddressesCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetHostAddressesCallback>.NativeClassPtr, 100666627);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetHostAddressesCallback>.NativeClassPtr, 100666628);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetHostAddressesCallback>.NativeClassPtr, 100666629);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetHostAddressesCallback>.NativeClassPtr, 100666630);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 862554, RefRangeEnd = 862560, XrefRangeStart = 862554, XrefRangeEnd = 862560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetHostAddressesCallback(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetHostAddressesCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<IPAddress> Invoke(string hostName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50589, RefRangeEnd = 50590, XrefRangeStart = 50589, XrefRangeEnd = 50590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<IPAddress> EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
		}

		public GetHostAddressesCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator GetHostAddressesCallback(System.Func<string, Il2CppReferenceArray<IPAddress>> P_0)
		{
			return DelegateSupport.ConvertDelegate<GetHostAddressesCallback>((System.Delegate)P_0);
		}

		public static GetHostAddressesCallback operator +(GetHostAddressesCallback P_0, GetHostAddressesCallback P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<GetHostAddressesCallback>();
		}

		public static GetHostAddressesCallback operator -(GetHostAddressesCallback P_0, GetHostAddressesCallback P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<GetHostAddressesCallback>();
			}
			return (GetHostAddressesCallback)obj;
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginGetHostAddresses_Public_Static_IAsyncResult_String_AsyncCallback_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndGetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostByName_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostByAddr_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostName_icall_Private_Static_Boolean_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostName_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHostAddressesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_IPAddress_String_0;

	static Dns()
	{
		Il2CppClassPointerStore<Dns>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Dns");
		NativeMethodInfoPtr_BeginGetHostAddresses_Public_Static_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666613);
		NativeMethodInfoPtr_EndGetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666614);
		NativeMethodInfoPtr_GetHostByName_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666615);
		NativeMethodInfoPtr_GetHostByAddr_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666616);
		NativeMethodInfoPtr_GetHostName_icall_Private_Static_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666617);
		NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666618);
		NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666619);
		NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666620);
		NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666621);
		NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666622);
		NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666623);
		NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666624);
		NativeMethodInfoPtr_GetHostName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666625);
		NativeMethodInfoPtr_GetHostAddressesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_IPAddress_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dns>.NativeClassPtr, 100666626);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891978, XrefRangeEnd = 891994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, Object state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requestCallback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginGetHostAddresses_Public_Static_IAsyncResult_String_AsyncCallback_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891994, XrefRangeEnd = 892008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<IPAddress> EndGetHostAddresses(IAsyncResult asyncResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndGetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_IAsyncResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892008, XrefRangeEnd = 892009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetHostByName_icall(string host, out string h_name, out Il2CppStringArray h_aliases, out Il2CppStringArray h_addr_list, int hint)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostByName_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		h_name = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		nint num7 = num4;
		h_aliases = ((num7 == 0) ? ((Il2CppStringArray)null) : new Il2CppStringArray((System.IntPtr)num7));
		nint num8 = num6;
		h_addr_list = ((num8 == 0) ? ((Il2CppStringArray)null) : new Il2CppStringArray((System.IntPtr)num8));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892009, XrefRangeEnd = 892010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetHostByAddr_icall(string addr, out string h_name, out Il2CppStringArray h_aliases, out Il2CppStringArray h_addr_list, int hint)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(addr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostByAddr_icall_Private_Static_Boolean_String_byref_String_byref_Il2CppStringArray_byref_Il2CppStringArray_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		h_name = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		nint num7 = num4;
		h_aliases = ((num7 == 0) ? ((Il2CppStringArray)null) : new Il2CppStringArray((System.IntPtr)num7));
		nint num8 = num6;
		h_addr_list = ((num8 == 0) ? ((Il2CppStringArray)null) : new Il2CppStringArray((System.IntPtr)num8));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892010, XrefRangeEnd = 892011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetHostName_icall(out string h_name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostName_icall_Private_Static_Boolean_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		h_name = IL2CPP.Il2CppStringToManaged((System.IntPtr)num);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892011, XrefRangeEnd = 892018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Error_11001(string hostName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Error_11001_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 892052, RefRangeEnd = 892056, XrefRangeStart = 892018, XrefRangeEnd = 892052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, Il2CppStringArray h_aliases, Il2CppStringArray h_addrlist)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(originalHostName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(h_name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h_aliases);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)h_addrlist);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hostent_to_IPHostEntry_Private_Static_IPHostEntry_String_String_Il2CppStringArray_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892056, XrefRangeEnd = 892071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPHostEntry GetHostByAddressFromString(string address, bool parse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostByAddressFromString_Private_Static_IPHostEntry_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 892093, RefRangeEnd = 892094, XrefRangeStart = 892071, XrefRangeEnd = 892093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPHostEntry GetHostEntry(string hostNameOrAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 892094, XrefRangeEnd = 892106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPHostEntry GetHostEntry(IPAddress address)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostEntry_Public_Static_IPHostEntry_IPAddress_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 892121, RefRangeEnd = 892122, XrefRangeStart = 892106, XrefRangeEnd = 892121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<IPAddress> GetHostAddresses(string hostNameOrAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostAddresses_Public_Static_Il2CppReferenceArray_1_IPAddress_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 892128, RefRangeEnd = 892130, XrefRangeStart = 892122, XrefRangeEnd = 892128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPHostEntry GetHostByName(string hostName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hostName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostByName_Public_Static_IPHostEntry_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 892131, RefRangeEnd = 892133, XrefRangeStart = 892130, XrefRangeEnd = 892131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetHostName()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostName_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 892151, RefRangeEnd = 892152, XrefRangeStart = 892133, XrefRangeEnd = 892151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Task<Il2CppReferenceArray<IPAddress>> GetHostAddressesAsync(string hostNameOrAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hostNameOrAddress);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHostAddressesAsync_Public_Static_Task_1_Il2CppReferenceArray_1_IPAddress_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<Il2CppReferenceArray<IPAddress>>>(intPtr2) : null;
	}

	public Dns(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
