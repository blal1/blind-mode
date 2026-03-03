using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

public class CompilerContextData : Il2CppSystem.Object
{
	public sealed class NativePassIterator : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Ctx;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompilerContextData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_byref_NativePassData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_NativePassIterator_0;

		public unsafe CompilerContextData m_Ctx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ctx);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompilerContextData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ctx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_Index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		public unsafe ref NativePassData Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061566, XrefRangeEnd = 1061570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_get_byref_NativePassData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return ref *(NativePassData*)intPtr2;
			}
		}

		static NativePassIterator()
		{
			Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "NativePassIterator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr);
			NativeFieldInfoPtr_m_Ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr, "m_Ctx");
			NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr, "m_Index");
			NativeMethodInfoPtr__ctor_Public_Void_CompilerContextData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr, 100667813);
			NativeMethodInfoPtr_get_Current_Public_get_byref_NativePassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr, 100667814);
			NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr, 100667815);
			NativeMethodInfoPtr_GetEnumerator_Public_NativePassIterator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr, 100667816);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1009994, RefRangeEnd = 1009997, XrefRangeStart = 1009994, XrefRangeEnd = 1009997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePassIterator(CompilerContextData ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CompilerContextData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1061576, RefRangeEnd = 1061579, XrefRangeStart = 1061570, XrefRangeEnd = 1061576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePassIterator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_NativePassIterator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativePassIterator(pointer);
		}

		public NativePassIterator(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public NativePassIterator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePassIterator>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_resources;

	private static readonly System.IntPtr NativeFieldInfoPtr_passData;

	private static readonly System.IntPtr NativeFieldInfoPtr_fences;

	private static readonly System.IntPtr NativeFieldInfoPtr_passNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputData;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputData;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentData;

	private static readonly System.IntPtr NativeFieldInfoPtr_createData;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyData;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomAccessResourceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativePassData;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeSubPassData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AreNativeListsAllocated;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateNativeDataStructuresIfNeeded_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_RenderGraphResourceRegistry_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnversionedResourceData_Public_byref_ResourceUnversionedData_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VersionedResourceData_Public_byref_ResourceVersionedData_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Readers_Public_ReadOnlySpan_1_ResourceReaderData_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResourceReader_Public_byref_ResourceReaderData_ResourceHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToFragmentList_Public_Boolean_TextureAccess_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFullPassName_Public_Name_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPassName_Public_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceName_Public_String_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceVersionedName_Public_String_ResourceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToRandomAccessResourceList_Public_Boolean_ResourceHandle_Int32_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TagAllPasses_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CullAllPasses_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NativePasses_Public_get_NativePassIterator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNativePasses_Internal_List_1_NativePassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

	public unsafe ResourcesData resources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResourcesData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeList<PassData> passData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passData);
			return new NativeList<PassData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<PassData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PassData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Dictionary<int, GraphicsFence> fences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fences);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, GraphicsFence>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fences)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DynamicArray<Name> passNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<Name>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeList<PassInputData> inputData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputData);
			return new NativeList<PassInputData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<PassInputData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PassInputData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<PassOutputData> outputData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputData);
			return new NativeList<PassOutputData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<PassOutputData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PassOutputData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<PassFragmentData> fragmentData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fragmentData);
			return new NativeList<PassFragmentData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<PassFragmentData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fragmentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PassFragmentData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<ResourceHandle> createData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createData);
			return new NativeList<ResourceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<ResourceHandle>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ResourceHandle>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<ResourceHandle> destroyData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyData);
			return new NativeList<ResourceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<ResourceHandle>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ResourceHandle>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<PassRandomWriteData> randomAccessResourceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomAccessResourceData);
			return new NativeList<PassRandomWriteData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<PassRandomWriteData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomAccessResourceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PassRandomWriteData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<NativePassData> nativePassData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativePassData);
			return new NativeList<NativePassData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<NativePassData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativePassData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<NativePassData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<SubPassDescriptor> nativeSubPassData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativeSubPassData);
			return new NativeList<SubPassDescriptor>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<SubPassDescriptor>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativeSubPassData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SubPassDescriptor>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool m_AreNativeListsAllocated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AreNativeListsAllocated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AreNativeListsAllocated)) = value;
		}
	}

	public unsafe NativePassIterator NativePasses
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061780, XrefRangeEnd = 1061781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NativePasses_Public_get_NativePassIterator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativePassIterator(pointer);
		}
	}

	static CompilerContextData()
	{
		Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "CompilerContextData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr);
		NativeFieldInfoPtr_resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "resources");
		NativeFieldInfoPtr_passData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "passData");
		NativeFieldInfoPtr_fences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "fences");
		NativeFieldInfoPtr_passNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "passNames");
		NativeFieldInfoPtr_inputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "inputData");
		NativeFieldInfoPtr_outputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "outputData");
		NativeFieldInfoPtr_fragmentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "fragmentData");
		NativeFieldInfoPtr_createData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "createData");
		NativeFieldInfoPtr_destroyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "destroyData");
		NativeFieldInfoPtr_randomAccessResourceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "randomAccessResourceData");
		NativeFieldInfoPtr_nativePassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "nativePassData");
		NativeFieldInfoPtr_nativeSubPassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "nativeSubPassData");
		NativeFieldInfoPtr_m_AreNativeListsAllocated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, "m_AreNativeListsAllocated");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667792);
		NativeMethodInfoPtr_AllocateNativeDataStructuresIfNeeded_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667793);
		NativeMethodInfoPtr_Initialize_Public_Void_RenderGraphResourceRegistry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667794);
		NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667795);
		NativeMethodInfoPtr_UnversionedResourceData_Public_byref_ResourceUnversionedData_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667796);
		NativeMethodInfoPtr_VersionedResourceData_Public_byref_ResourceVersionedData_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667797);
		NativeMethodInfoPtr_Readers_Public_ReadOnlySpan_1_ResourceReaderData_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667798);
		NativeMethodInfoPtr_ResourceReader_Public_byref_ResourceReaderData_ResourceHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667799);
		NativeMethodInfoPtr_AddToFragmentList_Public_Boolean_TextureAccess_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667800);
		NativeMethodInfoPtr_GetFullPassName_Public_Name_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667801);
		NativeMethodInfoPtr_GetPassName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667802);
		NativeMethodInfoPtr_GetResourceName_Public_String_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667803);
		NativeMethodInfoPtr_GetResourceVersionedName_Public_String_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667804);
		NativeMethodInfoPtr_AddToRandomAccessResourceList_Public_Boolean_ResourceHandle_Int32_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667805);
		NativeMethodInfoPtr_TagAllPasses_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667806);
		NativeMethodInfoPtr_CullAllPasses_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667807);
		NativeMethodInfoPtr_get_NativePasses_Public_get_NativePassIterator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667808);
		NativeMethodInfoPtr_GetNativePasses_Internal_List_1_NativePassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667809);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667810);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667811);
		NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr, 100667812);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061599, RefRangeEnd = 1061600, XrefRangeStart = 1061579, XrefRangeEnd = 1061599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompilerContextData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilerContextData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1061638, RefRangeEnd = 1061640, XrefRangeStart = 1061600, XrefRangeEnd = 1061638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateNativeDataStructuresIfNeeded(int estimatedNumPasses)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&estimatedNumPasses);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateNativeDataStructuresIfNeeded_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061640, XrefRangeEnd = 1061646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(RenderGraphResourceRegistry resourceRegistry, int estimatedNumPasses)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceRegistry);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &estimatedNumPasses;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_RenderGraphResourceRegistry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061646, XrefRangeEnd = 1061679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061679, XrefRangeEnd = 1061690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref ResourceUnversionedData UnversionedResourceData(ResourceHandle h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnversionedResourceData_Public_byref_ResourceUnversionedData_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(ResourceUnversionedData*)intPtr2;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061690, XrefRangeEnd = 1061691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref ResourceVersionedData VersionedResourceData(ResourceHandle h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VersionedResourceData_Public_byref_ResourceVersionedData_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(ResourceVersionedData*)intPtr2;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061691, XrefRangeEnd = 1061704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<ResourceReaderData> Readers(ResourceHandle h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Readers_Public_ReadOnlySpan_1_ResourceReaderData_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<ResourceReaderData>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061704, XrefRangeEnd = 1061717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref ResourceReaderData ResourceReader(ResourceHandle h, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResourceReader_Public_byref_ResourceReaderData_ResourceHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(ResourceReaderData*)intPtr2;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1061726, RefRangeEnd = 1061729, XrefRangeStart = 1061717, XrefRangeEnd = 1061726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddToFragmentList(TextureAccess access, int listFirstIndex, int numItems)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&access);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &listFirstIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numItems;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToFragmentList_Public_Boolean_TextureAccess_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061729, XrefRangeEnd = 1061732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Name GetFullPassName(int passId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&passId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFullPassName_Public_Name_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Name(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061732, XrefRangeEnd = 1061735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPassName(int passId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&passId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPassName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061735, XrefRangeEnd = 1061744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetResourceName(ResourceHandle h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceName_Public_String_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061744, XrefRangeEnd = 1061752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetResourceVersionedName(ResourceHandle h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&h);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceVersionedName_Public_String_ResourceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1061765, RefRangeEnd = 1061766, XrefRangeStart = 1061752, XrefRangeEnd = 1061765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddToRandomAccessResourceList(ResourceHandle h, int randomWriteSlotIndex, bool preserveCounterValue, int listFirstIndex, int numItems)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&h);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &randomWriteSlotIndex;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &preserveCounterValue;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &listFirstIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &numItems;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToRandomAccessResourceList_Public_Boolean_ResourceHandle_Int32_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061766, XrefRangeEnd = 1061773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TagAllPasses(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TagAllPasses_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061773, XrefRangeEnd = 1061780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CullAllPasses(bool isCulled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isCulled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CullAllPasses_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061781, XrefRangeEnd = 1061802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<NativePassData> GetNativePasses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNativePasses_Internal_List_1_NativePassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NativePassData>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061802, XrefRangeEnd = 1061806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1061811, RefRangeEnd = 1061813, XrefRangeStart = 1061806, XrefRangeEnd = 1061811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1061840, RefRangeEnd = 1061844, XrefRangeStart = 1061813, XrefRangeEnd = 1061840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CompilerContextData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
