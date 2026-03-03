using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001A68")]
public class PhaseSelect3D : MonoBehaviour
{
	[Token(Token = "0x400F32A")]
	private const string PATH_BUTTON = "Duel/BG/Timer/Timer_c001/PhaseButton_c001";

	[Token(Token = "0x400F32B")]
	private const string PATH_BUTTON_SP = "Duel/BG/Timer/Timer_013/PhaseButton_013";

	[Token(Token = "0x400F32C")]
	private const string LABEL_EO_TEXTPHASE = "Text";

	[Token(Token = "0x400F32D")]
	private const string LABEL_EO_TEXTSTEP = "Text02";

	[Token(Token = "0x400F32E")]
	private const string LABEL_EO_TEXTTURN = "Text03";

	[Token(Token = "0x400F32F")]
	private const string LABEL_EO_BUTTON = "Button";

	[Token(Token = "0x400F330")]
	private const string LABEL_EO_PLAYERBASE = "PlayerBase";

	[Token(Token = "0x400F331")]
	private const string LABEL_EO_PLAYERSURFACE = "PlayerSurface";

	[Token(Token = "0x400F332")]
	private const string LABEL_EO_OPPONENTBASE = "OpponentBase";

	[Token(Token = "0x400F333")]
	private const string LABEL_EO_OPPONENTSURFACE = "OpponentSurface";

	[Token(Token = "0x400F334")]
	private const string LABEL_EO_GUIDEFAR = "PlayableGuide_far";

	[Token(Token = "0x400F335")]
	private const string LABEL_EO_GUIDENEAR = "PlayableGuide_near";

	[Token(Token = "0x400F336")]
	private const string LABEL_EO_PADICON = "Position2";

	[Token(Token = "0x400F337")]
	private const string LABEL_EO_POSITION = "Position";

	[Token(Token = "0x400F338")]
	private const string LABEL_EO_HINTEFFECT = "HintEffect";

	[Token(Token = "0x400F339")]
	private const string LABEL_TWEEN_TEXTZOOMOUT = "TextZoomOut";

	[Token(Token = "0x400F33A")]
	private const string LABEL_TWEEN_SWITCHTURN0 = "SwitchTurn0";

	[Token(Token = "0x400F33B")]
	private const string LABEL_TWEEN_SWITCHTURN1 = "SwitchTurn1";

	[Token(Token = "0x400F33C")]
	private const string LABEL_TWEEN_MOUSEOVERIN = "MouseOverIn";

	[Token(Token = "0x400F33D")]
	private const string LABEL_TWEEN_MOUSEOVEROUT = "MouseOverOut";

	[Token(Token = "0x400F33E")]
	private const string LABEL_TWEEN_PRESSBUTTONIN = "PressButtonIn";

	[Token(Token = "0x400F33F")]
	private const string LABEL_TWEEN_PRESSBUTTONOUT = "PressButtonOut";

	[Token(Token = "0x400F340")]
	private const string LABEL_TWEEN_ACTIVEON = "ActiveOn";

	[Token(Token = "0x400F341")]
	private const string LABEL_TWEEN_ACTIVEOFF = "ActiveOff";

	[Token(Token = "0x400F342")]
	private const string LABEL_SHADER_SWITCHTURN = "_SwitchTurn";

	[Token(Token = "0x400F343")]
	private const string LABEL_SHADER_ACTIVE = "_Active";

	[Token(Token = "0x400F344")]
	private const string LABEL_TEXT_START = "S";

	[Token(Token = "0x400F345")]
	private const string LABEL_TEXT_DAMAGE1 = "D1";

	[Token(Token = "0x400F346")]
	private const string LABEL_TEXT_DAMAGE2 = "D2";

	[Token(Token = "0x400F347")]
	private const string LABEL_TEXT_DAMAGE3 = "D3";

	[Token(Token = "0x400F348")]
	private const string LABEL_TEXT_DAMAGE4 = "D4";

	[Token(Token = "0x400F349")]
	private const string LABEL_TEXT_DAMAGE5 = "D5";

	[Token(Token = "0x400F34A")]
	private const string LABEL_TEXT_END = "E";

	[Token(Token = "0x400F34B")]
	private const string PATH_PHASECHANGE_DP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelDrawPhase_near";

	[Token(Token = "0x400F34C")]
	private const string PATH_PHASECHANGE_DP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelDrawPhase_far";

	[Token(Token = "0x400F34D")]
	private const string PATH_PHASECHANGE_SP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelStanbyPhase_near";

	[Token(Token = "0x400F34E")]
	private const string PATH_PHASECHANGE_SP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelStanbyPhase_far";

	[Token(Token = "0x400F34F")]
	private const string PATH_PHASECHANGE_MP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelMain01Phase_near";

	[Token(Token = "0x400F350")]
	private const string PATH_PHASECHANGE_MP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelMain01Phase_far";

	[Token(Token = "0x400F351")]
	private const string PATH_PHASECHANGE_BP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelBattlePhase_near";

	[Token(Token = "0x400F352")]
	private const string PATH_PHASECHANGE_BP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelBattlePhase_far";

	[Token(Token = "0x400F353")]
	private const string PATH_PHASECHANGE_M2P0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelMain02Phase_near";

	[Token(Token = "0x400F354")]
	private const string PATH_PHASECHANGE_M2P1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelMain02Phase_far";

	[Token(Token = "0x400F355")]
	private const string PATH_PHASECHANGE_EP0 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelEndPhase_near";

	[Token(Token = "0x400F356")]
	private const string PATH_PHASECHANGE_EP1 = "Duel/Timeline/Duel/Universal/DuelPhase/ACDuelEndPhase_far";

	[Token(Token = "0x400F357")]
	private const string TAG_TURN = "Turn";

	[Token(Token = "0x400F358")]
	private const string TAG_PHASE = "Phase";

	[Token(Token = "0x400F359")]
	private const string TAG_BATTLE_NEAR = "BattlePhase_near";

	[Token(Token = "0x400F35A")]
	private const string TAG_BATTLE_FAR = "BattlePhase_far";

	[Token(Token = "0x400F35B")]
	[FieldOffset(Offset = "0x20")]
	public bool duelStart;

	[Token(Token = "0x400F35C")]
	[FieldOffset(Offset = "0x21")]
	public bool duelEnd;

	[Token(Token = "0x400F35D")]
	[FieldOffset(Offset = "0x28")]
	public UnityAction onPhaseChangedCallBack;

	[Token(Token = "0x400F35E")]
	[FieldOffset(Offset = "0x30")]
	public UnityAction<bool> onChangeActive;

	[Token(Token = "0x400F35F")]
	[FieldOffset(Offset = "0x38")]
	private ElementObjectManager m_RootManager;

	[Token(Token = "0x400F360")]
	[FieldOffset(Offset = "0x40")]
	private SelectionButton m_Button;

	[Token(Token = "0x400F361")]
	[FieldOffset(Offset = "0x48")]
	private Tween m_TweenSurface0;

	[Token(Token = "0x400F362")]
	[FieldOffset(Offset = "0x50")]
	private Tween m_TweenBase0;

	[Token(Token = "0x400F363")]
	[FieldOffset(Offset = "0x58")]
	private Tween m_TweenSurface1;

	[Token(Token = "0x400F364")]
	[FieldOffset(Offset = "0x60")]
	private Tween m_TweenBase1;

	[Token(Token = "0x400F365")]
	[FieldOffset(Offset = "0x68")]
	private Tween m_TweenText;

	[Token(Token = "0x400F366")]
	[FieldOffset(Offset = "0x70")]
	private MeshRenderer m_RendererSurface0;

	[Token(Token = "0x400F367")]
	[FieldOffset(Offset = "0x78")]
	private MeshRenderer m_RendererSurface1;

	[Token(Token = "0x400F368")]
	[FieldOffset(Offset = "0x80")]
	private MeshRenderer m_RendererBase0;

	[Token(Token = "0x400F369")]
	[FieldOffset(Offset = "0x88")]
	private MeshRenderer m_RendererBase1;

	[Token(Token = "0x400F36A")]
	[FieldOffset(Offset = "0x90")]
	private ExtendedTextMeshPro m_PhaseName;

	[Token(Token = "0x400F36B")]
	[FieldOffset(Offset = "0x98")]
	private ExtendedTextMeshPro m_StepName;

	[Token(Token = "0x400F36C")]
	[FieldOffset(Offset = "0xA0")]
	private ExtendedTextMeshPro m_TurnNum;

	[Token(Token = "0x400F36D")]
	[FieldOffset(Offset = "0xA8")]
	private Transform m_PadIcon;

	[Token(Token = "0x400F36E")]
	[FieldOffset(Offset = "0xB0")]
	private Transform m_Position;

	[Token(Token = "0x400F36F")]
	[FieldOffset(Offset = "0xB8")]
	private Transform m_HintEffect;

	[Token(Token = "0x400F370")]
	[FieldOffset(Offset = "0xC0")]
	private Engine.Phase m_NextPhase;

	[Token(Token = "0x400F371")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_Pressing;

	[Token(Token = "0x400F372")]
	[FieldOffset(Offset = "0xC5")]
	private bool m_Entering;

	[Token(Token = "0x400F373")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<Engine.StepType, string> m_BStepTextDict;

	[Token(Token = "0x400F374")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<string, Color> m_StepColorDict;

	[Token(Token = "0x400F375")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<Engine.DmgStepType, string> m_DStepTextDict;

	[Token(Token = "0x400F376")]
	[FieldOffset(Offset = "0xE0")]
	private Dictionary<Engine.Phase, string> m_PhaseTimelineDict0;

	[Token(Token = "0x400F377")]
	[FieldOffset(Offset = "0xE8")]
	private Dictionary<Engine.Phase, string> m_PhaseTImelineDict1;

	[Token(Token = "0x400F378")]
	[FieldOffset(Offset = "0xF0")]
	private Dictionary<Engine.Phase, string> m_PhaseSoundDict0;

	[Token(Token = "0x400F379")]
	[FieldOffset(Offset = "0xF8")]
	private Dictionary<Engine.Phase, string> m_PhaseSoundDict1;

	[Token(Token = "0x400F37A")]
	[FieldOffset(Offset = "0x100")]
	private DuelClient m_Host;

	[Token(Token = "0x400F37B")]
	[FieldOffset(Offset = "0x108")]
	private Queue<UnityAction> m_TaskQueue;

	[Token(Token = "0x400F37C")]
	[FieldOffset(Offset = "0x110")]
	private TimelineObject m_CurrentTimeline;

	[Token(Token = "0x17001A7B")]
	private int m_TurnPlayer
	{
		[Token(Token = "0x600AB66")]
		[Address(RVA = "0x428B40", Offset = "0x427D40", VA = "0x180428B40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600AB65")]
	[Address(RVA = "0x425590", Offset = "0x424790", VA = "0x180425590")]
	public static void Create(DuelClient host, Transform parent, UnityAction<PhaseSelect3D> onFinish, bool isEsportsVer)
	{
	}

	[Token(Token = "0x600AB67")]
	[Address(RVA = "0x427C60", Offset = "0x426E60", VA = "0x180427C60")]
	public void PhaseChange(Engine.Phase nextphase)
	{
	}

	[Token(Token = "0x600AB68")]
	[Address(RVA = "0x427B90", Offset = "0x426D90", VA = "0x180427B90")]
	public void PhaseChangeSE()
	{
	}

	[Token(Token = "0x600AB69")]
	[Address(RVA = "0x427390", Offset = "0x426590", VA = "0x180427390")]
	public void OnDuelStart()
	{
	}

	[Token(Token = "0x600AB6A")]
	[Address(RVA = "0x427B60", Offset = "0x426D60", VA = "0x180427B60")]
	public void PhaseChangeProcess()
	{
	}

	[Token(Token = "0x600AB6B")]
	[Address(RVA = "0x4288F0", Offset = "0x427AF0", VA = "0x1804288F0")]
	public void UpdateTurnText()
	{
	}

	[Token(Token = "0x600AB6C")]
	[Address(RVA = "0x4283F0", Offset = "0x4275F0", VA = "0x1804283F0")]
	public void TurnChange(int team, Action onFinished)
	{
	}

	[Token(Token = "0x600AB6D")]
	[Address(RVA = "0x4285B0", Offset = "0x4277B0", VA = "0x1804285B0")]
	public void UpdateStatus(int turnplayer, Engine.Phase nextphase)
	{
	}

	[Token(Token = "0x600AB6E")]
	[Address(RVA = "0x4281B0", Offset = "0x4273B0", VA = "0x1804281B0")]
	public void SkipTimeline()
	{
	}

	[Token(Token = "0x600AB6F")]
	[Address(RVA = "0x4286D0", Offset = "0x4278D0", VA = "0x1804286D0")]
	public void UpdateStepIcon(Engine.StepType battlestep, Engine.DmgStepType damagestep)
	{
	}

	[Token(Token = "0x600AB70")]
	[Address(RVA = "0x426DD0", Offset = "0x425FD0", VA = "0x180426DD0")]
	public bool IsPhaseMovable(Engine.Phase phase)
	{
		return default(bool);
	}

	[Token(Token = "0x600AB71")]
	[Address(RVA = "0x426E30", Offset = "0x426030", VA = "0x180426E30")]
	public void OnClickButtonPhase()
	{
	}

	[Token(Token = "0x600AB72")]
	[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
	public SelectionButton GetButton()
	{
		return null;
	}

	[Token(Token = "0x600AB73")]
	[Address(RVA = "0x4256C0", Offset = "0x4248C0", VA = "0x1804256C0")]
	public Vector3 GetPadIconPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AB74")]
	[Address(RVA = "0x425790", Offset = "0x424990", VA = "0x180425790")]
	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AB75")]
	[Address(RVA = "0x427E30", Offset = "0x427030", VA = "0x180427E30")]
	public void SetHintEffectVisible(bool visible)
	{
	}

	[Token(Token = "0x600AB76")]
	[Address(RVA = "0x4289D0", Offset = "0x427BD0", VA = "0x1804289D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600AB77")]
	[Address(RVA = "0x425FD0", Offset = "0x4251D0", VA = "0x180425FD0")]
	private void InitTables()
	{
	}

	[Token(Token = "0x600AB78")]
	[Address(RVA = "0x4257D0", Offset = "0x4249D0", VA = "0x1804257D0")]
	private void InitComponent()
	{
	}

	[Token(Token = "0x600AB79")]
	[Address(RVA = "0x425D10", Offset = "0x424F10", VA = "0x180425D10")]
	private void InitSelectorBotton()
	{
	}

	[Token(Token = "0x600AB7A")]
	[Address(RVA = "0x4280E0", Offset = "0x4272E0", VA = "0x1804280E0")]
	private void SetupSelectorPriority()
	{
	}

	[Token(Token = "0x600AB7B")]
	[Address(RVA = "0x4276F0", Offset = "0x4268F0", VA = "0x1804276F0")]
	private void OnSelected()
	{
	}

	[Token(Token = "0x600AB7C")]
	[Address(RVA = "0x427000", Offset = "0x426200", VA = "0x180427000")]
	private void OnDeselect()
	{
	}

	[Token(Token = "0x600AB7D")]
	[Address(RVA = "0x4274B0", Offset = "0x4266B0", VA = "0x1804274B0")]
	private void OnPointerEnter()
	{
	}

	[Token(Token = "0x600AB7E")]
	[Address(RVA = "0x427590", Offset = "0x426790", VA = "0x180427590")]
	private void OnPointerExit()
	{
	}

	[Token(Token = "0x600AB7F")]
	[Address(RVA = "0x4273E0", Offset = "0x4265E0", VA = "0x1804273E0")]
	private void OnPointerDown()
	{
	}

	[Token(Token = "0x600AB80")]
	[Address(RVA = "0x427670", Offset = "0x426870", VA = "0x180427670")]
	private void OnPointerUp()
	{
	}

	[Token(Token = "0x600AB81")]
	[Address(RVA = "0x428010", Offset = "0x427210", VA = "0x180428010")]
	private void SetPhaseButton()
	{
	}

	[Token(Token = "0x600AB82")]
	[Address(RVA = "0x427D40", Offset = "0x426F40", VA = "0x180427D40")]
	private void SetActive(bool active)
	{
	}

	[Token(Token = "0x600AB83")]
	[Address(RVA = "0x427F30", Offset = "0x427130", VA = "0x180427F30")]
	private void SetMaterialParam(string paramname, float value)
	{
	}

	[Token(Token = "0x600AB84")]
	[Address(RVA = "0x4284F0", Offset = "0x4276F0", VA = "0x1804284F0")]
	private void UpdateMovablePhaseIcon()
	{
	}

	[Token(Token = "0x600AB85")]
	[Address(RVA = "0x4269B0", Offset = "0x425BB0", VA = "0x1804269B0")]
	private void Initialize(DuelClient host)
	{
	}

	[Token(Token = "0x600AB86")]
	[Address(RVA = "0x427370", Offset = "0x426570", VA = "0x180427370")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600AB87")]
	[Address(RVA = "0x427370", Offset = "0x426570", VA = "0x180427370")]
	private void Terminate()
	{
	}

	[Token(Token = "0x600AB88")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public PhaseSelect3D()
	{
	}
}
