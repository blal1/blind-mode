using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements.Layout;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x200034D")]
public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler
{
	[Token(Token = "0x200034E")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits>
	{
		[Token(Token = "0x6001A31")]
		[Address(RVA = "0x29EF850", Offset = "0x29EEA50", VA = "0x1829EF850")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200034F")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public class UxmlTraits : UnityEngine.UIElements.UxmlTraits
	{
		[Token(Token = "0x4000C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected UxmlStringAttributeDescription m_Name;

		[Token(Token = "0x4000C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UxmlBoolAttributeDescription m_EnabledSelf;

		[Token(Token = "0x4000C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UxmlStringAttributeDescription m_ViewDataKey;

		[Token(Token = "0x4000C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode;

		[Token(Token = "0x4000C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UxmlStringAttributeDescription m_Tooltip;

		[Token(Token = "0x4000C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UxmlEnumAttributeDescription<UsageHints> m_UsageHints;

		[Token(Token = "0x4000C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UxmlIntAttributeDescription m_TabIndex;

		[Token(Token = "0x4000C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UxmlStringAttributeDescription m_Class;

		[Token(Token = "0x4000C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UxmlStringAttributeDescription m_ContentContainer;

		[Token(Token = "0x4000C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UxmlStringAttributeDescription m_Style;

		[Token(Token = "0x4000C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UxmlAssetAttributeDescription<Object> m_DataSource;

		[Token(Token = "0x4000C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UxmlStringAttributeDescription m_DataSourcePath;

		[Token(Token = "0x17000712")]
		protected UxmlIntAttributeDescription focusIndex
		{
			[Token(Token = "0x6001A32")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000713")]
		protected UxmlBoolAttributeDescription focusable
		{
			[Token(Token = "0x6001A33")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x29EF890", Offset = "0x29EEA90", VA = "0x1829EF890", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x29EFE30", Offset = "0x29EF030", VA = "0x1829EFE30")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x2000350")]
	public enum MeasureMode
	{
		[Token(Token = "0x4000C28")]
		Undefined,
		[Token(Token = "0x4000C29")]
		Exactly,
		[Token(Token = "0x4000C2A")]
		AtMost
	}

	[Token(Token = "0x2000351")]
	internal enum RenderTargetMode
	{
		[Token(Token = "0x4000C2C")]
		None,
		[Token(Token = "0x4000C2D")]
		NoColorConversion,
		[Token(Token = "0x4000C2E")]
		LinearToGamma,
		[Token(Token = "0x4000C2F")]
		GammaToLinear
	}

	[Token(Token = "0x2000352")]
	public struct Hierarchy
	{
		[Token(Token = "0x4000C30")]
		private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation";

		[Token(Token = "0x4000C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly VisualElement m_Owner;

		[Token(Token = "0x17000714")]
		public VisualElement parent
		{
			[Token(Token = "0x6001A36")]
			[Address(RVA = "0x29DD180", Offset = "0x29DC380", VA = "0x1829DD180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000715")]
		internal List<VisualElement> children
		{
			[Token(Token = "0x6001A37")]
			[Address(RVA = "0x29DBC70", Offset = "0x29DAE70", VA = "0x1829DBC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000716")]
		public int childCount
		{
			[Token(Token = "0x6001A42")]
			[Address(RVA = "0x29DD130", Offset = "0x29DC330", VA = "0x1829DD130")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000717")]
		public VisualElement this[int key]
		{
			[Token(Token = "0x6001A43")]
			[Address(RVA = "0x29DC0B0", Offset = "0x29DB2B0", VA = "0x1829DC0B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
		internal Hierarchy(VisualElement element)
		{
		}

		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x29DBA90", Offset = "0x29DAC90", VA = "0x1829DBA90")]
		public void Add(VisualElement child)
		{
		}

		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x29DC250", Offset = "0x29DB450", VA = "0x1829DC250")]
		public void Insert(int index, VisualElement child)
		{
		}

		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x29DCE70", Offset = "0x29DC070", VA = "0x1829DCE70")]
		public void Remove(VisualElement child)
		{
		}

		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x29DCB20", Offset = "0x29DBD20", VA = "0x1829DCB20")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x29DBC90", Offset = "0x29DAE90", VA = "0x1829DBC90")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x29DBB40", Offset = "0x29DAD40", VA = "0x1829DBB40")]
		internal void BringToFront(VisualElement child)
		{
		}

		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x29DCFA0", Offset = "0x29DC1A0", VA = "0x1829DCFA0")]
		internal void SendToBack(VisualElement child)
		{
		}

		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x29DC740", Offset = "0x29DB940", VA = "0x1829DC740")]
		internal void PlaceBehind(VisualElement child, VisualElement over)
		{
		}

		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x29DC630", Offset = "0x29DB830", VA = "0x1829DC630")]
		private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex)
		{
		}

		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x29DC1F0", Offset = "0x29DB3F0", VA = "0x1829DC1F0")]
		public int IndexOf(VisualElement element)
		{
			return default(int);
		}

		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x29DC0B0", Offset = "0x29DB2B0", VA = "0x1829DC0B0")]
		public VisualElement ElementAt(int index)
		{
			return null;
		}

		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x29DBC70", Offset = "0x29DAE70", VA = "0x1829DBC70")]
		public IEnumerable<VisualElement> Children()
		{
			return null;
		}

		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x29DD040", Offset = "0x29DC240", VA = "0x1829DD040")]
		private void SetParent(VisualElement value)
		{
		}

		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x29DC840", Offset = "0x29DBA40", VA = "0x1829DC840")]
		private void PutChildAtIndex(VisualElement child, int index)
		{
		}

		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x29DCDF0", Offset = "0x29DBFF0", VA = "0x1829DCDF0")]
		private void RemoveChildAtIndex(int index)
		{
		}

		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x29DCA20", Offset = "0x29DBC20", VA = "0x1829DCA20")]
		private void ReleaseChildList()
		{
		}

		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x29DC1B0", Offset = "0x29DB3B0", VA = "0x1829DC1B0")]
		public bool Equals(Hierarchy other)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x29DC110", Offset = "0x29DB310", VA = "0x1829DC110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x29DC1C0", Offset = "0x29DB3C0", VA = "0x1829DC1C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x2851DA0", Offset = "0x2850FA0", VA = "0x182851DA0")]
		public static bool operator ==(Hierarchy x, Hierarchy y)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000353")]
	private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem
	{
		[Token(Token = "0x4000C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IScheduler scheduler;

		[Token(Token = "0x4000C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback;

		[Token(Token = "0x4000C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback;

		[Token(Token = "0x17000718")]
		public VisualElement element
		{
			[Token(Token = "0x6001A4F")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A50")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000719")]
		public bool isScheduled
		{
			[Token(Token = "0x6001A51")]
			[Address(RVA = "0xC5EA80", Offset = "0xC5DC80", VA = "0x180C5EA80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700071A")]
		public bool isActive
		{
			[Token(Token = "0x6001A52")]
			[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A53")]
			[Address(RVA = "0x8C82C0", Offset = "0x8C74C0", VA = "0x1808C82C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700071B")]
		public bool isDetaching
		{
			[Token(Token = "0x6001A54")]
			[Address(RVA = "0x7CE730", Offset = "0x7CD930", VA = "0x1807CE730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A55")]
			[Address(RVA = "0xD99E80", Offset = "0xD99080", VA = "0x180D99E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6001A56")]
		[Address(RVA = "0x29D96E0", Offset = "0x29D88E0", VA = "0x1829D96E0")]
		protected BaseVisualElementScheduledItem(VisualElement handler)
		{
		}

		[Token(Token = "0x6001A57")]
		[Address(RVA = "0x29D9550", Offset = "0x29D8750", VA = "0x1829D9550")]
		private void SetActive(bool action)
		{
		}

		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x29D93D0", Offset = "0x29D85D0", VA = "0x1829D93D0")]
		private void SendActivation()
		{
		}

		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x29D94B0", Offset = "0x29D86B0", VA = "0x1829D94B0")]
		private void SendDeactivation()
		{
		}

		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x29D9170", Offset = "0x29D8370", VA = "0x1829D9170")]
		private void OnElementAttachToPanelCallback(AttachToPanelEvent evt)
		{
		}

		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x29D91F0", Offset = "0x29D83F0", VA = "0x1829D91F0")]
		private void OnElementDetachFromPanelCallback(DetachFromPanelEvent evt)
		{
		}

		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x29D9650", Offset = "0x29D8850", VA = "0x1829D9650", Slot = "11")]
		public IVisualElementScheduledItem StartingIn(long delayMs)
		{
			return null;
		}

		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x29D9660", Offset = "0x29D8860", VA = "0x1829D9660", Slot = "13")]
		public IVisualElementScheduledItem Until(Func<bool> stopCondition)
		{
			return null;
		}

		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x29D9070", Offset = "0x29D8270", VA = "0x1829D9070", Slot = "12")]
		public IVisualElementScheduledItem Every(long intervalMs)
		{
			return null;
		}

		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x29D9250", Offset = "0x29D8450", VA = "0x1829D9250", Slot = "5")]
		internal override void OnItemUnscheduled()
		{
		}

		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x29D93C0", Offset = "0x29D85C0", VA = "0x1829D93C0", Slot = "8")]
		public void Resume()
		{
		}

		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x29D93B0", Offset = "0x29D85B0", VA = "0x1829D93B0", Slot = "9")]
		public void Pause()
		{
		}

		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x29D9130", Offset = "0x29D8330", VA = "0x1829D9130", Slot = "10")]
		public void ExecuteLater(long delayMs)
		{
		}

		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x29D92A0", Offset = "0x29D84A0", VA = "0x1829D92A0")]
		public void OnPanelActivate()
		{
		}

		[Token(Token = "0x6001A64")]
		[Address(RVA = "0x29D9340", Offset = "0x29D8540", VA = "0x1829D9340")]
		public void OnPanelDeactivate()
		{
		}

		[Token(Token = "0x6001A65")]
		[Address(RVA = "0x29D9020", Offset = "0x29D8220", VA = "0x1829D9020")]
		public bool CanBeActivated()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000354")]
	private abstract class VisualElementScheduledItem<ActionType> : BaseVisualElementScheduledItem
	{
		[Token(Token = "0x4000C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ActionType updateEvent;

		[Token(Token = "0x6001A66")]
		public VisualElementScheduledItem(VisualElement handler, ActionType upEvent)
		{
		}
	}

	[Token(Token = "0x2000355")]
	private class TimerStateScheduledItem : VisualElementScheduledItem<Action<TimerState>>
	{
		[Token(Token = "0x6001A67")]
		[Address(RVA = "0x29EC2F0", Offset = "0x29EB4F0", VA = "0x1829EC2F0")]
		public TimerStateScheduledItem(VisualElement handler, Action<TimerState> updateEvent)
		{
		}

		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x29EC2B0", Offset = "0x29EB4B0", VA = "0x1829EC2B0", Slot = "4")]
		public override void PerformTimerUpdate(TimerState state)
		{
		}
	}

	[Token(Token = "0x2000356")]
	private class SimpleScheduledItem : VisualElementScheduledItem<Action>
	{
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x29E5F40", Offset = "0x29E5140", VA = "0x1829E5F40")]
		public SimpleScheduledItem(VisualElement handler, Action updateEvent)
		{
		}

		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x29E5F00", Offset = "0x29E5100", VA = "0x1829E5F00", Slot = "4")]
		public override void PerformTimerUpdate(TimerState state)
		{
		}
	}

	[Token(Token = "0x2000357")]
	internal class CustomStyleAccess : ICustomStyle
	{
		[Token(Token = "0x4000C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, StylePropertyValue> m_CustomProperties;

		[Token(Token = "0x4000C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_DpiScaling;

		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x29DA8B0", Offset = "0x29D9AB0", VA = "0x1829DA8B0")]
		public void SetContext(Dictionary<string, StylePropertyValue> customProperties, float dpiScaling)
		{
		}

		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x29DAD40", Offset = "0x29D9F40", VA = "0x1829DAD40", Slot = "4")]
		public bool TryGetValue(CustomStyleProperty<float> property, out float value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x29DAA50", Offset = "0x29D9C50", VA = "0x1829DAA50", Slot = "5")]
		public bool TryGetValue(CustomStyleProperty<int> property, out int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x29DA8E0", Offset = "0x29D9AE0", VA = "0x1829DA8E0", Slot = "6")]
		public bool TryGetValue(CustomStyleProperty<Color> property, out Color value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x29DAB70", Offset = "0x29D9D70", VA = "0x1829DAB70", Slot = "7")]
		public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x29DAF60", Offset = "0x29DA160", VA = "0x1829DAF60", Slot = "8")]
		public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x29DAE50", Offset = "0x29DA050", VA = "0x1829DAE50", Slot = "9")]
		public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x29DB070", Offset = "0x29DA270", VA = "0x1829DB070", Slot = "10")]
		public bool TryGetValue(CustomStyleProperty<string> property, out string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x29DAC80", Offset = "0x29D9E80", VA = "0x1829DAC80")]
		private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x29DA7D0", Offset = "0x29D99D0", VA = "0x1829DA7D0")]
		private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp)
		{
		}

		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CustomStyleAccess()
		{
		}
	}

	[Token(Token = "0x2000358")]
	internal class TypeData
	{
		[Token(Token = "0x4000C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_FullTypeName;

		[Token(Token = "0x4000C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_TypeName;

		[Token(Token = "0x1700071C")]
		public Type type
		{
			[Token(Token = "0x6001A76")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071D")]
		public string fullTypeName
		{
			[Token(Token = "0x6001A78")]
			[Address(RVA = "0x29EE2B0", Offset = "0x29ED4B0", VA = "0x1829EE2B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071E")]
		public string typeName
		{
			[Token(Token = "0x6001A79")]
			[Address(RVA = "0x29EE310", Offset = "0x29ED510", VA = "0x1829EE310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x29EE240", Offset = "0x29ED440", VA = "0x1829EE240")]
		public TypeData(Type type)
		{
		}
	}

	[Token(Token = "0x4000BB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static uint s_NextId;

	[Token(Token = "0x4000BB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<string> s_EmptyClassList;

	[Token(Token = "0x4000BB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static readonly PropertyName userDataPropertyKey;

	[Token(Token = "0x4000BB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string disabledUssClassName;

	[Token(Token = "0x4000BB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string m_Name;

	[Token(Token = "0x4000BB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<string> m_ClassList;

	[Token(Token = "0x4000BB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<PropertyName, object> m_PropertyBag;

	[Token(Token = "0x4000BBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	internal VisualElementFlags m_Flags;

	[Token(Token = "0x4000BBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string m_ViewDataKey;

	[Token(Token = "0x4000BBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private RenderHints m_RenderHints;

	[Token(Token = "0x4000BBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	internal Rect lastLayout;

	[Token(Token = "0x4000BBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	internal Rect lastPseudoPadding;

	[Token(Token = "0x4000BBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	internal RenderChainVEData renderChainData;

	[Token(Token = "0x4000BC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal bool shouldCutRenderChain;

	[Token(Token = "0x4000BC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal UIRenderer uiRenderer;

	[Token(Token = "0x4000BC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private Rect m_Layout;

	[Token(Token = "0x4000BC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private Rect m_BoundingBox;

	[Token(Token = "0x4000BC4")]
	private const VisualElementFlags worldBoundingBoxDirtyDependencies = VisualElementFlags.WorldTransformDirty | VisualElementFlags.BoundingBoxDirty | VisualElementFlags.WorldBoundingBoxDirty;

	[Token(Token = "0x4000BC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Rect m_WorldBoundingBox;

	[Token(Token = "0x4000BC6")]
	private const VisualElementFlags worldTransformInverseDirtyDependencies = VisualElementFlags.WorldTransformDirty | VisualElementFlags.WorldTransformInverseDirty;

	[Token(Token = "0x4000BC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private Matrix4x4 m_WorldTransformCache;

	[Token(Token = "0x4000BC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private Matrix4x4 m_WorldTransformInverseCache;

	[Token(Token = "0x4000BC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Rect m_WorldClip;

	[Token(Token = "0x4000BCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private Rect m_WorldClipMinusGroup;

	[Token(Token = "0x4000BCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private bool m_WorldClipIsInfinite;

	[Token(Token = "0x4000BCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal static readonly Rect s_InfiniteRect;

	[Token(Token = "0x4000BCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
	internal PseudoStates triggerPseudoMask;

	[Token(Token = "0x4000BCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	internal PseudoStates dependencyPseudoMask;

	[Token(Token = "0x4000BCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
	private PseudoStates m_PseudoStates;

	[Token(Token = "0x4000BD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
	private PickingMode m_PickingMode;

	[Token(Token = "0x4000BD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private LayoutNode m_LayoutNode;

	[Token(Token = "0x4000BD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	internal ComputedStyle m_Style;

	[Token(Token = "0x4000BD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal StyleVariableContext variableContext;

	[Token(Token = "0x4000BD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	internal int inheritedStylesHash;

	[Token(Token = "0x4000BD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
	internal readonly uint controlid;

	[Token(Token = "0x4000BD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	internal int imguiContainerDescendantCount;

	[Token(Token = "0x4000BD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	private bool m_EnabledSelf;

	[Token(Token = "0x4000BD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	private LanguageDirection m_LanguageDirection;

	[Token(Token = "0x4000BDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
	private LanguageDirection m_LocalLanguageDirection;

	[Token(Token = "0x4000BDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly ProfilerMarker k_GenerateVisualContentMarker;

	[Token(Token = "0x4000BDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	private RenderTargetMode m_SubRenderTargetMode;

	[Token(Token = "0x4000BDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static Material s_runtimeMaterial;

	[Token(Token = "0x4000BDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	private Material m_defaultMaterial;

	[Token(Token = "0x4000BE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	private List<IValueAnimationUpdate> m_RunningAnimations;

	[Token(Token = "0x4000BE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal static readonly BindingId childCountProperty;

	[Token(Token = "0x4000BE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	internal static readonly BindingId contentRectProperty;

	[Token(Token = "0x4000BE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	internal static readonly BindingId dataSourcePathProperty;

	[Token(Token = "0x4000BE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	internal static readonly BindingId dataSourceProperty;

	[Token(Token = "0x4000BE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	internal static readonly BindingId disablePlayModeTintProperty;

	[Token(Token = "0x4000BE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	internal static readonly BindingId enabledInHierarchyProperty;

	[Token(Token = "0x4000BE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	internal static readonly BindingId enabledSelfProperty;

	[Token(Token = "0x4000BE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
	internal static readonly BindingId layoutProperty;

	[Token(Token = "0x4000BE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
	internal static readonly BindingId languageDirectionProperty;

	[Token(Token = "0x4000BEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
	internal static readonly BindingId localBoundProperty;

	[Token(Token = "0x4000BEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
	internal static readonly BindingId nameProperty;

	[Token(Token = "0x4000BEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
	internal static readonly BindingId panelProperty;

	[Token(Token = "0x4000BED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
	internal static readonly BindingId pickingModeProperty;

	[Token(Token = "0x4000BEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
	internal static readonly BindingId styleSheetsProperty;

	[Token(Token = "0x4000BEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x890")]
	internal static readonly BindingId tooltipProperty;

	[Token(Token = "0x4000BF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x928")]
	internal static readonly BindingId usageHintsProperty;

	[Token(Token = "0x4000BF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C0")]
	internal static readonly BindingId userDataProperty;

	[Token(Token = "0x4000BF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA58")]
	internal static readonly BindingId viewDataKeyProperty;

	[Token(Token = "0x4000BF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAF0")]
	internal static readonly BindingId visibleProperty;

	[Token(Token = "0x4000BF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB88")]
	internal static readonly BindingId visualTreeAssetSourceProperty;

	[Token(Token = "0x4000BF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC20")]
	internal static readonly BindingId worldBoundProperty;

	[Token(Token = "0x4000BF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCB8")]
	internal static readonly BindingId worldTransformProperty;

	[Token(Token = "0x4000BF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	private object m_DataSource;

	[Token(Token = "0x4000BF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	private PropertyPath m_DataSourcePath;

	[Token(Token = "0x4000BF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	private List<Binding> m_Bindings;

	[Token(Token = "0x4000BFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	private readonly int m_TrickleDownHandleEventCategories;

	[Token(Token = "0x4000BFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
	private readonly int m_BubbleUpHandleEventCategories;

	[Token(Token = "0x4000BFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	private int m_BubbleUpEventCallbackCategories;

	[Token(Token = "0x4000BFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
	private int m_TrickleDownEventCallbackCategories;

	[Token(Token = "0x4000BFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	private int m_EventInterestSelfCategories;

	[Token(Token = "0x4000C00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
	private int m_CachedEventInterestParentCategories;

	[Token(Token = "0x4000C01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD50")]
	private static uint s_NextParentVersion;

	[Token(Token = "0x4000C02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	private uint m_NextParentCachedVersion;

	[Token(Token = "0x4000C03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x434")]
	private uint m_NextParentRequiredVersion;

	[Token(Token = "0x4000C04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	private VisualElement m_CachedNextParentWithEventInterests;

	[Token(Token = "0x4000C05")]
	internal const string k_RootVisualContainerName = "rootVisualContainer";

	[Token(Token = "0x4000C09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
	private VisualElement m_PhysicalParent;

	[Token(Token = "0x4000C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
	private VisualElement m_LogicalParent;

	[Token(Token = "0x4000C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD58")]
	private static readonly List<VisualElement> s_EmptyList;

	[Token(Token = "0x4000C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
	private List<VisualElement> m_Children;

	[Token(Token = "0x4000C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
	private VisualTreeAsset m_VisualTreeAssetSource;

	[Token(Token = "0x4000C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD60")]
	internal static CustomStyleAccess s_CustomStyleAccess;

	[Token(Token = "0x4000C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
	internal InlineStyleAccess inlineStyleAccess;

	[Token(Token = "0x4000C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
	internal ResolvedStyleAccess resolvedStyleAccess;

	[Token(Token = "0x4000C14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal List<StyleSheet> styleSheetList;

	[Token(Token = "0x4000C15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD68")]
	private static readonly Regex s_InternalStyleSheetPath;

	[Token(Token = "0x4000C16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD70")]
	internal static readonly PropertyName tooltipPropertyKey;

	[Token(Token = "0x4000C17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD78")]
	private static readonly Dictionary<Type, TypeData> s_TypeData;

	[Token(Token = "0x4000C18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
	private TypeData m_TypeData;

	[Token(Token = "0x1700065E")]
	private Align UnityEngine_002EUIElements_002EIResolvedStyle_002EalignContent
	{
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x29CC240", Offset = "0x29CB440", VA = "0x1829CC240", Slot = "21")]
		get
		{
			return default(Align);
		}
	}

	[Token(Token = "0x1700065F")]
	private Align UnityEngine_002EUIElements_002EIResolvedStyle_002EalignItems
	{
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x29CC290", Offset = "0x29CB490", VA = "0x1829CC290", Slot = "22")]
		get
		{
			return default(Align);
		}
	}

	[Token(Token = "0x17000660")]
	private Align UnityEngine_002EUIElements_002EIResolvedStyle_002EalignSelf
	{
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x29CC2F0", Offset = "0x29CB4F0", VA = "0x1829CC2F0", Slot = "23")]
		get
		{
			return default(Align);
		}
	}

	[Token(Token = "0x17000661")]
	private Color UnityEngine_002EUIElements_002EIResolvedStyle_002EbackgroundColor
	{
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x29CC350", Offset = "0x29CB550", VA = "0x1829CC350", Slot = "24")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000662")]
	private Background UnityEngine_002EUIElements_002EIResolvedStyle_002EbackgroundImage
	{
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x29CC430", Offset = "0x29CB630", VA = "0x1829CC430", Slot = "25")]
		get
		{
			return default(Background);
		}
	}

	[Token(Token = "0x17000663")]
	private BackgroundPosition UnityEngine_002EUIElements_002EIResolvedStyle_002EbackgroundPositionX
	{
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x29CC510", Offset = "0x29CB710", VA = "0x1829CC510", Slot = "26")]
		get
		{
			return default(BackgroundPosition);
		}
	}

	[Token(Token = "0x17000664")]
	private BackgroundPosition UnityEngine_002EUIElements_002EIResolvedStyle_002EbackgroundPositionY
	{
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x29CC5F0", Offset = "0x29CB7F0", VA = "0x1829CC5F0", Slot = "27")]
		get
		{
			return default(BackgroundPosition);
		}
	}

	[Token(Token = "0x17000665")]
	private BackgroundRepeat UnityEngine_002EUIElements_002EIResolvedStyle_002EbackgroundRepeat
	{
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x29CC6D0", Offset = "0x29CB8D0", VA = "0x1829CC6D0", Slot = "28")]
		get
		{
			return default(BackgroundRepeat);
		}
	}

	[Token(Token = "0x17000666")]
	private BackgroundSize UnityEngine_002EUIElements_002EIResolvedStyle_002EbackgroundSize
	{
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x29CC7A0", Offset = "0x29CB9A0", VA = "0x1829CC7A0", Slot = "29")]
		get
		{
			return default(BackgroundSize);
		}
	}

	[Token(Token = "0x17000667")]
	private Color UnityEngine_002EUIElements_002EIResolvedStyle_002EborderBottomColor
	{
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x29CC880", Offset = "0x29CBA80", VA = "0x1829CC880", Slot = "30")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000668")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EborderBottomLeftRadius
	{
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x29CC960", Offset = "0x29CBB60", VA = "0x1829CC960", Slot = "31")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000669")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EborderBottomRightRadius
	{
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x29CC9C0", Offset = "0x29CBBC0", VA = "0x1829CC9C0", Slot = "32")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700066A")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EborderBottomWidth
	{
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x29CCA20", Offset = "0x29CBC20", VA = "0x1829CCA20", Slot = "33")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700066B")]
	private Color UnityEngine_002EUIElements_002EIResolvedStyle_002EborderLeftColor
	{
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x29CCA80", Offset = "0x29CBC80", VA = "0x1829CCA80", Slot = "34")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700066C")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EborderLeftWidth
	{
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x29CCB60", Offset = "0x29CBD60", VA = "0x1829CCB60", Slot = "35")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700066D")]
	private Color UnityEngine_002EUIElements_002EIResolvedStyle_002EborderRightColor
	{
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x29CCBC0", Offset = "0x29CBDC0", VA = "0x1829CCBC0", Slot = "36")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700066E")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EborderRightWidth
	{
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x29CCCA0", Offset = "0x29CBEA0", VA = "0x1829CCCA0", Slot = "37")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700066F")]
	private Color UnityEngine_002EUIElements_002EIResolvedStyle_002EborderTopColor
	{
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x29CCD00", Offset = "0x29CBF00", VA = "0x1829CCD00", Slot = "38")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000670")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EborderTopLeftRadius
	{
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x29CCDE0", Offset = "0x29CBFE0", VA = "0x1829CCDE0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000671")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EborderTopRightRadius
	{
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x29CCE40", Offset = "0x29CC040", VA = "0x1829CCE40", Slot = "40")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000672")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EborderTopWidth
	{
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x29CCEA0", Offset = "0x29CC0A0", VA = "0x1829CCEA0", Slot = "41")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000673")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002Ebottom
	{
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x29CCF00", Offset = "0x29CC100", VA = "0x1829CCF00", Slot = "42")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000674")]
	private Color UnityEngine_002EUIElements_002EIResolvedStyle_002Ecolor
	{
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x29CCF60", Offset = "0x29CC160", VA = "0x1829CCF60", Slot = "43")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000675")]
	private DisplayStyle UnityEngine_002EUIElements_002EIResolvedStyle_002Edisplay
	{
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x29CD040", Offset = "0x29CC240", VA = "0x1829CD040", Slot = "44")]
		get
		{
			return default(DisplayStyle);
		}
	}

	[Token(Token = "0x17000676")]
	private StyleFloat UnityEngine_002EUIElements_002EIResolvedStyle_002EflexBasis
	{
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x29CD0A0", Offset = "0x29CC2A0", VA = "0x1829CD0A0", Slot = "45")]
		get
		{
			return default(StyleFloat);
		}
	}

	[Token(Token = "0x17000677")]
	private FlexDirection UnityEngine_002EUIElements_002EIResolvedStyle_002EflexDirection
	{
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x29CD100", Offset = "0x29CC300", VA = "0x1829CD100", Slot = "46")]
		get
		{
			return default(FlexDirection);
		}
	}

	[Token(Token = "0x17000678")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EflexGrow
	{
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x29CD160", Offset = "0x29CC360", VA = "0x1829CD160", Slot = "47")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000679")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EflexShrink
	{
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x29CD1C0", Offset = "0x29CC3C0", VA = "0x1829CD1C0", Slot = "48")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700067A")]
	private Wrap UnityEngine_002EUIElements_002EIResolvedStyle_002EflexWrap
	{
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x29CD220", Offset = "0x29CC420", VA = "0x1829CD220", Slot = "49")]
		get
		{
			return default(Wrap);
		}
	}

	[Token(Token = "0x1700067B")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EfontSize
	{
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x29CD280", Offset = "0x29CC480", VA = "0x1829CD280", Slot = "50")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700067C")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002Eheight
	{
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x29CD2E0", Offset = "0x29CC4E0", VA = "0x1829CD2E0", Slot = "51")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700067D")]
	private Justify UnityEngine_002EUIElements_002EIResolvedStyle_002EjustifyContent
	{
		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x29CD340", Offset = "0x29CC540", VA = "0x1829CD340", Slot = "52")]
		get
		{
			return default(Justify);
		}
	}

	[Token(Token = "0x1700067E")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002Eleft
	{
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x29CD3A0", Offset = "0x29CC5A0", VA = "0x1829CD3A0", Slot = "53")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700067F")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EletterSpacing
	{
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x29CD400", Offset = "0x29CC600", VA = "0x1829CD400", Slot = "54")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000680")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EmarginBottom
	{
		[Token(Token = "0x60018CB")]
		[Address(RVA = "0x29CD460", Offset = "0x29CC660", VA = "0x1829CD460", Slot = "55")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000681")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EmarginLeft
	{
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x29CD4C0", Offset = "0x29CC6C0", VA = "0x1829CD4C0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000682")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EmarginRight
	{
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x29CD520", Offset = "0x29CC720", VA = "0x1829CD520", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000683")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EmarginTop
	{
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x29CD580", Offset = "0x29CC780", VA = "0x1829CD580", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000684")]
	private StyleFloat UnityEngine_002EUIElements_002EIResolvedStyle_002EmaxHeight
	{
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x29CD5E0", Offset = "0x29CC7E0", VA = "0x1829CD5E0", Slot = "59")]
		get
		{
			return default(StyleFloat);
		}
	}

	[Token(Token = "0x17000685")]
	private StyleFloat UnityEngine_002EUIElements_002EIResolvedStyle_002EmaxWidth
	{
		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x29CD640", Offset = "0x29CC840", VA = "0x1829CD640", Slot = "60")]
		get
		{
			return default(StyleFloat);
		}
	}

	[Token(Token = "0x17000686")]
	private StyleFloat UnityEngine_002EUIElements_002EIResolvedStyle_002EminHeight
	{
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x29CD6A0", Offset = "0x29CC8A0", VA = "0x1829CD6A0", Slot = "61")]
		get
		{
			return default(StyleFloat);
		}
	}

	[Token(Token = "0x17000687")]
	private StyleFloat UnityEngine_002EUIElements_002EIResolvedStyle_002EminWidth
	{
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x29CD700", Offset = "0x29CC900", VA = "0x1829CD700", Slot = "62")]
		get
		{
			return default(StyleFloat);
		}
	}

	[Token(Token = "0x17000688")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002Eopacity
	{
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x29CD760", Offset = "0x29CC960", VA = "0x1829CD760", Slot = "63")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000689")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EpaddingBottom
	{
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x29CD7C0", Offset = "0x29CC9C0", VA = "0x1829CD7C0", Slot = "64")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700068A")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EpaddingLeft
	{
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x29CD820", Offset = "0x29CCA20", VA = "0x1829CD820", Slot = "65")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700068B")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EpaddingRight
	{
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x29CD880", Offset = "0x29CCA80", VA = "0x1829CD880", Slot = "66")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700068C")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EpaddingTop
	{
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x29CD8E0", Offset = "0x29CCAE0", VA = "0x1829CD8E0", Slot = "67")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700068D")]
	private Position UnityEngine_002EUIElements_002EIResolvedStyle_002Eposition
	{
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x29CD940", Offset = "0x29CCB40", VA = "0x1829CD940", Slot = "68")]
		get
		{
			return default(Position);
		}
	}

	[Token(Token = "0x1700068E")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002Eright
	{
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x29CD9A0", Offset = "0x29CCBA0", VA = "0x1829CD9A0", Slot = "69")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700068F")]
	private Rotate UnityEngine_002EUIElements_002EIResolvedStyle_002Erotate
	{
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x29CDA00", Offset = "0x29CCC00", VA = "0x1829CDA00", Slot = "70")]
		get
		{
			return default(Rotate);
		}
	}

	[Token(Token = "0x17000690")]
	private Scale UnityEngine_002EUIElements_002EIResolvedStyle_002Escale
	{
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x29CDAE0", Offset = "0x29CCCE0", VA = "0x1829CDAE0", Slot = "71")]
		get
		{
			return default(Scale);
		}
	}

	[Token(Token = "0x17000691")]
	private TextOverflow UnityEngine_002EUIElements_002EIResolvedStyle_002EtextOverflow
	{
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x29CDBC0", Offset = "0x29CCDC0", VA = "0x1829CDBC0", Slot = "72")]
		get
		{
			return default(TextOverflow);
		}
	}

	[Token(Token = "0x17000692")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002Etop
	{
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x29CDC20", Offset = "0x29CCE20", VA = "0x1829CDC20", Slot = "73")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000693")]
	private Vector3 UnityEngine_002EUIElements_002EIResolvedStyle_002EtransformOrigin
	{
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x29CDC80", Offset = "0x29CCE80", VA = "0x1829CDC80", Slot = "74")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000694")]
	private IEnumerable<TimeValue> UnityEngine_002EUIElements_002EIResolvedStyle_002EtransitionDelay
	{
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x29CDD60", Offset = "0x29CCF60", VA = "0x1829CDD60", Slot = "75")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000695")]
	private IEnumerable<TimeValue> UnityEngine_002EUIElements_002EIResolvedStyle_002EtransitionDuration
	{
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x29CDDC0", Offset = "0x29CCFC0", VA = "0x1829CDDC0", Slot = "76")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000696")]
	private IEnumerable<StylePropertyName> UnityEngine_002EUIElements_002EIResolvedStyle_002EtransitionProperty
	{
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x29CDE20", Offset = "0x29CD020", VA = "0x1829CDE20", Slot = "77")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000697")]
	private IEnumerable<EasingFunction> UnityEngine_002EUIElements_002EIResolvedStyle_002EtransitionTimingFunction
	{
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x29CDE80", Offset = "0x29CD080", VA = "0x1829CDE80", Slot = "78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000698")]
	private Vector3 UnityEngine_002EUIElements_002EIResolvedStyle_002Etranslate
	{
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x29CDEE0", Offset = "0x29CD0E0", VA = "0x1829CDEE0", Slot = "79")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000699")]
	private Color UnityEngine_002EUIElements_002EIResolvedStyle_002EunityBackgroundImageTintColor
	{
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x29CDFC0", Offset = "0x29CD1C0", VA = "0x1829CDFC0", Slot = "80")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700069A")]
	private EditorTextRenderingMode UnityEngine_002EUIElements_002EIResolvedStyle_002EunityEditorTextRenderingMode
	{
		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x29CE0A0", Offset = "0x29CD2A0", VA = "0x1829CE0A0", Slot = "81")]
		get
		{
			return default(EditorTextRenderingMode);
		}
	}

	[Token(Token = "0x1700069B")]
	private Font UnityEngine_002EUIElements_002EIResolvedStyle_002EunityFont
	{
		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x29CE240", Offset = "0x29CD440", VA = "0x1829CE240", Slot = "82")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700069C")]
	private FontDefinition UnityEngine_002EUIElements_002EIResolvedStyle_002EunityFontDefinition
	{
		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x29CE100", Offset = "0x29CD300", VA = "0x1829CE100", Slot = "83")]
		get
		{
			return default(FontDefinition);
		}
	}

	[Token(Token = "0x1700069D")]
	private FontStyle UnityEngine_002EUIElements_002EIResolvedStyle_002EunityFontStyleAndWeight
	{
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x29CE1E0", Offset = "0x29CD3E0", VA = "0x1829CE1E0", Slot = "84")]
		get
		{
			return default(FontStyle);
		}
	}

	[Token(Token = "0x1700069E")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EunityParagraphSpacing
	{
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x29CE310", Offset = "0x29CD510", VA = "0x1829CE310", Slot = "85")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700069F")]
	private int UnityEngine_002EUIElements_002EIResolvedStyle_002EunitySliceBottom
	{
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x29CE370", Offset = "0x29CD570", VA = "0x1829CE370", Slot = "86")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A0")]
	private int UnityEngine_002EUIElements_002EIResolvedStyle_002EunitySliceLeft
	{
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x29CE3D0", Offset = "0x29CD5D0", VA = "0x1829CE3D0", Slot = "87")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A1")]
	private int UnityEngine_002EUIElements_002EIResolvedStyle_002EunitySliceRight
	{
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x29CE430", Offset = "0x29CD630", VA = "0x1829CE430", Slot = "88")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A2")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EunitySliceScale
	{
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x29CE490", Offset = "0x29CD690", VA = "0x1829CE490", Slot = "89")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170006A3")]
	private int UnityEngine_002EUIElements_002EIResolvedStyle_002EunitySliceTop
	{
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x29CE4F0", Offset = "0x29CD6F0", VA = "0x1829CE4F0", Slot = "90")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006A4")]
	private SliceType UnityEngine_002EUIElements_002EIResolvedStyle_002EunitySliceType
	{
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x29CE550", Offset = "0x29CD750", VA = "0x1829CE550", Slot = "91")]
		get
		{
			return default(SliceType);
		}
	}

	[Token(Token = "0x170006A5")]
	private TextAnchor UnityEngine_002EUIElements_002EIResolvedStyle_002EunityTextAlign
	{
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x29CE5B0", Offset = "0x29CD7B0", VA = "0x1829CE5B0", Slot = "92")]
		get
		{
			return default(TextAnchor);
		}
	}

	[Token(Token = "0x170006A6")]
	private TextGeneratorType UnityEngine_002EUIElements_002EIResolvedStyle_002EunityTextGenerator
	{
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x29CE610", Offset = "0x29CD810", VA = "0x1829CE610", Slot = "93")]
		get
		{
			return default(TextGeneratorType);
		}
	}

	[Token(Token = "0x170006A7")]
	private Color UnityEngine_002EUIElements_002EIResolvedStyle_002EunityTextOutlineColor
	{
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x29CE670", Offset = "0x29CD870", VA = "0x1829CE670", Slot = "94")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006A8")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EunityTextOutlineWidth
	{
		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x29CE750", Offset = "0x29CD950", VA = "0x1829CE750", Slot = "95")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170006A9")]
	private TextOverflowPosition UnityEngine_002EUIElements_002EIResolvedStyle_002EunityTextOverflowPosition
	{
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x29CE7B0", Offset = "0x29CD9B0", VA = "0x1829CE7B0", Slot = "96")]
		get
		{
			return default(TextOverflowPosition);
		}
	}

	[Token(Token = "0x170006AA")]
	private Visibility UnityEngine_002EUIElements_002EIResolvedStyle_002Evisibility
	{
		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x29CE810", Offset = "0x29CDA10", VA = "0x1829CE810", Slot = "97")]
		get
		{
			return default(Visibility);
		}
	}

	[Token(Token = "0x170006AB")]
	private WhiteSpace UnityEngine_002EUIElements_002EIResolvedStyle_002EwhiteSpace
	{
		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x29CE870", Offset = "0x29CDA70", VA = "0x1829CE870", Slot = "98")]
		get
		{
			return default(WhiteSpace);
		}
	}

	[Token(Token = "0x170006AC")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002Ewidth
	{
		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x29CE8D0", Offset = "0x29CDAD0", VA = "0x1829CE8D0", Slot = "99")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170006AD")]
	private float UnityEngine_002EUIElements_002EIResolvedStyle_002EwordSpacing
	{
		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x29CE930", Offset = "0x29CDB30", VA = "0x1829CE930", Slot = "100")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170006AE")]
	internal bool hasRunningAnimations
	{
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x29D4B00", Offset = "0x29D3D00", VA = "0x1829D4B00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006AF")]
	internal bool hasCompletedAnimations
	{
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x29D4AA0", Offset = "0x29D3CA0", VA = "0x1829D4AA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006B0")]
	private int UnityEngine_002EUIElements_002EIStylePropertyAnimations_002ErunningAnimationCount
	{
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840", Slot = "121")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0", Slot = "122")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170006B1")]
	private int UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EcompletedAnimationCount
	{
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0", Slot = "123")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x9941B0", Offset = "0x9933B0", VA = "0x1809941B0", Slot = "124")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170006B2")]
	internal IStylePropertyAnimations styleAnimation
	{
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x52BB60", Offset = "0x52AD60", VA = "0x18052BB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B3")]
	internal bool isCompositeRoot
	{
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x29D4B70", Offset = "0x29D3D70", VA = "0x1829D4B70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x29D63E0", Offset = "0x29D55E0", VA = "0x1829D63E0")]
		set
		{
		}
	}

	[Token(Token = "0x170006B4")]
	internal bool areAncestorsAndSelfDisplayed
	{
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x29D3F50", Offset = "0x29D3150", VA = "0x1829D3F50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x29D5EA0", Offset = "0x29D50A0", VA = "0x1829D5EA0")]
		set
		{
		}
	}

	[Token(Token = "0x170006B5")]
	[CreateProperty]
	public string viewDataKey
	{
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x29D7870", Offset = "0x29D6A70", VA = "0x1829D7870")]
		set
		{
		}
	}

	[Token(Token = "0x170006B6")]
	internal bool enableViewDataPersistence
	{
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x29D46B0", Offset = "0x29D38B0", VA = "0x1829D46B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006B7")]
	[CreateProperty]
	public object userData
	{
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x29D5850", Offset = "0x29D4A50", VA = "0x1829D5850")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x29D7720", Offset = "0x29D6920", VA = "0x1829D7720")]
		set
		{
		}
	}

	[Token(Token = "0x170006B8")]
	public override bool canGrabFocus
	{
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x29D4020", Offset = "0x29D3220", VA = "0x1829D4020", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006B9")]
	public override FocusController focusController
	{
		[Token(Token = "0x6001924")]
		[Address(RVA = "0x29D4710", Offset = "0x29D3910", VA = "0x1829D4710", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BA")]
	[CreateProperty]
	public bool disablePlayModeTint
	{
		[Token(Token = "0x6001925")]
		[Address(RVA = "0x1521C70", Offset = "0x1520E70", VA = "0x181521C70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001926")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		set
		{
		}
	}

	[Token(Token = "0x170006BB")]
	internal Color playModeTintColor
	{
		[Token(Token = "0x6001927")]
		[Address(RVA = "0x29D5240", Offset = "0x29D4440", VA = "0x1829D5240")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170006BC")]
	[CreateProperty]
	public UsageHints usageHints
	{
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x29D5820", Offset = "0x29D4A20", VA = "0x1829D5820")]
		get
		{
			return default(UsageHints);
		}
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x29D7500", Offset = "0x29D6700", VA = "0x1829D7500")]
		set
		{
		}
	}

	[Token(Token = "0x170006BD")]
	internal RenderHints renderHints
	{
		[Token(Token = "0x600192A")]
		[Address(RVA = "0x28A5870", Offset = "0x28A4A70", VA = "0x1828A5870")]
		get
		{
			return default(RenderHints);
		}
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x29D7130", Offset = "0x29D6330", VA = "0x1829D7130")]
		set
		{
		}
	}

	[Token(Token = "0x170006BE")]
	public ITransform transform
	{
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x1F893F0", Offset = "0x1F885F0", VA = "0x181F893F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006BF")]
	private Vector3 UnityEngine_002EUIElements_002EITransform_002Eposition
	{
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x29D0310", Offset = "0x29CF510", VA = "0x1829D0310", Slot = "125")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x29D0520", Offset = "0x29CF720", VA = "0x1829D0520", Slot = "126")]
		set
		{
		}
	}

	[Token(Token = "0x170006C0")]
	private Vector3 UnityEngine_002EUIElements_002EITransform_002Escale
	{
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x29D0400", Offset = "0x29CF600", VA = "0x1829D0400", Slot = "127")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170006C1")]
	internal bool isLayoutManual
	{
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x29D4B90", Offset = "0x29D3D90", VA = "0x1829D4B90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001932")]
		[Address(RVA = "0x29D6440", Offset = "0x29D5640", VA = "0x1829D6440")]
		private set
		{
		}
	}

	[Token(Token = "0x170006C2")]
	public float scaledPixelsPerPoint
	{
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x29D5430", Offset = "0x29D4630", VA = "0x1829D5430")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170006C3")]
	[Obsolete("scaledPixelsPerPoint_noChecks is deprecated. Use scaledPixelsPerPoint instead.")]
	internal float scaledPixelsPerPoint_noChecks
	{
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x29D54D0", Offset = "0x29D46D0", VA = "0x1829D54D0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170006C4")]
	[CreateProperty(ReadOnly = true)]
	public Rect layout
	{
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x29D4C70", Offset = "0x29D3E70", VA = "0x1829D4C70")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x29D65A0", Offset = "0x29D57A0", VA = "0x1829D65A0")]
		internal set
		{
		}
	}

	[Token(Token = "0x170006C5")]
	[CreateProperty(ReadOnly = true)]
	public Rect contentRect
	{
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x29D4270", Offset = "0x29D3470", VA = "0x1829D4270")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006C6")]
	protected Rect paddingRect
	{
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x29D5060", Offset = "0x29D4260", VA = "0x1829D5060")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006C7")]
	internal bool needs3DBounds
	{
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x29D4E70", Offset = "0x29D4070", VA = "0x1829D4E70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006C8")]
	internal bool isLocalBounds3DDirty
	{
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x29D4BA0", Offset = "0x29D3DA0", VA = "0x1829D4BA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x29D6470", Offset = "0x29D5670", VA = "0x1829D6470")]
		set
		{
		}
	}

	[Token(Token = "0x170006C9")]
	internal bool isBoundingBoxDirty
	{
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x29D4B60", Offset = "0x29D3D60", VA = "0x1829D4B60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x29D63B0", Offset = "0x29D55B0", VA = "0x1829D63B0")]
		set
		{
		}
	}

	[Token(Token = "0x170006CA")]
	internal bool isWorldBoundingBoxDirty
	{
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x29D64B0", Offset = "0x29D56B0", VA = "0x1829D64B0")]
		set
		{
		}
	}

	[Token(Token = "0x170006CB")]
	internal bool isWorldBoundingBoxOrDependenciesDirty
	{
		[Token(Token = "0x6001940")]
		[Address(RVA = "0x29D4C30", Offset = "0x29D3E30", VA = "0x1829D4C30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006CC")]
	internal Rect boundingBox
	{
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x29D3FD0", Offset = "0x29D31D0", VA = "0x1829D3FD0")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006CD")]
	internal Rect worldBoundingBox
	{
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x29D5A60", Offset = "0x29D4C60", VA = "0x1829D5A60")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006CE")]
	private Rect boundingBoxInParentSpace
	{
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x29D3F70", Offset = "0x29D3170", VA = "0x1829D3F70")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006CF")]
	internal Bounds localBounds3D
	{
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x29D4DD0", Offset = "0x29D3FD0", VA = "0x1829D4DD0")]
		get
		{
			return default(Bounds);
		}
	}

	[Token(Token = "0x170006D0")]
	[CreateProperty(ReadOnly = true)]
	public Rect worldBound
	{
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x29D5960", Offset = "0x29D4B60", VA = "0x1829D5960")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006D1")]
	[CreateProperty(ReadOnly = true)]
	public Rect localBound
	{
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x29D4D40", Offset = "0x29D3F40", VA = "0x1829D4D40")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006D2")]
	internal Rect rect
	{
		[Token(Token = "0x600194A")]
		[Address(RVA = "0x29D5330", Offset = "0x29D4530", VA = "0x1829D5330")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006D3")]
	internal bool isWorldTransformDirty
	{
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x1E39330", Offset = "0x1E38530", VA = "0x181E39330")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x2184920", Offset = "0x2183B20", VA = "0x182184920")]
		set
		{
		}
	}

	[Token(Token = "0x170006D4")]
	internal bool isWorldTransformInverseDirty
	{
		[Token(Token = "0x600194D")]
		[Address(RVA = "0x2184950", Offset = "0x2183B50", VA = "0x182184950")]
		set
		{
		}
	}

	[Token(Token = "0x170006D5")]
	internal bool isWorldTransformInverseOrDependenciesDirty
	{
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x29D4C50", Offset = "0x29D3E50", VA = "0x1829D4C50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006D6")]
	[CreateProperty(ReadOnly = true)]
	public Matrix4x4 worldTransform
	{
		[Token(Token = "0x600194F")]
		[Address(RVA = "0x29D5CB0", Offset = "0x29D4EB0", VA = "0x1829D5CB0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Token(Token = "0x170006D7")]
	internal unsafe ref Matrix4x4 worldTransformRef
	{
		[Token(Token = "0x6001950")]
		[Address(RVA = "0x29D5C80", Offset = "0x29D4E80", VA = "0x1829D5C80")]
		get
		{
			return ref *(Matrix4x4*)null;
		}
	}

	[Token(Token = "0x170006D8")]
	internal unsafe ref Matrix4x4 worldTransformInverse
	{
		[Token(Token = "0x6001951")]
		[Address(RVA = "0x29D5C00", Offset = "0x29D4E00", VA = "0x1829D5C00")]
		get
		{
			return ref *(Matrix4x4*)null;
		}
	}

	[Token(Token = "0x170006D9")]
	internal bool isWorldClipDirty
	{
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x29D4C40", Offset = "0x29D3E40", VA = "0x1829D4C40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x29D64E0", Offset = "0x29D56E0", VA = "0x1829D64E0")]
		set
		{
		}
	}

	[Token(Token = "0x170006DA")]
	internal Rect worldClip
	{
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x29D5BB0", Offset = "0x29D4DB0", VA = "0x1829D5BB0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006DB")]
	internal Rect worldClipMinusGroup
	{
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x29D5B60", Offset = "0x29D4D60", VA = "0x1829D5B60")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x170006DC")]
	internal bool worldClipIsInfinite
	{
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x29D5B20", Offset = "0x29D4D20", VA = "0x1829D5B20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006DD")]
	internal bool receivesHierarchyGeometryChangedEvents
	{
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x29D5320", Offset = "0x29D4520", VA = "0x1829D5320")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x29D7100", Offset = "0x29D6300", VA = "0x1829D7100")]
		set
		{
		}
	}

	[Token(Token = "0x170006DE")]
	internal bool boundingBoxDirtiedSinceLastLayoutPass
	{
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x29D3F60", Offset = "0x29D3160", VA = "0x1829D3F60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x29D5F20", Offset = "0x29D5120", VA = "0x1829D5F20")]
		set
		{
		}
	}

	[Token(Token = "0x170006DF")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal PseudoStates pseudoStates
	{
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x29D5310", Offset = "0x29D4510", VA = "0x1829D5310")]
		get
		{
			return default(PseudoStates);
		}
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x29D7080", Offset = "0x29D6280", VA = "0x1829D7080")]
		set
		{
		}
	}

	[Token(Token = "0x170006E0")]
	internal int containedPointerIds
	{
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x6D4610", Offset = "0x6D3810", VA = "0x1806D4610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x6D7630", Offset = "0x6D6830", VA = "0x1806D7630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170006E1")]
	[CreateProperty]
	public PickingMode pickingMode
	{
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x262DBE0", Offset = "0x262CDE0", VA = "0x18262DBE0")]
		get
		{
			return default(PickingMode);
		}
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x29D6FD0", Offset = "0x29D61D0", VA = "0x1829D6FD0")]
		set
		{
		}
	}

	[Token(Token = "0x170006E2")]
	[CreateProperty]
	public string name
	{
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x2844C00", Offset = "0x2843E00", VA = "0x182844C00")]
		get
		{
			return null;
		}
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x29D6F10", Offset = "0x29D6110", VA = "0x1829D6F10")]
		set
		{
		}
	}

	[Token(Token = "0x170006E3")]
	internal List<string> classList
	{
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x29D41A0", Offset = "0x29D33A0", VA = "0x1829D41A0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E4")]
	internal string fullTypeName
	{
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x29D47F0", Offset = "0x29D39F0", VA = "0x1829D47F0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E5")]
	internal string typeName
	{
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x29D57F0", Offset = "0x29D49F0", VA = "0x1829D57F0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E6")]
	internal unsafe ref LayoutNode layoutNode
	{
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x29D4C60", Offset = "0x29D3E60", VA = "0x1829D4C60")]
		get
		{
			return ref *(LayoutNode*)null;
		}
	}

	[Token(Token = "0x170006E7")]
	internal unsafe ref ComputedStyle computedStyle
	{
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x29D4260", Offset = "0x29D3460", VA = "0x1829D4260")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return ref *(ComputedStyle*)null;
		}
	}

	[Token(Token = "0x170006E8")]
	internal bool hasInlineStyle
	{
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x29D4AF0", Offset = "0x29D3CF0", VA = "0x1829D4AF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006E9")]
	internal bool styleInitialized
	{
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x29D5530", Offset = "0x29D4730", VA = "0x1829D5530")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x29D72A0", Offset = "0x29D64A0", VA = "0x1829D72A0")]
		set
		{
		}
	}

	[Token(Token = "0x170006EA")]
	private bool isParentEnabledInHierarchy
	{
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x29D4BB0", Offset = "0x29D3DB0", VA = "0x1829D4BB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006EB")]
	[CreateProperty(ReadOnly = true)]
	public bool enabledInHierarchy
	{
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x29D46C0", Offset = "0x29D38C0", VA = "0x1829D46C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006EC")]
	[CreateProperty]
	public bool enabledSelf
	{
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x26DDD20", Offset = "0x26DCF20", VA = "0x1826DDD20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001986")]
		[Address(RVA = "0x29D6300", Offset = "0x29D5500", VA = "0x1829D6300")]
		set
		{
		}
	}

	[Token(Token = "0x170006ED")]
	[CreateProperty]
	public LanguageDirection languageDirection
	{
		[Token(Token = "0x6001989")]
		[Address(RVA = "0x262DD10", Offset = "0x262CF10", VA = "0x18262DD10")]
		get
		{
			return default(LanguageDirection);
		}
		[Token(Token = "0x600198A")]
		[Address(RVA = "0x29D6510", Offset = "0x29D5710", VA = "0x1829D6510")]
		set
		{
		}
	}

	[Token(Token = "0x170006EE")]
	internal LanguageDirection localLanguageDirection
	{
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x262DE60", Offset = "0x262D060", VA = "0x18262DE60")]
		get
		{
			return default(LanguageDirection);
		}
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x29D6E00", Offset = "0x29D6000", VA = "0x1829D6E00")]
		set
		{
		}
	}

	[Token(Token = "0x170006EF")]
	[CreateProperty]
	public bool visible
	{
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x29D58F0", Offset = "0x29D4AF0", VA = "0x1829D58F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x29D7940", Offset = "0x29D6B40", VA = "0x1829D7940")]
		set
		{
		}
	}

	[Token(Token = "0x170006F0")]
	public Action<MeshGenerationContext> generateVisualContent
	{
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x29D4820", Offset = "0x29D3A20", VA = "0x1829D4820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x29D6390", Offset = "0x29D5590", VA = "0x1829D6390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170006F1")]
	internal bool requireMeasureFunction
	{
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x29D5390", Offset = "0x29D4590", VA = "0x1829D5390")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600199B")]
		[Address(RVA = "0x29D71A0", Offset = "0x29D63A0", VA = "0x1829D71A0")]
		set
		{
		}
	}

	[Token(Token = "0x170006F2")]
	internal RenderTargetMode subRenderTargetMode
	{
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x29D55F0", Offset = "0x29D47F0", VA = "0x1829D55F0")]
		get
		{
			return default(RenderTargetMode);
		}
	}

	[Token(Token = "0x170006F3")]
	internal Material defaultMaterial
	{
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x29D4670", Offset = "0x29D3870", VA = "0x1829D4670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F4")]
	[CreateProperty]
	public object dataSource
	{
		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x29D4660", Offset = "0x29D3860", VA = "0x1829D4660")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x29D6170", Offset = "0x29D5370", VA = "0x1829D6170")]
		set
		{
		}
	}

	[Token(Token = "0x170006F5")]
	[CreateProperty]
	public PropertyPath dataSourcePath
	{
		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x29D45F0", Offset = "0x29D37F0", VA = "0x1829D45F0")]
		get
		{
			return default(PropertyPath);
		}
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x29D5F50", Offset = "0x29D5150", VA = "0x1829D5F50")]
		set
		{
		}
	}

	[Token(Token = "0x170006F6")]
	internal VisualElement nextParentWithEventInterests
	{
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x29D4E80", Offset = "0x29D4080", VA = "0x1829D4E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F7")]
	internal int eventInterestParentCategories
	{
		[Token(Token = "0x60019CC")]
		[Address(RVA = "0x29D46D0", Offset = "0x29D38D0", VA = "0x1829D46D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006F8")]
	internal bool isEventInterestParentCategoriesDirty
	{
		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x29D4B80", Offset = "0x29D3D80", VA = "0x1829D4B80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x29D6410", Offset = "0x29D5610", VA = "0x1829D6410")]
		set
		{
		}
	}

	[Token(Token = "0x170006F9")]
	public IExperimentalFeatures experimental
	{
		[Token(Token = "0x60019DB")]
		[Address(RVA = "0x1F893F0", Offset = "0x1F885F0", VA = "0x181F893F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FA")]
	private ITransitionAnimations UnityEngine_002EUIElements_002EIExperimentalFeatures_002Eanimation
	{
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x1F893F0", Offset = "0x1F885F0", VA = "0x181F893F0", Slot = "129")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FB")]
	public Hierarchy hierarchy
	{
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x29D4B50", Offset = "0x29D3D50", VA = "0x1829D4B50")]
		[CompilerGenerated]
		get
		{
			return default(Hierarchy);
		}
	}

	[Token(Token = "0x170006FC")]
	internal bool isRootVisualContainer
	{
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x29D4C20", Offset = "0x29D3E20", VA = "0x1829D4C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019DF")]
		[Address(RVA = "0x29D64A0", Offset = "0x29D56A0", VA = "0x1829D64A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170006FD")]
	internal bool disableClipping
	{
		[Token(Token = "0x60019E0")]
		[Address(RVA = "0x29D4680", Offset = "0x29D3880", VA = "0x1829D4680")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x29D6250", Offset = "0x29D5450", VA = "0x1829D6250")]
		set
		{
		}
	}

	[Token(Token = "0x170006FE")]
	internal bool disableRendering
	{
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x29D4690", Offset = "0x29D3890", VA = "0x1829D4690")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60019E4")]
		[Address(RVA = "0x29D6280", Offset = "0x29D5480", VA = "0x1829D6280")]
		set
		{
		}
	}

	[Token(Token = "0x170006FF")]
	public VisualElement parent
	{
		[Token(Token = "0x60019E9")]
		[Address(RVA = "0x29D5230", Offset = "0x29D4430", VA = "0x1829D5230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000700")]
	internal BaseVisualElementPanel elementPanel
	{
		[Token(Token = "0x60019EA")]
		[Address(RVA = "0x29D46A0", Offset = "0x29D38A0", VA = "0x1829D46A0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60019EB")]
		[Address(RVA = "0x29D62E0", Offset = "0x29D54E0", VA = "0x1829D62E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000701")]
	[CreateProperty(ReadOnly = true)]
	public IPanel panel
	{
		[Token(Token = "0x60019EC")]
		[Address(RVA = "0x29D5220", Offset = "0x29D4420", VA = "0x1829D5220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000702")]
	public virtual VisualElement contentContainer
	{
		[Token(Token = "0x60019ED")]
		[Address(RVA = "0x1F893F0", Offset = "0x1F885F0", VA = "0x181F893F0", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000703")]
	[CreateProperty(ReadOnly = true)]
	public VisualTreeAsset visualTreeAssetSource
	{
		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x29D5950", Offset = "0x29D4B50", VA = "0x1829D5950")]
		get
		{
			return null;
		}
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x29D7AC0", Offset = "0x29D6CC0", VA = "0x1829D7AC0")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000704")]
	public VisualElement this[int key]
	{
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x29D3EC0", Offset = "0x29D30C0", VA = "0x1829D3EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000705")]
	[CreateProperty(ReadOnly = true)]
	public int childCount
	{
		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x29D4130", Offset = "0x29D3330", VA = "0x1829D4130")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000706")]
	private Vector3 positionWithLayout
	{
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x29D5280", Offset = "0x29D4480", VA = "0x1829D5280")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000707")]
	internal bool hasDefaultRotationAndScale
	{
		[MethodImpl(256)]
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x29B45F0", Offset = "0x29B37F0", VA = "0x1829B45F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000708")]
	internal bool has3DTransform
	{
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x29D4910", Offset = "0x29D3B10", VA = "0x1829D4910")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000709")]
	private bool has3DTranslation
	{
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x29D4A60", Offset = "0x29D3C60", VA = "0x1829D4A60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700070A")]
	private bool has3DRotation
	{
		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x29D4830", Offset = "0x29D3A30", VA = "0x1829D4830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700070B")]
	public IVisualElementScheduler schedule
	{
		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x1F893F0", Offset = "0x1F885F0", VA = "0x181F893F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070C")]
	[CreateProperty]
	public IStyle style
	{
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x29D5570", Offset = "0x29D4770", VA = "0x1829D5570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070D")]
	[CreateProperty]
	public IResolvedStyle resolvedStyle
	{
		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x29D53A0", Offset = "0x29D45A0", VA = "0x1829D53A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070E")]
	public ICustomStyle customStyle
	{
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x29D4560", Offset = "0x29D3760", VA = "0x1829D4560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070F")]
	[CreateProperty(ReadOnly = true)]
	public VisualElementStyleSheetSet styleSheets
	{
		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x29D5540", Offset = "0x29D4740", VA = "0x1829D5540")]
		get
		{
			return default(VisualElementStyleSheetSet);
		}
	}

	[Token(Token = "0x17000710")]
	[CreateProperty]
	public string tooltip
	{
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x29D5600", Offset = "0x29D4800", VA = "0x1829D5600")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x29D72D0", Offset = "0x29D64D0", VA = "0x1829D72D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000711")]
	private TypeData typeData
	{
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x29D5690", Offset = "0x29D4890", VA = "0x1829D5690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400002D")]
	internal event Action<VisualElement, int> elementAdded
	{
		[Token(Token = "0x60019E5")]
		[Address(RVA = "0x29D3D40", Offset = "0x29D2F40", VA = "0x1829D3D40")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60019E6")]
		[Address(RVA = "0x29D5D20", Offset = "0x29D4F20", VA = "0x1829D5D20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400002E")]
	internal event Action<VisualElement> elementRemoved
	{
		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x29D3E00", Offset = "0x29D3000", VA = "0x1829D3E00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60019E8")]
		[Address(RVA = "0x29D5DE0", Offset = "0x29D4FE0", VA = "0x1829D5DE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x29C6DF0", Offset = "0x29C5FF0", VA = "0x1829C6DF0")]
	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
	{
		return null;
	}

	[Token(Token = "0x6001901")]
	[Address(RVA = "0x29CF4B0", Offset = "0x29CE6B0", VA = "0x1829CF4B0", Slot = "101")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001902")]
	[Address(RVA = "0x29CF8F0", Offset = "0x29CEAF0", VA = "0x1829CF8F0", Slot = "102")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001903")]
	[Address(RVA = "0x29CEEE0", Offset = "0x29CE0E0", VA = "0x1829CEEE0", Slot = "103")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001904")]
	[Address(RVA = "0x29CFAF0", Offset = "0x29CECF0", VA = "0x1829CFAF0", Slot = "104")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001905")]
	[Address(RVA = "0x29CECE0", Offset = "0x29CDEE0", VA = "0x1829CECE0", Slot = "105")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001906")]
	[Address(RVA = "0x29D0100", Offset = "0x29CF300", VA = "0x1829D0100", Slot = "106")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001907")]
	[Address(RVA = "0x29CFDF0", Offset = "0x29CEFF0", VA = "0x1829CFDF0", Slot = "107")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001908")]
	[Address(RVA = "0x29CEDA0", Offset = "0x29CDFA0", VA = "0x1829CEDA0", Slot = "108")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001909")]
	[Address(RVA = "0x29CFF60", Offset = "0x29CF160", VA = "0x1829CFF60", Slot = "109")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600190A")]
	[Address(RVA = "0x29CF600", Offset = "0x29CE800", VA = "0x1829CF600", Slot = "110")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600190B")]
	[Address(RVA = "0x29CFC60", Offset = "0x29CEE60", VA = "0x1829CFC60", Slot = "111")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600190C")]
	[Address(RVA = "0x29CF320", Offset = "0x29CE520", VA = "0x1829CF320", Slot = "112")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600190D")]
	[Address(RVA = "0x29CF770", Offset = "0x29CE970", VA = "0x1829CF770", Slot = "113")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600190E")]
	[Address(RVA = "0x29CF1A0", Offset = "0x29CE3A0", VA = "0x1829CF1A0", Slot = "114")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600190F")]
	[Address(RVA = "0x29CF9B0", Offset = "0x29CEBB0", VA = "0x1829CF9B0", Slot = "115")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001910")]
	[Address(RVA = "0x29CF020", Offset = "0x29CE220", VA = "0x1829CF020", Slot = "116")]
	private bool UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EStart(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001911")]
	[Address(RVA = "0x29CEAF0", Offset = "0x29CDCF0", VA = "0x1829CEAF0", Slot = "119")]
	private void UnityEngine_002EUIElements_002EIStylePropertyAnimations_002ECancelAnimation(StylePropertyId id)
	{
	}

	[Token(Token = "0x6001912")]
	[Address(RVA = "0x29CE990", Offset = "0x29CDB90", VA = "0x1829CE990", Slot = "120")]
	private void UnityEngine_002EUIElements_002EIStylePropertyAnimations_002ECancelAllAnimations()
	{
	}

	[Token(Token = "0x6001913")]
	[Address(RVA = "0x29D0290", Offset = "0x29CF490", VA = "0x1829D0290", Slot = "117")]
	private void UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EUpdateAnimation(StylePropertyId id)
	{
	}

	[Token(Token = "0x6001914")]
	[Address(RVA = "0x29CEB70", Offset = "0x29CDD70", VA = "0x1829CEB70", Slot = "118")]
	private void UnityEngine_002EUIElements_002EIStylePropertyAnimations_002EGetAllAnimations(List<StylePropertyId> outPropertyIds)
	{
	}

	[Token(Token = "0x6001915")]
	[Address(RVA = "0x29CBBA0", Offset = "0x29CADA0", VA = "0x1829CBBA0")]
	internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6001916")]
	[Address(RVA = "0x29CBDF0", Offset = "0x29CAFF0", VA = "0x1829CBDF0")]
	internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to)
	{
		return default(bool);
	}

	[Token(Token = "0x6001917")]
	[Address(RVA = "0x29CBEA0", Offset = "0x29CB0A0", VA = "0x1829CBEA0")]
	internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to)
	{
		return default(bool);
	}

	[Token(Token = "0x6001918")]
	[Address(RVA = "0x29CBAB0", Offset = "0x29CACB0", VA = "0x1829CBAB0")]
	internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to)
	{
		return default(bool);
	}

	[Token(Token = "0x6001919")]
	[Address(RVA = "0x29C64C0", Offset = "0x29C56C0", VA = "0x1829C64C0")]
	private float? GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0)
	{
		return null;
	}

	[Token(Token = "0x600192C")]
	[Address(RVA = "0x29C78A0", Offset = "0x29C6AA0", VA = "0x1829C78A0")]
	internal void MarkRenderHintsClean()
	{
	}

	[Token(Token = "0x6001937")]
	[Address(RVA = "0x29C4B50", Offset = "0x29C3D50", VA = "0x1829C4B50")]
	internal void ClearManualLayout()
	{
	}

	[Token(Token = "0x6001944")]
	[Address(RVA = "0x29D0940", Offset = "0x29CFB40", VA = "0x1829D0940")]
	internal void UpdateBoundingBox()
	{
	}

	[Token(Token = "0x6001945")]
	[Address(RVA = "0x29D18C0", Offset = "0x29D0AC0", VA = "0x1829D18C0")]
	internal void UpdateWorldBoundingBox()
	{
	}

	[Token(Token = "0x6001947")]
	[Address(RVA = "0x29D1550", Offset = "0x29D0750", VA = "0x1829D1550")]
	private void UpdateLocalBoundsAndPickingBounds3D()
	{
	}

	[Token(Token = "0x6001952")]
	[Address(RVA = "0x29D1E00", Offset = "0x29D1000", VA = "0x1829D1E00")]
	internal void UpdateWorldTransform()
	{
	}

	[Token(Token = "0x6001953")]
	[Address(RVA = "0x29D1D90", Offset = "0x29D0F90", VA = "0x1829D1D90")]
	internal void UpdateWorldTransformInverse()
	{
	}

	[Token(Token = "0x6001959")]
	[Address(RVA = "0x29C5AF0", Offset = "0x29C4CF0", VA = "0x1829C5AF0")]
	internal void EnsureWorldTransformAndClipUpToDate()
	{
	}

	[Token(Token = "0x600195A")]
	[Address(RVA = "0x29D1950", Offset = "0x29D0B50", VA = "0x1829D1950")]
	private void UpdateWorldClip()
	{
	}

	[Token(Token = "0x600195B")]
	[Address(RVA = "0x29C53F0", Offset = "0x29C45F0", VA = "0x1829C53F0")]
	private Rect CombineClipRects(Rect rect, Rect parentRect)
	{
		return default(Rect);
	}

	[Token(Token = "0x600195C")]
	[Address(RVA = "0x29CAFF0", Offset = "0x29CA1F0", VA = "0x1829CAFF0")]
	private Rect SubstractBorderPadding(Rect worldRect)
	{
		return default(Rect);
	}

	[Token(Token = "0x600195D")]
	[Address(RVA = "0x29C5480", Offset = "0x29C4680", VA = "0x1829C5480")]
	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat)
	{
		return default(Rect);
	}

	[Token(Token = "0x6001966")]
	[Address(RVA = "0x29D1440", Offset = "0x29D0640", VA = "0x1829D1440")]
	internal void UpdateHoverPseudoState()
	{
	}

	[Token(Token = "0x6001967")]
	[Address(RVA = "0x29C7770", Offset = "0x29C6970", VA = "0x1829C7770")]
	private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement)
	{
		return default(bool);
	}

	[Token(Token = "0x6001968")]
	[Address(RVA = "0x29D13C0", Offset = "0x29D05C0", VA = "0x1829D13C0")]
	internal void UpdateHoverPseudoStateAfterCaptureChange(int pointerId)
	{
	}

	[Token(Token = "0x6001975")]
	[Address(RVA = "0x29C4800", Offset = "0x29C3A00", VA = "0x1829C4800")]
	private void ChangeIMGUIContainerCount(int delta)
	{
	}

	[Token(Token = "0x6001976")]
	[Address(RVA = "0x29D37A0", Offset = "0x29D29A0", VA = "0x1829D37A0")]
	public VisualElement()
	{
	}

	[Token(Token = "0x6001977")]
	[Address(RVA = "0x29C5B80", Offset = "0x29C4D80", VA = "0x1829C5B80", Slot = "1")]
	~VisualElement()
	{
	}

	[Token(Token = "0x6001978")]
	[Address(RVA = "0x29C6E20", Offset = "0x29C6020", VA = "0x1829C6E20", Slot = "132")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal virtual Rect GetTooltipRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6001979")]
	[Address(RVA = "0x29CAD60", Offset = "0x29C9F60", VA = "0x1829CAD60")]
	internal void SetTooltip(TooltipEvent e)
	{
	}

	[Token(Token = "0x600197A")]
	[Address(RVA = "0x29C5F30", Offset = "0x29C5130", VA = "0x1829C5F30", Slot = "19")]
	public sealed override void Focus()
	{
	}

	[Token(Token = "0x600197B")]
	[Address(RVA = "0x29CA340", Offset = "0x29C9540", VA = "0x1829CA340")]
	internal void SetPanel(BaseVisualElementPanel p)
	{
	}

	[Token(Token = "0x600197C")]
	[Address(RVA = "0x29D2120", Offset = "0x29D1320", VA = "0x1829D2120")]
	private void WillChangePanel(BaseVisualElementPanel destinationPanel)
	{
	}

	[Token(Token = "0x600197D")]
	[Address(RVA = "0x29C6E90", Offset = "0x29C6090", VA = "0x1829C6E90")]
	private void HasChangedPanel(BaseVisualElementPanel prevPanel)
	{
	}

	[Token(Token = "0x600197E")]
	[Address(RVA = "0x29C9B00", Offset = "0x29C8D00", VA = "0x1829C9B00", Slot = "5")]
	public sealed override void SendEvent(EventBase e)
	{
	}

	[Token(Token = "0x600197F")]
	[Address(RVA = "0x29C9B20", Offset = "0x29C8D20", VA = "0x1829C9B20", Slot = "6")]
	internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode)
	{
	}

	[Token(Token = "0x6001980")]
	[Address(RVA = "0x29C7480", Offset = "0x29C6680", VA = "0x1829C7480")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void IncrementVersion(VersionChangeType changeType)
	{
	}

	[Token(Token = "0x6001981")]
	[Address(RVA = "0x29C7740", Offset = "0x29C6940", VA = "0x1829C7740")]
	internal void InvokeHierarchyChanged(HierarchyChangeType changeType, [Optional] IReadOnlyList<VisualElement> additionalContext)
	{
	}

	[Token(Token = "0x6001982")]
	[Address(RVA = "0x29C9EE0", Offset = "0x29C90E0", VA = "0x1829C9EE0")]
	private bool SetEnabledFromHierarchyPrivate(bool state)
	{
		return default(bool);
	}

	[Token(Token = "0x6001987")]
	[Address(RVA = "0x29CA280", Offset = "0x29C9480", VA = "0x1829CA280")]
	public void SetEnabled(bool value)
	{
	}

	[Token(Token = "0x6001988")]
	[Address(RVA = "0x29C8480", Offset = "0x29C7680", VA = "0x1829C8480")]
	private void PropagateEnabledToChildren(bool value)
	{
	}

	[Token(Token = "0x600198F")]
	[Address(RVA = "0x29C7870", Offset = "0x29C6A70", VA = "0x1829C7870")]
	public void MarkDirtyRepaint()
	{
	}

	[Token(Token = "0x6001992")]
	[Address(RVA = "0x29C7610", Offset = "0x29C6810", VA = "0x1829C7610")]
	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x6001993")]
	[Address(RVA = "0x29C6310", Offset = "0x29C5510", VA = "0x1829C6310")]
	internal void GetFullHierarchicalViewDataKey(StringBuilder key)
	{
	}

	[Token(Token = "0x6001994")]
	[Address(RVA = "0x29C6230", Offset = "0x29C5430", VA = "0x1829C6230")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal string GetFullHierarchicalViewDataKey()
	{
		return null;
	}

	[Token(Token = "0x6001995")]
	internal T GetOrCreateViewData<T>(object existing, string key) where T : class, new()
	{
		return null;
	}

	[Token(Token = "0x6001996")]
	[Address(RVA = "0x29C7E60", Offset = "0x29C7060", VA = "0x1829C7E60")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void OverwriteFromViewData(object obj, string key)
	{
	}

	[Token(Token = "0x6001997")]
	[Address(RVA = "0x29C9A70", Offset = "0x29C8C70", VA = "0x1829C9A70")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void SaveViewData()
	{
	}

	[Token(Token = "0x6001998")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "133")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal virtual void OnViewDataReady()
	{
	}

	[Token(Token = "0x6001999")]
	[Address(RVA = "0x29C5690", Offset = "0x29C4890", VA = "0x1829C5690", Slot = "134")]
	public virtual bool ContainsPoint(Vector2 localPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x600199C")]
	[Address(RVA = "0x29C31D0", Offset = "0x29C23D0", VA = "0x1829C31D0")]
	private void AssignMeasureFunction()
	{
	}

	[Token(Token = "0x600199D")]
	[Address(RVA = "0x29C91F0", Offset = "0x29C83F0", VA = "0x1829C91F0")]
	private void RemoveMeasureFunction()
	{
	}

	[Token(Token = "0x600199E")]
	[Address(RVA = "0x29C58D0", Offset = "0x29C4AD0", VA = "0x1829C58D0", Slot = "135")]
	protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600199F")]
	[Address(RVA = "0x29C78C0", Offset = "0x29C6AC0", VA = "0x1829C78C0")]
	internal static void Measure(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result)
	{
	}

	[Token(Token = "0x60019A0")]
	[Address(RVA = "0x29C5B20", Offset = "0x29C4D20", VA = "0x1829C5B20")]
	private void FinalizeLayout()
	{
	}

	[Token(Token = "0x60019A1")]
	[Address(RVA = "0x29CA290", Offset = "0x29C9490", VA = "0x1829CA290")]
	internal void SetInlineRule(StyleSheet sheet, StyleRule rule)
	{
	}

	[Token(Token = "0x60019A2")]
	[Address(RVA = "0x29C9C80", Offset = "0x29C8E80", VA = "0x1829C9C80")]
	internal void SetComputedStyle(ref ComputedStyle newStyle)
	{
	}

	[Token(Token = "0x60019A3")]
	[Address(RVA = "0x29CB370", Offset = "0x29CA570", VA = "0x1829CB370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x2874D00", Offset = "0x2873F00", VA = "0x182874D00")]
	internal List<string> GetClassesForIteration()
	{
		return null;
	}

	[Token(Token = "0x60019A5")]
	[Address(RVA = "0x29C2EE0", Offset = "0x29C20E0", VA = "0x1829C2EE0")]
	public void AddToClassList(string className)
	{
	}

	[Token(Token = "0x60019A6")]
	[Address(RVA = "0x29C9050", Offset = "0x29C8250", VA = "0x1829C9050")]
	public void RemoveFromClassList(string className)
	{
	}

	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x29C5AC0", Offset = "0x29C4CC0", VA = "0x1829C5AC0")]
	public void EnableInClassList(string className, bool enable)
	{
	}

	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x29C4A80", Offset = "0x29C3C80", VA = "0x1829C4A80")]
	public bool ClassListContains(string cls)
	{
		return default(bool);
	}

	[Token(Token = "0x60019A9")]
	[Address(RVA = "0x29C6C60", Offset = "0x29C5E60", VA = "0x1829C6C60")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal object GetProperty(PropertyName key)
	{
		return null;
	}

	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x29CACF0", Offset = "0x29C9EF0", VA = "0x1829CACF0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void SetProperty(PropertyName key, object value)
	{
	}

	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x29C7380", Offset = "0x29C6580", VA = "0x1829C7380")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool HasProperty(PropertyName key)
	{
		return default(bool);
	}

	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x29C52F0", Offset = "0x29C44F0", VA = "0x1829C52F0")]
	internal bool ClearProperty(PropertyName key)
	{
		return default(bool);
	}

	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x29C4850", Offset = "0x29C3A50", VA = "0x1829C4850")]
	private static void CheckUserKeyArgument(PropertyName key)
	{
	}

	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x29CAC30", Offset = "0x29C9E30", VA = "0x1829CAC30")]
	private void SetPropertyInternal(PropertyName key, object value)
	{
	}

	[Token(Token = "0x60019AF")]
	[Address(RVA = "0x29D0CC0", Offset = "0x29CFEC0", VA = "0x1829D0CC0")]
	internal void UpdateCursorStyle(long eventType)
	{
	}

	[Token(Token = "0x60019B2")]
	[Address(RVA = "0x29C6090", Offset = "0x29C5290", VA = "0x1829C6090")]
	private VisualElementAnimationSystem GetAnimationSystem()
	{
		return null;
	}

	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x29C8EB0", Offset = "0x29C80B0", VA = "0x1829C8EB0")]
	internal void RegisterAnimation(IValueAnimationUpdate anim)
	{
	}

	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x29D0830", Offset = "0x29CFA30", VA = "0x1829D0830")]
	internal void UnregisterAnimation(IValueAnimationUpdate anim)
	{
	}

	[Token(Token = "0x60019B5")]
	[Address(RVA = "0x29D08B0", Offset = "0x29CFAB0", VA = "0x1829D08B0")]
	private void UnregisterRunningAnimations()
	{
	}

	[Token(Token = "0x60019B6")]
	[Address(RVA = "0x29C8FE0", Offset = "0x29C81E0", VA = "0x1829C8FE0")]
	private void RegisterRunningAnimations()
	{
	}

	[Token(Token = "0x60019B7")]
	private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged)
	{
		return null;
	}

	[Token(Token = "0x60019B8")]
	[Address(RVA = "0x29C3260", Offset = "0x29C2460", VA = "0x1829C3260")]
	private static void AssignStyleValues(VisualElement ve, StyleValues src)
	{
	}

	[Token(Token = "0x60019B9")]
	[Address(RVA = "0x29C8540", Offset = "0x29C7740", VA = "0x1829C8540")]
	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead)
	{
		return default(StyleValues);
	}

	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x29CC030", Offset = "0x29CB230", VA = "0x1829CC030", Slot = "128")]
	private ValueAnimation<StyleValues> UnityEngine_002EUIElements_002EExperimental_002EITransitionAnimations_002EStart(StyleValues to, int durationMs)
	{
		return null;
	}

	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x29CAE90", Offset = "0x29CA090", VA = "0x1829CAE90")]
	private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs)
	{
		return null;
	}

	[Token(Token = "0x60019C0")]
	[Address(RVA = "0x29CBF50", Offset = "0x29CB150", VA = "0x1829CBF50")]
	public bool TryGetBinding(BindingId bindingId, out Binding binding)
	{
		return default(bool);
	}

	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x29C8330", Offset = "0x29C7530", VA = "0x1829C8330")]
	private void ProcessBindingRequests()
	{
	}

	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x29C5770", Offset = "0x29C4970", VA = "0x1829C5770")]
	private void CreateBindingRequests()
	{
	}

	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x29CB530", Offset = "0x29CA730", VA = "0x1829CB530")]
	private void TrackSource(object previous, object current)
	{
	}

	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x29C5810", Offset = "0x29C4A10", VA = "0x1829C5810")]
	private void DetachDataSource()
	{
	}

	[Token(Token = "0x60019C5")]
	[Address(RVA = "0x29C3F30", Offset = "0x29C3130", VA = "0x1829C3F30")]
	private void AttachDataSource()
	{
	}

	[Token(Token = "0x60019C6")]
	[Address(RVA = "0x29C5840", Offset = "0x29C4A40", VA = "0x1829C5840")]
	private void DirtyNextParentWithEventInterests()
	{
	}

	[Token(Token = "0x60019C7")]
	[Address(RVA = "0x29C9BB0", Offset = "0x29C8DB0", VA = "0x1829C9BB0")]
	internal void SetAsNextParentWithEventInterests()
	{
	}

	[Token(Token = "0x60019C8")]
	[Address(RVA = "0x29C6140", Offset = "0x29C5340", VA = "0x1829C6140")]
	internal bool GetCachedNextParentWithEventInterests(out VisualElement nextParent)
	{
		return default(bool);
	}

	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x29C83F0", Offset = "0x29C75F0", VA = "0x1829C83F0")]
	private void PropagateCachedNextParentWithEventInterests(VisualElement nextParent, VisualElement stopParent)
	{
	}

	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x29C2C60", Offset = "0x29C1E60", VA = "0x1829C2C60")]
	internal void AddEventCallbackCategories(int eventCategories, TrickleDown trickleDown)
	{
	}

	[Token(Token = "0x60019CF")]
	[Address(RVA = "0x29D1260", Offset = "0x29D0460", VA = "0x1829D1260")]
	private void UpdateEventInterestSelfCategories()
	{
	}

	[Token(Token = "0x60019D0")]
	[Address(RVA = "0x29D0FF0", Offset = "0x29D01F0", VA = "0x1829D0FF0")]
	private void UpdateEventInterestParentCategories()
	{
	}

	[Token(Token = "0x60019D1")]
	[Address(RVA = "0x29C7320", Offset = "0x29C6520", VA = "0x1829C7320")]
	internal bool HasParentEventInterests(EventCategory eventCategory)
	{
		return default(bool);
	}

	[Token(Token = "0x60019D2")]
	[Address(RVA = "0x29C72C0", Offset = "0x29C64C0", VA = "0x1829C72C0")]
	internal bool HasParentEventInterests(int eventCategories)
	{
		return default(bool);
	}

	[Token(Token = "0x60019D3")]
	[Address(RVA = "0x29C7410", Offset = "0x29C6610", VA = "0x1829C7410")]
	internal bool HasSelfEventInterests(EventCategory eventCategory)
	{
		return default(bool);
	}

	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x29C7430", Offset = "0x29C6630", VA = "0x1829C7430")]
	internal bool HasSelfEventInterests(int eventCategories)
	{
		return default(bool);
	}

	[Token(Token = "0x60019D5")]
	[Address(RVA = "0x29C7450", Offset = "0x29C6650", VA = "0x1829C7450")]
	internal bool HasTrickleDownEventInterests(int eventCategories)
	{
		return default(bool);
	}

	[Token(Token = "0x60019D6")]
	[Address(RVA = "0x29C6E60", Offset = "0x29C6060", VA = "0x1829C6E60")]
	internal bool HasBubbleUpEventInterests(int eventCategories)
	{
		return default(bool);
	}

	[Token(Token = "0x60019D7")]
	[Address(RVA = "0x29C7440", Offset = "0x29C6640", VA = "0x1829C7440")]
	internal bool HasTrickleDownEventCallbacks(int eventCategories)
	{
		return default(bool);
	}

	[Token(Token = "0x60019D8")]
	[Address(RVA = "0x29C6E50", Offset = "0x29C6050", VA = "0x1829C6E50")]
	internal bool HasBubbleUpEventCallbacks(int eventCategories)
	{
		return default(bool);
	}

	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x29C7470", Offset = "0x29C6670", VA = "0x1829C7470")]
	internal bool HasTrickleDownHandleEvent(int eventCategories)
	{
		return default(bool);
	}

	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x29C6E80", Offset = "0x29C6080", VA = "0x1829C6E80")]
	internal bool HasBubbleUpHandleEvent(int eventCategories)
	{
		return default(bool);
	}

	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x29CAE50", Offset = "0x29CA050", VA = "0x1829CAE50")]
	internal bool ShouldClip()
	{
		return default(bool);
	}

	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x29C3100", Offset = "0x29C2300", VA = "0x1829C3100")]
	public void Add(VisualElement child)
	{
	}

	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x29C7550", Offset = "0x29C6750", VA = "0x1829C7550")]
	public void Insert(int index, VisualElement element)
	{
	}

	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x29C9220", Offset = "0x29C8420", VA = "0x1829C9220")]
	public void Remove(VisualElement element)
	{
	}

	[Token(Token = "0x60019F3")]
	[Address(RVA = "0x29C5380", Offset = "0x29C4580", VA = "0x1829C5380")]
	public void Clear()
	{
	}

	[Token(Token = "0x60019F4")]
	[Address(RVA = "0x29C5AB0", Offset = "0x29C4CB0", VA = "0x1829C5AB0")]
	public VisualElement ElementAt(int index)
	{
		return null;
	}

	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x29C74B0", Offset = "0x29C66B0", VA = "0x1829C74B0")]
	public int IndexOf(VisualElement element)
	{
		return default(int);
	}

	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x29C58F0", Offset = "0x29C4AF0", VA = "0x1829C58F0")]
	internal VisualElement ElementAtTreePath(List<int> childIndexes)
	{
		return null;
	}

	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x29C5E10", Offset = "0x29C5010", VA = "0x1829C5E10")]
	internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes)
	{
		return default(bool);
	}

	[Token(Token = "0x60019FA")]
	[Address(RVA = "0x29C49C0", Offset = "0x29C3BC0", VA = "0x1829C49C0")]
	public IEnumerable<VisualElement> Children()
	{
		return null;
	}

	[Token(Token = "0x60019FB")]
	[Address(RVA = "0x29C3F50", Offset = "0x29C3150", VA = "0x1829C3F50")]
	public void BringToFront()
	{
	}

	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x29C9B40", Offset = "0x29C8D40", VA = "0x1829C9B40")]
	public void SendToBack()
	{
	}

	[Token(Token = "0x60019FD")]
	[Address(RVA = "0x29C81D0", Offset = "0x29C73D0", VA = "0x1829C81D0")]
	public void PlaceBehind(VisualElement sibling)
	{
	}

	[Token(Token = "0x60019FE")]
	[Address(RVA = "0x29C9180", Offset = "0x29C8380", VA = "0x1829C9180")]
	public void RemoveFromHierarchy()
	{
	}

	[Token(Token = "0x60019FF")]
	public T GetFirstOfType<T>() where T : class
	{
		return null;
	}

	[Token(Token = "0x6001A00")]
	public T GetFirstAncestorOfType<T>() where T : class
	{
		return null;
	}

	[Token(Token = "0x6001A01")]
	[Address(RVA = "0x29C61A0", Offset = "0x29C53A0", VA = "0x1829C61A0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal VisualElement GetFirstAncestorWhere(Predicate<VisualElement> predicate)
	{
		return null;
	}

	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x29C56F0", Offset = "0x29C48F0", VA = "0x1829C56F0")]
	public bool Contains(VisualElement child)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x29C5FD0", Offset = "0x29C51D0", VA = "0x1829C5FD0")]
	private void GatherAllChildren(List<VisualElement> elements)
	{
	}

	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x29C5C60", Offset = "0x29C4E60", VA = "0x1829C5C60")]
	public VisualElement FindCommonAncestor(VisualElement other)
	{
		return null;
	}

	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x29C6D70", Offset = "0x29C5F70", VA = "0x1829C6D70")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal VisualElement GetRoot()
	{
		return null;
	}

	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x29C6D00", Offset = "0x29C5F00", VA = "0x1829C6D00")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal VisualElement GetRootVisualContainer(bool stopAtNearestRoot = false)
	{
		return null;
	}

	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x29C63A0", Offset = "0x29C55A0", VA = "0x1829C63A0")]
	internal VisualElement GetNextElementDepthFirst()
	{
		return null;
	}

	[Token(Token = "0x6001A08")]
	[Address(RVA = "0x29C6B30", Offset = "0x29C5D30", VA = "0x1829C6B30")]
	internal VisualElement GetPreviousElementDepthFirst()
	{
		return null;
	}

	[Token(Token = "0x6001A09")]
	[Address(RVA = "0x29C99D0", Offset = "0x29C8BD0", VA = "0x1829C99D0")]
	internal VisualElement RetargetElement(VisualElement retargetAgainst)
	{
		return null;
	}

	[Token(Token = "0x6001A0B")]
	[Address(RVA = "0x29C6790", Offset = "0x29C5990", VA = "0x1829C6790")]
	internal void GetPivotedMatrixWithLayout(out Matrix4x4 result)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x29C7B00", Offset = "0x29C6D00", VA = "0x1829C7B00")]
	internal static float Min(float a, float b, float c, float d)
	{
		return default(float);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x29C78B0", Offset = "0x29C6AB0", VA = "0x1829C78B0")]
	internal static float Max(float a, float b, float c, float d)
	{
		return default(float);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x29CB5C0", Offset = "0x29CA7C0", VA = "0x1829CB5C0")]
	internal void TransformAlignedBoundsToParentSpace(ref Bounds bounds)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x29CB7E0", Offset = "0x29CA9E0", VA = "0x1829CB7E0")]
	private void TransformAlignedRectToParentSpace(ref Rect rect)
	{
	}

	[Token(Token = "0x6001A14")]
	[Address(RVA = "0x29C4480", Offset = "0x29C3680", VA = "0x1829C4480")]
	internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect)
	{
		return default(Rect);
	}

	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x29C3FC0", Offset = "0x29C31C0", VA = "0x1829C3FC0")]
	internal static Bounds CalculateConservativeBounds(ref Matrix4x4 matrix, Bounds bounds)
	{
		return default(Bounds);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A16")]
	[Address(RVA = "0x29CB920", Offset = "0x29CAB20", VA = "0x1829CB920")]
	internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x29CB740", Offset = "0x29CA940", VA = "0x1829CB740")]
	internal static void TransformAlignedBounds(ref Matrix4x4 matrix, ref Bounds bounds)
	{
	}

	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x29C7E10", Offset = "0x29C7010", VA = "0x1829C7E10")]
	internal static void OrderMinMaxRect(ref Rect rect)
	{
	}

	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x29C7DD0", Offset = "0x29C6FD0", VA = "0x1829C7DD0")]
	internal static void OrderMinMaxBounds(ref Bounds bounds)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x29C7D40", Offset = "0x29C6F40", VA = "0x1829C7D40")]
	internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x29C7D90", Offset = "0x29C6F90", VA = "0x1829C7D90")]
	internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x29C7B10", Offset = "0x29C6D10", VA = "0x1829C7B10")]
	internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0x29CB9A0", Offset = "0x29CABA0", VA = "0x1829CB9A0")]
	private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x24CCB70", Offset = "0x24CBD70", VA = "0x1824CCB70")]
	private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs)
	{
	}

	[Token(Token = "0x6001A20")]
	[Address(RVA = "0x29D06B0", Offset = "0x29CF8B0", VA = "0x1829D06B0", Slot = "130")]
	private IVisualElementScheduledItem UnityEngine_002EUIElements_002EIVisualElementScheduler_002EExecute(Action<TimerState> timerUpdateEvent)
	{
		return null;
	}

	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x29D0770", Offset = "0x29CF970", VA = "0x1829D0770", Slot = "131")]
	private IVisualElementScheduledItem UnityEngine_002EUIElements_002EIVisualElementScheduler_002EExecute(Action updateEvent)
	{
		return null;
	}

	[Token(Token = "0x6001A26")]
	[Address(RVA = "0x29C2C80", Offset = "0x29C1E80", VA = "0x1829C2C80")]
	internal void AddStyleSheetPath(string sheetPath)
	{
	}

	[Token(Token = "0x6001A27")]
	[Address(RVA = "0x29C92B0", Offset = "0x29C84B0", VA = "0x1829C92B0")]
	internal StyleFloat ResolveLengthValue(Length length, bool isRow)
	{
		return default(StyleFloat);
	}

	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x29C9810", Offset = "0x29C8A10", VA = "0x1829C9810")]
	internal Vector3 ResolveTranslate()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001A29")]
	[Address(RVA = "0x29C95E0", Offset = "0x29C87E0", VA = "0x1829C95E0")]
	internal Vector3 ResolveTransformOrigin()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001A2A")]
	[Address(RVA = "0x29C9410", Offset = "0x29C8610", VA = "0x1829C9410")]
	private Quaternion ResolveRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6001A2B")]
	[Address(RVA = "0x29C94F0", Offset = "0x29C86F0", VA = "0x1829C94F0")]
	private Vector3 ResolveScale()
	{
		return default(Vector3);
	}
}
