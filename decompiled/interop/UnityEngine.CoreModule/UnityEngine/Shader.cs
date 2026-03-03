using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class Shader : Object
{
	private delegate int get_maximumChunksOverrideDelegate();

	private delegate void set_maximumChunksOverrideDelegate(int value);

	private delegate int get_globalMaximumLODDelegate();

	private delegate void set_globalMaximumLODDelegate(int value);

	private delegate System.IntPtr GetEnabledGlobalKeywordsDelegate();

	private delegate System.IntPtr GetAllGlobalKeywordsDelegate();

	private delegate void WarmupAllShadersDelegate();

	private delegate void SetGlobalIntImplDelegate(int name, int value);

	private delegate int GetGlobalIntImplDelegate(int name);

	private delegate float GetGlobalFloatImplDelegate(int name);

	private delegate int GetGlobalFloatArrayCountImplDelegate(int name);

	private delegate int GetGlobalVectorArrayCountImplDelegate(int name);

	private delegate int GetGlobalMatrixArrayCountImplDelegate(int name);

	private delegate System.IntPtr FindBuiltin_InjectedDelegate(System.IntPtr name);

	private delegate int get_maximumLOD_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_maximumLOD_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void get_globalRenderPipeline_InjectedDelegate([Out] System.IntPtr ret);

	private delegate bool IsKeywordEnabled_InjectedDelegate(System.IntPtr keyword);

	private delegate void EnableKeywordFast_InjectedDelegate([In] System.IntPtr keyword);

	private delegate void DisableKeywordFast_InjectedDelegate([In] System.IntPtr keyword);

	private delegate void SetKeywordFast_InjectedDelegate([In] System.IntPtr keyword, bool value);

	private delegate bool IsKeywordEnabledFast_InjectedDelegate([In] System.IntPtr keyword);

	private delegate int get_renderQueue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate DisableBatchingType get_disableBatching_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void IDToTag_InjectedDelegate(int name, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetDependency_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name);

	private delegate int get_subshaderCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetPassCountInSubshader_InjectedDelegate(System.IntPtr _unity_self, int subshaderIndex);

	private delegate int Internal_FindPassTagValue_InjectedDelegate(System.IntPtr _unity_self, int passIndex, int tagName);

	private delegate int Internal_FindPassTagValueInSubShader_InjectedDelegate(System.IntPtr _unity_self, int subShaderIndex, int passIndex, int tagName);

	private delegate int Internal_FindSubshaderTagValue_InjectedDelegate(System.IntPtr _unity_self, int subShaderIndex, int tagName);

	private delegate void SetGlobalMatrixImpl_InjectedDelegate(int name, [In] System.IntPtr value);

	private delegate void SetGlobalRenderTextureImpl_InjectedDelegate(int name, System.IntPtr value, RenderTextureSubElement element);

	private delegate void SetGlobalGraphicsBufferImpl_InjectedDelegate(int name, System.IntPtr value);

	private delegate void SetGlobalConstantGraphicsBufferImpl_InjectedDelegate(int name, System.IntPtr value, int offset, int size);

	private delegate void SetGlobalRayTracingAccelerationStructureImpl_InjectedDelegate(int name, System.IntPtr accelerationStructure);

	private delegate void GetGlobalVectorImpl_InjectedDelegate(int name, [Out] System.IntPtr ret);

	private delegate void GetGlobalMatrixImpl_InjectedDelegate(int name, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetGlobalTextureImpl_InjectedDelegate(int name);

	private delegate void SetGlobalFloatArrayImpl_InjectedDelegate(int name, System.IntPtr values, int count);

	private delegate void SetGlobalVectorArrayImpl_InjectedDelegate(int name, System.IntPtr values, int count);

	private delegate void SetGlobalMatrixArrayImpl_InjectedDelegate(int name, System.IntPtr values, int count);

	private delegate void GetGlobalFloatArrayImpl_InjectedDelegate(int name, [Out] System.IntPtr ret);

	private delegate void GetGlobalVectorArrayImpl_InjectedDelegate(int name, [Out] System.IntPtr ret);

	private delegate void GetGlobalMatrixArrayImpl_InjectedDelegate(int name, [Out] System.IntPtr ret);

	private delegate void ExtractGlobalFloatArrayImpl_InjectedDelegate(int name, [Out] System.IntPtr val);

	private delegate void ExtractGlobalVectorArrayImpl_InjectedDelegate(int name, [Out] System.IntPtr val);

	private delegate void ExtractGlobalMatrixArrayImpl_InjectedDelegate(int name, [Out] System.IntPtr val);

	private delegate void GetPropertyName_InjectedDelegate(System.IntPtr shader, int propertyIndex, [Out] System.IntPtr ret);

	private delegate int GetPropertyNameId_InjectedDelegate(System.IntPtr shader, int propertyIndex);

	private delegate ShaderPropertyType GetPropertyType_InjectedDelegate(System.IntPtr shader, int propertyIndex);

	private delegate void GetPropertyDescription_InjectedDelegate(System.IntPtr shader, int propertyIndex, [Out] System.IntPtr ret);

	private delegate ShaderPropertyFlags GetPropertyFlags_InjectedDelegate(System.IntPtr shader, int propertyIndex);

	private delegate System.IntPtr GetPropertyAttributes_InjectedDelegate(System.IntPtr shader, int propertyIndex);

	private delegate int GetPropertyDefaultIntValue_InjectedDelegate(System.IntPtr shader, int propertyIndex);

	private delegate void GetPropertyDefaultValue_InjectedDelegate(System.IntPtr shader, int propertyIndex, [Out] System.IntPtr ret);

	private delegate TextureDimension GetPropertyTextureDimension_InjectedDelegate(System.IntPtr shader, int propertyIndex);

	private delegate void GetPropertyTextureDefaultName_InjectedDelegate(System.IntPtr shader, int propertyIndex, [Out] System.IntPtr ret);

	private delegate bool FindTextureStackImpl_InjectedDelegate(System.IntPtr s, int propertyIdx, [Out] System.IntPtr stackName, [Out] System.IntPtr layerIndex);

	private delegate int GetPropertyCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int FindPropertyIndex_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr propertyName);

	private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Static_Shader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalBufferImpl_Private_Static_Void_Int32_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSupported_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_globalRenderPipeline_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Static_Void_IntPtr_byref_LocalKeywordSpace_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TagToID_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PropertyToID_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalTextureImpl_Injected_Private_Static_Void_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalBufferImpl_Injected_Private_Static_Void_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Injected_Private_Static_Void_Int32_IntPtr_Int32_Int32_0;

	private static readonly get_maximumChunksOverrideDelegate get_maximumChunksOverrideDelegateField;

	private static readonly set_maximumChunksOverrideDelegate set_maximumChunksOverrideDelegateField;

	private static readonly get_globalMaximumLODDelegate get_globalMaximumLODDelegateField;

	private static readonly set_globalMaximumLODDelegate set_globalMaximumLODDelegateField;

	private static readonly GetEnabledGlobalKeywordsDelegate GetEnabledGlobalKeywordsDelegateField;

	private static readonly GetAllGlobalKeywordsDelegate GetAllGlobalKeywordsDelegateField;

	private static readonly WarmupAllShadersDelegate WarmupAllShadersDelegateField;

	private static readonly SetGlobalIntImplDelegate SetGlobalIntImplDelegateField;

	private static readonly GetGlobalIntImplDelegate GetGlobalIntImplDelegateField;

	private static readonly GetGlobalFloatImplDelegate GetGlobalFloatImplDelegateField;

	private static readonly GetGlobalFloatArrayCountImplDelegate GetGlobalFloatArrayCountImplDelegateField;

	private static readonly GetGlobalVectorArrayCountImplDelegate GetGlobalVectorArrayCountImplDelegateField;

	private static readonly GetGlobalMatrixArrayCountImplDelegate GetGlobalMatrixArrayCountImplDelegateField;

	private static readonly FindBuiltin_InjectedDelegate FindBuiltin_InjectedDelegateField;

	private static readonly get_maximumLOD_InjectedDelegate get_maximumLOD_InjectedDelegateField;

	private static readonly set_maximumLOD_InjectedDelegate set_maximumLOD_InjectedDelegateField;

	private static readonly get_globalRenderPipeline_InjectedDelegate get_globalRenderPipeline_InjectedDelegateField;

	private static readonly IsKeywordEnabled_InjectedDelegate IsKeywordEnabled_InjectedDelegateField;

	private static readonly EnableKeywordFast_InjectedDelegate EnableKeywordFast_InjectedDelegateField;

	private static readonly DisableKeywordFast_InjectedDelegate DisableKeywordFast_InjectedDelegateField;

	private static readonly SetKeywordFast_InjectedDelegate SetKeywordFast_InjectedDelegateField;

	private static readonly IsKeywordEnabledFast_InjectedDelegate IsKeywordEnabledFast_InjectedDelegateField;

	private static readonly get_renderQueue_InjectedDelegate get_renderQueue_InjectedDelegateField;

	private static readonly get_disableBatching_InjectedDelegate get_disableBatching_InjectedDelegateField;

	private static readonly IDToTag_InjectedDelegate IDToTag_InjectedDelegateField;

	private static readonly GetDependency_InjectedDelegate GetDependency_InjectedDelegateField;

	private static readonly get_subshaderCount_InjectedDelegate get_subshaderCount_InjectedDelegateField;

	private static readonly GetPassCountInSubshader_InjectedDelegate GetPassCountInSubshader_InjectedDelegateField;

	private static readonly Internal_FindPassTagValue_InjectedDelegate Internal_FindPassTagValue_InjectedDelegateField;

	private static readonly Internal_FindPassTagValueInSubShader_InjectedDelegate Internal_FindPassTagValueInSubShader_InjectedDelegateField;

	private static readonly Internal_FindSubshaderTagValue_InjectedDelegate Internal_FindSubshaderTagValue_InjectedDelegateField;

	private static readonly SetGlobalMatrixImpl_InjectedDelegate SetGlobalMatrixImpl_InjectedDelegateField;

	private static readonly SetGlobalRenderTextureImpl_InjectedDelegate SetGlobalRenderTextureImpl_InjectedDelegateField;

	private static readonly SetGlobalGraphicsBufferImpl_InjectedDelegate SetGlobalGraphicsBufferImpl_InjectedDelegateField;

	private static readonly SetGlobalConstantGraphicsBufferImpl_InjectedDelegate SetGlobalConstantGraphicsBufferImpl_InjectedDelegateField;

	private static readonly SetGlobalRayTracingAccelerationStructureImpl_InjectedDelegate SetGlobalRayTracingAccelerationStructureImpl_InjectedDelegateField;

	private static readonly GetGlobalVectorImpl_InjectedDelegate GetGlobalVectorImpl_InjectedDelegateField;

	private static readonly GetGlobalMatrixImpl_InjectedDelegate GetGlobalMatrixImpl_InjectedDelegateField;

	private static readonly GetGlobalTextureImpl_InjectedDelegate GetGlobalTextureImpl_InjectedDelegateField;

	private static readonly SetGlobalFloatArrayImpl_InjectedDelegate SetGlobalFloatArrayImpl_InjectedDelegateField;

	private static readonly SetGlobalVectorArrayImpl_InjectedDelegate SetGlobalVectorArrayImpl_InjectedDelegateField;

	private static readonly SetGlobalMatrixArrayImpl_InjectedDelegate SetGlobalMatrixArrayImpl_InjectedDelegateField;

	private static readonly GetGlobalFloatArrayImpl_InjectedDelegate GetGlobalFloatArrayImpl_InjectedDelegateField;

	private static readonly GetGlobalVectorArrayImpl_InjectedDelegate GetGlobalVectorArrayImpl_InjectedDelegateField;

	private static readonly GetGlobalMatrixArrayImpl_InjectedDelegate GetGlobalMatrixArrayImpl_InjectedDelegateField;

	private static readonly ExtractGlobalFloatArrayImpl_InjectedDelegate ExtractGlobalFloatArrayImpl_InjectedDelegateField;

	private static readonly ExtractGlobalVectorArrayImpl_InjectedDelegate ExtractGlobalVectorArrayImpl_InjectedDelegateField;

	private static readonly ExtractGlobalMatrixArrayImpl_InjectedDelegate ExtractGlobalMatrixArrayImpl_InjectedDelegateField;

	private static readonly GetPropertyName_InjectedDelegate GetPropertyName_InjectedDelegateField;

	private static readonly GetPropertyNameId_InjectedDelegate GetPropertyNameId_InjectedDelegateField;

	private static readonly GetPropertyType_InjectedDelegate GetPropertyType_InjectedDelegateField;

	private static readonly GetPropertyDescription_InjectedDelegate GetPropertyDescription_InjectedDelegateField;

	private static readonly GetPropertyFlags_InjectedDelegate GetPropertyFlags_InjectedDelegateField;

	private static readonly GetPropertyAttributes_InjectedDelegate GetPropertyAttributes_InjectedDelegateField;

	private static readonly GetPropertyDefaultIntValue_InjectedDelegate GetPropertyDefaultIntValue_InjectedDelegateField;

	private static readonly GetPropertyDefaultValue_InjectedDelegate GetPropertyDefaultValue_InjectedDelegateField;

	private static readonly GetPropertyTextureDimension_InjectedDelegate GetPropertyTextureDimension_InjectedDelegateField;

	private static readonly GetPropertyTextureDefaultName_InjectedDelegate GetPropertyTextureDefaultName_InjectedDelegateField;

	private static readonly FindTextureStackImpl_InjectedDelegate FindTextureStackImpl_InjectedDelegateField;

	private static readonly GetPropertyCount_InjectedDelegate GetPropertyCount_InjectedDelegateField;

	private static readonly FindPropertyIndex_InjectedDelegate FindPropertyIndex_InjectedDelegateField;

	public unsafe bool isSupported
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174989, RefRangeEnd = 1174990, XrefRangeStart = 1174984, XrefRangeEnd = 1174989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static string globalRenderPipeline
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_globalRenderPipeline_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1175004, RefRangeEnd = 1175006, XrefRangeStart = 1174990, XrefRangeEnd = 1175004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LocalKeywordSpace keywordSpace
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1175010, RefRangeEnd = 1175013, XrefRangeStart = 1175006, XrefRangeEnd = 1175010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe int passCount
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1175560, RefRangeEnd = 1175562, XrefRangeStart = 1175555, XrefRangeEnd = 1175560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_passCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static ShaderHardwareTier globalShaderHardwareTier
	{
		get
		{
			return (ShaderHardwareTier)Graphics.activeTier;
		}
		set
		{
			Graphics.activeTier = (GraphicsTier)value;
		}
	}

	public static int maximumChunksOverride
	{
		get
		{
			return get_maximumChunksOverrideDelegateField();
		}
		set
		{
			set_maximumChunksOverrideDelegateField(value);
		}
	}

	public int maximumLOD
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maximumLOD_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maximumLOD_Injected(intPtr, value);
		}
	}

	public static int globalMaximumLOD
	{
		get
		{
			return get_globalMaximumLODDelegateField();
		}
		set
		{
			set_globalMaximumLODDelegateField(value);
		}
	}

	public static Il2CppReferenceArray<GlobalKeyword> enabledGlobalKeywords => GetEnabledGlobalKeywords();

	public static Il2CppReferenceArray<GlobalKeyword> globalKeywords => GetAllGlobalKeywords();

	public int renderQueue
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_renderQueue_Injected(intPtr);
		}
	}

	public DisableBatchingType disableBatching
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_disableBatching_Injected(intPtr);
		}
	}

	public int subshaderCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_subshaderCount_Injected(intPtr);
		}
	}

	static Shader()
	{
		Il2CppClassPointerStore<Shader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Shader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shader>.NativeClassPtr);
		NativeMethodInfoPtr_Find_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664670);
		NativeMethodInfoPtr_get_isSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664671);
		NativeMethodInfoPtr_set_globalRenderPipeline_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664672);
		NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664673);
		NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664674);
		NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664675);
		NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664676);
		NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664677);
		NativeMethodInfoPtr_get_passCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664678);
		NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664679);
		NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664680);
		NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664681);
		NativeMethodInfoPtr_SetGlobalBufferImpl_Private_Static_Void_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664682);
		NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664683);
		NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664684);
		NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664685);
		NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664686);
		NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664687);
		NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664688);
		NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664689);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664690);
		NativeMethodInfoPtr_get_isSupported_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664691);
		NativeMethodInfoPtr_set_globalRenderPipeline_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664692);
		NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Static_Void_IntPtr_byref_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664693);
		NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664694);
		NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664695);
		NativeMethodInfoPtr_TagToID_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664696);
		NativeMethodInfoPtr_PropertyToID_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664697);
		NativeMethodInfoPtr_get_passCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664698);
		NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664699);
		NativeMethodInfoPtr_SetGlobalTextureImpl_Injected_Private_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664700);
		NativeMethodInfoPtr_SetGlobalBufferImpl_Injected_Private_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664701);
		NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Injected_Private_Static_Void_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shader>.NativeClassPtr, 100664702);
		get_maximumChunksOverrideDelegateField = IL2CPP.ResolveICall<get_maximumChunksOverrideDelegate>("UnityEngine.Shader::get_maximumChunksOverride");
		set_maximumChunksOverrideDelegateField = IL2CPP.ResolveICall<set_maximumChunksOverrideDelegate>("UnityEngine.Shader::set_maximumChunksOverride");
		get_globalMaximumLODDelegateField = IL2CPP.ResolveICall<get_globalMaximumLODDelegate>("UnityEngine.Shader::get_globalMaximumLOD");
		set_globalMaximumLODDelegateField = IL2CPP.ResolveICall<set_globalMaximumLODDelegate>("UnityEngine.Shader::set_globalMaximumLOD");
		GetEnabledGlobalKeywordsDelegateField = IL2CPP.ResolveICall<GetEnabledGlobalKeywordsDelegate>("UnityEngine.Shader::GetEnabledGlobalKeywords");
		GetAllGlobalKeywordsDelegateField = IL2CPP.ResolveICall<GetAllGlobalKeywordsDelegate>("UnityEngine.Shader::GetAllGlobalKeywords");
		WarmupAllShadersDelegateField = IL2CPP.ResolveICall<WarmupAllShadersDelegate>("UnityEngine.Shader::WarmupAllShaders");
		SetGlobalIntImplDelegateField = IL2CPP.ResolveICall<SetGlobalIntImplDelegate>("UnityEngine.Shader::SetGlobalIntImpl");
		GetGlobalIntImplDelegateField = IL2CPP.ResolveICall<GetGlobalIntImplDelegate>("UnityEngine.Shader::GetGlobalIntImpl");
		GetGlobalFloatImplDelegateField = IL2CPP.ResolveICall<GetGlobalFloatImplDelegate>("UnityEngine.Shader::GetGlobalFloatImpl");
		GetGlobalFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<GetGlobalFloatArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalFloatArrayCountImpl");
		GetGlobalVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<GetGlobalVectorArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalVectorArrayCountImpl");
		GetGlobalMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<GetGlobalMatrixArrayCountImplDelegate>("UnityEngine.Shader::GetGlobalMatrixArrayCountImpl");
		FindBuiltin_InjectedDelegateField = IL2CPP.ResolveICall<FindBuiltin_InjectedDelegate>("UnityEngine.Shader::FindBuiltin_Injected");
		get_maximumLOD_InjectedDelegateField = IL2CPP.ResolveICall<get_maximumLOD_InjectedDelegate>("UnityEngine.Shader::get_maximumLOD_Injected");
		set_maximumLOD_InjectedDelegateField = IL2CPP.ResolveICall<set_maximumLOD_InjectedDelegate>("UnityEngine.Shader::set_maximumLOD_Injected");
		get_globalRenderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<get_globalRenderPipeline_InjectedDelegate>("UnityEngine.Shader::get_globalRenderPipeline_Injected");
		IsKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsKeywordEnabled_InjectedDelegate>("UnityEngine.Shader::IsKeywordEnabled_Injected");
		EnableKeywordFast_InjectedDelegateField = IL2CPP.ResolveICall<EnableKeywordFast_InjectedDelegate>("UnityEngine.Shader::EnableKeywordFast_Injected");
		DisableKeywordFast_InjectedDelegateField = IL2CPP.ResolveICall<DisableKeywordFast_InjectedDelegate>("UnityEngine.Shader::DisableKeywordFast_Injected");
		SetKeywordFast_InjectedDelegateField = IL2CPP.ResolveICall<SetKeywordFast_InjectedDelegate>("UnityEngine.Shader::SetKeywordFast_Injected");
		IsKeywordEnabledFast_InjectedDelegateField = IL2CPP.ResolveICall<IsKeywordEnabledFast_InjectedDelegate>("UnityEngine.Shader::IsKeywordEnabledFast_Injected");
		get_renderQueue_InjectedDelegateField = IL2CPP.ResolveICall<get_renderQueue_InjectedDelegate>("UnityEngine.Shader::get_renderQueue_Injected");
		get_disableBatching_InjectedDelegateField = IL2CPP.ResolveICall<get_disableBatching_InjectedDelegate>("UnityEngine.Shader::get_disableBatching_Injected");
		IDToTag_InjectedDelegateField = IL2CPP.ResolveICall<IDToTag_InjectedDelegate>("UnityEngine.Shader::IDToTag_Injected");
		GetDependency_InjectedDelegateField = IL2CPP.ResolveICall<GetDependency_InjectedDelegate>("UnityEngine.Shader::GetDependency_Injected");
		get_subshaderCount_InjectedDelegateField = IL2CPP.ResolveICall<get_subshaderCount_InjectedDelegate>("UnityEngine.Shader::get_subshaderCount_Injected");
		GetPassCountInSubshader_InjectedDelegateField = IL2CPP.ResolveICall<GetPassCountInSubshader_InjectedDelegate>("UnityEngine.Shader::GetPassCountInSubshader_Injected");
		Internal_FindPassTagValue_InjectedDelegateField = IL2CPP.ResolveICall<Internal_FindPassTagValue_InjectedDelegate>("UnityEngine.Shader::Internal_FindPassTagValue_Injected");
		Internal_FindPassTagValueInSubShader_InjectedDelegateField = IL2CPP.ResolveICall<Internal_FindPassTagValueInSubShader_InjectedDelegate>("UnityEngine.Shader::Internal_FindPassTagValueInSubShader_Injected");
		Internal_FindSubshaderTagValue_InjectedDelegateField = IL2CPP.ResolveICall<Internal_FindSubshaderTagValue_InjectedDelegate>("UnityEngine.Shader::Internal_FindSubshaderTagValue_Injected");
		SetGlobalMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalMatrixImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalMatrixImpl_Injected");
		SetGlobalRenderTextureImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalRenderTextureImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalRenderTextureImpl_Injected");
		SetGlobalGraphicsBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalGraphicsBufferImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalGraphicsBufferImpl_Injected");
		SetGlobalConstantGraphicsBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalConstantGraphicsBufferImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalConstantGraphicsBufferImpl_Injected");
		SetGlobalRayTracingAccelerationStructureImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalRayTracingAccelerationStructureImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalRayTracingAccelerationStructureImpl_Injected");
		GetGlobalVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetGlobalVectorImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalVectorImpl_Injected");
		GetGlobalMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetGlobalMatrixImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalMatrixImpl_Injected");
		GetGlobalTextureImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetGlobalTextureImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalTextureImpl_Injected");
		SetGlobalFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalFloatArrayImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalFloatArrayImpl_Injected");
		SetGlobalVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalVectorArrayImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalVectorArrayImpl_Injected");
		SetGlobalMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGlobalMatrixArrayImpl_InjectedDelegate>("UnityEngine.Shader::SetGlobalMatrixArrayImpl_Injected");
		GetGlobalFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetGlobalFloatArrayImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalFloatArrayImpl_Injected");
		GetGlobalVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetGlobalVectorArrayImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalVectorArrayImpl_Injected");
		GetGlobalMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetGlobalMatrixArrayImpl_InjectedDelegate>("UnityEngine.Shader::GetGlobalMatrixArrayImpl_Injected");
		ExtractGlobalFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractGlobalFloatArrayImpl_InjectedDelegate>("UnityEngine.Shader::ExtractGlobalFloatArrayImpl_Injected");
		ExtractGlobalVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractGlobalVectorArrayImpl_InjectedDelegate>("UnityEngine.Shader::ExtractGlobalVectorArrayImpl_Injected");
		ExtractGlobalMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractGlobalMatrixArrayImpl_InjectedDelegate>("UnityEngine.Shader::ExtractGlobalMatrixArrayImpl_Injected");
		GetPropertyName_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyName_InjectedDelegate>("UnityEngine.Shader::GetPropertyName_Injected");
		GetPropertyNameId_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyNameId_InjectedDelegate>("UnityEngine.Shader::GetPropertyNameId_Injected");
		GetPropertyType_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyType_InjectedDelegate>("UnityEngine.Shader::GetPropertyType_Injected");
		GetPropertyDescription_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyDescription_InjectedDelegate>("UnityEngine.Shader::GetPropertyDescription_Injected");
		GetPropertyFlags_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyFlags_InjectedDelegate>("UnityEngine.Shader::GetPropertyFlags_Injected");
		GetPropertyAttributes_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyAttributes_InjectedDelegate>("UnityEngine.Shader::GetPropertyAttributes_Injected");
		GetPropertyDefaultIntValue_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyDefaultIntValue_InjectedDelegate>("UnityEngine.Shader::GetPropertyDefaultIntValue_Injected");
		GetPropertyDefaultValue_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyDefaultValue_InjectedDelegate>("UnityEngine.Shader::GetPropertyDefaultValue_Injected");
		GetPropertyTextureDimension_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyTextureDimension_InjectedDelegate>("UnityEngine.Shader::GetPropertyTextureDimension_Injected");
		GetPropertyTextureDefaultName_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyTextureDefaultName_InjectedDelegate>("UnityEngine.Shader::GetPropertyTextureDefaultName_Injected");
		FindTextureStackImpl_InjectedDelegateField = IL2CPP.ResolveICall<FindTextureStackImpl_InjectedDelegate>("UnityEngine.Shader::FindTextureStackImpl_Injected");
		GetPropertyCount_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyCount_InjectedDelegate>("UnityEngine.Shader::GetPropertyCount_Injected");
		FindPropertyIndex_InjectedDelegateField = IL2CPP.ResolveICall<FindPropertyIndex_InjectedDelegate>("UnityEngine.Shader::FindPropertyIndex_Injected");
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 1174950, RefRangeEnd = 1174984, XrefRangeStart = 1174945, XrefRangeEnd = 1174950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Shader Find(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Find_Public_Static_Shader_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1175027, RefRangeEnd = 1175029, XrefRangeStart = 1175013, XrefRangeEnd = 1175027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableKeyword(string keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableKeyword_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1175043, RefRangeEnd = 1175045, XrefRangeStart = 1175029, XrefRangeEnd = 1175043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableKeyword(string keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableKeyword_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1175059, RefRangeEnd = 1175061, XrefRangeStart = 1175045, XrefRangeEnd = 1175059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TagToID(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TagToID_Internal_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(480)]
	[CachedScanResults(RefRangeStart = 1175075, RefRangeEnd = 1175555, XrefRangeStart = 1175061, XrefRangeEnd = 1175075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PropertyToID(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropertyToID_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1175564, RefRangeEnd = 1175565, XrefRangeStart = 1175562, XrefRangeEnd = 1175564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalFloatImpl(int name, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalFloatImpl_Private_Static_Void_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175565, XrefRangeEnd = 1175567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalVectorImpl(int name, Vector4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalVectorImpl_Private_Static_Void_Int32_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1175572, RefRangeEnd = 1175573, XrefRangeStart = 1175567, XrefRangeEnd = 1175572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalTextureImpl(int name, Texture value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalTextureImpl_Private_Static_Void_Int32_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175573, XrefRangeEnd = 1175576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalBufferImpl(int name, ComputeBuffer value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalBufferImpl_Private_Static_Void_Int32_ComputeBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1175579, RefRangeEnd = 1175582, XrefRangeStart = 1175576, XrefRangeEnd = 1175579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Private_Static_Void_Int32_ComputeBuffer_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1175564, RefRangeEnd = 1175565, XrefRangeStart = 1175564, XrefRangeEnd = 1175565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalFloat(int nameID, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalFloat_Public_Static_Void_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1175584, RefRangeEnd = 1175585, XrefRangeStart = 1175582, XrefRangeEnd = 1175584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalColor(int nameID, Color value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalColor_Public_Static_Void_Int32_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175585, XrefRangeEnd = 1175591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalTexture(string name, Texture value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_String_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1175572, RefRangeEnd = 1175573, XrefRangeStart = 1175572, XrefRangeEnd = 1175573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalTexture(int nameID, Texture value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalTexture_Public_Static_Void_Int32_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1175595, RefRangeEnd = 1175599, XrefRangeStart = 1175591, XrefRangeEnd = 1175595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalBuffer(string name, ComputeBuffer value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalBuffer_Public_Static_Void_String_ComputeBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1175579, RefRangeEnd = 1175582, XrefRangeStart = 1175579, XrefRangeEnd = 1175582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalConstantBuffer_Public_Static_Void_Int32_ComputeBuffer_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175599, XrefRangeEnd = 1175603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Shader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175603, XrefRangeEnd = 1175605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isSupported_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSupported_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175605, XrefRangeEnd = 1175607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_globalRenderPipeline_Injected(ref ManagedSpanWrapper value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_globalRenderPipeline_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175607, XrefRangeEnd = 1175609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175609, XrefRangeEnd = 1175611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableKeyword_Injected(ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175611, XrefRangeEnd = 1175613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableKeyword_Injected(ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175613, XrefRangeEnd = 1175615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TagToID_Injected(ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TagToID_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175615, XrefRangeEnd = 1175617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PropertyToID_Injected(ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropertyToID_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175617, XrefRangeEnd = 1175619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_passCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_passCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175619, XrefRangeEnd = 1175621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalVectorImpl_Injected(int name, [In] ref Vector4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalVectorImpl_Injected_Private_Static_Void_Int32_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175621, XrefRangeEnd = 1175623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalTextureImpl_Injected(int name, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalTextureImpl_Injected_Private_Static_Void_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175623, XrefRangeEnd = 1175625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalBufferImpl_Injected(int name, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalBufferImpl_Injected_Private_Static_Void_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175625, XrefRangeEnd = 1175627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalConstantBufferImpl_Injected(int name, System.IntPtr value, int offset, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&name);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobalConstantBufferImpl_Injected_Private_Static_Void_Int32_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Shader(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static Shader FindBuiltin(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out System.IntPtr gcHandlePtr);
		Shader result;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					gcHandlePtr = FindBuiltin_Injected(ref managedSpanWrapper);
				}
			}
			else
			{
				gcHandlePtr = FindBuiltin_Injected(ref managedSpanWrapper);
			}
		}
		finally
		{
			result = Unmarshal.UnmarshalUnityObject<Shader>(gcHandlePtr);
		}
		return result;
	}

	public static Il2CppReferenceArray<GlobalKeyword> GetEnabledGlobalKeywords()
	{
		System.IntPtr intPtr = GetEnabledGlobalKeywordsDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GlobalKeyword>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<GlobalKeyword> GetAllGlobalKeywords()
	{
		System.IntPtr intPtr = GetAllGlobalKeywordsDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GlobalKeyword>>(intPtr) : null;
	}

	public unsafe static bool IsKeywordEnabled(string keyword)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(keyword, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(keyword);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return IsKeywordEnabled_Injected(ref managedSpanWrapper);
				}
			}
			return IsKeywordEnabled_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void EnableKeywordFast(GlobalKeyword keyword)
	{
		EnableKeywordFast_Injected(ref keyword);
	}

	public static void DisableKeywordFast(GlobalKeyword keyword)
	{
		DisableKeywordFast_Injected(ref keyword);
	}

	public static void SetKeywordFast(GlobalKeyword keyword, bool value)
	{
		SetKeywordFast_Injected(ref keyword, value);
	}

	public static bool IsKeywordEnabledFast(GlobalKeyword keyword)
	{
		return IsKeywordEnabledFast_Injected(ref keyword);
	}

	public static void EnableKeyword([In] ref GlobalKeyword keyword)
	{
		EnableKeywordFast(keyword);
	}

	public static void DisableKeyword([In] ref GlobalKeyword keyword)
	{
		DisableKeywordFast(keyword);
	}

	public static void SetKeyword([In] ref GlobalKeyword keyword, bool value)
	{
		SetKeywordFast(keyword, value);
	}

	public static bool IsKeywordEnabled([In] ref GlobalKeyword keyword)
	{
		return IsKeywordEnabledFast(keyword);
	}

	public static void WarmupAllShaders()
	{
		WarmupAllShadersDelegateField();
	}

	public static string IDToTag(int name)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			IDToTag_Injected(name, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe Shader GetDependency(string name)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out System.IntPtr dependency_Injected);
		Shader result;
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
					dependency_Injected = GetDependency_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			else
			{
				dependency_Injected = GetDependency_Injected(intPtr, ref managedSpanWrapper);
			}
		}
		finally
		{
			result = Unmarshal.UnmarshalUnityObject<Shader>(dependency_Injected);
		}
		return result;
	}

	public int GetPassCountInSubshader(int subshaderIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPassCountInSubshader_Injected(intPtr, subshaderIndex);
	}

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName)
	{
		if (passIndex < 0 || passIndex >= passCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("passIndex");
		}
		int id = Internal_FindPassTagValue(passIndex, tagName.id);
		ShaderTagId result = default(ShaderTagId);
		result.id = id;
		return result;
	}

	public ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, ShaderTagId tagName)
	{
		if (subshaderIndex < 0 || subshaderIndex >= subshaderCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("subshaderIndex");
		}
		if (passIndex < 0 || passIndex >= GetPassCountInSubshader(subshaderIndex))
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("passIndex");
		}
		int id = Internal_FindPassTagValueInSubShader(subshaderIndex, passIndex, tagName.id);
		ShaderTagId result = default(ShaderTagId);
		result.id = id;
		return result;
	}

	public ShaderTagId FindSubshaderTagValue(int subshaderIndex, ShaderTagId tagName)
	{
		if (subshaderIndex < 0 || subshaderIndex >= subshaderCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Invalid subshaderIndex {0}. Value must be in the range [0, {1})", (Il2CppSystem.Object)(object)subshaderIndex, (Il2CppSystem.Object)(object)subshaderCount));
		}
		int id = Internal_FindSubshaderTagValue(subshaderIndex, tagName.id);
		ShaderTagId result = default(ShaderTagId);
		result.id = id;
		return result;
	}

	public int Internal_FindPassTagValue(int passIndex, int tagName)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_FindPassTagValue_Injected(intPtr, passIndex, tagName);
	}

	public int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_FindPassTagValueInSubShader_Injected(intPtr, subShaderIndex, passIndex, tagName);
	}

	public int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_FindSubshaderTagValue_Injected(intPtr, subShaderIndex, tagName);
	}

	public static void SetGlobalIntImpl(int name, int value)
	{
		SetGlobalIntImplDelegateField(name, value);
	}

	public static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
	{
		SetGlobalMatrixImpl_Injected(name, ref value);
	}

	public static void SetGlobalRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element)
	{
		SetGlobalRenderTextureImpl_Injected(name, MarshalledUnityObject.Marshal(value), element);
	}

	public static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value)
	{
		SetGlobalGraphicsBufferImpl_Injected(name, (value == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(value));
	}

	public static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
	{
		SetGlobalConstantGraphicsBufferImpl_Injected(name, (value == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(value), offset, size);
	}

	public static void SetGlobalRayTracingAccelerationStructureImpl(int name, RayTracingAccelerationStructure accelerationStructure)
	{
		SetGlobalRayTracingAccelerationStructureImpl_Injected(name, (accelerationStructure == null) ? ((System.IntPtr)0) : RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(accelerationStructure));
	}

	public static int GetGlobalIntImpl(int name)
	{
		return GetGlobalIntImplDelegateField(name);
	}

	public static float GetGlobalFloatImpl(int name)
	{
		return GetGlobalFloatImplDelegateField(name);
	}

	public static Vector4 GetGlobalVectorImpl(int name)
	{
		GetGlobalVectorImpl_Injected(name, out var ret);
		return ret;
	}

	public static Matrix4x4 GetGlobalMatrixImpl(int name)
	{
		GetGlobalMatrixImpl_Injected(name, out var ret);
		return ret;
	}

	public static Texture GetGlobalTextureImpl(int name)
	{
		return Unmarshal.UnmarshalUnityObject<Texture>(GetGlobalTextureImpl_Injected(name));
	}

	public unsafe static void SetGlobalFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0010: Expected O, but got Ref
		//IL_001c: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
		((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)values);
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			SetGlobalFloatArrayImpl_Injected(name, ref values2, count);
		}
	}

	public unsafe static void SetGlobalVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0010: Expected O, but got Ref
		//IL_001c: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector4> span);
		((Il2CppSystem.Span<Vector4>)(&span))._002Ector((Il2CppArrayBase<Vector4>)(object)values);
		fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector4>)(&span)).Length);
			SetGlobalVectorArrayImpl_Injected(name, ref values2, count);
		}
	}

	public unsafe static void SetGlobalMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
	{
		//IL_0009: Expected O, but got Ref
		//IL_0010: Expected O, but got Ref
		//IL_001c: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<Matrix4x4> span);
		((Il2CppSystem.Span<Matrix4x4>)(&span))._002Ector((Il2CppArrayBase<Matrix4x4>)(object)values);
		fixed (Matrix4x4* begin = &((Il2CppSystem.Span<Matrix4x4>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Matrix4x4>)(&span)).Length);
			SetGlobalMatrixArrayImpl_Injected(name, ref values2, count);
		}
	}

	public unsafe static Il2CppStructArray<float> GetGlobalFloatArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<float> result;
		try
		{
			GetGlobalFloatArrayImpl_Injected(name, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<float> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<float>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<Vector4> GetGlobalVectorArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Vector4> result;
		try
		{
			GetGlobalVectorArrayImpl_Injected(name, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Vector4> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Vector4>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Matrix4x4> result;
		try
		{
			GetGlobalMatrixArrayImpl_Injected(name, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Matrix4x4> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Matrix4x4>*)(&array));
			result = array;
		}
		return result;
	}

	public static int GetGlobalFloatArrayCountImpl(int name)
	{
		return GetGlobalFloatArrayCountImplDelegateField(name);
	}

	public static int GetGlobalVectorArrayCountImpl(int name)
	{
		return GetGlobalVectorArrayCountImplDelegateField(name);
	}

	public static int GetGlobalMatrixArrayCountImpl(int name)
	{
		return GetGlobalMatrixArrayCountImplDelegateField(name);
	}

	public static void ExtractGlobalFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void ExtractGlobalVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void ExtractGlobalMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void SetGlobalFloatArray(int name, Il2CppStructArray<float> values, int count)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		if (((Il2CppArrayBase)values).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("Zero-sized array is not allowed.");
		}
		if (((Il2CppArrayBase)values).Length < count)
		{
			throw new Il2CppSystem.ArgumentException("array has less elements than passed count.");
		}
		SetGlobalFloatArrayImpl(name, values, count);
	}

	public static void SetGlobalVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		if (((Il2CppArrayBase)values).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("Zero-sized array is not allowed.");
		}
		if (((Il2CppArrayBase)values).Length < count)
		{
			throw new Il2CppSystem.ArgumentException("array has less elements than passed count.");
		}
		SetGlobalVectorArrayImpl(name, values, count);
	}

	public static void SetGlobalMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		if (((Il2CppArrayBase)values).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("Zero-sized array is not allowed.");
		}
		if (((Il2CppArrayBase)values).Length < count)
		{
			throw new Il2CppSystem.ArgumentException("array has less elements than passed count.");
		}
		SetGlobalMatrixArrayImpl(name, values, count);
	}

	public static void ExtractGlobalFloatArray(int name, List<float> values)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		values.Clear();
		int globalFloatArrayCountImpl = GetGlobalFloatArrayCountImpl(name);
		if (globalFloatArrayCountImpl > 0)
		{
			NoAllocHelpers.EnsureListElemCount(values, globalFloatArrayCountImpl);
			ExtractGlobalFloatArrayImpl(name, (Il2CppStructArray<float>)(object)NoAllocHelpers.ExtractArrayFromList(values));
		}
	}

	public static void ExtractGlobalVectorArray(int name, List<Vector4> values)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		values.Clear();
		int globalVectorArrayCountImpl = GetGlobalVectorArrayCountImpl(name);
		if (globalVectorArrayCountImpl > 0)
		{
			NoAllocHelpers.EnsureListElemCount(values, globalVectorArrayCountImpl);
			ExtractGlobalVectorArrayImpl(name, (Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(values));
		}
	}

	public static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		values.Clear();
		int globalMatrixArrayCountImpl = GetGlobalMatrixArrayCountImpl(name);
		if (globalMatrixArrayCountImpl > 0)
		{
			NoAllocHelpers.EnsureListElemCount(values, globalMatrixArrayCountImpl);
			ExtractGlobalMatrixArrayImpl(name, (Il2CppStructArray<Matrix4x4>)(object)NoAllocHelpers.ExtractArrayFromList(values));
		}
	}

	public static void SetGlobalInt(string name, int value)
	{
		SetGlobalFloatImpl(PropertyToID(name), value);
	}

	public static void SetGlobalInt(int nameID, int value)
	{
		SetGlobalFloatImpl(nameID, value);
	}

	public static void SetGlobalFloat(string name, float value)
	{
		SetGlobalFloatImpl(PropertyToID(name), value);
	}

	public static void SetGlobalInteger(string name, int value)
	{
		SetGlobalIntImpl(PropertyToID(name), value);
	}

	public static void SetGlobalInteger(int nameID, int value)
	{
		SetGlobalIntImpl(nameID, value);
	}

	public static void SetGlobalVector(string name, Vector4 value)
	{
		SetGlobalVectorImpl(PropertyToID(name), value);
	}

	public static void SetGlobalVector(int nameID, Vector4 value)
	{
		SetGlobalVectorImpl(nameID, value);
	}

	public static void SetGlobalColor(string name, Color value)
	{
		SetGlobalVectorImpl(PropertyToID(name), value);
	}

	public static void SetGlobalMatrix(string name, Matrix4x4 value)
	{
		SetGlobalMatrixImpl(PropertyToID(name), value);
	}

	public static void SetGlobalMatrix(int nameID, Matrix4x4 value)
	{
		SetGlobalMatrixImpl(nameID, value);
	}

	public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element)
	{
		SetGlobalRenderTextureImpl(PropertyToID(name), value, element);
	}

	public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element)
	{
		SetGlobalRenderTextureImpl(nameID, value, element);
	}

	public static void SetGlobalBuffer(int nameID, ComputeBuffer value)
	{
		SetGlobalBufferImpl(nameID, value);
	}

	public static void SetGlobalBuffer(string name, GraphicsBuffer value)
	{
		SetGlobalGraphicsBufferImpl(PropertyToID(name), value);
	}

	public static void SetGlobalBuffer(int nameID, GraphicsBuffer value)
	{
		SetGlobalGraphicsBufferImpl(nameID, value);
	}

	public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size)
	{
		SetGlobalConstantBufferImpl(PropertyToID(name), value, offset, size);
	}

	public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
	{
		SetGlobalConstantGraphicsBufferImpl(PropertyToID(name), value, offset, size);
	}

	public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
	{
		SetGlobalConstantGraphicsBufferImpl(nameID, value, offset, size);
	}

	public static void SetGlobalRayTracingAccelerationStructure(string name, RayTracingAccelerationStructure value)
	{
		SetGlobalRayTracingAccelerationStructureImpl(PropertyToID(name), value);
	}

	public static void SetGlobalRayTracingAccelerationStructure(int nameID, RayTracingAccelerationStructure value)
	{
		SetGlobalRayTracingAccelerationStructureImpl(nameID, value);
	}

	public static void SetGlobalFloatArray(string name, List<float> values)
	{
		SetGlobalFloatArray(PropertyToID(name), (Il2CppStructArray<float>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public static void SetGlobalFloatArray(int nameID, List<float> values)
	{
		SetGlobalFloatArray(nameID, (Il2CppStructArray<float>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public static void SetGlobalFloatArray(string name, Il2CppStructArray<float> values)
	{
		SetGlobalFloatArray(PropertyToID(name), values, ((Il2CppArrayBase)values).Length);
	}

	public static void SetGlobalFloatArray(int nameID, Il2CppStructArray<float> values)
	{
		SetGlobalFloatArray(nameID, values, ((Il2CppArrayBase)values).Length);
	}

	public static void SetGlobalVectorArray(string name, List<Vector4> values)
	{
		SetGlobalVectorArray(PropertyToID(name), (Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public static void SetGlobalVectorArray(int nameID, List<Vector4> values)
	{
		SetGlobalVectorArray(nameID, (Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public static void SetGlobalVectorArray(string name, Il2CppStructArray<Vector4> values)
	{
		SetGlobalVectorArray(PropertyToID(name), values, ((Il2CppArrayBase)values).Length);
	}

	public static void SetGlobalVectorArray(int nameID, Il2CppStructArray<Vector4> values)
	{
		SetGlobalVectorArray(nameID, values, ((Il2CppArrayBase)values).Length);
	}

	public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values)
	{
		SetGlobalMatrixArray(PropertyToID(name), (Il2CppStructArray<Matrix4x4>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
	{
		SetGlobalMatrixArray(nameID, (Il2CppStructArray<Matrix4x4>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public static void SetGlobalMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
	{
		SetGlobalMatrixArray(PropertyToID(name), values, ((Il2CppArrayBase)values).Length);
	}

	public static void SetGlobalMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
	{
		SetGlobalMatrixArray(nameID, values, ((Il2CppArrayBase)values).Length);
	}

	public static int GetGlobalInt(string name)
	{
		return (int)GetGlobalFloatImpl(PropertyToID(name));
	}

	public static int GetGlobalInt(int nameID)
	{
		return (int)GetGlobalFloatImpl(nameID);
	}

	public static float GetGlobalFloat(string name)
	{
		return GetGlobalFloatImpl(PropertyToID(name));
	}

	public static float GetGlobalFloat(int nameID)
	{
		return GetGlobalFloatImpl(nameID);
	}

	public static int GetGlobalInteger(string name)
	{
		return GetGlobalIntImpl(PropertyToID(name));
	}

	public static int GetGlobalInteger(int nameID)
	{
		return GetGlobalIntImpl(nameID);
	}

	public static Vector4 GetGlobalVector(string name)
	{
		return GetGlobalVectorImpl(PropertyToID(name));
	}

	public static Vector4 GetGlobalVector(int nameID)
	{
		return GetGlobalVectorImpl(nameID);
	}

	public static Color GetGlobalColor(string name)
	{
		return GetGlobalVectorImpl(PropertyToID(name));
	}

	public static Color GetGlobalColor(int nameID)
	{
		return GetGlobalVectorImpl(nameID);
	}

	public static Matrix4x4 GetGlobalMatrix(string name)
	{
		return GetGlobalMatrixImpl(PropertyToID(name));
	}

	public static Matrix4x4 GetGlobalMatrix(int nameID)
	{
		return GetGlobalMatrixImpl(nameID);
	}

	public static Texture GetGlobalTexture(string name)
	{
		return GetGlobalTextureImpl(PropertyToID(name));
	}

	public static Texture GetGlobalTexture(int nameID)
	{
		return GetGlobalTextureImpl(nameID);
	}

	public static Il2CppStructArray<float> GetGlobalFloatArray(string name)
	{
		return GetGlobalFloatArray(PropertyToID(name));
	}

	public static Il2CppStructArray<float> GetGlobalFloatArray(int nameID)
	{
		return (GetGlobalFloatArrayCountImpl(nameID) != 0) ? GetGlobalFloatArrayImpl(nameID) : null;
	}

	public static Il2CppStructArray<Vector4> GetGlobalVectorArray(string name)
	{
		return GetGlobalVectorArray(PropertyToID(name));
	}

	public static Il2CppStructArray<Vector4> GetGlobalVectorArray(int nameID)
	{
		return (GetGlobalVectorArrayCountImpl(nameID) != 0) ? GetGlobalVectorArrayImpl(nameID) : null;
	}

	public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(string name)
	{
		return GetGlobalMatrixArray(PropertyToID(name));
	}

	public static Il2CppStructArray<Matrix4x4> GetGlobalMatrixArray(int nameID)
	{
		return (GetGlobalMatrixArrayCountImpl(nameID) != 0) ? GetGlobalMatrixArrayImpl(nameID) : null;
	}

	public static void GetGlobalFloatArray(string name, List<float> values)
	{
		ExtractGlobalFloatArray(PropertyToID(name), values);
	}

	public static void GetGlobalFloatArray(int nameID, List<float> values)
	{
		ExtractGlobalFloatArray(nameID, values);
	}

	public static void GetGlobalVectorArray(string name, List<Vector4> values)
	{
		ExtractGlobalVectorArray(PropertyToID(name), values);
	}

	public static void GetGlobalVectorArray(int nameID, List<Vector4> values)
	{
		ExtractGlobalVectorArray(nameID, values);
	}

	public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values)
	{
		ExtractGlobalMatrixArray(PropertyToID(name), values);
	}

	public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values)
	{
		ExtractGlobalMatrixArray(nameID, values);
	}

	public static string GetPropertyName(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
			}
			GetPropertyName_Injected(intPtr, propertyIndex, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static int GetPropertyNameId(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		return GetPropertyNameId_Injected(intPtr, propertyIndex);
	}

	public static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		return GetPropertyType_Injected(intPtr, propertyIndex);
	}

	public static string GetPropertyDescription(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
			}
			GetPropertyDescription_Injected(intPtr, propertyIndex, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		return GetPropertyFlags_Injected(intPtr, propertyIndex);
	}

	public static Il2CppStringArray GetPropertyAttributes(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		return GetPropertyAttributes_Injected(intPtr, propertyIndex);
	}

	public static int GetPropertyDefaultIntValue(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		return GetPropertyDefaultIntValue_Injected(intPtr, propertyIndex);
	}

	public static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		GetPropertyDefaultValue_Injected(intPtr, propertyIndex, out var ret);
		return ret;
	}

	public static TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		return GetPropertyTextureDimension_Injected(intPtr, propertyIndex);
	}

	public static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex)
	{
		if ((object)shader == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
		}
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(shader);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(shader, "shader");
			}
			GetPropertyTextureDefaultName_Injected(intPtr, propertyIndex, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex)
	{
		if ((object)s == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(s, "s");
		}
		Unsafe.SkipInit(out ManagedSpanWrapper stackName2);
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(s);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(s, "s");
			}
			return FindTextureStackImpl_Injected(intPtr, propertyIdx, out stackName2, out layerIndex);
		}
		finally
		{
			stackName = OutStringMarshaller.GetStringAndDispose(stackName2);
		}
	}

	public static void CheckPropertyIndex(Shader s, int propertyIndex)
	{
		if (propertyIndex < 0 || propertyIndex >= s.GetPropertyCount())
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("propertyIndex");
		}
	}

	public int GetPropertyCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPropertyCount_Injected(intPtr);
	}

	public unsafe int FindPropertyIndex(string propertyName)
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
			if (!StringMarshaller.TryMarshalEmptyOrNullString(propertyName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(propertyName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return FindPropertyIndex_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return FindPropertyIndex_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public string GetPropertyName(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		return GetPropertyName(this, propertyIndex);
	}

	public int GetPropertyNameId(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		return GetPropertyNameId(this, propertyIndex);
	}

	public ShaderPropertyType GetPropertyType(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		return GetPropertyType(this, propertyIndex);
	}

	public string GetPropertyDescription(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		return GetPropertyDescription(this, propertyIndex);
	}

	public ShaderPropertyFlags GetPropertyFlags(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		return GetPropertyFlags(this, propertyIndex);
	}

	public Il2CppStringArray GetPropertyAttributes(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		return GetPropertyAttributes(this, propertyIndex);
	}

	public float GetPropertyDefaultFloatValue(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		ShaderPropertyType propertyType = GetPropertyType(propertyIndex);
		if (propertyType != ShaderPropertyType.Float && propertyType != ShaderPropertyType.Range)
		{
			throw new Il2CppSystem.ArgumentException("Property type is not Float or Range.");
		}
		return GetPropertyDefaultValue(this, propertyIndex)[0];
	}

	public Vector4 GetPropertyDefaultVectorValue(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		ShaderPropertyType propertyType = GetPropertyType(propertyIndex);
		if (propertyType != 0 && propertyType != ShaderPropertyType.Vector)
		{
			throw new Il2CppSystem.ArgumentException("Property type is not Color or Vector.");
		}
		return GetPropertyDefaultValue(this, propertyIndex);
	}

	public Vector2 GetPropertyRangeLimits(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		if (GetPropertyType(propertyIndex) != ShaderPropertyType.Range)
		{
			throw new Il2CppSystem.ArgumentException("Property type is not Range.");
		}
		Vector4 propertyDefaultValue = GetPropertyDefaultValue(this, propertyIndex);
		return new Vector2(propertyDefaultValue[1], propertyDefaultValue[2]);
	}

	public int GetPropertyDefaultIntValue(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		if (GetPropertyType(propertyIndex) != ShaderPropertyType.Int)
		{
			throw new Il2CppSystem.ArgumentException("Property type is not Int.");
		}
		return GetPropertyDefaultIntValue(this, propertyIndex);
	}

	public TextureDimension GetPropertyTextureDimension(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		if (GetPropertyType(propertyIndex) != ShaderPropertyType.Texture)
		{
			throw new Il2CppSystem.ArgumentException("Property type is not TexEnv.");
		}
		return GetPropertyTextureDimension(this, propertyIndex);
	}

	public string GetPropertyTextureDefaultName(int propertyIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		ShaderPropertyType propertyType = GetPropertyType(propertyIndex);
		if (propertyType != ShaderPropertyType.Texture)
		{
			throw new Il2CppSystem.ArgumentException("Property type is not Texture.");
		}
		return GetPropertyTextureDefaultName(this, propertyIndex);
	}

	public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex)
	{
		CheckPropertyIndex(this, propertyIndex);
		ShaderPropertyType propertyType = GetPropertyType(propertyIndex);
		if (propertyType != ShaderPropertyType.Texture)
		{
			throw new Il2CppSystem.ArgumentException("Property type is not Texture.");
		}
		return FindTextureStackImpl(this, propertyIndex, out stackName, out layerIndex);
	}

	public unsafe static System.IntPtr FindBuiltin_Injected(ref ManagedSpanWrapper name)
	{
		return FindBuiltin_InjectedDelegateField((nint)Unsafe.AsPointer(ref name));
	}

	public static int get_maximumLOD_Injected(System.IntPtr _unity_self)
	{
		return get_maximumLOD_InjectedDelegateField(_unity_self);
	}

	public static void set_maximumLOD_Injected(System.IntPtr _unity_self, int value)
	{
		set_maximumLOD_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_globalRenderPipeline_Injected(out ManagedSpanWrapper ret)
	{
		get_globalRenderPipeline_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool IsKeywordEnabled_Injected(ref ManagedSpanWrapper keyword)
	{
		return IsKeywordEnabled_InjectedDelegateField((nint)Unsafe.AsPointer(ref keyword));
	}

	public unsafe static void EnableKeywordFast_Injected([In] ref GlobalKeyword keyword)
	{
		EnableKeywordFast_InjectedDelegate enableKeywordFast_InjectedDelegateField = EnableKeywordFast_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyword);
		enableKeywordFast_InjectedDelegateField((nint)(&intPtr));
	}

	public unsafe static void DisableKeywordFast_Injected([In] ref GlobalKeyword keyword)
	{
		DisableKeywordFast_InjectedDelegate disableKeywordFast_InjectedDelegateField = DisableKeywordFast_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyword);
		disableKeywordFast_InjectedDelegateField((nint)(&intPtr));
	}

	public unsafe static void SetKeywordFast_Injected([In] ref GlobalKeyword keyword, bool value)
	{
		SetKeywordFast_InjectedDelegate setKeywordFast_InjectedDelegateField = SetKeywordFast_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyword);
		setKeywordFast_InjectedDelegateField((nint)(&intPtr), value);
	}

	public unsafe static bool IsKeywordEnabledFast_Injected([In] ref GlobalKeyword keyword)
	{
		IsKeywordEnabledFast_InjectedDelegate isKeywordEnabledFast_InjectedDelegateField = IsKeywordEnabledFast_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyword);
		return isKeywordEnabledFast_InjectedDelegateField((nint)(&intPtr));
	}

	public static int get_renderQueue_Injected(System.IntPtr _unity_self)
	{
		return get_renderQueue_InjectedDelegateField(_unity_self);
	}

	public static DisableBatchingType get_disableBatching_Injected(System.IntPtr _unity_self)
	{
		return get_disableBatching_InjectedDelegateField(_unity_self);
	}

	public unsafe static void IDToTag_Injected(int name, out ManagedSpanWrapper ret)
	{
		IDToTag_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static System.IntPtr GetDependency_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		return GetDependency_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name));
	}

	public static int get_subshaderCount_Injected(System.IntPtr _unity_self)
	{
		return get_subshaderCount_InjectedDelegateField(_unity_self);
	}

	public static int GetPassCountInSubshader_Injected(System.IntPtr _unity_self, int subshaderIndex)
	{
		return GetPassCountInSubshader_InjectedDelegateField(_unity_self, subshaderIndex);
	}

	public static int Internal_FindPassTagValue_Injected(System.IntPtr _unity_self, int passIndex, int tagName)
	{
		return Internal_FindPassTagValue_InjectedDelegateField(_unity_self, passIndex, tagName);
	}

	public static int Internal_FindPassTagValueInSubShader_Injected(System.IntPtr _unity_self, int subShaderIndex, int passIndex, int tagName)
	{
		return Internal_FindPassTagValueInSubShader_InjectedDelegateField(_unity_self, subShaderIndex, passIndex, tagName);
	}

	public static int Internal_FindSubshaderTagValue_Injected(System.IntPtr _unity_self, int subShaderIndex, int tagName)
	{
		return Internal_FindSubshaderTagValue_InjectedDelegateField(_unity_self, subShaderIndex, tagName);
	}

	public unsafe static void SetGlobalMatrixImpl_Injected(int name, [In] ref Matrix4x4 value)
	{
		SetGlobalMatrixImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref value));
	}

	public static void SetGlobalRenderTextureImpl_Injected(int name, System.IntPtr value, RenderTextureSubElement element)
	{
		SetGlobalRenderTextureImpl_InjectedDelegateField(name, value, element);
	}

	public static void SetGlobalGraphicsBufferImpl_Injected(int name, System.IntPtr value)
	{
		SetGlobalGraphicsBufferImpl_InjectedDelegateField(name, value);
	}

	public static void SetGlobalConstantGraphicsBufferImpl_Injected(int name, System.IntPtr value, int offset, int size)
	{
		SetGlobalConstantGraphicsBufferImpl_InjectedDelegateField(name, value, offset, size);
	}

	public static void SetGlobalRayTracingAccelerationStructureImpl_Injected(int name, System.IntPtr accelerationStructure)
	{
		SetGlobalRayTracingAccelerationStructureImpl_InjectedDelegateField(name, accelerationStructure);
	}

	public unsafe static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret)
	{
		GetGlobalVectorImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret)
	{
		GetGlobalMatrixImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref ret));
	}

	public static System.IntPtr GetGlobalTextureImpl_Injected(int name)
	{
		return GetGlobalTextureImpl_InjectedDelegateField(name);
	}

	public unsafe static void SetGlobalFloatArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count)
	{
		SetGlobalFloatArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref values), count);
	}

	public unsafe static void SetGlobalVectorArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count)
	{
		SetGlobalVectorArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref values), count);
	}

	public unsafe static void SetGlobalMatrixArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count)
	{
		SetGlobalMatrixArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref values), count);
	}

	public unsafe static void GetGlobalFloatArrayImpl_Injected(int name, out BlittableArrayWrapper ret)
	{
		GetGlobalFloatArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetGlobalVectorArrayImpl_Injected(int name, out BlittableArrayWrapper ret)
	{
		GetGlobalVectorArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetGlobalMatrixArrayImpl_Injected(int name, out BlittableArrayWrapper ret)
	{
		GetGlobalMatrixArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ExtractGlobalFloatArrayImpl_Injected(int name, out BlittableArrayWrapper val)
	{
		ExtractGlobalFloatArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void ExtractGlobalVectorArrayImpl_Injected(int name, out BlittableArrayWrapper val)
	{
		ExtractGlobalVectorArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void ExtractGlobalMatrixArrayImpl_Injected(int name, out BlittableArrayWrapper val)
	{
		ExtractGlobalMatrixArrayImpl_InjectedDelegateField(name, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void GetPropertyName_Injected(System.IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret)
	{
		GetPropertyName_InjectedDelegateField(shader, propertyIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public static int GetPropertyNameId_Injected(System.IntPtr shader, int propertyIndex)
	{
		return GetPropertyNameId_InjectedDelegateField(shader, propertyIndex);
	}

	public static ShaderPropertyType GetPropertyType_Injected(System.IntPtr shader, int propertyIndex)
	{
		return GetPropertyType_InjectedDelegateField(shader, propertyIndex);
	}

	public unsafe static void GetPropertyDescription_Injected(System.IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret)
	{
		GetPropertyDescription_InjectedDelegateField(shader, propertyIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public static ShaderPropertyFlags GetPropertyFlags_Injected(System.IntPtr shader, int propertyIndex)
	{
		return GetPropertyFlags_InjectedDelegateField(shader, propertyIndex);
	}

	public static Il2CppStringArray GetPropertyAttributes_Injected(System.IntPtr shader, int propertyIndex)
	{
		System.IntPtr intPtr = GetPropertyAttributes_InjectedDelegateField(shader, propertyIndex);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static int GetPropertyDefaultIntValue_Injected(System.IntPtr shader, int propertyIndex)
	{
		return GetPropertyDefaultIntValue_InjectedDelegateField(shader, propertyIndex);
	}

	public unsafe static void GetPropertyDefaultValue_Injected(System.IntPtr shader, int propertyIndex, out Vector4 ret)
	{
		GetPropertyDefaultValue_InjectedDelegateField(shader, propertyIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public static TextureDimension GetPropertyTextureDimension_Injected(System.IntPtr shader, int propertyIndex)
	{
		return GetPropertyTextureDimension_InjectedDelegateField(shader, propertyIndex);
	}

	public unsafe static void GetPropertyTextureDefaultName_Injected(System.IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret)
	{
		GetPropertyTextureDefaultName_InjectedDelegateField(shader, propertyIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool FindTextureStackImpl_Injected(System.IntPtr s, int propertyIdx, out ManagedSpanWrapper stackName, out int layerIndex)
	{
		return FindTextureStackImpl_InjectedDelegateField(s, propertyIdx, (nint)Unsafe.AsPointer(ref stackName), (nint)Unsafe.AsPointer(ref layerIndex));
	}

	public static int GetPropertyCount_Injected(System.IntPtr _unity_self)
	{
		return GetPropertyCount_InjectedDelegateField(_unity_self);
	}

	public unsafe static int FindPropertyIndex_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper propertyName)
	{
		return FindPropertyIndex_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref propertyName));
	}
}
