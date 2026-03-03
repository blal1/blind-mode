using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

public sealed class NativePassData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_loadAudit;

	private static readonly System.IntPtr NativeFieldInfoPtr_storeAudit;

	private static readonly System.IntPtr NativeFieldInfoPtr_breakAudit;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragments;

	private static readonly System.IntPtr NativeFieldInfoPtr_attachments;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstGraphPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastGraphPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_numGraphPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstNativeSubPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_numNativeSubPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumeDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_samples;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasFoveatedRasterization;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_PassData_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubPassFlagForMerging_Public_SubPassFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GraphPasses_Public_ReadOnlySpan_1_PassData_CompilerContextData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphPassNames_Public_Void_CompilerContextData_DynamicArray_1_Name_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanMerge_Public_Static_PassBreakAudit_CompilerContextData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanMergeNativeSubPass_Private_Static_Boolean_CompilerContextData_NativePassData_PassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMergeNativeSubPass_Public_Static_Void_CompilerContextData_byref_NativePassData_byref_PassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDepthAttachmentFirstDuringMerge_Private_Void_CompilerContextData_byref_PassFragmentData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMerge_Public_Static_PassBreakAudit_CompilerContextData_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPassStatesForNativePass_Public_Static_Void_CompilerContextData_Int32_0;

	public unsafe FixedAttachmentArray<LoadAudit> loadAudit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadAudit);
			return new FixedAttachmentArray<LoadAudit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FixedAttachmentArray<LoadAudit>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadAudit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FixedAttachmentArray<LoadAudit>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe FixedAttachmentArray<StoreAudit> storeAudit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storeAudit);
			return new FixedAttachmentArray<StoreAudit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FixedAttachmentArray<StoreAudit>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storeAudit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FixedAttachmentArray<StoreAudit>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe PassBreakAudit breakAudit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakAudit);
			return *(PassBreakAudit*)num;
		}
		set
		{
			*(PassBreakAudit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakAudit)) = value;
		}
	}

	public unsafe FixedAttachmentArray<PassFragmentData> fragments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fragments);
			return new FixedAttachmentArray<PassFragmentData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FixedAttachmentArray<PassFragmentData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fragments), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FixedAttachmentArray<PassFragmentData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe FixedAttachmentArray<NativePassAttachment> attachments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachments);
			return new FixedAttachmentArray<NativePassAttachment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FixedAttachmentArray<NativePassAttachment>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachments), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FixedAttachmentArray<NativePassAttachment>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int firstGraphPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstGraphPass);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstGraphPass)) = value;
		}
	}

	public unsafe int lastGraphPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastGraphPass);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastGraphPass)) = value;
		}
	}

	public unsafe int numGraphPasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numGraphPasses);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numGraphPasses)) = value;
		}
	}

	public unsafe int firstNativeSubPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstNativeSubPass);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstNativeSubPass)) = value;
		}
	}

	public unsafe int numNativeSubPasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numNativeSubPasses);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numNativeSubPasses)) = value;
		}
	}

	public unsafe int width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = value;
		}
	}

	public unsafe int height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = value;
		}
	}

	public unsafe int volumeDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeDepth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volumeDepth)) = value;
		}
	}

	public unsafe int samples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samples);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samples)) = value;
		}
	}

	public unsafe bool hasDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasDepth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasDepth)) = value;
		}
	}

	public unsafe bool hasFoveatedRasterization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasFoveatedRasterization);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasFoveatedRasterization)) = value;
		}
	}

	static NativePassData()
	{
		Il2CppClassPointerStore<NativePassData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "NativePassData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativePassData>.NativeClassPtr);
		NativeFieldInfoPtr_loadAudit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "loadAudit");
		NativeFieldInfoPtr_storeAudit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "storeAudit");
		NativeFieldInfoPtr_breakAudit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "breakAudit");
		NativeFieldInfoPtr_fragments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "fragments");
		NativeFieldInfoPtr_attachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "attachments");
		NativeFieldInfoPtr_firstGraphPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "firstGraphPass");
		NativeFieldInfoPtr_lastGraphPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "lastGraphPass");
		NativeFieldInfoPtr_numGraphPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "numGraphPasses");
		NativeFieldInfoPtr_firstNativeSubPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "firstNativeSubPass");
		NativeFieldInfoPtr_numNativeSubPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "numNativeSubPasses");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "height");
		NativeFieldInfoPtr_volumeDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "volumeDepth");
		NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "samples");
		NativeFieldInfoPtr_hasDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "hasDepth");
		NativeFieldInfoPtr_hasFoveatedRasterization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, "hasFoveatedRasterization");
		NativeMethodInfoPtr__ctor_Public_Void_byref_PassData_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667882);
		NativeMethodInfoPtr_GetSubPassFlagForMerging_Public_SubPassFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667883);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667884);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667885);
		NativeMethodInfoPtr_GraphPasses_Public_ReadOnlySpan_1_PassData_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667886);
		NativeMethodInfoPtr_GetGraphPassNames_Public_Void_CompilerContextData_DynamicArray_1_Name_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667887);
		NativeMethodInfoPtr_CanMerge_Public_Static_PassBreakAudit_CompilerContextData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667888);
		NativeMethodInfoPtr_CanMergeNativeSubPass_Private_Static_Boolean_CompilerContextData_NativePassData_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667889);
		NativeMethodInfoPtr_TryMergeNativeSubPass_Public_Static_Void_CompilerContextData_byref_NativePassData_byref_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667890);
		NativeMethodInfoPtr_AddDepthAttachmentFirstDuringMerge_Private_Void_CompilerContextData_byref_PassFragmentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667891);
		NativeMethodInfoPtr_TryMerge_Public_Static_PassBreakAudit_CompilerContextData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667892);
		NativeMethodInfoPtr_SetPassStatesForNativePass_Public_Static_Void_CompilerContextData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassData>.NativeClassPtr, 100667893);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1063547, RefRangeEnd = 1063549, XrefRangeStart = 1063475, XrefRangeEnd = 1063547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativePassData(ref PassData pass, CompilerContextData ctx)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePassData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref pass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_PassData_CompilerContextData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063549, RefRangeEnd = 1063550, XrefRangeStart = 1063549, XrefRangeEnd = 1063549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubPassFlags GetSubPassFlagForMerging()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubPassFlagForMerging_Public_SubPassFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SubPassFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063574, RefRangeEnd = 1063575, XrefRangeStart = 1063550, XrefRangeEnd = 1063574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsValid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063575, XrefRangeEnd = 1063585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<PassData> GraphPasses(CompilerContextData ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GraphPasses_Public_ReadOnlySpan_1_PassData_CompilerContextData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<PassData>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063585, XrefRangeEnd = 1063593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetGraphPassNames(CompilerContextData ctx, DynamicArray<Name> dest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphPassNames_Public_Void_CompilerContextData_DynamicArray_1_Name_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1063617, RefRangeEnd = 1063620, XrefRangeStart = 1063593, XrefRangeEnd = 1063617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PassBreakAudit CanMerge(CompilerContextData contextData, int activeNativePassId, int passIdToMerge)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeNativePassId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIdToMerge;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanMerge_Public_Static_PassBreakAudit_CompilerContextData_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PassBreakAudit*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063620, XrefRangeEnd = 1063627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanMergeNativeSubPass(CompilerContextData contextData, NativePassData nativePass, PassData passToMerge)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativePass));
		*(PassData**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &passToMerge;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanMergeNativeSubPass_Private_Static_Boolean_CompilerContextData_NativePassData_PassData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1063687, RefRangeEnd = 1063689, XrefRangeStart = 1063627, XrefRangeEnd = 1063687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TryMergeNativeSubPass(CompilerContextData contextData, ref NativePassData nativePass, ref PassData passToMerge)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativePass);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref passToMerge);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMergeNativeSubPass_Public_Static_Void_CompilerContextData_byref_NativePassData_byref_PassData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063731, RefRangeEnd = 1063732, XrefRangeStart = 1063689, XrefRangeEnd = 1063731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDepthAttachmentFirstDuringMerge(CompilerContextData contextData, [In] ref PassFragmentData depthAttachment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref depthAttachment);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDepthAttachmentFirstDuringMerge_Private_Void_CompilerContextData_byref_PassFragmentData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063797, RefRangeEnd = 1063798, XrefRangeStart = 1063732, XrefRangeEnd = 1063797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PassBreakAudit TryMerge(CompilerContextData contextData, int activeNativePassId, int passIdToMerge)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeNativePassId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIdToMerge;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMerge_Public_Static_PassBreakAudit_CompilerContextData_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PassBreakAudit*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063798, XrefRangeEnd = 1063804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPassStatesForNativePass(CompilerContextData contextData, int nativePassId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativePassId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPassStatesForNativePass_Public_Static_Void_CompilerContextData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NativePassData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public NativePassData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePassData>.NativeClassPtr))
	{
	}
}
