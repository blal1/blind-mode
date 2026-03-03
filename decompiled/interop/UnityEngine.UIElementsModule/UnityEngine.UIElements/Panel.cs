using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000294")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class Panel : BaseVisualElementPanel
{
	[Token(Token = "0x4000A46")]
	internal const int k_DefaultPixelsPerUnit = 100;

	[Token(Token = "0x4000A47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private VisualElement m_RootContainer;

	[Token(Token = "0x4000A48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private VisualTreeUpdater m_VisualTreeUpdater;

	[Token(Token = "0x4000A49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem;

	[Token(Token = "0x4000A4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private string m_PanelName;

	[Token(Token = "0x4000A4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private uint m_Version;

	[Token(Token = "0x4000A4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private uint m_RepaintVersion;

	[Token(Token = "0x4000A4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private uint m_HierarchyVersion;

	[Token(Token = "0x4000A4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ProfilerMarker m_MarkerBeforeUpdate;

	[Token(Token = "0x4000A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ProfilerMarker m_MarkerUpdate;

	[Token(Token = "0x4000A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ProfilerMarker m_MarkerRender;

	[Token(Token = "0x4000A51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ProfilerMarker m_MarkerLayout;

	[Token(Token = "0x4000A52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private ProfilerMarker m_MarkerBindings;

	[Token(Token = "0x4000A53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private ProfilerMarker m_MarkerDataBinding;

	[Token(Token = "0x4000A54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ProfilerMarker m_MarkerAnimations;

	[Token(Token = "0x4000A55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ProfilerMarker m_MarkerPanelChangeReceiver;

	[Token(Token = "0x4000A56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ProfilerMarker s_MarkerPickAll;

	[Token(Token = "0x4000A58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private TimerEventScheduler m_Scheduler;

	[Token(Token = "0x4000A60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18B")]
	private bool m_JustReceivedFocus;

	[Token(Token = "0x4000A61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private IDebugPanelChangeReceiver m_PanelChangeReceiver;

	[Token(Token = "0x4000A65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private AtlasBase m_Atlas;

	[Token(Token = "0x4000A66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool m_ValidatingLayout;

	[Token(Token = "0x4000A67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<Panel> beforeAnyRepaint;

	[Token(Token = "0x17000358")]
	public sealed override VisualElement visualTree
	{
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x287DBE0", Offset = "0x287CDE0", VA = "0x18287DBE0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000359")]
	public sealed override EventDispatcher dispatcher
	{
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0xB19B10", Offset = "0xB18D10", VA = "0x180B19B10", Slot = "43")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700035A")]
	public TimerEventScheduler timerEventScheduler
	{
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x2B38F20", Offset = "0x2B38120", VA = "0x182B38F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700035B")]
	internal override IScheduler scheduler
	{
		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x2B38F20", Offset = "0x2B38120", VA = "0x182B38F20", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700035C")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal override IStylePropertyAnimationSystem styleAnimationSystem
	{
		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0", Slot = "45")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0x2B39130", Offset = "0x2B38330", VA = "0x182B39130", Slot = "46")]
		set
		{
		}
	}

	[Token(Token = "0x1700035D")]
	public override ScriptableObject ownerObject
	{
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0xEB35D0", Offset = "0xEB27D0", VA = "0x180EB35D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0xEB36D0", Offset = "0xEB28D0", VA = "0x180EB36D0", Slot = "14")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700035E")]
	public override ContextType contextType
	{
		[Token(Token = "0x60011CC")]
		[Address(RVA = "0x2B38EB0", Offset = "0x2B380B0", VA = "0x182B38EB0", Slot = "47")]
		[CompilerGenerated]
		get
		{
			return default(ContextType);
		}
	}

	[Token(Token = "0x1700035F")]
	public override SavePersistentViewData saveViewData
	{
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x49BCE0", Offset = "0x49AEE0", VA = "0x18049BCE0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000360")]
	public override GetViewDataDictionary getViewDataDictionary
	{
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0xEB35C0", Offset = "0xEB27C0", VA = "0x180EB35C0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000361")]
	public sealed override FocusController focusController
	{
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0xEB3600", Offset = "0xEB2800", VA = "0x180EB3600", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0xEB36F0", Offset = "0xEB28F0", VA = "0x180EB36F0", Slot = "20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000362")]
	public override UnityEngine.EventInterests IMGUIEventInterests
	{
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x2B38E30", Offset = "0x2B38030", VA = "0x182B38E30", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(UnityEngine.EventInterests);
		}
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x2B38FA0", Offset = "0x2B381A0", VA = "0x182B38FA0", Slot = "12")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000363")]
	private static LoadResourceFunction loadResourceFunc
	{
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x2B38EC0", Offset = "0x2B380C0", VA = "0x182B38EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000364")]
	internal string name
	{
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x2B38F10", Offset = "0x2B38110", VA = "0x182B38F10")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x2B39050", Offset = "0x2B38250", VA = "0x182B39050")]
		set
		{
		}
	}

	[Token(Token = "0x17000365")]
	public IDebugPanelChangeReceiver panelChangeReceiver
	{
		[Token(Token = "0x60011DA")]
		[Address(RVA = "0xAE41E0", Offset = "0xAE33E0", VA = "0x180AE41E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x2B39080", Offset = "0x2B38280", VA = "0x182B39080")]
		set
		{
		}
	}

	[Token(Token = "0x17000366")]
	private static TimeMsFunction TimeSinceStartup
	{
		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x2B38E50", Offset = "0x2B38050", VA = "0x182B38E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000367")]
	public override int IMGUIContainersCount
	{
		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x608CB0", Offset = "0x607EB0", VA = "0x180608CB0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x608FA0", Offset = "0x6081A0", VA = "0x180608FA0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000368")]
	public override IMGUIContainer rootIMGUIContainer
	{
		[Token(Token = "0x60011E0")]
		[Address(RVA = "0xAE41D0", Offset = "0xAE33D0", VA = "0x180AE41D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000369")]
	internal override uint version
	{
		[Token(Token = "0x60011E1")]
		[Address(RVA = "0x3F4B30", Offset = "0x3F3D30", VA = "0x1803F4B30", Slot = "30")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700036A")]
	internal override uint hierarchyVersion
	{
		[Token(Token = "0x60011E2")]
		[Address(RVA = "0xA2A0D0", Offset = "0xA292D0", VA = "0x180A2A0D0", Slot = "31")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700036B")]
	public override AtlasBase atlas
	{
		[Token(Token = "0x60011E3")]
		[Address(RVA = "0x2B38EA0", Offset = "0x2B380A0", VA = "0x182B38EA0", Slot = "51")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x2B38FC0", Offset = "0x2B381C0", VA = "0x182B38FC0", Slot = "52")]
		set
		{
		}
	}

	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x2B37A60", Offset = "0x2B36C60", VA = "0x182B37A60")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static Object LoadResource(string pathName, Type type, float dpiScaling)
	{
		return null;
	}

	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x2B37A20", Offset = "0x2B36C20", VA = "0x182B37A20")]
	internal void Focus()
	{
	}

	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x2B37460", Offset = "0x2B36660", VA = "0x182B37460")]
	internal void Blur()
	{
	}

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x2B38700", Offset = "0x2B37900", VA = "0x182B38700", Slot = "24")]
	public override void ValidateFocus()
	{
	}

	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x2B37580", Offset = "0x2B36780", VA = "0x182B37580")]
	private void CreateMarkers()
	{
	}

	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x2B388B0", Offset = "0x2B37AB0", VA = "0x182B388B0")]
	public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher)
	{
	}

	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x2B37810", Offset = "0x2B36A10", VA = "0x182B37810", Slot = "22")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x2B38540", Offset = "0x2B37740", VA = "0x182B38540")]
	public static long TimeSinceStartupMs()
	{
		return default(long);
	}

	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x2B377F0", Offset = "0x2B369F0", VA = "0x182B377F0")]
	internal static long DefaultTimeSinceStartupMs()
	{
		return default(long);
	}

	[Token(Token = "0x60011E9")]
	[Address(RVA = "0x2B380A0", Offset = "0x2B372A0", VA = "0x182B380A0")]
	private static VisualElement PickAll(VisualElement root, Vector2 point, [Optional] List<VisualElement> picked, bool includeIgnoredElement = false)
	{
		return null;
	}

	[Token(Token = "0x60011EA")]
	[Address(RVA = "0x2B37D30", Offset = "0x2B36F30", VA = "0x182B37D30")]
	private static VisualElement PerformPick(VisualElement root, Vector2 point, [Optional] List<VisualElement> picked, bool includeIgnoredElement = false)
	{
		return null;
	}

	[Token(Token = "0x60011EB")]
	[Address(RVA = "0x2B37FC0", Offset = "0x2B371C0", VA = "0x182B37FC0", Slot = "49")]
	public override VisualElement PickAll(Vector2 point, List<VisualElement> picked)
	{
		return null;
	}

	[Token(Token = "0x60011EC")]
	[Address(RVA = "0x2B38130", Offset = "0x2B37330", VA = "0x182B38130", Slot = "48")]
	public override VisualElement Pick(Vector2 point)
	{
		return null;
	}

	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x2B387D0", Offset = "0x2B379D0", VA = "0x182B387D0", Slot = "25")]
	public override void ValidateLayout()
	{
	}

	[Token(Token = "0x60011EE")]
	[Address(RVA = "0x2B38600", Offset = "0x2B37800", VA = "0x182B38600", Slot = "26")]
	public override void UpdateAnimations()
	{
	}

	[Token(Token = "0x60011EF")]
	[Address(RVA = "0x2B38630", Offset = "0x2B37830", VA = "0x182B38630", Slot = "27")]
	public override void UpdateBindings()
	{
	}

	[Token(Token = "0x60011F0")]
	[Address(RVA = "0x2B37430", Offset = "0x2B36630", VA = "0x182B37430", Slot = "28")]
	public override void ApplyStyles()
	{
	}

	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x2B38660", Offset = "0x2B37860", VA = "0x182B38660")]
	private void UpdateForRepaint()
	{
	}

	[Token(Token = "0x60011F2")]
	[Address(RVA = "0x2B382B0", Offset = "0x2B374B0", VA = "0x182B382B0", Slot = "23")]
	public override void Repaint(Event e)
	{
	}

	[Token(Token = "0x60011F3")]
	[Address(RVA = "0x2B28DB0", Offset = "0x2B27FB0", VA = "0x182B28DB0", Slot = "53")]
	public override void Render()
	{
	}

	[Token(Token = "0x60011F4")]
	[Address(RVA = "0x2B37BA0", Offset = "0x2B36DA0", VA = "0x182B37BA0", Slot = "32")]
	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x2B38510", Offset = "0x2B37710", VA = "0x182B38510", Slot = "33")]
	internal override void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
	{
	}

	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x2B37A30", Offset = "0x2B36C30", VA = "0x182B37A30", Slot = "50")]
	internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
	{
		return null;
	}
}
