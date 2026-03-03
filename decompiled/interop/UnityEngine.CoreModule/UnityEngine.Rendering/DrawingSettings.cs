using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DrawingSettings
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.DrawingSettings+<shaderPassNames>e__FixedBuffer")]
	public struct _shaderPassNames_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public int FixedElementField;

		static _shaderPassNames_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_shaderPassNames_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "<shaderPassNames>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_shaderPassNames_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_shaderPassNames_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_shaderPassNames_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_maxShaderPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SortingSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_shaderPassNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PerObjectData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideShaderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideShaderPassIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideMaterialInstanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideMaterialPassIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fallbackMaterialInstanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MainLightIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseSrpBatcher;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0;

	[FieldOffset(0)]
	public SortingSettings m_SortingSettings;

	[FieldOffset(96)]
	public _shaderPassNames_e__FixedBuffer shaderPassNames;

	[FieldOffset(160)]
	public PerObjectData m_PerObjectData;

	[FieldOffset(164)]
	public DrawRendererFlags m_Flags;

	[FieldOffset(168)]
	public int m_OverrideShaderID;

	[FieldOffset(172)]
	public int m_OverrideShaderPassIndex;

	[FieldOffset(176)]
	public int m_OverrideMaterialInstanceId;

	[FieldOffset(180)]
	public int m_OverrideMaterialPassIndex;

	[FieldOffset(184)]
	public int m_fallbackMaterialInstanceId;

	[FieldOffset(188)]
	public int m_MainLightIndex;

	[FieldOffset(192)]
	public int m_UseSrpBatcher;

	public const int kMaxShaderPasses = 16;

	public unsafe static int maxShaderPasses
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxShaderPasses, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxShaderPasses, (void*)(&value));
		}
	}

	public unsafe PerObjectData perObjectData
	{
		get
		{
			return m_PerObjectData;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 483144, RefRangeEnd = 483151, XrefRangeStart = 483144, XrefRangeEnd = 483151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool enableDynamicBatching
	{
		get
		{
			return (m_Flags & DrawRendererFlags.EnableDynamicBatching) != 0;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1238245, RefRangeEnd = 1238249, XrefRangeStart = 1238245, XrefRangeEnd = 1238245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool enableInstancing
	{
		get
		{
			return (m_Flags & DrawRendererFlags.EnableInstancing) != 0;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1238249, RefRangeEnd = 1238253, XrefRangeStart = 1238249, XrefRangeEnd = 1238249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Material overrideMaterial
	{
		get
		{
			return (m_OverrideMaterialInstanceId != 0) ? ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_OverrideMaterialInstanceId)).TryCast<Material>() : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238254, RefRangeEnd = 1238256, XrefRangeStart = 1238253, XrefRangeEnd = 1238254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Shader overrideShader
	{
		get
		{
			return (m_OverrideShaderID != 0) ? ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_OverrideShaderID)).TryCast<Shader>() : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238257, RefRangeEnd = 1238258, XrefRangeStart = 1238256, XrefRangeEnd = 1238257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int overrideMaterialPassIndex
	{
		get
		{
			return m_OverrideMaterialPassIndex;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152258, RefRangeEnd = 152260, XrefRangeStart = 152258, XrefRangeEnd = 152260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int overrideShaderPassIndex
	{
		get
		{
			return m_OverrideShaderPassIndex;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 596246, RefRangeEnd = 596247, XrefRangeStart = 596246, XrefRangeEnd = 596247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int mainLightIndex
	{
		get
		{
			return m_MainLightIndex;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168565, RefRangeEnd = 168566, XrefRangeStart = 168565, XrefRangeEnd = 168566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public SortingSettings sortingSettings
	{
		get
		{
			return m_SortingSettings;
		}
		set
		{
			m_SortingSettings = value;
		}
	}

	public Material fallbackMaterial
	{
		get
		{
			return (m_fallbackMaterialInstanceId != 0) ? ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_fallbackMaterialInstanceId)).TryCast<Material>() : null;
		}
		set
		{
			m_fallbackMaterialInstanceId = value?.GetInstanceID() ?? 0;
		}
	}

	static DrawingSettings()
	{
		Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "DrawingSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr);
		NativeFieldInfoPtr_maxShaderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "maxShaderPasses");
		NativeFieldInfoPtr_m_SortingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_SortingSettings");
		NativeFieldInfoPtr_shaderPassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "shaderPassNames");
		NativeFieldInfoPtr_m_PerObjectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_PerObjectData");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_OverrideShaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideShaderID");
		NativeFieldInfoPtr_m_OverrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideShaderPassIndex");
		NativeFieldInfoPtr_m_OverrideMaterialInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideMaterialInstanceId");
		NativeFieldInfoPtr_m_OverrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideMaterialPassIndex");
		NativeFieldInfoPtr_m_fallbackMaterialInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_fallbackMaterialInstanceId");
		NativeFieldInfoPtr_m_MainLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_MainLightIndex");
		NativeFieldInfoPtr_m_UseSrpBatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_UseSrpBatcher");
		NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668494);
		NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668495);
		NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668496);
		NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668497);
		NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668498);
		NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668499);
		NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668500);
		NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668501);
		NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668502);
		NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668503);
		NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668504);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668505);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668506);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668507);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100668508);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1238239, RefRangeEnd = 1238245, XrefRangeStart = 1238234, XrefRangeEnd = 1238239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&shaderPassName);
		*(SortingSettings**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortingSettings;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1238262, RefRangeEnd = 1238264, XrefRangeStart = 1238258, XrefRangeEnd = 1238262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShaderTagId GetShaderPassName(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ShaderTagId*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1238268, RefRangeEnd = 1238276, XrefRangeStart = 1238264, XrefRangeEnd = 1238268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShaderPassName(int index, ShaderTagId shaderPassName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(ShaderTagId**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPassName;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1238286, RefRangeEnd = 1238289, XrefRangeStart = 1238276, XrefRangeEnd = 1238286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(DrawingSettings other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238289, XrefRangeEnd = 1238295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238295, XrefRangeEnd = 1238296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238296, XrefRangeEnd = 1238300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(DrawingSettings left, DrawingSettings right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(DrawingSettings**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=(DrawingSettings left, DrawingSettings right)
	{
		return !left.Equals(right);
	}
}
