using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class DebugDisplaySettingsRenderGraph : Il2CppSystem.Object
{
	public class SettingsPanel : DebugDisplaySettingsPanel
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PanelName_Public_Virtual_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsRenderGraph_0;

		public unsafe override string PanelName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046763, XrefRangeEnd = 1046765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_PanelName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		static SettingsPanel()
		{
			Il2CppClassPointerStore<SettingsPanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRenderGraph>.NativeClassPtr, "SettingsPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsPanel>.NativeClassPtr);
			NativeMethodInfoPtr_get_PanelName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPanel>.NativeClassPtr, 100666004);
			NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsRenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPanel>.NativeClassPtr, 100666005);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1046811, RefRangeEnd = 1046812, XrefRangeStart = 1046765, XrefRangeEnd = 1046811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsPanel(DebugDisplaySettingsRenderGraph _)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsPanel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsRenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SettingsPanel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

	public unsafe virtual bool AreAnySettingsActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046840, XrefRangeEnd = 1046858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static DebugDisplaySettingsRenderGraph()
	{
		Il2CppClassPointerStore<DebugDisplaySettingsRenderGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugDisplaySettingsRenderGraph");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRenderGraph>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRenderGraph>.NativeClassPtr, 100666001);
		NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRenderGraph>.NativeClassPtr, 100666002);
		NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRenderGraph>.NativeClassPtr, 100666003);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1046835, RefRangeEnd = 1046836, XrefRangeStart = 1046812, XrefRangeEnd = 1046835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugDisplaySettingsRenderGraph()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRenderGraph>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046836, XrefRangeEnd = 1046840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IDebugDisplaySettingsPanelDisposable UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr2) : null;
	}

	public DebugDisplaySettingsRenderGraph(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
