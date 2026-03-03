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
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.VFX;

namespace UnityEngine.Rendering.Universal;

public class ScriptableRenderer : Il2CppSystem.Object
{
	public static class Profiling : Il2CppSystem.Object
	{
		public static class RenderBlock : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_k_Name;

			private static readonly System.IntPtr NativeFieldInfoPtr_beforeRendering;

			private static readonly System.IntPtr NativeFieldInfoPtr_mainRenderingOpaque;

			private static readonly System.IntPtr NativeFieldInfoPtr_mainRenderingTransparent;

			private static readonly System.IntPtr NativeFieldInfoPtr_afterRendering;

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

			public unsafe static ProfilingSampler beforeRendering
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beforeRendering, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beforeRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler mainRenderingOpaque
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainRenderingOpaque, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainRenderingOpaque, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler mainRenderingTransparent
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainRenderingTransparent, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainRenderingTransparent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler afterRendering
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_afterRendering, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_afterRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static RenderBlock()
			{
				Il2CppClassPointerStore<RenderBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "RenderBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBlock>.NativeClassPtr);
				NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBlock>.NativeClassPtr, "k_Name");
				NativeFieldInfoPtr_beforeRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBlock>.NativeClassPtr, "beforeRendering");
				NativeFieldInfoPtr_mainRenderingOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBlock>.NativeClassPtr, "mainRenderingOpaque");
				NativeFieldInfoPtr_mainRenderingTransparent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBlock>.NativeClassPtr, "mainRenderingTransparent");
				NativeFieldInfoPtr_afterRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBlock>.NativeClassPtr, "afterRendering");
			}

			public RenderBlock(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public static class RenderPass : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_k_Name;

			private static readonly System.IntPtr NativeFieldInfoPtr_configure;

			private static readonly System.IntPtr NativeFieldInfoPtr_setRenderPassAttachments;

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

			public unsafe static ProfilingSampler configure
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_configure, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_configure, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe static ProfilingSampler setRenderPassAttachments
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setRenderPassAttachments, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setRenderPassAttachments, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			static RenderPass()
			{
				Il2CppClassPointerStore<RenderPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "RenderPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPass>.NativeClassPtr);
				NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPass>.NativeClassPtr, "k_Name");
				NativeFieldInfoPtr_configure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPass>.NativeClassPtr, "configure");
				NativeFieldInfoPtr_setRenderPassAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPass>.NativeClassPtr, "setRenderPassAttachments");
			}

			public RenderPass(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_setMRTAttachmentsList;

		private static readonly System.IntPtr NativeFieldInfoPtr_setAttachmentList;

		private static readonly System.IntPtr NativeFieldInfoPtr_execute;

		private static readonly System.IntPtr NativeFieldInfoPtr_setupFrameData;

		private static readonly System.IntPtr NativeFieldInfoPtr_k_Name;

		private static readonly System.IntPtr NativeFieldInfoPtr_setPerCameraShaderVariables;

		private static readonly System.IntPtr NativeFieldInfoPtr_sortRenderPasses;

		private static readonly System.IntPtr NativeFieldInfoPtr_recordRenderGraph;

		private static readonly System.IntPtr NativeFieldInfoPtr_setupLights;

		private static readonly System.IntPtr NativeFieldInfoPtr_setupCamera;

		private static readonly System.IntPtr NativeFieldInfoPtr_vfxProcessCamera;

		private static readonly System.IntPtr NativeFieldInfoPtr_addRenderPasses;

		private static readonly System.IntPtr NativeFieldInfoPtr_setupRenderPasses;

		private static readonly System.IntPtr NativeFieldInfoPtr_clearRenderingState;

		private static readonly System.IntPtr NativeFieldInfoPtr_internalStartRendering;

		private static readonly System.IntPtr NativeFieldInfoPtr_internalFinishRenderingCommon;

		private static readonly System.IntPtr NativeFieldInfoPtr_drawGizmos;

		private static readonly System.IntPtr NativeFieldInfoPtr_drawWireOverlay;

		private static readonly System.IntPtr NativeFieldInfoPtr_beginXRRendering;

		private static readonly System.IntPtr NativeFieldInfoPtr_endXRRendering;

		private static readonly System.IntPtr NativeFieldInfoPtr_initRenderGraphFrame;

		private static readonly System.IntPtr NativeFieldInfoPtr_setEditorTarget;

		public unsafe static ProfilingSampler setMRTAttachmentsList
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setMRTAttachmentsList, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setMRTAttachmentsList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler setAttachmentList
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setAttachmentList, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setAttachmentList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler execute
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_execute, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_execute, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler setupFrameData
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setupFrameData, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setupFrameData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

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

		public unsafe static ProfilingSampler setPerCameraShaderVariables
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setPerCameraShaderVariables, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setPerCameraShaderVariables, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler sortRenderPasses
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sortRenderPasses, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sortRenderPasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler recordRenderGraph
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_recordRenderGraph, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_recordRenderGraph, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler setupLights
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setupLights, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setupLights, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler setupCamera
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setupCamera, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setupCamera, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler vfxProcessCamera
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vfxProcessCamera, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vfxProcessCamera, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler addRenderPasses
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_addRenderPasses, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_addRenderPasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler setupRenderPasses
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setupRenderPasses, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setupRenderPasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler clearRenderingState
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clearRenderingState, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clearRenderingState, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler internalStartRendering
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_internalStartRendering, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_internalStartRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler internalFinishRenderingCommon
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_internalFinishRenderingCommon, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_internalFinishRenderingCommon, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler drawGizmos
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_drawGizmos, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_drawGizmos, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler drawWireOverlay
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_drawWireOverlay, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_drawWireOverlay, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler beginXRRendering
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beginXRRendering, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beginXRRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler endXRRendering
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endXRRendering, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endXRRendering, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler initRenderGraphFrame
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initRenderGraphFrame, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initRenderGraphFrame, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static ProfilingSampler setEditorTarget
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setEditorTarget, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setEditorTarget, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Profiling()
		{
			Il2CppClassPointerStore<Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "Profiling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiling>.NativeClassPtr);
			NativeFieldInfoPtr_setMRTAttachmentsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setMRTAttachmentsList");
			NativeFieldInfoPtr_setAttachmentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setAttachmentList");
			NativeFieldInfoPtr_execute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "execute");
			NativeFieldInfoPtr_setupFrameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setupFrameData");
			NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "k_Name");
			NativeFieldInfoPtr_setPerCameraShaderVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setPerCameraShaderVariables");
			NativeFieldInfoPtr_sortRenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "sortRenderPasses");
			NativeFieldInfoPtr_recordRenderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "recordRenderGraph");
			NativeFieldInfoPtr_setupLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setupLights");
			NativeFieldInfoPtr_setupCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setupCamera");
			NativeFieldInfoPtr_vfxProcessCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "vfxProcessCamera");
			NativeFieldInfoPtr_addRenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "addRenderPasses");
			NativeFieldInfoPtr_setupRenderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setupRenderPasses");
			NativeFieldInfoPtr_clearRenderingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "clearRenderingState");
			NativeFieldInfoPtr_internalStartRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "internalStartRendering");
			NativeFieldInfoPtr_internalFinishRenderingCommon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "internalFinishRenderingCommon");
			NativeFieldInfoPtr_drawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "drawGizmos");
			NativeFieldInfoPtr_drawWireOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "drawWireOverlay");
			NativeFieldInfoPtr_beginXRRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "beginXRRendering");
			NativeFieldInfoPtr_endXRRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "endXRRendering");
			NativeFieldInfoPtr_initRenderGraphFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "initRenderGraphFrame");
			NativeFieldInfoPtr_setEditorTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setEditorTarget");
		}

		public Profiling(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct RenderPassDescriptor
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_w;

		private static readonly System.IntPtr NativeFieldInfoPtr_h;

		private static readonly System.IntPtr NativeFieldInfoPtr_samples;

		private static readonly System.IntPtr NativeFieldInfoPtr_depthID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0;

		[FieldOffset(0)]
		public int w;

		[FieldOffset(4)]
		public int h;

		[FieldOffset(8)]
		public int samples;

		[FieldOffset(12)]
		public int depthID;

		static RenderPassDescriptor()
		{
			Il2CppClassPointerStore<RenderPassDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RenderPassDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPassDescriptor>.NativeClassPtr);
			NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassDescriptor>.NativeClassPtr, "w");
			NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassDescriptor>.NativeClassPtr, "h");
			NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassDescriptor>.NativeClassPtr, "samples");
			NativeFieldInfoPtr_depthID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassDescriptor>.NativeClassPtr, "depthID");
			NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPassDescriptor>.NativeClassPtr, 100664379);
		}

		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1023969, RefRangeEnd = 1023994, XrefRangeStart = 1023969, XrefRangeEnd = 1023994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPassDescriptor(int width, int height, int sampleCount, int rtID)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&width);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleCount;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rtID;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderPassDescriptor>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class RenderingFeatures : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__cameraStacking_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__msaa_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraStacking_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_cameraStacking_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_msaa_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_msaa_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool _cameraStacking_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraStacking_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraStacking_k__BackingField)) = value;
			}
		}

		public unsafe bool _msaa_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__msaa_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__msaa_k__BackingField)) = value;
			}
		}

		public unsafe bool cameraStacking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraStacking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86557, RefRangeEnd = 86558, XrefRangeStart = 86557, XrefRangeEnd = 86558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cameraStacking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool msaa
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_msaa_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_msaa_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static RenderingFeatures()
		{
			Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RenderingFeatures");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr);
			NativeFieldInfoPtr__cameraStacking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr, "<cameraStacking>k__BackingField");
			NativeFieldInfoPtr__msaa_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr, "<msaa>k__BackingField");
			NativeMethodInfoPtr_get_cameraStacking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr, 100664380);
			NativeMethodInfoPtr_set_cameraStacking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr, 100664381);
			NativeMethodInfoPtr_get_msaa_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr, 100664382);
			NativeMethodInfoPtr_set_msaa_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr, 100664383);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr, 100664384);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1083805, RefRangeEnd = 1083807, XrefRangeStart = 1083804, XrefRangeEnd = 1083805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderingFeatures()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderingFeatures>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public RenderingFeatures(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class RenderPassBlock : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_BeforeRendering;

		private static readonly System.IntPtr NativeFieldInfoPtr_MainRenderingOpaque;

		private static readonly System.IntPtr NativeFieldInfoPtr_MainRenderingTransparent;

		private static readonly System.IntPtr NativeFieldInfoPtr_AfterRendering;

		public unsafe static int BeforeRendering
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeforeRendering, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeforeRendering, (void*)(&value));
			}
		}

		public unsafe static int MainRenderingOpaque
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainRenderingOpaque, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainRenderingOpaque, (void*)(&value));
			}
		}

		public unsafe static int MainRenderingTransparent
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainRenderingTransparent, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainRenderingTransparent, (void*)(&value));
			}
		}

		public unsafe static int AfterRendering
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AfterRendering, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AfterRendering, (void*)(&value));
			}
		}

		static RenderPassBlock()
		{
			Il2CppClassPointerStore<RenderPassBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RenderPassBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPassBlock>.NativeClassPtr);
			NativeFieldInfoPtr_BeforeRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassBlock>.NativeClassPtr, "BeforeRendering");
			NativeFieldInfoPtr_MainRenderingOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassBlock>.NativeClassPtr, "MainRenderingOpaque");
			NativeFieldInfoPtr_MainRenderingTransparent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassBlock>.NativeClassPtr, "MainRenderingTransparent");
			NativeFieldInfoPtr_AfterRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassBlock>.NativeClassPtr, "AfterRendering");
		}

		public RenderPassBlock(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class VFXProcessCameraPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_renderingData;

		private static readonly System.IntPtr NativeFieldInfoPtr_camera;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraXRSettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_xrPass;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe UniversalRenderingData renderingData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderingData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Camera camera
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe VFXCameraXRSettings cameraXRSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraXRSettings);
				return *(VFXCameraXRSettings*)num;
			}
			set
			{
				*(VFXCameraXRSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraXRSettings)) = value;
			}
		}

		public unsafe XRPass xrPass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrPass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRPass>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static VFXProcessCameraPassData()
		{
			Il2CppClassPointerStore<VFXProcessCameraPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "VFXProcessCameraPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXProcessCameraPassData>.NativeClassPtr);
			NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXProcessCameraPassData>.NativeClassPtr, "renderingData");
			NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXProcessCameraPassData>.NativeClassPtr, "camera");
			NativeFieldInfoPtr_cameraXRSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXProcessCameraPassData>.NativeClassPtr, "cameraXRSettings");
			NativeFieldInfoPtr_xrPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXProcessCameraPassData>.NativeClassPtr, "xrPass");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXProcessCameraPassData>.NativeClassPtr, 100664386);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXProcessCameraPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXProcessCameraPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public VFXProcessCameraPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DrawGizmosPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_gizmoRenderList;

		private static readonly System.IntPtr NativeFieldInfoPtr_color;

		private static readonly System.IntPtr NativeFieldInfoPtr_depth;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe RendererListHandle gizmoRenderList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoRenderList);
				return *(RendererListHandle*)num;
			}
			set
			{
				*(RendererListHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gizmoRenderList)) = value;
			}
		}

		public unsafe TextureHandle color
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = value;
			}
		}

		public unsafe TextureHandle depth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth)) = value;
			}
		}

		static DrawGizmosPassData()
		{
			Il2CppClassPointerStore<DrawGizmosPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "DrawGizmosPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawGizmosPassData>.NativeClassPtr);
			NativeFieldInfoPtr_gizmoRenderList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGizmosPassData>.NativeClassPtr, "gizmoRenderList");
			NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGizmosPassData>.NativeClassPtr, "color");
			NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawGizmosPassData>.NativeClassPtr, "depth");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawGizmosPassData>.NativeClassPtr, 100664387);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawGizmosPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawGizmosPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DrawGizmosPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DrawWireOverlayPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_wireOverlayList;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe RendererListHandle wireOverlayList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wireOverlayList);
				return *(RendererListHandle*)num;
			}
			set
			{
				*(RendererListHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wireOverlayList)) = value;
			}
		}

		static DrawWireOverlayPassData()
		{
			Il2CppClassPointerStore<DrawWireOverlayPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "DrawWireOverlayPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawWireOverlayPassData>.NativeClassPtr);
			NativeFieldInfoPtr_wireOverlayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawWireOverlayPassData>.NativeClassPtr, "wireOverlayList");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawWireOverlayPassData>.NativeClassPtr, 100664388);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawWireOverlayPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawWireOverlayPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DrawWireOverlayPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BeginXRPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe UniversalCameraData cameraData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static BeginXRPassData()
		{
			Il2CppClassPointerStore<BeginXRPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "BeginXRPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginXRPassData>.NativeClassPtr);
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginXRPassData>.NativeClassPtr, "cameraData");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginXRPassData>.NativeClassPtr, 100664389);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeginXRPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeginXRPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public BeginXRPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class EndXRPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe UniversalCameraData cameraData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static EndXRPassData()
		{
			Il2CppClassPointerStore<EndXRPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "EndXRPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndXRPassData>.NativeClassPtr);
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndXRPassData>.NativeClassPtr, "cameraData");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndXRPassData>.NativeClassPtr, 100664390);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndXRPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndXRPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public EndXRPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DummyData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DummyData()
		{
			Il2CppClassPointerStore<DummyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "DummyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DummyData>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyData>.NativeClassPtr, 100664391);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DummyData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DummyData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DummyData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_renderer;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeFieldInfoPtr_isTargetBackbuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraTargetSizeCopy;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ScriptableRenderer renderer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe UniversalCameraData cameraData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool isTargetBackbuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTargetBackbuffer);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTargetBackbuffer)) = value;
			}
		}

		public unsafe Vector2Int cameraTargetSizeCopy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTargetSizeCopy);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTargetSizeCopy)) = value;
			}
		}

		static PassData()
		{
			Il2CppClassPointerStore<PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "PassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassData>.NativeClassPtr);
			NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "renderer");
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "cameraData");
			NativeFieldInfoPtr_isTargetBackbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "isTargetBackbuffer");
			NativeFieldInfoPtr_cameraTargetSizeCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "cameraTargetSizeCopy");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100664392);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class RenderBlocks : Il2CppSystem.ValueType
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct BlockRange
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_m_Current;

			private static readonly System.IntPtr NativeFieldInfoPtr_m_End;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_BlockRange_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			[FieldOffset(0)]
			public int m_Current;

			[FieldOffset(4)]
			public int m_End;

			public unsafe int Current
			{
				[CallerCount(175)]
				[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			static BlockRange()
			{
				Il2CppClassPointerStore<BlockRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, "BlockRange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockRange>.NativeClassPtr);
				NativeFieldInfoPtr_m_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockRange>.NativeClassPtr, "m_Current");
				NativeFieldInfoPtr_m_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockRange>.NativeClassPtr, "m_End");
				NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockRange>.NativeClassPtr, 100664398);
				NativeMethodInfoPtr_GetEnumerator_Public_BlockRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockRange>.NativeClassPtr, 100664399);
				NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockRange>.NativeClassPtr, 100664400);
				NativeMethodInfoPtr_get_Current_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockRange>.NativeClassPtr, 100664401);
				NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockRange>.NativeClassPtr, 100664402);
			}

			[CallerCount(0)]
			public unsafe BlockRange(int begin, int end)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&begin);
				*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(98)]
			[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BlockRange GetEnumerator()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_BlockRange_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(BlockRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1083807, RefRangeEnd = 1083808, XrefRangeStart = 1083807, XrefRangeEnd = 1083807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(19883)]
			[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlockRange>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BlockEventLimits;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BlockRanges;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BlockRangeLengths;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ScriptableRenderPass_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FillBlockRanges_Private_Void_List_1_ScriptableRenderPass_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetRange_Public_BlockRange_Int32_0;

		public unsafe NativeArray<RenderPassEvent> m_BlockEventLimits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlockEventLimits);
				return new NativeArray<RenderPassEvent>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RenderPassEvent>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlockEventLimits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RenderPassEvent>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> m_BlockRanges
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlockRanges);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlockRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> m_BlockRangeLengths
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlockRangeLengths);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlockRangeLengths), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static RenderBlocks()
		{
			Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "RenderBlocks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr);
			NativeFieldInfoPtr_m_BlockEventLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, "m_BlockEventLimits");
			NativeFieldInfoPtr_m_BlockRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, "m_BlockRanges");
			NativeFieldInfoPtr_m_BlockRangeLengths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, "m_BlockRangeLengths");
			NativeMethodInfoPtr__ctor_Public_Void_List_1_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, 100664393);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, 100664394);
			NativeMethodInfoPtr_FillBlockRanges_Private_Void_List_1_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, 100664395);
			NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, 100664396);
			NativeMethodInfoPtr_GetRange_Public_BlockRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr, 100664397);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1083832, RefRangeEnd = 1083833, XrefRangeStart = 1083808, XrefRangeEnd = 1083832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeRenderPassQueue);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_ScriptableRenderPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1083838, RefRangeEnd = 1083840, XrefRangeStart = 1083833, XrefRangeEnd = 1083838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083840, XrefRangeEnd = 1083846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeRenderPassQueue);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FillBlockRanges_Private_Void_List_1_ScriptableRenderPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1071659, RefRangeEnd = 1071664, XrefRangeStart = 1071659, XrefRangeEnd = 1071664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLength(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLength_Public_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1083846, RefRangeEnd = 1083847, XrefRangeStart = 1083846, XrefRangeEnd = 1083846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockRange GetRange(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRange_Public_BlockRange_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(BlockRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public RenderBlocks(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public RenderBlocks()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderBlocks>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.ScriptableRenderer+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__140_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__142_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__143_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__149_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__151_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__153_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__InitRenderGraphFrame_b__140_0_Internal_Void_PassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ProcessVFXCameraCommand_b__142_0_Internal_Void_VFXProcessCameraPassData_UnsafeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetupRenderGraphCameraProperties_b__143_0_Internal_Void_PassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BeginRenderGraphXRRendering_b__149_0_Internal_Void_BeginXRPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__EndRenderGraphXRRendering_b__151_0_Internal_Void_EndXRPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetEditorTarget_b__153_0_Internal_Void_DummyData_UnsafeGraphContext_0;

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

		public unsafe static BaseRenderFunc<PassData, UnsafeGraphContext> __9__140_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__140_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__140_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<VFXProcessCameraPassData, UnsafeGraphContext> __9__142_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__142_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<VFXProcessCameraPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__142_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<PassData, RasterGraphContext> __9__143_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__143_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__143_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<BeginXRPassData, RasterGraphContext> __9__149_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__149_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<BeginXRPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__149_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<EndXRPassData, RasterGraphContext> __9__151_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__151_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<EndXRPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__151_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<DummyData, UnsafeGraphContext> __9__153_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__153_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<DummyData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__153_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__140_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__140_0");
			NativeFieldInfoPtr___9__142_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__142_0");
			NativeFieldInfoPtr___9__143_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__143_0");
			NativeFieldInfoPtr___9__149_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__149_0");
			NativeFieldInfoPtr___9__151_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__151_0");
			NativeFieldInfoPtr___9__153_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__153_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664404);
			NativeMethodInfoPtr__InitRenderGraphFrame_b__140_0_Internal_Void_PassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664405);
			NativeMethodInfoPtr__ProcessVFXCameraCommand_b__142_0_Internal_Void_VFXProcessCameraPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664406);
			NativeMethodInfoPtr__SetupRenderGraphCameraProperties_b__143_0_Internal_Void_PassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664407);
			NativeMethodInfoPtr__BeginRenderGraphXRRendering_b__149_0_Internal_Void_BeginXRPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664408);
			NativeMethodInfoPtr__EndRenderGraphXRRendering_b__151_0_Internal_Void_EndXRPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664409);
			NativeMethodInfoPtr__SetEditorTarget_b__153_0_Internal_Void_DummyData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664410);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083847, XrefRangeEnd = 1083855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitRenderGraphFrame_b__140_0(PassData data, UnsafeGraphContext rgContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitRenderGraphFrame_b__140_0_Internal_Void_PassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083855, XrefRangeEnd = 1083862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessVFXCameraCommand_b__142_0(VFXProcessCameraPassData data, UnsafeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ProcessVFXCameraCommand_b__142_0_Internal_Void_VFXProcessCameraPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083862, XrefRangeEnd = 1083877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetupRenderGraphCameraProperties_b__143_0(PassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetupRenderGraphCameraProperties_b__143_0_Internal_Void_PassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083877, XrefRangeEnd = 1083893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BeginRenderGraphXRRendering_b__149_0(BeginXRPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BeginRenderGraphXRRendering_b__149_0_Internal_Void_BeginXRPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083893, XrefRangeEnd = 1083911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _EndRenderGraphXRRendering_b__151_0(EndXRPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__EndRenderGraphXRRendering_b__151_0_Internal_Void_EndXRPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083911, XrefRangeEnd = 1083913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetEditorTarget_b__153_0(DummyData data, UnsafeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetEditorTarget_b__153_0_Internal_Void_DummyData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kRenderPassMapSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_kRenderPassMaxCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastBeginSubpassPassIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MergeableRenderPassesMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MergeableRenderPassesMapArrays;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PassIndexToPassHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderPassesAttachmentCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_firstPassIndexOfLastMergeableGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveColorAttachmentDescriptors;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveDepthAttachmentDescriptor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsActiveColorAttachmentTransient;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FinalColorStoreAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FinalDepthStoreAction;

	private static readonly System.IntPtr NativeFieldInfoPtr__profilingExecute_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasReleasedRTs;

	private static readonly System.IntPtr NativeFieldInfoPtr__DebugHandler_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_current;

	private static readonly System.IntPtr NativeFieldInfoPtr__supportedRenderingFeatures_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__unsupportedGraphicsDeviceTypes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StoreActionsOptimizationSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseOptimizedStoreActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RenderPassBlockCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CameraTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveRenderPassQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererFeatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraColorTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraDepthTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraResolveTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstTimeCameraColorTargetIsBound;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstTimeCameraDepthTargetIsBound;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsPipelineExecuting;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableNativeRenderPassInFeatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRenderPassEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveColorAttachmentIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveColorAttachments;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveDepthAttachment;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_frameData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveColorStoreActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveDepthStoreAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TrimmedColorAttachmentCopyIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TrimmedColorAttachmentCopies;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Planes;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_VectorPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr__useDepthPriming_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__stripShadowsOffVariants_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__stripAdditionalLightOffVariants_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraDepth_Public_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetNativeRenderPassFrameData_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupNativeRenderPassFrameData_Internal_Void_UniversalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFinalStoreActions_Internal_Void_Il2CppStructArray_1_Int32_UniversalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNativeRenderPassMRTAttachmentList_Internal_Void_ScriptableRenderPass_UniversalCameraData_Boolean_ClearFlag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDepthOnlyRenderTexture_Private_Boolean_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNativeRenderPassAttachmentList_Internal_Void_ScriptableRenderPass_UniversalCameraData_RTHandle_RTHandle_ClearFlag_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteNativeRenderPass_Internal_Void_ScriptableRenderContext_ScriptableRenderPass_UniversalCameraData_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupInputAttachmentIndices_Internal_Void_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupTransientInputAttachments_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubPassAttachmentIndicesCount_Internal_Static_UInt32_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AreAttachmentIndicesCompatible_Internal_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidColorAttachmentCount_Internal_Static_UInt32_Il2CppStructArray_1_AttachmentDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidInputAttachmentCount_Internal_Static_Int32_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_Int32_AttachmentDescriptor_Il2CppStructArray_1_AttachmentDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_RenderTargetIdentifier_Il2CppStructArray_1_AttachmentDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidPassIndexCount_Internal_Static_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstAllocatedRTHandle_Internal_Static_RTHandle_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PassHasInputAttachments_Internal_Static_Boolean_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_Int32_Int32_Int32_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_RenderPassDescriptor_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTextureDescriptor_Internal_Static_Void_UniversalCameraData_ScriptableRenderPass_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeRenderPassDescriptor_Private_RenderPassDescriptor_UniversalCameraData_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsCameraStackingType_Public_Boolean_CameraRenderType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsMotionVectors_FamOrAssem_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsCameraOpaque_FamOrAssem_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsCameraNormals_FamOrAssem_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_profilingExecute_Protected_get_ProfilingSampler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_profilingExecute_Protected_set_Void_ProfilingSampler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugHandler_Internal_get_DebugHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_byref_CameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_UniversalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraMatrices_Internal_Static_Void_RasterCommandBuffer_UniversalCameraData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_RasterCommandBuffer_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_RasterCommandBuffer_UniversalCameraData_Vector2Int_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPerCameraBillboardProperties_Private_Void_RasterCommandBuffer_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBillboardProperties_Private_Static_Void_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_RasterCommandBuffer_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_RasterCommandBuffer_byref_UniversalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderTimeValues_Private_Static_Void_IBaseCommandBuffer_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraColorTarget_Public_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraColorTargetHandle_Public_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraDepthTarget_Public_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraDepthTargetHandle_Public_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rendererFeatures_Protected_get_List_1_ScriptableRendererFeature_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activeRenderPassQueue_Protected_get_List_1_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportedRenderingFeatures_Public_get_RenderingFeatures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportedRenderingFeatures_Public_set_Void_RenderingFeatures_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unsupportedGraphicsDeviceTypes_Public_get_Il2CppStructArray_1_GraphicsDeviceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_unsupportedGraphicsDeviceTypes_Public_set_Void_Il2CppStructArray_1_GraphicsDeviceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frameData_Internal_get_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useDepthPriming_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useDepthPriming_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptableRendererData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RTHandle_RTHandle_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupLights_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_New_Void_byref_ScriptableCullingParameters_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishRendering_Public_Virtual_New_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginRenderGraphFrame_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_ScriptableRenderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndRenderGraphFrame_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitRenderGraphFrame_Private_Void_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessVFXCameraCommand_Internal_Void_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRenderGraphCameraProperties_Internal_Void_RenderGraph_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawRenderGraphGizmos_Internal_Void_RenderGraph_ContextContainer_TextureHandle_TextureHandle_GizmoSubset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawRenderGraphWireOverlay_Internal_Void_RenderGraph_ContextContainer_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginRenderGraphXRRendering_Internal_Void_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndRenderGraphXRRendering_Internal_Void_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEditorTarget_Private_Void_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordRenderGraph_Internal_Void_RenderGraph_ScriptableRenderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishRenderGraphRendering_Internal_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_New_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordCustomRenderGraphPassesInEventRange_Internal_Void_RenderGraph_RenderPassEvent_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSplitEventRange_Internal_Void_RenderPassEvent_RenderPassEvent_byref_RenderPassEvent_byref_RenderPassEvent_byref_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_RenderPassEvent_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InterruptFramebufferFetch_Internal_Boolean_FramebufferFetchEvent_RenderPassEvent_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPerCameraProperties_Internal_Void_ScriptableRenderContext_UniversalCameraData_Camera_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnqueuePass_Public_Void_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPreCullRenderPasses_Internal_Void_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRenderPasses_Internal_Void_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRenderPasses_Protected_Void_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearRenderingState_Private_Static_Void_IBaseCommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_CameraRenderType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteBlock_Private_Void_Int32_byref_RenderBlocks_ScriptableRenderContext_byref_RenderingData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderPassEnabled_Private_Boolean_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteRenderPass_Private_Void_ScriptableRenderContext_ScriptableRenderPass_UniversalCameraData_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSceneFilteringEnabled_Internal_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderPassAttachments_Private_Void_CommandBuffer_ScriptableRenderPass_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_New_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawGizmos_Private_Void_ScriptableRenderContext_Camera_GizmoSubset_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWireOverlay_Private_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalStartRendering_Private_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalFinishRenderingCommon_Private_Void_CommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalFinishRenderingExecute_Private_Void_ScriptableRenderContext_CommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustAndGetScreenMSAASamples_FamAndAssem_Int32_RenderGraph_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortStable_Internal_Static_Void_List_1_ScriptableRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsNativeRenderPassRendergraphCompiler_Internal_Virtual_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsGPUOcclusion_Public_Virtual_New_get_Boolean_0;

	public unsafe static int kRenderPassMapSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kRenderPassMapSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kRenderPassMapSize, (void*)(&value));
		}
	}

	public unsafe static int kRenderPassMaxCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kRenderPassMaxCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kRenderPassMaxCount, (void*)(&value));
		}
	}

	public unsafe int m_LastBeginSubpassPassIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastBeginSubpassPassIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastBeginSubpassPassIndex)) = value;
		}
	}

	public unsafe Dictionary<Hash128, Il2CppStructArray<int>> m_MergeableRenderPassesMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MergeableRenderPassesMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Hash128, Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MergeableRenderPassesMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> m_MergeableRenderPassesMapArrays
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MergeableRenderPassesMapArrays);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MergeableRenderPassesMapArrays)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Hash128> m_PassIndexToPassHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassIndexToPassHash);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Hash128>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassIndexToPassHash)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<Hash128, int> m_RenderPassesAttachmentCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderPassesAttachmentCount);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Hash128, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderPassesAttachmentCount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_firstPassIndexOfLastMergeableGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_firstPassIndexOfLastMergeableGroup);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_firstPassIndexOfLastMergeableGroup)) = value;
		}
	}

	public unsafe Il2CppStructArray<AttachmentDescriptor> m_ActiveColorAttachmentDescriptors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveColorAttachmentDescriptors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<AttachmentDescriptor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveColorAttachmentDescriptors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AttachmentDescriptor m_ActiveDepthAttachmentDescriptor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveDepthAttachmentDescriptor);
			return *(AttachmentDescriptor*)num;
		}
		set
		{
			*(AttachmentDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveDepthAttachmentDescriptor)) = value;
		}
	}

	public unsafe Il2CppStructArray<bool> m_IsActiveColorAttachmentTransient
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsActiveColorAttachmentTransient);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsActiveColorAttachmentTransient)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<RenderBufferStoreAction> m_FinalColorStoreAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalColorStoreAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalColorStoreAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderBufferStoreAction m_FinalDepthStoreAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalDepthStoreAction);
			return *(RenderBufferStoreAction*)num;
		}
		set
		{
			*(RenderBufferStoreAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalDepthStoreAction)) = value;
		}
	}

	public unsafe ProfilingSampler _profilingExecute_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__profilingExecute_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__profilingExecute_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasReleasedRTs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasReleasedRTs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasReleasedRTs)) = value;
		}
	}

	public unsafe DebugHandler _DebugHandler_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DebugHandler_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DebugHandler_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ScriptableRenderer current
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_current, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_current, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderingFeatures _supportedRenderingFeatures_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportedRenderingFeatures_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderingFeatures>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportedRenderingFeatures_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<GraphicsDeviceType> _unsupportedGraphicsDeviceTypes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unsupportedGraphicsDeviceTypes_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsDeviceType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unsupportedGraphicsDeviceTypes_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StoreActionsOptimization m_StoreActionsOptimizationSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StoreActionsOptimizationSetting);
			return *(StoreActionsOptimization*)num;
		}
		set
		{
			*(StoreActionsOptimization*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StoreActionsOptimizationSetting)) = value;
		}
	}

	public unsafe static bool m_UseOptimizedStoreActions
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_UseOptimizedStoreActions, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_UseOptimizedStoreActions, (void*)(&value));
		}
	}

	public unsafe static int k_RenderPassBlockCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RenderPassBlockCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RenderPassBlockCount, (void*)(&value));
		}
	}

	public unsafe static RTHandle k_CameraTarget
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CameraTarget, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CameraTarget, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<ScriptableRenderPass> m_ActiveRenderPassQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveRenderPassQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScriptableRenderPass>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveRenderPassQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<ScriptableRendererFeature> m_RendererFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererFeatures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScriptableRendererFeature>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererFeatures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_CameraColorTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraColorTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraColorTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_CameraDepthTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_CameraResolveTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraResolveTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraResolveTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_FirstTimeCameraColorTargetIsBound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstTimeCameraColorTargetIsBound);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstTimeCameraColorTargetIsBound)) = value;
		}
	}

	public unsafe bool m_FirstTimeCameraDepthTargetIsBound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstTimeCameraDepthTargetIsBound);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstTimeCameraDepthTargetIsBound)) = value;
		}
	}

	public unsafe bool m_IsPipelineExecuting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsPipelineExecuting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsPipelineExecuting)) = value;
		}
	}

	public unsafe bool disableNativeRenderPassInFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableNativeRenderPassInFeatures);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableNativeRenderPassInFeatures)) = value;
		}
	}

	public unsafe bool useRenderPassEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRenderPassEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRenderPassEnabled)) = value;
		}
	}

	public unsafe static Il2CppStructArray<RenderTargetIdentifier> m_ActiveColorAttachmentIDs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ActiveColorAttachmentIDs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ActiveColorAttachmentIDs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<RTHandle> m_ActiveColorAttachments
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ActiveColorAttachments, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ActiveColorAttachments, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_ActiveDepthAttachment
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ActiveDepthAttachment, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ActiveDepthAttachment, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ContextContainer m_frameData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_frameData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<RenderBufferStoreAction> m_ActiveColorStoreActions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ActiveColorStoreActions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ActiveColorStoreActions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RenderBufferStoreAction m_ActiveDepthStoreAction
	{
		get
		{
			Unsafe.SkipInit(out RenderBufferStoreAction result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ActiveDepthStoreAction, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ActiveDepthStoreAction, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<RenderTargetIdentifier>> m_TrimmedColorAttachmentCopyIDs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_TrimmedColorAttachmentCopyIDs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<RenderTargetIdentifier>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_TrimmedColorAttachmentCopyIDs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppReferenceArray<RTHandle>> m_TrimmedColorAttachmentCopies
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_TrimmedColorAttachmentCopies, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<RTHandle>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_TrimmedColorAttachmentCopies, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Plane> s_Planes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Planes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Planes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Vector4> s_VectorPlanes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_VectorPlanes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_VectorPlanes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _useDepthPriming_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useDepthPriming_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useDepthPriming_k__BackingField)) = value;
		}
	}

	public unsafe bool _stripShadowsOffVariants_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stripShadowsOffVariants_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stripShadowsOffVariants_k__BackingField)) = value;
		}
	}

	public unsafe bool _stripAdditionalLightOffVariants_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stripAdditionalLightOffVariants_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stripAdditionalLightOffVariants_k__BackingField)) = value;
		}
	}

	public unsafe RenderTargetIdentifier cameraDepth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraDepth_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ProfilingSampler profilingExecute
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_profilingExecute_Protected_get_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_profilingExecute_Protected_set_Void_ProfilingSampler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DebugHandler DebugHandler
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DebugHandler_Internal_get_DebugHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr2) : null;
		}
	}

	public unsafe RenderTargetIdentifier cameraColorTarget
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084693, XrefRangeEnd = 1084699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraColorTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RTHandle cameraColorTargetHandle
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1084701, RefRangeEnd = 1084716, XrefRangeStart = 1084699, XrefRangeEnd = 1084701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraColorTargetHandle_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	public unsafe RenderTargetIdentifier cameraDepthTarget
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084716, XrefRangeEnd = 1084722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraDepthTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RTHandle cameraDepthTargetHandle
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1084724, RefRangeEnd = 1084728, XrefRangeStart = 1084722, XrefRangeEnd = 1084724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraDepthTargetHandle_Public_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	public unsafe List<ScriptableRendererFeature> rendererFeatures
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rendererFeatures_Protected_get_List_1_ScriptableRendererFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScriptableRendererFeature>>(intPtr2) : null;
		}
	}

	public unsafe List<ScriptableRenderPass> activeRenderPassQueue
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activeRenderPassQueue_Protected_get_List_1_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScriptableRenderPass>>(intPtr2) : null;
		}
	}

	public unsafe RenderingFeatures supportedRenderingFeatures
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportedRenderingFeatures_Public_get_RenderingFeatures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderingFeatures>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportedRenderingFeatures_Public_set_Void_RenderingFeatures_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<GraphicsDeviceType> unsupportedGraphicsDeviceTypes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unsupportedGraphicsDeviceTypes_Public_get_Il2CppStructArray_1_GraphicsDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsDeviceType>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_unsupportedGraphicsDeviceTypes_Public_set_Void_Il2CppStructArray_1_GraphicsDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ContextContainer frameData
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frameData_Internal_get_ContextContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextContainer>(intPtr2) : null;
		}
	}

	public unsafe bool useDepthPriming
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useDepthPriming_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useDepthPriming_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool stripShadowsOffVariants
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool stripAdditionalLightOffVariants
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual bool supportsNativeRenderPassRendergraphCompiler
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_supportsNativeRenderPassRendergraphCompiler_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual bool supportsGPUOcclusion
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_supportsGPUOcclusion_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ScriptableRenderer()
	{
		Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScriptableRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr);
		NativeFieldInfoPtr_kRenderPassMapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "kRenderPassMapSize");
		NativeFieldInfoPtr_kRenderPassMaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "kRenderPassMaxCount");
		NativeFieldInfoPtr_m_LastBeginSubpassPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_LastBeginSubpassPassIndex");
		NativeFieldInfoPtr_m_MergeableRenderPassesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_MergeableRenderPassesMap");
		NativeFieldInfoPtr_m_MergeableRenderPassesMapArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_MergeableRenderPassesMapArrays");
		NativeFieldInfoPtr_m_PassIndexToPassHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_PassIndexToPassHash");
		NativeFieldInfoPtr_m_RenderPassesAttachmentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_RenderPassesAttachmentCount");
		NativeFieldInfoPtr_m_firstPassIndexOfLastMergeableGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_firstPassIndexOfLastMergeableGroup");
		NativeFieldInfoPtr_m_ActiveColorAttachmentDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveColorAttachmentDescriptors");
		NativeFieldInfoPtr_m_ActiveDepthAttachmentDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveDepthAttachmentDescriptor");
		NativeFieldInfoPtr_m_IsActiveColorAttachmentTransient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_IsActiveColorAttachmentTransient");
		NativeFieldInfoPtr_m_FinalColorStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_FinalColorStoreAction");
		NativeFieldInfoPtr_m_FinalDepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_FinalDepthStoreAction");
		NativeFieldInfoPtr__profilingExecute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<profilingExecute>k__BackingField");
		NativeFieldInfoPtr_hasReleasedRTs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "hasReleasedRTs");
		NativeFieldInfoPtr__DebugHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<DebugHandler>k__BackingField");
		NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "current");
		NativeFieldInfoPtr__supportedRenderingFeatures_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<supportedRenderingFeatures>k__BackingField");
		NativeFieldInfoPtr__unsupportedGraphicsDeviceTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<unsupportedGraphicsDeviceTypes>k__BackingField");
		NativeFieldInfoPtr_m_StoreActionsOptimizationSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_StoreActionsOptimizationSetting");
		NativeFieldInfoPtr_m_UseOptimizedStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_UseOptimizedStoreActions");
		NativeFieldInfoPtr_k_RenderPassBlockCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "k_RenderPassBlockCount");
		NativeFieldInfoPtr_k_CameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "k_CameraTarget");
		NativeFieldInfoPtr_m_ActiveRenderPassQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveRenderPassQueue");
		NativeFieldInfoPtr_m_RendererFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_RendererFeatures");
		NativeFieldInfoPtr_m_CameraColorTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_CameraColorTarget");
		NativeFieldInfoPtr_m_CameraDepthTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_CameraDepthTarget");
		NativeFieldInfoPtr_m_CameraResolveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_CameraResolveTarget");
		NativeFieldInfoPtr_m_FirstTimeCameraColorTargetIsBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_FirstTimeCameraColorTargetIsBound");
		NativeFieldInfoPtr_m_FirstTimeCameraDepthTargetIsBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_FirstTimeCameraDepthTargetIsBound");
		NativeFieldInfoPtr_m_IsPipelineExecuting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_IsPipelineExecuting");
		NativeFieldInfoPtr_disableNativeRenderPassInFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "disableNativeRenderPassInFeatures");
		NativeFieldInfoPtr_useRenderPassEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "useRenderPassEnabled");
		NativeFieldInfoPtr_m_ActiveColorAttachmentIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveColorAttachmentIDs");
		NativeFieldInfoPtr_m_ActiveColorAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveColorAttachments");
		NativeFieldInfoPtr_m_ActiveDepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveDepthAttachment");
		NativeFieldInfoPtr_m_frameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_frameData");
		NativeFieldInfoPtr_m_ActiveColorStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveColorStoreActions");
		NativeFieldInfoPtr_m_ActiveDepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_ActiveDepthStoreAction");
		NativeFieldInfoPtr_m_TrimmedColorAttachmentCopyIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_TrimmedColorAttachmentCopyIDs");
		NativeFieldInfoPtr_m_TrimmedColorAttachmentCopies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "m_TrimmedColorAttachmentCopies");
		NativeFieldInfoPtr_s_Planes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "s_Planes");
		NativeFieldInfoPtr_s_VectorPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "s_VectorPlanes");
		NativeFieldInfoPtr__useDepthPriming_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<useDepthPriming>k__BackingField");
		NativeFieldInfoPtr__stripShadowsOffVariants_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<stripShadowsOffVariants>k__BackingField");
		NativeFieldInfoPtr__stripAdditionalLightOffVariants_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, "<stripAdditionalLightOffVariants>k__BackingField");
		NativeMethodInfoPtr_get_cameraDepth_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664252);
		NativeMethodInfoPtr_ResetNativeRenderPassFrameData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664253);
		NativeMethodInfoPtr_SetupNativeRenderPassFrameData_Internal_Void_UniversalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664254);
		NativeMethodInfoPtr_UpdateFinalStoreActions_Internal_Void_Il2CppStructArray_1_Int32_UniversalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr_SetNativeRenderPassMRTAttachmentList_Internal_Void_ScriptableRenderPass_UniversalCameraData_Boolean_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr_IsDepthOnlyRenderTexture_Private_Boolean_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr_SetNativeRenderPassAttachmentList_Internal_Void_ScriptableRenderPass_UniversalCameraData_RTHandle_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr_ExecuteNativeRenderPass_Internal_Void_ScriptableRenderContext_ScriptableRenderPass_UniversalCameraData_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_SetupInputAttachmentIndices_Internal_Void_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_SetupTransientInputAttachments_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_GetSubPassAttachmentIndicesCount_Internal_Static_UInt32_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664262);
		NativeMethodInfoPtr_AreAttachmentIndicesCompatible_Internal_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664263);
		NativeMethodInfoPtr_GetValidColorAttachmentCount_Internal_Static_UInt32_Il2CppStructArray_1_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664264);
		NativeMethodInfoPtr_GetValidInputAttachmentCount_Internal_Static_Int32_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664265);
		NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_Int32_AttachmentDescriptor_Il2CppStructArray_1_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664266);
		NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_RenderTargetIdentifier_Il2CppStructArray_1_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664267);
		NativeMethodInfoPtr_GetValidPassIndexCount_Internal_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664268);
		NativeMethodInfoPtr_GetFirstAllocatedRTHandle_Internal_Static_RTHandle_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664269);
		NativeMethodInfoPtr_PassHasInputAttachments_Internal_Static_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664270);
		NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_Int32_Int32_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664271);
		NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_RenderPassDescriptor_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664272);
		NativeMethodInfoPtr_GetRenderTextureDescriptor_Internal_Static_Void_UniversalCameraData_ScriptableRenderPass_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664273);
		NativeMethodInfoPtr_InitializeRenderPassDescriptor_Private_RenderPassDescriptor_UniversalCameraData_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664274);
		NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664275);
		NativeMethodInfoPtr_SupportsCameraStackingType_Public_Boolean_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_SupportsMotionVectors_FamOrAssem_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_SupportsCameraOpaque_FamOrAssem_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_SupportsCameraNormals_FamOrAssem_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664279);
		NativeMethodInfoPtr_get_profilingExecute_Protected_get_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_set_profilingExecute_Protected_set_Void_ProfilingSampler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_get_DebugHandler_Internal_get_DebugHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_byref_CameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_UniversalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_SetCameraMatrices_Internal_Static_Void_RasterCommandBuffer_UniversalCameraData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664285);
		NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_RasterCommandBuffer_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_RasterCommandBuffer_UniversalCameraData_Vector2Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664287);
		NativeMethodInfoPtr_SetPerCameraBillboardProperties_Private_Void_RasterCommandBuffer_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664288);
		NativeMethodInfoPtr_CalculateBillboardProperties_Private_Static_Void_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664289);
		NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_RasterCommandBuffer_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664290);
		NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_RasterCommandBuffer_byref_UniversalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664291);
		NativeMethodInfoPtr_SetShaderTimeValues_Private_Static_Void_IBaseCommandBuffer_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664292);
		NativeMethodInfoPtr_get_cameraColorTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664293);
		NativeMethodInfoPtr_get_cameraColorTargetHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664294);
		NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr_get_cameraDepthTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664297);
		NativeMethodInfoPtr_get_cameraDepthTargetHandle_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664298);
		NativeMethodInfoPtr_get_rendererFeatures_Protected_get_List_1_ScriptableRendererFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr_get_activeRenderPassQueue_Protected_get_List_1_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_get_supportedRenderingFeatures_Public_get_RenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_set_supportedRenderingFeatures_Public_set_Void_RenderingFeatures_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_get_unsupportedGraphicsDeviceTypes_Public_get_Il2CppStructArray_1_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664303);
		NativeMethodInfoPtr_set_unsupportedGraphicsDeviceTypes_Public_set_Void_Il2CppStructArray_1_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664304);
		NativeMethodInfoPtr_get_frameData_Internal_get_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664305);
		NativeMethodInfoPtr_get_useDepthPriming_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr_set_useDepthPriming_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664307);
		NativeMethodInfoPtr_get_stripShadowsOffVariants_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664308);
		NativeMethodInfoPtr_set_stripShadowsOffVariants_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664309);
		NativeMethodInfoPtr_get_stripAdditionalLightOffVariants_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664310);
		NativeMethodInfoPtr_set_stripAdditionalLightOffVariants_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664311);
		NativeMethodInfoPtr__ctor_Public_Void_ScriptableRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664312);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664313);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664314);
		NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664315);
		NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664316);
		NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664317);
		NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RTHandle_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664318);
		NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664319);
		NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664320);
		NativeMethodInfoPtr_SetupLights_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_New_Void_byref_ScriptableCullingParameters_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664322);
		NativeMethodInfoPtr_FinishRendering_Public_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664323);
		NativeMethodInfoPtr_OnBeginRenderGraphFrame_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664324);
		NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664325);
		NativeMethodInfoPtr_OnEndRenderGraphFrame_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr_InitRenderGraphFrame_Private_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664327);
		NativeMethodInfoPtr_ProcessVFXCameraCommand_Internal_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664328);
		NativeMethodInfoPtr_SetupRenderGraphCameraProperties_Internal_Void_RenderGraph_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664329);
		NativeMethodInfoPtr_DrawRenderGraphGizmos_Internal_Void_RenderGraph_ContextContainer_TextureHandle_TextureHandle_GizmoSubset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664330);
		NativeMethodInfoPtr_DrawRenderGraphWireOverlay_Internal_Void_RenderGraph_ContextContainer_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664331);
		NativeMethodInfoPtr_BeginRenderGraphXRRendering_Internal_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664332);
		NativeMethodInfoPtr_EndRenderGraphXRRendering_Internal_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664333);
		NativeMethodInfoPtr_SetEditorTarget_Private_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664334);
		NativeMethodInfoPtr_RecordRenderGraph_Internal_Void_RenderGraph_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664335);
		NativeMethodInfoPtr_FinishRenderGraphRendering_Internal_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664336);
		NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664337);
		NativeMethodInfoPtr_RecordCustomRenderGraphPassesInEventRange_Internal_Void_RenderGraph_RenderPassEvent_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664338);
		NativeMethodInfoPtr_CalculateSplitEventRange_Internal_Void_RenderPassEvent_RenderPassEvent_byref_RenderPassEvent_byref_RenderPassEvent_byref_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664339);
		NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_RenderPassEvent_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664340);
		NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664341);
		NativeMethodInfoPtr_InterruptFramebufferFetch_Internal_Boolean_FramebufferFetchEvent_RenderPassEvent_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664342);
		NativeMethodInfoPtr_SetPerCameraProperties_Internal_Void_ScriptableRenderContext_UniversalCameraData_Camera_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664343);
		NativeMethodInfoPtr_Execute_Public_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664344);
		NativeMethodInfoPtr_EnqueuePass_Public_Void_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664345);
		NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664346);
		NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664347);
		NativeMethodInfoPtr_OnPreCullRenderPasses_Internal_Void_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664348);
		NativeMethodInfoPtr_AddRenderPasses_Internal_Void_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664349);
		NativeMethodInfoPtr_SetupRenderPasses_Protected_Void_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664350);
		NativeMethodInfoPtr_ClearRenderingState_Private_Static_Void_IBaseCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664351);
		NativeMethodInfoPtr_Clear_Internal_Void_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664352);
		NativeMethodInfoPtr_ExecuteBlock_Private_Void_Int32_byref_RenderBlocks_ScriptableRenderContext_byref_RenderingData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664353);
		NativeMethodInfoPtr_IsRenderPassEnabled_Private_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664354);
		NativeMethodInfoPtr_ExecuteRenderPass_Private_Void_ScriptableRenderContext_ScriptableRenderPass_UniversalCameraData_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664355);
		NativeMethodInfoPtr_IsSceneFilteringEnabled_Internal_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664356);
		NativeMethodInfoPtr_SetRenderPassAttachments_Private_Void_CommandBuffer_ScriptableRenderPass_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664357);
		NativeMethodInfoPtr_BeginXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664358);
		NativeMethodInfoPtr_EndXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664359);
		NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664360);
		NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664361);
		NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664362);
		NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664363);
		NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_New_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664364);
		NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664365);
		NativeMethodInfoPtr_DrawGizmos_Private_Void_ScriptableRenderContext_Camera_GizmoSubset_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664366);
		NativeMethodInfoPtr_DrawWireOverlay_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664367);
		NativeMethodInfoPtr_InternalStartRendering_Private_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664368);
		NativeMethodInfoPtr_InternalFinishRenderingCommon_Private_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664369);
		NativeMethodInfoPtr_InternalFinishRenderingExecute_Private_Void_ScriptableRenderContext_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664370);
		NativeMethodInfoPtr_AdjustAndGetScreenMSAASamples_FamAndAssem_Int32_RenderGraph_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664371);
		NativeMethodInfoPtr_SortStable_Internal_Static_Void_List_1_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664372);
		NativeMethodInfoPtr_get_supportsNativeRenderPassRendergraphCompiler_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664373);
		NativeMethodInfoPtr_get_supportsGPUOcclusion_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr, 100664374);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1083921, RefRangeEnd = 1083924, XrefRangeStart = 1083913, XrefRangeEnd = 1083921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetNativeRenderPassFrameData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetNativeRenderPassFrameData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084012, RefRangeEnd = 1084013, XrefRangeStart = 1083924, XrefRangeEnd = 1084012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupNativeRenderPassFrameData(UniversalCameraData cameraData, bool isRenderPassEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isRenderPassEnabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupNativeRenderPassFrameData_Internal_Void_UniversalCameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1084038, RefRangeEnd = 1084040, XrefRangeStart = 1084013, XrefRangeEnd = 1084038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFinalStoreActions(Il2CppStructArray<int> currentMergeablePasses, UniversalCameraData cameraData, bool isLastMergeableGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentMergeablePasses);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLastMergeableGroup;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFinalStoreActions_Internal_Void_Il2CppStructArray_1_Int32_UniversalCameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084040, XrefRangeEnd = 1084123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNativeRenderPassMRTAttachmentList(ScriptableRenderPass renderPass, UniversalCameraData cameraData, bool needCustomCameraColorClear, ClearFlag cameraClearFlag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &needCustomCameraColorClear;
		*(ClearFlag**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraClearFlag;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNativeRenderPassMRTAttachmentList_Internal_Void_ScriptableRenderPass_UniversalCameraData_Boolean_ClearFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084123, XrefRangeEnd = 1084124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDepthOnlyRenderTexture(RenderTexture t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDepthOnlyRenderTexture_Private_Boolean_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084222, RefRangeEnd = 1084223, XrefRangeStart = 1084124, XrefRangeEnd = 1084222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNativeRenderPassAttachmentList(ScriptableRenderPass renderPass, UniversalCameraData cameraData, RTHandle passColorAttachment, RTHandle passDepthAttachment, ClearFlag finalClearFlag, Color finalClearColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passColorAttachment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passDepthAttachment);
		*(ClearFlag**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalClearFlag;
		*(Color**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &finalClearColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNativeRenderPassAttachmentList_Internal_Void_ScriptableRenderPass_UniversalCameraData_RTHandle_RTHandle_ClearFlag_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084355, RefRangeEnd = 1084356, XrefRangeStart = 1084223, XrefRangeEnd = 1084355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteNativeRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, UniversalCameraData cameraData, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteNativeRenderPass_Internal_Void_ScriptableRenderContext_ScriptableRenderPass_UniversalCameraData_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1084373, RefRangeEnd = 1084375, XrefRangeStart = 1084356, XrefRangeEnd = 1084373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupInputAttachmentIndices(ScriptableRenderPass pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupInputAttachmentIndices_Internal_Void_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084375, XrefRangeEnd = 1084379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTransientInputAttachments(int attachmentCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&attachmentCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupTransientInputAttachments_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1084393, RefRangeEnd = 1084398, XrefRangeStart = 1084379, XrefRangeEnd = 1084393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetSubPassAttachmentIndicesCount(ScriptableRenderPass pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubPassAttachmentIndicesCount_Internal_Static_UInt32_ScriptableRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084398, XrefRangeEnd = 1084403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AreAttachmentIndicesCompatible(ScriptableRenderPass lastSubPass, ScriptableRenderPass currentSubPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lastSubPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentSubPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreAttachmentIndicesCompatible_Internal_Static_Boolean_ScriptableRenderPass_ScriptableRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084403, XrefRangeEnd = 1084412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetValidColorAttachmentCount(Il2CppStructArray<AttachmentDescriptor> colorAttachments)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachments);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidColorAttachmentCount_Internal_Static_UInt32_Il2CppStructArray_1_AttachmentDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int GetValidInputAttachmentCount(ScriptableRenderPass renderPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidInputAttachmentCount_Internal_Static_Int32_ScriptableRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084417, RefRangeEnd = 1084418, XrefRangeStart = 1084412, XrefRangeEnd = 1084417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindAttachmentDescriptorIndexInList(int attachmentIdx, AttachmentDescriptor attachmentDescriptor, Il2CppStructArray<AttachmentDescriptor> attachmentDescriptors)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&attachmentIdx);
		*(AttachmentDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &attachmentDescriptor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachmentDescriptors);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_Int32_AttachmentDescriptor_Il2CppStructArray_1_AttachmentDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1084421, RefRangeEnd = 1084423, XrefRangeStart = 1084418, XrefRangeEnd = 1084421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int FindAttachmentDescriptorIndexInList(RenderTargetIdentifier target, Il2CppStructArray<AttachmentDescriptor> attachmentDescriptors)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachmentDescriptors);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAttachmentDescriptorIndexInList_Internal_Static_Int32_RenderTargetIdentifier_Il2CppStructArray_1_AttachmentDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084423, XrefRangeEnd = 1084424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetValidPassIndexCount(Il2CppStructArray<int> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidPassIndexCount_Internal_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1084429, RefRangeEnd = 1084431, XrefRangeStart = 1084424, XrefRangeEnd = 1084429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RTHandle GetFirstAllocatedRTHandle(ScriptableRenderPass pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstAllocatedRTHandle_Internal_Static_RTHandle_ScriptableRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool PassHasInputAttachments(ScriptableRenderPass renderPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PassHasInputAttachments_Internal_Static_Boolean_ScriptableRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084431, XrefRangeEnd = 1084432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthID;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sample;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hashIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_Int32_Int32_Int32_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Hash128*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084432, XrefRangeEnd = 1084436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hash128 CreateRenderPassHash(RenderPassDescriptor desc, uint hashIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&desc);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hashIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderPassHash_Internal_Static_Hash128_RenderPassDescriptor_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Hash128*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084452, RefRangeEnd = 1084453, XrefRangeStart = 1084436, XrefRangeEnd = 1084452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRenderTextureDescriptor(UniversalCameraData cameraData, ScriptableRenderPass renderPass, out RenderTextureDescriptor targetRT)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref targetRT);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderTextureDescriptor_Internal_Static_Void_UniversalCameraData_ScriptableRenderPass_byref_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1084468, RefRangeEnd = 1084470, XrefRangeStart = 1084453, XrefRangeEnd = 1084468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderPassDescriptor InitializeRenderPassDescriptor(UniversalCameraData cameraData, ScriptableRenderPass renderPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeRenderPassDescriptor_Private_RenderPassDescriptor_UniversalCameraData_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderPassDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int SupportedCameraStackingTypes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1084470, RefRangeEnd = 1084472, XrefRangeStart = 1084470, XrefRangeEnd = 1084470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SupportsCameraStackingType(CameraRenderType cameraRenderType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cameraRenderType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsCameraStackingType_Public_Boolean_CameraRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool SupportsMotionVectors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SupportsMotionVectors_FamOrAssem_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool SupportsCameraOpaque()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SupportsCameraOpaque_FamOrAssem_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool SupportsCameraNormals()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SupportsCameraNormals_FamOrAssem_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084472, XrefRangeEnd = 1084482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &setInverseMatrices;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_byref_CameraData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084482, XrefRangeEnd = 1084491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCameraMatrices(CommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &setInverseMatrices;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraMatrices_Public_Static_Void_CommandBuffer_UniversalCameraData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1084516, RefRangeEnd = 1084519, XrefRangeStart = 1084491, XrefRangeEnd = 1084516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCameraMatrices(RasterCommandBuffer cmd, UniversalCameraData cameraData, bool setInverseMatrices, bool isTargetFlipped)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &setInverseMatrices;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTargetFlipped;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraMatrices_Internal_Static_Void_RasterCommandBuffer_UniversalCameraData_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084519, XrefRangeEnd = 1084521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPerCameraShaderVariables(RasterCommandBuffer cmd, UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_RasterCommandBuffer_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1084593, RefRangeEnd = 1084597, XrefRangeStart = 1084521, XrefRangeEnd = 1084593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPerCameraShaderVariables(RasterCommandBuffer cmd, UniversalCameraData cameraData, Vector2Int cameraTargetSizeCopy, bool isTargetFlipped)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(Vector2Int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraTargetSizeCopy;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTargetFlipped;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPerCameraShaderVariables_Private_Void_RasterCommandBuffer_UniversalCameraData_Vector2Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084615, RefRangeEnd = 1084616, XrefRangeStart = 1084597, XrefRangeEnd = 1084615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPerCameraBillboardProperties(RasterCommandBuffer cmd, UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPerCameraBillboardProperties_Private_Void_RasterCommandBuffer_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1084626, RefRangeEnd = 1084628, XrefRangeStart = 1084616, XrefRangeEnd = 1084626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateBillboardProperties([In] ref Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref worldToCameraMatrix);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref billboardTangent);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref billboardNormal);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cameraXZAngle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateBillboardProperties_Private_Static_Void_byref_Matrix4x4_byref_Vector3_byref_Vector3_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084628, XrefRangeEnd = 1084630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPerCameraClippingPlaneProperties(RasterCommandBuffer cmd, UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_RasterCommandBuffer_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1084648, RefRangeEnd = 1084651, XrefRangeStart = 1084630, XrefRangeEnd = 1084648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPerCameraClippingPlaneProperties(RasterCommandBuffer cmd, [In] ref UniversalCameraData cameraData, bool isTargetFlipped)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTargetFlipped;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPerCameraClippingPlaneProperties_Private_Void_RasterCommandBuffer_byref_UniversalCameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		cameraData = ((intPtr4 == (System.IntPtr)0) ? null : new UniversalCameraData(intPtr4));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1084689, RefRangeEnd = 1084693, XrefRangeStart = 1084651, XrefRangeEnd = 1084689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetShaderTimeValues(IBaseCommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaTime;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &smoothDeltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShaderTimeValues_Private_Static_Void_IBaseCommandBuffer_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_New_RTHandle_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084870, RefRangeEnd = 1084871, XrefRangeStart = 1084728, XrefRangeEnd = 1084870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScriptableRenderer(ScriptableRendererData data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ScriptableRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1084888, RefRangeEnd = 1084891, XrefRangeStart = 1084871, XrefRangeEnd = 1084888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084892, RefRangeEnd = 1084893, XrefRangeStart = 1084891, XrefRangeEnd = 1084892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ReleaseRenderTargets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084893, XrefRangeEnd = 1084899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&colorTarget);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RenderTargetIdentifier_RenderTargetIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1084901, RefRangeEnd = 1084907, XrefRangeStart = 1084899, XrefRangeEnd = 1084901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorTarget);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureCameraTarget_Public_Void_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084907, XrefRangeEnd = 1084910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget, RTHandle resolveTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorTarget);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthTarget);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resolveTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureCameraTarget_Internal_Void_RTHandle_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureCameraColorTarget(RTHandle colorTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureCameraColorTarget_Internal_Void_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Setup_Public_Abstract_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetupLights_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref cullingParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_New_Void_byref_ScriptableCullingParameters_byref_CameraData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void FinishRendering(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishRendering_Public_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeginRenderGraphFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnBeginRenderGraphFrame_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_New_Void_RenderGraph_ScriptableRenderContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEndRenderGraphFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnEndRenderGraphFrame_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1084949, RefRangeEnd = 1084950, XrefRangeStart = 1084910, XrefRangeEnd = 1084949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitRenderGraphFrame(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitRenderGraphFrame_Private_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085004, RefRangeEnd = 1085005, XrefRangeStart = 1084950, XrefRangeEnd = 1085004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessVFXCameraCommand(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessVFXCameraCommand_Internal_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085050, RefRangeEnd = 1085052, XrefRangeStart = 1085005, XrefRangeEnd = 1085050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRenderGraphCameraProperties(RenderGraph renderGraph, bool isTargetBackbuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTargetBackbuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRenderGraphCameraProperties_Internal_Void_RenderGraph_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawRenderGraphGizmos(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(TextureHandle**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(GizmoSubset**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &gizmoSubset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawRenderGraphGizmos_Internal_Void_RenderGraph_ContextContainer_TextureHandle_TextureHandle_GizmoSubset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawRenderGraphWireOverlay(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawRenderGraphWireOverlay_Internal_Void_RenderGraph_ContextContainer_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085112, RefRangeEnd = 1085113, XrefRangeStart = 1085052, XrefRangeEnd = 1085112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginRenderGraphXRRendering(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginRenderGraphXRRendering_Internal_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085160, RefRangeEnd = 1085161, XrefRangeStart = 1085113, XrefRangeEnd = 1085160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndRenderGraphXRRendering(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndRenderGraphXRRendering_Internal_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085161, XrefRangeEnd = 1085201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEditorTarget(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEditorTarget_Private_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1085228, RefRangeEnd = 1085231, XrefRangeStart = 1085201, XrefRangeEnd = 1085228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordRenderGraph_Internal_Void_RenderGraph_ScriptableRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085236, RefRangeEnd = 1085237, XrefRangeStart = 1085231, XrefRangeEnd = 1085236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishRenderGraphRendering(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishRenderGraphRendering_Internal_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnFinishRenderGraphRendering(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1085251, RefRangeEnd = 1085259, XrefRangeStart = 1085237, XrefRangeEnd = 1085251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordCustomRenderGraphPassesInEventRange(RenderGraph renderGraph, RenderPassEvent eventStart, RenderPassEvent eventEnd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventStart;
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventEnd;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordCustomRenderGraphPassesInEventRange_Internal_Void_RenderGraph_RenderPassEvent_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1085272, RefRangeEnd = 1085275, XrefRangeStart = 1085259, XrefRangeEnd = 1085272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateSplitEventRange(RenderPassEvent startInjectionPoint, RenderPassEvent targetEvent, out RenderPassEvent startEvent, out RenderPassEvent splitEvent, out RenderPassEvent endEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&startInjectionPoint);
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetEvent;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref startEvent);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref splitEvent);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref endEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSplitEventRange_Internal_Void_RenderPassEvent_RenderPassEvent_byref_RenderPassEvent_byref_RenderPassEvent_byref_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1085280, RefRangeEnd = 1085286, XrefRangeStart = 1085275, XrefRangeEnd = 1085280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent startInjectionPoint, RenderPassEvent endInjectionPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startInjectionPoint;
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endInjectionPoint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_RenderPassEvent_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1085291, RefRangeEnd = 1085305, XrefRangeStart = 1085286, XrefRangeEnd = 1085291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent injectionPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injectionPoint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordCustomRenderGraphPasses_Internal_Void_RenderGraph_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085305, XrefRangeEnd = 1085319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InterruptFramebufferFetch(FramebufferFetchEvent fetchEvent, RenderPassEvent startInjectionPoint, RenderPassEvent endInjectionPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&fetchEvent);
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startInjectionPoint;
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &endInjectionPoint;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InterruptFramebufferFetch_Internal_Boolean_FramebufferFetchEvent_RenderPassEvent_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085348, RefRangeEnd = 1085350, XrefRangeStart = 1085319, XrefRangeEnd = 1085348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPerCameraProperties(ScriptableRenderContext context, UniversalCameraData cameraData, Camera camera, CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPerCameraProperties_Internal_Void_ScriptableRenderContext_UniversalCameraData_Camera_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085588, RefRangeEnd = 1085589, XrefRangeStart = 1085350, XrefRangeEnd = 1085588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 1085594, RefRangeEnd = 1085611, XrefRangeStart = 1085589, XrefRangeEnd = 1085594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnqueuePass(ScriptableRenderPass pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnqueuePass_Public_Void_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085611, XrefRangeEnd = 1085616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ClearFlag GetCameraClearFlag(ref CameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_byref_CameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ClearFlag*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1085630, RefRangeEnd = 1085633, XrefRangeStart = 1085616, XrefRangeEnd = 1085630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ClearFlag GetCameraClearFlag(UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraClearFlag_Protected_Static_ClearFlag_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ClearFlag*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085640, RefRangeEnd = 1085641, XrefRangeStart = 1085633, XrefRangeEnd = 1085640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPreCullRenderPasses([In] ref CameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPreCullRenderPasses_Internal_Void_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085670, RefRangeEnd = 1085671, XrefRangeStart = 1085641, XrefRangeEnd = 1085670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddRenderPasses(ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRenderPasses_Internal_Void_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085686, RefRangeEnd = 1085687, XrefRangeStart = 1085671, XrefRangeEnd = 1085686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRenderPasses([In] ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRenderPasses_Protected_Void_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085757, RefRangeEnd = 1085759, XrefRangeStart = 1085687, XrefRangeEnd = 1085757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearRenderingState(IBaseCommandBuffer cmd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearRenderingState_Private_Static_Void_IBaseCommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1085790, RefRangeEnd = 1085792, XrefRangeStart = 1085759, XrefRangeEnd = 1085790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear(CameraRenderType cameraType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cameraType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Internal_Void_CameraRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1085810, RefRangeEnd = 1085814, XrefRangeStart = 1085792, XrefRangeEnd = 1085810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteBlock(int blockIndex, [In] ref RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&blockIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderBlocks);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &submit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteBlock_Private_Void_Int32_byref_RenderBlocks_ScriptableRenderContext_byref_RenderingData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsRenderPassEnabled(ScriptableRenderPass renderPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderPassEnabled_Private_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085863, RefRangeEnd = 1085864, XrefRangeStart = 1085814, XrefRangeEnd = 1085863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, UniversalCameraData cameraData, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteRenderPass_Private_Void_ScriptableRenderContext_ScriptableRenderPass_UniversalCameraData_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSceneFilteringEnabled(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSceneFilteringEnabled_Internal_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085933, RefRangeEnd = 1085934, XrefRangeStart = 1085864, XrefRangeEnd = 1085933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderPass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderPassAttachments_Private_Void_CommandBuffer_ScriptableRenderPass_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1085959, RefRangeEnd = 1085960, XrefRangeStart = 1085934, XrefRangeEnd = 1085959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085960, XrefRangeEnd = 1085985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndXRRendering_Private_Void_CommandBuffer_ScriptableRenderContext_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086033, RefRangeEnd = 1086034, XrefRangeStart = 1085985, XrefRangeEnd = 1086033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthAttachment);
		*(ClearFlag**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearFlag;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086073, RefRangeEnd = 1086074, XrefRangeStart = 1086034, XrefRangeEnd = 1086073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthAttachment);
		*(ClearFlag**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearFlag;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorStoreAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStoreAction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTarget_Internal_Static_Void_CommandBuffer_RTHandle_RTHandle_ClearFlag_Color_RenderBufferStoreAction_RenderBufferStoreAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1086082, RefRangeEnd = 1086084, XrefRangeStart = 1086074, XrefRangeEnd = 1086082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachment);
		*(RenderBufferLoadAction**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorLoadAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorStoreAction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthAttachment);
		*(RenderBufferLoadAction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthLoadAction;
		*(RenderBufferStoreAction**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStoreAction;
		*(ClearFlag**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearFlags;
		*(Color**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086084, XrefRangeEnd = 1086101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRenderTarget(CommandBuffer cmd, Il2CppReferenceArray<RTHandle> colorAttachments, Il2CppStructArray<RenderTargetIdentifier> colorAttachmentIDs, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorAttachmentIDs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)depthAttachment);
		*(ClearFlag**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearFlag;
		*(Color**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderTarget_Private_Static_Void_CommandBuffer_Il2CppReferenceArray_1_RTHandle_Il2CppStructArray_1_RenderTargetIdentifier_RTHandle_ClearFlag_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SwapColorBuffer(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_New_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void EnableSwapBufferMSAA(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(GizmoSubset**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &gizmoSubset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawGizmos_Private_Void_ScriptableRenderContext_Camera_GizmoSubset_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086101, XrefRangeEnd = 1086105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawWireOverlay(ScriptableRenderContext context, Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWireOverlay_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086126, RefRangeEnd = 1086127, XrefRangeStart = 1086105, XrefRangeEnd = 1086126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalStartRendering_Private_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1086145, RefRangeEnd = 1086148, XrefRangeStart = 1086127, XrefRangeEnd = 1086145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalFinishRenderingCommon(CommandBuffer cmd, bool resolveFinalTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolveFinalTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalFinishRenderingCommon_Private_Void_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086148, XrefRangeEnd = 1086155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalFinishRenderingExecute(ScriptableRenderContext context, CommandBuffer cmd, bool resolveFinalTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &resolveFinalTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalFinishRenderingExecute_Private_Void_ScriptableRenderContext_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1086173, RefRangeEnd = 1086174, XrefRangeStart = 1086155, XrefRangeEnd = 1086173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int AdjustAndGetScreenMSAASamples(RenderGraph renderGraph, bool useIntermediateColorTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useIntermediateColorTarget;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustAndGetScreenMSAASamples_FamAndAssem_Int32_RenderGraph_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1086191, RefRangeEnd = 1086193, XrefRangeStart = 1086174, XrefRangeEnd = 1086191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortStable(List<ScriptableRenderPass> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortStable_Internal_Static_Void_List_1_ScriptableRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ScriptableRenderer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
