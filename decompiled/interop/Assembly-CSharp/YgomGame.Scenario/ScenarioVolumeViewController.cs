using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Scenario;

[Token(Token = "0x2000AD2")]
public class ScenarioVolumeViewController : BaseMenuViewController
{
	[Token(Token = "0x2000AD3")]
	public class VolumeSliderInfo
	{
		[Token(Token = "0x40093F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float initVolume;

		[Token(Token = "0x40093F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int selectPriority;

		[Token(Token = "0x40093F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40093F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<float> onValueChanged;

		[Token(Token = "0x40093F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float min;

		[Token(Token = "0x40093F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float max;

		[Token(Token = "0x40093F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onValueConfirm;

		[Token(Token = "0x600429D")]
		[Address(RVA = "0x8AB6E0", Offset = "0x8AA8E0", VA = "0x1808AB6E0")]
		public VolumeSliderInfo(float initVolume, int selectPriority, string text, Action<float> onValueChanged, float min = 0f, float max = 1f, [Optional] Action onValueConfirm)
		{
		}
	}

	[Token(Token = "0x40093E1")]
	private const string k_PrefPath = "Scenario/ScenarioVolume";

	[Token(Token = "0x40093E2")]
	private const string KEY_PUSHED = "VOLUME_PUSHED";

	[Token(Token = "0x40093E3")]
	private const string KEY_POPED = "VOLUME_POPED";

	[Token(Token = "0x40093E4")]
	private const string KEY_MUTED = "VOLUME_MUTED";

	[Token(Token = "0x40093E5")]
	private const string KEY_SLIDERINFO = "VOLUME_SLIDERINFO";

	[Token(Token = "0x40093E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_LabelTemplate;

	[Token(Token = "0x40093E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_LabelSlider;

	[Token(Token = "0x40093E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_LabelCancel;

	[Token(Token = "0x40093E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Action m_OnPushed;

	[Token(Token = "0x40093EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Action m_OnPoped;

	[Token(Token = "0x40093EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Action<bool> m_OnMuted;

	[Token(Token = "0x40093EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private VolumeSliderInfo[] m_Info;

	[Token(Token = "0x40093ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<Slider> m_Sliders;

	[Token(Token = "0x40093EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private List<SelectionButton> m_SliderButtons;

	[Token(Token = "0x40093EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private SelectionButton m_CancelButton;

	[Token(Token = "0x40093F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool m_IsMute;

	[Token(Token = "0x40093F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	private bool m_IsHideing;

	[Token(Token = "0x6004294")]
	[Address(RVA = "0x8A86F0", Offset = "0x8A78F0", VA = "0x1808A86F0")]
	public static void Open(Action onPushed, Action onPoped, Action<bool> onMuted, params VolumeSliderInfo[] info)
	{
	}

	[Token(Token = "0x6004295")]
	[Address(RVA = "0x8A7A20", Offset = "0x8A6C20", VA = "0x1808A7A20", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6004296")]
	[Address(RVA = "0x8A7C70", Offset = "0x8A6E70", VA = "0x1808A7C70", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6004297")]
	[Address(RVA = "0x8A7CB0", Offset = "0x8A6EB0", VA = "0x1808A7CB0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6004298")]
	[Address(RVA = "0x8A7860", Offset = "0x8A6A60", VA = "0x1808A7860")]
	private bool IsMute()
	{
		return default(bool);
	}

	[Token(Token = "0x6004299")]
	[Address(RVA = "0x8A73E0", Offset = "0x8A65E0", VA = "0x1808A73E0")]
	public void HideView()
	{
	}

	[Token(Token = "0x600429A")]
	[Address(RVA = "0x8A79C0", Offset = "0x8A6BC0", VA = "0x1808A79C0")]
	public static bool IsMute(params VolumeSliderInfo[] infos)
	{
		return default(bool);
	}

	[Token(Token = "0x600429B")]
	[Address(RVA = "0x8A8870", Offset = "0x8A7A70", VA = "0x1808A8870")]
	public ScenarioVolumeViewController()
	{
	}
}
