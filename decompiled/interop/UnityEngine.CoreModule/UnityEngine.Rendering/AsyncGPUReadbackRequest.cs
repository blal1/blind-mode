using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AsyncGPUReadbackRequest
{
	private sealed class MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate void UpdateDelegate(System.IntPtr @this);

	private delegate int GetWidthDelegate(System.IntPtr @this);

	private delegate int GetHeightDelegate(System.IntPtr @this);

	private delegate int GetDepthDelegate(System.IntPtr @this);

	private delegate bool GetForcePlayerLoopUpdateDelegate(System.IntPtr @this);

	private delegate void SetForcePlayerLoopUpdateDelegate(System.IntPtr @this, bool b);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly System.IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_done_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDone_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasError_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerCount_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Action_1_AsyncGPUReadbackRequest_AsyncGPUReadbackRequest_0;

	[FieldOffset(0)]
	public System.IntPtr m_Ptr;

	[FieldOffset(8)]
	public int m_Version;

	private static readonly UpdateDelegate UpdateDelegateField;

	private static readonly GetWidthDelegate GetWidthDelegateField;

	private static readonly GetHeightDelegate GetHeightDelegateField;

	private static readonly GetDepthDelegate GetDepthDelegateField;

	private static readonly GetForcePlayerLoopUpdateDelegate GetForcePlayerLoopUpdateDelegateField;

	private static readonly SetForcePlayerLoopUpdateDelegate SetForcePlayerLoopUpdateDelegateField;

	public unsafe bool done
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1231766, RefRangeEnd = 1231769, XrefRangeStart = 1231764, XrefRangeEnd = 1231766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_done_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasError
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1231771, RefRangeEnd = 1231774, XrefRangeStart = 1231769, XrefRangeEnd = 1231771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int layerCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231776, RefRangeEnd = 1231777, XrefRangeStart = 1231774, XrefRangeEnd = 1231776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int layerDataSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1231779, RefRangeEnd = 1231780, XrefRangeStart = 1231777, XrefRangeEnd = 1231779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public int width => GetWidth();

	public int height => GetHeight();

	public int depth => GetDepth();

	public bool forcePlayerLoopUpdate
	{
		get
		{
			return GetForcePlayerLoopUpdate();
		}
		set
		{
			SetForcePlayerLoopUpdate(value);
		}
	}

	static AsyncGPUReadbackRequest()
	{
		Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AsyncGPUReadbackRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, "m_Version");
		NativeMethodInfoPtr_WaitForCompletion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667642);
		NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667643);
		NativeMethodInfoPtr_get_done_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667644);
		NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667645);
		NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667646);
		NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667647);
		NativeMethodInfoPtr_IsDone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667648);
		NativeMethodInfoPtr_HasError_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667649);
		NativeMethodInfoPtr_GetLayerCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667650);
		NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667651);
		NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667652);
		NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667653);
		NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Action_1_AsyncGPUReadbackRequest_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100667654);
		UpdateDelegateField = IL2CPP.ResolveICall<UpdateDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::Update");
		GetWidthDelegateField = IL2CPP.ResolveICall<GetWidthDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetWidth");
		GetHeightDelegateField = IL2CPP.ResolveICall<GetHeightDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetHeight");
		GetDepthDelegateField = IL2CPP.ResolveICall<GetDepthDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetDepth");
		GetForcePlayerLoopUpdateDelegateField = IL2CPP.ResolveICall<GetForcePlayerLoopUpdateDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetForcePlayerLoopUpdate");
		SetForcePlayerLoopUpdateDelegateField = IL2CPP.ResolveICall<SetForcePlayerLoopUpdateDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::SetForcePlayerLoopUpdate");
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1231751, RefRangeEnd = 1231754, XrefRangeStart = 1231749, XrefRangeEnd = 1231751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WaitForCompletion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WaitForCompletion_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1231762, RefRangeEnd = 1231764, XrefRangeStart = 1231754, XrefRangeEnd = 1231762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<T> GetData<T>(int layer = 0) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_Int32_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<T>(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1231766, RefRangeEnd = 1231769, XrefRangeStart = 1231766, XrefRangeEnd = 1231769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDone()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDone_Private_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1231771, RefRangeEnd = 1231774, XrefRangeStart = 1231771, XrefRangeEnd = 1231774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasError()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasError_Private_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1231776, RefRangeEnd = 1231777, XrefRangeStart = 1231776, XrefRangeEnd = 1231777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLayerCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLayerCount_Private_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1231779, RefRangeEnd = 1231780, XrefRangeStart = 1231779, XrefRangeEnd = 1231780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLayerDataSize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231780, XrefRangeEnd = 1231782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetScriptingCallback(Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1231784, RefRangeEnd = 1231785, XrefRangeStart = 1231782, XrefRangeEnd = 1231784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr GetDataRaw(int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void InvokeCallback(Il2CppSystem.Action<AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(AsyncGPUReadbackRequest**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &obj;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Action_1_AsyncGPUReadbackRequest_AsyncGPUReadbackRequest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public unsafe void Update()
	{
		//IL_000b: Expected O, but got Ref
		UpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe int GetWidth()
	{
		//IL_000b: Expected O, but got Ref
		return GetWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe int GetHeight()
	{
		//IL_000b: Expected O, but got Ref
		return GetHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe int GetDepth()
	{
		//IL_000b: Expected O, but got Ref
		return GetDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe bool GetForcePlayerLoopUpdate()
	{
		//IL_000b: Expected O, but got Ref
		return GetForcePlayerLoopUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe void SetForcePlayerLoopUpdate(bool b)
	{
		//IL_000b: Expected O, but got Ref
		SetForcePlayerLoopUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), b);
	}
}
