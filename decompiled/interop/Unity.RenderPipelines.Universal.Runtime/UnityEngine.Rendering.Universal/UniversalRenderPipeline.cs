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
using Il2CppSystem.Reflection;
using Unity.Collections;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public sealed class UniversalRenderPipeline : RenderPipeline
{
	public static class CameraMetadataCache : Il2CppSystem.Object
	{
		public class CameraMetadataCacheEntry : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			private static readonly System.IntPtr NativeFieldInfoPtr_sampler;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

			static CameraMetadataCacheEntry()
			{
				Il2CppClassPointerStore<CameraMetadataCacheEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraMetadataCache>.NativeClassPtr, "CameraMetadataCacheEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMetadataCacheEntry>.NativeClassPtr);
				NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMetadataCacheEntry>.NativeClassPtr, "name");
				NativeFieldInfoPtr_sampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMetadataCacheEntry>.NativeClassPtr, "sampler");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMetadataCacheEntry>.NativeClassPtr, 100665975);
			}

			[CallerCount(1950)]
			[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraMetadataCacheEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraMetadataCacheEntry>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public CameraMetadataCacheEntry(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_s_MetadataCache;

		private static readonly System.IntPtr NativeFieldInfoPtr_k_NoAllocEntry;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCached_Public_Static_CameraMetadataCacheEntry_Camera_0;

		public unsafe static Dictionary<int, CameraMetadataCacheEntry> s_MetadataCache
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MetadataCache, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CameraMetadataCacheEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MetadataCache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static CameraMetadataCacheEntry k_NoAllocEntry
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NoAllocEntry, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraMetadataCacheEntry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NoAllocEntry, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static CameraMetadataCache()
		{
			Il2CppClassPointerStore<CameraMetadataCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "CameraMetadataCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraMetadataCache>.NativeClassPtr);
			NativeFieldInfoPtr_s_MetadataCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMetadataCache>.NativeClassPtr, "s_MetadataCache");
			NativeFieldInfoPtr_k_NoAllocEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraMetadataCache>.NativeClassPtr, "k_NoAllocEntry");
			NativeMethodInfoPtr_GetCached_Public_Static_CameraMetadataCacheEntry_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraMetadataCache>.NativeClassPtr, 100665973);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104316, XrefRangeEnd = 1104343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CameraMetadataCacheEntry GetCached(Camera camera)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCached_Public_Static_CameraMetadataCacheEntry_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraMetadataCacheEntry>(intPtr2) : null;
		}

		public CameraMetadataCache(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class Profiling : Il2CppSystem.Object
	{
		public static class Pipeline : Il2CppSystem.Object
		{
			public static class Renderer : Il2CppSystem.Object
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_k_Name;

				private static readonly System.IntPtr NativeFieldInfoPtr_setupCullingParameters;

				private static readonly System.IntPtr NativeFieldInfoPtr_setup;

				public unsafe static string k_Name
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				public unsafe static ProfilingSampler setupCullingParameters
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setupCullingParameters, (void*)(&intPtr));
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setupCullingParameters, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
					}
				}

				public unsafe static ProfilingSampler setup
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setup, (void*)(&intPtr));
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
					}
				}

				static Renderer()
				{
					Il2CppClassPointerStore<Renderer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "Renderer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer>.NativeClassPtr);
					NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer>.NativeClassPtr, "k_Name");
					NativeFieldInfoPtr_setupCullingParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer>.NativeClassPtr, "setupCullingParameters");
					NativeFieldInfoPtr_setup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer>.NativeClassPtr, "setup");
				}

				public Renderer(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			public static class Context : Il2CppSystem.Object
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_k_Name;

				private static readonly System.IntPtr NativeFieldInfoPtr_submit;

				public unsafe static string k_Name
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				public unsafe static ProfilingSampler submit
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_submit, (void*)(&intPtr));
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_submit, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
					}
				}

				static Context()
				{
					Il2CppClassPointerStore<Context>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "Context");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Context>.NativeClassPtr);
					NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "k_Name");
					NativeFieldInfoPtr_submit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Context>.NativeClassPtr, "submit");
				}

				public Context(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_k_Name;

			private static readonly System.IntPtr NativeFieldInfoPtr_initializeCameraData;

			private static readonly System.IntPtr NativeFieldInfoPtr_initializeStackedCameraData;

			private static readonly System.IntPtr NativeFieldInfoPtr_initializeAdditionalCameraData;

			private static readonly System.IntPtr NativeFieldInfoPtr_initializeRenderingData;

			private static readonly System.IntPtr NativeFieldInfoPtr_initializeShadowData;

			private static readonly System.IntPtr NativeFieldInfoPtr_initializeLightData;

			private static readonly System.IntPtr NativeFieldInfoPtr_buildAdditionalLightsShadowAtlasLayout;

			private static readonly System.IntPtr NativeFieldInfoPtr_getPerObjectLightFlags;

			private static readonly System.IntPtr NativeFieldInfoPtr_getMainLightIndex;

			private static readonly System.IntPtr NativeFieldInfoPtr_setupPerFrameShaderConstants;

			private static readonly System.IntPtr NativeFieldInfoPtr_setupPerCameraShaderConstants;

			public unsafe static string k_Name
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			public unsafe static ProfilingSampler initializeCameraData
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initializeCameraData, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initializeCameraData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler initializeStackedCameraData
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initializeStackedCameraData, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initializeStackedCameraData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler initializeAdditionalCameraData
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initializeAdditionalCameraData, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initializeAdditionalCameraData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler initializeRenderingData
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initializeRenderingData, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initializeRenderingData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler initializeShadowData
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initializeShadowData, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initializeShadowData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler initializeLightData
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initializeLightData, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initializeLightData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler buildAdditionalLightsShadowAtlasLayout
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buildAdditionalLightsShadowAtlasLayout, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buildAdditionalLightsShadowAtlasLayout, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler getPerObjectLightFlags
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_getPerObjectLightFlags, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_getPerObjectLightFlags, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler getMainLightIndex
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_getMainLightIndex, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_getMainLightIndex, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler setupPerFrameShaderConstants
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setupPerFrameShaderConstants, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setupPerFrameShaderConstants, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler setupPerCameraShaderConstants
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setupPerCameraShaderConstants, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setupPerCameraShaderConstants, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static Pipeline()
			{
				Il2CppClassPointerStore<Pipeline>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "Pipeline");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pipeline>.NativeClassPtr);
				NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "k_Name");
				NativeFieldInfoPtr_initializeCameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "initializeCameraData");
				NativeFieldInfoPtr_initializeStackedCameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "initializeStackedCameraData");
				NativeFieldInfoPtr_initializeAdditionalCameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "initializeAdditionalCameraData");
				NativeFieldInfoPtr_initializeRenderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "initializeRenderingData");
				NativeFieldInfoPtr_initializeShadowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "initializeShadowData");
				NativeFieldInfoPtr_initializeLightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "initializeLightData");
				NativeFieldInfoPtr_buildAdditionalLightsShadowAtlasLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "buildAdditionalLightsShadowAtlasLayout");
				NativeFieldInfoPtr_getPerObjectLightFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "getPerObjectLightFlags");
				NativeFieldInfoPtr_getMainLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "getMainLightIndex");
				NativeFieldInfoPtr_setupPerFrameShaderConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "setupPerFrameShaderConstants");
				NativeFieldInfoPtr_setupPerCameraShaderConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pipeline>.NativeClassPtr, "setupPerCameraShaderConstants");
			}

			public Pipeline(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		static Profiling()
		{
			Il2CppClassPointerStore<Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "Profiling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiling>.NativeClassPtr);
		}

		public Profiling(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class CameraRenderingScope : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_beginCameraRenderingSampler;

		private static readonly System.IntPtr NativeFieldInfoPtr_endCameraRenderingSampler;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Context;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Camera;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptableRenderContext_Camera_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		public unsafe static ProfilingSampler beginCameraRenderingSampler
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beginCameraRenderingSampler, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beginCameraRenderingSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler endCameraRenderingSampler
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endCameraRenderingSampler, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endCameraRenderingSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ScriptableRenderContext m_Context
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Context);
				return *(ScriptableRenderContext*)num;
			}
			set
			{
				*(ScriptableRenderContext*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Context)) = value;
			}
		}

		public unsafe Camera m_Camera
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Camera);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static CameraRenderingScope()
		{
			Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "CameraRenderingScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr);
			NativeFieldInfoPtr_beginCameraRenderingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr, "beginCameraRenderingSampler");
			NativeFieldInfoPtr_endCameraRenderingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr, "endCameraRenderingSampler");
			NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr, "m_Context");
			NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr, "m_Camera");
			NativeMethodInfoPtr__ctor_Public_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr, 100665979);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr, 100665980);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1104353, RefRangeEnd = 1104357, XrefRangeStart = 1104343, XrefRangeEnd = 1104353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraRenderingScope(ScriptableRenderContext context, Camera camera)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&context);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ScriptableRenderContext_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1104366, RefRangeEnd = 1104374, XrefRangeStart = 1104357, XrefRangeEnd = 1104366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CameraRenderingScope(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CameraRenderingScope()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraRenderingScope>.NativeClassPtr))
		{
		}
	}

	public sealed class ContextRenderingScope : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_beginContextRenderingSampler;

		private static readonly System.IntPtr NativeFieldInfoPtr_endContextRenderingSampler;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Context;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Cameras;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptableRenderContext_List_1_Camera_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		public unsafe static ProfilingSampler beginContextRenderingSampler
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beginContextRenderingSampler, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beginContextRenderingSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler endContextRenderingSampler
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endContextRenderingSampler, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endContextRenderingSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ScriptableRenderContext m_Context
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Context);
				return *(ScriptableRenderContext*)num;
			}
			set
			{
				*(ScriptableRenderContext*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Context)) = value;
			}
		}

		public unsafe List<Camera> m_Cameras
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cameras);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Cameras)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static ContextRenderingScope()
		{
			Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "ContextRenderingScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr);
			NativeFieldInfoPtr_beginContextRenderingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr, "beginContextRenderingSampler");
			NativeFieldInfoPtr_endContextRenderingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr, "endContextRenderingSampler");
			NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr, "m_Context");
			NativeFieldInfoPtr_m_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr, "m_Cameras");
			NativeMethodInfoPtr__ctor_Public_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr, 100665982);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr, 100665983);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104384, RefRangeEnd = 1104386, XrefRangeStart = 1104374, XrefRangeEnd = 1104384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextRenderingScope(ScriptableRenderContext context, List<Camera> cameras)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&context);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1104395, RefRangeEnd = 1104399, XrefRangeStart = 1104386, XrefRangeEnd = 1104395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ContextRenderingScope(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ContextRenderingScope()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextRenderingScope>.NativeClassPtr))
		{
		}
	}

	public class SingleCameraRequest : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeFieldInfoPtr_mipLevel;

		private static readonly System.IntPtr NativeFieldInfoPtr_face;

		private static readonly System.IntPtr NativeFieldInfoPtr_slice;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe RenderTexture destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int mipLevel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mipLevel);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mipLevel)) = value;
			}
		}

		public unsafe CubemapFace face
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_face);
				return *(CubemapFace*)num;
			}
			set
			{
				*(CubemapFace*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_face)) = value;
			}
		}

		public unsafe int slice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slice);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slice)) = value;
			}
		}

		static SingleCameraRequest()
		{
			Il2CppClassPointerStore<SingleCameraRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "SingleCameraRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleCameraRequest>.NativeClassPtr);
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleCameraRequest>.NativeClassPtr, "destination");
			NativeFieldInfoPtr_mipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleCameraRequest>.NativeClassPtr, "mipLevel");
			NativeFieldInfoPtr_face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleCameraRequest>.NativeClassPtr, "face");
			NativeFieldInfoPtr_slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleCameraRequest>.NativeClassPtr, "slice");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleCameraRequest>.NativeClassPtr, 100665985);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104399, XrefRangeEnd = 1104400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleCameraRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleCameraRequest>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SingleCameraRequest(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__47_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__47_0_Internal_Int32_Camera_Camera_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__123_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;

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

		public unsafe static Il2CppSystem.Comparison<Camera> __9__47_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__47_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__47_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665987);
			NativeMethodInfoPtr___ctor_b__47_0_Internal_Int32_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665988);
			NativeMethodInfoPtr___cctor_b__123_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665989);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104400, XrefRangeEnd = 1104402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int __ctor_b__47_0(Camera camera1, Camera camera2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera2);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__47_0_Internal_Int32_Camera_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104402, XrefRangeEnd = 1104426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__123_0(Il2CppReferenceArray<Light> requests, NativeArray<LightDataGI> lightsOutput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requests);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lightsOutput));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__123_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0<RequestData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0, Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0, Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShaderTagName;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultRenderingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugDisplaySettingsUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlobalSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr__runtimeTextures_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraStackRequiresDepthForPostprocessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_RenderGraph;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_RTHandlePool;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRenderGraph;

	private static readonly System.IntPtr NativeFieldInfoPtr_apvIsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr__canOptimizeScreenMSAASamples_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__startFrameScreenMSAASamples_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_pipelineAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableHDROnce;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultLightPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultLightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultLightAttenuation;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultLightSpotDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DefaultLightsProbeChannel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowBiasData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowResolutionData;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraComparison;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightsDelegate;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxShadowBias_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_minRenderScale_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxRenderScale_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxNumIterationsEnclosingSphere_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxPerObjectLights_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxVisibleAdditionalLights_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightsPerTile_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxZBinWords_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxTileWords_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxVisibleReflectionProbes_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runtimeTextures_Internal_get_UniversalRenderPipelineRuntimeTextures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_runtimeTextures_Private_set_Void_UniversalRenderPipelineRuntimeTextures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_get_RenderPipelineGlobalSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_canOptimizeScreenMSAASamples_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_canOptimizeScreenMSAASamples_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_startFrameScreenMSAASamples_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_startFrameScreenMSAASamples_Private_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UniversalRenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeAdditionalCameraData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderSingleCamera_Public_Static_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_byref_UniversalAdditionalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCullingParameters_Private_Static_Boolean_UniversalCameraData_byref_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderSingleCamera_Private_Static_Void_ScriptableRenderContext_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowAtlasAndCullShadowCasters_Private_Static_Void_UniversalLightData_UniversalShadowData_UniversalCameraData_byref_CullingResults_byref_ScriptableRenderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderCameraStack_Private_Static_Void_ScriptableRenderContext_Camera_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraData_Private_Static_Void_UniversalCameraData_byref_XRPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVolumeFramework_Private_Static_Void_Camera_UniversalAdditionalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSupportedRenderingFeatures_Private_Static_Void_UniversalRenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderer_Private_Static_ScriptableRenderer_Camera_UniversalAdditionalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCameraData_Private_Static_UniversalCameraData_ContextContainer_Camera_UniversalAdditionalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeStackedCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAdditionalCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_Boolean_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderingData_Private_Static_UniversalRenderingData_ContextContainer_UniversalRenderPipelineAsset_CommandBuffer_Boolean_ScriptableRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateShadowData_Private_Static_UniversalShadowData_ContextContainer_UniversalRenderPipelineAsset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainLightCascadeSplit_Private_Static_Vector3_Int32_UniversalRenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeMainLightShadowResolution_Private_Static_Void_UniversalShadowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePostProcessingData_Private_Static_UniversalPostProcessingData_ContextContainer_UniversalRenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUniversalResourceData_Private_Static_UniversalResourceData_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLightData_Private_Static_UniversalLightData_ContextContainer_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTaaRenderingDebugOverrides_Private_Static_Void_byref_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTemporalAAData_Private_Static_Void_UniversalCameraData_UniversalAdditionalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTemporalAATargets_Private_Static_Void_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraStereoMatrices_Private_Static_Void_Camera_XRPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerObjectLightFlags_Private_Static_PerObjectData_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainLightIndex_Private_Static_Int32_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupPerFrameShaderConstants_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupPerCameraShaderConstants_Private_Static_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAndApplyDebugSettings_Private_Static_Void_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveUpscalingFilterSelection_Private_Static_ImageUpscalingFilter_Vector2_Single_UpscalingFilterSelection_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HDROutputForMainDisplayIsActive_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HDROutputForAnyDisplayIsActive_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHDRState_Private_Void_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHDROutputLuminanceParameters_Internal_Static_Void_HDRDisplayInformation_ColorGamut_Tonemapping_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHDROutputGradingParameters_Internal_Static_Void_Tonemapping_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAdditionalLightsShadowAtlasLayout_Private_Static_AdditionalLightsShadowAtlasLayout_UniversalLightData_UniversalShadowData_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustUIOverlayOwnership_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupScreenMSAASamplesState_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGameCamera_Public_Static_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_asset_Public_Static_get_UniversalRenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortCameras_Private_Void_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastBaseCameraIndex_Private_Int32_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_Boolean_HDRColorBufferPrecision_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeUnormRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderTextureDescriptor_Internal_Static_RenderTextureDescriptor_Camera_UniversalCameraData_Boolean_HDRColorBufferPrecision_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightAttenuationAndSpotDirection_Public_Static_Void_LightType_Single_Matrix4x4_Single_Nullable_1_Single_byref_Vector4_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPunctualLightDistanceAttenuation_Internal_Static_Void_Single_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpotAngleAttenuation_Internal_Static_Void_Single_Nullable_1_Single_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpotDirection_Internal_Static_Void_byref_Matrix4x4_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeLightConstants_Common_Public_Static_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_ScriptableRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordAndExecuteRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_ScriptableRenderer_CommandBuffer_Camera_String_0;

	public unsafe static string k_ShaderTagName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShaderTagName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShaderTagName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static int k_DefaultRenderingLayerMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultRenderingLayerMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultRenderingLayerMask, (void*)(&value));
		}
	}

	public unsafe DebugDisplaySettingsUI m_DebugDisplaySettingsUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugDisplaySettingsUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugDisplaySettingsUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UniversalRenderPipelineGlobalSettings m_GlobalSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlobalSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineGlobalSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlobalSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UniversalRenderPipelineRuntimeTextures _runtimeTextures_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runtimeTextures_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineRuntimeTextures>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__runtimeTextures_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool cameraStackRequiresDepthForPostprocessing
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cameraStackRequiresDepthForPostprocessing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cameraStackRequiresDepthForPostprocessing, (void*)(&value));
		}
	}

	public unsafe static RenderGraph s_RenderGraph
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RenderGraph, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderGraph>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RenderGraph, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandleResourcePool s_RTHandlePool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RTHandlePool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandleResourcePool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RTHandlePool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool useRenderGraph
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_useRenderGraph, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_useRenderGraph, (void*)(&value));
		}
	}

	public unsafe bool apvIsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apvIsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apvIsEnabled)) = value;
		}
	}

	public unsafe static bool _canOptimizeScreenMSAASamples_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__canOptimizeScreenMSAASamples_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__canOptimizeScreenMSAASamples_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static int _startFrameScreenMSAASamples_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__startFrameScreenMSAASamples_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__startFrameScreenMSAASamples_k__BackingField, (void*)(&value));
		}
	}

	public unsafe UniversalRenderPipelineAsset pipelineAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pipelineAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pipelineAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool enableHDROnce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableHDROnce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableHDROnce)) = value;
		}
	}

	public unsafe static Vector4 k_DefaultLightPosition
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultLightPosition, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultLightPosition, (void*)(&value));
		}
	}

	public unsafe static Vector4 k_DefaultLightColor
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultLightColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultLightColor, (void*)(&value));
		}
	}

	public unsafe static Vector4 k_DefaultLightAttenuation
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultLightAttenuation, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultLightAttenuation, (void*)(&value));
		}
	}

	public unsafe static Vector4 k_DefaultLightSpotDirection
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultLightSpotDirection, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultLightSpotDirection, (void*)(&value));
		}
	}

	public unsafe static Vector4 k_DefaultLightsProbeChannel
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultLightsProbeChannel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultLightsProbeChannel, (void*)(&value));
		}
	}

	public unsafe static List<Vector4> m_ShadowBiasData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ShadowBiasData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ShadowBiasData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<int> m_ShadowResolutionData
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ShadowResolutionData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ShadowResolutionData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Comparison<Camera> cameraComparison
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraComparison);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Camera>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraComparison)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Lightmapping.RequestLightsDelegate lightsDelegate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lightsDelegate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lightsDelegate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static float maxShadowBias
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1039140, RefRangeEnd = 1039143, XrefRangeStart = 1039140, XrefRangeEnd = 1039143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxShadowBias_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float minRenderScale
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1039143, RefRangeEnd = 1039145, XrefRangeStart = 1039143, XrefRangeEnd = 1039145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_minRenderScale_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float maxRenderScale
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1104426, RefRangeEnd = 1104428, XrefRangeStart = 1104426, XrefRangeEnd = 1104426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxRenderScale_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxNumIterationsEnclosingSphere
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxNumIterationsEnclosingSphere_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxPerObjectLights
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 86918, RefRangeEnd = 86933, XrefRangeStart = 86918, XrefRangeEnd = 86933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxPerObjectLights_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxVisibleAdditionalLights
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1104440, RefRangeEnd = 1104456, XrefRangeStart = 1104428, XrefRangeEnd = 1104440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxVisibleAdditionalLights_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int lightsPerTile
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104456, XrefRangeEnd = 1104460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightsPerTile_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxZBinWords
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1104460, RefRangeEnd = 1104465, XrefRangeStart = 1104460, XrefRangeEnd = 1104460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxZBinWords_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxTileWords
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1104469, RefRangeEnd = 1104474, XrefRangeStart = 1104465, XrefRangeEnd = 1104469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxTileWords_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxVisibleReflectionProbes
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1104482, RefRangeEnd = 1104485, XrefRangeStart = 1104474, XrefRangeEnd = 1104482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxVisibleReflectionProbes_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe UniversalRenderPipelineRuntimeTextures runtimeTextures
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runtimeTextures_Internal_get_UniversalRenderPipelineRuntimeTextures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineRuntimeTextures>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_runtimeTextures_Private_set_Void_UniversalRenderPipelineRuntimeTextures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe override RenderPipelineGlobalSettings defaultSettings
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_get_RenderPipelineGlobalSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr2) : null;
		}
	}

	public unsafe static bool canOptimizeScreenMSAASamples
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104485, XrefRangeEnd = 1104489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canOptimizeScreenMSAASamples_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104489, XrefRangeEnd = 1104493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_canOptimizeScreenMSAASamples_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int startFrameScreenMSAASamples
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104493, XrefRangeEnd = 1104497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startFrameScreenMSAASamples_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104497, XrefRangeEnd = 1104501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_startFrameScreenMSAASamples_Private_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static UniversalRenderPipelineAsset asset
	{
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 1106620, RefRangeEnd = 1106690, XrefRangeStart = 1106614, XrefRangeEnd = 1106620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_asset_Public_Static_get_UniversalRenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineAsset>(intPtr2) : null;
		}
	}

	static UniversalRenderPipeline()
	{
		Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderPipeline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr);
		NativeFieldInfoPtr_k_ShaderTagName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_ShaderTagName");
		NativeFieldInfoPtr_k_DefaultRenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultRenderingLayerMask");
		NativeFieldInfoPtr_m_DebugDisplaySettingsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "m_DebugDisplaySettingsUI");
		NativeFieldInfoPtr_m_GlobalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "m_GlobalSettings");
		NativeFieldInfoPtr__runtimeTextures_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "<runtimeTextures>k__BackingField");
		NativeFieldInfoPtr_cameraStackRequiresDepthForPostprocessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "cameraStackRequiresDepthForPostprocessing");
		NativeFieldInfoPtr_s_RenderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "s_RenderGraph");
		NativeFieldInfoPtr_s_RTHandlePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "s_RTHandlePool");
		NativeFieldInfoPtr_useRenderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "useRenderGraph");
		NativeFieldInfoPtr_apvIsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "apvIsEnabled");
		NativeFieldInfoPtr__canOptimizeScreenMSAASamples_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "<canOptimizeScreenMSAASamples>k__BackingField");
		NativeFieldInfoPtr__startFrameScreenMSAASamples_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "<startFrameScreenMSAASamples>k__BackingField");
		NativeFieldInfoPtr_pipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "pipelineAsset");
		NativeFieldInfoPtr_enableHDROnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "enableHDROnce");
		NativeFieldInfoPtr_k_DefaultLightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightPosition");
		NativeFieldInfoPtr_k_DefaultLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightColor");
		NativeFieldInfoPtr_k_DefaultLightAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightAttenuation");
		NativeFieldInfoPtr_k_DefaultLightSpotDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightSpotDirection");
		NativeFieldInfoPtr_k_DefaultLightsProbeChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "k_DefaultLightsProbeChannel");
		NativeFieldInfoPtr_m_ShadowBiasData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "m_ShadowBiasData");
		NativeFieldInfoPtr_m_ShadowResolutionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "m_ShadowResolutionData");
		NativeFieldInfoPtr_cameraComparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "cameraComparison");
		NativeFieldInfoPtr_lightsDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, "lightsDelegate");
		NativeMethodInfoPtr_get_maxShadowBias_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665892);
		NativeMethodInfoPtr_get_minRenderScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665893);
		NativeMethodInfoPtr_get_maxRenderScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665894);
		NativeMethodInfoPtr_get_maxNumIterationsEnclosingSphere_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665895);
		NativeMethodInfoPtr_get_maxPerObjectLights_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665896);
		NativeMethodInfoPtr_get_maxVisibleAdditionalLights_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665897);
		NativeMethodInfoPtr_get_lightsPerTile_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665898);
		NativeMethodInfoPtr_get_maxZBinWords_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665899);
		NativeMethodInfoPtr_get_maxTileWords_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665900);
		NativeMethodInfoPtr_get_maxVisibleReflectionProbes_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665901);
		NativeMethodInfoPtr_get_runtimeTextures_Internal_get_UniversalRenderPipelineRuntimeTextures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665902);
		NativeMethodInfoPtr_set_runtimeTextures_Private_set_Void_UniversalRenderPipelineRuntimeTextures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665903);
		NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_get_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665904);
		NativeMethodInfoPtr_get_canOptimizeScreenMSAASamples_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665905);
		NativeMethodInfoPtr_set_canOptimizeScreenMSAASamples_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665906);
		NativeMethodInfoPtr_get_startFrameScreenMSAASamples_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665907);
		NativeMethodInfoPtr_set_startFrameScreenMSAASamples_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665908);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665909);
		NativeMethodInfoPtr__ctor_Public_Void_UniversalRenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665910);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665911);
		NativeMethodInfoPtr_DisposeAdditionalCameraData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665912);
		NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665913);
		NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665914);
		NativeMethodInfoPtr_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665915);
		NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665916);
		NativeMethodInfoPtr_RenderSingleCamera_Public_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665917);
		NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665918);
		NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_byref_UniversalAdditionalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665919);
		NativeMethodInfoPtr_TryGetCullingParameters_Private_Static_Boolean_UniversalCameraData_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665920);
		NativeMethodInfoPtr_RenderSingleCamera_Private_Static_Void_ScriptableRenderContext_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665921);
		NativeMethodInfoPtr_CreateShadowAtlasAndCullShadowCasters_Private_Static_Void_UniversalLightData_UniversalShadowData_UniversalCameraData_byref_CullingResults_byref_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665922);
		NativeMethodInfoPtr_RenderCameraStack_Private_Static_Void_ScriptableRenderContext_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665923);
		NativeMethodInfoPtr_UpdateCameraData_Private_Static_Void_UniversalCameraData_byref_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665924);
		NativeMethodInfoPtr_UpdateVolumeFramework_Private_Static_Void_Camera_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665925);
		NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665926);
		NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665927);
		NativeMethodInfoPtr_SetSupportedRenderingFeatures_Private_Static_Void_UniversalRenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665928);
		NativeMethodInfoPtr_GetRenderer_Private_Static_ScriptableRenderer_Camera_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665929);
		NativeMethodInfoPtr_CreateCameraData_Private_Static_UniversalCameraData_ContextContainer_Camera_UniversalAdditionalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665930);
		NativeMethodInfoPtr_InitializeStackedCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665931);
		NativeMethodInfoPtr_InitializeAdditionalCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665932);
		NativeMethodInfoPtr_CreateRenderingData_Private_Static_UniversalRenderingData_ContextContainer_UniversalRenderPipelineAsset_CommandBuffer_Boolean_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665933);
		NativeMethodInfoPtr_CreateShadowData_Private_Static_UniversalShadowData_ContextContainer_UniversalRenderPipelineAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665934);
		NativeMethodInfoPtr_GetMainLightCascadeSplit_Private_Static_Vector3_Int32_UniversalRenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665935);
		NativeMethodInfoPtr_InitializeMainLightShadowResolution_Private_Static_Void_UniversalShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665936);
		NativeMethodInfoPtr_CreatePostProcessingData_Private_Static_UniversalPostProcessingData_ContextContainer_UniversalRenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665937);
		NativeMethodInfoPtr_CreateUniversalResourceData_Private_Static_UniversalResourceData_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665938);
		NativeMethodInfoPtr_CreateLightData_Private_Static_UniversalLightData_ContextContainer_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665939);
		NativeMethodInfoPtr_ApplyTaaRenderingDebugOverrides_Private_Static_Void_byref_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665940);
		NativeMethodInfoPtr_UpdateTemporalAAData_Private_Static_Void_UniversalCameraData_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665941);
		NativeMethodInfoPtr_UpdateTemporalAATargets_Private_Static_Void_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665942);
		NativeMethodInfoPtr_UpdateCameraStereoMatrices_Private_Static_Void_Camera_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665943);
		NativeMethodInfoPtr_GetPerObjectLightFlags_Private_Static_PerObjectData_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665944);
		NativeMethodInfoPtr_GetMainLightIndex_Private_Static_Int32_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665945);
		NativeMethodInfoPtr_SetupPerFrameShaderConstants_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665946);
		NativeMethodInfoPtr_SetupPerCameraShaderConstants_Private_Static_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665947);
		NativeMethodInfoPtr_CheckAndApplyDebugSettings_Private_Static_Void_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665948);
		NativeMethodInfoPtr_ResolveUpscalingFilterSelection_Private_Static_ImageUpscalingFilter_Vector2_Single_UpscalingFilterSelection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665949);
		NativeMethodInfoPtr_HDROutputForMainDisplayIsActive_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665950);
		NativeMethodInfoPtr_HDROutputForAnyDisplayIsActive_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665951);
		NativeMethodInfoPtr_SetHDRState_Private_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665952);
		NativeMethodInfoPtr_GetHDROutputLuminanceParameters_Internal_Static_Void_HDRDisplayInformation_ColorGamut_Tonemapping_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665953);
		NativeMethodInfoPtr_GetHDROutputGradingParameters_Internal_Static_Void_Tonemapping_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665954);
		NativeMethodInfoPtr_BuildAdditionalLightsShadowAtlasLayout_Private_Static_AdditionalLightsShadowAtlasLayout_UniversalLightData_UniversalShadowData_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665955);
		NativeMethodInfoPtr_AdjustUIOverlayOwnership_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665956);
		NativeMethodInfoPtr_SetupScreenMSAASamplesState_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665957);
		NativeMethodInfoPtr_IsGameCamera_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665958);
		NativeMethodInfoPtr_get_asset_Public_Static_get_UniversalRenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665959);
		NativeMethodInfoPtr_SortCameras_Private_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665960);
		NativeMethodInfoPtr_GetLastBaseCameraIndex_Private_Int32_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665961);
		NativeMethodInfoPtr_MakeRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_Boolean_HDRColorBufferPrecision_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665962);
		NativeMethodInfoPtr_MakeUnormRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665963);
		NativeMethodInfoPtr_CreateRenderTextureDescriptor_Internal_Static_RenderTextureDescriptor_Camera_UniversalCameraData_Boolean_HDRColorBufferPrecision_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665964);
		NativeMethodInfoPtr_GetLightAttenuationAndSpotDirection_Public_Static_Void_LightType_Single_Matrix4x4_Single_Nullable_1_Single_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665965);
		NativeMethodInfoPtr_GetPunctualLightDistanceAttenuation_Internal_Static_Void_Single_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665966);
		NativeMethodInfoPtr_GetSpotAngleAttenuation_Internal_Static_Void_Single_Nullable_1_Single_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665967);
		NativeMethodInfoPtr_GetSpotDirection_Internal_Static_Void_byref_Matrix4x4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665968);
		NativeMethodInfoPtr_InitializeLightConstants_Common_Public_Static_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665969);
		NativeMethodInfoPtr_RecordRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665970);
		NativeMethodInfoPtr_RecordAndExecuteRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_ScriptableRenderer_CommandBuffer_Camera_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr, 100665971);
	}

	[CallerCount(0)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1104668, RefRangeEnd = 1104669, XrefRangeStart = 1104501, XrefRangeEnd = 1104668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalRenderPipeline(UniversalRenderPipelineAsset asset)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipeline>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UniversalRenderPipelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104669, XrefRangeEnd = 1104739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104739, XrefRangeEnd = 1104745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeAdditionalCameraData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeAdditionalCameraData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104745, XrefRangeEnd = 1104751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Render(ScriptableRenderContext renderContext, Il2CppReferenceArray<Camera> cameras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104751, XrefRangeEnd = 1104889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Render(ScriptableRenderContext renderContext, List<Camera> cameras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104889, XrefRangeEnd = 1104899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
	{
		//IL_005e->IL0061: Incompatible stack types: I vs Ref
		//IL_0051->IL0061: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref RequestData reference;
		if (!typeof(RequestData).IsValueType)
		{
			object obj = data;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref data;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IsRenderRequestSupported_Protected_Virtual_Boolean_Camera_RequestData_0<RequestData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104899, XrefRangeEnd = 1105017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
	{
		//IL_006c->IL006f: Incompatible stack types: I vs Ref
		//IL_005f->IL006f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref RequestData reference;
		if (!typeof(RequestData).IsValueType)
		{
			object obj = renderRequest;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref renderRequest;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105017, XrefRangeEnd = 1105021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderSingleCamera(ScriptableRenderContext context, Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderSingleCamera_Public_Static_Void_ScriptableRenderContext_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1105032, RefRangeEnd = 1105034, XrefRangeStart = 1105021, XrefRangeEnd = 1105032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, bool isLastBaseCamera = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLastBaseCamera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1105047, RefRangeEnd = 1105049, XrefRangeStart = 1105034, XrefRangeEnd = 1105047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData, bool isLastBaseCamera = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalCameraData);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLastBaseCamera;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderSingleCameraInternal_Internal_Static_Void_ScriptableRenderContext_Camera_byref_UniversalAdditionalCameraData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		additionalCameraData = ((intPtr4 == (System.IntPtr)0) ? null : new UniversalAdditionalCameraData(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105049, XrefRangeEnd = 1105067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetCullingParameters(UniversalCameraData cameraData, out ScriptableCullingParameters cullingParams)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullingParams);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCullingParameters_Private_Static_Boolean_UniversalCameraData_byref_ScriptableCullingParameters_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1105393, RefRangeEnd = 1105395, XrefRangeStart = 1105067, XrefRangeEnd = 1105393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderSingleCamera(ScriptableRenderContext context, UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderSingleCamera_Private_Static_Void_ScriptableRenderContext_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105395, XrefRangeEnd = 1105409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateShadowAtlasAndCullShadowCasters(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData, ref CullingResults cullResults, ref ScriptableRenderContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShadowAtlasAndCullShadowCasters_Private_Static_Void_UniversalLightData_UniversalShadowData_UniversalCameraData_byref_CullingResults_byref_ScriptableRenderContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1105688, RefRangeEnd = 1105689, XrefRangeStart = 1105409, XrefRangeEnd = 1105688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera, bool isLastBaseCamera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseCamera);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLastBaseCamera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderCameraStack_Private_Static_Void_ScriptableRenderContext_Camera_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1105701, RefRangeEnd = 1105703, XrefRangeStart = 1105689, XrefRangeEnd = 1105701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateCameraData(UniversalCameraData baseCameraData, [In] ref XRPass xr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseCameraData);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraData_Private_Static_Void_UniversalCameraData_byref_XRPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		xr = ((intPtr4 == (System.IntPtr)0) ? null : new XRPass(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1105740, RefRangeEnd = 1105743, XrefRangeStart = 1105703, XrefRangeEnd = 1105740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalCameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateVolumeFramework_Private_Static_Void_Camera_UniversalAdditionalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105743, XrefRangeEnd = 1105745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckPostProcessForDepth(UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1105757, RefRangeEnd = 1105759, XrefRangeStart = 1105745, XrefRangeEnd = 1105757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckPostProcessForDepth()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPostProcessForDepth_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105759, XrefRangeEnd = 1105764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pipelineAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSupportedRenderingFeatures_Private_Static_Void_UniversalRenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1105775, RefRangeEnd = 1105777, XrefRangeStart = 1105764, XrefRangeEnd = 1105775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScriptableRenderer GetRenderer(Camera camera, UniversalAdditionalCameraData additionalCameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalCameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderer_Private_Static_ScriptableRenderer_Camera_UniversalAdditionalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1105863, RefRangeEnd = 1105865, XrefRangeStart = 1105777, XrefRangeEnd = 1105863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniversalCameraData CreateCameraData(ContextContainer frameData, Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalCameraData);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolveFinalTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCameraData_Private_Static_UniversalCameraData_ContextContainer_Camera_UniversalAdditionalCameraData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraData>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1105949, RefRangeEnd = 1105950, XrefRangeStart = 1105865, XrefRangeEnd = 1105949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseCamera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseAdditionalCameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeStackedCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1106067, RefRangeEnd = 1106070, XrefRangeStart = 1105950, XrefRangeEnd = 1106067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, bool isLastBaseCamera, UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalCameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolveFinalTarget;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLastBaseCamera;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeAdditionalCameraData_Private_Static_Void_Camera_UniversalAdditionalCameraData_Boolean_Boolean_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106070, XrefRangeEnd = 1106086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniversalRenderingData CreateRenderingData(ContextContainer frameData, UniversalRenderPipelineAsset settings, CommandBuffer cmd, bool isForwardPlus, ScriptableRenderer renderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isForwardPlus;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderingData_Private_Static_UniversalRenderingData_ContextContainer_UniversalRenderPipelineAsset_CommandBuffer_Boolean_ScriptableRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderingData>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106243, RefRangeEnd = 1106244, XrefRangeStart = 1106086, XrefRangeEnd = 1106243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniversalShadowData CreateShadowData(ContextContainer frameData, UniversalRenderPipelineAsset urpAsset, bool isForwardPlus)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)urpAsset);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isForwardPlus;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShadowData_Private_Static_UniversalShadowData_ContextContainer_UniversalRenderPipelineAsset_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalShadowData>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static Vector3 GetMainLightCascadeSplit(int mainLightShadowCascadesCount, UniversalRenderPipelineAsset urpAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&mainLightShadowCascadesCount);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)urpAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainLightCascadeSplit_Private_Static_Vector3_Int32_UniversalRenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106244, XrefRangeEnd = 1106248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeMainLightShadowResolution(UniversalShadowData shadowData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMainLightShadowResolution_Private_Static_Void_UniversalShadowData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106248, XrefRangeEnd = 1106255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniversalPostProcessingData CreatePostProcessingData(ContextContainer frameData, UniversalRenderPipelineAsset settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePostProcessingData_Private_Static_UniversalPostProcessingData_ContextContainer_UniversalRenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalPostProcessingData>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106255, XrefRangeEnd = 1106259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniversalResourceData CreateUniversalResourceData(ContextContainer frameData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUniversalResourceData_Private_Static_UniversalResourceData_ContextContainer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalResourceData>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106289, RefRangeEnd = 1106290, XrefRangeStart = 1106259, XrefRangeEnd = 1106289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniversalLightData CreateLightData(ContextContainer frameData, UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)visibleLights));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateLightData_Private_Static_UniversalLightData_ContextContainer_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalLightData>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106290, XrefRangeEnd = 1106296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ApplyTaaRenderingDebugOverrides(ref TemporalAA.Settings taaSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref taaSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTaaRenderingDebugOverrides_Private_Static_Void_byref_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106296, XrefRangeEnd = 1106312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateTemporalAAData(UniversalCameraData cameraData, UniversalAdditionalCameraData additionalCameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalCameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTemporalAAData_Private_Static_Void_UniversalCameraData_UniversalAdditionalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106312, XrefRangeEnd = 1106314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateTemporalAATargets(UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTemporalAATargets_Private_Static_Void_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1106320, RefRangeEnd = 1106322, XrefRangeStart = 1106314, XrefRangeEnd = 1106320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateCameraStereoMatrices(Camera camera, XRPass xr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraStereoMatrices_Private_Static_Void_Camera_XRPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1106335, RefRangeEnd = 1106337, XrefRangeStart = 1106322, XrefRangeEnd = 1106335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus, bool reflectionProbeBlending)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&additionalLightsCount);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isForwardPlus;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &reflectionProbeBlending;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerObjectLightFlags_Private_Static_PerObjectData_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PerObjectData*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106365, RefRangeEnd = 1106366, XrefRangeStart = 1106337, XrefRangeEnd = 1106365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)visibleLights));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainLightIndex_Private_Static_Int32_UniversalRenderPipelineAsset_NativeArray_1_VisibleLight_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106408, RefRangeEnd = 1106409, XrefRangeStart = 1106366, XrefRangeEnd = 1106408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupPerFrameShaderConstants()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupPerFrameShaderConstants_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106457, RefRangeEnd = 1106458, XrefRangeStart = 1106409, XrefRangeEnd = 1106457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupPerCameraShaderConstants(CommandBuffer cmd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupPerCameraShaderConstants_Private_Static_Void_CommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106506, RefRangeEnd = 1106507, XrefRangeStart = 1106458, XrefRangeEnd = 1106506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckAndApplyDebugSettings(ref RenderingData renderingData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAndApplyDebugSettings_Private_Static_Void_byref_RenderingData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106520, RefRangeEnd = 1106521, XrefRangeStart = 1106507, XrefRangeEnd = 1106520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection, bool enableRenderGraph)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&imageSize);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderScale;
		*(UpscalingFilterSelection**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selection;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableRenderGraph;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveUpscalingFilterSelection_Private_Static_ImageUpscalingFilter_Vector2_Single_UpscalingFilterSelection_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ImageUpscalingFilter*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1106532, RefRangeEnd = 1106535, XrefRangeStart = 1106521, XrefRangeEnd = 1106532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HDROutputForMainDisplayIsActive()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HDROutputForMainDisplayIsActive_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106535, XrefRangeEnd = 1106546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HDROutputForAnyDisplayIsActive()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HDROutputForAnyDisplayIsActive_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106546, XrefRangeEnd = 1106570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHDRState(List<Camera> cameras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHDRState_Private_Void_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1106570, RefRangeEnd = 1106575, XrefRangeStart = 1106570, XrefRangeEnd = 1106570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetHDROutputLuminanceParameters(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&hdrDisplayInformation);
		*(ColorGamut**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hdrDisplayColorGamut;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tonemapping);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hdrOutputParameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHDROutputLuminanceParameters_Internal_Static_Void_HDRDisplayInformation_ColorGamut_Tonemapping_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106576, RefRangeEnd = 1106577, XrefRangeStart = 1106575, XrefRangeEnd = 1106576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tonemapping);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hdrOutputParameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHDROutputGradingParameters_Internal_Static_Void_Tonemapping_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1106586, RefRangeEnd = 1106588, XrefRangeStart = 1106577, XrefRangeEnd = 1106586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AdditionalLightsShadowAtlasLayout BuildAdditionalLightsShadowAtlasLayout(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAdditionalLightsShadowAtlasLayout_Private_Static_AdditionalLightsShadowAtlasLayout_UniversalLightData_UniversalShadowData_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new AdditionalLightsShadowAtlasLayout(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106588, XrefRangeEnd = 1106596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AdjustUIOverlayOwnership(int cameraCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cameraCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustUIOverlayOwnership_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106596, XrefRangeEnd = 1106608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetupScreenMSAASamplesState(int cameraCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cameraCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupScreenMSAASamplesState_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106613, RefRangeEnd = 1106614, XrefRangeStart = 1106608, XrefRangeEnd = 1106613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGameCamera(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGameCamera_Public_Static_Boolean_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106690, XrefRangeEnd = 1106694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortCameras(List<Camera> cameras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortCameras_Private_Void_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106694, XrefRangeEnd = 1106702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetLastBaseCameraIndex(List<Camera> cameras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastBaseCameraIndex_Private_Int32_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1106704, RefRangeEnd = 1106707, XrefRangeStart = 1106702, XrefRangeEnd = 1106704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&isHdrEnabled);
		*(HDRColorBufferPrecision**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestHDRColorBufferPrecision;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &needsAlpha;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_Boolean_HDRColorBufferPrecision_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1106708, RefRangeEnd = 1106710, XrefRangeStart = 1106707, XrefRangeEnd = 1106708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat MakeUnormRenderTextureGraphicsFormat()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeUnormRenderTextureGraphicsFormat_Internal_Static_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106747, RefRangeEnd = 1106748, XrefRangeStart = 1106710, XrefRangeEnd = 1106747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, UniversalCameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHdrEnabled;
		*(HDRColorBufferPrecision**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestHDRColorBufferPrecision;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &msaaSamples;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &needsAlpha;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiresOpaqueTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderTextureDescriptor_Internal_Static_RenderTextureDescriptor_Camera_UniversalCameraData_Boolean_HDRColorBufferPrecision_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106748, XrefRangeEnd = 1106759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, Il2CppSystem.Nullable<float> innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&lightType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightRange;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightLocalToWorldMatrix;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &spotAngle;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)innerSpotAngle));
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightAttenuation);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightSpotDir);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightAttenuationAndSpotDirection_Public_Static_Void_LightType_Single_Matrix4x4_Single_Nullable_1_Single_byref_Vector4_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lightRange);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightAttenuation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPunctualLightDistanceAttenuation_Internal_Static_Void_Single_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1106768, RefRangeEnd = 1106770, XrefRangeStart = 1106759, XrefRangeEnd = 1106768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSpotAngleAttenuation(float spotAngle, Il2CppSystem.Nullable<float> innerSpotAngle, ref Vector4 lightAttenuation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&spotAngle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)innerSpotAngle));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightAttenuation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpotAngleAttenuation_Internal_Static_Void_Single_Nullable_1_Single_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1106771, RefRangeEnd = 1106772, XrefRangeStart = 1106770, XrefRangeEnd = 1106771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref lightLocalToWorldMatrix);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightSpotDir);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpotDirection_Internal_Static_Void_byref_Matrix4x4_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1106811, RefRangeEnd = 1106817, XrefRangeStart = 1106772, XrefRangeEnd = 1106811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lights));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightPos);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightColor);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightAttenuation);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightSpotDir);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightOcclusionProbeChannel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeLightConstants_Common_Public_Static_Void_NativeArray_1_VisibleLight_Int32_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106817, XrefRangeEnd = 1106819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ScriptableRenderer renderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_ScriptableRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106819, XrefRangeEnd = 1106828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ScriptableRenderer renderer, CommandBuffer cmd, Camera camera, string cameraName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cameraName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordAndExecuteRenderGraph_Private_Static_Void_RenderGraph_ScriptableRenderContext_ScriptableRenderer_CommandBuffer_Camera_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalRenderPipeline(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
