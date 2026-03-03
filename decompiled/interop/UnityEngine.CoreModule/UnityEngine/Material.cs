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

public class Material : Object
{
	private delegate System.IntPtr GetDefaultMaterial_InjectedDelegate();

	private delegate System.IntPtr GetDefaultParticleMaterial_InjectedDelegate();

	private delegate System.IntPtr GetDefaultLineMaterial_InjectedDelegate();

	private delegate bool HasIntImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasTextureImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasMatrixImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasVectorImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasConstantBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate int get_rawRenderQueue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetLocalKeyword_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword, bool value);

	private delegate bool IsLocalKeywordEnabled_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword);

	private delegate System.IntPtr GetEnabledKeywords_InjectedDelegate(System.IntPtr _unity_self);

	private delegate MaterialGlobalIlluminationFlags get_globalIlluminationFlags_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_globalIlluminationFlags_InjectedDelegate(System.IntPtr _unity_self, MaterialGlobalIlluminationFlags value);

	private delegate bool get_doubleSidedGI_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_doubleSidedGI_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void SetShaderPassEnabled_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr passName, bool enabled);

	private delegate bool GetShaderPassEnabled_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr passName);

	private delegate void GetPassName_InjectedDelegate(System.IntPtr _unity_self, int pass, [Out] System.IntPtr ret);

	private delegate void SetOverrideTag_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr tag, System.IntPtr val);

	private delegate void GetTagImpl_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr tag, bool currentSubShaderOnly, System.IntPtr defaultValue, [Out] System.IntPtr ret);

	private delegate void Lerp_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr start, System.IntPtr end, float t);

	private delegate void CopyMatchingPropertiesFromMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr mat);

	private delegate System.IntPtr GetPropertyNamesImpl_InjectedDelegate(System.IntPtr _unity_self, int propertyType);

	private delegate System.IntPtr GetTexturePropertyNames_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetTexturePropertyNameIDs_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void GetTexturePropertyNamesInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr outNames);

	private delegate void GetTexturePropertyNameIDsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr outNames);

	private delegate void SetRenderTextureImpl_InjectedDelegate(System.IntPtr _unity_self, int name, System.IntPtr value, RenderTextureSubElement element);

	private delegate void SetBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name, System.IntPtr value);

	private delegate void SetConstantGraphicsBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name, System.IntPtr value, int offset, int size);

	private delegate int GetIntImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate void GetMatrixImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void GetBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void GetConstantBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void SetColorArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, System.IntPtr values, int count);

	private delegate void GetFloatArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void GetVectorArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void GetColorArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void GetMatrixArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate int GetFloatArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate int GetVectorArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate int GetColorArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate int GetMatrixArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate void ExtractFloatArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr val);

	private delegate void ExtractVectorArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr val);

	private delegate void ExtractColorArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr val);

	private delegate void ExtractMatrixArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr val);

	private delegate void GetTextureScaleAndOffsetImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void SetTextureScaleImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [In] System.IntPtr scale);

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ColorId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MainTexId;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shader_Public_get_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFloatImpl_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFloat_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeywordEnabled_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableLocalKeyword_Private_Void_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableLocalKeyword_Private_Void_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_byref_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_byref_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabledKeywords_Private_Void_Il2CppReferenceArray_1_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enabledKeywords_Public_set_Void_Il2CppReferenceArray_1_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableInstancing_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindPass_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPass_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCRC_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGraphicsBufferImpl_Private_Void_Int32_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureOffsetImpl_Private_Void_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_String_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Void_Int32_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArray_Public_Void_Int32_Il2CppStructArray_1_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureOffset_Public_Void_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWithShader_Injected_Private_Static_Void_Material_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWithMaterial_Injected_Private_Static_Void_Material_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shader_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shader_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Injected_Private_Static_Int32_IntPtr_ShaderPropertyFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasProperty_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFloatImpl_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderQueue_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_renderQueue_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeywordEnabled_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableLocalKeyword_Injected_Private_Static_Void_IntPtr_byref_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableLocalKeyword_Injected_Private_Static_Void_IntPtr_byref_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEnabledKeywords_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_LocalKeyword_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableInstancing_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableInstancing_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindPass_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPass_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyPropertiesFromMaterial_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderKeywords_Injected_Private_Static_Il2CppStringArray_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCRC_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIntImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatImpl_Injected_Private_Static_Void_IntPtr_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGraphicsBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatImpl_Injected_Private_Static_Single_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureImpl_Injected_Private_Static_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureOffsetImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0;

	private static readonly GetDefaultMaterial_InjectedDelegate GetDefaultMaterial_InjectedDelegateField;

	private static readonly GetDefaultParticleMaterial_InjectedDelegate GetDefaultParticleMaterial_InjectedDelegateField;

	private static readonly GetDefaultLineMaterial_InjectedDelegate GetDefaultLineMaterial_InjectedDelegateField;

	private static readonly HasIntImpl_InjectedDelegate HasIntImpl_InjectedDelegateField;

	private static readonly HasTextureImpl_InjectedDelegate HasTextureImpl_InjectedDelegateField;

	private static readonly HasMatrixImpl_InjectedDelegate HasMatrixImpl_InjectedDelegateField;

	private static readonly HasVectorImpl_InjectedDelegate HasVectorImpl_InjectedDelegateField;

	private static readonly HasBufferImpl_InjectedDelegate HasBufferImpl_InjectedDelegateField;

	private static readonly HasConstantBufferImpl_InjectedDelegate HasConstantBufferImpl_InjectedDelegateField;

	private static readonly get_rawRenderQueue_InjectedDelegate get_rawRenderQueue_InjectedDelegateField;

	private static readonly SetLocalKeyword_InjectedDelegate SetLocalKeyword_InjectedDelegateField;

	private static readonly IsLocalKeywordEnabled_InjectedDelegate IsLocalKeywordEnabled_InjectedDelegateField;

	private static readonly GetEnabledKeywords_InjectedDelegate GetEnabledKeywords_InjectedDelegateField;

	private static readonly get_globalIlluminationFlags_InjectedDelegate get_globalIlluminationFlags_InjectedDelegateField;

	private static readonly set_globalIlluminationFlags_InjectedDelegate set_globalIlluminationFlags_InjectedDelegateField;

	private static readonly get_doubleSidedGI_InjectedDelegate get_doubleSidedGI_InjectedDelegateField;

	private static readonly set_doubleSidedGI_InjectedDelegate set_doubleSidedGI_InjectedDelegateField;

	private static readonly SetShaderPassEnabled_InjectedDelegate SetShaderPassEnabled_InjectedDelegateField;

	private static readonly GetShaderPassEnabled_InjectedDelegate GetShaderPassEnabled_InjectedDelegateField;

	private static readonly GetPassName_InjectedDelegate GetPassName_InjectedDelegateField;

	private static readonly SetOverrideTag_InjectedDelegate SetOverrideTag_InjectedDelegateField;

	private static readonly GetTagImpl_InjectedDelegate GetTagImpl_InjectedDelegateField;

	private static readonly Lerp_InjectedDelegate Lerp_InjectedDelegateField;

	private static readonly CopyMatchingPropertiesFromMaterial_InjectedDelegate CopyMatchingPropertiesFromMaterial_InjectedDelegateField;

	private static readonly GetPropertyNamesImpl_InjectedDelegate GetPropertyNamesImpl_InjectedDelegateField;

	private static readonly GetTexturePropertyNames_InjectedDelegate GetTexturePropertyNames_InjectedDelegateField;

	private static readonly GetTexturePropertyNameIDs_InjectedDelegate GetTexturePropertyNameIDs_InjectedDelegateField;

	private static readonly GetTexturePropertyNamesInternal_InjectedDelegate GetTexturePropertyNamesInternal_InjectedDelegateField;

	private static readonly GetTexturePropertyNameIDsInternal_InjectedDelegate GetTexturePropertyNameIDsInternal_InjectedDelegateField;

	private static readonly SetRenderTextureImpl_InjectedDelegate SetRenderTextureImpl_InjectedDelegateField;

	private static readonly SetBufferImpl_InjectedDelegate SetBufferImpl_InjectedDelegateField;

	private static readonly SetConstantGraphicsBufferImpl_InjectedDelegate SetConstantGraphicsBufferImpl_InjectedDelegateField;

	private static readonly GetIntImpl_InjectedDelegate GetIntImpl_InjectedDelegateField;

	private static readonly GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;

	private static readonly GetBufferImpl_InjectedDelegate GetBufferImpl_InjectedDelegateField;

	private static readonly GetConstantBufferImpl_InjectedDelegate GetConstantBufferImpl_InjectedDelegateField;

	private static readonly SetColorArrayImpl_InjectedDelegate SetColorArrayImpl_InjectedDelegateField;

	private static readonly GetFloatArrayImpl_InjectedDelegate GetFloatArrayImpl_InjectedDelegateField;

	private static readonly GetVectorArrayImpl_InjectedDelegate GetVectorArrayImpl_InjectedDelegateField;

	private static readonly GetColorArrayImpl_InjectedDelegate GetColorArrayImpl_InjectedDelegateField;

	private static readonly GetMatrixArrayImpl_InjectedDelegate GetMatrixArrayImpl_InjectedDelegateField;

	private static readonly GetFloatArrayCountImpl_InjectedDelegate GetFloatArrayCountImpl_InjectedDelegateField;

	private static readonly GetVectorArrayCountImpl_InjectedDelegate GetVectorArrayCountImpl_InjectedDelegateField;

	private static readonly GetColorArrayCountImpl_InjectedDelegate GetColorArrayCountImpl_InjectedDelegateField;

	private static readonly GetMatrixArrayCountImpl_InjectedDelegate GetMatrixArrayCountImpl_InjectedDelegateField;

	private static readonly ExtractFloatArrayImpl_InjectedDelegate ExtractFloatArrayImpl_InjectedDelegateField;

	private static readonly ExtractVectorArrayImpl_InjectedDelegate ExtractVectorArrayImpl_InjectedDelegateField;

	private static readonly ExtractColorArrayImpl_InjectedDelegate ExtractColorArrayImpl_InjectedDelegateField;

	private static readonly ExtractMatrixArrayImpl_InjectedDelegate ExtractMatrixArrayImpl_InjectedDelegateField;

	private static readonly GetTextureScaleAndOffsetImpl_InjectedDelegate GetTextureScaleAndOffsetImpl_InjectedDelegateField;

	private static readonly SetTextureScaleImpl_InjectedDelegate SetTextureScaleImpl_InjectedDelegateField;

	public unsafe static int k_ColorId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ColorId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ColorId, (void*)(&value));
		}
	}

	public unsafe static int k_MainTexId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MainTexId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MainTexId, (void*)(&value));
		}
	}

	public unsafe Shader shader
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1175761, RefRangeEnd = 1175780, XrefRangeStart = 1175750, XrefRangeEnd = 1175761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shader_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1175791, RefRangeEnd = 1175796, XrefRangeStart = 1175780, XrefRangeEnd = 1175791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Color color
	{
		get
		{
			int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainColor);
			if (firstPropertyNameIdByAttribute >= 0)
			{
				return GetColor(firstPropertyNameIdByAttribute);
			}
			return GetColor(k_ColorId);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1175814, RefRangeEnd = 1175815, XrefRangeStart = 1175796, XrefRangeEnd = 1175814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Texture mainTexture
	{
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1175828, RefRangeEnd = 1175854, XrefRangeStart = 1175815, XrefRangeEnd = 1175828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 1175866, RefRangeEnd = 1175924, XrefRangeStart = 1175854, XrefRangeEnd = 1175866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int renderQueue
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1176030, RefRangeEnd = 1176031, XrefRangeStart = 1176022, XrefRangeEnd = 1176030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1176039, RefRangeEnd = 1176070, XrefRangeStart = 1176031, XrefRangeEnd = 1176039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<LocalKeyword> enabledKeywords
	{
		get
		{
			return GetEnabledKeywords();
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1176228, RefRangeEnd = 1176232, XrefRangeStart = 1176228, XrefRangeEnd = 1176232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enabledKeywords_Public_set_Void_Il2CppReferenceArray_1_LocalKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool enableInstancing
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1176240, RefRangeEnd = 1176246, XrefRangeStart = 1176232, XrefRangeEnd = 1176240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableInstancing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1176254, RefRangeEnd = 1176258, XrefRangeStart = 1176246, XrefRangeEnd = 1176254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int passCount
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1176266, RefRangeEnd = 1176270, XrefRangeStart = 1176258, XrefRangeEnd = 1176266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe Il2CppStringArray shaderKeywords
	{
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1176349, RefRangeEnd = 1176370, XrefRangeStart = 1176349, XrefRangeEnd = 1176370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1176378, RefRangeEnd = 1176406, XrefRangeStart = 1176378, XrefRangeEnd = 1176406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public Vector2 mainTextureOffset
	{
		get
		{
			int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
			if (firstPropertyNameIdByAttribute >= 0)
			{
				return GetTextureOffset(firstPropertyNameIdByAttribute);
			}
			return GetTextureOffset(k_MainTexId);
		}
		set
		{
			int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
			if (firstPropertyNameIdByAttribute >= 0)
			{
				SetTextureOffset(firstPropertyNameIdByAttribute, value);
			}
			else
			{
				SetTextureOffset(k_MainTexId, value);
			}
		}
	}

	public Vector2 mainTextureScale
	{
		get
		{
			int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
			if (firstPropertyNameIdByAttribute >= 0)
			{
				return GetTextureScale(firstPropertyNameIdByAttribute);
			}
			return GetTextureScale(k_MainTexId);
		}
		set
		{
			int firstPropertyNameIdByAttribute = GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags.MainTexture);
			if (firstPropertyNameIdByAttribute >= 0)
			{
				SetTextureScale(firstPropertyNameIdByAttribute, value);
			}
			else
			{
				SetTextureScale(k_MainTexId, value);
			}
		}
	}

	public int rawRenderQueue
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_rawRenderQueue_Injected(intPtr);
		}
	}

	public MaterialGlobalIlluminationFlags globalIlluminationFlags
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_globalIlluminationFlags_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_globalIlluminationFlags_Injected(intPtr, value);
		}
	}

	public bool doubleSidedGI
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_doubleSidedGI_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_doubleSidedGI_Injected(intPtr, value);
		}
	}

	static Material()
	{
		Il2CppClassPointerStore<Material>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Material");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Material>.NativeClassPtr);
		NativeFieldInfoPtr_k_ColorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Material>.NativeClassPtr, "k_ColorId");
		NativeFieldInfoPtr_k_MainTexId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Material>.NativeClassPtr, "k_MainTexId");
		NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664703);
		NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664704);
		NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664705);
		NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664706);
		NativeMethodInfoPtr__ctor_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664707);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664708);
		NativeMethodInfoPtr_get_shader_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664709);
		NativeMethodInfoPtr_set_shader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664710);
		NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664711);
		NativeMethodInfoPtr_get_mainTexture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664712);
		NativeMethodInfoPtr_set_mainTexture_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664713);
		NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664714);
		NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664715);
		NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664716);
		NativeMethodInfoPtr_HasFloatImpl_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664717);
		NativeMethodInfoPtr_HasFloat_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664718);
		NativeMethodInfoPtr_get_renderQueue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664719);
		NativeMethodInfoPtr_set_renderQueue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664720);
		NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664721);
		NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664722);
		NativeMethodInfoPtr_IsKeywordEnabled_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664723);
		NativeMethodInfoPtr_EnableLocalKeyword_Private_Void_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664724);
		NativeMethodInfoPtr_DisableLocalKeyword_Private_Void_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664725);
		NativeMethodInfoPtr_EnableKeyword_Public_Void_byref_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664726);
		NativeMethodInfoPtr_DisableKeyword_Public_Void_byref_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664727);
		NativeMethodInfoPtr_SetEnabledKeywords_Private_Void_Il2CppReferenceArray_1_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664728);
		NativeMethodInfoPtr_set_enabledKeywords_Public_set_Void_Il2CppReferenceArray_1_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664729);
		NativeMethodInfoPtr_get_enableInstancing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664730);
		NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664731);
		NativeMethodInfoPtr_get_passCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664732);
		NativeMethodInfoPtr_FindPass_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664733);
		NativeMethodInfoPtr_SetPass_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664734);
		NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664735);
		NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664736);
		NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664737);
		NativeMethodInfoPtr_get_shaderKeywords_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664738);
		NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664739);
		NativeMethodInfoPtr_ComputeCRC_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664740);
		NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664741);
		NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664742);
		NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664743);
		NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664744);
		NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664745);
		NativeMethodInfoPtr_SetGraphicsBufferImpl_Private_Void_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664746);
		NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664747);
		NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664748);
		NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664749);
		NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664750);
		NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664751);
		NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664752);
		NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664753);
		NativeMethodInfoPtr_SetTextureOffsetImpl_Private_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664754);
		NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664755);
		NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664756);
		NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664757);
		NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664758);
		NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664759);
		NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664760);
		NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664761);
		NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664762);
		NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664763);
		NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664764);
		NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664765);
		NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664766);
		NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664767);
		NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664768);
		NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664769);
		NativeMethodInfoPtr_SetBuffer_Public_Void_String_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664770);
		NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664771);
		NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664772);
		NativeMethodInfoPtr_SetFloatArray_Public_Void_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664773);
		NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664774);
		NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664775);
		NativeMethodInfoPtr_SetMatrixArray_Public_Void_Int32_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664776);
		NativeMethodInfoPtr_GetInt_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664777);
		NativeMethodInfoPtr_GetFloat_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664778);
		NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664779);
		NativeMethodInfoPtr_GetColor_Public_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664780);
		NativeMethodInfoPtr_GetColor_Public_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664781);
		NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664782);
		NativeMethodInfoPtr_GetTexture_Public_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664783);
		NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664784);
		NativeMethodInfoPtr_SetTextureOffset_Public_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664785);
		NativeMethodInfoPtr_CreateWithShader_Injected_Private_Static_Void_Material_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664787);
		NativeMethodInfoPtr_CreateWithMaterial_Injected_Private_Static_Void_Material_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664788);
		NativeMethodInfoPtr_get_shader_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664789);
		NativeMethodInfoPtr_set_shader_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664790);
		NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Injected_Private_Static_Int32_IntPtr_ShaderPropertyFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664791);
		NativeMethodInfoPtr_HasProperty_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664792);
		NativeMethodInfoPtr_HasFloatImpl_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664793);
		NativeMethodInfoPtr_get_renderQueue_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664794);
		NativeMethodInfoPtr_set_renderQueue_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664795);
		NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664796);
		NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664797);
		NativeMethodInfoPtr_IsKeywordEnabled_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664798);
		NativeMethodInfoPtr_EnableLocalKeyword_Injected_Private_Static_Void_IntPtr_byref_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664799);
		NativeMethodInfoPtr_DisableLocalKeyword_Injected_Private_Static_Void_IntPtr_byref_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664800);
		NativeMethodInfoPtr_SetEnabledKeywords_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_LocalKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664801);
		NativeMethodInfoPtr_get_enableInstancing_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664802);
		NativeMethodInfoPtr_set_enableInstancing_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664803);
		NativeMethodInfoPtr_get_passCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664804);
		NativeMethodInfoPtr_FindPass_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664805);
		NativeMethodInfoPtr_SetPass_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664806);
		NativeMethodInfoPtr_CopyPropertiesFromMaterial_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664807);
		NativeMethodInfoPtr_GetShaderKeywords_Injected_Private_Static_Il2CppStringArray_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664808);
		NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664809);
		NativeMethodInfoPtr_ComputeCRC_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664810);
		NativeMethodInfoPtr_SetIntImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664811);
		NativeMethodInfoPtr_SetFloatImpl_Injected_Private_Static_Void_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664812);
		NativeMethodInfoPtr_SetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664813);
		NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664814);
		NativeMethodInfoPtr_SetTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664815);
		NativeMethodInfoPtr_SetGraphicsBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664816);
		NativeMethodInfoPtr_SetConstantBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664817);
		NativeMethodInfoPtr_GetFloatImpl_Injected_Private_Static_Single_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664818);
		NativeMethodInfoPtr_GetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664819);
		NativeMethodInfoPtr_GetTextureImpl_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664820);
		NativeMethodInfoPtr_SetFloatArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664821);
		NativeMethodInfoPtr_SetVectorArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664822);
		NativeMethodInfoPtr_SetMatrixArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664823);
		NativeMethodInfoPtr_SetTextureOffsetImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Material>.NativeClassPtr, 100664824);
		GetDefaultMaterial_InjectedDelegateField = IL2CPP.ResolveICall<GetDefaultMaterial_InjectedDelegate>("UnityEngine.Material::GetDefaultMaterial_Injected");
		GetDefaultParticleMaterial_InjectedDelegateField = IL2CPP.ResolveICall<GetDefaultParticleMaterial_InjectedDelegate>("UnityEngine.Material::GetDefaultParticleMaterial_Injected");
		GetDefaultLineMaterial_InjectedDelegateField = IL2CPP.ResolveICall<GetDefaultLineMaterial_InjectedDelegate>("UnityEngine.Material::GetDefaultLineMaterial_Injected");
		HasIntImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasIntImpl_InjectedDelegate>("UnityEngine.Material::HasIntImpl_Injected");
		HasTextureImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasTextureImpl_InjectedDelegate>("UnityEngine.Material::HasTextureImpl_Injected");
		HasMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasMatrixImpl_InjectedDelegate>("UnityEngine.Material::HasMatrixImpl_Injected");
		HasVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasVectorImpl_InjectedDelegate>("UnityEngine.Material::HasVectorImpl_Injected");
		HasBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasBufferImpl_InjectedDelegate>("UnityEngine.Material::HasBufferImpl_Injected");
		HasConstantBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasConstantBufferImpl_InjectedDelegate>("UnityEngine.Material::HasConstantBufferImpl_Injected");
		get_rawRenderQueue_InjectedDelegateField = IL2CPP.ResolveICall<get_rawRenderQueue_InjectedDelegate>("UnityEngine.Material::get_rawRenderQueue_Injected");
		SetLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<SetLocalKeyword_InjectedDelegate>("UnityEngine.Material::SetLocalKeyword_Injected");
		IsLocalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsLocalKeywordEnabled_InjectedDelegate>("UnityEngine.Material::IsLocalKeywordEnabled_Injected");
		GetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<GetEnabledKeywords_InjectedDelegate>("UnityEngine.Material::GetEnabledKeywords_Injected");
		get_globalIlluminationFlags_InjectedDelegateField = IL2CPP.ResolveICall<get_globalIlluminationFlags_InjectedDelegate>("UnityEngine.Material::get_globalIlluminationFlags_Injected");
		set_globalIlluminationFlags_InjectedDelegateField = IL2CPP.ResolveICall<set_globalIlluminationFlags_InjectedDelegate>("UnityEngine.Material::set_globalIlluminationFlags_Injected");
		get_doubleSidedGI_InjectedDelegateField = IL2CPP.ResolveICall<get_doubleSidedGI_InjectedDelegate>("UnityEngine.Material::get_doubleSidedGI_Injected");
		set_doubleSidedGI_InjectedDelegateField = IL2CPP.ResolveICall<set_doubleSidedGI_InjectedDelegate>("UnityEngine.Material::set_doubleSidedGI_Injected");
		SetShaderPassEnabled_InjectedDelegateField = IL2CPP.ResolveICall<SetShaderPassEnabled_InjectedDelegate>("UnityEngine.Material::SetShaderPassEnabled_Injected");
		GetShaderPassEnabled_InjectedDelegateField = IL2CPP.ResolveICall<GetShaderPassEnabled_InjectedDelegate>("UnityEngine.Material::GetShaderPassEnabled_Injected");
		GetPassName_InjectedDelegateField = IL2CPP.ResolveICall<GetPassName_InjectedDelegate>("UnityEngine.Material::GetPassName_Injected");
		SetOverrideTag_InjectedDelegateField = IL2CPP.ResolveICall<SetOverrideTag_InjectedDelegate>("UnityEngine.Material::SetOverrideTag_Injected");
		GetTagImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetTagImpl_InjectedDelegate>("UnityEngine.Material::GetTagImpl_Injected");
		Lerp_InjectedDelegateField = IL2CPP.ResolveICall<Lerp_InjectedDelegate>("UnityEngine.Material::Lerp_Injected");
		CopyMatchingPropertiesFromMaterial_InjectedDelegateField = IL2CPP.ResolveICall<CopyMatchingPropertiesFromMaterial_InjectedDelegate>("UnityEngine.Material::CopyMatchingPropertiesFromMaterial_Injected");
		GetPropertyNamesImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetPropertyNamesImpl_InjectedDelegate>("UnityEngine.Material::GetPropertyNamesImpl_Injected");
		GetTexturePropertyNames_InjectedDelegateField = IL2CPP.ResolveICall<GetTexturePropertyNames_InjectedDelegate>("UnityEngine.Material::GetTexturePropertyNames_Injected");
		GetTexturePropertyNameIDs_InjectedDelegateField = IL2CPP.ResolveICall<GetTexturePropertyNameIDs_InjectedDelegate>("UnityEngine.Material::GetTexturePropertyNameIDs_Injected");
		GetTexturePropertyNamesInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetTexturePropertyNamesInternal_InjectedDelegate>("UnityEngine.Material::GetTexturePropertyNamesInternal_Injected");
		GetTexturePropertyNameIDsInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetTexturePropertyNameIDsInternal_InjectedDelegate>("UnityEngine.Material::GetTexturePropertyNameIDsInternal_Injected");
		SetRenderTextureImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetRenderTextureImpl_InjectedDelegate>("UnityEngine.Material::SetRenderTextureImpl_Injected");
		SetBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetBufferImpl_InjectedDelegate>("UnityEngine.Material::SetBufferImpl_Injected");
		SetConstantGraphicsBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetConstantGraphicsBufferImpl_InjectedDelegate>("UnityEngine.Material::SetConstantGraphicsBufferImpl_Injected");
		GetIntImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetIntImpl_InjectedDelegate>("UnityEngine.Material::GetIntImpl_Injected");
		GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetMatrixImpl_InjectedDelegate>("UnityEngine.Material::GetMatrixImpl_Injected");
		GetBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetBufferImpl_InjectedDelegate>("UnityEngine.Material::GetBufferImpl_Injected");
		GetConstantBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetConstantBufferImpl_InjectedDelegate>("UnityEngine.Material::GetConstantBufferImpl_Injected");
		SetColorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetColorArrayImpl_InjectedDelegate>("UnityEngine.Material::SetColorArrayImpl_Injected");
		GetFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetFloatArrayImpl_InjectedDelegate>("UnityEngine.Material::GetFloatArrayImpl_Injected");
		GetVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetVectorArrayImpl_InjectedDelegate>("UnityEngine.Material::GetVectorArrayImpl_Injected");
		GetColorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetColorArrayImpl_InjectedDelegate>("UnityEngine.Material::GetColorArrayImpl_Injected");
		GetMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetMatrixArrayImpl_InjectedDelegate>("UnityEngine.Material::GetMatrixArrayImpl_Injected");
		GetFloatArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetFloatArrayCountImpl_InjectedDelegate>("UnityEngine.Material::GetFloatArrayCountImpl_Injected");
		GetVectorArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetVectorArrayCountImpl_InjectedDelegate>("UnityEngine.Material::GetVectorArrayCountImpl_Injected");
		GetColorArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetColorArrayCountImpl_InjectedDelegate>("UnityEngine.Material::GetColorArrayCountImpl_Injected");
		GetMatrixArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetMatrixArrayCountImpl_InjectedDelegate>("UnityEngine.Material::GetMatrixArrayCountImpl_Injected");
		ExtractFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractFloatArrayImpl_InjectedDelegate>("UnityEngine.Material::ExtractFloatArrayImpl_Injected");
		ExtractVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractVectorArrayImpl_InjectedDelegate>("UnityEngine.Material::ExtractVectorArrayImpl_Injected");
		ExtractColorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractColorArrayImpl_InjectedDelegate>("UnityEngine.Material::ExtractColorArrayImpl_Injected");
		ExtractMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractMatrixArrayImpl_InjectedDelegate>("UnityEngine.Material::ExtractMatrixArrayImpl_Injected");
		GetTextureScaleAndOffsetImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetTextureScaleAndOffsetImpl_InjectedDelegate>("UnityEngine.Material::GetTextureScaleAndOffsetImpl_Injected");
		SetTextureScaleImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetTextureScaleImpl_InjectedDelegate>("UnityEngine.Material::SetTextureScaleImpl_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175627, XrefRangeEnd = 1175639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateWithShader(Material self, Shader shader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWithShader_Private_Static_Void_Material_Shader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175639, XrefRangeEnd = 1175651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateWithMaterial(Material self, Material source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWithMaterial_Private_Static_Void_Material_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175651, XrefRangeEnd = 1175653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateWithString(Material self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWithString_Private_Static_Void_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1175672, RefRangeEnd = 1175693, XrefRangeStart = 1175653, XrefRangeEnd = 1175672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material(Shader shader)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 1175712, RefRangeEnd = 1175741, XrefRangeStart = 1175693, XrefRangeEnd = 1175712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material(Material source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175741, XrefRangeEnd = 1175750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Material(string contents)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Material>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175924, XrefRangeEnd = 1175932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&attributeFlag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Private_Int32_ShaderPropertyFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 1175940, RefRangeEnd = 1175994, XrefRangeStart = 1175932, XrefRangeEnd = 1175940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasProperty(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasProperty_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1176003, RefRangeEnd = 1176012, XrefRangeStart = 1175994, XrefRangeEnd = 1176003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasProperty(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1176020, RefRangeEnd = 1176022, XrefRangeStart = 1176012, XrefRangeEnd = 1176020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasFloatImpl(int name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFloatImpl_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1176020, RefRangeEnd = 1176022, XrefRangeStart = 1176020, XrefRangeEnd = 1176022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasFloat(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFloat_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(46)]
	[CachedScanResults(RefRangeStart = 1176089, RefRangeEnd = 1176135, XrefRangeStart = 1176070, XrefRangeEnd = 1176089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableKeyword(string keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1176154, RefRangeEnd = 1176169, XrefRangeStart = 1176135, XrefRangeEnd = 1176154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1176188, RefRangeEnd = 1176191, XrefRangeStart = 1176169, XrefRangeEnd = 1176188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKeywordEnabled(string keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeywordEnabled_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176191, XrefRangeEnd = 1176198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableLocalKeyword(LocalKeyword keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableLocalKeyword_Private_Void_LocalKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176198, XrefRangeEnd = 1176205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableLocalKeyword(LocalKeyword keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableLocalKeyword_Private_Void_LocalKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176205, XrefRangeEnd = 1176212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableKeyword([In] ref LocalKeyword keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableKeyword_Public_Void_byref_LocalKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1176219, RefRangeEnd = 1176220, XrefRangeStart = 1176212, XrefRangeEnd = 1176219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableKeyword([In] ref LocalKeyword keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableKeyword_Public_Void_byref_LocalKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1176228, RefRangeEnd = 1176232, XrefRangeStart = 1176220, XrefRangeEnd = 1176228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnabledKeywords(Il2CppReferenceArray<LocalKeyword> keywords)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keywords);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnabledKeywords_Private_Void_Il2CppReferenceArray_1_LocalKeyword_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1176289, RefRangeEnd = 1176309, XrefRangeStart = 1176270, XrefRangeEnd = 1176289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindPass(string passName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPass_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1176317, RefRangeEnd = 1176323, XrefRangeStart = 1176309, XrefRangeEnd = 1176317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetPass(int pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPass_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1176334, RefRangeEnd = 1176341, XrefRangeStart = 1176323, XrefRangeEnd = 1176334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyPropertiesFromMaterial(Material mat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyPropertiesFromMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1176349, RefRangeEnd = 1176370, XrefRangeStart = 1176341, XrefRangeEnd = 1176349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray GetShaderKeywords()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShaderKeywords_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 1176378, RefRangeEnd = 1176406, XrefRangeStart = 1176370, XrefRangeEnd = 1176378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShaderKeywords(Il2CppStringArray names)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1176414, RefRangeEnd = 1176420, XrefRangeStart = 1176406, XrefRangeEnd = 1176414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ComputeCRC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeCRC_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1176428, RefRangeEnd = 1176431, XrefRangeStart = 1176420, XrefRangeEnd = 1176428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIntImpl(int name, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1176439, RefRangeEnd = 1176443, XrefRangeStart = 1176431, XrefRangeEnd = 1176439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloatImpl(int name, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176443, XrefRangeEnd = 1176450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColorImpl(int name, Color value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176450, XrefRangeEnd = 1176457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrixImpl(int name, Matrix4x4 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1176468, RefRangeEnd = 1176471, XrefRangeStart = 1176457, XrefRangeEnd = 1176468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTextureImpl(int name, Texture value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1176479, RefRangeEnd = 1176481, XrefRangeStart = 1176471, XrefRangeEnd = 1176479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGraphicsBufferImpl_Private_Void_Int32_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1176489, RefRangeEnd = 1176491, XrefRangeStart = 1176481, XrefRangeEnd = 1176489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(85)]
	[CachedScanResults(RefRangeStart = 1176499, RefRangeEnd = 1176584, XrefRangeStart = 1176491, XrefRangeEnd = 1176499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloatImpl(int name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176584, XrefRangeEnd = 1176591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColorImpl(int name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorImpl_Private_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1176602, RefRangeEnd = 1176605, XrefRangeStart = 1176591, XrefRangeEnd = 1176602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture GetTextureImpl(int name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176605, XrefRangeEnd = 1176619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176619, XrefRangeEnd = 1176633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176633, XrefRangeEnd = 1176647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176647, XrefRangeEnd = 1176654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTextureOffsetImpl(int name, Vector2 offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureOffsetImpl_Private_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1176667, RefRangeEnd = 1176668, XrefRangeStart = 1176654, XrefRangeEnd = 1176667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1176681, RefRangeEnd = 1176683, XrefRangeStart = 1176668, XrefRangeEnd = 1176681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1176696, RefRangeEnd = 1176697, XrefRangeStart = 1176683, XrefRangeEnd = 1176696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1176699, RefRangeEnd = 1176720, XrefRangeStart = 1176697, XrefRangeEnd = 1176699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInt(string name, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1176721, RefRangeEnd = 1176725, XrefRangeStart = 1176720, XrefRangeEnd = 1176721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInt(int nameID, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(105)]
	[CachedScanResults(RefRangeStart = 1176727, RefRangeEnd = 1176832, XrefRangeStart = 1176725, XrefRangeEnd = 1176727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloat(string name, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 1176833, RefRangeEnd = 1176915, XrefRangeStart = 1176832, XrefRangeEnd = 1176833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloat(int nameID, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1176428, RefRangeEnd = 1176431, XrefRangeStart = 1176428, XrefRangeEnd = 1176431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInteger(int nameID, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 1176923, RefRangeEnd = 1176951, XrefRangeStart = 1176915, XrefRangeEnd = 1176923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(string name, Color value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1176958, RefRangeEnd = 1176963, XrefRangeStart = 1176951, XrefRangeEnd = 1176958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(int nameID, Color value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1176971, RefRangeEnd = 1176992, XrefRangeStart = 1176963, XrefRangeEnd = 1176971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVector(string name, Vector4 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1176999, RefRangeEnd = 1177064, XrefRangeStart = 1176992, XrefRangeEnd = 1176999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVector(int nameID, Vector4 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1177071, RefRangeEnd = 1177073, XrefRangeStart = 1177064, XrefRangeEnd = 1177071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrix(int nameID, Matrix4x4 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(60)]
	[CachedScanResults(RefRangeStart = 1177075, RefRangeEnd = 1177135, XrefRangeStart = 1177073, XrefRangeEnd = 1177075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTexture(string name, Texture value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(58)]
	[CachedScanResults(RefRangeStart = 1177136, RefRangeEnd = 1177194, XrefRangeStart = 1177135, XrefRangeEnd = 1177136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTexture(int nameID, Texture value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1177203, RefRangeEnd = 1177206, XrefRangeStart = 1177194, XrefRangeEnd = 1177203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBuffer(string name, GraphicsBuffer value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuffer_Public_Void_String_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1176479, RefRangeEnd = 1176481, XrefRangeStart = 1176479, XrefRangeEnd = 1176481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBuffer(int nameID, GraphicsBuffer value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuffer_Public_Void_Int32_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1176489, RefRangeEnd = 1176491, XrefRangeStart = 1176489, XrefRangeEnd = 1176491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1177207, RefRangeEnd = 1177209, XrefRangeStart = 1177206, XrefRangeEnd = 1177207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloatArray(int nameID, Il2CppStructArray<float> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatArray_Public_Void_Int32_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1177211, RefRangeEnd = 1177213, XrefRangeStart = 1177209, XrefRangeEnd = 1177211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1177214, RefRangeEnd = 1177219, XrefRangeStart = 1177213, XrefRangeEnd = 1177214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1177220, RefRangeEnd = 1177223, XrefRangeStart = 1177219, XrefRangeEnd = 1177220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrixArray_Public_Void_Int32_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177231, RefRangeEnd = 1177232, XrefRangeStart = 1177223, XrefRangeEnd = 1177231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInt(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1177241, RefRangeEnd = 1177248, XrefRangeStart = 1177232, XrefRangeEnd = 1177241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloat(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(85)]
	[CachedScanResults(RefRangeStart = 1176499, RefRangeEnd = 1176584, XrefRangeStart = 1176499, XrefRangeEnd = 1176584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloat(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177256, RefRangeEnd = 1177257, XrefRangeStart = 1177248, XrefRangeEnd = 1177256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1177264, RefRangeEnd = 1177267, XrefRangeStart = 1177257, XrefRangeEnd = 1177264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1177274, RefRangeEnd = 1177286, XrefRangeStart = 1177267, XrefRangeEnd = 1177274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 GetVector(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177288, RefRangeEnd = 1177289, XrefRangeStart = 1177286, XrefRangeEnd = 1177288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture GetTexture(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTexture_Public_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 1177290, RefRangeEnd = 1177315, XrefRangeStart = 1177289, XrefRangeEnd = 1177290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture GetTexture(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1177322, RefRangeEnd = 1177323, XrefRangeStart = 1177315, XrefRangeEnd = 1177322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTextureOffset(int nameID, Vector2 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureOffset_Public_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177323, XrefRangeEnd = 1177325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateWithShader_Injected(Material self, System.IntPtr shader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shader;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWithShader_Injected_Private_Static_Void_Material_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177325, XrefRangeEnd = 1177327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateWithMaterial_Injected(Material self, System.IntPtr source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWithMaterial_Injected_Private_Static_Void_Material_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177327, XrefRangeEnd = 1177329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_shader_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shader_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177329, XrefRangeEnd = 1177331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_shader_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shader_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177331, XrefRangeEnd = 1177333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetFirstPropertyNameIdByAttribute_Injected(System.IntPtr _unity_self, ShaderPropertyFlags attributeFlag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(ShaderPropertyFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &attributeFlag;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstPropertyNameIdByAttribute_Injected_Private_Static_Int32_IntPtr_ShaderPropertyFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177333, XrefRangeEnd = 1177335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasProperty_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasProperty_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177335, XrefRangeEnd = 1177337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasFloatImpl_Injected(System.IntPtr _unity_self, int name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFloatImpl_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177337, XrefRangeEnd = 1177339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_renderQueue_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderQueue_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177339, XrefRangeEnd = 1177341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_renderQueue_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_renderQueue_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177341, XrefRangeEnd = 1177343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177343, XrefRangeEnd = 1177345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177345, XrefRangeEnd = 1177347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsKeywordEnabled_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeywordEnabled_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177347, XrefRangeEnd = 1177349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableLocalKeyword_Injected(System.IntPtr _unity_self, [In] ref LocalKeyword keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableLocalKeyword_Injected_Private_Static_Void_IntPtr_byref_LocalKeyword_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177349, XrefRangeEnd = 1177351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableLocalKeyword_Injected(System.IntPtr _unity_self, [In] ref LocalKeyword keyword)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableLocalKeyword_Injected_Private_Static_Void_IntPtr_byref_LocalKeyword_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177351, XrefRangeEnd = 1177353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetEnabledKeywords_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<LocalKeyword> keywords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keywords);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEnabledKeywords_Injected_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_LocalKeyword_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177353, XrefRangeEnd = 1177355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_enableInstancing_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableInstancing_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177355, XrefRangeEnd = 1177357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_enableInstancing_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableInstancing_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177357, XrefRangeEnd = 1177359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177359, XrefRangeEnd = 1177361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindPass_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper passName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref passName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPass_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177361, XrefRangeEnd = 1177363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetPass_Injected(System.IntPtr _unity_self, int pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPass_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177363, XrefRangeEnd = 1177365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyPropertiesFromMaterial_Injected(System.IntPtr _unity_self, System.IntPtr mat)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyPropertiesFromMaterial_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177365, XrefRangeEnd = 1177367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetShaderKeywords_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShaderKeywords_Injected_Private_Static_Il2CppStringArray_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177367, XrefRangeEnd = 1177369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetShaderKeywords_Injected(System.IntPtr _unity_self, Il2CppStringArray names)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)names);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177369, XrefRangeEnd = 1177371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ComputeCRC_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeCRC_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177371, XrefRangeEnd = 1177373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetIntImpl_Injected(System.IntPtr _unity_self, int name, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIntImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177373, XrefRangeEnd = 1177375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFloatImpl_Injected(System.IntPtr _unity_self, int name, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatImpl_Injected_Private_Static_Void_IntPtr_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177375, XrefRangeEnd = 1177377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetColorImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Color value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177377, XrefRangeEnd = 1177379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMatrixImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Matrix4x4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177379, XrefRangeEnd = 1177381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTextureImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177381, XrefRangeEnd = 1177383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGraphicsBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGraphicsBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177383, XrefRangeEnd = 1177385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetConstantBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value, int offset, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConstantBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177385, XrefRangeEnd = 1177387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetFloatImpl_Injected(System.IntPtr _unity_self, int name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloatImpl_Injected_Private_Static_Single_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177387, XrefRangeEnd = 1177389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetColorImpl_Injected(System.IntPtr _unity_self, int name, out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177389, XrefRangeEnd = 1177391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetTextureImpl_Injected(System.IntPtr _unity_self, int name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureImpl_Injected_Private_Static_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177391, XrefRangeEnd = 1177393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFloatArrayImpl_Injected(System.IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref values);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177393, XrefRangeEnd = 1177395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVectorArrayImpl_Injected(System.IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref values);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVectorArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177395, XrefRangeEnd = 1177397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMatrixArrayImpl_Injected(System.IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref values);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrixArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177397, XrefRangeEnd = 1177399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTextureOffsetImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Vector2 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureOffsetImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Material(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Material Create(string scriptContents)
	{
		return new Material(scriptContents);
	}

	public static Material GetDefaultMaterial()
	{
		return Unmarshal.UnmarshalUnityObject<Material>(GetDefaultMaterial_Injected());
	}

	public static Material GetDefaultParticleMaterial()
	{
		return Unmarshal.UnmarshalUnityObject<Material>(GetDefaultParticleMaterial_Injected());
	}

	public static Material GetDefaultLineMaterial()
	{
		return Unmarshal.UnmarshalUnityObject<Material>(GetDefaultLineMaterial_Injected());
	}

	public bool HasFloat(string name)
	{
		return HasFloatImpl(Shader.PropertyToID(name));
	}

	public bool HasInt(string name)
	{
		return HasFloatImpl(Shader.PropertyToID(name));
	}

	public bool HasInt(int nameID)
	{
		return HasFloatImpl(nameID);
	}

	public bool HasIntImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasIntImpl_Injected(intPtr, name);
	}

	public bool HasInteger(string name)
	{
		return HasIntImpl(Shader.PropertyToID(name));
	}

	public bool HasInteger(int nameID)
	{
		return HasIntImpl(nameID);
	}

	public bool HasTextureImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasTextureImpl_Injected(intPtr, name);
	}

	public bool HasTexture(string name)
	{
		return HasTextureImpl(Shader.PropertyToID(name));
	}

	public bool HasTexture(int nameID)
	{
		return HasTextureImpl(nameID);
	}

	public bool HasMatrixImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasMatrixImpl_Injected(intPtr, name);
	}

	public bool HasMatrix(string name)
	{
		return HasMatrixImpl(Shader.PropertyToID(name));
	}

	public bool HasMatrix(int nameID)
	{
		return HasMatrixImpl(nameID);
	}

	public bool HasVectorImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasVectorImpl_Injected(intPtr, name);
	}

	public bool HasVector(string name)
	{
		return HasVectorImpl(Shader.PropertyToID(name));
	}

	public bool HasVector(int nameID)
	{
		return HasVectorImpl(nameID);
	}

	public bool HasColor(string name)
	{
		return HasVectorImpl(Shader.PropertyToID(name));
	}

	public bool HasColor(int nameID)
	{
		return HasVectorImpl(nameID);
	}

	public bool HasBufferImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasBufferImpl_Injected(intPtr, name);
	}

	public bool HasBuffer(string name)
	{
		return HasBufferImpl(Shader.PropertyToID(name));
	}

	public bool HasBuffer(int nameID)
	{
		return HasBufferImpl(nameID);
	}

	public bool HasConstantBufferImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasConstantBufferImpl_Injected(intPtr, name);
	}

	public bool HasConstantBuffer(string name)
	{
		return HasConstantBufferImpl(Shader.PropertyToID(name));
	}

	public bool HasConstantBuffer(int nameID)
	{
		return HasConstantBufferImpl(nameID);
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

	public void SetKeyword([In] ref LocalKeyword keyword, bool value)
	{
		SetLocalKeyword(keyword, value);
	}

	public bool IsKeywordEnabled([In] ref LocalKeyword keyword)
	{
		return IsLocalKeywordEnabled(keyword);
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

	public unsafe void SetShaderPassEnabled(string passName, bool enabled)
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
			if (!StringMarshaller.TryMarshalEmptyOrNullString(passName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(passName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetShaderPassEnabled_Injected(intPtr, ref managedSpanWrapper, enabled);
					return;
				}
			}
			SetShaderPassEnabled_Injected(intPtr, ref managedSpanWrapper, enabled);
		}
		finally
		{
		}
	}

	public unsafe bool GetShaderPassEnabled(string passName)
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
			if (!StringMarshaller.TryMarshalEmptyOrNullString(passName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(passName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetShaderPassEnabled_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return GetShaderPassEnabled_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public string GetPassName(int pass)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetPassName_Injected(intPtr, pass, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe void SetOverrideTag(string tag, string val)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//IL_0062: Expected O, but got Ref
		//The blocks IL_0039, IL_0046, IL_0054, IL_0062, IL_0067 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0067 are reachable both inside and outside the pinned region starting at IL_0054. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0067 are reachable both inside and outside the pinned region starting at IL_0054. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper tag2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(tag, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(tag);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					tag2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(val, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(val);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							SetOverrideTag_Injected(intPtr, ref tag2, ref managedSpanWrapper2);
							return;
						}
					}
					SetOverrideTag_Injected(intPtr, ref tag2, ref managedSpanWrapper2);
					return;
				}
			}
			tag2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(val, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(val);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					SetOverrideTag_Injected(intPtr, ref tag2, ref managedSpanWrapper2);
					return;
				}
			}
			SetOverrideTag_Injected(intPtr, ref tag2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//IL_0055: Expected O, but got Ref
		//IL_0063: Expected O, but got Ref
		//The blocks IL_0039, IL_0047, IL_0055, IL_0063, IL_0068 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0068 are reachable both inside and outside the pinned region starting at IL_0055. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0068 are reachable both inside and outside the pinned region starting at IL_0055. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper tag2;
			bool currentSubShaderOnly2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(tag, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(tag);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					tag2 = ref managedSpanWrapper;
					currentSubShaderOnly2 = currentSubShaderOnly;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(defaultValue, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(defaultValue);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							GetTagImpl_Injected(intPtr, ref tag2, currentSubShaderOnly2, ref managedSpanWrapper2, out ret);
						}
					}
					else
					{
						GetTagImpl_Injected(intPtr, ref tag2, currentSubShaderOnly2, ref managedSpanWrapper2, out ret);
					}
				}
			}
			else
			{
				tag2 = ref managedSpanWrapper;
				currentSubShaderOnly2 = currentSubShaderOnly;
				if (!StringMarshaller.TryMarshalEmptyOrNullString(defaultValue, ref managedSpanWrapper2))
				{
					readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(defaultValue);
					fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
					{
						managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
						GetTagImpl_Injected(intPtr, ref tag2, currentSubShaderOnly2, ref managedSpanWrapper2, out ret);
					}
				}
				else
				{
					GetTagImpl_Injected(intPtr, ref tag2, currentSubShaderOnly2, ref managedSpanWrapper2, out ret);
				}
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public string GetTag(string tag, bool searchFallbacks, string defaultValue)
	{
		return GetTagImpl(tag, !searchFallbacks, defaultValue);
	}

	public string GetTag(string tag, bool searchFallbacks)
	{
		return GetTagImpl(tag, !searchFallbacks, "");
	}

	public void Lerp(Material start, Material end, float t)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Lerp_Injected(intPtr, MarshalledUnityObject.Marshal(start), MarshalledUnityObject.Marshal(end), t);
	}

	public void CopyMatchingPropertiesFromMaterial(Material mat)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CopyMatchingPropertiesFromMaterial_Injected(intPtr, MarshalledUnityObject.Marshal(mat));
	}

	public Il2CppStringArray GetPropertyNamesImpl(int propertyType)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPropertyNamesImpl_Injected(intPtr, propertyType);
	}

	public Il2CppStringArray GetTexturePropertyNames()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTexturePropertyNames_Injected(intPtr);
	}

	public unsafe Il2CppStructArray<int> GetTexturePropertyNameIDs()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetTexturePropertyNameIDs_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public void GetTexturePropertyNamesInternal(Il2CppSystem.Object outNames)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetTexturePropertyNamesInternal_Injected(intPtr, outNames);
	}

	public void GetTexturePropertyNameIDsInternal(Il2CppSystem.Object outNames)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetTexturePropertyNameIDsInternal_Injected(intPtr, outNames);
	}

	public void GetTexturePropertyNames(List<string> outNames)
	{
		if (outNames == null)
		{
			throw new Il2CppSystem.ArgumentNullException("outNames");
		}
		GetTexturePropertyNamesInternal(outNames);
	}

	public void GetTexturePropertyNameIDs(List<int> outNames)
	{
		if (outNames == null)
		{
			throw new Il2CppSystem.ArgumentNullException("outNames");
		}
		GetTexturePropertyNameIDsInternal(outNames);
	}

	public void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetRenderTextureImpl_Injected(intPtr, name, MarshalledUnityObject.Marshal(value), element);
	}

	public void SetBufferImpl(int name, ComputeBuffer value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetBufferImpl_Injected(intPtr, name, (value == null) ? ((System.IntPtr)0) : ComputeBuffer.BindingsMarshaller.ConvertToNative(value));
	}

	public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetConstantGraphicsBufferImpl_Injected(intPtr, name, (value == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(value), offset, size);
	}

	public int GetIntImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetIntImpl_Injected(intPtr, name);
	}

	public Matrix4x4 GetMatrixImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetMatrixImpl_Injected(intPtr, name, out var ret);
		return ret;
	}

	public GraphicsBufferHandle GetBufferImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetBufferImpl_Injected(intPtr, name, out var ret);
		return ret;
	}

	public GraphicsBufferHandle GetConstantBufferImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetConstantBufferImpl_Injected(intPtr, name, out var ret);
		return ret;
	}

	public unsafe void SetColorArrayImpl(int name, Il2CppStructArray<Color> values, int count)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Color> span);
		((Il2CppSystem.Span<Color>)(&span))._002Ector((Il2CppArrayBase<Color>)(object)values);
		fixed (Color* begin = &((Il2CppSystem.Span<Color>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper values2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Color>)(&span)).Length);
			SetColorArrayImpl_Injected(intPtr, name, ref values2, count);
		}
	}

	public unsafe Il2CppStructArray<float> GetFloatArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<float> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetFloatArrayImpl_Injected(intPtr, name, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<float> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<float>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Vector4> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetVectorArrayImpl_Injected(intPtr, name, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Vector4> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Vector4>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe Il2CppStructArray<Color> GetColorArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Color> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetColorArrayImpl_Injected(intPtr, name, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Color> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Color>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Matrix4x4> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetMatrixArrayImpl_Injected(intPtr, name, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Matrix4x4> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Matrix4x4>*)(&array));
			result = array;
		}
		return result;
	}

	public int GetFloatArrayCountImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetFloatArrayCountImpl_Injected(intPtr, name);
	}

	public int GetVectorArrayCountImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetVectorArrayCountImpl_Injected(intPtr, name);
	}

	public int GetColorArrayCountImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetColorArrayCountImpl_Injected(intPtr, name);
	}

	public int GetMatrixArrayCountImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetMatrixArrayCountImpl_Injected(intPtr, name);
	}

	public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ExtractColorArrayImpl(int name, [Out] Il2CppStructArray<Color> val)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Vector4 GetTextureScaleAndOffsetImpl(int name)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetTextureScaleAndOffsetImpl_Injected(intPtr, name, out var ret);
		return ret;
	}

	public void SetTextureScaleImpl(int name, Vector2 scale)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetTextureScaleImpl_Injected(intPtr, name, ref scale);
	}

	public void SetColorArray(int name, Il2CppStructArray<Color> values, int count)
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
		SetColorArrayImpl(name, values, count);
	}

	public void ExtractFloatArray(int name, List<float> values)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		values.Clear();
		int floatArrayCountImpl = GetFloatArrayCountImpl(name);
		if (floatArrayCountImpl > 0)
		{
			NoAllocHelpers.EnsureListElemCount(values, floatArrayCountImpl);
			ExtractFloatArrayImpl(name, (Il2CppStructArray<float>)(object)NoAllocHelpers.ExtractArrayFromList(values));
		}
	}

	public void ExtractVectorArray(int name, List<Vector4> values)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		values.Clear();
		int vectorArrayCountImpl = GetVectorArrayCountImpl(name);
		if (vectorArrayCountImpl > 0)
		{
			NoAllocHelpers.EnsureListElemCount(values, vectorArrayCountImpl);
			ExtractVectorArrayImpl(name, (Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(values));
		}
	}

	public void ExtractColorArray(int name, List<Color> values)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		values.Clear();
		int colorArrayCountImpl = GetColorArrayCountImpl(name);
		if (colorArrayCountImpl > 0)
		{
			NoAllocHelpers.EnsureListElemCount(values, colorArrayCountImpl);
			ExtractColorArrayImpl(name, (Il2CppStructArray<Color>)(object)NoAllocHelpers.ExtractArrayFromList(values));
		}
	}

	public void ExtractMatrixArray(int name, List<Matrix4x4> values)
	{
		if (values == null)
		{
			throw new Il2CppSystem.ArgumentNullException("values");
		}
		values.Clear();
		int matrixArrayCountImpl = GetMatrixArrayCountImpl(name);
		if (matrixArrayCountImpl > 0)
		{
			NoAllocHelpers.EnsureListElemCount(values, matrixArrayCountImpl);
			ExtractMatrixArrayImpl(name, (Il2CppStructArray<Matrix4x4>)(object)NoAllocHelpers.ExtractArrayFromList(values));
		}
	}

	public void SetInteger(string name, int value)
	{
		SetIntImpl(Shader.PropertyToID(name), value);
	}

	public void SetMatrix(string name, Matrix4x4 value)
	{
		SetMatrixImpl(Shader.PropertyToID(name), value);
	}

	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element)
	{
		SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
	}

	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element)
	{
		SetRenderTextureImpl(nameID, value, element);
	}

	public void SetBuffer(string name, ComputeBuffer value)
	{
		SetBufferImpl(Shader.PropertyToID(name), value);
	}

	public void SetBuffer(int nameID, ComputeBuffer value)
	{
		SetBufferImpl(nameID, value);
	}

	public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
	{
		SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
	}

	public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
	{
		SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
	}

	public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
	{
		SetConstantGraphicsBufferImpl(nameID, value, offset, size);
	}

	public void SetFloatArray(string name, List<float> values)
	{
		SetFloatArray(Shader.PropertyToID(name), (Il2CppStructArray<float>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public void SetFloatArray(int nameID, List<float> values)
	{
		SetFloatArray(nameID, (Il2CppStructArray<float>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public void SetFloatArray(string name, Il2CppStructArray<float> values)
	{
		SetFloatArray(Shader.PropertyToID(name), values, ((Il2CppArrayBase)values).Length);
	}

	public void SetColorArray(string name, List<Color> values)
	{
		SetColorArray(Shader.PropertyToID(name), (Il2CppStructArray<Color>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public void SetColorArray(int nameID, List<Color> values)
	{
		SetColorArray(nameID, (Il2CppStructArray<Color>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public void SetColorArray(string name, Il2CppStructArray<Color> values)
	{
		SetColorArray(Shader.PropertyToID(name), values, ((Il2CppArrayBase)values).Length);
	}

	public void SetColorArray(int nameID, Il2CppStructArray<Color> values)
	{
		SetColorArray(nameID, values, ((Il2CppArrayBase)values).Length);
	}

	public void SetVectorArray(string name, List<Vector4> values)
	{
		SetVectorArray(Shader.PropertyToID(name), (Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public void SetVectorArray(int nameID, List<Vector4> values)
	{
		SetVectorArray(nameID, (Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public void SetMatrixArray(string name, List<Matrix4x4> values)
	{
		SetMatrixArray(Shader.PropertyToID(name), (Il2CppStructArray<Matrix4x4>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public void SetMatrixArray(int nameID, List<Matrix4x4> values)
	{
		SetMatrixArray(nameID, (Il2CppStructArray<Matrix4x4>)(object)NoAllocHelpers.ExtractArrayFromList(values), values.Count);
	}

	public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
	{
		SetMatrixArray(Shader.PropertyToID(name), values, ((Il2CppArrayBase)values).Length);
	}

	public int GetInt(int nameID)
	{
		return (int)GetFloatImpl(nameID);
	}

	public int GetInteger(string name)
	{
		return GetIntImpl(Shader.PropertyToID(name));
	}

	public int GetInteger(int nameID)
	{
		return GetIntImpl(nameID);
	}

	public Vector4 GetVector(string name)
	{
		return GetColorImpl(Shader.PropertyToID(name));
	}

	public Matrix4x4 GetMatrix(string name)
	{
		return GetMatrixImpl(Shader.PropertyToID(name));
	}

	public Matrix4x4 GetMatrix(int nameID)
	{
		return GetMatrixImpl(nameID);
	}

	public GraphicsBufferHandle GetBuffer(string name)
	{
		return GetBufferImpl(Shader.PropertyToID(name));
	}

	public GraphicsBufferHandle GetConstantBuffer(string name)
	{
		return GetConstantBufferImpl(Shader.PropertyToID(name));
	}

	public Il2CppStructArray<float> GetFloatArray(string name)
	{
		return GetFloatArray(Shader.PropertyToID(name));
	}

	public Il2CppStructArray<float> GetFloatArray(int nameID)
	{
		return (GetFloatArrayCountImpl(nameID) != 0) ? GetFloatArrayImpl(nameID) : null;
	}

	public Il2CppStructArray<Color> GetColorArray(string name)
	{
		return GetColorArray(Shader.PropertyToID(name));
	}

	public Il2CppStructArray<Color> GetColorArray(int nameID)
	{
		return (GetColorArrayCountImpl(nameID) != 0) ? GetColorArrayImpl(nameID) : null;
	}

	public Il2CppStructArray<Vector4> GetVectorArray(string name)
	{
		return GetVectorArray(Shader.PropertyToID(name));
	}

	public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
	{
		return (GetVectorArrayCountImpl(nameID) != 0) ? GetVectorArrayImpl(nameID) : null;
	}

	public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
	{
		return GetMatrixArray(Shader.PropertyToID(name));
	}

	public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
	{
		return (GetMatrixArrayCountImpl(nameID) != 0) ? GetMatrixArrayImpl(nameID) : null;
	}

	public void GetFloatArray(string name, List<float> values)
	{
		ExtractFloatArray(Shader.PropertyToID(name), values);
	}

	public void GetFloatArray(int nameID, List<float> values)
	{
		ExtractFloatArray(nameID, values);
	}

	public void GetColorArray(string name, List<Color> values)
	{
		ExtractColorArray(Shader.PropertyToID(name), values);
	}

	public void GetColorArray(int nameID, List<Color> values)
	{
		ExtractColorArray(nameID, values);
	}

	public void GetVectorArray(string name, List<Vector4> values)
	{
		ExtractVectorArray(Shader.PropertyToID(name), values);
	}

	public void GetVectorArray(int nameID, List<Vector4> values)
	{
		ExtractVectorArray(nameID, values);
	}

	public void GetMatrixArray(string name, List<Matrix4x4> values)
	{
		ExtractMatrixArray(Shader.PropertyToID(name), values);
	}

	public void GetMatrixArray(int nameID, List<Matrix4x4> values)
	{
		ExtractMatrixArray(nameID, values);
	}

	public void SetTextureOffset(string name, Vector2 value)
	{
		SetTextureOffsetImpl(Shader.PropertyToID(name), value);
	}

	public void SetTextureScale(string name, Vector2 value)
	{
		SetTextureScaleImpl(Shader.PropertyToID(name), value);
	}

	public void SetTextureScale(int nameID, Vector2 value)
	{
		SetTextureScaleImpl(nameID, value);
	}

	public Vector2 GetTextureOffset(string name)
	{
		return GetTextureOffset(Shader.PropertyToID(name));
	}

	public Vector2 GetTextureOffset(int nameID)
	{
		Vector4 textureScaleAndOffsetImpl = GetTextureScaleAndOffsetImpl(nameID);
		return new Vector2(textureScaleAndOffsetImpl.z, textureScaleAndOffsetImpl.w);
	}

	public Vector2 GetTextureScale(string name)
	{
		return GetTextureScale(Shader.PropertyToID(name));
	}

	public Vector2 GetTextureScale(int nameID)
	{
		Vector4 textureScaleAndOffsetImpl = GetTextureScaleAndOffsetImpl(nameID);
		return new Vector2(textureScaleAndOffsetImpl.x, textureScaleAndOffsetImpl.y);
	}

	public Il2CppStringArray GetPropertyNames(MaterialPropertyType type)
	{
		return GetPropertyNamesImpl((int)type);
	}

	public static System.IntPtr GetDefaultMaterial_Injected()
	{
		return GetDefaultMaterial_InjectedDelegateField();
	}

	public static System.IntPtr GetDefaultParticleMaterial_Injected()
	{
		return GetDefaultParticleMaterial_InjectedDelegateField();
	}

	public static System.IntPtr GetDefaultLineMaterial_Injected()
	{
		return GetDefaultLineMaterial_InjectedDelegateField();
	}

	public static bool HasIntImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return HasIntImpl_InjectedDelegateField(_unity_self, name);
	}

	public static bool HasTextureImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return HasTextureImpl_InjectedDelegateField(_unity_self, name);
	}

	public static bool HasMatrixImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return HasMatrixImpl_InjectedDelegateField(_unity_self, name);
	}

	public static bool HasVectorImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return HasVectorImpl_InjectedDelegateField(_unity_self, name);
	}

	public static bool HasBufferImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return HasBufferImpl_InjectedDelegateField(_unity_self, name);
	}

	public static bool HasConstantBufferImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return HasConstantBufferImpl_InjectedDelegateField(_unity_self, name);
	}

	public static int get_rawRenderQueue_Injected(System.IntPtr _unity_self)
	{
		return get_rawRenderQueue_InjectedDelegateField(_unity_self);
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

	public static Il2CppReferenceArray<LocalKeyword> GetEnabledKeywords_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetEnabledKeywords_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(intPtr) : null;
	}

	public static MaterialGlobalIlluminationFlags get_globalIlluminationFlags_Injected(System.IntPtr _unity_self)
	{
		return get_globalIlluminationFlags_InjectedDelegateField(_unity_self);
	}

	public static void set_globalIlluminationFlags_Injected(System.IntPtr _unity_self, MaterialGlobalIlluminationFlags value)
	{
		set_globalIlluminationFlags_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_doubleSidedGI_Injected(System.IntPtr _unity_self)
	{
		return get_doubleSidedGI_InjectedDelegateField(_unity_self);
	}

	public static void set_doubleSidedGI_Injected(System.IntPtr _unity_self, bool value)
	{
		set_doubleSidedGI_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void SetShaderPassEnabled_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper passName, bool enabled)
	{
		SetShaderPassEnabled_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref passName), enabled);
	}

	public unsafe static bool GetShaderPassEnabled_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper passName)
	{
		return GetShaderPassEnabled_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref passName));
	}

	public unsafe static void GetPassName_Injected(System.IntPtr _unity_self, int pass, out ManagedSpanWrapper ret)
	{
		GetPassName_InjectedDelegateField(_unity_self, pass, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetOverrideTag_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper tag, ref ManagedSpanWrapper val)
	{
		SetOverrideTag_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref tag), (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void GetTagImpl_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper tag, bool currentSubShaderOnly, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret)
	{
		GetTagImpl_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref tag), currentSubShaderOnly, (nint)Unsafe.AsPointer(ref defaultValue), (nint)Unsafe.AsPointer(ref ret));
	}

	public static void Lerp_Injected(System.IntPtr _unity_self, System.IntPtr start, System.IntPtr end, float t)
	{
		Lerp_InjectedDelegateField(_unity_self, start, end, t);
	}

	public static void CopyMatchingPropertiesFromMaterial_Injected(System.IntPtr _unity_self, System.IntPtr mat)
	{
		CopyMatchingPropertiesFromMaterial_InjectedDelegateField(_unity_self, mat);
	}

	public static Il2CppStringArray GetPropertyNamesImpl_Injected(System.IntPtr _unity_self, int propertyType)
	{
		System.IntPtr intPtr = GetPropertyNamesImpl_InjectedDelegateField(_unity_self, propertyType);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppStringArray GetTexturePropertyNames_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetTexturePropertyNames_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static void GetTexturePropertyNameIDs_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		GetTexturePropertyNameIDs_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void GetTexturePropertyNamesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object outNames)
	{
		GetTexturePropertyNamesInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outNames));
	}

	public static void GetTexturePropertyNameIDsInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object outNames)
	{
		GetTexturePropertyNameIDsInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outNames));
	}

	public static void SetRenderTextureImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value, RenderTextureSubElement element)
	{
		SetRenderTextureImpl_InjectedDelegateField(_unity_self, name, value, element);
	}

	public static void SetBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value)
	{
		SetBufferImpl_InjectedDelegateField(_unity_self, name, value);
	}

	public static void SetConstantGraphicsBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value, int offset, int size)
	{
		SetConstantGraphicsBufferImpl_InjectedDelegateField(_unity_self, name, value, offset, size);
	}

	public static int GetIntImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return GetIntImpl_InjectedDelegateField(_unity_self, name);
	}

	public unsafe static void GetMatrixImpl_Injected(System.IntPtr _unity_self, int name, out Matrix4x4 ret)
	{
		GetMatrixImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetBufferImpl_Injected(System.IntPtr _unity_self, int name, out GraphicsBufferHandle ret)
	{
		GetBufferImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetConstantBufferImpl_Injected(System.IntPtr _unity_self, int name, out GraphicsBufferHandle ret)
	{
		GetConstantBufferImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetColorArrayImpl_Injected(System.IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count)
	{
		SetColorArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref values), count);
	}

	public unsafe static void GetFloatArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper ret)
	{
		GetFloatArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetVectorArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper ret)
	{
		GetVectorArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetColorArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper ret)
	{
		GetColorArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetMatrixArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper ret)
	{
		GetMatrixArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public static int GetFloatArrayCountImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return GetFloatArrayCountImpl_InjectedDelegateField(_unity_self, name);
	}

	public static int GetVectorArrayCountImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return GetVectorArrayCountImpl_InjectedDelegateField(_unity_self, name);
	}

	public static int GetColorArrayCountImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return GetColorArrayCountImpl_InjectedDelegateField(_unity_self, name);
	}

	public static int GetMatrixArrayCountImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return GetMatrixArrayCountImpl_InjectedDelegateField(_unity_self, name);
	}

	public unsafe static void ExtractFloatArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper val)
	{
		ExtractFloatArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void ExtractVectorArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper val)
	{
		ExtractVectorArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void ExtractColorArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper val)
	{
		ExtractColorArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void ExtractMatrixArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper val)
	{
		ExtractMatrixArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void GetTextureScaleAndOffsetImpl_Injected(System.IntPtr _unity_self, int name, out Vector4 ret)
	{
		GetTextureScaleAndOffsetImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetTextureScaleImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Vector2 scale)
	{
		SetTextureScaleImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref scale));
	}
}
