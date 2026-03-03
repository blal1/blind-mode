using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct PlayableGraph
{
	private sealed class MethodInfoStoreGeneric_Connect_Public_Boolean_U_Int32_V_Int32_0<U, V>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0, Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
		}))));
	}

	private delegate bool IsDoneDelegate(System.IntPtr @this);

	private delegate DirectorUpdateMode GetTimeUpdateModeDelegate(System.IntPtr @this);

	private delegate void SetResolverDelegate(System.IntPtr @this, System.IntPtr value);

	private delegate int GetOutputCountDelegate(System.IntPtr @this);

	private delegate void DisableMatchFrameRateDelegate(System.IntPtr @this);

	private delegate bool GetOutputInternalDelegate(System.IntPtr @this, int index, [Out] System.IntPtr handle);

	private delegate int GetOutputCountByTypeInternalDelegate(System.IntPtr @this, System.IntPtr outputType);

	private delegate bool GetOutputByTypeInternalDelegate(System.IntPtr @this, System.IntPtr outputType, int index, [Out] System.IntPtr handle);

	private delegate void DestroyOutputInternal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr handle);

	private delegate void EnableMatchFrameRate_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr frameRate);

	private delegate void DisconnectInternal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr playable, int inputPort);

	private delegate void DestroyPlayableInternal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr playable);

	private delegate void DestroySubgraphInternal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr playable);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlaying_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTimeUpdateMode_Public_Void_DirectorUpdateMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0;

	[FieldOffset(0)]
	public System.IntPtr m_Handle;

	[FieldOffset(8)]
	public uint m_Version;

	private static readonly IsDoneDelegate IsDoneDelegateField;

	private static readonly GetTimeUpdateModeDelegate GetTimeUpdateModeDelegateField;

	private static readonly SetResolverDelegate SetResolverDelegateField;

	private static readonly GetOutputCountDelegate GetOutputCountDelegateField;

	private static readonly DisableMatchFrameRateDelegate DisableMatchFrameRateDelegateField;

	private static readonly GetOutputInternalDelegate GetOutputInternalDelegateField;

	private static readonly GetOutputCountByTypeInternalDelegate GetOutputCountByTypeInternalDelegateField;

	private static readonly GetOutputByTypeInternalDelegate GetOutputByTypeInternalDelegateField;

	private static readonly DestroyOutputInternal_InjectedDelegate DestroyOutputInternal_InjectedDelegateField;

	private static readonly EnableMatchFrameRate_InjectedDelegate EnableMatchFrameRate_InjectedDelegateField;

	private static readonly DisconnectInternal_InjectedDelegate DisconnectInternal_InjectedDelegateField;

	private static readonly DestroyPlayableInternal_InjectedDelegate DestroyPlayableInternal_InjectedDelegateField;

	private static readonly DestroySubgraphInternal_InjectedDelegate DestroySubgraphInternal_InjectedDelegateField;

	static PlayableGraph()
	{
		Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableGraph");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Handle");
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Version");
		NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667460);
		NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667461);
		NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667462);
		NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667463);
		NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667464);
		NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667465);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667466);
		NativeMethodInfoPtr_IsPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667467);
		NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667468);
		NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667469);
		NativeMethodInfoPtr_Evaluate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667470);
		NativeMethodInfoPtr_SetTimeUpdateMode_Public_Void_DirectorUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667471);
		NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667472);
		NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667473);
		NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667474);
		NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667475);
		NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667476);
		NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667477);
		NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667478);
		NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667479);
		NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667480);
		NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667481);
		NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667482);
		NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667483);
		NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667484);
		NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667485);
		NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667486);
		NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667487);
		NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667488);
		IsDoneDelegateField = IL2CPP.ResolveICall<IsDoneDelegate>("UnityEngine.Playables.PlayableGraph::IsDone");
		GetTimeUpdateModeDelegateField = IL2CPP.ResolveICall<GetTimeUpdateModeDelegate>("UnityEngine.Playables.PlayableGraph::GetTimeUpdateMode");
		SetResolverDelegateField = IL2CPP.ResolveICall<SetResolverDelegate>("UnityEngine.Playables.PlayableGraph::SetResolver");
		GetOutputCountDelegateField = IL2CPP.ResolveICall<GetOutputCountDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCount");
		DisableMatchFrameRateDelegateField = IL2CPP.ResolveICall<DisableMatchFrameRateDelegate>("UnityEngine.Playables.PlayableGraph::DisableMatchFrameRate");
		GetOutputInternalDelegateField = IL2CPP.ResolveICall<GetOutputInternalDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputInternal");
		GetOutputCountByTypeInternalDelegateField = IL2CPP.ResolveICall<GetOutputCountByTypeInternalDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCountByTypeInternal");
		GetOutputByTypeInternalDelegateField = IL2CPP.ResolveICall<GetOutputByTypeInternalDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputByTypeInternal");
		DestroyOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<DestroyOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyOutputInternal_Injected");
		EnableMatchFrameRate_InjectedDelegateField = IL2CPP.ResolveICall<EnableMatchFrameRate_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::EnableMatchFrameRate_Injected");
		DisconnectInternal_InjectedDelegateField = IL2CPP.ResolveICall<DisconnectInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DisconnectInternal_Injected");
		DestroyPlayableInternal_InjectedDelegateField = IL2CPP.ResolveICall<DestroyPlayableInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyPlayableInternal_Injected");
		DestroySubgraphInternal_InjectedDelegateField = IL2CPP.ResolveICall<DestroySubgraphInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroySubgraphInternal_Injected");
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1230050, RefRangeEnd = 1230066, XrefRangeStart = 1230048, XrefRangeEnd = 1230050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Playable GetRootPlayable(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230075, RefRangeEnd = 1230076, XrefRangeStart = 1230066, XrefRangeEnd = 1230075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : new() where V : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		//IL_009b->IL009e: Incompatible stack types: I vs Ref
		//IL_008e->IL009e: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		ref U reference;
		if (!typeof(U).IsValueType)
		{
			object obj = source;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref source;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceOutputPort;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref V reference2;
		if (!typeof(V).IsValueType)
		{
			object obj2 = destination;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref destination;
		}
		*(void**)num = Unsafe.AsPointer(ref reference2);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationInputPort;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Connect_Public_Boolean_U_Int32_V_Int32_0<U, V>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230078, RefRangeEnd = 1230079, XrefRangeStart = 1230076, XrefRangeEnd = 1230078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Evaluate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1230080, RefRangeEnd = 1230085, XrefRangeStart = 1230079, XrefRangeEnd = 1230080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableGraph Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableGraph*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230099, RefRangeEnd = 1230100, XrefRangeStart = 1230085, XrefRangeEnd = 1230099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableGraph Create(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_PlayableGraph_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableGraph*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230102, RefRangeEnd = 1230103, XrefRangeStart = 1230100, XrefRangeEnd = 1230102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Destroy()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1230105, RefRangeEnd = 1230111, XrefRangeStart = 1230103, XrefRangeEnd = 1230105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1230113, RefRangeEnd = 1230120, XrefRangeStart = 1230111, XrefRangeEnd = 1230113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlaying()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlaying_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1230122, RefRangeEnd = 1230128, XrefRangeStart = 1230120, XrefRangeEnd = 1230122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230130, RefRangeEnd = 1230131, XrefRangeStart = 1230128, XrefRangeEnd = 1230130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230131, XrefRangeEnd = 1230133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Evaluate(float deltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230135, RefRangeEnd = 1230136, XrefRangeStart = 1230133, XrefRangeEnd = 1230135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTimeUpdateMode(DirectorUpdateMode value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTimeUpdateMode_Public_Void_DirectorUpdateMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1230138, RefRangeEnd = 1230152, XrefRangeStart = 1230136, XrefRangeEnd = 1230138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IExposedPropertyTable GetResolver()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IExposedPropertyTable>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230154, RefRangeEnd = 1230156, XrefRangeStart = 1230152, XrefRangeEnd = 1230154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPlayableCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1230158, RefRangeEnd = 1230163, XrefRangeStart = 1230156, XrefRangeEnd = 1230158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRootPlayableCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230165, RefRangeEnd = 1230166, XrefRangeStart = 1230163, XrefRangeEnd = 1230165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SynchronizeEvaluation(PlayableGraph playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230168, RefRangeEnd = 1230169, XrefRangeStart = 1230166, XrefRangeEnd = 1230168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableHandle CreatePlayableHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230183, RefRangeEnd = 1230185, XrefRangeStart = 1230169, XrefRangeEnd = 1230183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230185, XrefRangeEnd = 1230187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableHandle GetRootPlayableInternal(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230189, RefRangeEnd = 1230191, XrefRangeStart = 1230187, XrefRangeEnd = 1230189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsMatchFrameRateEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230191, XrefRangeEnd = 1230193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FrameRate GetFrameRate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FrameRate*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230195, RefRangeEnd = 1230196, XrefRangeStart = 1230193, XrefRangeEnd = 1230195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceOutputPort;
		*(PlayableHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationInputPort;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230196, XrefRangeEnd = 1230198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Create_Injected(ref ManagedSpanWrapper name, out PlayableGraph ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230198, XrefRangeEnd = 1230200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, [In] ref PlayableGraph playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230200, XrefRangeEnd = 1230202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230202, XrefRangeEnd = 1230204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, ref ManagedSpanWrapper name, out PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_ManagedSpanWrapper_byref_PlayableOutputHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230204, XrefRangeEnd = 1230206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230206, XrefRangeEnd = 1230208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230208, XrefRangeEnd = 1230210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, [In] ref PlayableHandle source, int sourceOutputPort, [In] ref PlayableHandle destination, int destinationInputPort)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref source);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceOutputPort;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destination);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationInputPort;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void Disconnect<U>(U input, int inputPort) where U : struct
	{
		DisconnectInternal(((IPlayable)input).GetHandle(), inputPort);
	}

	public void DestroyPlayable<U>(U playable) where U : struct
	{
		DestroyPlayableInternal(((IPlayable)playable).GetHandle());
	}

	public void DestroySubgraph<U>(U playable) where U : struct
	{
		DestroySubgraphInternal(((IPlayable)playable).GetHandle());
	}

	public void DestroyOutput<U>(U output) where U : struct
	{
		DestroyOutputInternal(((IPlayableOutput)output).GetHandle());
	}

	public int GetOutputCountByType<T>() where T : struct
	{
		return GetOutputCountByTypeInternal(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
	}

	public PlayableOutput GetOutput(int index)
	{
		if (!GetOutputInternal(index, out var handle))
		{
			return PlayableOutput.Null;
		}
		return new PlayableOutput(handle);
	}

	public PlayableOutput GetOutputByType<T>(int index) where T : struct
	{
		if (!GetOutputByTypeInternal(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), index, out var handle))
		{
			return PlayableOutput.Null;
		}
		return new PlayableOutput(handle);
	}

	public unsafe bool IsDone()
	{
		//IL_000b: Expected O, but got Ref
		return IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe DirectorUpdateMode GetTimeUpdateMode()
	{
		//IL_000b: Expected O, but got Ref
		return GetTimeUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe void SetResolver(IExposedPropertyTable value)
	{
		//IL_000b: Expected O, but got Ref
		SetResolverDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public unsafe int GetOutputCount()
	{
		//IL_000b: Expected O, but got Ref
		return GetOutputCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public void DestroyOutputInternal(PlayableOutputHandle handle)
	{
		DestroyOutputInternal_Injected(ref this, ref handle);
	}

	public void EnableMatchFrameRate(FrameRate frameRate)
	{
		EnableMatchFrameRate_Injected(ref this, ref frameRate);
	}

	public unsafe void DisableMatchFrameRate()
	{
		//IL_000b: Expected O, but got Ref
		DisableMatchFrameRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe bool GetOutputInternal(int index, out PlayableOutputHandle handle)
	{
		//IL_000b: Expected O, but got Ref
		return GetOutputInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), index, (nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe int GetOutputCountByTypeInternal(Il2CppSystem.Type outputType)
	{
		//IL_000b: Expected O, but got Ref
		return GetOutputCountByTypeInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputType));
	}

	public unsafe bool GetOutputByTypeInternal(Il2CppSystem.Type outputType, int index, out PlayableOutputHandle handle)
	{
		//IL_000b: Expected O, but got Ref
		return GetOutputByTypeInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputType), index, (nint)Unsafe.AsPointer(ref handle));
	}

	public void DisconnectInternal(PlayableHandle playable, int inputPort)
	{
		DisconnectInternal_Injected(ref this, ref playable, inputPort);
	}

	public void DestroyPlayableInternal(PlayableHandle playable)
	{
		DestroyPlayableInternal_Injected(ref this, ref playable);
	}

	public void DestroySubgraphInternal(PlayableHandle playable)
	{
		DestroySubgraphInternal_Injected(ref this, ref playable);
	}

	public unsafe static void DestroyOutputInternal_Injected(ref PlayableGraph _unity_self, [In] ref PlayableOutputHandle handle)
	{
		DestroyOutputInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref handle));
	}

	public unsafe static void EnableMatchFrameRate_Injected(ref PlayableGraph _unity_self, [In] ref FrameRate frameRate)
	{
		EnableMatchFrameRate_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref frameRate));
	}

	public unsafe static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, [In] ref PlayableHandle playable, int inputPort)
	{
		DisconnectInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref playable), inputPort);
	}

	public unsafe static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, [In] ref PlayableHandle playable)
	{
		DestroyPlayableInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref playable));
	}

	public unsafe static void DestroySubgraphInternal_Injected(ref PlayableGraph _unity_self, [In] ref PlayableHandle playable)
	{
		DestroySubgraphInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref playable));
	}
}
