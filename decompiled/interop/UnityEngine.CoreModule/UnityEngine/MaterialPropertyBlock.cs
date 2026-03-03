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

public sealed class MaterialPropertyBlock : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_MaterialPropertyBlock_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100664560);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(MaterialPropertyBlock materialPropertyBlock)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertyBlock);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_MaterialPropertyBlock_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate int GetIntImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate float GetFloatImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate void GetColorImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void GetMatrixImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate bool HasPropertyImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasFloatImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasIntImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasTextureImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasMatrixImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasVectorImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate bool HasConstantBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate void SetColorImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [In] System.IntPtr value);

	private delegate void SetGraphicsBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name, System.IntPtr value);

	private delegate void SetConstantGraphicsBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name, System.IntPtr value, int offset, int size);

	private delegate void GetFloatArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void GetVectorArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate void GetMatrixArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

	private delegate int GetFloatArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate int GetVectorArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate int GetMatrixArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

	private delegate void ExtractFloatArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr val);

	private delegate void ExtractVectorArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr val);

	private delegate void ExtractMatrixArrayImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr val);

	private delegate void Internal_CopySHCoefficientArraysFrom_InjectedDelegate(System.IntPtr properties, System.IntPtr lightProbes, int sourceStart, int destStart, int count);

	private delegate void Internal_CopyProbeOcclusionArrayFrom_InjectedDelegate(System.IntPtr properties, System.IntPtr occlusionProbes, int sourceStart, int destStart, int count);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVectorImpl_Private_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureImpl_Injected_Private_Static_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIntImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatImpl_Injected_Private_Static_Void_IntPtr_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_RenderTextureSubElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrixArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly GetIntImpl_InjectedDelegate GetIntImpl_InjectedDelegateField;

	private static readonly GetFloatImpl_InjectedDelegate GetFloatImpl_InjectedDelegateField;

	private static readonly GetColorImpl_InjectedDelegate GetColorImpl_InjectedDelegateField;

	private static readonly GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;

	private static readonly HasPropertyImpl_InjectedDelegate HasPropertyImpl_InjectedDelegateField;

	private static readonly HasFloatImpl_InjectedDelegate HasFloatImpl_InjectedDelegateField;

	private static readonly HasIntImpl_InjectedDelegate HasIntImpl_InjectedDelegateField;

	private static readonly HasTextureImpl_InjectedDelegate HasTextureImpl_InjectedDelegateField;

	private static readonly HasMatrixImpl_InjectedDelegate HasMatrixImpl_InjectedDelegateField;

	private static readonly HasVectorImpl_InjectedDelegate HasVectorImpl_InjectedDelegateField;

	private static readonly HasBufferImpl_InjectedDelegate HasBufferImpl_InjectedDelegateField;

	private static readonly HasConstantBufferImpl_InjectedDelegate HasConstantBufferImpl_InjectedDelegateField;

	private static readonly SetColorImpl_InjectedDelegate SetColorImpl_InjectedDelegateField;

	private static readonly SetGraphicsBufferImpl_InjectedDelegate SetGraphicsBufferImpl_InjectedDelegateField;

	private static readonly SetConstantGraphicsBufferImpl_InjectedDelegate SetConstantGraphicsBufferImpl_InjectedDelegateField;

	private static readonly GetFloatArrayImpl_InjectedDelegate GetFloatArrayImpl_InjectedDelegateField;

	private static readonly GetVectorArrayImpl_InjectedDelegate GetVectorArrayImpl_InjectedDelegateField;

	private static readonly GetMatrixArrayImpl_InjectedDelegate GetMatrixArrayImpl_InjectedDelegateField;

	private static readonly GetFloatArrayCountImpl_InjectedDelegate GetFloatArrayCountImpl_InjectedDelegateField;

	private static readonly GetVectorArrayCountImpl_InjectedDelegate GetVectorArrayCountImpl_InjectedDelegateField;

	private static readonly GetMatrixArrayCountImpl_InjectedDelegate GetMatrixArrayCountImpl_InjectedDelegateField;

	private static readonly ExtractFloatArrayImpl_InjectedDelegate ExtractFloatArrayImpl_InjectedDelegateField;

	private static readonly ExtractVectorArrayImpl_InjectedDelegate ExtractVectorArrayImpl_InjectedDelegateField;

	private static readonly ExtractMatrixArrayImpl_InjectedDelegate ExtractMatrixArrayImpl_InjectedDelegateField;

	private static readonly Internal_CopySHCoefficientArraysFrom_InjectedDelegate Internal_CopySHCoefficientArraysFrom_InjectedDelegateField;

	private static readonly Internal_CopyProbeOcclusionArrayFrom_InjectedDelegate Internal_CopyProbeOcclusionArrayFrom_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe bool isEmpty
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173818, RefRangeEnd = 1173819, XrefRangeStart = 1173804, XrefRangeEnd = 1173818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MaterialPropertyBlock()
	{
		Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MaterialPropertyBlock");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr_GetVectorImpl_Private_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664501);
		NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664502);
		NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664503);
		NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664504);
		NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664505);
		NativeMethodInfoPtr_SetMatrixImpl_Private_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664506);
		NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664507);
		NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664508);
		NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664509);
		NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664510);
		NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664511);
		NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664512);
		NativeMethodInfoPtr_SetMatrixArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664513);
		NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664514);
		NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664515);
		NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664516);
		NativeMethodInfoPtr_Clear_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664517);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664518);
		NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664519);
		NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664520);
		NativeMethodInfoPtr_SetMatrixArray_Private_Void_Int32_Il2CppStructArray_1_Matrix4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664522);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664523);
		NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664524);
		NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664525);
		NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664526);
		NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664527);
		NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664528);
		NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664529);
		NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664530);
		NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664531);
		NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664532);
		NativeMethodInfoPtr_SetMatrix_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664533);
		NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664541);
		NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr_GetVector_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr_GetTexture_Public_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664544);
		NativeMethodInfoPtr_GetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664545);
		NativeMethodInfoPtr_GetTextureImpl_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664546);
		NativeMethodInfoPtr_SetIntImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664547);
		NativeMethodInfoPtr_SetFloatImpl_Injected_Private_Static_Void_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr_SetMatrixImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr_SetTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr_SetRenderTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664552);
		NativeMethodInfoPtr_SetBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr_SetConstantBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664554);
		NativeMethodInfoPtr_SetFloatArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664555);
		NativeMethodInfoPtr_SetVectorArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664556);
		NativeMethodInfoPtr_SetMatrixArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_get_isEmpty_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664558);
		NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100664559);
		GetIntImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetIntImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetIntImpl_Injected");
		GetFloatImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetFloatImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatImpl_Injected");
		GetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetColorImpl_Injected");
		GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixImpl_Injected");
		HasPropertyImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasPropertyImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasPropertyImpl_Injected");
		HasFloatImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasFloatImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasFloatImpl_Injected");
		HasIntImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasIntImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasIntImpl_Injected");
		HasTextureImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasTextureImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasTextureImpl_Injected");
		HasMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasMatrixImpl_Injected");
		HasVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasVectorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasVectorImpl_Injected");
		HasBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasBufferImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasBufferImpl_Injected");
		HasConstantBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<HasConstantBufferImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasConstantBufferImpl_Injected");
		SetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetColorImpl_Injected");
		SetGraphicsBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetGraphicsBufferImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetGraphicsBufferImpl_Injected");
		SetConstantGraphicsBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<SetConstantGraphicsBufferImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantGraphicsBufferImpl_Injected");
		GetFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetFloatArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayImpl_Injected");
		GetVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetVectorArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayImpl_Injected");
		GetMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetMatrixArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayImpl_Injected");
		GetFloatArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetFloatArrayCountImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayCountImpl_Injected");
		GetVectorArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetVectorArrayCountImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayCountImpl_Injected");
		GetMatrixArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetMatrixArrayCountImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayCountImpl_Injected");
		ExtractFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractFloatArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::ExtractFloatArrayImpl_Injected");
		ExtractVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractVectorArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::ExtractVectorArrayImpl_Injected");
		ExtractMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<ExtractMatrixArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::ExtractMatrixArrayImpl_Injected");
		Internal_CopySHCoefficientArraysFrom_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CopySHCoefficientArraysFrom_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopySHCoefficientArraysFrom_Injected");
		Internal_CopyProbeOcclusionArrayFrom_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CopyProbeOcclusionArrayFrom_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopyProbeOcclusionArrayFrom_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173672, XrefRangeEnd = 1173675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 GetVectorImpl(int name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVectorImpl_Private_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173682, RefRangeEnd = 1173683, XrefRangeStart = 1173675, XrefRangeEnd = 1173682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1173687, RefRangeEnd = 1173690, XrefRangeStart = 1173683, XrefRangeEnd = 1173687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1173694, RefRangeEnd = 1173714, XrefRangeStart = 1173690, XrefRangeEnd = 1173694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173714, XrefRangeEnd = 1173717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVectorImpl(int name, Vector4 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173717, XrefRangeEnd = 1173720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1173730, RefRangeEnd = 1173750, XrefRangeStart = 1173720, XrefRangeEnd = 1173730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173760, RefRangeEnd = 1173761, XrefRangeStart = 1173750, XrefRangeEnd = 1173760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(RenderTextureSubElement**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173761, XrefRangeEnd = 1173765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBufferImpl(int name, ComputeBuffer value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173769, RefRangeEnd = 1173770, XrefRangeStart = 1173765, XrefRangeEnd = 1173769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173770, XrefRangeEnd = 1173780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173780, XrefRangeEnd = 1173790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173790, XrefRangeEnd = 1173800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173800, XrefRangeEnd = 1173802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateImpl()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173802, XrefRangeEnd = 1173804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyImpl(System.IntPtr mpb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mpb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173819, XrefRangeEnd = 1173823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear(bool keepMemory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keepMemory);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1173827, RefRangeEnd = 1173835, XrefRangeStart = 1173823, XrefRangeEnd = 1173827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173844, RefRangeEnd = 1173845, XrefRangeStart = 1173835, XrefRangeEnd = 1173844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1173854, RefRangeEnd = 1173856, XrefRangeStart = 1173845, XrefRangeEnd = 1173854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1173865, RefRangeEnd = 1173866, XrefRangeStart = 1173856, XrefRangeEnd = 1173865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1173869, RefRangeEnd = 1173879, XrefRangeStart = 1173866, XrefRangeEnd = 1173869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialPropertyBlock()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173879, XrefRangeEnd = 1173888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173888, XrefRangeEnd = 1173894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1173899, RefRangeEnd = 1173907, XrefRangeStart = 1173894, XrefRangeEnd = 1173899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1173911, RefRangeEnd = 1173922, XrefRangeStart = 1173907, XrefRangeEnd = 1173911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1173927, RefRangeEnd = 1173935, XrefRangeStart = 1173922, XrefRangeEnd = 1173927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1173694, RefRangeEnd = 1173714, XrefRangeStart = 1173694, XrefRangeEnd = 1173714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1173687, RefRangeEnd = 1173690, XrefRangeStart = 1173687, XrefRangeEnd = 1173690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1173939, RefRangeEnd = 1173943, XrefRangeStart = 1173935, XrefRangeEnd = 1173939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 1173946, RefRangeEnd = 1173982, XrefRangeStart = 1173943, XrefRangeEnd = 1173946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1173986, RefRangeEnd = 1173988, XrefRangeStart = 1173982, XrefRangeEnd = 1173986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrix(string name, Matrix4x4 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrix_Public_Void_String_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173991, RefRangeEnd = 1173992, XrefRangeStart = 1173988, XrefRangeEnd = 1173991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173997, RefRangeEnd = 1173998, XrefRangeStart = 1173992, XrefRangeEnd = 1173997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBuffer(string name, ComputeBuffer value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1174009, RefRangeEnd = 1174011, XrefRangeStart = 1173998, XrefRangeEnd = 1174009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1173730, RefRangeEnd = 1173750, XrefRangeStart = 1173730, XrefRangeEnd = 1173750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173760, RefRangeEnd = 1173761, XrefRangeStart = 1173760, XrefRangeEnd = 1173761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&nameID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(RenderTextureSubElement**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1173769, RefRangeEnd = 1173770, XrefRangeStart = 1173769, XrefRangeEnd = 1173770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1174013, RefRangeEnd = 1174020, XrefRangeStart = 1174011, XrefRangeEnd = 1174013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloatArray(string name, Il2CppStructArray<float> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1174022, RefRangeEnd = 1174024, XrefRangeStart = 1174020, XrefRangeEnd = 1174022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1174025, RefRangeEnd = 1174026, XrefRangeStart = 1174024, XrefRangeEnd = 1174025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1174028, RefRangeEnd = 1174030, XrefRangeStart = 1174026, XrefRangeEnd = 1174028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrixArray_Public_Void_String_Il2CppStructArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1174033, RefRangeEnd = 1174036, XrefRangeStart = 1174030, XrefRangeEnd = 1174033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1173682, RefRangeEnd = 1173683, XrefRangeStart = 1173682, XrefRangeEnd = 1173683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174036, XrefRangeEnd = 1174038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetVectorImpl_Injected(System.IntPtr _unity_self, int name, out Vector4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174038, XrefRangeEnd = 1174040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174040, XrefRangeEnd = 1174042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174042, XrefRangeEnd = 1174044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174044, XrefRangeEnd = 1174046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVectorImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Vector4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174046, XrefRangeEnd = 1174048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174048, XrefRangeEnd = 1174050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174050, XrefRangeEnd = 1174052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTextureImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value, RenderTextureSubElement element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(RenderTextureSubElement**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_RenderTextureSubElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174052, XrefRangeEnd = 1174054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &name;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174054, XrefRangeEnd = 1174056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174056, XrefRangeEnd = 1174058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174058, XrefRangeEnd = 1174060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174060, XrefRangeEnd = 1174062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174062, XrefRangeEnd = 1174064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isEmpty_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isEmpty_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174064, XrefRangeEnd = 1174066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear_Injected(System.IntPtr _unity_self, bool keepMemory)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keepMemory;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MaterialPropertyBlock(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void AddFloat(string name, float value)
	{
		SetFloat(Shader.PropertyToID(name), value);
	}

	public void AddFloat(int nameID, float value)
	{
		SetFloat(nameID, value);
	}

	public void AddVector(string name, Vector4 value)
	{
		SetVector(Shader.PropertyToID(name), value);
	}

	public void AddVector(int nameID, Vector4 value)
	{
		SetVector(nameID, value);
	}

	public void AddColor(string name, Color value)
	{
		SetColor(Shader.PropertyToID(name), value);
	}

	public void AddColor(int nameID, Color value)
	{
		SetColor(nameID, value);
	}

	public void AddMatrix(string name, Matrix4x4 value)
	{
		SetMatrix(Shader.PropertyToID(name), value);
	}

	public void AddMatrix(int nameID, Matrix4x4 value)
	{
		SetMatrix(nameID, value);
	}

	public void AddTexture(string name, Texture value)
	{
		SetTexture(Shader.PropertyToID(name), value);
	}

	public void AddTexture(int nameID, Texture value)
	{
		SetTexture(nameID, value);
	}

	public int GetIntImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetIntImpl_Injected(intPtr, name);
	}

	public float GetFloatImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetFloatImpl_Injected(intPtr, name);
	}

	public Color GetColorImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetColorImpl_Injected(intPtr, name, out var ret);
		return ret;
	}

	public Matrix4x4 GetMatrixImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetMatrixImpl_Injected(intPtr, name, out var ret);
		return ret;
	}

	public bool HasPropertyImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasPropertyImpl_Injected(intPtr, name);
	}

	public bool HasFloatImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasFloatImpl_Injected(intPtr, name);
	}

	public bool HasIntImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasIntImpl_Injected(intPtr, name);
	}

	public bool HasTextureImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasTextureImpl_Injected(intPtr, name);
	}

	public bool HasMatrixImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasMatrixImpl_Injected(intPtr, name);
	}

	public bool HasVectorImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasVectorImpl_Injected(intPtr, name);
	}

	public bool HasBufferImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasBufferImpl_Injected(intPtr, name);
	}

	public bool HasConstantBufferImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasConstantBufferImpl_Injected(intPtr, name);
	}

	public void SetColorImpl(int name, Color value)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetColorImpl_Injected(intPtr, name, ref value);
	}

	public void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetGraphicsBufferImpl_Injected(intPtr, name, (value == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(value));
	}

	public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetConstantGraphicsBufferImpl_Injected(intPtr, name, (value == null) ? ((System.IntPtr)0) : GraphicsBuffer.BindingsMarshaller.ConvertToNative(value), offset, size);
	}

	public unsafe Il2CppStructArray<float> GetFloatArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<float> result;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
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
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
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

	public unsafe Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Matrix4x4> result;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
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
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetFloatArrayCountImpl_Injected(intPtr, name);
	}

	public int GetVectorArrayCountImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetVectorArrayCountImpl_Injected(intPtr, name);
	}

	public int GetMatrixArrayCountImpl(int name)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
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

	public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, Il2CppStructArray<SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
	{
		//IL_0017: Expected O, but got Ref
		//IL_001e: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		System.IntPtr properties2 = ((properties == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(properties));
		Unsafe.SkipInit(out Il2CppSystem.Span<SphericalHarmonicsL2> span);
		((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span))._002Ector((Il2CppArrayBase<SphericalHarmonicsL2>)(object)lightProbes);
		fixed (SphericalHarmonicsL2* begin = &((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper lightProbes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<SphericalHarmonicsL2>)(&span)).Length);
			Internal_CopySHCoefficientArraysFrom_Injected(properties2, ref lightProbes2, sourceStart, destStart, count);
		}
	}

	public unsafe static void Internal_CopyProbeOcclusionArrayFrom(MaterialPropertyBlock properties, Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
	{
		//IL_0017: Expected O, but got Ref
		//IL_001e: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		System.IntPtr properties2 = ((properties == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(properties));
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector4> span);
		((Il2CppSystem.Span<Vector4>)(&span))._002Ector((Il2CppArrayBase<Vector4>)(object)occlusionProbes);
		fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper occlusionProbes2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector4>)(&span)).Length);
			Internal_CopyProbeOcclusionArrayFrom_Injected(properties2, ref occlusionProbes2, sourceStart, destStart, count);
		}
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

	public void SetColor(string name, Color value)
	{
		SetColorImpl(Shader.PropertyToID(name), value);
	}

	public void SetColor(int nameID, Color value)
	{
		SetColorImpl(nameID, value);
	}

	public void SetBuffer(int nameID, ComputeBuffer value)
	{
		SetBufferImpl(nameID, value);
	}

	public void SetBuffer(string name, GraphicsBuffer value)
	{
		SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
	}

	public void SetBuffer(int nameID, GraphicsBuffer value)
	{
		SetGraphicsBufferImpl(nameID, value);
	}

	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element)
	{
		SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
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

	public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
	{
		SetFloatArray(nameID, values, ((Il2CppArrayBase)values).Length);
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

	public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
	{
		SetMatrixArray(nameID, values, ((Il2CppArrayBase)values).Length);
	}

	public bool HasProperty(string name)
	{
		return HasPropertyImpl(Shader.PropertyToID(name));
	}

	public bool HasProperty(int nameID)
	{
		return HasPropertyImpl(nameID);
	}

	public bool HasInt(string name)
	{
		return HasFloatImpl(Shader.PropertyToID(name));
	}

	public bool HasInt(int nameID)
	{
		return HasFloatImpl(nameID);
	}

	public bool HasFloat(string name)
	{
		return HasFloatImpl(Shader.PropertyToID(name));
	}

	public bool HasFloat(int nameID)
	{
		return HasFloatImpl(nameID);
	}

	public bool HasInteger(string name)
	{
		return HasIntImpl(Shader.PropertyToID(name));
	}

	public bool HasInteger(int nameID)
	{
		return HasIntImpl(nameID);
	}

	public bool HasTexture(string name)
	{
		return HasTextureImpl(Shader.PropertyToID(name));
	}

	public bool HasTexture(int nameID)
	{
		return HasTextureImpl(nameID);
	}

	public bool HasMatrix(string name)
	{
		return HasMatrixImpl(Shader.PropertyToID(name));
	}

	public bool HasMatrix(int nameID)
	{
		return HasMatrixImpl(nameID);
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

	public bool HasBuffer(string name)
	{
		return HasBufferImpl(Shader.PropertyToID(name));
	}

	public bool HasBuffer(int nameID)
	{
		return HasBufferImpl(nameID);
	}

	public bool HasConstantBuffer(string name)
	{
		return HasConstantBufferImpl(Shader.PropertyToID(name));
	}

	public bool HasConstantBuffer(int nameID)
	{
		return HasConstantBufferImpl(nameID);
	}

	public float GetFloat(string name)
	{
		return GetFloatImpl(Shader.PropertyToID(name));
	}

	public float GetFloat(int nameID)
	{
		return GetFloatImpl(nameID);
	}

	public int GetInt(string name)
	{
		return (int)GetFloatImpl(Shader.PropertyToID(name));
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
		return GetVectorImpl(Shader.PropertyToID(name));
	}

	public Color GetColor(string name)
	{
		return GetColorImpl(Shader.PropertyToID(name));
	}

	public Color GetColor(int nameID)
	{
		return GetColorImpl(nameID);
	}

	public Matrix4x4 GetMatrix(string name)
	{
		return GetMatrixImpl(Shader.PropertyToID(name));
	}

	public Matrix4x4 GetMatrix(int nameID)
	{
		return GetMatrixImpl(nameID);
	}

	public Texture GetTexture(string name)
	{
		return GetTextureImpl(Shader.PropertyToID(name));
	}

	public Il2CppStructArray<float> GetFloatArray(string name)
	{
		return GetFloatArray(Shader.PropertyToID(name));
	}

	public Il2CppStructArray<float> GetFloatArray(int nameID)
	{
		return (GetFloatArrayCountImpl(nameID) != 0) ? GetFloatArrayImpl(nameID) : null;
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

	public void CopySHCoefficientArraysFrom(List<SphericalHarmonicsL2> lightProbes)
	{
		if (lightProbes == null)
		{
			throw new Il2CppSystem.ArgumentNullException("lightProbes");
		}
		CopySHCoefficientArraysFrom((Il2CppStructArray<SphericalHarmonicsL2>)(object)NoAllocHelpers.ExtractArrayFromList(lightProbes), 0, 0, lightProbes.Count);
	}

	public void CopySHCoefficientArraysFrom(Il2CppStructArray<SphericalHarmonicsL2> lightProbes)
	{
		if (lightProbes == null)
		{
			throw new Il2CppSystem.ArgumentNullException("lightProbes");
		}
		CopySHCoefficientArraysFrom(lightProbes, 0, 0, ((Il2CppArrayBase)lightProbes).Length);
	}

	public void CopySHCoefficientArraysFrom(List<SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
	{
		CopySHCoefficientArraysFrom((Il2CppStructArray<SphericalHarmonicsL2>)(object)NoAllocHelpers.ExtractArrayFromList(lightProbes), sourceStart, destStart, count);
	}

	public void CopySHCoefficientArraysFrom(Il2CppStructArray<SphericalHarmonicsL2> lightProbes, int sourceStart, int destStart, int count)
	{
		if (lightProbes == null)
		{
			throw new Il2CppSystem.ArgumentNullException("lightProbes");
		}
		if (sourceStart < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("sourceStart", "Argument sourceStart must not be negative.");
		}
		if (destStart < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("sourceStart", "Argument destStart must not be negative.");
		}
		if (count < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("count", "Argument count must not be negative.");
		}
		if (((Il2CppArrayBase)lightProbes).Length < sourceStart + count)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
		}
		Internal_CopySHCoefficientArraysFrom(this, lightProbes, sourceStart, destStart, count);
	}

	public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes)
	{
		if (occlusionProbes == null)
		{
			throw new Il2CppSystem.ArgumentNullException("occlusionProbes");
		}
		CopyProbeOcclusionArrayFrom((Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(occlusionProbes), 0, 0, occlusionProbes.Count);
	}

	public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes)
	{
		if (occlusionProbes == null)
		{
			throw new Il2CppSystem.ArgumentNullException("occlusionProbes");
		}
		CopyProbeOcclusionArrayFrom(occlusionProbes, 0, 0, ((Il2CppArrayBase)occlusionProbes).Length);
	}

	public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
	{
		CopyProbeOcclusionArrayFrom((Il2CppStructArray<Vector4>)(object)NoAllocHelpers.ExtractArrayFromList(occlusionProbes), sourceStart, destStart, count);
	}

	public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
	{
		if (occlusionProbes == null)
		{
			throw new Il2CppSystem.ArgumentNullException("occlusionProbes");
		}
		if (sourceStart < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("sourceStart", "Argument sourceStart must not be negative.");
		}
		if (destStart < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("sourceStart", "Argument destStart must not be negative.");
		}
		if (count < 0)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("count", "Argument count must not be negative.");
		}
		if (((Il2CppArrayBase)occlusionProbes).Length < sourceStart + count)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
		}
		Internal_CopyProbeOcclusionArrayFrom(this, occlusionProbes, sourceStart, destStart, count);
	}

	public static int GetIntImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return GetIntImpl_InjectedDelegateField(_unity_self, name);
	}

	public static float GetFloatImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return GetFloatImpl_InjectedDelegateField(_unity_self, name);
	}

	public unsafe static void GetColorImpl_Injected(System.IntPtr _unity_self, int name, out Color ret)
	{
		GetColorImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetMatrixImpl_Injected(System.IntPtr _unity_self, int name, out Matrix4x4 ret)
	{
		GetMatrixImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool HasPropertyImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return HasPropertyImpl_InjectedDelegateField(_unity_self, name);
	}

	public static bool HasFloatImpl_Injected(System.IntPtr _unity_self, int name)
	{
		return HasFloatImpl_InjectedDelegateField(_unity_self, name);
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

	public unsafe static void SetColorImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Color value)
	{
		SetColorImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref value));
	}

	public static void SetGraphicsBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value)
	{
		SetGraphicsBufferImpl_InjectedDelegateField(_unity_self, name, value);
	}

	public static void SetConstantGraphicsBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value, int offset, int size)
	{
		SetConstantGraphicsBufferImpl_InjectedDelegateField(_unity_self, name, value, offset, size);
	}

	public unsafe static void GetFloatArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper ret)
	{
		GetFloatArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetVectorArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper ret)
	{
		GetVectorArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref ret));
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

	public unsafe static void ExtractMatrixArrayImpl_Injected(System.IntPtr _unity_self, int name, out BlittableArrayWrapper val)
	{
		ExtractMatrixArrayImpl_InjectedDelegateField(_unity_self, name, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void Internal_CopySHCoefficientArraysFrom_Injected(System.IntPtr properties, ref ManagedSpanWrapper lightProbes, int sourceStart, int destStart, int count)
	{
		Internal_CopySHCoefficientArraysFrom_InjectedDelegateField(properties, (nint)Unsafe.AsPointer(ref lightProbes), sourceStart, destStart, count);
	}

	public unsafe static void Internal_CopyProbeOcclusionArrayFrom_Injected(System.IntPtr properties, ref ManagedSpanWrapper occlusionProbes, int sourceStart, int destStart, int count)
	{
		Internal_CopyProbeOcclusionArrayFrom_InjectedDelegateField(properties, (nint)Unsafe.AsPointer(ref occlusionProbes), sourceStart, destStart, count);
	}
}
