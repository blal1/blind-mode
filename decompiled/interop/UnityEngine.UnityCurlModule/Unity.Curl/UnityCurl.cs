using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.Curl;

public static class UnityCurl
{
	private delegate global::System.IntPtr CreateMultiHandleDelegate();

	private delegate void DestroyMultiHandleDelegate(global::System.IntPtr handle);

	private delegate global::System.IntPtr CreateEasyHandleDelegate(global::System.IntPtr method, global::System.IntPtr url, [Out] global::System.IntPtr curlMethod);

	private delegate void SetupEasyHandleDelegate(global::System.IntPtr handle, uint curlMethod, global::System.IntPtr headers, ulong contentLen, uint flags);

	private delegate void DestroyEasyHandleDelegate(global::System.IntPtr handle);

	private delegate void QueueRequestDelegate(global::System.IntPtr multiHandle, global::System.IntPtr easyHandle);

	private delegate global::System.IntPtr AppendHeaderDelegate(global::System.IntPtr headerList, global::System.IntPtr header);

	private delegate void FreeHeaderListDelegate(global::System.IntPtr headerList);

	private delegate int GetRequestErrorCodeDelegate(global::System.IntPtr request);

	private delegate int GetRequestStatusDelegate(global::System.IntPtr request);

	private delegate uint GetRequestStatusCodeDelegate(global::System.IntPtr request);

	private delegate void GetDownloadSizeDelegate(global::System.IntPtr request, [Out] global::System.IntPtr downloaded, [Out] global::System.IntPtr expected);

	private delegate global::System.IntPtr GetResponseHeaderDelegate(global::System.IntPtr request, uint index, [Out] global::System.IntPtr length);

	private delegate global::System.IntPtr GetMoreBodyDelegate(global::System.IntPtr handle, [Out] global::System.IntPtr length);

	private delegate void SendMoreBodyDelegate(global::System.IntPtr handle, global::System.IntPtr chunk, uint length, int ownership);

	private delegate void AbortRequestDelegate(global::System.IntPtr handle);

	private static readonly CreateMultiHandleDelegate CreateMultiHandleDelegateField = IL2CPP.ResolveICall<CreateMultiHandleDelegate>("Unity.Curl.UnityCurl::CreateMultiHandle");

	private static readonly DestroyMultiHandleDelegate DestroyMultiHandleDelegateField = IL2CPP.ResolveICall<DestroyMultiHandleDelegate>("Unity.Curl.UnityCurl::DestroyMultiHandle");

	private static readonly CreateEasyHandleDelegate CreateEasyHandleDelegateField = IL2CPP.ResolveICall<CreateEasyHandleDelegate>("Unity.Curl.UnityCurl::CreateEasyHandle");

	private static readonly SetupEasyHandleDelegate SetupEasyHandleDelegateField = IL2CPP.ResolveICall<SetupEasyHandleDelegate>("Unity.Curl.UnityCurl::SetupEasyHandle");

	private static readonly DestroyEasyHandleDelegate DestroyEasyHandleDelegateField = IL2CPP.ResolveICall<DestroyEasyHandleDelegate>("Unity.Curl.UnityCurl::DestroyEasyHandle");

	private static readonly QueueRequestDelegate QueueRequestDelegateField = IL2CPP.ResolveICall<QueueRequestDelegate>("Unity.Curl.UnityCurl::QueueRequest");

	private static readonly AppendHeaderDelegate AppendHeaderDelegateField = IL2CPP.ResolveICall<AppendHeaderDelegate>("Unity.Curl.UnityCurl::AppendHeader");

	private static readonly FreeHeaderListDelegate FreeHeaderListDelegateField = IL2CPP.ResolveICall<FreeHeaderListDelegate>("Unity.Curl.UnityCurl::FreeHeaderList");

	private static readonly GetRequestErrorCodeDelegate GetRequestErrorCodeDelegateField = IL2CPP.ResolveICall<GetRequestErrorCodeDelegate>("Unity.Curl.UnityCurl::GetRequestErrorCode");

	private static readonly GetRequestStatusDelegate GetRequestStatusDelegateField = IL2CPP.ResolveICall<GetRequestStatusDelegate>("Unity.Curl.UnityCurl::GetRequestStatus");

	private static readonly GetRequestStatusCodeDelegate GetRequestStatusCodeDelegateField = IL2CPP.ResolveICall<GetRequestStatusCodeDelegate>("Unity.Curl.UnityCurl::GetRequestStatusCode");

	private static readonly GetDownloadSizeDelegate GetDownloadSizeDelegateField = IL2CPP.ResolveICall<GetDownloadSizeDelegate>("Unity.Curl.UnityCurl::GetDownloadSize");

	private static readonly GetResponseHeaderDelegate GetResponseHeaderDelegateField = IL2CPP.ResolveICall<GetResponseHeaderDelegate>("Unity.Curl.UnityCurl::GetResponseHeader");

	private static readonly GetMoreBodyDelegate GetMoreBodyDelegateField = IL2CPP.ResolveICall<GetMoreBodyDelegate>("Unity.Curl.UnityCurl::GetMoreBody");

	private static readonly SendMoreBodyDelegate SendMoreBodyDelegateField = IL2CPP.ResolveICall<SendMoreBodyDelegate>("Unity.Curl.UnityCurl::SendMoreBody");

	private static readonly AbortRequestDelegate AbortRequestDelegateField = IL2CPP.ResolveICall<AbortRequestDelegate>("Unity.Curl.UnityCurl::AbortRequest");

	public static global::System.IntPtr CreateMultiHandle()
	{
		return CreateMultiHandleDelegateField();
	}

	public static void DestroyMultiHandle(global::System.IntPtr handle)
	{
		DestroyMultiHandleDelegateField(handle);
	}

	public unsafe static global::System.IntPtr CreateEasyHandle(byte* method, byte* url, out uint curlMethod)
	{
		return CreateEasyHandleDelegateField((nint)method, (nint)url, (nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref curlMethod));
	}

	public static void SetupEasyHandle(global::System.IntPtr handle, uint curlMethod, global::System.IntPtr headers, ulong contentLen, uint flags)
	{
		SetupEasyHandleDelegateField(handle, curlMethod, headers, contentLen, flags);
	}

	public static void DestroyEasyHandle(global::System.IntPtr handle)
	{
		DestroyEasyHandleDelegateField(handle);
	}

	public static void QueueRequest(global::System.IntPtr multiHandle, global::System.IntPtr easyHandle)
	{
		QueueRequestDelegateField(multiHandle, easyHandle);
	}

	public unsafe static global::System.IntPtr AppendHeader(global::System.IntPtr headerList, byte* header)
	{
		return AppendHeaderDelegateField(headerList, (nint)header);
	}

	public static void FreeHeaderList(global::System.IntPtr headerList)
	{
		FreeHeaderListDelegateField(headerList);
	}

	public static int GetRequestErrorCode(global::System.IntPtr request)
	{
		return GetRequestErrorCodeDelegateField(request);
	}

	public static int GetRequestStatus(global::System.IntPtr request)
	{
		return GetRequestStatusDelegateField(request);
	}

	public static uint GetRequestStatusCode(global::System.IntPtr request)
	{
		return GetRequestStatusCodeDelegateField(request);
	}

	public unsafe static void GetDownloadSize(global::System.IntPtr request, out ulong downloaded, out ulong expected)
	{
		GetDownloadSizeDelegateField(request, (nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref downloaded), (nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref expected));
	}

	public unsafe static byte* GetResponseHeader(global::System.IntPtr request, uint index, out uint length)
	{
		return (byte*)GetResponseHeaderDelegateField(request, index, (nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref length));
	}

	public unsafe static byte* GetMoreBody(global::System.IntPtr handle, out int length)
	{
		return (byte*)GetMoreBodyDelegateField(handle, (nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref length));
	}

	public unsafe static void SendMoreBody(global::System.IntPtr handle, byte* chunk, uint length, BufferOwnership ownership)
	{
		SendMoreBody(handle, chunk, length, (int)ownership);
	}

	public unsafe static void SendMoreBody(global::System.IntPtr handle, byte* chunk, uint length, int ownership)
	{
		SendMoreBodyDelegateField(handle, (nint)chunk, length, ownership);
	}

	public static void AbortRequest(global::System.IntPtr handle)
	{
		AbortRequestDelegateField(handle);
	}
}
