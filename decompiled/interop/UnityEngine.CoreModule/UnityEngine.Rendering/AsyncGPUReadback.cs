using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public static class AsyncGPUReadback : Il2CppSystem.Object
{
	private delegate void WaitAllRequestsDelegate();

	private delegate void Request_Internal_ComputeBuffer_1_InjectedDelegate(System.IntPtr buffer, System.IntPtr data, [Out] System.IntPtr ret);

	private delegate void Request_Internal_ComputeBuffer_2_InjectedDelegate(System.IntPtr src, int size, int offset, System.IntPtr data, [Out] System.IntPtr ret);

	private delegate void Request_Internal_Texture_1_InjectedDelegate(System.IntPtr src, int mipIndex, System.IntPtr data, [Out] System.IntPtr ret);

	private delegate void Request_Internal_Texture_2_InjectedDelegate(System.IntPtr src, int mipIndex, GraphicsFormat dstFormat, System.IntPtr data, [Out] System.IntPtr ret);

	private delegate void Request_Internal_Texture_3_InjectedDelegate(System.IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.IntPtr data, [Out] System.IntPtr ret);

	private delegate void Request_Internal_Texture_4_InjectedDelegate(System.IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, System.IntPtr data, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Int32_Int32_Action_1_AsyncGPUReadbackRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_2_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Int32_Int32_ptr_AsyncRequestNativeArrayData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_IntPtr_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_2_Injected_Private_Static_Void_IntPtr_Int32_Int32_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0;

	private static readonly WaitAllRequestsDelegate WaitAllRequestsDelegateField;

	private static readonly Request_Internal_ComputeBuffer_1_InjectedDelegate Request_Internal_ComputeBuffer_1_InjectedDelegateField;

	private static readonly Request_Internal_ComputeBuffer_2_InjectedDelegate Request_Internal_ComputeBuffer_2_InjectedDelegateField;

	private static readonly Request_Internal_Texture_1_InjectedDelegate Request_Internal_Texture_1_InjectedDelegateField;

	private static readonly Request_Internal_Texture_2_InjectedDelegate Request_Internal_Texture_2_InjectedDelegateField;

	private static readonly Request_Internal_Texture_3_InjectedDelegate Request_Internal_Texture_3_InjectedDelegateField;

	private static readonly Request_Internal_Texture_4_InjectedDelegate Request_Internal_Texture_4_InjectedDelegateField;

	static AsyncGPUReadback()
	{
		Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncGPUReadback");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr);
		NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667656);
		NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Int32_Int32_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667657);
		NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667658);
		NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_2_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Int32_Int32_ptr_AsyncRequestNativeArrayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667659);
		NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_IntPtr_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667660);
		NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_2_Injected_Private_Static_Void_IntPtr_Int32_Int32_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100667661);
		WaitAllRequestsDelegateField = IL2CPP.ResolveICall<WaitAllRequestsDelegate>("UnityEngine.Rendering.AsyncGPUReadback::WaitAllRequests");
		Request_Internal_ComputeBuffer_1_InjectedDelegateField = IL2CPP.ResolveICall<Request_Internal_ComputeBuffer_1_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_1_Injected");
		Request_Internal_ComputeBuffer_2_InjectedDelegateField = IL2CPP.ResolveICall<Request_Internal_ComputeBuffer_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_2_Injected");
		Request_Internal_Texture_1_InjectedDelegateField = IL2CPP.ResolveICall<Request_Internal_Texture_1_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_1_Injected");
		Request_Internal_Texture_2_InjectedDelegateField = IL2CPP.ResolveICall<Request_Internal_Texture_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_2_Injected");
		Request_Internal_Texture_3_InjectedDelegateField = IL2CPP.ResolveICall<Request_Internal_Texture_3_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_3_Injected");
		Request_Internal_Texture_4_InjectedDelegateField = IL2CPP.ResolveICall<Request_Internal_Texture_4_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_4_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1231793, RefRangeEnd = 1231795, XrefRangeStart = 1231786, XrefRangeEnd = 1231793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncGPUReadbackRequest Request(GraphicsBuffer src, Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AsyncGPUReadbackRequest*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1231802, RefRangeEnd = 1231803, XrefRangeStart = 1231795, XrefRangeEnd = 1231802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncGPUReadbackRequest Request(GraphicsBuffer src, int size, int offset, Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Int32_Int32_Action_1_AsyncGPUReadbackRequest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AsyncGPUReadbackRequest*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231803, XrefRangeEnd = 1231808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(AsyncRequestNativeArrayData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = data;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AsyncGPUReadbackRequest*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231808, XrefRangeEnd = 1231813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2(GraphicsBuffer src, int size, int offset, AsyncRequestNativeArrayData* data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(AsyncRequestNativeArrayData**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = data;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_2_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Int32_Int32_ptr_AsyncRequestNativeArrayData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AsyncGPUReadbackRequest*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231813, XrefRangeEnd = 1231815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Request_Internal_GraphicsBuffer_1_Injected(System.IntPtr buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&buffer);
		*(AsyncRequestNativeArrayData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = data;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_IntPtr_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231815, XrefRangeEnd = 1231817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Request_Internal_GraphicsBuffer_2_Injected(System.IntPtr src, int size, int offset, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(AsyncRequestNativeArrayData**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = data;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_2_Injected_Private_Static_Void_IntPtr_Int32_Int32_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AsyncGPUReadback(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void ValidateFormat(Texture src, GraphicsFormat dstformat)
	{
		GraphicsFormat format = GraphicsFormatUtility.GetFormat(src);
		if (!SystemInfo.IsFormatSupported(format, GraphicsFormatUsage.ReadPixels))
		{
			Debug.LogError(Il2CppSystem.String.Format("'{0}' doesn't support ReadPixels usage on this platform. Async GPU readback failed.", (Il2CppSystem.Object)(object)format));
		}
	}

	public static void WaitAllRequests()
	{
		WaitAllRequestsDelegateField();
	}

	public unsafe static AsyncGPUReadbackRequest Request(ComputeBuffer src, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		AsyncGPUReadbackRequest result = Request_Internal_ComputeBuffer_1(src, null);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest Request(ComputeBuffer src, int size, int offset, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		AsyncGPUReadbackRequest result = Request_Internal_ComputeBuffer_2(src, size, offset, null);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest Request(Texture src, [Optional] int mipIndex, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		AsyncGPUReadbackRequest result = Request_Internal_Texture_1(src, mipIndex, null);
		result.SetScriptingCallback(callback);
		return result;
	}

	public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, TextureFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		return Request(src, mipIndex, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
	}

	public unsafe static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, GraphicsFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		ValidateFormat(src, dstFormat);
		AsyncGPUReadbackRequest result = Request_Internal_Texture_2(src, mipIndex, dstFormat, null);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		AsyncGPUReadbackRequest result = Request_Internal_Texture_3(src, mipIndex, x, width, y, height, z, depth, null);
		result.SetScriptingCallback(callback);
		return result;
	}

	public static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		return Request(src, mipIndex, x, width, y, height, z, depth, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
	}

	public unsafe static AsyncGPUReadbackRequest Request(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		ValidateFormat(src, dstFormat);
		AsyncGPUReadbackRequest result = Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, null);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_ComputeBuffer_1(src, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, ComputeBuffer src, int size, int offset, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_ComputeBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, GraphicsBuffer src, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_GraphicsBuffer_1(src, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, GraphicsBuffer src, int size, int offset, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_GraphicsBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, [Optional] int mipIndex, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_Texture_1(src, mipIndex, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, TextureFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		return RequestIntoNativeArray(ref output, src, mipIndex, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, GraphicsFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		ValidateFormat(src, dstFormat);
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_Texture_2(src, mipIndex, dstFormat, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		return RequestIntoNativeArray(ref output, src, mipIndex, x, width, y, height, z, depth, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(ref NativeArray<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		ValidateFormat(src, dstFormat);
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, ComputeBuffer src, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_ComputeBuffer_1(src, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, ComputeBuffer src, int size, int offset, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_ComputeBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, GraphicsBuffer src, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_GraphicsBuffer_1(src, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, GraphicsBuffer src, int size, int offset, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_GraphicsBuffer_2(src, size, offset, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, [Optional] int mipIndex, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_Texture_1(src, mipIndex, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, TextureFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		return RequestIntoNativeSlice(ref output, src, mipIndex, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, GraphicsFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		ValidateFormat(src, dstFormat);
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_Texture_2(src, mipIndex, dstFormat, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		return RequestIntoNativeSlice(ref output, src, mipIndex, x, width, y, height, z, depth, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
	}

	public unsafe static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(ref NativeSlice<T> output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, [Optional] Il2CppSystem.Action<AsyncGPUReadbackRequest> callback) where T : struct
	{
		ValidateFormat(src, dstFormat);
		AsyncRequestNativeArrayData asyncRequestNativeArrayData = AsyncRequestNativeArrayData.CreateAndCheckAccess(output);
		AsyncGPUReadbackRequest result = Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, &asyncRequestNativeArrayData);
		result.SetScriptingCallback(callback);
		return result;
	}

	public unsafe static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(ComputeBuffer buffer, AsyncRequestNativeArrayData* data)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = ComputeBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		Request_Internal_ComputeBuffer_1_Injected(intPtr, data, out var ret);
		return ret;
	}

	public unsafe static AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_2(ComputeBuffer src, int size, int offset, AsyncRequestNativeArrayData* data)
	{
		if (src == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		System.IntPtr intPtr = ComputeBuffer.BindingsMarshaller.ConvertToNative(src);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		Request_Internal_ComputeBuffer_2_Injected(intPtr, size, offset, data, out var ret);
		return ret;
	}

	public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_1(Texture src, int mipIndex, AsyncRequestNativeArrayData* data)
	{
		if ((object)src == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(src);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		Request_Internal_Texture_1_Injected(intPtr, mipIndex, data, out var ret);
		return ret;
	}

	public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_2(Texture src, int mipIndex, GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data)
	{
		if ((object)src == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(src);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		Request_Internal_Texture_2_Injected(intPtr, mipIndex, dstFormat, data, out var ret);
		return ret;
	}

	public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_3(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, AsyncRequestNativeArrayData* data)
	{
		if ((object)src == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(src);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		Request_Internal_Texture_3_Injected(intPtr, mipIndex, x, width, y, height, z, depth, data, out var ret);
		return ret;
	}

	public unsafe static AsyncGPUReadbackRequest Request_Internal_Texture_4(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data)
	{
		if ((object)src == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(src);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(src, "src");
		}
		Request_Internal_Texture_4_Injected(intPtr, mipIndex, x, width, y, height, z, depth, dstFormat, data, out var ret);
		return ret;
	}

	public unsafe static void Request_Internal_ComputeBuffer_1_Injected(System.IntPtr buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
	{
		Request_Internal_ComputeBuffer_1_InjectedDelegateField(buffer, (nint)data, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Request_Internal_ComputeBuffer_2_Injected(System.IntPtr src, int size, int offset, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
	{
		Request_Internal_ComputeBuffer_2_InjectedDelegateField(src, size, offset, (nint)data, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Request_Internal_Texture_1_Injected(System.IntPtr src, int mipIndex, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
	{
		Request_Internal_Texture_1_InjectedDelegateField(src, mipIndex, (nint)data, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Request_Internal_Texture_2_Injected(System.IntPtr src, int mipIndex, GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
	{
		Request_Internal_Texture_2_InjectedDelegateField(src, mipIndex, dstFormat, (nint)data, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Request_Internal_Texture_3_Injected(System.IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
	{
		Request_Internal_Texture_3_InjectedDelegateField(src, mipIndex, x, width, y, height, z, depth, (nint)data, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Request_Internal_Texture_4_Injected(System.IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret)
	{
		Request_Internal_Texture_4_InjectedDelegateField(src, mipIndex, x, width, y, height, z, depth, dstFormat, (nint)data, (nint)Unsafe.AsPointer(ref ret));
	}
}
