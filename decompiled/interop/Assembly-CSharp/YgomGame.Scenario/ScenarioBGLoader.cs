using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using YgomSystem.Effect;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A58")]
[DisallowMultipleComponent]
public class ScenarioBGLoader : MonoBehaviour
{
	[Token(Token = "0x2000A59")]
	private class RequestData
	{
		[Token(Token = "0x4009194")]
		[FieldOffset(Offset = "0x10")]
		public Action<BgGeneratedResource> callback;

		[Token(Token = "0x4009195")]
		[FieldOffset(Offset = "0x18")]
		public GameObject owner;

		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x8653D0", Offset = "0x8645D0", VA = "0x1808653D0")]
		public RequestData(GameObject owner, Action<BgGeneratedResource> callback)
		{
		}
	}

	[Token(Token = "0x2000A5A")]
	public class BgGeneratedResource
	{
		[Token(Token = "0x400919F")]
		[FieldOffset(Offset = "0x58")]
		private string m_ResourcePath;

		[Token(Token = "0x40091A4")]
		[FieldOffset(Offset = "0x80")]
		public bool fadeoutKeep;

		[Token(Token = "0x40091A9")]
		[FieldOffset(Offset = "0x98")]
		private List<string> m_TMSoundClips;

		[Token(Token = "0x17000870")]
		public ElementObjectManager eom
		{
			[Token(Token = "0x6003F9C")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F9D")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000871")]
		public int renderTextureId
		{
			[Token(Token = "0x6003F9E")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003F9F")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000872")]
		public Sprite createdSprite
		{
			[Token(Token = "0x6003FA0")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FA1")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000873")]
		public Texture renderTexture
		{
			[Token(Token = "0x6003FA2")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FA3")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000874")]
		public SpriteRenderer spriteRenderer
		{
			[Token(Token = "0x6003FA4")]
			[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FA5")]
			[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000875")]
		public SpriteScaler spriteScaler
		{
			[Token(Token = "0x6003FA6")]
			[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FA7")]
			[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000876")]
		public LabeledPlayableController labeledPlayableController
		{
			[Token(Token = "0x6003FA8")]
			[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FA9")]
			[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000877")]
		public ScenarioSoundTrackBinder soundTrackBinder
		{
			[Token(Token = "0x6003FAA")]
			[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FAB")]
			[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000878")]
		public GameObject gameObject
		{
			[Token(Token = "0x6003FAC")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FAD")]
			[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000879")]
		public Transform transform
		{
			[Token(Token = "0x6003FAE")]
			[Address(RVA = "0x865380", Offset = "0x864580", VA = "0x180865380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700087A")]
		public Transform rootTran
		{
			[Token(Token = "0x6003FAF")]
			[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FB0")]
			[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700087B")]
		public Transform scalerTran
		{
			[Token(Token = "0x6003FB1")]
			[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FB2")]
			[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700087C")]
		public Transform shakePosTran
		{
			[Token(Token = "0x6003FB3")]
			[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FB4")]
			[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700087D")]
		public Transform movePosTran
		{
			[Token(Token = "0x6003FB5")]
			[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003FB6")]
			[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700087E")]
		public int width
		{
			[Token(Token = "0x6003FB7")]
			[Address(RVA = "0x4497E0", Offset = "0x4489E0", VA = "0x1804497E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003FB8")]
			[Address(RVA = "0x449830", Offset = "0x448A30", VA = "0x180449830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700087F")]
		public int height
		{
			[Token(Token = "0x6003FB9")]
			[Address(RVA = "0x865350", Offset = "0x864550", VA = "0x180865350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003FBA")]
			[Address(RVA = "0x8653A0", Offset = "0x8645A0", VA = "0x1808653A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000880")]
		public float spriteScalerVirtualWidth
		{
			[Token(Token = "0x6003FBB")]
			[Address(RVA = "0x865370", Offset = "0x864570", VA = "0x180865370")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6003FBC")]
			[Address(RVA = "0x8653C0", Offset = "0x8645C0", VA = "0x1808653C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000881")]
		public float spriteScalerVirtualHeight
		{
			[Token(Token = "0x6003FBD")]
			[Address(RVA = "0x865360", Offset = "0x864560", VA = "0x180865360")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6003FBE")]
			[Address(RVA = "0x8653B0", Offset = "0x8645B0", VA = "0x1808653B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000882")]
		public List<string> tmSoundClips
		{
			[Token(Token = "0x6003FBF")]
			[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		public void SetSpriteScaler(SpriteScaler scaler)
		{
		}

		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x864610", Offset = "0x863810", VA = "0x180864610")]
		public static BgGeneratedResource Create(GameObject gameObject, string resourcePath)
		{
			return null;
		}

		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x864390", Offset = "0x863590", VA = "0x180864390")]
		public static BgGeneratedResource Create(Sprite sprite, string resourcePath)
		{
			return null;
		}

		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x864530", Offset = "0x863730", VA = "0x180864530")]
		public static BgGeneratedResource Create(Texture2D texture2D, string resourcePath)
		{
			return null;
		}

		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x864C90", Offset = "0x863E90", VA = "0x180864C90")]
		public BgGeneratedResource(GameObject originGob, string resourcePath)
		{
		}

		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x864680", Offset = "0x863880", VA = "0x180864680")]
		public void OnCreatedRenderTexture(int rtId, RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x6003FC6")]
		[Address(RVA = "0x864A40", Offset = "0x863C40", VA = "0x180864A40")]
		public void SetupTMTracks(PlayableDirector director)
		{
		}

		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x864760", Offset = "0x863960", VA = "0x180864760")]
		private void SetupTMTrack(PlayableDirector director, TrackAsset trackAsset)
		{
		}

		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x863D50", Offset = "0x862F50", VA = "0x180863D50")]
		private void BindScenarioSoundTrack(PlayableDirector director, ScenarioSoundTrack soundTrack)
		{
		}

		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x8640A0", Offset = "0x8632A0", VA = "0x1808640A0")]
		private void CollectSoundLabels(SoundTrack soundTrack)
		{
		}

		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0x8646A0", Offset = "0x8638A0", VA = "0x1808646A0")]
		public void Release()
		{
		}
	}

	[Token(Token = "0x400918F")]
	[FieldOffset(Offset = "0x20")]
	private ScenarioBGActor.Setting m_BGSetting;

	[Token(Token = "0x4009190")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, List<RequestData>> m_Requests;

	[Token(Token = "0x4009191")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, BgGeneratedResource> m_BgResourceMap;

	[Token(Token = "0x4009192")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, List<GameObject>> m_ReferencedOwnerMap;

	[Token(Token = "0x4009193")]
	[FieldOffset(Offset = "0x40")]
	private bool m_UseSubRTLayer;

	[Token(Token = "0x6003F91")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void Initialize(ScenarioBGActor.Setting bgSetting)
	{
	}

	[Token(Token = "0x6003F92")]
	[Address(RVA = "0x867F50", Offset = "0x867150", VA = "0x180867F50")]
	public void LoadBG(GameObject owner, string path, bool tryFullSize, Action<BgGeneratedResource> onFinish)
	{
	}

	[Token(Token = "0x6003F93")]
	[Address(RVA = "0x8693A0", Offset = "0x8685A0", VA = "0x1808693A0")]
	public Texture TryGetLoadedBgTexture(GameObject owner, string path)
	{
		return null;
	}

	[Token(Token = "0x6003F94")]
	[Address(RVA = "0x868B50", Offset = "0x867D50", VA = "0x180868B50")]
	private void OnLoadedBgAsset(GameObject owner, string loadedPath, bool tryFullSize)
	{
	}

	[Token(Token = "0x6003F95")]
	[Address(RVA = "0x867C70", Offset = "0x866E70", VA = "0x180867C70")]
	private void CreateBgRenderTexture(GameObject owner, string path, bool tryFullSize, BgGeneratedResource bgGeneratedResource)
	{
	}

	[Token(Token = "0x6003F96")]
	[Address(RVA = "0x8685F0", Offset = "0x8677F0", VA = "0x1808685F0")]
	private void OnCreatedRenderTexture(string path, BgGeneratedResource bgGeneratedResource, int rtId, RenderTexture renderTexture, Texture2D texture)
	{
	}

	[Token(Token = "0x6003F97")]
	[Address(RVA = "0x8683B0", Offset = "0x8675B0", VA = "0x1808683B0")]
	private void OnCompleteRequest(string path, BgGeneratedResource bgGeneratedResource)
	{
	}

	[Token(Token = "0x6003F98")]
	[Address(RVA = "0x868E00", Offset = "0x868000", VA = "0x180868E00")]
	public void ReleaseBg(GameObject owner, string path)
	{
	}

	[Token(Token = "0x6003F99")]
	[Address(RVA = "0x8689B0", Offset = "0x867BB0", VA = "0x1808689B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003F9A")]
	[Address(RVA = "0x869530", Offset = "0x868730", VA = "0x180869530")]
	public ScenarioBGLoader()
	{
	}
}
