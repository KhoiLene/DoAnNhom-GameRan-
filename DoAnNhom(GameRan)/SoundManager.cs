using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;

namespace DoAnNhom_GameRan_
{
    public static class SoundManager
    {
        private static WindowsMediaPlayer bgMusic = new WindowsMediaPlayer();
        private static WindowsMediaPlayer dieSound = new WindowsMediaPlayer();

        private static bool isPlaying = false;

        static SoundManager()
        {
            bgMusic.settings.setMode("loop", true);
            UpdateVolume();
        }

        // 🔊 cập nhật volume
        public static void UpdateVolume()
        {
            int vol = Properties.Settings.Default.SoundOn
                        ? Properties.Settings.Default.Volume
                        : 0;

            bgMusic.settings.volume = vol;
            dieSound.settings.volume = vol;
        }

        // 🎵 nhạc nền
        public static void PlayBackground()
        {
            if (!Properties.Settings.Default.SoundOn) return;
            if (isPlaying) return;

            bgMusic.URL = System.IO.Path.Combine(Application.StartupPath, "amthanhtrochoi.wav"); // 🔥 chuyển сюда
            bgMusic.controls.play();
            isPlaying = true;
        }

        public static void StopBackground()
        {
            bgMusic.controls.stop();
            isPlaying = false;
        }

        // 💀 âm thanh thua
        public static void PlayDie()
        {
            if(!Properties.Settings.Default.SoundOn) return;

            dieSound.URL = Application.StartupPath + "bin\\Debug\\amthanhthatbai.wav"; // 🔥 chuyển сюда
            dieSound.controls.stop();
            dieSound.controls.play();
        }
    }
}
