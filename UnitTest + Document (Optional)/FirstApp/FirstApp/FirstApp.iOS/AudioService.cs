using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

using AVFoundation;
using FirstApp.iOS;
using System.IO;
//using MonoTouch.Foundation;
//using MonoTouch.UIKit;

[assembly: Dependency(typeof(AudioService))]

namespace FirstApp.iOS
{
    public class AudioService : IAudio 
    {
        public AudioService()
        {
        }

        public void PlayAudioFile(string fileName)
        {
            string sFilePath = NSBundle.MainBundle.PathForResource
            (Path.GetFileNameWithoutExtension(fileName), Path.GetExtension(fileName));
            var url = NSUrl.FromString(sFilePath);
            var _player = AVAudioPlayer.FromUrl(url);
            _player.FinishedPlaying += (object sender, AVStatusEventArgs e) => {
                _player = null;
            };
            _player.Play();
        }
    }
}