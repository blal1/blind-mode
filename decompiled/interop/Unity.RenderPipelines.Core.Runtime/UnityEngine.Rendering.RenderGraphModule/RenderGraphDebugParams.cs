using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.RenderGraphModule;

public class RenderGraphDebugParams : Il2CppSystem.Object
{
	public static class Strings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ClearRenderTargetsAtCreation;

		private static readonly System.IntPtr NativeFieldInfoPtr_ClearRenderTargetsAtFree;

		private static readonly System.IntPtr NativeFieldInfoPtr_DisablePassCulling;

		private static readonly System.IntPtr NativeFieldInfoPtr_ImmediateMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_EnableLogging;

		private static readonly System.IntPtr NativeFieldInfoPtr_LogFrameInformation;

		private static readonly System.IntPtr NativeFieldInfoPtr_LogResources;

		private static readonly System.IntPtr NativeFieldInfoPtr_EnableNativeCompiler;

		public unsafe static DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClearRenderTargetsAtCreation, (void*)intPtr);
				return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClearRenderTargetsAtCreation, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtFree
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClearRenderTargetsAtFree, (void*)intPtr);
				return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClearRenderTargetsAtFree, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static DebugUI.Widget.NameAndTooltip DisablePassCulling
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisablePassCulling, (void*)intPtr);
				return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisablePassCulling, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static DebugUI.Widget.NameAndTooltip ImmediateMode
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ImmediateMode, (void*)intPtr);
				return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ImmediateMode, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static DebugUI.Widget.NameAndTooltip EnableLogging
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnableLogging, (void*)intPtr);
				return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnableLogging, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static DebugUI.Widget.NameAndTooltip LogFrameInformation
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LogFrameInformation, (void*)intPtr);
				return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LogFrameInformation, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static DebugUI.Widget.NameAndTooltip LogResources
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LogResources, (void*)intPtr);
				return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LogResources, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		public unsafe static DebugUI.Widget.NameAndTooltip EnableNativeCompiler
		{
			get
			{
				System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, ref *(uint*)null)];
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnableNativeCompiler, (void*)intPtr);
				return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnableNativeCompiler, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
			}
		}

		static Strings()
		{
			Il2CppClassPointerStore<Strings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "Strings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Strings>.NativeClassPtr);
			NativeFieldInfoPtr_ClearRenderTargetsAtCreation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "ClearRenderTargetsAtCreation");
			NativeFieldInfoPtr_ClearRenderTargetsAtFree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "ClearRenderTargetsAtFree");
			NativeFieldInfoPtr_DisablePassCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "DisablePassCulling");
			NativeFieldInfoPtr_ImmediateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "ImmediateMode");
			NativeFieldInfoPtr_EnableLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "EnableLogging");
			NativeFieldInfoPtr_LogFrameInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "LogFrameInformation");
			NativeFieldInfoPtr_LogResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "LogResources");
			NativeFieldInfoPtr_EnableNativeCompiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "EnableNativeCompiler");
		}

		public Strings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearRenderTargetsAtCreation;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearRenderTargetsAtRelease;

	private static readonly System.IntPtr NativeFieldInfoPtr_disablePassCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_immediateMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableLogging;

	private static readonly System.IntPtr NativeFieldInfoPtr_logFrameInformation;

	private static readonly System.IntPtr NativeFieldInfoPtr_logResources;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWidgetList_Internal_List_1_Widget_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsImmediateModeSupported_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDebug_Public_Void_String_Panel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterDebug_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_0_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_1_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_2_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_3_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_4_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_5_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_6_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_7_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_8_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_9_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_10_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_11_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetWidgetList_b__11_12_Private_Void_0;

	public unsafe Il2CppReferenceArray<DebugUI.Widget> m_DebugItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Widget>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DebugUI.Panel m_DebugPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugPanel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugUI.Panel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugPanel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool clearRenderTargetsAtCreation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearRenderTargetsAtCreation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearRenderTargetsAtCreation)) = value;
		}
	}

	public unsafe bool clearRenderTargetsAtRelease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearRenderTargetsAtRelease);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearRenderTargetsAtRelease)) = value;
		}
	}

	public unsafe bool disablePassCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disablePassCulling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disablePassCulling)) = value;
		}
	}

	public unsafe bool immediateMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_immediateMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_immediateMode)) = value;
		}
	}

	public unsafe bool enableLogging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableLogging);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableLogging)) = value;
		}
	}

	public unsafe bool logFrameInformation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logFrameInformation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logFrameInformation)) = value;
		}
	}

	public unsafe bool logResources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logResources);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logResources)) = value;
		}
	}

	public unsafe virtual bool AreAnySettingsActive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RenderGraphDebugParams()
	{
		Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RenderGraphDebugParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr);
		NativeFieldInfoPtr_m_DebugItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "m_DebugItems");
		NativeFieldInfoPtr_m_DebugPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "m_DebugPanel");
		NativeFieldInfoPtr_clearRenderTargetsAtCreation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "clearRenderTargetsAtCreation");
		NativeFieldInfoPtr_clearRenderTargetsAtRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "clearRenderTargetsAtRelease");
		NativeFieldInfoPtr_disablePassCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "disablePassCulling");
		NativeFieldInfoPtr_immediateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "immediateMode");
		NativeFieldInfoPtr_enableLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "enableLogging");
		NativeFieldInfoPtr_logFrameInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "logFrameInformation");
		NativeFieldInfoPtr_logResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, "logResources");
		NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667074);
		NativeMethodInfoPtr_GetWidgetList_Internal_List_1_Widget_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667075);
		NativeMethodInfoPtr_IsImmediateModeSupported_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667076);
		NativeMethodInfoPtr_RegisterDebug_Public_Void_String_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667077);
		NativeMethodInfoPtr_UnRegisterDebug_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667078);
		NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667079);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667080);
		NativeMethodInfoPtr__GetWidgetList_b__11_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667081);
		NativeMethodInfoPtr__GetWidgetList_b__11_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667082);
		NativeMethodInfoPtr__GetWidgetList_b__11_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667083);
		NativeMethodInfoPtr__GetWidgetList_b__11_3_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667084);
		NativeMethodInfoPtr__GetWidgetList_b__11_4_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667085);
		NativeMethodInfoPtr__GetWidgetList_b__11_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667086);
		NativeMethodInfoPtr__GetWidgetList_b__11_6_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667087);
		NativeMethodInfoPtr__GetWidgetList_b__11_7_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667088);
		NativeMethodInfoPtr__GetWidgetList_b__11_8_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667089);
		NativeMethodInfoPtr__GetWidgetList_b__11_9_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667090);
		NativeMethodInfoPtr__GetWidgetList_b__11_10_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667091);
		NativeMethodInfoPtr__GetWidgetList_b__11_11_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667092);
		NativeMethodInfoPtr__GetWidgetList_b__11_12_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr, 100667093);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1055421, RefRangeEnd = 1055422, XrefRangeStart = 1055421, XrefRangeEnd = 1055421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1055579, RefRangeEnd = 1055582, XrefRangeStart = 1055422, XrefRangeEnd = 1055579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DebugUI.Widget> GetWidgetList(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWidgetList_Internal_List_1_Widget_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DebugUI.Widget>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055582, XrefRangeEnd = 1055589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsImmediateModeSupported()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsImmediateModeSupported_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055589, XrefRangeEnd = 1055606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterDebug(string name, DebugUI.Panel debugPanel = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugPanel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDebug_Public_Void_String_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055606, XrefRangeEnd = 1055612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnRegisterDebug(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterDebug_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderGraphDebugParams()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphDebugParams>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _GetWidgetList_b__11_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 59885, RefRangeEnd = 59887, XrefRangeStart = 59885, XrefRangeEnd = 59887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _GetWidgetList_b__11_1(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _GetWidgetList_b__11_2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _GetWidgetList_b__11_3(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_3_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _GetWidgetList_b__11_4()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_4_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _GetWidgetList_b__11_5(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _GetWidgetList_b__11_6()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_6_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _GetWidgetList_b__11_7(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_7_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055612, XrefRangeEnd = 1055619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _GetWidgetList_b__11_8()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_8_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _GetWidgetList_b__11_9()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_9_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _GetWidgetList_b__11_10(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_10_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055619, XrefRangeEnd = 1055625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _GetWidgetList_b__11_11()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_11_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055625, XrefRangeEnd = 1055631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _GetWidgetList_b__11_12()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetWidgetList_b__11_12_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderGraphDebugParams(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
