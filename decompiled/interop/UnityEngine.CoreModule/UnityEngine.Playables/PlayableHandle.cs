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

namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct PlayableHandle
{
	private sealed class MethodInfoStoreGeneric_GetObject_Internal_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetObject_Internal_T_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate bool IsNullDelegate(System.IntPtr @this);

	private delegate bool CanChangeInputsDelegate(System.IntPtr @this);

	private delegate bool CanSetWeightsDelegate(System.IntPtr @this);

	private delegate bool CanDestroyDelegate(System.IntPtr @this);

	private delegate bool GetPropagateSetTimeDelegate(System.IntPtr @this);

	private delegate int GetOutputPortFromInputIndexDelegate(System.IntPtr @this, int index);

	private delegate int GetInputPortFromOutputIndexDelegate(System.IntPtr @this, int index);

	private delegate void SetOutputCountDelegate(System.IntPtr @this, int value);

	private delegate void SetDelayDelegate(System.IntPtr @this, double delay);

	private delegate double GetDelayDelegate(System.IntPtr @this);

	private delegate bool IsDelayedDelegate(System.IntPtr @this);

	private delegate void SetLeadTimeDelegate(System.IntPtr @this, float value);

	private delegate float GetLeadTimeDelegate(System.IntPtr @this);

	private delegate PlayableTraversalMode GetTraversalModeDelegate(System.IntPtr @this);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Null;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Internal_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOutput_Internal_Playable_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayableType_Internal_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJobType_Internal_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeed_Internal_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTime_Internal_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTime_Internal_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDone_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Internal_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputCount_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOutputCount_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJobData_Internal_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScriptInstance_Private_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOutputHandle_Private_PlayableHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOutputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0;

	[FieldOffset(0)]
	public System.IntPtr m_Handle;

	[FieldOffset(8)]
	public uint m_Version;

	private static readonly IsNullDelegate IsNullDelegateField;

	private static readonly CanChangeInputsDelegate CanChangeInputsDelegateField;

	private static readonly CanSetWeightsDelegate CanSetWeightsDelegateField;

	private static readonly CanDestroyDelegate CanDestroyDelegateField;

	private static readonly GetPropagateSetTimeDelegate GetPropagateSetTimeDelegateField;

	private static readonly GetOutputPortFromInputIndexDelegate GetOutputPortFromInputIndexDelegateField;

	private static readonly GetInputPortFromOutputIndexDelegate GetInputPortFromOutputIndexDelegateField;

	private static readonly SetOutputCountDelegate SetOutputCountDelegateField;

	private static readonly SetDelayDelegate SetDelayDelegateField;

	private static readonly GetDelayDelegate GetDelayDelegateField;

	private static readonly IsDelayedDelegate IsDelayedDelegateField;

	private static readonly SetLeadTimeDelegate SetLeadTimeDelegateField;

	private static readonly GetLeadTimeDelegate GetLeadTimeDelegateField;

	private static readonly GetTraversalModeDelegate GetTraversalModeDelegateField;

	public unsafe static PlayableHandle m_Null
	{
		get
		{
			Unsafe.SkipInit(out PlayableHandle result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Null, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Null, (void*)(&value));
		}
	}

	public unsafe static PlayableHandle Null
	{
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 1230275, RefRangeEnd = 1230324, XrefRangeStart = 1230271, XrefRangeEnd = 1230275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PlayableHandle()
	{
		Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Handle");
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Version");
		NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Null");
		NativeMethodInfoPtr_GetObject_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667489);
		NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667490);
		NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667491);
		NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667492);
		NativeMethodInfoPtr_GetOutput_Internal_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667493);
		NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667494);
		NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667495);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667496);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667497);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667498);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667499);
		NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667500);
		NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667501);
		NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667502);
		NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667503);
		NativeMethodInfoPtr_GetPlayableType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667504);
		NativeMethodInfoPtr_GetJobType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667505);
		NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667506);
		NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667507);
		NativeMethodInfoPtr_Play_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667508);
		NativeMethodInfoPtr_Pause_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667509);
		NativeMethodInfoPtr_GetSpeed_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667510);
		NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667511);
		NativeMethodInfoPtr_GetTime_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667512);
		NativeMethodInfoPtr_SetTime_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667513);
		NativeMethodInfoPtr_IsDone_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667514);
		NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667515);
		NativeMethodInfoPtr_GetDuration_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667516);
		NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667517);
		NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667518);
		NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667519);
		NativeMethodInfoPtr_GetInputCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667520);
		NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667521);
		NativeMethodInfoPtr_GetOutputCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667522);
		NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667523);
		NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667524);
		NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667525);
		NativeMethodInfoPtr_GetJobData_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667526);
		NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667527);
		NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667528);
		NativeMethodInfoPtr_GetScriptInstance_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667529);
		NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667530);
		NativeMethodInfoPtr_GetOutputHandle_Private_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667531);
		NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667532);
		NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667533);
		NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667535);
		NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667536);
		NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667537);
		NativeMethodInfoPtr_GetOutputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667538);
		IsNullDelegateField = IL2CPP.ResolveICall<IsNullDelegate>("UnityEngine.Playables.PlayableHandle::IsNull");
		CanChangeInputsDelegateField = IL2CPP.ResolveICall<CanChangeInputsDelegate>("UnityEngine.Playables.PlayableHandle::CanChangeInputs");
		CanSetWeightsDelegateField = IL2CPP.ResolveICall<CanSetWeightsDelegate>("UnityEngine.Playables.PlayableHandle::CanSetWeights");
		CanDestroyDelegateField = IL2CPP.ResolveICall<CanDestroyDelegate>("UnityEngine.Playables.PlayableHandle::CanDestroy");
		GetPropagateSetTimeDelegateField = IL2CPP.ResolveICall<GetPropagateSetTimeDelegate>("UnityEngine.Playables.PlayableHandle::GetPropagateSetTime");
		GetOutputPortFromInputIndexDelegateField = IL2CPP.ResolveICall<GetOutputPortFromInputIndexDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputPortFromInputIndex");
		GetInputPortFromOutputIndexDelegateField = IL2CPP.ResolveICall<GetInputPortFromOutputIndexDelegate>("UnityEngine.Playables.PlayableHandle::GetInputPortFromOutputIndex");
		SetOutputCountDelegateField = IL2CPP.ResolveICall<SetOutputCountDelegate>("UnityEngine.Playables.PlayableHandle::SetOutputCount");
		SetDelayDelegateField = IL2CPP.ResolveICall<SetDelayDelegate>("UnityEngine.Playables.PlayableHandle::SetDelay");
		GetDelayDelegateField = IL2CPP.ResolveICall<GetDelayDelegate>("UnityEngine.Playables.PlayableHandle::GetDelay");
		IsDelayedDelegateField = IL2CPP.ResolveICall<IsDelayedDelegate>("UnityEngine.Playables.PlayableHandle::IsDelayed");
		SetLeadTimeDelegateField = IL2CPP.ResolveICall<SetLeadTimeDelegate>("UnityEngine.Playables.PlayableHandle::SetLeadTime");
		GetLeadTimeDelegateField = IL2CPP.ResolveICall<GetLeadTimeDelegate>("UnityEngine.Playables.PlayableHandle::GetLeadTime");
		GetTraversalModeDelegateField = IL2CPP.ResolveICall<GetTraversalModeDelegate>("UnityEngine.Playables.PlayableHandle::GetTraversalMode");
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1230221, RefRangeEnd = 1230224, XrefRangeStart = 1230210, XrefRangeEnd = 1230221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetObject<T>() where T : class
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetObject_Internal_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 1230242, RefRangeEnd = 1230271, XrefRangeStart = 1230224, XrefRangeEnd = 1230242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlayableOfType<T>()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230332, RefRangeEnd = 1230333, XrefRangeStart = 1230324, XrefRangeEnd = 1230332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Playable GetInput(int inputPort)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputPort);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230341, RefRangeEnd = 1230342, XrefRangeStart = 1230333, XrefRangeEnd = 1230341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Playable GetOutput(int outputPort)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&outputPort);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOutput_Internal_Playable_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230349, RefRangeEnd = 1230350, XrefRangeStart = 1230342, XrefRangeEnd = 1230349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetInputWeight(int inputIndex, float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inputIndex);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230357, RefRangeEnd = 1230358, XrefRangeStart = 1230350, XrefRangeEnd = 1230357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetInputWeight(int inputIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1230361, RefRangeEnd = 1230374, XrefRangeStart = 1230358, XrefRangeEnd = 1230361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(PlayableHandle x, PlayableHandle y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(PlayableHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230374, XrefRangeEnd = 1230382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230382, XrefRangeEnd = 1230385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(PlayableHandle other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230385, XrefRangeEnd = 1230387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1165558, RefRangeEnd = 1165561, XrefRangeStart = 1165558, XrefRangeEnd = 1165561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(PlayableHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230387, XrefRangeEnd = 1230391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckInputBounds(int inputIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1230396, RefRangeEnd = 1230399, XrefRangeStart = 1230391, XrefRangeEnd = 1230396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckInputBounds(int inputIndex, bool acceptAny)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inputIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &acceptAny;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 1230401, RefRangeEnd = 1230435, XrefRangeStart = 1230399, XrefRangeEnd = 1230401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Internal_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1230437, RefRangeEnd = 1230440, XrefRangeStart = 1230435, XrefRangeEnd = 1230437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Type GetPlayableType()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayableType_Internal_Type_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230442, RefRangeEnd = 1230443, XrefRangeStart = 1230440, XrefRangeEnd = 1230442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Type GetJobType()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJobType_Internal_Type_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1230445, RefRangeEnd = 1230448, XrefRangeStart = 1230443, XrefRangeEnd = 1230445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetScriptInstance(Il2CppSystem.Object scriptInstance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scriptInstance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230450, RefRangeEnd = 1230451, XrefRangeStart = 1230448, XrefRangeEnd = 1230450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayState GetPlayState()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230453, RefRangeEnd = 1230455, XrefRangeStart = 1230451, XrefRangeEnd = 1230453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230457, RefRangeEnd = 1230458, XrefRangeStart = 1230455, XrefRangeEnd = 1230457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pause_Internal_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230460, RefRangeEnd = 1230461, XrefRangeStart = 1230458, XrefRangeEnd = 1230460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetSpeed()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeed_Internal_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230463, RefRangeEnd = 1230464, XrefRangeStart = 1230461, XrefRangeEnd = 1230463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSpeed(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230466, RefRangeEnd = 1230467, XrefRangeStart = 1230464, XrefRangeEnd = 1230466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetTime()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTime_Internal_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230469, RefRangeEnd = 1230471, XrefRangeStart = 1230467, XrefRangeEnd = 1230469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTime(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTime_Internal_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230473, RefRangeEnd = 1230474, XrefRangeStart = 1230471, XrefRangeEnd = 1230473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDone()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDone_Internal_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230476, RefRangeEnd = 1230478, XrefRangeStart = 1230474, XrefRangeEnd = 1230476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDone(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230480, RefRangeEnd = 1230482, XrefRangeStart = 1230478, XrefRangeEnd = 1230480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetDuration()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDuration_Internal_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1230484, RefRangeEnd = 1230487, XrefRangeStart = 1230482, XrefRangeEnd = 1230484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDuration(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230489, RefRangeEnd = 1230490, XrefRangeStart = 1230487, XrefRangeEnd = 1230489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPropagateSetTime(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230495, RefRangeEnd = 1230496, XrefRangeStart = 1230490, XrefRangeEnd = 1230495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableGraph GetGraph()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableGraph*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1230498, RefRangeEnd = 1230505, XrefRangeStart = 1230496, XrefRangeEnd = 1230498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInputCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputCount_Internal_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1230507, RefRangeEnd = 1230523, XrefRangeStart = 1230505, XrefRangeEnd = 1230507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInputCount(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230525, RefRangeEnd = 1230526, XrefRangeStart = 1230523, XrefRangeEnd = 1230525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetOutputCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOutputCount_Internal_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230531, RefRangeEnd = 1230532, XrefRangeStart = 1230526, XrefRangeEnd = 1230531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInputWeight(PlayableHandle input, float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&input);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230534, RefRangeEnd = 1230535, XrefRangeStart = 1230532, XrefRangeEnd = 1230534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetPreviousTime()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230539, RefRangeEnd = 1230540, XrefRangeStart = 1230535, XrefRangeEnd = 1230539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTraversalMode(PlayableTraversalMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1230542, RefRangeEnd = 1230544, XrefRangeStart = 1230540, XrefRangeEnd = 1230542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr GetJobData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJobData_Internal_IntPtr_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230546, RefRangeEnd = 1230547, XrefRangeStart = 1230544, XrefRangeEnd = 1230546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DirectorWrapMode GetTimeWrapMode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DirectorWrapMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230549, RefRangeEnd = 1230550, XrefRangeStart = 1230547, XrefRangeEnd = 1230549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTimeWrapMode(DirectorWrapMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1230552, RefRangeEnd = 1230553, XrefRangeStart = 1230550, XrefRangeEnd = 1230552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object GetScriptInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScriptInstance_Private_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230553, XrefRangeEnd = 1230558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableHandle GetInputHandle(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230558, XrefRangeEnd = 1230563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableHandle GetOutputHandle(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOutputHandle_Private_PlayableHandle_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230563, XrefRangeEnd = 1230565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInputWeightFromIndex(int index, float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230565, XrefRangeEnd = 1230567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetInputWeightFromIndex(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230567, XrefRangeEnd = 1230569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230569, XrefRangeEnd = 1230571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetInputWeight_Injected(ref PlayableHandle _unity_self, [In] ref PlayableHandle input, float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref input);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230571, XrefRangeEnd = 1230573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230573, XrefRangeEnd = 1230575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetOutputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOutputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public T GetPayload<T>() where T : struct
	{
		if (!IsValid())
		{
			return default(T);
		}
		Il2CppSystem.Object scriptInstance = GetScriptInstance();
		if (scriptInstance == null)
		{
			return default(T);
		}
		return ((Il2CppObjectBase)scriptInstance).Cast<T>();
	}

	public void SetPayload<T>(T payload) where T : struct
	{
		if (IsValid())
		{
			SetScriptInstance((Il2CppSystem.Object)(object)payload);
		}
	}

	public int GetOutputPortFromInputConnection(int inputPort)
	{
		return GetOutputPortFromInputIndex(inputPort);
	}

	public int GetInputPortFromOutputConnection(int inputPort)
	{
		return GetInputPortFromOutputIndex(inputPort);
	}

	public void Destroy()
	{
		GetGraph().DestroyPlayable(new Playable(this));
	}

	public static bool operator !=(PlayableHandle x, PlayableHandle y)
	{
		return !CompareVersion(x, y);
	}

	public unsafe bool IsNull()
	{
		//IL_000b: Expected O, but got Ref
		return IsNullDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe bool CanChangeInputs()
	{
		//IL_000b: Expected O, but got Ref
		return CanChangeInputsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe bool CanSetWeights()
	{
		//IL_000b: Expected O, but got Ref
		return CanSetWeightsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe bool CanDestroy()
	{
		//IL_000b: Expected O, but got Ref
		return CanDestroyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe bool GetPropagateSetTime()
	{
		//IL_000b: Expected O, but got Ref
		return GetPropagateSetTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe int GetOutputPortFromInputIndex(int index)
	{
		//IL_000b: Expected O, but got Ref
		return GetOutputPortFromInputIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), index);
	}

	public unsafe int GetInputPortFromOutputIndex(int index)
	{
		//IL_000b: Expected O, but got Ref
		return GetInputPortFromOutputIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), index);
	}

	public unsafe void SetOutputCount(int value)
	{
		//IL_000b: Expected O, but got Ref
		SetOutputCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), value);
	}

	public unsafe void SetDelay(double delay)
	{
		//IL_000b: Expected O, but got Ref
		SetDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), delay);
	}

	public unsafe double GetDelay()
	{
		//IL_000b: Expected O, but got Ref
		return GetDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe bool IsDelayed()
	{
		//IL_000b: Expected O, but got Ref
		return IsDelayedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe void SetLeadTime(float value)
	{
		//IL_000b: Expected O, but got Ref
		SetLeadTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)), value);
	}

	public unsafe float GetLeadTime()
	{
		//IL_000b: Expected O, but got Ref
		return GetLeadTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public unsafe PlayableTraversalMode GetTraversalMode()
	{
		//IL_000b: Expected O, but got Ref
		return GetTraversalModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}
}
