using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Duel;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x2001314")]
public class ProfileEditViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001315")]
	internal class ProfileAvatarEdit : ProfileEdit
	{
		[Token(Token = "0x2001317")]
		[CompilerGenerated]
		private sealed class _003CDelaySelect_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BF7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BF7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BF7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProfileAvatarEdit _003C_003E4__this;

			[Token(Token = "0x400BF7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int dataindex;

			[Token(Token = "0x400BF80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool selectItem;

			[Token(Token = "0x400BF81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			public bool isIni;

			[Token(Token = "0x1700127B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60076A0")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700127C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60076A2")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600769D")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CDelaySelect_003Ed__27(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600769E")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600769F")]
			[Address(RVA = "0xBE6CD0", Offset = "0xBE5ED0", VA = "0x180BE6CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60076A1")]
			[Address(RVA = "0xBE6DB0", Offset = "0xBE5FB0", VA = "0x180BE6DB0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BF6D")]
		private const string IMG_RROFILE_BADGE_LABEL = "ProfileBadge";

		[Token(Token = "0x400BF6E")]
		private const string IMG_SELECTED_LABEL = "ImageSelected";

		[Token(Token = "0x400BF6F")]
		private const string IMG_LABEL = "Image";

		[Token(Token = "0x400BF70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected TextMeshProUGUI m_ItemName;

		[Token(Token = "0x400BF71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected TextGroupLoadHolder textGroupLoadHolder;

		[Token(Token = "0x400BF72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InfinityScrollView m_InfinityScroll;

		[Token(Token = "0x400BF73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<object> itemIdList;

		[Token(Token = "0x400BF74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int focusId;

		[Token(Token = "0x400BF75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int m_ProfileAvatarId;

		[Token(Token = "0x400BF76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly int noneSelectAvatarId;

		[Token(Token = "0x17001278")]
		public string itemName
		{
			[Token(Token = "0x6007688")]
			[Address(RVA = "0xA75A10", Offset = "0xA74C10", VA = "0x180A75A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007689")]
			[Address(RVA = "0xBD4110", Offset = "0xBD3310", VA = "0x180BD4110")]
			set
			{
			}
		}

		[Token(Token = "0x17001279")]
		public int selectedItemId
		{
			[Token(Token = "0x600768A")]
			[Address(RVA = "0xA2A110", Offset = "0xA29310", VA = "0x180A2A110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600768B")]
			[Address(RVA = "0xA2A550", Offset = "0xA29750", VA = "0x180A2A550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700127A")]
		public Action onCompleteInitiazeCallback
		{
			[Token(Token = "0x6007690")]
			[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007691")]
			[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600768C")]
		[Address(RVA = "0xBD3FB0", Offset = "0xBD31B0", VA = "0x180BD3FB0")]
		internal ProfileAvatarEdit(string clientWorkKeyName, string saveKeyName, int profileAvatarId, GameObject tmpEdit, Transform parentEdit, SideMenuType sideMenuType, List<object> tagList, TextGroupLoadHolder textGroupLoadHolder, bool isReplay = false)
		{
		}

		[Token(Token = "0x600768D")]
		[Address(RVA = "0xBD3BD0", Offset = "0xBD2DD0", VA = "0x180BD3BD0", Slot = "16")]
		internal virtual void SetActiveViewItem(bool isActive)
		{
		}

		[Token(Token = "0x600768E")]
		[Address(RVA = "0xBD2E50", Offset = "0xBD2050", VA = "0x180BD2E50", Slot = "8")]
		internal override void EnterFromMenu()
		{
		}

		[Token(Token = "0x600768F")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760", Slot = "7")]
		internal override void SetCurrent(object dictionary)
		{
		}

		[Token(Token = "0x6007692")]
		[Address(RVA = "0xBD3460", Offset = "0xBD2660", VA = "0x180BD3460", Slot = "4")]
		internal override void Init()
		{
		}

		[Token(Token = "0x6007693")]
		[Address(RVA = "0xBD3080", Offset = "0xBD2280", VA = "0x180BD3080")]
		public void FocusImmidiate(int dataindex, bool selectItem = false, bool isIni = true)
		{
		}

		[Token(Token = "0x6007694")]
		[Address(RVA = "0xBD2DB0", Offset = "0xBD1FB0", VA = "0x180BD2DB0")]
		[IteratorStateMachine(typeof(_003CDelaySelect_003Ed__27))]
		private IEnumerator DelaySelect(int dataindex, bool selectItem = false, bool isIni = true)
		{
			return null;
		}

		[Token(Token = "0x6007695")]
		[Address(RVA = "0xBD3670", Offset = "0xBD2870", VA = "0x180BD3670")]
		private void OnGsvStanby()
		{
		}

		[Token(Token = "0x6007696")]
		[Address(RVA = "0xBD3160", Offset = "0xBD2360", VA = "0x180BD3160", Slot = "15")]
		internal override List<(string, object)> GetSaveData(Dictionary<string, object> dic)
		{
			return null;
		}

		[Token(Token = "0x6007697")]
		[Address(RVA = "0xBD3720", Offset = "0xBD2920", VA = "0x180BD3720")]
		private void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		[Token(Token = "0x6007698")]
		[Address(RVA = "0xBD3F80", Offset = "0xBD3180", VA = "0x180BD3F80", Slot = "5")]
		internal override void UpdateData()
		{
		}
	}

	[Token(Token = "0x2001318")]
	internal class ProfileCardFileEdit : ProfileEdit
	{
		[Token(Token = "0x200131A")]
		[CompilerGenerated]
		private sealed class _003CDelaySelect_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BF91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BF92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BF93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProfileCardFileEdit _003C_003E4__this;

			[Token(Token = "0x400BF94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int dataindex;

			[Token(Token = "0x400BF95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool selectItem;

			[Token(Token = "0x400BF96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			public bool isIni;

			[Token(Token = "0x17001282")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60076BD")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001283")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60076BF")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60076BA")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CDelaySelect_003Ed__30(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60076BB")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60076BC")]
			[Address(RVA = "0xBE6DF0", Offset = "0xBE5FF0", VA = "0x180BE6DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60076BE")]
			[Address(RVA = "0xBE6ED0", Offset = "0xBE60D0", VA = "0x180BE6ED0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BF82")]
		private const string IMG_SELECTED_LABEL = "ImageSelected";

		[Token(Token = "0x400BF83")]
		private const string OBJ_MYCARDFILE_LABEL = "MyCardFileField";

		[Token(Token = "0x400BF84")]
		private const string IMG_IMAGE_LABEL = "Image";

		[Token(Token = "0x400BF85")]
		private const string IMG_NONE_LABEL = "NoneImage";

		[Token(Token = "0x400BF86")]
		private const string ITEM_ID_KEY = "item_id";

		[Token(Token = "0x400BF87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected TextMeshProUGUI m_ItemName;

		[Token(Token = "0x400BF88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected TextGroupLoadHolder textGroupLoadHolder;

		[Token(Token = "0x400BF89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ElementObjectManager m_MyCardFileField;

		[Token(Token = "0x400BF8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private InfinityScrollView m_InfinityScroll;

		[Token(Token = "0x400BF8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<object> itemIdList;

		[Token(Token = "0x1700127D")]
		public int selectedItemId
		{
			[Token(Token = "0x60076A3")]
			[Address(RVA = "0x4226F0", Offset = "0x4218F0", VA = "0x1804226F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60076A4")]
			[Address(RVA = "0x422700", Offset = "0x421900", VA = "0x180422700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700127E")]
		public string itemName
		{
			[Token(Token = "0x60076A5")]
			[Address(RVA = "0xA75A10", Offset = "0xA74C10", VA = "0x180A75A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60076A6")]
			[Address(RVA = "0xBD4110", Offset = "0xBD3310", VA = "0x180BD4110")]
			set
			{
			}
		}

		[Token(Token = "0x1700127F")]
		public GameObject image
		{
			[Token(Token = "0x60076A7")]
			[Address(RVA = "0xBD5520", Offset = "0xBD4720", VA = "0x180BD5520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001280")]
		public GameObject noneImage
		{
			[Token(Token = "0x60076A8")]
			[Address(RVA = "0xBD5570", Offset = "0xBD4770", VA = "0x180BD5570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001281")]
		public Action onCompleteInitiazeCallback
		{
			[Token(Token = "0x60076AC")]
			[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076AD")]
			[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60076A9")]
		[Address(RVA = "0xBD5300", Offset = "0xBD4500", VA = "0x180BD5300")]
		internal ProfileCardFileEdit(string clientWorkKeyName, string saveKeyName, GameObject tmpEdit, Transform parentEdit, SideMenuType sideMenuType, List<object> tagList, TextGroupLoadHolder textGroupLoadHolder, bool isReplay = false)
		{
		}

		[Token(Token = "0x60076AA")]
		[Address(RVA = "0xBD41E0", Offset = "0xBD33E0", VA = "0x180BD41E0", Slot = "8")]
		internal override void EnterFromMenu()
		{
		}

		[Token(Token = "0x60076AB")]
		[Address(RVA = "0xBD4FF0", Offset = "0xBD41F0", VA = "0x180BD4FF0", Slot = "7")]
		internal override void SetCurrent(object dictionary)
		{
		}

		[Token(Token = "0x60076AE")]
		[Address(RVA = "0xBD47D0", Offset = "0xBD39D0", VA = "0x180BD47D0", Slot = "4")]
		internal override void Init()
		{
		}

		[Token(Token = "0x60076AF")]
		[Address(RVA = "0xBD4420", Offset = "0xBD3620", VA = "0x180BD4420")]
		public void FocusImmidiate(int dataindex, bool selectItem = false, bool isIni = true)
		{
		}

		[Token(Token = "0x60076B0")]
		[Address(RVA = "0xBD4140", Offset = "0xBD3340", VA = "0x180BD4140")]
		[IteratorStateMachine(typeof(_003CDelaySelect_003Ed__30))]
		private IEnumerator DelaySelect(int dataindex, bool selectItem = false, bool isIni = true)
		{
			return null;
		}

		[Token(Token = "0x60076B1")]
		[Address(RVA = "0xBD49E0", Offset = "0xBD3BE0", VA = "0x180BD49E0")]
		private void OnGsvStanby()
		{
		}

		[Token(Token = "0x60076B2")]
		[Address(RVA = "0xBD4500", Offset = "0xBD3700", VA = "0x180BD4500", Slot = "15")]
		internal override List<(string, object)> GetSaveData(Dictionary<string, object> dic)
		{
			return null;
		}

		[Token(Token = "0x60076B3")]
		[Address(RVA = "0xBD4F40", Offset = "0xBD4140", VA = "0x180BD4F40", Slot = "9")]
		internal override void SetActiveRoot(bool rootActive)
		{
		}

		[Token(Token = "0x60076B4")]
		[Address(RVA = "0xBD4A90", Offset = "0xBD3C90", VA = "0x180BD4A90")]
		private void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		[Token(Token = "0x60076B5")]
		[Address(RVA = "0xBD52D0", Offset = "0xBD44D0", VA = "0x180BD52D0", Slot = "5")]
		internal override void UpdateData()
		{
		}
	}

	[Token(Token = "0x200131B")]
	internal class ProfileHomeWallPaperEdit : ProfileEdit
	{
		[Token(Token = "0x200131C")]
		private class Data
		{
			[Token(Token = "0x400BFAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool interactable;

			[Token(Token = "0x400BFAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int index;

			[Token(Token = "0x400BFB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object value;

			[Token(Token = "0x60076D6")]
			[Address(RVA = "0xBD29D0", Offset = "0xBD1BD0", VA = "0x180BD29D0")]
			public Data(bool interactable, object value)
			{
			}
		}

		[Token(Token = "0x200131F")]
		[CompilerGenerated]
		private sealed class _003CDelaySelect_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BFB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BFB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BFB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProfileHomeWallPaperEdit _003C_003E4__this;

			[Token(Token = "0x400BFBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int dataindex;

			[Token(Token = "0x400BFBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool selectItem;

			[Token(Token = "0x400BFBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			public bool isIni;

			[Token(Token = "0x17001288")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60076DF")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001289")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60076E1")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60076DC")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CDelaySelect_003Ed__40(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60076DD")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60076DE")]
			[Address(RVA = "0xBE6F10", Offset = "0xBE6110", VA = "0x180BE6F10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60076E0")]
			[Address(RVA = "0xBE6FF0", Offset = "0xBE61F0", VA = "0x180BE6FF0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BF97")]
		private const string IMG_SELECTED_LABEL = "ImageSelected";

		[Token(Token = "0x400BF98")]
		private const string IMG_UNSELECTED_LABEL = "ImageUnselected";

		[Token(Token = "0x400BF99")]
		private const string TEMPLATE_LABEL = "template";

		[Token(Token = "0x400BF9A")]
		private const string TXT_EMPTY = "TextEmpty";

		[Token(Token = "0x400BF9B")]
		private const string IMG_LABEL = "Image";

		[Token(Token = "0x400BF9C")]
		private const string OBJ_MYTAG_LABEL = "MyTagField";

		[Token(Token = "0x400BF9D")]
		private const int MYFAV_EMPTY = -1;

		[Token(Token = "0x400BF9E")]
		private const string LOADING_LABEL = "Loading";

		[Token(Token = "0x400BF9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected TextMeshProUGUI m_ItemName;

		[Token(Token = "0x400BFA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected TextGroupLoadHolder textGroupLoadHolder;

		[Token(Token = "0x400BFA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SelectionButton m_FooterBtn;

		[Token(Token = "0x400BFA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<GameObject> myFavs;

		[Token(Token = "0x400BFA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Dictionary<int, int> currentSelectedIndexList;

		[Token(Token = "0x400BFA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private InfinityScrollView m_InfinityScroll;

		[Token(Token = "0x400BFA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private GameObject myFavField;

		[Token(Token = "0x400BFA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GameObject myFavTemplate;

		[Token(Token = "0x400BFA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private GameObject textEmpty;

		[Token(Token = "0x400BFA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<object> itemIdList;

		[Token(Token = "0x400BFA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<Data> dataList;

		[Token(Token = "0x400BFAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool isSelectedMax;

		[Token(Token = "0x400BFAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private int editingFavIndex;

		[Token(Token = "0x17001284")]
		public string itemName
		{
			[Token(Token = "0x60076C0")]
			[Address(RVA = "0xA75A10", Offset = "0xA74C10", VA = "0x180A75A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60076C1")]
			[Address(RVA = "0xBD4110", Offset = "0xBD3310", VA = "0x180BD4110")]
			set
			{
			}
		}

		[Token(Token = "0x17001285")]
		public int editingIdx
		{
			[Token(Token = "0x60076C2")]
			[Address(RVA = "0x49B890", Offset = "0x49AA90", VA = "0x18049B890")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17001286")]
		public int selectedItemId
		{
			[Token(Token = "0x60076C3")]
			[Address(RVA = "0xA2A0C0", Offset = "0xA292C0", VA = "0x180A2A0C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60076C4")]
			[Address(RVA = "0xA2A510", Offset = "0xA29710", VA = "0x180A2A510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001287")]
		public Action onCompleteInitiazeCallback
		{
			[Token(Token = "0x60076C8")]
			[Address(RVA = "0x4D0610", Offset = "0x4CF810", VA = "0x1804D0610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076C9")]
			[Address(RVA = "0x587E30", Offset = "0x587030", VA = "0x180587E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60076C5")]
		[Address(RVA = "0xBE5B40", Offset = "0xBE4D40", VA = "0x180BE5B40")]
		internal ProfileHomeWallPaperEdit(string clientWorkKeyName, string saveKeyName, GameObject tmpEdit, Transform parentEdit, SideMenuType sideMenuType, List<object> tagList, SelectionButton footerBtn, TextGroupLoadHolder textGroupLoadHolder, bool isReplay = false)
		{
		}

		[Token(Token = "0x60076C6")]
		[Address(RVA = "0xBE3360", Offset = "0xBE2560", VA = "0x180BE3360", Slot = "8")]
		internal override void EnterFromMenu()
		{
		}

		[Token(Token = "0x60076C7")]
		[Address(RVA = "0xBE4690", Offset = "0xBE3890", VA = "0x180BE4690", Slot = "7")]
		internal override void SetCurrent(object dictionary)
		{
		}

		[Token(Token = "0x60076CA")]
		[Address(RVA = "0xBE3C50", Offset = "0xBE2E50", VA = "0x180BE3C50", Slot = "4")]
		internal override void Init()
		{
		}

		[Token(Token = "0x60076CB")]
		[Address(RVA = "0xBE3680", Offset = "0xBE2880", VA = "0x180BE3680")]
		public void FocusImmidiate(int dataindex, bool selectItem = false, bool isIni = true)
		{
		}

		[Token(Token = "0x60076CC")]
		[Address(RVA = "0xBE32C0", Offset = "0xBE24C0", VA = "0x180BE32C0")]
		[IteratorStateMachine(typeof(_003CDelaySelect_003Ed__40))]
		private IEnumerator DelaySelect(int dataindex, bool selectItem = false, bool isIni = true)
		{
			return null;
		}

		[Token(Token = "0x60076CD")]
		[Address(RVA = "0xBE40A0", Offset = "0xBE32A0", VA = "0x180BE40A0")]
		private void OnGsvStanby()
		{
		}

		[Token(Token = "0x60076CE")]
		[Address(RVA = "0xBE3760", Offset = "0xBE2960", VA = "0x180BE3760", Slot = "15")]
		internal override List<(string, object)> GetSaveData(Dictionary<string, object> dic)
		{
			return null;
		}

		[Token(Token = "0x60076CF")]
		[Address(RVA = "0xBE4150", Offset = "0xBE3350", VA = "0x180BE4150")]
		private void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		[Token(Token = "0x60076D0")]
		[Address(RVA = "0xBE3E90", Offset = "0xBE3090", VA = "0x180BE3E90")]
		private bool IsContainsData(object data)
		{
			return default(bool);
		}

		[Token(Token = "0x60076D1")]
		[Address(RVA = "0xBE5B10", Offset = "0xBE4D10", VA = "0x180BE5B10")]
		private void UpdateWPScroll()
		{
		}

		[Token(Token = "0x60076D2")]
		[Address(RVA = "0xBE4F80", Offset = "0xBE4180", VA = "0x180BE4F80")]
		private void SetEditingIndex(int tagNo)
		{
		}

		[Token(Token = "0x60076D3")]
		[Address(RVA = "0xBE5760", Offset = "0xBE4960", VA = "0x180BE5760")]
		private void UpdateMyFav()
		{
		}

		[Token(Token = "0x60076D4")]
		[Address(RVA = "0xBE5380", Offset = "0xBE4580", VA = "0x180BE5380")]
		private void UpdateMyFavImage()
		{
		}
	}

	[Token(Token = "0x2001320")]
	private class TitleArea : MonoBehaviour
	{
		[Token(Token = "0x400BFBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400BFBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isInitialized;

		[Token(Token = "0x400BFBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExtendedTextMeshProUGUI m_TitleText;

		[Token(Token = "0x400BFC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExtendedTextMeshProUGUI m_CautionBtnText;

		[Token(Token = "0x400BFC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SelectionButton m_CautionButton;

		[Token(Token = "0x1700128A")]
		public Action onClickCautionButtonCallback
		{
			[Token(Token = "0x60076E2")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076E3")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60076E4")]
		[Address(RVA = "0xBE67A0", Offset = "0xBE59A0", VA = "0x180BE67A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60076E5")]
		[Address(RVA = "0xBE67F0", Offset = "0xBE59F0", VA = "0x180BE67F0")]
		public void InitializeElements()
		{
		}

		[Token(Token = "0x60076E6")]
		[Address(RVA = "0xBE6BB0", Offset = "0xBE5DB0", VA = "0x180BE6BB0")]
		public void SetTitleByEditType(EditType editType)
		{
		}

		[Token(Token = "0x60076E7")]
		[Address(RVA = "0xBE69A0", Offset = "0xBE5BA0", VA = "0x180BE69A0")]
		private void OpenCautionDialog()
		{
		}

		[Token(Token = "0x60076E8")]
		[Address(RVA = "0xBE6B60", Offset = "0xBE5D60", VA = "0x180BE6B60")]
		public void SetCautionButtonText(string label)
		{
		}

		[Token(Token = "0x60076E9")]
		[Address(RVA = "0xBE67B0", Offset = "0xBE59B0", VA = "0x180BE67B0")]
		public void DispCautionButton(bool disp)
		{
		}

		[Token(Token = "0x60076EA")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public TitleArea()
		{
		}
	}

	[Token(Token = "0x2001322")]
	private class SideMenu : MonoBehaviour
	{
		[Token(Token = "0x400BFC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400BFC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isInitialized;

		[Token(Token = "0x400BFC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AccordionTabGroupWidget accordionTabGroupWidget;

		[Token(Token = "0x1700128B")]
		public Selector selector
		{
			[Token(Token = "0x60076EF")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076F0")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700128C")]
		public SelectionButton m_BackButton
		{
			[Token(Token = "0x60076F1")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076F2")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700128D")]
		public Action onClickBackButtonCallback
		{
			[Token(Token = "0x60076F5")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076F6")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60076F3")]
		[Address(RVA = "0xBE5F40", Offset = "0xBE5140", VA = "0x180BE5F40")]
		private void Awake()
		{
		}

		[Token(Token = "0x60076F4")]
		[Address(RVA = "0xBE6030", Offset = "0xBE5230", VA = "0x180BE6030")]
		public void InitializeElements()
		{
		}

		[Token(Token = "0x60076F7")]
		[Address(RVA = "0xBE5F50", Offset = "0xBE5150", VA = "0x180BE5F50")]
		private void InitShottcutBack()
		{
		}

		[Token(Token = "0x60076F8")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public SideMenu()
		{
		}
	}

	[Token(Token = "0x2001323")]
	private class FooterArea : MonoBehaviour
	{
		[Token(Token = "0x400BFCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400BFCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isInitialized;

		[Token(Token = "0x400BFCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SelectionButton m_PreviewButton;

		[Token(Token = "0x400BFCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionButton m_SetAccessoryButton;

		[Token(Token = "0x400BFCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ExtendedTextMeshProUGUI m_PreviewButtonText;

		[Token(Token = "0x400BFD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ExtendedTextMeshProUGUI m_SetAccessoryBtnText;

		[Token(Token = "0x1700128E")]
		public SelectionButton previewButton
		{
			[Token(Token = "0x60076FA")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700128F")]
		public Action onClickPreviewButtonCallback
		{
			[Token(Token = "0x60076FC")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076FD")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001290")]
		public Action onClickSetAccessoryButtonCallback
		{
			[Token(Token = "0x60076FE")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60076FF")]
			[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001291")]
		public string buttonText
		{
			[Token(Token = "0x6007701")]
			[Address(RVA = "0x95A6D0", Offset = "0x9598D0", VA = "0x18095A6D0")]
			set
			{
			}
		}

		[Token(Token = "0x60076FB")]
		[Address(RVA = "0xBD2A40", Offset = "0xBD1C40", VA = "0x180BD2A40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6007700")]
		[Address(RVA = "0xBD2AB0", Offset = "0xBD1CB0", VA = "0x180BD2AB0")]
		public void InitializeElements()
		{
		}

		[Token(Token = "0x6007702")]
		[Address(RVA = "0xBD2D10", Offset = "0xBD1F10", VA = "0x180BD2D10")]
		public void SetAccessoryButtonText(string label)
		{
		}

		[Token(Token = "0x6007703")]
		[Address(RVA = "0xBD2A50", Offset = "0xBD1C50", VA = "0x180BD2A50")]
		public void DispSetAccessoryButton(bool disp)
		{
		}

		[Token(Token = "0x6007704")]
		[Address(RVA = "0xBD2CE0", Offset = "0xBD1EE0", VA = "0x180BD2CE0")]
		public void IsEnableSetAccessoryButton(bool isOn)
		{
		}

		[Token(Token = "0x6007705")]
		[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
		public FooterArea()
		{
		}
	}

	[Token(Token = "0x2001324")]
	public enum EditType
	{
		[Token(Token = "0x400BFD4")]
		USER_PROFILE,
		[Token(Token = "0x400BFD5")]
		ACCESSORY,
		[Token(Token = "0x400BFD6")]
		ACCESSORY_TOURNAMENT,
		[Token(Token = "0x400BFD7")]
		ACCESSORY_EXHIBITION,
		[Token(Token = "0x400BFD8")]
		ACCESSORY_CUP,
		[Token(Token = "0x400BFD9")]
		ACCESSORY_WCS,
		[Token(Token = "0x400BFDA")]
		ACCESSORY_RANKEVENT,
		[Token(Token = "0x400BFDB")]
		ACCESSORY_DUELTRIAL,
		[Token(Token = "0x400BFDC")]
		ACCESSORY_VERSUS,
		[Token(Token = "0x400BFDD")]
		WCS_PROFILE,
		[Token(Token = "0x400BFDE")]
		ACCESSORY_RDC,
		[Token(Token = "0x400BFDF")]
		REPLAY,
		[Token(Token = "0x400BFE0")]
		ACCESSORY_DICERALLY
	}

	[Token(Token = "0x2001325")]
	public enum SideMenuType
	{
		[Token(Token = "0x400BFE2")]
		NONE,
		[Token(Token = "0x400BFE3")]
		USER_NAME,
		[Token(Token = "0x400BFE4")]
		ICON,
		[Token(Token = "0x400BFE5")]
		ICONFRAME,
		[Token(Token = "0x400BFE6")]
		TAG,
		[Token(Token = "0x400BFE7")]
		MATE,
		[Token(Token = "0x400BFE8")]
		WALLPAPER_PROFILE,
		[Token(Token = "0x400BFE9")]
		WALLPAPER_HOME,
		[Token(Token = "0x400BFEA")]
		CARDFILE,
		[Token(Token = "0x400BFEB")]
		DECKCASE,
		[Token(Token = "0x400BFEC")]
		PROTECTOR,
		[Token(Token = "0x400BFED")]
		FIELD,
		[Token(Token = "0x400BFEE")]
		FIELDPARTS,
		[Token(Token = "0x400BFEF")]
		MATEBASE,
		[Token(Token = "0x400BFF0")]
		MATE_DECK,
		[Token(Token = "0x400BFF1")]
		PICKCARDS,
		[Token(Token = "0x400BFF2")]
		COIN,
		[Token(Token = "0x400BFF3")]
		TAG_REPLAY,
		[Token(Token = "0x400BFF4")]
		PICKCARDS_OWN,
		[Token(Token = "0x400BFF5")]
		PICKCARDS_RIVAL
	}

	[Token(Token = "0x2001326")]
	private class SideViewTemplate
	{
		[Token(Token = "0x2001327")]
		public enum TemplateType
		{
			[Token(Token = "0x400BFF7")]
			NORMAL,
			[Token(Token = "0x400BFF8")]
			COIN
		}

		[Token(Token = "0x6007708")]
		[Address(RVA = "0xBE6440", Offset = "0xBE5640", VA = "0x180BE6440")]
		public static void SetActiveAll(ElementObjectManager parent, bool isActive)
		{
		}

		[Token(Token = "0x6007709")]
		[Address(RVA = "0xBE63A0", Offset = "0xBE55A0", VA = "0x180BE63A0")]
		private static GameObject GetTemplate(ElementObjectManager parent, TemplateType tmpType)
		{
			return null;
		}

		[Token(Token = "0x600770A")]
		[Address(RVA = "0xBE6220", Offset = "0xBE5420", VA = "0x180BE6220")]
		public static GameObject CreateTemplate(ElementObjectManager parent, TemplateType tmpType)
		{
			return null;
		}

		[Token(Token = "0x600770B")]
		[Address(RVA = "0xBE6350", Offset = "0xBE5550", VA = "0x180BE6350")]
		public static GameObject GetRootTemplate(ElementObjectManager parent)
		{
			return null;
		}

		[Token(Token = "0x600770C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SideViewTemplate()
		{
		}
	}

	[Token(Token = "0x2001328")]
	internal abstract class ProfileEdit
	{
		[Token(Token = "0x400BFF9")]
		private const string k_ELabelTextOn = "TextOn";

		[Token(Token = "0x400BFFA")]
		private const string k_ELabelTextOff = "TextOff";

		[Token(Token = "0x400BFFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly SideMenuType sideMenuType;

		[Token(Token = "0x400BFFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ElementObjectManager m_Eom;

		[Token(Token = "0x400BFFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected GameObject m_Edit;

		[Token(Token = "0x400BFFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected GameObject m_View;

		[Token(Token = "0x400BFFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected GameObject m_Loading;

		[Token(Token = "0x400C000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Selector m_Selector;

		[Token(Token = "0x400C001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected SelectionButton m_ViewButton;

		[Token(Token = "0x400C002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Selector m_ParentSelector;

		[Token(Token = "0x400C003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected object current;

		[Token(Token = "0x400C004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected bool isInitializeCalled;

		[Token(Token = "0x400C005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isInitialized;

		[Token(Token = "0x400C006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal readonly string clientWorkKeyName;

		[Token(Token = "0x400C007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal readonly string saveKeyName;

		[Token(Token = "0x400C008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Action onUpdateViewCallback;

		[Token(Token = "0x400C009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Action onClickPreviewCallback;

		[Token(Token = "0x400C00A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Action onClickViewCallback;

		[Token(Token = "0x400C00B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Action onClickCautionCallBack;

		[Token(Token = "0x400C00C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Action onClickSetAccessoryCallBack;

		[Token(Token = "0x400C00D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool DispSetAccessoryButton;

		[Token(Token = "0x400C00E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string CautionBtnText;

		[Token(Token = "0x400C00F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string SetAccessoryBtnText;

		[Token(Token = "0x17001292")]
		public bool isActive
		{
			[Token(Token = "0x600770D")]
			[Address(RVA = "0xBE32A0", Offset = "0xBE24A0", VA = "0x180BE32A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17001293")]
		public GameObject view
		{
			[Token(Token = "0x600770E")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600770F")]
		[Address(RVA = "0xBE3110", Offset = "0xBE2310", VA = "0x180BE3110")]
		protected ProfileEdit(string clientWorkKeyName, string saveKeyName, GameObject template, Transform parent, SideMenuType sideMenuType)
		{
		}

		[Token(Token = "0x6007710")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
		internal virtual void Init()
		{
		}

		[Token(Token = "0x6007711")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		internal virtual void UpdateData()
		{
		}

		[Token(Token = "0x6007712")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "6")]
		internal virtual object GetCurrent()
		{
			return null;
		}

		[Token(Token = "0x6007713")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760", Slot = "7")]
		internal virtual void SetCurrent(object current)
		{
		}

		[Token(Token = "0x6007714")]
		internal abstract void EnterFromMenu();

		[Token(Token = "0x6007715")]
		[Address(RVA = "0xBE2D90", Offset = "0xBE1F90", VA = "0x180BE2D90", Slot = "9")]
		internal virtual void SetActiveRoot(bool rootActive)
		{
		}

		[Token(Token = "0x6007716")]
		[Address(RVA = "0x931650", Offset = "0x930850", VA = "0x180931650", Slot = "10")]
		internal virtual void UpdateView()
		{
		}

		[Token(Token = "0x6007717")]
		[Address(RVA = "0xBE30D0", Offset = "0xBE22D0", VA = "0x180BE30D0", Slot = "11")]
		internal virtual void SetView(GameObject view, Action callback)
		{
		}

		[Token(Token = "0x6007718")]
		[Address(RVA = "0xBE2F80", Offset = "0xBE2180", VA = "0x180BE2F80", Slot = "12")]
		internal virtual void SetViewButton()
		{
		}

		[Token(Token = "0x6007719")]
		[Address(RVA = "0xBE2A20", Offset = "0xBE1C20", VA = "0x180BE2A20", Slot = "13")]
		internal virtual void DispViewButton(bool active)
		{
		}

		[Token(Token = "0x600771A")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90", Slot = "14")]
		internal virtual void SetParentSelector(Selector parentSelector)
		{
		}

		[Token(Token = "0x600771B")]
		[Address(RVA = "0xBE2A90", Offset = "0xBE1C90", VA = "0x180BE2A90", Slot = "15")]
		internal virtual List<(string, object)> GetSaveData(Dictionary<string, object> dic)
		{
			return null;
		}
	}

	[Token(Token = "0x2001329")]
	internal class ProfileEditText : ProfileEdit
	{
		[Token(Token = "0x400C010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private InputFieldWidget m_InputFieldWidget;

		[Token(Token = "0x400C011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private SelectionButton m_InputButton;

		[Token(Token = "0x400C012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly string INPUT_NAME_LABEL;

		[Token(Token = "0x400C013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly string INPUT_NAME_BTN_LABEL;

		[Token(Token = "0x600771D")]
		[Address(RVA = "0xBD57D0", Offset = "0xBD49D0", VA = "0x180BD57D0")]
		internal ProfileEditText(string clientWorkKeyName, string saveKeyName, GameObject tmpEdit, Transform parentEdit, int groupPriority, EditType editType, SideMenuType sideMenuType)
		{
		}

		[Token(Token = "0x600771E")]
		[Address(RVA = "0xBD5750", Offset = "0xBD4950", VA = "0x180BD5750", Slot = "7")]
		internal override void SetCurrent(object name)
		{
		}

		[Token(Token = "0x600771F")]
		[Address(RVA = "0xBD56C0", Offset = "0xBD48C0", VA = "0x180BD56C0", Slot = "4")]
		internal override void Init()
		{
		}

		[Token(Token = "0x6007720")]
		[Address(RVA = "0xBD5600", Offset = "0xBD4800", VA = "0x180BD5600", Slot = "8")]
		internal override void EnterFromMenu()
		{
		}
	}

	[Token(Token = "0x200132D")]
	internal class ProfileEditImage : ProfileEdit
	{
		[Token(Token = "0x200132F")]
		[CompilerGenerated]
		private sealed class _003CDelaySelect_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400C036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400C037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400C038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProfileEditImage _003C_003E4__this;

			[Token(Token = "0x400C039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int dataindex;

			[Token(Token = "0x400C03A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool selectItem;

			[Token(Token = "0x400C03B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
			public bool isIni;

			[Token(Token = "0x17001297")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007749")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001298")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600774B")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007746")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CDelaySelect_003Ed__23(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007747")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6007748")]
			[Address(RVA = "0xBFA4D0", Offset = "0xBF96D0", VA = "0x180BFA4D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600774A")]
			[Address(RVA = "0xBFA5B0", Offset = "0xBF97B0", VA = "0x180BFA5B0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400C024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected readonly string IMG_SELECTED_LABEL;

		[Token(Token = "0x400C025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected readonly string SCROLL_LABEL;

		[Token(Token = "0x400C026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected readonly string IMG_LABEL;

		[Token(Token = "0x400C027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected readonly string TXT_LABEL;

		[Token(Token = "0x400C028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected readonly string TXT_LABEL_ON;

		[Token(Token = "0x400C029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected readonly string TXT_LABEL_OFF;

		[Token(Token = "0x400C02A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x400C02B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected readonly string LOADING_LABEL;

		[Token(Token = "0x400C02C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected TextMeshProUGUI m_ItemName;

		[Token(Token = "0x400C02D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected TextGroupLoadHolder textGroupLoadHolder;

		[Token(Token = "0x400C02F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected InfinityScrollView m_InfinityScroll;

		[Token(Token = "0x400C030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected List<object> itemList;

		[Token(Token = "0x400C031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Action onItemSelectedCallBack;

		[Token(Token = "0x17001294")]
		public string itemName
		{
			[Token(Token = "0x6007733")]
			[Address(RVA = "0xBEA0D0", Offset = "0xBE92D0", VA = "0x180BEA0D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007734")]
			[Address(RVA = "0xBEA100", Offset = "0xBE9300", VA = "0x180BEA100")]
			set
			{
			}
		}

		[Token(Token = "0x17001295")]
		public int selectedItemId
		{
			[Token(Token = "0x6007735")]
			[Address(RVA = "0x3F4B30", Offset = "0x3F3D30", VA = "0x1803F4B30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007736")]
			[Address(RVA = "0x3F4B40", Offset = "0x3F3D40", VA = "0x1803F4B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17001296")]
		public Action onCompleteInitiazeCallback
		{
			[Token(Token = "0x600773E")]
			[Address(RVA = "0x9538F0", Offset = "0x952AF0", VA = "0x1809538F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600773F")]
			[Address(RVA = "0x596720", Offset = "0x595920", VA = "0x180596720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6007737")]
		[Address(RVA = "0xBE9DD0", Offset = "0xBE8FD0", VA = "0x180BE9DD0")]
		internal ProfileEditImage(string clientWorkKeyName, string saveKeyName, GameObject template, Transform parent, SideMenuType sideMenuType, List<object> itemList, TextGroupLoadHolder textGroupLoadHolder)
		{
		}

		[Token(Token = "0x6007738")]
		[Address(RVA = "0xBE9380", Offset = "0xBE8580", VA = "0x180BE9380", Slot = "4")]
		internal override void Init()
		{
		}

		[Token(Token = "0x6007739")]
		[Address(RVA = "0xBE9DB0", Offset = "0xBE8FB0", VA = "0x180BE9DB0", Slot = "5")]
		internal override void UpdateData()
		{
		}

		[Token(Token = "0x600773A")]
		[Address(RVA = "0xBE92A0", Offset = "0xBE84A0", VA = "0x180BE92A0")]
		public void FocusImmidiate(int dataindex, bool selectItem = false, bool isIni = true)
		{
		}

		[Token(Token = "0x600773B")]
		[Address(RVA = "0xBE8FD0", Offset = "0xBE81D0", VA = "0x180BE8FD0")]
		[IteratorStateMachine(typeof(_003CDelaySelect_003Ed__23))]
		private IEnumerator DelaySelect(int dataindex, bool selectItem = false, bool isIni = true)
		{
			return null;
		}

		[Token(Token = "0x600773C")]
		[Address(RVA = "0xBE9AF0", Offset = "0xBE8CF0", VA = "0x180BE9AF0", Slot = "16")]
		internal virtual void SetActiveViewItem(bool isActive)
		{
		}

		[Token(Token = "0x600773D")]
		[Address(RVA = "0xBE9640", Offset = "0xBE8840", VA = "0x180BE9640")]
		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		[Token(Token = "0x6007740")]
		[Address(RVA = "0xBE9590", Offset = "0xBE8790", VA = "0x180BE9590")]
		public void OnGsvStanby()
		{
		}

		[Token(Token = "0x6007741")]
		[Address(RVA = "0xBE9070", Offset = "0xBE8270", VA = "0x180BE9070", Slot = "8")]
		internal override void EnterFromMenu()
		{
		}
	}

	[Token(Token = "0x2001330")]
	internal class ProfileEditPickCards : ProfileEdit
	{
		[Token(Token = "0x400C03C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal DeckCaseWidget deckCaseWidget;

		[Token(Token = "0x400C03D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal bool shouldSavePicks;

		[Token(Token = "0x400C03E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int[] pickupCards;

		[Token(Token = "0x400C03F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int[] pickupDecos;

		[Token(Token = "0x400C040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int deckcaseId;

		[Token(Token = "0x400C041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int protectorId;

		[Token(Token = "0x400C042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int initialDeckcaseId;

		[Token(Token = "0x400C043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int initialProtectorId;

		[Token(Token = "0x400C044")]
		internal const int PICKUP_MAX = 3;

		[Token(Token = "0x600774C")]
		[Address(RVA = "0xBEAC80", Offset = "0xBE9E80", VA = "0x180BEAC80")]
		internal ProfileEditPickCards(string clientWorkKeyName, string saveKeyName, GameObject tmpEdit, Transform parentEdit, SideMenuType sideMenuType, int caseId, int sleeveId, Dictionary<string, object> pickCards)
		{
		}

		[Token(Token = "0x600774D")]
		[Address(RVA = "0xBEAC20", Offset = "0xBE9E20", VA = "0x180BEAC20")]
		public void UpdateDeckcase(int deckcaseId)
		{
		}

		[Token(Token = "0x600774E")]
		[Address(RVA = "0xBEAC50", Offset = "0xBE9E50", VA = "0x180BEAC50")]
		public void UpdateSleeve(int sleeveId)
		{
		}

		[Token(Token = "0x600774F")]
		[Address(RVA = "0xBEA970", Offset = "0xBE9B70", VA = "0x180BEA970")]
		public void UpdateCards(Dictionary<string, object> pickCards)
		{
		}

		[Token(Token = "0x6007750")]
		[Address(RVA = "0xBEA3D0", Offset = "0xBE95D0", VA = "0x180BEA3D0", Slot = "15")]
		internal override List<(string, object)> GetSaveData(Dictionary<string, object> dic)
		{
			return null;
		}

		[Token(Token = "0x6007751")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760", Slot = "7")]
		internal override void SetCurrent(object name)
		{
		}

		[Token(Token = "0x6007752")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
		internal override void EnterFromMenu()
		{
		}

		[Token(Token = "0x6007753")]
		[Address(RVA = "0xBEA130", Offset = "0xBE9330", VA = "0x180BEA130")]
		internal void EnterFromMenu(Dictionary<string, object> updatedDict)
		{
		}
	}

	[Token(Token = "0x2001331")]
	internal class ProfileEditTag : ProfileEdit
	{
		[Token(Token = "0x2001332")]
		private class Data
		{
			[Token(Token = "0x400C05D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool interactable;

			[Token(Token = "0x400C05E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int colorIndex;

			[Token(Token = "0x400C05F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object value;

			[Token(Token = "0x600776A")]
			[Address(RVA = "0xBD29D0", Offset = "0xBD1BD0", VA = "0x180BD29D0")]
			public Data(bool interactable, object value)
			{
			}
		}

		[Token(Token = "0x400C045")]
		private const string TEMPLATE_LABEL = "Template";

		[Token(Token = "0x400C046")]
		private const string OBJ_MYTAG_LABEL = "MyTagField";

		[Token(Token = "0x400C047")]
		private const string TXT_LABEL_ON = "TextOn";

		[Token(Token = "0x400C048")]
		private const string TXT_LABEL_OFF = "TextOff";

		[Token(Token = "0x400C049")]
		private const string TXT_TITLE = "TitleText";

		[Token(Token = "0x400C04A")]
		private const string IMG_ON_LABEL = "ImageOn";

		[Token(Token = "0x400C04B")]
		private const string IMG_OFF_LABEL = "ImageOff";

		[Token(Token = "0x400C04C")]
		private const string TAG_SET_SE = "SE_MENU_S_DECIDE_01";

		[Token(Token = "0x400C04D")]
		private const string TAG_UNSET_SE = "SE_MENU_S_DECIDE_02";

		[Token(Token = "0x400C04E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal readonly int MYTAG_EMPTY;

		[Token(Token = "0x400C04F")]
		private const int k_TagClickResCode_None = 0;

		[Token(Token = "0x400C050")]
		private const int k_TagClickResCode_Add = 1;

		[Token(Token = "0x400C051")]
		private const int k_TagClickResCode_Remove = 2;

		[Token(Token = "0x400C052")]
		private const int k_TagClickResCode_DisabledByEmpty = 3;

		[Token(Token = "0x400C053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<GameObject> myTags;

		[Token(Token = "0x400C054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<object> tagList;

		[Token(Token = "0x400C055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<Data> dataList;

		[Token(Token = "0x400C056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GameObject myTagTemplate;

		[Token(Token = "0x400C057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private GameObject myTagField;

		[Token(Token = "0x400C058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI titleText;

		[Token(Token = "0x400C059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private InfinityScrollView m_InfinityScroll;

		[Token(Token = "0x400C05A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool isReplay;

		[Token(Token = "0x400C05C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int editingTagIndex;

		[Token(Token = "0x17001299")]
		public int selectedItemId
		{
			[Token(Token = "0x6007754")]
			[Address(RVA = "0xA2A0B0", Offset = "0xA292B0", VA = "0x180A2A0B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6007755")]
			[Address(RVA = "0xA2A500", Offset = "0xA29700", VA = "0x180A2A500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700129A")]
		public int editingIdx
		{
			[Token(Token = "0x6007756")]
			[Address(RVA = "0xA2A100", Offset = "0xA29300", VA = "0x180A2A100")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6007757")]
		[Address(RVA = "0xBEE430", Offset = "0xBED630", VA = "0x180BEE430")]
		internal ProfileEditTag(string clientWorkKeyName, string saveKeyName, GameObject tmpEdit, Transform parentEdit, SideMenuType sideMenuType, List<object> tagList, bool isReplay = false)
		{
		}

		[Token(Token = "0x6007758")]
		[Address(RVA = "0xBEB930", Offset = "0xBEAB30", VA = "0x180BEB930")]
		private int IndexOfDataListByTag(int tag)
		{
			return default(int);
		}

		[Token(Token = "0x6007759")]
		[Address(RVA = "0xBEB180", Offset = "0xBEA380", VA = "0x180BEB180")]
		private bool EnableRemove()
		{
			return default(bool);
		}

		[Token(Token = "0x600775A")]
		[Address(RVA = "0xBEBA20", Offset = "0xBEAC20", VA = "0x180BEBA20", Slot = "4")]
		internal override void Init()
		{
		}

		[Token(Token = "0x600775B")]
		[Address(RVA = "0xBEC2B0", Offset = "0xBEB4B0", VA = "0x180BEC2B0")]
		private void OnCompleteInitialize()
		{
		}

		[Token(Token = "0x600775C")]
		[Address(RVA = "0xBECCC0", Offset = "0xBEBEC0", VA = "0x180BECCC0")]
		public bool SelectEditingMyTag(bool initializeSelection = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600775D")]
		[Address(RVA = "0xBECD80", Offset = "0xBEBF80", VA = "0x180BECD80", Slot = "7")]
		internal override void SetCurrent(object dictionary)
		{
		}

		[Token(Token = "0x600775E")]
		[Address(RVA = "0xBED570", Offset = "0xBEC770", VA = "0x180BED570")]
		private SelectionButton TryGetSideMyTagButton(int selfIdx, PadInputDirection direction)
		{
			return null;
		}

		[Token(Token = "0x600775F")]
		[Address(RVA = "0xBEB270", Offset = "0xBEA470", VA = "0x180BEB270", Slot = "8")]
		internal override void EnterFromMenu()
		{
		}

		[Token(Token = "0x6007760")]
		[Address(RVA = "0xBEB310", Offset = "0xBEA510", VA = "0x180BEB310", Slot = "15")]
		internal override List<(string, object)> GetSaveData(Dictionary<string, object> dic)
		{
			return null;
		}

		[Token(Token = "0x6007761")]
		[Address(RVA = "0xBEC600", Offset = "0xBEB800", VA = "0x180BEC600")]
		private void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		[Token(Token = "0x6007762")]
		[Address(RVA = "0xBEBD90", Offset = "0xBEAF90", VA = "0x180BEBD90")]
		private int OnClickTagListItem(int dataindex)
		{
			return default(int);
		}

		[Token(Token = "0x6007763")]
		[Address(RVA = "0xBEC4B0", Offset = "0xBEB6B0", VA = "0x180BEC4B0")]
		private void OnGsvStanby()
		{
		}

		[Token(Token = "0x6007764")]
		[Address(RVA = "0xBEB810", Offset = "0xBEAA10", VA = "0x180BEB810")]
		private int IndexOfCurrentTag(object tag)
		{
			return default(int);
		}

		[Token(Token = "0x6007765")]
		[Address(RVA = "0xBED8B0", Offset = "0xBECAB0", VA = "0x180BED8B0")]
		private void UpdateMytag()
		{
		}

		[Token(Token = "0x6007766")]
		[Address(RVA = "0xBEBCF0", Offset = "0xBEAEF0", VA = "0x180BEBCF0")]
		private void OnClickMyTag(int tagNo, bool select = true)
		{
		}

		[Token(Token = "0x6007767")]
		[Address(RVA = "0xBEE180", Offset = "0xBED380", VA = "0x180BEE180")]
		private void UpdateTagScroll()
		{
		}

		[Token(Token = "0x6007768")]
		[Address(RVA = "0xBED760", Offset = "0xBEC960", VA = "0x180BED760")]
		private void UpdateMyTagImage()
		{
		}
	}

	[Token(Token = "0x400BF29")]
	private const string k_ELabelTitleArea = "TitleArea";

	[Token(Token = "0x400BF2A")]
	private const string k_ELabelFooterArea = "FooterArea";

	[Token(Token = "0x400BF2B")]
	private const string k_ELabelRootSideMenu = "RootSideMenu";

	[Token(Token = "0x400BF2C")]
	private const string k_Args_type = "type";

	[Token(Token = "0x400BF2D")]
	private const string k_Args_identifierId = "identifierId";

	[Token(Token = "0x400BF2E")]
	private const string k_Args_fix = "fix";

	[Token(Token = "0x400BF2F")]
	private const string k_Args_fixPick = "fixPick";

	[Token(Token = "0x400BF30")]
	private const string k_Args_deckID = "deckID";

	[Token(Token = "0x400BF31")]
	public const string k_Args_sideMenuType = "sideMenuType";

	[Token(Token = "0x400BF32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private FooterArea m_FooterArea;

	[Token(Token = "0x400BF33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private TitleArea m_TitleArea;

	[Token(Token = "0x400BF34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private SideMenu m_SideMenu;

	[Token(Token = "0x400BF35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string ROOT_EDIT_LABEL;

	[Token(Token = "0x400BF36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_VIEW_LABEL;

	[Token(Token = "0x400BF37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string TMP_TXT_LABEL;

	[Token(Token = "0x400BF38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string TMP_IMG_LABEL;

	[Token(Token = "0x400BF39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string TMP_HOME_WP_LABEL;

	[Token(Token = "0x400BF3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string TMP_RESIZE_IMG_LABEL;

	[Token(Token = "0x400BF3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string TMP_TAG_LABEL;

	[Token(Token = "0x400BF3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string TMP_PICK_LABEL;

	[Token(Token = "0x400BF3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string TMP_CARDFILE_LABEL;

	[Token(Token = "0x400BF3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly string IMG_LABEL;

	[Token(Token = "0x400BF3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly string TEXT_ITEM_NAME_LABEL;

	[Token(Token = "0x400BF40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private readonly string MATE_TRANSFORM_SETTING_PATH;

	[Token(Token = "0x400BF41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private readonly string OBJ_MATE_LABEL;

	[Token(Token = "0x400BF42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private bool isSaved;

	[Token(Token = "0x400BF43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
	private bool isFixedAccsessory;

	[Token(Token = "0x400BF44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
	private bool isFixedPickCards;

	[Token(Token = "0x400BF45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
	private bool isSkipProfileCard;

	[Token(Token = "0x400BF46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private ProfileEdit currentEditing;

	[Token(Token = "0x400BF47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private List<ProfileEdit> profileEdits;

	[Token(Token = "0x400BF48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private EditType editType;

	[Token(Token = "0x400BF49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private int deckID;

	[Token(Token = "0x400BF4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private int identifierID;

	[Token(Token = "0x400BF4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private int defaultTabIdx;

	[Token(Token = "0x400BF4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private int wcsIndex;

	[Token(Token = "0x400BF4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private SideMenuType defaultSideMenuType;

	[Token(Token = "0x400BF4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int myId;

	[Token(Token = "0x400BF4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private int myDeckCaseId;

	[Token(Token = "0x400BF50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private int rivalDeckCaseId;

	[Token(Token = "0x400BF51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private long did;

	[Token(Token = "0x400BF52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private string myDeckName;

	[Token(Token = "0x400BF53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private string rivalDeckName;

	[Token(Token = "0x400BF54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private Dictionary<string, object> myMainCards;

	[Token(Token = "0x400BF55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Dictionary<string, object> myExtraCards;

	[Token(Token = "0x400BF56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private Dictionary<string, object> rivalMainCards;

	[Token(Token = "0x400BF57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Dictionary<string, object> rivalExtraCards;

	[Token(Token = "0x400BF58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private GameObject rootEdit;

	[Token(Token = "0x400BF59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private GameObject rootView;

	[Token(Token = "0x400BF5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private GameObject tmpEditTxt;

	[Token(Token = "0x400BF5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private GameObject tmpEditImg;

	[Token(Token = "0x400BF5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private GameObject tmpEditHomeWP;

	[Token(Token = "0x400BF5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private GameObject tmpEditResizeImg;

	[Token(Token = "0x400BF5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private GameObject tmpEditTag;

	[Token(Token = "0x400BF5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private GameObject tmpEditPick;

	[Token(Token = "0x400BF60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private GameObject tmpEditCardFile;

	[Token(Token = "0x400BF61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private ProfileCard profileCard;

	[Token(Token = "0x400BF62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private TextMeshProUGUI m_CurrentItemNameText;

	[Token(Token = "0x400BF63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private string m_CurrentItemName;

	[Token(Token = "0x400BF64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private ProfileEditPickCards m_PEPC;

	[Token(Token = "0x400BF65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private ProfileEditPickCards m_PEPC_My;

	[Token(Token = "0x400BF66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private ProfileEditPickCards m_PEPC_Rival;

	[Token(Token = "0x400BF67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	private readonly int noneSelectAvatorId;

	[Token(Token = "0x400BF68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	private int m_ProfileAvatorId;

	[Token(Token = "0x400BF69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	private int charaId;

	[Token(Token = "0x400BF6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	private Character2D chara;

	[Token(Token = "0x400BF6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	private MateTransformSetting m_ModelLocateSettings;

	[Token(Token = "0x400BF6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	private DefinitionSetting matchingDefine;

	[Token(Token = "0x17001274")]
	public string currentItemName
	{
		[Token(Token = "0x6007660")]
		[Address(RVA = "0x49BD00", Offset = "0x49AF00", VA = "0x18049BD00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007661")]
		[Address(RVA = "0xBE2950", Offset = "0xBE1B50", VA = "0x180BE2950")]
		set
		{
		}
	}

	[Token(Token = "0x17001275")]
	private static bool isMobile
	{
		[Token(Token = "0x6007662")]
		[Address(RVA = "0xBE27C0", Offset = "0xBE19C0", VA = "0x180BE27C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001276")]
	public static bool isGamePad
	{
		[Token(Token = "0x6007663")]
		[Address(RVA = "0xBE2730", Offset = "0xBE1930", VA = "0x180BE2730")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001277")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007664")]
		[Address(RVA = "0xBE2810", Offset = "0xBE1A10", VA = "0x180BE2810", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007665")]
	[Address(RVA = "0xBD5F70", Offset = "0xBD5170", VA = "0x180BD5F70")]
	public static Dictionary<string, object> GetArgsUsedForDeck(EditType type, int identifierId, bool isFixedAccessories = false, bool isFixedPickCards = false, int deckId = -1, SideMenuType sideMenuType = SideMenuType.NONE)
	{
		return null;
	}

	[Token(Token = "0x6007666")]
	[Address(RVA = "0xBE0010", Offset = "0xBDF210", VA = "0x180BE0010")]
	public static void Open([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007667")]
	[Address(RVA = "0xBDD170", Offset = "0xBDC370", VA = "0x180BDD170", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007668")]
	[Address(RVA = "0xBDD900", Offset = "0xBDCB00", VA = "0x180BDD900", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007669")]
	[Address(RVA = "0xBDD9B0", Offset = "0xBDCBB0", VA = "0x180BDD9B0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600766A")]
	[Address(RVA = "0xBDD930", Offset = "0xBDCB30", VA = "0x180BDD930", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x600766B")]
	[Address(RVA = "0xBE0120", Offset = "0xBDF320", VA = "0x180BE0120")]
	private void SaveEdit([Optional] UnityAction callback)
	{
	}

	[Token(Token = "0x600766C")]
	[Address(RVA = "0xBD5B80", Offset = "0xBD4D80", VA = "0x180BD5B80")]
	private Dictionary<string, object> CheckUpdatedProfile()
	{
		return null;
	}

	[Token(Token = "0x600766D")]
	[Address(RVA = "0xBE1CD0", Offset = "0xBE0ED0", VA = "0x180BE1CD0")]
	private void UpdateSetAccessory(List<int> list)
	{
	}

	[Token(Token = "0x600766E")]
	[Address(RVA = "0xBD97E0", Offset = "0xBD89E0", VA = "0x180BD97E0")]
	private void InitEdit()
	{
	}

	[Token(Token = "0x600766F")]
	[Address(RVA = "0xBE0780", Offset = "0xBDF980", VA = "0x180BE0780")]
	private void SetActiveMenu(ProfileEdit profileEdit)
	{
	}

	[Token(Token = "0x6007670")]
	[Address(RVA = "0xBD5E60", Offset = "0xBD5060", VA = "0x180BD5E60")]
	private void EnterMenu(ProfileEdit profileEdit)
	{
	}

	[Token(Token = "0x6007671")]
	[Address(RVA = "0xBDB270", Offset = "0xBDA470", VA = "0x180BDB270")]
	private void InitUserProfileEdit(EditType editType)
	{
	}

	[Token(Token = "0x6007672")]
	[Address(RVA = "0xBD6DC0", Offset = "0xBD5FC0", VA = "0x180BD6DC0")]
	private void InitAccessoryEdit()
	{
	}

	[Token(Token = "0x6007673")]
	[Address(RVA = "0xBDA680", Offset = "0xBD9880", VA = "0x180BDA680")]
	private void InitReplayEdit()
	{
	}

	[Token(Token = "0x6007674")]
	[Address(RVA = "0xBDA000", Offset = "0xBD9200", VA = "0x180BDA000")]
	private void InitMateSettings(ElementObjectManager eom, ProfileAvatarEdit pei)
	{
	}

	[Token(Token = "0x6007675")]
	[Address(RVA = "0xBE0080", Offset = "0xBDF280", VA = "0x180BE0080")]
	private void PlayMateMotion()
	{
	}

	[Token(Token = "0x6007676")]
	[Address(RVA = "0xBE17E0", Offset = "0xBE09E0", VA = "0x180BE17E0")]
	private void SwitchTagScrollContent(string label)
	{
	}

	[Token(Token = "0x6007677")]
	[Address(RVA = "0xBDEEE0", Offset = "0xBDE0E0", VA = "0x180BDEEE0")]
	private void OpenPickupSelectionBrowserForReplay(bool isPlayer, int myId, long did, Dictionary<string, object> pickCards)
	{
	}

	[Token(Token = "0x6007678")]
	[Address(RVA = "0xBDF1A0", Offset = "0xBDE3A0", VA = "0x180BDF1A0")]
	private void OpenPickupSelectionBrowser()
	{
	}

	[Token(Token = "0x6007679")]
	[Address(RVA = "0xBDE150", Offset = "0xBDD350", VA = "0x180BDE150")]
	private void OpenFieldPreview()
	{
	}

	[Token(Token = "0x600767A")]
	[Address(RVA = "0xBDE620", Offset = "0xBDD820", VA = "0x180BDE620")]
	private void OpenItemPreview()
	{
	}

	[Token(Token = "0x600767B")]
	[Address(RVA = "0xBD6AC0", Offset = "0xBD5CC0", VA = "0x180BD6AC0")]
	private bool GetHasSetAccessoryItem(int itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x600767C")]
	[Address(RVA = "0xBDD160", Offset = "0xBDC360", VA = "0x180BDD160")]
	private bool IsEdittingAccessorry()
	{
		return default(bool);
	}

	[Token(Token = "0x600767D")]
	[Address(RVA = "0xBD61A0", Offset = "0xBD53A0", VA = "0x180BD61A0")]
	private Dictionary<string, object> GetEditDic(EditType type)
	{
		return null;
	}

	[Token(Token = "0x600767E")]
	[Address(RVA = "0xBD65E0", Offset = "0xBD57E0", VA = "0x180BD65E0")]
	private Dictionary<string, object> GetEditPickCards(EditType type, bool isMyPcard = false)
	{
		return null;
	}

	[Token(Token = "0x600767F")]
	[Address(RVA = "0xBE2350", Offset = "0xBE1550", VA = "0x180BE2350")]
	public ProfileEditViewController()
	{
	}
}
