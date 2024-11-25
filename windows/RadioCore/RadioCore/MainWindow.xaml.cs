using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DiscordRPC;

namespace RadioCore
{
    public partial class MainWindow : Window
    {

        private DiscordRPC.DiscordRpcClient _discordRpcClient;

        private MediaPlayer _mediaPlayer;
        private bool _isPlaying = false;
        private readonly string _mp3Url = "https://psr.streamabc.net/regc-psrlive-mp3-192-4316100?sABC=6741r23r%230%2329nn526sprp3574oq1qps493qp185prs%23enqvbcynlre&aw_0_1st.playerid=radioplayer";

        public MainWindow()
        {
            InitializeComponent();

            // Initialize MediaPlayer
            _mediaPlayer = new MediaPlayer();
            _mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
            _mediaPlayer.MediaOpened += MediaPlayer_MediaOpened;

            // Set initial volume
            _mediaPlayer.Volume = 0.5; // Default volume (50%)
            VolumeSlider.Value = 50; // Set slider to match the initial volume

            _discordRpcClient = new DiscordRPC.DiscordRpcClient("APP_ID");  // Replace with your own Discord App ID
            _discordRpcClient.Initialize();

            // Set the initial Discord presence

            SetDiscordPresence("Playling RadioPSR", "Livestream");
        }

        // Play or Pause the stream
        private void PlayPauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (_isPlaying)
            {
                _mediaPlayer.Pause();
                PlayIcon.Visibility = Visibility.Visible;
                PauseIcon.Visibility = Visibility.Collapsed;
            }
            else
            {
                _mediaPlayer.Open(new Uri(_mp3Url));
                _mediaPlayer.Play();
                PlayIcon.Visibility = Visibility.Collapsed;
                PauseIcon.Visibility = Visibility.Visible;
            }
            _isPlaying = !_isPlaying;
        }

        // Media opened event
        private void MediaPlayer_MediaOpened(object sender, EventArgs e)
        {
            // Optional: Actions when the media is successfully opened
        }

        // Media ended event
        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            _isPlaying = false;
            PlayIcon.Visibility = Visibility.Visible;
            PauseIcon.Visibility = Visibility.Collapsed;
        }

        // Volume Slider Value Changed (Adjust volume based on slider value)
        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (_mediaPlayer != null)
            {
                _mediaPlayer.Volume = e.NewValue / 100.0; // Map slider value (0-100) to volume (0.0-1.0)
            }
        }
        private void SetDiscordPresence(string songTitle, string status)
        {
            if (_discordRpcClient == null) return; // Ensure the RPC client is initialized

            var presence = new RichPresence
            {
                Details = songTitle,  // Song or Stream Title
                State = status,       // Current status (e.g., "Playing" or "Paused")
                Assets = new Assets
                {
                    LargeImageKey = "image_key",   // Replace with the key for your image uploaded to Discord Developer Portal
                    LargeImageText = "Radio PSR", // Text displayed when hovering over the image
                }
            };

            _discordRpcClient.SetPresence(presence);
        }
    }
}