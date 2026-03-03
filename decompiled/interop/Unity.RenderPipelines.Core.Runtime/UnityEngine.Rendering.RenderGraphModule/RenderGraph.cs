using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering.RenderGraphModule;

public class RenderGraph : Il2CppSystem.Object
{
	public sealed class CompiledResourceInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_producers;

		private static readonly System.IntPtr NativeFieldInfoPtr_consumers;

		private static readonly System.IntPtr NativeFieldInfoPtr_refCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_imported;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		public unsafe List<int> producers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_producers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_producers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe List<int> consumers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int refCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refCount)) = value;
			}
		}

		public unsafe bool imported
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imported);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imported)) = value;
			}
		}

		static CompiledResourceInfo()
		{
			Il2CppClassPointerStore<CompiledResourceInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "CompiledResourceInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompiledResourceInfo>.NativeClassPtr);
			NativeFieldInfoPtr_producers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledResourceInfo>.NativeClassPtr, "producers");
			NativeFieldInfoPtr_consumers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledResourceInfo>.NativeClassPtr, "consumers");
			NativeFieldInfoPtr_refCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledResourceInfo>.NativeClassPtr, "refCount");
			NativeFieldInfoPtr_imported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledResourceInfo>.NativeClassPtr, "imported");
			NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledResourceInfo>.NativeClassPtr, 100667250);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055640, XrefRangeEnd = 1055653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CompiledResourceInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CompiledResourceInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompiledResourceInfo>.NativeClassPtr))
		{
		}
	}

	public sealed class CompiledPassInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_index;

		private static readonly System.IntPtr NativeFieldInfoPtr_resourceCreateList;

		private static readonly System.IntPtr NativeFieldInfoPtr_resourceReleaseList;

		private static readonly System.IntPtr NativeFieldInfoPtr_fence;

		private static readonly System.IntPtr NativeFieldInfoPtr_refCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_syncToPassIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_syncFromPassIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableAsyncCompute;

		private static readonly System.IntPtr NativeFieldInfoPtr_allowPassCulling;

		private static readonly System.IntPtr NativeFieldInfoPtr_needGraphicsFence;

		private static readonly System.IntPtr NativeFieldInfoPtr_culled;

		private static readonly System.IntPtr NativeFieldInfoPtr_culledByRendererList;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasSideEffect;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableFoveatedRasterization;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_RenderGraphPass_Int32_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = value;
			}
		}

		public unsafe Il2CppReferenceArray<List<int>> resourceCreateList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceCreateList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceCreateList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<List<int>> resourceReleaseList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceReleaseList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceReleaseList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsFence fence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fence);
				return *(GraphicsFence*)num;
			}
			set
			{
				*(GraphicsFence*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fence)) = value;
			}
		}

		public unsafe int refCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_refCount)) = value;
			}
		}

		public unsafe int syncToPassIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncToPassIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncToPassIndex)) = value;
			}
		}

		public unsafe int syncFromPassIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncFromPassIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncFromPassIndex)) = value;
			}
		}

		public unsafe bool enableAsyncCompute
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAsyncCompute);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAsyncCompute)) = value;
			}
		}

		public unsafe bool allowPassCulling
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPassCulling);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowPassCulling)) = value;
			}
		}

		public unsafe bool needGraphicsFence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needGraphicsFence);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needGraphicsFence)) = value;
			}
		}

		public unsafe bool culled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culled)) = value;
			}
		}

		public unsafe bool culledByRendererList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culledByRendererList);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culledByRendererList)) = value;
			}
		}

		public unsafe bool hasSideEffect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSideEffect);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSideEffect)) = value;
			}
		}

		public unsafe bool enableFoveatedRasterization
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFoveatedRasterization);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFoveatedRasterization)) = value;
			}
		}

		static CompiledPassInfo()
		{
			Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "CompiledPassInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "name");
			NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "index");
			NativeFieldInfoPtr_resourceCreateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "resourceCreateList");
			NativeFieldInfoPtr_resourceReleaseList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "resourceReleaseList");
			NativeFieldInfoPtr_fence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "fence");
			NativeFieldInfoPtr_refCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "refCount");
			NativeFieldInfoPtr_syncToPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "syncToPassIndex");
			NativeFieldInfoPtr_syncFromPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "syncFromPassIndex");
			NativeFieldInfoPtr_enableAsyncCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "enableAsyncCompute");
			NativeFieldInfoPtr_allowPassCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "allowPassCulling");
			NativeFieldInfoPtr_needGraphicsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "needGraphicsFence");
			NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "culled");
			NativeFieldInfoPtr_culledByRendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "culledByRendererList");
			NativeFieldInfoPtr_hasSideEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "hasSideEffect");
			NativeFieldInfoPtr_enableFoveatedRasterization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, "enableFoveatedRasterization");
			NativeMethodInfoPtr_Reset_Public_Void_RenderGraphPass_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr, 100667251);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1055676, RefRangeEnd = 1055678, XrefRangeStart = 1055653, XrefRangeEnd = 1055676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(RenderGraphPass pass, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_RenderGraphPass_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CompiledPassInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CompiledPassInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompiledPassInfo>.NativeClassPtr))
		{
		}
	}

	public class ICompiledGraph : Il2CppObjectBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;

		static ICompiledGraph()
		{
			Il2CppClassPointerStore<ICompiledGraph>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "ICompiledGraph");
			NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICompiledGraph>.NativeClassPtr, 100667252);
		}

		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ICompiledGraph(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CompiledGraph : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_compiledResourcesInfos;

		private static readonly System.IntPtr NativeFieldInfoPtr_compiledPassInfos;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastExecutionFrame;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitResourceInfosData_Private_Void_DynamicArray_1_CompiledResourceInfo_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCompilationData_Public_Void_List_1_RenderGraphPass_RenderGraphResourceRegistry_0;

		public unsafe Il2CppReferenceArray<DynamicArray<CompiledResourceInfo>> compiledResourcesInfos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compiledResourcesInfos);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicArray<CompiledResourceInfo>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compiledResourcesInfos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DynamicArray<CompiledPassInfo> compiledPassInfos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compiledPassInfos);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<CompiledPassInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compiledPassInfos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int lastExecutionFrame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastExecutionFrame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastExecutionFrame)) = value;
			}
		}

		static CompiledGraph()
		{
			Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "CompiledGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr);
			NativeFieldInfoPtr_compiledResourcesInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr, "compiledResourcesInfos");
			NativeFieldInfoPtr_compiledPassInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr, "compiledPassInfos");
			NativeFieldInfoPtr_lastExecutionFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr, "lastExecutionFrame");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr, 100667253);
			NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr, 100667254);
			NativeMethodInfoPtr_InitResourceInfosData_Private_Void_DynamicArray_1_CompiledResourceInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr, 100667255);
			NativeMethodInfoPtr_InitializeCompilationData_Public_Void_List_1_RenderGraphPass_RenderGraphResourceRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr, 100667256);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1055698, RefRangeEnd = 1055700, XrefRangeStart = 1055678, XrefRangeEnd = 1055698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompiledGraph()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompiledGraph>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1055708, RefRangeEnd = 1055714, XrefRangeStart = 1055700, XrefRangeEnd = 1055708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1055735, RefRangeEnd = 1055738, XrefRangeStart = 1055714, XrefRangeEnd = 1055735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitResourceInfosData(DynamicArray<CompiledResourceInfo> resourceInfos, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceInfos);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitResourceInfosData_Private_Void_DynamicArray_1_CompiledResourceInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1055757, RefRangeEnd = 1055758, XrefRangeStart = 1055738, XrefRangeEnd = 1055757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCompilationData(List<RenderGraphPass> passes, RenderGraphResourceRegistry resources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeCompilationData_Public_Void_List_1_RenderGraphPass_RenderGraphResourceRegistry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CompiledGraph(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ProfilingScopePassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sampler;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ProfilingSampler sampler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampler);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static ProfilingScopePassData()
		{
			Il2CppClassPointerStore<ProfilingScopePassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "ProfilingScopePassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilingScopePassData>.NativeClassPtr);
			NativeFieldInfoPtr_sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilingScopePassData>.NativeClassPtr, "sampler");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilingScopePassData>.NativeClassPtr, 100667257);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilingScopePassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProfilingScopePassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ProfilingScopePassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class OnGraphRegisteredDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static OnGraphRegisteredDelegate()
		{
			Il2CppClassPointerStore<OnGraphRegisteredDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "OnGraphRegisteredDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGraphRegisteredDelegate>.NativeClassPtr, 100667258);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGraphRegisteredDelegate>.NativeClassPtr, 100667259);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGraphRegisteredDelegate>.NativeClassPtr, 100667260);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGraphRegisteredDelegate>.NativeClassPtr, 100667261);
		}

		[CallerCount(809)]
		[CachedScanResults(RefRangeStart = 49779, RefRangeEnd = 50588, XrefRangeStart = 49779, XrefRangeEnd = 50588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnGraphRegisteredDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnGraphRegisteredDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(RenderGraph graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50589, RefRangeEnd = 50590, XrefRangeStart = 50589, XrefRangeEnd = 50590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(RenderGraph graph, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnGraphRegisteredDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnGraphRegisteredDelegate(System.Action<RenderGraph> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnGraphRegisteredDelegate>((System.Delegate)P_0);
		}

		public static OnGraphRegisteredDelegate operator +(OnGraphRegisteredDelegate P_0, OnGraphRegisteredDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnGraphRegisteredDelegate>();
		}

		public static OnGraphRegisteredDelegate operator -(OnGraphRegisteredDelegate P_0, OnGraphRegisteredDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnGraphRegisteredDelegate>();
			}
			return (OnGraphRegisteredDelegate)obj;
		}
	}

	public sealed class OnExecutionRegisteredDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_String_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static OnExecutionRegisteredDelegate()
		{
			Il2CppClassPointerStore<OnExecutionRegisteredDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "OnExecutionRegisteredDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnExecutionRegisteredDelegate>.NativeClassPtr, 100667262);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnExecutionRegisteredDelegate>.NativeClassPtr, 100667263);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnExecutionRegisteredDelegate>.NativeClassPtr, 100667264);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnExecutionRegisteredDelegate>.NativeClassPtr, 100667265);
		}

		[CallerCount(110)]
		[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49769, XrefRangeStart = 49659, XrefRangeEnd = 49769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnExecutionRegisteredDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnExecutionRegisteredDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(RenderGraph graph, string executionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(executionName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RenderGraph_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(RenderGraph graph, string executionName, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(executionName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_RenderGraph_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnExecutionRegisteredDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnExecutionRegisteredDelegate(System.Action<RenderGraph, string> P_0)
		{
			return DelegateSupport.ConvertDelegate<OnExecutionRegisteredDelegate>((System.Delegate)P_0);
		}

		public static OnExecutionRegisteredDelegate operator +(OnExecutionRegisteredDelegate P_0, OnExecutionRegisteredDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnExecutionRegisteredDelegate>();
		}

		public static OnExecutionRegisteredDelegate operator -(OnExecutionRegisteredDelegate P_0, OnExecutionRegisteredDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnExecutionRegisteredDelegate>();
			}
			return (OnExecutionRegisteredDelegate)obj;
		}
	}

	public class DebugData : Il2CppSystem.Object
	{
		public sealed class PassData : Il2CppSystem.ValueType
		{
			public class NRPInfo : Il2CppSystem.Object
			{
				public class NativeRenderPassInfo : Il2CppSystem.Object
				{
					public class AttachmentInfo : Il2CppSystem.Object
					{
						private static readonly System.IntPtr NativeFieldInfoPtr_resourceName;

						private static readonly System.IntPtr NativeFieldInfoPtr_loadReason;

						private static readonly System.IntPtr NativeFieldInfoPtr_storeReason;

						private static readonly System.IntPtr NativeFieldInfoPtr_storeMsaaReason;

						private static readonly System.IntPtr NativeFieldInfoPtr_attachmentIndex;

						private static readonly System.IntPtr NativeFieldInfoPtr_attachment;

						private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

						public unsafe string resourceName
						{
							get
							{
								nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceName);
								return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
							}
							set
							{
								System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
								IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceName)), IL2CPP.ManagedStringToIl2Cpp(value));
							}
						}

						public unsafe string loadReason
						{
							get
							{
								nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadReason);
								return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
							}
							set
							{
								System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
								IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadReason)), IL2CPP.ManagedStringToIl2Cpp(value));
							}
						}

						public unsafe string storeReason
						{
							get
							{
								nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storeReason);
								return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
							}
							set
							{
								System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
								IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storeReason)), IL2CPP.ManagedStringToIl2Cpp(value));
							}
						}

						public unsafe string storeMsaaReason
						{
							get
							{
								nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storeMsaaReason);
								return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
							}
							set
							{
								System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
								IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storeMsaaReason)), IL2CPP.ManagedStringToIl2Cpp(value));
							}
						}

						public unsafe int attachmentIndex
						{
							get
							{
								nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachmentIndex);
								return *(int*)num;
							}
							set
							{
								*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachmentIndex)) = value;
							}
						}

						public unsafe NativePassAttachment attachment
						{
							get
							{
								nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachment);
								return *(NativePassAttachment*)num;
							}
							set
							{
								*(NativePassAttachment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachment)) = value;
							}
						}

						static AttachmentInfo()
						{
							Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr, "AttachmentInfo");
							IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr);
							NativeFieldInfoPtr_resourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr, "resourceName");
							NativeFieldInfoPtr_loadReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr, "loadReason");
							NativeFieldInfoPtr_storeReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr, "storeReason");
							NativeFieldInfoPtr_storeMsaaReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr, "storeMsaaReason");
							NativeFieldInfoPtr_attachmentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr, "attachmentIndex");
							NativeFieldInfoPtr_attachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr, "attachment");
							NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr, 100667271);
						}

						[CallerCount(1950)]
						[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
						public unsafe AttachmentInfo()
							: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttachmentInfo>.NativeClassPtr))
						{
							System.IntPtr* ptr = null;
							Unsafe.SkipInit(out System.IntPtr intPtr);
							System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
							Il2CppException.RaiseExceptionIfNecessary(intPtr);
						}

						public AttachmentInfo(System.IntPtr pointer)
							: base(pointer)
						{
						}
					}

					public sealed class PassCompatibilityInfo : Il2CppSystem.ValueType
					{
						private static readonly System.IntPtr NativeFieldInfoPtr_message;

						private static readonly System.IntPtr NativeFieldInfoPtr_isCompatible;

						public unsafe string message
						{
							get
							{
								nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_message);
								return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
							}
							set
							{
								System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
								IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_message)), IL2CPP.ManagedStringToIl2Cpp(value));
							}
						}

						public unsafe bool isCompatible
						{
							get
							{
								nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCompatible);
								return *(bool*)num;
							}
							set
							{
								*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCompatible)) = value;
							}
						}

						static PassCompatibilityInfo()
						{
							Il2CppClassPointerStore<PassCompatibilityInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr, "PassCompatibilityInfo");
							IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassCompatibilityInfo>.NativeClassPtr);
							NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassCompatibilityInfo>.NativeClassPtr, "message");
							NativeFieldInfoPtr_isCompatible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassCompatibilityInfo>.NativeClassPtr, "isCompatible");
						}

						public PassCompatibilityInfo(System.IntPtr pointer)
							: base(pointer)
						{
						}

						public PassCompatibilityInfo()
							: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassCompatibilityInfo>.NativeClassPtr))
						{
						}
					}

					private static readonly System.IntPtr NativeFieldInfoPtr_passBreakReasoning;

					private static readonly System.IntPtr NativeFieldInfoPtr_attachmentInfos;

					private static readonly System.IntPtr NativeFieldInfoPtr_passCompatibility;

					private static readonly System.IntPtr NativeFieldInfoPtr_mergedPassIds;

					private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

					public unsafe string passBreakReasoning
					{
						get
						{
							nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passBreakReasoning);
							return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
						}
						set
						{
							System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passBreakReasoning)), IL2CPP.ManagedStringToIl2Cpp(value));
						}
					}

					public unsafe List<AttachmentInfo> attachmentInfos
					{
						get
						{
							nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachmentInfos);
							System.IntPtr intPtr = *(System.IntPtr*)num;
							return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AttachmentInfo>>(intPtr) : null;
						}
						set
						{
							System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attachmentInfos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
						}
					}

					public unsafe Dictionary<int, PassCompatibilityInfo> passCompatibility
					{
						get
						{
							nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passCompatibility);
							System.IntPtr intPtr = *(System.IntPtr*)num;
							return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, PassCompatibilityInfo>>(intPtr) : null;
						}
						set
						{
							System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passCompatibility)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
						}
					}

					public unsafe List<int> mergedPassIds
					{
						get
						{
							nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mergedPassIds);
							System.IntPtr intPtr = *(System.IntPtr*)num;
							return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
						}
						set
						{
							System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mergedPassIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
						}
					}

					static NativeRenderPassInfo()
					{
						Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "NativeRenderPassInfo");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr);
						NativeFieldInfoPtr_passBreakReasoning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr, "passBreakReasoning");
						NativeFieldInfoPtr_attachmentInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr, "attachmentInfos");
						NativeFieldInfoPtr_passCompatibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr, "passCompatibility");
						NativeFieldInfoPtr_mergedPassIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr, "mergedPassIds");
						NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr, 100667270);
					}

					[CallerCount(1950)]
					[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe NativeRenderPassInfo()
						: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeRenderPassInfo>.NativeClassPtr))
					{
						System.IntPtr* ptr = null;
						Unsafe.SkipInit(out System.IntPtr intPtr);
						System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
						Il2CppException.RaiseExceptionIfNecessary(intPtr);
					}

					public NativeRenderPassInfo(System.IntPtr pointer)
						: base(pointer)
					{
					}
				}

				private static readonly System.IntPtr NativeFieldInfoPtr_nativePassInfo;

				private static readonly System.IntPtr NativeFieldInfoPtr_textureFBFetchList;

				private static readonly System.IntPtr NativeFieldInfoPtr_setGlobals;

				private static readonly System.IntPtr NativeFieldInfoPtr_width;

				private static readonly System.IntPtr NativeFieldInfoPtr_height;

				private static readonly System.IntPtr NativeFieldInfoPtr_volumeDepth;

				private static readonly System.IntPtr NativeFieldInfoPtr_samples;

				private static readonly System.IntPtr NativeFieldInfoPtr_hasDepth;

				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				public unsafe NativeRenderPassInfo nativePassInfo
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativePassInfo);
						System.IntPtr intPtr = *(System.IntPtr*)num;
						return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NativeRenderPassInfo>(intPtr) : null;
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativePassInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
					}
				}

				public unsafe List<int> textureFBFetchList
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureFBFetchList);
						System.IntPtr intPtr = *(System.IntPtr*)num;
						return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureFBFetchList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
					}
				}

				public unsafe List<int> setGlobals
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setGlobals);
						System.IntPtr intPtr = *(System.IntPtr*)num;
						return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setGlobals)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

				static NRPInfo()
				{
					Il2CppClassPointerStore<NRPInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PassData>.NativeClassPtr, "NRPInfo");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr);
					NativeFieldInfoPtr_nativePassInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "nativePassInfo");
					NativeFieldInfoPtr_textureFBFetchList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "textureFBFetchList");
					NativeFieldInfoPtr_setGlobals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "setGlobals");
					NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "width");
					NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "height");
					NativeFieldInfoPtr_volumeDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "volumeDepth");
					NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "samples");
					NativeFieldInfoPtr_hasDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, "hasDepth");
					NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr, 100667269);
				}

				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055758, XrefRangeEnd = 1055771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe NRPInfo()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NRPInfo>.NativeClassPtr))
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
				}

				public NRPInfo(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			private static readonly System.IntPtr NativeFieldInfoPtr_type;

			private static readonly System.IntPtr NativeFieldInfoPtr_resourceReadLists;

			private static readonly System.IntPtr NativeFieldInfoPtr_resourceWriteLists;

			private static readonly System.IntPtr NativeFieldInfoPtr_culled;

			private static readonly System.IntPtr NativeFieldInfoPtr_async;

			private static readonly System.IntPtr NativeFieldInfoPtr_nativeSubPassIndex;

			private static readonly System.IntPtr NativeFieldInfoPtr_syncToPassIndex;

			private static readonly System.IntPtr NativeFieldInfoPtr_syncFromPassIndex;

			private static readonly System.IntPtr NativeFieldInfoPtr_generateDebugData;

			private static readonly System.IntPtr NativeFieldInfoPtr_nrpInfo;

			private static readonly System.IntPtr NativeFieldInfoPtr_scriptInfo;

			public unsafe string name
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe RenderGraphPassType type
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
					return *(RenderGraphPassType*)num;
				}
				set
				{
					*(RenderGraphPassType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = value;
				}
			}

			public unsafe Il2CppReferenceArray<List<int>> resourceReadLists
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceReadLists);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceReadLists)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe Il2CppReferenceArray<List<int>> resourceWriteLists
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceWriteLists);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceWriteLists)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe bool culled
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culled);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culled)) = value;
				}
			}

			public unsafe bool async
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_async);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_async)) = value;
				}
			}

			public unsafe int nativeSubPassIndex
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativeSubPassIndex);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativeSubPassIndex)) = value;
				}
			}

			public unsafe int syncToPassIndex
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncToPassIndex);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncToPassIndex)) = value;
				}
			}

			public unsafe int syncFromPassIndex
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncFromPassIndex);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncFromPassIndex)) = value;
				}
			}

			public unsafe bool generateDebugData
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateDebugData);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateDebugData)) = value;
				}
			}

			public unsafe NRPInfo nrpInfo
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nrpInfo);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NRPInfo>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nrpInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe PassScriptInfo scriptInfo
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scriptInfo);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PassScriptInfo>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scriptInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static PassData()
			{
				Il2CppClassPointerStore<PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassData>.NativeClassPtr);
				NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "name");
				NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "type");
				NativeFieldInfoPtr_resourceReadLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "resourceReadLists");
				NativeFieldInfoPtr_resourceWriteLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "resourceWriteLists");
				NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "culled");
				NativeFieldInfoPtr_async = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "async");
				NativeFieldInfoPtr_nativeSubPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "nativeSubPassIndex");
				NativeFieldInfoPtr_syncToPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "syncToPassIndex");
				NativeFieldInfoPtr_syncFromPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "syncFromPassIndex");
				NativeFieldInfoPtr_generateDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "generateDebugData");
				NativeFieldInfoPtr_nrpInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "nrpInfo");
				NativeFieldInfoPtr_scriptInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "scriptInfo");
			}

			public PassData(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public PassData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassData>.NativeClassPtr))
			{
			}
		}

		public class BufferResourceData : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_count;

			private static readonly System.IntPtr NativeFieldInfoPtr_stride;

			private static readonly System.IntPtr NativeFieldInfoPtr_target;

			private static readonly System.IntPtr NativeFieldInfoPtr_usage;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe int count
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = value;
				}
			}

			public unsafe int stride
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stride);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stride)) = value;
				}
			}

			public unsafe GraphicsBuffer.Target target
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
					return *(GraphicsBuffer.Target*)num;
				}
				set
				{
					*(GraphicsBuffer.Target*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target)) = value;
				}
			}

			public unsafe GraphicsBuffer.UsageFlags usage
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage);
					return *(GraphicsBuffer.UsageFlags*)num;
				}
				set
				{
					*(GraphicsBuffer.UsageFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usage)) = value;
				}
			}

			static BufferResourceData()
			{
				Il2CppClassPointerStore<BufferResourceData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "BufferResourceData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferResourceData>.NativeClassPtr);
				NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferResourceData>.NativeClassPtr, "count");
				NativeFieldInfoPtr_stride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferResourceData>.NativeClassPtr, "stride");
				NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferResourceData>.NativeClassPtr, "target");
				NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferResourceData>.NativeClassPtr, "usage");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferResourceData>.NativeClassPtr, 100667272);
			}

			[CallerCount(1950)]
			[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BufferResourceData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferResourceData>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public BufferResourceData(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class TextureResourceData : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_width;

			private static readonly System.IntPtr NativeFieldInfoPtr_height;

			private static readonly System.IntPtr NativeFieldInfoPtr_depth;

			private static readonly System.IntPtr NativeFieldInfoPtr_bindMS;

			private static readonly System.IntPtr NativeFieldInfoPtr_samples;

			private static readonly System.IntPtr NativeFieldInfoPtr_format;

			private static readonly System.IntPtr NativeFieldInfoPtr_clearBuffer;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

			public unsafe int depth
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth)) = value;
				}
			}

			public unsafe bool bindMS
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindMS);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bindMS)) = value;
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

			public unsafe GraphicsFormat format
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format);
					return *(GraphicsFormat*)num;
				}
				set
				{
					*(GraphicsFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format)) = value;
				}
			}

			public unsafe bool clearBuffer
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearBuffer);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearBuffer)) = value;
				}
			}

			static TextureResourceData()
			{
				Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "TextureResourceData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr);
				NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr, "width");
				NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr, "height");
				NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr, "depth");
				NativeFieldInfoPtr_bindMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr, "bindMS");
				NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr, "samples");
				NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr, "format");
				NativeFieldInfoPtr_clearBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr, "clearBuffer");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr, 100667273);
			}

			[CallerCount(1950)]
			[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureResourceData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureResourceData>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public TextureResourceData(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public sealed class ResourceData : Il2CppSystem.ValueType
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			private static readonly System.IntPtr NativeFieldInfoPtr_imported;

			private static readonly System.IntPtr NativeFieldInfoPtr_creationPassIndex;

			private static readonly System.IntPtr NativeFieldInfoPtr_releasePassIndex;

			private static readonly System.IntPtr NativeFieldInfoPtr_consumerList;

			private static readonly System.IntPtr NativeFieldInfoPtr_producerList;

			private static readonly System.IntPtr NativeFieldInfoPtr_memoryless;

			private static readonly System.IntPtr NativeFieldInfoPtr_textureData;

			private static readonly System.IntPtr NativeFieldInfoPtr_bufferData;

			public unsafe string name
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe bool imported
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imported);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imported)) = value;
				}
			}

			public unsafe int creationPassIndex
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creationPassIndex);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creationPassIndex)) = value;
				}
			}

			public unsafe int releasePassIndex
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releasePassIndex);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releasePassIndex)) = value;
				}
			}

			public unsafe List<int> consumerList
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumerList);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumerList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe List<int> producerList
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_producerList);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_producerList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe bool memoryless
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memoryless);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memoryless)) = value;
				}
			}

			public unsafe TextureResourceData textureData
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureData);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextureResourceData>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe BufferResourceData bufferData
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferData);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BufferResourceData>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static ResourceData()
			{
				Il2CppClassPointerStore<ResourceData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "ResourceData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceData>.NativeClassPtr);
				NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "name");
				NativeFieldInfoPtr_imported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "imported");
				NativeFieldInfoPtr_creationPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "creationPassIndex");
				NativeFieldInfoPtr_releasePassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "releasePassIndex");
				NativeFieldInfoPtr_consumerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "consumerList");
				NativeFieldInfoPtr_producerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "producerList");
				NativeFieldInfoPtr_memoryless = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "memoryless");
				NativeFieldInfoPtr_textureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "textureData");
				NativeFieldInfoPtr_bufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceData>.NativeClassPtr, "bufferData");
			}

			public ResourceData(System.IntPtr pointer)
				: base(pointer)
			{
			}

			public ResourceData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceData>.NativeClassPtr))
			{
			}
		}

		public class PassScriptInfo : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_filePath;

			private static readonly System.IntPtr NativeFieldInfoPtr_line;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe string filePath
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath)), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe int line
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_line);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_line)) = value;
				}
			}

			static PassScriptInfo()
			{
				Il2CppClassPointerStore<PassScriptInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "PassScriptInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassScriptInfo>.NativeClassPtr);
				NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassScriptInfo>.NativeClassPtr, "filePath");
				NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassScriptInfo>.NativeClassPtr, "line");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassScriptInfo>.NativeClassPtr, 100667274);
			}

			[CallerCount(1950)]
			[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassScriptInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassScriptInfo>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public PassScriptInfo(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_passList;

		private static readonly System.IntPtr NativeFieldInfoPtr_resourceLists;

		private static readonly System.IntPtr NativeFieldInfoPtr_isNRPCompiler;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_PassScriptMetadata;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		public unsafe List<PassData> passList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PassData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<List<ResourceData>> resourceLists
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceLists);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<ResourceData>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceLists)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool isNRPCompiler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNRPCompiler);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNRPCompiler)) = value;
			}
		}

		public unsafe static Dictionary<Il2CppSystem.Object, PassScriptInfo> s_PassScriptMetadata
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PassScriptMetadata, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Object, PassScriptInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PassScriptMetadata, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static DebugData()
		{
			Il2CppClassPointerStore<DebugData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "DebugData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugData>.NativeClassPtr);
			NativeFieldInfoPtr_passList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "passList");
			NativeFieldInfoPtr_resourceLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "resourceLists");
			NativeFieldInfoPtr_isNRPCompiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "isNRPCompiler");
			NativeFieldInfoPtr_s_PassScriptMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugData>.NativeClassPtr, "s_PassScriptMetadata");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugData>.NativeClassPtr, 100667266);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugData>.NativeClassPtr, 100667267);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055771, XrefRangeEnd = 1055791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1055795, RefRangeEnd = 1055796, XrefRangeStart = 1055791, XrefRangeEnd = 1055795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DebugData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.RenderGraphModule.RenderGraph+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__111_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__112_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BeginProfilingSampler_b__111_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__EndProfilingSampler_b__112_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<ProfilingScopePassData, RenderGraphContext> __9__111_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__111_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<ProfilingScopePassData, RenderGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__111_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<ProfilingScopePassData, RenderGraphContext> __9__112_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__112_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<ProfilingScopePassData, RenderGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__112_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__111_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__111_0");
			NativeFieldInfoPtr___9__112_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__112_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667276);
			NativeMethodInfoPtr__BeginProfilingSampler_b__111_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667277);
			NativeMethodInfoPtr__EndProfilingSampler_b__112_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667278);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055796, XrefRangeEnd = 1055798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BeginProfilingSampler_b__111_0(ProfilingScopePassData data, RenderGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ctx));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BeginProfilingSampler_b__111_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055798, XrefRangeEnd = 1055814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _EndProfilingSampler_b__112_0(ProfilingScopePassData data, RenderGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ctx));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__EndProfilingSampler_b__112_0_Internal_Void_ProfilingScopePassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_String_Int32_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_String_Int32_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_String_Int32_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_String_Int32_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_String_Int32_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_String_Int32_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_String_Int32_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_String_Int32_0, Il2CppClassPointerStore<RenderGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeCompiler;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxMRTCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__nativeRenderPassesEnabled_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Resources;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderGraphPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_builderInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererLists;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugParameters;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameInformationLogger;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultResources;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultProfilingSamplers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderGraphContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviousCommandBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ImmediateModeResourceList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CompilationCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TempMRTArrays;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentExecutionName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ExecutionCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentFrameIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentImmediatePassIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ExecutionExceptionWasRaised;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasRenderGraphBegun;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererListCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EnableCompilationCaching;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultCompiledGraph;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentCompiledGraph;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CaptureDebugDataForExecution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugData;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_RegisteredGraphs;

	private static readonly System.IntPtr NativeFieldInfoPtr__name_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isRenderGraphViewerActive_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__enableValidityChecks_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BeginProfilingSamplerPassName;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EndProfilingSamplerPassName;

	private static readonly System.IntPtr NativeFieldInfoPtr_onGraphRegistered;

	private static readonly System.IntPtr NativeFieldInfoPtr_onGraphUnregistered;

	private static readonly System.IntPtr NativeFieldInfoPtr_onExecutionRegistered;

	private static readonly System.IntPtr NativeFieldInfoPtr_onExecutionUnregistered;

	private static readonly System.IntPtr NativeFieldInfoPtr_onDebugDataCaptured;

	private static readonly System.IntPtr NativeFieldInfoPtr_registeredGlobals;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_PassNameDebugIgnoreList;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileNativeRenderGraph_Internal_NativePassCompiler_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteNativeRenderGraph_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nativeRenderPassesEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_nativeRenderPassesEnabled_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Private_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestCaptureDebugData_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isRenderGraphViewerActive_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isRenderGraphViewerActive_Internal_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enableValidityChecks_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enableValidityChecks_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_debugParams_Internal_get_RenderGraphDebugParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWidgetList_Internal_List_1_Widget_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_areAnySettingsActive_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDebug_Public_Void_Panel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterDebug_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRegisteredRenderGraphs_Public_Static_List_1_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugData_Internal_DebugData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_ImportResourceParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_RenderTargetInfo_ImportResourceParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_RTHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_RenderTargetInfo_ImportResourceParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_byref_TextureDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSharedTexture_Public_TextureHandle_byref_TextureDesc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSharedTextureDesc_Public_Void_TextureHandle_byref_TextureDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseSharedTexture_Public_Void_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTextureIfInvalid_Public_Void_byref_TextureDesc_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureDesc_Public_TextureDesc_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTargetInfo_Public_RenderTargetInfo_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererListHandle_byref_ShadowDrawingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererListHandle_byref_Camera_byref_GizmoSubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererListHandle_byref_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererListHandle_byref_Camera_byref_UISubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererListHandle_byref_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportBuffer_Public_BufferHandle_GraphicsBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBuffer_Public_BufferHandle_byref_BufferDesc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBuffer_Public_BufferHandle_byref_BufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferDesc_Public_BufferDesc_byref_BufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportRayTracingAccelerationStructure_Public_RayTracingAccelerationStructureHandle_byref_RayTracingAccelerationStructure_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginRecording_Public_Void_byref_RenderGraphParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndRecordingAndExecute_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginProfilingSampler_Public_Void_ProfilingSampler_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndProfilingSampler_Public_Void_ProfilingSampler_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompiledPassInfos_Internal_DynamicArray_1_CompiledPassInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCompiledGraph_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCompiledGraph_Private_Void_CompiledGraph_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateContext_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPassAdded_Internal_Void_RenderGraphPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onGraphRegistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onGraphRegistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onGraphUnregistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onGraphUnregistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onExecutionRegistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onExecutionRegistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onExecutionUnregistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onExecutionUnregistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onDebugDataCaptured_Internal_Static_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onDebugDataCaptured_Internal_Static_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeGraphHash_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountReferences_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CullUnusedPasses_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePassSynchronization_Private_Void_byref_CompiledPassInfo_byref_CompiledPassInfo_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateResourceSynchronization_Private_Void_byref_Int32_byref_Int32_Int32_byref_CompiledResourceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstValidConsumerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTextureProducer_Private_Int32_Int32_byref_CompiledResourceInfo_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestProducerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestValidReadIndex_Private_Int32_byref_CompiledResourceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLatestValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererLists_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetImportedFallback_Internal_Boolean_TextureDesc_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateCulledPassResources_Private_Void_byref_CompiledPassInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateResourceAllocationAndSynchronization_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAllSharedResourceLastFrameIndex_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AreRendererListsEmpty_Private_Boolean_List_1_RendererListHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCullPassAtIndex_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CullRendererLists_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCurrentCompiledGraph_Private_Boolean_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileRenderGraph_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompilePassImmediatly_Private_byref_CompiledPassInfo_RenderGraphPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecutePassImmediately_Private_Void_RenderGraphPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCompiledPass_Private_Void_byref_CompiledPassInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteRenderGraph_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreRenderPassSetRenderTargets_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearRenderPasses_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseImmediateModeResources_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogFrameInformation_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogRendererListsCreation_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogRenderPassBegin_Private_Void_byref_CompiledPassInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogCulledPasses_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultProfilingSampler_Private_ProfilingSampler_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateImportedResourceLifeTime_Private_Void_byref_ResourceData_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDebugData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCompilerDebugData_Private_Void_byref_DebugData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupDebugData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGlobal_Internal_Void_TextureHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGlobal_Internal_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllGlobals_Internal_ValueCollection_Int32_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobal_Internal_TextureHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearGlobalBindings_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPassDebugMetadata_Private_Void_RenderGraphPass_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearPassDebugMetadata_Private_Void_0;

	public unsafe NativePassCompiler nativeCompiler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativeCompiler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NativePassCompiler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nativeCompiler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int kMaxMRTCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxMRTCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxMRTCount, (void*)(&value));
		}
	}

	public unsafe bool _nativeRenderPassesEnabled_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nativeRenderPassesEnabled_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nativeRenderPassesEnabled_k__BackingField)) = value;
		}
	}

	public unsafe RenderGraphResourceRegistry m_Resources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Resources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphResourceRegistry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Resources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphObjectPool m_RenderGraphPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphObjectPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphBuilders m_builderInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_builderInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphBuilders>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_builderInstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe List<RendererListHandle> m_RendererLists
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererLists);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RendererListHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererLists)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphDebugParams m_DebugParameters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugParameters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphDebugParams>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugParameters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphLogger m_FrameInformationLogger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameInformationLogger);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphLogger>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameInformationLogger)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderGraphDefaultResources m_DefaultResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultResources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphDefaultResources>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultResources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, ProfilingSampler> m_DefaultProfilingSamplers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultProfilingSamplers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, ProfilingSampler>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultProfilingSamplers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InternalRenderGraphContext m_RenderGraphContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InternalRenderGraphContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderGraphContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CommandBuffer m_PreviousCommandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreviousCommandBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreviousCommandBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<List<int>> m_ImmediateModeResourceList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ImmediateModeResourceList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ImmediateModeResourceList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe Il2CppReferenceArray<Il2CppStructArray<RenderTargetIdentifier>> m_TempMRTArrays
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempMRTArrays);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<RenderTargetIdentifier>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TempMRTArrays)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Stack<int> m_CullingStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullingStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullingStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_CurrentExecutionName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentExecutionName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentExecutionName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int m_ExecutionCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionCount)) = value;
		}
	}

	public unsafe int m_CurrentFrameIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFrameIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentFrameIndex)) = value;
		}
	}

	public unsafe int m_CurrentImmediatePassIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentImmediatePassIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentImmediatePassIndex)) = value;
		}
	}

	public unsafe bool m_ExecutionExceptionWasRaised
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionExceptionWasRaised);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ExecutionExceptionWasRaised)) = value;
		}
	}

	public unsafe bool m_HasRenderGraphBegun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasRenderGraphBegun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasRenderGraphBegun)) = value;
		}
	}

	public unsafe bool m_RendererListCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererListCulling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererListCulling)) = value;
		}
	}

	public unsafe bool m_EnableCompilationCaching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableCompilationCaching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableCompilationCaching)) = value;
		}
	}

	public unsafe CompiledGraph m_DefaultCompiledGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultCompiledGraph);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompiledGraph>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultCompiledGraph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CompiledGraph m_CurrentCompiledGraph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentCompiledGraph);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompiledGraph>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentCompiledGraph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_CaptureDebugDataForExecution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CaptureDebugDataForExecution);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CaptureDebugDataForExecution)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Dictionary<string, DebugData> m_DebugData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, DebugData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<RenderGraph> s_RegisteredGraphs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RegisteredGraphs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RenderGraph>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RegisteredGraphs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _name_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static bool _isRenderGraphViewerActive_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__isRenderGraphViewerActive_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__isRenderGraphViewerActive_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool _enableValidityChecks_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__enableValidityChecks_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__enableValidityChecks_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static string k_BeginProfilingSamplerPassName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_BeginProfilingSamplerPassName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_BeginProfilingSamplerPassName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_EndProfilingSamplerPassName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EndProfilingSamplerPassName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EndProfilingSamplerPassName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static OnGraphRegisteredDelegate onGraphRegistered
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onGraphRegistered, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnGraphRegisteredDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onGraphRegistered, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static OnGraphRegisteredDelegate onGraphUnregistered
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onGraphUnregistered, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnGraphRegisteredDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onGraphUnregistered, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static OnExecutionRegisteredDelegate onExecutionRegistered
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onExecutionRegistered, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnExecutionRegisteredDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onExecutionRegistered, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static OnExecutionRegisteredDelegate onExecutionUnregistered
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onExecutionUnregistered, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnExecutionRegisteredDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onExecutionUnregistered, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action onDebugDataCaptured
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onDebugDataCaptured, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onDebugDataCaptured, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, TextureHandle> registeredGlobals
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_registeredGlobals);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TextureHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_registeredGlobals)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray k_PassNameDebugIgnoreList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_PassNameDebugIgnoreList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_PassNameDebugIgnoreList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool nativeRenderPassesEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nativeRenderPassesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nativeRenderPassesEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202047, RefRangeEnd = 202048, XrefRangeStart = 202047, XrefRangeEnd = 202048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool isRenderGraphViewerActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055857, XrefRangeEnd = 1055861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRenderGraphViewerActive_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055861, XrefRangeEnd = 1055865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isRenderGraphViewerActive_Internal_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool enableValidityChecks
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055865, XrefRangeEnd = 1055869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enableValidityChecks_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055869, XrefRangeEnd = 1055873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enableValidityChecks_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RenderGraphDefaultResources defaultResources
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphDefaultResources>(intPtr2) : null;
		}
	}

	public unsafe RenderGraphDebugParams debugParams
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugParams_Internal_get_RenderGraphDebugParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraphDebugParams>(intPtr2) : null;
		}
	}

	public unsafe bool areAnySettingsActive
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1056049, RefRangeEnd = 1056050, XrefRangeStart = 1056049, XrefRangeEnd = 1056049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_areAnySettingsActive_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RenderGraph()
	{
		Il2CppClassPointerStore<RenderGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RenderGraph");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr);
		NativeFieldInfoPtr_nativeCompiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "nativeCompiler");
		NativeFieldInfoPtr_kMaxMRTCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "kMaxMRTCount");
		NativeFieldInfoPtr__nativeRenderPassesEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "<nativeRenderPassesEnabled>k__BackingField");
		NativeFieldInfoPtr_m_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_Resources");
		NativeFieldInfoPtr_m_RenderGraphPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RenderGraphPool");
		NativeFieldInfoPtr_m_builderInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_builderInstance");
		NativeFieldInfoPtr_m_RenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RenderPasses");
		NativeFieldInfoPtr_m_RendererLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RendererLists");
		NativeFieldInfoPtr_m_DebugParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DebugParameters");
		NativeFieldInfoPtr_m_FrameInformationLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_FrameInformationLogger");
		NativeFieldInfoPtr_m_DefaultResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DefaultResources");
		NativeFieldInfoPtr_m_DefaultProfilingSamplers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DefaultProfilingSamplers");
		NativeFieldInfoPtr_m_RenderGraphContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RenderGraphContext");
		NativeFieldInfoPtr_m_PreviousCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_PreviousCommandBuffer");
		NativeFieldInfoPtr_m_ImmediateModeResourceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_ImmediateModeResourceList");
		NativeFieldInfoPtr_m_CompilationCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CompilationCache");
		NativeFieldInfoPtr_m_TempMRTArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_TempMRTArrays");
		NativeFieldInfoPtr_m_CullingStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CullingStack");
		NativeFieldInfoPtr_m_CurrentExecutionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CurrentExecutionName");
		NativeFieldInfoPtr_m_ExecutionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_ExecutionCount");
		NativeFieldInfoPtr_m_CurrentFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CurrentFrameIndex");
		NativeFieldInfoPtr_m_CurrentImmediatePassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CurrentImmediatePassIndex");
		NativeFieldInfoPtr_m_ExecutionExceptionWasRaised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_ExecutionExceptionWasRaised");
		NativeFieldInfoPtr_m_HasRenderGraphBegun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_HasRenderGraphBegun");
		NativeFieldInfoPtr_m_RendererListCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_RendererListCulling");
		NativeFieldInfoPtr_m_EnableCompilationCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_EnableCompilationCaching");
		NativeFieldInfoPtr_m_DefaultCompiledGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DefaultCompiledGraph");
		NativeFieldInfoPtr_m_CurrentCompiledGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CurrentCompiledGraph");
		NativeFieldInfoPtr_m_CaptureDebugDataForExecution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_CaptureDebugDataForExecution");
		NativeFieldInfoPtr_m_DebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "m_DebugData");
		NativeFieldInfoPtr_s_RegisteredGraphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "s_RegisteredGraphs");
		NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "<name>k__BackingField");
		NativeFieldInfoPtr__isRenderGraphViewerActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "<isRenderGraphViewerActive>k__BackingField");
		NativeFieldInfoPtr__enableValidityChecks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "<enableValidityChecks>k__BackingField");
		NativeFieldInfoPtr_k_BeginProfilingSamplerPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "k_BeginProfilingSamplerPassName");
		NativeFieldInfoPtr_k_EndProfilingSamplerPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "k_EndProfilingSamplerPassName");
		NativeFieldInfoPtr_onGraphRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onGraphRegistered");
		NativeFieldInfoPtr_onGraphUnregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onGraphUnregistered");
		NativeFieldInfoPtr_onExecutionRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onExecutionRegistered");
		NativeFieldInfoPtr_onExecutionUnregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onExecutionUnregistered");
		NativeFieldInfoPtr_onDebugDataCaptured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "onDebugDataCaptured");
		NativeFieldInfoPtr_registeredGlobals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "registeredGlobals");
		NativeFieldInfoPtr_k_PassNameDebugIgnoreList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, "k_PassNameDebugIgnoreList");
		NativeMethodInfoPtr_CompileNativeRenderGraph_Internal_NativePassCompiler_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667123);
		NativeMethodInfoPtr_ExecuteNativeRenderGraph_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667124);
		NativeMethodInfoPtr_get_nativeRenderPassesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667125);
		NativeMethodInfoPtr_set_nativeRenderPassesEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667126);
		NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667127);
		NativeMethodInfoPtr_set_name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667128);
		NativeMethodInfoPtr_RequestCaptureDebugData_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667129);
		NativeMethodInfoPtr_get_isRenderGraphViewerActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667130);
		NativeMethodInfoPtr_set_isRenderGraphViewerActive_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667131);
		NativeMethodInfoPtr_get_enableValidityChecks_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667132);
		NativeMethodInfoPtr_set_enableValidityChecks_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667133);
		NativeMethodInfoPtr_get_defaultResources_Public_get_RenderGraphDefaultResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667134);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667135);
		NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667136);
		NativeMethodInfoPtr_get_debugParams_Internal_get_RenderGraphDebugParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667137);
		NativeMethodInfoPtr_GetWidgetList_Internal_List_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667138);
		NativeMethodInfoPtr_get_areAnySettingsActive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667139);
		NativeMethodInfoPtr_RegisterDebug_Public_Void_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667140);
		NativeMethodInfoPtr_UnRegisterDebug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667141);
		NativeMethodInfoPtr_GetRegisteredRenderGraphs_Public_Static_List_1_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667142);
		NativeMethodInfoPtr_GetDebugData_Internal_DebugData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667143);
		NativeMethodInfoPtr_EndFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667144);
		NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667145);
		NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_ImportResourceParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667146);
		NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_RenderTargetInfo_ImportResourceParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667147);
		NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_RTHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667148);
		NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_RenderTargetInfo_ImportResourceParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667149);
		NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667150);
		NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667151);
		NativeMethodInfoPtr_CreateSharedTexture_Public_TextureHandle_byref_TextureDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667152);
		NativeMethodInfoPtr_RefreshSharedTextureDesc_Public_Void_TextureHandle_byref_TextureDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667153);
		NativeMethodInfoPtr_ReleaseSharedTexture_Public_Void_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667154);
		NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667155);
		NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667156);
		NativeMethodInfoPtr_CreateTextureIfInvalid_Public_Void_byref_TextureDesc_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667157);
		NativeMethodInfoPtr_GetTextureDesc_Public_TextureDesc_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667158);
		NativeMethodInfoPtr_GetRenderTargetInfo_Public_RenderTargetInfo_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667159);
		NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667160);
		NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667161);
		NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererListHandle_byref_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667162);
		NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererListHandle_byref_Camera_byref_GizmoSubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667163);
		NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererListHandle_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667164);
		NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererListHandle_byref_Camera_byref_UISubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667165);
		NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererListHandle_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667166);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667167);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667168);
		NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667169);
		NativeMethodInfoPtr_ImportBuffer_Public_BufferHandle_GraphicsBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667170);
		NativeMethodInfoPtr_CreateBuffer_Public_BufferHandle_byref_BufferDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667171);
		NativeMethodInfoPtr_CreateBuffer_Public_BufferHandle_byref_BufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667172);
		NativeMethodInfoPtr_GetBufferDesc_Public_BufferDesc_byref_BufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667173);
		NativeMethodInfoPtr_ImportRayTracingAccelerationStructure_Public_RayTracingAccelerationStructureHandle_byref_RayTracingAccelerationStructure_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667174);
		NativeMethodInfoPtr_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667175);
		NativeMethodInfoPtr_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667176);
		NativeMethodInfoPtr_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667177);
		NativeMethodInfoPtr_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667178);
		NativeMethodInfoPtr_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667179);
		NativeMethodInfoPtr_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667180);
		NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667181);
		NativeMethodInfoPtr_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667182);
		NativeMethodInfoPtr_BeginRecording_Public_Void_byref_RenderGraphParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667183);
		NativeMethodInfoPtr_EndRecordingAndExecute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667184);
		NativeMethodInfoPtr_Execute_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667185);
		NativeMethodInfoPtr_BeginProfilingSampler_Public_Void_ProfilingSampler_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667186);
		NativeMethodInfoPtr_EndProfilingSampler_Public_Void_ProfilingSampler_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667187);
		NativeMethodInfoPtr_GetCompiledPassInfos_Internal_DynamicArray_1_CompiledPassInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667188);
		NativeMethodInfoPtr_ClearCompiledGraph_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667189);
		NativeMethodInfoPtr_ClearCompiledGraph_Private_Void_CompiledGraph_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667190);
		NativeMethodInfoPtr_InvalidateContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667191);
		NativeMethodInfoPtr_OnPassAdded_Internal_Void_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667192);
		NativeMethodInfoPtr_add_onGraphRegistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667193);
		NativeMethodInfoPtr_remove_onGraphRegistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667194);
		NativeMethodInfoPtr_add_onGraphUnregistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667195);
		NativeMethodInfoPtr_remove_onGraphUnregistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667196);
		NativeMethodInfoPtr_add_onExecutionRegistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667197);
		NativeMethodInfoPtr_remove_onExecutionRegistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667198);
		NativeMethodInfoPtr_add_onExecutionUnregistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667199);
		NativeMethodInfoPtr_remove_onExecutionUnregistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667200);
		NativeMethodInfoPtr_add_onDebugDataCaptured_Internal_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667201);
		NativeMethodInfoPtr_remove_onDebugDataCaptured_Internal_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667202);
		NativeMethodInfoPtr_ComputeGraphHash_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667203);
		NativeMethodInfoPtr_CountReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667204);
		NativeMethodInfoPtr_CullUnusedPasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667205);
		NativeMethodInfoPtr_UpdatePassSynchronization_Private_Void_byref_CompiledPassInfo_byref_CompiledPassInfo_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667206);
		NativeMethodInfoPtr_UpdateResourceSynchronization_Private_Void_byref_Int32_byref_Int32_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667207);
		NativeMethodInfoPtr_GetFirstValidConsumerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667208);
		NativeMethodInfoPtr_FindTextureProducer_Private_Int32_Int32_byref_CompiledResourceInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667209);
		NativeMethodInfoPtr_GetLatestProducerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667210);
		NativeMethodInfoPtr_GetLatestValidReadIndex_Private_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667211);
		NativeMethodInfoPtr_GetFirstValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667212);
		NativeMethodInfoPtr_GetLatestValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667213);
		NativeMethodInfoPtr_CreateRendererLists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667214);
		NativeMethodInfoPtr_GetImportedFallback_Internal_Boolean_TextureDesc_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667215);
		NativeMethodInfoPtr_AllocateCulledPassResources_Private_Void_byref_CompiledPassInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667216);
		NativeMethodInfoPtr_UpdateResourceAllocationAndSynchronization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667217);
		NativeMethodInfoPtr_UpdateAllSharedResourceLastFrameIndex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667218);
		NativeMethodInfoPtr_AreRendererListsEmpty_Private_Boolean_List_1_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667219);
		NativeMethodInfoPtr_TryCullPassAtIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667220);
		NativeMethodInfoPtr_CullRendererLists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667221);
		NativeMethodInfoPtr_UpdateCurrentCompiledGraph_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667222);
		NativeMethodInfoPtr_CompileRenderGraph_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667223);
		NativeMethodInfoPtr_CompilePassImmediatly_Private_byref_CompiledPassInfo_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667224);
		NativeMethodInfoPtr_ExecutePassImmediately_Private_Void_RenderGraphPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667225);
		NativeMethodInfoPtr_ExecuteCompiledPass_Private_Void_byref_CompiledPassInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667226);
		NativeMethodInfoPtr_ExecuteRenderGraph_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667227);
		NativeMethodInfoPtr_PreRenderPassSetRenderTargets_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667228);
		NativeMethodInfoPtr_PreRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667229);
		NativeMethodInfoPtr_PostRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667230);
		NativeMethodInfoPtr_ClearRenderPasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667231);
		NativeMethodInfoPtr_ReleaseImmediateModeResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667232);
		NativeMethodInfoPtr_LogFrameInformation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667233);
		NativeMethodInfoPtr_LogRendererListsCreation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667234);
		NativeMethodInfoPtr_LogRenderPassBegin_Private_Void_byref_CompiledPassInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667235);
		NativeMethodInfoPtr_LogCulledPasses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667236);
		NativeMethodInfoPtr_GetDefaultProfilingSampler_Private_ProfilingSampler_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667237);
		NativeMethodInfoPtr_UpdateImportedResourceLifeTime_Private_Void_byref_ResourceData_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667238);
		NativeMethodInfoPtr_GenerateDebugData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667239);
		NativeMethodInfoPtr_GenerateCompilerDebugData_Private_Void_byref_DebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667240);
		NativeMethodInfoPtr_CleanupDebugData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667241);
		NativeMethodInfoPtr_SetGlobal_Internal_Void_TextureHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667242);
		NativeMethodInfoPtr_IsGlobal_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667243);
		NativeMethodInfoPtr_AllGlobals_Internal_ValueCollection_Int32_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667244);
		NativeMethodInfoPtr_GetGlobal_Internal_TextureHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667245);
		NativeMethodInfoPtr_ClearGlobalBindings_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667246);
		NativeMethodInfoPtr_AddPassDebugMetadata_Private_Void_RenderGraphPass_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667247);
		NativeMethodInfoPtr_ClearPassDebugMetadata_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr, 100667248);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1055842, RefRangeEnd = 1055843, XrefRangeStart = 1055814, XrefRangeEnd = 1055842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativePassCompiler CompileNativeRenderGraph(int graphHash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&graphHash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileNativeRenderGraph_Internal_NativePassCompiler_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NativePassCompiler>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1055856, RefRangeEnd = 1055857, XrefRangeStart = 1055843, XrefRangeEnd = 1055856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteNativeRenderGraph()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteNativeRenderGraph_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestCaptureDebugData(string executionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(executionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestCaptureDebugData_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056024, RefRangeEnd = 1056025, XrefRangeStart = 1055873, XrefRangeEnd = 1056024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderGraph(string name = "RenderGraph")
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraph>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056045, RefRangeEnd = 1056046, XrefRangeStart = 1056025, XrefRangeEnd = 1056045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056048, RefRangeEnd = 1056049, XrefRangeStart = 1056046, XrefRangeEnd = 1056048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DebugUI.Widget> GetWidgetList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWidgetList_Internal_List_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DebugUI.Widget>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056050, XrefRangeEnd = 1056067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDebug(DebugUI.Panel panel = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)panel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDebug_Public_Void_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056067, XrefRangeEnd = 1056073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnRegisterDebug()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterDebug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056073, XrefRangeEnd = 1056077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<RenderGraph> GetRegisteredRenderGraphs()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRegisteredRenderGraphs_Public_Static_List_1_RenderGraph_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RenderGraph>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056077, XrefRangeEnd = 1056080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugData GetDebugData(string executionName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(executionName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDebugData_Internal_DebugData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugData>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056087, RefRangeEnd = 1056088, XrefRangeStart = 1056080, XrefRangeEnd = 1056087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1056089, RefRangeEnd = 1056110, XrefRangeStart = 1056088, XrefRangeEnd = 1056089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportTexture(RTHandle rt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1056111, RefRangeEnd = 1056116, XrefRangeStart = 1056110, XrefRangeEnd = 1056111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportTexture(RTHandle rt, ImportResourceParams importParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*(ImportResourceParams**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &importParams;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_ImportResourceParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1056117, RefRangeEnd = 1056123, XrefRangeStart = 1056116, XrefRangeEnd = 1056117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportTexture(RTHandle rt, RenderTargetInfo info, ImportResourceParams importParams = default(ImportResourceParams))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*(RenderTargetInfo**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		*(ImportResourceParams**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &importParams;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTexture_Public_TextureHandle_RTHandle_RenderTargetInfo_ImportResourceParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1056124, RefRangeEnd = 1056134, XrefRangeStart = 1056123, XrefRangeEnd = 1056124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportTexture(RTHandle rt, bool isBuiltin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isBuiltin;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportTexture_Internal_TextureHandle_RTHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056134, XrefRangeEnd = 1056135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportBackbuffer(RenderTargetIdentifier rt, RenderTargetInfo info, ImportResourceParams importParams = default(ImportResourceParams))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rt);
		*(RenderTargetInfo**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		*(ImportResourceParams**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &importParams;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_RenderTargetInfo_ImportResourceParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056135, XrefRangeEnd = 1056136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportBackbuffer_Public_TextureHandle_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 1056137, RefRangeEnd = 1056156, XrefRangeStart = 1056136, XrefRangeEnd = 1056137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle CreateTexture([In] ref TextureDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056156, XrefRangeEnd = 1056157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle CreateSharedTexture([In] ref TextureDesc desc, bool explicitRelease = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &explicitRelease;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSharedTexture_Public_TextureHandle_byref_TextureDesc_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056157, XrefRangeEnd = 1056158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshSharedTextureDesc(TextureHandle handle, [In] ref TextureDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshSharedTextureDesc_Public_Void_TextureHandle_byref_TextureDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056158, XrefRangeEnd = 1056159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseSharedTexture(TextureHandle texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseSharedTexture_Public_Void_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056159, XrefRangeEnd = 1056161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle CreateTexture(TextureHandle texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056164, RefRangeEnd = 1056165, XrefRangeStart = 1056161, XrefRangeEnd = 1056164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle CreateTexture(TextureHandle texture, string name, bool clear = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&texture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &clear;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTexture_Public_TextureHandle_TextureHandle_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056165, XrefRangeEnd = 1056173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateTextureIfInvalid([In] ref TextureDesc desc, ref TextureHandle texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTextureIfInvalid_Public_Void_byref_TextureDesc_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1056174, RefRangeEnd = 1056183, XrefRangeStart = 1056173, XrefRangeEnd = 1056174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureDesc GetTextureDesc(TextureHandle texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureDesc_Public_TextureDesc_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TextureDesc(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1056184, RefRangeEnd = 1056187, XrefRangeStart = 1056183, XrefRangeEnd = 1056184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetInfo GetRenderTargetInfo(TextureHandle texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&texture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderTargetInfo_Public_RenderTargetInfo_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTargetInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056187, XrefRangeEnd = 1056188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateRendererList([In] ref RendererListDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1056189, RefRangeEnd = 1056199, XrefRangeStart = 1056188, XrefRangeEnd = 1056189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateRendererList([In] ref RendererListParams desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Public_RendererListHandle_byref_RendererListParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1056200, RefRangeEnd = 1056203, XrefRangeStart = 1056199, XrefRangeEnd = 1056200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateShadowRendererList(ref ShadowDrawingSettings shadowDrawingSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref shadowDrawingSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShadowRendererList_Public_RendererListHandle_byref_ShadowDrawingSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056203, XrefRangeEnd = 1056204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateGizmoRendererList([In] ref Camera camera, [In] ref GizmoSubset gizmoSubset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref gizmoSubset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGizmoRendererList_Public_RendererListHandle_byref_Camera_byref_GizmoSubset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056204, XrefRangeEnd = 1056205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateUIOverlayRendererList([In] ref Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererListHandle_byref_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1056206, RefRangeEnd = 1056210, XrefRangeStart = 1056205, XrefRangeEnd = 1056206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateUIOverlayRendererList([In] ref Camera camera, [In] ref UISubset uiSubset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref uiSubset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIOverlayRendererList_Public_RendererListHandle_byref_Camera_byref_UISubset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056210, XrefRangeEnd = 1056211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateWireOverlayRendererList([In] ref Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWireOverlayRendererList_Public_RendererListHandle_byref_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056212, RefRangeEnd = 1056213, XrefRangeStart = 1056211, XrefRangeEnd = 1056212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateSkyboxRendererList([In] ref Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056214, RefRangeEnd = 1056215, XrefRangeStart = 1056213, XrefRangeEnd = 1056214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateSkyboxRendererList([In] ref Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*ptr = (nint)(&intPtr);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrix;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrix;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_Matrix4x4_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056216, RefRangeEnd = 1056217, XrefRangeStart = 1056215, XrefRangeEnd = 1056216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererListHandle CreateSkyboxRendererList([In] ref Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*ptr = (nint)(&intPtr);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrixL;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrixL;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &projectionMatrixR;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrixR;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSkyboxRendererList_Public_RendererListHandle_byref_Camera_Matrix4x4_Matrix4x4_Matrix4x4_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		camera = ((intPtr4 == (System.IntPtr)0) ? null : new Camera(intPtr4));
		return *(RendererListHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1056218, RefRangeEnd = 1056225, XrefRangeStart = 1056217, XrefRangeEnd = 1056218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferHandle ImportBuffer(GraphicsBuffer graphicsBuffer, bool forceRelease = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graphicsBuffer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceRelease;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportBuffer_Public_BufferHandle_GraphicsBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056225, XrefRangeEnd = 1056226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferHandle CreateBuffer([In] ref BufferDesc desc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBuffer_Public_BufferHandle_byref_BufferDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056226, XrefRangeEnd = 1056228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferHandle CreateBuffer([In] ref BufferHandle graphicsBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref graphicsBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBuffer_Public_BufferHandle_byref_BufferHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(BufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056228, XrefRangeEnd = 1056229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferDesc GetBufferDesc([In] ref BufferHandle graphicsBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref graphicsBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferDesc_Public_BufferDesc_byref_BufferHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BufferDesc(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056229, XrefRangeEnd = 1056230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RayTracingAccelerationStructureHandle ImportRayTracingAccelerationStructure([In] ref RayTracingAccelerationStructure accelStruct, string name = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accelStruct);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportRayTracingAccelerationStructure_Public_RayTracingAccelerationStructureHandle_byref_RayTracingAccelerationStructure_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		accelStruct = ((intPtr4 == (System.IntPtr)0) ? null : new RayTracingAccelerationStructure(intPtr4));
		return *(RayTracingAccelerationStructureHandle*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1056233, RefRangeEnd = 1056235, XrefRangeStart = 1056230, XrefRangeEnd = 1056233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, out PassData passData, string file = "", int line = 0) where PassData : class, new()
	{
		//IL_003f->IL0041: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref PassData reference;
		if (!typeof(PassData).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref passData;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_String_Int32_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(PassData).IsValueType)
		{
			nint num3 = num2;
			passData = ((num3 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>((System.IntPtr)num3, false, false));
		}
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IRasterRenderGraphBuilder>(intPtr2) : null;
	}

	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 1056256, RefRangeEnd = 1056311, XrefRangeStart = 1056235, XrefRangeEnd = 1056256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IRasterRenderGraphBuilder AddRasterRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) where PassData : class, new()
	{
		//IL_003f->IL0041: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref PassData reference;
		if (!typeof(PassData).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref passData;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sampler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddRasterRenderPass_Public_IRasterRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(PassData).IsValueType)
		{
			nint num3 = num2;
			passData = ((num3 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>((System.IntPtr)num3, false, false));
		}
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IRasterRenderGraphBuilder>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056311, XrefRangeEnd = 1056314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, out PassData passData, string file = "", int line = 0) where PassData : class, new()
	{
		//IL_003f->IL0041: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref PassData reference;
		if (!typeof(PassData).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref passData;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_String_Int32_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(PassData).IsValueType)
		{
			nint num3 = num2;
			passData = ((num3 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>((System.IntPtr)num3, false, false));
		}
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IComputeRenderGraphBuilder>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1056335, RefRangeEnd = 1056343, XrefRangeStart = 1056314, XrefRangeEnd = 1056335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IComputeRenderGraphBuilder AddComputePass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) where PassData : class, new()
	{
		//IL_003f->IL0041: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref PassData reference;
		if (!typeof(PassData).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref passData;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sampler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddComputePass_Public_IComputeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(PassData).IsValueType)
		{
			nint num3 = num2;
			passData = ((num3 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>((System.IntPtr)num3, false, false));
		}
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IComputeRenderGraphBuilder>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1056346, RefRangeEnd = 1056352, XrefRangeStart = 1056343, XrefRangeEnd = 1056346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, out PassData passData, string file = "", int line = 0) where PassData : class, new()
	{
		//IL_003f->IL0041: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref PassData reference;
		if (!typeof(PassData).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref passData;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_String_Int32_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(PassData).IsValueType)
		{
			nint num3 = num2;
			passData = ((num3 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>((System.IntPtr)num3, false, false));
		}
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IUnsafeRenderGraphBuilder>(intPtr2) : null;
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1056373, RefRangeEnd = 1056389, XrefRangeStart = 1056352, XrefRangeEnd = 1056373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IUnsafeRenderGraphBuilder AddUnsafePass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) where PassData : class, new()
	{
		//IL_003f->IL0041: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref PassData reference;
		if (!typeof(PassData).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref passData;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sampler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddUnsafePass_Public_IUnsafeRenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(PassData).IsValueType)
		{
			nint num3 = num2;
			passData = ((num3 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>((System.IntPtr)num3, false, false));
		}
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IUnsafeRenderGraphBuilder>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1056410, RefRangeEnd = 1056413, XrefRangeStart = 1056389, XrefRangeEnd = 1056410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, ProfilingSampler sampler, string file = "", int line = 0) where PassData : class, new()
	{
		//IL_003f->IL0041: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref PassData reference;
		if (!typeof(PassData).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref passData;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sampler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_ProfilingSampler_String_Int32_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(PassData).IsValueType)
		{
			nint num3 = num2;
			passData = ((num3 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>((System.IntPtr)num3, false, false));
		}
		return new RenderGraphBuilder(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056416, RefRangeEnd = 1056417, XrefRangeStart = 1056413, XrefRangeEnd = 1056416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderGraphBuilder AddRenderPass<PassData>(string passName, out PassData passData, string file = "", int line = 0) where PassData : class, new()
	{
		//IL_003f->IL0041: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref PassData reference;
		if (!typeof(PassData).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref passData;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddRenderPass_Public_RenderGraphBuilder_String_byref_PassData_String_Int32_0<PassData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(PassData).IsValueType)
		{
			nint num3 = num2;
			passData = ((num3 == 0) ? null : IL2CPP.PointerToValueGeneric<PassData>((System.IntPtr)num3, false, false));
		}
		return new RenderGraphBuilder(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1056446, RefRangeEnd = 1056448, XrefRangeStart = 1056417, XrefRangeEnd = 1056446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginRecording([In] ref RenderGraphParameters parameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginRecording_Public_Void_byref_RenderGraphParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1056449, RefRangeEnd = 1056451, XrefRangeStart = 1056448, XrefRangeEnd = 1056449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndRecordingAndExecute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndRecordingAndExecute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056473, RefRangeEnd = 1056474, XrefRangeStart = 1056451, XrefRangeEnd = 1056473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056474, XrefRangeEnd = 1056503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginProfilingSampler(ProfilingSampler sampler, string file = "", int line = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sampler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginProfilingSampler_Public_Void_ProfilingSampler_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056503, XrefRangeEnd = 1056532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndProfilingSampler(ProfilingSampler sampler, string file = "", int line = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sampler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndProfilingSampler_Public_Void_ProfilingSampler_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe DynamicArray<CompiledPassInfo> GetCompiledPassInfos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompiledPassInfos_Internal_DynamicArray_1_CompiledPassInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicArray<CompiledPassInfo>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056532, XrefRangeEnd = 1056539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCompiledGraph()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCompiledGraph_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056539, XrefRangeEnd = 1056546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCompiledGraph(CompiledGraph compiledGraph, bool useCompilationCaching)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compiledGraph);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useCompilationCaching;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCompiledGraph_Private_Void_CompiledGraph_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056546, XrefRangeEnd = 1056550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvalidateContext()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvalidateContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1056552, RefRangeEnd = 1056555, XrefRangeStart = 1056550, XrefRangeEnd = 1056552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPassAdded(RenderGraphPass pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPassAdded_Internal_Void_RenderGraphPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056555, XrefRangeEnd = 1056566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onGraphRegistered(OnGraphRegisteredDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onGraphRegistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056566, XrefRangeEnd = 1056577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onGraphRegistered(OnGraphRegisteredDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onGraphRegistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056577, XrefRangeEnd = 1056588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onGraphUnregistered(OnGraphRegisteredDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onGraphUnregistered_Internal_Static_add_Void_OnGraphRegisteredDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056588, XrefRangeEnd = 1056599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onGraphUnregistered(OnGraphRegisteredDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onGraphUnregistered_Internal_Static_rem_Void_OnGraphRegisteredDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056599, XrefRangeEnd = 1056610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onExecutionRegistered(OnExecutionRegisteredDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onExecutionRegistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056610, XrefRangeEnd = 1056621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onExecutionRegistered(OnExecutionRegisteredDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onExecutionRegistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056621, XrefRangeEnd = 1056632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onExecutionUnregistered(OnExecutionRegisteredDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onExecutionUnregistered_Internal_Static_add_Void_OnExecutionRegisteredDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056632, XrefRangeEnd = 1056643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onExecutionUnregistered(OnExecutionRegisteredDelegate value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onExecutionUnregistered_Internal_Static_rem_Void_OnExecutionRegisteredDelegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056643, XrefRangeEnd = 1056654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onDebugDataCaptured(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onDebugDataCaptured_Internal_Static_add_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056654, XrefRangeEnd = 1056665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onDebugDataCaptured(Il2CppSystem.Action value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onDebugDataCaptured_Internal_Static_rem_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056678, RefRangeEnd = 1056679, XrefRangeStart = 1056665, XrefRangeEnd = 1056678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ComputeGraphHash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeGraphHash_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056747, RefRangeEnd = 1056748, XrefRangeStart = 1056679, XrefRangeEnd = 1056747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CountReferences()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056813, RefRangeEnd = 1056814, XrefRangeStart = 1056748, XrefRangeEnd = 1056813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CullUnusedPasses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CullUnusedPasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void UpdatePassSynchronization(ref CompiledPassInfo currentPassInfo, ref CompiledPassInfo producerPassInfo, int currentPassIndex, int lastProducer, ref int intLastSyncIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)currentPassInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)producerPassInfo);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentPassIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastProducer;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref intLastSyncIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePassSynchronization_Private_Void_byref_CompiledPassInfo_byref_CompiledPassInfo_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1056825, RefRangeEnd = 1056827, XrefRangeStart = 1056814, XrefRangeEnd = 1056825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateResourceSynchronization(ref int lastGraphicsPipeSync, ref int lastComputePipeSync, int currentPassIndex, [In] ref CompiledResourceInfo resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref lastGraphicsPipeSync);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lastComputePipeSync);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentPassIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateResourceSynchronization_Private_Void_byref_Int32_byref_Int32_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056840, RefRangeEnd = 1056841, XrefRangeStart = 1056827, XrefRangeEnd = 1056840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFirstValidConsumerIndex(int passIndex, [In] ref CompiledResourceInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&passIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstValidConsumerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056849, RefRangeEnd = 1056850, XrefRangeStart = 1056841, XrefRangeEnd = 1056849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindTextureProducer(int consumerPass, [In] ref CompiledResourceInfo info, out int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&consumerPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTextureProducer_Private_Int32_Int32_byref_CompiledResourceInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056870, RefRangeEnd = 1056871, XrefRangeStart = 1056850, XrefRangeEnd = 1056870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLatestProducerIndex(int passIndex, [In] ref CompiledResourceInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&passIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLatestProducerIndex_Private_Int32_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1056878, RefRangeEnd = 1056882, XrefRangeStart = 1056871, XrefRangeEnd = 1056878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLatestValidReadIndex([In] ref CompiledResourceInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLatestValidReadIndex_Private_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1056892, RefRangeEnd = 1056895, XrefRangeStart = 1056882, XrefRangeEnd = 1056892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFirstValidWriteIndex([In] ref CompiledResourceInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1056902, RefRangeEnd = 1056904, XrefRangeStart = 1056895, XrefRangeEnd = 1056902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLatestValidWriteIndex([In] ref CompiledResourceInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLatestValidWriteIndex_Private_Int32_byref_CompiledResourceInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1056904, XrefRangeEnd = 1056916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRendererLists()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererLists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1056934, RefRangeEnd = 1056936, XrefRangeStart = 1056916, XrefRangeEnd = 1056934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetImportedFallback(TextureDesc desc, out TextureHandle fallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fallback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetImportedFallback_Internal_Boolean_TextureDesc_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1056971, RefRangeEnd = 1056972, XrefRangeStart = 1056936, XrefRangeEnd = 1056971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateCulledPassResources(ref CompiledPassInfo passInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)passInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateCulledPassResources_Private_Void_byref_CompiledPassInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057068, RefRangeEnd = 1057069, XrefRangeStart = 1056972, XrefRangeEnd = 1057068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateResourceAllocationAndSynchronization()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateResourceAllocationAndSynchronization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057069, XrefRangeEnd = 1057076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAllSharedResourceLastFrameIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAllSharedResourceLastFrameIndex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057092, RefRangeEnd = 1057093, XrefRangeStart = 1057076, XrefRangeEnd = 1057092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AreRendererListsEmpty(List<RendererListHandle> rendererLists)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rendererLists);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreRendererListsEmpty_Private_Boolean_List_1_RendererListHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1057100, RefRangeEnd = 1057102, XrefRangeStart = 1057093, XrefRangeEnd = 1057100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryCullPassAtIndex(int passIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&passIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCullPassAtIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057102, XrefRangeEnd = 1057112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CullRendererLists()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CullRendererLists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057112, XrefRangeEnd = 1057113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateCurrentCompiledGraph(int graphHash, bool forceNoCaching = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&graphHash);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceNoCaching;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCurrentCompiledGraph_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057170, RefRangeEnd = 1057171, XrefRangeStart = 1057113, XrefRangeEnd = 1057170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompileRenderGraph(int graphHash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&graphHash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileRenderGraph_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1057251, RefRangeEnd = 1057253, XrefRangeStart = 1057171, XrefRangeEnd = 1057251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref CompiledPassInfo CompilePassImmediatly(RenderGraphPass pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompilePassImmediatly_Private_byref_CompiledPassInfo_RenderGraphPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(CompiledPassInfo*)intPtr2;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057253, XrefRangeEnd = 1057255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecutePassImmediately(RenderGraphPass pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecutePassImmediately_Private_Void_RenderGraphPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1057271, RefRangeEnd = 1057274, XrefRangeStart = 1057255, XrefRangeEnd = 1057271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteCompiledPass(ref CompiledPassInfo passInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)passInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCompiledPass_Private_Void_byref_CompiledPassInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057287, RefRangeEnd = 1057288, XrefRangeStart = 1057274, XrefRangeEnd = 1057287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteRenderGraph()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteRenderGraph_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057307, RefRangeEnd = 1057308, XrefRangeStart = 1057288, XrefRangeEnd = 1057307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreRenderPassSetRenderTargets([In] ref CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)passInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreRenderPassSetRenderTargets_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057344, RefRangeEnd = 1057345, XrefRangeStart = 1057308, XrefRangeEnd = 1057344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreRenderPassExecute([In] ref CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)passInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057392, RefRangeEnd = 1057393, XrefRangeStart = 1057345, XrefRangeEnd = 1057392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostRenderPassExecute(ref CompiledPassInfo passInfo, RenderGraphPass pass, InternalRenderGraphContext rgContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)passInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostRenderPassExecute_Private_Void_byref_CompiledPassInfo_RenderGraphPass_InternalRenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1057409, RefRangeEnd = 1057412, XrefRangeStart = 1057393, XrefRangeEnd = 1057409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearRenderPasses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearRenderPasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057412, XrefRangeEnd = 1057428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseImmediateModeResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseImmediateModeResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1057448, RefRangeEnd = 1057450, XrefRangeStart = 1057428, XrefRangeEnd = 1057448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogFrameInformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogFrameInformation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057450, XrefRangeEnd = 1057461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogRendererListsCreation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogRendererListsCreation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057495, RefRangeEnd = 1057496, XrefRangeStart = 1057461, XrefRangeEnd = 1057495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogRenderPassBegin([In] ref CompiledPassInfo passInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)passInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogRenderPassBegin_Private_Void_byref_CompiledPassInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057531, RefRangeEnd = 1057532, XrefRangeStart = 1057496, XrefRangeEnd = 1057531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogCulledPasses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogCulledPasses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProfilingSampler GetDefaultProfilingSampler(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultProfilingSampler_Private_ProfilingSampler_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1057555, RefRangeEnd = 1057557, XrefRangeStart = 1057532, XrefRangeEnd = 1057555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateImportedResourceLifeTime(ref DebugData.ResourceData data, List<int> passList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateImportedResourceLifeTime_Private_Void_byref_ResourceData_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057557, XrefRangeEnd = 1057578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateDebugData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDebugData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057736, RefRangeEnd = 1057737, XrefRangeStart = 1057578, XrefRangeEnd = 1057736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateCompilerDebugData(ref DebugData debugData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugData);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCompilerDebugData_Private_Void_byref_DebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		debugData = ((intPtr4 == (System.IntPtr)0) ? null : new DebugData(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057737, XrefRangeEnd = 1057759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupDebugData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupDebugData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057769, RefRangeEnd = 1057770, XrefRangeStart = 1057759, XrefRangeEnd = 1057769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGlobal(TextureHandle h, int globalPropertyId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&h);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &globalPropertyId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGlobal_Internal_Void_TextureHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057770, XrefRangeEnd = 1057774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsGlobal(int globalPropertyId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&globalPropertyId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGlobal_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057778, RefRangeEnd = 1057779, XrefRangeStart = 1057774, XrefRangeEnd = 1057778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<int, TextureHandle>.ValueCollection AllGlobals()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllGlobals_Internal_ValueCollection_Int32_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TextureHandle>.ValueCollection>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057782, RefRangeEnd = 1057783, XrefRangeStart = 1057779, XrefRangeEnd = 1057782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle GetGlobal(int globalPropertyId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&globalPropertyId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobal_Internal_TextureHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1057803, RefRangeEnd = 1057804, XrefRangeStart = 1057783, XrefRangeEnd = 1057803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearGlobalBindings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearGlobalBindings_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057804, XrefRangeEnd = 1057818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPassDebugMetadata(RenderGraphPass renderPass, string file, int line)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &line;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPassDebugMetadata_Private_Void_RenderGraphPass_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1057818, XrefRangeEnd = 1057826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearPassDebugMetadata()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearPassDebugMetadata_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderGraph(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
