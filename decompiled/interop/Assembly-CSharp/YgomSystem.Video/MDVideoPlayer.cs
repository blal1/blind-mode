using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace YgomSystem.Video;

[Token(Token = "0x20001E4")]
public class MDVideoPlayer : MonoBehaviour
{
	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x28")]
	private MDVideoPlayerBase videoPlayerBase;

	[Token(Token = "0x17000135")]
	public bool hasBase
	{
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0xC0F710", Offset = "0xC0E910", VA = "0x180C0F710")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000136")]
	public VideoSource source
	{
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0xC0F7E0", Offset = "0xC0E9E0", VA = "0x180C0F7E0")]
		get
		{
			return default(VideoSource);
		}
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0xC0FB80", Offset = "0xC0ED80", VA = "0x180C0FB80")]
		set
		{
		}
	}

	[Token(Token = "0x17000137")]
	public long frame
	{
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0xC0F6E0", Offset = "0xC0E8E0", VA = "0x180C0F6E0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0xC0FB20", Offset = "0xC0ED20", VA = "0x180C0FB20")]
		set
		{
		}
	}

	[Token(Token = "0x17000138")]
	public ulong frameCount
	{
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0xC0F680", Offset = "0xC0E880", VA = "0x180C0F680")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17000139")]
	public bool isPaused
	{
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0xC0F750", Offset = "0xC0E950", VA = "0x180C0F750")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700013A")]
	public bool isLooping
	{
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0xC0F720", Offset = "0xC0E920", VA = "0x180C0F720")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0xC0FB50", Offset = "0xC0ED50", VA = "0x180C0FB50")]
		set
		{
		}
	}

	[Token(Token = "0x1700013B")]
	public string url
	{
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0xC0F840", Offset = "0xC0EA40", VA = "0x180C0F840")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0xC0FBE0", Offset = "0xC0EDE0", VA = "0x180C0FBE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700013C")]
	public RenderTexture targetTexture
	{
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0xC0F810", Offset = "0xC0EA10", VA = "0x180C0F810")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0xC0FBB0", Offset = "0xC0EDB0", VA = "0x180C0FBB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700013D")]
	public VideoClip clip
	{
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0xC0F620", Offset = "0xC0E820", VA = "0x180C0F620")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0xC0FAF0", Offset = "0xC0ECF0", VA = "0x180C0FAF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700013E")]
	public bool isPrepared
	{
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0xC0F780", Offset = "0xC0E980", VA = "0x180C0F780")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700013F")]
	public float frameRate
	{
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0xC0F6B0", Offset = "0xC0E8B0", VA = "0x180C0F6B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000140")]
	public double length
	{
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0xC0F7B0", Offset = "0xC0E9B0", VA = "0x180C0F7B0")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000141")]
	public double clockTime
	{
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0xC0F650", Offset = "0xC0E850", VA = "0x180C0F650")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x14000001")]
	public event VideoPlayer.EventHandler prepareCompleted
	{
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0xC0F4E0", Offset = "0xC0E6E0", VA = "0x180C0F4E0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0xC0F9B0", Offset = "0xC0EBB0", VA = "0x180C0F9B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event VideoPlayer.EventHandler loopPointReached
	{
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0xC0F440", Offset = "0xC0E640", VA = "0x180C0F440")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0xC0F910", Offset = "0xC0EB10", VA = "0x180C0F910")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event VideoPlayer.ErrorEventHandler errorReceived
	{
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0xC0F3A0", Offset = "0xC0E5A0", VA = "0x180C0F3A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0xC0F870", Offset = "0xC0EA70", VA = "0x180C0F870")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event VideoPlayer.EventHandler started
	{
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0xC0F580", Offset = "0xC0E780", VA = "0x180C0F580")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0xC0FA50", Offset = "0xC0EC50", VA = "0x180C0FA50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000B62")]
	[Address(RVA = "0xC0EE60", Offset = "0xC0E060", VA = "0x180C0EE60")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B63")]
	[Address(RVA = "0xC0F260", Offset = "0xC0E460", VA = "0x180C0F260")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000B64")]
	[Address(RVA = "0xC0F2C0", Offset = "0xC0E4C0", VA = "0x180C0F2C0")]
	private void OnPrepareCompleted(VideoPlayer source)
	{
	}

	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x406F30", Offset = "0x406130", VA = "0x180406F30")]
	private void OnLoopPointReached(VideoPlayer source)
	{
	}

	[Token(Token = "0x6000B66")]
	[Address(RVA = "0xC0F2A0", Offset = "0xC0E4A0", VA = "0x180C0F2A0")]
	private void OnErrorReceived(VideoPlayer source, string message)
	{
	}

	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x406ED0", Offset = "0x4060D0", VA = "0x180406ED0")]
	private void OnStarted(VideoPlayer source)
	{
	}

	[Token(Token = "0x6000B68")]
	[Address(RVA = "0xC0F310", Offset = "0xC0E510", VA = "0x180C0F310")]
	public void Play()
	{
	}

	[Token(Token = "0x6000B69")]
	[Address(RVA = "0xC0F340", Offset = "0xC0E540", VA = "0x180C0F340")]
	public void Prepare()
	{
	}

	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0xC0F370", Offset = "0xC0E570", VA = "0x180C0F370")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0xC0F2E0", Offset = "0xC0E4E0", VA = "0x180C0F2E0")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0xC0F220", Offset = "0xC0E420", VA = "0x180C0F220")]
	public void ClearBuffer(Color color)
	{
	}

	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public MDVideoPlayer()
	{
	}
}
