using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using DavyKager;

namespace CrossSpeak;

internal class ScreenReaderWindows : IScreenReader
{
	private bool isLoaded;

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool SetDllDirectory(string lpPathName);

	public ScreenReaderWindows()
	{
		string text = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
		if (!(text == string.Empty))
		{
			SetDllDirectory(Path.Combine(text, "lib", "screen-reader-libs", "windows"));
		}
	}

	public bool Initialize()
	{
		if (isLoaded)
		{
			Close();
		}
		Tolk.Load();
		string text = Tolk.DetectScreenReader();
		isLoaded = text != null;
		return isLoaded;
	}

	public bool IsLoaded()
	{
		if (isLoaded)
		{
			return Tolk.IsLoaded();
		}
		return false;
	}

	public void TrySAPI(bool trySAPI)
	{
		Tolk.TrySAPI(trySAPI);
	}

	public void PreferSAPI(bool preferSAPI)
	{
		Tolk.PreferSAPI(preferSAPI);
	}

	public string DetectScreenReader()
	{
		if (!isLoaded)
		{
			return null;
		}
		return Tolk.DetectScreenReader();
	}

	public bool HasSpeech()
	{
		if (isLoaded)
		{
			return Tolk.HasSpeech();
		}
		return false;
	}

	public bool HasBraille()
	{
		if (isLoaded)
		{
			return Tolk.HasBraille();
		}
		return false;
	}

	public bool Speak(string text, bool interrupt = false)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return false;
		}
		if (!isLoaded)
		{
			return false;
		}
		return Tolk.Speak(text, interrupt);
	}

	public bool Braille(string text)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return false;
		}
		if (!isLoaded)
		{
			return false;
		}
		return Tolk.Braille(text);
	}

	public bool Output(string text, bool interrupt = false)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return false;
		}
		if (!isLoaded)
		{
			return false;
		}
		return Tolk.Output(text, interrupt);
	}

	public bool IsSpeaking()
	{
		if (isLoaded)
		{
			return Tolk.IsSpeaking();
		}
		return false;
	}

	public float GetVolume()
	{
		return 0f;
	}

	public void SetVolume(float volume)
	{
	}

	public float GetRate()
	{
		return 0f;
	}

	public void SetRate(float rate)
	{
	}

	public bool Silence()
	{
		if (isLoaded)
		{
			return Tolk.Silence();
		}
		return false;
	}

	public void Close()
	{
		if (isLoaded)
		{
			Tolk.Unload();
			isLoaded = false;
		}
	}
}
