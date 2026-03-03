using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.LocalizedFont;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000612")]
public class InputFieldWidget : ElementWidgetBehaviourBase<InputFieldWidget>, ILocalizedFontOwner
{
	[Token(Token = "0x4001D25")]
	private const string k_ELabelInputField = "InputField";

	[Token(Token = "0x4001D26")]
	private const string k_ELabelTMPInputField = "InputFieldTMP";

	[Token(Token = "0x4001D27")]
	private const string k_ELabelInputButton = "InputButton";

	[Token(Token = "0x4001D28")]
	private const string k_ELabelClearButton = "ClearButton";

	[Token(Token = "0x4001D29")]
	private const string k_ELabelClearButtonRoot = "ClearButtonRoot";

	[Token(Token = "0x4001D2A")]
	private const string k_ELabelEditingCover = "EditingCover";

	[Token(Token = "0x4001D2B")]
	private const string k_ELabelEditingMask = "Mask";

	[Token(Token = "0x4001D2C")]
	private const string k_ELabelShortcutIconGroup = "ShortcutIconGroup";

	[Token(Token = "0x4001D2D")]
	private const string k_ELabelInactiveButtonRoot = "InactivateButtonRoot";

	[Token(Token = "0x4001D2E")]
	private const string k_ELabelInactiveButton = "InactivateButton";

	[Token(Token = "0x4001D2F")]
	private const string k_TweenToEditOn = "ToEditOn";

	[Token(Token = "0x4001D30")]
	private const string k_TweenToEditOff = "ToEditOff";

	[Token(Token = "0x4001D31")]
	[FieldOffset(Offset = "0x28")]
	private InputFieldWrapper inputFieldWrapper;

	[Token(Token = "0x4001D32")]
	[FieldOffset(Offset = "0x30")]
	private ExtendedInputField m_InputFieldCache;

	[Token(Token = "0x4001D33")]
	[FieldOffset(Offset = "0x38")]
	private TMP_InputField m_TMPInputFieldCache;

	[Token(Token = "0x4001D34")]
	[FieldOffset(Offset = "0x40")]
	private SelectionButton m_InputButtonCache;

	[Token(Token = "0x4001D35")]
	[FieldOffset(Offset = "0x48")]
	private Button m_ClearButtonCache;

	[Token(Token = "0x4001D36")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_EditingCoverCache;

	[Token(Token = "0x4001D37")]
	[FieldOffset(Offset = "0x58")]
	private RectTransform m_MaskCache;

	[Token(Token = "0x4001D38")]
	[FieldOffset(Offset = "0x60")]
	private DeviceIcon m_ClearButtonRootCache;

	[Token(Token = "0x4001D39")]
	[FieldOffset(Offset = "0x68")]
	private DeviceIcon m_ShortcutIconGroup;

	[Token(Token = "0x4001D3A")]
	[FieldOffset(Offset = "0x70")]
	private Selector m_InactivateButtonSelectorCache;

	[Token(Token = "0x4001D3B")]
	[FieldOffset(Offset = "0x78")]
	private SelectionButton m_InactivateButtonCache;

	[Token(Token = "0x4001D3C")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsEditEndFrame;

	[Token(Token = "0x4001D3D")]
	[FieldOffset(Offset = "0x81")]
	private bool m_requestSubmit;

	[Token(Token = "0x4001D3E")]
	[FieldOffset(Offset = "0x82")]
	private bool m_inputFieldActivated;

	[Token(Token = "0x4001D3F")]
	[FieldOffset(Offset = "0x83")]
	[SerializeField]
	private bool _submitOnClickOuter;

	[Token(Token = "0x4001D40")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public TMP_FontAsset fontAsset;

	[Token(Token = "0x4001D41")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private LocalizedFontSettingsBase.FontType m_localizedFontType;

	[Token(Token = "0x4001D42")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	private int m_localizedFontMaterialIndex;

	[Token(Token = "0x4001D43")]
	[FieldOffset(Offset = "0x98")]
	public readonly InputField.SubmitEvent onSubmitEdit;

	[Token(Token = "0x4001D44")]
	[FieldOffset(Offset = "0xA0")]
	public readonly InputField.OnChangeEvent onFilterdValueChanged;

	[Token(Token = "0x4001D45")]
	[FieldOffset(Offset = "0xA8")]
	public readonly UnityEvent onBeginEdit;

	[Token(Token = "0x4001D46")]
	[FieldOffset(Offset = "0xB0")]
	public readonly UnityEvent onEndEdit;

	[Token(Token = "0x170004DC")]
	private bool useTMP
	{
		[Token(Token = "0x60027C6")]
		[Address(RVA = "0x6ABFD0", Offset = "0x6AB1D0", VA = "0x1806ABFD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170004DD")]
	public bool interactable
	{
		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x6ABC70", Offset = "0x6AAE70", VA = "0x1806ABC70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x6AC060", Offset = "0x6AB260", VA = "0x1806AC060")]
		set
		{
		}
	}

	[Token(Token = "0x170004DE")]
	public bool submitOnClickOuter
	{
		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x6ABE80", Offset = "0x6AB080", VA = "0x1806ABE80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x6AC1F0", Offset = "0x6AB3F0", VA = "0x1806AC1F0")]
		set
		{
		}
	}

	[Token(Token = "0x170004DF")]
	public LocalizedFontSettingsBase.FontType localizedFontType
	{
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x6ABCD0", Offset = "0x6AAED0", VA = "0x1806ABCD0", Slot = "5")]
		get
		{
			return default(LocalizedFontSettingsBase.FontType);
		}
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x6AC1E0", Offset = "0x6AB3E0", VA = "0x1806AC1E0", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x170004E0")]
	public int localizedFontMaterialIndex
	{
		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x6ABCC0", Offset = "0x6AAEC0", VA = "0x1806ABCC0", Slot = "7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x56CBF0", Offset = "0x56BDF0", VA = "0x18056CBF0", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x170004E1")]
	public InputFieldWrapper inputField
	{
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x6ABA00", Offset = "0x6AAC00", VA = "0x1806ABA00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E2")]
	private ExtendedInputField uInputField
	{
		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x6ABF00", Offset = "0x6AB100", VA = "0x1806ABF00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E3")]
	private TMP_InputField TMPInputField
	{
		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x6AB460", Offset = "0x6AA660", VA = "0x1806AB460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E4")]
	public SelectionButton inputButton
	{
		[Token(Token = "0x60027D2")]
		[Address(RVA = "0x6AB930", Offset = "0x6AAB30", VA = "0x1806AB930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E5")]
	public GameObject editingCover
	{
		[Token(Token = "0x60027D3")]
		[Address(RVA = "0x6AB6D0", Offset = "0x6AA8D0", VA = "0x1806AB6D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E6")]
	public Button clearButton
	{
		[Token(Token = "0x60027D4")]
		[Address(RVA = "0x6AB600", Offset = "0x6AA800", VA = "0x1806AB600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E7")]
	public RectTransform mask
	{
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x6ABCE0", Offset = "0x6AAEE0", VA = "0x1806ABCE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E8")]
	public DeviceIcon clearButtonRoot
	{
		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x6AB530", Offset = "0x6AA730", VA = "0x1806AB530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004E9")]
	public DeviceIcon shortcutIconGroup
	{
		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x6ABDB0", Offset = "0x6AAFB0", VA = "0x1806ABDB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EA")]
	public Selector inactivateButtonSelector
	{
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x6AB790", Offset = "0x6AA990", VA = "0x1806AB790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EB")]
	public SelectionButton inactivateButton
	{
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x6AB860", Offset = "0x6AAA60", VA = "0x1806AB860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004EC")]
	public string text
	{
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x6ABE90", Offset = "0x6AB090", VA = "0x1806ABE90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x6AC200", Offset = "0x6AB400", VA = "0x1806AC200")]
		set
		{
		}
	}

	[Token(Token = "0x60027DC")]
	[Address(RVA = "0x6A98C0", Offset = "0x6A8AC0", VA = "0x1806A98C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60027DD")]
	[Address(RVA = "0x6AB070", Offset = "0x6AA270", VA = "0x1806AB070", Slot = "9")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60027DE")]
	[Address(RVA = "0x6AA360", Offset = "0x6A9560", VA = "0x1806AA360")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60027DF")]
	[Address(RVA = "0x6AA280", Offset = "0x6A9480", VA = "0x1806AA280")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60027E0")]
	[Address(RVA = "0x6AA0D0", Offset = "0x6A92D0", VA = "0x1806AA0D0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60027E1")]
	[Address(RVA = "0x6AA260", Offset = "0x6A9460", VA = "0x1806AA260")]
	private void OnClick()
	{
	}

	[Token(Token = "0x60027E2")]
	[Address(RVA = "0x6AA150", Offset = "0x6A9350", VA = "0x1806AA150")]
	private void OnClickClear()
	{
	}

	[Token(Token = "0x60027E3")]
	[Address(RVA = "0x6AA630", Offset = "0x6A9830", VA = "0x1806AA630")]
	private void OnValueChanged(string input)
	{
	}

	[Token(Token = "0x60027E4")]
	[Address(RVA = "0x6AA450", Offset = "0x6A9650", VA = "0x1806AA450")]
	private void OnEndEdit(string res)
	{
	}

	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x6A95C0", Offset = "0x6A87C0", VA = "0x1806A95C0")]
	public void ActivateInputField()
	{
	}

	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x6A9EB0", Offset = "0x6A90B0", VA = "0x1806A9EB0")]
	public void InactivateInputField()
	{
	}

	[Token(Token = "0x60027E7")]
	[Address(RVA = "0x6AB110", Offset = "0x6AA310", VA = "0x1806AB110")]
	private void UpdateClearButton()
	{
	}

	[Token(Token = "0x60027E8")]
	[Address(RVA = "0x6AAC80", Offset = "0x6A9E80", VA = "0x1806AAC80")]
	private void ResizeClearButtonWidth()
	{
	}

	[Token(Token = "0x60027E9")]
	[Address(RVA = "0x6AABC0", Offset = "0x6A9DC0", VA = "0x1806AABC0")]
	private void PlayToEditOn()
	{
	}

	[Token(Token = "0x60027EA")]
	[Address(RVA = "0x6AAB00", Offset = "0x6A9D00", VA = "0x1806AAB00")]
	private void PlayToEditOff()
	{
	}

	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x6AAF90", Offset = "0x6AA190", VA = "0x1806AAF90")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x60027EC")]
	[Address(RVA = "0x6A9830", Offset = "0x6A8A30", VA = "0x1806A9830")]
	private void Awake_Platform()
	{
	}

	[Token(Token = "0x60027ED")]
	[Address(RVA = "0x6AA8C0", Offset = "0x6A9AC0", VA = "0x1806AA8C0")]
	protected void OpenSoftwareKeyboard()
	{
	}

	[Token(Token = "0x60027EE")]
	[Address(RVA = "0x6AA4D0", Offset = "0x6A96D0", VA = "0x1806AA4D0")]
	private void OnSteamSoftwareKeyboardCallback(bool result, string inputtext)
	{
	}

	[Token(Token = "0x60027EF")]
	[Address(RVA = "0x6AB330", Offset = "0x6AA530", VA = "0x1806AB330")]
	public InputFieldWidget()
	{
	}
}
