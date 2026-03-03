using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004C5")]
[HelpURL("UIE-VisualTree-landing")]
public class VisualTreeAsset : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20004C6")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct UsingEntry
	{
		[Token(Token = "0x4000F96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static readonly IComparer<UsingEntry> comparer;

		[Token(Token = "0x4000F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string alias;

		[Token(Token = "0x4000F98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		public string path;

		[Token(Token = "0x4000F99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public VisualTreeAsset asset;

		[Token(Token = "0x6002325")]
		[Address(RVA = "0x2A3A630", Offset = "0x2A39830", VA = "0x182A3A630")]
		public UsingEntry(string alias, string path)
		{
		}
	}

	[Token(Token = "0x20004C7")]
	private class UsingEntryComparer : IComparer<UsingEntry>
	{
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x2A3A580", Offset = "0x2A39780", VA = "0x182A3A580", Slot = "4")]
		public int Compare(UsingEntry x, UsingEntry y)
		{
			return default(int);
		}

		[Token(Token = "0x6002328")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public UsingEntryComparer()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20004C8")]
	internal struct SlotDefinition
	{
		[Token(Token = "0x4000F9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string name;

		[Token(Token = "0x4000F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		public int insertionPointId;
	}

	[Serializable]
	[Token(Token = "0x20004C9")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct SlotUsageEntry
	{
		[Token(Token = "0x4000F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string slotName;

		[Token(Token = "0x4000F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		public int assetId;
	}

	[Serializable]
	[Token(Token = "0x20004CA")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct UxmlObjectEntry
	{
		[Token(Token = "0x4000F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public int parentId;

		[Token(Token = "0x4000F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		public List<UxmlObjectAsset> uxmlObjectAssets;

		[Token(Token = "0x6002329")]
		[Address(RVA = "0xD59140", Offset = "0xD58340", VA = "0x180D59140")]
		public UxmlObjectEntry(int parentId, List<UxmlObjectAsset> uxmlObjectAssets)
		{
		}

		[Token(Token = "0x600232A")]
		[Address(RVA = "0x2A3B6A0", Offset = "0x2A3A8A0", VA = "0x182A3B6A0")]
		public UxmlObjectAsset GetField(string fieldName)
		{
			return null;
		}

		[Token(Token = "0x600232B")]
		[Address(RVA = "0x2A3B7E0", Offset = "0x2A3A9E0", VA = "0x182A3B7E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x20004CB")]
	private struct AssetEntry
	{
		[Token(Token = "0x4000FA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string m_Path;

		[Token(Token = "0x4000FA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private string m_TypeFullName;

		[Token(Token = "0x4000FA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LazyLoadReference<Object> m_AssetReference;

		[Token(Token = "0x4000FA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_InstanceID;

		[Token(Token = "0x4000FA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Type m_CachedType;

		[Token(Token = "0x17000947")]
		public Type type
		{
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x2A298C0", Offset = "0x2A28AC0", VA = "0x182A298C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000948")]
		public string path
		{
			[Token(Token = "0x600232D")]
			[Address(RVA = "0x5BF740", Offset = "0x5BE940", VA = "0x1805BF740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000949")]
		public Object asset
		{
			[Token(Token = "0x600232E")]
			[Address(RVA = "0x2A29850", Offset = "0x2A28A50", VA = "0x182A29850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600232F")]
		[Address(RVA = "0x2A29780", Offset = "0x2A28980", VA = "0x182A29780")]
		public AssetEntry(string path, Type type, Object asset)
		{
		}
	}

	[Token(Token = "0x20004CE")]
	[CompilerGenerated]
	private sealed class _003Cget_stylesheets_003Ed__31 : IEnumerable<StyleSheet>, IEnumerable, IEnumerator<StyleSheet>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000FA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StyleSheet _003C_003E2__current;

		[Token(Token = "0x4000FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VisualTreeAsset _003C_003E4__this;

		[Token(Token = "0x4000FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<StyleSheet> _003Csent_003E5__1;

		[Token(Token = "0x4000FAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<VisualElementAsset>.Enumerator _003C_003Es__2;

		[Token(Token = "0x4000FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VisualElementAsset _003Cvea_003E5__3;

		[Token(Token = "0x4000FAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<StyleSheet>.Enumerator _003C_003Es__4;

		[Token(Token = "0x4000FAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private StyleSheet _003Cstylesheet_003E5__5;

		[Token(Token = "0x4000FB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<string>.Enumerator _003C_003Es__6;

		[Token(Token = "0x4000FB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _003CstylesheetPath_003E5__7;

		[Token(Token = "0x4000FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private StyleSheet _003Cstylesheet_003E5__8;

		[Token(Token = "0x1700094A")]
		private StyleSheet System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EUIElements_002EStyleSheet_003E_002ECurrent
		{
			[Token(Token = "0x6002338")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700094B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600233A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002332")]
		[Address(RVA = "0x59ED60", Offset = "0x59DF60", VA = "0x18059ED60")]
		[DebuggerHidden]
		public _003Cget_stylesheets_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002333")]
		[Address(RVA = "0x2A33A20", Offset = "0x2A32C20", VA = "0x182A33A20", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002334")]
		[Address(RVA = "0x2A33140", Offset = "0x2A32340", VA = "0x182A33140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002335")]
		[Address(RVA = "0x2A33BB0", Offset = "0x2A32DB0", VA = "0x182A33BB0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6002336")]
		[Address(RVA = "0x2A33C00", Offset = "0x2A32E00", VA = "0x182A33C00")]
		private void _003C_003Em__Finally2()
		{
		}

		[Token(Token = "0x6002337")]
		[Address(RVA = "0x2A33C50", Offset = "0x2A32E50", VA = "0x182A33C50")]
		private void _003C_003Em__Finally3()
		{
		}

		[Token(Token = "0x6002339")]
		[Address(RVA = "0x2A339E0", Offset = "0x2A32BE0", VA = "0x182A339E0", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600233B")]
		[Address(RVA = "0x2A33940", Offset = "0x2A32B40", VA = "0x182A33940", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<StyleSheet> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EUIElements_002EStyleSheet_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600233C")]
		[Address(RVA = "0x2A33940", Offset = "0x2A32B40", VA = "0x182A33940", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x20004CF")]
	[CompilerGenerated]
	private sealed class _003Cget_templateDependencies_003Ed__27 : IEnumerable<VisualTreeAsset>, IEnumerable, IEnumerator<VisualTreeAsset>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000FB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VisualTreeAsset _003C_003E2__current;

		[Token(Token = "0x4000FB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000FB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VisualTreeAsset _003C_003E4__this;

		[Token(Token = "0x4000FB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<VisualTreeAsset> _003Csent_003E5__1;

		[Token(Token = "0x4000FB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<UsingEntry>.Enumerator _003C_003Es__2;

		[Token(Token = "0x4000FB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UsingEntry _003Centry_003E5__3;

		[Token(Token = "0x4000FBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private VisualTreeAsset _003Cvta_003E5__4;

		[Token(Token = "0x1700094C")]
		private VisualTreeAsset System_002ECollections_002EGeneric_002EIEnumerator_003CUnityEngine_002EUIElements_002EVisualTreeAsset_003E_002ECurrent
		{
			[Token(Token = "0x6002341")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700094D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002343")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600233D")]
		[Address(RVA = "0x59ED60", Offset = "0x59DF60", VA = "0x18059ED60")]
		[DebuggerHidden]
		public _003Cget_templateDependencies_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600233E")]
		[Address(RVA = "0x2A343A0", Offset = "0x2A335A0", VA = "0x182A343A0", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600233F")]
		[Address(RVA = "0x2A33CA0", Offset = "0x2A32EA0", VA = "0x182A33CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002340")]
		[Address(RVA = "0x2A34430", Offset = "0x2A33630", VA = "0x182A34430")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6002342")]
		[Address(RVA = "0x2A34360", Offset = "0x2A33560", VA = "0x182A34360", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002344")]
		[Address(RVA = "0x2A342C0", Offset = "0x2A334C0", VA = "0x182A342C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<VisualTreeAsset> System_002ECollections_002EGeneric_002EIEnumerable_003CUnityEngine_002EUIElements_002EVisualTreeAsset_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6002345")]
		[Address(RVA = "0x2A342C0", Offset = "0x2A334C0", VA = "0x182A342C0", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000F85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static string LinkedVEAInTemplatePropertyName;

	[Token(Token = "0x4000F86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal static string NoRegisteredFactoryErrorMessage;

	[Token(Token = "0x4000F87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_ImportedWithErrors;

	[Token(Token = "0x4000F88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool m_HasUpdatedUrls;

	[Token(Token = "0x4000F89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool m_ImportedWithWarnings;

	[Token(Token = "0x4000F8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints;

	[Token(Token = "0x4000F8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly List<int> s_VeaIdsPath;

	[Token(Token = "0x4000F8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<UsingEntry> m_Usings;

	[Token(Token = "0x4000F8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal StyleSheet inlineSheet;

	[Token(Token = "0x4000F8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal List<VisualElementAsset> m_VisualElementAssets;

	[Token(Token = "0x4000F8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	internal List<TemplateAsset> m_TemplateAssets;

	[Token(Token = "0x4000F90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<UxmlObjectEntry> m_UxmlObjectEntries;

	[Token(Token = "0x4000F91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<int> m_UxmlObjectIds;

	[Token(Token = "0x4000F92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<AssetEntry> m_AssetEntries;

	[Token(Token = "0x4000F93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<SlotDefinition> m_Slots;

	[Token(Token = "0x4000F94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private int m_ContentContainerId;

	[Token(Token = "0x4000F95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private int m_ContentHash;

	[Token(Token = "0x1700093A")]
	public bool importedWithErrors
	{
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x277C150", Offset = "0x277B350", VA = "0x18277C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700093B")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool importerWithUpdatedUrls
	{
		[Token(Token = "0x60022F0")]
		[Address(RVA = "0x29FA960", Offset = "0x29F9B60", VA = "0x1829FA960")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0xAA0C10", Offset = "0xA9FE10", VA = "0x180AA0C10")]
		set
		{
		}
	}

	[Token(Token = "0x1700093C")]
	public bool importedWithWarnings
	{
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x2A28110", Offset = "0x2A27310", VA = "0x182A28110")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0xEF99A0", Offset = "0xEF8BA0", VA = "0x180EF99A0")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700093D")]
	internal List<UsingEntry> usings
	{
		[Token(Token = "0x60022F5")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093E")]
	public IEnumerable<VisualTreeAsset> templateDependencies
	{
		[Token(Token = "0x60022F6")]
		[Address(RVA = "0x2A281A0", Offset = "0x2A273A0", VA = "0x182A281A0")]
		[IteratorStateMachine(typeof(_003Cget_templateDependencies_003Ed__27))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093F")]
	public IEnumerable<StyleSheet> stylesheets
	{
		[Token(Token = "0x60022F7")]
		[Address(RVA = "0x2A28120", Offset = "0x2A27320", VA = "0x182A28120")]
		[IteratorStateMachine(typeof(_003Cget_stylesheets_003Ed__31))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000940")]
	internal List<VisualElementAsset> visualElementAssets
	{
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000941")]
	internal List<TemplateAsset> templateAssets
	{
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000942")]
	internal List<UxmlObjectEntry> uxmlObjectEntries
	{
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000943")]
	internal List<int> uxmlObjectIds
	{
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000944")]
	internal List<SlotDefinition> slots
	{
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000945")]
	internal int contentContainerId
	{
		[Token(Token = "0x600230E")]
		[Address(RVA = "0x28A5870", Offset = "0x28A4A70", VA = "0x1828A5870")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600230F")]
		[Address(RVA = "0x4048C0", Offset = "0x403AC0", VA = "0x1804048C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000946")]
	public int contentHash
	{
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x2855EB0", Offset = "0x28550B0", VA = "0x182855EB0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002321")]
		[Address(RVA = "0x91EA10", Offset = "0x91DC10", VA = "0x18091EA10")]
		set
		{
		}
	}

	[Token(Token = "0x60022F4")]
	[Address(RVA = "0x2A26020", Offset = "0x2A25220", VA = "0x182A26020")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal int GetNextChildSerialNumber()
	{
		return default(int);
	}

	[Token(Token = "0x60022FC")]
	[Address(RVA = "0x2A26BE0", Offset = "0x2A25DE0", VA = "0x182A26BE0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void RemoveElementAndDependencies(VisualElementAsset asset)
	{
	}

	[Token(Token = "0x60022FD")]
	[Address(RVA = "0x2A269D0", Offset = "0x2A25BD0", VA = "0x182A269D0")]
	internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset)
	{
	}

	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x2A233A0", Offset = "0x2A225A0", VA = "0x182A233A0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal UxmlObjectAsset AddUxmlObject(UxmlAsset parent, string fieldUxmlName, string fullTypeName, [Optional] UxmlNamespaceDefinition xmlNamespace)
	{
		return null;
	}

	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x2A26190", Offset = "0x2A25390", VA = "0x182A26190")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal int GetNextUxmlAssetId(int parentId)
	{
		return default(int);
	}

	[Token(Token = "0x6002300")]
	[Address(RVA = "0x2A27150", Offset = "0x2A26350", VA = "0x182A27150")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void RemoveUxmlObject(int id, bool onlyIfIsField = false)
	{
	}

	[Token(Token = "0x6002301")]
	[Address(RVA = "0x2A26CC0", Offset = "0x2A25EC0", VA = "0x182A26CC0")]
	private void RemoveUxmlObjectEntryDependencies(int parentId)
	{
	}

	[Token(Token = "0x6002302")]
	[Address(RVA = "0x2A25280", Offset = "0x2A24480", VA = "0x182A25280")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void CollectUxmlObjectAssets(UxmlAsset parent, string fieldName, List<UxmlObjectAsset> foundEntries)
	{
	}

	[Token(Token = "0x6002303")]
	[Address(RVA = "0x2A275B0", Offset = "0x2A267B0", VA = "0x182A275B0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void SetUxmlObjectAssets(UxmlAsset parent, string fieldName, List<UxmlObjectAsset> entries)
	{
	}

	[Token(Token = "0x6002304")]
	internal List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc) where T : new()
	{
		return null;
	}

	[Token(Token = "0x6002305")]
	[Address(RVA = "0x2A23730", Offset = "0x2A22930", VA = "0x182A23730")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool AssetEntryExists(string path, Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6002306")]
	[Address(RVA = "0x2A268C0", Offset = "0x2A25AC0", VA = "0x182A268C0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void RegisterAssetEntry(string path, Type type, Object asset)
	{
	}

	[Token(Token = "0x6002307")]
	[Address(RVA = "0x2A27900", Offset = "0x2A26B00", VA = "0x182A27900")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void TransferAssetEntries(VisualTreeAsset otherVta)
	{
	}

	[Token(Token = "0x6002308")]
	internal T GetAsset<T>(string path) where T : Object
	{
		return null;
	}

	[Token(Token = "0x6002309")]
	[Address(RVA = "0x2A25E60", Offset = "0x2A25060", VA = "0x182A25E60")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Object GetAsset(string path, Type type)
	{
		return null;
	}

	[Token(Token = "0x600230A")]
	[Address(RVA = "0x2A25CF0", Offset = "0x2A24EF0", VA = "0x182A25CF0")]
	internal Type GetAssetType(string path)
	{
		return null;
	}

	[Token(Token = "0x600230B")]
	[Address(RVA = "0x2A26200", Offset = "0x2A25400", VA = "0x182A26200")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal UxmlObjectEntry GetUxmlObjectEntry(int id)
	{
		return default(UxmlObjectEntry);
	}

	[Token(Token = "0x600230C")]
	[Address(RVA = "0x2A26340", Offset = "0x2A25540", VA = "0x182A26340")]
	internal IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset)
	{
		return null;
	}

	[Token(Token = "0x6002310")]
	[Address(RVA = "0x2A266F0", Offset = "0x2A258F0", VA = "0x182A266F0")]
	public TemplateContainer Instantiate()
	{
		return null;
	}

	[Token(Token = "0x6002311")]
	[Address(RVA = "0x2A24FF0", Offset = "0x2A241F0", VA = "0x182A24FF0")]
	public TemplateContainer Instantiate(string bindingPath)
	{
		return null;
	}

	[Token(Token = "0x6002312")]
	[Address(RVA = "0x2A25270", Offset = "0x2A24470", VA = "0x182A25270")]
	public TemplateContainer CloneTree()
	{
		return null;
	}

	[Token(Token = "0x6002313")]
	[Address(RVA = "0x2A24FF0", Offset = "0x2A241F0", VA = "0x182A24FF0")]
	public TemplateContainer CloneTree(string bindingPath)
	{
		return null;
	}

	[Token(Token = "0x6002314")]
	[Address(RVA = "0x2A24FC0", Offset = "0x2A241C0", VA = "0x182A24FC0")]
	public void CloneTree(VisualElement target)
	{
	}

	[Token(Token = "0x6002315")]
	[Address(RVA = "0x2A25040", Offset = "0x2A24240", VA = "0x182A25040")]
	public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
	{
	}

	[Token(Token = "0x6002316")]
	[Address(RVA = "0x2A247C0", Offset = "0x2A239C0", VA = "0x182A247C0")]
	internal void CloneTree(VisualElement target, CreationContext cc)
	{
	}

	[Token(Token = "0x6002317")]
	[Address(RVA = "0x2A23CB0", Offset = "0x2A22EB0", VA = "0x182A23CB0")]
	private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context)
	{
		return null;
	}

	[Token(Token = "0x6002318")]
	[Address(RVA = "0x2A25560", Offset = "0x2A24760", VA = "0x182A25560")]
	internal static int CompareForOrder(VisualElementAsset a, VisualElementAsset b)
	{
		return default(int);
	}

	[Token(Token = "0x6002319")]
	[Address(RVA = "0x2A27990", Offset = "0x2A26B90", VA = "0x182A27990")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
	{
		return default(bool);
	}

	[Token(Token = "0x600231A")]
	[Address(RVA = "0x2A27A70", Offset = "0x2A26C70", VA = "0x182A27A70")]
	internal bool TryGetUsingEntry(string templateName, out UsingEntry entry)
	{
		return default(bool);
	}

	[Token(Token = "0x600231B")]
	[Address(RVA = "0x2A26C50", Offset = "0x2A25E50", VA = "0x182A26C50")]
	private void RemoveUsingEntry(UsingEntry entry)
	{
	}

	[Token(Token = "0x600231C")]
	[Address(RVA = "0x2A27320", Offset = "0x2A26520", VA = "0x182A27320")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal VisualTreeAsset ResolveTemplate(string templateName)
	{
		return null;
	}

	[Token(Token = "0x600231D")]
	[Address(RVA = "0x2A25590", Offset = "0x2A24790", VA = "0x182A25590")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx)
	{
		return null;
	}

	[Token(Token = "0x600231E")]
	[Address(RVA = "0x2A238E0", Offset = "0x2A22AE0", VA = "0x182A238E0")]
	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
	{
	}

	[Token(Token = "0x600231F")]
	[Address(RVA = "0x2A23970", Offset = "0x2A22B70", VA = "0x182A23970")]
	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
	{
	}

	[Token(Token = "0x6002322")]
	[Address(RVA = "0x2A27EF0", Offset = "0x2A270F0", VA = "0x182A27EF0")]
	public VisualTreeAsset()
	{
	}
}
