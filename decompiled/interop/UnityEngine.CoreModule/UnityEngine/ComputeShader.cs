using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class ComputeShader : Object
{
	private delegate bool HasKernel_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name);

	private delegate void SetFloat_InjectedDelegate(System.IntPtr _unity_self, int nameID, float val);

	private delegate void SetVector_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr val);

	private delegate void SetMatrix_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr val);

	private delegate void SetFloatArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

	private delegate void SetVectorArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

	private delegate void SetMatrixArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

	private delegate void SetTexture_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex, int nameID, System.IntPtr texture, int mipLevel);

	private delegate void SetRenderTexture_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex, int nameID, System.IntPtr texture, int mipLevel, RenderTextureSubElement element);

	private delegate void SetTextureFromGlobal_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex, int nameID, int globalTextureNameID);

	private delegate void Internal_SetRayTracingAccelerationStructure_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex, int nameID, System.IntPtr accelerationStructure);

	private delegate void SetConstantGraphicsBuffer_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr buffer, int offset, int size);

	private delegate void GetKernelThreadGroupSizes_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex, [Out] System.IntPtr x, [Out] System.IntPtr y, [Out] System.IntPtr z);

	private delegate void Internal_DispatchIndirect_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex, System.IntPtr argsBuffer, uint argsOffset);

	private delegate void Internal_DispatchIndirectGraphicsBuffer_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex, System.IntPtr argsBuffer, uint argsOffset);

	private delegate bool IsKeywordEnabled_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr keyword);

	private delegate void EnableLocalKeyword_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword);

	private delegate void DisableLocalKeyword_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword);

	private delegate void SetLocalKeyword_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword, bool value);

	private delegate bool IsLocalKeywordEnabled_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword);

	private delegate bool IsSupported_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex);

	private delegate System.IntPtr GetShaderKeywords_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetEnabledKeywords_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetEnabledKeywords_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr keywords);

	private static readonly System.IntPtr NativeMethodInfoPtr_FindKernel_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIntArray_Private_Void_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetBuffer_Private_Void_Int32_Int32_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetGraphicsBuffer_Private_Void_Int32_Int32_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInts_Public_Void_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindKernel_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIntArray_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetBuffer_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetGraphicsBuffer_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantComputeBuffer_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispatch_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Static_Void_IntPtr_byref_LocalKeywordSpace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0;

	private static readonly HasKernel_InjectedDelegate HasKernel_InjectedDelegateField;

	private static readonly SetFloat_InjectedDelegate SetFloat_InjectedDelegateField;

	private static readonly SetVector_InjectedDelegate SetVector_InjectedDelegateField;

	private static readonly SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField;

	private static readonly SetFloatArray_InjectedDelegate SetFloatArray_InjectedDelegateField;

	private static readonly SetVectorArray_InjectedDelegate SetVectorArray_InjectedDelegateField;

	private static readonly SetMatrixArray_InjectedDelegate SetMatrixArray_InjectedDelegateField;

	private static readonly SetTexture_InjectedDelegate SetTexture_InjectedDelegateField;

	private static readonly SetRenderTexture_InjectedDelegate SetRenderTexture_InjectedDelegateField;

	private static readonly SetTextureFromGlobal_InjectedDelegate SetTextureFromGlobal_InjectedDelegateField;

	private static readonly Internal_SetRayTracingAccelerationStructure_InjectedDelegate Internal_SetRayTracingAccelerationStructure_InjectedDelegateField;

	private static readonly SetConstantGraphicsBuffer_InjectedDelegate SetConstantGraphicsBuffer_InjectedDelegateField;

	private static readonly GetKernelThreadGroupSizes_InjectedDelegate GetKernelThreadGroupSizes_InjectedDelegateField;

	private static readonly Internal_DispatchIndirect_InjectedDelegate Internal_DispatchIndirect_InjectedDelegateField;

	private static readonly Internal_DispatchIndirectGraphicsBuffer_InjectedDelegate Internal_DispatchIndirectGraphicsBuffer_InjectedDelegateField;

	private static readonly IsKeywordEnabled_InjectedDelegate IsKeywordEnabled_InjectedDelegateField;

	private static readonly EnableLocalKeyword_InjectedDelegate EnableLocalKeyword_InjectedDelegateField;

	private static readonly DisableLocalKeyword_InjectedDelegate DisableLocalKeyword_InjectedDelegateField;

	private static readonly SetLocalKeyword_InjectedDelegate SetLocalKeyword_InjectedDelegateField;

	private static readonly IsLocalKeywordEnabled_InjectedDelegate IsLocalKeywordEnabled_InjectedDelegateField;

	private static readonly IsSupported_InjectedDelegate IsSupported_InjectedDelegateField;

	private static readonly GetShaderKeywords_InjectedDelegate GetShaderKeywords_InjectedDelegateField;

	private static readonly GetEnabledKeywords_InjectedDelegate GetEnabledKeywords_InjectedDelegateField;

	private static readonly SetEnabledKeywords_InjectedDelegate SetEnabledKeywords_InjectedDelegateField;

	public unsafe LocalKeywordSpace keywordSpace
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215612, RefRangeEnd = 1215613, XrefRangeStart = 1215609, XrefRangeEnd = 1215612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LocalKeywordSpace*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppStringArray shaderKeywords
	{
		get
		{
			return GetShaderKeywords();
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1215662, RefRangeEnd = 1215665, XrefRangeStart = 1215662, XrefRangeEnd = 1215665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Il2CppReferenceArray<LocalKeyword> enabledKeywords
	{
		get
		{
			return GetEnabledKeywords();
		}
		set
		{
			SetEnabledKeywords(value);
		}
	}

	static ComputeShader()
	{
		Il2CppClassPointerStore<ComputeShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeShader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr);
		NativeMethodInfoPtr_FindKernel_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666625);
		NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666626);
		NativeMethodInfoPtr_SetIntArray_Private_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666627);
		NativeMethodInfoPtr_Internal_SetBuffer_Private_Void_Int32_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666628);
		NativeMethodInfoPtr_Internal_SetGraphicsBuffer_Private_Void_Int32_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666629);
		NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666630);
		NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666631);
		NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666632);
		NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666633);
		NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666634);
		NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666635);
		NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666636);
		NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666637);
		NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666638);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666639);
		NativeMethodInfoPtr_SetInts_Public_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666640);
		NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666641);
		NativeMethodInfoPtr_FindKernel_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666642);
		NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666643);
		NativeMethodInfoPtr_SetIntArray_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666644);
		NativeMethodInfoPtr_Internal_SetBuffer_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666645);
		NativeMethodInfoPtr_Internal_SetGraphicsBuffer_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666646);
		NativeMethodInfoPtr_SetConstantComputeBuffer_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666647);
		NativeMethodInfoPtr_Dispatch_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666648);
		NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Static_Void_IntPtr_byref_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666649);
		NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666650);
		NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666651);
		NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100666652);
		HasKernel_InjectedDelegateField = IL2CPP.ResolveICall<HasKernel_InjectedDelegate>("UnityEngine.ComputeShader::HasKernel_Injected");
		SetFloat_InjectedDelegateField = IL2CPP.ResolveICall<SetFloat_InjectedDelegate>("UnityEngine.ComputeShader::SetFloat_Injected");
		SetVector_InjectedDelegateField = IL2CPP.ResolveICall<SetVector_InjectedDelegate>("UnityEngine.ComputeShader::SetVector_Injected");
		SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<SetMatrix_InjectedDelegate>("UnityEngine.ComputeShader::SetMatrix_Injected");
		SetFloatArray_InjectedDelegateField = IL2CPP.ResolveICall<SetFloatArray_InjectedDelegate>("UnityEngine.ComputeShader::SetFloatArray_Injected");
		SetVectorArray_InjectedDelegateField = IL2CPP.ResolveICall<SetVectorArray_InjectedDelegate>("UnityEngine.ComputeShader::SetVectorArray_Injected");
		SetMatrixArray_InjectedDelegateField = IL2CPP.ResolveICall<SetMatrixArray_InjectedDelegate>("UnityEngine.ComputeShader::SetMatrixArray_Injected");
		SetTexture_InjectedDelegateField = IL2CPP.ResolveICall<SetTexture_InjectedDelegate>("UnityEngine.ComputeShader::SetTexture_Injected");
		SetRenderTexture_InjectedDelegateField = IL2CPP.ResolveICall<SetRenderTexture_InjectedDelegate>("UnityEngine.ComputeShader::SetRenderTexture_Injected");
		SetTextureFromGlobal_InjectedDelegateField = IL2CPP.ResolveICall<SetTextureFromGlobal_InjectedDelegate>("UnityEngine.ComputeShader::SetTextureFromGlobal_Injected");
		Internal_SetRayTracingAccelerationStructure_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SetRayTracingAccelerationStructure_InjectedDelegate>("UnityEngine.ComputeShader::Internal_SetRayTracingAccelerationStructure_Injected");
		SetConstantGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SetConstantGraphicsBuffer_InjectedDelegate>("UnityEngine.ComputeShader::SetConstantGraphicsBuffer_Injected");
		GetKernelThreadGroupSizes_InjectedDelegateField = IL2CPP.ResolveICall<GetKernelThreadGroupSizes_InjectedDelegate>("UnityEngine.ComputeShader::GetKernelThreadGroupSizes_Injected");
		Internal_DispatchIndirect_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DispatchIndirect_InjectedDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirect_Injected");
		Internal_DispatchIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DispatchIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirectGraphicsBuffer_Injected");
		IsKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsKeywordEnabled_InjectedDelegate>("UnityEngine.ComputeShader::IsKeywordEnabled_Injected");
		EnableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<EnableLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::EnableLocalKeyword_Injected");
		DisableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<DisableLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::DisableLocalKeyword_Injected");
		SetLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<SetLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::SetLocalKeyword_Injected");
		IsLocalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsLocalKeywordEnabled_InjectedDelegate>("UnityEngine.ComputeShader::IsLocalKeywordEnabled_Injected");
		IsSupported_InjectedDelegateField = IL2CPP.ResolveICall<IsSupported_InjectedDelegate>("UnityEngine.ComputeShader::IsSupported_Injected");
		GetShaderKeywords_InjectedDelegateField = IL2CPP.ResolveICall<GetShaderKeywords_InjectedDelegate>("UnityEngine.ComputeShader::GetShaderKeywords_Injected");
		GetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<GetEnabledKeywords_InjectedDelegate>("UnityEngine.ComputeShader::GetEnabledKeywords_Injected");
		SetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<SetEnabledKeywords_InjectedDelegate>("UnityEngine.ComputeShader::SetEnabledKeywords_Injected");
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 1215448, RefRangeEnd = 1215499, XrefRangeStart = 1215435, XrefRangeEnd = 1215448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindKernel(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindKernel_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 1215504, RefRangeEnd = 1215528, XrefRangeStart = 1215499, XrefRangeEnd = 1215504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInt(int nameID, int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1215537, RefRangeEnd = 1215539, XrefRangeStart = 1215528, XrefRangeEnd = 1215537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIntArray(int nameID, Il2CppStructArray<int> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIntArray_Private_Void_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1215549, RefRangeEnd = 1215561, XrefRangeStart = 1215539, XrefRangeEnd = 1215549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&kernelIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetBuffer_Private_Void_Int32_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1215571, RefRangeEnd = 1215587, XrefRangeStart = 1215561, XrefRangeEnd = 1215571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&kernelIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetGraphicsBuffer_Private_Void_Int32_Int32_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1215549, RefRangeEnd = 1215561, XrefRangeStart = 1215549, XrefRangeEnd = 1215561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&kernelIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1215571, RefRangeEnd = 1215587, XrefRangeStart = 1215571, XrefRangeEnd = 1215587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&kernelIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_Int32_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215597, RefRangeEnd = 1215598, XrefRangeStart = 1215587, XrefRangeEnd = 1215597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1215603, RefRangeEnd = 1215609, XrefRangeStart = 1215598, XrefRangeEnd = 1215603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&kernelIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &threadGroupsX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &threadGroupsY;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &threadGroupsZ;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1215626, RefRangeEnd = 1215640, XrefRangeStart = 1215613, XrefRangeEnd = 1215626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableKeyword(string keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1215653, RefRangeEnd = 1215657, XrefRangeStart = 1215640, XrefRangeEnd = 1215653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableKeyword(string keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1215662, RefRangeEnd = 1215665, XrefRangeStart = 1215657, XrefRangeEnd = 1215662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShaderKeywords(Il2CppStringArray names)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215665, XrefRangeEnd = 1215669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComputeShader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1215537, RefRangeEnd = 1215539, XrefRangeStart = 1215537, XrefRangeEnd = 1215539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInts(int nameID, [Optional] Il2CppStructArray<int> values)
	{
		if (values == null)
		{
			values = new Il2CppStructArray<int>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInts_Public_Void_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215597, RefRangeEnd = 1215598, XrefRangeStart = 1215597, XrefRangeEnd = 1215598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215669, XrefRangeEnd = 1215671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindKernel_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindKernel_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215671, XrefRangeEnd = 1215673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetInt_Injected(System.IntPtr _unity_self, int nameID, int val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215673, XrefRangeEnd = 1215675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetIntArray_Injected(System.IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIntArray_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215675, XrefRangeEnd = 1215677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetBuffer_Injected(System.IntPtr _unity_self, int kernelIndex, int nameID, System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kernelIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetBuffer_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215677, XrefRangeEnd = 1215679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetGraphicsBuffer_Injected(System.IntPtr _unity_self, int kernelIndex, int nameID, System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kernelIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetGraphicsBuffer_Injected_Private_Static_Void_IntPtr_Int32_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215679, XrefRangeEnd = 1215681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetConstantComputeBuffer_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr buffer, int offset, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConstantComputeBuffer_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215681, XrefRangeEnd = 1215683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Dispatch_Injected(System.IntPtr _unity_self, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &kernelIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &threadGroupsX;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &threadGroupsY;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &threadGroupsZ;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispatch_Injected_Private_Static_Void_IntPtr_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215683, XrefRangeEnd = 1215685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_keywordSpace_Injected(System.IntPtr _unity_self, out LocalKeywordSpace ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Static_Void_IntPtr_byref_LocalKeywordSpace_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215685, XrefRangeEnd = 1215687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableKeyword_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215687, XrefRangeEnd = 1215689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableKeyword_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215689, XrefRangeEnd = 1215691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetShaderKeywords_Injected(System.IntPtr _unity_self, Il2CppStringArray names)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public void SetInts(int nameID, params int[] values)
	{
		SetInts(nameID, new Il2CppStructArray<int>(values));
	}

	public ComputeShader(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe bool HasKernel(string name)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return HasKernel_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return HasKernel_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public void SetFloat(int nameID, float val)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetFloat_Injected(intPtr, nameID, val);
	}

	public void SetVector(int nameID, Vector4 val)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetVector_Injected(intPtr, nameID, ref val);
	}

	public void SetMatrix(int nameID, Matrix4x4 val)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetMatrix_Injected(intPtr, nameID, ref val);
	}

	public unsafe void SetFloatArray(int nameID, Il2CppStructArray<float> values)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
		((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)values);
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			SetFloatArray_Injected(intPtr, nameID, ref values2);
		}
	}

	public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector4> span);
		((Il2CppSystem.Span<Vector4>)(&span))._002Ector((Il2CppArrayBase<Vector4>)(object)values);
		fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector4>)(&span)).Length);
			SetVectorArray_Injected(intPtr, nameID, ref values2);
		}
	}

	public unsafe void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Matrix4x4> span);
		((Il2CppSystem.Span<Matrix4x4>)(&span))._002Ector((Il2CppArrayBase<Matrix4x4>)(object)values);
		fixed (Matrix4x4* begin = &((Il2CppSystem.Span<Matrix4x4>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Matrix4x4>)(&span)).Length);
			SetMatrixArray_Injected(intPtr, nameID, ref values2);
		}
	}

	public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel)
	{
		if ((object)texture == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(texture, "texture");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(texture);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(texture, "texture");
		}
		SetTexture_Injected(intPtr, kernelIndex, nameID, intPtr2, mipLevel);
	}

	public void SetRenderTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, RenderTextureSubElement element)
	{
		if ((object)texture == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(texture, "texture");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(texture);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(texture, "texture");
		}
		SetRenderTexture_Injected(intPtr, kernelIndex, nameID, intPtr2, mipLevel, element);
	}

	public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTextureFromGlobal_Injected(intPtr, kernelIndex, nameID, globalTextureNameID);
	}

	public void Internal_SetRayTracingAccelerationStructure(int kernelIndex, int nameID, RayTracingAccelerationStructure accelerationStructure)
	{
		if (accelerationStructure == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(accelerationStructure, "accelerationStructure");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(accelerationStructure);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(accelerationStructure, "accelerationStructure");
		}
		Internal_SetRayTracingAccelerationStructure_Injected(intPtr, kernelIndex, nameID, intPtr2);
	}

	public void SetRayTracingAccelerationStructure(int kernelIndex, int nameID, RayTracingAccelerationStructure accelerationStructure)
	{
		Internal_SetRayTracingAccelerationStructure(kernelIndex, nameID, accelerationStructure);
	}

	public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
	{
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(buffer, "buffer");
		}
		SetConstantGraphicsBuffer_Injected(intPtr, nameID, intPtr2, offset, size);
	}

	public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetKernelThreadGroupSizes_Injected(intPtr, kernelIndex, out x, out y, out z);
	}

	public void Internal_DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
	{
		if (argsBuffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(argsBuffer, "argsBuffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = ComputeBuffer.BindingsMarshaller.ConvertToNative(argsBuffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(argsBuffer, "argsBuffer");
		}
		Internal_DispatchIndirect_Injected(intPtr, kernelIndex, intPtr2, argsOffset);
	}

	public void Internal_DispatchIndirectGraphicsBuffer(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
	{
		if (argsBuffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(argsBuffer, "argsBuffer");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = GraphicsBuffer.BindingsMarshaller.ConvertToNative(argsBuffer);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(argsBuffer, "argsBuffer");
		}
		Internal_DispatchIndirectGraphicsBuffer_Injected(intPtr, kernelIndex, intPtr2, argsOffset);
	}

	public unsafe bool IsKeywordEnabled(string keyword)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(keyword, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(keyword);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return IsKeywordEnabled_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return IsKeywordEnabled_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public void EnableLocalKeyword(LocalKeyword keyword)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		EnableLocalKeyword_Injected(intPtr, ref keyword);
	}

	public void DisableLocalKeyword(LocalKeyword keyword)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		DisableLocalKeyword_Injected(intPtr, ref keyword);
	}

	public void SetLocalKeyword(LocalKeyword keyword, bool value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetLocalKeyword_Injected(intPtr, ref keyword, value);
	}

	public bool IsLocalKeywordEnabled(LocalKeyword keyword)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsLocalKeywordEnabled_Injected(intPtr, ref keyword);
	}

	public void EnableKeyword([In] ref LocalKeyword keyword)
	{
		EnableLocalKeyword(keyword);
	}

	public void DisableKeyword([In] ref LocalKeyword keyword)
	{
		DisableLocalKeyword(keyword);
	}

	public void SetKeyword([In] ref LocalKeyword keyword, bool value)
	{
		SetLocalKeyword(keyword, value);
	}

	public bool IsKeywordEnabled([In] ref LocalKeyword keyword)
	{
		return IsLocalKeywordEnabled(keyword);
	}

	public bool IsSupported(int kernelIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsSupported_Injected(intPtr, kernelIndex);
	}

	public Il2CppStringArray GetShaderKeywords()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetShaderKeywords_Injected(intPtr);
	}

	public Il2CppReferenceArray<LocalKeyword> GetEnabledKeywords()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetEnabledKeywords_Injected(intPtr);
	}

	public void SetEnabledKeywords(Il2CppReferenceArray<LocalKeyword> keywords)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetEnabledKeywords_Injected(intPtr, keywords);
	}

	public void SetFloat(string name, float val)
	{
		SetFloat(Shader.PropertyToID(name), val);
	}

	public void SetInt(string name, int val)
	{
		SetInt(Shader.PropertyToID(name), val);
	}

	public void SetVector(string name, Vector4 val)
	{
		SetVector(Shader.PropertyToID(name), val);
	}

	public void SetMatrix(string name, Matrix4x4 val)
	{
		SetMatrix(Shader.PropertyToID(name), val);
	}

	public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
	{
		SetVectorArray(Shader.PropertyToID(name), values);
	}

	public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
	{
		SetMatrixArray(Shader.PropertyToID(name), values);
	}

	public void SetFloats(string name, Il2CppStructArray<float> values)
	{
		SetFloatArray(Shader.PropertyToID(name), values);
	}

	public void SetFloats(string name, params float[] values)
	{
		SetFloats(name, new Il2CppStructArray<float>(values));
	}

	public void SetFloats(int nameID, Il2CppStructArray<float> values)
	{
		SetFloatArray(nameID, values);
	}

	public void SetFloats(int nameID, params float[] values)
	{
		SetFloats(nameID, new Il2CppStructArray<float>(values));
	}

	public void SetInts(string name, Il2CppStructArray<int> values)
	{
		SetIntArray(Shader.PropertyToID(name), values);
	}

	public void SetInts(string name, params int[] values)
	{
		SetInts(name, new Il2CppStructArray<int>(values));
	}

	public void SetBool(string name, bool val)
	{
		SetInt(Shader.PropertyToID(name), val ? 1 : 0);
	}

	public void SetBool(int nameID, bool val)
	{
		SetInt(nameID, val ? 1 : 0);
	}

	public void SetTexture(int kernelIndex, int nameID, Texture texture)
	{
		SetTexture(kernelIndex, nameID, texture, 0);
	}

	public void SetTexture(int kernelIndex, string name, Texture texture)
	{
		SetTexture(kernelIndex, Shader.PropertyToID(name), texture, 0);
	}

	public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel)
	{
		SetTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel);
	}

	public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, RenderTextureSubElement element)
	{
		SetRenderTexture(kernelIndex, nameID, texture, mipLevel, element);
	}

	public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, RenderTextureSubElement element)
	{
		SetRenderTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel, element);
	}

	public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName)
	{
		SetTextureFromGlobal(kernelIndex, Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
	}

	public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
	{
		SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
	}

	public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer)
	{
		SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
	}

	public void SetRayTracingAccelerationStructure(int kernelIndex, string name, RayTracingAccelerationStructure accelerationStructure)
	{
		SetRayTracingAccelerationStructure(kernelIndex, Shader.PropertyToID(name), accelerationStructure);
	}

	public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
	{
		SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
	}

	public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
	{
		SetConstantGraphicsBuffer(nameID, buffer, offset, size);
	}

	public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
	{
		SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
	}

	public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
	{
		if (argsBuffer == null)
		{
			throw new Il2CppSystem.ArgumentNullException("argsBuffer");
		}
		if (argsBuffer.m_Ptr == Il2CppSystem.IntPtr.Zero)
		{
			throw new Il2CppSystem.ObjectDisposedException("argsBuffer");
		}
		if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Metal && !SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		Internal_DispatchIndirect(kernelIndex, argsBuffer, argsOffset);
	}

	public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer)
	{
		DispatchIndirect(kernelIndex, argsBuffer, 0u);
	}

	public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
	{
		if (argsBuffer == null)
		{
			throw new Il2CppSystem.ArgumentNullException("argsBuffer");
		}
		if (argsBuffer.m_Ptr == Il2CppSystem.IntPtr.Zero)
		{
			throw new Il2CppSystem.ObjectDisposedException("argsBuffer");
		}
		if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Metal && !SystemInfo.supportsIndirectArgumentsBuffer)
		{
			throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
		}
		Internal_DispatchIndirectGraphicsBuffer(kernelIndex, argsBuffer, argsOffset);
	}

	public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer)
	{
		DispatchIndirect(kernelIndex, argsBuffer, 0u);
	}

	public unsafe static bool HasKernel_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		return HasKernel_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name));
	}

	public static void SetFloat_Injected(System.IntPtr _unity_self, int nameID, float val)
	{
		SetFloat_InjectedDelegateField(_unity_self, nameID, val);
	}

	public unsafe static void SetVector_Injected(System.IntPtr _unity_self, int nameID, [In] ref Vector4 val)
	{
		SetVector_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void SetMatrix_Injected(System.IntPtr _unity_self, int nameID, [In] ref Matrix4x4 val)
	{
		SetMatrix_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void SetFloatArray_Injected(System.IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
	{
		SetFloatArray_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref values));
	}

	public unsafe static void SetVectorArray_Injected(System.IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
	{
		SetVectorArray_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref values));
	}

	public unsafe static void SetMatrixArray_Injected(System.IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
	{
		SetMatrixArray_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref values));
	}

	public static void SetTexture_Injected(System.IntPtr _unity_self, int kernelIndex, int nameID, System.IntPtr texture, int mipLevel)
	{
		SetTexture_InjectedDelegateField(_unity_self, kernelIndex, nameID, texture, mipLevel);
	}

	public static void SetRenderTexture_Injected(System.IntPtr _unity_self, int kernelIndex, int nameID, System.IntPtr texture, int mipLevel, RenderTextureSubElement element)
	{
		SetRenderTexture_InjectedDelegateField(_unity_self, kernelIndex, nameID, texture, mipLevel, element);
	}

	public static void SetTextureFromGlobal_Injected(System.IntPtr _unity_self, int kernelIndex, int nameID, int globalTextureNameID)
	{
		SetTextureFromGlobal_InjectedDelegateField(_unity_self, kernelIndex, nameID, globalTextureNameID);
	}

	public static void Internal_SetRayTracingAccelerationStructure_Injected(System.IntPtr _unity_self, int kernelIndex, int nameID, System.IntPtr accelerationStructure)
	{
		Internal_SetRayTracingAccelerationStructure_InjectedDelegateField(_unity_self, kernelIndex, nameID, accelerationStructure);
	}

	public static void SetConstantGraphicsBuffer_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr buffer, int offset, int size)
	{
		SetConstantGraphicsBuffer_InjectedDelegateField(_unity_self, nameID, buffer, offset, size);
	}

	public unsafe static void GetKernelThreadGroupSizes_Injected(System.IntPtr _unity_self, int kernelIndex, out uint x, out uint y, out uint z)
	{
		GetKernelThreadGroupSizes_InjectedDelegateField(_unity_self, kernelIndex, (nint)Unsafe.AsPointer(ref x), (nint)Unsafe.AsPointer(ref y), (nint)Unsafe.AsPointer(ref z));
	}

	public static void Internal_DispatchIndirect_Injected(System.IntPtr _unity_self, int kernelIndex, System.IntPtr argsBuffer, uint argsOffset)
	{
		Internal_DispatchIndirect_InjectedDelegateField(_unity_self, kernelIndex, argsBuffer, argsOffset);
	}

	public static void Internal_DispatchIndirectGraphicsBuffer_Injected(System.IntPtr _unity_self, int kernelIndex, System.IntPtr argsBuffer, uint argsOffset)
	{
		Internal_DispatchIndirectGraphicsBuffer_InjectedDelegateField(_unity_self, kernelIndex, argsBuffer, argsOffset);
	}

	public unsafe static bool IsKeywordEnabled_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper keyword)
	{
		return IsKeywordEnabled_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref keyword));
	}

	public unsafe static void EnableLocalKeyword_Injected(System.IntPtr _unity_self, [In] ref LocalKeyword keyword)
	{
		EnableLocalKeyword_InjectedDelegate enableLocalKeyword_InjectedDelegateField = EnableLocalKeyword_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyword);
		enableLocalKeyword_InjectedDelegateField(_unity_self, (nint)(&intPtr));
	}

	public unsafe static void DisableLocalKeyword_Injected(System.IntPtr _unity_self, [In] ref LocalKeyword keyword)
	{
		DisableLocalKeyword_InjectedDelegate disableLocalKeyword_InjectedDelegateField = DisableLocalKeyword_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyword);
		disableLocalKeyword_InjectedDelegateField(_unity_self, (nint)(&intPtr));
	}

	public unsafe static void SetLocalKeyword_Injected(System.IntPtr _unity_self, [In] ref LocalKeyword keyword, bool value)
	{
		SetLocalKeyword_InjectedDelegate setLocalKeyword_InjectedDelegateField = SetLocalKeyword_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyword);
		setLocalKeyword_InjectedDelegateField(_unity_self, (nint)(&intPtr), value);
	}

	public unsafe static bool IsLocalKeywordEnabled_Injected(System.IntPtr _unity_self, [In] ref LocalKeyword keyword)
	{
		IsLocalKeywordEnabled_InjectedDelegate isLocalKeywordEnabled_InjectedDelegateField = IsLocalKeywordEnabled_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyword);
		return isLocalKeywordEnabled_InjectedDelegateField(_unity_self, (nint)(&intPtr));
	}

	public static bool IsSupported_Injected(System.IntPtr _unity_self, int kernelIndex)
	{
		return IsSupported_InjectedDelegateField(_unity_self, kernelIndex);
	}

	public static Il2CppStringArray GetShaderKeywords_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetShaderKeywords_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppReferenceArray<LocalKeyword> GetEnabledKeywords_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetEnabledKeywords_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(intPtr) : null;
	}

	public static void SetEnabledKeywords_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<LocalKeyword> keywords)
	{
		SetEnabledKeywords_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keywords));
	}
}
