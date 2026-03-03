using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

public class NativePassCompiler : Il2CppSystem.Object
{
	public sealed class RenderGraphInputInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_ResourcesForDebugOnly;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderPasses;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugName;

		private static readonly System.IntPtr NativeFieldInfoPtr_disableCulling;

		public unsafe RenderGraphResourceRegistry m_ResourcesForDebugOnly
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResourcesForDebugOnly);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ResourcesForDebugOnly)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe List<RenderGraphPass> m_RenderPasses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderPasses);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RenderGraphPass>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderPasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string debugName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe bool disableCulling
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableCulling);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableCulling)) = value;
			}
		}

		static RenderGraphInputInfo()
		{
			Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "RenderGraphInputInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr);
			NativeFieldInfoPtr_m_ResourcesForDebugOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr, "m_ResourcesForDebugOnly");
			NativeFieldInfoPtr_m_RenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr, "m_RenderPasses");
			NativeFieldInfoPtr_debugName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr, "debugName");
			NativeFieldInfoPtr_disableCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr, "disableCulling");
		}

		public RenderGraphInputInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public RenderGraphInputInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr))
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "NativeCompilerProfileId")]
	public enum NativeCompilerProfileId
	{
		NRPRGComp_PrepareNativePass,
		NRPRGComp_SetupContextData,
		NRPRGComp_BuildGraph,
		NRPRGComp_CullNodes,
		NRPRGComp_TryMergeNativePasses,
		NRPRGComp_FindResourceUsageRanges,
		NRPRGComp_DetectMemorylessResources,
		NRPRGComp_ExecuteInitializeResources,
		NRPRGComp_ExecuteBeginRenderpassCommand,
		NRPRGComp_ExecuteDestroyResources
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_graph;

	private static readonly System.IntPtr NativeFieldInfoPtr_contextData;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultContextData;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousCommandBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_toVisitPassIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CompilationCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EstimatedPassCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxSubpass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BeginRenderPassAttachments;

	private static readonly System.IntPtr NativeFieldInfoPtr_ArbitraryMaxNbMergedPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphPassNamesForDebug;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderGraphCompilationCache_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Boolean_RenderGraphResourceRegistry_List_1_RenderGraphPass_Boolean_String_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compile_Public_Void_RenderGraphResourceRegistry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPassStatesForNativePass_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupContextData_Private_Void_RenderGraphResourceRegistry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildGraph_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CullUnusedRenderPasses_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMergeNativePasses_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindResourceUsageRanges_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareNativeRenderPasses_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGlobalTextureInPass_Private_Static_Boolean_RenderGraphPass_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetectMemoryLessResources_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSameNativeSubPass_Internal_Static_Boolean_byref_SubPassDescriptor_byref_SubPassDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteInitializeResource_Private_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_PassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetermineLoadStoreActions_Private_Void_byref_NativePassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateNativePass_Private_Void_byref_NativePassData_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateAttachmentRenderTarget_Private_Void_byref_RenderTargetInfo_RenderGraphResourceRegistry_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteBeginRenderPass_Internal_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_NativePassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteDestroyResource_Private_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_PassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteSetRandomWriteTarget_Internal_Void_byref_CommandBuffer_RenderGraphResourceRegistry_Int32_ResourceHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteGraphNode_Internal_Void_byref_InternalRenderGraphContext_RenderGraphResourceRegistry_RenderGraphPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteGraph_Public_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_List_1_RenderGraphPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeAttachmentInfo_Private_Static_AttachmentInfo_CompilerContextData_byref_NativePassData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakePassBreakInfoMessage_Internal_Static_String_CompilerContextData_byref_NativePassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakePassMergeMessage_Internal_Static_String_CompilerContextData_byref_PassData_byref_PassData_PassBreakAudit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InjectSpaces_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateNativeCompilerDebugData_Internal_Void_byref_DebugData_0;

	public unsafe RenderGraphInputInfo graph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graph);
			return new RenderGraphInputInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graph), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderGraphInputInfo>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CompilerContextData contextData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contextData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompilerContextData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contextData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CompilerContextData defaultContextData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultContextData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompilerContextData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultContextData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CommandBuffer previousCommandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousCommandBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousCommandBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Stack<int> toVisitPassIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toVisitPassIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toVisitPassIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphCompilationCache m_CompilationCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CompilationCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphCompilationCache>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CompilationCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_EstimatedPassCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EstimatedPassCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EstimatedPassCount, (void*)(&value));
		}
	}

	public unsafe static int k_MaxSubpass
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxSubpass, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxSubpass, (void*)(&value));
		}
	}

	public unsafe NativeList<AttachmentDescriptor> m_BeginRenderPassAttachments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BeginRenderPassAttachments);
			return new NativeList<AttachmentDescriptor>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<AttachmentDescriptor>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BeginRenderPassAttachments), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<AttachmentDescriptor>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe static int ArbitraryMaxNbMergedPasses
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ArbitraryMaxNbMergedPasses, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ArbitraryMaxNbMergedPasses, (void*)(&value));
		}
	}

	public unsafe DynamicArray<Name> graphPassNamesForDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphPassNamesForDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Name>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphPassNamesForDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static NativePassCompiler()
	{
		Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "NativePassCompiler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr);
		NativeFieldInfoPtr_graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "graph");
		NativeFieldInfoPtr_contextData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "contextData");
		NativeFieldInfoPtr_defaultContextData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "defaultContextData");
		NativeFieldInfoPtr_previousCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "previousCommandBuffer");
		NativeFieldInfoPtr_toVisitPassIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "toVisitPassIds");
		NativeFieldInfoPtr_m_CompilationCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "m_CompilationCache");
		NativeFieldInfoPtr_k_EstimatedPassCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "k_EstimatedPassCount");
		NativeFieldInfoPtr_k_MaxSubpass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "k_MaxSubpass");
		NativeFieldInfoPtr_m_BeginRenderPassAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "m_BeginRenderPassAttachments");
		NativeFieldInfoPtr_ArbitraryMaxNbMergedPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "ArbitraryMaxNbMergedPasses");
		NativeFieldInfoPtr_graphPassNamesForDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, "graphPassNamesForDebug");
		NativeMethodInfoPtr__ctor_Public_Void_RenderGraphCompilationCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667825);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667826);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667827);
		NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667828);
		NativeMethodInfoPtr_Initialize_Public_Boolean_RenderGraphResourceRegistry_List_1_RenderGraphPass_Boolean_String_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667829);
		NativeMethodInfoPtr_Compile_Public_Void_RenderGraphResourceRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667830);
		NativeMethodInfoPtr_Clear_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667831);
		NativeMethodInfoPtr_SetPassStatesForNativePass_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667832);
		NativeMethodInfoPtr_SetupContextData_Private_Void_RenderGraphResourceRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667833);
		NativeMethodInfoPtr_BuildGraph_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667834);
		NativeMethodInfoPtr_CullUnusedRenderPasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667835);
		NativeMethodInfoPtr_TryMergeNativePasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667836);
		NativeMethodInfoPtr_FindResourceUsageRanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667837);
		NativeMethodInfoPtr_PrepareNativeRenderPasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667838);
		NativeMethodInfoPtr_IsGlobalTextureInPass_Private_Static_Boolean_RenderGraphPass_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667839);
		NativeMethodInfoPtr_DetectMemoryLessResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667840);
		NativeMethodInfoPtr_IsSameNativeSubPass_Internal_Static_Boolean_byref_SubPassDescriptor_byref_SubPassDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667841);
		NativeMethodInfoPtr_ExecuteInitializeResource_Private_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667842);
		NativeMethodInfoPtr_DetermineLoadStoreActions_Private_Void_byref_NativePassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667843);
		NativeMethodInfoPtr_ValidateNativePass_Private_Void_byref_NativePassData_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667844);
		NativeMethodInfoPtr_ValidateAttachmentRenderTarget_Private_Void_byref_RenderTargetInfo_RenderGraphResourceRegistry_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667845);
		NativeMethodInfoPtr_ExecuteBeginRenderPass_Internal_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_NativePassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667846);
		NativeMethodInfoPtr_ExecuteDestroyResource_Private_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_PassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667847);
		NativeMethodInfoPtr_ExecuteSetRandomWriteTarget_Internal_Void_byref_CommandBuffer_RenderGraphResourceRegistry_Int32_ResourceHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667848);
		NativeMethodInfoPtr_ExecuteGraphNode_Internal_Void_byref_InternalRenderGraphContext_RenderGraphResourceRegistry_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667849);
		NativeMethodInfoPtr_ExecuteGraph_Public_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_List_1_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667850);
		NativeMethodInfoPtr_MakeAttachmentInfo_Private_Static_AttachmentInfo_CompilerContextData_byref_NativePassData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667851);
		NativeMethodInfoPtr_MakePassBreakInfoMessage_Internal_Static_String_CompilerContextData_byref_NativePassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667852);
		NativeMethodInfoPtr_MakePassMergeMessage_Internal_Static_String_CompilerContextData_byref_PassData_byref_PassData_PassBreakAudit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667853);
		NativeMethodInfoPtr_InjectSpaces_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667854);
		NativeMethodInfoPtr_GenerateNativeCompilerDebugData_Internal_Void_byref_DebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr, 100667855);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061907, RefRangeEnd = 1061908, XrefRangeStart = 1061867, XrefRangeEnd = 1061907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativePassCompiler(RenderGraphCompilationCache cache)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePassCompiler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cache);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderGraphCompilationCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061908, XrefRangeEnd = 1061912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061912, XrefRangeEnd = 1061917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1061931, RefRangeEnd = 1061934, XrefRangeStart = 1061917, XrefRangeEnd = 1061931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061941, RefRangeEnd = 1061942, XrefRangeStart = 1061934, XrefRangeEnd = 1061941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Initialize(RenderGraphResourceRegistry resources, List<RenderGraphPass> renderPasses, bool disableCulling, string debugName, bool useCompilationCaching, int graphHash, int frameIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPasses);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableCulling;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(debugName);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCompilationCaching;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &graphHash;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Boolean_RenderGraphResourceRegistry_List_1_RenderGraphPass_Boolean_String_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061956, RefRangeEnd = 1061957, XrefRangeStart = 1061942, XrefRangeEnd = 1061956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Compile(RenderGraphResourceRegistry resources)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compile_Public_Void_RenderGraphResourceRegistry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061994, RefRangeEnd = 1061995, XrefRangeStart = 1061957, XrefRangeEnd = 1061994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear(bool clearContextData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&clearContextData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1062001, RefRangeEnd = 1062003, XrefRangeStart = 1061995, XrefRangeEnd = 1062001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPassStatesForNativePass(int nativePassId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativePassId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPassStatesForNativePass_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062015, RefRangeEnd = 1062016, XrefRangeStart = 1062003, XrefRangeEnd = 1062015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupContextData(RenderGraphResourceRegistry resources)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupContextData_Private_Void_RenderGraphResourceRegistry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062121, RefRangeEnd = 1062122, XrefRangeStart = 1062016, XrefRangeEnd = 1062121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildGraph()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildGraph_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062171, RefRangeEnd = 1062172, XrefRangeStart = 1062122, XrefRangeEnd = 1062171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CullUnusedRenderPasses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CullUnusedRenderPasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062206, RefRangeEnd = 1062207, XrefRangeStart = 1062172, XrefRangeEnd = 1062206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryMergeNativePasses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMergeNativePasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062275, RefRangeEnd = 1062276, XrefRangeStart = 1062207, XrefRangeEnd = 1062275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindResourceUsageRanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindResourceUsageRanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062276, XrefRangeEnd = 1062284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareNativeRenderPasses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareNativeRenderPasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062297, RefRangeEnd = 1062298, XrefRangeStart = 1062284, XrefRangeEnd = 1062297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGlobalTextureInPass(RenderGraphPass pass, ResourceHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		*(ResourceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &handle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGlobalTextureInPass_Private_Static_Boolean_RenderGraphPass_ResourceHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062333, RefRangeEnd = 1062334, XrefRangeStart = 1062298, XrefRangeEnd = 1062333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DetectMemoryLessResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetectMemoryLessResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062360, RefRangeEnd = 1062361, XrefRangeStart = 1062334, XrefRangeEnd = 1062360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSameNativeSubPass(ref SubPassDescriptor a, ref SubPassDescriptor b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref a);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSameNativeSubPass_Internal_Static_Boolean_byref_SubPassDescriptor_byref_SubPassDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062425, RefRangeEnd = 1062426, XrefRangeStart = 1062361, XrefRangeEnd = 1062425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteInitializeResource(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, [In] ref PassData pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteInitializeResource_Private_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_PassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1062483, RefRangeEnd = 1062485, XrefRangeStart = 1062426, XrefRangeEnd = 1062483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DetermineLoadStoreActions(ref NativePassData nativePass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativePass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineLoadStoreActions_Private_Void_byref_NativePassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062485, XrefRangeEnd = 1062496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateNativePass([In] ref NativePassData nativePass, int width, int height, int depth, int samples, int attachmentCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativePass);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &samples;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &attachmentCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateNativePass_Private_Void_byref_NativePassData_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1062496, XrefRangeEnd = 1062503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateAttachmentRenderTarget([In] ref RenderTargetInfo attRenderTargetInfo, RenderGraphResourceRegistry resources, int nativePassWidth, int nativePassHeight, int nativePassMSAASamples)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref attRenderTargetInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativePassWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativePassHeight;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativePassMSAASamples;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateAttachmentRenderTarget_Private_Void_byref_RenderTargetInfo_RenderGraphResourceRegistry_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062592, RefRangeEnd = 1062593, XrefRangeStart = 1062503, XrefRangeEnd = 1062592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteBeginRenderPass(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, ref NativePassData nativePass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativePass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteBeginRenderPass_Internal_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_NativePassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062645, RefRangeEnd = 1062646, XrefRangeStart = 1062593, XrefRangeEnd = 1062645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteDestroyResource(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, ref PassData pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteDestroyResource_Private_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_PassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062659, RefRangeEnd = 1062660, XrefRangeStart = 1062646, XrefRangeEnd = 1062659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteSetRandomWriteTarget([In] ref CommandBuffer cmd, RenderGraphResourceRegistry resources, int index, ResourceHandle resource, bool preserveCounterValue = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(ResourceHandle**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &resource;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &preserveCounterValue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteSetRandomWriteTarget_Internal_Void_byref_CommandBuffer_RenderGraphResourceRegistry_Int32_ResourceHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		cmd = ((intPtr4 == (System.IntPtr)0) ? null : new CommandBuffer(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062683, RefRangeEnd = 1062684, XrefRangeStart = 1062660, XrefRangeEnd = 1062683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteGraphNode(ref InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, RenderGraphPass pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteGraphNode_Internal_Void_byref_InternalRenderGraphContext_RenderGraphResourceRegistry_RenderGraphPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		rgContext = ((intPtr4 == (System.IntPtr)0) ? null : new InternalRenderGraphContext(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062751, RefRangeEnd = 1062752, XrefRangeStart = 1062684, XrefRangeEnd = 1062751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteGraph(InternalRenderGraphContext rgContext, RenderGraphResourceRegistry resources, [In] ref List<RenderGraphPass> passes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passes);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteGraph_Public_Void_InternalRenderGraphContext_RenderGraphResourceRegistry_byref_List_1_RenderGraphPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		passes = ((intPtr4 == (System.IntPtr)0) ? null : new List<RenderGraphPass>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062817, RefRangeEnd = 1062818, XrefRangeStart = 1062752, XrefRangeEnd = 1062817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo MakeAttachmentInfo(CompilerContextData ctx, [In] ref NativePassData nativePass, int attachmentIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativePass);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &attachmentIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeAttachmentInfo_Private_Static_AttachmentInfo_CompilerContextData_byref_NativePassData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraph.DebugData.PassData.NRPInfo.NativeRenderPassInfo.AttachmentInfo>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1062835, RefRangeEnd = 1062836, XrefRangeStart = 1062818, XrefRangeEnd = 1062835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakePassBreakInfoMessage(CompilerContextData ctx, [In] ref NativePassData nativePass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nativePass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakePassBreakInfoMessage_Internal_Static_String_CompilerContextData_byref_NativePassData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1062904, RefRangeEnd = 1062906, XrefRangeStart = 1062836, XrefRangeEnd = 1062904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MakePassMergeMessage(CompilerContextData ctx, [In] ref PassData pass, [In] ref PassData prevPass, PassBreakAudit mergeResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pass);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref prevPass);
		*(PassBreakAudit**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mergeResult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakePassMergeMessage_Internal_Static_String_CompilerContextData_byref_PassData_byref_PassData_PassBreakAudit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1062927, RefRangeEnd = 1062930, XrefRangeStart = 1062906, XrefRangeEnd = 1062927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InjectSpaces(string camelCaseString)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(camelCaseString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InjectSpaces_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1063351, RefRangeEnd = 1063352, XrefRangeStart = 1062930, XrefRangeEnd = 1063351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateNativeCompilerDebugData(ref RenderGraph.DebugData debugData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugData);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateNativeCompilerDebugData_Internal_Void_byref_DebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		debugData = ((intPtr4 == (System.IntPtr)0) ? null : new RenderGraph.DebugData(intPtr4));
	}

	public NativePassCompiler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
